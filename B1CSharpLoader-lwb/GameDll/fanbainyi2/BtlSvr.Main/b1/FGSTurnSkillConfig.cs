using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSTurnSkillConfig")]
public struct FGSTurnSkillConfig
{
	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[UMeta(MDProp.ClampMax, "180")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSTurnSkillConfig:TurnDegreeThresholdLow")]
	public int TurnDegreeThresholdLow;

	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "180")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSTurnSkillConfig:TurnDegreeThresholdHigh")]
	public int TurnDegreeThresholdHigh;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSTurnSkillConfig:LeftSmallTurnSkillID")]
	public int LeftSmallTurnSkillID;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSTurnSkillConfig:LeftBigTurnSkillID")]
	public int LeftBigTurnSkillID;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSTurnSkillConfig:RightSmallTurnSkillID")]
	public int RightSmallTurnSkillID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSTurnSkillConfig:RightBigTurnSkillID")]
	public int RightBigTurnSkillID;

	[UProperty]
	[EditAnywhere]
	[Tooltip("是否禁用在播放转身技能同时进行寻路，若不禁用，播放转身技能的期间旋转会受寻路目标点方向的影响")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSTurnSkillConfig:bDisableImmediatePathfinding")]
	public bool bDisableImmediatePathfinding;

	private static int FGSTurnSkillConfig_StructSize;

	private static int FGSTurnSkillConfig_IsValid;

	private static bool TurnDegreeThresholdLow_IsValid;

	private static int TurnDegreeThresholdLow_Offset;

	private static bool TurnDegreeThresholdHigh_IsValid;

	private static int TurnDegreeThresholdHigh_Offset;

	private static bool LeftSmallTurnSkillID_IsValid;

	private static int LeftSmallTurnSkillID_Offset;

	private static bool LeftBigTurnSkillID_IsValid;

	private static int LeftBigTurnSkillID_Offset;

	private static bool RightSmallTurnSkillID_IsValid;

	private static int RightSmallTurnSkillID_Offset;

	private static bool RightBigTurnSkillID_IsValid;

	private static int RightBigTurnSkillID_Offset;

	private static bool bDisableImmediatePathfinding_IsValid;

	private static int bDisableImmediatePathfinding_Offset;

	private static FFieldAddress bDisableImmediatePathfinding_PropertyAddress;

	public FGSTurnSkillConfig Copy()
	{
		return this;
	}

	public static FGSTurnSkillConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSTurnSkillConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSTurnSkillConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSTurnSkillConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSTurnSkillConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSTurnSkillConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSTurnSkillConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSTurnSkillConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSTurnSkillConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSTurnSkillConfig");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TurnDegreeThresholdLow_Offset), TurnDegreeThresholdLow);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TurnDegreeThresholdHigh_Offset), TurnDegreeThresholdHigh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LeftSmallTurnSkillID_Offset), LeftSmallTurnSkillID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LeftBigTurnSkillID_Offset), LeftBigTurnSkillID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RightSmallTurnSkillID_Offset), RightSmallTurnSkillID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RightBigTurnSkillID_Offset), RightBigTurnSkillID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDisableImmediatePathfinding_Offset), 0, bDisableImmediatePathfinding_PropertyAddress.Address, bDisableImmediatePathfinding);
	}

	public FGSTurnSkillConfig(IntPtr nativeStruct)
	{
		if (FGSTurnSkillConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSTurnSkillConfig");
			TurnDegreeThresholdLow = 0;
			TurnDegreeThresholdHigh = 0;
			LeftSmallTurnSkillID = 0;
			LeftBigTurnSkillID = 0;
			RightSmallTurnSkillID = 0;
			RightBigTurnSkillID = 0;
			bDisableImmediatePathfinding = false;
		}
		else
		{
			TurnDegreeThresholdLow = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TurnDegreeThresholdLow_Offset));
			TurnDegreeThresholdHigh = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TurnDegreeThresholdHigh_Offset));
			LeftSmallTurnSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LeftSmallTurnSkillID_Offset));
			LeftBigTurnSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LeftBigTurnSkillID_Offset));
			RightSmallTurnSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RightSmallTurnSkillID_Offset));
			RightBigTurnSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RightBigTurnSkillID_Offset));
			bDisableImmediatePathfinding = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDisableImmediatePathfinding_Offset), 0, bDisableImmediatePathfinding_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSTurnSkillConfig");
		FGSTurnSkillConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		TurnDegreeThresholdLow_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurnDegreeThresholdLow");
		TurnDegreeThresholdLow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurnDegreeThresholdLow", Classes.FIntProperty);
		TurnDegreeThresholdHigh_Offset = NativeReflection.GetPropertyOffset(intPtr, "TurnDegreeThresholdHigh");
		TurnDegreeThresholdHigh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TurnDegreeThresholdHigh", Classes.FIntProperty);
		LeftSmallTurnSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftSmallTurnSkillID");
		LeftSmallTurnSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftSmallTurnSkillID", Classes.FIntProperty);
		LeftBigTurnSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftBigTurnSkillID");
		LeftBigTurnSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftBigTurnSkillID", Classes.FIntProperty);
		RightSmallTurnSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightSmallTurnSkillID");
		RightSmallTurnSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightSmallTurnSkillID", Classes.FIntProperty);
		RightBigTurnSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightBigTurnSkillID");
		RightBigTurnSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightBigTurnSkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bDisableImmediatePathfinding_PropertyAddress, intPtr, "bDisableImmediatePathfinding");
		bDisableImmediatePathfinding_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableImmediatePathfinding");
		bDisableImmediatePathfinding_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableImmediatePathfinding", Classes.FBoolProperty);
		FGSTurnSkillConfig_IsValid = ((intPtr != IntPtr.Zero && TurnDegreeThresholdLow_IsValid && TurnDegreeThresholdHigh_IsValid && LeftSmallTurnSkillID_IsValid && LeftBigTurnSkillID_IsValid && RightSmallTurnSkillID_IsValid && RightBigTurnSkillID_IsValid && bDisableImmediatePathfinding_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSTurnSkillConfig", (byte)FGSTurnSkillConfig_IsValid != 0);
	}

	static FGSTurnSkillConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSTurnSkillConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSTurnSkillConfig));
	}
}
