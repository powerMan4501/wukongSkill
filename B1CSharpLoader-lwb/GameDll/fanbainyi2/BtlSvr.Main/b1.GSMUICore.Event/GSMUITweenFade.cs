using UnrealEngine.Engine;
using UnrealEngine.UMG;

namespace b1.GSMUICore.Event;

public class GSMUITweenFade : GSMUIEventBase
{
	public delegate void Del_GSMUITweenFadeCallBack();

	private UWidget TargetWidget;

	private readonly float FromOpacity;

	private readonly float ToOpacity;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	private Del_GSMUITweenFadeCallBack GSMUITweenFadeCallBack;

	public GSMUITweenFade(UWidget RefWidget, float FromOpacity = -1f, float ToOpacity = 0f, float Duration = 0.5f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut, Del_GSMUITweenFadeCallBack CallBack = null)
		: base("GSMUITweenFade")
	{
		TargetWidget = RefWidget;
		this.Delay = Delay;
		this.Duration = Duration;
		this.ToOpacity = ToOpacity;
		this.EasingFuncType = EasingFuncType;
		if (FromOpacity == -1f)
		{
			this.FromOpacity = TargetWidget.GetRenderOpacity();
		}
		else
		{
			this.FromOpacity = FromOpacity;
			TargetWidget.SetRenderOpacity(FromOpacity);
		}
		GSMUITweenFadeCallBack = CallBack;
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
		float renderOpacity = GSEaseFuncInUE.GSMathEase(FromOpacity, ToOpacity, x, EasingFuncType);
		TargetWidget.SetRenderOpacity(renderOpacity);
		if (RunTime >= Duration + Delay)
		{
			if (GSMUITweenFadeCallBack != null)
			{
				GSMUITweenFadeCallBack();
			}
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
