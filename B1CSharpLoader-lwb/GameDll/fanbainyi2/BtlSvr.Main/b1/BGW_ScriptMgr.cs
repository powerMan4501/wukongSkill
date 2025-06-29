using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using b1.GSFile;
using b1.UI;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Enviorment;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ScriptMgr")]
public abstract class BGW_ScriptMgr : GameInstanceSystemBaseUObj
{
	public class HotScriptAssembly
	{
		public string AssemblyName;

		public Version Version;

		public string EntryClassName;

		public string TickMethod;

		public int TickGroup;
	}

	protected Dictionary<string, string> InitFuncDic;

	protected Dictionary<string, string> TickFuncDic;

	protected Dictionary<string, string> DestoryFuncDic;

	protected Dictionary<string, HotScriptAssembly> HotScriptAssembles = new Dictionary<string, HotScriptAssembly>();

	private object[] sHotScriptTickParamList = new object[1] { 0 };

	public override bool bTickEnabled => true;

	public void LoadHotScriptAssembly(string URL, string EntryClass, string EntryMethod, string TickMethod = null, int TickGroup = 0)
	{
		BGW_AsyncTaskMgr.Get(this).HttpRequestAsync(URL, "GET", null, null, delegate(int HttpStatusCode, byte[] resultBody)
		{
			if (HttpStatusCode != 200)
			{
				BGW_LogUtil.LogError("request fail code:{httpStatus}", HttpStatusCode);
			}
			else
			{
				string text = Path.Combine(FPaths.ProjectPersistentDownloadDir, "TempAssembly.dll");
				File.WriteAllBytes(text, resultBody);
				string text2 = null;
				Version version = null;
				using (FileStream stream = new FileStream(text, FileMode.Open, FileAccess.Read))
				{
					ModuleDefinition moduleDefinition = ModuleDefinition.ReadModule(stream);
					text2 = moduleDefinition.Assembly.Name.Name;
					version = moduleDefinition.Assembly.Name.Version;
				}
				if (HotScriptAssembles.TryGetValue(text2, out var value))
				{
					if (value.Version >= version)
					{
						return;
					}
				}
				else
				{
					value = new HotScriptAssembly();
					HotScriptAssembles.Add(text2, value);
				}
				value.Version = version;
				value.TickMethod = TickMethod;
				value.EntryClassName = EntryClass;
				value.TickGroup = TickGroup;
				string text3 = Path.Combine(FPaths.ProjectPersistentDownloadDir, text2 + "." + version.ToString() + ".dll");
				File.Delete(text3);
				File.Move(text, text3);
				LoadHotScriptAssemblyDo(text3, EntryClass, EntryMethod, TickMethod);
			}
		});
	}

	public override int GetTickGroupMask()
	{
		return int.MaxValue;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		sHotScriptTickParamList[0] = TickGroup;
		foreach (KeyValuePair<string, HotScriptAssembly> hotScriptAssemble in HotScriptAssembles)
		{
			if ((hotScriptAssemble.Value.TickGroup & TickGroup) > 0 && !string.IsNullOrEmpty(hotScriptAssemble.Value.TickMethod))
			{
				BGW_ILRuntimeMgr.ILRuntimeInvoke(this, hotScriptAssemble.Value.EntryClassName, hotScriptAssemble.Value.TickMethod, null, sHotScriptTickParamList);
			}
		}
	}

	public abstract void LoadHotScriptAssemblyDo(string LocalPath, string EntryClass, string EntryMethod, string TickMethod);

	protected string UnderContentPathFix(string path)
	{
		if (FPlatformProperties.GetPlatform() == EPlatform.IOS)
		{
			return path.ToLower();
		}
		return path;
	}

	public virtual void RegisterUIDelegateConvertor<Signature, Wrapper>(BUI_Widget HolderWidget) where Signature : Delegate where Wrapper : UILRuntimeDelegateWrapperBase
	{
		FDelegateBase<Signature>.BindHook = delegate(Signature evnt, out Signature newEvnt)
		{
			Wrapper val = UObject.NewObject<Wrapper>(HolderWidget);
			val.SetAction(evnt);
			HolderWidget.AddDelegateWrapper(val);
			newEvnt = val.GetSignature() as Signature;
			return true;
		};
		FDelegateBase<Signature>.UnBindHook = delegate(Signature evnt, out Signature newEvnt, out UObject target)
		{
			newEvnt = null;
			target = null;
			Wrapper val = HolderWidget.FindDelegateWrapper(evnt) as Wrapper;
			if (val != null)
			{
				val.SetAction(null);
				HolderWidget.RemoveDelegateWrapper(val);
				target = val;
				newEvnt = val.GetSignature() as Signature;
				return true;
			}
			return false;
		};
	}

