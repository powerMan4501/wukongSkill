using Diana.Common;
using UnrealEngine.Runtime;

namespace b1;

public static class BGWCheatManageExtensions
{
	public static FNetStruct_Vector ToNetStruct(this FVector InVector)
	{
		return new FNetStruct_Vector
		{
			X = InVector.X,
			Y = InVector.Y,
			Z = InVector.Z
		};
	}

	public static FNetStruct_Vector ToNetStruct(this GSLocation InLocation)
	{
		if (InLocation == null)
		{
			return default(FNetStruct_Vector);
		}
		return new FNetStruct_Vector
		{
			X = InLocation.X,
			Y = InLocation.Y,
			Z = InLocation.Z
		};
	}

	public static FNetStruct_Rotator ToNetStruct(this FRotator InRotator)
	{
		return new FNetStruct_Rotator
		{
			Pitch = InRotator.Pitch,
			Yaw = InRotator.Yaw,
			Roll = InRotator.Roll
		};
	}

	public static FNetStruct_Rotator ToNetStruct(this GSRotation InRotator)
	{
		if (InRotator == null)
		{
			return default(FNetStruct_Rotator);
		}
		return new FNetStruct_Rotator
		{
			Pitch = InRotator.Pitch,
			Yaw = InRotator.Yaw,
			Roll = InRotator.Roll
		};
	}
}
