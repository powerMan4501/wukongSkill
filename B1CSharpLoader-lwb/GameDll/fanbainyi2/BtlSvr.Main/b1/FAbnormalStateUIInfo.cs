namespace b1;

public class FAbnormalStateUIInfo
{
	public GSBindProp<bool> bIsInFinalState;

	public GSBindProp<int> FinalEffectBuffID;

	public float TotalTime_FinalEffectBuff;

	public float RemainTime_FinalEffectBuff;

	public FAbnormalStateUIInfo()
	{
		bIsInFinalState = new GSBindProp<bool>();
		FinalEffectBuffID = new GSBindProp<int>();
	}
}
