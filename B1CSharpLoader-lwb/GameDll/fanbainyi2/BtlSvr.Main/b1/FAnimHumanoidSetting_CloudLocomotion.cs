using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion")]
public struct FAnimHumanoidSetting_CloudLocomotion
{
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:RotationSpeedCurve")]
	public UCurveFloat RotationSpeedCurve;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:AnimIdleList")]
	public List<UAnimSequence> AnimIdleList;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:LeanPitchAdditvie_Up")]
	public UAnimSequence LeanPitchAdditvie_Up;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:LeanPitchAdditvie_Down")]
	public UAnimSequence LeanPitchAdditvie_Down;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:StartFwd")]
	public UAnimSequence StartFwd;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:StartFwdL")]
	public UAnimSequence StartFwdL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:StartFwdR")]
	public UAnimSequence StartFwdR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:StartBwdL")]
	public UAnimSequence StartBwdL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:StartBwdR")]
	public UAnimSequence StartBwdR;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:RunLoop")]
	public UAnimSequence RunLoop;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:RushLoop")]
	public UAnimSequence RushLoop;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:RunLoopAdditvie_Left")]
	public UAnimSequence RunLoopAdditvie_Left;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:RunLoopAdditvie_Right")]
	public UAnimSequence RunLoopAdditvie_Right;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:RushLoopAdditvie_Left")]
	public UAnimSequence RushLoopAdditvie_Left;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:RushLoopAdditvie_Right")]
	public UAnimSequence RushLoopAdditvie_Right;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:RunStop")]
	public UAnimSequence RunStop;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:RushStop")]
	public UAnimSequence RushStop;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:CloudFallLoop")]
	public UAnimSequence CloudFallLoop;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:CloudLand_High")]
	public FAnimHumanoidSetting_Jump_Land CloudLand_High;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:CloudLand_Low")]
	public FAnimHumanoidSetting_Jump_Land CloudLand_Low;

	[DisplayName("击坠动画配置")]
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion:CloudBreakAnimSettings")]
	public Dictionary<int, FCloudBreakAnimSetting> CloudBreakAnimSettings;

	private static int AnimHumanoidSetting_CloudLocomotion_StructSize;

	private static int AnimHumanoidSetting_CloudLocomotion_IsValid;

	private static bool RotationSpeedCurve_IsValid;

	private static int RotationSpeedCurve_Offset;

	private static bool AnimIdleList_IsValid;

	private static int AnimIdleList_Offset;

	private static FFieldAddress AnimIdleList_PropertyAddress;

	private static bool LeanPitchAdditvie_Up_IsValid;

	private static int LeanPitchAdditvie_Up_Offset;

	private static bool LeanPitchAdditvie_Down_IsValid;

	private static int LeanPitchAdditvie_Down_Offset;

	private static bool StartFwd_IsValid;

	private static int StartFwd_Offset;

	private static bool StartFwdL_IsValid;

	private static int StartFwdL_Offset;

	private static bool StartFwdR_IsValid;

	private static int StartFwdR_Offset;

	private static bool StartBwdL_IsValid;

	private static int StartBwdL_Offset;

	private static bool StartBwdR_IsValid;

	private static int StartBwdR_Offset;

	private static bool RunLoop_IsValid;

	private static int RunLoop_Offset;

	private static bool RushLoop_IsValid;

	private static int RushLoop_Offset;

	private static bool RunLoopAdditvie_Left_IsValid;

	private static int RunLoopAdditvie_Left_Offset;

	private static bool RunLoopAdditvie_Right_IsValid;

	private static int RunLoopAdditvie_Right_Offset;

	private static bool RushLoopAdditvie_Left_IsValid;

	private static int RushLoopAdditvie_Left_Offset;

	private static bool RushLoopAdditvie_Right_IsValid;

	private static int RushLoopAdditvie_Right_Offset;

	private static bool RunStop_IsValid;

	private static int RunStop_Offset;

	private static bool RushStop_IsValid;

	private static int RushStop_Offset;

	private static bool CloudFallLoop_IsValid;

	private static int CloudFallLoop_Offset;

	private static bool CloudLand_High_IsValid;

	private static int CloudLand_High_Offset;

	private static bool CloudLand_Low_IsValid;

	private static int CloudLand_Low_Offset;

	private static bool CloudBreakAnimSettings_IsValid;

	private static int CloudBreakAnimSettings_Offset;

	private static FFieldAddress CloudBreakAnimSettings_PropertyAddress;

	public FAnimHumanoidSetting_CloudLocomotion Copy()
	{
		FAnimHumanoidSetting_CloudLocomotion result = this;
		if (AnimIdleList != null)
		{
			result.AnimIdleList = new List<UAnimSequence>(AnimIdleList);
		}
		if (CloudBreakAnimSettings != null)
		{
			result.CloudBreakAnimSettings = new Dictionary<int, FCloudBreakAnimSetting>(CloudBreakAnimSettings);
		}
		return result;
	}

