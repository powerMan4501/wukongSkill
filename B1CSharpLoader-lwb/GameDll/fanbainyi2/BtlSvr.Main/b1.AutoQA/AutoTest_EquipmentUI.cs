using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_EquipmentUI")]
internal class AutoTest_EquipmentUI : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_TraversalEquipmentUI(this));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_EquipmentUI");
	}

	static AutoTest_EquipmentUI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_EquipmentUI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_EquipmentUI));
	}
}
