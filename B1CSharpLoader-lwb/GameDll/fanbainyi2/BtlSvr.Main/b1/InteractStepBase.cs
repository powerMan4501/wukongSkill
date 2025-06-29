using System;

namespace b1;

public abstract class InteractStepBase
{
	public PlayerInteractState StateName;

	protected InteractContext Context;

	protected float TimeOut = -1f;

	public event Action<PlayerInteractState, InteractStepResult> StepTriggerFinish;

	public void StepInit(InteractContext Context, Action<PlayerInteractState, InteractStepResult> StepTriggerFinish)
	{
		this.Context = Context;
		this.StepTriggerFinish = StepTriggerFinish;
	}

	public virtual void StepBegin()
	{
	}

	public virtual void OnTick(float DeltaTime)
	{
		if (TimeOut > 0f)
		{
			TimeOut -= DeltaTime;
			if (TimeOut <= 0f)
			{
				OnTimeOut();
			}
		}
	}

	public virtual void StepFinish()
	{
	}

	protected virtual void OnTimeOut()
	{
	}

	public virtual void OnBreak()
	{
	}

	public virtual void OnSkip()
	{
	}

	protected virtual void TriggerFinish(InteractStepResult Result)
	{
		if (this.StepTriggerFinish != null)
		{
			this.StepTriggerFinish(StateName, Result);
			this.StepTriggerFinish = null;
		}
	}
}
