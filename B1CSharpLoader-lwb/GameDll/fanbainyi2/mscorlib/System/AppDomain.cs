using System.Collections;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Deployment.Internal.Isolation.Manifest;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.Hosting;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Security.Util;
using System.Text;
using System.Threading;

namespace System;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_AppDomain))]
[ComVisible(true)]
public sealed class AppDomain : MarshalByRefObject, _AppDomain, IEvidenceFactory
{
	[Flags]
	private enum APPX_FLAGS
	{
		APPX_FLAGS_INITIALIZED = 1,
		APPX_FLAGS_APPX_MODEL = 2,
		APPX_FLAGS_APPX_DESIGN_MODE = 4,
		APPX_FLAGS_APPX_NGEN = 8,
		APPX_FLAGS_APPX_MASK = 0xE,
		APPX_FLAGS_API_CHECK = 0x10
	}

	private class NamespaceResolverForIntrospection
	{
		private IEnumerable<string> _packageGraphFilePaths;

		public NamespaceResolverForIntrospection(IEnumerable<string> packageGraphFilePaths)
		{
			_packageGraphFilePaths = packageGraphFilePaths;
		}

		[SecurityCritical]
		public void ResolveNamespace(object sender, NamespaceResolveEventArgs args)
		{
			IEnumerable<string> enumerable = WindowsRuntimeMetadata.ResolveNamespace(args.NamespaceName, null, _packageGraphFilePaths);
			foreach (string item in enumerable)
			{
				args.ResolvedAssemblies.Add(Assembly.ReflectionOnlyLoadFrom(item));
			}
		}
	}

	[Serializable]
	private class EvidenceCollection
	{
		public Evidence ProvidedSecurityInfo;

		public Evidence CreatorsSecurityInfo;
	}

	private class CAPTCASearcher : IComparer
	{
		int IComparer.Compare(object lhs, object rhs)
		{
			AssemblyName assemblyName = new AssemblyName((string)lhs);
			AssemblyName assemblyName2 = (AssemblyName)rhs;
			int num = string.Compare(assemblyName.Name, assemblyName2.Name, StringComparison.OrdinalIgnoreCase);
			if (num != 0)
			{
				return num;
			}
			byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
			byte[] publicKeyToken2 = assemblyName2.GetPublicKeyToken();
			if (publicKeyToken == null)
			{
				return -1;
			}
			if (publicKeyToken2 == null)
			{
				return 1;
			}
			if (publicKeyToken.Length < publicKeyToken2.Length)
			{
				return -1;
			}
			if (publicKeyToken.Length > publicKeyToken2.Length)
			{
				return 1;
			}
			for (int i = 0; i < publicKeyToken.Length; i++)
			{
				byte b = publicKeyToken[i];
				byte b2 = publicKeyToken2[i];
				if (b < b2)
				{
					return -1;
				}
				if (b > b2)
				{
					return 1;
				}
			}
			return 0;
		}
	}

	private static class InitState
	{
		private static bool s_EarlyInitIsComplete;

		internal static bool EarlyInitIsComplete()
		{
			return s_EarlyInitIsComplete;
		}

		internal static void RecordEndOfEarlyAppDomainInit()
		{
			s_EarlyInitIsComplete = true;
		}
	}

	[SecurityCritical]
	private AppDomainManager _domainManager;

	private Dictionary<string, object[]> _LocalStore;

	private AppDomainSetup _FusionStore;

	private Evidence _SecurityIdentity;

	private object[] _Policies;

	[SecurityCritical]
	private ResolveEventHandler _TypeResolve;

	[SecurityCritical]
	private ResolveEventHandler _ResourceResolve;

	[SecurityCritical]
	private ResolveEventHandler _AssemblyResolve;

	private Context _DefaultContext;

	private ActivationContext _activationContext;

	private ApplicationIdentity _applicationIdentity;

	private ApplicationTrust _applicationTrust;

	private IPrincipal _DefaultPrincipal;

	private DomainSpecificRemotingData _RemotingData;

	private EventHandler _processExit;

	private EventHandler _domainUnload;

	private UnhandledExceptionEventHandler _unhandledException;

	private string[] _aptcaVisibleAssemblies;

	private Dictionary<string, object> _compatFlags;

	private EventHandler<FirstChanceExceptionEventArgs> _firstChanceException;

	private IntPtr _pDomain;

	private PrincipalPolicy _PrincipalPolicy;

	private bool _HasSetPolicy;

	private bool _IsFastFullTrustDomain;

	private bool _compatFlagsInitialized;

	internal const string TargetFrameworkNameAppCompatSetting = "TargetFrameworkName";

	private static APPX_FLAGS s_flags;

	internal const int DefaultADID = 1;

	private static APPX_FLAGS Flags
	{
		[SecuritySafeCritical]
		get
		{
			if (s_flags == (APPX_FLAGS)0)
			{
				s_flags = nGetAppXFlags();
			}
			return s_flags;
		}
	}

	internal static bool ProfileAPICheck
	{
		[SecuritySafeCritical]
		get
		{
			return (Flags & APPX_FLAGS.APPX_FLAGS_API_CHECK) != 0;
		}
	}

	internal static bool IsAppXNGen
	{
		[SecuritySafeCritical]
		get
		{
			return (Flags & APPX_FLAGS.APPX_FLAGS_APPX_NGEN) != 0;
		}
	}

	internal string[] PartialTrustVisibleAssemblies
	{
		get
		{
			return _aptcaVisibleAssemblies;
		}
		[SecuritySafeCritical]
		set
		{
			_aptcaVisibleAssemblies = value;
			string canonicalConditionalAptcaList = null;
			if (value != null)
			{
				StringBuilder stringBuilder = StringBuilderCache.Acquire();
				for (int i = 0; i < value.Length; i++)
				{
					if (value[i] != null)
					{
						stringBuilder.Append(value[i].ToUpperInvariant());
						if (i != value.Length - 1)
						{
							stringBuilder.Append(';');
						}
					}
				}
				canonicalConditionalAptcaList = StringBuilderCache.GetStringAndRelease(stringBuilder);
			}
			SetCanonicalConditionalAptcaList(canonicalConditionalAptcaList);
		}
	}

	public AppDomainManager DomainManager
	{
		[SecurityCritical]
		get
		{
			return _domainManager;
		}
	}

	internal HostSecurityManager HostSecurityManager
	{
		[SecurityCritical]
		get
		{
			HostSecurityManager hostSecurityManager = null;
			AppDomainManager domainManager = CurrentDomain.DomainManager;
			if (domainManager != null)
			{
				hostSecurityManager = domainManager.HostSecurityManager;
			}
			if (hostSecurityManager == null)
			{
				hostSecurityManager = new HostSecurityManager();
			}
			return hostSecurityManager;
		}
	}

	public static AppDomain CurrentDomain => Thread.GetDomain();

