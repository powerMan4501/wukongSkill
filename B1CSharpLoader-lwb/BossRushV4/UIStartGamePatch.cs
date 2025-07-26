using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using b1;
using b1.Protobuf.GSProtobufRuntimeAPI;
using BtlB1;
using HarmonyLib;
using ResB1;

namespace BossRushV4;

[HarmonyPatch]
public class UIStartGamePatch
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("B1UI.GSUI.UIStartGame:OnUIPageConstructImpl", (Type[])null, (Type[])null);
	}

	private static BossIterationsDesc NewRandom(int randomCount = 3)
	{
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(1);
		if (bossIterationsDesc == null)
		{
			return null;
		}
		BossIterationsDesc val = bossIterationsDesc.Clone();
		val.Id = 9990 + randomCount;
		val.GroupName = ((randomCount == 9) ? "随机全Boss" : $"随机{randomCount}连");
		val.SortId = 9990 + randomCount;
		val.LocalizationTag = 1;
		val.PictureId = 0;
		val.BattleEndBuff = 415;
		val.BossSuccessiveInfo.Clear();
		val.LimitTimeList.Clear();
		if (randomCount == 9)
		{
			Dictionary<int, FUStBossRushConfigDesc> tBFUStBossRushConfigDesc = GameDBRuntime.GetTBFUStBossRushConfigDesc();
			if (tBFUStBossRushConfigDesc != null)
			{
				List<FUStBossRushConfigDesc> list = new List<FUStBossRushConfigDesc>();
				foreach (KeyValuePair<int, FUStBossRushConfigDesc> kvp in tBFUStBossRushConfigDesc)
				{
					if (list.FirstOrDefault((FUStBossRushConfigDesc b) => b.LevelName == kvp.Value.LevelName) == null)
					{
						list.Add(kvp.Value);
					}
				}
				for (int num = 0; num < list.Count; num++)
				{
					val.BossSuccessiveInfo.Add(202201);
					val.LimitTimeList.Add(360);
				}
				val.UnlockInfo.Clear();
				for (int num2 = 0; num2 < list.Count; num2++)
				{
					val.UnlockInfo.Add(new BossUnlockConfig
					{
						UnlockCondition = (EBossUnlockCondition)1,
						UnlockId = 202201
					});
				}
			}
		}
		else
		{
			for (int num3 = 0; num3 < randomCount; num3++)
			{
				val.BossSuccessiveInfo.Add(202201);
				val.LimitTimeList.Add(360);
			}
			val.UnlockInfo.Clear();
			for (int num4 = 0; num4 < randomCount; num4++)
			{
				val.UnlockInfo.Add(new BossUnlockConfig
				{
					UnlockCondition = (EBossUnlockCondition)1,
					UnlockId = 202201
				});
			}
		}
		val.IterationsAward.Clear();
		switch (randomCount)
		{
		case 3:
			val.IterationsAward.Add(new ItemOne
			{
				Id = 3309,
				Num = 2
			});
			val.IterationsAward.Add(new ItemOne
			{
				Id = 3952,
				Num = 2
			});
			val.IterationsAward.Add(new ItemOne
			{
				Id = 3960,
				Num = 2
			});
			break;
		case 6:
			val.IterationsAward.Add(new ItemOne
			{
				Id = 3310,
				Num = 1
			});
			val.IterationsAward.Add(new ItemOne
			{
				Id = 3954,
				Num = 1
			});
			val.IterationsAward.Add(new ItemOne
			{
				Id = 3962,
				Num = 1
			});
			break;
		case 9:
			val.IterationsAward.Add(new ItemOne
			{
				Id = 3310,
				Num = 10
			});
			val.IterationsAward.Add(new ItemOne
			{
				Id = 3954,
				Num = 10
			});
			val.IterationsAward.Add(new ItemOne
			{
				Id = 3962,
				Num = 10
			});
			break;
		}
		val.LimitTime = 0;
		return val;
	}

	private static void AddRandom(int count, MethodInfo method, object instance)
	{
		BossIterationsDesc val = NewRandom(count);
		BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(val.Id);
		if (bossIterationsDesc == null)
		{
			method.Invoke(instance, new object[1] { val });
			Console.WriteLine("random ID " + val.Id + " Count " + count);
		}
	}

	private static void AddRandomToList(int count)
	{
		BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(9990 + count);
		if (bossIterationsDesc != null)
		{
			TBBossIterationsDesc tBBossIterationsDesc = GameDBRuntime.GetTBBossIterationsDesc();
			if (tBBossIterationsDesc != null && !tBBossIterationsDesc.List.Contains(bossIterationsDesc))
			{
				tBBossIterationsDesc.List.Add(bossIterationsDesc);
			}
		}
	}

	public static void Postfix(object __instance)
	{
		GSProtobufRuntimeAPI<TBBossIterationsDesc, BossIterationsDesc> val = GSProtobufRuntimeAPI<TBBossIterationsDesc, BossIterationsDesc>.Get();
		Console.WriteLine("protoData " + (object)val);
		Type type = ((object)val).GetType();
		Console.WriteLine("type " + type);
		MethodInfo method = type.GetMethod("TryAddToDictionary", BindingFlags.Instance | BindingFlags.NonPublic);
		Console.WriteLine("method " + method);
		if (!(method != null))
		{
			return;
		}
		AddRandom(3, method, val);
		AddRandom(6, method, val);
		AddRandom(9, method, val);
		BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(99);
		if (bossIterationsDesc == null)
		{
			if (BossRushV4.Instance.CustomBossIterationConfig == null)
			{
				BossIterationsDesc bossIterationsDesc2 = GameDBRuntime.GetBossIterationsDesc(1);
				if (bossIterationsDesc2 == null)
				{
					return;
				}
				BossIterationsDesc val2 = bossIterationsDesc2.Clone();
				val2.Id = 99;
				val2.GroupName = "自定义连战";
				val2.SortId = 99;
				val2.LocalizationTag = 1;
				val2.PictureId = 0;
				val2.BattleEndBuff = 415;
				method.Invoke(val, new object[1] { val2 });
				Console.WriteLine(" Add Iteration Success ");
			}
			else
			{
				method.Invoke(val, new object[1] { BossRushV4.Instance.CustomBossIterationConfig.CustomBossIterationDesc });
				Console.WriteLine(" Add Iteration Success ");
			}
		}
		AddRandomToList(3);
		AddRandomToList(6);
		AddRandomToList(9);
		BossIterationsDesc bossIterationsDesc3 = GameDBRuntime.GetBossIterationsDesc(99);
		if (bossIterationsDesc3 != null)
		{
			TBBossIterationsDesc tBBossIterationsDesc = GameDBRuntime.GetTBBossIterationsDesc();
			if (tBBossIterationsDesc != null && !tBBossIterationsDesc.List.Contains(bossIterationsDesc3))
			{
				tBBossIterationsDesc.List.Add(bossIterationsDesc3);
			}
		}
		CustomBossIterationConfig customBossIterationConfig = BossRushV4.Instance.CustomBossIterationConfig;
		if (customBossIterationConfig == null || customBossIterationConfig.CustomBossIterationDesc == null || customBossIterationConfig.CustomBossIterationDesc.BossSuccessiveInfo == null || customBossIterationConfig.CustomBossIterationDesc.BossSuccessiveInfo.Count <= 0)
		{
			return;
		}
		foreach (int item in customBossIterationConfig.CustomBossIterationDesc.BossSuccessiveInfo)
		{
			FUStBossRushConfigDesc fUStBossRushConfigDesc = GameDBRuntime.GetFUStBossRushConfigDesc(item);
			if (fUStBossRushConfigDesc != null && !BossRushV4.Instance.IterationsList.Contains(fUStBossRushConfigDesc))
			{
				BossRushV4.Instance.IterationsList.Add(fUStBossRushConfigDesc);
			}
		}
	}
}
