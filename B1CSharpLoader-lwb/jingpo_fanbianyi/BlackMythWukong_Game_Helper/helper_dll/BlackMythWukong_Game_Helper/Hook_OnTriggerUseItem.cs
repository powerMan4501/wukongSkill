using System;
using System.Reflection;
using b1;
using BtlB1;
using BtlShare;
using HarmonyLib;
using UnrealEngine.Engine;

namespace BlackMythWukong_Game_Helper;

[HarmonyPatch]
public class Hook_OnTriggerUseItem
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("b1.BGU.BUS.BUS_PlayerItemClientSystem:OnTriggerUseItem", (Type[])null, (Type[])null);
	}

	[HarmonyPatch]
	private static bool Prefix(int ItemId)
	{
		UseItem(ItemId);
		return true;
	}

	private static void UseItem(int itemId)
	{
		AttrBool att = GlobalObjectMgr.Get<AttrBool>();
		if (itemId == att.InDsModItemID)
		{
			att.Trans2DaSheng = true;
			AActor Owner = MyUtils.GetControlledPawn();
			SuperCharacter.BU_TimerSystem_Add(0.5f, delegate
			{
				if (Owner != null)
				{
					FUStTransQiTianDaShengConfigDesc transQiTianDaShengConfigDesc = BGW_GameDB.GetTransQiTianDaShengConfigDesc(1, Owner);
					transQiTianDaShengConfigDesc.Duration = att.Duration;
					BUS_EventCollectionCS.Get(Owner)?.Evt_TriggerTrans2DaSheng.Invoke();
					BGUFunctionLibraryCS.BGUSetAttrValue(MyUtils.GetControlledPawn(), (EBGUAttrFloat)191, 480f);
					Console.WriteLine($"使用丹药{itemId}进入大圣模式");
				}
			});
		}
		Console.WriteLine(itemId);
	}
}
