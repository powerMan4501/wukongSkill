using UnrealEngine.Runtime;

namespace b1;

public class TeleportTemplate_SimpleLevelIdAndTransform : TeleportTemplateBase
{
	private TeleportParam_SimpleLevelIdAndTransform TeleportParam => (TeleportParam_SimpleLevelIdAndTransform)(object)UserData;

	public override FTransform ChoosePlayerTeleportTransform()
	{
		return TeleportParam.TeleportTransform;
	}

	public override int GetTargetLevelId()
	{
		return TeleportParam.LevelId;
	}

	public override bool LevelTravelUseDefaultPlayerStart()
	{
		return TeleportParam.LevelTravelUseDefaultPlayerStart;
	}

	public override void LoadingFadeAwayBegin()
	{
		base.LoadingFadeAwayBegin();
		TeleportParam.TeleportFinishCallback?.Invoke();
	}
}
