using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TransitionCondition_Battle")]
public struct FTransitionCondition_Battle
{
	[DisplayName("跳转条件类型")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:ConditionType")]
	public ETransitionConditionType_Battle ConditionType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("怪物列表")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:UnitList")]
	public FGsSmartParamArray UnitList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("指定刷怪器")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:UnitSpawner")]
	public FGsSmartParam UnitSpawner;

	[DisplayName("指定怪物")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:Unit")]
	public FGsSmartParam Unit;

	[EditAnywhere]
	[UProperty]
	[DisplayName("Buff ID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:Buff")]
	public FGsSmartParam Buff;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("击杀顺序")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:UnitKillOrder")]
	public FGsSmartParamArray UnitKillOrder;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("群体单位信息")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:GroupUnit")]
	public FGsSmartParam GroupUnit;

	[BlueprintReadWrite]
	[DisplayName("检测的触发盒")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:Overlap")]
	public FGsSmartParam Overlap;

	[DisplayName("死亡单位数量")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:UnitDeadNum")]
	public int UnitDeadNum;

	[Tooltip("单位：秒")]
	[BlueprintReadWrite]
	[DisplayName("倒计时时间")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:CountdownTime")]
	public int CountdownTime;

	[DisplayName("是否反转条件")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:bReverseCondition")]
	public bool bReverseCondition;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("注释")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Battle:Comment")]
	public string Comment;

	private static int TransitionCondition_Battle_StructSize;

	private static int TransitionCondition_Battle_IsValid;

	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool UnitList_IsValid;

	private static int UnitList_Offset;

	private static bool UnitSpawner_IsValid;

	private static int UnitSpawner_Offset;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool Buff_IsValid;

	private static int Buff_Offset;

	private static bool UnitKillOrder_IsValid;

	private static int UnitKillOrder_Offset;

	private static bool GroupUnit_IsValid;

	private static int GroupUnit_Offset;

	private static bool Overlap_IsValid;

	private static int Overlap_Offset;

	private static bool UnitDeadNum_IsValid;

	private static int UnitDeadNum_Offset;

	private static bool CountdownTime_IsValid;

	private static int CountdownTime_Offset;

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FTransitionCondition_Battle Copy()
	{
		return this;
	}

	public static FTransitionCondition_Battle FromNative(IntPtr nativeBuffer)
	{
		return new FTransitionCondition_Battle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTransitionCondition_Battle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTransitionCondition_Battle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTransitionCondition_Battle(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_Battle_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTransitionCondition_Battle value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_Battle_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TransitionCondition_Battle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_Battle");
			return;
		}
		EnumMarshaler<ETransitionConditionType_Battle>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		FGsSmartParamArray.ToNative(IntPtr.Add(nativeStruct, UnitList_Offset), UnitList);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, UnitSpawner_Offset), UnitSpawner);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Buff_Offset), Buff);
		FGsSmartParamArray.ToNative(IntPtr.Add(nativeStruct, UnitKillOrder_Offset), UnitKillOrder);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, GroupUnit_Offset), GroupUnit);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Overlap_Offset), Overlap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UnitDeadNum_Offset), UnitDeadNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CountdownTime_Offset), CountdownTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, bReverseCondition);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FTransitionCondition_Battle(IntPtr nativeStruct)
	{
		if (TransitionCondition_Battle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_Battle");
			ConditionType = ETransitionConditionType_Battle.None;
			UnitList = default(FGsSmartParamArray);
			UnitSpawner = default(FGsSmartParam);
			Unit = default(FGsSmartParam);
			Buff = default(FGsSmartParam);
			UnitKillOrder = default(FGsSmartParamArray);
			GroupUnit = default(FGsSmartParam);
			Overlap = default(FGsSmartParam);
			UnitDeadNum = 0;
			CountdownTime = 0;
			bReverseCondition = false;
			Comment = null;
		}
		else
		{
			ConditionType = EnumMarshaler<ETransitionConditionType_Battle>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			UnitList = FGsSmartParamArray.FromNative(IntPtr.Add(nativeStruct, UnitList_Offset));
			UnitSpawner = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, UnitSpawner_Offset));
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			Buff = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Buff_Offset));
			UnitKillOrder = FGsSmartParamArray.FromNative(IntPtr.Add(nativeStruct, UnitKillOrder_Offset));
			GroupUnit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, GroupUnit_Offset));
			Overlap = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Overlap_Offset));
			UnitDeadNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UnitDeadNum_Offset));
			CountdownTime = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CountdownTime_Offset));
			bReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TransitionCondition_Battle");
		TransitionCondition_Battle_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		UnitList_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitList");
		UnitList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitList", Classes.FStructProperty);
		UnitSpawner_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitSpawner");
		UnitSpawner_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitSpawner", Classes.FStructProperty);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		Buff_Offset = NativeReflection.GetPropertyOffset(intPtr, "Buff");
		Buff_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Buff", Classes.FStructProperty);
		UnitKillOrder_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitKillOrder");
		UnitKillOrder_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitKillOrder", Classes.FStructProperty);
		GroupUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupUnit");
		GroupUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupUnit", Classes.FStructProperty);
		Overlap_Offset = NativeReflection.GetPropertyOffset(intPtr, "Overlap");
		Overlap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Overlap", Classes.FStructProperty);
		UnitDeadNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitDeadNum");
		UnitDeadNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitDeadNum", Classes.FIntProperty);
		CountdownTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "CountdownTime");
		CountdownTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CountdownTime", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		TransitionCondition_Battle_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && UnitList_IsValid && UnitSpawner_IsValid && Unit_IsValid && Buff_IsValid && UnitKillOrder_IsValid && GroupUnit_IsValid && Overlap_IsValid && UnitDeadNum_IsValid && CountdownTime_IsValid && bReverseCondition_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TransitionCondition_Battle", (byte)TransitionCondition_Battle_IsValid != 0);
	}

	static FTransitionCondition_Battle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTransitionCondition_Battle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransitionCondition_Battle));
	}
}
