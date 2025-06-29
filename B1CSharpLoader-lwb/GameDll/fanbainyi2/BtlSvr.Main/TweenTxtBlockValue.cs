using b1;
using b1.GSMUICore.Event;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

public class TweenTxtBlockValue : GSMUIEventBase
{
	private UTextBlock Txt;

	private float FromValue;

	private float ToValue;

	private float Duration;

	private EEasingFunc EasingFuncType;

	private string Ex;

	private float CurValue;

	public TweenTxtBlockValue(UTextBlock Txt, EEasingFunc EasingFuncType = EEasingFunc.EaseOut, string Ex = "")
		: base("TweenTxtBlockValue")
	{
		this.Txt = Txt;
		this.EasingFuncType = EasingFuncType;
		this.Ex = Ex;
	}

	public void ChangeToValue(float FromValue = -1f, float ToValue = -1f, float Duration = 0.5f, bool IsForce = false)
	{
		if (IsForce)
		{
			SetTxtValue(ToValue);
			return;
		}
		if (FromValue == -1f)
		{
			this.FromValue = CurValue;
		}
		else
		{
			this.FromValue = FromValue;
			SetTxtValue(this.FromValue);
		}
		this.ToValue = ToValue;
		if (Duration == -1f)
		{
			float num = FMath.Abs(ToValue - FromValue);
			if (num > 999f)
			{
				this.Duration = 0.8f;
			}
			else
			{
				this.Duration = 0.2f + num / 1000f * 0.6f;
			}
		}
		RunTime = 0f;
	}

	private void SetTxtValue(float NewValue)
	{
		CurValue = NewValue;
		Txt?.SetText(FText.FromString($"{Ex}{(int)NewValue}"));
	}

	protected override GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		float x = RunTime / Duration;
		x = MathLib.Clamp(x, 0f, 1f);
		float txtValue = GSEaseFuncInUE.GSMathEase(FromValue, ToValue, x, EasingFuncType);
		SetTxtValue(txtValue);
		if (RunTime >= Duration)
		{
			return GSMUITickableStat.IDLE;
		}
		return GSMUITickableStat.TICKING;
	}
}
