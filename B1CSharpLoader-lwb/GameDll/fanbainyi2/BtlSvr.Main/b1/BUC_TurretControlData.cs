namespace b1;

public class BUC_TurretControlData : IBUC_TurretControlData
{
	public bool bEnableTurretControl { get; set; }

	public float Turn2CameraOriginTriggerYaw { get; set; }

	public float Turn2CameraOriginDelay { get; set; }

	public float Turn2CameraTriggerYaw { get; set; }

	public float Turn2CameraDelay { get; set; }

	public float Turn2CameraBlendTime { get; set; }

	public float Turn2CameraYawSpeed { get; set; }

	public bool bEnableTurretRotate { get; set; }
}
