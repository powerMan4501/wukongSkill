using System;
using System.Reflection;
using b1;
using HarmonyLib;
using UnrealEngine.Runtime;

namespace BlackMythWukong_Game_Helper;

[HarmonyPatch]
public class HookBGGGameStateCS
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("b1.BGGGameStateCS:AfterInitAllComp", (Type[])null, (Type[])null);
	}

	[HarmonyPatch]
	private static void Prefix(ref BGGGameStateCS __instance)
	{
		if ((UObject)(object)__instance != null)
		{
			GlobalObjectMgr.Add(__instance.ActorCompContainerCS.AddComp(new GameStateSystemMgr()));
			__instance.ActorCompContainerCS?.RecalculateCanTick();
		}
	}
}
