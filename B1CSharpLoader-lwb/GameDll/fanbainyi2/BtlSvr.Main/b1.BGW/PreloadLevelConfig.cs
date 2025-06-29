namespace b1.BGW;

public class PreloadLevelConfig
{
	public bool IsIgnoreAllFX;

	public bool IsIgnoreUnitCommRes;

	public bool IsIgnorePublicResource;

	public bool IsIgnoreHitSceneItemFX;

	public bool IsIgnoreBeAttackedAndDeathAM;

	public bool IsIgnoreAllAiConversation;

	public bool IsIgnoreUIResourceAsyncLoad;

	public PreloadLevelConfig(int PreloadLevel)
	{
		IsIgnoreAllFX = false;
		IsIgnoreUnitCommRes = false;
		IsIgnorePublicResource = false;
		IsIgnoreHitSceneItemFX = false;
		IsIgnoreBeAttackedAndDeathAM = false;
		IsIgnoreAllAiConversation = false;
		IsIgnoreUIResourceAsyncLoad = false;
		switch (PreloadLevel)
		{
		case 1:
			IsIgnoreAllFX = true;
			IsIgnoreUnitCommRes = true;
			IsIgnorePublicResource = true;
			IsIgnoreHitSceneItemFX = true;
			IsIgnoreAllAiConversation = true;
			IsIgnoreUIResourceAsyncLoad = true;
			break;
		case 2:
			IsIgnorePublicResource = true;
			IsIgnoreHitSceneItemFX = true;
			IsIgnoreAllAiConversation = true;
			IsIgnoreUIResourceAsyncLoad = true;
			break;
		case 3:
			IsIgnoreAllFX = true;
			IsIgnoreUnitCommRes = true;
			IsIgnorePublicResource = true;
			IsIgnoreHitSceneItemFX = true;
			IsIgnoreBeAttackedAndDeathAM = true;
			IsIgnoreAllAiConversation = true;
			IsIgnoreUIResourceAsyncLoad = true;
			break;
		case 4:
			IsIgnoreAllFX = true;
			IsIgnoreUnitCommRes = true;
			IsIgnorePublicResource = true;
			IsIgnoreHitSceneItemFX = true;
			IsIgnoreBeAttackedAndDeathAM = true;
			IsIgnoreUIResourceAsyncLoad = true;
			break;
		case 5:
			IsIgnoreAllFX = true;
			IsIgnoreUnitCommRes = true;
			IsIgnorePublicResource = true;
			IsIgnoreHitSceneItemFX = true;
			IsIgnoreAllAiConversation = true;
			IsIgnoreBeAttackedAndDeathAM = true;
			break;
		}
	}
}
