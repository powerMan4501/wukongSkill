namespace b1;

public class TeleportTemplate_NextChapter : TeleportTemlate_NextChapterBase
{
	private TeleportParam_NextChapter TeleportParam => (TeleportParam_NextChapter)(object)UserData;

	public override int GetTargetLevelId()
	{
		return TeleportParam.LevelId;
	}

	public override void LoadingFadeAwayBegin()
	{
		base.LoadingFadeAwayBegin();
		TeleportParam.TeleportFinishCallback?.Invoke();
	}

	public override void OnBegin()
	{
		base.PlayerController.SetViewTargetWithBlend(base.PlayerController.GetControlledPawn());
		base.OnBegin();
	}

	protected override void ReSetPlayerState(bool ReSetActor)
	{
		base.ReSetPlayerState(ReSetActor);
	}
}
