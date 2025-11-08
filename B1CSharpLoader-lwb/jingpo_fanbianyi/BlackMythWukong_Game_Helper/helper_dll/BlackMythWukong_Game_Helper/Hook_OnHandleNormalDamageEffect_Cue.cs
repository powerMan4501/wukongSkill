using System;
using System.Reflection;
using System.Threading.Tasks;
using b1;
using HarmonyLib;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace BlackMythWukong_Game_Helper;

[HarmonyPatch]
public class Hook_OnHandleNormalDamageEffect_Cue
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("b1.BUS_BeAttackedComp:OnHandleNormalDamageEffect_Cue", (Type[])null, (Type[])null);
	}

	[HarmonyPatch]
	private static bool Prefix(BUS_BeAttackedComp __instance, AActor Attacker)
	{
		if (!(Attacker == null))
		{
			AActor controlledPawn = MyUtils.GetControlledPawn();
			AttrBool attrBool = GlobalObjectMgr.Get<AttrBool>();
			if (__instance.GetOwner() == controlledPawn && attrBool.LockPrecise)
			{
				GlobalObjectMgr.Get<ComGp>().Init();
				BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, controlledPawn, 117, EBuffSourceType.Default, 500f);
				switch (attrBool.LockPreciseType)
				{
				case 0:
				{
					Random random = new Random();
					int num = random.Next(1, 4);
					FCastSkillInfo fCastSkillInfo = new FCastSkillInfo(50054, ECastSkillSourceType.PreciseDodge);
					fCastSkillInfo.MontageStartSectionName = new FName("AM_Dasheng_PreciseDodge_F_01");
					fCastSkillInfo.NeedCheckSkillCanCast = false;
					fCastSkillInfo.SkillDirection = (ESkillDirection)num;
					BUS_EventCollectionCS.Get(controlledPawn).Evt_UnitCastSkillTry.Invoke(fCastSkillInfo);
					BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, controlledPawn, 10000102, EBuffSourceType.GM, 1500f);
					BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, controlledPawn, 10000101, EBuffSourceType.GM, 1500f);
					break;
				}
				case 1:
					if (!BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, 10000287))
					{
						GPA(controlledPawn);
					}
					else
					{
						Console.WriteLine("InGP");
					}
					break;
				case 2:
					if (!BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, 10000102))
					{
						SuperCharacter.HuiMaQiang(controlledPawn);
					}
					else
					{
						Console.WriteLine("冷却中");
					}
					break;
				}
			}
		}
		return true;
	}

	private static async void GP(AActor wukong)
	{
		BUS_EventCollectionCS.Get(wukong)?.Evt_TriggerInputActionImpl.Invoke("IA_B1LightAttack", ETriggerEvent.Started, b1.FInputActionValue.True);
		BUS_EventCollectionCS.Get(wukong)?.Evt_TriggerInputActionImpl.Invoke("IA_B1LightAttack", ETriggerEvent.Completed, b1.FInputActionValue.True);
		await Task.Delay(500);
		BGUFunctionLibraryCS.BGUAddBuff(wukong, wukong, 288, EBuffSourceType.Default, 1000f);
		BUS_EventCollectionCS.Get(wukong)?.Evt_TriggerInputActionImpl.Invoke("IA_B1HeavyAttack", ETriggerEvent.Started, b1.FInputActionValue.True);
		BUS_EventCollectionCS.Get(wukong)?.Evt_TriggerInputActionImpl.Invoke("IA_B1HeavyAttack", ETriggerEvent.Completed, b1.FInputActionValue.True);
	}

	private static void GPA(AActor wukong)
	{
		BGUFunctionLibraryCS.BGUAddBuff(wukong, wukong, 10000287, EBuffSourceType.GM, 3000f);
		BGUFunctionLibraryCS.BGUAddBuff(wukong, wukong, 10000101, EBuffSourceType.GM, 1000f);
		FCastSkillInfo fCastSkillInfo = new FCastSkillInfo(10705, ECastSkillSourceType.PreciseDodge);
		fCastSkillInfo.MontageStartSectionName = new FName("AM_Dasheng_PreciseDodge_F_01");
		fCastSkillInfo.NeedCheckSkillCanCast = false;
		BUS_EventCollectionCS.Get(wukong).Evt_UnitCastSkillTry.Invoke(fCastSkillInfo);
	}
}
