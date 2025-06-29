using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;
using UnrealEngine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ManagedReflectMgr")]
public class BGW_ManagedReflectMgr : BGW_ScriptMgr
{
	public interface IScriptAssemblyLoadContext
	{
		Assembly LoadFromStream(Stream assembly, Stream assemblySymbols);

		void Unload();
	}

	public static class ResolveEventHandlerClass
	{
		public static Assembly ResolveHandler(AssemblyName assemblyName)
		{
			string name = assemblyName.Name;
			name += ".dll";
			if (name == "UnrealBuildTool.dll")
			{
				name = "UnrealBuildTool.exe";
			}
			string text = Path.Combine(UnrealTypes.GameAssemblyDirectory, name);
			if (File.Exists(text))
			{
				return CurrentAssemblyContext.LoadFrom(text);
			}
			BGW_LogUtil.LogError("ResolveEventHandlerClass assemblyPath: " + text + " not find!!!");
			return null;
		}
	}

	public class SerralTestClass
	{
		private IEnumerable<Assembly> loadedAssemblies;

		private List<Assembly> loadedAssembliesList;

		public void ExecTestFuncs(IScriptAssemblyLoadContext TargetALC)
		{
			PropertyInfo property = ScriptGeneratedContextType.GetProperty("Assemblies");
			loadedAssemblies = (IEnumerable<Assembly>)property.GetValue(TargetALC);
			loadedAssembliesList = new List<Assembly>();
			foreach (Assembly loadedAssembly in loadedAssemblies)
			{
				loadedAssembliesList.Add(loadedAssembly);
			}
		}
	}

	private object[] params0 = new object[0];

	private object[] params1 = new object[1];

	private object[] params2 = new object[2];

	private object[] params3 = new object[3];

	private object[] params4 = new object[4];

	private object[] params5 = new object[5];

	private Dictionary<string, Assembly> _appdomain;

	private float DeltaTimeSkipLock;

	private bool GameAssemblyLoaded;

	private static List<IScriptAssemblyLoadContext> ScriptDllAssemblyLoadContextList;

	private static Type ScriptGeneratedContextType;

