using UnrealEngine.Runtime;

namespace b1.UI;

public class DSProgBarInfo : UIBindData
{
	public readonly GSBindProp<bool> IsShow = new GSBindProp<bool>();

	public readonly GSBindProp<bool> CanShow = new GSBindProp<bool>();

	public readonly GSBindProp<float> MaxValue = new GSBindProp<float>();

	public readonly GSBindProp<float> Value = new GSBindProp<float>();

	public readonly GSBindProp<float> Percent = new GSBindProp<float>();

	public readonly GSBindProp<FBarData> BarData = new GSBindProp<FBarData>();

	public readonly GSBindProp<int> BindResId = new GSBindProp<int>();

	public GSBindProp<bool> PauseScaleAnim = new GSBindProp<bool>();

	public GSBindProp<bool> PlayScaleAnimAction = new GSBindProp<bool>();

	public GSBindProp<float> ScaleAnimShowTime = new GSBindProp<float>();

	private BindDataDelayEvent DelayEvent;

	public DSProgBarInfo(BUI_Widget BindWidget)
		: base(BindWidget)
	{
		IsShow.InitForEnumBugFix(InitValue: true);
		CanShow.InitForEnumBugFix(InitValue: true);
		MaxValue.InitForEnumBugFix(1f);
		Value.InitForEnumBugFix(1f);
		Percent.InitForEnumBugFix(1f);
		PauseScaleAnim.InitForEnumBugFix(InitValue: false);
		PlayScaleAnimAction.InitForEnumBugFix(InitValue: false);
		DelayEvent = new BindDataDelayEvent(this);
	}

	public virtual void Clear()
	{
	}

	public void Play()
	{
		SetCanShow(InCanShow: true);
	}

	public void Stop()
	{
		SetCanShow(InCanShow: false);
	}

	public void SetValue(EChangeReason Reason, float InValue)
	{
		Value.SetValue(Reason, InValue);
		UpdatePercent(Reason);
	}

	public void SetMaxValue(EChangeReason Reason, float InMaxValue)
	{
		if (!FMath.IsNearlyZero(InMaxValue))
		{
			MaxValue.SetValue(Reason, InMaxValue);
			UpdatePercent(Reason);
		}
	}

	public void SetBarData(EChangeReason Reason, FBarData InBarData)
	{
		BarData.SetValue(Reason, InBarData);
	}

	protected void UpdatePercent(EChangeReason Reason)
	{
		if (MaxValue.Value != 0f)
		{
			Percent.SetValue(Reason, Value.Value / MaxValue.Value);
		}
		if (Reason == EChangeReason.Init)
		{
			SetBarData(Reason, new FBarData(Value.Value, MaxValue.Value, Percent.Value));
			return;
		}
		DelayEvent.Start(delegate
		{
			SetBarData(Reason, new FBarData(Value.Value, MaxValue.Value, Percent.Value));
		}, 0.1f);
	}

	public void SetIsShow(bool InIsShow)
	{
		IsShow.SetValue(EChangeReason.ManualSet, CanShow.Value && InIsShow);
	}

	public void SetCanShow(bool InCanShow)
	{
		CanShow.SetValue(EChangeReason.ManualSet, InCanShow);
		UpdateIsShow();
	}

	public virtual void UpdateIsShow()
	{
		bool value = CanShow.Value;
		IsShow.SetValue(EChangeReason.ManualSet, value);
	}

	public void SetPauseScaleAnim(bool InPauseScaleAnim)
	{
		PauseScaleAnim.SetValue(EChangeReason.ManualSet, InPauseScaleAnim);
	}

	public void PlayScaleAnim(EChangeReason Reason)
	{
		PlayScaleAnimAction.SetTrigger(Reason, value: true);
	}

	public void SetScaleAnimShowTime(float InScaleAnimShowTime)
	{
		ScaleAnimShowTime.SetValue(EChangeReason.ManualSet, InScaleAnimShowTime);
	}

	public void ForceUpdate()
	{
		DelayEvent.Invoke();
	}
}
