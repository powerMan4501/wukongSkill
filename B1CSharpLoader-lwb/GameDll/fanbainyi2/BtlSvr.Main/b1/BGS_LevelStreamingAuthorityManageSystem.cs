namespace b1;

public class BGS_LevelStreamingAuthorityManageSystem : GameModeSystemBase
{
	private BGC_LevelAuthorityData LevelAuthorityData;

	public override void OnAttach()
	{
		base.OnAttach();
		LevelAuthorityData = RequireWritableGameStateData<BGC_LevelAuthorityData>();
	}
}
