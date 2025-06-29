namespace b1;

public abstract class FCameraBlendBase
{
	protected GSCameraControlData CameraControlData { get; set; }

	protected GSCameraMonitorData MonitorData { get; set; }

	protected BUC_CameraState CameraState { get; set; }

	protected float DeltaTime { get; set; }

	protected BUC_CameraBlendCache CameraBlendCache => CameraState?.CameraBlendCache;

	protected GSCameraGraph CameraGraph { get; }

	public void NotifyBlendCamera()
	{
		if (!(CameraGraph == null))
		{
			CameraControlData = CameraGraph.CameraControlData;
			MonitorData = CameraGraph.MonitorData;
			CameraState = CameraGraph.CameraState;
			DeltaTime = CameraGraph.DeltaTime;
			BlendCamera();
		}
	}

	protected virtual void BlendCamera()
	{
	}

	public FCameraBlendBase(GSCameraGraph InCameraGraph)
	{
		CameraGraph = InCameraGraph;
	}

	protected float GetDefaultArmLength()
	{
		float result = CameraState.DefaultArmLengthDefault;
		switch (CameraState.CameraArmMode)
		{
		case EDefaultCamArmMode.Close:
			result = CameraState.DefaultArmLengthClose;
			break;
		case EDefaultCamArmMode.Normal:
			result = CameraState.DefaultArmLengthNormal;
			break;
		case EDefaultCamArmMode.Far:
			result = CameraState.DefaultArmLengthFar;
			break;
		case EDefaultCamArmMode.Free:
			result = CameraState.Rt_FreeCameraArmLength;
			break;
		}
		return result;
	}
}
