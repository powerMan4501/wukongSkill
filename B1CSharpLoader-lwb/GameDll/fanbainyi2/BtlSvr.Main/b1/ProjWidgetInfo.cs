using b1.UI.Comm;
using UnrealEngine.Runtime;

namespace b1;

public class ProjWidgetInfo
{
	public BUI_ProjWidget ProjWidget;

	public UGSRoundRectQuick RoundRect;

	public bool UseRoundRectCalSize;

	public FVector2D RoundRectCalSize;

	public UGSRoundRectQuick HideRoundRect;

	public bool NeedCheckProjView;

	public float ShowDistanceMax;

	public bool UseDistanceZoom;

	public float MinScale;

	public float MaxScale;

	public float ScaleRate;

	public float XMinScale;

	public float XMaxScale;

	public float YMinScale;

	public float YMaxScale;

	public ProjWidgetInfo(BUI_ProjWidget InProjWidget, UGSRoundRectQuick InRoundRect = null, bool InUseRoundRectCalSize = false, FVector2D InRoundRectCalSize = default(FVector2D), UGSRoundRectQuick InHideRoundRect = null, bool InUseDistanceZoom = false, bool InNeedCheckProjView = false, float InShowDistanceMax = 0f)
	{
		ProjWidget = InProjWidget;
		BUI_MBarBase bUI_MBarBase = ProjWidget as BUI_MBarBase;
		UseDistanceZoom = bUI_MBarBase != null && InUseDistanceZoom;
		if (UseDistanceZoom)
		{
			MinScale = bUI_MBarBase.MinScale;
			MaxScale = bUI_MBarBase.MaxScale;
			ScaleRate = bUI_MBarBase.ScaleRate;
			XMinScale = bUI_MBarBase.XMinScale;
			XMaxScale = bUI_MBarBase.XMaxScale;
			YMinScale = bUI_MBarBase.YMinScale;
			YMaxScale = bUI_MBarBase.YMaxScale;
		}
		RoundRect = InRoundRect;
		if (RoundRect != null)
		{
			UseRoundRectCalSize = InUseRoundRectCalSize;
			RoundRectCalSize = InRoundRectCalSize;
		}
		HideRoundRect = InHideRoundRect;
		NeedCheckProjView = InNeedCheckProjView;
		ShowDistanceMax = InShowDistanceMax;
	}
}
