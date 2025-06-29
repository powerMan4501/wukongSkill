using System.Collections;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.TCEAdapterGen;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;

namespace System.Runtime.InteropServices;

[Guid("F1C3BF79-C3E4-11d3-88E7-00902754C43A")]
[ClassInterface(ClassInterfaceType.None)]
[ComVisible(true)]
public sealed class TypeLibConverter : ITypeLibConverter
{
	private class TypeResolveHandler : ITypeLibImporterNotifySink
	{
		private ModuleBuilder m_Module;

		private ITypeLibImporterNotifySink m_UserSink;

		private List<RuntimeAssembly> m_AsmList = new List<RuntimeAssembly>();

		public TypeResolveHandler(ModuleBuilder mod, ITypeLibImporterNotifySink userSink)
		{
			m_Module = mod;
			m_UserSink = userSink;
		}

		public void ReportEvent(ImporterEventKind eventKind, int eventCode, string eventMsg)
		{
			m_UserSink.ReportEvent(eventKind, eventCode, eventMsg);
		}

		public Assembly ResolveRef(object typeLib)
		{
			Assembly assembly = m_UserSink.ResolveRef(typeLib);
			if (assembly == null)
			{
				throw new ArgumentNullException();
			}
			RuntimeAssembly runtimeAssembly = assembly as RuntimeAssembly;
			if (runtimeAssembly == null)
			{
				AssemblyBuilder assemblyBuilder = assembly as AssemblyBuilder;
				if (assemblyBuilder != null)
				{
					runtimeAssembly = assemblyBuilder.InternalAssembly;
				}
			}
			if (runtimeAssembly == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"));
			}
			m_AsmList.Add(runtimeAssembly);
			return runtimeAssembly;
		}

		[SecurityCritical]
		public Assembly ResolveEvent(object sender, ResolveEventArgs args)
		{
			try
			{
				LoadInMemoryTypeByName(m_Module.GetNativeHandle(), args.Name);
				return m_Module.Assembly;
			}
			catch (TypeLoadException ex)
			{
				if (ex.ResourceId != -2146233054)
				{
					throw;
				}
			}
			foreach (RuntimeAssembly asm in m_AsmList)
			{
				try
				{
					asm.GetType(args.Name, throwOnError: true, ignoreCase: false);
					return asm;
				}
				catch (TypeLoadException ex2)
				{
					if (ex2._HResult != -2146233054)
					{
						throw;
					}
				}
			}
			return null;
		}

