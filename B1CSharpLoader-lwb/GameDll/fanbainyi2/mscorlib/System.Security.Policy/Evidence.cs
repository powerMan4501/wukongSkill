using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Hosting;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Threading;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
public sealed class Evidence : ICollection, IEnumerable
{
	private enum DuplicateEvidenceAction
	{
		Throw,
		Merge,
		SelectNewObject
	}

	private class EvidenceLockHolder : IDisposable
	{
		public enum LockType
		{
			Reader,
			Writer
		}

		private Evidence m_target;

		private LockType m_lockType;

		public EvidenceLockHolder(Evidence target, LockType lockType)
		{
			m_target = target;
			m_lockType = lockType;
			if (m_lockType == LockType.Reader)
			{
				m_target.AcquireReaderLock();
			}
			else
			{
				m_target.AcquireWriterlock();
			}
		}

		public void Dispose()
		{
			if (m_lockType == LockType.Reader && m_target.IsReaderLockHeld)
			{
				m_target.ReleaseReaderLock();
			}
			else if (m_lockType == LockType.Writer && m_target.IsWriterLockHeld)
			{
				m_target.ReleaseWriterLock();
			}
		}
	}

	private class EvidenceUpgradeLockHolder : IDisposable
	{
		private Evidence m_target;

		private LockCookie m_cookie;

		public EvidenceUpgradeLockHolder(Evidence target)
		{
			m_target = target;
			m_cookie = m_target.UpgradeToWriterLock();
		}

		public void Dispose()
		{
			if (m_target.IsWriterLockHeld)
			{
				m_target.DowngradeFromWriterLock(ref m_cookie);
			}
		}
	}

	internal sealed class RawEvidenceEnumerator : IEnumerator<EvidenceBase>, IDisposable, IEnumerator
	{
		private Evidence m_evidence;

		private bool m_hostEnumerator;

		private uint m_evidenceVersion;

		private Type[] m_evidenceTypes;

		private int m_typeIndex;

		private EvidenceBase m_currentEvidence;

		private static volatile List<Type> s_expensiveEvidence;

