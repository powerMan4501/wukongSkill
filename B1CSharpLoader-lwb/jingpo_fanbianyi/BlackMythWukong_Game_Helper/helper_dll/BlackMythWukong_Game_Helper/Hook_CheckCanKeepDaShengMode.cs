using System;
using System.Reflection;
using b1;
using HarmonyLib;

namespace BlackMythWukong_Game_Helper;

[HarmonyPatch]
public class Hook_CheckCanKeepDaShengMode
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("b1.BUS_QiTianDaShengComp:CheckCanKeepDaShengMode", (Type[])null, (Type[])null);
	}

	[HarmonyPatch]
	private static bool Prefix(BUS_QiTianDaShengComp __instance, ref bool __result)
	{
		AttrBool attrBool = GlobalObjectMgr.Get<AttrBool>();
		if (attrBool != null)
		{
			__result = true;
			return !attrBool.Trans2DaSheng;
		}
		return true;
	}
}
