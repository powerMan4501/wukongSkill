using System.Collections;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Util;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace System.Reflection;

[Serializable]
internal class RuntimeAssembly : Assembly, ICustomQueryInterface
{
	private enum ASSEMBLY_FLAGS : uint
	{
		ASSEMBLY_FLAGS_UNKNOWN = 0u,
		ASSEMBLY_FLAGS_INITIALIZED = 16777216u,
		ASSEMBLY_FLAGS_FRAMEWORK = 33554432u,
		ASSEMBLY_FLAGS_SAFE_REFLECTION = 67108864u,
		ASSEMBLY_FLAGS_TOKEN_MASK = 16777215u
	}

	private const uint COR_E_LOADING_REFERENCE_ASSEMBLY = 2148733016u;

	private string m_fullname;

	private object m_syncRoot;

	private IntPtr m_assembly;

	private ASSEMBLY_FLAGS m_flags;

	private const string s_localFilePrefix = "file:";

	private static string[] s_unsafeFrameworkAssemblyNames = new string[2] { "System.Reflection.Context", "Microsoft.VisualBasic" };

	internal int InvocableAttributeCtorToken
	{
		get
		{
			int num = (int)(Flags & ASSEMBLY_FLAGS.ASSEMBLY_FLAGS_TOKEN_MASK);
			return num | 0x6000000;
		}
	}

	private ASSEMBLY_FLAGS Flags
	{
		[SecuritySafeCritical]
		get
		{
			if ((m_flags & ASSEMBLY_FLAGS.ASSEMBLY_FLAGS_INITIALIZED) == 0)
			{
				ASSEMBLY_FLAGS aSSEMBLY_FLAGS = ASSEMBLY_FLAGS.ASSEMBLY_FLAGS_UNKNOWN;
				if (IsFrameworkAssembly(GetName()))
				{
					aSSEMBLY_FLAGS |= (ASSEMBLY_FLAGS)100663296u;
					string[] array = s_unsafeFrameworkAssemblyNames;
					foreach (string strB in array)
					{
						if (string.Compare(GetSimpleName(), strB, StringComparison.OrdinalIgnoreCase) == 0)
						{
							aSSEMBLY_FLAGS = (ASSEMBLY_FLAGS)((uint)aSSEMBLY_FLAGS & 0xFBFFFFFFu);
							break;
						}
					}
					Type type = GetType("__DynamicallyInvokableAttribute", throwOnError: false);
					if (type != null)
					{
						ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
						int metadataToken = constructor.MetadataToken;
						aSSEMBLY_FLAGS = (ASSEMBLY_FLAGS)((uint)aSSEMBLY_FLAGS | (uint)(metadataToken & 0xFFFFFF));
					}
				}
				else if (IsDesignerBindingContext())
				{
					aSSEMBLY_FLAGS = ASSEMBLY_FLAGS.ASSEMBLY_FLAGS_SAFE_REFLECTION;
				}
				m_flags = aSSEMBLY_FLAGS | ASSEMBLY_FLAGS.ASSEMBLY_FLAGS_INITIALIZED;
			}
			return m_flags;
		}
	}

	internal object SyncRoot
	{
		get
		{
			if (m_syncRoot == null)
			{
				Interlocked.CompareExchange<object>(ref m_syncRoot, new object(), (object)null);
			}
			return m_syncRoot;
		}
	}

	public override string CodeBase
	{
		[SecuritySafeCritical]
		get
		{
			string codeBase = GetCodeBase(copiedName: false);
			VerifyCodeBaseDiscovery(codeBase);
			return codeBase;
		}
	}

	public override string FullName
	{
		[SecuritySafeCritical]
		get
		{
			if (m_fullname == null)
			{
				string s = null;
				GetFullName(GetNativeHandle(), JitHelpers.GetStringHandleOnStack(ref s));
				Interlocked.CompareExchange(ref m_fullname, s, null);
			}
			return m_fullname;
		}
	}

	public override MethodInfo EntryPoint
	{
		[SecuritySafeCritical]
		get
		{
			IRuntimeMethodInfo o = null;
			GetEntryPoint(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
			if (o == null)
			{
				return null;
			}
			return (MethodInfo)RuntimeType.GetMethodBase(o);
		}
	}

	public override IEnumerable<TypeInfo> DefinedTypes
	{
		[SecuritySafeCritical]
		get
		{
			List<RuntimeType> list = new List<RuntimeType>();
			RuntimeModule[] modulesInternal = GetModulesInternal(loadIfNotFound: true, getResourceModules: false);
			for (int i = 0; i < modulesInternal.Length; i++)
			{
				list.AddRange(modulesInternal[i].GetDefinedTypes());
			}
			return list.ToArray();
		}
	}

	public override Evidence Evidence
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
		get
		{
			Evidence evidenceNoDemand = EvidenceNoDemand;
			return evidenceNoDemand.Clone();
		}
	}

