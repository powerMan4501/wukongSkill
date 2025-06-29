using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_AllUI")]
internal class AutoTest_AllUI : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_PreTraversalAllUI(this));
		StateStack.Push(new TestState_TraversalLegacyUI(this, 5, InIsDebug: false, InIsChangeBagState: false));
		StateStack.Push(new TestState_TraversalTravelNotesUI(this, 5, InIsDebug: false, InIsChangeBagState: false));
		StateStack.Push(new TestState_TraversalEquipmentUI(this, 5, InIsDebug: false, InIsChangeBagState: false));
		StateStack.Push(new TestState_TraversalBagUI(this, 5, InIsDebug: false, InIsChangeBagState: false));
		StateStack.Push(new TestState_PostTraversalAllUI(this));
		StateStack.Push(new TestState_MemReportAnalysis(base.WorldContext, "PreTraversalAllUI.memreport", "PostTraversalAllUI.memreport"));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_AllUI");
	}

	static AutoTest_AllUI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_AllUI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_AllUI));
	}
}
