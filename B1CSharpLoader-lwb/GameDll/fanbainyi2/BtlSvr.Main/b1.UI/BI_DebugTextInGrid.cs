using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DebugTextInGrid")]
internal class BI_DebugTextInGrid : BUI_Widget
{
	private UImage BG;

	private URichTextBlock Content;

	protected override void OnUIInitialized()
	{
		BG = FindChildWidget("BG") as UImage;
		Content = FindChildWidget("Content") as URichTextBlock;
	}

	public void SetText(string Text)
	{
		Content.SetText(FText.FromString(Text));
	}

	public void SetBGVisibility(ESlateVisibility visibility)
	{
		BG.SetVisibility(visibility);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DebugTextInGrid");
	}

	static BI_DebugTextInGrid()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BI_DebugTextInGrid)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BI_DebugTextInGrid));
	}
}
