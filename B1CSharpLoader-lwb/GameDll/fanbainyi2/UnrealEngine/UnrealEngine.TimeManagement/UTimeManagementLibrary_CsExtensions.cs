using UnrealEngine.Runtime;

namespace UnrealEngine.TimeManagement;

public static class UTimeManagementLibrary_CsExtensions
{
	public static FFrameNumber Subtract_FrameNumberInteger(this FFrameNumber A, int B)
	{
		return UTimeManagementLibrary.Subtract_FrameNumberInteger(A, B);
	}

	public static FFrameNumber Subtract_FrameNumberFrameNumber(this FFrameNumber A, FFrameNumber B)
	{
		return UTimeManagementLibrary.Subtract_FrameNumberFrameNumber(A, B);
	}

	public static FFrameNumber Multiply_FrameNumberInteger(this FFrameNumber A, int B)
	{
		return UTimeManagementLibrary.Multiply_FrameNumberInteger(A, B);
	}

	public static FFrameNumber Divide_FrameNumberInteger(this FFrameNumber A, int B)
	{
		return UTimeManagementLibrary.Divide_FrameNumberInteger(A, B);
	}

	public static FFrameNumber Add_FrameNumberInteger(this FFrameNumber A, int B)
	{
		return UTimeManagementLibrary.Add_FrameNumberInteger(A, B);
	}

	public static FFrameNumber Add_FrameNumberFrameNumber(this FFrameNumber A, FFrameNumber B)
	{
		return UTimeManagementLibrary.Add_FrameNumberFrameNumber(A, B);
	}
}
