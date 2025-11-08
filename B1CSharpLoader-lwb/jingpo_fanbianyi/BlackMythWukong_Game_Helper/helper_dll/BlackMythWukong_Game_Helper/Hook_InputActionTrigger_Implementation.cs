using System;
using System.Reflection;
using b1;
using BtlB1;
using BtlShare;
using HarmonyLib;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace BlackMythWukong_Game_Helper;

[HarmonyPatch]
public class Hook_InputActionTrigger_Implementation
{
	public static ComGp GP_ = new ComGp();

	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("b1.UInputActionEventReceiver:InputActionTrigger_Implementation", (Type[])null, (Type[])null);
	}

	[HarmonyPatch]
	private static bool Prefix(string ActionName, ETriggerEvent TriggerEvent)
	{
		switch (ActionName)
		{
		case "IA_B1LightAttack":
			LightAttack();
			break;
		case "IA_B1HeavyAttack":
			HeavyAttack();
			break;
		case "IA_B1Spell_QS":
			SuperCharacter.BU_TimerSystem_Add(1000f, delegate
			{
				ChangeSpell((SpellType)3);
			}, 3);
			break;
		case "IA_B1Spell_SF":
			SuperCharacter.BU_TimerSystem_Add(1000f, delegate
			{
				ChangeSpell((SpellType)1);
			}, 1);
			break;
		}
		return true;
	}

	private static void HeavyAttack()
	{
		AttrBool attrBool = GlobalObjectMgr.Get<AttrBool>();
		if (attrBool.LockPrecise)
		{
			AActor controlledPawn = MyUtils.GetControlledPawn();
			ComGp comGp = GlobalObjectMgr.Get<ComGp>();
			comGp.Init();
			if (BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, 10000287) && !BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, 10000101))
			{
				if (comGp.Next(10705) != null)
				{
					FCastSkillInfo fCastSkillInfo = new FCastSkillInfo(comGp.NextSkill, ECastSkillSourceType.PreciseDodge);
					fCastSkillInfo.MontageStartSectionName = new FName("AM_Dasheng_PreciseDodge_F_01");
					fCastSkillInfo.NeedCheckSkillCanCast = false;
					BUS_EventCollectionCS.Get(controlledPawn).Evt_UnitCastSkillTry.Invoke(fCastSkillInfo);
					GP_.CurrentSkill = comGp.NextSkill;
				}
				BGUFunctionLibraryCS.BGURemoveBuff(controlledPawn, 10000287, (EBuffEffectTriggerType)1, 1);
				BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, controlledPawn, 10000101, EBuffSourceType.GM, 1500f);
			}
			else if (comGp.Next(50054) != null && BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, 10000102))
			{
				FCastSkillInfo fCastSkillInfo2 = new FCastSkillInfo(comGp.NextSkill, ECastSkillSourceType.PreciseDodge);
				fCastSkillInfo2.MontageStartSectionName = new FName("AM_Dasheng_PreciseDodge_F_01");
				fCastSkillInfo2.NeedCheckSkillCanCast = false;
				BUS_EventCollectionCS.Get(controlledPawn).Evt_UnitCastSkillTry.Invoke(fCastSkillInfo2);
				GP_.CurrentSkill = 0;
				BGUFunctionLibraryCS.BGURemoveBuff(controlledPawn, 10000102, (EBuffEffectTriggerType)1, 1);
				BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, controlledPawn, 10000101, EBuffSourceType.GM, 1500f);
			}
			else if (comGp.Next(GP_.CurrentSkill) != null && !BGUFunctionLibraryCS.BGUHasBuffByID(controlledPawn, 10000101))
			{
				FCastSkillInfo fCastSkillInfo3 = new FCastSkillInfo(comGp.NextSkill, ECastSkillSourceType.PreciseDodge);
				fCastSkillInfo3.MontageStartSectionName = new FName("AM_Dasheng_PreciseDodge_F_01");
				fCastSkillInfo3.NeedCheckSkillCanCast = false;
				BUS_EventCollectionCS.Get(controlledPawn).Evt_UnitCastSkillTry.Invoke(fCastSkillInfo3);
				GP_.CurrentSkill = comGp.NextSkill;
				BGUFunctionLibraryCS.BGUAddBuff(controlledPawn, controlledPawn, 10000101, EBuffSourceType.GM, 1500f);
			}
		}
		else
		{
			GP_.CurrentSkill = 0;
		}
	}

	private static void LightAttack()
	{
	}

	private static void ChangeSpell(SpellType spellType)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		AttrBool attrBool = GlobalObjectMgr.Get<AttrBool>();
		if (attrBool.LockSpellRebirth)
		{
			int num = PlayerGm.SpellChage(spellType);
			if (num != 0)
			{
				CD0(num);
			}
		}
	}

	private static void CD0(int SpellId)
	{
		AttrBool attrBool = GlobalObjectMgr.Get<AttrBool>();
		if (attrBool.SpellCD_0)
		{
			PlayerGm.SpellCD(SpellId, attrBool.SpellCD_0_All);
		}
	}
}
