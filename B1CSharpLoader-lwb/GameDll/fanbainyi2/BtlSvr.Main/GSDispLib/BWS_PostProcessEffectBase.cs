using UnrealEngine.Runtime;

namespace GSDispLib;

public abstract class BWS_PostProcessEffectBase
{
	public enum PostProcessState
	{
		Idle,
		Beginning,
		Looping,
		Finishing
	}

	protected float BeginningDuration;

	protected float FinishingDuration;

	protected float LeftTime;

	protected float Duration = -1f;

	protected float LoopTimer;

	public int EffectID = -1;

	protected PostProcessState State;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	protected UDispLib_PPEffectParameters Parameters { get; set; }

	public virtual bool IsActive()
	{
		return State != PostProcessState.Idle;
	}

	public void Begin(GSDispLib_PostProcessContext Context, UDispLib_PPEffectParameters Parameters)
	{
		if (State == PostProcessState.Beginning || State == PostProcessState.Looping)
		{
			OnAlreadyBegin(Context);
			return;
		}
		SetParameters(Parameters);
		OnEnterBegin(Context);
		if (State == PostProcessState.Idle)
		{
			LeftTime = BeginningDuration;
			State = PostProcessState.Beginning;
		}
		else if (State == PostProcessState.Finishing)
		{
			State = PostProcessState.Beginning;
		}
	}

	public void Restart(GSDispLib_PostProcessContext Context)
	{
		Begin(Context, null);
	}

	public void End(GSDispLib_PostProcessContext Context)
	{
		if (State == PostProcessState.Idle || State == PostProcessState.Finishing)
		{
			OnAlreadyFinish(Context);
			return;
		}
		OnEnterFinish(Context);
		if (State == PostProcessState.Beginning)
		{
			State = PostProcessState.Finishing;
		}
		if (State == PostProcessState.Looping)
		{
			LeftTime = 0f;
			State = PostProcessState.Finishing;
		}
	}

	public virtual void OnDestroy(GSDispLib_PostProcessContext Context)
	{
	}

	public void OnTick(float DeltaTime, GSDispLib_PostProcessContext Context)
	{
		if (!IsActive())
		{
			return;
		}
		float progress = GetProgress();
		OnEffectTick(DeltaTime, progress, Context);
		switch (State)
		{
		case PostProcessState.Beginning:
			LeftTime -= DeltaTime;
			if (LeftTime <= 0f)
			{
				State = PostProcessState.Looping;
				LoopTimer = Duration;
				OnEndBegin(Context);
			}
			break;
		case PostProcessState.Finishing:
			LeftTime += DeltaTime;
			if (LeftTime >= FinishingDuration)
			{
				State = PostProcessState.Idle;
				OnEndFinish(Context);
			}
			break;
		case PostProcessState.Looping:
			if (Duration > 0f)
			{
				LoopTimer -= DeltaTime;
				if (LoopTimer <= 0f)
				{
					OnEnterFinish(Context);
					State = PostProcessState.Finishing;
				}
			}
			break;
		}
	}

	protected abstract void OnEffectTick(float DeltaTime, float Progress, GSDispLib_PostProcessContext Context);

	protected virtual void SetParameters(UDispLib_PPEffectParameters InParameters)
	{
		if (InParameters != null)
		{
			Duration = InParameters.Duration;
			BeginningDuration = InParameters.BeginningDuration;
			FinishingDuration = InParameters.FinishingDuration;
			Parameters = InParameters;
		}
	}

	public virtual void OnAlreadyBegin(GSDispLib_PostProcessContext Context)
	{
	}

	public virtual void OnAlreadyFinish(GSDispLib_PostProcessContext Context)
	{
	}

	public virtual void OnEnterBegin(GSDispLib_PostProcessContext Context)
	{
	}

	public virtual void OnEndBegin(GSDispLib_PostProcessContext Context)
	{
	}

	public virtual void OnEnterFinish(GSDispLib_PostProcessContext Context)
	{
	}

	public virtual void OnEndFinish(GSDispLib_PostProcessContext Context)
	{
	}

	public float GetProgress()
	{
		if (!IsActive())
		{
			return 1f;
		}
		if (State == PostProcessState.Beginning)
		{
			return FMath.Clamp((BeginningDuration - LeftTime) / BeginningDuration, 0f, 1f);
		}
		if (State == PostProcessState.Finishing)
		{
			return FMath.Clamp((FinishingDuration - LeftTime) / FinishingDuration, 0f, 1f);
		}
		return 1f;
	}

	public bool IsConstantEffect()
	{
		return Duration < 0f;
	}
}
