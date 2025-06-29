using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace b1;

public struct MonitorMessage
{
	public static readonly int DataSize = 1016;

	public static readonly int MessageSize = 1024;

	[MarshalAs(UnmanagedType.I4)]
	public EMonitorMessageType MessageType;

	[MarshalAs(UnmanagedType.I4)]
	public int Length;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1016)]
	public byte[] Data;

	public static bool Create(EMonitorMessageType InMessageType, byte[] InData, out List<MonitorMessage> OutMessages)
	{
		OutMessages = new List<MonitorMessage>();
		if (InData.Length == 0)
		{
			return false;
		}
		MonitorMessage item = new MonitorMessage
		{
			MessageType = InMessageType,
			Length = Math.Min(InData.Length, DataSize),
			Data = new byte[DataSize]
		};
		Array.Copy(InData, 0, item.Data, 0, item.Length);
		OutMessages.Add(item);
		return true;
	}
}