	public static string GetDllPathFull(string dllName)
	{
		EPlatform platform = FPlatformProperties.GetPlatform();
		string result = "";
		if (File.Exists(dllName))
		{
			return dllName;
		}
		switch (platform)
		{
		case EPlatform.Android:
			result = GSEFileSystem.GetInstance().GetFileFullPath(Path.Combine("Script", dllName));
			break;
		case EPlatform.IOS:
			result = GSEFileSystem.GetInstance().GetFileFullPath(Path.Combine("Script", dllName));
			break;
		case EPlatform.Windows:
			result = FPaths.Combine(UPaths.ProjectDir(), "Binaries/Win64/Managed", dllName);
			break;
		case EPlatform.Mac:
			result = FPaths.Combine(UPaths.ProjectDir(), "Binaries/Managed", dllName);
			break;
		case EPlatform.Linux:
			result = FPaths.Combine(UPaths.ProjectDir(), "Binaries/Managed", dllName);
			break;
		case EPlatform.PS5:
			result = FPaths.Combine("/app0/b1", "binaries/ps5/managed", dllName);
			break;
		case EPlatform.XSX:
			result = FPaths.Combine("/b1/", "Binaries/Managed", dllName);
			break;
		}
		return result;
	}

	protected void GameProcessInit(ILRuntime.Runtime.Enviorment.AppDomain ILRuntimeAppdomain, Dictionary<string, Assembly> ReflectAppdomain)
	{
		object[] array = new object[1] { BGWGameInstanceCS.Get(this) };
		if (ILRuntimeAppdomain != null)
		{
			if (!FGlobals.IsRunningDedicatedServer)
			{
				ILRuntimeAppdomain.Invoke("B1UI.GSG", "Init", null, array);
			}
			if (!FGlobals.IsRunningDedicatedServer)
			{
				ILRuntimeAppdomain.Invoke("B1UI.B1ScriptMain", "GameProcessInit", null, array);
			}
			else
			{
				ILRuntimeAppdomain.Invoke("b1.GSGBtl", "GameProcessInit", null, array);
			}
		}
		if (ReflectAppdomain != null)
		{
			if (!FGlobals.IsRunningDedicatedServer)
			{
				ReflectAppdomain["B1UI_GSE.Script.dll"].GetType("B1UI.GSG").GetMethod("Init").Invoke(null, array);
			}
			if (!FGlobals.IsRunningDedicatedServer)
			{
				ReflectAppdomain["B1UI_GSE.Script.dll"].GetType("B1UI.B1ScriptMain").GetMethod("GameProcessInit").Invoke(null, array);
			}
			else
			{
				ReflectAppdomain["BtlSvr_GSE.Script.dll"].GetType("b1.GSGBtl").GetMethod("GameProcessInit").Invoke(null, array);
			}
		}
	}

	protected void GameProcessTick(ILRuntime.Runtime.Enviorment.AppDomain ILRuntimeAppdomain, Dictionary<string, Assembly> ReflectAppdomain, object[] params1)
	{
		ILRuntimeAppdomain?.Invoke("B1UI.B1ScriptMain", "Tick", null, params1);
		ReflectAppdomain?["B1UI_GSE.Script.dll"].GetType("B1UI.B1ScriptMain").GetMethod("Tick").Invoke(null, params1);
	}

	protected void GameProcessEnd(ILRuntime.Runtime.Enviorment.AppDomain ILRuntimeAppdomain, Dictionary<string, Assembly> ReflectAppdomain)
	{
		string key = "B1UI_GSE.Script.dll";
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list.Add("OnBattleDestroy");
		list.Add("Destroy");
		list2.Add("b1.GSGBtl");
		list2.Add("B1UI.GSG");
		for (int i = 0; i < list.Count; i++)
		{
			ILRuntimeAppdomain?.Invoke(list2[i], list[i], null);
			ReflectAppdomain?[key].GetType(list2[i]).GetMethod(list[i]).Invoke(null, null);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_ScriptMgr");
	}

	static BGW_ScriptMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ScriptMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ScriptMgr));
	}
}
