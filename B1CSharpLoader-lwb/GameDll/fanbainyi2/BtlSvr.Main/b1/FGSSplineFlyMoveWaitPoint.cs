using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint")]
public struct FGSSplineFlyMoveWaitPoint
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint:IsUnlimitedNeedWaitTime")]
	public bool IsUnlimitedNeedWaitTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint:WaitTime")]
	public float WaitTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint:WaitAM")]
	public UAnimMontage WaitAM;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint:ForwardSplineRangeAfterWaiting")]
	public float ForwardSplineRangeAfterWaiting;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint:TransitionInterpSpeed")]
	public float TransitionInterpSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint:RotationInterpSpeed")]
	public float RotationInterpSpeed;

	private static int FGSSplineFlyMoveWaitPoint_StructSize;

	private static int FGSSplineFlyMoveWaitPoint_IsValid;

	private static bool IsUnlimitedNeedWaitTime_IsValid;

	private static int IsUnlimitedNeedWaitTime_Offset;

	private static FFieldAddress IsUnlimitedNeedWaitTime_PropertyAddress;

	private static bool WaitTime_IsValid;

	private static int WaitTime_Offset;

	private static bool WaitAM_IsValid;

	private static int WaitAM_Offset;

	private static bool ForwardSplineRangeAfterWaiting_IsValid;

	private static int ForwardSplineRangeAfterWaiting_Offset;

	private static bool TransitionInterpSpeed_IsValid;

	private static int TransitionInterpSpeed_Offset;

	private static bool RotationInterpSpeed_IsValid;

	private static int RotationInterpSpeed_Offset;

	public FGSSplineFlyMoveWaitPoint Copy()
	{
		return this;
	}

	public static FGSSplineFlyMoveWaitPoint FromNative(IntPtr nativeBuffer)
	{
		return new FGSSplineFlyMoveWaitPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSplineFlyMoveWaitPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSplineFlyMoveWaitPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSplineFlyMoveWaitPoint(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplineFlyMoveWaitPoint_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSplineFlyMoveWaitPoint value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplineFlyMoveWaitPoint_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSplineFlyMoveWaitPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsUnlimitedNeedWaitTime_Offset), 0, IsUnlimitedNeedWaitTime_PropertyAddress.Address, IsUnlimitedNeedWaitTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WaitTime_Offset), WaitTime);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, WaitAM_Offset), WaitAM);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ForwardSplineRangeAfterWaiting_Offset), ForwardSplineRangeAfterWaiting);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TransitionInterpSpeed_Offset), TransitionInterpSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RotationInterpSpeed_Offset), RotationInterpSpeed);
	}

	public FGSSplineFlyMoveWaitPoint(IntPtr nativeStruct)
	{
		if (FGSSplineFlyMoveWaitPoint_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint");
			IsUnlimitedNeedWaitTime = false;
			WaitTime = 0f;
			WaitAM = null;
			ForwardSplineRangeAfterWaiting = 0f;
			TransitionInterpSpeed = 0f;
			RotationInterpSpeed = 0f;
		}
		else
		{
			IsUnlimitedNeedWaitTime = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsUnlimitedNeedWaitTime_Offset), 0, IsUnlimitedNeedWaitTime_PropertyAddress.Address);
			WaitTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WaitTime_Offset));
			WaitAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, WaitAM_Offset));
			ForwardSplineRangeAfterWaiting = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ForwardSplineRangeAfterWaiting_Offset));
			TransitionInterpSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TransitionInterpSpeed_Offset));
			RotationInterpSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RotationInterpSpeed_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint");
		FGSSplineFlyMoveWaitPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref IsUnlimitedNeedWaitTime_PropertyAddress, intPtr, "IsUnlimitedNeedWaitTime");
		IsUnlimitedNeedWaitTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUnlimitedNeedWaitTime");
		IsUnlimitedNeedWaitTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUnlimitedNeedWaitTime", Classes.FBoolProperty);
		WaitTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitTime");
		WaitTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitTime", Classes.FFloatProperty);
		WaitAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitAM");
		WaitAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitAM", Classes.FObjectProperty);
		ForwardSplineRangeAfterWaiting_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardSplineRangeAfterWaiting");
		ForwardSplineRangeAfterWaiting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardSplineRangeAfterWaiting", Classes.FFloatProperty);
		TransitionInterpSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransitionInterpSpeed");
		TransitionInterpSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransitionInterpSpeed", Classes.FFloatProperty);
		RotationInterpSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationInterpSpeed");
		RotationInterpSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationInterpSpeed", Classes.FFloatProperty);
		FGSSplineFlyMoveWaitPoint_IsValid = ((intPtr != IntPtr.Zero && IsUnlimitedNeedWaitTime_IsValid && WaitTime_IsValid && WaitAM_IsValid && ForwardSplineRangeAfterWaiting_IsValid && TransitionInterpSpeed_IsValid && RotationInterpSpeed_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSplineFlyMoveWaitPoint", (byte)FGSSplineFlyMoveWaitPoint_IsValid != 0);
	}

	static FGSSplineFlyMoveWaitPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSplineFlyMoveWaitPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSplineFlyMoveWaitPoint));
	}
}