	public Evidence Evidence
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
		get
		{
			return EvidenceNoDemand;
		}
	}

	internal Evidence EvidenceNoDemand
	{
		[SecurityCritical]
		get
		{
			if (_SecurityIdentity == null)
			{
				if (!IsDefaultAppDomain() && nIsDefaultAppDomainForEvidence())
				{
					return GetDefaultDomain().Evidence;
				}
				return new Evidence(new AppDomainEvidenceFactory(this));
			}
			return _SecurityIdentity.Clone();
		}
	}

	internal Evidence InternalEvidence => _SecurityIdentity;

	public string FriendlyName
	{
		[SecuritySafeCritical]
		get
		{
			return nGetFriendlyName();
		}
	}

	public string BaseDirectory => FusionStore.ApplicationBase;

	public string RelativeSearchPath => FusionStore.PrivateBinPath;

	public bool ShadowCopyFiles
	{
		get
		{
			string shadowCopyFiles = FusionStore.ShadowCopyFiles;
			if (shadowCopyFiles != null && string.Compare(shadowCopyFiles, "true", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
			return false;
		}
	}

	public ActivationContext ActivationContext
	{
		[SecurityCritical]
		get
		{
			return _activationContext;
		}
	}

	public ApplicationIdentity ApplicationIdentity
	{
		[SecurityCritical]
		get
		{
			return _applicationIdentity;
		}
	}

	public ApplicationTrust ApplicationTrust
	{
		[SecurityCritical]
		get
		{
			if (_applicationTrust == null && _IsFastFullTrustDomain)
			{
				_applicationTrust = new ApplicationTrust(new PermissionSet(PermissionState.Unrestricted));
			}
			return _applicationTrust;
		}
	}

	public string DynamicDirectory
	{
		[SecuritySafeCritical]
		get
		{
			string dynamicDir = GetDynamicDir();
			if (dynamicDir != null)
			{
				FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, dynamicDir);
			}
			return dynamicDir;
		}
	}

	internal DomainSpecificRemotingData RemotingData
	{
		get
		{
			if (_RemotingData == null)
			{
				CreateRemotingData();
			}
			return _RemotingData;
		}
	}

	internal AppDomainSetup FusionStore => _FusionStore;

	private Dictionary<string, object[]> LocalStore
	{
		get
		{
			if (_LocalStore != null)
			{
				return _LocalStore;
			}
			_LocalStore = new Dictionary<string, object[]>();
			return _LocalStore;
		}
	}

	public AppDomainSetup SetupInformation => new AppDomainSetup(FusionStore, copyDomainBoundData: true);

	public PermissionSet PermissionSet
	{
		[SecurityCritical]
		get
		{
			PermissionSet o = null;
			GetGrantSet(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
			if (o != null)
			{
				return o.Copy();
			}
			return new PermissionSet(PermissionState.Unrestricted);
		}
	}

	public bool IsFullyTrusted
	{
		[SecuritySafeCritical]
		get
		{
			PermissionSet o = null;
			GetGrantSet(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
			return o?.IsUnrestricted() ?? true;
		}
	}

	public bool IsHomogenous
	{
		get
		{
			if (!_IsFastFullTrustDomain)
			{
				return _applicationTrust != null;
			}
			return true;
		}
	}

	internal bool IsLegacyCasPolicyEnabled
	{
		[SecuritySafeCritical]
		get
		{
			return GetIsLegacyCasPolicyEnabled(GetNativeHandle());
		}
	}

	public int Id
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return GetId();
		}
	}

	public static bool MonitoringIsEnabled
	{
		[SecurityCritical]
		get
		{
			return nMonitoringIsEnabled();
		}
		[SecurityCritical]
		set
		{
			if (!value)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_MustBeTrue"));
			}
			nEnableMonitoring();
		}
	}

	public TimeSpan MonitoringTotalProcessorTime
	{
		[SecurityCritical]
		get
		{
			long num = nGetTotalProcessorTime();
			if (num == -1)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WithoutARM"));
			}
			return new TimeSpan(num);
		}
	}

	public long MonitoringTotalAllocatedMemorySize
	{
		[SecurityCritical]
		get
		{
			long num = nGetTotalAllocatedMemorySize();
			if (num == -1)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WithoutARM"));
			}
			return num;
		}
	}

	public long MonitoringSurvivedMemorySize
	{
		[SecurityCritical]
		get
		{
			long num = nGetLastSurvivedMemorySize();
			if (num == -1)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WithoutARM"));
			}
			return num;
		}
	}

	public static long MonitoringSurvivedProcessMemorySize
	{
		[SecurityCritical]
		get
		{
			long num = nGetLastSurvivedProcessMemorySize();
			if (num == -1)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WithoutARM"));
			}
			return num;
		}
	}

	[method: SecurityCritical]
	public event AssemblyLoadEventHandler AssemblyLoad;

	public event ResolveEventHandler TypeResolve
	{
		[SecurityCritical]
		add
		{
			lock (this)
			{
				_TypeResolve = (ResolveEventHandler)Delegate.Combine(_TypeResolve, value);
			}
		}
		[SecurityCritical]
		remove
		{
			lock (this)
			{
				_TypeResolve = (ResolveEventHandler)Delegate.Remove(_TypeResolve, value);
			}
		}
	}

	public event ResolveEventHandler ResourceResolve
	{
		[SecurityCritical]
		add
		{
			lock (this)
			{
				_ResourceResolve = (ResolveEventHandler)Delegate.Combine(_ResourceResolve, value);
			}
		}
		[SecurityCritical]
		remove
		{
			lock (this)
			{
				_ResourceResolve = (ResolveEventHandler)Delegate.Remove(_ResourceResolve, value);
			}
		}
	}

	public event ResolveEventHandler AssemblyResolve
	{
		[SecurityCritical]
		add
		{
			lock (this)
			{
				_AssemblyResolve = (ResolveEventHandler)Delegate.Combine(_AssemblyResolve, value);
			}
		}
		[SecurityCritical]
		remove
		{
			lock (this)
			{
				_AssemblyResolve = (ResolveEventHandler)Delegate.Remove(_AssemblyResolve, value);
			}
		}
	}

	[method: SecurityCritical]
	public event ResolveEventHandler ReflectionOnlyAssemblyResolve;

	public event EventHandler ProcessExit
	{
		[SecuritySafeCritical]
		add
		{
			if (value != null)
			{
				RuntimeHelpers.PrepareContractedDelegate(value);
				lock (this)
				{
					_processExit = (EventHandler)Delegate.Combine(_processExit, value);
				}
			}
		}
		remove
		{
			lock (this)
			{
				_processExit = (EventHandler)Delegate.Remove(_processExit, value);
			}
		}
	}

	public event EventHandler DomainUnload
	{
		[SecuritySafeCritical]
		add
		{
			if (value != null)
			{
				RuntimeHelpers.PrepareContractedDelegate(value);
				lock (this)
				{
					_domainUnload = (EventHandler)Delegate.Combine(_domainUnload, value);
				}
			}
		}
		remove
		{
			lock (this)
			{
				_domainUnload = (EventHandler)Delegate.Remove(_domainUnload, value);
			}
		}
	}

	public event UnhandledExceptionEventHandler UnhandledException
	{
		[SecurityCritical]
		add
		{
			if (value != null)
			{
				RuntimeHelpers.PrepareContractedDelegate(value);
				lock (this)
				{
					_unhandledException = (UnhandledExceptionEventHandler)Delegate.Combine(_unhandledException, value);
				}
			}
		}
		[SecurityCritical]
		remove
		{
			lock (this)
			{
				_unhandledException = (UnhandledExceptionEventHandler)Delegate.Remove(_unhandledException, value);
			}
		}
	}

	public event EventHandler<FirstChanceExceptionEventArgs> FirstChanceException
	{
		[SecurityCritical]
		add
		{
			if (value != null)
			{
				RuntimeHelpers.PrepareContractedDelegate(value);
				lock (this)
				{
					_firstChanceException = (EventHandler<FirstChanceExceptionEventArgs>)Delegate.Combine(_firstChanceException, value);
				}
			}
		}
		[SecurityCritical]
		remove
		{
			lock (this)
			{
				_firstChanceException = (EventHandler<FirstChanceExceptionEventArgs>)Delegate.Remove(_firstChanceException, value);
			}
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DisableFusionUpdatesFromADManager(AppDomainHandle domain);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.I4)]
	private static extern APPX_FLAGS nGetAppXFlags();

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetAppDomainManagerType(AppDomainHandle domain, StringHandleOnStack retAssembly, StringHandleOnStack retType);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SetAppDomainManagerType(AppDomainHandle domain, string assembly, string type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void nSetHostSecurityManagerFlags(HostSecurityManagerOptions flags);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SetSecurityHomogeneousFlag(AppDomainHandle domain, [MarshalAs(UnmanagedType.Bool)] bool runtimeSuppliedHomogenousGrantSet);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SetLegacyCasPolicyEnabled(AppDomainHandle domain);

	[SecurityCritical]
	private void SetLegacyCasPolicyEnabled()
	{
		SetLegacyCasPolicyEnabled(GetNativeHandle());
	}

	internal AppDomainHandle GetNativeHandle()
	{
		if (_pDomain.IsNull())
		{
			throw new InvalidOperationException(Environment.GetResourceString("Argument_InvalidHandle"));
		}
		return new AppDomainHandle(_pDomain);
	}

	[SecuritySafeCritical]
	private void CreateAppDomainManager()
	{
		AppDomainSetup fusionStore = FusionStore;
		GetAppDomainManagerType(out var assembly, out var type);
		if (assembly != null && type != null)
		{
			try
			{
				new PermissionSet(PermissionState.Unrestricted).Assert();
				_domainManager = CreateInstanceAndUnwrap(assembly, type) as AppDomainManager;
				CodeAccessPermission.RevertAssert();
			}
			catch (FileNotFoundException inner)
			{
				throw new TypeLoadException(Environment.GetResourceString("Argument_NoDomainManager"), inner);
			}
			catch (SecurityException inner2)
			{
				throw new TypeLoadException(Environment.GetResourceString("Argument_NoDomainManager"), inner2);
			}
			catch (TypeLoadException inner3)
			{
				throw new TypeLoadException(Environment.GetResourceString("Argument_NoDomainManager"), inner3);
			}
			if (_domainManager == null)
			{
				throw new TypeLoadException(Environment.GetResourceString("Argument_NoDomainManager"));
			}
			FusionStore.AppDomainManagerAssembly = assembly;
			FusionStore.AppDomainManagerType = type;
			bool flag = _domainManager.GetType() != typeof(AppDomainManager) && !DisableFusionUpdatesFromADManager();
			AppDomainSetup oldInfo = null;
			if (flag)
			{
				oldInfo = new AppDomainSetup(FusionStore, copyDomainBoundData: true);
			}
			_domainManager.InitializeNewDomain(FusionStore);
			if (flag)
			{
				SetupFusionStore(_FusionStore, oldInfo);
			}
			AppDomainManagerInitializationOptions initializationFlags = _domainManager.InitializationFlags;
			if ((initializationFlags & AppDomainManagerInitializationOptions.RegisterWithHost) == AppDomainManagerInitializationOptions.RegisterWithHost)
			{
				_domainManager.RegisterWithHost();
			}
		}
		InitializeCompatibilityFlags();
	}

	private void InitializeCompatibilityFlags()
	{
		AppDomainSetup fusionStore = FusionStore;
		if (fusionStore.GetCompatibilityFlags() != null)
		{
			_compatFlags = new Dictionary<string, object>(fusionStore.GetCompatibilityFlags(), StringComparer.OrdinalIgnoreCase);
		}
		_compatFlagsInitialized = true;
		CompatibilitySwitches.InitializeSwitches();
	}

	[SecuritySafeCritical]
	internal string GetTargetFrameworkName()
	{
		string text = _FusionStore.TargetFrameworkName;
		if (text == null && IsDefaultAppDomain() && !_FusionStore.CheckedForTargetFrameworkName)
		{
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			if (entryAssembly != null)
			{
				TargetFrameworkAttribute[] array = (TargetFrameworkAttribute[])entryAssembly.GetCustomAttributes(typeof(TargetFrameworkAttribute));
				if (array != null && array.Length != 0)
				{
					text = array[0].FrameworkName;
					_FusionStore.TargetFrameworkName = text;
				}
			}
			_FusionStore.CheckedForTargetFrameworkName = true;
		}
		return text;
	}

	[SecuritySafeCritical]
	private void SetTargetFrameworkName(string targetFrameworkName)
	{
		if (!_FusionStore.CheckedForTargetFrameworkName)
		{
			_FusionStore.TargetFrameworkName = targetFrameworkName;
			_FusionStore.CheckedForTargetFrameworkName = true;
		}
	}

	[SecuritySafeCritical]
	internal bool DisableFusionUpdatesFromADManager()
	{
		return DisableFusionUpdatesFromADManager(GetNativeHandle());
	}

	[SecuritySafeCritical]
	internal static bool IsAppXModel()
	{
		return (Flags & APPX_FLAGS.APPX_FLAGS_APPX_MODEL) != 0;
	}

	[SecuritySafeCritical]
	internal static bool IsAppXDesignMode()
	{
		return (Flags & APPX_FLAGS.APPX_FLAGS_APPX_MASK) == (APPX_FLAGS.APPX_FLAGS_APPX_MODEL | APPX_FLAGS.APPX_FLAGS_APPX_DESIGN_MODE);
	}

	[SecuritySafeCritical]
	internal static void CheckLoadFromSupported()
	{
		if (IsAppXModel())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_AppX", "Assembly.LoadFrom"));
		}
	}

	[SecuritySafeCritical]
	internal static void CheckLoadFileSupported()
	{
		if (IsAppXModel())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_AppX", "Assembly.LoadFile"));
		}
	}

	[SecuritySafeCritical]
	internal static void CheckReflectionOnlyLoadSupported()
	{
		if (IsAppXModel())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_AppX", "Assembly.ReflectionOnlyLoad"));
		}
	}

	[SecuritySafeCritical]
	internal static void CheckLoadWithPartialNameSupported(StackCrawlMark stackMark)
	{
		if (IsAppXModel())
		{
			RuntimeAssembly executingAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			if (!(executingAssembly != null) || !executingAssembly.IsFrameworkAssembly())
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_AppX", "Assembly.LoadWithPartialName"));
			}
		}
	}

	[SecuritySafeCritical]
	internal static void CheckDefinePInvokeSupported()
	{
		if (IsAppXModel())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_AppX", "DefinePInvokeMethod"));
		}
	}

	[SecuritySafeCritical]
	internal static void CheckLoadByteArraySupported()
	{
		if (IsAppXModel())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_AppX", "Assembly.Load(byte[], ...)"));
		}
	}

	[SecuritySafeCritical]
	internal static void CheckCreateDomainSupported()
	{
		if (IsAppXModel() && !IsAppXDesignMode())
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_AppX", "AppDomain.CreateDomain"));
		}
	}

	[SecuritySafeCritical]
	internal void GetAppDomainManagerType(out string assembly, out string type)
	{
		string s = null;
		string s2 = null;
		GetAppDomainManagerType(GetNativeHandle(), JitHelpers.GetStringHandleOnStack(ref s), JitHelpers.GetStringHandleOnStack(ref s2));
		assembly = s;
		type = s2;
	}

	[SecuritySafeCritical]
	private void SetAppDomainManagerType(string assembly, string type)
	{
		SetAppDomainManagerType(GetNativeHandle(), assembly, type);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SetCanonicalConditionalAptcaList(AppDomainHandle appDomain, string canonicalList);

	[SecurityCritical]
	private void SetCanonicalConditionalAptcaList(string canonicalList)
	{
		SetCanonicalConditionalAptcaList(GetNativeHandle(), canonicalList);
	}

	private void SetupDefaultClickOnceDomain(string fullName, string[] manifestPaths, string[] activationData)
	{
		FusionStore.ActivationArguments = new ActivationArguments(fullName, manifestPaths, activationData);
	}

	[SecurityCritical]
	private void InitializeDomainSecurity(Evidence providedSecurityInfo, Evidence creatorsSecurityInfo, bool generateDefaultEvidence, IntPtr parentSecurityDescriptor, bool publishAppDomain)
	{
		AppDomainSetup fusionStore = FusionStore;
		if (CompatibilitySwitches.IsNetFx40LegacySecurityPolicy)
		{
			SetLegacyCasPolicyEnabled();
		}
		if (fusionStore.ActivationArguments != null)
		{
			ActivationContext activationContext = null;
			ApplicationIdentity applicationIdentity = null;
			string[] array = null;
			CmsUtils.CreateActivationContext(fusionStore.ActivationArguments.ApplicationFullName, fusionStore.ActivationArguments.ApplicationManifestPaths, fusionStore.ActivationArguments.UseFusionActivationContext, out applicationIdentity, out activationContext);
			array = fusionStore.ActivationArguments.ActivationData;
			providedSecurityInfo = CmsUtils.MergeApplicationEvidence(providedSecurityInfo, applicationIdentity, activationContext, array, fusionStore.ApplicationTrust);
			SetupApplicationHelper(providedSecurityInfo, creatorsSecurityInfo, applicationIdentity, activationContext, array);
		}
		else
		{
			bool runtimeSuppliedHomogenousGrantSet = false;
			ApplicationTrust applicationTrust = fusionStore.ApplicationTrust;
			if (applicationTrust == null && !IsLegacyCasPolicyEnabled)
			{
				_IsFastFullTrustDomain = true;
				runtimeSuppliedHomogenousGrantSet = true;
			}
			if (applicationTrust != null)
			{
				SetupDomainSecurityForHomogeneousDomain(applicationTrust, runtimeSuppliedHomogenousGrantSet);
			}
			else if (_IsFastFullTrustDomain)
			{
				SetSecurityHomogeneousFlag(GetNativeHandle(), runtimeSuppliedHomogenousGrantSet);
			}
		}
		Evidence evidence = ((providedSecurityInfo != null) ? providedSecurityInfo : creatorsSecurityInfo);
		if (evidence == null && generateDefaultEvidence)
		{
			evidence = new Evidence(new AppDomainEvidenceFactory(this));
		}
		if (_domainManager != null)
		{
			HostSecurityManager hostSecurityManager = _domainManager.HostSecurityManager;
			if (hostSecurityManager != null)
			{
				nSetHostSecurityManagerFlags(hostSecurityManager.Flags);
				if ((hostSecurityManager.Flags & HostSecurityManagerOptions.HostAppDomainEvidence) == HostSecurityManagerOptions.HostAppDomainEvidence)
				{
					evidence = hostSecurityManager.ProvideAppDomainEvidence(evidence);
					if (evidence != null && evidence.Target == null)
					{
						evidence.Target = new AppDomainEvidenceFactory(this);
					}
				}
			}
		}
		_SecurityIdentity = evidence;
		SetupDomainSecurity(evidence, parentSecurityDescriptor, publishAppDomain);
		if (_domainManager != null)
		{
			RunDomainManagerPostInitialization(_domainManager);
		}
		InitState.RecordEndOfEarlyAppDomainInit();
	}

	[SecurityCritical]
	private void RunDomainManagerPostInitialization(AppDomainManager domainManager)
	{
		HostExecutionContextManager hostExecutionContextManager = domainManager.HostExecutionContextManager;
		if (!IsLegacyCasPolicyEnabled)
		{
			return;
		}
		HostSecurityManager hostSecurityManager = domainManager.HostSecurityManager;
		if (hostSecurityManager != null && (hostSecurityManager.Flags & HostSecurityManagerOptions.HostPolicyLevel) == HostSecurityManagerOptions.HostPolicyLevel)
		{
			PolicyLevel domainPolicy = hostSecurityManager.DomainPolicy;
			if (domainPolicy != null)
			{
				SetAppDomainPolicy(domainPolicy);
			}
		}
	}

	[SecurityCritical]
	private void SetupApplicationHelper(Evidence providedSecurityInfo, Evidence creatorsSecurityInfo, ApplicationIdentity appIdentity, ActivationContext activationContext, string[] activationData)
	{
		HostSecurityManager hostSecurityManager = CurrentDomain.HostSecurityManager;
		ApplicationTrust applicationTrust = hostSecurityManager.DetermineApplicationTrust(providedSecurityInfo, creatorsSecurityInfo, new TrustManagerContext());
		if (applicationTrust == null || !applicationTrust.IsApplicationTrustedToRun)
		{
			throw new PolicyException(Environment.GetResourceString("Policy_NoExecutionPermission"), -2146233320, null);
		}
		if (activationContext != null)
		{
			SetupDomainForApplication(activationContext, activationData);
		}
		SetupDomainSecurityForApplication(appIdentity, applicationTrust);
	}

	[SecurityCritical]
	private void SetupDomainForApplication(ActivationContext activationContext, string[] activationData)
	{
		if (IsDefaultAppDomain())
		{
			AppDomainSetup fusionStore = FusionStore;
			fusionStore.ActivationArguments = new ActivationArguments(activationContext, activationData);
			string entryPointFullPath = CmsUtils.GetEntryPointFullPath(activationContext);
			if (!string.IsNullOrEmpty(entryPointFullPath))
			{
				fusionStore.SetupDefaults(entryPointFullPath);
			}
			else
			{
				fusionStore.ApplicationBase = activationContext.ApplicationDirectory;
			}
			SetupFusionStore(fusionStore, null);
		}
		activationContext.PrepareForExecution();
		activationContext.SetApplicationState(ActivationContext.ApplicationState.Starting);
		activationContext.SetApplicationState(ActivationContext.ApplicationState.Running);
		IPermission permission = null;
		string dataDirectory = activationContext.DataDirectory;
		if (dataDirectory != null && dataDirectory.Length > 0)
		{
			permission = new FileIOPermission(FileIOPermissionAccess.PathDiscovery, dataDirectory);
		}
		SetData("DataDirectory", dataDirectory, permission);
		_activationContext = activationContext;
	}

	[SecurityCritical]
	private void SetupDomainSecurityForApplication(ApplicationIdentity appIdentity, ApplicationTrust appTrust)
	{
		_applicationIdentity = appIdentity;
		SetupDomainSecurityForHomogeneousDomain(appTrust, runtimeSuppliedHomogenousGrantSet: false);
	}

	[SecurityCritical]
	private void SetupDomainSecurityForHomogeneousDomain(ApplicationTrust appTrust, bool runtimeSuppliedHomogenousGrantSet)
	{
		if (runtimeSuppliedHomogenousGrantSet)
		{
			_FusionStore.ApplicationTrust = null;
		}
		_applicationTrust = appTrust;
		SetSecurityHomogeneousFlag(GetNativeHandle(), runtimeSuppliedHomogenousGrantSet);
	}

	[SecuritySafeCritical]
	private int ActivateApplication()
	{
		ObjectHandle objectHandle = Activator.CreateInstance(CurrentDomain.ActivationContext);
		return (int)objectHandle.Unwrap();
	}

	private Assembly ResolveAssemblyForIntrospection(object sender, ResolveEventArgs args)
	{
		return Assembly.ReflectionOnlyLoad(ApplyPolicy(args.Name));
	}

	[SecuritySafeCritical]
	private void EnableResolveAssembliesForIntrospection(string verifiedFileDirectory)
	{
		CurrentDomain.ReflectionOnlyAssemblyResolve += ResolveAssemblyForIntrospection;
		string[] packageGraphFilePaths = null;
		if (verifiedFileDirectory != null)
		{
			packageGraphFilePaths = new string[1] { verifiedFileDirectory };
		}
		NamespaceResolverForIntrospection namespaceResolverForIntrospection = new NamespaceResolverForIntrospection(packageGraphFilePaths);
		WindowsRuntimeMetadata.ReflectionOnlyNamespaceResolve += namespaceResolverForIntrospection.ResolveNamespace;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, null, null, null, null, null, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, null, null, null, null, null, ref stackMark, assemblyAttributes, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes, SecurityContextSource securityContextSource)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, null, null, null, null, null, ref stackMark, assemblyAttributes, securityContextSource);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, dir, null, null, null, null, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, null, evidence, null, null, null, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, null, null, requiredPermissions, optionalPermissions, refusedPermissions, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of DefineDynamicAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, dir, evidence, null, null, null, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, dir, null, requiredPermissions, optionalPermissions, refusedPermissions, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, null, evidence, requiredPermissions, optionalPermissions, refusedPermissions, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default.  Please see http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, dir, evidence, requiredPermissions, optionalPermissions, refusedPermissions, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, dir, evidence, requiredPermissions, optionalPermissions, refusedPermissions, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, dir, evidence, requiredPermissions, optionalPermissions, refusedPermissions, ref stackMark, assemblyAttributes, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, bool isSynchronized, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, dir, null, null, null, null, ref stackMark, assemblyAttributes, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	private AssemblyBuilder InternalDefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, ref StackCrawlMark stackMark, IEnumerable<CustomAttributeBuilder> assemblyAttributes, SecurityContextSource securityContextSource)
	{
		return AssemblyBuilder.InternalDefineDynamicAssembly(name, access, dir, evidence, requiredPermissions, optionalPermissions, refusedPermissions, ref stackMark, assemblyAttributes, securityContextSource);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern string nApplyPolicy(AssemblyName an);

	[ComVisible(false)]
	public string ApplyPolicy(string assemblyName)
	{
		AssemblyName assemblyName2 = new AssemblyName(assemblyName);
		byte[] array = assemblyName2.GetPublicKeyToken();
		if (array == null)
		{
			array = assemblyName2.GetPublicKey();
		}
		if (array == null || array.Length == 0)
		{
			return assemblyName;
		}
		return nApplyPolicy(assemblyName2);
	}

	public ObjectHandle CreateInstance(string assemblyName, string typeName)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		if (assemblyName == null)
		{
			throw new ArgumentNullException("assemblyName");
		}
		return Activator.CreateInstance(assemblyName, typeName);
	}

	[SecurityCritical]
	internal ObjectHandle InternalCreateInstanceWithNoSecurity(string assemblyName, string typeName)
	{
		PermissionSet.s_fullTrust.Assert();
		return CreateInstance(assemblyName, typeName);
	}

	public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		return Activator.CreateInstanceFrom(assemblyFile, typeName);
	}

	[SecurityCritical]
	internal ObjectHandle InternalCreateInstanceFromWithNoSecurity(string assemblyName, string typeName)
	{
		PermissionSet.s_fullTrust.Assert();
		return CreateInstanceFrom(assemblyName, typeName);
	}

	public ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		return Activator.CreateComInstanceFrom(assemblyName, typeName);
	}

	public ObjectHandle CreateComInstanceFrom(string assemblyFile, string typeName, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		return Activator.CreateComInstanceFrom(assemblyFile, typeName, hashValue, hashAlgorithm);
	}

	public ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		if (assemblyName == null)
		{
			throw new ArgumentNullException("assemblyName");
		}
		return Activator.CreateInstance(assemblyName, typeName, activationAttributes);
	}

	public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		return Activator.CreateInstanceFrom(assemblyFile, typeName, activationAttributes);
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		if (assemblyName == null)
		{
			throw new ArgumentNullException("assemblyName");
		}
		if (securityAttributes != null && !IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
		}
		return Activator.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
	}

	public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		if (assemblyName == null)
		{
			throw new ArgumentNullException("assemblyName");
		}
		return Activator.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
	}

	[SecurityCritical]
	internal ObjectHandle InternalCreateInstanceWithNoSecurity(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
	{
		PermissionSet.s_fullTrust.Assert();
		return CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		if (securityAttributes != null && !IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
		}
		return Activator.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
	}

	public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		return Activator.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
	}

	[SecurityCritical]
	internal ObjectHandle InternalCreateInstanceFromWithNoSecurity(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
	{
		PermissionSet.s_fullTrust.Assert();
		return CreateInstanceFrom(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public Assembly Load(AssemblyName assemblyRef)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadAssemblyName(assemblyRef, null, null, ref stackMark, throwOnFileNotFound: true, forIntrospection: false, suppressSecurityChecks: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public Assembly Load(string assemblyString)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoad(assemblyString, null, ref stackMark, forIntrospection: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public Assembly Load(byte[] rawAssembly)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.nLoadImage(rawAssembly, null, null, ref stackMark, fIntrospection: false, fSkipIntegrityCheck: false, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.nLoadImage(rawAssembly, rawSymbolStore, null, ref stackMark, fIntrospection: false, fSkipIntegrityCheck: false, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkId=155570 for more information.")]
	[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
	public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence)
	{
		if (securityEvidence != null && !IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.nLoadImage(rawAssembly, rawSymbolStore, securityEvidence, ref stackMark, fIntrospection: false, fSkipIntegrityCheck: false, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadAssemblyName(assemblyRef, assemblySecurity, null, ref stackMark, throwOnFileNotFound: true, forIntrospection: false, suppressSecurityChecks: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public Assembly Load(string assemblyString, Evidence assemblySecurity)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoad(assemblyString, assemblySecurity, ref stackMark, forIntrospection: false);
	}

	public int ExecuteAssembly(string assemblyFile)
	{
		return ExecuteAssembly(assemblyFile, (string[])null);
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity)
	{
		return ExecuteAssembly(assemblyFile, assemblySecurity, null);
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args)
	{
		if (assemblySecurity != null && !IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
		}
		RuntimeAssembly assembly = (RuntimeAssembly)Assembly.LoadFrom(assemblyFile, assemblySecurity);
		if (args == null)
		{
			args = new string[0];
		}
		return nExecuteAssembly(assembly, args);
	}

	public int ExecuteAssembly(string assemblyFile, string[] args)
	{
		RuntimeAssembly assembly = (RuntimeAssembly)Assembly.LoadFrom(assemblyFile);
		if (args == null)
		{
			args = new string[0];
		}
		return nExecuteAssembly(assembly, args);
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssembly which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
	{
		if (assemblySecurity != null && !IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
		}
		RuntimeAssembly assembly = (RuntimeAssembly)Assembly.LoadFrom(assemblyFile, assemblySecurity, hashValue, hashAlgorithm);
		if (args == null)
		{
			args = new string[0];
		}
		return nExecuteAssembly(assembly, args);
	}

	public int ExecuteAssembly(string assemblyFile, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
	{
		RuntimeAssembly assembly = (RuntimeAssembly)Assembly.LoadFrom(assemblyFile, hashValue, hashAlgorithm);
		if (args == null)
		{
			args = new string[0];
		}
		return nExecuteAssembly(assembly, args);
	}

	public int ExecuteAssemblyByName(string assemblyName)
	{
		return ExecuteAssemblyByName(assemblyName, (string[])null);
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity)
	{
		return ExecuteAssemblyByName(assemblyName, assemblySecurity, (string[])null);
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity, params string[] args)
	{
		if (assemblySecurity != null && !IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
		}
		RuntimeAssembly assembly = (RuntimeAssembly)Assembly.Load(assemblyName, assemblySecurity);
		if (args == null)
		{
			args = new string[0];
		}
		return nExecuteAssembly(assembly, args);
	}

	public int ExecuteAssemblyByName(string assemblyName, params string[] args)
	{
		RuntimeAssembly assembly = (RuntimeAssembly)Assembly.Load(assemblyName);
		if (args == null)
		{
			args = new string[0];
		}
		return nExecuteAssembly(assembly, args);
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of ExecuteAssemblyByName which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public int ExecuteAssemblyByName(AssemblyName assemblyName, Evidence assemblySecurity, params string[] args)
	{
		if (assemblySecurity != null && !IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
		}
		RuntimeAssembly assembly = (RuntimeAssembly)Assembly.Load(assemblyName, assemblySecurity);
		if (args == null)
		{
			args = new string[0];
		}
		return nExecuteAssembly(assembly, args);
	}

	public int ExecuteAssemblyByName(AssemblyName assemblyName, params string[] args)
	{
		RuntimeAssembly assembly = (RuntimeAssembly)Assembly.Load(assemblyName);
		if (args == null)
		{
			args = new string[0];
		}
		return nExecuteAssembly(assembly, args);
	}

	internal EvidenceBase GetHostEvidence(Type type)
	{
		if (_SecurityIdentity != null)
		{
			return _SecurityIdentity.GetHostEvidence(type);
		}
		return new Evidence(new AppDomainEvidenceFactory(this)).GetHostEvidence(type);
	}

	[SecuritySafeCritical]
	public override string ToString()
	{
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		string text = nGetFriendlyName();
		if (text != null)
		{
			stringBuilder.Append(Environment.GetResourceString("Loader_Name") + text);
			stringBuilder.Append(Environment.NewLine);
		}
		if (_Policies == null || _Policies.Length == 0)
		{
			stringBuilder.Append(Environment.GetResourceString("Loader_NoContextPolicies") + Environment.NewLine);
		}
		else
		{
			stringBuilder.Append(Environment.GetResourceString("Loader_ContextPolicies") + Environment.NewLine);
			for (int i = 0; i < _Policies.Length; i++)
			{
				stringBuilder.Append(_Policies[i]);
				stringBuilder.Append(Environment.NewLine);
			}
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	public Assembly[] GetAssemblies()
	{
		return nGetAssemblies(forIntrospection: false);
	}

	public Assembly[] ReflectionOnlyGetAssemblies()
	{
		return nGetAssemblies(forIntrospection: true);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern Assembly[] nGetAssemblies(bool forIntrospection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern bool IsUnloadingForcedFinalize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public extern bool IsFinalizingForUnload();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void PublishAnonymouslyHostedDynamicMethodsAssembly(RuntimeAssembly assemblyHandle);

	[SecurityCritical]
	[Obsolete("AppDomain.AppendPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public void AppendPrivatePath(string path)
	{
		if (path == null || path.Length == 0)
		{
			return;
		}
		string text = FusionStore.Value[5];
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		if (text != null && text.Length > 0)
		{
			stringBuilder.Append(text);
			if (text[text.Length - 1] != Path.PathSeparator && path[0] != Path.PathSeparator)
			{
				stringBuilder.Append(Path.PathSeparator);
			}
		}
		stringBuilder.Append(path);
		string stringAndRelease = StringBuilderCache.GetStringAndRelease(stringBuilder);
		InternalSetPrivateBinPath(stringAndRelease);
	}

	[SecurityCritical]
	[Obsolete("AppDomain.ClearPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public void ClearPrivatePath()
	{
		InternalSetPrivateBinPath(string.Empty);
	}

	[SecurityCritical]
	[Obsolete("AppDomain.ClearShadowCopyPath has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyDirectories instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public void ClearShadowCopyPath()
	{
		InternalSetShadowCopyPath(string.Empty);
	}

	[SecurityCritical]
	[Obsolete("AppDomain.SetCachePath has been deprecated. Please investigate the use of AppDomainSetup.CachePath instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public void SetCachePath(string path)
	{
		InternalSetCachePath(path);
	}

	[SecurityCritical]
	public void SetData(string name, object data)
	{
		SetDataHelper(name, data, null);
	}

	[SecurityCritical]
	public void SetData(string name, object data, IPermission permission)
	{
		SetDataHelper(name, data, permission);
	}

	[SecurityCritical]
	private void SetDataHelper(string name, object data, IPermission permission)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Equals("TargetFrameworkName"))
		{
			_FusionStore.TargetFrameworkName = (string)data;
			return;
		}
		if (name.Equals("IgnoreSystemPolicy"))
		{
			lock (this)
			{
				if (!_HasSetPolicy)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_SetData"));
				}
			}
			new PermissionSet(PermissionState.Unrestricted).Demand();
		}
		int num = AppDomainSetup.Locate(name);
		if (num == -1)
		{
			lock (((ICollection)LocalStore).SyncRoot)
			{
				LocalStore[name] = new object[2] { data, permission };
				return;
			}
		}
		if (permission != null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_SetData"));
		}
		switch (num)
		{
		case 2:
			FusionStore.DynamicBase = (string)data;
			break;
		case 3:
			FusionStore.DeveloperPath = (string)data;
			break;
		case 7:
			FusionStore.ShadowCopyDirectories = (string)data;
			break;
		case 11:
			if (data != null)
			{
				FusionStore.DisallowPublisherPolicy = true;
			}
			else
			{
				FusionStore.DisallowPublisherPolicy = false;
			}
			break;
		case 12:
			if (data != null)
			{
				FusionStore.DisallowCodeDownload = true;
			}
			else
			{
				FusionStore.DisallowCodeDownload = false;
			}
			break;
		case 13:
			if (data != null)
			{
				FusionStore.DisallowBindingRedirects = true;
			}
			else
			{
				FusionStore.DisallowBindingRedirects = false;
			}
			break;
		case 14:
			if (data != null)
			{
				FusionStore.DisallowApplicationBaseProbing = true;
			}
			else
			{
				FusionStore.DisallowApplicationBaseProbing = false;
			}
			break;
		case 15:
			FusionStore.SetConfigurationBytes((byte[])data);
			break;
		default:
			FusionStore.Value[num] = (string)data;
			break;
		}
	}

	[SecuritySafeCritical]
	public object GetData(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		switch (AppDomainSetup.Locate(name))
		{
		case -1:
		{
			if (name.Equals(AppDomainSetup.LoaderOptimizationKey))
			{
				return FusionStore.LoaderOptimization;
			}
			object[] value;
			lock (((ICollection)LocalStore).SyncRoot)
			{
				LocalStore.TryGetValue(name, out value);
			}
			if (value == null)
			{
				return null;
			}
			if (value[1] != null)
			{
				IPermission permission = (IPermission)value[1];
				permission.Demand();
			}
			return value[0];
		}
		case 0:
			return FusionStore.ApplicationBase;
		case 4:
			return FusionStore.ApplicationName;
		case 1:
			return FusionStore.ConfigurationFile;
		case 2:
			return FusionStore.DynamicBase;
		case 3:
			return FusionStore.DeveloperPath;
		case 5:
			return FusionStore.PrivateBinPath;
		case 6:
			return FusionStore.PrivateBinPathProbe;
		case 7:
			return FusionStore.ShadowCopyDirectories;
		case 8:
			return FusionStore.ShadowCopyFiles;
		case 9:
			return FusionStore.CachePath;
		case 10:
			return FusionStore.LicenseFile;
		case 11:
			return FusionStore.DisallowPublisherPolicy;
		case 12:
			return FusionStore.DisallowCodeDownload;
		case 13:
			return FusionStore.DisallowBindingRedirects;
		case 14:
			return FusionStore.DisallowApplicationBaseProbing;
		case 15:
			return FusionStore.GetConfigurationBytes();
		default:
			return null;
		}
	}

	public bool? IsCompatibilitySwitchSet(string value)
	{
		bool? result = (_compatFlagsInitialized ? new bool?(_compatFlags != null && _compatFlags.ContainsKey(value)) : ((bool?)null));
		return result;
	}

	[DllImport("kernel32.dll")]
	[Obsolete("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
	public static extern int GetCurrentThreadId();

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.MayFail)]
	[SecurityPermission(SecurityAction.Demand, ControlAppDomain = true)]
	public static void Unload(AppDomain domain)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		try
		{
			int idForUnload = GetIdForUnload(domain);
			if (idForUnload == 0)
			{
				throw new CannotUnloadAppDomainException();
			}
			nUnload(idForUnload);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	[SecurityCritical]
	[Obsolete("AppDomain policy levels are obsolete and will be removed in a future release of the .NET Framework. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public void SetAppDomainPolicy(PolicyLevel domainPolicy)
	{
		if (domainPolicy == null)
		{
			throw new ArgumentNullException("domainPolicy");
		}
		if (!IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		lock (this)
		{
			if (_HasSetPolicy)
			{
				throw new PolicyException(Environment.GetResourceString("Policy_PolicyAlreadySet"));
			}
			_HasSetPolicy = true;
			nChangeSecurityPolicy();
		}
		SecurityManager.PolicyManager.AddLevel(domainPolicy);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public void SetThreadPrincipal(IPrincipal principal)
	{
		if (principal == null)
		{
			throw new ArgumentNullException("principal");
		}
		lock (this)
		{
			if (_DefaultPrincipal != null)
			{
				throw new PolicyException(Environment.GetResourceString("Policy_PrincipalTwice"));
			}
			_DefaultPrincipal = principal;
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public void SetPrincipalPolicy(PrincipalPolicy policy)
	{
		_PrincipalPolicy = policy;
	}

	[SecurityCritical]
	public override object InitializeLifetimeService()
	{
		return null;
	}

	public void DoCallBack(CrossAppDomainDelegate callBackDelegate)
	{
		if (callBackDelegate == null)
		{
			throw new ArgumentNullException("callBackDelegate");
		}
		callBackDelegate();
	}

	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo)
	{
		return CreateDomain(friendlyName, securityInfo, null);
	}

	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles)
	{
		AppDomainSetup appDomainSetup = new AppDomainSetup();
		appDomainSetup.ApplicationBase = appBasePath;
		appDomainSetup.PrivateBinPath = appRelativeSearchPath;
		if (shadowCopyFiles)
		{
			appDomainSetup.ShadowCopyFiles = "true";
		}
		return CreateDomain(friendlyName, securityInfo, appDomainSetup);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern string GetDynamicDir();

	public static AppDomain CreateDomain(string friendlyName)
	{
		return CreateDomain(friendlyName, null, null);
	}

	[SecurityCritical]
	private static byte[] MarshalObject(object o)
	{
		CodeAccessPermission.Assert(allPossible: true);
		return Serialize(o);
	}

	[SecurityCritical]
	private static byte[] MarshalObjects(object o1, object o2, out byte[] blob2)
	{
		CodeAccessPermission.Assert(allPossible: true);
		byte[] result = Serialize(o1);
		blob2 = Serialize(o2);
		return result;
	}

	[SecurityCritical]
	private static object UnmarshalObject(byte[] blob)
	{
		CodeAccessPermission.Assert(allPossible: true);
		return Deserialize(blob);
	}

	[SecurityCritical]
	private static object UnmarshalObjects(byte[] blob1, byte[] blob2, out object o2)
	{
		CodeAccessPermission.Assert(allPossible: true);
		object result = Deserialize(blob1);
		o2 = Deserialize(blob2);
		return result;
	}

	[SecurityCritical]
	private static byte[] Serialize(object o)
	{
		if (o == null)
		{
			return null;
		}
		if (o is ISecurityEncodable)
		{
			SecurityElement securityElement = ((ISecurityEncodable)o).ToXml();
			MemoryStream memoryStream = new MemoryStream(4096);
			memoryStream.WriteByte(0);
			StreamWriter streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);
			securityElement.ToWriter(streamWriter);
			streamWriter.Flush();
			return memoryStream.ToArray();
		}
		MemoryStream memoryStream2 = new MemoryStream();
		memoryStream2.WriteByte(1);
		CrossAppDomainSerializer.SerializeObject(o, memoryStream2);
		return memoryStream2.ToArray();
	}

	[SecurityCritical]
	private static object Deserialize(byte[] blob)
	{
		if (blob == null)
		{
			return null;
		}
		if (blob[0] == 0)
		{
			Parser parser = new Parser(blob, Tokenizer.ByteTokenEncoding.UTF8Tokens, 1);
			SecurityElement topElement = parser.GetTopElement();
			if (topElement.Tag.Equals("IPermission") || topElement.Tag.Equals("Permission"))
			{
				IPermission permission = XMLUtil.CreatePermission(topElement, PermissionState.None, ignoreTypeLoadFailures: false);
				if (permission == null)
				{
					return null;
				}
				permission.FromXml(topElement);
				return permission;
			}
			if (topElement.Tag.Equals("PermissionSet"))
			{
				PermissionSet permissionSet = new PermissionSet();
				permissionSet.FromXml(topElement, allowInternalOnly: false, ignoreTypeLoadFailures: false);
				return permissionSet;
			}
			if (topElement.Tag.Equals("PermissionToken"))
			{
				PermissionToken permissionToken = new PermissionToken();
				permissionToken.FromXml(topElement);
				return permissionToken;
			}
			return null;
		}
		object obj = null;
		using MemoryStream stm = new MemoryStream(blob, 1, blob.Length - 1);
		return CrossAppDomainSerializer.DeserializeObject(stm);
	}

	[SecurityCritical]
	internal static void Pause()
	{
		AppDomainPauseManager.Instance.Pausing();
		AppDomainPauseManager.Instance.Paused();
	}

	[SecurityCritical]
	internal static void Resume()
	{
		if (AppDomainPauseManager.IsPaused)
		{
			AppDomainPauseManager.Instance.Resuming();
			AppDomainPauseManager.Instance.Resumed();
		}
	}

	private AppDomain()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_Constructor"));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern int _nExecuteAssembly(RuntimeAssembly assembly, string[] args);

	internal int nExecuteAssembly(RuntimeAssembly assembly, string[] args)
	{
		return _nExecuteAssembly(assembly, args);
	}

	internal void CreateRemotingData()
	{
		lock (this)
		{
			if (_RemotingData == null)
			{
				_RemotingData = new DomainSpecificRemotingData();
			}
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern string nGetFriendlyName();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern bool nIsDefaultAppDomainForEvidence();

	private void OnAssemblyLoadEvent(RuntimeAssembly LoadedAssembly)
	{
		AssemblyLoadEventHandler assemblyLoadEventHandler = this.AssemblyLoad;
		if (assemblyLoadEventHandler != null)
		{
			AssemblyLoadEventArgs args = new AssemblyLoadEventArgs(LoadedAssembly);
			assemblyLoadEventHandler(this, args);
		}
	}

	[SecurityCritical]
	private RuntimeAssembly OnResourceResolveEvent(RuntimeAssembly assembly, string resourceName)
	{
		ResolveEventHandler resourceResolve = _ResourceResolve;
		if (resourceResolve == null)
		{
			return null;
		}
		Delegate[] invocationList = resourceResolve.GetInvocationList();
		int num = invocationList.Length;
		for (int i = 0; i < num; i++)
		{
			Assembly asm = ((ResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(resourceName, assembly));
			RuntimeAssembly runtimeAssembly = GetRuntimeAssembly(asm);
			if (runtimeAssembly != null)
			{
				return runtimeAssembly;
			}
		}
		return null;
	}

	[SecurityCritical]
	private RuntimeAssembly OnTypeResolveEvent(RuntimeAssembly assembly, string typeName)
	{
		ResolveEventHandler typeResolve = _TypeResolve;
		if (typeResolve == null)
		{
			return null;
		}
		Delegate[] invocationList = typeResolve.GetInvocationList();
		int num = invocationList.Length;
		for (int i = 0; i < num; i++)
		{
			Assembly asm = ((ResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(typeName, assembly));
			RuntimeAssembly runtimeAssembly = GetRuntimeAssembly(asm);
			if (runtimeAssembly != null)
			{
				return runtimeAssembly;
			}
		}
		return null;
	}

	[SecurityCritical]
	private RuntimeAssembly OnAssemblyResolveEvent(RuntimeAssembly assembly, string assemblyFullName)
	{
		ResolveEventHandler assemblyResolve = _AssemblyResolve;
		if (assemblyResolve == null)
		{
			return null;
		}
		Delegate[] invocationList = assemblyResolve.GetInvocationList();
		int num = invocationList.Length;
		for (int i = 0; i < num; i++)
		{
			Assembly asm = ((ResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(assemblyFullName, assembly));
			RuntimeAssembly runtimeAssembly = GetRuntimeAssembly(asm);
			if (runtimeAssembly != null)
			{
				return runtimeAssembly;
			}
		}
		return null;
	}

	private RuntimeAssembly OnReflectionOnlyAssemblyResolveEvent(RuntimeAssembly assembly, string assemblyFullName)
	{
		ResolveEventHandler resolveEventHandler = this.ReflectionOnlyAssemblyResolve;
		if (resolveEventHandler != null)
		{
			Delegate[] invocationList = resolveEventHandler.GetInvocationList();
			int num = invocationList.Length;
			for (int i = 0; i < num; i++)
			{
				Assembly asm = ((ResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(assemblyFullName, assembly));
				RuntimeAssembly runtimeAssembly = GetRuntimeAssembly(asm);
				if (runtimeAssembly != null)
				{
					return runtimeAssembly;
				}
			}
		}
		return null;
	}

	private RuntimeAssembly[] OnReflectionOnlyNamespaceResolveEvent(RuntimeAssembly assembly, string namespaceName)
	{
		return WindowsRuntimeMetadata.OnReflectionOnlyNamespaceResolveEvent(this, assembly, namespaceName);
	}

	private string[] OnDesignerNamespaceResolveEvent(string namespaceName)
	{
		return WindowsRuntimeMetadata.OnDesignerNamespaceResolveEvent(this, namespaceName);
	}

	internal static RuntimeAssembly GetRuntimeAssembly(Assembly asm)
	{
		if (asm == null)
		{
			return null;
		}
		RuntimeAssembly runtimeAssembly = asm as RuntimeAssembly;
		if (runtimeAssembly != null)
		{
			return runtimeAssembly;
		}
		AssemblyBuilder assemblyBuilder = asm as AssemblyBuilder;
		if (assemblyBuilder != null)
		{
			return assemblyBuilder.InternalAssembly;
		}
		return null;
	}

	private void TurnOnBindingRedirects()
	{
		_FusionStore.DisallowBindingRedirects = false;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static int GetIdForUnload(AppDomain domain)
	{
		if (RemotingServices.IsTransparentProxy(domain))
		{
			return RemotingServices.GetServerDomainIdForProxy(domain);
		}
		return domain.Id;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern bool IsDomainIdValid(int id);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern AppDomain GetDefaultDomain();

	internal IPrincipal GetThreadPrincipal()
	{
		IPrincipal principal = null;
		if (_DefaultPrincipal == null)
		{
			return _PrincipalPolicy switch
			{
				PrincipalPolicy.NoPrincipal => null, 
				PrincipalPolicy.UnauthenticatedPrincipal => new GenericPrincipal(new GenericIdentity("", ""), new string[1] { "" }), 
				PrincipalPolicy.WindowsPrincipal => new WindowsPrincipal(WindowsIdentity.GetCurrent()), 
				_ => null, 
			};
		}
		return _DefaultPrincipal;
	}

	[SecurityCritical]
	internal void CreateDefaultContext()
	{
		lock (this)
		{
			if (_DefaultContext == null)
			{
				_DefaultContext = Context.CreateDefaultContext();
			}
		}
	}

	[SecurityCritical]
	internal Context GetDefaultContext()
	{
		if (_DefaultContext == null)
		{
			CreateDefaultContext();
		}
		return _DefaultContext;
	}

	[SecuritySafeCritical]
	internal static void CheckDomainCreationEvidence(AppDomainSetup creationDomainSetup, Evidence creationEvidence)
	{
		if (creationEvidence != null && !CurrentDomain.IsLegacyCasPolicyEnabled && (creationDomainSetup == null || creationDomainSetup.ApplicationTrust == null))
		{
			SecurityZone securityZone = CurrentDomain.EvidenceNoDemand.GetHostEvidence<Zone>()?.SecurityZone ?? SecurityZone.MyComputer;
			Zone hostEvidence = creationEvidence.GetHostEvidence<Zone>();
			if (hostEvidence != null && hostEvidence.SecurityZone != securityZone && hostEvidence.SecurityZone != SecurityZone.MyComputer)
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
			}
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlAppDomain = true)]
	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info)
	{
		return InternalCreateDomain(friendlyName, securityInfo, info);
	}

	[SecurityCritical]
	internal static AppDomain InternalCreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info)
	{
		if (friendlyName == null)
		{
			throw new ArgumentNullException(Environment.GetResourceString("ArgumentNull_String"));
		}
		CheckCreateDomainSupported();
		if (info == null)
		{
			info = new AppDomainSetup();
		}
		if (info.TargetFrameworkName == null)
		{
			info.TargetFrameworkName = CurrentDomain.GetTargetFrameworkName();
		}
		AppDomainManager domainManager = CurrentDomain.DomainManager;
		if (domainManager != null)
		{
			return domainManager.CreateDomain(friendlyName, securityInfo, info);
		}
		if (securityInfo != null)
		{
			new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
			CheckDomainCreationEvidence(info, securityInfo);
		}
		return nCreateDomain(friendlyName, info, securityInfo, (securityInfo == null) ? CurrentDomain.InternalEvidence : null, CurrentDomain.GetSecurityDescriptor());
	}

	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info, PermissionSet grantSet, params StrongName[] fullTrustAssemblies)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (info.ApplicationBase == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_AppDomainSandboxAPINeedsExplicitAppBase"));
		}
		if (fullTrustAssemblies == null)
		{
			fullTrustAssemblies = new StrongName[0];
		}
		info.ApplicationTrust = new ApplicationTrust(grantSet, fullTrustAssemblies);
		return CreateDomain(friendlyName, securityInfo, info);
	}

	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, AppDomainInitializer adInit, string[] adInitArgs)
	{
		AppDomainSetup appDomainSetup = new AppDomainSetup();
		appDomainSetup.ApplicationBase = appBasePath;
		appDomainSetup.PrivateBinPath = appRelativeSearchPath;
		appDomainSetup.AppDomainInitializer = adInit;
		appDomainSetup.AppDomainInitializerArguments = adInitArgs;
		if (shadowCopyFiles)
		{
			appDomainSetup.ShadowCopyFiles = "true";
		}
		return CreateDomain(friendlyName, securityInfo, appDomainSetup);
	}

	[SecurityCritical]
	private void SetupFusionStore(AppDomainSetup info, AppDomainSetup oldInfo)
	{
		_FusionStore = info;
		if (oldInfo == null)
		{
			if (info.Value[0] == null || info.Value[1] == null)
			{
				AppDomain defaultDomain = GetDefaultDomain();
				if (this == defaultDomain)
				{
					info.SetupDefaults(RuntimeEnvironment.GetModuleFileName(), imageLocationAlreadyNormalized: true);
				}
				else
				{
					if (info.Value[1] == null)
					{
						info.ConfigurationFile = defaultDomain.FusionStore.Value[1];
					}
					if (info.Value[0] == null)
					{
						info.ApplicationBase = defaultDomain.FusionStore.Value[0];
					}
					if (info.Value[4] == null)
					{
						info.ApplicationName = defaultDomain.FusionStore.Value[4];
					}
				}
			}
			if (info.Value[5] == null)
			{
				info.PrivateBinPath = Environment.nativeGetEnvironmentVariable(AppDomainSetup.PrivateBinPathEnvironmentVariable);
			}
			if (info.DeveloperPath == null)
			{
				info.DeveloperPath = RuntimeEnvironment.GetDeveloperPath();
			}
		}
		IntPtr fusionContext = GetFusionContext();
		info.SetupFusionContext(fusionContext, oldInfo);
		if (info.LoaderOptimization != LoaderOptimization.NotSpecified || (oldInfo != null && info.LoaderOptimization != oldInfo.LoaderOptimization))
		{
			UpdateLoaderOptimization(info.LoaderOptimization);
		}
	}

	private static void RunInitializer(AppDomainSetup setup)
	{
		if (setup.AppDomainInitializer != null)
		{
			string[] args = null;
			if (setup.AppDomainInitializerArguments != null)
			{
				args = (string[])setup.AppDomainInitializerArguments.Clone();
			}
			setup.AppDomainInitializer(args);
		}
	}

	[SecurityCritical]
	private static object PrepareDataForSetup(string friendlyName, AppDomainSetup setup, Evidence providedSecurityInfo, Evidence creatorsSecurityInfo, IntPtr parentSecurityDescriptor, string sandboxName, string[] propertyNames, string[] propertyValues)
	{
		byte[] array = null;
		bool flag = false;
		EvidenceCollection evidenceCollection = null;
		if (providedSecurityInfo != null || creatorsSecurityInfo != null)
		{
			HostSecurityManager hostSecurityManager = ((CurrentDomain.DomainManager != null) ? CurrentDomain.DomainManager.HostSecurityManager : null);
			if (hostSecurityManager == null || !(hostSecurityManager.GetType() != typeof(HostSecurityManager)) || (hostSecurityManager.Flags & HostSecurityManagerOptions.HostAppDomainEvidence) != HostSecurityManagerOptions.HostAppDomainEvidence)
			{
				if (providedSecurityInfo != null && providedSecurityInfo.IsUnmodified && providedSecurityInfo.Target != null && providedSecurityInfo.Target is AppDomainEvidenceFactory)
				{
					providedSecurityInfo = null;
					flag = true;
				}
				if (creatorsSecurityInfo != null && creatorsSecurityInfo.IsUnmodified && creatorsSecurityInfo.Target != null && creatorsSecurityInfo.Target is AppDomainEvidenceFactory)
				{
					creatorsSecurityInfo = null;
					flag = true;
				}
			}
		}
		if (providedSecurityInfo != null || creatorsSecurityInfo != null)
		{
			evidenceCollection = new EvidenceCollection();
			evidenceCollection.ProvidedSecurityInfo = providedSecurityInfo;
			evidenceCollection.CreatorsSecurityInfo = creatorsSecurityInfo;
		}
		if (evidenceCollection != null)
		{
			array = CrossAppDomainSerializer.SerializeObject(evidenceCollection).GetBuffer();
		}
		AppDomainInitializerInfo appDomainInitializerInfo = null;
		if (setup != null && setup.AppDomainInitializer != null)
		{
			appDomainInitializerInfo = new AppDomainInitializerInfo(setup.AppDomainInitializer);
		}
		AppDomainSetup appDomainSetup = new AppDomainSetup(setup, copyDomainBoundData: false);
		return new object[9] { friendlyName, appDomainSetup, parentSecurityDescriptor, flag, array, appDomainInitializerInfo, sandboxName, propertyNames, propertyValues };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	private static object Setup(object arg)
	{
		object[] array = (object[])arg;
		string friendlyName = (string)array[0];
		AppDomainSetup appDomainSetup = (AppDomainSetup)array[1];
		IntPtr parentSecurityDescriptor = (IntPtr)array[2];
		bool generateDefaultEvidence = (bool)array[3];
		byte[] array2 = (byte[])array[4];
		AppDomainInitializerInfo appDomainInitializerInfo = (AppDomainInitializerInfo)array[5];
		string text = (string)array[6];
		string[] array3 = (string[])array[7];
		string[] array4 = (string[])array[8];
		Evidence evidence = null;
		Evidence creatorsSecurityInfo = null;
		AppDomain currentDomain = CurrentDomain;
		AppDomainSetup appDomainSetup2 = new AppDomainSetup(appDomainSetup, copyDomainBoundData: false);
		if (array3 != null && array4 != null)
		{
			for (int i = 0; i < array3.Length; i++)
			{
				if (array3[i] == "APPBASE")
				{
					if (array4[i] == null)
					{
						throw new ArgumentNullException("APPBASE");
					}
					if (Path.IsRelative(array4[i]))
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_AbsolutePathRequired"));
					}
					appDomainSetup2.ApplicationBase = NormalizePath(array4[i], fullCheck: true);
				}
				else if (array3[i] == "LOCATION_URI" && evidence == null)
				{
					evidence = new Evidence();
					evidence.AddHostEvidence(new Url(array4[i]));
					currentDomain.SetDataHelper(array3[i], array4[i], null);
				}
				else if (array3[i] == "LOADER_OPTIMIZATION")
				{
					if (array4[i] == null)
					{
						throw new ArgumentNullException("LOADER_OPTIMIZATION");
					}
					switch (array4[i])
					{
					case "SingleDomain":
						appDomainSetup2.LoaderOptimization = LoaderOptimization.SingleDomain;
						break;
					case "MultiDomain":
						appDomainSetup2.LoaderOptimization = LoaderOptimization.MultiDomain;
						break;
					case "MultiDomainHost":
						appDomainSetup2.LoaderOptimization = LoaderOptimization.MultiDomainHost;
						break;
					case "NotSpecified":
						appDomainSetup2.LoaderOptimization = LoaderOptimization.NotSpecified;
						break;
					default:
						throw new ArgumentException(Environment.GetResourceString("Argument_UnrecognizedLoaderOptimization"), "LOADER_OPTIMIZATION");
					}
				}
			}
		}
		AppDomainSortingSetupInfo appDomainSortingSetupInfo = appDomainSetup2._AppDomainSortingSetupInfo;
		if (appDomainSortingSetupInfo != null && (appDomainSortingSetupInfo._pfnIsNLSDefinedString == IntPtr.Zero || appDomainSortingSetupInfo._pfnCompareStringEx == IntPtr.Zero || appDomainSortingSetupInfo._pfnLCMapStringEx == IntPtr.Zero || appDomainSortingSetupInfo._pfnFindNLSStringEx == IntPtr.Zero || appDomainSortingSetupInfo._pfnCompareStringOrdinal == IntPtr.Zero || appDomainSortingSetupInfo._pfnGetNLSVersionEx == IntPtr.Zero) && (!(appDomainSortingSetupInfo._pfnIsNLSDefinedString == IntPtr.Zero) || !(appDomainSortingSetupInfo._pfnCompareStringEx == IntPtr.Zero) || !(appDomainSortingSetupInfo._pfnLCMapStringEx == IntPtr.Zero) || !(appDomainSortingSetupInfo._pfnFindNLSStringEx == IntPtr.Zero) || !(appDomainSortingSetupInfo._pfnCompareStringOrdinal == IntPtr.Zero) || !(appDomainSortingSetupInfo._pfnGetNLSVersionEx == IntPtr.Zero)))
		{
			throw new ArgumentException(Environment.GetResourceString("ArgumentException_NotAllCustomSortingFuncsDefined"));
		}
		currentDomain.SetupFusionStore(appDomainSetup2, null);
		AppDomainSetup fusionStore = currentDomain.FusionStore;
		if (array2 != null)
		{
			EvidenceCollection evidenceCollection = (EvidenceCollection)CrossAppDomainSerializer.DeserializeObject(new MemoryStream(array2));
			evidence = evidenceCollection.ProvidedSecurityInfo;
			creatorsSecurityInfo = evidenceCollection.CreatorsSecurityInfo;
		}
		currentDomain.nSetupFriendlyName(friendlyName);
		if (appDomainSetup != null && appDomainSetup.SandboxInterop)
		{
			currentDomain.nSetDisableInterfaceCache();
		}
		if (fusionStore.AppDomainManagerAssembly != null && fusionStore.AppDomainManagerType != null)
		{
			currentDomain.SetAppDomainManagerType(fusionStore.AppDomainManagerAssembly, fusionStore.AppDomainManagerType);
		}
		currentDomain.PartialTrustVisibleAssemblies = fusionStore.PartialTrustVisibleAssemblies;
		currentDomain.CreateAppDomainManager();
		currentDomain.InitializeDomainSecurity(evidence, creatorsSecurityInfo, generateDefaultEvidence, parentSecurityDescriptor, publishAppDomain: true);
		if (appDomainInitializerInfo != null)
		{
			fusionStore.AppDomainInitializer = appDomainInitializerInfo.Unwrap();
		}
		RunInitializer(fusionStore);
		ObjectHandle obj = null;
		if (fusionStore.ActivationArguments != null && fusionStore.ActivationArguments.ActivateInstance)
		{
			obj = Activator.CreateInstance(currentDomain.ActivationContext);
		}
		return RemotingServices.MarshalInternal(obj, null, null);
	}

	[SecuritySafeCritical]
	internal static string NormalizePath(string path, bool fullCheck)
	{
		return Path.LegacyNormalizePath(path, fullCheck, 260, expandShortPaths: true);
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	private bool IsAssemblyOnAptcaVisibleList(RuntimeAssembly assembly)
	{
		if (_aptcaVisibleAssemblies == null)
		{
			return false;
		}
		AssemblyName name = assembly.GetName();
		string nameWithPublicKey = name.GetNameWithPublicKey();
		nameWithPublicKey = nameWithPublicKey.ToUpperInvariant();
		int num = Array.BinarySearch(_aptcaVisibleAssemblies, nameWithPublicKey, StringComparer.OrdinalIgnoreCase);
		return num >= 0;
	}

	[SecurityCritical]
	private unsafe bool IsAssemblyOnAptcaVisibleListRaw(char* namePtr, int nameLen, byte* keyTokenPtr, int keyTokenLen)
	{
		if (_aptcaVisibleAssemblies == null)
		{
			return false;
		}
		string name = new string(namePtr, 0, nameLen);
		byte[] array = new byte[keyTokenLen];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = keyTokenPtr[i];
		}
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.Name = name;
		assemblyName.SetPublicKeyToken(array);
		try
		{
			int num = Array.BinarySearch(_aptcaVisibleAssemblies, assemblyName, new CAPTCASearcher());
			return num >= 0;
		}
		catch (InvalidOperationException)
		{
			return false;
		}
	}

	[SecurityCritical]
	private void SetupDomain(bool allowRedirects, string path, string configFile, string[] propertyNames, string[] propertyValues)
	{
		lock (this)
		{
			if (_FusionStore != null)
			{
				return;
			}
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			appDomainSetup.SetupDefaults(RuntimeEnvironment.GetModuleFileName(), imageLocationAlreadyNormalized: true);
			if (path != null)
			{
				appDomainSetup.Value[0] = path;
			}
			if (configFile != null)
			{
				appDomainSetup.Value[1] = configFile;
			}
			if (!allowRedirects)
			{
				appDomainSetup.DisallowBindingRedirects = true;
			}
			if (propertyNames != null)
			{
				for (int i = 0; i < propertyNames.Length; i++)
				{
					if (string.Equals(propertyNames[i], "PARTIAL_TRUST_VISIBLE_ASSEMBLIES", StringComparison.Ordinal) && propertyValues[i] != null)
					{
						if (propertyValues[i].Length > 0)
						{
							appDomainSetup.PartialTrustVisibleAssemblies = propertyValues[i].Split(';');
						}
						else
						{
							appDomainSetup.PartialTrustVisibleAssemblies = new string[0];
						}
					}
				}
			}
			PartialTrustVisibleAssemblies = appDomainSetup.PartialTrustVisibleAssemblies;
			SetupFusionStore(appDomainSetup, null);
		}
	}

	[SecurityCritical]
	private void SetupLoaderOptimization(LoaderOptimization policy)
	{
		if (policy != LoaderOptimization.NotSpecified)
		{
			FusionStore.LoaderOptimization = policy;
			UpdateLoaderOptimization(FusionStore.LoaderOptimization);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern IntPtr GetFusionContext();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern IntPtr GetSecurityDescriptor();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern AppDomain nCreateDomain(string friendlyName, AppDomainSetup setup, Evidence providedSecurityInfo, Evidence creatorsSecurityInfo, IntPtr parentSecurityDescriptor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern ObjRef nCreateInstance(string friendlyName, AppDomainSetup setup, Evidence providedSecurityInfo, Evidence creatorsSecurityInfo, IntPtr parentSecurityDescriptor);

	[SecurityCritical]
	private void SetupDomainSecurity(Evidence appDomainEvidence, IntPtr creatorsSecurityDescriptor, bool publishAppDomain)
	{
		Evidence o = appDomainEvidence;
		SetupDomainSecurity(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o), creatorsSecurityDescriptor, publishAppDomain);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SetupDomainSecurity(AppDomainHandle appDomain, ObjectHandleOnStack appDomainEvidence, IntPtr creatorsSecurityDescriptor, [MarshalAs(UnmanagedType.Bool)] bool publishAppDomain);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void nSetupFriendlyName(string friendlyName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	private extern void nSetDisableInterfaceCache();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern void UpdateLoaderOptimization(LoaderOptimization optimization);

	[SecurityCritical]
	[Obsolete("AppDomain.SetShadowCopyPath has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyDirectories instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public void SetShadowCopyPath(string path)
	{
		InternalSetShadowCopyPath(path);
	}

	[SecurityCritical]
	[Obsolete("AppDomain.SetShadowCopyFiles has been deprecated. Please investigate the use of AppDomainSetup.ShadowCopyFiles instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public void SetShadowCopyFiles()
	{
		InternalSetShadowCopyFiles();
	}

	[SecurityCritical]
	[Obsolete("AppDomain.SetDynamicBase has been deprecated. Please investigate the use of AppDomainSetup.DynamicBase instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public void SetDynamicBase(string path)
	{
		InternalSetDynamicBase(path);
	}

	[SecurityCritical]
	internal void InternalSetShadowCopyPath(string path)
	{
		if (path != null)
		{
			IntPtr fusionContext = GetFusionContext();
			AppDomainSetup.UpdateContextProperty(fusionContext, AppDomainSetup.ShadowCopyDirectoriesKey, path);
		}
		FusionStore.ShadowCopyDirectories = path;
	}

	[SecurityCritical]
	internal void InternalSetShadowCopyFiles()
	{
		IntPtr fusionContext = GetFusionContext();
		AppDomainSetup.UpdateContextProperty(fusionContext, AppDomainSetup.ShadowCopyFilesKey, "true");
		FusionStore.ShadowCopyFiles = "true";
	}

	[SecurityCritical]
	internal void InternalSetCachePath(string path)
	{
		FusionStore.CachePath = path;
		if (FusionStore.Value[9] != null)
		{
			IntPtr fusionContext = GetFusionContext();
			AppDomainSetup.UpdateContextProperty(fusionContext, AppDomainSetup.CachePathKey, FusionStore.Value[9]);
		}
	}

	[SecurityCritical]
	internal void InternalSetPrivateBinPath(string path)
	{
		IntPtr fusionContext = GetFusionContext();
		AppDomainSetup.UpdateContextProperty(fusionContext, AppDomainSetup.PrivateBinPathKey, path);
		FusionStore.PrivateBinPath = path;
	}

	[SecurityCritical]
	internal void InternalSetDynamicBase(string path)
	{
		FusionStore.DynamicBase = path;
		if (FusionStore.Value[2] != null)
		{
			IntPtr fusionContext = GetFusionContext();
			AppDomainSetup.UpdateContextProperty(fusionContext, AppDomainSetup.DynamicBaseKey, FusionStore.Value[2]);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern string IsStringInterned(string str);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern string GetOrInternString(string str);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetGrantSet(AppDomainHandle domain, ObjectHandleOnStack retGrantSet);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetIsLegacyCasPolicyEnabled(AppDomainHandle domain);

	[SecuritySafeCritical]
	internal PermissionSet GetHomogenousGrantSet(Evidence evidence)
	{
		if (_IsFastFullTrustDomain)
		{
			return new PermissionSet(PermissionState.Unrestricted);
		}
		if (evidence.GetDelayEvaluatedHostEvidence<StrongName>() != null)
		{
			foreach (StrongName fullTrustAssembly in ApplicationTrust.FullTrustAssemblies)
			{
				StrongNameMembershipCondition strongNameMembershipCondition = new StrongNameMembershipCondition(fullTrustAssembly.PublicKey, fullTrustAssembly.Name, fullTrustAssembly.Version);
				object usedEvidence = null;
				if (((IReportMatchMembershipCondition)strongNameMembershipCondition).Check(evidence, out usedEvidence))
				{
					IDelayEvaluatedEvidence delayEvaluatedEvidence = usedEvidence as IDelayEvaluatedEvidence;
					if (usedEvidence != null)
					{
						delayEvaluatedEvidence.MarkUsed();
					}
					return new PermissionSet(PermissionState.Unrestricted);
				}
			}
		}
		return ApplicationTrust.DefaultGrantSet.PermissionSet.Copy();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void nChangeSecurityPolicy();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.MayCorruptAppDomain, Cer.MayFail)]
	internal static extern void nUnload(int domainInternal);

	public object CreateInstanceAndUnwrap(string assemblyName, string typeName)
	{
		return CreateInstance(assemblyName, typeName)?.Unwrap();
	}

	public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
	{
		return CreateInstance(assemblyName, typeName, activationAttributes)?.Unwrap();
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceAndUnwrap which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
	{
		return CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes)?.Unwrap();
	}

	public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
	{
		return CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes)?.Unwrap();
	}

	public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName)
	{
		return CreateInstanceFrom(assemblyName, typeName)?.Unwrap();
	}

	public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes)
	{
		return CreateInstanceFrom(assemblyName, typeName, activationAttributes)?.Unwrap();
	}

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFromAndUnwrap which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes)
	{
		return CreateInstanceFrom(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes, securityAttributes)?.Unwrap();
	}

	public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
	{
		return CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes)?.Unwrap();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal extern int GetId();

	public bool IsDefaultAppDomain()
	{
		if (GetId() == 1)
		{
			return true;
		}
		return false;
	}

	private static AppDomainSetup InternalCreateDomainSetup(string imageLocation)
	{
		int num = imageLocation.LastIndexOf('\\');
		AppDomainSetup appDomainSetup = new AppDomainSetup();
		appDomainSetup.ApplicationBase = imageLocation.Substring(0, num + 1);
		StringBuilder stringBuilder = new StringBuilder(imageLocation.Substring(num + 1));
		stringBuilder.Append(AppDomainSetup.ConfigurationExtension);
		appDomainSetup.ConfigurationFile = stringBuilder.ToString();
		return appDomainSetup;
	}

	private static AppDomain InternalCreateDomain(string imageLocation)
	{
		AppDomainSetup info = InternalCreateDomainSetup(imageLocation);
		return CreateDomain("Validator", null, info);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void nEnableMonitoring();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool nMonitoringIsEnabled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern long nGetTotalProcessorTime();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern long nGetTotalAllocatedMemorySize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern long nGetLastSurvivedMemorySize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern long nGetLastSurvivedProcessMemorySize();

	[SecurityCritical]
	private void InternalSetDomainContext(string imageLocation)
	{
		SetupFusionStore(InternalCreateDomainSetup(imageLocation), null);
	}

	[__DynamicallyInvokable]
	public new Type GetType()
	{
		return base.GetType();
	}

	void _AppDomain.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _AppDomain.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _AppDomain.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _AppDomain.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}

	internal static bool IsStillInEarlyInit()
	{
		return !InitState.EarlyInitIsComplete();
	}
}
