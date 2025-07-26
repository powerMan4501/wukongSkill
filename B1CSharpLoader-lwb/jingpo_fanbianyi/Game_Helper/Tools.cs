using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using b1;
using BtlB1;
using BtlShare;
using CSharpModBase;
using CSharpModBase.Input;
using Newtonsoft.Json;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace Game_Helper;

public class Tools
{
	public class BossInfo
	{
		public string AssetPath { get; set; }

		public string BossName { get; set; }

		public int BossID { get; set; }

		public int Level { get; set; }

		public bool Boss { get; set; }
	}

	public class BossSkillInfo
	{
		public string Name { get; set; }

		public int BossID { get; set; }

		public int Skill { get; set; }
	}

	public class ModSet
	{
		public bool CanUseBossSkill { get; set; }

		public bool InDsMod { get; set; }

		public int InDsModBy { get; set; }

		public int InDsModMax { get; set; } = 60;
	}

	public const string LoaderDir = "CSharpLoader";

	public const string ModDir = "CSharpLoader\\Mods";

	public const string DataDir = "CSharpLoader\\Data";

	public const string ModName = "BlackMythWukong_Game_Helper";

	public static Dictionary<int, BossInfo> bossInfoDic = new Dictionary<int, BossInfo>();

	public static List<BossSkillInfo> bossSkillInfos = new List<BossSkillInfo>();

	public static int bossskill;

	public static List<BossInfo> bossInfos = new List<BossInfo>();

	public static TimerAndPlayerDataComp TimerAndPlayerDataComp;

	public static GameHelperMgrSystem gameHelperMgrSystem;

	public static BU_Timer bU_Timer;

	public static BU_UIGameHelper BU_UIGameHelper;

	public static BU_PlayerTransSystem BU_PlayerTransSystem;

	public static BU_PlayerTransSysemA BU_PlayerTransSysemA;

	public static BuffRun buffRun;

	public static BU_GameData GameData;

	public static ModSet modSet;

	public static void Init()
	{
		LoadAll();
		RegisterKey();
		GameData.CreateObject<BU_PlayerTransSysemA>();
		GameData.CreateObject<BU_PlayerTransSystem>();
		GameData.CreateObject<BU_Timer>();
		GameData.CreateObject<BuffRun>();
	}

	private static void RegisterKey()
	{
		Utils.RegisterKeyBind((Key)120, (Action)delegate
		{
			modSet.CanUseBossSkill = !modSet.CanUseBossSkill;
		});
		Utils.RegisterKeyBind((Key)121, (Action)delegate
		{
			modSet.InDsMod = false;
		});
	}

	public static void LoadAll()
	{
		LoadBossInfo();
		BossSkillInit();
		LoadModSet();
	}

	private static void LoadModSet()
	{
		string path = "CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\ AModSet.json";
		if (!File.Exists(path))
		{
			modSet = new ModSet();
			modSet.CanUseBossSkill = false;
			modSet.InDsMod = false;
			modSet.InDsModBy = 2208;
			string value = JsonConvert.SerializeObject(modSet);
			StreamWriter streamWriter = new StreamWriter(File.Open(path, FileMode.Create));
			streamWriter.WriteLine(value);
			streamWriter.Close();
			Console.WriteLine("创建AModSet配置文件");
		}
		else
		{
			string value2 = File.ReadAllText(path);
			modSet = JsonConvert.DeserializeObject<ModSet>(value2);
			Console.WriteLine("读取AModSet配置文件");
		}
	}

	public static void LoadBossInfo()
	{
		string text = "CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\ABossInfos.json";
		if (File.Exists(text))
		{
			string text2 = File.ReadAllText(text);
			if (text2 == null)
			{
				return;
			}
			bossInfos = JsonConvert.DeserializeObject<List<BossInfo>>(text2);
			if (bossInfos == null || bossInfos.Count <= 0)
			{
				return;
			}
			StreamWriter streamWriter = new StreamWriter(File.Open("CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\Abs.txt", FileMode.Create));
			foreach (BossInfo bossInfo in bossInfos)
			{
				bossInfoDic[bossInfo.BossID] = bossInfo;
				streamWriter.WriteLine($"{bossInfo.BossID}--{bossInfo.BossName}");
			}
			streamWriter.Close();
		}
		else
		{
			Console.WriteLine("加载BossInfo出错：" + text + "不存在");
		}
	}

