using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_ExportInfo")]
internal class AutoTest_ExportInfo : b1.AutoQA.AutoTest_Template
{
	public override float TickInterval => 0f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 5));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.sys ExportSimpleState"));
		StateStack.Push(new AutoTestNodeLib.TestState_ConsoleCommand(base.WorldContext, "b.sys ExportGMData"));
		StateStack.Push(new AutoTestNodeLib.TestState_Wait(base.WorldContext, 5));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_ExportInfo");
	}

	static AutoTest_ExportInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_ExportInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_ExportInfo));
	}
}
