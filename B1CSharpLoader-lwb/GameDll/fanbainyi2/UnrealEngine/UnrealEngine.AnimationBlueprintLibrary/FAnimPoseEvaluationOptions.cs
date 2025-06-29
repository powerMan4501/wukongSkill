using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions", "AnimationBlueprintLibrary", UnrealModuleType.Engine)]
public struct FAnimPoseEvaluationOptions
{
	private static bool EvaluationType_IsValid;

	private static FFieldAddress EvaluationType_PropertyAddress;

	private static int EvaluationType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:EvaluationType")]
	public EAnimDataEvalType EvaluationType;

	private static bool ShouldRetarget_IsValid;

	private static FFieldAddress ShouldRetarget_PropertyAddress;

	private static int ShouldRetarget_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:bShouldRetarget")]
	public bool ShouldRetarget;

	private static bool ExtractRootMotion_IsValid;

	private static FFieldAddress ExtractRootMotion_PropertyAddress;

	private static int ExtractRootMotion_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:bExtractRootMotion")]
	public bool ExtractRootMotion;

	private static bool OptionalSkeletalMesh_IsValid;

	private static int OptionalSkeletalMesh_Offset;

	[UProperty(Flags = (PropFlags)7885767187628549uL)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions:OptionalSkeletalMesh")]
	public USkeletalMesh OptionalSkeletalMesh;

	private static bool FAnimPoseEvaluationOptions_IsValid;

	private static int FAnimPoseEvaluationOptions_StructSize;

	public FAnimPoseEvaluationOptions Copy()
	{
		return this;
	}

	public static FAnimPoseEvaluationOptions FromNative(IntPtr nativeBuffer)
	{
		return new FAnimPoseEvaluationOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimPoseEvaluationOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimPoseEvaluationOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimPoseEvaluationOptions(nativeBuffer + arrayIndex * FAnimPoseEvaluationOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimPoseEvaluationOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimPoseEvaluationOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimPoseEvaluationOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions");
			return;
		}
		EnumMarshaler<EAnimDataEvalType>.ToNative(IntPtr.Add(nativeStruct, EvaluationType_Offset), 0, EvaluationType_PropertyAddress.Address, EvaluationType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShouldRetarget_Offset), 0, ShouldRetarget_PropertyAddress.Address, ShouldRetarget);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ExtractRootMotion_Offset), 0, ExtractRootMotion_PropertyAddress.Address, ExtractRootMotion);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(nativeStruct, OptionalSkeletalMesh_Offset), OptionalSkeletalMesh);
	}

	public FAnimPoseEvaluationOptions(IntPtr nativeStruct)
	{
		if (!FAnimPoseEvaluationOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions");
			EvaluationType = EAnimDataEvalType.Source;
			ShouldRetarget = false;
			ExtractRootMotion = false;
			OptionalSkeletalMesh = null;
		}
		else
		{
			EvaluationType = EnumMarshaler<EAnimDataEvalType>.FromNative(IntPtr.Add(nativeStruct, EvaluationType_Offset), 0, EvaluationType_PropertyAddress.Address);
			ShouldRetarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShouldRetarget_Offset), 0, ShouldRetarget_PropertyAddress.Address);
			ExtractRootMotion = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ExtractRootMotion_Offset), 0, ExtractRootMotion_PropertyAddress.Address);
			OptionalSkeletalMesh = UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(nativeStruct, OptionalSkeletalMesh_Offset));
		}
	}

	static FAnimPoseEvaluationOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimPoseEvaluationOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimPoseEvaluationOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions");
		FAnimPoseEvaluationOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EvaluationType_PropertyAddress, intPtr, "EvaluationType");
		EvaluationType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EvaluationType");
		EvaluationType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EvaluationType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldRetarget_PropertyAddress, intPtr, "bShouldRetarget");
		ShouldRetarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldRetarget");
		ShouldRetarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldRetarget", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractRootMotion_PropertyAddress, intPtr, "bExtractRootMotion");
		ExtractRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExtractRootMotion");
		ExtractRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExtractRootMotion", Classes.FBoolProperty);
		OptionalSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OptionalSkeletalMesh");
		OptionalSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OptionalSkeletalMesh", Classes.FObjectProperty);
		FAnimPoseEvaluationOptions_IsValid = intPtr != IntPtr.Zero && EvaluationType_IsValid && ShouldRetarget_IsValid && ExtractRootMotion_IsValid && OptionalSkeletalMesh_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions", FAnimPoseEvaluationOptions_IsValid);
	}
}
