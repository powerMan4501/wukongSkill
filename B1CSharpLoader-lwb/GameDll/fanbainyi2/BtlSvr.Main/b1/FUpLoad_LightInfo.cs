namespace b1;

public struct FUpLoad_LightInfo
{
	public FUpLoad_LightInfoWithCategory DirectionalLightData;

	public FUpLoad_LightInfoWithCategory SkyLightData;

	public FUpLoad_LightInfoWithCategory AtmosphereData;

	public FUpLoad_LightInfoWithCategory HeightFogData;

	public FUpLoad_LightInfoWithCategory CustomVariableData;

	public FUpLoad_LightInfoWithCategory OtherData;

	public FUpLoad_CharacterLightInfo PlayerLightData;

	public FUpLoad_LightVolumeInfo[] VolumeInfos;
}
