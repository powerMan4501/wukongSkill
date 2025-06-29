using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_SlateDebug")]
public class BUI_SlateDebug : BUI_Widget
{
	private static int[] StatTickTimeDataInUs;

	private UTextBlock SlateTickTxt;

	public static void UpdateStatTickTime(EGSSlateDebugTime TickTimeType, int ValueInUs)
	{
		if ((int)TickTimeType < 3)
		{
			StatTickTimeDataInUs[(uint)TickTimeType] = ValueInUs;
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		SlateTickTxt = FindChildWidget("SlateTickTxt") as UTextBlock;
	}

	private float GetTickTimeInMs(EGSSlateDebugTime TickTimeType)
	{
		return (float)Math.Round((double)StatTickTimeDataInUs[(uint)TickTimeType] / 1000.0, 3);
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		string text = $"TotalMainUITick:{GetTickTimeInMs(EGSSlateDebugTime.TotalMainUITick)} ms\n";
		text += $"UIActorMgrTick:{GetTickTimeInMs(EGSSlateDebugTime.UIActorMgrTick)} ms\n";
		text += $"DoGSQuickTick:{GetTickTimeInMs(EGSSlateDebugTime.DoGSQuickTick)} ms\n";
		SlateTickTxt?.SetText(FText.FromString(text));
	}

	static BUI_SlateDebug()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_SlateDebug)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_SlateDebug));
		StatTickTimeDataInUs = new int[4];
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_SlateDebug");
	}
}
