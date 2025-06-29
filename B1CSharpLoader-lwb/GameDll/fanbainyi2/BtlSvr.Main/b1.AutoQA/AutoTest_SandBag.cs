using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.AutoTest_SandBag")]
internal class AutoTest_SandBag : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_MonitorSandBag(base.WorldContext, 3600));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_SandBag");
	}

	static AutoTest_SandBag()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_SandBag)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_SandBag));
	}
}