	public static BGW_ManagedReflectMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_ManagedReflectMgr>(WorldContext);
	}

	public override void OnInit()
	{
		InitManaged();
		(new object[1])[0] = BGWGameInstanceCS.Get(this);
		GameProcessInit(null, _appdomain);
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		StopManaged();
	}

	public MethodInfo FindMethodInfo(string TypeName, string MethodName, object[] paramList)
	{
		MethodInfo methodInfo = null;
		List<Type> list = new List<Type>();
		foreach (object obj in paramList)
		{
			list.Add(obj.GetType());
		}
		foreach (KeyValuePair<string, Assembly> item in _appdomain)
		{
			Type type = item.Value.GetType(TypeName);
			if (type != null)
			{
				methodInfo = type.GetMethod(MethodName, list.ToArray());
			}
			if (methodInfo != null)
			{
				break;
			}
		}
		return methodInfo;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (GameAssemblyLoaded)
		{
			DeltaTimeSkipLock += DeltaTime;
			params1[0] = DeltaTimeSkipLock;
			DeltaTimeSkipLock = 0f;
			GameProcessTick(null, _appdomain, params1);
		}
	}

	public static void LoadScriptAssemblyFile(Dictionary<string, Assembly> appdomain)
	{
		LoadAssemblyFile(appdomain, "B1UI_GSE.Script.dll");
	}

	public void LoadGameAssemblyFile()
	{
		LoadScriptAssemblyFile(_appdomain);
	}

	public void StartManaged()
	{
		if (_appdomain == null)
		{
			_appdomain = new Dictionary<string, Assembly>();
		}
	}

	private void InitManaged()
	{
		if (_appdomain == null)
		{
			StartManaged();
		}
		LoadGameAssemblyFile();
		GameAssemblyLoaded = true;
	}

	public static void LoadAssemblyFile(Dictionary<string, Assembly> appdomain, string dllName)
	{
		LoadAssemblyFileWithoutSymbol(appdomain, dllName);
	}

	public static void LoadAssemblyFileWithoutSymbol(Dictionary<string, Assembly> appdomain, string dllName)
	{
		string dllPathFull = BGW_ScriptMgr.GetDllPathFull(dllName);
		FileInfo fileInfo = new FileInfo(dllPathFull);
		if (!fileInfo.Exists && !SharedRuntimeState.IsAOT)
		{
			throw new FileNotFoundException($"Assembly File not find!:\r\n{dllPathFull}");
		}
		if (AssemblyContext.IsCLR)
		{
			appdomain.Add(dllName, Assembly.Load(dllName.Substring(0, dllName.Length - 4) + ", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			return;
		}
		if (!CurrentAssemblyContext.LoadFromAssmName(dllName.Substring(0, dllName.Length - 4) + ", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", out var Assem))
		{
			Assem = Assembly.LoadFile(fileInfo.FullName);
		}
		GSEUtil.Ensure(Assem != null, "Load Script Dll Failed!!! dllName:" + dllName + " FullName:" + fileInfo.FullName);
		appdomain.Add(dllName, Assem);
	}

	public static void LoadAssemblyFileWithSymbol(Dictionary<string, Assembly> appdomain, string dllName)
	{
		string dllPathFull = BGW_ScriptMgr.GetDllPathFull(dllName);
		FileInfo fileInfo = new FileInfo(dllPathFull);
		if (!fileInfo.Exists && !SharedRuntimeState.IsAOT)
		{
			throw new FileNotFoundException($"Assembly File not find!:\r\n{dllPathFull}");
		}
		string directoryName = fileInfo.DirectoryName;
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.Name);
		string text = $"{directoryName}/{fileNameWithoutExtension}.pdb";
		string text2 = $"{directoryName}/{fileNameWithoutExtension}.mdb";
		string value = "";
		if (File.Exists(text))
		{
			value = text;
		}
		else if (File.Exists(text2))
		{
			value = text2;
		}
		if (string.IsNullOrEmpty(value) && !SharedRuntimeState.IsAOT)
		{
			throw new FileNotFoundException($"symbol file not find!:\r\ncheck:\r\n{text}\r\n{text2}\r\n");
		}
		if (AssemblyContext.IsCLR)
		{
			appdomain.Add(dllName, Assembly.Load(dllName.Substring(0, dllName.Length - 4) + ", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
			return;
		}
		if (!CurrentAssemblyContext.LoadFromAssmName(dllName.Substring(0, dllName.Length - 4) + ", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", out var Assem))
		{
			Assem = Assembly.LoadFile(fileInfo.FullName);
		}
		GSEUtil.Ensure(Assem != null, "Load Script Dll Failed!!! dllName:" + dllName + " FullName:" + fileInfo.FullName);
		appdomain.Add(dllName, Assem);
	}

	private void StopManaged()
	{
		try
		{
			GameProcessEnd(null, _appdomain);
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError(ex.ToString());
		}
		_appdomain = null;
	}

	public override void LoadHotScriptAssemblyDo(string LocalPath, string EntryClass, string EntryMethod, string TickMethod)
	{
	}

	private static Assembly LoadScripetAssemblyCoreCLR(string ScriptDllPath)
	{
		if (ScriptGeneratedContextType == null)
		{
			Type type = Type.GetType("System.Runtime.Loader.AssemblyLoadContext");
			ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(bool) }, null);
			MethodInfo method = type.GetMethod("Load", BindingFlags.Instance | BindingFlags.NonPublic);
			MethodInfo method2 = type.GetMethod("Unload", BindingFlags.Instance | BindingFlags.Public);
			MethodInfo method3 = type.GetMethod("LoadFromStream", new Type[2]
			{
				typeof(Stream),
				typeof(Stream)
			});
			AssemblyName assemblyName = new AssemblyName("ScriptAssemblyLoadContextHelper");
			TypeBuilder typeBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndCollect).DefineDynamicModule(assemblyName.Name).DefineType("GeneratedAssemblyLoadContext", TypeAttributes.Public, type, new Type[1] { typeof(IScriptAssemblyLoadContext) });
			ILGenerator iLGenerator = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.HasThis, Type.EmptyTypes).GetILGenerator();
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Ldc_I4_1);
			iLGenerator.Emit(OpCodes.Call, constructor);
			iLGenerator.Emit(OpCodes.Ret);
			MethodInfo method4 = typeof(ResolveEventHandlerClass).GetMethod("ResolveHandler");
			MethodBuilder methodBuilder = typeBuilder.DefineMethod("Load", MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(Assembly), new Type[1] { typeof(AssemblyName) });
			ILGenerator iLGenerator2 = methodBuilder.GetILGenerator();
			iLGenerator2.Emit(OpCodes.Ldarg_1);
			iLGenerator2.Emit(OpCodes.Call, method4);
			iLGenerator2.Emit(OpCodes.Ret);
			typeBuilder.DefineMethodOverride(methodBuilder, method);
			ILGenerator iLGenerator3 = typeBuilder.DefineMethod("Unload", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(void), Type.EmptyTypes).GetILGenerator();
			iLGenerator3.Emit(OpCodes.Ldarg_0);
			iLGenerator3.Emit(OpCodes.Call, method2);
			iLGenerator3.Emit(OpCodes.Ret);
			typeBuilder.DefineMethodOverride(methodBuilder, method);
			ILGenerator iLGenerator4 = typeBuilder.DefineMethod("LoadFromStream", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, typeof(Assembly), new Type[2]
			{
				typeof(Stream),
				typeof(Stream)
			}).GetILGenerator();
			iLGenerator4.Emit(OpCodes.Ldarg_0);
			iLGenerator4.Emit(OpCodes.Ldarg_1);
			iLGenerator4.Emit(OpCodes.Ldarg_2);
			iLGenerator4.Emit(OpCodes.Call, method3);
			iLGenerator4.Emit(OpCodes.Ret);
			ScriptGeneratedContextType = typeBuilder.CreateType();
		}
		if (ScriptGeneratedContextType == null)
		{
			BGW_LogUtil.LogError("ScriptGeneratedContextType == null, cant load ScriptDll!!!");
			return null;
		}
		IScriptAssemblyLoadContext scriptAssemblyLoadContext = (IScriptAssemblyLoadContext)Activator.CreateInstance(ScriptGeneratedContextType);
		if (scriptAssemblyLoadContext == null)
		{
			BGW_LogUtil.LogError("NewLoadContext == null, cant load ScriptDll!!!");
			return null;
		}
		ScriptDllAssemblyLoadContextList.Add(scriptAssemblyLoadContext);
		if (File.Exists(ScriptDllPath))
		{
			ScriptDllPath = Path.GetFullPath(ScriptDllPath);
			FileStream fileStream = File.OpenRead(ScriptDllPath);
			FileStream fileStream2 = null;
			try
			{
				string path = Path.ChangeExtension(ScriptDllPath, ".pdb");
				if (File.Exists(path))
				{
					fileStream2 = File.OpenRead(path);
				}
				return scriptAssemblyLoadContext.LoadFromStream(fileStream, fileStream2);
			}
			finally
			{
				fileStream.Close();
				fileStream2?.Close();
			}
		}
		BGW_LogUtil.LogError("ScriptDllPath: " + ScriptDllPath + " not find!!!");
		return null;
	}

	public void ClearAssemblyContext()
	{
		List<WeakReference> list = new List<WeakReference>();
		foreach (IScriptAssemblyLoadContext scriptDllAssemblyLoadContext in ScriptDllAssemblyLoadContextList)
		{
			list.Add(new WeakReference(scriptDllAssemblyLoadContext));
		}
		ScriptDllAssemblyLoadContextList.Clear();
		foreach (WeakReference item in list)
		{
			try
			{
				((IScriptAssemblyLoadContext)item.Target).Unload();
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError("ScriptDllAssemblyLoadContext 卸载失败: " + ex.Message);
			}
		}
		list.Clear();
		for (int i = 0; i < 15; i++)
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			Thread.Sleep(100);
		}
	}

	static BGW_ManagedReflectMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ManagedReflectMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ManagedReflectMgr));
		ScriptDllAssemblyLoadContextList = new List<IScriptAssemblyLoadContext>();
		ScriptGeneratedContextType = null;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_ManagedReflectMgr");
	}
}