		public Assembly ResolveAsmEvent(object sender, ResolveEventArgs args)
		{
			foreach (RuntimeAssembly asm in m_AsmList)
			{
				if (string.Compare(asm.FullName, args.Name, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return asm;
				}
			}
			return null;
		}

		public Assembly ResolveROAsmEvent(object sender, ResolveEventArgs args)
		{
			foreach (RuntimeAssembly asm in m_AsmList)
			{
				if (string.Compare(asm.FullName, args.Name, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return asm;
				}
			}
			string assemblyString = AppDomain.CurrentDomain.ApplyPolicy(args.Name);
			return Assembly.ReflectionOnlyLoad(assemblyString);
		}
	}

	private const string s_strTypeLibAssemblyTitlePrefix = "TypeLib ";

	private const string s_strTypeLibAssemblyDescPrefix = "Assembly generated from typelib ";

	private const int MAX_NAMESPACE_LENGTH = 1024;

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public AssemblyBuilder ConvertTypeLibToAssembly([MarshalAs(UnmanagedType.Interface)] object typeLib, string asmFileName, int flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, bool unsafeInterfaces)
	{
		return ConvertTypeLibToAssembly(typeLib, asmFileName, unsafeInterfaces ? TypeLibImporterFlags.UnsafeInterfaces : TypeLibImporterFlags.None, notifySink, publicKey, keyPair, null, null);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public AssemblyBuilder ConvertTypeLibToAssembly([MarshalAs(UnmanagedType.Interface)] object typeLib, string asmFileName, TypeLibImporterFlags flags, ITypeLibImporterNotifySink notifySink, byte[] publicKey, StrongNameKeyPair keyPair, string asmNamespace, Version asmVersion)
	{
		if (typeLib == null)
		{
			throw new ArgumentNullException("typeLib");
		}
		if (asmFileName == null)
		{
			throw new ArgumentNullException("asmFileName");
		}
		if (notifySink == null)
		{
			throw new ArgumentNullException("notifySink");
		}
		if (string.Empty.Equals(asmFileName))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidFileName"), "asmFileName");
		}
		if (asmFileName.Length > 260)
		{
			throw new ArgumentException(Environment.GetResourceString("IO.PathTooLong"), asmFileName);
		}
		if ((flags & TypeLibImporterFlags.PrimaryInteropAssembly) != TypeLibImporterFlags.None && publicKey == null && keyPair == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_PIAMustBeStrongNamed"));
		}
		ArrayList eventItfInfoList = null;
		AssemblyNameFlags asmNameFlags = AssemblyNameFlags.None;
		AssemblyName assemblyNameFromTypelib = GetAssemblyNameFromTypelib(typeLib, asmFileName, publicKey, keyPair, asmVersion, asmNameFlags);
		AssemblyBuilder assemblyBuilder = CreateAssemblyForTypeLib(typeLib, asmFileName, assemblyNameFromTypelib, (flags & TypeLibImporterFlags.PrimaryInteropAssembly) != 0, (flags & TypeLibImporterFlags.ReflectionOnlyLoading) != 0, (flags & TypeLibImporterFlags.NoDefineVersionResource) != 0);
		string fileName = Path.GetFileName(asmFileName);
		ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(fileName, fileName);
		if (asmNamespace == null)
		{
			asmNamespace = assemblyNameFromTypelib.Name;
		}
		TypeResolveHandler typeResolveHandler = new TypeResolveHandler(moduleBuilder, notifySink);
		AppDomain domain = Thread.GetDomain();
		ResolveEventHandler value = typeResolveHandler.ResolveEvent;
		ResolveEventHandler value2 = typeResolveHandler.ResolveAsmEvent;
		ResolveEventHandler value3 = typeResolveHandler.ResolveROAsmEvent;
		domain.TypeResolve += value;
		domain.AssemblyResolve += value2;
		domain.ReflectionOnlyAssemblyResolve += value3;
		nConvertTypeLibToMetadata(typeLib, assemblyBuilder.InternalAssembly, moduleBuilder.InternalModule, asmNamespace, flags, typeResolveHandler, out eventItfInfoList);
		UpdateComTypesInAssembly(assemblyBuilder, moduleBuilder);
		if (eventItfInfoList.Count > 0)
		{
			new TCEAdapterGenerator().Process(moduleBuilder, eventItfInfoList);
		}
		domain.TypeResolve -= value;
		domain.AssemblyResolve -= value2;
		domain.ReflectionOnlyAssemblyResolve -= value3;
		return assemblyBuilder;
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public object ConvertAssemblyToTypeLib(Assembly assembly, string strTypeLibName, TypeLibExporterFlags flags, ITypeLibExporterNotifySink notifySink)
	{
		AssemblyBuilder assemblyBuilder = assembly as AssemblyBuilder;
		RuntimeAssembly assembly2 = ((!(assemblyBuilder != null)) ? (assembly as RuntimeAssembly) : assemblyBuilder.InternalAssembly);
		return nConvertAssemblyToTypeLib(assembly2, strTypeLibName, flags, notifySink);
	}

	public bool GetPrimaryInteropAssembly(Guid g, int major, int minor, int lcid, out string asmName, out string asmCodeBase)
	{
		string name = "{" + g.ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		string name2 = major.ToString("x", CultureInfo.InvariantCulture) + "." + minor.ToString("x", CultureInfo.InvariantCulture);
		asmName = null;
		asmCodeBase = null;
		using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("TypeLib", writable: false))
		{
			if (registryKey != null)
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey(name);
				if (registryKey2 != null)
				{
					using RegistryKey registryKey3 = registryKey2.OpenSubKey(name2, writable: false);
					if (registryKey3 != null)
					{
						asmName = (string)registryKey3.GetValue("PrimaryInteropAssemblyName");
						asmCodeBase = (string)registryKey3.GetValue("PrimaryInteropAssemblyCodeBase");
					}
				}
			}
		}
		return asmName != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	private static AssemblyBuilder CreateAssemblyForTypeLib(object typeLib, string asmFileName, AssemblyName asmName, bool bPrimaryInteropAssembly, bool bReflectionOnly, bool bNoDefineVersionResource)
	{
		AppDomain domain = Thread.GetDomain();
		string text = null;
		if (asmFileName != null)
		{
			text = Path.GetDirectoryName(asmFileName);
			if (string.IsNullOrEmpty(text))
			{
				text = null;
			}
		}
		AssemblyBuilderAccess access = ((!bReflectionOnly) ? AssemblyBuilderAccess.RunAndSave : AssemblyBuilderAccess.ReflectionOnly);
		List<CustomAttributeBuilder> list = new List<CustomAttributeBuilder>();
		ConstructorInfo constructor = typeof(SecurityRulesAttribute).GetConstructor(new Type[1] { typeof(SecurityRuleSet) });
		CustomAttributeBuilder item = new CustomAttributeBuilder(constructor, new object[1] { SecurityRuleSet.Level2 });
		list.Add(item);
		AssemblyBuilder assemblyBuilder = domain.DefineDynamicAssembly(asmName, access, text, isSynchronized: false, list);
		SetGuidAttributeOnAssembly(assemblyBuilder, typeLib);
		SetImportedFromTypeLibAttrOnAssembly(assemblyBuilder, typeLib);
		if (bNoDefineVersionResource)
		{
			SetTypeLibVersionAttribute(assemblyBuilder, typeLib);
		}
		else
		{
			SetVersionInformation(assemblyBuilder, typeLib, asmName);
		}
		if (bPrimaryInteropAssembly)
		{
			SetPIAAttributeOnAssembly(assemblyBuilder, typeLib);
		}
		return assemblyBuilder;
	}

	[SecurityCritical]
	internal static AssemblyName GetAssemblyNameFromTypelib(object typeLib, string asmFileName, byte[] publicKey, StrongNameKeyPair keyPair, Version asmVersion, AssemblyNameFlags asmNameFlags)
	{
		string strName = null;
		string strDocString = null;
		int dwHelpContext = 0;
		string strHelpFile = null;
		ITypeLib typeLib2 = (ITypeLib)typeLib;
		typeLib2.GetDocumentation(-1, out strName, out strDocString, out dwHelpContext, out strHelpFile);
		if (asmFileName == null)
		{
			asmFileName = strName;
		}
		else
		{
			string fileName = Path.GetFileName(asmFileName);
			string extension = Path.GetExtension(asmFileName);
			if (!".dll".Equals(extension, StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidFileExtension"));
			}
			asmFileName = fileName.Substring(0, fileName.Length - ".dll".Length);
		}
		if (asmVersion == null)
		{
			Marshal.GetTypeLibVersion(typeLib2, out var major, out var minor);
			asmVersion = new Version(major, minor, 0, 0);
		}
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.Init(asmFileName, publicKey, null, asmVersion, null, AssemblyHashAlgorithm.None, AssemblyVersionCompatibility.SameMachine, null, asmNameFlags, keyPair);
		return assemblyName;
	}

	private static void UpdateComTypesInAssembly(AssemblyBuilder asmBldr, ModuleBuilder modBldr)
	{
		AssemblyBuilderData assemblyData = asmBldr.m_assemblyData;
		Type[] types = modBldr.GetTypes();
		int num = types.Length;
		for (int i = 0; i < num; i++)
		{
			assemblyData.AddPublicComType(types[i]);
		}
	}

	[SecurityCritical]
	private static void SetGuidAttributeOnAssembly(AssemblyBuilder asmBldr, object typeLib)
	{
		Type[] types = new Type[1] { typeof(string) };
		ConstructorInfo constructor = typeof(GuidAttribute).GetConstructor(types);
		object[] constructorArgs = new object[1] { Marshal.GetTypeLibGuid((ITypeLib)typeLib).ToString() };
		CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, constructorArgs);
		asmBldr.SetCustomAttribute(customAttribute);
	}

	[SecurityCritical]
	private static void SetImportedFromTypeLibAttrOnAssembly(AssemblyBuilder asmBldr, object typeLib)
	{
		Type[] types = new Type[1] { typeof(string) };
		ConstructorInfo constructor = typeof(ImportedFromTypeLibAttribute).GetConstructor(types);
		string typeLibName = Marshal.GetTypeLibName((ITypeLib)typeLib);
		object[] constructorArgs = new object[1] { typeLibName };
		CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, constructorArgs);
		asmBldr.SetCustomAttribute(customAttribute);
	}

