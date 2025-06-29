using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_AssemblyBuilder))]
[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class AssemblyBuilder : Assembly, _AssemblyBuilder
{
	private class AssemblyBuilderLock
	{
	}

	internal AssemblyBuilderData m_assemblyData;

	private InternalAssemblyBuilder m_internalAssemblyBuilder;

	private ModuleBuilder m_manifestModuleBuilder;

	private bool m_fManifestModuleUsedAsDefinedModule;

	internal const string MANIFEST_MODULE_NAME = "RefEmit_InMemoryManifestModule";

	private ModuleBuilder m_onDiskAssemblyModuleBuilder;

	private bool m_profileAPICheck;

	internal object SyncRoot => InternalAssembly.SyncRoot;

	internal InternalAssemblyBuilder InternalAssembly => m_internalAssemblyBuilder;

	internal bool ProfileAPICheck => m_profileAPICheck;

	public override string Location => InternalAssembly.Location;

	public override string ImageRuntimeVersion => InternalAssembly.ImageRuntimeVersion;

	public override string CodeBase => InternalAssembly.CodeBase;

	public override MethodInfo EntryPoint => m_assemblyData.m_entryPointMethod;

	public override string FullName => InternalAssembly.FullName;

	public override Evidence Evidence => InternalAssembly.Evidence;

	public override PermissionSet PermissionSet
	{
		[SecurityCritical]
		get
		{
			return InternalAssembly.PermissionSet;
		}
	}

	public override SecurityRuleSet SecurityRuleSet => InternalAssembly.SecurityRuleSet;

	public override Module ManifestModule => m_manifestModuleBuilder.InternalModule;

	public override bool ReflectionOnly => InternalAssembly.ReflectionOnly;

	public override bool GlobalAssemblyCache => InternalAssembly.GlobalAssemblyCache;

	public override long HostContext => InternalAssembly.HostContext;

	public override bool IsDynamic => true;

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern RuntimeModule GetInMemoryAssemblyModule(RuntimeAssembly assembly);

	[SecurityCritical]
	private Module nGetInMemoryAssemblyModule()
	{
		return GetInMemoryAssemblyModule(GetNativeHandle());
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern RuntimeModule GetOnDiskAssemblyModule(RuntimeAssembly assembly);

	[SecurityCritical]
	private ModuleBuilder GetOnDiskAssemblyModuleBuilder()
	{
		if (m_onDiskAssemblyModuleBuilder == null)
		{
			Module onDiskAssemblyModule = GetOnDiskAssemblyModule(InternalAssembly.GetNativeHandle());
			ModuleBuilder moduleBuilder = new ModuleBuilder(this, (InternalModuleBuilder)onDiskAssemblyModule);
			moduleBuilder.Init("RefEmit_OnDiskManifestModule", null, 0);
			m_onDiskAssemblyModuleBuilder = moduleBuilder;
		}
		return m_onDiskAssemblyModuleBuilder;
	}

	internal ModuleBuilder GetModuleBuilder(InternalModuleBuilder module)
	{
		lock (SyncRoot)
		{
			foreach (ModuleBuilder moduleBuilder in m_assemblyData.m_moduleBuilderList)
			{
				if (moduleBuilder.InternalModule == module)
				{
					return moduleBuilder;
				}
			}
			if (m_onDiskAssemblyModuleBuilder != null && m_onDiskAssemblyModuleBuilder.InternalModule == module)
			{
				return m_onDiskAssemblyModuleBuilder;
			}
			if (m_manifestModuleBuilder.InternalModule == module)
			{
				return m_manifestModuleBuilder;
			}
			throw new ArgumentException("module");
		}
	}

	internal RuntimeAssembly GetNativeHandle()
	{
		return InternalAssembly.GetNativeHandle();
	}

	[SecurityCritical]
	internal Version GetVersion()
	{
		return InternalAssembly.GetVersion();
	}

	[SecurityCritical]
	internal AssemblyBuilder(AppDomain domain, AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, ref StackCrawlMark stackMark, IEnumerable<CustomAttributeBuilder> unsafeAssemblyAttributes, SecurityContextSource securityContextSource)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (access != AssemblyBuilderAccess.Run && access != AssemblyBuilderAccess.Save && access != AssemblyBuilderAccess.RunAndSave && access != AssemblyBuilderAccess.ReflectionOnly && access != AssemblyBuilderAccess.RunAndCollect)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)access), "access");
		}
		if (securityContextSource < SecurityContextSource.CurrentAppDomain || securityContextSource > SecurityContextSource.CurrentAssembly)
		{
			throw new ArgumentOutOfRangeException("securityContextSource");
		}
		name = (AssemblyName)name.Clone();
		if (name.KeyPair != null)
		{
			name.SetPublicKey(name.KeyPair.PublicKey);
		}
		if (evidence != null)
		{
			new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
		}
		if (access == AssemblyBuilderAccess.RunAndCollect)
		{
			new PermissionSet(PermissionState.Unrestricted).Demand();
		}
		List<CustomAttributeBuilder> list = null;
		DynamicAssemblyFlags dynamicAssemblyFlags = DynamicAssemblyFlags.None;
		byte[] array = null;
		byte[] array2 = null;
		if (unsafeAssemblyAttributes != null)
		{
			list = new List<CustomAttributeBuilder>(unsafeAssemblyAttributes);
			foreach (CustomAttributeBuilder item in list)
			{
				if (item.m_con.DeclaringType == typeof(SecurityTransparentAttribute))
				{
					dynamicAssemblyFlags |= DynamicAssemblyFlags.Transparent;
				}
				else if (item.m_con.DeclaringType == typeof(SecurityCriticalAttribute))
				{
					SecurityCriticalScope securityCriticalScope = SecurityCriticalScope.Everything;
					if (item.m_constructorArgs != null && item.m_constructorArgs.Length == 1 && item.m_constructorArgs[0] is SecurityCriticalScope)
					{
						securityCriticalScope = (SecurityCriticalScope)item.m_constructorArgs[0];
					}
					dynamicAssemblyFlags |= DynamicAssemblyFlags.Critical;
					if (securityCriticalScope == SecurityCriticalScope.Everything)
					{
						dynamicAssemblyFlags |= DynamicAssemblyFlags.AllCritical;
					}
				}
				else if (item.m_con.DeclaringType == typeof(SecurityRulesAttribute))
				{
					array = new byte[item.m_blob.Length];
					Array.Copy(item.m_blob, array, array.Length);
				}
				else if (item.m_con.DeclaringType == typeof(SecurityTreatAsSafeAttribute))
				{
					dynamicAssemblyFlags |= DynamicAssemblyFlags.TreatAsSafe;
				}
				else if (item.m_con.DeclaringType == typeof(AllowPartiallyTrustedCallersAttribute))
				{
					dynamicAssemblyFlags |= DynamicAssemblyFlags.Aptca;
					array2 = new byte[item.m_blob.Length];
					Array.Copy(item.m_blob, array2, array2.Length);
				}
			}
		}
		m_internalAssemblyBuilder = (InternalAssemblyBuilder)nCreateDynamicAssembly(domain, name, evidence, ref stackMark, requiredPermissions, optionalPermissions, refusedPermissions, array, array2, access, dynamicAssemblyFlags, securityContextSource);
		m_assemblyData = new AssemblyBuilderData(m_internalAssemblyBuilder, name.Name, access, dir);
		m_assemblyData.AddPermissionRequests(requiredPermissions, optionalPermissions, refusedPermissions);
		if (AppDomain.ProfileAPICheck)
		{
			RuntimeAssembly executingAssembly = RuntimeAssembly.GetExecutingAssembly(ref stackMark);
			if (executingAssembly != null && !executingAssembly.IsFrameworkAssembly())
			{
				m_profileAPICheck = true;
			}
		}
		InitManifestModule();
		if (list == null)
		{
			return;
		}
		foreach (CustomAttributeBuilder item2 in list)
		{
			SetCustomAttribute(item2);
		}
	}

	[SecurityCritical]
	private void InitManifestModule()
	{
		InternalModuleBuilder internalModuleBuilder = (InternalModuleBuilder)nGetInMemoryAssemblyModule();
		m_manifestModuleBuilder = new ModuleBuilder(this, internalModuleBuilder);
		m_manifestModuleBuilder.Init("RefEmit_InMemoryManifestModule", null, 0);
		m_fManifestModuleUsedAsDefinedModule = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, null, null, null, null, null, ref stackMark, null, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalDefineDynamicAssembly(name, access, null, null, null, null, null, ref stackMark, assemblyAttributes, SecurityContextSource.CurrentAssembly);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern Assembly nCreateDynamicAssembly(AppDomain domain, AssemblyName name, Evidence identity, ref StackCrawlMark stackMark, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, byte[] securityRulesBlob, byte[] aptcaBlob, AssemblyBuilderAccess access, DynamicAssemblyFlags flags, SecurityContextSource securityContextSource);

	[SecurityCritical]
	internal static AssemblyBuilder InternalDefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, ref StackCrawlMark stackMark, IEnumerable<CustomAttributeBuilder> unsafeAssemblyAttributes, SecurityContextSource securityContextSource)
	{
		if (evidence != null && !AppDomain.CurrentDomain.IsLegacyCasPolicyEnabled)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_RequiresCasPolicyExplicit"));
		}
		lock (typeof(AssemblyBuilderLock))
		{
			return new AssemblyBuilder(AppDomain.CurrentDomain, name, access, dir, evidence, requiredPermissions, optionalPermissions, refusedPermissions, ref stackMark, unsafeAssemblyAttributes, securityContextSource);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public ModuleBuilder DefineDynamicModule(string name)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return DefineDynamicModuleInternal(name, emitSymbolInfo: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public ModuleBuilder DefineDynamicModule(string name, bool emitSymbolInfo)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return DefineDynamicModuleInternal(name, emitSymbolInfo, ref stackMark);
	}

	[SecurityCritical]
	private ModuleBuilder DefineDynamicModuleInternal(string name, bool emitSymbolInfo, ref StackCrawlMark stackMark)
	{
		lock (SyncRoot)
		{
			return DefineDynamicModuleInternalNoLock(name, emitSymbolInfo, ref stackMark);
		}
	}

	[SecurityCritical]
	private ModuleBuilder DefineDynamicModuleInternalNoLock(string name, bool emitSymbolInfo, ref StackCrawlMark stackMark)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (name[0] == '\0')
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidName"), "name");
		}
		ISymbolWriter symbolWriter = null;
		IntPtr pInternalSymWriter = default(IntPtr);
		m_assemblyData.CheckNameConflict(name);
		ModuleBuilder moduleBuilder;
		if (m_fManifestModuleUsedAsDefinedModule)
		{
			int tkFile;
			InternalModuleBuilder internalModuleBuilder = (InternalModuleBuilder)DefineDynamicModule(InternalAssembly, emitSymbolInfo, name, name, ref stackMark, ref pInternalSymWriter, fIsTransient: true, out tkFile);
			moduleBuilder = new ModuleBuilder(this, internalModuleBuilder);
			moduleBuilder.Init(name, null, tkFile);
		}
		else
		{
			m_manifestModuleBuilder.ModifyModuleName(name);
			moduleBuilder = m_manifestModuleBuilder;
			if (emitSymbolInfo)
			{
				pInternalSymWriter = ModuleBuilder.nCreateISymWriterForDynamicModule(moduleBuilder.InternalModule, name);
			}
		}
		if (emitSymbolInfo)
		{
			Assembly assembly = LoadISymWrapper();
			Type type = assembly.GetType("System.Diagnostics.SymbolStore.SymWriter", throwOnError: true, ignoreCase: false);
			if (type != null && !type.IsVisible)
			{
				type = null;
			}
			if (type == null)
			{
				throw new TypeLoadException(Environment.GetResourceString("MissingType", "SymWriter"));
			}
			new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
			try
			{
				new PermissionSet(PermissionState.Unrestricted).Assert();
				symbolWriter = (ISymbolWriter)Activator.CreateInstance(type);
				symbolWriter.SetUnderlyingWriter(pInternalSymWriter);
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
		}
		moduleBuilder.SetSymWriter(symbolWriter);
		m_assemblyData.AddModule(moduleBuilder);
		if (moduleBuilder == m_manifestModuleBuilder)
		{
			m_fManifestModuleUsedAsDefinedModule = true;
		}
		return moduleBuilder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public ModuleBuilder DefineDynamicModule(string name, string fileName)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return DefineDynamicModuleInternal(name, fileName, emitSymbolInfo: false, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public ModuleBuilder DefineDynamicModule(string name, string fileName, bool emitSymbolInfo)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return DefineDynamicModuleInternal(name, fileName, emitSymbolInfo, ref stackMark);
	}

	[SecurityCritical]
	private ModuleBuilder DefineDynamicModuleInternal(string name, string fileName, bool emitSymbolInfo, ref StackCrawlMark stackMark)
	{
		lock (SyncRoot)
		{
			return DefineDynamicModuleInternalNoLock(name, fileName, emitSymbolInfo, ref stackMark);
		}
	}

	[SecurityCritical]
	private ModuleBuilder DefineDynamicModuleInternalNoLock(string name, string fileName, bool emitSymbolInfo, ref StackCrawlMark stackMark)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		if (name[0] == '\0')
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidName"), "name");
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), "fileName");
		}
		if (!string.Equals(fileName, Path.GetFileName(fileName)))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotSimpleFileName"), "fileName");
		}
		if (m_assemblyData.m_access == AssemblyBuilderAccess.Run)
		{
			throw new NotSupportedException(Environment.GetResourceString("Argument_BadPersistableModuleInTransientAssembly"));
		}
		if (m_assemblyData.m_isSaved)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotAlterAssembly"));
		}
		ISymbolWriter symbolWriter = null;
		IntPtr pInternalSymWriter = default(IntPtr);
		m_assemblyData.CheckNameConflict(name);
		m_assemblyData.CheckFileNameConflict(fileName);
		int tkFile;
		InternalModuleBuilder internalModuleBuilder = (InternalModuleBuilder)DefineDynamicModule(InternalAssembly, emitSymbolInfo, name, fileName, ref stackMark, ref pInternalSymWriter, fIsTransient: false, out tkFile);
		ModuleBuilder moduleBuilder = new ModuleBuilder(this, internalModuleBuilder);
		moduleBuilder.Init(name, fileName, tkFile);
		if (emitSymbolInfo)
		{
			Assembly assembly = LoadISymWrapper();
			Type type = assembly.GetType("System.Diagnostics.SymbolStore.SymWriter", throwOnError: true, ignoreCase: false);
			if (type != null && !type.IsVisible)
			{
				type = null;
			}
			if (type == null)
			{
				throw new TypeLoadException(Environment.GetResourceString("MissingType", "SymWriter"));
			}
			try
			{
				new PermissionSet(PermissionState.Unrestricted).Assert();
				symbolWriter = (ISymbolWriter)Activator.CreateInstance(type);
				symbolWriter.SetUnderlyingWriter(pInternalSymWriter);
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
		}
		moduleBuilder.SetSymWriter(symbolWriter);
		m_assemblyData.AddModule(moduleBuilder);
		return moduleBuilder;
	}

	private Assembly LoadISymWrapper()
	{
		if (m_assemblyData.m_ISymWrapperAssembly != null)
		{
			return m_assemblyData.m_ISymWrapperAssembly;
		}
		Assembly assembly = Assembly.Load("ISymWrapper, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
		m_assemblyData.m_ISymWrapperAssembly = assembly;
		return assembly;
	}

	internal void CheckContext(params Type[][] typess)
	{
		if (typess == null)
		{
			return;
		}
		foreach (Type[] array in typess)
		{
			if (array != null)
			{
				CheckContext(array);
			}
		}
	}

	internal void CheckContext(params Type[] types)
	{
		if (types == null)
		{
			return;
		}
		foreach (Type type in types)
		{
			if (type == null)
			{
				continue;
			}
			if (type.Module == null || type.Module.Assembly == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_TypeNotValid"));
			}
			if (!(type.Module.Assembly == typeof(object).Module.Assembly))
			{
				if (type.Module.Assembly.ReflectionOnly && !ReflectionOnly)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Arugment_EmitMixedContext1", type.AssemblyQualifiedName));
				}
				if (!type.Module.Assembly.ReflectionOnly && ReflectionOnly)
				{
					throw new InvalidOperationException(Environment.GetResourceString("Arugment_EmitMixedContext2", type.AssemblyQualifiedName));
				}
			}
		}
	}

	public IResourceWriter DefineResource(string name, string description, string fileName)
	{
		return DefineResource(name, description, fileName, ResourceAttributes.Public);
	}

	public IResourceWriter DefineResource(string name, string description, string fileName, ResourceAttributes attribute)
	{
		lock (SyncRoot)
		{
			return DefineResourceNoLock(name, description, fileName, attribute);
		}
	}

	private IResourceWriter DefineResourceNoLock(string name, string description, string fileName, ResourceAttributes attribute)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), name);
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), "fileName");
		}
		if (!string.Equals(fileName, Path.GetFileName(fileName)))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotSimpleFileName"), "fileName");
		}
		m_assemblyData.CheckResNameConflict(name);
		m_assemblyData.CheckFileNameConflict(fileName);
		ResourceWriter resourceWriter;
		string text;
		if (m_assemblyData.m_strDir == null)
		{
			text = Path.Combine(Environment.CurrentDirectory, fileName);
			resourceWriter = new ResourceWriter(text);
		}
		else
		{
			text = Path.Combine(m_assemblyData.m_strDir, fileName);
			resourceWriter = new ResourceWriter(text);
		}
		text = Path.GetFullPath(text);
		fileName = Path.GetFileName(text);
		m_assemblyData.AddResWriter(new ResWriterData(resourceWriter, null, name, fileName, text, attribute));
		return resourceWriter;
	}

	public void AddResourceFile(string name, string fileName)
	{
		AddResourceFile(name, fileName, ResourceAttributes.Public);
	}

	public void AddResourceFile(string name, string fileName, ResourceAttributes attribute)
	{
		lock (SyncRoot)
		{
			AddResourceFileNoLock(name, fileName, attribute);
		}
	}

	[SecuritySafeCritical]
	private void AddResourceFileNoLock(string name, string fileName, ResourceAttributes attribute)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), name);
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), fileName);
		}
		if (!string.Equals(fileName, Path.GetFileName(fileName)))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotSimpleFileName"), "fileName");
		}
		m_assemblyData.CheckResNameConflict(name);
		m_assemblyData.CheckFileNameConflict(fileName);
		string path = ((m_assemblyData.m_strDir != null) ? Path.Combine(m_assemblyData.m_strDir, fileName) : Path.Combine(Environment.CurrentDirectory, fileName));
		path = Path.UnsafeGetFullPath(path);
		fileName = Path.GetFileName(path);
		if (!File.UnsafeExists(path))
		{
			throw new FileNotFoundException(Environment.GetResourceString("IO.FileNotFound_FileName", fileName), fileName);
		}
		m_assemblyData.AddResWriter(new ResWriterData(null, null, name, fileName, path, attribute));
	}

	public override bool Equals(object obj)
	{
		return InternalAssembly.Equals(obj);
	}

	public override int GetHashCode()
	{
		return InternalAssembly.GetHashCode();
	}

	public override object[] GetCustomAttributes(bool inherit)
	{
		return InternalAssembly.GetCustomAttributes(inherit);
	}

	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return InternalAssembly.GetCustomAttributes(attributeType, inherit);
	}

	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return InternalAssembly.IsDefined(attributeType, inherit);
	}

	public override IList<CustomAttributeData> GetCustomAttributesData()
	{
		return InternalAssembly.GetCustomAttributesData();
	}

	public override string[] GetManifestResourceNames()
	{
		return InternalAssembly.GetManifestResourceNames();
	}

	public override FileStream GetFile(string name)
	{
		return InternalAssembly.GetFile(name);
	}

	public override FileStream[] GetFiles(bool getResourceModules)
	{
		return InternalAssembly.GetFiles(getResourceModules);
	}

	public override Stream GetManifestResourceStream(Type type, string name)
	{
		return InternalAssembly.GetManifestResourceStream(type, name);
	}

	public override Stream GetManifestResourceStream(string name)
	{
		return InternalAssembly.GetManifestResourceStream(name);
	}

	public override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
	{
		return InternalAssembly.GetManifestResourceInfo(resourceName);
	}

	public override Type[] GetExportedTypes()
	{
		return InternalAssembly.GetExportedTypes();
	}

	public override AssemblyName GetName(bool copiedName)
	{
		return InternalAssembly.GetName(copiedName);
	}

	public override Type GetType(string name, bool throwOnError, bool ignoreCase)
	{
		return InternalAssembly.GetType(name, throwOnError, ignoreCase);
	}

	public override Module GetModule(string name)
	{
		return InternalAssembly.GetModule(name);
	}

	public override AssemblyName[] GetReferencedAssemblies()
	{
		return InternalAssembly.GetReferencedAssemblies();
	}

	public override Module[] GetModules(bool getResourceModules)
	{
		return InternalAssembly.GetModules(getResourceModules);
	}

	public override Module[] GetLoadedModules(bool getResourceModules)
	{
		return InternalAssembly.GetLoadedModules(getResourceModules);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Assembly GetSatelliteAssembly(CultureInfo culture)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalAssembly.InternalGetSatelliteAssembly(culture, null, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Assembly GetSatelliteAssembly(CultureInfo culture, Version version)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return InternalAssembly.InternalGetSatelliteAssembly(culture, version, ref stackMark);
	}

	public void DefineVersionInfoResource(string product, string productVersion, string company, string copyright, string trademark)
	{
		lock (SyncRoot)
		{
			DefineVersionInfoResourceNoLock(product, productVersion, company, copyright, trademark);
		}
	}

	private void DefineVersionInfoResourceNoLock(string product, string productVersion, string company, string copyright, string trademark)
	{
		if (m_assemblyData.m_strResourceFileName != null || m_assemblyData.m_resourceBytes != null || m_assemblyData.m_nativeVersion != null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NativeResourceAlreadyDefined"));
		}
		m_assemblyData.m_nativeVersion = new NativeVersionInfo();
		m_assemblyData.m_nativeVersion.m_strCopyright = copyright;
		m_assemblyData.m_nativeVersion.m_strTrademark = trademark;
		m_assemblyData.m_nativeVersion.m_strCompany = company;
		m_assemblyData.m_nativeVersion.m_strProduct = product;
		m_assemblyData.m_nativeVersion.m_strProductVersion = productVersion;
		m_assemblyData.m_hasUnmanagedVersionInfo = true;
		m_assemblyData.m_OverrideUnmanagedVersionInfo = true;
	}

	public void DefineVersionInfoResource()
	{
		lock (SyncRoot)
		{
			DefineVersionInfoResourceNoLock();
		}
	}

	private void DefineVersionInfoResourceNoLock()
	{
		if (m_assemblyData.m_strResourceFileName != null || m_assemblyData.m_resourceBytes != null || m_assemblyData.m_nativeVersion != null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NativeResourceAlreadyDefined"));
		}
		m_assemblyData.m_hasUnmanagedVersionInfo = true;
		m_assemblyData.m_nativeVersion = new NativeVersionInfo();
	}

	public void DefineUnmanagedResource(byte[] resource)
	{
		if (resource == null)
		{
			throw new ArgumentNullException("resource");
		}
		lock (SyncRoot)
		{
			DefineUnmanagedResourceNoLock(resource);
		}
	}

	private void DefineUnmanagedResourceNoLock(byte[] resource)
	{
		if (m_assemblyData.m_strResourceFileName != null || m_assemblyData.m_resourceBytes != null || m_assemblyData.m_nativeVersion != null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NativeResourceAlreadyDefined"));
		}
		m_assemblyData.m_resourceBytes = new byte[resource.Length];
		Array.Copy(resource, m_assemblyData.m_resourceBytes, resource.Length);
	}

	[SecuritySafeCritical]
	public void DefineUnmanagedResource(string resourceFileName)
	{
		if (resourceFileName == null)
		{
			throw new ArgumentNullException("resourceFileName");
		}
		lock (SyncRoot)
		{
			DefineUnmanagedResourceNoLock(resourceFileName);
		}
	}

	[SecurityCritical]
	private void DefineUnmanagedResourceNoLock(string resourceFileName)
	{
		if (m_assemblyData.m_strResourceFileName != null || m_assemblyData.m_resourceBytes != null || m_assemblyData.m_nativeVersion != null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NativeResourceAlreadyDefined"));
		}
		string text;
		if (m_assemblyData.m_strDir == null)
		{
			text = Path.Combine(Environment.CurrentDirectory, resourceFileName);
		}
		else
		{
			text = Path.Combine(m_assemblyData.m_strDir, resourceFileName);
		}
		text = Path.GetFullPath(resourceFileName);
		new FileIOPermission(FileIOPermissionAccess.Read, text).Demand();
		if (!File.Exists(text))
		{
			throw new FileNotFoundException(Environment.GetResourceString("IO.FileNotFound_FileName", resourceFileName), resourceFileName);
		}
		m_assemblyData.m_strResourceFileName = text;
	}

	public ModuleBuilder GetDynamicModule(string name)
	{
		lock (SyncRoot)
		{
			return GetDynamicModuleNoLock(name);
		}
	}

	private ModuleBuilder GetDynamicModuleNoLock(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "name");
		}
		int count = m_assemblyData.m_moduleBuilderList.Count;
		for (int i = 0; i < count; i++)
		{
			ModuleBuilder moduleBuilder = m_assemblyData.m_moduleBuilderList[i];
			if (moduleBuilder.m_moduleData.m_strModuleName.Equals(name))
			{
				return moduleBuilder;
			}
		}
		return null;
	}

	public void SetEntryPoint(MethodInfo entryMethod)
	{
		SetEntryPoint(entryMethod, PEFileKinds.ConsoleApplication);
	}

	public void SetEntryPoint(MethodInfo entryMethod, PEFileKinds fileKind)
	{
		lock (SyncRoot)
		{
			SetEntryPointNoLock(entryMethod, fileKind);
		}
	}

	private void SetEntryPointNoLock(MethodInfo entryMethod, PEFileKinds fileKind)
	{
		if (entryMethod == null)
		{
			throw new ArgumentNullException("entryMethod");
		}
		Module module = entryMethod.Module;
		if (module == null || !InternalAssembly.Equals(module.Assembly))
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EntryMethodNotDefinedInAssembly"));
		}
		m_assemblyData.m_entryPointMethod = entryMethod;
		m_assemblyData.m_peFileKind = fileKind;
		ModuleBuilder moduleBuilder = module as ModuleBuilder;
		if (moduleBuilder != null)
		{
			m_assemblyData.m_entryPointModule = moduleBuilder;
		}
		else
		{
			m_assemblyData.m_entryPointModule = GetModuleBuilder((InternalModuleBuilder)module);
		}
		MethodToken methodToken = m_assemblyData.m_entryPointModule.GetMethodToken(entryMethod);
		m_assemblyData.m_entryPointModule.SetEntryPoint(methodToken);
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
	{
		if (con == null)
		{
			throw new ArgumentNullException("con");
		}
		if (binaryAttribute == null)
		{
			throw new ArgumentNullException("binaryAttribute");
		}
		lock (SyncRoot)
		{
			SetCustomAttributeNoLock(con, binaryAttribute);
		}
	}

	[SecurityCritical]
	private void SetCustomAttributeNoLock(ConstructorInfo con, byte[] binaryAttribute)
	{
		TypeBuilder.DefineCustomAttribute(m_manifestModuleBuilder, 536870913, m_manifestModuleBuilder.GetConstructorToken(con).Token, binaryAttribute, toDisk: false, typeof(DebuggableAttribute) == con.DeclaringType);
		if (m_assemblyData.m_access != AssemblyBuilderAccess.Run)
		{
			m_assemblyData.AddCustomAttribute(con, binaryAttribute);
		}
	}

	[SecuritySafeCritical]
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
	{
		if (customBuilder == null)
		{
			throw new ArgumentNullException("customBuilder");
		}
		lock (SyncRoot)
		{
			SetCustomAttributeNoLock(customBuilder);
		}
	}

	[SecurityCritical]
	private void SetCustomAttributeNoLock(CustomAttributeBuilder customBuilder)
	{
		customBuilder.CreateCustomAttribute(m_manifestModuleBuilder, 536870913);
		if (m_assemblyData.m_access != AssemblyBuilderAccess.Run)
		{
			m_assemblyData.AddCustomAttribute(customBuilder);
		}
	}

	public void Save(string assemblyFileName)
	{
		Save(assemblyFileName, PortableExecutableKinds.ILOnly, ImageFileMachine.I386);
	}

	[SecuritySafeCritical]
	public void Save(string assemblyFileName, PortableExecutableKinds portableExecutableKind, ImageFileMachine imageFileMachine)
	{
		lock (SyncRoot)
		{
			SaveNoLock(assemblyFileName, portableExecutableKind, imageFileMachine);
		}
	}

	[SecurityCritical]
	private void SaveNoLock(string assemblyFileName, PortableExecutableKinds portableExecutableKind, ImageFileMachine imageFileMachine)
	{
		if (assemblyFileName == null)
		{
			throw new ArgumentNullException("assemblyFileName");
		}
		if (assemblyFileName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), "assemblyFileName");
		}
		if (!string.Equals(assemblyFileName, Path.GetFileName(assemblyFileName)))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NotSimpleFileName"), "assemblyFileName");
		}
		int[] array = null;
		int[] array2 = null;
		string s = null;
		try
		{
			if (m_assemblyData.m_iCABuilder != 0)
			{
				array = new int[m_assemblyData.m_iCABuilder];
			}
			if (m_assemblyData.m_iCAs != 0)
			{
				array2 = new int[m_assemblyData.m_iCAs];
			}
			if (m_assemblyData.m_isSaved)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_AssemblyHasBeenSaved", InternalAssembly.GetSimpleName()));
			}
			if ((m_assemblyData.m_access & AssemblyBuilderAccess.Save) != AssemblyBuilderAccess.Save)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CantSaveTransientAssembly"));
			}
			ModuleBuilder moduleBuilder = m_assemblyData.FindModuleWithFileName(assemblyFileName);
			if (moduleBuilder != null)
			{
				m_onDiskAssemblyModuleBuilder = moduleBuilder;
				moduleBuilder.m_moduleData.FileToken = 0;
			}
			else
			{
				m_assemblyData.CheckFileNameConflict(assemblyFileName);
			}
			if (m_assemblyData.m_strDir == null)
			{
				m_assemblyData.m_strDir = Environment.CurrentDirectory;
			}
			else if (!Directory.Exists(m_assemblyData.m_strDir))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidDirectory", m_assemblyData.m_strDir));
			}
			assemblyFileName = Path.Combine(m_assemblyData.m_strDir, assemblyFileName);
			assemblyFileName = Path.GetFullPath(assemblyFileName);
			new FileIOPermission(FileIOPermissionAccess.Write | FileIOPermissionAccess.Append, assemblyFileName).Demand();
			if (moduleBuilder != null)
			{
				for (int i = 0; i < m_assemblyData.m_iCABuilder; i++)
				{
					array[i] = m_assemblyData.m_CABuilders[i].PrepareCreateCustomAttributeToDisk(moduleBuilder);
				}
				for (int i = 0; i < m_assemblyData.m_iCAs; i++)
				{
					array2[i] = moduleBuilder.InternalGetConstructorToken(m_assemblyData.m_CACons[i], usingRef: true).Token;
				}
				moduleBuilder.PreSave(assemblyFileName, portableExecutableKind, imageFileMachine);
			}
			RuntimeModule assemblyModule = ((moduleBuilder != null) ? moduleBuilder.ModuleHandle.GetRuntimeModule() : null);
			PrepareForSavingManifestToDisk(GetNativeHandle(), assemblyModule);
			ModuleBuilder onDiskAssemblyModuleBuilder = GetOnDiskAssemblyModuleBuilder();
			if (m_assemblyData.m_strResourceFileName != null)
			{
				onDiskAssemblyModuleBuilder.DefineUnmanagedResourceFileInternalNoLock(m_assemblyData.m_strResourceFileName);
			}
			else if (m_assemblyData.m_resourceBytes != null)
			{
				onDiskAssemblyModuleBuilder.DefineUnmanagedResourceInternalNoLock(m_assemblyData.m_resourceBytes);
			}
			else if (m_assemblyData.m_hasUnmanagedVersionInfo)
			{
				m_assemblyData.FillUnmanagedVersionInfo();
				string text = m_assemblyData.m_nativeVersion.m_strFileVersion;
				if (text == null)
				{
					text = GetVersion().ToString();
				}
				CreateVersionInfoResource(assemblyFileName, m_assemblyData.m_nativeVersion.m_strTitle, null, m_assemblyData.m_nativeVersion.m_strDescription, m_assemblyData.m_nativeVersion.m_strCopyright, m_assemblyData.m_nativeVersion.m_strTrademark, m_assemblyData.m_nativeVersion.m_strCompany, m_assemblyData.m_nativeVersion.m_strProduct, m_assemblyData.m_nativeVersion.m_strProductVersion, text, m_assemblyData.m_nativeVersion.m_lcid, m_assemblyData.m_peFileKind == PEFileKinds.Dll, JitHelpers.GetStringHandleOnStack(ref s));
				onDiskAssemblyModuleBuilder.DefineUnmanagedResourceFileInternalNoLock(s);
			}
			if (moduleBuilder == null)
			{
				for (int i = 0; i < m_assemblyData.m_iCABuilder; i++)
				{
					array[i] = m_assemblyData.m_CABuilders[i].PrepareCreateCustomAttributeToDisk(onDiskAssemblyModuleBuilder);
				}
				for (int i = 0; i < m_assemblyData.m_iCAs; i++)
				{
					array2[i] = onDiskAssemblyModuleBuilder.InternalGetConstructorToken(m_assemblyData.m_CACons[i], usingRef: true).Token;
				}
			}
			int count = m_assemblyData.m_moduleBuilderList.Count;
			for (int i = 0; i < count; i++)
			{
				ModuleBuilder moduleBuilder2 = m_assemblyData.m_moduleBuilderList[i];
				if (!moduleBuilder2.IsTransient() && moduleBuilder2 != moduleBuilder)
				{
					string text2 = moduleBuilder2.m_moduleData.m_strFileName;
					if (m_assemblyData.m_strDir != null)
					{
						text2 = Path.Combine(m_assemblyData.m_strDir, text2);
						text2 = Path.GetFullPath(text2);
					}
					new FileIOPermission(FileIOPermissionAccess.Write | FileIOPermissionAccess.Append, text2).Demand();
					moduleBuilder2.m_moduleData.FileToken = AddFile(GetNativeHandle(), moduleBuilder2.m_moduleData.m_strFileName);
					moduleBuilder2.PreSave(text2, portableExecutableKind, imageFileMachine);
					moduleBuilder2.Save(text2, isAssemblyFile: false, portableExecutableKind, imageFileMachine);
					SetFileHashValue(GetNativeHandle(), moduleBuilder2.m_moduleData.FileToken, text2);
				}
			}
			for (int i = 0; i < m_assemblyData.m_iPublicComTypeCount; i++)
			{
				Type type = m_assemblyData.m_publicComTypeList[i];
				if (type is RuntimeType)
				{
					InternalModuleBuilder module = (InternalModuleBuilder)type.Module;
					ModuleBuilder moduleBuilder3 = GetModuleBuilder(module);
					if (moduleBuilder3 != moduleBuilder)
					{
						DefineNestedComType(type, moduleBuilder3.m_moduleData.FileToken, type.MetadataToken);
					}
				}
				else
				{
					TypeBuilder typeBuilder = (TypeBuilder)type;
					ModuleBuilder moduleBuilder3 = typeBuilder.GetModuleBuilder();
					if (moduleBuilder3 != moduleBuilder)
					{
						DefineNestedComType(type, moduleBuilder3.m_moduleData.FileToken, typeBuilder.MetadataTokenInternal);
					}
				}
			}
			if (onDiskAssemblyModuleBuilder != m_manifestModuleBuilder)
			{
				for (int i = 0; i < m_assemblyData.m_iCABuilder; i++)
				{
					m_assemblyData.m_CABuilders[i].CreateCustomAttribute(onDiskAssemblyModuleBuilder, 536870913, array[i], toDisk: true);
				}
				for (int i = 0; i < m_assemblyData.m_iCAs; i++)
				{
					TypeBuilder.DefineCustomAttribute(onDiskAssemblyModuleBuilder, 536870913, array2[i], m_assemblyData.m_CABytes[i], toDisk: true, updateCompilerFlags: false);
				}
			}
			if (m_assemblyData.m_RequiredPset != null)
			{
				AddDeclarativeSecurity(m_assemblyData.m_RequiredPset, SecurityAction.RequestMinimum);
			}
			if (m_assemblyData.m_RefusedPset != null)
			{
				AddDeclarativeSecurity(m_assemblyData.m_RefusedPset, SecurityAction.RequestRefuse);
			}
			if (m_assemblyData.m_OptionalPset != null)
			{
				AddDeclarativeSecurity(m_assemblyData.m_OptionalPset, SecurityAction.RequestOptional);
			}
			count = m_assemblyData.m_resWriterList.Count;
			for (int i = 0; i < count; i++)
			{
				ResWriterData resWriterData = null;
				try
				{
					resWriterData = m_assemblyData.m_resWriterList[i];
					if (resWriterData.m_resWriter != null)
					{
						new FileIOPermission(FileIOPermissionAccess.Write | FileIOPermissionAccess.Append, resWriterData.m_strFullFileName).Demand();
					}
				}
				finally
				{
					if (resWriterData != null && resWriterData.m_resWriter != null)
					{
						resWriterData.m_resWriter.Close();
					}
				}
				AddStandAloneResource(GetNativeHandle(), resWriterData.m_strName, resWriterData.m_strFileName, resWriterData.m_strFullFileName, (int)resWriterData.m_attribute);
			}
			if (moduleBuilder == null)
			{
				onDiskAssemblyModuleBuilder.DefineNativeResource(portableExecutableKind, imageFileMachine);
				int entryPoint = ((m_assemblyData.m_entryPointModule != null) ? m_assemblyData.m_entryPointModule.m_moduleData.FileToken : 0);
				SaveManifestToDisk(GetNativeHandle(), assemblyFileName, entryPoint, (int)m_assemblyData.m_peFileKind, (int)portableExecutableKind, (int)imageFileMachine);
			}
			else
			{
				if (m_assemblyData.m_entryPointModule != null && m_assemblyData.m_entryPointModule != moduleBuilder)
				{
					moduleBuilder.SetEntryPoint(new MethodToken(m_assemblyData.m_entryPointModule.m_moduleData.FileToken));
				}
				moduleBuilder.Save(assemblyFileName, isAssemblyFile: true, portableExecutableKind, imageFileMachine);
			}
			m_assemblyData.m_isSaved = true;
		}
		finally
		{
			if (s != null)
			{
				File.Delete(s);
			}
		}
	}

	[SecurityCritical]
	private void AddDeclarativeSecurity(PermissionSet pset, SecurityAction action)
	{
		byte[] array = pset.EncodeXml();
		AddDeclarativeSecurity(GetNativeHandle(), action, array, array.Length);
	}

	internal bool IsPersistable()
	{
		if ((m_assemblyData.m_access & AssemblyBuilderAccess.Save) == AssemblyBuilderAccess.Save)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	private int DefineNestedComType(Type type, int tkResolutionScope, int tkTypeDef)
	{
		Type declaringType = type.DeclaringType;
		if (declaringType == null)
		{
			return AddExportedTypeOnDisk(GetNativeHandle(), type.FullName, tkResolutionScope, tkTypeDef, type.Attributes);
		}
		tkResolutionScope = DefineNestedComType(declaringType, tkResolutionScope, tkTypeDef);
		return AddExportedTypeOnDisk(GetNativeHandle(), type.Name, tkResolutionScope, tkTypeDef, type.Attributes);
	}

	[SecurityCritical]
	internal int DefineExportedTypeInMemory(Type type, int tkResolutionScope, int tkTypeDef)
	{
		Type declaringType = type.DeclaringType;
		if (declaringType == null)
		{
			return AddExportedTypeInMemory(GetNativeHandle(), type.FullName, tkResolutionScope, tkTypeDef, type.Attributes);
		}
		tkResolutionScope = DefineExportedTypeInMemory(declaringType, tkResolutionScope, tkTypeDef);
		return AddExportedTypeInMemory(GetNativeHandle(), type.Name, tkResolutionScope, tkTypeDef, type.Attributes);
	}

	private AssemblyBuilder()
	{
	}

	void _AssemblyBuilder.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _AssemblyBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _AssemblyBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _AssemblyBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void DefineDynamicModule(RuntimeAssembly containingAssembly, bool emitSymbolInfo, string name, string filename, StackCrawlMarkHandle stackMark, ref IntPtr pInternalSymWriter, ObjectHandleOnStack retModule, bool fIsTransient, out int tkFile);

	[SecurityCritical]
	private static Module DefineDynamicModule(RuntimeAssembly containingAssembly, bool emitSymbolInfo, string name, string filename, ref StackCrawlMark stackMark, ref IntPtr pInternalSymWriter, bool fIsTransient, out int tkFile)
	{
		RuntimeModule o = null;
		DefineDynamicModule(containingAssembly.GetNativeHandle(), emitSymbolInfo, name, filename, JitHelpers.GetStackCrawlMarkHandle(ref stackMark), ref pInternalSymWriter, JitHelpers.GetObjectHandleOnStack(ref o), fIsTransient, out tkFile);
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void PrepareForSavingManifestToDisk(RuntimeAssembly assembly, RuntimeModule assemblyModule);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SaveManifestToDisk(RuntimeAssembly assembly, string strFileName, int entryPoint, int fileKind, int portableExecutableKind, int ImageFileMachine);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int AddFile(RuntimeAssembly assembly, string strFileName);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void SetFileHashValue(RuntimeAssembly assembly, int tkFile, string strFullFileName);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int AddExportedTypeInMemory(RuntimeAssembly assembly, string strComTypeName, int tkAssemblyRef, int tkTypeDef, TypeAttributes flags);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int AddExportedTypeOnDisk(RuntimeAssembly assembly, string strComTypeName, int tkAssemblyRef, int tkTypeDef, TypeAttributes flags);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddStandAloneResource(RuntimeAssembly assembly, string strName, string strFileName, string strFullFileName, int attribute);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void AddDeclarativeSecurity(RuntimeAssembly assembly, SecurityAction action, byte[] blob, int length);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void CreateVersionInfoResource(string filename, string title, string iconFilename, string description, string copyright, string trademark, string company, string product, string productVersion, string fileVersion, int lcid, bool isDll, StringHandleOnStack retFileName);
}
