using System.Runtime.InteropServices;

namespace b1;

public struct CameraMonitorControlData
{
	[MarshalAs(UnmanagedType.I4)]
	private int DataIndex;

	[MarshalAs(UnmanagedType.R4)]
	public float DataValue;

	public static bool Create(int InIndex, float Value, out CameraMonitorControlData OutCameraMonitorControlData)
	{
		OutCameraMonitorControlData = default(CameraMonitorControlData);
		OutCameraMonitorControlData.DataIndex = InIndex;
		OutCameraMonitorControlData.DataValue = Value;
		return true;
	}

	public static int GetIndex(EMonitorDataType DataType, EMonitorDataSubType SubType, EMonitorDataValueType ValueIndex)
	{
		return (int)DataType * 100 + (int)SubType * 10 + (int)ValueIndex;
	}
}
