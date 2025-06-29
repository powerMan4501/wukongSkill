using System.Collections;
using System.Deployment.Internal.Isolation;
using System.Deployment.Internal.Isolation.Manifest;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Security.Policy;

[SecurityCritical]
[ComVisible(true)]
public sealed class ApplicationTrustCollection : ICollection, IEnumerable
{
	private const string ApplicationTrustProperty = "ApplicationTrust";

	private const string InstallerIdentifier = "{60051b8f-4f12-400a-8e50-dd05ebd438d1}";

	private static Guid ClrPropertySet = new Guid("c989bb7a-8385-4715-98cf-a741a8edb823");

	private static object s_installReference = null;

	private object m_appTrusts;

	private bool m_storeBounded;

	private Store m_pStore;

	private static StoreApplicationReference InstallReference
	{
		get
		{
			if (s_installReference == null)
			{
				Interlocked.CompareExchange(ref s_installReference, new StoreApplicationReference(IsolationInterop.GUID_SXS_INSTALL_REFERENCE_SCHEME_OPAQUESTRING, "{60051b8f-4f12-400a-8e50-dd05ebd438d1}", null), null);
			}
			return (StoreApplicationReference)s_installReference;
		}
	}

	private ArrayList AppTrusts
	{
		[SecurityCritical]
		get
		{
			if (m_appTrusts == null)
			{
				ArrayList arrayList = new ArrayList();
				if (m_storeBounded)
				{
					RefreshStorePointer();
					StoreDeploymentMetadataEnumeration storeDeploymentMetadataEnumeration = m_pStore.EnumInstallerDeployments(IsolationInterop.GUID_SXS_INSTALL_REFERENCE_SCHEME_OPAQUESTRING, "{60051b8f-4f12-400a-8e50-dd05ebd438d1}", "ApplicationTrust", null);
					foreach (IDefinitionAppId item in storeDeploymentMetadataEnumeration)
					{
						StoreDeploymentMetadataPropertyEnumeration storeDeploymentMetadataPropertyEnumeration = m_pStore.EnumInstallerDeploymentProperties(IsolationInterop.GUID_SXS_INSTALL_REFERENCE_SCHEME_OPAQUESTRING, "{60051b8f-4f12-400a-8e50-dd05ebd438d1}", "ApplicationTrust", item);
						foreach (StoreOperationMetadataProperty item2 in storeDeploymentMetadataPropertyEnumeration)
						{
							string value = item2.Value;
							if (value != null && value.Length > 0)
							{
								SecurityElement element = SecurityElement.FromString(value);
								ApplicationTrust applicationTrust = new ApplicationTrust();
								applicationTrust.FromXml(element);
								arrayList.Add(applicationTrust);
							}
						}
					}
				}
				Interlocked.CompareExchange(ref m_appTrusts, arrayList, null);
			}
			return m_appTrusts as ArrayList;
		}
	}

	public int Count
	{
		[SecuritySafeCritical]
		get
		{
			return AppTrusts.Count;
		}
	}

	public ApplicationTrust this[int index]
	{
		[SecurityCritical]
		get
		{
			return AppTrusts[index] as ApplicationTrust;
		}
	}

	public ApplicationTrust this[string appFullName]
	{
		[SecurityCritical]
		get
		{
			ApplicationIdentity applicationIdentity = new ApplicationIdentity(appFullName);
			ApplicationTrustCollection applicationTrustCollection = Find(applicationIdentity, ApplicationVersionMatch.MatchExactVersion);
			if (applicationTrustCollection.Count > 0)
			{
				return applicationTrustCollection[0];
			}
			return null;
		}
	}

	public bool IsSynchronized
	{
		[SecuritySafeCritical]
		get
		{
			return false;
		}
	}

	public object SyncRoot
	{
		[SecuritySafeCritical]
		get
		{
			return this;
		}
	}

	[SecurityCritical]
	internal ApplicationTrustCollection()
		: this(storeBounded: false)
	{
	}

	internal ApplicationTrustCollection(bool storeBounded)
	{
		m_storeBounded = storeBounded;
	}

	[SecurityCritical]
	private void RefreshStorePointer()
	{
		if (m_pStore != null)
		{
			Marshal.ReleaseComObject(m_pStore.InternalStore);
		}
		m_pStore = IsolationInterop.GetUserStore();
	}

	[SecurityCritical]
	private void CommitApplicationTrust(ApplicationIdentity applicationIdentity, string trustXml)
	{
		StoreOperationMetadataProperty[] setProperties = new StoreOperationMetadataProperty[1]
		{
			new StoreOperationMetadataProperty(ClrPropertySet, "ApplicationTrust", trustXml)
		};
		IEnumDefinitionIdentity enumDefinitionIdentity = applicationIdentity.Identity.EnumAppPath();
		IDefinitionIdentity[] array = new IDefinitionIdentity[1];
		IDefinitionIdentity definitionIdentity = null;
		if (enumDefinitionIdentity.Next(1u, array) == 1)
		{
			definitionIdentity = array[0];
		}
		IDefinitionAppId definitionAppId = IsolationInterop.AppIdAuthority.CreateDefinition();
		definitionAppId.SetAppPath(1u, new IDefinitionIdentity[1] { definitionIdentity });
		definitionAppId.put_Codebase(applicationIdentity.CodeBase);
		using (StoreTransaction storeTransaction = new StoreTransaction())
		{
			storeTransaction.Add(new StoreOperationSetDeploymentMetadata(definitionAppId, InstallReference, setProperties));
			RefreshStorePointer();
			m_pStore.Transact(storeTransaction.Operations);
		}
		m_appTrusts = null;
	}

