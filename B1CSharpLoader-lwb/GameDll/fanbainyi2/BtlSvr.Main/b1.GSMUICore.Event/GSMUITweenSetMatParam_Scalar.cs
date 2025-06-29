using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.GSMUICore.Event;

public class GSMUITweenSetMatParam_Scalar : GSMUIEventBase
{
	private UMaterialInstanceDynamic TargetMat;

	private readonly float FromValue;

	private readonly float ToPercent;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	private FName ParamName = FName.None;

	public GSMUITweenSetMatParam_Scalar(UMaterialInstanceDynamic TargetMat, FName ParamName, float FromPercent = -1f, float ToValue = -1f, float Duration = 0.5f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut)
		: base("GSMUITweenBarMatPercent")
	{
		this.TargetMat = TargetMat;
		this.Delay = Delay;
		this.Duration = Duration;
		ToPercent = ToValue;
		this.EasingFuncType = EasingFuncType;
		this.ParamName = ParamName;
		if (FromPercent == -1f && TargetMat != null)
		{
			FromValue = TargetMat.GetScalarParameterValue(ParamName);
			return;
		}
		FromValue = FromPercent;
		SetBarMatPercent(FromValue);
	}

	private void SetBarMatPercent(float NewPercent)
	{
		TargetMat?.SetScalarParameterValue(ParamName, NewPercent);
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
		float barMatPercent = GSEaseFuncInUE.GSMathEase(FromValue, ToPercent, x, EasingFuncType);
		SetBarMatPercent(barMatPercent);
		if (RunTime >= Duration + Delay)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
