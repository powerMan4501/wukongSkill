using UnrealEngine.Engine;
using UnrealEngine.UMG;

namespace b1.GSMUICore.Event;

public class GSMUITweenWidgetRenderOpacity : GSMUIEventBase
{
	private UWidget TargetWidget;

	private readonly float FromValue;

	private readonly float ToValue;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	public GSMUITweenWidgetRenderOpacity(UWidget TargetWidget, float FromPercent = -1f, float ToPercent = -1f, float Duration = 0.5f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut)
		: base("GSMUITweenBarMatPercent")
	{
		this.TargetWidget = TargetWidget;
		this.Delay = Delay;
		this.Duration = Duration;
		ToValue = ToPercent;
		this.EasingFuncType = EasingFuncType;
		if (FromPercent == -1f && TargetWidget != null)
		{
			FromValue = TargetWidget.GetRenderOpacity();
			return;
		}
		FromValue = FromPercent;
		SetWidgetRenderOpacity(FromValue);
	}

	private void SetWidgetRenderOpacity(float NewOpacity)
	{
		TargetWidget?.SetRenderOpacity(NewOpacity);
	}

	protected override GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		float num = RunTime - Delay;
		if (num <= 0f)
		{
			return GSMUITickableStat.TICKING;
		}
		float x = num / Duration;
		x = MathLib.Clamp(x, 0f, 1f);
		float widgetRenderOpacity = GSEaseFuncInUE.GSMathEase(FromValue, ToValue, x, EasingFuncType);
		SetWidgetRenderOpacity(widgetRenderOpacity);
		if (RunTime >= Duration + Delay)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
