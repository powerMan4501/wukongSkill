using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using Microsoft.Win32;

namespace System.Runtime.InteropServices;

[Guid("475E398F-8AFA-43a7-A3BE-F4EF8D6787C9")]
[ClassInterface(ClassInterfaceType.None)]
[ComVisible(true)]
public class RegistrationServices : IRegistrationServices
{
	private const string strManagedCategoryGuid = "{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}";

	private const string strDocStringPrefix = "";

	private const string strManagedTypeThreadingModel = "Both";

	private const string strComponentCategorySubKey = "Component Categories";

	private const string strManagedCategoryDescription = ".NET Category";

	private const string strImplementedCategoriesSubKey = "Implemented Categories";

	private const string strMsCorEEFileName = "mscoree.dll";

	private const string strRecordRootName = "Record";

	private const string strClsIdRootName = "CLSID";

	private const string strTlbRootName = "TypeLib";

	private static Guid s_ManagedCategoryGuid = new Guid("{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}");

	[SecurityCritical]
	public virtual bool RegisterAssembly(Assembly assembly, AssemblyRegistrationFlags flags)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException("assembly");
		}
		if (assembly.ReflectionOnly)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_AsmLoadedForReflectionOnly"));
		}
		RuntimeAssembly runtimeAssembly = assembly as RuntimeAssembly;
		if (runtimeAssembly == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"));
		}
		string fullName = assembly.FullName;
		if (fullName == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NoAsmName"));
		}
		string text = null;
		if ((flags & AssemblyRegistrationFlags.SetCodeBase) != AssemblyRegistrationFlags.None)
		{
			text = runtimeAssembly.GetCodeBase(copiedName: false);
			if (text == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NoAsmCodeBase"));
			}
		}
		Type[] registrableTypesInAssembly = GetRegistrableTypesInAssembly(assembly);
		int num = registrableTypesInAssembly.Length;
		string strAsmVersion = runtimeAssembly.GetVersion().ToString();
		string imageRuntimeVersion = assembly.ImageRuntimeVersion;
		for (int i = 0; i < num; i++)
		{
			if (IsRegisteredAsValueType(registrableTypesInAssembly[i]))
			{
				RegisterValueType(registrableTypesInAssembly[i], fullName, strAsmVersion, text, imageRuntimeVersion);
			}
			else if (TypeRepresentsComType(registrableTypesInAssembly[i]))
			{
				RegisterComImportedType(registrableTypesInAssembly[i], fullName, strAsmVersion, text, imageRuntimeVersion);
			}
			else
			{
				RegisterManagedType(registrableTypesInAssembly[i], fullName, strAsmVersion, text, imageRuntimeVersion);
			}
			CallUserDefinedRegistrationMethod(registrableTypesInAssembly[i], bRegister: true);
		}
		object[] customAttributes = assembly.GetCustomAttributes(typeof(PrimaryInteropAssemblyAttribute), inherit: false);
		int num2 = customAttributes.Length;
		for (int j = 0; j < num2; j++)
		{
			RegisterPrimaryInteropAssembly(runtimeAssembly, text, (PrimaryInteropAssemblyAttribute)customAttributes[j]);
		}
		if (registrableTypesInAssembly.Length != 0 || num2 > 0)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	public virtual bool UnregisterAssembly(Assembly assembly)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException("assembly");
		}
		if (assembly.ReflectionOnly)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_AsmLoadedForReflectionOnly"));
		}
		RuntimeAssembly runtimeAssembly = assembly as RuntimeAssembly;
		if (runtimeAssembly == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"));
		}
		bool flag = true;
		Type[] registrableTypesInAssembly = GetRegistrableTypesInAssembly(assembly);
		int num = registrableTypesInAssembly.Length;
		string strAsmVersion = runtimeAssembly.GetVersion().ToString();
		for (int i = 0; i < num; i++)
		{
			CallUserDefinedRegistrationMethod(registrableTypesInAssembly[i], bRegister: false);
			if (IsRegisteredAsValueType(registrableTypesInAssembly[i]))
			{
				if (!UnregisterValueType(registrableTypesInAssembly[i], strAsmVersion))
				{
					flag = false;
				}
			}
			else if (TypeRepresentsComType(registrableTypesInAssembly[i]))
			{
				if (!UnregisterComImportedType(registrableTypesInAssembly[i], strAsmVersion))
				{
					flag = false;
				}
			}
			else if (!UnregisterManagedType(registrableTypesInAssembly[i], strAsmVersion))
			{
				flag = false;
			}
		}
		object[] customAttributes = assembly.GetCustomAttributes(typeof(PrimaryInteropAssemblyAttribute), inherit: false);
		int num2 = customAttributes.Length;
		if (flag)
		{
			for (int j = 0; j < num2; j++)
			{
				UnregisterPrimaryInteropAssembly(assembly, (PrimaryInteropAssemblyAttribute)customAttributes[j]);
			}
		}
		if (registrableTypesInAssembly.Length != 0 || num2 > 0)
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	public virtual Type[] GetRegistrableTypesInAssembly(Assembly assembly)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException("assembly");
		}
		if (!(assembly is RuntimeAssembly))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeAssembly"), "assembly");
		}
		Type[] exportedTypes = assembly.GetExportedTypes();
		int num = exportedTypes.Length;
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < num; i++)
		{
			Type type = exportedTypes[i];
			if (TypeRequiresRegistration(type))
			{
				arrayList.Add(type);
			}
		}
		Type[] array = new Type[arrayList.Count];
		arrayList.CopyTo(array);
		return array;
	}

	[SecurityCritical]
	public virtual string GetProgIdForType(Type type)
	{
		return Marshal.GenerateProgIdForType(type);
	}

	[SecurityCritical]
	public virtual void RegisterTypeForComClients(Type type, ref Guid g)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (type as RuntimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "type");
		}
		if (!TypeRequiresRegistration(type))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TypeMustBeComCreatable"), "type");
		}
		RegisterTypeForComClientsNative(type, ref g);
	}

	public virtual Guid GetManagedCategoryGuid()
	{
		return s_ManagedCategoryGuid;
	}

	[SecurityCritical]
	public virtual bool TypeRequiresRegistration(Type type)
	{
		return TypeRequiresRegistrationHelper(type);
	}

	[SecuritySafeCritical]
	public virtual bool TypeRepresentsComType(Type type)
	{
		if (!type.IsCOMObject)
		{
			return false;
		}
		if (type.IsImport)
		{
			return true;
		}
		Type baseComImportType = GetBaseComImportType(type);
		if (Marshal.GenerateGuidForType(type) == Marshal.GenerateGuidForType(baseComImportType))
		{
			return true;
		}
		return false;
	}

	[SecurityCritical]
	[ComVisible(false)]
	public virtual int RegisterTypeForComClients(Type type, RegistrationClassContext classContext, RegistrationConnectionType flags)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (type as RuntimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeType"), "type");
		}
		if (!TypeRequiresRegistration(type))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TypeMustBeComCreatable"), "type");
		}
		return RegisterTypeForComClientsExNative(type, classContext, flags);
	}

	[SecurityCritical]
	[ComVisible(false)]
	public virtual void UnregisterTypeForComClients(int cookie)
	{
		CoRevokeClassObject(cookie);
	}

	[SecurityCritical]
	internal static bool TypeRequiresRegistrationHelper(Type type)
	{
		if (!type.IsClass && !type.IsValueType)
		{
			return false;
		}
		if (type.IsAbstract)
		{
			return false;
		}
		if (!type.IsValueType && type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[0], null) == null)
		{
			return false;
		}
		return Marshal.IsTypeVisibleFromCom(type);
	}

	[SecurityCritical]
	private void RegisterValueType(Type type, string strAsmName, string strAsmVersion, string strAsmCodeBase, string strRuntimeVersion)
	{
		string subkey = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		using RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey("Record");
		using RegistryKey registryKey2 = registryKey.CreateSubKey(subkey);
		using RegistryKey registryKey3 = registryKey2.CreateSubKey(strAsmVersion);
		registryKey3.SetValue("Class", type.FullName);
		registryKey3.SetValue("Assembly", strAsmName);
		registryKey3.SetValue("RuntimeVersion", strRuntimeVersion);
		if (strAsmCodeBase != null)
		{
			registryKey3.SetValue("CodeBase", strAsmCodeBase);
		}
	}

	[SecurityCritical]
	private void RegisterManagedType(Type type, string strAsmName, string strAsmVersion, string strAsmCodeBase, string strRuntimeVersion)
	{
		string value = type.FullName ?? "";
		string text = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		string progIdForType = GetProgIdForType(type);
		if (progIdForType != string.Empty)
		{
			using RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(progIdForType);
			registryKey.SetValue("", value);
			using RegistryKey registryKey2 = registryKey.CreateSubKey("CLSID");
			registryKey2.SetValue("", text);
		}
		using (RegistryKey registryKey3 = Registry.ClassesRoot.CreateSubKey("CLSID"))
		{
			using RegistryKey registryKey4 = registryKey3.CreateSubKey(text);
			registryKey4.SetValue("", value);
			using (RegistryKey registryKey5 = registryKey4.CreateSubKey("InprocServer32"))
			{
				registryKey5.SetValue("", "mscoree.dll");
				registryKey5.SetValue("ThreadingModel", "Both");
				registryKey5.SetValue("Class", type.FullName);
				registryKey5.SetValue("Assembly", strAsmName);
				registryKey5.SetValue("RuntimeVersion", strRuntimeVersion);
				if (strAsmCodeBase != null)
				{
					registryKey5.SetValue("CodeBase", strAsmCodeBase);
				}
				using (RegistryKey registryKey6 = registryKey5.CreateSubKey(strAsmVersion))
				{
					registryKey6.SetValue("Class", type.FullName);
					registryKey6.SetValue("Assembly", strAsmName);
					registryKey6.SetValue("RuntimeVersion", strRuntimeVersion);
					if (strAsmCodeBase != null)
					{
						registryKey6.SetValue("CodeBase", strAsmCodeBase);
					}
				}
				if (progIdForType != string.Empty)
				{
					using RegistryKey registryKey7 = registryKey4.CreateSubKey("ProgId");
					registryKey7.SetValue("", progIdForType);
				}
			}
			using RegistryKey registryKey8 = registryKey4.CreateSubKey("Implemented Categories");
			using (registryKey8.CreateSubKey("{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}"))
			{
			}
		}
		EnsureManagedCategoryExists();
	}

	[SecurityCritical]
	private void RegisterComImportedType(Type type, string strAsmName, string strAsmVersion, string strAsmCodeBase, string strRuntimeVersion)
	{
		string subkey = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		using RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey("CLSID");
		using RegistryKey registryKey2 = registryKey.CreateSubKey(subkey);
		using RegistryKey registryKey3 = registryKey2.CreateSubKey("InprocServer32");
		registryKey3.SetValue("Class", type.FullName);
		registryKey3.SetValue("Assembly", strAsmName);
		registryKey3.SetValue("RuntimeVersion", strRuntimeVersion);
		if (strAsmCodeBase != null)
		{
			registryKey3.SetValue("CodeBase", strAsmCodeBase);
		}
		using RegistryKey registryKey4 = registryKey3.CreateSubKey(strAsmVersion);
		registryKey4.SetValue("Class", type.FullName);
		registryKey4.SetValue("Assembly", strAsmName);
		registryKey4.SetValue("RuntimeVersion", strRuntimeVersion);
		if (strAsmCodeBase != null)
		{
			registryKey4.SetValue("CodeBase", strAsmCodeBase);
		}
	}

	[SecurityCritical]
	private bool UnregisterValueType(Type type, string strAsmVersion)
	{
		bool result = true;
		string text = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("Record", writable: true))
		{
			if (registryKey != null)
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text, writable: true))
				{
					if (registryKey2 != null)
					{
						using (RegistryKey registryKey3 = registryKey2.OpenSubKey(strAsmVersion, writable: true))
						{
							if (registryKey3 != null)
							{
								registryKey3.DeleteValue("Assembly", throwOnMissingValue: false);
								registryKey3.DeleteValue("Class", throwOnMissingValue: false);
								registryKey3.DeleteValue("CodeBase", throwOnMissingValue: false);
								registryKey3.DeleteValue("RuntimeVersion", throwOnMissingValue: false);
								if (registryKey3.SubKeyCount == 0 && registryKey3.ValueCount == 0)
								{
									registryKey2.DeleteSubKey(strAsmVersion);
								}
							}
						}
						if (registryKey2.SubKeyCount != 0)
						{
							result = false;
						}
						if (registryKey2.SubKeyCount == 0 && registryKey2.ValueCount == 0)
						{
							registryKey.DeleteSubKey(text);
						}
					}
				}
				if (registryKey.SubKeyCount == 0 && registryKey.ValueCount == 0)
				{
					Registry.ClassesRoot.DeleteSubKey("Record");
				}
			}
		}
		return result;
	}

	[SecurityCritical]
	private bool UnregisterManagedType(Type type, string strAsmVersion)
	{
		bool flag = true;
		string text = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		string progIdForType = GetProgIdForType(type);
		using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("CLSID", writable: true))
		{
			if (registryKey != null)
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text, writable: true))
				{
					if (registryKey2 != null)
					{
						using (RegistryKey registryKey3 = registryKey2.OpenSubKey("InprocServer32", writable: true))
						{
							if (registryKey3 != null)
							{
								using (RegistryKey registryKey4 = registryKey3.OpenSubKey(strAsmVersion, writable: true))
								{
									if (registryKey4 != null)
									{
										registryKey4.DeleteValue("Assembly", throwOnMissingValue: false);
										registryKey4.DeleteValue("Class", throwOnMissingValue: false);
										registryKey4.DeleteValue("RuntimeVersion", throwOnMissingValue: false);
										registryKey4.DeleteValue("CodeBase", throwOnMissingValue: false);
										if (registryKey4.SubKeyCount == 0 && registryKey4.ValueCount == 0)
										{
											registryKey3.DeleteSubKey(strAsmVersion);
										}
									}
								}
								if (registryKey3.SubKeyCount != 0)
								{
									flag = false;
								}
								if (flag)
								{
									registryKey3.DeleteValue("", throwOnMissingValue: false);
									registryKey3.DeleteValue("ThreadingModel", throwOnMissingValue: false);
								}
								registryKey3.DeleteValue("Assembly", throwOnMissingValue: false);
								registryKey3.DeleteValue("Class", throwOnMissingValue: false);
								registryKey3.DeleteValue("RuntimeVersion", throwOnMissingValue: false);
								registryKey3.DeleteValue("CodeBase", throwOnMissingValue: false);
								if (registryKey3.SubKeyCount == 0 && registryKey3.ValueCount == 0)
								{
									registryKey2.DeleteSubKey("InprocServer32");
								}
							}
						}
						if (flag)
						{
							registryKey2.DeleteValue("", throwOnMissingValue: false);
							if (progIdForType != string.Empty)
							{
								using RegistryKey registryKey5 = registryKey2.OpenSubKey("ProgId", writable: true);
								if (registryKey5 != null)
								{
									registryKey5.DeleteValue("", throwOnMissingValue: false);
									if (registryKey5.SubKeyCount == 0 && registryKey5.ValueCount == 0)
									{
										registryKey2.DeleteSubKey("ProgId");
									}
								}
							}
							using RegistryKey registryKey6 = registryKey2.OpenSubKey("Implemented Categories", writable: true);
							if (registryKey6 != null)
							{
								using (RegistryKey registryKey7 = registryKey6.OpenSubKey("{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}", writable: true))
								{
									if (registryKey7 != null && registryKey7.SubKeyCount == 0 && registryKey7.ValueCount == 0)
									{
										registryKey6.DeleteSubKey("{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}");
									}
								}
								if (registryKey6.SubKeyCount == 0 && registryKey6.ValueCount == 0)
								{
									registryKey2.DeleteSubKey("Implemented Categories");
								}
							}
						}
						if (registryKey2.SubKeyCount == 0 && registryKey2.ValueCount == 0)
						{
							registryKey.DeleteSubKey(text);
						}
					}
				}
				if (registryKey.SubKeyCount == 0 && registryKey.ValueCount == 0)
				{
					Registry.ClassesRoot.DeleteSubKey("CLSID");
				}
			}
			if (flag && progIdForType != string.Empty)
			{
				using RegistryKey registryKey8 = Registry.ClassesRoot.OpenSubKey(progIdForType, writable: true);
				if (registryKey8 != null)
				{
					registryKey8.DeleteValue("", throwOnMissingValue: false);
					using (RegistryKey registryKey9 = registryKey8.OpenSubKey("CLSID", writable: true))
					{
						if (registryKey9 != null)
						{
							registryKey9.DeleteValue("", throwOnMissingValue: false);
							if (registryKey9.SubKeyCount == 0 && registryKey9.ValueCount == 0)
							{
								registryKey8.DeleteSubKey("CLSID");
							}
						}
					}
					if (registryKey8.SubKeyCount == 0 && registryKey8.ValueCount == 0)
					{
						Registry.ClassesRoot.DeleteSubKey(progIdForType);
					}
				}
			}
		}
		return flag;
	}

	[SecurityCritical]
	private bool UnregisterComImportedType(Type type, string strAsmVersion)
	{
		bool result = true;
		string text = "{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("CLSID", writable: true))
		{
			if (registryKey != null)
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text, writable: true))
				{
					if (registryKey2 != null)
					{
						using (RegistryKey registryKey3 = registryKey2.OpenSubKey("InprocServer32", writable: true))
						{
							if (registryKey3 != null)
							{
								registryKey3.DeleteValue("Assembly", throwOnMissingValue: false);
								registryKey3.DeleteValue("Class", throwOnMissingValue: false);
								registryKey3.DeleteValue("RuntimeVersion", throwOnMissingValue: false);
								registryKey3.DeleteValue("CodeBase", throwOnMissingValue: false);
								using (RegistryKey registryKey4 = registryKey3.OpenSubKey(strAsmVersion, writable: true))
								{
									if (registryKey4 != null)
									{
										registryKey4.DeleteValue("Assembly", throwOnMissingValue: false);
										registryKey4.DeleteValue("Class", throwOnMissingValue: false);
										registryKey4.DeleteValue("RuntimeVersion", throwOnMissingValue: false);
										registryKey4.DeleteValue("CodeBase", throwOnMissingValue: false);
										if (registryKey4.SubKeyCount == 0 && registryKey4.ValueCount == 0)
										{
											registryKey3.DeleteSubKey(strAsmVersion);
										}
									}
								}
								if (registryKey3.SubKeyCount != 0)
								{
									result = false;
								}
								if (registryKey3.SubKeyCount == 0 && registryKey3.ValueCount == 0)
								{
									registryKey2.DeleteSubKey("InprocServer32");
								}
							}
						}
						if (registryKey2.SubKeyCount == 0 && registryKey2.ValueCount == 0)
						{
							registryKey.DeleteSubKey(text);
						}
					}
				}
				if (registryKey.SubKeyCount == 0 && registryKey.ValueCount == 0)
				{
					Registry.ClassesRoot.DeleteSubKey("CLSID");
				}
			}
		}
		return result;
	}

	[SecurityCritical]
	private void RegisterPrimaryInteropAssembly(RuntimeAssembly assembly, string strAsmCodeBase, PrimaryInteropAssemblyAttribute attr)
	{
		if (assembly.GetPublicKey().Length == 0)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_PIAMustBeStrongNamed"));
		}
		string subkey = "{" + Marshal.GetTypeLibGuidForAssembly(assembly).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		string subkey2 = attr.MajorVersion.ToString("x", CultureInfo.InvariantCulture) + "." + attr.MinorVersion.ToString("x", CultureInfo.InvariantCulture);
		using RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey("TypeLib");
		using RegistryKey registryKey2 = registryKey.CreateSubKey(subkey);
		using RegistryKey registryKey3 = registryKey2.CreateSubKey(subkey2);
		registryKey3.SetValue("PrimaryInteropAssemblyName", assembly.FullName);
		if (strAsmCodeBase != null)
		{
			registryKey3.SetValue("PrimaryInteropAssemblyCodeBase", strAsmCodeBase);
		}
	}

	[SecurityCritical]
	private void UnregisterPrimaryInteropAssembly(Assembly assembly, PrimaryInteropAssemblyAttribute attr)
	{
		string text = "{" + Marshal.GetTypeLibGuidForAssembly(assembly).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
		string text2 = attr.MajorVersion.ToString("x", CultureInfo.InvariantCulture) + "." + attr.MinorVersion.ToString("x", CultureInfo.InvariantCulture);
		using RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("TypeLib", writable: true);
		if (registryKey == null)
		{
			return;
		}
		using (RegistryKey registryKey2 = registryKey.OpenSubKey(text, writable: true))
		{
			if (registryKey2 != null)
			{
				using (RegistryKey registryKey3 = registryKey2.OpenSubKey(text2, writable: true))
				{
					if (registryKey3 != null)
					{
						registryKey3.DeleteValue("PrimaryInteropAssemblyName", throwOnMissingValue: false);
						registryKey3.DeleteValue("PrimaryInteropAssemblyCodeBase", throwOnMissingValue: false);
						if (registryKey3.SubKeyCount == 0 && registryKey3.ValueCount == 0)
						{
							registryKey2.DeleteSubKey(text2);
						}
					}
				}
				if (registryKey2.SubKeyCount == 0 && registryKey2.ValueCount == 0)
				{
					registryKey.DeleteSubKey(text);
				}
			}
		}
		if (registryKey.SubKeyCount == 0 && registryKey.ValueCount == 0)
		{
			Registry.ClassesRoot.DeleteSubKey("TypeLib");
		}
	}

	private void EnsureManagedCategoryExists()
	{
		if (ManagedCategoryExists())
		{
			return;
		}
		using RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey("Component Categories");
		using RegistryKey registryKey2 = registryKey.CreateSubKey("{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}");
		registryKey2.SetValue("0", ".NET Category");
	}

	private static bool ManagedCategoryExists()
	{
		using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("Component Categories", RegistryKeyPermissionCheck.ReadSubTree))
		{
			if (registryKey == null)
			{
				return false;
			}
			using RegistryKey registryKey2 = registryKey.OpenSubKey("{62C8FE65-4EBB-45e7-B440-6E39B2CDBF29}", RegistryKeyPermissionCheck.ReadSubTree);
			if (registryKey2 == null)
			{
				return false;
			}
			object value = registryKey2.GetValue("0");
			if (value == null || value.GetType() != typeof(string))
			{
				return false;
			}
			string text = (string)value;
			if (text != ".NET Category")
			{
				return false;
			}
		}
		return true;
	}

	[SecurityCritical]
	private void CallUserDefinedRegistrationMethod(Type type, bool bRegister)
	{
		bool flag = false;
		Type type2 = null;
		type2 = ((!bRegister) ? typeof(ComUnregisterFunctionAttribute) : typeof(ComRegisterFunctionAttribute));
		Type type3 = type;
		while (!flag && type3 != null)
		{
			MethodInfo[] methods = type3.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			int num = methods.Length;
			for (int i = 0; i < num; i++)
			{
				MethodInfo methodInfo = methods[i];
				if (methodInfo.GetCustomAttributes(type2, inherit: true).Length == 0)
				{
					continue;
				}
				if (!methodInfo.IsStatic)
				{
					if (bRegister)
					{
						throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NonStaticComRegFunction", methodInfo.Name, type3.Name));
					}
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NonStaticComUnRegFunction", methodInfo.Name, type3.Name));
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				if (methodInfo.ReturnType != typeof(void) || parameters == null || parameters.Length != 1 || (parameters[0].ParameterType != typeof(string) && parameters[0].ParameterType != typeof(Type)))
				{
					if (bRegister)
					{
						throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InvalidComRegFunctionSig", methodInfo.Name, type3.Name));
					}
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_InvalidComUnRegFunctionSig", methodInfo.Name, type3.Name));
				}
				if (flag)
				{
					if (bRegister)
					{
						throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_MultipleComRegFunctions", type3.Name));
					}
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_MultipleComUnRegFunctions", type3.Name));
				}
				object[] array = new object[1];
				if (parameters[0].ParameterType == typeof(string))
				{
					array[0] = "HKEY_CLASSES_ROOT\\CLSID\\{" + Marshal.GenerateGuidForType(type).ToString().ToUpper(CultureInfo.InvariantCulture) + "}";
				}
				else
				{
					array[0] = type;
				}
				methodInfo.Invoke(null, array);
				flag = true;
			}
			type3 = type3.BaseType;
		}
	}

	private Type GetBaseComImportType(Type type)
	{
		while (type != null && !type.IsImport)
		{
			type = type.BaseType;
		}
		return type;
	}

	private bool IsRegisteredAsValueType(Type type)
	{
		if (!type.IsValueType)
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void RegisterTypeForComClientsNative(Type type, ref Guid g);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int RegisterTypeForComClientsExNative(Type t, RegistrationClassContext clsContext, RegistrationConnectionType flags);

	[DllImport("ole32.dll", CharSet = CharSet.Auto, PreserveSig = false)]
	private static extern void CoRevokeClassObject(int cookie);
}
