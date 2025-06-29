using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("释放Combo技能")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo")]
internal class BED_BehaviorNode_Combo : b1.BED_BehaviorNode_Action
{
	private static bool ComboTargetType_IsValid;

	private static int ComboTargetType_Offset;

	private static FFieldAddress ComboTargetType_PropertyAddress;

	private static bool SkillSourceType_IsValid;

	private static int SkillSourceType_Offset;

	private static FFieldAddress SkillSourceType_PropertyAddress;

	private static bool PursuitInAllSkill_IsValid;

	private static int PursuitInAllSkill_Offset;

	private static FFieldAddress PursuitInAllSkill_PropertyAddress;

	private static bool PursuitAnyWhere_IsValid;

	private static int PursuitAnyWhere_Offset;

	private static FFieldAddress PursuitAnyWhere_PropertyAddress;

	private static bool ForceCastSkillAfterPursuitFailed_IsValid;

	private static int ForceCastSkillAfterPursuitFailed_Offset;

	private static FFieldAddress ForceCastSkillAfterPursuitFailed_PropertyAddress;

	private static bool PursuitRangePos_IsValid;

	private static int PursuitRangePos_Offset;

	private static bool SpeedRateType_IsValid;

	private static int SpeedRateType_Offset;

	private static FFieldAddress SpeedRateType_PropertyAddress;

	private static bool MotionMatchingMoveMode_IsValid;

	private static int MotionMatchingMoveMode_Offset;

	private static FFieldAddress MotionMatchingMoveMode_PropertyAddress;

	private static bool MoveAIType_IsValid;

	private static int MoveAIType_Offset;

	private static FFieldAddress MoveAIType_PropertyAddress;

	private static bool MoveAcceptableRadiusType_IsValid;

	private static int MoveAcceptableRadiusType_Offset;

	private static FFieldAddress MoveAcceptableRadiusType_PropertyAddress;

	private static bool BeginRotateAngle_IsValid;

	private static int BeginRotateAngle_Offset;

	private static bool IsUseSkillForTurn_IsValid;

	private static int IsUseSkillForTurn_Offset;

	private static FFieldAddress IsUseSkillForTurn_PropertyAddress;

	private static bool IsUseSkillForMove_IsValid;

	private static int IsUseSkillForMove_Offset;

	private static FFieldAddress IsUseSkillForMove_PropertyAddress;

	private static bool BeginMoveDistanceWhenUseSkill_IsValid;

	private static int BeginMoveDistanceWhenUseSkill_Offset;

	private static bool EnableInterruptReduceCBNum_IsValid;

	private static int EnableInterruptReduceCBNum_Offset;

	private static FFieldAddress EnableInterruptReduceCBNum_PropertyAddress;

	private static bool NeedTraceHitTargetBefore_IsValid;

	private static int NeedTraceHitTargetBefore_Offset;

	private static FFieldAddress NeedTraceHitTargetBefore_PropertyAddress;

	private static bool EnableForceComboRelation_IsValid;

	private static int EnableForceComboRelation_Offset;

	private static FFieldAddress EnableForceComboRelation_PropertyAddress;

	private static bool EnableComboCondition_IsValid;

	private static int EnableComboCondition_Offset;

	private static FFieldAddress EnableComboCondition_PropertyAddress;

	private static bool TraceDistance_IsValid;

	private static int TraceDistance_Offset;

	private static bool TraceTypeQuery_IsValid;

	private static int TraceTypeQuery_Offset;

	private static FFieldAddress TraceTypeQuery_PropertyAddress;

	private static bool IsGetTopRandomSkill_IsValid;

	private static int IsGetTopRandomSkill_Offset;

	private static FFieldAddress IsGetTopRandomSkill_PropertyAddress;

	private static bool TopRandomSkillPercent_IsValid;

	private static int TopRandomSkillPercent_Offset;

	private static bool SkillArray_IsValid;

	private static int SkillArray_Offset;

	private static FFieldAddress SkillArray_PropertyAddress;

	private TArrayReadWriteMarshaler<FComboSkill> SkillArray_Marshaler;

	private static bool IsGetAdvanceComboLength_IsValid;

	private static int IsGetAdvanceComboLength_Offset;

	private static FFieldAddress IsGetAdvanceComboLength_PropertyAddress;

	private static bool ComboSkillNumInfo_IsValid;

	private static int ComboSkillNumInfo_Offset;

