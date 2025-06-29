using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_FXActorLifeComp : UActorCompBaseCS
{
	private BUC_FXActorLifeData FXActorLifeData { get; set; }

	public override void OnAttach()
	{
		FXActorLifeData = RequireWritableData<BUC_FXActorLifeData>();
		b1.IBUC_FXActorBaseData iBUC_FXActorBaseData = RequireReadOnlyData<b1.IBUC_FXActorBaseData, b1.BUC_FXActorBaseData>();
		if (iBUC_FXActorBaseData != null)
		{
			FXActorLifeData.LifeTime = iBUC_FXActorBaseData.LifeTime;
			FXActorLifeData.DelayDestroyTimer = iBUC_FXActorBaseData.DelayDestroyTime;
		}
		if (FXActorLifeData.LifeTime < 0f)
		{
			SetCanTick(Val: false);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!InDeadDestroyTick(DeltaTime))
		{
			LifeTick(DeltaTime);
		}
	}

	private void LifeTick(float DeltaTime)
	{
		if (!GetOwner().IsNullOrDestroyed() && FXActorLifeData.LifeTime != -1f && FXActorLifeData.FXActorAge < FXActorLifeData.LifeTime)
		{
			FXActorLifeData.FXActorAge += DeltaTime;
			if (FXActorLifeData.FXActorAge >= FXActorLifeData.LifeTime)
			{
				FXActorLifeData.FXActorIsDead = true;
			}
		}
	}

	private void OnDestroySelf()
	{
		AActor owner = GetOwner();
		if (!owner.IsNullOrDestroyed())
		{
			BGU_UnrealWorldUtil.DestroyActor(owner);
		}
	}

	private bool InDeadDestroyTick(float DeltaTime)
	{
		if (GetOwner().IsNullOrDestroyed())
		{
			return true;
		}
		if (FXActorLifeData.FXActorIsDead)
		{
			if (FXActorLifeData.DelayDestroyTimer >= 0f)
			{
				FXActorLifeData.DelayDestroyTimer -= DeltaTime;
				if (FXActorLifeData.DelayDestroyTimer < 0f)
				{
					OnDestroySelf();
				}
			}
			return true;
		}
		return false;
	}
}
