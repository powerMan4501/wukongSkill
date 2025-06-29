using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;

namespace System.IO.IsolatedStorage;

[ComVisible(true)]
public abstract class IsolatedStorage : MarshalByRefObject
{
	internal const IsolatedStorageScope c_Assembly = IsolatedStorageScope.User | IsolatedStorageScope.Assembly;

	internal const IsolatedStorageScope c_Domain = IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly;

	internal const IsolatedStorageScope c_AssemblyRoaming = IsolatedStorageScope.User | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming;

	internal const IsolatedStorageScope c_DomainRoaming = IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming;

	internal const IsolatedStorageScope c_MachineAssembly = IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine;

	internal const IsolatedStorageScope c_MachineDomain = IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine;

	internal const IsolatedStorageScope c_AppUser = IsolatedStorageScope.User | IsolatedStorageScope.Application;

	internal const IsolatedStorageScope c_AppMachine = IsolatedStorageScope.Machine | IsolatedStorageScope.Application;

	internal const IsolatedStorageScope c_AppUserRoaming = IsolatedStorageScope.User | IsolatedStorageScope.Roaming | IsolatedStorageScope.Application;

	private const string s_Publisher = "Publisher";

	private const string s_StrongName = "StrongName";

	private const string s_Site = "Site";

	private const string s_Url = "Url";

	private const string s_Zone = "Zone";

	private ulong m_Quota;

	private bool m_ValidQuota;

	private object m_DomainIdentity;

	private object m_AssemIdentity;

	private object m_AppIdentity;

	private string m_DomainName;

	private string m_AssemName;

	private string m_AppName;

	private IsolatedStorageScope m_Scope;

	private static volatile IsolatedStorageFilePermission s_PermDomain;

	private static volatile IsolatedStorageFilePermission s_PermMachineDomain;

	private static volatile IsolatedStorageFilePermission s_PermDomainRoaming;

	private static volatile IsolatedStorageFilePermission s_PermAssem;

	private static volatile IsolatedStorageFilePermission s_PermMachineAssem;

	private static volatile IsolatedStorageFilePermission s_PermAssemRoaming;

	private static volatile IsolatedStorageFilePermission s_PermAppUser;

	private static volatile IsolatedStorageFilePermission s_PermAppMachine;

	private static volatile IsolatedStorageFilePermission s_PermAppUserRoaming;

	private static volatile SecurityPermission s_PermControlEvidence;

	private static volatile PermissionSet s_PermUnrestricted;

	protected virtual char SeparatorExternal => '\\';

	protected virtual char SeparatorInternal => '.';

	[CLSCompliant(false)]
	[Obsolete("IsolatedStorage.MaximumSize has been deprecated because it is not CLS Compliant.  To get the maximum size use IsolatedStorage.Quota")]
	public virtual ulong MaximumSize
	{
		get
		{
			if (m_ValidQuota)
			{
				return m_Quota;
			}
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_QuotaIsUndefined", "MaximumSize"));
		}
	}

