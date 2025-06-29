using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUICore.Event;

public class GSMEventWidgetQuickBezierTo : GSMUIEventBase
{
	private UWidget TargetWidget;

	private readonly float DelayTime;

	private readonly FVector2D Start;

	private readonly FVector2D Control;

	private readonly FVector2D End;

	private readonly float Duration;

	private readonly ENGSEasingFunc EasingFunc;

	public GSMEventWidgetQuickBezierTo(UWidget RefWidget, FVector2D Start = default(FVector2D), FVector2D Control = default(FVector2D), FVector2D End = default(FVector2D), float Duration = 1f, float DelayTime = 0f, ENGSEasingFunc TEasingFunc = ENGSEasingFunc.EaseOut)
		: base("GSMEventWidgetQuickBezierTo")
	{
		this.DelayTime = DelayTime;
		TargetWidget = RefWidget;
		this.Start = Start;
		this.End = End;
		this.Control = Control;
		this.Duration = Duration;
		EasingFunc = TEasingFunc;
	}

	private FVector2D CalcBezierPos(float t)
	{
		float num = 1f - t;
		float num2 = t * t;
		return num * num * Start + 2f * num * t * Control + num2 * End;
	}

	protected override GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		if (RunTime < DelayTime)
		{
			return GSMUITickableStat.TICKING;
		}
		float num = RunTime - DelayTime;
		float t = GSEaseFunc.Ease(Alpha: MathLib.Clamp(num / Duration, 0f, 1f), ENGSEasingFunc: EasingFunc, Start: 0f, End: 1f);
		FVector2D renderTranslation = CalcBezierPos(t);
		TargetWidget.SetRenderTranslation(renderTranslation);
		if (num >= Duration)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
