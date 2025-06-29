using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_RotateRootBone
{
	private static bool BasePose_IsValid;

	private static int BasePose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone:BasePose")]
	public FPoseLink BasePose;

	private static bool Pitch_IsValid;

	private static int Pitch_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone:Pitch")]
	public float Pitch;

	private static bool Yaw_IsValid;

	private static int Yaw_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone:Yaw")]
	public float Yaw;

	private static bool Roll_IsValid;

	private static int Roll_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone:Roll")]
	public float Roll;

	private static bool PitchScaleBiasClamp_IsValid;

	private static int PitchScaleBiasClamp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone:PitchScaleBiasClamp")]
	public FInputScaleBiasClamp PitchScaleBiasClamp;

	private static bool YawScaleBiasClamp_IsValid;

	private static int YawScaleBiasClamp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone:YawScaleBiasClamp")]
	public FInputScaleBiasClamp YawScaleBiasClamp;

	private static bool RollScaleBiasClamp_IsValid;

	private static int RollScaleBiasClamp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone:RollScaleBiasClamp")]
	public FInputScaleBiasClamp RollScaleBiasClamp;

	private static bool MeshToComponent_IsValid;

	private static int MeshToComponent_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone:MeshToComponent")]
	public FRotator MeshToComponent;

	private static bool FAnimNode_RotateRootBone_IsValid;

	private static int FAnimNode_RotateRootBone_StructSize;

	public FAnimNode_RotateRootBone Copy()
	{
		return this;
	}

	public static FAnimNode_RotateRootBone FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_RotateRootBone(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_RotateRootBone value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_RotateRootBone FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_RotateRootBone(nativeBuffer + arrayIndex * FAnimNode_RotateRootBone_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_RotateRootBone value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_RotateRootBone_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_RotateRootBone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_RotateRootBone");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, BasePose_Offset), BasePose);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Pitch_Offset), Pitch);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Yaw_Offset), Yaw);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Roll_Offset), Roll);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, PitchScaleBiasClamp_Offset), PitchScaleBiasClamp);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, YawScaleBiasClamp_Offset), YawScaleBiasClamp);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, RollScaleBiasClamp_Offset), RollScaleBiasClamp);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, MeshToComponent_Offset), MeshToComponent);
	}

	public FAnimNode_RotateRootBone(IntPtr nativeStruct)
	{
		if (!FAnimNode_RotateRootBone_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_RotateRootBone");
			BasePose = default(FPoseLink);
			Pitch = 0f;
			Yaw = 0f;
			Roll = 0f;
			PitchScaleBiasClamp = default(FInputScaleBiasClamp);
			YawScaleBiasClamp = default(FInputScaleBiasClamp);
			RollScaleBiasClamp = default(FInputScaleBiasClamp);
			MeshToComponent = default(FRotator);
		}
		else
		{
			BasePose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, BasePose_Offset));
			Pitch = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Pitch_Offset));
			Yaw = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Yaw_Offset));
			Roll = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Roll_Offset));
			PitchScaleBiasClamp = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, PitchScaleBiasClamp_Offset));
			YawScaleBiasClamp = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, YawScaleBiasClamp_Offset));
			RollScaleBiasClamp = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, RollScaleBiasClamp_Offset));
			MeshToComponent = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, MeshToComponent_Offset));
		}
	}

	static FAnimNode_RotateRootBone()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_RotateRootBone)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_RotateRootBone));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_RotateRootBone");
		FAnimNode_RotateRootBone_StructSize = NativeReflection.GetStructSize(intPtr);
		BasePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BasePose");
		BasePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BasePose", Classes.FStructProperty);
		Pitch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pitch");
		Pitch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pitch", Classes.FFloatProperty);
		Yaw_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Yaw");
		Yaw_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Yaw", Classes.FFloatProperty);
		Roll_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Roll");
		Roll_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Roll", Classes.FFloatProperty);
		PitchScaleBiasClamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PitchScaleBiasClamp");
		PitchScaleBiasClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PitchScaleBiasClamp", Classes.FStructProperty);
		YawScaleBiasClamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "YawScaleBiasClamp");
		YawScaleBiasClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "YawScaleBiasClamp", Classes.FStructProperty);
		RollScaleBiasClamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RollScaleBiasClamp");
		RollScaleBiasClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RollScaleBiasClamp", Classes.FStructProperty);
		MeshToComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshToComponent");
		MeshToComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshToComponent", Classes.FStructProperty);
		FAnimNode_RotateRootBone_IsValid = intPtr != IntPtr.Zero && BasePose_IsValid && Pitch_IsValid && Yaw_IsValid && Roll_IsValid && PitchScaleBiasClamp_IsValid && YawScaleBiasClamp_IsValid && RollScaleBiasClamp_IsValid && MeshToComponent_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_RotateRootBone", FAnimNode_RotateRootBone_IsValid);
	}
}