	[CLSCompliant(false)]
	[Obsolete("IsolatedStorage.CurrentSize has been deprecated because it is not CLS Compliant.  To get the current size use IsolatedStorage.UsedSize")]
	public virtual ulong CurrentSize
	{
		get
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_CurrentSizeUndefined", "CurrentSize"));
		}
	}

	[ComVisible(false)]
	public virtual long UsedSize
	{
		get
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_CurrentSizeUndefined", "UsedSize"));
		}
	}

	[ComVisible(false)]
	public virtual long Quota
	{
		get
		{
			if (m_ValidQuota)
			{
				return (long)m_Quota;
			}
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_QuotaIsUndefined", "Quota"));
		}
		internal set
		{
			m_Quota = (ulong)value;
			m_ValidQuota = true;
		}
	}

	[ComVisible(false)]
	public virtual long AvailableFreeSpace
	{
		get
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_QuotaIsUndefined", "AvailableFreeSpace"));
		}
	}

	public object DomainIdentity
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
		get
		{
			if (IsDomain())
			{
				return m_DomainIdentity;
			}
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_DomainUndefined"));
		}
	}

	[ComVisible(false)]
	public object ApplicationIdentity
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
		get
		{
			if (IsApp())
			{
				return m_AppIdentity;
			}
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_ApplicationUndefined"));
		}
	}

	public object AssemblyIdentity
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPolicy)]
		get
		{
			if (IsAssembly())
			{
				return m_AssemIdentity;
			}
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_AssemblyUndefined"));
		}
	}

	public IsolatedStorageScope Scope => m_Scope;

	internal string DomainName
	{
		get
		{
			if (IsDomain())
			{
				return m_DomainName;
			}
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_DomainUndefined"));
		}
	}

	internal string AssemName
	{
		get
		{
			if (IsAssembly())
			{
				return m_AssemName;
			}
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_AssemblyUndefined"));
		}
	}

	internal string AppName
	{
		get
		{
			if (IsApp())
			{
				return m_AppName;
			}
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_ApplicationUndefined"));
		}
	}

	internal static bool IsRoaming(IsolatedStorageScope scope)
	{
		return (scope & IsolatedStorageScope.Roaming) != 0;
	}

	internal bool IsRoaming()
	{
		return (m_Scope & IsolatedStorageScope.Roaming) != 0;
	}

	internal static bool IsDomain(IsolatedStorageScope scope)
	{
		return (scope & IsolatedStorageScope.Domain) != 0;
	}

	internal bool IsDomain()
	{
		return (m_Scope & IsolatedStorageScope.Domain) != 0;
	}

	internal static bool IsMachine(IsolatedStorageScope scope)
	{
		return (scope & IsolatedStorageScope.Machine) != 0;
	}

	internal bool IsAssembly()
	{
		return (m_Scope & IsolatedStorageScope.Assembly) != 0;
	}

	internal static bool IsApp(IsolatedStorageScope scope)
	{
		return (scope & IsolatedStorageScope.Application) != 0;
	}

	internal bool IsApp()
	{
		return (m_Scope & IsolatedStorageScope.Application) != 0;
	}

	private string GetNameFromID(string typeID, string instanceID)
	{
		return typeID + SeparatorInternal + instanceID;
	}

	private static string GetPredefinedTypeName(object o)
	{
		if (o is Publisher)
		{
			return "Publisher";
		}
		if (o is StrongName)
		{
			return "StrongName";
		}
		if (o is Url)
		{
			return "Url";
		}
		if (o is Site)
		{
			return "Site";
		}
		if (o is Zone)
		{
			return "Zone";
		}
		return null;
	}

	internal static string GetHash(Stream s)
	{
		using SHA1 sHA = new SHA1CryptoServiceProvider();
		byte[] buff = sHA.ComputeHash(s);
		return Path.ToBase32StringSuitableForDirName(buff);
	}

	private static bool IsValidName(string s)
	{
		for (int i = 0; i < s.Length; i++)
		{
			if (!char.IsLetter(s[i]) && !char.IsDigit(s[i]))
			{
				return false;
			}
		}
		return true;
	}

	private static SecurityPermission GetControlEvidencePermission()
	{
		if (s_PermControlEvidence == null)
		{
			s_PermControlEvidence = new SecurityPermission(SecurityPermissionFlag.ControlEvidence);
		}
		return s_PermControlEvidence;
	}

	private static PermissionSet GetUnrestricted()
	{
		if (s_PermUnrestricted == null)
		{
			s_PermUnrestricted = new PermissionSet(PermissionState.Unrestricted);
		}
		return s_PermUnrestricted;
	}

	[ComVisible(false)]
	public virtual bool IncreaseQuotaTo(long newQuotaSize)
	{
		return false;
	}

	[SecurityCritical]
	internal MemoryStream GetIdentityStream(IsolatedStorageScope scope)
	{
		GetUnrestricted().Assert();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		MemoryStream memoryStream = new MemoryStream();
		object obj = (IsApp(scope) ? m_AppIdentity : ((!IsDomain(scope)) ? m_AssemIdentity : m_DomainIdentity));
		if (obj != null)
		{
			binaryFormatter.Serialize(memoryStream, obj);
		}
		memoryStream.Position = 0L;
		return memoryStream;
	}

	[SecuritySafeCritical]
	protected void InitStore(IsolatedStorageScope scope, Type domainEvidenceType, Type assemblyEvidenceType)
	{
		PermissionSet newGrant = null;
		PermissionSet newDenied = null;
		RuntimeAssembly caller = GetCaller();
		GetControlEvidencePermission().Assert();
		if (IsDomain(scope))
		{
			AppDomain domain = Thread.GetDomain();
			if (!IsRoaming(scope))
			{
				newGrant = domain.PermissionSet;
				if (newGrant == null)
				{
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DomainGrantSet"));
				}
			}
			_InitStore(scope, domain.Evidence, domainEvidenceType, caller.Evidence, assemblyEvidenceType, null, null);
		}
		else
		{
			if (!IsRoaming(scope))
			{
				caller.GetGrantSet(out newGrant, out newDenied);
				if (newGrant == null)
				{
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_AssemblyGrantSet"));
				}
			}
			_InitStore(scope, null, null, caller.Evidence, assemblyEvidenceType, null, null);
		}
		SetQuota(newGrant, newDenied);
	}

	[SecuritySafeCritical]
	protected void InitStore(IsolatedStorageScope scope, Type appEvidenceType)
	{
		PermissionSet permissionSet = null;
		PermissionSet psDenied = null;
		Assembly caller = GetCaller();
		GetControlEvidencePermission().Assert();
		if (IsApp(scope))
		{
			AppDomain domain = Thread.GetDomain();
			if (!IsRoaming(scope))
			{
				permissionSet = domain.PermissionSet;
				if (permissionSet == null)
				{
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DomainGrantSet"));
				}
			}
			ActivationContext activationContext = AppDomain.CurrentDomain.ActivationContext;
			if (activationContext == null)
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_ApplicationMissingIdentity"));
			}
			ApplicationSecurityInfo applicationSecurityInfo = new ApplicationSecurityInfo(activationContext);
			_InitStore(scope, null, null, null, null, applicationSecurityInfo.ApplicationEvidence, appEvidenceType);
		}
		SetQuota(permissionSet, psDenied);
	}

	[SecuritySafeCritical]
	internal void InitStore(IsolatedStorageScope scope, object domain, object assem, object app)
	{
		PermissionSet newGrant = null;
		PermissionSet newDenied = null;
		Evidence evidence = null;
		Evidence evidence2 = null;
		Evidence evidence3 = null;
		if (IsApp(scope))
		{
			EvidenceBase evidenceBase = app as EvidenceBase;
			if (evidenceBase == null)
			{
				evidenceBase = new LegacyEvidenceWrapper(app);
			}
			evidence3 = new Evidence();
			evidence3.AddHostEvidence(evidenceBase);
		}
		else
		{
			EvidenceBase evidenceBase2 = assem as EvidenceBase;
			if (evidenceBase2 == null)
			{
				evidenceBase2 = new LegacyEvidenceWrapper(assem);
			}
			evidence2 = new Evidence();
			evidence2.AddHostEvidence(evidenceBase2);
			if (IsDomain(scope))
			{
				EvidenceBase evidenceBase3 = domain as EvidenceBase;
				if (evidenceBase3 == null)
				{
					evidenceBase3 = new LegacyEvidenceWrapper(domain);
				}
				evidence = new Evidence();
				evidence.AddHostEvidence(evidenceBase3);
			}
		}
		_InitStore(scope, evidence, null, evidence2, null, evidence3, null);
		if (!IsRoaming(scope))
		{
			RuntimeAssembly caller = GetCaller();
			GetControlEvidencePermission().Assert();
			caller.GetGrantSet(out newGrant, out newDenied);
			if (newGrant == null)
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_AssemblyGrantSet"));
			}
		}
		SetQuota(newGrant, newDenied);
	}

	[SecurityCritical]
	internal void InitStore(IsolatedStorageScope scope, Evidence domainEv, Type domainEvidenceType, Evidence assemEv, Type assemEvidenceType, Evidence appEv, Type appEvidenceType)
	{
		PermissionSet psAllowed = null;
		if (!IsRoaming(scope))
		{
			psAllowed = (IsApp(scope) ? SecurityManager.GetStandardSandbox(appEv) : ((!IsDomain(scope)) ? SecurityManager.GetStandardSandbox(assemEv) : SecurityManager.GetStandardSandbox(domainEv)));
		}
		_InitStore(scope, domainEv, domainEvidenceType, assemEv, assemEvidenceType, appEv, appEvidenceType);
		SetQuota(psAllowed, null);
	}

	[SecuritySafeCritical]
	internal bool InitStore(IsolatedStorageScope scope, Stream domain, Stream assem, Stream app, string domainName, string assemName, string appName)
	{
		try
		{
			GetUnrestricted().Assert();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			if (IsApp(scope))
			{
				m_AppIdentity = binaryFormatter.Deserialize(app);
				m_AppName = appName;
			}
			else
			{
				m_AssemIdentity = binaryFormatter.Deserialize(assem);
				m_AssemName = assemName;
				if (IsDomain(scope))
				{
					m_DomainIdentity = binaryFormatter.Deserialize(domain);
					m_DomainName = domainName;
				}
			}
		}
		catch
		{
			return false;
		}
		m_Scope = scope;
		return true;
	}

	[SecurityCritical]
	private void _InitStore(IsolatedStorageScope scope, Evidence domainEv, Type domainEvidenceType, Evidence assemEv, Type assemblyEvidenceType, Evidence appEv, Type appEvidenceType)
	{
		VerifyScope(scope);
		if (IsApp(scope))
		{
			if (appEv == null)
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_ApplicationMissingIdentity"));
			}
		}
		else
		{
			if (assemEv == null)
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_AssemblyMissingIdentity"));
			}
			if (IsDomain(scope) && domainEv == null)
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DomainMissingIdentity"));
			}
		}
		DemandPermission(scope);
		string typeName = null;
		string instanceName = null;
		if (IsApp(scope))
		{
			m_AppIdentity = GetAccountingInfo(appEv, appEvidenceType, IsolatedStorageScope.Application, out typeName, out instanceName);
			m_AppName = GetNameFromID(typeName, instanceName);
		}
		else
		{
			m_AssemIdentity = GetAccountingInfo(assemEv, assemblyEvidenceType, IsolatedStorageScope.Assembly, out typeName, out instanceName);
			m_AssemName = GetNameFromID(typeName, instanceName);
			if (IsDomain(scope))
			{
				m_DomainIdentity = GetAccountingInfo(domainEv, domainEvidenceType, IsolatedStorageScope.Domain, out typeName, out instanceName);
				m_DomainName = GetNameFromID(typeName, instanceName);
			}
		}
		m_Scope = scope;
	}

	[SecurityCritical]
	private static object GetAccountingInfo(Evidence evidence, Type evidenceType, IsolatedStorageScope fAssmDomApp, out string typeName, out string instanceName)
	{
		object oNormalized = null;
		object obj = _GetAccountingInfo(evidence, evidenceType, fAssmDomApp, out oNormalized);
		typeName = GetPredefinedTypeName(obj);
		if (typeName == null)
		{
			GetUnrestricted().Assert();
			MemoryStream memoryStream = new MemoryStream();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, obj.GetType());
			memoryStream.Position = 0L;
			typeName = GetHash(memoryStream);
			CodeAccessPermission.RevertAssert();
		}
		instanceName = null;
		if (oNormalized != null)
		{
			if (oNormalized is Stream)
			{
				instanceName = GetHash((Stream)oNormalized);
			}
			else if (oNormalized is string)
			{
				if (IsValidName((string)oNormalized))
				{
					instanceName = (string)oNormalized;
				}
				else
				{
					MemoryStream memoryStream = new MemoryStream();
					BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
					binaryWriter.Write((string)oNormalized);
					memoryStream.Position = 0L;
					instanceName = GetHash(memoryStream);
				}
			}
		}
		else
		{
			oNormalized = obj;
		}
		if (instanceName == null)
		{
			GetUnrestricted().Assert();
			MemoryStream memoryStream = new MemoryStream();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, oNormalized);
			memoryStream.Position = 0L;
			instanceName = GetHash(memoryStream);
			CodeAccessPermission.RevertAssert();
		}
		return obj;
	}

	private static object _GetAccountingInfo(Evidence evidence, Type evidenceType, IsolatedStorageScope fAssmDomApp, out object oNormalized)
	{
		object obj = null;
		if (evidenceType == null)
		{
			obj = evidence.GetHostEvidence<Publisher>();
			if (obj == null)
			{
				obj = evidence.GetHostEvidence<StrongName>();
			}
			if (obj == null)
			{
				obj = evidence.GetHostEvidence<Url>();
			}
			if (obj == null)
			{
				obj = evidence.GetHostEvidence<Site>();
			}
			if (obj == null)
			{
				obj = evidence.GetHostEvidence<Zone>();
			}
			if (obj == null)
			{
				switch (fAssmDomApp)
				{
				case IsolatedStorageScope.Domain:
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DomainNoEvidence"));
				case IsolatedStorageScope.Application:
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_ApplicationNoEvidence"));
				default:
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_AssemblyNoEvidence"));
				}
			}
		}
		else
		{
			obj = evidence.GetHostEvidence(evidenceType);
			if (obj == null)
			{
				switch (fAssmDomApp)
				{
				case IsolatedStorageScope.Domain:
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DomainNoEvidence"));
				case IsolatedStorageScope.Application:
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_ApplicationNoEvidence"));
				default:
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_AssemblyNoEvidence"));
				}
			}
		}
		if (obj is INormalizeForIsolatedStorage)
		{
			oNormalized = ((INormalizeForIsolatedStorage)obj).Normalize();
		}
		else if (obj is Publisher)
		{
			oNormalized = ((Publisher)obj).Normalize();
		}
		else if (obj is StrongName)
		{
			oNormalized = ((StrongName)obj).Normalize();
		}
		else if (obj is Url)
		{
			oNormalized = ((Url)obj).Normalize();
		}
		else if (obj is Site)
		{
			oNormalized = ((Site)obj).Normalize();
		}
		else if (obj is Zone)
		{
			oNormalized = ((Zone)obj).Normalize();
		}
		else
		{
			oNormalized = null;
		}
		return obj;
	}

	[SecurityCritical]
	private static void DemandPermission(IsolatedStorageScope scope)
	{
		IsolatedStorageFilePermission isolatedStorageFilePermission = null;
		switch (scope)
		{
		case IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly:
			if (s_PermDomain == null)
			{
				s_PermDomain = new IsolatedStorageFilePermission(IsolatedStorageContainment.DomainIsolationByUser, 0L, PermanentData: false);
			}
			isolatedStorageFilePermission = s_PermDomain;
			break;
		case IsolatedStorageScope.User | IsolatedStorageScope.Assembly:
			if (s_PermAssem == null)
			{
				s_PermAssem = new IsolatedStorageFilePermission(IsolatedStorageContainment.AssemblyIsolationByUser, 0L, PermanentData: false);
			}
			isolatedStorageFilePermission = s_PermAssem;
			break;
		case IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming:
			if (s_PermDomainRoaming == null)
			{
				s_PermDomainRoaming = new IsolatedStorageFilePermission(IsolatedStorageContainment.DomainIsolationByRoamingUser, 0L, PermanentData: false);
			}
			isolatedStorageFilePermission = s_PermDomainRoaming;
			break;
		case IsolatedStorageScope.User | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming:
			if (s_PermAssemRoaming == null)
			{
				s_PermAssemRoaming = new IsolatedStorageFilePermission(IsolatedStorageContainment.AssemblyIsolationByRoamingUser, 0L, PermanentData: false);
			}
			isolatedStorageFilePermission = s_PermAssemRoaming;
			break;
		case IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine:
			if (s_PermMachineDomain == null)
			{
				s_PermMachineDomain = new IsolatedStorageFilePermission(IsolatedStorageContainment.DomainIsolationByMachine, 0L, PermanentData: false);
			}
			isolatedStorageFilePermission = s_PermMachineDomain;
			break;
		case IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine:
			if (s_PermMachineAssem == null)
			{
				s_PermMachineAssem = new IsolatedStorageFilePermission(IsolatedStorageContainment.AssemblyIsolationByMachine, 0L, PermanentData: false);
			}
			isolatedStorageFilePermission = s_PermMachineAssem;
			break;
		case IsolatedStorageScope.User | IsolatedStorageScope.Application:
			if (s_PermAppUser == null)
			{
				s_PermAppUser = new IsolatedStorageFilePermission(IsolatedStorageContainment.ApplicationIsolationByUser, 0L, PermanentData: false);
			}
			isolatedStorageFilePermission = s_PermAppUser;
			break;
		case IsolatedStorageScope.Machine | IsolatedStorageScope.Application:
			if (s_PermAppMachine == null)
			{
				s_PermAppMachine = new IsolatedStorageFilePermission(IsolatedStorageContainment.ApplicationIsolationByMachine, 0L, PermanentData: false);
			}
			isolatedStorageFilePermission = s_PermAppMachine;
			break;
		case IsolatedStorageScope.User | IsolatedStorageScope.Roaming | IsolatedStorageScope.Application:
			if (s_PermAppUserRoaming == null)
			{
				s_PermAppUserRoaming = new IsolatedStorageFilePermission(IsolatedStorageContainment.ApplicationIsolationByRoamingUser, 0L, PermanentData: false);
			}
			isolatedStorageFilePermission = s_PermAppUserRoaming;
			break;
		}
		isolatedStorageFilePermission.Demand();
	}

	internal static void VerifyScope(IsolatedStorageScope scope)
	{
		if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly) || scope == (IsolatedStorageScope.User | IsolatedStorageScope.Assembly) || scope == (IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming) || scope == (IsolatedStorageScope.User | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming) || scope == (IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine) || scope == (IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine) || scope == (IsolatedStorageScope.User | IsolatedStorageScope.Application) || scope == (IsolatedStorageScope.Machine | IsolatedStorageScope.Application) || scope == (IsolatedStorageScope.User | IsolatedStorageScope.Roaming | IsolatedStorageScope.Application))
		{
			return;
		}
		throw new ArgumentException(Environment.GetResourceString("IsolatedStorage_Scope_Invalid"));
	}

	[SecurityCritical]
	internal virtual void SetQuota(PermissionSet psAllowed, PermissionSet psDenied)
	{
		IsolatedStoragePermission permission = GetPermission(psAllowed);
		m_Quota = 0uL;
		if (permission != null)
		{
			if (permission.IsUnrestricted())
			{
				m_Quota = 9223372036854775807uL;
			}
			else
			{
				m_Quota = (ulong)permission.UserQuota;
			}
		}
		if (psDenied != null)
		{
			IsolatedStoragePermission permission2 = GetPermission(psDenied);
			if (permission2 != null)
			{
				if (permission2.IsUnrestricted())
				{
					m_Quota = 0uL;
				}
				else
				{
					ulong userQuota = (ulong)permission2.UserQuota;
					if (userQuota > m_Quota)
					{
						m_Quota = 0uL;
					}
					else
					{
						m_Quota -= userQuota;
					}
				}
			}
		}
		m_ValidQuota = true;
	}

	public abstract void Remove();

	protected abstract IsolatedStoragePermission GetPermission(PermissionSet ps);

	[SecuritySafeCritical]
	internal static RuntimeAssembly GetCaller()
	{
		RuntimeAssembly o = null;
		GetCaller(JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetCaller(ObjectHandleOnStack retAssembly);
}
