using UnrealEngine.Engine;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.GSMUICore.Event;

public class GSMUITweenBarLength : GSMUIEventBase
{
	private UWidget TargetWidget;

	private readonly float BarMaxLength;

	private readonly float FromLength;

	private readonly float ToLength;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	public GSMUITweenBarLength(UWidget RefWidget, float BarMaxLength, float FromLength = -1f, float ToLength = -1f, float Duration = 0.5f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut)
		: base("GSMUITweenBarLength")
	{
		TargetWidget = RefWidget;
		this.Delay = Delay;
		this.Duration = Duration;
		this.ToLength = ToLength;
		this.EasingFuncType = EasingFuncType;
		this.BarMaxLength = BarMaxLength;
		if (FromLength == -1f)
		{
			this.FromLength = UGSE_UMGFuncLib.GetWidgetLocalSize(RefWidget).X;
			return;
		}
		this.FromLength = FromLength;
		SetOverlaySlotLength(TargetWidget, this.FromLength);
	}

	private void SetOverlaySlotLength(UWidget TargetWidget, float NewLength)
	{
		UOverlaySlot obj = TargetWidget.Slot as UOverlaySlot;
		FMargin padding = obj.Padding;
		padding.Right = BarMaxLength - NewLength;
		obj.SetPadding(padding);
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
		float newLength = GSEaseFuncInUE.GSMathEase(FromLength, ToLength, x, EasingFuncType);
		SetOverlaySlotLength(TargetWidget, newLength);
		if (RunTime >= Duration + Delay)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
