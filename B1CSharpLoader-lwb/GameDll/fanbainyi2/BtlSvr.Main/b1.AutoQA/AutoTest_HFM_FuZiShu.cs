using System;
using b1.BGW;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_HFM_FuZiShu")]
internal class AutoTest_HFM_FuZiShu : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_TestBegin(base.WorldContext, 2002, "RebirthPoint_HFM_Default_C_0", 20101101));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, new FVector(-40277.0, -15785.0, 1903.0), "父子鼠门前"));
		StateStack.Push(new AutoTestNodeLib.TestState_Interact(base.WorldContext, "HFM_DoorVillageOut_C_0"));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		UClass uClass = BGW_PreloadAssetMgr.Get(base.WorldContext).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/Design/Units/HFM/Unit_HFM_FuZiShu.Unit_HFM_FuZiShu_C'", ELoadResourceType.SyncLoadAndCache);
		StateStack.Push(new AutoTestNodeLib.TestState_AutoBattle(base.WorldContext, uClass, AutoTestNodeLib.AutoBattleExitCondition.KillTarget));
		StateStack.Push(new AutoTestNodeLib.TestState_WatchSequence(base.WorldContext));
		StateStack.Push(new AutoTestNodeLib.TestState_AttackOnTheMove(base.WorldContext, "RebirthPoint_HFM_Default_C_2", "藏龙洞外"));
		StateStack.Push(new AutoTestNodeLib.TestState_ActivateRebirthPoint(base.WorldContext, "RebirthPoint_HFM_Default_C_2", AutoTestNodeLib.QARebirthPointChoice.Leave));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_HFM_FuZiShu");
	}

	static AutoTest_HFM_FuZiShu()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_HFM_FuZiShu)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_HFM_FuZiShu));
	}
}
