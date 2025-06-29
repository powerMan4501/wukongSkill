namespace GSDispLib;

public struct DBCCustomEventTimeInfo
{
	public float PlayAtTime;

	public DispLibDBCEndMode EndMode;

	public float Duration;

	public float EndDispStageDuration;

	public DBCCustomEventTimeInfo(float _PlayAtTime, DispLibDBCEndMode _EndMode, float _Duration, float _EndDispStageDuration)
	{
		PlayAtTime = _PlayAtTime;
		EndMode = _EndMode;
		Duration = _Duration;
		EndDispStageDuration = _EndDispStageDuration;
	}
}
