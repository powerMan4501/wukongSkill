using UnrealEngine.Engine;
using UnrealEngine.UMG;

namespace b1.GSMUICore.Event;

public class GSMUITweenBlink : GSMUIEventBase
{
	private UWidget TargetWidget;

	private readonly float FromOpacity;

	private readonly float ToOpacity;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	public GSMUITweenBlink(UWidget RefWidget, float FromOpacity = 0f, float ToOpacity = 1f, float Duration = 0.1f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut)
		: base("GSMUITweenBlink")
	{
		TargetWidget = RefWidget;
		this.Delay = Delay;
		this.Duration = Duration;
		this.ToOpacity = ToOpacity;
		this.EasingFuncType = EasingFuncType;
		if (FromOpacity == -1f)
		{
			this.FromOpacity = TargetWidget.GetRenderOpacity();
			return;
		}
		this.FromOpacity = FromOpacity;
		TargetWidget.SetRenderOpacity(FromOpacity);
	}

	protected override GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		float num = RunTime - Delay;
		if (num <= 0f)
		{
			return GSMUITickableStat.TICKING;
		}
		bool flag = true;
		float num2 = Duration / 2f;
		if (num > num2)
		{
			num -= num2;
			flag = false;
		}
		float x = num / num2;
		float renderOpacity = GSEaseFuncInUE.GSMathEase(Alpha: (!flag) ? MathLib.Clamp(x, 1f, 0f) : MathLib.Clamp(x, 0f, 1f), Start: FromOpacity, End: ToOpacity, EasingFuncType: EasingFuncType);
		TargetWidget.SetRenderOpacity(renderOpacity);
		if (RunTime >= Duration + Delay)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
