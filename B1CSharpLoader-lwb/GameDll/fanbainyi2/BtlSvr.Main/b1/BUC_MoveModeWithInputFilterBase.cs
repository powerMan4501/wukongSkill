using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_MoveModeWithInputFilterBase : BUC_MoveModeBase
{
	protected FVector ForwardDir;

	protected FVector RightDir;

	protected float ForwardValue;

	protected float RightValue;

	private FVector RecentMoveInputForFilter;

	private float RecentMoveInputFilterTimer;

	private float MoveInputFilterTime = -1f;

	private float OnEndGameTime;

	protected FVector ResultMoveInput { get; private set; }

	private bool ShouldFilterMoveInput(in FVector MoveInput)
	{
		bool flag = true;
		bool result = false;
		switch (MoveSys.CommonData.FinalABPMoveMode)
		{
		case EABPMoveMode.PlayerLocomotion:
			flag = MoveSys.PlayerLocomotionData.bSwitchToLock;
			result = MoveSys.PlayerLocomotionData.bInFreeTurn;
			break;
		case EABPMoveMode.AdvancedMonsterLocomotion:
			flag = MoveSys.AdvancedMonsterLocomotionData.bSwitchToLock;
			result = MoveSys.AdvancedMonsterLocomotionData.bInFreeTurn;
			break;
		}
		if (!flag)
		{
			return result;
		}
		return FMath.Abs(MathLib.NormalizedDeltaRotator(MoveInput.Rotation(), MoveSys.ChrData.Velocity.Rotation()).Yaw) > 90f;
	}

	protected override void OnUpdate(float DeltaTime)
	{
		if (MoveInputFilterTime < 0f)
		{
			FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(MoveSys.GetActorResID(), OwnerCharacter);
			if (playerCommDesc != null)
			{
				MoveInputFilterTime = playerCommDesc.MoveInputFilterTime;
			}
		}
		if (OnEndGameTime > 0f)
		{
			float num = USystemLibrary.GetGameTimeInSeconds(OwnerCharacter) - OnEndGameTime;
			RecentMoveInputFilterTimer -= num;
			if (RecentMoveInputFilterTimer <= 0f)
			{
				RecentMoveInputFilterTimer = 0f;
			}
			OnEndGameTime = 0f;
		}
		ResultMoveInput = ForwardDir * ForwardValue + RightDir * RightValue;
		if (RecentMoveInputFilterTimer > 0f)
		{
			ResultMoveInput = RecentMoveInputForFilter;
		}
		else if (!ResultMoveInput.IsNearlyZero())
		{
			if (RecentMoveInputForFilter.IsNearlyZero())
			{
				RecentMoveInputForFilter = ResultMoveInput;
			}
			else
			{
				if (ShouldFilterMoveInput(ResultMoveInput))
				{
					RecentMoveInputFilterTimer = MoveInputFilterTime;
				}
				RecentMoveInputForFilter = ResultMoveInput;
			}
		}
		if (RecentMoveInputFilterTimer > 0f)
		{
			RecentMoveInputFilterTimer -= DeltaTime;
			if (RecentMoveInputFilterTimer <= 0f)
			{
				RecentMoveInputForFilter = ResultMoveInput;
				RecentMoveInputFilterTimer = 0f;
			}
		}
	}

	protected override void OnEnd()
	{
		OnEndGameTime = USystemLibrary.GetGameTimeInSeconds(OwnerCharacter);
		ResultMoveInput = FVector.ZeroVector;
		ForwardDir = (RightDir = FVector.ZeroVector);
		ForwardValue = (RightValue = 0f);
	}
}
