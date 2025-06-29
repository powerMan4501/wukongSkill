using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSCastDingShenSetting")]
public struct FGSCastDingShenSetting
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("定身添加Buff")]
	[USharpPath("/Script/b1-Managed.FGSCastDingShenSetting:DingShenBuffID")]
	public int DingShenBuffID;

	[DisplayName("开启范围选择")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSCastDingShenSetting:EnableRangeSelect")]
	public bool EnableRangeSelect;

	[Tooltip("包含目标自己")]
	[UMeta(MDProp.ClampMin, "1")]
	[DisplayName("定身目标个数")]
	[UMeta(MDProp.EditCondition, "EnableRangeSelect")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSCastDingShenSetting:SelectCount")]
	public int SelectCount;

	[UMeta(MDProp.EditCondition, "EnableRangeSelect")]
	[Tooltip("单位：cm, 目前只提供圆形")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("定身范围")]
	[USharpPath("/Script/b1-Managed.FGSCastDingShenSetting:RangeRadius")]
	public int RangeRadius;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("选取目标筛选")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "EnableRangeSelect")]
	[USharpPath("/Script/b1-Managed.FGSCastDingShenSetting:TargetFilter")]
	public int TargetFilter;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "EnableRangeSelect")]
	[DisplayName("目标类型筛选")]
	[USharpPath("/Script/b1-Managed.FGSCastDingShenSetting:TargetTypeFilter")]
	public int TargetTypeFilter;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("归属类型筛选")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "EnableRangeSelect")]
	[USharpPath("/Script/b1-Managed.FGSCastDingShenSetting:AffiliationTypeFilter")]
	public int AffiliationTypeFilter;

	private static int FGSCastDingShenSetting_StructSize;

	private static int FGSCastDingShenSetting_IsValid;

	private static bool DingShenBuffID_IsValid;

	private static int DingShenBuffID_Offset;

	private static bool EnableRangeSelect_IsValid;

	private static int EnableRangeSelect_Offset;

	private static FFieldAddress EnableRangeSelect_PropertyAddress;

	private static bool SelectCount_IsValid;

	private static int SelectCount_Offset;

	private static bool RangeRadius_IsValid;

	private static int RangeRadius_Offset;

	private static bool TargetFilter_IsValid;

	private static int TargetFilter_Offset;

	private static bool TargetTypeFilter_IsValid;

	private static int TargetTypeFilter_Offset;

	private static bool AffiliationTypeFilter_IsValid;

	private static int AffiliationTypeFilter_Offset;

	public FGSCastDingShenSetting Copy()
	{
		return this;
	}

	public static FGSCastDingShenSetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSCastDingShenSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSCastDingShenSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSCastDingShenSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSCastDingShenSetting(IntPtr.Add(nativeBuffer, arrayIndex * FGSCastDingShenSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSCastDingShenSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSCastDingShenSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSCastDingShenSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSCastDingShenSetting");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DingShenBuffID_Offset), DingShenBuffID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableRangeSelect_Offset), 0, EnableRangeSelect_PropertyAddress.Address, EnableRangeSelect);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SelectCount_Offset), SelectCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RangeRadius_Offset), RangeRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetFilter_Offset), TargetFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset), TargetTypeFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AffiliationTypeFilter_Offset), AffiliationTypeFilter);
	}

	public FGSCastDingShenSetting(IntPtr nativeStruct)
	{
		if (FGSCastDingShenSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSCastDingShenSetting");
			DingShenBuffID = 0;
			EnableRangeSelect = false;
			SelectCount = 0;
			RangeRadius = 0;
			TargetFilter = 0;
			TargetTypeFilter = 0;
			AffiliationTypeFilter = 0;
		}
		else
		{
			DingShenBuffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DingShenBuffID_Offset));
			EnableRangeSelect = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableRangeSelect_Offset), 0, EnableRangeSelect_PropertyAddress.Address);
			SelectCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SelectCount_Offset));
			RangeRadius = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RangeRadius_Offset));
			TargetFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetFilter_Offset));
			TargetTypeFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset));
			AffiliationTypeFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AffiliationTypeFilter_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSCastDingShenSetting");
		FGSCastDingShenSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		DingShenBuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DingShenBuffID");
		DingShenBuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DingShenBuffID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EnableRangeSelect_PropertyAddress, intPtr, "EnableRangeSelect");
		EnableRangeSelect_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableRangeSelect");
		EnableRangeSelect_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableRangeSelect", Classes.FBoolProperty);
		SelectCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "SelectCount");
		SelectCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SelectCount", Classes.FIntProperty);
		RangeRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeRadius");
		RangeRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeRadius", Classes.FIntProperty);
		TargetFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetFilter");
		TargetFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetFilter", Classes.FIntProperty);
		TargetTypeFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTypeFilter");
		TargetTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTypeFilter", Classes.FIntProperty);
		AffiliationTypeFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "AffiliationTypeFilter");
		AffiliationTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AffiliationTypeFilter", Classes.FIntProperty);
		FGSCastDingShenSetting_IsValid = ((intPtr != IntPtr.Zero && DingShenBuffID_IsValid && EnableRangeSelect_IsValid && SelectCount_IsValid && RangeRadius_IsValid && TargetFilter_IsValid && TargetTypeFilter_IsValid && AffiliationTypeFilter_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSCastDingShenSetting", (byte)FGSCastDingShenSetting_IsValid != 0);
	}

	static FGSCastDingShenSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSCastDingShenSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSCastDingShenSetting));
	}
}
