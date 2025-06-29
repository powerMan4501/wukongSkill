using System;
using UnrealEngine.Engine;

namespace b1.GSMUICore.Event;

public class GSMUITweenFloat : GSMUIEventBase
{
	private Func<float> GetFloatValue;

	private Action<float> SetFloatValue;

	private readonly float FromValue;

	private readonly float ToValue;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	public GSMUITweenFloat(Func<float> GetFloatFunc, Action<float> SetFloatAction, float FromValue = -1f, float ToValue = 0f, float Duration = 0.5f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut)
		: base("GSMUITweenFloat")
	{
		GetFloatValue = GetFloatFunc;
		SetFloatValue = SetFloatAction;
		this.Delay = Delay;
		this.Duration = Duration;
		this.ToValue = ToValue;
		this.EasingFuncType = EasingFuncType;
		if (FromValue == -1f)
		{
			this.FromValue = GetFloatValue();
			return;
		}
		this.FromValue = FromValue;
		SetFloatValue(FromValue);
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
		float obj = GSEaseFuncInUE.GSMathEase(FromValue, ToValue, x, EasingFuncType);
		SetFloatValue(obj);
		if (RunTime >= Duration + Delay)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