	private static FFieldAddress ComboSkillNumInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<FComboSkillNumInfo> ComboSkillNumInfo_Marshaler;

	private static bool IsCanBeForceAbort_IsValid;

	private static int IsCanBeForceAbort_Offset;

	private static FFieldAddress IsCanBeForceAbort_PropertyAddress;

	private static bool UseSocketDirection_IsValid;

	private static int UseSocketDirection_Offset;

	private static FFieldAddress UseSocketDirection_PropertyAddress;

	private static bool DirectionBaseSocket_IsValid;

	private static int DirectionBaseSocket_Offset;

	private static bool ForwardSocket_IsValid;

	private static int ForwardSocket_Offset;

	private static bool RightSocket_IsValid;

	private static int RightSocket_Offset;

	private static bool SkillConfigMode_IsValid;

	private static int SkillConfigMode_Offset;

	private static FFieldAddress SkillConfigMode_PropertyAddress;

	private static bool SingleDirectionSkills_IsValid;

	private static int SingleDirectionSkills_Offset;

	private static FFieldAddress SingleDirectionSkills_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SingleDirectionSkills_Marshaler;

	private static bool AvoidObstacleSectionNum_IsValid;

	private static int AvoidObstacleSectionNum_Offset;

	private static bool SectionsStartAngle_IsValid;

	private static int SectionsStartAngle_Offset;

	private static bool IntervalAngle_IsValid;

	private static int IntervalAngle_Offset;

	private static bool AvoidObstacleSections_IsValid;

	private static int AvoidObstacleSections_Offset;

	private static FFieldAddress AvoidObstacleSections_PropertyAddress;