	public static FAnimHumanoidSetting_CloudLocomotion FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_CloudLocomotion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_CloudLocomotion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_CloudLocomotion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_CloudLocomotion(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_CloudLocomotion_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_CloudLocomotion value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_CloudLocomotion_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_CloudLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion");
			return;
		}
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, RotationSpeedCurve_Offset), RotationSpeedCurve);
		new TArrayCopyMarshaler<UAnimSequence>(1, AnimIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AnimIdleList_Offset), AnimIdleList);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, LeanPitchAdditvie_Up_Offset), LeanPitchAdditvie_Up);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, LeanPitchAdditvie_Down_Offset), LeanPitchAdditvie_Down);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, StartFwd_Offset), StartFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, StartFwdL_Offset), StartFwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, StartFwdR_Offset), StartFwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, StartBwdL_Offset), StartBwdL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, StartBwdR_Offset), StartBwdR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, RunLoop_Offset), RunLoop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, RushLoop_Offset), RushLoop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, RunLoopAdditvie_Left_Offset), RunLoopAdditvie_Left);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, RunLoopAdditvie_Right_Offset), RunLoopAdditvie_Right);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, RushLoopAdditvie_Left_Offset), RushLoopAdditvie_Left);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, RushLoopAdditvie_Right_Offset), RushLoopAdditvie_Right);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, RunStop_Offset), RunStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, RushStop_Offset), RushStop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, CloudFallLoop_Offset), CloudFallLoop);
		FAnimHumanoidSetting_Jump_Land.ToNative(IntPtr.Add(nativeStruct, CloudLand_High_Offset), CloudLand_High);
		FAnimHumanoidSetting_Jump_Land.ToNative(IntPtr.Add(nativeStruct, CloudLand_Low_Offset), CloudLand_Low);
		new TMapCopyMarshaler<int, FCloudBreakAnimSetting>(1, CloudBreakAnimSettings_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FCloudBreakAnimSetting, FCloudBreakAnimSetting>.FromNative, CachedMarshalingDelegates<FCloudBreakAnimSetting, FCloudBreakAnimSetting>.ToNative).ToNative(IntPtr.Add(nativeStruct, CloudBreakAnimSettings_Offset), CloudBreakAnimSettings);
	}

	public FAnimHumanoidSetting_CloudLocomotion(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_CloudLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion");
			RotationSpeedCurve = null;
			AnimIdleList = null;
			LeanPitchAdditvie_Up = null;
			LeanPitchAdditvie_Down = null;
			StartFwd = null;
			StartFwdL = null;
			StartFwdR = null;
			StartBwdL = null;
			StartBwdR = null;
			RunLoop = null;
			RushLoop = null;
			RunLoopAdditvie_Left = null;
			RunLoopAdditvie_Right = null;
			RushLoopAdditvie_Left = null;
			RushLoopAdditvie_Right = null;
			RunStop = null;
			RushStop = null;
			CloudFallLoop = null;
			CloudLand_High = default(FAnimHumanoidSetting_Jump_Land);
			CloudLand_Low = default(FAnimHumanoidSetting_Jump_Land);
			CloudBreakAnimSettings = null;
		}
		else
		{
			RotationSpeedCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, RotationSpeedCurve_Offset));
			AnimIdleList = new TArrayCopyMarshaler<UAnimSequence>(1, AnimIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AnimIdleList_Offset));
			LeanPitchAdditvie_Up = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, LeanPitchAdditvie_Up_Offset));
			LeanPitchAdditvie_Down = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, LeanPitchAdditvie_Down_Offset));
			StartFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, StartFwd_Offset));
			StartFwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, StartFwdL_Offset));
			StartFwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, StartFwdR_Offset));
			StartBwdL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, StartBwdL_Offset));
			StartBwdR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, StartBwdR_Offset));
			RunLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, RunLoop_Offset));
			RushLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, RushLoop_Offset));
			RunLoopAdditvie_Left = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, RunLoopAdditvie_Left_Offset));
			RunLoopAdditvie_Right = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, RunLoopAdditvie_Right_Offset));
			RushLoopAdditvie_Left = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, RushLoopAdditvie_Left_Offset));
			RushLoopAdditvie_Right = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, RushLoopAdditvie_Right_Offset));
			RunStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, RunStop_Offset));
			RushStop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, RushStop_Offset));
			CloudFallLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, CloudFallLoop_Offset));
			CloudLand_High = FAnimHumanoidSetting_Jump_Land.FromNative(IntPtr.Add(nativeStruct, CloudLand_High_Offset));
			CloudLand_Low = FAnimHumanoidSetting_Jump_Land.FromNative(IntPtr.Add(nativeStruct, CloudLand_Low_Offset));
			CloudBreakAnimSettings = new TMapCopyMarshaler<int, FCloudBreakAnimSetting>(1, CloudBreakAnimSettings_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FCloudBreakAnimSetting, FCloudBreakAnimSetting>.FromNative, CachedMarshalingDelegates<FCloudBreakAnimSetting, FCloudBreakAnimSetting>.ToNative).FromNative(IntPtr.Add(nativeStruct, CloudBreakAnimSettings_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion");
		AnimHumanoidSetting_CloudLocomotion_StructSize = NativeReflection.GetStructSize(intPtr);
		RotationSpeedCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationSpeedCurve");
		RotationSpeedCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationSpeedCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AnimIdleList_PropertyAddress, intPtr, "AnimIdleList");
		AnimIdleList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdleList");
		AnimIdleList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdleList", Classes.FArrayProperty);
		LeanPitchAdditvie_Up_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeanPitchAdditvie_Up");
		LeanPitchAdditvie_Up_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeanPitchAdditvie_Up", Classes.FObjectProperty);
		LeanPitchAdditvie_Down_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeanPitchAdditvie_Down");
		LeanPitchAdditvie_Down_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeanPitchAdditvie_Down", Classes.FObjectProperty);
		StartFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartFwd");
		StartFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartFwd", Classes.FObjectProperty);
		StartFwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartFwdL");
		StartFwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartFwdL", Classes.FObjectProperty);
		StartFwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartFwdR");
		StartFwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartFwdR", Classes.FObjectProperty);
		StartBwdL_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartBwdL");
		StartBwdL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartBwdL", Classes.FObjectProperty);
		StartBwdR_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartBwdR");
		StartBwdR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartBwdR", Classes.FObjectProperty);
		RunLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunLoop");
		RunLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunLoop", Classes.FObjectProperty);
		RushLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushLoop");
		RushLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushLoop", Classes.FObjectProperty);
		RunLoopAdditvie_Left_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunLoopAdditvie_Left");
		RunLoopAdditvie_Left_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunLoopAdditvie_Left", Classes.FObjectProperty);
		RunLoopAdditvie_Right_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunLoopAdditvie_Right");
		RunLoopAdditvie_Right_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunLoopAdditvie_Right", Classes.FObjectProperty);
		RushLoopAdditvie_Left_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushLoopAdditvie_Left");
		RushLoopAdditvie_Left_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushLoopAdditvie_Left", Classes.FObjectProperty);
		RushLoopAdditvie_Right_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushLoopAdditvie_Right");
		RushLoopAdditvie_Right_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushLoopAdditvie_Right", Classes.FObjectProperty);
		RunStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunStop");
		RunStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunStop", Classes.FObjectProperty);
		RushStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "RushStop");
		RushStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RushStop", Classes.FObjectProperty);
		CloudFallLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "CloudFallLoop");
		CloudFallLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CloudFallLoop", Classes.FObjectProperty);
		CloudLand_High_Offset = NativeReflection.GetPropertyOffset(intPtr, "CloudLand_High");
		CloudLand_High_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CloudLand_High", Classes.FStructProperty);
		CloudLand_Low_Offset = NativeReflection.GetPropertyOffset(intPtr, "CloudLand_Low");
		CloudLand_Low_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CloudLand_Low", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CloudBreakAnimSettings_PropertyAddress, intPtr, "CloudBreakAnimSettings");
		CloudBreakAnimSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "CloudBreakAnimSettings");
		CloudBreakAnimSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CloudBreakAnimSettings", Classes.FMapProperty);
		AnimHumanoidSetting_CloudLocomotion_IsValid = ((intPtr != IntPtr.Zero && RotationSpeedCurve_IsValid && AnimIdleList_IsValid && LeanPitchAdditvie_Up_IsValid && LeanPitchAdditvie_Down_IsValid && StartFwd_IsValid && StartFwdL_IsValid && StartFwdR_IsValid && StartBwdL_IsValid && StartBwdR_IsValid && RunLoop_IsValid && RushLoop_IsValid && RunLoopAdditvie_Left_IsValid && RunLoopAdditvie_Right_IsValid && RushLoopAdditvie_Left_IsValid && RushLoopAdditvie_Right_IsValid && RunStop_IsValid && RushStop_IsValid && CloudFallLoop_IsValid && CloudLand_High_IsValid && CloudLand_Low_IsValid && CloudBreakAnimSettings_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_CloudLocomotion", (byte)AnimHumanoidSetting_CloudLocomotion_IsValid != 0);
	}

	static FAnimHumanoidSetting_CloudLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_CloudLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_CloudLocomotion));
	}
}
