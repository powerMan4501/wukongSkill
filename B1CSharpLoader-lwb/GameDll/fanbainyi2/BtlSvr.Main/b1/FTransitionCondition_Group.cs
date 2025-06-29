using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TransitionCondition_Group")]
public struct FTransitionCondition_Group
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("跳转条件类型")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:ConditionType")]
	public ETransitionConditionType_Group ConditionType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("指定怪物")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:UnitList")]
	public FGsSmartParamArray UnitList;

	[EditAnywhere]
	[UProperty]
	[DisplayName("指定刷怪器")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:UnitSpawner")]
	public FGsSmartParam UnitSpawner;

	[BlueprintReadWrite]
	[DisplayName("判断buff的怪物")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:Unit")]
	public FGsSmartParam Unit;

	[DisplayName("Buff ID")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:Buff")]
	public FGsSmartParam Buff;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("击杀顺序")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:UnitKillOrder")]
	public FGsSmartParamArray UnitKillOrder;

	[UProperty]
	[EditAnywhere]
	[DisplayName("触发盒")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:Overlap")]
	public FGsSmartParam Overlap;

	[DisplayName("交互物")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:Interactor")]
	public FGsSmartParam Interactor;

	[DisplayName("游戏状态条件")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:GameStateCondition")]
	public EQueryGameStateCondition GameStateCondition;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:Sequence")]
	public FGsSmartParam Sequence;

	[DisplayName("任务阶段ID")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:TaskStage")]
	public FGsSmartParam TaskStage;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("任务阶段状态")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:TaskStageStatus")]
	public EStageStatus TaskStageStatus;

	[DisplayName("是否反转条件")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:bReverseCondition")]
	public bool bReverseCondition;

	[DisplayName("注释")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Group:Comment")]
	public string Comment;

	private static int TransitionCondition_Group_StructSize;

	private static int TransitionCondition_Group_IsValid;

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

	private static bool Overlap_IsValid;

	private static int Overlap_Offset;

	private static bool Interactor_IsValid;

	private static int Interactor_Offset;

	private static bool GameStateCondition_IsValid;

	private static int GameStateCondition_Offset;

	private static FFieldAddress GameStateCondition_PropertyAddress;

	private static bool Sequence_IsValid;

	private static int Sequence_Offset;

	private static bool TaskStage_IsValid;

	private static int TaskStage_Offset;

	private static bool TaskStageStatus_IsValid;

	private static int TaskStageStatus_Offset;

	private static FFieldAddress TaskStageStatus_PropertyAddress;

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FTransitionCondition_Group Copy()
	{
		return this;
	}

	public static FTransitionCondition_Group FromNative(IntPtr nativeBuffer)
	{
		return new FTransitionCondition_Group(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTransitionCondition_Group value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTransitionCondition_Group FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTransitionCondition_Group(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_Group_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTransitionCondition_Group value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_Group_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TransitionCondition_Group_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_Group");
			return;
		}
		EnumMarshaler<ETransitionConditionType_Group>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		FGsSmartParamArray.ToNative(IntPtr.Add(nativeStruct, UnitList_Offset), UnitList);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, UnitSpawner_Offset), UnitSpawner);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Buff_Offset), Buff);
		FGsSmartParamArray.ToNative(IntPtr.Add(nativeStruct, UnitKillOrder_Offset), UnitKillOrder);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Overlap_Offset), Overlap);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Interactor_Offset), Interactor);
		EnumMarshaler<EQueryGameStateCondition>.ToNative(IntPtr.Add(nativeStruct, GameStateCondition_Offset), 0, GameStateCondition_PropertyAddress.Address, GameStateCondition);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Sequence_Offset), Sequence);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, TaskStage_Offset), TaskStage);
		EnumMarshaler<EStageStatus>.ToNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address, TaskStageStatus);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, bReverseCondition);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FTransitionCondition_Group(IntPtr nativeStruct)
	{
		if (TransitionCondition_Group_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_Group");
			ConditionType = ETransitionConditionType_Group.None;
			UnitList = default(FGsSmartParamArray);
			UnitSpawner = default(FGsSmartParam);
			Unit = default(FGsSmartParam);
			Buff = default(FGsSmartParam);
			UnitKillOrder = default(FGsSmartParamArray);
			Overlap = default(FGsSmartParam);
			Interactor = default(FGsSmartParam);
			GameStateCondition = EQueryGameStateCondition.None;
			Sequence = default(FGsSmartParam);
			TaskStage = default(FGsSmartParam);
			TaskStageStatus = EStageStatus.Default;
			bReverseCondition = false;
			Comment = null;
		}
		else
		{
			ConditionType = EnumMarshaler<ETransitionConditionType_Group>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			UnitList = FGsSmartParamArray.FromNative(IntPtr.Add(nativeStruct, UnitList_Offset));
			UnitSpawner = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, UnitSpawner_Offset));
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			Buff = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Buff_Offset));
			UnitKillOrder = FGsSmartParamArray.FromNative(IntPtr.Add(nativeStruct, UnitKillOrder_Offset));
			Overlap = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Overlap_Offset));
			Interactor = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Interactor_Offset));
			GameStateCondition = EnumMarshaler<EQueryGameStateCondition>.FromNative(IntPtr.Add(nativeStruct, GameStateCondition_Offset), 0, GameStateCondition_PropertyAddress.Address);
			Sequence = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Sequence_Offset));
			TaskStage = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, TaskStage_Offset));
			TaskStageStatus = EnumMarshaler<EStageStatus>.FromNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address);
			bReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TransitionCondition_Group");
		TransitionCondition_Group_StructSize = NativeReflection.GetStructSize(intPtr);
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
		Overlap_Offset = NativeReflection.GetPropertyOffset(intPtr, "Overlap");
		Overlap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Overlap", Classes.FStructProperty);
		Interactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Interactor");
		Interactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Interactor", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GameStateCondition_PropertyAddress, intPtr, "GameStateCondition");
		GameStateCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "GameStateCondition");
		GameStateCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GameStateCondition", Classes.FEnumProperty);
		Sequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "Sequence");
		Sequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Sequence", Classes.FStructProperty);
		TaskStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStage");
		TaskStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStage", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStatus_PropertyAddress, intPtr, "TaskStageStatus");
		TaskStageStatus_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageStatus");
		TaskStageStatus_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageStatus", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		TransitionCondition_Group_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && UnitList_IsValid && UnitSpawner_IsValid && Unit_IsValid && Buff_IsValid && UnitKillOrder_IsValid && Overlap_IsValid && Interactor_IsValid && GameStateCondition_IsValid && Sequence_IsValid && TaskStage_IsValid && TaskStageStatus_IsValid && bReverseCondition_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TransitionCondition_Group", (byte)TransitionCondition_Group_IsValid != 0);
	}

	static FTransitionCondition_Group()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTransitionCondition_Group)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransitionCondition_Group));
	}
}
