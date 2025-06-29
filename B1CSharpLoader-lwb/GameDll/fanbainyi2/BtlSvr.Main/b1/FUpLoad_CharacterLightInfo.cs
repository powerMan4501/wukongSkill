namespace b1;

public struct FUpLoad_CharacterLightInfo
{
	public string OriginData;

	public string CurrentData;

	public string TargetData;

	public FUpLoad_PointLightInfo FrontLight;

	public FUpLoad_PointLightInfo BackLight;

	public float SpeedAlpha;

	public bool bOriginUseCustomBlendOutSpeed;

	public float OriginCustomBlendOutSpeedAlpha;

	public bool bTargetUseCustomBlendOutSpeed;

	public float TargetCustomBlendOutSpeedAlpha;

	public float CurrentAlpha;

	public float TargetAlpha;

	public float CurrentPercentage;
}
