namespace b1;

public class TeleportTemplate_PrologueCompleted : TeleportTemlate_NextChapterBase
{
	public override int GetTargetLevelId()
	{
		return BGUFuncLibMap.GetAfterPrologueLevelId(base.PlayerController);
	}

	public override bool LevelTravelUseDefaultPlayerStart()
	{
		return true;
	}
}
