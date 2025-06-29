using System;
using b1.Plugins.MM;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting")]
public struct FGSMotionMatchingSetting
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:UseMotionMatching")]
	public bool UseMotionMatching;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:DefaultMMState")]
	public EState_MM DefaultMMState;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:AA_Locking")]
	public UAnimationAnalyzer AA_Locking;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:AA_Free")]
	public UAnimationAnalyzer AA_Free;

	[Tooltip("Blend time between different Animation Analyzer")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:AnimationAnalyzerBlendTime")]
	public float AnimationAnalyzerBlendTime;

	[Tooltip("Blend time between different animation in same Animation Analyzer")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:MotionBlendTime")]
	public float MotionBlendTime;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:ControllerInputReactionSpeed")]
	public float ControllerInputReactionSpeed;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:ControllerRotationReactionSpeed")]
	public float ControllerRotationReactionSpeed;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:BeginStandRotateAngleOffset")]
	public float BeginStandRotateAngleOffset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:StandRotateReactionSpeed")]
	public float StandRotateReactionSpeed;

	[UProperty]
	[Tooltip("Force set rotation by AI, when speed above this value")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:ForceSetRotAnimSpeed")]
	public float ForceSetRotAnimSpeed;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("Disable MotionMatching rotation verify, when speed below this value")]
	[USharpPath("/Script/b1-Managed.FGSMotionMatchingSetting:DisableRotVerifyAnimSpeed")]
	public float DisableRotVerifyAnimSpeed;

	private static int FGSMotionMatchingSetting_StructSize;

	private static int FGSMotionMatchingSetting_IsValid;

	private static bool UseMotionMatching_IsValid;

	private static int UseMotionMatching_Offset;

	private static FFieldAddress UseMotionMatching_PropertyAddress;

	private static bool DefaultMMState_IsValid;

	private static int DefaultMMState_Offset;

	private static FFieldAddress DefaultMMState_PropertyAddress;

	private static bool AA_Locking_IsValid;

	private static int AA_Locking_Offset;

	private static bool AA_Free_IsValid;

	private static int AA_Free_Offset;

	private static bool AnimationAnalyzerBlendTime_IsValid;

	private static int AnimationAnalyzerBlendTime_Offset;

	private static bool MotionBlendTime_IsValid;

	private static int MotionBlendTime_Offset;

	private static bool ControllerInputReactionSpeed_IsValid;

	private static int ControllerInputReactionSpeed_Offset;

	private static bool ControllerRotationReactionSpeed_IsValid;

	private static int ControllerRotationReactionSpeed_Offset;

	private static bool BeginStandRotateAngleOffset_IsValid;

	private static int BeginStandRotateAngleOffset_Offset;

	private static bool StandRotateReactionSpeed_IsValid;

	private static int StandRotateReactionSpeed_Offset;

	private static bool ForceSetRotAnimSpeed_IsValid;

	private static int ForceSetRotAnimSpeed_Offset;

	private static bool DisableRotVerifyAnimSpeed_IsValid;

	private static int DisableRotVerifyAnimSpeed_Offset;

	public FGSMotionMatchingSetting Copy()
	{
		return this;
	}

	public static FGSMotionMatchingSetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSMotionMatchingSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSMotionMatchingSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSMotionMatchingSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSMotionMatchingSetting(IntPtr.Add(nativeBuffer, arrayIndex * FGSMotionMatchingSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSMotionMatchingSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSMotionMatchingSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSMotionMatchingSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSMotionMatchingSetting");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseMotionMatching_Offset), 0, UseMotionMatching_PropertyAddress.Address, UseMotionMatching);
		EnumMarshaler<EState_MM>.ToNative(IntPtr.Add(nativeStruct, DefaultMMState_Offset), 0, DefaultMMState_PropertyAddress.Address, DefaultMMState);
		UObjectMarshaler<UAnimationAnalyzer>.ToNative(IntPtr.Add(nativeStruct, AA_Locking_Offset), AA_Locking);
		UObjectMarshaler<UAnimationAnalyzer>.ToNative(IntPtr.Add(nativeStruct, AA_Free_Offset), AA_Free);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimationAnalyzerBlendTime_Offset), AnimationAnalyzerBlendTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MotionBlendTime_Offset), MotionBlendTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ControllerInputReactionSpeed_Offset), ControllerInputReactionSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ControllerRotationReactionSpeed_Offset), ControllerRotationReactionSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeginStandRotateAngleOffset_Offset), BeginStandRotateAngleOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StandRotateReactionSpeed_Offset), StandRotateReactionSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ForceSetRotAnimSpeed_Offset), ForceSetRotAnimSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DisableRotVerifyAnimSpeed_Offset), DisableRotVerifyAnimSpeed);
	}

	public FGSMotionMatchingSetting(IntPtr nativeStruct)
	{
		if (FGSMotionMatchingSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSMotionMatchingSetting");
			UseMotionMatching = false;
			DefaultMMState = EState_MM.None;
			AA_Locking = null;
			AA_Free = null;
			AnimationAnalyzerBlendTime = 0f;
			MotionBlendTime = 0f;
			ControllerInputReactionSpeed = 0f;
			ControllerRotationReactionSpeed = 0f;
			BeginStandRotateAngleOffset = 0f;
			StandRotateReactionSpeed = 0f;
			ForceSetRotAnimSpeed = 0f;
			DisableRotVerifyAnimSpeed = 0f;
		}
		else
		{
			UseMotionMatching = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseMotionMatching_Offset), 0, UseMotionMatching_PropertyAddress.Address);
			DefaultMMState = EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(nativeStruct, DefaultMMState_Offset), 0, DefaultMMState_PropertyAddress.Address);
			AA_Locking = UObjectMarshaler<UAnimationAnalyzer>.FromNative(IntPtr.Add(nativeStruct, AA_Locking_Offset));
			AA_Free = UObjectMarshaler<UAnimationAnalyzer>.FromNative(IntPtr.Add(nativeStruct, AA_Free_Offset));
			AnimationAnalyzerBlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimationAnalyzerBlendTime_Offset));
			MotionBlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MotionBlendTime_Offset));
			ControllerInputReactionSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ControllerInputReactionSpeed_Offset));
			ControllerRotationReactionSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ControllerRotationReactionSpeed_Offset));
			BeginStandRotateAngleOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeginStandRotateAngleOffset_Offset));
			StandRotateReactionSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StandRotateReactionSpeed_Offset));
			ForceSetRotAnimSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ForceSetRotAnimSpeed_Offset));
			DisableRotVerifyAnimSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DisableRotVerifyAnimSpeed_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSMotionMatchingSetting");
		FGSMotionMatchingSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UseMotionMatching_PropertyAddress, intPtr, "UseMotionMatching");
		UseMotionMatching_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseMotionMatching");
		UseMotionMatching_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseMotionMatching", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DefaultMMState_PropertyAddress, intPtr, "DefaultMMState");
		DefaultMMState_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultMMState");
		DefaultMMState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultMMState", Classes.FEnumProperty);
		AA_Locking_Offset = NativeReflection.GetPropertyOffset(intPtr, "AA_Locking");
		AA_Locking_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AA_Locking", Classes.FObjectProperty);
		AA_Free_Offset = NativeReflection.GetPropertyOffset(intPtr, "AA_Free");
		AA_Free_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AA_Free", Classes.FObjectProperty);
		AnimationAnalyzerBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationAnalyzerBlendTime");
		AnimationAnalyzerBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationAnalyzerBlendTime", Classes.FFloatProperty);
		MotionBlendTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "MotionBlendTime");
		MotionBlendTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MotionBlendTime", Classes.FFloatProperty);
		ControllerInputReactionSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "ControllerInputReactionSpeed");
		ControllerInputReactionSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ControllerInputReactionSpeed", Classes.FFloatProperty);
		ControllerRotationReactionSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "ControllerRotationReactionSpeed");
		ControllerRotationReactionSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ControllerRotationReactionSpeed", Classes.FFloatProperty);
		BeginStandRotateAngleOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeginStandRotateAngleOffset");
		BeginStandRotateAngleOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeginStandRotateAngleOffset", Classes.FFloatProperty);
		StandRotateReactionSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "StandRotateReactionSpeed");
		StandRotateReactionSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StandRotateReactionSpeed", Classes.FFloatProperty);
		ForceSetRotAnimSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceSetRotAnimSpeed");
		ForceSetRotAnimSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceSetRotAnimSpeed", Classes.FFloatProperty);
		DisableRotVerifyAnimSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisableRotVerifyAnimSpeed");
		DisableRotVerifyAnimSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisableRotVerifyAnimSpeed", Classes.FFloatProperty);
		FGSMotionMatchingSetting_IsValid = ((intPtr != IntPtr.Zero && UseMotionMatching_IsValid && DefaultMMState_IsValid && AA_Locking_IsValid && AA_Free_IsValid && AnimationAnalyzerBlendTime_IsValid && MotionBlendTime_IsValid && ControllerInputReactionSpeed_IsValid && ControllerRotationReactionSpeed_IsValid && BeginStandRotateAngleOffset_IsValid && StandRotateReactionSpeed_IsValid && ForceSetRotAnimSpeed_IsValid && DisableRotVerifyAnimSpeed_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSMotionMatchingSetting", (byte)FGSMotionMatchingSetting_IsValid != 0);
	}

	static FGSMotionMatchingSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSMotionMatchingSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSMotionMatchingSetting));
	}
}
