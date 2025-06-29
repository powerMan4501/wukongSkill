using System;
using System.Collections.Generic;
using System.Linq;
using b1;
using BtlShare;
using CSharpModBase;
using CSharpModBase.Input;
using HarmonyLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace buff;

[HarmonyPatch]
public class buff : ICSharpMod
{
	public static string Nameo;

	private static Harmony harmony;

	private static AActor wukong;

	private static BuffDescRuntime DescRuntime;

	public string Name => "buffto";

	public string Version => "1.0.0.0";

	public buff()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		harmony = new Harmony(Name);
	}

	public void DeInit()
	{
		harmony.UnpatchAll((string)null);
	}

	public void Init()
	{
		Utils.RegisterKeyBind((Key)112, (Action)test);
		harmony.PatchAll();
	}

	private static void test()
	{
		wukong = (AActor)(object)MyUtils.GetControlledPawn();
		BGUFunctionLibraryCS.BGUAddBuff(wukong, wukong, 710, (EBuffSourceType)0, 100f);
	}

	private static void BuffTo(int BuffID, AActor Caster)
	{
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(BuffID, Caster);
		((IEnumerable<int>)skillEffectDesc.EffectParamsInt).ToList();
		((IEnumerable<float>)skillEffectDesc.EffectParamsFloat).ToList();
	}

	[HarmonyPatch(typeof(BUEffectSpawnBullets), "ApplyByBuff_Implement")]
	[HarmonyPrefix]
	private static bool ApplyByBuff_Implement(ref BuffInstData BuffInst, ref AActor Target, ref int EffectIdx, ref bool bIsPeriodical)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		if (BuffInst == null)
		{
			return false;
		}
		int buffID = BuffInst.BuffID;
		FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(buffID);
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffInst.RootCasterRef));
		if (originalBuffDesc != null)
		{
			DescRuntime = new BuffDescRuntime(buffID, readOnlyData, originalBuffDesc);
		}
		FSpawnBulletMinMaxValue x = default(FSpawnBulletMinMaxValue);
		FSpawnBulletMinMaxValue y = default(FSpawnBulletMinMaxValue);
		FSpawnBulletMinMaxValue z = default(FSpawnBulletMinMaxValue);
		int intEffectParam = DescRuntime.GetIntEffectParam(EffectIdx, 0);
		int intEffectParam2 = DescRuntime.GetIntEffectParam(EffectIdx, 1);
		int intEffectParam3 = DescRuntime.GetIntEffectParam(EffectIdx, 2);
		int intEffectParam4 = DescRuntime.GetIntEffectParam(EffectIdx, 3);
		int intEffectParam5 = DescRuntime.GetIntEffectParam(EffectIdx, 4);
		int intEffectParam6 = DescRuntime.GetIntEffectParam(EffectIdx, 5);
		Nameo = DescRuntime.GetStringEffectParam(EffectIdx, 0);
		int intEffectParam7 = DescRuntime.GetIntEffectParam(EffectIdx, 6);
		float floatEffectParam = DescRuntime.GetFloatEffectParam(EffectIdx, 0);
		float floatEffectParam2 = DescRuntime.GetFloatEffectParam(EffectIdx, 1);
		float floatEffectParam3 = DescRuntime.GetFloatEffectParam(EffectIdx, 2);
		float floatEffectParam4 = DescRuntime.GetFloatEffectParam(EffectIdx, 3);
		float floatEffectParam5 = DescRuntime.GetFloatEffectParam(EffectIdx, 4);
		float floatEffectParam6 = DescRuntime.GetFloatEffectParam(EffectIdx, 5);
		float floatEffectParam7 = DescRuntime.GetFloatEffectParam(EffectIdx, 6);
		MyUtils.sm = Nameo;
		z.LeftValue = DescRuntime.GetIntEffectParam(EffectIdx, 7);
		z.RightValue = DescRuntime.GetIntEffectParam(EffectIdx, 8);
		z.IsEquidistance = true;
		MyUtils.SpwanProjectileByTracker3(intEffectParam, (MyUtils.ETrackType)intEffectParam2, intEffectParam3, new FVector((double)floatEffectParam, (double)floatEffectParam2, (double)floatEffectParam3), new FVector((double)floatEffectParam4, (double)floatEffectParam5, (double)floatEffectParam6), x, y, z, floatEffectParam7, intEffectParam4, intEffectParam5, intEffectParam6, intEffectParam7 == 1);
		return true;
	}
}
