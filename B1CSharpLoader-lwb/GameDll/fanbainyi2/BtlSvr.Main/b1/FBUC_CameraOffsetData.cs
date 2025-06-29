namespace b1;

public class FBUC_CameraOffsetData
{
	public bool EnableCamOffsetTick;

	public float CamOffsetTickTimer;

	public float CamOffsetTickTotalTime;

	public FGSCameraOffsetSetting CameraOffsetSetting;

	public FBUC_CameraOffsetData()
	{
		EnableCamOffsetTick = false;
		CamOffsetTickTimer = 0f;
		CamOffsetTickTotalTime = 0f;
		CameraOffsetSetting = default(FGSCameraOffsetSetting);
	}

	public void Reset()
	{
		EnableCamOffsetTick = false;
		CamOffsetTickTimer = 0f;
		CamOffsetTickTotalTime = 0f;
		CameraOffsetSetting = default(FGSCameraOffsetSetting);
	}
}
