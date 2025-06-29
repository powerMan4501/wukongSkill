using System;
using b1.Plugins.GSInput;
using UnrealEngine.Runtime;

namespace b1;

public class GSScrollUtil
{
	public const float MinDeltaTime = 0.02f;

	private ScrollInputData InputParams;

	private ScrollData ScrollParams;

	private float ScrollSpeed;

	private float CurSpeed;

	private GSSecondOrderDynamics SecOrdDyn;

	private bool IsStartScroll;

	private float TargetOffset;

	private float InputTick;

	private float InputValue;

	private float SpeedRate;

	public event Action OnScrollFinished;

	public void InitParam(ScrollInputData InInputParam, ScrollData InScrollParam)
	{
		InputParams = InInputParam;
		ScrollParams = InScrollParam;
		Reset();
	}

	public void Reset()
	{
		SpeedRate = 1f;
		SecOrdDyn = new GSSecondOrderDynamics(ScrollParams.Frequency, ScrollParams.Damping, ScrollParams.InitResponse, 0f);
		ScrollSpeed = 0f;
		CurSpeed = 0f;
		IsStartScroll = false;
		TargetOffset = 0f;
		this.OnScrollFinished = null;
	}

	public void SetScrollSpeed(float InScrollSpeed)
	{
		ScrollSpeed = InScrollSpeed;
	}

	public void StartScroll(float InTargetOffset, Action InOnScrollFinished = null)
	{
		TargetOffset = InTargetOffset;
		IsStartScroll = true;
		this.OnScrollFinished = InOnScrollFinished;
	}

	private void EndScroll()
	{
		this.OnScrollFinished?.Invoke();
		this.OnScrollFinished = null;
		IsStartScroll = false;
		TargetOffset = 0f;
	}

	public void SetSpeedRate(float InSpeedRate)
	{
		SpeedRate = InSpeedRate;
	}

	public void SetInput(float InInputTick, float InInputValue)
	{
		InputTick = InInputTick;
		InputValue = InInputValue;
	}

	public void UpdateInput(float DeltaTime)
	{
		if (InputTick > 0f)
		{
			if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse)
			{
				SetScrollSpeed(InputValue * InputParams.KeyboardScrollMultiplier);
			}
			else if (FMath.IsNearlyEqual(GetSpeed(), 0f))
			{
				SetScrollSpeed(InputValue * InputParams.GamepadScrollOriSpeed);
			}
			else
			{
				SetScrollSpeed(InputValue * InputParams.GamepadScrollMultiplier);
			}
			InputTick -= DeltaTime;
		}
	}

	public float UpdateScroll(float ScrollOffset, float InDeltaTime)
	{
		float num;
		if (FMath.Abs(ScrollSpeed) > 0f)
		{
			CurSpeed += ScrollSpeed;
			ClampSpeed();
			ScrollSpeed = 0f;
			num = ScrollOffset + CurSpeed * SpeedRate * InDeltaTime;
			EndScroll();
		}
		else if (IsStartScroll)
		{
			if (FMath.IsNearlyEqual(ScrollOffset, TargetOffset, 0.01f))
			{
				num = TargetOffset;
				EndScroll();
			}
			else
			{
				num = SecOrdDyn.Update(InDeltaTime, ScrollOffset, TargetOffset, CurSpeed * SpeedRate);
				CurSpeed = (num - ScrollOffset) / InDeltaTime;
			}
		}
		else
		{
			int num2 = ((CurSpeed > 0f) ? 1 : (-1));
			float num3 = FMath.Abs(CurSpeed);
			float num4 = ScrollParams.Resistance * InDeltaTime;
			num3 = ((!(num3 > num4)) ? 0f : (num3 - num4));
			CurSpeed = (float)num2 * num3;
			num = ScrollOffset + CurSpeed * SpeedRate * InDeltaTime;
		}
		return num;
	}

	protected void ClampSpeed()
	{
		int num = ((CurSpeed > 0f) ? 1 : (-1));
		float x = FMath.Abs(CurSpeed);
		x = FMath.Clamp(x, 0f, ScrollParams.MaxSpeed);
		CurSpeed = (float)num * x;
	}

	public bool GetUseScrollToTarget()
	{
		return ScrollParams.UseSecOrdDyn;
	}

	public bool GetInScrollToTarget()
	{
		return IsStartScroll;
	}

	public bool GetIsUseScroll()
	{
		if (!GetInScrollToTarget())
		{
			return GetHaveInput();
		}
		return true;
	}

	public bool GetHaveInput()
	{
		return FMath.Abs(ScrollSpeed) > 0f;
	}

	public float GetSpeed()
	{
		return CurSpeed;
	}

	public void SetSpeed(float InSpeed)
	{
		CurSpeed = InSpeed;
	}
}
