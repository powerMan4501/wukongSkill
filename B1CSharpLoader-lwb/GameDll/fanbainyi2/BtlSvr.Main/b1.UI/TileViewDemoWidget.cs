using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TileViewDemoWidget")]
public class TileViewDemoWidget : BUI_Widget
{
	private UTileView _tileView;

	protected override void OnUIInitialized()
	{
		_tileView = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TileView_Main) as UTileView;
		if (_tileView == null)
		{
			UGSE_EngineFuncLib.LogInfo($"Widget named 'TileView_Main' not found");
			return;
		}
		for (int i = 0; i < 30; i++)
		{
			TileViewDemoItemObject tileViewDemoItemObject = UObject.NewObject<TileViewDemoItemObject>(this);
			tileViewDemoItemObject.skillName = "Default";
			_tileView.AddItem(tileViewDemoItemObject);
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		_tileView.SetScrollbarVisibility(ESlateVisibility.Hidden);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.TileViewDemoWidget");
	}

	static TileViewDemoWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TileViewDemoWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TileViewDemoWidget));
	}
}
