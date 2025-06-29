using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUICore.Event;

public class GSMUITweenBarMatLineMarkScale : GSMUIEventBase
{
	private UImage LineMarkImage;

	private UCurveVector LineMarkScaleCurve;

	private readonly float MaxLength;

	private readonly float FromPercent;

	private readonly float ToPercent;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	public GSMUITweenBarMatLineMarkScale(UImage LineMark, UCurveVector InCurveVector, float MaxLength = 0f, float FromPercent = -1f, float ToPercent = -1f, float Duration = 0.5f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut)
		: base("GSMUITweenBarMatLineMarkScale")
	{
		LineMarkImage = LineMark;
		LineMarkScaleCurve = InCurveVector;
		this.MaxLength = MaxLength;
		this.Delay = Delay;
		this.Duration = Duration;
		this.ToPercent = ToPercent;
		this.EasingFuncType = EasingFuncType;
		this.FromPercent = FromPercent;
	}

	private void SetLineMarkScale(float NewYScale)
	{
		LineMarkImage.SetRenderScale(new FVector2D(1.0, NewYScale));
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
		float num2 = GSEaseFuncInUE.GSMathEase(FromPercent, ToPercent, x, EasingFuncType);
		if (num2 < 1f)
		{
			LineMarkImage.SetVisibility(ESlateVisibility.Visible);
		}
		else
		{
			LineMarkImage.SetVisibility(ESlateVisibility.Hidden);
		}
		UCanvasPanelSlot obj = LineMarkImage.Slot as UCanvasPanelSlot;
		float num3 = MathLib.FFloor(MaxLength * num2);
		obj.SetPosition(new FVector2D(num3, 0.0));
		float y = LineMarkScaleCurve.GetVectorValue(num2).Y;
		SetLineMarkScale(y);
		if (RunTime >= Duration + Delay)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
