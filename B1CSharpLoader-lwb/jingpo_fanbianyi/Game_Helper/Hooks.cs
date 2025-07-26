using System;
using System.Reflection;
using b1;
using BtlShare;
using CommB1;
using HarmonyLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace Game_Helper;

[HarmonyPatch]
public class Hooks
{
	[HarmonyPatch]
	public class HookBUS_QiTianDaShengComp
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("b1.BUS_QiTianDaShengComp:InitDaShengConfig", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static void Prefix()
		{
			Tools.RegistAllComp();
			Console.WriteLine("HOOk:BUS_QiTianDaShengComp:InitDaShengConfig");
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(2307);
			if (itemDesc != null)
			{
				itemDesc.Name = "浪漫的最爱";
				itemDesc.EffectDesc = "饮酒后短时间内，缓缓恢复些微<{0}_KW>40%生命</>";
			}
		}
	}

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
				Tools.gameHelperMgrSystem = __instance.ActorCompContainerCS.AddComp<GameHelperMgrSystem>(new GameHelperMgrSystem(), int.MaxValue, 0);
				UActorCompContainerCS actorCompContainerCS = __instance.ActorCompContainerCS;
				if (actorCompContainerCS != null)
				{
					actorCompContainerCS.RecalculateCanTick();
				}
			}
		}
	}

	[HarmonyPatch]
	public class hookTickInputForMoving
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("BUS_PlayerInputActionComp:TickInputForMoving", (Type[])null, (Type[])null);
		}

		private static void Postfix(in FVector MoveInputAxis, float DeltaTime)
		{
			if (MoveInputAxis.X == 0f && MoveInputAxis.Y != 0f)
			{
			}
		}
	}

	[HarmonyPatch]
	public class OnPlayerRebirth
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("BUS_PlayerCameraCompImpl:OnPlayerRebirth", (Type[])null, (Type[])null);
		}

		private unsafe static void Postfix(ERebirthType Rebirthtype)
		{
			Console.WriteLine(((object)(*(ERebirthType*)(&Rebirthtype))/*cast due to .constrained prefix*/).ToString());
		}
	}

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

	[HarmonyPatch]
	public class HookB1BattleLogicSvc
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("B1UI.GSSvc.B1BattleLogicSvc:UseItem", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static void Prefix(int ItemId)
		{
			Tools.InDsMod(ItemId);
		}
	}

	[HarmonyPatch]
	public class HookBUS_PlayerInputActionComp
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("b1.BUS_PlayerInputActionComp:OnTriggerItemSkillAction_ShortCut", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static void Prefix(int InputActionID)
		{
			FUStEnhancedInputActionDesc enhancedInputActionDesc = BGW_GameDB.GetEnhancedInputActionDesc(InputActionID);
			if (enhancedInputActionDesc == null || enhancedInputActionDesc.InputActionParamsInt.Count == 0)
			{
				return;
			}
			int num = enhancedInputActionDesc.InputActionParamsInt[0];
			IBPC_PlayerRoleData playerRoleData = Tools.TimerAndPlayerDataComp.PlayerRoleData;
			if (playerRoleData == null)
			{
				return;
			}
			foreach (ReadOnlyShortcutItem shortcuts in playerRoleData.RoleData.RoleCs.Actor.Wear.ShortcutsList)
			{
				if (shortcuts.Position == playerRoleData.DefaultShortcutsPosition)
				{
					Tools.InDsMod(shortcuts.ItemId);
					break;
				}
			}
		}
	}

	[HarmonyPatch]
	public class HookBUS_MagicallyChangeComp
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("b1.BUS_MagicallyChangeComp:OnTriggerVigorSkill", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static void Prefix(ref int VigorSkillID)
		{
			if (Tools.bossSkillInfos != null && Tools.bossskill > Tools.bossSkillInfos.Count - 1)
			{
				Tools.bossskill = 0;
			}
			if (!BU_PlayerTransSystem.IsReleasingSkills && Tools.bossSkillInfos != null && Tools.modSet.CanUseBossSkill)
			{
				VigorSkillID = 10000 + VigorSkillID;
				Tools.BossSkillInfo[] array = Tools.bossSkillInfos.ToArray();
				Console.WriteLine($"{array[Tools.bossskill].Name};{array[Tools.bossskill].Skill}");
				Tools.PlayerTrans(array[Tools.bossskill].BossID, isInit: true, array[Tools.bossskill].Skill, 0.7f);
				Tools.bossskill++;
			}
		}
	}

	public class HookBGU_CharacterAI
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("b1.BGU_CharacterAI:InitAllComp", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static void Prefix(BGU_CharacterAI __instance)
		{
			if ((UObject)(object)__instance != null && ((AActor)(object)__instance).GetOwner() != null)
			{
				AActor owner = ((AActor)(object)__instance).GetOwner();
				if (!(owner != null))
				{
				}
			}
		}
	}

	public class HookBUS_AttrComp
	{
		private static MethodBase TargetMethod()
		{
			return AccessTools.Method("b1.BUS_AttrComp:OnAttach", (Type[])null, (Type[])null);
		}

		[HarmonyPatch]
		private static void Prefix(BUS_AttrComp __instance)
		{
			if (__instance != null && ((UActorCompBaseCS)__instance).GetOwner() != null)
			{
				AActor owner = ((UActorCompBaseCS)__instance).GetOwner();
				if (!(owner != null))
				{
				}
			}
		}
	}

	public static T GetPrivateField<T>(object Obj, string FieldName)
	{
		return (T)Obj.GetType().GetField(FieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(Obj);
	}

	public static T GetPrivateField<T>(Type t, string FieldName)
	{
		return (T)t.GetField(FieldName, BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
	}

	[HarmonyPatch(typeof(BUS_MagicallyChangeComp), "Reset")]
	[HarmonyPrefix]
	private static bool Reset(BUS_MagicallyChangeComp __instance)
	{
		if (Tools.BU_PlayerTransSystem != null)
		{
			if (Tools.BU_PlayerTransSystem.isInTrans && !BU_PlayerTransSystem.IsInit && ((UActorCompBaseCS)__instance).GetOwner() == MyUtils.GetControlledPawn())
			{
				BU_PlayerTransSystem.IsReleasingSkills = false;
				return false;
			}
			BU_PlayerTransSystem.IsReleasingSkills = false;
			BU_PlayerTransSystem.Init();
			return true;
		}
		return true;
	}

	[HarmonyPatch(typeof(BUEffectSpawnEmitter), "ApplyByBuff_Implement")]
	[HarmonyPrefix]
	private static bool ApplyByBuff_Implement(ref BuffInstData BuffInst, ref AActor Target, ref int EffectIdx, ref bool bIsPeriodical)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		int buffID = BuffInst.BuffID;
		FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(buffID);
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffInst.RootCasterRef));
		if (originalBuffDesc != null)
		{
			BuffDescRuntime buffDescRuntime = new BuffDescRuntime(buffID, readOnlyData, originalBuffDesc);
			if (Tools.buffRun != null && Tools.buffRun.IsKey(buffDescRuntime, EffectIdx))
			{
				Tools.buffRun.Run(buffDescRuntime, EffectIdx);
				return false;
			}
		}
		return true;
	}

	[HarmonyPatch(typeof(BUS_QiTianDaShengComp), "CheckCanKeepDaShengMode")]
	[HarmonyPrefix]
	public static bool CheckCanKeepDaSheng(ref BUS_QiTianDaShengComp __instance, ref bool __result)
	{
		__result = true;
		return !Tools.modSet.InDsMod;
	}
}
