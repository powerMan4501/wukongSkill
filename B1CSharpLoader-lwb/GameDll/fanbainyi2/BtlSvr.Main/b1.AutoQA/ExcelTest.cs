using System;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.ExcelTest")]
internal class ExcelTest : b1.AutoQA.AutoTest_Template
{
	protected override void RegisterTestState()
	{
		StateStack.Push(new b1.AutoQA.TestState_ReportExcelError(this));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.ExcelTest");
	}

	static ExcelTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.ExcelTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.ExcelTest));
	}
}
