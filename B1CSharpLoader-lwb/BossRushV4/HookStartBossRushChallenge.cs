using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using b1;
using B1UI.GSUI;
using BtlB1;
using HarmonyLib;
using ResB1;

namespace BossRushV4;

[HarmonyPatch]
public class HookStartBossRushChallenge
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("B1UI.GSUI.UIBossIterationsMain:Start_OnLongPressFinishEvent", (Type[])null, (Type[])null);
	}

	private static void Prefix(UIBossIterationsMain __instance)
	{
		if (__instance == null)
		{
			return;
		}
		DSCrossLevelData fieldOrPropertyValue = Utils.GetFieldOrPropertyValue<DSCrossLevelData>("CrossData", __instance, BindingFlags.Instance | BindingFlags.NonPublic);
		if (fieldOrPropertyValue == null || (fieldOrPropertyValue.BossIterationsGroupId.Value != 9993 && fieldOrPropertyValue.BossIterationsGroupId.Value != 9996 && fieldOrPropertyValue.BossIterationsGroupId.Value != 9999))
		{
			return;
		}
		Dictionary<int, FUStBossRushConfigDesc> tBFUStBossRushConfigDesc = GameDBRuntime.GetTBFUStBossRushConfigDesc();
		if (tBFUStBossRushConfigDesc == null)
		{
			return;
		}
		BossIterationsDesc bossIterationsDesc = GameDBRuntime.GetBossIterationsDesc(fieldOrPropertyValue.BossIterationsGroupId.Value);
		if (bossIterationsDesc == null || bossIterationsDesc.BossSuccessiveInfo == null || bossIterationsDesc.BossSuccessiveInfo.Count <= 0)
		{
			return;
		}
		List<FUStBossRushConfigDesc> list = new List<FUStBossRushConfigDesc>();
		foreach (KeyValuePair<int, FUStBossRushConfigDesc> kvp in tBFUStBossRushConfigDesc)
		{
			if (list.FirstOrDefault((FUStBossRushConfigDesc b) => b.LevelName == kvp.Value.LevelName) == null)
			{
				list.Add(kvp.Value);
			}
		}
		for (int num = 0; num < bossIterationsDesc.BossSuccessiveInfo.Count; num++)
		{
			Random random = new Random();
			FUStBossRushConfigDesc val = list[random.Next(list.Count)];
			if (val == null)
			{
				break;
			}
			bossIterationsDesc.BossSuccessiveInfo[num] = val.ID;
			list.Remove(val);
		}
	}
}
