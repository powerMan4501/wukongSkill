using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive")]
public struct FAnimHumanoidSetting_SpecialAdditive
{
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive:MinSlopeAngle")]
	public float MinSlopeAngle;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive:MaxSlopeAngle")]
	public float MaxSlopeAngle;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive:ASSlopeAdditiveLocalSpace")]
	public UAnimSequence ASSlopeAdditiveLocalSpace;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive:ASSlopeAdditiveMeshSpace")]
	public UAnimSequence ASSlopeAdditiveMeshSpace;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive:BSMoveSpeedAdditive")]
	public UBlendSpace BSMoveSpeedAdditive;

	private static int AnimHumanoidSetting_SpecialAdditive_StructSize;

	private static int AnimHumanoidSetting_SpecialAdditive_IsValid;

	private static bool MinSlopeAngle_IsValid;

	private static int MinSlopeAngle_Offset;

	private static bool MaxSlopeAngle_IsValid;

	private static int MaxSlopeAngle_Offset;

	private static bool ASSlopeAdditiveLocalSpace_IsValid;

	private static int ASSlopeAdditiveLocalSpace_Offset;

	private static bool ASSlopeAdditiveMeshSpace_IsValid;

	private static int ASSlopeAdditiveMeshSpace_Offset;

	private static bool BSMoveSpeedAdditive_IsValid;

	private static int BSMoveSpeedAdditive_Offset;

	public FAnimHumanoidSetting_SpecialAdditive Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_SpecialAdditive FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_SpecialAdditive(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_SpecialAdditive value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_SpecialAdditive FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_SpecialAdditive(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_SpecialAdditive_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_SpecialAdditive value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_SpecialAdditive_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_SpecialAdditive_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSlopeAngle_Offset), MinSlopeAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxSlopeAngle_Offset), MaxSlopeAngle);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSlopeAdditiveLocalSpace_Offset), ASSlopeAdditiveLocalSpace);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSlopeAdditiveMeshSpace_Offset), ASSlopeAdditiveMeshSpace);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSMoveSpeedAdditive_Offset), BSMoveSpeedAdditive);
	}

	public FAnimHumanoidSetting_SpecialAdditive(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_SpecialAdditive_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive");
			MinSlopeAngle = 0f;
			MaxSlopeAngle = 0f;
			ASSlopeAdditiveLocalSpace = null;
			ASSlopeAdditiveMeshSpace = null;
			BSMoveSpeedAdditive = null;
		}
		else
		{
			MinSlopeAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSlopeAngle_Offset));
			MaxSlopeAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxSlopeAngle_Offset));
			ASSlopeAdditiveLocalSpace = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSlopeAdditiveLocalSpace_Offset));
			ASSlopeAdditiveMeshSpace = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSlopeAdditiveMeshSpace_Offset));
			BSMoveSpeedAdditive = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSMoveSpeedAdditive_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive");
		AnimHumanoidSetting_SpecialAdditive_StructSize = NativeReflection.GetStructSize(intPtr);
		MinSlopeAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinSlopeAngle");
		MinSlopeAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinSlopeAngle", Classes.FFloatProperty);
		MaxSlopeAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxSlopeAngle");
		MaxSlopeAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxSlopeAngle", Classes.FFloatProperty);
		ASSlopeAdditiveLocalSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSlopeAdditiveLocalSpace");
		ASSlopeAdditiveLocalSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSlopeAdditiveLocalSpace", Classes.FObjectProperty);
		ASSlopeAdditiveMeshSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSlopeAdditiveMeshSpace");
		ASSlopeAdditiveMeshSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSlopeAdditiveMeshSpace", Classes.FObjectProperty);
		BSMoveSpeedAdditive_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSMoveSpeedAdditive");
		BSMoveSpeedAdditive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSMoveSpeedAdditive", Classes.FObjectProperty);
		AnimHumanoidSetting_SpecialAdditive_IsValid = ((intPtr != IntPtr.Zero && MinSlopeAngle_IsValid && MaxSlopeAngle_IsValid && ASSlopeAdditiveLocalSpace_IsValid && ASSlopeAdditiveMeshSpace_IsValid && BSMoveSpeedAdditive_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_SpecialAdditive", (byte)AnimHumanoidSetting_SpecialAdditive_IsValid != 0);
	}

	static FAnimHumanoidSetting_SpecialAdditive()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_SpecialAdditive)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_SpecialAdditive));
	}
}
