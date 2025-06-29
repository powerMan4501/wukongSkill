using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_ActorYawRotation")]
public struct FDetectCondition_ActorYawRotation
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("基准方向")]
	[USharpPath("/Script/b1-Managed.DetectCondition_ActorYawRotation:BaseDirection")]
	public ERotationBaseDirection BaseDirection;

	[UMeta(MDProp.ClampMin, -180f)]
	[UMeta(MDProp.ClampMax, 180f)]
	[EditAnywhere]
	[DisplayName("最小Yaw值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_ActorYawRotation:MinYawAngle")]
	public float MinYawAngle;

	[UProperty]
	[EditAnywhere]
	[DisplayName("最大Yaw值")]
	[UMeta(MDProp.ClampMin, -180f)]
	[UMeta(MDProp.ClampMax, 180f)]
	[USharpPath("/Script/b1-Managed.DetectCondition_ActorYawRotation:MaxYawAngle")]
	public float MaxYawAngle;

	private static int DetectCondition_ActorYawRotation_StructSize;

	private static int DetectCondition_ActorYawRotation_IsValid;

	private static bool BaseDirection_IsValid;

	private static int BaseDirection_Offset;

	private static FFieldAddress BaseDirection_PropertyAddress;

	private static bool MinYawAngle_IsValid;

	private static int MinYawAngle_Offset;

	private static bool MaxYawAngle_IsValid;

	private static int MaxYawAngle_Offset;

	public FDetectCondition_ActorYawRotation Copy()
	{
		return this;
	}

	public static FDetectCondition_ActorYawRotation FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_ActorYawRotation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_ActorYawRotation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_ActorYawRotation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_ActorYawRotation(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_ActorYawRotation_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_ActorYawRotation value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_ActorYawRotation_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_ActorYawRotation_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_ActorYawRotation");
			return;
		}
		EnumMarshaler<ERotationBaseDirection>.ToNative(IntPtr.Add(nativeStruct, BaseDirection_Offset), 0, BaseDirection_PropertyAddress.Address, BaseDirection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinYawAngle_Offset), MinYawAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxYawAngle_Offset), MaxYawAngle);
	}

	public FDetectCondition_ActorYawRotation(IntPtr nativeStruct)
	{
		if (DetectCondition_ActorYawRotation_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_ActorYawRotation");
			BaseDirection = ERotationBaseDirection.WorldSpaceXAxis;
			MinYawAngle = 0f;
			MaxYawAngle = 0f;
		}
		else
		{
			BaseDirection = EnumMarshaler<ERotationBaseDirection>.FromNative(IntPtr.Add(nativeStruct, BaseDirection_Offset), 0, BaseDirection_PropertyAddress.Address);
			MinYawAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinYawAngle_Offset));
			MaxYawAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxYawAngle_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_ActorYawRotation");
		DetectCondition_ActorYawRotation_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref BaseDirection_PropertyAddress, intPtr, "BaseDirection");
		BaseDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseDirection");
		BaseDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseDirection", Classes.FEnumProperty);
		MinYawAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinYawAngle");
		MinYawAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinYawAngle", Classes.FFloatProperty);
		MaxYawAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxYawAngle");
		MaxYawAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxYawAngle", Classes.FFloatProperty);
		DetectCondition_ActorYawRotation_IsValid = ((intPtr != IntPtr.Zero && BaseDirection_IsValid && MinYawAngle_IsValid && MaxYawAngle_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_ActorYawRotation", (byte)DetectCondition_ActorYawRotation_IsValid != 0);
	}

	static FDetectCondition_ActorYawRotation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_ActorYawRotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_ActorYawRotation));
	}
}