	internal Evidence EvidenceNoDemand
	{
		[SecurityCritical]
		get
		{
			Evidence o = null;
			GetEvidence(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
			return o;
		}
	}

	public override PermissionSet PermissionSet
	{
		[SecurityCritical]
		get
		{
			PermissionSet newGrant = null;
			PermissionSet newDenied = null;
			GetGrantSet(out newGrant, out newDenied);
			if (newGrant != null)
			{
				return newGrant.Copy();
			}
			return new PermissionSet(PermissionState.Unrestricted);
		}
	}

	public override SecurityRuleSet SecurityRuleSet
	{
		[SecuritySafeCritical]
		get
		{
			return GetSecurityRuleSet(GetNativeHandle());
		}
	}

	public override Module ManifestModule => GetManifestModule(GetNativeHandle());

	[ComVisible(false)]
	public override bool ReflectionOnly
	{
		[SecuritySafeCritical]
		get
		{
			return IsReflectionOnly(GetNativeHandle());
		}
	}

	public override string Location
	{
		[SecuritySafeCritical]
		get
		{
			string s = null;
			GetLocation(GetNativeHandle(), JitHelpers.GetStringHandleOnStack(ref s));
			if (s != null)
			{
				new FileIOPermission(FileIOPermissionAccess.PathDiscovery, s).Demand();
			}
			return s;
		}
	}

	[ComVisible(false)]
	public override string ImageRuntimeVersion
	{
		[SecuritySafeCritical]
		get
		{
			string s = null;
			GetImageRuntimeVersion(GetNativeHandle(), JitHelpers.GetStringHandleOnStack(ref s));
			return s;
		}
	}

	public override bool GlobalAssemblyCache
	{
		[SecuritySafeCritical]
		get
		{
			return IsGlobalAssemblyCache(GetNativeHandle());
		}
	}

	public override long HostContext
	{
		[SecuritySafeCritical]
		get
		{
			return GetHostContext(GetNativeHandle());
		}
	}

	internal bool IsStrongNameVerified
	{
		[SecurityCritical]
		get
		{
			return GetIsStrongNameVerified(GetNativeHandle());
		}
	}

	public override bool IsDynamic
	{
		[SecuritySafeCritical]
		get
		{
			return FCallIsDynamic(GetNativeHandle());
		}
	}

	[method: SecurityCritical]
	private event ModuleResolveEventHandler _ModuleResolve;

	public override event ModuleResolveEventHandler ModuleResolve
	{
		[SecurityCritical]
		add
		{
			_ModuleResolve += value;
		}
		[SecurityCritical]
		remove
		{
			_ModuleResolve -= value;
		}
	}

	[SecurityCritical]
	CustomQueryInterfaceResult ICustomQueryInterface.GetInterface([In] ref Guid iid, out IntPtr ppv)
	{
		if (iid == typeof(NativeMethods.IDispatch).GUID)
		{
			ppv = Marshal.GetComInterfaceForObject(this, typeof(_Assembly));
			return CustomQueryInterfaceResult.Handled;
		}
		ppv = IntPtr.Zero;
		return CustomQueryInterfaceResult.NotHandled;
	}

	internal RuntimeAssembly()
	{
		throw new NotSupportedException();
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetCodeBase(RuntimeAssembly assembly, bool copiedName, StringHandleOnStack retString);

	[SecurityCritical]
	internal string GetCodeBase(bool copiedName)
	{
		string s = null;
		GetCodeBase(GetNativeHandle(), copiedName, JitHelpers.GetStringHandleOnStack(ref s));
		return s;
	}

	internal RuntimeAssembly GetNativeHandle()
	{
		return this;
	}

	[SecuritySafeCritical]
	public override AssemblyName GetName(bool copiedName)
	{
		AssemblyName assemblyName = new AssemblyName();
		string codeBase = GetCodeBase(copiedName);
		VerifyCodeBaseDiscovery(codeBase);
		assemblyName.Init(GetSimpleName(), GetPublicKey(), null, GetVersion(), GetLocale(), GetHashAlgorithm(), AssemblyVersionCompatibility.SameMachine, codeBase, GetFlags() | AssemblyNameFlags.PublicKey, null);
		Module manifestModule = ManifestModule;
		if (manifestModule != null && manifestModule.MDStreamVersion > 65536)
		{
			ManifestModule.GetPEKind(out var peKind, out var machine);
			assemblyName.SetProcArchIndex(peKind, machine);
		}
		return assemblyName;
	}

	[SecurityCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	private string GetNameForConditionalAptca()
	{
		AssemblyName name = GetName();
		return name.GetNameWithPublicKey();
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetFullName(RuntimeAssembly assembly, StringHandleOnStack retString);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetEntryPoint(RuntimeAssembly assembly, ObjectHandleOnStack retMethod);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetType(RuntimeAssembly assembly, string name, bool throwOnError, bool ignoreCase, ObjectHandleOnStack type);

	[SecuritySafeCritical]
	public override Type GetType(string name, bool throwOnError, bool ignoreCase)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		RuntimeType o = null;
		GetType(GetNativeHandle(), name, throwOnError, ignoreCase, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void GetForwardedTypes(RuntimeAssembly assembly, ObjectHandleOnStack retTypes);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetExportedTypes(RuntimeAssembly assembly, ObjectHandleOnStack retTypes);

	[SecuritySafeCritical]
	public override Type[] GetExportedTypes()
	{
		Type[] o = null;
		GetExportedTypes(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public override Stream GetManifestResourceStream(Type type, string name)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return GetManifestResourceStream(type, name, skipSecurityCheck: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public override Stream GetManifestResourceStream(string name)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return GetManifestResourceStream(name, ref stackMark, skipSecurityCheck: false);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetEvidence(RuntimeAssembly assembly, ObjectHandleOnStack retEvidence);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern SecurityRuleSet GetSecurityRuleSet(RuntimeAssembly assembly);

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		UnitySerializationHolder.GetUnitySerializationInfo(info, 6, FullName, this);
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return CustomAttribute.GetCustomAttributes(this, typeof(object) as RuntimeType);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "attributeType");
		}
		return CustomAttribute.GetCustomAttributes(this, runtimeType);
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		if (attributeType == null)
		{
			throw new ArgumentNullException("attributeType");
		}
		RuntimeType runtimeType = attributeType.UnderlyingSystemType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "caType");
		}
		return CustomAttribute.IsDefined(this, runtimeType);
	}

	public override IList<CustomAttributeData> GetCustomAttributesData()
	{
		return CustomAttributeData.GetCustomAttributesInternal(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	internal static RuntimeAssembly InternalLoadFrom(string assemblyFile, Evidence securityEvidence, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm, bool forIntrospection, bool suppressSecurityChecks, ref StackCrawlMark stackMark)
	{
		if (assemblyFile == null)
		{
			throw new ArgumentNullException("assemblyFile");
		}
		if (securityEvidence != null && !AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
		}
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.CodeBase = assemblyFile;
		assemblyName.SetHashControl(hashValue, hashAlgorithm);
		return InternalLoadAssemblyName(assemblyName, securityEvidence, null, ref stackMark, throwOnFileNotFound: true, forIntrospection, suppressSecurityChecks);
	}

	[SecurityCritical]
	internal static RuntimeAssembly InternalLoad(string assemblyString, Evidence assemblySecurity, ref StackCrawlMark stackMark, bool forIntrospection)
	{
		return InternalLoad(assemblyString, assemblySecurity, ref stackMark, IntPtr.Zero, forIntrospection);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	internal static RuntimeAssembly InternalLoad(string assemblyString, Evidence assemblySecurity, ref StackCrawlMark stackMark, IntPtr pPrivHostBinder, bool forIntrospection)
	{
		RuntimeAssembly assemblyFromResolveEvent;
		AssemblyName assemblyRef = CreateAssemblyName(assemblyString, forIntrospection, out assemblyFromResolveEvent);
		if (assemblyFromResolveEvent != null)
		{
			return assemblyFromResolveEvent;
		}
		return InternalLoadAssemblyName(assemblyRef, assemblySecurity, null, ref stackMark, pPrivHostBinder, throwOnFileNotFound: true, forIntrospection, suppressSecurityChecks: false);
	}

	[SecurityCritical]
	internal static AssemblyName CreateAssemblyName(string assemblyString, bool forIntrospection, out RuntimeAssembly assemblyFromResolveEvent)
	{
		if (assemblyString == null)
		{
			throw new ArgumentNullException("assemblyString");
		}
		if (assemblyString.Length == 0 || assemblyString[0] == '\0')
		{
			throw new ArgumentException(Environment.GetResourceString("Format_StringZeroLength"));
		}
		if (forIntrospection)
		{
			AppDomain.CheckReflectionOnlyLoadSupported();
		}
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.Name = assemblyString;
		assemblyName.nInit(out assemblyFromResolveEvent, forIntrospection, raiseResolveEvent: true);
		return assemblyName;
	}

	[SecurityCritical]
	internal static RuntimeAssembly InternalLoadAssemblyName(AssemblyName assemblyRef, Evidence assemblySecurity, RuntimeAssembly reqAssembly, ref StackCrawlMark stackMark, bool throwOnFileNotFound, bool forIntrospection, bool suppressSecurityChecks)
	{
		return InternalLoadAssemblyName(assemblyRef, assemblySecurity, reqAssembly, ref stackMark, IntPtr.Zero, throwOnFileNotFound: true, forIntrospection, suppressSecurityChecks);
	}

	[SecurityCritical]
	internal static RuntimeAssembly InternalLoadAssemblyName(AssemblyName assemblyRef, Evidence assemblySecurity, RuntimeAssembly reqAssembly, ref StackCrawlMark stackMark, IntPtr pPrivHostBinder, bool throwOnFileNotFound, bool forIntrospection, bool suppressSecurityChecks)
	{
		if (assemblyRef == null)
		{
			throw new ArgumentNullException("assemblyRef");
		}
		if (assemblyRef.CodeBase != null)
		{
			AppDomain.CheckLoadFromSupported();
		}
		assemblyRef = (AssemblyName)assemblyRef.Clone();
		if (assemblySecurity != null)
		{
			if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
			}
			if (!suppressSecurityChecks)
			{
				new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
			}
		}
		string text = VerifyCodeBase(assemblyRef.CodeBase);
		if (text != null && !suppressSecurityChecks)
		{
			if (string.Compare(text, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) != 0)
			{
				IPermission permission = CreateWebPermission(assemblyRef.EscapedCodeBase);
				permission.Demand();
			}
			else
			{
				URLString uRLString = new URLString(text, parsed: true);
				new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, uRLString.GetFileName()).Demand();
			}
		}
		return nLoad(assemblyRef, text, assemblySecurity, reqAssembly, ref stackMark, pPrivHostBinder, throwOnFileNotFound, forIntrospection, suppressSecurityChecks);
	}

	[SecuritySafeCritical]
	internal bool IsFrameworkAssembly()
	{
		ASSEMBLY_FLAGS flags = Flags;
		return (flags & ASSEMBLY_FLAGS.ASSEMBLY_FLAGS_FRAMEWORK) != 0;
	}

	internal bool IsSafeForReflection()
	{
		ASSEMBLY_FLAGS flags = Flags;
		return (flags & ASSEMBLY_FLAGS.ASSEMBLY_FLAGS_SAFE_REFLECTION) != 0;
	}

	[SecuritySafeCritical]
	private bool IsDesignerBindingContext()
	{
		return nIsDesignerBindingContext(this);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool nIsDesignerBindingContext(RuntimeAssembly assembly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern RuntimeAssembly _nLoad(AssemblyName fileName, string codeBase, Evidence assemblySecurity, RuntimeAssembly locationHint, ref StackCrawlMark stackMark, IntPtr pPrivHostBinder, bool throwOnFileNotFound, bool forIntrospection, bool suppressSecurityChecks);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool IsFrameworkAssembly(AssemblyName assemblyName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern bool IsNewPortableAssembly(AssemblyName assemblyName);

	[SecurityCritical]
	private static RuntimeAssembly nLoad(AssemblyName fileName, string codeBase, Evidence assemblySecurity, RuntimeAssembly locationHint, ref StackCrawlMark stackMark, IntPtr pPrivHostBinder, bool throwOnFileNotFound, bool forIntrospection, bool suppressSecurityChecks)
	{
		return _nLoad(fileName, codeBase, assemblySecurity, locationHint, ref stackMark, pPrivHostBinder, throwOnFileNotFound, forIntrospection, suppressSecurityChecks);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	private static RuntimeAssembly LoadWithPartialNameHack(string partialName, bool cropPublicKey)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		AssemblyName assemblyName = new AssemblyName(partialName);
		if (!IsSimplyNamed(assemblyName))
		{
			if (cropPublicKey)
			{
				assemblyName.SetPublicKey(null);
				assemblyName.SetPublicKeyToken(null);
			}
			if (IsFrameworkAssembly(assemblyName) || !AppDomain.IsAppXModel())
			{
				AssemblyName assemblyName2 = EnumerateCache(assemblyName);
				if (assemblyName2 != null)
				{
					return InternalLoadAssemblyName(assemblyName2, null, null, ref stackMark, throwOnFileNotFound: true, forIntrospection: false, suppressSecurityChecks: false);
				}
				return null;
			}
		}
		if (AppDomain.IsAppXModel())
		{
			assemblyName.Version = null;
			return nLoad(assemblyName, null, null, null, ref stackMark, IntPtr.Zero, throwOnFileNotFound: false, forIntrospection: false, suppressSecurityChecks: false);
		}
		return null;
	}

	[SecurityCritical]
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark)
	{
		AssemblyName an = new AssemblyName(partialName);
		return LoadWithPartialNameInternal(an, securityEvidence, ref stackMark);
	}

	[SecurityCritical]
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark)
	{
		if (securityEvidence != null)
		{
			if (!AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
			}
			new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
		}
		AppDomain.CheckLoadWithPartialNameSupported(stackMark);
		RuntimeAssembly result = null;
		try
		{
			result = nLoad(an, null, securityEvidence, null, ref stackMark, IntPtr.Zero, throwOnFileNotFound: true, forIntrospection: false, suppressSecurityChecks: false);
		}
		catch (Exception ex)
		{
			if (ex.IsTransient)
			{
				throw ex;
			}
			if (IsUserError(ex))
			{
				throw;
			}
			if (IsFrameworkAssembly(an) || !AppDomain.IsAppXModel())
			{
				if (IsSimplyNamed(an))
				{
					return null;
				}
				AssemblyName assemblyName = EnumerateCache(an);
				if (assemblyName != null)
				{
					result = InternalLoadAssemblyName(assemblyName, securityEvidence, null, ref stackMark, throwOnFileNotFound: true, forIntrospection: false, suppressSecurityChecks: false);
				}
			}
			else
			{
				an.Version = null;
				result = nLoad(an, null, securityEvidence, null, ref stackMark, IntPtr.Zero, throwOnFileNotFound: false, forIntrospection: false, suppressSecurityChecks: false);
			}
		}
		return result;
	}

	[SecuritySafeCritical]
	private static bool IsUserError(Exception e)
	{
		return e.HResult == -2146234280;
	}

	private static bool IsSimplyNamed(AssemblyName partialName)
	{
		byte[] publicKeyToken = partialName.GetPublicKeyToken();
		if (publicKeyToken != null && publicKeyToken.Length == 0)
		{
			return true;
		}
		publicKeyToken = partialName.GetPublicKey();
		if (publicKeyToken != null && publicKeyToken.Length == 0)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	private static AssemblyName EnumerateCache(AssemblyName partialName)
	{
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		partialName.Version = null;
		ArrayList arrayList = new ArrayList();
		Fusion.ReadCache(arrayList, partialName.FullName, 2u);
		IEnumerator enumerator = arrayList.GetEnumerator();
		AssemblyName assemblyName = null;
		CultureInfo cultureInfo = partialName.CultureInfo;
		while (enumerator.MoveNext())
		{
			AssemblyName assemblyName2 = new AssemblyName((string)enumerator.Current);
			if (CulturesEqual(cultureInfo, assemblyName2.CultureInfo))
			{
				if (assemblyName == null)
				{
					assemblyName = assemblyName2;
				}
				else if (assemblyName2.Version > assemblyName.Version)
				{
					assemblyName = assemblyName2;
				}
			}
		}
		return assemblyName;
	}

	private static bool CulturesEqual(CultureInfo refCI, CultureInfo defCI)
	{
		bool flag = defCI.Equals(CultureInfo.InvariantCulture);
		if (refCI == null || refCI.Equals(CultureInfo.InvariantCulture))
		{
			return flag;
		}
		if (flag || !defCI.Equals(refCI))
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool IsReflectionOnly(RuntimeAssembly assembly);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void LoadModule(RuntimeAssembly assembly, string moduleName, byte[] rawModule, int cbModule, byte[] rawSymbolStore, int cbSymbolStore, ObjectHandleOnStack retModule);

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
	public override Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore)
	{
		RuntimeModule o = null;
		LoadModule(GetNativeHandle(), moduleName, rawModule, (rawModule != null) ? rawModule.Length : 0, rawSymbolStore, (rawSymbolStore != null) ? rawSymbolStore.Length : 0, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetModule(RuntimeAssembly assembly, string name, ObjectHandleOnStack retModule);

	[SecuritySafeCritical]
	public override Module GetModule(string name)
	{
		Module o = null;
		GetModule(GetNativeHandle(), name, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[SecuritySafeCritical]
	public override FileStream GetFile(string name)
	{
		RuntimeModule runtimeModule = (RuntimeModule)GetModule(name);
		if (runtimeModule == null)
		{
			return null;
		}
		return new FileStream(runtimeModule.GetFullyQualifiedName(), FileMode.Open, FileAccess.Read, FileShare.Read, 4096, useAsync: false);
	}

	[SecuritySafeCritical]
	public override FileStream[] GetFiles(bool getResourceModules)
	{
		Module[] modules = GetModules(getResourceModules);
		int num = modules.Length;
		FileStream[] array = new FileStream[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = new FileStream(((RuntimeModule)modules[i]).GetFullyQualifiedName(), FileMode.Open, FileAccess.Read, FileShare.Read, 4096, useAsync: false);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern string[] GetManifestResourceNames(RuntimeAssembly assembly);

	[SecuritySafeCritical]
	public override string[] GetManifestResourceNames()
	{
		return GetManifestResourceNames(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetExecutingAssembly(StackCrawlMarkHandle stackMark, ObjectHandleOnStack retAssembly);

	[SecurityCritical]
	internal static RuntimeAssembly GetExecutingAssembly(ref StackCrawlMark stackMark)
	{
		RuntimeAssembly o = null;
		GetExecutingAssembly(JitHelpers.GetStackCrawlMarkHandle(ref stackMark), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern AssemblyName[] GetReferencedAssemblies(RuntimeAssembly assembly);

	[SecuritySafeCritical]
	public override AssemblyName[] GetReferencedAssemblies()
	{
		return GetReferencedAssemblies(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int GetManifestResourceInfo(RuntimeAssembly assembly, string resourceName, ObjectHandleOnStack assemblyRef, StringHandleOnStack retFileName, StackCrawlMarkHandle stackMark);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
	{
		RuntimeAssembly o = null;
		string s = null;
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		int manifestResourceInfo = GetManifestResourceInfo(GetNativeHandle(), resourceName, JitHelpers.GetObjectHandleOnStack(ref o), JitHelpers.GetStringHandleOnStack(ref s), JitHelpers.GetStackCrawlMarkHandle(ref stackMark));
		if (manifestResourceInfo == -1)
		{
			return null;
		}
		return new ManifestResourceInfo(o, s, (ResourceLocation)manifestResourceInfo);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetLocation(RuntimeAssembly assembly, StringHandleOnStack retString);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetImageRuntimeVersion(RuntimeAssembly assembly, StringHandleOnStack retString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool IsGlobalAssemblyCache(RuntimeAssembly assembly);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern long GetHostContext(RuntimeAssembly assembly);

	private static string VerifyCodeBase(string codebase)
	{
		if (codebase == null)
		{
			return null;
		}
		int length = codebase.Length;
		if (length == 0)
		{
			return null;
		}
		int num = codebase.IndexOf(':');
		if (num != -1 && num + 2 < length && (codebase[num + 1] == '/' || codebase[num + 1] == '\\') && (codebase[num + 2] == '/' || codebase[num + 2] == '\\'))
		{
			return codebase;
		}
		if (length > 2 && codebase[0] == '\\' && codebase[1] == '\\')
		{
			return "file://" + codebase;
		}
		return "file:///" + Path.GetFullPathInternal(codebase);
	}

	[SecurityCritical]
	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (type == null)
		{
			if (name == null)
			{
				throw new ArgumentNullException("type");
			}
		}
		else
		{
			string text = type.Namespace;
			if (text != null)
			{
				stringBuilder.Append(text);
				if (name != null)
				{
					stringBuilder.Append(Type.Delimiter);
				}
			}
		}
		if (name != null)
		{
			stringBuilder.Append(name);
		}
		return GetManifestResourceStream(stringBuilder.ToString(), ref stackMark, skipSecurityCheck);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool GetIsStrongNameVerified(RuntimeAssembly assembly);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern byte* GetResource(RuntimeAssembly assembly, string resourceName, out ulong length, StackCrawlMarkHandle stackMark, bool skipSecurityCheck);

	[SecurityCritical]
	internal unsafe Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck)
	{
		ulong length = 0uL;
		byte* resource = GetResource(GetNativeHandle(), name, out length, JitHelpers.GetStackCrawlMarkHandle(ref stackMark), skipSecurityCheck);
		if (resource != null)
		{
			if (length > long.MaxValue)
			{
				throw new NotImplementedException(Environment.GetResourceString("NotImplemented_ResourcesLongerThan2^63"));
			}
			return new UnmanagedMemoryStream(resource, (long)length, (long)length, FileAccess.Read, skipSecurityCheck: true);
		}
		return null;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetVersion(RuntimeAssembly assembly, out int majVer, out int minVer, out int buildNum, out int revNum);

	[SecurityCritical]
	internal Version GetVersion()
	{
		GetVersion(GetNativeHandle(), out var majVer, out var minVer, out var buildNum, out var revNum);
		return new Version(majVer, minVer, buildNum, revNum);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetLocale(RuntimeAssembly assembly, StringHandleOnStack retString);

	[SecurityCritical]
	internal CultureInfo GetLocale()
	{
		string s = null;
		GetLocale(GetNativeHandle(), JitHelpers.GetStringHandleOnStack(ref s));
		if (s == null)
		{
			return CultureInfo.InvariantCulture;
		}
		return new CultureInfo(s);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool FCallIsDynamic(RuntimeAssembly assembly);

	[SecurityCritical]
	private void VerifyCodeBaseDiscovery(string codeBase)
	{
		if (!CodeAccessSecurityEngine.QuickCheckForAllDemands() && codeBase != null && string.Compare(codeBase, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0)
		{
			URLString uRLString = new URLString(codeBase, parsed: true);
			new FileIOPermission(FileIOPermissionAccess.PathDiscovery, uRLString.GetFileName()).Demand();
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetSimpleName(RuntimeAssembly assembly, StringHandleOnStack retSimpleName);

	[SecuritySafeCritical]
	internal string GetSimpleName()
	{
		string s = null;
		GetSimpleName(GetNativeHandle(), JitHelpers.GetStringHandleOnStack(ref s));
		return s;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern AssemblyHashAlgorithm GetHashAlgorithm(RuntimeAssembly assembly);

	[SecurityCritical]
	private AssemblyHashAlgorithm GetHashAlgorithm()
	{
		return GetHashAlgorithm(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern AssemblyNameFlags GetFlags(RuntimeAssembly assembly);

	[SecurityCritical]
	private AssemblyNameFlags GetFlags()
	{
		return GetFlags(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetRawBytes(RuntimeAssembly assembly, ObjectHandleOnStack retRawBytes);

	[SecuritySafeCritical]
	internal byte[] GetRawBytes()
	{
		byte[] o = null;
		GetRawBytes(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetPublicKey(RuntimeAssembly assembly, ObjectHandleOnStack retPublicKey);

	[SecurityCritical]
	internal byte[] GetPublicKey()
	{
		byte[] o = null;
		GetPublicKey(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetGrantSet(RuntimeAssembly assembly, ObjectHandleOnStack granted, ObjectHandleOnStack denied);

	[SecurityCritical]
	internal void GetGrantSet(out PermissionSet newGrant, out PermissionSet newDenied)
	{
		PermissionSet o = null;
		PermissionSet o2 = null;
		GetGrantSet(GetNativeHandle(), JitHelpers.GetObjectHandleOnStack(ref o), JitHelpers.GetObjectHandleOnStack(ref o2));
		newGrant = o;
		newDenied = o2;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsAllSecurityCritical(RuntimeAssembly assembly);

	[SecuritySafeCritical]
	internal bool IsAllSecurityCritical()
	{
		return IsAllSecurityCritical(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsAllSecuritySafeCritical(RuntimeAssembly assembly);

	[SecuritySafeCritical]
	internal bool IsAllSecuritySafeCritical()
	{
		return IsAllSecuritySafeCritical(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsAllPublicAreaSecuritySafeCritical(RuntimeAssembly assembly);

	[SecuritySafeCritical]
	internal bool IsAllPublicAreaSecuritySafeCritical()
	{
		return IsAllPublicAreaSecuritySafeCritical(GetNativeHandle());
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsAllSecurityTransparent(RuntimeAssembly assembly);

	[SecuritySafeCritical]
	internal bool IsAllSecurityTransparent()
	{
		return IsAllSecurityTransparent(GetNativeHandle());
	}

	[SecurityCritical]
	private static void DemandPermission(string codeBase, bool havePath, int demandFlag)
	{
		FileIOPermissionAccess access = FileIOPermissionAccess.PathDiscovery;
		switch (demandFlag)
		{
		case 1:
			access = FileIOPermissionAccess.Read;
			break;
		case 2:
			access = FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery;
			break;
		case 3:
		{
			IPermission permission = CreateWebPermission(AssemblyName.EscapeCodeBase(codeBase));
			permission.Demand();
			return;
		}
		}
		if (!havePath)
		{
			URLString uRLString = new URLString(codeBase, parsed: true);
			codeBase = uRLString.GetFileName();
		}
		codeBase = Path.GetFullPathInternal(codeBase);
		new FileIOPermission(access, codeBase).Demand();
	}

	private static IPermission CreateWebPermission(string codeBase)
	{
		Assembly assembly = Assembly.Load("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
		Type type = assembly.GetType("System.Net.NetworkAccess", throwOnError: true);
		IPermission permission = null;
		if (type.IsEnum && type.IsVisible)
		{
			object[] array = new object[2]
			{
				(Enum)Enum.Parse(type, "Connect", ignoreCase: true),
				null
			};
			if (array[0] != null)
			{
				array[1] = codeBase;
				type = assembly.GetType("System.Net.WebPermission", throwOnError: true);
				if (type.IsVisible)
				{
					permission = (IPermission)Activator.CreateInstance(type, array);
				}
			}
		}
		if (permission == null)
		{
			throw new InvalidOperationException();
		}
		return permission;
	}

	[SecurityCritical]
	private RuntimeModule OnModuleResolveEvent(string moduleName)
	{
		ModuleResolveEventHandler moduleResolveEventHandler = this._ModuleResolve;
		if (moduleResolveEventHandler == null)
		{
			return null;
		}
		Delegate[] invocationList = moduleResolveEventHandler.GetInvocationList();
		int num = invocationList.Length;
		for (int i = 0; i < num; i++)
		{
			RuntimeModule runtimeModule = (RuntimeModule)((ModuleResolveEventHandler)invocationList[i])(this, new ResolveEventArgs(moduleName, this));
			if (runtimeModule != null)
			{
				return runtimeModule;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Assembly GetSatelliteAssembly(CultureInfo culture)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalGetSatelliteAssembly(culture, null, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Assembly GetSatelliteAssembly(CultureInfo culture, Version version)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalGetSatelliteAssembly(culture, version, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	internal Assembly InternalGetSatelliteAssembly(CultureInfo culture, Version version, ref StackCrawlMark stackMark)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		string name = GetSimpleName() + ".resources";
		return InternalGetSatelliteAssembly(name, culture, version, throwOnFileNotFound: true, ref stackMark);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UseRelativeBindForSatellites();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark)
	{
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.SetPublicKey(GetPublicKey());
		assemblyName.Flags = GetFlags() | AssemblyNameFlags.PublicKey;
		if (version == null)
		{
			assemblyName.Version = GetVersion();
		}
		else
		{
			assemblyName.Version = version;
		}
		assemblyName.CultureInfo = culture;
		assemblyName.Name = name;
		RuntimeAssembly runtimeAssembly = null;
		bool flag = AppDomain.IsAppXDesignMode();
		bool flag2 = false;
		if (CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			flag2 = IsFrameworkAssembly() || UseRelativeBindForSatellites();
		}
		if (flag || flag2)
		{
			if (GlobalAssemblyCache)
			{
				ArrayList arrayList = new ArrayList();
				bool flag3 = false;
				try
				{
					Fusion.ReadCache(arrayList, assemblyName.FullName, 2u);
				}
				catch (Exception ex)
				{
					if (ex.IsTransient)
					{
						throw;
					}
					if (!AppDomain.IsAppXModel())
					{
						flag3 = true;
					}
				}
				if (arrayList.Count > 0 || flag3)
				{
					runtimeAssembly = nLoad(assemblyName, null, null, this, ref stackMark, IntPtr.Zero, throwOnFileNotFound, forIntrospection: false, suppressSecurityChecks: false);
				}
			}
			else
			{
				string codeBase = CodeBase;
				if (codeBase != null && string.Compare(codeBase, 0, "file:", 0, 5, StringComparison.OrdinalIgnoreCase) == 0)
				{
					runtimeAssembly = InternalProbeForSatelliteAssemblyNextToParentAssembly(assemblyName, name, codeBase, culture, throwOnFileNotFound, flag, ref stackMark);
					if (runtimeAssembly != null && !IsSimplyNamed(assemblyName))
					{
						AssemblyName name2 = runtimeAssembly.GetName();
						if (!AssemblyName.ReferenceMatchesDefinitionInternal(assemblyName, name2, parse: false))
						{
							runtimeAssembly = null;
						}
					}
				}
				else if (!flag)
				{
					runtimeAssembly = nLoad(assemblyName, null, null, this, ref stackMark, IntPtr.Zero, throwOnFileNotFound, forIntrospection: false, suppressSecurityChecks: false);
				}
			}
		}
		else
		{
			runtimeAssembly = nLoad(assemblyName, null, null, this, ref stackMark, IntPtr.Zero, throwOnFileNotFound, forIntrospection: false, suppressSecurityChecks: false);
		}
		if (runtimeAssembly == this || (runtimeAssembly == null && throwOnFileNotFound))
		{
			throw new FileNotFoundException(string.Format(culture, Environment.GetResourceString("IO.FileNotFound_FileName"), assemblyName.Name));
		}
		return runtimeAssembly;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	private RuntimeAssembly InternalProbeForSatelliteAssemblyNextToParentAssembly(AssemblyName an, string name, string codeBase, CultureInfo culture, bool throwOnFileNotFound, bool useLoadFile, ref StackCrawlMark stackMark)
	{
		RuntimeAssembly runtimeAssembly = null;
		string text = null;
		if (useLoadFile)
		{
			text = Location;
		}
		FileNotFoundException ex = null;
		StringBuilder stringBuilder = new StringBuilder(useLoadFile ? text : codeBase, 0, useLoadFile ? (text.LastIndexOf('\\') + 1) : (codeBase.LastIndexOf('/') + 1), 260);
		stringBuilder.Append(an.CultureInfo.Name);
		stringBuilder.Append(useLoadFile ? '\\' : '/');
		stringBuilder.Append(name);
		stringBuilder.Append(".DLL");
		string text2 = stringBuilder.ToString();
		AssemblyName assemblyName = null;
		if (!useLoadFile)
		{
			assemblyName = new AssemblyName();
			assemblyName.CodeBase = text2;
		}
		try
		{
			try
			{
				runtimeAssembly = (useLoadFile ? nLoadFile(text2, null) : nLoad(assemblyName, text2, null, this, ref stackMark, IntPtr.Zero, throwOnFileNotFound, forIntrospection: false, suppressSecurityChecks: false));
			}
			catch (FileNotFoundException)
			{
				ex = new FileNotFoundException(string.Format(culture, Environment.GetResourceString("IO.FileNotFound_FileName"), text2), text2);
				runtimeAssembly = null;
			}
			if (runtimeAssembly == null)
			{
				stringBuilder.Remove(stringBuilder.Length - 4, 4);
				stringBuilder.Append(".EXE");
				text2 = stringBuilder.ToString();
				if (!useLoadFile)
				{
					assemblyName.CodeBase = text2;
				}
				try
				{
					runtimeAssembly = (useLoadFile ? nLoadFile(text2, null) : nLoad(assemblyName, text2, null, this, ref stackMark, IntPtr.Zero, throwOnFileNotFound: false, forIntrospection: false, suppressSecurityChecks: false));
				}
				catch (FileNotFoundException)
				{
					runtimeAssembly = null;
				}
				if (runtimeAssembly == null && throwOnFileNotFound)
				{
					throw ex;
				}
			}
		}
		catch (DirectoryNotFoundException)
		{
			if (throwOnFileNotFound)
			{
				throw;
			}
			runtimeAssembly = null;
		}
		return runtimeAssembly;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern RuntimeAssembly nLoadFile(string path, Evidence evidence);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern RuntimeAssembly nLoadImage(byte[] rawAssembly, byte[] rawSymbolStore, Evidence evidence, ref StackCrawlMark stackMark, bool fIntrospection, bool fSkipIntegrityCheck, SecurityContextSource securityContextSource);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetModules(RuntimeAssembly assembly, bool loadIfNotFound, bool getResourceModules, ObjectHandleOnStack retModuleHandles);

	[SecuritySafeCritical]
	private RuntimeModule[] GetModulesInternal(bool loadIfNotFound, bool getResourceModules)
	{
		RuntimeModule[] o = null;
		GetModules(GetNativeHandle(), loadIfNotFound, getResourceModules, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	public override Module[] GetModules(bool getResourceModules)
	{
		return GetModulesInternal(loadIfNotFound: true, getResourceModules);
	}

	public override Module[] GetLoadedModules(bool getResourceModules)
	{
		return GetModulesInternal(loadIfNotFound: false, getResourceModules);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern RuntimeModule GetManifestModule(RuntimeAssembly assembly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern bool AptcaCheck(RuntimeAssembly targetAssembly, RuntimeAssembly sourceAssembly);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetToken(RuntimeAssembly assembly);
}
