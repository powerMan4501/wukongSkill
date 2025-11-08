using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using b1;
using BtlShare;
using Newtonsoft.Json;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace BlackMythWukong_Game_Helper;

public class MethodByKey
{
	private static MethodByKey _Instance;

	private MethodByKey()
	{
	}

	public static MethodByKey Get()
	{
		if (_Instance == null)
		{
			_Instance = new MethodByKey();
		}
		return _Instance;
	}

	public List<string> GetAllMethod()
	{
		MethodInfo[] methods = typeof(MethodByKey).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
		List<string> list = new List<string>();
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
			list.Add(methodInfo.Name);
		}
		return list;
	}

	private static MethodInfo GetGMMethod(string MethodName)
	{
		MethodInfo[] methods = typeof(MethodByKey).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
			if (methodInfo.Name.ToLowerInvariant() == MethodName.ToLowerInvariant())
			{
				return methodInfo;
			}
		}
		return null;
	}

	public static void TryInvokeLocalMethod(string MethodName)
	{
		MethodInfo gMMethod = GetGMMethod(MethodName);
		Name name = GlobalObjectMgr.Get<NameCN>().CN(MethodName);
		if (gMMethod != null)
		{
			gMMethod.Invoke(Get(), null);
		}
	}

	public void Init()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		string modTB_KeyHookPath = GlobalObjectMgr.ModTB_KeyHookPath;
		TB_KeyHook tB_KeyHook = GlobalObjectMgr.Get<TB_KeyHook>();
		if (!File.Exists(modTB_KeyHookPath))
		{
			List<string> allMethod = GetAllMethod();
			foreach (string item in allMethod)
			{
				if (GlobalObjectMgr.Get<NameCN>().CN(item) != null)
				{
					tB_KeyHook.List_.Add(new KeyHook
					{
						HookKey = GlobalObjectMgr.Get<NameCN>().CN(item).HookKey,
						Name = GlobalObjectMgr.Get<NameCN>().CN(item).Value,
						Method = (item ?? "")
					});
				}
			}
			string value = JsonConvert.SerializeObject(tB_KeyHook, Formatting.Indented);
			StreamWriter streamWriter = new StreamWriter(File.Open(modTB_KeyHookPath, FileMode.Create));
			streamWriter.WriteLine(value);
			streamWriter.Close();
			Console.WriteLine("创建" + modTB_KeyHookPath + "配置文件");
		}
		else
		{
			string value2 = File.ReadAllText(modTB_KeyHookPath);
			TB_KeyHook tB_KeyHook2 = JsonConvert.DeserializeObject<TB_KeyHook>(value2);
			tB_KeyHook.List_.Clear();
			tB_KeyHook.List_.AddRange(tB_KeyHook2.List_);
			Console.WriteLine("读取" + modTB_KeyHookPath + "配置文件");
		}
	}

	private void OpenMainMenu()
	{
		MainMenu.Get().OpenMainMenu();
	}

	private void OnGSLockHP()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSLockHP();
	}

	private void OnGSLockMP()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSLockMP();
	}

	private void OnGSLockPE()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSLockPE();
	}

	private void OnGSLockStamina()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSLockStamina();
	}

	private void OnGSLockVigorEnergy()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSLockVigorEnergy();
	}

	private void OnGSSetSpeed()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSSetSpeed();
	}

	private void OnGSLockCD()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSLockCD();
	}

	private void OnGSPreciseDodge()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSPreciseDodge();
	}

	private void OnGSPreciseGP()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSPreciseGP();
	}

	private void OnGSPreciseHMQ()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSPreciseHMQ();
	}

	private void OnGSLockJDY()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGSLockJDY();
	}

	private void OnGsKuaiSuXuLi()
	{
		GlobalObjectMgr.Get<SuperCharacter>().OnGsKuaiSuXuLi(5);
	}

	private void OnGSLockSpellRebirth()
	{
		Console.WriteLine("法术轮回");
		GlobalObjectMgr.Get<SuperCharacter>().OnGSLockSpellRebirth();
	}

	private void test()
	{
		Console.WriteLine("test");
		BGUPlayerCharacterCS bGUPlayerCharacterCS = MyUtils.GetBGUPlayerCharacterCS();
		BUTamerActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>((UObject)(object)bGUPlayerCharacterCS);
		BUTamerActor[] array = allActorsOfClass;
		BUTamerActor[] array2 = array;
		foreach (BUTamerActor bUTamerActor in array2)
		{
			FTamerRef currentRef = bUTamerActor.CurrentRef;
			FieldInfo field = typeof(FTamerRef).GetField("_phase", BindingFlags.Instance | BindingFlags.NonPublic);
			string text = field.GetValue(currentRef).ToString();
			if (text != "Dead")
			{
				BGUCharacterCS monster = bUTamerActor.GetMonster();
				float num = BGUFunctionLibraryCS.BGUGetFloatAttr((AActor)(object)monster, (EBGUAttrFloat)51);
				BGUFunctionLibraryCS.BGUSetAttrValue((AActor)(object)monster, (EBGUAttrFloat)51, 1000000f);
				BGUFunctionLibraryCS.BGUSetAttrValue((AActor)(object)monster, (EBGUAttrFloat)151, BGUFunctionLibraryCS.BGUGetFloatAttr((AActor)(object)monster, (EBGUAttrFloat)1));
			}
		}
	}

	private void test1()
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = MyUtils.GetBGUPlayerCharacterCS();
		BUTamerActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>((UObject)(object)bGUPlayerCharacterCS);
		BUTamerActor[] array = allActorsOfClass;
		BUTamerActor[] array2 = array;
		foreach (BUTamerActor bUTamerActor in array2)
		{
			FTamerRef currentRef = bUTamerActor.CurrentRef;
			FieldInfo field = typeof(FTamerRef).GetField("_phase", BindingFlags.Instance | BindingFlags.NonPublic);
			string text = field.GetValue(currentRef).ToString();
			if (text != "Dead")
			{
				BGUCharacterCS monster = bUTamerActor.GetMonster();
				float num = BGUFunctionLibraryCS.BGUGetFloatAttr((AActor)(object)monster, (EBGUAttrFloat)51);
				float num2 = BGUFunctionLibraryCS.BGUGetFloatAttr((AActor)(object)monster, (EBGUAttrFloat)151);
				Console.WriteLine($"{num}{num2}");
			}
		}
	}
}
