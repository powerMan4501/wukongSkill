using System;
using System.Reflection;
using HarmonyLib;
using UnrealEngine.Engine;

namespace BlackMythWukong_Game_Helper;

[HarmonyPatch]
public class onSetBossBar
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("BPS_BattleMainInfoComp:OnSetBossBar", (Type[])null, (Type[])null);
	}

	private static bool Prefix(AActor Actor, float Percent, bool IsAdd)
	{
		if (Actor != null && Actor == BU_PlayerTransSysemA.GetbossActor() && IsAdd)
		{
			return false;
		}
		return true;
	}
}
