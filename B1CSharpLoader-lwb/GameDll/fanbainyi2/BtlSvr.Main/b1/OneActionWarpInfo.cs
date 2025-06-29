namespace b1;

public class OneActionWarpInfo
{
	public EGroupPriorityActionType ActionType;

	public IGroupAIActionInfo GroupAIActionInfo;

	public float WaitForBeginTime;

	public float BeginNoiseTime;

	public OneActionWarpInfo(EGroupPriorityActionType _ActionType, IGroupAIActionInfo _GroupAIActionInfo, float _WaitForBeginTime, float _BeginNoiseTime)
	{
		ActionType = _ActionType;
		GroupAIActionInfo = _GroupAIActionInfo;
		WaitForBeginTime = _WaitForBeginTime;
		BeginNoiseTime = _BeginNoiseTime;
	}
}