	private TArrayReadWriteMarshaler<FAvoidObstacleSection> AvoidObstacleSections_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Combo期间目标类型")]
	[UProperty]
	[Category("CommSetting")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:ComboTargetType")]
	public EComboTargetType ComboTargetType
	{
		get
		{
			CheckDestroyed();
			if (!ComboTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:ComboTargetType");
				return EComboTargetType.None;
			}
			return EnumMarshaler<EComboTargetType>.FromNative(IntPtr.Add(base.Address, ComboTargetType_Offset), 0, ComboTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComboTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:ComboTargetType");
			}
			else
			{
				EnumMarshaler<EComboTargetType>.ToNative(IntPtr.Add(base.Address, ComboTargetType_Offset), 0, ComboTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("技能来源")]
	[EditAnywhere]
	[Category("CommSetting")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:SkillSourceType")]
	public EZatoichiSkillSourceType SkillSourceType
	{
		get
		{
			CheckDestroyed();
			if (!SkillSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SkillSourceType");
				return EZatoichiSkillSourceType.None;
			}
			return EnumMarshaler<EZatoichiSkillSourceType>.FromNative(IntPtr.Add(base.Address, SkillSourceType_Offset), 0, SkillSourceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkillSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SkillSourceType");
			}
			else
			{
				EnumMarshaler<EZatoichiSkillSourceType>.ToNative(IntPtr.Add(base.Address, SkillSourceType_Offset), 0, SkillSourceType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Pursuit")]
	[DisplayName("是否全部技能前都会追逐")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("不勾选则只有第一次技能释放前才会触发追逐逻辑")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:PursuitInAllSkill")]
	public bool PursuitInAllSkill
	{
		get
		{
			CheckDestroyed();
			if (!PursuitInAllSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:PursuitInAllSkill");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PursuitInAllSkill_Offset), 0, PursuitInAllSkill_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PursuitInAllSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:PursuitInAllSkill");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PursuitInAllSkill_Offset), 0, PursuitInAllSkill_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("寻路中断后是否仍然追逐")]
	[Tooltip("主要是处理由于导航网格缺失带来的追逐异常")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:PursuitAnyWhere")]
	public bool PursuitAnyWhere
	{
		get
		{
			CheckDestroyed();
			if (!PursuitAnyWhere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:PursuitAnyWhere");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PursuitAnyWhere_Offset), 0, PursuitAnyWhere_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PursuitAnyWhere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:PursuitAnyWhere");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PursuitAnyWhere_Offset), 0, PursuitAnyWhere_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("追逐失效后是否强行释放技能")]
	[Tooltip("主要是处理配置技能转身和技能位移后触发失效，导致长时间卡死AI的问题")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:ForceCastSkillAfterPursuitFailed")]
	public bool ForceCastSkillAfterPursuitFailed
	{
		get
		{
			CheckDestroyed();
			if (!ForceCastSkillAfterPursuitFailed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:ForceCastSkillAfterPursuitFailed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceCastSkillAfterPursuitFailed_Offset), 0, ForceCastSkillAfterPursuitFailed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceCastSkillAfterPursuitFailed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:ForceCastSkillAfterPursuitFailed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceCastSkillAfterPursuitFailed_Offset), 0, ForceCastSkillAfterPursuitFailed_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("追逐距离计算偏向")]
	[Tooltip("0.5就是选择追逐到技能释放距离区域的中部")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "1")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:PursuitRangePos")]
	public float PursuitRangePos
	{
		get
		{
			CheckDestroyed();
			if (!PursuitRangePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:PursuitRangePos");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PursuitRangePos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PursuitRangePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:PursuitRangePos");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PursuitRangePos_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("追逐移动速率")]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SpeedRateType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("追逐移动MotionMatching模式")]
	[Category("Pursuit")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:MotionMatchingMoveMode")]
	public EState_MM MotionMatchingMoveMode
	{
		get
		{
			CheckDestroyed();
			if (!MotionMatchingMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:MotionMatchingMoveMode");
				return EState_MM.None;
			}
			return EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(base.Address, MotionMatchingMoveMode_Offset), 0, MotionMatchingMoveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MotionMatchingMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:MotionMatchingMoveMode");
			}
			else
			{
				EnumMarshaler<EState_MM>.ToNative(IntPtr.Add(base.Address, MotionMatchingMoveMode_Offset), 0, MotionMatchingMoveMode_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[UProperty]
	[DisplayName("追逐移动朝向模式")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:MoveAIType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[UProperty]
	[DisplayName("追逐移动抵达半径包括类型")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:MoveAcceptableRadiusType")]
	public EBGUMoveAcceptableRadiusType MoveAcceptableRadiusType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAcceptableRadiusType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:MoveAcceptableRadiusType");
				return EBGUMoveAcceptableRadiusType.NoInclude;
			}
			return EnumMarshaler<EBGUMoveAcceptableRadiusType>.FromNative(IntPtr.Add(base.Address, MoveAcceptableRadiusType_Offset), 0, MoveAcceptableRadiusType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAcceptableRadiusType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:MoveAcceptableRadiusType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAcceptableRadiusType>.ToNative(IntPtr.Add(base.Address, MoveAcceptableRadiusType_Offset), 0, MoveAcceptableRadiusType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("追逐前开始旋转角度")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[Category("Pursuit")]
	[UMeta(MDProp.ClampMax, "180")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:BeginRotateAngle")]
	public float BeginRotateAngle
	{
		get
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:BeginRotateAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:BeginRotateAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("是否使用技能旋转")]
	[Tooltip("对应旋转技能在表格里填写")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:IsUseSkillForTurn")]
	public bool IsUseSkillForTurn
	{
		get
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsUseSkillForTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsUseSkillForTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("是否使用技能位移")]
	[Tooltip("对应位移技能在表格里填写")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:IsUseSkillForMove")]
	public bool IsUseSkillForMove
	{
		get
		{
			CheckDestroyed();
			if (!IsUseSkillForMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsUseSkillForMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseSkillForMove_Offset), 0, IsUseSkillForMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseSkillForMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsUseSkillForMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseSkillForMove_Offset), 0, IsUseSkillForMove_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "IsUseSkillForMove")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("追逐前位移距离")]
	[Tooltip("只有使用技能位移才生效，如果距离小于这个值不释放技能")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:BeginMoveDistanceWhenUseSkill")]
	public float BeginMoveDistanceWhenUseSkill
	{
		get
		{
			CheckDestroyed();
			if (!BeginMoveDistanceWhenUseSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:BeginMoveDistanceWhenUseSkill");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginMoveDistanceWhenUseSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginMoveDistanceWhenUseSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:BeginMoveDistanceWhenUseSkill");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginMoveDistanceWhenUseSkill_Offset), value);
			}
		}
	}

	[DisplayName("技能释放失败后，退出Combo节点节点时是否减少连招套数")]
	[EditAnywhere]
	[UProperty]
	[Category("Skill")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:EnableInterruptReduceCBNum")]
	public bool EnableInterruptReduceCBNum
	{
		get
		{
			CheckDestroyed();
			if (!EnableInterruptReduceCBNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:EnableInterruptReduceCBNum");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableInterruptReduceCBNum_Offset), 0, EnableInterruptReduceCBNum_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableInterruptReduceCBNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:EnableInterruptReduceCBNum");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableInterruptReduceCBNum_Offset), 0, EnableInterruptReduceCBNum_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否需要射线检测")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:NeedTraceHitTargetBefore")]
	public bool NeedTraceHitTargetBefore
	{
		get
		{
			CheckDestroyed();
			if (!NeedTraceHitTargetBefore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:NeedTraceHitTargetBefore");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedTraceHitTargetBefore_Offset), 0, NeedTraceHitTargetBefore_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedTraceHitTargetBefore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:NeedTraceHitTargetBefore");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedTraceHitTargetBefore_Offset), 0, NeedTraceHitTargetBefore_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("是否开启强制连招关系")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:EnableForceComboRelation")]
	public bool EnableForceComboRelation
	{
		get
		{
			CheckDestroyed();
			if (!EnableForceComboRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:EnableForceComboRelation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableForceComboRelation_Offset), 0, EnableForceComboRelation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableForceComboRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:EnableForceComboRelation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableForceComboRelation_Offset), 0, EnableForceComboRelation_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否屏蔽连招内放过技能")]
	[BlueprintReadWrite]
	[Category("Skill")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:EnableComboCondition")]
	public bool EnableComboCondition
	{
		get
		{
			CheckDestroyed();
			if (!EnableComboCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:EnableComboCondition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableComboCondition_Offset), 0, EnableComboCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableComboCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:EnableComboCondition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableComboCondition_Offset), 0, EnableComboCondition_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("射线检测距离")]
	[UMeta(MDProp.EditCondition, "NeedTraceHitTargetBefore")]
	[EditAnywhere]
	[Category("Skill")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:TraceDistance")]
	public float TraceDistance
	{
		get
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:TraceDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:TraceDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceDistance_Offset), value);
			}
		}
	}

	[DisplayName("射线检测通道")]
	[Category("Skill")]
	[UMeta(MDProp.EditCondition, "NeedTraceHitTargetBefore")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:TraceTypeQuery")]
	public ETraceTypeQuery TraceTypeQuery
	{
		get
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:TraceTypeQuery");
				return ETraceTypeQuery.TraceTypeQuery1;
			}
			return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:TraceTypeQuery");
			}
			else
			{
				EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否随机获取算分顶部技能")]
	[Category("Skill")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:IsGetTopRandomSkill")]
	public bool IsGetTopRandomSkill
	{
		get
		{
			CheckDestroyed();
			if (!IsGetTopRandomSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsGetTopRandomSkill");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsGetTopRandomSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsGetTopRandomSkill");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Skill")]
	[DisplayName("算分顶部随机选取技能万分比")]
	[UMeta(MDProp.ClampMin, "0")]
	[EditAnywhere]
	[UMeta(MDProp.ClampMax, "10000")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:TopRandomSkillPercent")]
	public int TopRandomSkillPercent
	{
		get
		{
			CheckDestroyed();
			if (!TopRandomSkillPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:TopRandomSkillPercent");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TopRandomSkillPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TopRandomSkillPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:TopRandomSkillPercent");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TopRandomSkillPercent_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("Skill")]
	[DisplayName("连招技能池")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:SkillArray")]
	public TArrayReadWrite<FComboSkill> SkillArray
	{
		get
		{
			CheckDestroyed();
			if (!SkillArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SkillArray");
				return null;
			}
			if (SkillArray_Marshaler == null)
			{
				SkillArray_Marshaler = new TArrayReadWriteMarshaler<FComboSkill>(1, SkillArray_PropertyAddress, CachedMarshalingDelegates<FComboSkill, FComboSkill>.FromNative, CachedMarshalingDelegates<FComboSkill, FComboSkill>.ToNative);
			}
			return SkillArray_Marshaler.FromNative(IntPtr.Add(base.Address, SkillArray_Offset));
		}
	}

	[UProperty]
	[DisplayName("是否获取提前算好的随机连招长度")]
	[Category("Skill")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:IsGetAdvanceComboLength")]
	public bool IsGetAdvanceComboLength
	{
		get
		{
			CheckDestroyed();
			if (!IsGetAdvanceComboLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsGetAdvanceComboLength");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsGetAdvanceComboLength_Offset), 0, IsGetAdvanceComboLength_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsGetAdvanceComboLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsGetAdvanceComboLength");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsGetAdvanceComboLength_Offset), 0, IsGetAdvanceComboLength_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("连招长度信息")]
	[Category("Skill")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:ComboSkillNumInfo")]
	public TArrayReadWrite<FComboSkillNumInfo> ComboSkillNumInfo
	{
		get
		{
			CheckDestroyed();
			if (!ComboSkillNumInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:ComboSkillNumInfo");
				return null;
			}
			if (ComboSkillNumInfo_Marshaler == null)
			{
				ComboSkillNumInfo_Marshaler = new TArrayReadWriteMarshaler<FComboSkillNumInfo>(1, ComboSkillNumInfo_PropertyAddress, CachedMarshalingDelegates<FComboSkillNumInfo, BlittableTypeMarshaler<FComboSkillNumInfo>>.FromNative, CachedMarshalingDelegates<FComboSkillNumInfo, BlittableTypeMarshaler<FComboSkillNumInfo>>.ToNative);
			}
			return ComboSkillNumInfo_Marshaler.FromNative(IntPtr.Add(base.Address, ComboSkillNumInfo_Offset));
		}
	}

	[DisplayName("技能是否可以被强制打断")]
	[Category("Skill")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:IsCanBeForceAbort")]
	public bool IsCanBeForceAbort
	{
		get
		{
			CheckDestroyed();
			if (!IsCanBeForceAbort_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsCanBeForceAbort");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCanBeForceAbort_Offset), 0, IsCanBeForceAbort_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCanBeForceAbort_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IsCanBeForceAbort");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCanBeForceAbort_Offset), 0, IsCanBeForceAbort_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Skill")]
	[DisplayName("是否使用Socket替代角色朝向")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:UseSocketDirection")]
	public bool UseSocketDirection
	{
		get
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:UseSocketDirection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:UseSocketDirection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[DisplayName("朝向基准Socket")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:DirectionBaseSocket")]
	public FName DirectionBaseSocket
	{
		get
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:DirectionBaseSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:DirectionBaseSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[DisplayName("前向Socket")]
	[Category("Skill")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:ForwardSocket")]
	public FName ForwardSocket
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:ForwardSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ForwardSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:ForwardSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ForwardSocket_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[DisplayName("右向Socket")]
	[Category("Skill")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:RightSocket")]
	public FName RightSocket
	{
		get
		{
			CheckDestroyed();
			if (!RightSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:RightSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RightSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:RightSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RightSocket_Offset), value);
			}
		}
	}

	[Category("AvoidObstacle")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:SkillConfigMode")]
	public EEscapeSkillConfigMode SkillConfigMode
	{
		get
		{
			CheckDestroyed();
			if (!SkillConfigMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SkillConfigMode");
				return EEscapeSkillConfigMode.None;
			}
			return EnumMarshaler<EEscapeSkillConfigMode>.FromNative(IntPtr.Add(base.Address, SkillConfigMode_Offset), 0, SkillConfigMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkillConfigMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SkillConfigMode");
			}
			else
			{
				EnumMarshaler<EEscapeSkillConfigMode>.ToNative(IntPtr.Add(base.Address, SkillConfigMode_Offset), 0, SkillConfigMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AvoidObstacle")]
	[DisplayName("单方向技能列表")]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Single")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:SingleDirectionSkills")]
	public TArrayReadWrite<int> SingleDirectionSkills
	{
		get
		{
			CheckDestroyed();
			if (!SingleDirectionSkills_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SingleDirectionSkills");
				return null;
			}
			if (SingleDirectionSkills_Marshaler == null)
			{
				SingleDirectionSkills_Marshaler = new TArrayReadWriteMarshaler<int>(1, SingleDirectionSkills_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SingleDirectionSkills_Marshaler.FromNative(IntPtr.Add(base.Address, SingleDirectionSkills_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("AvoidObstacle")]
	[DisplayName("脱困技能扇区数")]
	[UMeta(MDProp.ClampMax, 8)]
	[UMeta(MDProp.ClampMin, 1)]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:AvoidObstacleSectionNum")]
	public int AvoidObstacleSectionNum
	{
		get
		{
			CheckDestroyed();
			if (!AvoidObstacleSectionNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:AvoidObstacleSectionNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AvoidObstacleSectionNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AvoidObstacleSectionNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:AvoidObstacleSectionNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AvoidObstacleSectionNum_Offset), value);
			}
		}
	}

	[Category("AvoidObstacle")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("起始扇区角度")]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:SectionsStartAngle")]
	public float SectionsStartAngle
	{
		get
		{
			CheckDestroyed();
			if (!SectionsStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SectionsStartAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SectionsStartAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectionsStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:SectionsStartAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SectionsStartAngle_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("AvoidObstacle")]
	[DisplayName("每个扇区的角度大小")]
	[UProperty]
	[VisibleAnywhere]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:IntervalAngle")]
	public float IntervalAngle
	{
		get
		{
			CheckDestroyed();
			if (!IntervalAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IntervalAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IntervalAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntervalAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:IntervalAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IntervalAngle_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[VisibleAnywhere]
	[Category("AvoidObstacle")]
	[DisplayName("扇区脱困技能")]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Combo:AvoidObstacleSections")]
	public TArrayReadWrite<FAvoidObstacleSection> AvoidObstacleSections
	{
		get
		{
			CheckDestroyed();
			if (!AvoidObstacleSections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Combo:AvoidObstacleSections");
				return null;
			}
			if (AvoidObstacleSections_Marshaler == null)
			{
				AvoidObstacleSections_Marshaler = new TArrayReadWriteMarshaler<FAvoidObstacleSection>(1, AvoidObstacleSections_PropertyAddress, CachedMarshalingDelegates<FAvoidObstacleSection, FAvoidObstacleSection>.FromNative, CachedMarshalingDelegates<FAvoidObstacleSection, FAvoidObstacleSection>.ToNative);
			}
			return AvoidObstacleSections_Marshaler.FromNative(IntPtr.Add(base.Address, AvoidObstacleSections_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.Combo;
	}

	public override byte[] GetCustomData()
	{
		BehaviorCustom_Combo behaviorCustom_Combo = new BehaviorCustom_Combo();
		behaviorCustom_Combo.ComboTargetType = (int)ComboTargetType;
		behaviorCustom_Combo.SkillSourceType = (int)SkillSourceType;
		behaviorCustom_Combo.PursuitInAllSkill = PursuitInAllSkill;
		behaviorCustom_Combo.PursuitAnyWhere = PursuitAnyWhere;
		behaviorCustom_Combo.ForceCastSkillAfterPursuitFailed = ForceCastSkillAfterPursuitFailed;
		behaviorCustom_Combo.PursuitRangePos = PursuitRangePos;
		behaviorCustom_Combo.SpeedRateType = (int)SpeedRateType;
		behaviorCustom_Combo.MotionMatchingMoveMode = (int)MotionMatchingMoveMode;
		behaviorCustom_Combo.MoveAIType = (int)MoveAIType;
		behaviorCustom_Combo.MoveAcceptableRadiusType = (int)MoveAcceptableRadiusType;
		behaviorCustom_Combo.BeginRotateAngle = BeginRotateAngle;
		behaviorCustom_Combo.IsUseSkillForTurn = IsUseSkillForTurn;
		behaviorCustom_Combo.IsUseSkillForMove = IsUseSkillForMove;
		behaviorCustom_Combo.BeginMoveDistanceWhenUseSkill = BeginMoveDistanceWhenUseSkill;
		behaviorCustom_Combo.EnableInterruptReduceCBNum = EnableInterruptReduceCBNum;
		behaviorCustom_Combo.NeedTraceHitTargetBefore = NeedTraceHitTargetBefore;
		behaviorCustom_Combo.EnableForceComboRelation = EnableForceComboRelation;
		behaviorCustom_Combo.EnableComboCondition = EnableComboCondition;
		behaviorCustom_Combo.TraceDistance = TraceDistance;
		behaviorCustom_Combo.TraceTypeQuery = (int)TraceTypeQuery;
		behaviorCustom_Combo.IsGetTopRandomSkill = IsGetTopRandomSkill;
		behaviorCustom_Combo.TopRandomSkillPercent = TopRandomSkillPercent;
		foreach (FComboSkill item2 in SkillArray)
		{
			BehaviorCustom_ComboSkill behaviorCustom_ComboSkill = new BehaviorCustom_ComboSkill();
			behaviorCustom_ComboSkill.SkillId.Add(item2.SkillID);
			behaviorCustom_Combo.SkillArray.Add(behaviorCustom_ComboSkill);
		}
		behaviorCustom_Combo.IsGetAdvanceComboLength = IsGetAdvanceComboLength;
		foreach (FComboSkillNumInfo item3 in ComboSkillNumInfo)
		{
			BehaviorCustom_ComboSkillNumInfo item = new BehaviorCustom_ComboSkillNumInfo
			{
				ComboNum = item3.ComboNum,
				ComboPercentRatio = item3.ComboPercenRatio
			};
			behaviorCustom_Combo.ComboSkillNumInfo.Add(item);
		}
		behaviorCustom_Combo.IsCanBeForceAbort = IsCanBeForceAbort;
		behaviorCustom_Combo.UseSocketDirection = UseSocketDirection;
		behaviorCustom_Combo.DirectionBaseSocket = DirectionBaseSocket.ToString();
		behaviorCustom_Combo.ForwardSocket = ForwardSocket.ToString();
		behaviorCustom_Combo.RightSocket = RightSocket.ToString();
		behaviorCustom_Combo.SkillConfigMode = (int)SkillConfigMode;
		foreach (int singleDirectionSkill in SingleDirectionSkills)
		{
			behaviorCustom_Combo.SingleDirectionSkills.Add(singleDirectionSkill);
		}
		behaviorCustom_Combo.AvoidObstacleSectionNum = AvoidObstacleSectionNum;
		behaviorCustom_Combo.SectionsStartAngle = SectionsStartAngle;
		behaviorCustom_Combo.IntervalAngle = IntervalAngle;
		foreach (FAvoidObstacleSection avoidObstacleSection in AvoidObstacleSections)
		{
			BehaviorCustom_AvoidObstacleSection behaviorCustom_AvoidObstacleSection = new BehaviorCustom_AvoidObstacleSection
			{
				StartAngle = avoidObstacleSection.StartAngle,
				EndAngle = avoidObstacleSection.EndAngle
			};
			behaviorCustom_AvoidObstacleSection.SkillList.Add(avoidObstacleSection.SkillList);
			behaviorCustom_Combo.AvoidObstacleSections.Add(behaviorCustom_AvoidObstacleSection);
		}
		return behaviorCustom_Combo.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_Combo");
		NativeReflection.GetPropertyRef(ref ComboTargetType_PropertyAddress, unrealStruct, "ComboTargetType");
		ComboTargetType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ComboTargetType");
		ComboTargetType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ComboTargetType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SkillSourceType_PropertyAddress, unrealStruct, "SkillSourceType");
		SkillSourceType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillSourceType");
		SkillSourceType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillSourceType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PursuitInAllSkill_PropertyAddress, unrealStruct, "PursuitInAllSkill");
		PursuitInAllSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PursuitInAllSkill");
		PursuitInAllSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PursuitInAllSkill", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PursuitAnyWhere_PropertyAddress, unrealStruct, "PursuitAnyWhere");
		PursuitAnyWhere_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PursuitAnyWhere");
		PursuitAnyWhere_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PursuitAnyWhere", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ForceCastSkillAfterPursuitFailed_PropertyAddress, unrealStruct, "ForceCastSkillAfterPursuitFailed");
		ForceCastSkillAfterPursuitFailed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceCastSkillAfterPursuitFailed");
		ForceCastSkillAfterPursuitFailed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceCastSkillAfterPursuitFailed", Classes.FBoolProperty);
		PursuitRangePos_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PursuitRangePos");
		PursuitRangePos_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PursuitRangePos", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SpeedRateType_PropertyAddress, unrealStruct, "SpeedRateType");
		SpeedRateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedRateType");
		SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedRateType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MotionMatchingMoveMode_PropertyAddress, unrealStruct, "MotionMatchingMoveMode");
		MotionMatchingMoveMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MotionMatchingMoveMode");
		MotionMatchingMoveMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MotionMatchingMoveMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, unrealStruct, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveAcceptableRadiusType_PropertyAddress, unrealStruct, "MoveAcceptableRadiusType");
		MoveAcceptableRadiusType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveAcceptableRadiusType");
		MoveAcceptableRadiusType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveAcceptableRadiusType", Classes.FEnumProperty);
		BeginRotateAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginRotateAngle");
		BeginRotateAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginRotateAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsUseSkillForTurn_PropertyAddress, unrealStruct, "IsUseSkillForTurn");
		IsUseSkillForTurn_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsUseSkillForTurn");
		IsUseSkillForTurn_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsUseSkillForTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsUseSkillForMove_PropertyAddress, unrealStruct, "IsUseSkillForMove");
		IsUseSkillForMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsUseSkillForMove");
		IsUseSkillForMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsUseSkillForMove", Classes.FBoolProperty);
		BeginMoveDistanceWhenUseSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginMoveDistanceWhenUseSkill");
		BeginMoveDistanceWhenUseSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginMoveDistanceWhenUseSkill", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableInterruptReduceCBNum_PropertyAddress, unrealStruct, "EnableInterruptReduceCBNum");
		EnableInterruptReduceCBNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableInterruptReduceCBNum");
		EnableInterruptReduceCBNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableInterruptReduceCBNum", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedTraceHitTargetBefore_PropertyAddress, unrealStruct, "NeedTraceHitTargetBefore");
		NeedTraceHitTargetBefore_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedTraceHitTargetBefore");
		NeedTraceHitTargetBefore_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedTraceHitTargetBefore", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableForceComboRelation_PropertyAddress, unrealStruct, "EnableForceComboRelation");
		EnableForceComboRelation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableForceComboRelation");
		EnableForceComboRelation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableForceComboRelation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableComboCondition_PropertyAddress, unrealStruct, "EnableComboCondition");
		EnableComboCondition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableComboCondition");
		EnableComboCondition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableComboCondition", Classes.FBoolProperty);
		TraceDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TraceDistance");
		TraceDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TraceDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TraceTypeQuery_PropertyAddress, unrealStruct, "TraceTypeQuery");
		TraceTypeQuery_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TraceTypeQuery");
		TraceTypeQuery_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TraceTypeQuery", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsGetTopRandomSkill_PropertyAddress, unrealStruct, "IsGetTopRandomSkill");
		IsGetTopRandomSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsGetTopRandomSkill");
		IsGetTopRandomSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsGetTopRandomSkill", Classes.FBoolProperty);
		TopRandomSkillPercent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TopRandomSkillPercent");
		TopRandomSkillPercent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TopRandomSkillPercent", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SkillArray_PropertyAddress, unrealStruct, "SkillArray");
		SkillArray_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillArray");
		SkillArray_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillArray", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IsGetAdvanceComboLength_PropertyAddress, unrealStruct, "IsGetAdvanceComboLength");
		IsGetAdvanceComboLength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsGetAdvanceComboLength");
		IsGetAdvanceComboLength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsGetAdvanceComboLength", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ComboSkillNumInfo_PropertyAddress, unrealStruct, "ComboSkillNumInfo");
		ComboSkillNumInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ComboSkillNumInfo");
		ComboSkillNumInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ComboSkillNumInfo", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IsCanBeForceAbort_PropertyAddress, unrealStruct, "IsCanBeForceAbort");
		IsCanBeForceAbort_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsCanBeForceAbort");
		IsCanBeForceAbort_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsCanBeForceAbort", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseSocketDirection_PropertyAddress, unrealStruct, "UseSocketDirection");
		UseSocketDirection_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseSocketDirection");
		UseSocketDirection_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseSocketDirection", Classes.FBoolProperty);
		DirectionBaseSocket_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionBaseSocket");
		DirectionBaseSocket_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionBaseSocket", Classes.FNameProperty);
		ForwardSocket_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForwardSocket");
		ForwardSocket_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForwardSocket", Classes.FNameProperty);
		RightSocket_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RightSocket");
		RightSocket_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RightSocket", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SkillConfigMode_PropertyAddress, unrealStruct, "SkillConfigMode");
		SkillConfigMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillConfigMode");
		SkillConfigMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillConfigMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SingleDirectionSkills_PropertyAddress, unrealStruct, "SingleDirectionSkills");
		SingleDirectionSkills_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SingleDirectionSkills");
		SingleDirectionSkills_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SingleDirectionSkills", Classes.FArrayProperty);
		AvoidObstacleSectionNum_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AvoidObstacleSectionNum");
		AvoidObstacleSectionNum_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AvoidObstacleSectionNum", Classes.FIntProperty);
		SectionsStartAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SectionsStartAngle");
		SectionsStartAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SectionsStartAngle", Classes.FFloatProperty);
		IntervalAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IntervalAngle");
		IntervalAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IntervalAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AvoidObstacleSections_PropertyAddress, unrealStruct, "AvoidObstacleSections");
		AvoidObstacleSections_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AvoidObstacleSections");
		AvoidObstacleSections_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AvoidObstacleSections", Classes.FArrayProperty);
	}

	static BED_BehaviorNode_Combo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_Combo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_Combo));
	}
}
