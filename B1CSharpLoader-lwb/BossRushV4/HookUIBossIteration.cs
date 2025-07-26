using System;
using System.Reflection;
using b1;
using B1UI.GSUI;
using HarmonyLib;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace BossRushV4;

[HarmonyPatch]
public class HookUIBossIteration
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("B1UI.GSUI.UIBossIterationsMain:OnChangeEnemyIdx", (Type[])null, (Type[])null);
	}

	private static void Postfix(UIBossIterationsMain __instance, ChangeReason Reason, int OldValue, int NewValue)
	{
		if (__instance == null)
		{
			return;
		}
		DSCrossLevelData fieldOrPropertyValue = Utils.GetFieldOrPropertyValue<DSCrossLevelData>("CrossData", __instance, BindingFlags.Instance | BindingFlags.NonPublic);
		if (fieldOrPropertyValue != null && (fieldOrPropertyValue.BossIterationsGroupId.Value == 9993 || fieldOrPropertyValue.BossIterationsGroupId.Value == 9996 || fieldOrPropertyValue.BossIterationsGroupId.Value == 9999))
		{
			URichTextBlock fieldOrPropertyValue2 = Utils.GetFieldOrPropertyValue<URichTextBlock>("RichTxtName", __instance, BindingFlags.Instance | BindingFlags.NonPublic);
			if (fieldOrPropertyValue2 != null)
			{
				fieldOrPropertyValue2.SetText(FText.FromString("随机"));
			}
		}
	}
}
