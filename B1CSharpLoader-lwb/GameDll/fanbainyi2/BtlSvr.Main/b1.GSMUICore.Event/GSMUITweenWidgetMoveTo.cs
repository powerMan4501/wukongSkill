using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUICore.Event;

public class GSMUITweenWidgetMoveTo : GSMUIEventBase
{
	private readonly float FromValue;

	private readonly float ToPercent = 1f;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	private UWidget TargetWidget;

	private FVector2D TargetPos;

	private FVector2D OriPos;

	private UCanvasPanelSlot Slot;

	public GSMUITweenWidgetMoveTo(UWidget TargetWidget, FVector2D TargetPos, float Duration = 0.5f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut)
		: base("GSMUITweenWidgetMoveTo")
	{
		this.TargetWidget = TargetWidget;
		this.Delay = Delay;
		this.Duration = Duration;
		this.TargetPos = TargetPos;
		Slot = TargetWidget?.Slot as UCanvasPanelSlot;
		OriPos = Slot.GetPosition();
		this.EasingFuncType = EasingFuncType;
	}

	private void SetWidgetPosition(float Alpha)
	{
		FVector2D position = OriPos + (TargetPos - OriPos) * Alpha;
		Slot.SetPosition(position);
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
		float widgetPosition = GSEaseFuncInUE.GSMathEase(FromValue, ToPercent, x, EasingFuncType);
		SetWidgetPosition(widgetPosition);
		if (RunTime >= Duration + Delay)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
