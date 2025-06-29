using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

public static class WindowsRuntimeMetadata
{
	[method: SecurityCritical]
	public static event EventHandler<NamespaceResolveEventArgs> ReflectionOnlyNamespaceResolve;

	[method: SecurityCritical]
	public static event EventHandler<DesignerNamespaceResolveEventArgs> DesignerNamespaceResolve;

	[SecurityCritical]
	public static IEnumerable<string> ResolveNamespace(string namespaceName, IEnumerable<string> packageGraphFilePaths)
	{
		return ResolveNamespace(namespaceName, null, packageGraphFilePaths);
	}

	[SecurityCritical]
	public static IEnumerable<string> ResolveNamespace(string namespaceName, string windowsSdkFilePath, IEnumerable<string> packageGraphFilePaths)
	{
		if (namespaceName == null)
		{
			throw new ArgumentNullException("namespaceName");
		}
		string[] array = null;
		if (packageGraphFilePaths != null)
		{
			List<string> list = new List<string>(packageGraphFilePaths);
			array = new string[list.Count];
			int num = 0;
			foreach (string item in list)
			{
				array[num] = item;
				num++;
			}
		}
		string[] o = null;
		nResolveNamespace(namespaceName, windowsSdkFilePath, array, (array != null) ? array.Length : 0, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void nResolveNamespace(string namespaceName, string windowsSdkFilePath, string[] packageGraphFilePaths, int cPackageGraphFilePaths, ObjectHandleOnStack retFileNames);

	internal static RuntimeAssembly[] OnReflectionOnlyNamespaceResolveEvent(AppDomain appDomain, RuntimeAssembly assembly, string namespaceName)
	{
		EventHandler<NamespaceResolveEventArgs> reflectionOnlyNamespaceResolve = WindowsRuntimeMetadata.ReflectionOnlyNamespaceResolve;
		if (reflectionOnlyNamespaceResolve != null)
		{
			Delegate[] invocationList = reflectionOnlyNamespaceResolve.GetInvocationList();
			int num = invocationList.Length;
			for (int i = 0; i < num; i++)
			{
				NamespaceResolveEventArgs e = new NamespaceResolveEventArgs(namespaceName, assembly);
				((EventHandler<NamespaceResolveEventArgs>)invocationList[i])(appDomain, e);
				Collection<Assembly> resolvedAssemblies = e.ResolvedAssemblies;
				if (resolvedAssemblies.Count <= 0)
				{
					continue;
				}
				RuntimeAssembly[] array = new RuntimeAssembly[resolvedAssemblies.Count];
				int num2 = 0;
				{
					foreach (Assembly item in resolvedAssemblies)
					{
						array[num2] = AppDomain.GetRuntimeAssembly(item);
						num2++;
					}
					return array;
				}
			}
		}
		return null;
	}

	internal static string[] OnDesignerNamespaceResolveEvent(AppDomain appDomain, string namespaceName)
	{
		EventHandler<DesignerNamespaceResolveEventArgs> designerNamespaceResolve = WindowsRuntimeMetadata.DesignerNamespaceResolve;
		if (designerNamespaceResolve != null)
		{
			Delegate[] invocationList = designerNamespaceResolve.GetInvocationList();
			int num = invocationList.Length;
			for (int i = 0; i < num; i++)
			{
				DesignerNamespaceResolveEventArgs e = new DesignerNamespaceResolveEventArgs(namespaceName);
				((EventHandler<DesignerNamespaceResolveEventArgs>)invocationList[i])(appDomain, e);
				Collection<string> resolvedAssemblyFiles = e.ResolvedAssemblyFiles;
				if (resolvedAssemblyFiles.Count <= 0)
				{
					continue;
				}
				string[] array = new string[resolvedAssemblyFiles.Count];
				int num2 = 0;
				{
					foreach (string item in resolvedAssemblyFiles)
					{
						if (string.IsNullOrEmpty(item))
						{
							throw new ArgumentException(Environment.GetResourceString("Arg_EmptyOrNullString"), "DesignerNamespaceResolveEventArgs.ResolvedAssemblyFiles");
						}
						array[num2] = item;
						num2++;
					}
					return array;
				}
			}
		}
		return null;
	}
}