	[SecurityCritical]
	private static void SetTypeLibVersionAttribute(AssemblyBuilder asmBldr, object typeLib)
	{
		Type[] types = new Type[2]
		{
			typeof(int),
			typeof(int)
		};
		ConstructorInfo constructor = typeof(TypeLibVersionAttribute).GetConstructor(types);
		Marshal.GetTypeLibVersion((ITypeLib)typeLib, out var major, out var minor);
		object[] constructorArgs = new object[2] { major, minor };
		CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, constructorArgs);
		asmBldr.SetCustomAttribute(customAttribute);
	}

	[SecurityCritical]
	private static void SetVersionInformation(AssemblyBuilder asmBldr, object typeLib, AssemblyName asmName)
	{
		string strName = null;
		string strDocString = null;
		int dwHelpContext = 0;
		string strHelpFile = null;
		ITypeLib typeLib2 = (ITypeLib)typeLib;
		typeLib2.GetDocumentation(-1, out strName, out strDocString, out dwHelpContext, out strHelpFile);
		string product = string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("TypeLibConverter_ImportedTypeLibProductName"), strName);
		asmBldr.DefineVersionInfoResource(product, asmName.Version.ToString(), null, null, null);
		SetTypeLibVersionAttribute(asmBldr, typeLib);
	}

	[SecurityCritical]
	private static void SetPIAAttributeOnAssembly(AssemblyBuilder asmBldr, object typeLib)
	{
		IntPtr ppTLibAttr = IntPtr.Zero;
		ITypeLib typeLib2 = (ITypeLib)typeLib;
		int num = 0;
		int num2 = 0;
		Type[] types = new Type[2]
		{
			typeof(int),
			typeof(int)
		};
		ConstructorInfo constructor = typeof(PrimaryInteropAssemblyAttribute).GetConstructor(types);
		try
		{
			typeLib2.GetLibAttr(out ppTLibAttr);
			System.Runtime.InteropServices.ComTypes.TYPELIBATTR tYPELIBATTR = (System.Runtime.InteropServices.ComTypes.TYPELIBATTR)Marshal.PtrToStructure(ppTLibAttr, typeof(System.Runtime.InteropServices.ComTypes.TYPELIBATTR));
			num = tYPELIBATTR.wMajorVerNum;
			num2 = tYPELIBATTR.wMinorVerNum;
		}
		finally
		{
			if (ppTLibAttr != IntPtr.Zero)
			{
				typeLib2.ReleaseTLibAttr(ppTLibAttr);
			}
		}
		object[] constructorArgs = new object[2] { num, num2 };
		CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, constructorArgs);
		asmBldr.SetCustomAttribute(customAttribute);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void nConvertTypeLibToMetadata(object typeLib, RuntimeAssembly asmBldr, RuntimeModule modBldr, string nameSpace, TypeLibImporterFlags flags, ITypeLibImporterNotifySink notifySink, out ArrayList eventItfInfoList);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object nConvertAssemblyToTypeLib(RuntimeAssembly assembly, string strTypeLibName, TypeLibExporterFlags flags, ITypeLibExporterNotifySink notifySink);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void LoadInMemoryTypeByName(RuntimeModule module, string className);
}
