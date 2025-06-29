namespace b1;

public class FWeakPerformConfig
{
	public bool IsValid { get; set; }

	public bool bDisableXAxisMove { get; set; }

	public bool bDisableMoveBack { get; set; }

	public bool bDisableInteract { get; set; }

	public UnitLockTargetInfo LockTarget { get; set; }

	public float ExitDelayTime { get; set; }

	public float DurationTime { get; set; }

	public void Clear()
	{
		IsValid = false;
		bDisableXAxisMove = false;
		bDisableMoveBack = false;
		bDisableInteract = false;
		LockTarget = null;
		ExitDelayTime = -1f;
		DurationTime = -1f;
	}
}
