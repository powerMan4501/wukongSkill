using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSDebugDrawMessage")]
public class GSDebugDrawMessage : GSDebugDrawBase
{
	private URichTextBlock TxtMessage;

	protected override void Init()
	{
		base.Init();
		TxtMessage = FindChildWidget("TxtMessage") as URichTextBlock;
	}

	protected override void BindEvent()
	{
		base.BindEvent();
		if (Data is DebugDrawMessage debugDrawMessage)
		{
			TxtMessage?.SetText(FText.FromString(debugDrawMessage.Message));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSDebugDrawMessage");
	}

	static GSDebugDrawMessage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDebugDrawMessage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDebugDrawMessage));
	}
}
