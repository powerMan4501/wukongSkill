using CommB1;

namespace b1;

public class FGuardCondition_GameStateCondition : FGuardConditionBase
{
	private EQueryGameStateCondition GameStateCondition { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.GameStateCondition;

	protected override void Clean()
	{
		GameStateCondition = EQueryGameStateCondition.None;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		GameStateCondition = (EQueryGameStateCondition)IdleCondition.GameStateCondition;
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Group GroupCondition, PsmNodeInstance InPsmNodeInstance)
	{
		GameStateCondition = (EQueryGameStateCondition)GroupCondition.GameStateCondition;
		return true;
	}

	protected override void Start()
	{
		string Message;
		switch (GameStateCondition)
		{
		case EQueryGameStateCondition.HasArchive:
			if (BGW_GameArchiveMgr.Get(base.Owner).HasArchiveFile() || DebugConfig.DebugStartWithOutArchive)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			else
			{
				base.QueryState = EQueryState.QueryFailure;
			}
			break;
		case EQueryGameStateCondition.IsDebug:
			if (BGW_GameArchiveMgr.Get(base.Owner).IsCurrentArchiveIdInvalid(out Message))
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			else
			{
				base.QueryState = EQueryState.QueryFailure;
			}
			break;
		case EQueryGameStateCondition.NoArchive:
			if (BGW_GameArchiveMgr.Get(base.Owner).NoArchiveFile() && !DebugConfig.DebugStartWithOutArchive)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			else
			{
				base.QueryState = EQueryState.QueryFailure;
			}
			break;
		case EQueryGameStateCondition.NotInDebug:
			if (!BGW_GameArchiveMgr.Get(base.Owner).IsCurrentArchiveIdInvalid(out Message))
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			else
			{
				base.QueryState = EQueryState.QueryFailure;
			}
			break;
		}
	}

	protected override void OnTick(float DeltaTime)
	{
		switch (GameStateCondition)
		{
		case EQueryGameStateCondition.SeamlessStartNewGame:
			if (BGW_GameLifeTimeMgr.Get(base.Owner).IsInTravelLevel(EGlobalTravelLevelType.SeamlessStartNewGame))
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			break;
		case EQueryGameStateCondition.GenericStartNewGame:
			if (!BGW_GameLifeTimeMgr.Get(base.Owner).IsInTravelLevel(EGlobalTravelLevelType.SeamlessStartNewGame))
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
			break;
		}
	}
}