	public static void BossSkillInit()
	{
		string path = "CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\ ABossSkillInfos.json";
		if (!File.Exists(path))
		{
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "青背龙",
				BossID = 55,
				Skill = 302915
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "青狮",
				BossID = 59,
				Skill = 198905
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "红孩儿",
				BossID = 48,
				Skill = 440171
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "小俪龙",
				BossID = 49,
				Skill = 302509
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "广智",
				BossID = 6,
				Skill = 112804
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "杨戬",
				BossID = 62,
				Skill = 800088
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "亢金龙",
				BossID = 52,
				Skill = 340120
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "红孩儿",
				BossID = 48,
				Skill = 440111
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "小黄龙",
				BossID = 50,
				Skill = 19043
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "虎先锋",
				BossID = 259,
				Skill = 202261
			});
			bossSkillInfos.Add(new BossSkillInfo
			{
				Name = "杨戬",
				BossID = 62,
				Skill = 800084
			});
			string value = JsonConvert.SerializeObject(bossSkillInfos);
			StreamWriter streamWriter = new StreamWriter(File.Open(path, FileMode.Create));
			streamWriter.WriteLine(value);
			streamWriter.Close();
			Console.WriteLine("创建Boss技能配置文件");
		}
		else
		{
			string value2 = File.ReadAllText(path);
			bossSkillInfos = JsonConvert.DeserializeObject<List<BossSkillInfo>>(value2);
			Console.WriteLine("读取Boss技能配置文件");
		}
	}

	public static void PlayerTrans(int boss, bool isInit, int skill, float Scale3D)
	{
		if (bossInfoDic.TryGetValue(boss, out var value) && BU_PlayerTransSystem != null)
		{
			BU_PlayerTransSystem.IsInit = isInit;
			BU_GameData.Get().GetObject<BU_PlayerTransSystem>()?.SpawnActor(value.AssetPath, skill, Scale3D, (EState_MM)7);
		}
	}

	public static void SpawPlayerTransActor(int boss, float scale3D)
	{
	}

	public static void InDsMod(int itemID)
	{
		if (itemID <= 0 || itemID != modSet.InDsModBy)
		{
			return;
		}
		modSet.InDsMod = true;
		AActor Owner = MyUtils.GetControlledPawn();
		BU_Timer.Add(0.5f, delegate
		{
			if (Owner != null)
			{
				FUStTransQiTianDaShengConfigDesc transQiTianDaShengConfigDesc = BGW_GameDB.GetTransQiTianDaShengConfigDesc(1, Owner);
				transQiTianDaShengConfigDesc.Duration = modSet.InDsModMax;
				BUS_GSEventCollection obj = BUS_EventCollectionCS.Get(Owner);
				if (obj != null)
				{
					obj.Evt_TriggerTrans2DaSheng.Invoke();
				}
				BGUFunctionLibraryCS.BGUSetAttrValue((AActor)MyUtils.GetControlledPawn(), (EBGUAttrFloat)191, 480f);
				Console.WriteLine($"使用丹药{itemID}进入大圣模式");
			}
		});
	}

	private static T RegiestComp<T>(T ActorComponent = default(T)) where T : UActorCompBaseCS, new()
	{
		APawn controlledPawn = MyUtils.GetControlledPawn();
		if (controlledPawn != null)
		{
			BGUPlayerCharacterCS val = (BGUPlayerCharacterCS)(object)((controlledPawn is BGUPlayerCharacterCS) ? controlledPawn : null);
			if ((UObject)(object)val != null)
			{
				List<UActorCompBaseCS> fieldOrProperty = ((BGUCharacterCS)val).ActorCompContainerCS.GetFieldOrProperty<List<UActorCompBaseCS>>("CompCSs");
				if (fieldOrProperty == null)
				{
					return default(T);
				}
				foreach (UActorCompBaseCS item in fieldOrProperty)
				{
					if (((object)item).GetType().ToString() == typeof(T).ToString())
					{
						return (T)(object)((item is T) ? item : null);
					}
				}
				if (ActorComponent == null)
				{
					ActorComponent = new T();
					ActorComponent = ((BGUCharacterCS)val).ActorCompContainerCS.AddComp<T>(ActorComponent, int.MaxValue, 0);
					Console.WriteLine("RegistComp-------" + typeof(T).ToString());
					((BGUCharacterCS)val).ActorCompContainerCS.RecalculateCanTick();
					return ActorComponent;
				}
			}
		}
		return default(T);
	}

	public static void RegistAllComp()
	{
		TimerAndPlayerDataComp = RegiestComp<TimerAndPlayerDataComp>();
	}

	public static T BUC_AnyDataGet<T>() where T : class, new()
	{
		if (TimerAndPlayerDataComp == null)
		{
			return null;
		}
		TimerAndPlayerDataComp timerAndPlayerDataComp = TimerAndPlayerDataComp;
		return (timerAndPlayerDataComp != null) ? timerAndPlayerDataComp.BUC_AnyDataGet<T>() : null;
	}

	public static IT GetReadOnlyData<IT, T>() where IT : class where T : class, IT, new()
	{
		if (TimerAndPlayerDataComp == null)
		{
			return null;
		}
		TimerAndPlayerDataComp timerAndPlayerDataComp = TimerAndPlayerDataComp;
		return (timerAndPlayerDataComp != null) ? timerAndPlayerDataComp.GetReadOnlyData<IT, T>() : null;
	}

	public static void ir9aZOTM2X()
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		foreach (Assembly assembly in array)
		{
			if (!assembly.IsDynamic)
			{
				Console.WriteLine(assembly.Location);
				string name = assembly.GetName().Name;
				string path = name + ".dll";
				byte[] array2 = aVYaK7Q8j0(name);
				if (array2 != null)
				{
					File.WriteAllBytes(path, array2);
					Console.WriteLine("111111");
				}
			}
		}
	}

	private static byte[] aVYaK7Q8j0(string P_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string name = executingAssembly.GetName().Name + "." + P_0 + ".dll";
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name);
		if (manifestResourceStream != null)
		{
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			return array;
		}
		return null;
	}
}
