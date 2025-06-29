using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.AutoTest_SpawnTrace")]
internal class AutoTest_SpawnTrace : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 60));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_SpawnTrace");
	}

	static AutoTest_SpawnTrace()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_SpawnTrace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_SpawnTrace));
	}
}
