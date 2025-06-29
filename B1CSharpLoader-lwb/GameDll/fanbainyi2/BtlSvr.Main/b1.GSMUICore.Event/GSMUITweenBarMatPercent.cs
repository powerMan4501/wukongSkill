using UnrealEngine.Engine;

namespace b1.GSMUICore.Event;

public class GSMUITweenBarMatPercent : GSMUIEventBase
{
	private UMaterialInstanceDynamic TargetMat;

	private readonly float FromPercent;

	private readonly float ToPercent;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	public GSMUITweenBarMatPercent(UMaterialInstanceDynamic TargetMat, float FromPercent = -1f, float ToPercent = -1f, float Duration = 0.5f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut)
		: base("GSMUITweenBarMatPercent")
	{
		this.TargetMat = TargetMat;
		this.Delay = Delay;
		this.Duration = Duration;
		this.ToPercent = ToPercent;
		this.EasingFuncType = EasingFuncType;
		if (FromPercent == -1f && TargetMat != null)
		{
			this.FromPercent = TargetMat.GetScalarParameterValue(B1Names.GSMaskMatPercent);
			return;
		}
		this.FromPercent = FromPercent;
		SetBarMatPercent(this.FromPercent);
	}

	private void SetBarMatPercent(float NewPercent)
	{
		TargetMat?.SetScalarParameterValue(B1Names.GSMaskMatPercent, NewPercent);
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
		float barMatPercent = GSEaseFuncInUE.GSMathEase(FromPercent, ToPercent, x, EasingFuncType);
		SetBarMatPercent(barMatPercent);
		if (RunTime >= Duration + Delay)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
