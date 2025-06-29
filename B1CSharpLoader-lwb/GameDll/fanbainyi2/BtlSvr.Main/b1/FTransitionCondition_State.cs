using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TransitionCondition_State")]
public struct FTransitionCondition_State
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("跳转条件类型")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:ConditionType")]
	public ETransitionConditionType_State ConditionType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("指定怪物")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:UnitList")]
	public FGsSmartParamArray UnitList;

	[EditAnywhere]
	[DisplayName("指定刷怪器")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:UnitSpawner")]
	public FGsSmartParam UnitSpawner;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("判断buff的怪物")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:Unit")]
	public FGsSmartParam Unit;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Buff ID")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:Buff")]
	public FGsSmartParam Buff;

	[UProperty]
	[EditAnywhere]
	[DisplayName("触发盒")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:Overlap")]
	public FGsSmartParam Overlap;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("交互物")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:Interactor")]
	public FGsSmartParam Interactor;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:Sequence")]
	public FGsSmartParam Sequence;

	[EditAnywhere]
	[UProperty]
	[DisplayName("任务阶段ID")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:TaskStage")]
	public FGsSmartParam TaskStage;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("任务阶段状态")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:TaskStageStatus")]
	public EStageStatus TaskStageStatus;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("计数类型")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:CounterType")]
	public EGameplayCounterType CounterType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("计数数值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:CounterValue")]
	public float CounterValue;

	[DisplayName("注释")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:Comment")]
	public string Comment;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("Circus成员别名")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_State:CircusMemberNickName")]
	public FGameplayTag CircusMemberNickName;

	private static int TransitionCondition_State_StructSize;

	private static int TransitionCondition_State_IsValid;

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

	private static bool Overlap_IsValid;

	private static int Overlap_Offset;

	private static bool Interactor_IsValid;

	private static int Interactor_Offset;

	private static bool Sequence_IsValid;

	private static int Sequence_Offset;

	private static bool TaskStage_IsValid;

	private static int TaskStage_Offset;

	private static bool TaskStageStatus_IsValid;

	private static int TaskStageStatus_Offset;

	private static FFieldAddress TaskStageStatus_PropertyAddress;

	private static bool CounterType_IsValid;

	private static int CounterType_Offset;

	private static FFieldAddress CounterType_PropertyAddress;

	private static bool CounterValue_IsValid;

	private static int CounterValue_Offset;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	private static bool CircusMemberNickName_IsValid;

	private static int CircusMemberNickName_Offset;

	public FTransitionCondition_State Copy()
	{
		return this;
	}

	public static FTransitionCondition_State FromNative(IntPtr nativeBuffer)
	{
		return new FTransitionCondition_State(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTransitionCondition_State value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTransitionCondition_State FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTransitionCondition_State(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_State_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTransitionCondition_State value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_State_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TransitionCondition_State_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_State");
			return;
		}
		EnumMarshaler<ETransitionConditionType_State>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		FGsSmartParamArray.ToNative(IntPtr.Add(nativeStruct, UnitList_Offset), UnitList);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, UnitSpawner_Offset), UnitSpawner);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Buff_Offset), Buff);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Overlap_Offset), Overlap);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Interactor_Offset), Interactor);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Sequence_Offset), Sequence);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, TaskStage_Offset), TaskStage);
		EnumMarshaler<EStageStatus>.ToNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address, TaskStageStatus);
		EnumMarshaler<EGameplayCounterType>.ToNative(IntPtr.Add(nativeStruct, CounterType_Offset), 0, CounterType_PropertyAddress.Address, CounterType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CounterValue_Offset), CounterValue);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, CircusMemberNickName_Offset), CircusMemberNickName);
	}

	public FTransitionCondition_State(IntPtr nativeStruct)
	{
		if (TransitionCondition_State_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_State");
			ConditionType = ETransitionConditionType_State.None;
			UnitList = default(FGsSmartParamArray);
			UnitSpawner = default(FGsSmartParam);
			Unit = default(FGsSmartParam);
			Buff = default(FGsSmartParam);
			Overlap = default(FGsSmartParam);
			Interactor = default(FGsSmartParam);
			Sequence = default(FGsSmartParam);
			TaskStage = default(FGsSmartParam);
			TaskStageStatus = EStageStatus.Default;
			CounterType = EGameplayCounterType.None;
			CounterValue = 0f;
			Comment = null;
			CircusMemberNickName = default(FGameplayTag);
		}
		else
		{
			ConditionType = EnumMarshaler<ETransitionConditionType_State>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			UnitList = FGsSmartParamArray.FromNative(IntPtr.Add(nativeStruct, UnitList_Offset));
			UnitSpawner = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, UnitSpawner_Offset));
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			Buff = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Buff_Offset));
			Overlap = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Overlap_Offset));
			Interactor = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Interactor_Offset));
			Sequence = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Sequence_Offset));
			TaskStage = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, TaskStage_Offset));
			TaskStageStatus = EnumMarshaler<EStageStatus>.FromNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address);
			CounterType = EnumMarshaler<EGameplayCounterType>.FromNative(IntPtr.Add(nativeStruct, CounterType_Offset), 0, CounterType_PropertyAddress.Address);
			CounterValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CounterValue_Offset));
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
			CircusMemberNickName = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, CircusMemberNickName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TransitionCondition_State");
		TransitionCondition_State_StructSize = NativeReflection.GetStructSize(intPtr);
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
		Overlap_Offset = NativeReflection.GetPropertyOffset(intPtr, "Overlap");
		Overlap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Overlap", Classes.FStructProperty);
		Interactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Interactor");
		Interactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Interactor", Classes.FStructProperty);
		Sequence_Offset = NativeReflection.GetPropertyOffset(intPtr, "Sequence");
		Sequence_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Sequence", Classes.FStructProperty);
		TaskStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStage");
		TaskStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStage", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStatus_PropertyAddress, intPtr, "TaskStageStatus");
		TaskStageStatus_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageStatus");
		TaskStageStatus_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageStatus", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CounterType_PropertyAddress, intPtr, "CounterType");
		CounterType_Offset = NativeReflection.GetPropertyOffset(intPtr, "CounterType");
		CounterType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CounterType", Classes.FEnumProperty);
		CounterValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CounterValue");
		CounterValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CounterValue", Classes.FFloatProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		CircusMemberNickName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CircusMemberNickName");
		CircusMemberNickName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CircusMemberNickName", Classes.FStructProperty);
		TransitionCondition_State_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && UnitList_IsValid && UnitSpawner_IsValid && Unit_IsValid && Buff_IsValid && Overlap_IsValid && Interactor_IsValid && Sequence_IsValid && TaskStage_IsValid && TaskStageStatus_IsValid && CounterType_IsValid && CounterValue_IsValid && Comment_IsValid && CircusMemberNickName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TransitionCondition_State", (byte)TransitionCondition_State_IsValid != 0);
	}

	static FTransitionCondition_State()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTransitionCondition_State)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransitionCondition_State));
	}
}