	[SecurityCritical]
	public int Add(ApplicationTrust trust)
	{
		if (trust == null)
		{
			throw new ArgumentNullException("trust");
		}
		if (trust.ApplicationIdentity == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ApplicationTrustShouldHaveIdentity"));
		}
		if (m_storeBounded)
		{
			CommitApplicationTrust(trust.ApplicationIdentity, trust.ToXml().ToString());
			return -1;
		}
		return AppTrusts.Add(trust);
	}

	[SecurityCritical]
	public void AddRange(ApplicationTrust[] trusts)
	{
		if (trusts == null)
		{
			throw new ArgumentNullException("trusts");
		}
		int i = 0;
		try
		{
			for (; i < trusts.Length; i++)
			{
				Add(trusts[i]);
			}
		}
		catch
		{
			for (int j = 0; j < i; j++)
			{
				Remove(trusts[j]);
			}
			throw;
		}
	}

	[SecurityCritical]
	public void AddRange(ApplicationTrustCollection trusts)
	{
		if (trusts == null)
		{
			throw new ArgumentNullException("trusts");
		}
		int num = 0;
		try
		{
			ApplicationTrustEnumerator enumerator = trusts.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ApplicationTrust current = enumerator.Current;
				Add(current);
				num++;
			}
		}
		catch
		{
			for (int i = 0; i < num; i++)
			{
				Remove(trusts[i]);
			}
			throw;
		}
	}

	[SecurityCritical]
	public ApplicationTrustCollection Find(ApplicationIdentity applicationIdentity, ApplicationVersionMatch versionMatch)
	{
		ApplicationTrustCollection applicationTrustCollection = new ApplicationTrustCollection(storeBounded: false);
		ApplicationTrustEnumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			ApplicationTrust current = enumerator.Current;
			if (CmsUtils.CompareIdentities(current.ApplicationIdentity, applicationIdentity, versionMatch))
			{
				applicationTrustCollection.Add(current);
			}
		}
		return applicationTrustCollection;
	}

	[SecurityCritical]
	public void Remove(ApplicationIdentity applicationIdentity, ApplicationVersionMatch versionMatch)
	{
		ApplicationTrustCollection trusts = Find(applicationIdentity, versionMatch);
		RemoveRange(trusts);
	}

	[SecurityCritical]
	public void Remove(ApplicationTrust trust)
	{
		if (trust == null)
		{
			throw new ArgumentNullException("trust");
		}
		if (trust.ApplicationIdentity == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ApplicationTrustShouldHaveIdentity"));
		}
		if (m_storeBounded)
		{
			CommitApplicationTrust(trust.ApplicationIdentity, null);
		}
		else
		{
			AppTrusts.Remove(trust);
		}
	}

	[SecurityCritical]
	public void RemoveRange(ApplicationTrust[] trusts)
	{
		if (trusts == null)
		{
			throw new ArgumentNullException("trusts");
		}
		int i = 0;
		try
		{
			for (; i < trusts.Length; i++)
			{
				Remove(trusts[i]);
			}
		}
		catch
		{
			for (int j = 0; j < i; j++)
			{
				Add(trusts[j]);
			}
			throw;
		}
	}

	[SecurityCritical]
	public void RemoveRange(ApplicationTrustCollection trusts)
	{
		if (trusts == null)
		{
			throw new ArgumentNullException("trusts");
		}
		int num = 0;
		try
		{
			ApplicationTrustEnumerator enumerator = trusts.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ApplicationTrust current = enumerator.Current;
				Remove(current);
				num++;
			}
		}
		catch
		{
			for (int i = 0; i < num; i++)
			{
				Add(trusts[i]);
			}
			throw;
		}
	}

	[SecurityCritical]
	public void Clear()
	{
		ArrayList appTrusts = AppTrusts;
		if (m_storeBounded)
		{
			foreach (ApplicationTrust item in appTrusts)
			{
				if (item.ApplicationIdentity == null)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_ApplicationTrustShouldHaveIdentity"));
				}
				CommitApplicationTrust(item.ApplicationIdentity, null);
			}
		}
		appTrusts.Clear();
	}

	public ApplicationTrustEnumerator GetEnumerator()
	{
		return new ApplicationTrustEnumerator(this);
	}

	[SecuritySafeCritical]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new ApplicationTrustEnumerator(this);
	}

	[SecuritySafeCritical]
	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RankMultiDimNotSupported"));
		}
		if (index < 0 || index >= array.Length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (array.Length - index < Count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		for (int i = 0; i < Count; i++)
		{
			array.SetValue(this[i], index++);
		}
	}

	public void CopyTo(ApplicationTrust[] array, int index)
	{
		((ICollection)this).CopyTo((Array)array, index);
	}
}
