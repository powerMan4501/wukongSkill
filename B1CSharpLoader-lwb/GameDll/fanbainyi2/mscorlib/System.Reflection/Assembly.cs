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
using System.Threading;

namespace System.Reflection;

[Serializable]
[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(true)]
[__DynamicallyInvokable]
[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
public abstract class Assembly : _Assembly, IEvidenceFactory, ICustomAttributeProvider, ISerializable
{
	public virtual string CodeBase
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual string EscapedCodeBase
	{
		[SecuritySafeCritical]
		get
		{
			return AssemblyName.EscapeCodeBase(CodeBase);
		}
	}

	[__DynamicallyInvokable]
	public virtual string FullName
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual MethodInfo EntryPoint
	{
		[__DynamicallyInvokable]
		get
		{
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<Type> ExportedTypes
	{
		[__DynamicallyInvokable]
		get
		{
			return GetExportedTypes();
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<TypeInfo> DefinedTypes
	{
		[__DynamicallyInvokable]
		get
		{
			Type[] types = GetTypes();
			TypeInfo[] array = new TypeInfo[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				TypeInfo typeInfo = types[i].GetTypeInfo();
				if (typeInfo == null)
				{
					throw new NotSupportedException(Environment.GetResourceString("NotSupported_NoTypeInfo", types[i].FullName));
				}
				array[i] = typeInfo;
			}
			return array;
		}
	}

	public virtual Evidence Evidence
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual PermissionSet PermissionSet
	{
		[SecurityCritical]
		get
		{
			throw new NotImplementedException();
		}
	}

	public bool IsFullyTrusted
	{
		[SecuritySafeCritical]
		get
		{
			return PermissionSet.IsUnrestricted();
		}
	}

	public virtual SecurityRuleSet SecurityRuleSet
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public virtual Module ManifestModule
	{
		[__DynamicallyInvokable]
		get
		{
			RuntimeAssembly runtimeAssembly = this as RuntimeAssembly;
			if (runtimeAssembly != null)
			{
				return runtimeAssembly.ManifestModule;
			}
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<CustomAttributeData> CustomAttributes
	{
		[__DynamicallyInvokable]
		get
		{
			return GetCustomAttributesData();
		}
	}

	[ComVisible(false)]
	public virtual bool ReflectionOnly
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual IEnumerable<Module> Modules
	{
		[__DynamicallyInvokable]
		get
		{
			return GetLoadedModules(getResourceModules: true);
		}
	}

	public virtual string Location
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	[ComVisible(false)]
	public virtual string ImageRuntimeVersion
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual bool GlobalAssemblyCache
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	[ComVisible(false)]
	public virtual long HostContext
	{
		get
		{
			RuntimeAssembly runtimeAssembly = this as RuntimeAssembly;
			if (runtimeAssembly != null)
			{
				return runtimeAssembly.HostContext;
			}
			throw new NotImplementedException();
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsDynamic
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	public virtual event ModuleResolveEventHandler ModuleResolve
	{
		[SecurityCritical]
		add
		{
			throw new NotImplementedException();
		}
		[SecurityCritical]
		remove
		{
			throw new NotImplementedException();
		}
	}

	public static string CreateQualifiedName(string assemblyName, string typeName)
	{
		return typeName + ", " + assemblyName;
	}

	public static Assembly GetAssembly(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		Module module = type.Module;
		if (module == null)
		{
			return null;
		}
		return module.Assembly;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(Assembly left, Assembly right)
	{
		if ((object)left == right)
		{
			return true;
		}
		if ((object)left == null || (object)right == null || left is RuntimeAssembly || right is RuntimeAssembly)
		{
			return false;
		}
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(Assembly left, Assembly right)
	{
		return !(left == right);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object o)
	{
		return base.Equals(o);
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Assembly LoadFrom(string assemblyFile)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadFrom(assemblyFile, null, null, AssemblyHashAlgorithm.None, forIntrospection: false, suppressSecurityChecks: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Assembly ReflectionOnlyLoadFrom(string assemblyFile)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadFrom(assemblyFile, null, null, AssemblyHashAlgorithm.None, forIntrospection: true, suppressSecurityChecks: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of LoadFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadFrom(assemblyFile, securityEvidence, null, AssemblyHashAlgorithm.None, forIntrospection: false, suppressSecurityChecks: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of LoadFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadFrom(assemblyFile, securityEvidence, hashValue, hashAlgorithm, forIntrospection: false, suppressSecurityChecks: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Assembly LoadFrom(string assemblyFile, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadFrom(assemblyFile, null, hashValue, hashAlgorithm, forIntrospection: false, suppressSecurityChecks: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public static Assembly UnsafeLoadFrom(string assemblyFile)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadFrom(assemblyFile, null, null, AssemblyHashAlgorithm.None, forIntrospection: false, suppressSecurityChecks: true, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static Assembly Load(string assemblyString)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoad(assemblyString, null, ref stackMark, forIntrospection: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	internal static Type GetType_Compat(string assemblyString, string typeName)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		RuntimeAssembly assemblyFromResolveEvent;
		AssemblyName assemblyName = RuntimeAssembly.CreateAssemblyName(assemblyString, forIntrospection: false, out assemblyFromResolveEvent);
		if (assemblyFromResolveEvent == null)
		{
			if (assemblyName.ContentType == AssemblyContentType.WindowsRuntime)
			{
				return Type.GetType(typeName + ", " + assemblyString, throwOnError: true, ignoreCase: false);
			}
			assemblyFromResolveEvent = RuntimeAssembly.InternalLoadAssemblyName(assemblyName, null, null, ref stackMark, throwOnFileNotFound: true, forIntrospection: false, suppressSecurityChecks: false);
		}
		return assemblyFromResolveEvent.GetType(typeName, throwOnError: true, ignoreCase: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Assembly ReflectionOnlyLoad(string assemblyString)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoad(assemblyString, null, ref stackMark, forIntrospection: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static Assembly Load(string assemblyString, Evidence assemblySecurity)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoad(assemblyString, assemblySecurity, ref stackMark, forIntrospection: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static Assembly Load(AssemblyName assemblyRef)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadAssemblyName(assemblyRef, null, null, ref stackMark, throwOnFileNotFound: true, forIntrospection: false, suppressSecurityChecks: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.InternalLoadAssemblyName(assemblyRef, assemblySecurity, null, ref stackMark, throwOnFileNotFound: true, forIntrospection: false, suppressSecurityChecks: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.LoadWithPartialNameInternal(partialName, null, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.LoadWithPartialNameInternal(partialName, securityEvidence, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Assembly Load(byte[] rawAssembly)
	{
		AppDomain.CheckLoadByteArraySupported();
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.nLoadImage(rawAssembly, null, null, ref stackMark, fIntrospection: false, fSkipIntegrityCheck: false, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Assembly ReflectionOnlyLoad(byte[] rawAssembly)
	{
		AppDomain.CheckReflectionOnlyLoadSupported();
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.nLoadImage(rawAssembly, null, null, ref stackMark, fIntrospection: true, fSkipIntegrityCheck: false, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore)
	{
		AppDomain.CheckLoadByteArraySupported();
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.nLoadImage(rawAssembly, rawSymbolStore, null, ref stackMark, fIntrospection: false, fSkipIntegrityCheck: false, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, SecurityContextSource securityContextSource)
	{
		AppDomain.CheckLoadByteArraySupported();
		if (securityContextSource < SecurityContextSource.CurrentAppDomain || securityContextSource > SecurityContextSource.CurrentAssembly)
		{
			throw new ArgumentOutOfRangeException("securityContextSource");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.nLoadImage(rawAssembly, rawSymbolStore, null, ref stackMark, fIntrospection: false, fSkipIntegrityCheck: false, securityContextSource);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	internal static Assembly LoadImageSkipIntegrityCheck(byte[] rawAssembly, byte[] rawSymbolStore, SecurityContextSource securityContextSource)
	{
		AppDomain.CheckLoadByteArraySupported();
		if (securityContextSource < SecurityContextSource.CurrentAppDomain || securityContextSource > SecurityContextSource.CurrentAssembly)
		{
			throw new ArgumentOutOfRangeException("securityContextSource");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.nLoadImage(rawAssembly, rawSymbolStore, null, ref stackMark, fIntrospection: false, fSkipIntegrityCheck: true, securityContextSource);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of Load which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlEvidence)]
	public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence)
	{
		AppDomain.CheckLoadByteArraySupported();
		if (securityEvidence != null && !AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			Zone hostEvidence = securityEvidence.GetHostEvidence<Zone>();
			if (hostEvidence == null || hostEvidence.SecurityZone != SecurityZone.MyComputer)
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
			}
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.nLoadImage(rawAssembly, rawSymbolStore, securityEvidence, ref stackMark, fIntrospection: false, fSkipIntegrityCheck: false, SecurityContextSource.CurrentAssembly);
	}

	[SecuritySafeCritical]
	public static Assembly LoadFile(string path)
	{
		AppDomain.CheckLoadFileSupported();
		new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, path).Demand();
		return RuntimeAssembly.nLoadFile(path, null);
	}

	[SecuritySafeCritical]
	[Obsolete("This method is obsolete and will be removed in a future release of the .NET Framework. Please use an overload of LoadFile which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlEvidence)]
	public static Assembly LoadFile(string path, Evidence securityEvidence)
	{
		AppDomain.CheckLoadFileSupported();
		if (securityEvidence != null && !AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyImplicit"));
		}
		new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, path).Demand();
		return RuntimeAssembly.nLoadFile(path, securityEvidence);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static Assembly GetExecutingAssembly()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return RuntimeAssembly.GetExecutingAssembly(ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static Assembly GetCallingAssembly()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCallersCaller;
		return RuntimeAssembly.GetExecutingAssembly(ref stackMark);
	}

	[SecuritySafeCritical]
	public static Assembly GetEntryAssembly()
	{
		AppDomainManager appDomainManager = AppDomain.CurrentDomain.DomainManager;
		if (appDomainManager == null)
		{
			appDomainManager = new AppDomainManager();
		}
		return appDomainManager.EntryAssembly;
	}

	[__DynamicallyInvokable]
	public virtual AssemblyName GetName()
	{
		return GetName(copiedName: false);
	}

	public virtual AssemblyName GetName(bool copiedName)
	{
		throw new NotImplementedException();
	}

	Type _Assembly.GetType()
	{
		return GetType();
	}

	[__DynamicallyInvokable]
	public virtual Type GetType(string name)
	{
		return GetType(name, throwOnError: false, ignoreCase: false);
	}

	[__DynamicallyInvokable]
	public virtual Type GetType(string name, bool throwOnError)
	{
		return GetType(name, throwOnError, ignoreCase: false);
	}

	[__DynamicallyInvokable]
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public virtual Type[] GetExportedTypes()
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public virtual Type[] GetTypes()
	{
		Module[] modules = GetModules(getResourceModules: false);
		int num = modules.Length;
		int num2 = 0;
		Type[][] array = new Type[num][];
		for (int i = 0; i < num; i++)
		{
			array[i] = modules[i].GetTypes();
			num2 += array[i].Length;
		}
		int num3 = 0;
		Type[] array2 = new Type[num2];
		for (int j = 0; j < num; j++)
		{
			int num4 = array[j].Length;
			Array.Copy(array[j], 0, array2, num3, num4);
			num3 += num4;
		}
		return array2;
	}

	[__DynamicallyInvokable]
	public virtual Stream GetManifestResourceStream(Type type, string name)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public virtual Stream GetManifestResourceStream(string name)
	{
		throw new NotImplementedException();
	}

	public virtual Assembly GetSatelliteAssembly(CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public virtual Assembly GetSatelliteAssembly(CultureInfo culture, Version version)
	{
		throw new NotImplementedException();
	}

	[SecurityCritical]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public virtual object[] GetCustomAttributes(bool inherit)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public virtual bool IsDefined(Type attributeType, bool inherit)
	{
		throw new NotImplementedException();
	}

	public virtual IList<CustomAttributeData> GetCustomAttributesData()
	{
		throw new NotImplementedException();
	}

	public Module LoadModule(string moduleName, byte[] rawModule)
	{
		return LoadModule(moduleName, rawModule, null);
	}

	public virtual Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore)
	{
		throw new NotImplementedException();
	}

	public object CreateInstance(string typeName)
	{
		return CreateInstance(typeName, ignoreCase: false, BindingFlags.Instance | BindingFlags.Public, null, null, null, null);
	}

	public object CreateInstance(string typeName, bool ignoreCase)
	{
		return CreateInstance(typeName, ignoreCase, BindingFlags.Instance | BindingFlags.Public, null, null, null, null);
	}

	public virtual object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
	{
		Type type = GetType(typeName, throwOnError: false, ignoreCase);
		if (type == null)
		{
			return null;
		}
		return Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);
	}

	public Module[] GetLoadedModules()
	{
		return GetLoadedModules(getResourceModules: false);
	}

	public virtual Module[] GetLoadedModules(bool getResourceModules)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public Module[] GetModules()
	{
		return GetModules(getResourceModules: false);
	}

	public virtual Module[] GetModules(bool getResourceModules)
	{
		throw new NotImplementedException();
	}

	public virtual Module GetModule(string name)
	{
		throw new NotImplementedException();
	}

	public virtual FileStream GetFile(string name)
	{
		throw new NotImplementedException();
	}

	public virtual FileStream[] GetFiles()
	{
		return GetFiles(getResourceModules: false);
	}

	public virtual FileStream[] GetFiles(bool getResourceModules)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public virtual string[] GetManifestResourceNames()
	{
		throw new NotImplementedException();
	}

	public virtual AssemblyName[] GetReferencedAssemblies()
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
	{
		throw new NotImplementedException();
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		string fullName = FullName;
		if (fullName == null)
		{
			return base.ToString();
		}
		return fullName;
	}
}
