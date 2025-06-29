using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UnitAIDesc")]
public struct FUnitAIDesc
{
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:bOverrideEnableLoSVisualizationInTable")]
	public bool bOverrideEnableLoSVisualizationInTable;

	[UProperty]
	[BlueprintReadOnly]
	[UMeta(MDProp.EditCondition, "bOverrideEnableLoSVisualizationInTable")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:bEnableLoSVisualization")]
	public bool bEnableLoSVisualization;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("视野范围")]
	[Tooltip("-1, 读取表格数据")]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:SightRange")]
	public float SightRange;

	[DisplayName("视野夹角")]
	[Tooltip("-1, 读取表格数据")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:VisionAngleDegrees")]
	public float VisionAngleDegrees;

	[EditAnywhere]
	[UProperty]
	[Tooltip("-1, 读取表格数据")]
	[BlueprintReadOnly]
	[DisplayName("听力范围")]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:HearRange")]
	public float HearRange;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("追逐范围")]
	[Tooltip("-1, 读取表格数据")]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:PursuitRange")]
	public float PursuitRange;

	[UProperty]
	[EditAnywhere]
	[Tooltip("-1, 读取表格数据")]
	[DisplayName("默认观察时间最小值")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:AIWatchTimeMin")]
	public float AIWatchTimeMin;

	[Tooltip("-1, 读取表格数据")]
	[DisplayName("默认观察时间最大值")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:AIWatchTimeMax")]
	public float AIWatchTimeMax;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:bOverrideUnitAIAttackType")]
	public bool bOverrideUnitAIAttackType;

	[UMeta(MDProp.EditCondition, "bOverrideUnitAIAttackType")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[DisplayName("单位AI攻击类型")]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:UnitAIAttackType")]
	public EUnitAIAttackType UnitAIAttackType;

	[EditAnywhere]
	[DisplayName("僵持回家相关（Key是状态BuffID，默认状态是0）")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitAIDesc:StalemateInfoMap")]
	public Dictionary<int, FStalemateInfo> StalemateInfoMap;

	private static int UnitAIDesc_StructSize;

	private static int UnitAIDesc_IsValid;

	private static bool bOverrideEnableLoSVisualizationInTable_IsValid;

	private static int bOverrideEnableLoSVisualizationInTable_Offset;

	private static FFieldAddress bOverrideEnableLoSVisualizationInTable_PropertyAddress;

	private static bool bEnableLoSVisualization_IsValid;

	private static int bEnableLoSVisualization_Offset;

	private static FFieldAddress bEnableLoSVisualization_PropertyAddress;

	private static bool SightRange_IsValid;

	private static int SightRange_Offset;

	private static bool VisionAngleDegrees_IsValid;

	private static int VisionAngleDegrees_Offset;

	private static bool HearRange_IsValid;

	private static int HearRange_Offset;

	private static bool PursuitRange_IsValid;

	private static int PursuitRange_Offset;

	private static bool AIWatchTimeMin_IsValid;

	private static int AIWatchTimeMin_Offset;

	private static bool AIWatchTimeMax_IsValid;

	private static int AIWatchTimeMax_Offset;

	private static bool bOverrideUnitAIAttackType_IsValid;

	private static int bOverrideUnitAIAttackType_Offset;

	private static FFieldAddress bOverrideUnitAIAttackType_PropertyAddress;

	private static bool UnitAIAttackType_IsValid;

	private static int UnitAIAttackType_Offset;

	private static FFieldAddress UnitAIAttackType_PropertyAddress;

	private static bool StalemateInfoMap_IsValid;

	private static int StalemateInfoMap_Offset;

	private static FFieldAddress StalemateInfoMap_PropertyAddress;

	public FUnitAIDesc Copy()
	{
		FUnitAIDesc result = this;
		if (StalemateInfoMap != null)
		{
			result.StalemateInfoMap = new Dictionary<int, FStalemateInfo>(StalemateInfoMap);
		}
		return result;
	}

	public static FUnitAIDesc FromNative(IntPtr nativeBuffer)
	{
		return new FUnitAIDesc(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitAIDesc value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitAIDesc FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitAIDesc(IntPtr.Add(nativeBuffer, arrayIndex * UnitAIDesc_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitAIDesc value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitAIDesc_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitAIDesc_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitAIDesc");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bOverrideEnableLoSVisualizationInTable_Offset), 0, bOverrideEnableLoSVisualizationInTable_PropertyAddress.Address, bOverrideEnableLoSVisualizationInTable);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableLoSVisualization_Offset), 0, bEnableLoSVisualization_PropertyAddress.Address, bEnableLoSVisualization);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SightRange_Offset), SightRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VisionAngleDegrees_Offset), VisionAngleDegrees);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HearRange_Offset), HearRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PursuitRange_Offset), PursuitRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AIWatchTimeMin_Offset), AIWatchTimeMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AIWatchTimeMax_Offset), AIWatchTimeMax);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bOverrideUnitAIAttackType_Offset), 0, bOverrideUnitAIAttackType_PropertyAddress.Address, bOverrideUnitAIAttackType);
		EnumMarshaler<EUnitAIAttackType>.ToNative(IntPtr.Add(nativeStruct, UnitAIAttackType_Offset), 0, UnitAIAttackType_PropertyAddress.Address, UnitAIAttackType);
		new TMapCopyMarshaler<int, FStalemateInfo>(1, StalemateInfoMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FStalemateInfo, FStalemateInfo>.FromNative, CachedMarshalingDelegates<FStalemateInfo, FStalemateInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, StalemateInfoMap_Offset), StalemateInfoMap);
	}

	public FUnitAIDesc(IntPtr nativeStruct)
	{
		if (UnitAIDesc_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitAIDesc");
			bOverrideEnableLoSVisualizationInTable = false;
			bEnableLoSVisualization = false;
			SightRange = 0f;
			VisionAngleDegrees = 0f;
			HearRange = 0f;
			PursuitRange = 0f;
			AIWatchTimeMin = 0f;
			AIWatchTimeMax = 0f;
			bOverrideUnitAIAttackType = false;
			UnitAIAttackType = EUnitAIAttackType.ActiveAttack;
			StalemateInfoMap = null;
		}
		else
		{
			bOverrideEnableLoSVisualizationInTable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bOverrideEnableLoSVisualizationInTable_Offset), 0, bOverrideEnableLoSVisualizationInTable_PropertyAddress.Address);
			bEnableLoSVisualization = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableLoSVisualization_Offset), 0, bEnableLoSVisualization_PropertyAddress.Address);
			SightRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SightRange_Offset));
			VisionAngleDegrees = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VisionAngleDegrees_Offset));
			HearRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HearRange_Offset));
			PursuitRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PursuitRange_Offset));
			AIWatchTimeMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AIWatchTimeMin_Offset));
			AIWatchTimeMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AIWatchTimeMax_Offset));
			bOverrideUnitAIAttackType = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bOverrideUnitAIAttackType_Offset), 0, bOverrideUnitAIAttackType_PropertyAddress.Address);
			UnitAIAttackType = EnumMarshaler<EUnitAIAttackType>.FromNative(IntPtr.Add(nativeStruct, UnitAIAttackType_Offset), 0, UnitAIAttackType_PropertyAddress.Address);
			StalemateInfoMap = new TMapCopyMarshaler<int, FStalemateInfo>(1, StalemateInfoMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FStalemateInfo, FStalemateInfo>.FromNative, CachedMarshalingDelegates<FStalemateInfo, FStalemateInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, StalemateInfoMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitAIDesc");
		UnitAIDesc_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bOverrideEnableLoSVisualizationInTable_PropertyAddress, intPtr, "bOverrideEnableLoSVisualizationInTable");
		bOverrideEnableLoSVisualizationInTable_Offset = NativeReflection.GetPropertyOffset(intPtr, "bOverrideEnableLoSVisualizationInTable");
		bOverrideEnableLoSVisualizationInTable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bOverrideEnableLoSVisualizationInTable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableLoSVisualization_PropertyAddress, intPtr, "bEnableLoSVisualization");
		bEnableLoSVisualization_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableLoSVisualization");
		bEnableLoSVisualization_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableLoSVisualization", Classes.FBoolProperty);
		SightRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "SightRange");
		SightRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SightRange", Classes.FFloatProperty);
		VisionAngleDegrees_Offset = NativeReflection.GetPropertyOffset(intPtr, "VisionAngleDegrees");
		VisionAngleDegrees_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VisionAngleDegrees", Classes.FFloatProperty);
		HearRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "HearRange");
		HearRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HearRange", Classes.FFloatProperty);
		PursuitRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "PursuitRange");
		PursuitRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PursuitRange", Classes.FFloatProperty);
		AIWatchTimeMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "AIWatchTimeMin");
		AIWatchTimeMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AIWatchTimeMin", Classes.FFloatProperty);
		AIWatchTimeMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "AIWatchTimeMax");
		AIWatchTimeMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AIWatchTimeMax", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bOverrideUnitAIAttackType_PropertyAddress, intPtr, "bOverrideUnitAIAttackType");
		bOverrideUnitAIAttackType_Offset = NativeReflection.GetPropertyOffset(intPtr, "bOverrideUnitAIAttackType");
		bOverrideUnitAIAttackType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bOverrideUnitAIAttackType", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UnitAIAttackType_PropertyAddress, intPtr, "UnitAIAttackType");
		UnitAIAttackType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitAIAttackType");
		UnitAIAttackType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitAIAttackType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref StalemateInfoMap_PropertyAddress, intPtr, "StalemateInfoMap");
		StalemateInfoMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "StalemateInfoMap");
		StalemateInfoMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StalemateInfoMap", Classes.FMapProperty);
		UnitAIDesc_IsValid = ((intPtr != IntPtr.Zero && bOverrideEnableLoSVisualizationInTable_IsValid && bEnableLoSVisualization_IsValid && SightRange_IsValid && VisionAngleDegrees_IsValid && HearRange_IsValid && PursuitRange_IsValid && AIWatchTimeMin_IsValid && AIWatchTimeMax_IsValid && bOverrideUnitAIAttackType_IsValid && UnitAIAttackType_IsValid && StalemateInfoMap_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitAIDesc", (byte)UnitAIDesc_IsValid != 0);
	}

	static FUnitAIDesc()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitAIDesc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitAIDesc));
	}
}
