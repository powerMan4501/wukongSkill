using Diana.Common;

namespace b1;

public interface IBUC_PlayerCameraData
{
	FDownloadInfo_CameraMonitor CameraMonitorData { get; }

	FDownloadInfo_PlayerCamera PlayerCameraMonitorData { get; }

	FDownloadInfo_StraightCamera StraightCameraMonitorData { get; }

	FDownloadInfo_DiagonalCamera DiagonalCameraMonitorData { get; }

	FDownloadInfo_GiantCamera GiantCameraMonitorData { get; }

	bool IsInG4Mode();

	int GetCurrentCameraGroupID();

	int GetCurrentFreeCameraID();

	int GetCurrentLockCameraID();
}
