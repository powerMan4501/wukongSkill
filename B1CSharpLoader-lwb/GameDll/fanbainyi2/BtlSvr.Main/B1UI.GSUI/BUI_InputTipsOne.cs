using System;
using b1;
using b1.Plugins.GSInput;
using b1.UI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace B1UI.GSUI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_InputTipsOne")]
public class BUI_InputTipsOne : BUI_Widget
{
	private UGSInputActionIcon ImgIcon;

	private UTextBlock TxtDesc;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ImgIcon = FindChildWidget("InputIcon") as UGSInputActionIcon;
		TxtDesc = FindChildWidget("TxtDesc") as UTextBlock;
	}

	public void InitData(FInputTipsOneCfg OneCfg)
	{
		ImgIcon.SetInputAction(OneCfg.InputAction);
		if (OneCfg.TxtDesc.IsEmpty())
		{
			TxtDesc.SetVisibility(ESlateVisibility.Collapsed);
			return;
		}
		TxtDesc.SetText(OneCfg.TxtDesc);
		TxtDesc.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_InputTipsOne");
	}

	static BUI_InputTipsOne()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_InputTipsOne)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_InputTipsOne));
	}
}
