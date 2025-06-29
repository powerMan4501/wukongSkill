using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.GSMUICore.Event;

public class GSMUITweenSetMPCParam : GSMUIEventBase
{
	private UMaterialParameterCollection TargetMPC;

	private UObject WorldContext;

	private readonly float FromValue;

	private readonly float ToPercent;

	private readonly float Delay;

	private readonly float Duration;

	private readonly EEasingFunc EasingFuncType = EEasingFunc.EaseOut;

	private FName ParamName = FName.None;

	public GSMUITweenSetMPCParam(UObject WorldContext, UMaterialParameterCollection TargetMPC, FName ParamName, float FromPercent = -1f, float ToValue = -1f, float Duration = 0.5f, float Delay = 0f, EEasingFunc EasingFuncType = EEasingFunc.EaseOut)
		: base("GSMUITweenBarMatPercent")
	{
		this.WorldContext = WorldContext;
		this.TargetMPC = TargetMPC;
		this.Delay = Delay;
		this.Duration = Duration;
		ToPercent = ToValue;
		this.EasingFuncType = EasingFuncType;
		this.ParamName = ParamName;
		if (FromPercent == -1f && TargetMPC != null)
		{
			FromValue = UMaterialLibrary.GetScalarParameterValue(WorldContext, TargetMPC, ParamName);
			return;
		}
		FromValue = FromPercent;
		SetBarMatPercent(FromValue);
	}

	private void SetBarMatPercent(float NewPercent)
	{
		UMaterialLibrary.SetScalarParameterValue(WorldContext, TargetMPC, ParamName, NewPercent);
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
