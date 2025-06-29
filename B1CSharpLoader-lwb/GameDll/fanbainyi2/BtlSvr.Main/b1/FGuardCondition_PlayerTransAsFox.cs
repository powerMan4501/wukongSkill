using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class FGuardCondition_PlayerTransAsFox : FGuardConditionBase
{
	public override EGuardConditionType ConditionType => EGuardConditionType.PlayerTransAsFox;

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return true;
	}

	protected override void Start()
	{
	}

	protected override void Stop()
	{
	}

	protected override void Clean()
	{
	}

	protected override void OnTick(float DeltaTime)
	{
		CheckTransAsFox();
	}

	private void CheckTransAsFox()
	{
		base.QueryState = EQueryState.Querying;
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		if (controlledPawn == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(controlledPawn);
		if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.FoxTransResID, out var ConfigInfo))
		{
			if (actorResID == ConfigInfo.IntValue)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			else
			{
				base.QueryState = EQueryState.QueryFailure;
			}
		}
	}
}
