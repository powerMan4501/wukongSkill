using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSSplinePatrolWaitPoint")]
public struct FGSSplinePatrolWaitPoint
{
	public float WaitTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplinePatrolWaitPoint:WaitAM")]
	public UAnimMontage WaitAM;

	private static int FGSSplinePatrolWaitPoint_StructSize;

	private static int FGSSplinePatrolWaitPoint_IsValid;

	private static bool WaitAM_IsValid;

	private static int WaitAM_Offset;

	public FGSSplinePatrolWaitPoint Copy()
	{
		return this;
	}

	public static FGSSplinePatrolWaitPoint FromNative(IntPtr nativeBuffer)
	{
		return new FGSSplinePatrolWaitPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSplinePatrolWaitPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSplinePatrolWaitPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSplinePatrolWaitPoint(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplinePatrolWaitPoint_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSplinePatrolWaitPoint value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplinePatrolWaitPoint_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSplinePatrolWaitPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplinePatrolWaitPoint");
		}
		else
		{
			UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, WaitAM_Offset), WaitAM);
		}
	}

	public FGSSplinePatrolWaitPoint(IntPtr nativeStruct)
	{
		if (FGSSplinePatrolWaitPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplinePatrolWaitPoint");
			WaitAM = null;
		}
		else
		{
			WaitAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, WaitAM_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSplinePatrolWaitPoint");
		FGSSplinePatrolWaitPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		WaitAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitAM");
		WaitAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitAM", Classes.FObjectProperty);
		FGSSplinePatrolWaitPoint_IsValid = ((intPtr != IntPtr.Zero && WaitAM_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSplinePatrolWaitPoint", (byte)FGSSplinePatrolWaitPoint_IsValid != 0);
	}

	static FGSSplinePatrolWaitPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSplinePatrolWaitPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSplinePatrolWaitPoint));
	}
}