		public EvidenceBase Current
		{
			get
			{
				if (m_evidence.m_version != m_evidenceVersion)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
				}
				return m_currentEvidence;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				if (m_evidence.m_version != m_evidenceVersion)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
				}
				return m_currentEvidence;
			}
		}

		private static List<Type> ExpensiveEvidence
		{
			get
			{
				if (s_expensiveEvidence == null)
				{
					List<Type> list = new List<Type>();
					list.Add(typeof(Hash));
					list.Add(typeof(Publisher));
					s_expensiveEvidence = list;
				}
				return s_expensiveEvidence;
			}
		}

		public RawEvidenceEnumerator(Evidence evidence, IEnumerable<Type> evidenceTypes, bool hostEnumerator)
		{
			m_evidence = evidence;
			m_hostEnumerator = hostEnumerator;
			m_evidenceTypes = GenerateEvidenceTypes(evidence, evidenceTypes, hostEnumerator);
			m_evidenceVersion = evidence.m_version;
			Reset();
		}

		public void Dispose()
		{
		}

		private static Type[] GenerateEvidenceTypes(Evidence evidence, IEnumerable<Type> evidenceTypes, bool hostEvidence)
		{
			List<Type> list = new List<Type>();
			List<Type> list2 = new List<Type>();
			List<Type> list3 = new List<Type>(ExpensiveEvidence.Count);
			foreach (Type evidenceType in evidenceTypes)
			{
				EvidenceTypeDescriptor evidenceTypeDescriptor = evidence.GetEvidenceTypeDescriptor(evidenceType);
				if ((hostEvidence && evidenceTypeDescriptor.HostEvidence != null) || (!hostEvidence && evidenceTypeDescriptor.AssemblyEvidence != null))
				{
					list.Add(evidenceType);
				}
				else if (ExpensiveEvidence.Contains(evidenceType))
				{
					list3.Add(evidenceType);
				}
				else
				{
					list2.Add(evidenceType);
				}
			}
			Type[] array = new Type[list.Count + list2.Count + list3.Count];
			list.CopyTo(array, 0);
			list2.CopyTo(array, list.Count);
			list3.CopyTo(array, list.Count + list2.Count);
			return array;
		}

		[SecuritySafeCritical]
		public bool MoveNext()
		{
			using (new EvidenceLockHolder(m_evidence, EvidenceLockHolder.LockType.Reader))
			{
				if (m_evidence.m_version != m_evidenceVersion)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
				}
				m_currentEvidence = null;
				do
				{
					m_typeIndex++;
					if (m_typeIndex < m_evidenceTypes.Length)
					{
						if (m_hostEnumerator)
						{
							m_currentEvidence = m_evidence.GetHostEvidenceNoLock(m_evidenceTypes[m_typeIndex]);
						}
						else
						{
							m_currentEvidence = m_evidence.GetAssemblyEvidenceNoLock(m_evidenceTypes[m_typeIndex]);
						}
					}
				}
				while (m_typeIndex < m_evidenceTypes.Length && m_currentEvidence == null);
			}
			return m_currentEvidence != null;
		}

		public void Reset()
		{
			if (m_evidence.m_version != m_evidenceVersion)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumFailedVersion"));
			}
			m_typeIndex = -1;
			m_currentEvidence = null;
		}
	}

	private sealed class EvidenceEnumerator : IEnumerator
	{
		[Flags]
		internal enum Category
		{
			Host = 1,
			Assembly = 2
		}

		private Evidence m_evidence;

		private Category m_category;

		private Stack m_enumerators;

		private object m_currentEvidence;

		public object Current => m_currentEvidence;

		private IEnumerator CurrentEnumerator
		{
			get
			{
				if (m_enumerators.Count <= 0)
				{
					return null;
				}
				return m_enumerators.Peek() as IEnumerator;
			}
		}

		internal EvidenceEnumerator(Evidence evidence, Category category)
		{
			m_evidence = evidence;
			m_category = category;
			ResetNoLock();
		}

		public bool MoveNext()
		{
			IEnumerator currentEnumerator = CurrentEnumerator;
			if (currentEnumerator == null)
			{
				m_currentEvidence = null;
				return false;
			}
			if (currentEnumerator.MoveNext())
			{
				LegacyEvidenceWrapper legacyEvidenceWrapper = currentEnumerator.Current as LegacyEvidenceWrapper;
				LegacyEvidenceList legacyEvidenceList = currentEnumerator.Current as LegacyEvidenceList;
				if (legacyEvidenceWrapper != null)
				{
					m_currentEvidence = legacyEvidenceWrapper.EvidenceObject;
				}
				else if (legacyEvidenceList != null)
				{
					IEnumerator enumerator = legacyEvidenceList.GetEnumerator();
					m_enumerators.Push(enumerator);
					MoveNext();
				}
				else
				{
					m_currentEvidence = currentEnumerator.Current;
				}
				return true;
			}
			m_enumerators.Pop();
			return MoveNext();
		}

		public void Reset()
		{
			using (new EvidenceLockHolder(m_evidence, EvidenceLockHolder.LockType.Reader))
			{
				ResetNoLock();
			}
		}

		private void ResetNoLock()
		{
			m_currentEvidence = null;
			m_enumerators = new Stack();
			if ((m_category & Category.Host) == Category.Host)
			{
				m_enumerators.Push(m_evidence.GetRawHostEvidenceEnumerator());
			}
			if ((m_category & Category.Assembly) == Category.Assembly)
			{
				m_enumerators.Push(m_evidence.GetRawAssemblyEvidenceEnumerator());
			}
		}
	}

	[OptionalField(VersionAdded = 4)]
	private Dictionary<Type, EvidenceTypeDescriptor> m_evidence;

	[OptionalField(VersionAdded = 4)]
	private bool m_deserializedTargetEvidence;

	private volatile ArrayList m_hostList;

	private volatile ArrayList m_assemblyList;

	[NonSerialized]
	private ReaderWriterLock m_evidenceLock;

	[NonSerialized]
	private uint m_version;

	[NonSerialized]
	private IRuntimeEvidenceFactory m_target;

	private bool m_locked;

	[NonSerialized]
	private WeakReference m_cloneOrigin;

	private static volatile Type[] s_runtimeEvidenceTypes;

	private const int LockTimeout = 5000;

	internal static Type[] RuntimeEvidenceTypes
	{
		get
		{
			if (s_runtimeEvidenceTypes == null)
			{
				Type[] array = new Type[10]
				{
					typeof(ActivationArguments),
					typeof(ApplicationDirectory),
					typeof(ApplicationTrust),
					typeof(GacInstalled),
					typeof(Hash),
					typeof(Publisher),
					typeof(Site),
					typeof(StrongName),
					typeof(Url),
					typeof(Zone)
				};
				if (AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
				{
					int num = array.Length;
					Array.Resize(ref array, num + 1);
					array[num] = typeof(PermissionRequestEvidence);
				}
				s_runtimeEvidenceTypes = array;
			}
			return s_runtimeEvidenceTypes;
		}
	}

	private bool IsReaderLockHeld
	{
		get
		{
			if (m_evidenceLock != null)
			{
				return m_evidenceLock.IsReaderLockHeld;
			}
			return true;
		}
	}

	private bool IsWriterLockHeld
	{
		get
		{
			if (m_evidenceLock != null)
			{
				return m_evidenceLock.IsWriterLockHeld;
			}
			return true;
		}
	}

	internal bool IsUnmodified => m_version == 0;

	public bool Locked
	{
		get
		{
			return m_locked;
		}
		[SecuritySafeCritical]
		set
		{
			if (!value)
			{
				new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
				m_locked = false;
			}
			else
			{
				m_locked = true;
			}
		}
	}

	internal IRuntimeEvidenceFactory Target
	{
		get
		{
			return m_target;
		}
		[SecurityCritical]
		set
		{
			using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Writer))
			{
				m_target = value;
				QueryHostForPossibleEvidenceTypes();
			}
		}
	}

	[Obsolete("Evidence should not be treated as an ICollection. Please use GetHostEnumerator and GetAssemblyEnumerator to iterate over the evidence to collect a count.")]
	public int Count
	{
		get
		{
			int num = 0;
			IEnumerator hostEnumerator = GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				num++;
			}
			IEnumerator assemblyEnumerator = GetAssemblyEnumerator();
			while (assemblyEnumerator.MoveNext())
			{
				num++;
			}
			return num;
		}
	}

	[ComVisible(false)]
	internal int RawCount
	{
		get
		{
			int num = 0;
			using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
			{
				foreach (Type item in new List<Type>(m_evidence.Keys))
				{
					EvidenceTypeDescriptor evidenceTypeDescriptor = GetEvidenceTypeDescriptor(item);
					if (evidenceTypeDescriptor != null)
					{
						if (evidenceTypeDescriptor.AssemblyEvidence != null)
						{
							num++;
						}
						if (evidenceTypeDescriptor.HostEvidence != null)
						{
							num++;
						}
					}
				}
				return num;
			}
		}
	}

	public object SyncRoot => this;

	public bool IsSynchronized => true;

	public bool IsReadOnly => false;

	public Evidence()
	{
		m_evidence = new Dictionary<Type, EvidenceTypeDescriptor>();
		m_evidenceLock = new ReaderWriterLock();
	}

	public Evidence(Evidence evidence)
	{
		m_evidence = new Dictionary<Type, EvidenceTypeDescriptor>();
		if (evidence != null)
		{
			using (new EvidenceLockHolder(evidence, EvidenceLockHolder.LockType.Reader))
			{
				foreach (KeyValuePair<Type, EvidenceTypeDescriptor> item in evidence.m_evidence)
				{
					EvidenceTypeDescriptor evidenceTypeDescriptor = item.Value;
					if (evidenceTypeDescriptor != null)
					{
						evidenceTypeDescriptor = evidenceTypeDescriptor.Clone();
					}
					m_evidence[item.Key] = evidenceTypeDescriptor;
				}
				m_target = evidence.m_target;
				m_locked = evidence.m_locked;
				m_deserializedTargetEvidence = evidence.m_deserializedTargetEvidence;
				if (evidence.Target != null)
				{
					m_cloneOrigin = new WeakReference(evidence);
				}
			}
		}
		m_evidenceLock = new ReaderWriterLock();
	}

	[Obsolete("This constructor is obsolete. Please use the constructor which takes arrays of EvidenceBase instead.")]
	public Evidence(object[] hostEvidence, object[] assemblyEvidence)
	{
		m_evidence = new Dictionary<Type, EvidenceTypeDescriptor>();
		if (hostEvidence != null)
		{
			foreach (object id in hostEvidence)
			{
				AddHost(id);
			}
		}
		if (assemblyEvidence != null)
		{
			foreach (object id2 in assemblyEvidence)
			{
				AddAssembly(id2);
			}
		}
		m_evidenceLock = new ReaderWriterLock();
	}

	public Evidence(EvidenceBase[] hostEvidence, EvidenceBase[] assemblyEvidence)
	{
		m_evidence = new Dictionary<Type, EvidenceTypeDescriptor>();
		if (hostEvidence != null)
		{
			foreach (EvidenceBase evidence in hostEvidence)
			{
				AddHostEvidence(evidence, GetEvidenceIndexType(evidence), DuplicateEvidenceAction.Throw);
			}
		}
		if (assemblyEvidence != null)
		{
			foreach (EvidenceBase evidence2 in assemblyEvidence)
			{
				AddAssemblyEvidence(evidence2, GetEvidenceIndexType(evidence2), DuplicateEvidenceAction.Throw);
			}
		}
		m_evidenceLock = new ReaderWriterLock();
	}

	[SecuritySafeCritical]
	internal Evidence(IRuntimeEvidenceFactory target)
	{
		m_evidence = new Dictionary<Type, EvidenceTypeDescriptor>();
		m_target = target;
		Type[] runtimeEvidenceTypes = RuntimeEvidenceTypes;
		foreach (Type key in runtimeEvidenceTypes)
		{
			m_evidence[key] = null;
		}
		QueryHostForPossibleEvidenceTypes();
		m_evidenceLock = new ReaderWriterLock();
	}

	private void AcquireReaderLock()
	{
		if (m_evidenceLock != null)
		{
			m_evidenceLock.AcquireReaderLock(5000);
		}
	}

	private void AcquireWriterlock()
	{
		if (m_evidenceLock != null)
		{
			m_evidenceLock.AcquireWriterLock(5000);
		}
	}

	private void DowngradeFromWriterLock(ref LockCookie lockCookie)
	{
		if (m_evidenceLock != null)
		{
			m_evidenceLock.DowngradeFromWriterLock(ref lockCookie);
		}
	}

	private LockCookie UpgradeToWriterLock()
	{
		if (m_evidenceLock == null)
		{
			return default(LockCookie);
		}
		return m_evidenceLock.UpgradeToWriterLock(5000);
	}

	private void ReleaseReaderLock()
	{
		if (m_evidenceLock != null)
		{
			m_evidenceLock.ReleaseReaderLock();
		}
	}

	private void ReleaseWriterLock()
	{
		if (m_evidenceLock != null)
		{
			m_evidenceLock.ReleaseWriterLock();
		}
	}

	[Obsolete("This method is obsolete. Please use AddHostEvidence instead.")]
	[SecuritySafeCritical]
	public void AddHost(object id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (!id.GetType().IsSerializable)
		{
			throw new ArgumentException(Environment.GetResourceString("Policy_EvidenceMustBeSerializable"), "id");
		}
		if (m_locked)
		{
			new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
		}
		EvidenceBase evidence = WrapLegacyEvidence(id);
		Type evidenceIndexType = GetEvidenceIndexType(evidence);
		AddHostEvidence(evidence, evidenceIndexType, DuplicateEvidenceAction.Merge);
	}

	[Obsolete("This method is obsolete. Please use AddAssemblyEvidence instead.")]
	public void AddAssembly(object id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (!id.GetType().IsSerializable)
		{
			throw new ArgumentException(Environment.GetResourceString("Policy_EvidenceMustBeSerializable"), "id");
		}
		EvidenceBase evidence = WrapLegacyEvidence(id);
		Type evidenceIndexType = GetEvidenceIndexType(evidence);
		AddAssemblyEvidence(evidence, evidenceIndexType, DuplicateEvidenceAction.Merge);
	}

	[ComVisible(false)]
	public void AddAssemblyEvidence<T>(T evidence) where T : EvidenceBase
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		Type evidenceType = typeof(T);
		if (typeof(T) == typeof(EvidenceBase) || evidence is ILegacyEvidenceAdapter)
		{
			evidenceType = GetEvidenceIndexType(evidence);
		}
		AddAssemblyEvidence(evidence, evidenceType, DuplicateEvidenceAction.Throw);
	}

	private void AddAssemblyEvidence(EvidenceBase evidence, Type evidenceType, DuplicateEvidenceAction duplicateAction)
	{
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Writer))
		{
			AddAssemblyEvidenceNoLock(evidence, evidenceType, duplicateAction);
		}
	}

	private void AddAssemblyEvidenceNoLock(EvidenceBase evidence, Type evidenceType, DuplicateEvidenceAction duplicateAction)
	{
		DeserializeTargetEvidence();
		EvidenceTypeDescriptor evidenceTypeDescriptor = GetEvidenceTypeDescriptor(evidenceType, addIfNotExist: true);
		m_version++;
		if (evidenceTypeDescriptor.AssemblyEvidence == null)
		{
			evidenceTypeDescriptor.AssemblyEvidence = evidence;
		}
		else
		{
			evidenceTypeDescriptor.AssemblyEvidence = HandleDuplicateEvidence(evidenceTypeDescriptor.AssemblyEvidence, evidence, duplicateAction);
		}
	}

	[ComVisible(false)]
	public void AddHostEvidence<T>(T evidence) where T : EvidenceBase
	{
		if (evidence == null)
		{
			throw new ArgumentNullException("evidence");
		}
		Type evidenceType = typeof(T);
		if (typeof(T) == typeof(EvidenceBase) || evidence is ILegacyEvidenceAdapter)
		{
			evidenceType = GetEvidenceIndexType(evidence);
		}
		AddHostEvidence(evidence, evidenceType, DuplicateEvidenceAction.Throw);
	}

	[SecuritySafeCritical]
	private void AddHostEvidence(EvidenceBase evidence, Type evidenceType, DuplicateEvidenceAction duplicateAction)
	{
		if (Locked)
		{
			new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
		}
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Writer))
		{
			AddHostEvidenceNoLock(evidence, evidenceType, duplicateAction);
		}
	}

	private void AddHostEvidenceNoLock(EvidenceBase evidence, Type evidenceType, DuplicateEvidenceAction duplicateAction)
	{
		EvidenceTypeDescriptor evidenceTypeDescriptor = GetEvidenceTypeDescriptor(evidenceType, addIfNotExist: true);
		m_version++;
		if (evidenceTypeDescriptor.HostEvidence == null)
		{
			evidenceTypeDescriptor.HostEvidence = evidence;
		}
		else
		{
			evidenceTypeDescriptor.HostEvidence = HandleDuplicateEvidence(evidenceTypeDescriptor.HostEvidence, evidence, duplicateAction);
		}
	}

	[SecurityCritical]
	private void QueryHostForPossibleEvidenceTypes()
	{
		if (AppDomain.CurrentDomain.DomainManager == null)
		{
			return;
		}
		HostSecurityManager hostSecurityManager = AppDomain.CurrentDomain.DomainManager.HostSecurityManager;
		if (hostSecurityManager == null)
		{
			return;
		}
		Type[] array = null;
		AppDomain appDomain = m_target.Target as AppDomain;
		Assembly assembly = m_target.Target as Assembly;
		if (assembly != null && (hostSecurityManager.Flags & HostSecurityManagerOptions.HostAssemblyEvidence) == HostSecurityManagerOptions.HostAssemblyEvidence)
		{
			array = hostSecurityManager.GetHostSuppliedAssemblyEvidenceTypes(assembly);
		}
		else if (appDomain != null && (hostSecurityManager.Flags & HostSecurityManagerOptions.HostAppDomainEvidence) == HostSecurityManagerOptions.HostAppDomainEvidence)
		{
			array = hostSecurityManager.GetHostSuppliedAppDomainEvidenceTypes();
		}
		if (array != null)
		{
			Type[] array2 = array;
			foreach (Type evidenceType in array2)
			{
				EvidenceTypeDescriptor evidenceTypeDescriptor = GetEvidenceTypeDescriptor(evidenceType, addIfNotExist: true);
				evidenceTypeDescriptor.HostCanGenerate = true;
			}
		}
	}

	private static Type GetEvidenceIndexType(EvidenceBase evidence)
	{
		if (evidence is ILegacyEvidenceAdapter legacyEvidenceAdapter)
		{
			return legacyEvidenceAdapter.EvidenceType;
		}
		return evidence.GetType();
	}

	internal EvidenceTypeDescriptor GetEvidenceTypeDescriptor(Type evidenceType)
	{
		return GetEvidenceTypeDescriptor(evidenceType, addIfNotExist: false);
	}

	private EvidenceTypeDescriptor GetEvidenceTypeDescriptor(Type evidenceType, bool addIfNotExist)
	{
		EvidenceTypeDescriptor value = null;
		if (!m_evidence.TryGetValue(evidenceType, out value) && !addIfNotExist)
		{
			return null;
		}
		if (value == null)
		{
			value = new EvidenceTypeDescriptor();
			bool flag = false;
			LockCookie lockCookie = default(LockCookie);
			try
			{
				if (!IsWriterLockHeld)
				{
					lockCookie = UpgradeToWriterLock();
					flag = true;
				}
				m_evidence[evidenceType] = value;
			}
			finally
			{
				if (flag)
				{
					DowngradeFromWriterLock(ref lockCookie);
				}
			}
		}
		return value;
	}

	private static EvidenceBase HandleDuplicateEvidence(EvidenceBase original, EvidenceBase duplicate, DuplicateEvidenceAction action)
	{
		switch (action)
		{
		case DuplicateEvidenceAction.Throw:
			throw new InvalidOperationException(Environment.GetResourceString("Policy_DuplicateEvidence", duplicate.GetType().FullName));
		case DuplicateEvidenceAction.SelectNewObject:
			return duplicate;
		case DuplicateEvidenceAction.Merge:
		{
			LegacyEvidenceList legacyEvidenceList = original as LegacyEvidenceList;
			if (legacyEvidenceList == null)
			{
				legacyEvidenceList = new LegacyEvidenceList();
				legacyEvidenceList.Add(original);
			}
			legacyEvidenceList.Add(duplicate);
			return legacyEvidenceList;
		}
		default:
			return null;
		}
	}

	private static EvidenceBase WrapLegacyEvidence(object evidence)
	{
		EvidenceBase evidenceBase = evidence as EvidenceBase;
		if (evidenceBase == null)
		{
			evidenceBase = new LegacyEvidenceWrapper(evidence);
		}
		return evidenceBase;
	}

	private static object UnwrapEvidence(EvidenceBase evidence)
	{
		if (evidence is ILegacyEvidenceAdapter legacyEvidenceAdapter)
		{
			return legacyEvidenceAdapter.EvidenceObject;
		}
		return evidence;
	}

	[SecuritySafeCritical]
	public void Merge(Evidence evidence)
	{
		if (evidence == null)
		{
			return;
		}
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Writer))
		{
			bool flag = false;
			IEnumerator hostEnumerator = evidence.GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				if (Locked && !flag)
				{
					new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
					flag = true;
				}
				Type type = hostEnumerator.Current.GetType();
				if (m_evidence.ContainsKey(type))
				{
					GetHostEvidenceNoLock(type);
				}
				EvidenceBase evidence2 = WrapLegacyEvidence(hostEnumerator.Current);
				AddHostEvidenceNoLock(evidence2, GetEvidenceIndexType(evidence2), DuplicateEvidenceAction.Merge);
			}
			IEnumerator assemblyEnumerator = evidence.GetAssemblyEnumerator();
			while (assemblyEnumerator.MoveNext())
			{
				EvidenceBase evidence3 = WrapLegacyEvidence(assemblyEnumerator.Current);
				AddAssemblyEvidenceNoLock(evidence3, GetEvidenceIndexType(evidence3), DuplicateEvidenceAction.Merge);
			}
		}
	}

	internal void MergeWithNoDuplicates(Evidence evidence)
	{
		if (evidence == null)
		{
			return;
		}
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Writer))
		{
			IEnumerator hostEnumerator = evidence.GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				EvidenceBase evidence2 = WrapLegacyEvidence(hostEnumerator.Current);
				AddHostEvidenceNoLock(evidence2, GetEvidenceIndexType(evidence2), DuplicateEvidenceAction.SelectNewObject);
			}
			IEnumerator assemblyEnumerator = evidence.GetAssemblyEnumerator();
			while (assemblyEnumerator.MoveNext())
			{
				EvidenceBase evidence3 = WrapLegacyEvidence(assemblyEnumerator.Current);
				AddAssemblyEvidenceNoLock(evidence3, GetEvidenceIndexType(evidence3), DuplicateEvidenceAction.SelectNewObject);
			}
		}
	}

	[ComVisible(false)]
	[OnSerializing]
	[SecurityCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	private void OnSerializing(StreamingContext context)
	{
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
		{
			foreach (Type item in new List<Type>(m_evidence.Keys))
			{
				GetHostEvidenceNoLock(item);
			}
			DeserializeTargetEvidence();
		}
		ArrayList arrayList = new ArrayList();
		IEnumerator hostEnumerator = GetHostEnumerator();
		while (hostEnumerator.MoveNext())
		{
			arrayList.Add(hostEnumerator.Current);
		}
		m_hostList = arrayList;
		ArrayList arrayList2 = new ArrayList();
		IEnumerator assemblyEnumerator = GetAssemblyEnumerator();
		while (assemblyEnumerator.MoveNext())
		{
			arrayList2.Add(assemblyEnumerator.Current);
		}
		m_assemblyList = arrayList2;
	}

	[ComVisible(false)]
	[OnDeserialized]
	[SecurityCritical]
	private void OnDeserialized(StreamingContext context)
	{
		if (m_evidence == null)
		{
			m_evidence = new Dictionary<Type, EvidenceTypeDescriptor>();
			if (m_hostList != null)
			{
				foreach (object host in m_hostList)
				{
					if (host != null)
					{
						AddHost(host);
					}
				}
				m_hostList = null;
			}
			if (m_assemblyList != null)
			{
				foreach (object assembly in m_assemblyList)
				{
					if (assembly != null)
					{
						AddAssembly(assembly);
					}
				}
				m_assemblyList = null;
			}
		}
		m_evidenceLock = new ReaderWriterLock();
	}

	private void DeserializeTargetEvidence()
	{
		if (m_target == null || m_deserializedTargetEvidence)
		{
			return;
		}
		bool flag = false;
		LockCookie lockCookie = default(LockCookie);
		try
		{
			if (!IsWriterLockHeld)
			{
				lockCookie = UpgradeToWriterLock();
				flag = true;
			}
			m_deserializedTargetEvidence = true;
			foreach (EvidenceBase item in m_target.GetFactorySuppliedEvidence())
			{
				AddAssemblyEvidenceNoLock(item, GetEvidenceIndexType(item), DuplicateEvidenceAction.Throw);
			}
		}
		finally
		{
			if (flag)
			{
				DowngradeFromWriterLock(ref lockCookie);
			}
		}
	}

	[SecurityCritical]
	internal byte[] RawSerialize()
	{
		try
		{
			using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
			{
				Dictionary<Type, EvidenceBase> dictionary = new Dictionary<Type, EvidenceBase>();
				foreach (KeyValuePair<Type, EvidenceTypeDescriptor> item in m_evidence)
				{
					if (item.Value != null && item.Value.HostEvidence != null)
					{
						dictionary[item.Key] = item.Value.HostEvidence;
					}
				}
				using MemoryStream memoryStream = new MemoryStream();
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(memoryStream, dictionary);
				return memoryStream.ToArray();
			}
		}
		catch (SecurityException)
		{
			return null;
		}
	}

	[Obsolete("Evidence should not be treated as an ICollection. Please use the GetHostEnumerator and GetAssemblyEnumerator methods rather than using CopyTo.")]
	public void CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (index < 0 || index > array.Length - Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		int num = index;
		IEnumerator hostEnumerator = GetHostEnumerator();
		while (hostEnumerator.MoveNext())
		{
			array.SetValue(hostEnumerator.Current, num);
			num++;
		}
		IEnumerator assemblyEnumerator = GetAssemblyEnumerator();
		while (assemblyEnumerator.MoveNext())
		{
			array.SetValue(assemblyEnumerator.Current, num);
			num++;
		}
	}

	public IEnumerator GetHostEnumerator()
	{
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
		{
			return new EvidenceEnumerator(this, EvidenceEnumerator.Category.Host);
		}
	}

	public IEnumerator GetAssemblyEnumerator()
	{
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
		{
			DeserializeTargetEvidence();
			return new EvidenceEnumerator(this, EvidenceEnumerator.Category.Assembly);
		}
	}

	internal RawEvidenceEnumerator GetRawAssemblyEvidenceEnumerator()
	{
		DeserializeTargetEvidence();
		return new RawEvidenceEnumerator(this, new List<Type>(m_evidence.Keys), hostEnumerator: false);
	}

	internal RawEvidenceEnumerator GetRawHostEvidenceEnumerator()
	{
		return new RawEvidenceEnumerator(this, new List<Type>(m_evidence.Keys), hostEnumerator: true);
	}

	[Obsolete("GetEnumerator is obsolete. Please use GetAssemblyEnumerator and GetHostEnumerator instead.")]
	public IEnumerator GetEnumerator()
	{
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
		{
			return new EvidenceEnumerator(this, EvidenceEnumerator.Category.Host | EvidenceEnumerator.Category.Assembly);
		}
	}

	[ComVisible(false)]
	public T GetAssemblyEvidence<T>() where T : EvidenceBase
	{
		return UnwrapEvidence(GetAssemblyEvidence(typeof(T))) as T;
	}

	internal EvidenceBase GetAssemblyEvidence(Type type)
	{
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
		{
			return GetAssemblyEvidenceNoLock(type);
		}
	}

	private EvidenceBase GetAssemblyEvidenceNoLock(Type type)
	{
		DeserializeTargetEvidence();
		return GetEvidenceTypeDescriptor(type)?.AssemblyEvidence;
	}

	[ComVisible(false)]
	public T GetHostEvidence<T>() where T : EvidenceBase
	{
		return UnwrapEvidence(GetHostEvidence(typeof(T))) as T;
	}

	internal T GetDelayEvaluatedHostEvidence<T>() where T : EvidenceBase, IDelayEvaluatedEvidence
	{
		return UnwrapEvidence(GetHostEvidence(typeof(T), markDelayEvaluatedEvidenceUsed: false)) as T;
	}

	internal EvidenceBase GetHostEvidence(Type type)
	{
		return GetHostEvidence(type, markDelayEvaluatedEvidenceUsed: true);
	}

	[SecuritySafeCritical]
	private EvidenceBase GetHostEvidence(Type type, bool markDelayEvaluatedEvidenceUsed)
	{
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
		{
			EvidenceBase hostEvidenceNoLock = GetHostEvidenceNoLock(type);
			if (markDelayEvaluatedEvidenceUsed && hostEvidenceNoLock is IDelayEvaluatedEvidence delayEvaluatedEvidence)
			{
				delayEvaluatedEvidence.MarkUsed();
			}
			return hostEvidenceNoLock;
		}
	}

	[SecurityCritical]
	private EvidenceBase GetHostEvidenceNoLock(Type type)
	{
		EvidenceTypeDescriptor evidenceTypeDescriptor = GetEvidenceTypeDescriptor(type);
		if (evidenceTypeDescriptor == null)
		{
			return null;
		}
		if (evidenceTypeDescriptor.HostEvidence != null)
		{
			return evidenceTypeDescriptor.HostEvidence;
		}
		if (m_target != null && !evidenceTypeDescriptor.Generated)
		{
			using (new EvidenceUpgradeLockHolder(this))
			{
				evidenceTypeDescriptor.Generated = true;
				EvidenceBase evidenceBase = GenerateHostEvidence(type, evidenceTypeDescriptor.HostCanGenerate);
				if (evidenceBase != null)
				{
					evidenceTypeDescriptor.HostEvidence = evidenceBase;
					Evidence evidence = ((m_cloneOrigin != null) ? (m_cloneOrigin.Target as Evidence) : null);
					if (evidence != null)
					{
						using (new EvidenceLockHolder(evidence, EvidenceLockHolder.LockType.Writer))
						{
							EvidenceTypeDescriptor evidenceTypeDescriptor2 = evidence.GetEvidenceTypeDescriptor(type);
							if (evidenceTypeDescriptor2 != null && evidenceTypeDescriptor2.HostEvidence == null)
							{
								evidenceTypeDescriptor2.HostEvidence = evidenceBase.Clone();
							}
						}
					}
				}
				return evidenceBase;
			}
		}
		return null;
	}

	[SecurityCritical]
	private EvidenceBase GenerateHostEvidence(Type type, bool hostCanGenerate)
	{
		if (hostCanGenerate)
		{
			AppDomain appDomain = m_target.Target as AppDomain;
			Assembly assembly = m_target.Target as Assembly;
			EvidenceBase evidenceBase = null;
			if (appDomain != null)
			{
				evidenceBase = AppDomain.CurrentDomain.HostSecurityManager.GenerateAppDomainEvidence(type);
			}
			else if (assembly != null)
			{
				evidenceBase = AppDomain.CurrentDomain.HostSecurityManager.GenerateAssemblyEvidence(type, assembly);
			}
			if (evidenceBase != null)
			{
				if (!type.IsAssignableFrom(evidenceBase.GetType()))
				{
					string fullName = AppDomain.CurrentDomain.HostSecurityManager.GetType().FullName;
					string fullName2 = evidenceBase.GetType().FullName;
					string fullName3 = type.FullName;
					throw new InvalidOperationException(Environment.GetResourceString("Policy_IncorrectHostEvidence", fullName, fullName2, fullName3));
				}
				return evidenceBase;
			}
		}
		return m_target.GenerateEvidence(type);
	}

	[ComVisible(false)]
	public Evidence Clone()
	{
		return new Evidence(this);
	}

	[ComVisible(false)]
	[SecuritySafeCritical]
	public void Clear()
	{
		if (Locked)
		{
			new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
		}
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Writer))
		{
			m_version++;
			m_evidence.Clear();
		}
	}

	[ComVisible(false)]
	[SecuritySafeCritical]
	public void RemoveType(Type t)
	{
		if (t == null)
		{
			throw new ArgumentNullException("t");
		}
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Writer))
		{
			EvidenceTypeDescriptor evidenceTypeDescriptor = GetEvidenceTypeDescriptor(t);
			if (evidenceTypeDescriptor != null)
			{
				m_version++;
				if (Locked && (evidenceTypeDescriptor.HostEvidence != null || evidenceTypeDescriptor.HostCanGenerate))
				{
					new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
				}
				m_evidence.Remove(t);
			}
		}
	}

	internal void MarkAllEvidenceAsUsed()
	{
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
		{
			foreach (KeyValuePair<Type, EvidenceTypeDescriptor> item in m_evidence)
			{
				if (item.Value != null)
				{
					if (item.Value.HostEvidence is IDelayEvaluatedEvidence delayEvaluatedEvidence)
					{
						delayEvaluatedEvidence.MarkUsed();
					}
					if (item.Value.AssemblyEvidence is IDelayEvaluatedEvidence delayEvaluatedEvidence2)
					{
						delayEvaluatedEvidence2.MarkUsed();
					}
				}
			}
		}
	}

	private bool WasStrongNameEvidenceUsed()
	{
		using (new EvidenceLockHolder(this, EvidenceLockHolder.LockType.Reader))
		{
			EvidenceTypeDescriptor evidenceTypeDescriptor = GetEvidenceTypeDescriptor(typeof(StrongName));
			if (evidenceTypeDescriptor != null)
			{
				return evidenceTypeDescriptor.HostEvidence is IDelayEvaluatedEvidence delayEvaluatedEvidence && delayEvaluatedEvidence.WasUsed;
			}
			return false;
		}
	}
}
