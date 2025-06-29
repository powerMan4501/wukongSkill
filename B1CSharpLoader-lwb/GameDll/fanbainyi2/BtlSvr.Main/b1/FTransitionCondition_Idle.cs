using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TransitionCondition_Idle")]
public struct FTransitionCondition_Idle
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("跳转条件类型")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:ConditionType")]
	public ETransitionConditionType_Idle ConditionType;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("触发盒")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:Overlap")]
	public FGsSmartParam Overlap;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("交互物")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:Interactor")]
	public FGsSmartParam Interactor;

	[EditAnywhere]
	[UProperty]
	[DisplayName("单位")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:Unit")]
	public FGsSmartParam Unit;

	[BlueprintReadWrite]
	[DisplayName("NPC")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:NPCUnit")]
	public FGsSmartParam NPCUnit;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("游戏状态条件")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:GameStateCondition")]
	public EQueryGameStateCondition GameStateCondition;

	[DisplayName("隐性区域内计时器")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:Timer_InArea")]
	public float Timer_InArea;

	[DisplayName("隐性区域外计时器")]
	[Tooltip("填-1，则不开启出区域过期倒计时")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:Timer_OutArea")]
	public float Timer_OutArea;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("任务阶段ID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:TaskStage")]
	public FGsSmartParam TaskStage;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("任务阶段状态")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:TaskStageStatus")]
	public EStageStatus TaskStageStatus;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("交互信息GroupID")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:InteractionGroupID")]
	public int InteractionGroupID;

	[DisplayName("交互步骤")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:InteractionStep")]
	public int InteractionStep;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("拥有物品ID")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:OwningItemID")]
	public int OwningItemID;

	[DisplayName("拥有物品数量")]
	[UMeta(MDProp.ClampMin, "0")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:OwningNum")]
	public int OwningNum;

	[BlueprintReadWrite]
	[DisplayName("消耗物品ID")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:ConsumeItemID")]
	public int ConsumeItemID;

	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[DisplayName("消耗物品数量")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:ConsumptionQuantity")]
	public int ConsumptionQuantity;

	[DisplayName("目标Actor")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:TargetActor")]
	public FGsActorGuidReference TargetActor;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("SplineActor")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:SplineActor")]
	public FGsActorGuidReference SplineActor;

	[DisplayName("Npc移动类型")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:NpcMoveType")]
	public ENpcMoveType NpcMoveType;

	[EditAnywhere]
	[DisplayName("可接受范围")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:MoveAcceptableRadius")]
	public float MoveAcceptableRadius;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("SkillID")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:SkillID")]
	public int SkillID;

	[UProperty]
	[DisplayName("是否反转条件")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:bReverseCondition")]
	public bool bReverseCondition;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("注释")]
	[USharpPath("/Script/b1-Managed.TransitionCondition_Idle:Comment")]
	public string Comment;

	private static int TransitionCondition_Idle_StructSize;

	private static int TransitionCondition_Idle_IsValid;

	private static bool ConditionType_IsValid;

	private static int ConditionType_Offset;

	private static FFieldAddress ConditionType_PropertyAddress;

	private static bool Overlap_IsValid;

	private static int Overlap_Offset;

	private static bool Interactor_IsValid;

	private static int Interactor_Offset;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool NPCUnit_IsValid;

	private static int NPCUnit_Offset;

	private static bool GameStateCondition_IsValid;

	private static int GameStateCondition_Offset;

	private static FFieldAddress GameStateCondition_PropertyAddress;

	private static bool Timer_InArea_IsValid;

	private static int Timer_InArea_Offset;

	private static bool Timer_OutArea_IsValid;

	private static int Timer_OutArea_Offset;

	private static bool TaskStage_IsValid;

	private static int TaskStage_Offset;

	private static bool TaskStageStatus_IsValid;

	private static int TaskStageStatus_Offset;

	private static FFieldAddress TaskStageStatus_PropertyAddress;

	private static bool InteractionGroupID_IsValid;

	private static int InteractionGroupID_Offset;

	private static bool InteractionStep_IsValid;

	private static int InteractionStep_Offset;

	private static bool OwningItemID_IsValid;

	private static int OwningItemID_Offset;

	private static bool OwningNum_IsValid;

	private static int OwningNum_Offset;

	private static bool ConsumeItemID_IsValid;

	private static int ConsumeItemID_Offset;

	private static bool ConsumptionQuantity_IsValid;

	private static int ConsumptionQuantity_Offset;

	private static bool TargetActor_IsValid;

	private static int TargetActor_Offset;

	private static bool SplineActor_IsValid;

	private static int SplineActor_Offset;

	private static bool NpcMoveType_IsValid;

	private static int NpcMoveType_Offset;

	private static FFieldAddress NpcMoveType_PropertyAddress;

	private static bool MoveAcceptableRadius_IsValid;

	private static int MoveAcceptableRadius_Offset;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public FTransitionCondition_Idle Copy()
	{
		return this;
	}

	public static FTransitionCondition_Idle FromNative(IntPtr nativeBuffer)
	{
		return new FTransitionCondition_Idle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTransitionCondition_Idle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTransitionCondition_Idle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTransitionCondition_Idle(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_Idle_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTransitionCondition_Idle value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TransitionCondition_Idle_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TransitionCondition_Idle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_Idle");
			return;
		}
		EnumMarshaler<ETransitionConditionType_Idle>.ToNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address, ConditionType);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Overlap_Offset), Overlap);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Interactor_Offset), Interactor);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, NPCUnit_Offset), NPCUnit);
		EnumMarshaler<EQueryGameStateCondition>.ToNative(IntPtr.Add(nativeStruct, GameStateCondition_Offset), 0, GameStateCondition_PropertyAddress.Address, GameStateCondition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Timer_InArea_Offset), Timer_InArea);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Timer_OutArea_Offset), Timer_OutArea);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, TaskStage_Offset), TaskStage);
		EnumMarshaler<EStageStatus>.ToNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address, TaskStageStatus);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InteractionGroupID_Offset), InteractionGroupID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InteractionStep_Offset), InteractionStep);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OwningItemID_Offset), OwningItemID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OwningNum_Offset), OwningNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ConsumeItemID_Offset), ConsumeItemID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ConsumptionQuantity_Offset), ConsumptionQuantity);
		FGsActorGuidReference.ToNative(IntPtr.Add(nativeStruct, TargetActor_Offset), TargetActor);
		FGsActorGuidReference.ToNative(IntPtr.Add(nativeStruct, SplineActor_Offset), SplineActor);
		EnumMarshaler<ENpcMoveType>.ToNative(IntPtr.Add(nativeStruct, NpcMoveType_Offset), 0, NpcMoveType_PropertyAddress.Address, NpcMoveType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MoveAcceptableRadius_Offset), MoveAcceptableRadius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillID_Offset), SkillID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, bReverseCondition);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FTransitionCondition_Idle(IntPtr nativeStruct)
	{
		if (TransitionCondition_Idle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TransitionCondition_Idle");
			ConditionType = ETransitionConditionType_Idle.None;
			Overlap = default(FGsSmartParam);
			Interactor = default(FGsSmartParam);
			Unit = default(FGsSmartParam);
			NPCUnit = default(FGsSmartParam);
			GameStateCondition = EQueryGameStateCondition.None;
			Timer_InArea = 0f;
			Timer_OutArea = 0f;
			TaskStage = default(FGsSmartParam);
			TaskStageStatus = EStageStatus.Default;
			InteractionGroupID = 0;
			InteractionStep = 0;
			OwningItemID = 0;
			OwningNum = 0;
			ConsumeItemID = 0;
			ConsumptionQuantity = 0;
			TargetActor = default(FGsActorGuidReference);
			SplineActor = default(FGsActorGuidReference);
			NpcMoveType = ENpcMoveType.Navigation;
			MoveAcceptableRadius = 0f;
			SkillID = 0;
			bReverseCondition = false;
			Comment = null;
		}
		else
		{
			ConditionType = EnumMarshaler<ETransitionConditionType_Idle>.FromNative(IntPtr.Add(nativeStruct, ConditionType_Offset), 0, ConditionType_PropertyAddress.Address);
			Overlap = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Overlap_Offset));
			Interactor = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Interactor_Offset));
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			NPCUnit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, NPCUnit_Offset));
			GameStateCondition = EnumMarshaler<EQueryGameStateCondition>.FromNative(IntPtr.Add(nativeStruct, GameStateCondition_Offset), 0, GameStateCondition_PropertyAddress.Address);
			Timer_InArea = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Timer_InArea_Offset));
			Timer_OutArea = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Timer_OutArea_Offset));
			TaskStage = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, TaskStage_Offset));
			TaskStageStatus = EnumMarshaler<EStageStatus>.FromNative(IntPtr.Add(nativeStruct, TaskStageStatus_Offset), 0, TaskStageStatus_PropertyAddress.Address);
			InteractionGroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InteractionGroupID_Offset));
			InteractionStep = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InteractionStep_Offset));
			OwningItemID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OwningItemID_Offset));
			OwningNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OwningNum_Offset));
			ConsumeItemID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ConsumeItemID_Offset));
			ConsumptionQuantity = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ConsumptionQuantity_Offset));
			TargetActor = FGsActorGuidReference.FromNative(IntPtr.Add(nativeStruct, TargetActor_Offset));
			SplineActor = FGsActorGuidReference.FromNative(IntPtr.Add(nativeStruct, SplineActor_Offset));
			NpcMoveType = EnumMarshaler<ENpcMoveType>.FromNative(IntPtr.Add(nativeStruct, NpcMoveType_Offset), 0, NpcMoveType_PropertyAddress.Address);
			MoveAcceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MoveAcceptableRadius_Offset));
			SkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillID_Offset));
			bReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TransitionCondition_Idle");
		TransitionCondition_Idle_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionType_PropertyAddress, intPtr, "ConditionType");
		ConditionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionType");
		ConditionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionType", Classes.FEnumProperty);
		Overlap_Offset = NativeReflection.GetPropertyOffset(intPtr, "Overlap");
		Overlap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Overlap", Classes.FStructProperty);
		Interactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "Interactor");
		Interactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Interactor", Classes.FStructProperty);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		NPCUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "NPCUnit");
		NPCUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NPCUnit", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GameStateCondition_PropertyAddress, intPtr, "GameStateCondition");
		GameStateCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "GameStateCondition");
		GameStateCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GameStateCondition", Classes.FEnumProperty);
		Timer_InArea_Offset = NativeReflection.GetPropertyOffset(intPtr, "Timer_InArea");
		Timer_InArea_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Timer_InArea", Classes.FFloatProperty);
		Timer_OutArea_Offset = NativeReflection.GetPropertyOffset(intPtr, "Timer_OutArea");
		Timer_OutArea_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Timer_OutArea", Classes.FFloatProperty);
		TaskStage_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStage");
		TaskStage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStage", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref TaskStageStatus_PropertyAddress, intPtr, "TaskStageStatus");
		TaskStageStatus_Offset = NativeReflection.GetPropertyOffset(intPtr, "TaskStageStatus");
		TaskStageStatus_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TaskStageStatus", Classes.FEnumProperty);
		InteractionGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractionGroupID");
		InteractionGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractionGroupID", Classes.FIntProperty);
		InteractionStep_Offset = NativeReflection.GetPropertyOffset(intPtr, "InteractionStep");
		InteractionStep_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InteractionStep", Classes.FIntProperty);
		OwningItemID_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwningItemID");
		OwningItemID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwningItemID", Classes.FIntProperty);
		OwningNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwningNum");
		OwningNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwningNum", Classes.FIntProperty);
		ConsumeItemID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConsumeItemID");
		ConsumeItemID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConsumeItemID", Classes.FIntProperty);
		ConsumptionQuantity_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConsumptionQuantity");
		ConsumptionQuantity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConsumptionQuantity", Classes.FIntProperty);
		TargetActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetActor");
		TargetActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetActor", Classes.FStructProperty);
		SplineActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineActor");
		SplineActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineActor", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref NpcMoveType_PropertyAddress, intPtr, "NpcMoveType");
		NpcMoveType_Offset = NativeReflection.GetPropertyOffset(intPtr, "NpcMoveType");
		NpcMoveType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NpcMoveType", Classes.FEnumProperty);
		MoveAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveAcceptableRadius");
		MoveAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveAcceptableRadius", Classes.FFloatProperty);
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		TransitionCondition_Idle_IsValid = ((intPtr != IntPtr.Zero && ConditionType_IsValid && Overlap_IsValid && Interactor_IsValid && Unit_IsValid && NPCUnit_IsValid && GameStateCondition_IsValid && Timer_InArea_IsValid && Timer_OutArea_IsValid && TaskStage_IsValid && TaskStageStatus_IsValid && InteractionGroupID_IsValid && InteractionStep_IsValid && OwningItemID_IsValid && OwningNum_IsValid && ConsumeItemID_IsValid && ConsumptionQuantity_IsValid && TargetActor_IsValid && SplineActor_IsValid && NpcMoveType_IsValid && MoveAcceptableRadius_IsValid && SkillID_IsValid && bReverseCondition_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TransitionCondition_Idle", (byte)TransitionCondition_Idle_IsValid != 0);
	}

	static FTransitionCondition_Idle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTransitionCondition_Idle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransitionCondition_Idle));
	}
}
