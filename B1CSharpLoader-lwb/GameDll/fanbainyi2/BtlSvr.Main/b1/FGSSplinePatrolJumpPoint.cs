using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSSplinePatrolJumpPoint")]
public struct FGSSplinePatrolJumpPoint
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplinePatrolJumpPoint:JumpAM")]
	public UAnimMontage JumpAM;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSSplinePatrolJumpPoint:JumpForce")]
	public float JumpForce;

	private static int FGSSplinePatrolJumpPoint_StructSize;

	private static int FGSSplinePatrolJumpPoint_IsValid;

	private static bool JumpAM_IsValid;

	private static int JumpAM_Offset;

	private static bool JumpForce_IsValid;

	private static int JumpForce_Offset;

	public FGSSplinePatrolJumpPoint Copy()
	{
		return this;
	}

	public static FGSSplinePatrolJumpPoint FromNative(IntPtr nativeBuffer)
	{
		return new FGSSplinePatrolJumpPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSplinePatrolJumpPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSplinePatrolJumpPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSplinePatrolJumpPoint(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplinePatrolJumpPoint_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSplinePatrolJumpPoint value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplinePatrolJumpPoint_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSplinePatrolJumpPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplinePatrolJumpPoint");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, JumpAM_Offset), JumpAM);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, JumpForce_Offset), JumpForce);
	}

	public FGSSplinePatrolJumpPoint(IntPtr nativeStruct)
	{
		if (FGSSplinePatrolJumpPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplinePatrolJumpPoint");
			JumpAM = null;
			JumpForce = 0f;
		}
		else
		{
			JumpAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, JumpAM_Offset));
			JumpForce = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, JumpForce_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSplinePatrolJumpPoint");
		FGSSplinePatrolJumpPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		JumpAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpAM");
		JumpAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpAM", Classes.FObjectProperty);
		JumpForce_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpForce");
		JumpForce_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpForce", Classes.FFloatProperty);
		FGSSplinePatrolJumpPoint_IsValid = ((intPtr != IntPtr.Zero && JumpAM_IsValid && JumpForce_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSplinePatrolJumpPoint", (byte)FGSSplinePatrolJumpPoint_IsValid != 0);
	}

	static FGSSplinePatrolJumpPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSplinePatrolJumpPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSplinePatrolJumpPoint));
	}
}
