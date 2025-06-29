namespace b1;

public static class GSCSResPathUtil
{
	public static string GetCollectionSpawnFXPath(bool DontDestorty)
	{
		return "BGWDataAsset_B1DBC'/Game/00MainHZ/Item/YaoCai/DBC/DBC_YaoCai.DBC_YaoCai'";
	}

	public static string GetCollectionDontDestortyFXPath()
	{
		return "BGWDataAsset_B1DBC'/Game/00MainHZ/Item/YaoCai/DBC/DBC_YaoCai_Finish_DontDestorty_Init.DBC_YaoCai_Finish_DontDestorty_Init'";
	}

	public static string GetCollectionDealutDestroyFXPath()
	{
		return "BGWDataAsset_B1DBC'/Game/00MainHZ/Item/YaoCai/DBC/DBC_YaoCai_Finish.DBC_YaoCai_Finish'";
	}

	public static string GetBHLBossTraceFXPath()
	{
		return "BGWDataAsset_B1DBC'/Game/00MainHZ/Item/YaoCai/DBC/DBC_Migge_Test.DBC_Migge_Test'";
	}

	public static string GetBGWDataAsset_B1DBCPath(string DBCPath)
	{
		return "BGWDataAsset_B1DBC'" + DBCPath + "'";
	}

	public static string EditBtnPath(int Id)
	{
		return $"Texture2D'/Game/00MainHZ/UI/Editor/UIDev/EndingCredits/ECTOOL_sec_btn_{Id}.ECTOOL_sec_btn_{Id}'";
	}
}
