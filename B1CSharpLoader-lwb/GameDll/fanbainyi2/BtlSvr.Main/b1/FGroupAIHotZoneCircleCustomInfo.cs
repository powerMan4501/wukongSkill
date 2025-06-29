using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GroupAIHotZoneCircleCustomInfo")]
public struct FGroupAIHotZoneCircleCustomInfo
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GroupAIHotZoneCircleCustomInfo:EnableCustomSetting")]
	public bool EnableCustomSetting;

	[Tooltip("决定一个区域内有几环点")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.EditCondition, "EnableCustomSetting")]
	[DisplayName("站点圈点环数")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GroupAIHotZoneCircleCustomInfo:BattleCirclePointRingNum")]
	public int BattleCirclePointRingNum;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("站点圈角度间隔")]
	[Tooltip("单位：°；决定一环点的密度")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.ClampMax, 360)]
	[UMeta(MDProp.EditCondition, "EnableCustomSetting")]
	[USharpPath("/Script/b1-Managed.GroupAIHotZoneCircleCustomInfo:BattleCirclePointAngleInterval")]
	public int BattleCirclePointAngleInterval;

	private static int GroupAIHotZoneCircleCustomInfo_StructSize;

	private static int GroupAIHotZoneCircleCustomInfo_IsValid;

	private static bool EnableCustomSetting_IsValid;

	private static int EnableCustomSetting_Offset;

	private static FFieldAddress EnableCustomSetting_PropertyAddress;

	private static bool BattleCirclePointRingNum_IsValid;

	private static int BattleCirclePointRingNum_Offset;

	private static bool BattleCirclePointAngleInterval_IsValid;

	private static int BattleCirclePointAngleInterval_Offset;

	public FGroupAIHotZoneCircleCustomInfo Copy()
	{
		return this;
	}

	public static FGroupAIHotZoneCircleCustomInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGroupAIHotZoneCircleCustomInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGroupAIHotZoneCircleCustomInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGroupAIHotZoneCircleCustomInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGroupAIHotZoneCircleCustomInfo(IntPtr.Add(nativeBuffer, arrayIndex * GroupAIHotZoneCircleCustomInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGroupAIHotZoneCircleCustomInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GroupAIHotZoneCircleCustomInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GroupAIHotZoneCircleCustomInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GroupAIHotZoneCircleCustomInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableCustomSetting_Offset), 0, EnableCustomSetting_PropertyAddress.Address, EnableCustomSetting);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BattleCirclePointRingNum_Offset), BattleCirclePointRingNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BattleCirclePointAngleInterval_Offset), BattleCirclePointAngleInterval);
	}

	public FGroupAIHotZoneCircleCustomInfo(IntPtr nativeStruct)
	{
		if (GroupAIHotZoneCircleCustomInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GroupAIHotZoneCircleCustomInfo");
			EnableCustomSetting = false;
			BattleCirclePointRingNum = 0;
			BattleCirclePointAngleInterval = 0;
		}
		else
		{
			EnableCustomSetting = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableCustomSetting_Offset), 0, EnableCustomSetting_PropertyAddress.Address);
			BattleCirclePointRingNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BattleCirclePointRingNum_Offset));
			BattleCirclePointAngleInterval = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BattleCirclePointAngleInterval_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GroupAIHotZoneCircleCustomInfo");
		GroupAIHotZoneCircleCustomInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref EnableCustomSetting_PropertyAddress, intPtr, "EnableCustomSetting");
		EnableCustomSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableCustomSetting");
		EnableCustomSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableCustomSetting", Classes.FBoolProperty);
		BattleCirclePointRingNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleCirclePointRingNum");
		BattleCirclePointRingNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleCirclePointRingNum", Classes.FIntProperty);
		BattleCirclePointAngleInterval_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleCirclePointAngleInterval");
		BattleCirclePointAngleInterval_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleCirclePointAngleInterval", Classes.FIntProperty);
		GroupAIHotZoneCircleCustomInfo_IsValid = ((intPtr != IntPtr.Zero && EnableCustomSetting_IsValid && BattleCirclePointRingNum_IsValid && BattleCirclePointAngleInterval_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GroupAIHotZoneCircleCustomInfo", (byte)GroupAIHotZoneCircleCustomInfo_IsValid != 0);
	}

	static FGroupAIHotZoneCircleCustomInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGroupAIHotZoneCircleCustomInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGroupAIHotZoneCircleCustomInfo));
	}
}
