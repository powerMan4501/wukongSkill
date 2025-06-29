using b1.ECS;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_PlayerCameraData : IBUC_PlayerCameraData, IPersistentECSData
{
	private readonly TStrongObjectPtr<GSCameraGraph> mCameraGraph = new TStrongObjectPtr<GSCameraGraph>();

	public BUC_CameraState CameraState { get; set; }

	public GSCameraGraph CameraGraph
	{
		get
		{
			return mCameraGraph.Get();
		}
		set
		{
			mCameraGraph.Set(value);
		}
	}

	public GSCameraControlData ControlData { get; } = new GSCameraControlData();

	public GSCameraMonitorData MonitorData { get; } = new GSCameraMonitorData();

	public FBUC_CameraOffsetData CameraOffsetData { get; set; }

	public FDownloadInfo_CameraMonitor CameraMonitorData { get; set; }

	public FDownloadInfo_PlayerCamera PlayerCameraMonitorData { get; set; }

	public FDownloadInfo_StraightCamera StraightCameraMonitorData { get; set; }

	public FDownloadInfo_DiagonalCamera DiagonalCameraMonitorData { get; set; }

	public FDownloadInfo_GiantCamera GiantCameraMonitorData { get; set; }

	public float CurrentDeltaTime { get; set; }

	public ACameraActor SyncCamera { get; set; }

	public FName CameraSyncPointOnHost { get; set; }

	public FName LastCameraSyncPointOnHost { get; set; }

	public USceneComponent DummyMeshComp { get; set; }

	public float SwitchSyncPointBlendTime { get; set; }

	public float SwitchSyncPointBlendTimer { get; set; }

	public BUC_PlayerCameraData()
	{
		CameraOffsetData = new FBUC_CameraOffsetData();
		CameraState = new BUC_CameraState();
	}

	public bool IsInG4Mode()
	{
		return CameraState.FreeCameraMode == EPlayerFreeCameraType.G4Mode;
	}

	public int GetCurrentCameraGroupID()
	{
		return CameraState.CurrentCameraGroupId;
	}

	public int GetCurrentFreeCameraID()
	{
		return CameraState.CurrentCameraID;
	}

	public int GetCurrentLockCameraID()
	{
		return CameraState.FinalLockCameraID;
	}
}
