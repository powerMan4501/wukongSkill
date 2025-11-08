using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ArchiveB1;
using b1;
using b1.Localization;
using B1UI;
using b1x;
using BlackMythWukong_Game_Helper;
using BtlB1;
using BtlShare;
using CommB1;
using CsB1;
using Google.Protobuf.Collections;
using Newtonsoft.Json;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

public class PlayerGm
{
	private PlayerDataMgr PlayerMgr;

	private GamePlayer Player;

	public PlayerGm()
	{
		Player = GSG.GamePlayer;
		PlayerMgr = GSG.GamePlayer.CreateTransaction((OPReason)2);
	}

	public static bool IsCommandExist(string Command)
	{
		return GetGMMethod(Command) != null;
	}

	private static MethodInfo GetGMMethod(string MethodName)
	{
		MethodInfo[] methods = typeof(PlayerGm).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
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

	public static List<string> GetAllMethod()
	{
		List<string> list = new List<string>();
		MethodInfo[] methods = typeof(PlayerGm).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo[] array = methods;
		foreach (MethodInfo methodInfo in array)
		{
			list.Add(methodInfo.Name);
		}
		return list;
	}

	public static void Init()
	{
		TB_GMMethod tB_GMMethod = GlobalObjectMgr.Get<TB_GMMethod>();
		string modTB_GMMethodPath = GlobalObjectMgr.ModTB_GMMethodPath;
		if (!File.Exists(modTB_GMMethodPath))
		{
			foreach (string item in GetAllMethod())
			{
				if (!Ban(item) && GlobalObjectMgr.Get<NameCN>().CN(item) != null)
				{
					tB_GMMethod.List.Add(new GMMethod
					{
						Name = GlobalObjectMgr.Get<NameCN>().CN(item).Value,
						Method = item,
						Parameters = new List<string> { "1", "1" }
					});
				}
			}
			string value = JsonConvert.SerializeObject(tB_GMMethod, Formatting.Indented);
			StreamWriter streamWriter = new StreamWriter(File.Open(modTB_GMMethodPath, FileMode.Create));
			streamWriter.WriteLine(value);
			streamWriter.Close();
			Console.WriteLine("创建" + modTB_GMMethodPath + "配置文件");
		}
		else
		{
			string value2 = File.ReadAllText(modTB_GMMethodPath);
			TB_GMMethod tB_GMMethod2 = JsonConvert.DeserializeObject<TB_GMMethod>(value2);
			tB_GMMethod.List.Clear();
			tB_GMMethod.List.AddRange(tB_GMMethod2.List);
			Console.WriteLine("读取" + modTB_GMMethodPath + "配置文件");
		}
	}

	public static int TryInvokeLocalMethod(string MethodName, List<string> CommandList)
	{
		typeof(PlayerGm).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo gMMethod = GetGMMethod(MethodName);
		if (gMMethod != null)
		{
			object[] parameters = new object[1] { CommandList };
			return (int)gMMethod.Invoke(GlobalObjectMgr.Get<PlayerGm>(), parameters);
		}
		return 103;
	}

	public void Commit()
	{
		PlayerMgr.Commit();
	}

	private static bool Ban(string name)
	{
		List<string> list = new List<string>();
		list.AddRange(new List<string> { "Commit", "Ban" });
		if (list.Contains(name))
		{
			return true;
		}
		return false;
	}

	public static int SpellChage(SpellType spellType)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Invalid comparison between Unknown and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GSG.Context).GetControlledPawn();
		if (controlledPawn != null)
		{
			APlayerState playerState = controlledPawn.PlayerState;
			if (playerState != null)
			{
				BTF_EventCollectionCS bTF_EventCollectionCS = BTF_EventCollectionCS.Get(MyUtils.GetControlledPawn().GetController().PlayerState);
				int num = 0;
				foreach (DSSpellItem value in GSG.GamePlayer.Actor.Wear.SpellList.ValueList)
				{
					if (value.Type == spellType)
					{
						num = value.SpellId;
					}
				}
				if ((int)spellType != 1)
				{
					if ((int)spellType == 3)
					{
						num = ((num == 5102) ? 5101 : 5102);
					}
				}
				else
				{
					num = ((num == 5202) ? 5201 : 5202);
				}
				bTF_EventCollectionCS.Evt_ActorSetSpellReq(new CSMsgActorSetSpellReq
				{
					SpellId = num
				}, delegate
				{
				});
				return num;
			}
		}
		return 0;
	}

	public static void SpellCD(int spellId, bool AllSpell = false)
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GSG.Context).GetControlledPawn();
		if (controlledPawn != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get((AActor)controlledPawn);
			if ((UObject)(object)bUS_GSEventCollection != null && AllSpell)
			{
				bUS_GSEventCollection.Evt_ResetSkillCD.Invoke();
			}
			else if ((UObject)(object)bUS_GSEventCollection != null)
			{
				SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(spellId);
				bUS_GSEventCollection.Evt_ModifyCD.Invoke(spellDesc.SkillId, bAddOrMul: false, -10000f);
			}
		}
	}

	[GM("Additem Id Num，添加物品，例：Additem 1002 1000", true)]
	private MsgErrCode AddItem(List<string> ParamStringList)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		int id = int.Parse(ParamStringList[0]);
		int num = 1;
		if (ParamStringList.Count > 1)
		{
			num = int.Parse(ParamStringList[1]);
		}
		return PlayerMgr.Bag.GainItemOne(new ItemOne
		{
			Id = id,
			Num = num
		});
	}

	[GM("AllTaskItem，获取所有任务道具，例：AllTaskItem", true)]
	private MsgErrCode AllTaskItem(List<string> ParamStringList)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		if (ParamStringList.Count > 0)
		{
			num = int.Parse(ParamStringList[0]);
		}
		TBItemDesc tBItemDesc = GameDBRuntime.GetTBItemDesc();
		for (int i = 0; i < tBItemDesc.List.Count; i++)
		{
			ItemDesc val = tBItemDesc.List[i];
			if ((int)val.ItemType == 5)
			{
				MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = val.Id,
					Num = num
				});
				if ((int)val2 > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{1}");
					return val2;
				}
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AddExp Num，获取经验，例：AddExp 10000", true)]
	private MsgErrCode AddExp(List<string> ParamStringList)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count < 1)
		{
			return (MsgErrCode)0;
		}
		int gainNum = int.Parse(ParamStringList[0]);
		PlayerMgr.Actor.GainXp(gainNum);
		return (MsgErrCode)0;
	}

	[GM("AddSpell SpellId，获取法术，例：AddSpell 5809", true)]
	private MsgErrCode AddSpell(List<string> ParamStringList)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		int spellId = int.Parse(ParamStringList[0]);
		PlayerMgr.Actor.AddNewSpell(spellId);
		return (MsgErrCode)0;
	}

	[GM("SetSpell SpellId，获取法术并装配，例：SetSpell 5809", true)]
	private MsgErrCode SetSpell(List<string> ParamStringList)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (ParamStringList.Count > 0)
		{
			num = int.Parse(ParamStringList[0]);
		}
		if (GameDBRuntime.GetSpellDesc(num) != null)
		{
			PlayerMgr.Actor.AddNewSpell(num);
			PlayerMgr.Actor.SetWearSpell(num);
			return (MsgErrCode)0;
		}
		return (MsgErrCode)10001;
	}

	[GM("AddTalent TalentId，获取天赋，例：AddTalent 101001", true)]
	private MsgErrCode AddTalent(List<string> ParamStringList)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		int talentId = int.Parse(ParamStringList[0]);
		PlayerMgr.Actor.ActivateDefaultTalent(talentId);
		return (MsgErrCode)0;
	}

	[GM("CostItem ItemId Num，消耗道具，例：CostItem 1002 100", true)]
	private MsgErrCode CostItem(List<string> ParamStringList)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		int num = int.Parse(ParamStringList[0]);
		int num2 = 1;
		if (ParamStringList.Count > 1)
		{
			num2 = int.Parse(ParamStringList[1]);
		}
		MsgErrCode val = PlayerMgr.Bag.CostItem(num, num2);
		if ((int)val > 0)
		{
			SysLogUtil.GAME_PLAYER.LogError($"CostItem Failed, ItemId:{num}, NUm:{num2}");
		}
		return val;
	}

	[GM("AllTalent，全天赋，例：AllTalent", true)]
	private MsgErrCode AllTalent(List<string> ParamStringList)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		TBTalentSDesc tBTalentSDesc = GameDBRuntime.GetTBTalentSDesc();
		for (int i = 0; i < tBTalentSDesc.List.Count; i++)
		{
			TalentSDesc val = tBTalentSDesc.List[i];
			if ((int)val.Type != 1 && (int)val.Type != 2 && (int)val.Type != 3 && !val.Id.ToString().StartsWith("9901"))
			{
				PlayerMgr.Actor.ActivateDefaultTalent(val.Id);
			}
		}
		return (MsgErrCode)0;
	}

	[GM("TalentLevelUp ItemId Level，天赋升级 ，例：TalentLevelUp 101103 2", true)]
	private MsgErrCode TalentLevelUp(List<string> ParamStringList)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		int talentId = int.Parse(ParamStringList[0]);
		int num = int.Parse(ParamStringList[1]);
		TalentOne val = PlayerMgr.Actor.FindTalent(talentId);
		if (val != null)
		{
			for (int num2 = num - val.Level; num2 > 0; num2--)
			{
				PlayerMgr.Actor.DefaultTalentLevelUp(talentId);
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AddTalentPoint Num，获得天赋/道行点 ，例：AddTalentPoint 2", true)]
	private MsgErrCode AddTalentPoint(List<string> ParamStringList)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		int gainNum = int.Parse(ParamStringList[0]);
		PlayerMgr.Actor.GainTalentPoint(gainNum);
		return (MsgErrCode)0;
	}

	[GM("AllItem，全道具(只会获得材料和消耗物，不包括酒)，例：AllItem", true)]
	private MsgErrCode AllItem(List<string> ParamStringList)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		if (ParamStringList.Count > 0)
		{
			num = int.Parse(ParamStringList[0]);
		}
		TBItemDesc tBItemDesc = GameDBRuntime.GetTBItemDesc();
		int num2 = 0;
		for (int i = 0; i < tBItemDesc.List.Count; i++)
		{
			ItemDesc val = tBItemDesc.List[i];
			if ((int)val.ItemType == 3 || ((int)val.ItemType == 4 && (int)GameDBRuntime.GetConsumeType(val.Id) != 1))
			{
				MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = val.Id,
					Num = num
				});
				if ((int)val2 > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{num}");
					return val2;
				}
				num2++;
			}
		}
		return (MsgErrCode)0;
	}

	[GMNoExport]
	private MsgErrCode GMStartActivity(List<string> ParamStringList)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		int activity = 0;
		if (ParamStringList.Count > 0)
		{
			activity = int.Parse(ParamStringList[0]);
		}
		PlayerMgr.Activities.GMStartActvity(activity);
		return (MsgErrCode)0;
	}

	[GM("AllBossRush，解锁所有BossRush，例：AllBossRush", true)]
	private MsgErrCode AllBossRush(List<string> ParamStringList)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		PlayerMgr.BossRush.GMUnlockAllBossRush();
		return (MsgErrCode)0;
	}

	[GM("AllWine，所有酒，例：AllWine", true)]
	private MsgErrCode AllWine(List<string> ParamStringList)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		TBConsumeDesc tBConsumeDesc = GameDBRuntime.GetTBConsumeDesc();
		for (int i = 0; i < tBConsumeDesc.List.Count; i++)
		{
			ConsumeDesc val = tBConsumeDesc.List[i];
			if ((int)val.Type == 1)
			{
				MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = val.Id,
					Num = 1
				});
				if ((int)val2 > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{1}");
					return val2;
				}
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AddSurprise ChapterId SurpriseId，获取彩蛋，例：AddSurprise 10 1001", true)]
	private MsgErrCode AddSurprise(List<string> ParamStringList)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count < 2)
		{
			return (MsgErrCode)10001;
		}
		int num = int.Parse(ParamStringList[0]);
		int num2 = int.Parse(ParamStringList[1]);
		ChapterDesc chapterDesc = GameDBRuntime.GetChapterDesc(num);
		SurpriseDesc surpriseDesc = GameDBRuntime.GetSurpriseDesc(num2);
		if (chapterDesc == null || surpriseDesc == null)
		{
			SysLogUtil.GAME_PLAYER.LogError($"ChapterDesc == null || SurprieseDesc == null ChapterID:{num} SurpriseId:{num2}");
			return (MsgErrCode)10001;
		}
		return PlayerMgr.Chapter.AddNewSurprise(num, num2);
	}

	[GM("AllSurprise，全彩蛋，例：AllSurprise", true)]
	private MsgErrCode AllSurprise(List<string> ParamStringList)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		foreach (SurpriseDesc item in GameDBRuntime.GetTBSurpriseDesc().List)
		{
			MsgErrCode val = PlayerMgr.Chapter.AddNewSurprise(item.ChapterId, item.Id);
			if ((int)val > 0)
			{
				return val;
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AllSeeds，获取所有种子，例：AllSeeds", true)]
	private MsgErrCode AllSeeds(List<string> ParamStringList)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		TBItemDesc tBItemDesc = GameDBRuntime.GetTBItemDesc();
		for (int i = 0; i < tBItemDesc.List.Count; i++)
		{
			ItemDesc val = tBItemDesc.List[i];
			if ((int)val.ItemType == 19)
			{
				MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = val.Id,
					Num = 1
				});
				if ((int)val2 > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{1}");
					return val2;
				}
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AllEquip，全装备（一个系列只会获得一件），例：AllEquip", true)]
	private MsgErrCode AllEquip(List<string> ParamStringList)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		TBItemDesc tBItemDesc = GameDBRuntime.GetTBItemDesc();
		for (int i = 0; i < tBItemDesc.List.Count; i++)
		{
			ItemDesc val = tBItemDesc.List[i];
			if ((int)val.ItemType == 6 && (int)GameDBRuntime.GetEquipPosition(val.Id) != 4 && (int)GameDBRuntime.GetEquipPosition(val.Id) != 5)
			{
				MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = val.Id,
					Num = 1
				});
				if ((int)val2 > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{1}");
					return val2;
				}
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AllHulu，全葫芦，例：AllHulu", true)]
	private MsgErrCode AllHulu(List<string> ParamStringList)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		TBEquipDesc tBEquipDesc = GameDBRuntime.GetTBEquipDesc();
		for (int i = 0; i < tBEquipDesc.List.Count; i++)
		{
			EquipDesc val = tBEquipDesc.List[i];
			if ((int)val.EquipPosition == 4)
			{
				MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = val.Id,
					Num = 1
				});
				if ((int)val2 > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{1}");
					return val2;
				}
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AllWeapon，全武器，例：AllWeapon", true)]
	private MsgErrCode AllWeapon(List<string> ParamStringList)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		TBEquipDesc tBEquipDesc = GameDBRuntime.GetTBEquipDesc();
		for (int i = 0; i < tBEquipDesc.List.Count; i++)
		{
			EquipDesc val = tBEquipDesc.List[i];
			if ((int)val.EquipPosition == 5 && val.Id == GameDBRuntime.GetRootWeaponId(val.Id))
			{
				MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = val.Id,
					Num = 1
				});
				if ((int)val2 > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{1}");
					return val2;
				}
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AllSpell，全法术，例：AllSpell", true)]
	private MsgErrCode AllSpell(List<string> ParamStringList)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		TBItemDesc tBItemDesc = GameDBRuntime.GetTBItemDesc();
		for (int i = 0; i < tBItemDesc.List.Count; i++)
		{
			ItemDesc val = tBItemDesc.List[i];
			if ((int)val.ItemType == 8)
			{
				MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = val.Id,
					Num = 1
				});
				if ((int)val2 > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{1}");
					return val2;
				}
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AllAttrItem，获得所有属性道具，例：AllAttrItem", true)]
	private MsgErrCode AllAttrItem(List<string> ParamStringList)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		TBItemDesc tBItemDesc = GameDBRuntime.GetTBItemDesc();
		new CSMsgBagGainItemListReq();
		for (int i = 0; i < tBItemDesc.List.Count; i++)
		{
			ItemDesc val = tBItemDesc.List[i];
			if ((int)val.ItemType == 7)
			{
				MsgErrCode val2 = PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = val.Id,
					Num = 1
				});
				if ((int)val2 > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{val.Id}, Num:{1}");
					return val2;
				}
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AllRecipe，获得所有单方，例：AllRecipe", true)]
	private MsgErrCode AllRecipe(List<string> ParamStringList)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		TBItemRecipeDesc tBItemRecipeDesc = GameDBRuntime.GetTBItemRecipeDesc();
		for (int i = 0; i < tBItemRecipeDesc.List.Count; i++)
		{
			MsgErrCode val = PlayerMgr.Bag.GainItemOne(new ItemOne
			{
				Id = tBItemRecipeDesc.List[i].Id,
				Num = 1
			});
			if ((int)val > 0)
			{
				SysLogUtil.GAME_PLAYER.LogError($"GainItemOne Failed, Id:{tBItemRecipeDesc.List[i].Id}, Num:{1}");
				return val;
			}
		}
		return (MsgErrCode)0;
	}

	[GM("AllMedition Status，解锁所有打坐点，例：AllMedition 0/1 1为拥有大圣之耳解锁", true)]
	private MsgErrCode AllMedition(List<string> ParamStringList)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count < 1)
		{
			SysLogUtil.GAME_PLAYER.LogError("ParamStringList.Count < 1");
			return (MsgErrCode)10001;
		}
		if (!int.TryParse(ParamStringList[0], out var result))
		{
			return (MsgErrCode)10001;
		}
		PlayerMgr.Actor.GMUnlockAllMeditation((MeditationUnlockStatus)result);
		return (MsgErrCode)0;
	}

	[GM("AllLegacy，获得所有大圣遗物，例：AllLegacy", true)]
	private int AllLegacy(List<string> ParamStringList)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		TBItemDesc tBItemDesc = GameDBRuntime.GetTBItemDesc();
		foreach (ItemDesc item in tBItemDesc.List)
		{
			if ((int)item.ItemType == 22)
			{
				PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = item.Id,
					Num = 99
				});
			}
		}
		foreach (ItemDesc item2 in tBItemDesc.List)
		{
			if ((int)item2.ItemType == 14)
			{
				PlayerMgr.Bag.GainItemOne(new ItemOne
				{
					Id = item2.Id,
					Num = 1
				});
			}
		}
		TBTalentSDesc tBTalentSDesc = GameDBRuntime.GetTBTalentSDesc();
		for (int i = 0; i < tBTalentSDesc.List.Count; i++)
		{
			TalentSDesc val = tBTalentSDesc.List[i];
			if ((int)val.Type == 2)
			{
				int talentOwnLegacy = GameDBRuntime.GetTalentOwnLegacy(val.Id);
				PlayerMgr.Actor.ActivateLegacyTalent(talentOwnLegacy, val.Id);
			}
		}
		return 0;
	}

	[GM("OnActiveAllRebirthPoint，解锁所有土地庙，例：OnActiveAllRebirthPoint", true)]
	private MsgErrCode OnActiveAllRebirthPoint(List<string> ParamStringList)
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GSG.Context, 0);
			foreach (FUStRebirthPointDesc value in BGW_GameDB.GetAllRebirthPointDesc().Values)
			{
				LevelDesc levelDesc = GameDBRuntime.GetLevelDesc(value.GroupMapID);
				if (levelDesc != null && levelDesc.RebirthSortId >= 1)
				{
					BPS_EventCollectionCS.GetLocal(playerCharacter).Evt_ActiveRebirthPoint.Invoke(value.ID, P2: true);
				}
			}
			foreach (BGURebirthPointBase allActorsOfClass in playerCharacter.World.GetAllActorsOfClassList<BGURebirthPointBase>())
			{
				BUS_EventCollectionCS.Get((AActor)(object)allActorsOfClass).Evt_InteractRebirthPoint.Invoke(playerCharacter);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
		return (MsgErrCode)0;
	}

	[GM("AllCard，全图鉴，例：AllCard", true)]
	private int AllCard(List<string> ParamStringList)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		TBCardDesc tBCardDesc = GameDBRuntime.GetTBCardDesc();
		Player.Collection.MonsterCollectionList.Clear(ChangeReason.None);
		foreach (CardDesc item in tBCardDesc.List)
		{
			if (item.Id != GameDBRuntime.GetCommLogicCfgValue((CommCfgType)43))
			{
				PlayerMgr.Collection.PushCardPortraitStage(item.Id, (ECollectionPortraitStage)1);
				PlayerMgr.Collection.PushCardStoryStage(item.Id, PlayerMgr.Collection.CalCardCollectionStage(item.CardStory.Count));
			}
		}
		return 0;
	}

	[GM("AllMuseum，游戏内解锁全博物馆，例：AllMuseum", true)]
	private int AllMuseum(List<string> ParamStringList)
	{
		return 0;
	}

	[GM("AllMuseumCS，画卷界面解锁全博物馆，例：AllMuseumCS", true)]
	private MsgErrCode AllMuseumCS(List<string> ParamStringList)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		foreach (MuseumMVDesc item in GameDBRuntime.GetTBMuseumMVDesc().List)
		{
			PlayerMgr.Museum.UnlockMuseumMv(item.Id);
		}
		return (MsgErrCode)0;
	}

	[GM("MV，解锁MV，例：MV 1001", true)]
	private MsgErrCode MV(List<string> ParamStringList)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (!int.TryParse(ParamStringList[0], out var result))
		{
			return (MsgErrCode)10001;
		}
		if (GameDBRuntime.GetMuseumMVDesc(result) == null)
		{
			return (MsgErrCode)10001;
		}
		PlayerMgr.Museum.UnlockMuseumMv(result);
		return (MsgErrCode)0;
	}

	[GM("Card CardId ECollectionStage RedPoint，解锁图鉴，例：Card 101001 0", true)]
	private int Card(List<string> ParamStringList)
	{
		if (ParamStringList.Count < 3)
		{
			SysLogUtil.GAME_PLAYER.LogError("params nums should greater than or equal to 4");
			return -1;
		}
		int num = int.Parse(ParamStringList[0]);
		int num2 = int.Parse(ParamStringList[1]);
		int num3 = int.Parse(ParamStringList[2]);
		CardDesc cardDesc = GameDBRuntime.GetCardDesc(num);
		if (cardDesc == null)
		{
			SysLogUtil.GAME_PLAYER.LogError($"GetCardDesc Failed Id : {num}");
			return 10003;
		}
		if (!GameDBRuntime.IsVersionCard(cardDesc))
		{
			SysLogUtil.GAME_PLAYER.LogError($"Card not in version : {num}");
			return -1;
		}
		PlayerMgr.Collection.GMSetCard(num, (ECollectionStage)(byte)num2, (ECollectionPortraitStage)(byte)num3);
		return 0;
	}

	[GM("AddBossRushRecord BossRushType BossId EReChallengeLevel", true)]
	private int AddBossRushRecord(List<string> ParamStringList)
	{
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		if (ParamStringList.Count < 3)
		{
			SysLogUtil.GAME_PLAYER.LogError("params nums should greater than or equal to 4");
			return -1;
		}
		int num = int.Parse(ParamStringList[0]);
		int num2 = int.Parse(ParamStringList[1]);
		int num3 = int.Parse(ParamStringList[2]);
		if (num == 0)
		{
			if (GameDBRuntime.GetBossReChallengeDesc(num2) == null)
			{
				return -1;
			}
			PlayerMgr.BossRush.FindOrAddRefightBossOne(num2);
			PlayerMgr.BossRush.RefightUpdateLastChallengeLevel(num2, (EReChallengeLevel)num3);
			PlayerMgr.BossRush.RefightUpdatePassedMaxLevel(num2, (EReChallengeLevel)num3);
			BossRushBattleData val = new BossRushBattleData();
			val.ArchiveTime = UBGWFunctionLibraryCS.GetUTCTimeStamp();
			val.Score = num3;
			val.DebuffList.Add(1);
			val.TotalTime = 5f;
			val.BattleStyleInfo = new BossRushBattleStyle();
			PlayerMgr.BossRush.RefightUpdateBossRecord(num2, (EReChallengeLevel)num3, val);
		}
		else
		{
			if (GameDBRuntime.GetBossIterationsDesc(num2) == null)
			{
				return -1;
			}
			PlayerMgr.BossRush.FindOrAddContinuousFightOne(num2);
			BossRushBattleData val2 = new BossRushBattleData();
			val2.ArchiveTime = UBGWFunctionLibraryCS.GetUTCTimeStamp();
			val2.Score = num3;
			val2.DebuffList.Add(1);
			val2.TotalTime = 5f;
			val2.BattleStyleInfo = new BossRushBattleStyle();
			PlayerMgr.BossRush.ContinuousFightUpdateBossRecord(num2, val2);
		}
		return 0;
	}

	[GM("SetChapter, 设置当前章节，例：SetChapter 30", true)]
	private int SetChapter(List<string> ParamStringList)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count < 1)
		{
			SysLogUtil.GAME_PLAYER.LogError("params nums should greater than or equal to 1");
			return 10001;
		}
		int num = int.Parse(ParamStringList[0]);
		if (GameDBRuntime.GetChapterDesc(num) == null)
		{
			return 10003;
		}
		if (PlayerMgr.Chapter.FindChapter(num) == null)
		{
			return 10602;
		}
		foreach (ChapterDesc item in GameDBRuntime.GetTBChapterDesc().List)
		{
			if (item.Id < num)
			{
				PlayerMgr.Chapter.UpdateChapterStage(item.Id, (ChapterStage)2);
			}
			else
			{
				PlayerMgr.Chapter.UpdateChapterStage(item.Id, (ChapterStage)0);
			}
		}
		PlayerMgr.Chapter.SetCurChapter(num);
		return 0;
	}

	[GM("Map MapId，解锁地图碎片，例：Map 5701", true)]
	private int Map(List<string> ParamStringList)
	{
		return 0;
	}

	[GM("ArmorToTop ArmorId，防具升到最高级，例：ArmorToTop 10302", true)]
	public int ArmorToTop(List<string> ParamStringList)
	{
		if (ParamStringList.Count < 1)
		{
			SysLogUtil.GAME_PLAYER.LogError("params nums should greater than or equal to 1");
			return 10001;
		}
		int num = int.Parse(ParamStringList[0]);
		int curArmorMaxLevelId = GameDBRuntime.GetCurArmorMaxLevelId(num);
		if (curArmorMaxLevelId != 0)
		{
			for (int i = 0; i < Player.Bag.EquipList.Count; i++)
			{
				if (Player.Bag.EquipList[i].EquipId == num)
				{
					RoleEquip protobuf = Player.Bag.EquipList[i].Protobuf;
					RoleEquip val = PlayerMgr.Bag.FindBagEquipByUid(protobuf.Uid);
					if (val != null)
					{
						PlayerMgr.Bag.ArmorRebuild(val, curArmorMaxLevelId);
					}
					return 0;
				}
			}
		}
		return -1;
	}

	[GM("AllArmorToTop，所有防具升到最高级，例：AllArmorToTop", true)]
	public int AllArmorToTop(List<string> ParamStringList)
	{
		foreach (RoleEquip bagAllArmor in PlayerMgr.Bag.GetBagAllArmors())
		{
			int curArmorMaxLevelId = GameDBRuntime.GetCurArmorMaxLevelId(bagAllArmor.EquipId);
			if (curArmorMaxLevelId != 0)
			{
				PlayerMgr.Bag.ArmorRebuild(bagAllArmor, curArmorMaxLevelId);
			}
			SysLogUtil.GAME_PLAYER.LogError($"TopId:{curArmorMaxLevelId}");
		}
		return 0;
	}

	[GM("AllMap，解锁所有地图碎片，例：AllMap", true)]
	private int AllMap(List<string> ParamStringList)
	{
		return 0;
	}

	[GMNoExport]
	private int GMEnterShow(List<string> ParamStringList)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		int curChapterId = PlayerMgr.Chapter.GetCurChapterId();
		PlayerMgr.Chapter.UpdateChapterStage(curChapterId, (ChapterStage)1);
		return 0;
	}

	[GMNoExport]
	private int GetChapterAward(List<string> ParamStringList)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Invalid comparison between Unknown and I4
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		AwardList awardList = new AwardList();
		if (ParamStringList.Count < 1)
		{
			SysLogUtil.GAME_PLAYER.LogError("param string list size should greater than 0");
			return -1;
		}
		int num = int.Parse(ParamStringList[0]);
		ChapterDesc chapterDesc = GameDBRuntime.GetChapterDesc(num);
		List<ItemOne> list = new List<ItemOne>();
		if (chapterDesc != null)
		{
			foreach (int award in chapterDesc.AwardList)
			{
				list.AddRange(PlayerDropUtil.RandCommDropAward(Player, PlayerMgr, award, "GM", 0));
			}
			if (list.Count > 0)
			{
				MsgErrCode val = PlayerMgr.Bag.GainItemList(list, awardList);
				if ((int)val > 0)
				{
					SysLogUtil.GAME_PLAYER.LogError($"GainItemList Failed, errCode:{val}");
					return -1;
				}
			}
			PlayerMgr.Chapter.UpdateChapterStage(num, (ChapterStage)2);
			return 0;
		}
		SysLogUtil.GAME_PLAYER.LogError($"GetChapterDesc Failed, GetChapterDesc:{num}");
		return -1;
	}

	[GM("CommDrop DropId，获取随机掉落结果，例：CommDrop 2027", true)]
	private MsgErrCode CommDrop(List<string> ParamStringList)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count < 1)
		{
			return (MsgErrCode)10001;
		}
		int dropRuleId = int.Parse(ParamStringList[0]);
		List<ItemOne> list = PlayerDropUtil.RandCommDropAward(Player, PlayerMgr, dropRuleId, "GM", 0);
		if (list != null)
		{
			SysLogUtil.GAME_PLAYER.LogError("DropResult:" + XDumper.DumpAsString(list));
		}
		else
		{
			SysLogUtil.GAME_PLAYER.LogError("DropResult is null!");
		}
		MsgErrCode val = PlayerMgr.Bag.GainItemList(list);
		if ((int)val > 0)
		{
			return val;
		}
		return (MsgErrCode)0;
	}

	[GM("RefreshShop ShopRefreshId，商店解锁，例：RefreshShop 1110", true)]
	private MsgErrCode RefreshShop(List<string> ParamStringList)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		int resId = 0;
		if (ParamStringList.Count > 0)
		{
			resId = int.Parse(ParamStringList[0]);
		}
		ShopRefreshDesc shopRefreshDesc = GameDBRuntime.GetShopRefreshDesc(resId);
		if (shopRefreshDesc != null)
		{
			MsgErrCode val = PlayerMgr.Shop.RefreshShop(shopRefreshDesc);
			if ((int)val > 0)
			{
				SysLogUtil.GAME_PLAYER.LogError($"RefreshShop Failed, errCode:{val}, ShopId:{shopRefreshDesc.ShopId}, GroupId:{shopRefreshDesc.GroupId}");
				return val;
			}
			return (MsgErrCode)0;
		}
		return (MsgErrCode)10001;
	}

	[GM("EnableFunc interactionFuncId，交互物功能解锁，例：EnableFunc 1001", true)]
	private MsgErrCode EnableFunc(List<string> ParamStringList)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		if (ParamStringList.Count > 0)
		{
			num = int.Parse(ParamStringList[0]);
		}
		if (num > 0)
		{
			PlayerMgr.Interaction.InteractionFuncUnlock(num);
			return (MsgErrCode)0;
		}
		return (MsgErrCode)0;
	}

	[GM("ClearMeditation，清除所有打坐点，例：ClearMeditation", true)]
	private MsgErrCode ClearMeditation(List<string> ParamStringList)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		PlayerMgr.Actor.GMClearMeditationPoint();
		return (MsgErrCode)0;
	}

	[GMNoExport]
	public static void ClearRoleBag(PlayerDataMgr PlayerMgr)
	{
		PlayerMgr.Bag.GMClearBag();
		PlayerMgr.Actor.GMClearActor();
		PlayerMgr.Base.GMClearBase();
	}

	[GM("ClearRoleBag，角色等级设置为0，清除角色背包 天赋 法术，例：ClearRoleBag", true)]
	private MsgErrCode ClearRoleBag(List<string> ParamStringList)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ClearRoleBag(PlayerMgr);
		return (MsgErrCode)0;
	}

	[GM("ReInitRoleData configType RoleId RoleName, 重新初始化角色数据,例：ReInitRoleData 1 10001 robot", true)]
	private MsgErrCode ReInitRoleData(List<string> ParamStringList)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		int configGroup = 1;
		ulong roleId = Player.Base.Roleid;
		string roleName = "null";
		if (ParamStringList.Count > 0)
		{
			configGroup = int.Parse(ParamStringList[0]);
		}
		if (ParamStringList.Count > 1)
		{
			roleId = ulong.Parse(ParamStringList[1]);
		}
		if (ParamStringList.Count > 2)
		{
			roleName = ParamStringList[2];
		}
		ClearRoleBag(PlayerMgr);
		RoleSvc.InitRoleDataByConfig(PlayerMgr, configGroup, roleId, roleName, -1);
		return (MsgErrCode)0;
	}

	[GM("ReInitRoleDataByP4Snapshot SnapshotName", true)]
	private MsgErrCode ReInitRoleDataByP4Snapshoot(List<string> ParamStringList)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count > 0)
		{
			FUStBEDArchivesData val = ArchiveFileUtil.LoadP4RoleSnapshotData(ParamStringList[0]);
			if (val != null)
			{
				RoleDataCS roleCs = val.RoleData.RoleCs;
				roleCs.Base.Roleid = Player.OnlineRoleId;
				roleCs.Base.Name = Player.Base.Name;
				RoleSvc.ReInitRoleDataBySnapshoot(PlayerMgr, roleCs);
				return (MsgErrCode)0;
			}
			return (MsgErrCode)10001;
		}
		return (MsgErrCode)10001;
	}

	[GMNoExport]
	private MsgErrCode ChangeStance(List<string> ParamStringList)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count >= 1)
		{
			Stance targetStance = (Stance)int.Parse(ParamStringList[0]);
			return PlayerMgr.Actor.ChangeStance(targetStance);
		}
		if ((int)PlayerMgr.Actor.GetCurStance() == 0)
		{
			return PlayerMgr.Actor.ChangeStance((Stance)2);
		}
		if ((int)PlayerMgr.Actor.GetCurStance() == 2)
		{
			return PlayerMgr.Actor.ChangeStance((Stance)1);
		}
		return PlayerMgr.Actor.ChangeStance((Stance)0);
	}

	[GM("GMClearLegacy, 清除大圣遗物和大圣天赋,例：GMClearLegacy", true)]
	private MsgErrCode GMClearLegacy(List<string> ParamStringList)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		PlayerMgr.Actor.GetProgress().LegacyList.Clear();
		RepeatedField<TalentOne> talenList = PlayerMgr.Actor.GetProgress().TalenList;
		for (int num = talenList.Count - 1; num >= 0; num--)
		{
			TalentSDesc talentSDesc = GameDBRuntime.GetTalentSDesc(talenList[num].Id);
			if (talentSDesc != null && (int)talentSDesc.Type == 2)
			{
				talenList.RemoveAt(num);
			}
		}
		return (MsgErrCode)0;
	}

	[GM("UnlockMeditation Id, 解锁打坐点,例：UnlockMeditation 1003", true)]
	private MsgErrCode UnlockMeditation(List<string> ParamStringList)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		bool flag2 = false;
		int result = 0;
		if (ParamStringList.Count < 1)
		{
			flag = true;
		}
		else
		{
			flag2 = int.TryParse(ParamStringList[0], out result);
		}
		if (flag)
		{
			foreach (MeditationPointDesc item in GameDBRuntime.GetTBMeditationPointDesc().List)
			{
				PlayerMgr.Actor.UnlockMeditationPoint(item.Id);
			}
			return (MsgErrCode)0;
		}
		if (!flag2)
		{
			return (MsgErrCode)10001;
		}
		if (GameDBRuntime.GetMeditationPointDesc(result) == null)
		{
			return (MsgErrCode)10003;
		}
		PlayerMgr.Actor.UnlockMeditationPoint(result);
		return (MsgErrCode)0;
	}

	[GM("ClearShopData, 清除所有商店数据,例：ClearShopData", true)]
	private MsgErrCode ClearShopData(List<string> ParamStringList)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		PlayerMgr.Shop.GMResetShopData();
		return (MsgErrCode)0;
	}

	[GM("RefreshAllShop, 解锁所有商店,例：RefreshAllShop", true)]
	private MsgErrCode RefreshAllShop(List<string> ParamStringList)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		foreach (ShopRefreshDesc item in GameDBRuntime.GetTBShopRefreshDesc().List)
		{
			MsgErrCode val = PlayerMgr.Shop.RefreshShop(item);
			if ((int)val > 0)
			{
				SysLogUtil.GAME_PLAYER.LogError($"RefreshShop Failed, Error:{val}");
				return val;
			}
		}
		return (MsgErrCode)0;
	}

	[GM("SoulSkill, 获得精魄战技，例：SoulSkill 30", true)]
	private int SoulSkill(List<string> ParamStringList)
	{
		if (ParamStringList.Count < 1)
		{
			SysLogUtil.GAME_PLAYER.LogError("params nums should greater than or equal to 1");
			return 10001;
		}
		int num = int.Parse(ParamStringList[0]);
		if (GameDBRuntime.GetItemDesc(num) == null)
		{
			return 10003;
		}
		PlayerBag.GainSoulSkill(PlayerMgr, num);
		return 0;
	}

	[GM("AllSoulSkill, 获得所有精魄战技，例：AllSoulSkill", true)]
	private int AllSoulSkill(List<string> ParamStringList)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		PlayerMgr.Bag.GMResetSoulSkill();
		foreach (ItemDesc item in GameDBRuntime.GetTBItemDesc().List)
		{
			if ((int)item.ItemType == 18)
			{
				PlayerBag.GainSoulSkill(PlayerMgr, item.Id);
			}
		}
		return 0;
	}

	[GM("SetSoulSkill, 装备精魄战技，例：SetSoulSkill 10", true)]
	private int SetSoulSkill(List<string> ParamStringList)
	{
		if (ParamStringList.Count < 1)
		{
			SysLogUtil.GAME_PLAYER.LogError("params nums should greater than or equal to 1");
			return 10001;
		}
		int num = int.Parse(ParamStringList[0]);
		if (GameDBRuntime.GetItemDesc(num) == null)
		{
			return 10003;
		}
		RoleSoulSkill val = PlayerMgr.Bag.GMFindFirstBagSoulSkill(num);
		if (val == null)
		{
			PlayerBag.GainSoulSkillResult gainSoulSkillResult = PlayerBag.GainSoulSkill(PlayerMgr, num);
			if (gainSoulSkillResult.GenSoulSkillUid != 0)
			{
				PlayerMgr.Actor.SetSoulSkill(num, gainSoulSkillResult.GenSoulSkillUid);
			}
		}
		else
		{
			PlayerMgr.Actor.SetSoulSkill(num, val.Uid);
		}
		return 0;
	}

	[GM("AddPlayTime, 增加游玩时间 参数单位为秒，例：AddPlayTime 60", true)]
	private int AddPlayerTime(List<string> ParamStringList)
	{
		if (ParamStringList.Count < 1)
		{
			SysLogUtil.GAME_PLAYER.LogError("params nums should greater than or equal to 1");
			return 10001;
		}
		int num = int.Parse(ParamStringList[0]);
		Player.CheckTickLowHz(num);
		return 0;
	}

	[GM("SetCurAchievementVersion 设置当前成就版本，例：SetCurAchievementVersion", true)]
	private MsgErrCode SetCurAchievementVersion(List<string> ParamStringList)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count < 1)
		{
			return (MsgErrCode)10001;
		}
		PlayerMgr.Achievement.GMSetCurAchievementVersion((AchievementVersion)int.Parse(ParamStringList[0]));
		return (MsgErrCode)0;
	}

	[GM("PrintCompletedAchievements 查看已完成的成就信息，例：PrintCompletedAchievements", true)]
	private MsgErrCode PrintCompletedAchievements(List<string> ParamStringList)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		foreach (DSAchievementOne value in Player.Achievement.Achievements.ValueList)
		{
			AchievementDesc achievementDesc = GameDBRuntime.GetAchievementDesc(value.Config.AchievementId);
			if ((int)Player.Achievement.AchievementVersion == 36)
			{
				if (GameDBRuntime.GetPlatformAchievementLiteDesc(value.Config.AchievementId) == null)
				{
					continue;
				}
			}
			else if (GameDBRuntime.GetPlatformAchievementDesc(value.Config.AchievementId) == null)
			{
				continue;
			}
			_ = value.CompleteRequirementList.Count;
			_ = value.Config.RequirementCount;
			string format = "AchievementId:{0} Desc:{1}";
			if (value.IsComplete)
			{
				format = string.Format(format, value.Config.AchievementId, GSLocalization.ToFText(achievementDesc.AchiDesc));
				text = text + format + "\n";
			}
		}
		SysLogUtil.GAME_PLAYER.LogInfo(text);
		UB1Util.CopyStringToClipboard(text);
		return (MsgErrCode)0;
	}

	[GM("PrintInProgressAchievements 查看已完成的成就信息，例：PrintInProgressAchievements", true)]
	private MsgErrCode PrintInProgressAchievements(List<string> ParamStringList)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and I4
		string text = "";
		foreach (DSAchievementOne value in Player.Achievement.Achievements.ValueList)
		{
			AchievementDesc achievementDesc = GameDBRuntime.GetAchievementDesc(value.Config.AchievementId);
			if ((int)Player.Achievement.AchievementVersion == 36)
			{
				if (GameDBRuntime.GetPlatformAchievementLiteDesc(value.Config.AchievementId) == null)
				{
					continue;
				}
			}
			else if (GameDBRuntime.GetPlatformAchievementDesc(value.Config.AchievementId) == null)
			{
				continue;
			}
			int count = value.CompleteRequirementList.Count;
			int requirementCount = value.Config.RequirementCount;
			string format = "AchievementId:{0} Desc:{1} Status:{2}";
			if (!value.IsComplete)
			{
				if ((int)achievementDesc.IsProgress == 1)
				{
					format = string.Format(format, value.Config.AchievementId, GSLocalization.ToFText(achievementDesc.AchiDesc), "未解锁");
					format += $" {count}/{requirementCount}";
				}
				else
				{
					format = string.Format(format, value.Config.AchievementId, GSLocalization.ToFText(achievementDesc.AchiDesc), "未解锁");
				}
				text = text + format + "\n";
			}
		}
		SysLogUtil.GAME_PLAYER.LogInfo(text);
		UB1Util.CopyStringToClipboard(text);
		return (MsgErrCode)0;
	}

	[GM("PrintAllAchievements 查看已完成的成就信息，例：PrintAllAchievements", true)]
	private MsgErrCode PrintAllAchievements(List<string> ParamStringList)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Invalid comparison between Unknown and I4
		string text = "";
		foreach (DSAchievementOne value in Player.Achievement.Achievements.ValueList)
		{
			AchievementDesc achievementDesc = GameDBRuntime.GetAchievementDesc(value.Config.AchievementId);
			if ((int)Player.Achievement.AchievementVersion == 36)
			{
				if (GameDBRuntime.GetPlatformAchievementLiteDesc(value.Config.AchievementId) == null)
				{
					continue;
				}
			}
			else if (GameDBRuntime.GetPlatformAchievementDesc(value.Config.AchievementId) == null)
			{
				continue;
			}
			int count = value.CompleteRequirementList.Count;
			int requirementCount = value.Config.RequirementCount;
			string format = "AchievementId:{0} Desc:{1} Status:{2}";
			if (value.IsComplete)
			{
				format = string.Format(format, value.Config.AchievementId, GSLocalization.ToFText(achievementDesc.AchiDesc), "已解锁");
			}
			else if ((int)achievementDesc.IsProgress == 1)
			{
				format = string.Format(format, value.Config.AchievementId, GSLocalization.ToFText(achievementDesc.AchiDesc), "未解锁");
				format += $" {count}/{requirementCount}";
			}
			else
			{
				format = string.Format(format, value.Config.AchievementId, GSLocalization.ToFText(achievementDesc.AchiDesc), "未解锁");
			}
			text = text + format + "\n";
		}
		SysLogUtil.GAME_PLAYER.LogInfo(text);
		UB1Util.CopyStringToClipboard(text);
		return (MsgErrCode)0;
	}

	[GM("ClearCard，清理全部图鉴，例：ClearCard", true)]
	private MsgErrCode ClearCard(List<string> ParamStringList)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		PlayerMgr.Collection.GMClearAllCard();
		PlayerMgr.RedPoint.GMClearRedpointList((RedPointType)11);
		PlayerMgr.RedPoint.GMClearRedpointList((RedPointType)7);
		return (MsgErrCode)0;
	}

	[GM("ClearItem，清理背包Item，例：ClearItem", true)]
	private MsgErrCode ClearItem(List<string> ParamStringList)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count < 1)
		{
			return (MsgErrCode)10001;
		}
		if (int.TryParse(ParamStringList[0], out var result))
		{
			PlayerMgr.Bag.GMClearItemOne(result);
			return (MsgErrCode)0;
		}
		return (MsgErrCode)10001;
	}

	[GM("ClearInterFunc，清空交互功能，例：ClearInterFunc", true)]
	private MsgErrCode ClearInterFunc(List<string> ParamStringList)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		PlayerMgr.Interaction.GMClearInterFuncId();
		return (MsgErrCode)0;
	}

	[GM("AllAchievements，全成就，例：AllAchievements", true)]
	private MsgErrCode AllAchievements(List<string> ParamStringList)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		PlayerMgr.Achievement.GMUnlockAllAchievement();
		return (MsgErrCode)0;
	}

	[GM("UnlockAchievement，解锁某个成就，例：UnlockAchievement 81001", true)]
	private MsgErrCode UnlockAchievement(List<string> ParamStringList)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count < 1)
		{
			return (MsgErrCode)10001;
		}
		if (!int.TryParse(ParamStringList[0], out var result))
		{
			return (MsgErrCode)10001;
		}
		AchievementOne achievement = PlayerMgr.Achievement.FindAchievementOneById(result);
		PlayerMgr.Achievement.GMUnlockAchievemnt(achievement);
		return (MsgErrCode)0;
	}

	[GM("UnlockAchievementExclude，全成就，例：UnlockAchievementExclude 81 81001 81081", true)]
	private MsgErrCode UnlockAchievementExclude(List<string> ParamStringList)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		if (ParamStringList.Count < 1)
		{
			return (MsgErrCode)10001;
		}
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		for (int i = 1; i < ParamStringList.Count; i++)
		{
			if (int.TryParse(ParamStringList[i], out var result))
			{
				list.Add(result);
			}
		}
		if (ParamStringList[0] == "81")
		{
			foreach (PlatformAchievementDesc item in GameDBRuntime.GetTBPlatformAchievementDesc().List)
			{
				list2.Add(item.Id);
			}
		}
		if (ParamStringList[0] == "36")
		{
			foreach (PlatformAchievementLiteDesc item2 in GameDBRuntime.GetTBPlatformAchievementLiteDesc().List)
			{
				list2.Add(item2.Id);
			}
		}
		foreach (int item3 in list2)
		{
			if (!list.Contains(item3))
			{
				AchievementOne achievement = PlayerMgr.Achievement.FindAchievementOneById(item3);
				PlayerMgr.Achievement.GMUnlockAchievemnt(achievement);
			}
		}
		return (MsgErrCode)0;
	}

	public void Not()
	{
		Player = GSG.GamePlayer;
		PlayerMgr = GSG.GamePlayer.CreateTransaction((OPReason)2);
	}
}
