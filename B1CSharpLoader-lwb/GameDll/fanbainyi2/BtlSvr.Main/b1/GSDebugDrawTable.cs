using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSDebugDrawTable")]
public class GSDebugDrawTable : GSDebugDrawBase
{
	private URichTextBlock TxtMessage0;

	private URichTextBlock TxtMessage1;

	protected override void Init()
	{
		base.Init();
		TxtMessage0 = FindChildWidget("TxtMessage_0") as URichTextBlock;
		TxtMessage1 = FindChildWidget("TxtMessage_1") as URichTextBlock;
	}

	protected override void BindEvent()
	{
		base.BindEvent();
		if (Data is DebugDrawTable debugDrawTable)
		{
			TxtMessage0?.SetText(FText.FromString(debugDrawTable.Message0));
			TxtMessage1?.SetText(FText.FromString(debugDrawTable.Message1));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSDebugDrawTable");
	}

	static GSDebugDrawTable()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDebugDrawTable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDebugDrawTable));
	}
}
