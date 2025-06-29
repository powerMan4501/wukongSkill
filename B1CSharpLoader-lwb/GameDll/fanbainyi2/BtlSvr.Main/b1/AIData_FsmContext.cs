namespace b1;

public class AIData_FsmContext
{
	public bool bCanTriggerReturnHome;

	public bool bCanUpdateForReturnHome;

	public bool bCanTriggerGazeAndSurround;

	public float ReturnHomeTimer;

	public int ReturnHomeBuffID;

	public bool bNeedReturnHome;

	public bool bCanTriggerWakeupActivated;

	public void Init()
	{
		bCanTriggerReturnHome = false;
		bCanUpdateForReturnHome = false;
		bCanTriggerGazeAndSurround = false;
		ReturnHomeTimer = 0f;
		ReturnHomeBuffID = 0;
		bNeedReturnHome = false;
		bCanTriggerWakeupActivated = false;
	}
}
