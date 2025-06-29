namespace b1;

public interface IBUC_TurretControlData
{
	float Turn2CameraTriggerYaw { get; }

	float Turn2CameraDelay { get; }

	float Turn2CameraYawSpeed { get; }

	bool bEnableTurretRotate { get; }
}
