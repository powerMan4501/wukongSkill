using System.Runtime.InteropServices;

namespace b1;

public struct CameraMonitorCurvePoint
{
	[MarshalAs(UnmanagedType.U1)]
	private byte Index;

	[MarshalAs(UnmanagedType.R4)]
	public float X;

	[MarshalAs(UnmanagedType.R4)]
	public float Y;

	[MarshalAs(UnmanagedType.R4)]
	public float Z;

	public static bool Create(ECameraMonitorPointType PointType, float InX, float InY, float InZ, out CameraMonitorCurvePoint OutCameraMonitorCurvePoint)
	{
		OutCameraMonitorCurvePoint = default(CameraMonitorCurvePoint);
		OutCameraMonitorCurvePoint.Index = (byte)PointType;
		OutCameraMonitorCurvePoint.X = InX;
		OutCameraMonitorCurvePoint.Y = InY;
		OutCameraMonitorCurvePoint.Z = InZ;
		return true;
	}
}
