using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig")]
public class BGWDataAsset_AutoTestComboConfig : UBGWDataAsset
{
	private static bool SkillSourceType_IsValid;

	private static int SkillSourceType_Offset;

	private static FFieldAddress SkillSourceType_PropertyAddress;

	private static bool PursuitAnyWhere_IsValid;

	private static int PursuitAnyWhere_Offset;

	private static FFieldAddress PursuitAnyWhere_PropertyAddress;

	private static bool PursuitInAllSkill_IsValid;

	private static int PursuitInAllSkill_Offset;

	private static FFieldAddress PursuitInAllSkill_PropertyAddress;

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

	private static bool bCanBeForceAbort_IsValid;

	private static int bCanBeForceAbort_Offset;

	private static FFieldAddress bCanBeForceAbort_PropertyAddress;

	private static bool bCanBeInterruptedByHRCounterattack_IsValid;

	private static int bCanBeInterruptedByHRCounterattack_Offset;

	private static FFieldAddress bCanBeInterruptedByHRCounterattack_PropertyAddress;

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

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("技能来源")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SkillSourceType")]
	public EZatoichiSkillSourceType SkillSourceType
	{
		get
		{
			CheckDestroyed();
			if (!SkillSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SkillSourceType");
				return EZatoichiSkillSourceType.None;
			}
			return EnumMarshaler<EZatoichiSkillSourceType>.FromNative(IntPtr.Add(base.Address, SkillSourceType_Offset), 0, SkillSourceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkillSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SkillSourceType");
			}
			else
			{
				EnumMarshaler<EZatoichiSkillSourceType>.ToNative(IntPtr.Add(base.Address, SkillSourceType_Offset), 0, SkillSourceType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("寻路中断后是否任然追逐")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:PursuitAnyWhere")]
	public bool PursuitAnyWhere
	{
		get
		{
			CheckDestroyed();
			if (!PursuitAnyWhere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:PursuitAnyWhere");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PursuitAnyWhere_Offset), 0, PursuitAnyWhere_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PursuitAnyWhere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:PursuitAnyWhere");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PursuitAnyWhere_Offset), 0, PursuitAnyWhere_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否全部技能前都会追逐")]
	[Category("Pursuit")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:PursuitInAllSkill")]
	public bool PursuitInAllSkill
	{
		get
		{
			CheckDestroyed();
			if (!PursuitInAllSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:PursuitInAllSkill");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PursuitInAllSkill_Offset), 0, PursuitInAllSkill_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PursuitInAllSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:PursuitInAllSkill");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PursuitInAllSkill_Offset), 0, PursuitInAllSkill_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("追逐距离计算偏向")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "1")]
	[Tooltip("0.5就是选择追逐到技能释放距离区域的中部")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:PursuitRangePos")]
	public float PursuitRangePos
	{
		get
		{
			CheckDestroyed();
			if (!PursuitRangePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:PursuitRangePos");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PursuitRangePos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PursuitRangePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:PursuitRangePos");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PursuitRangePos_Offset), value);
			}
		}
	}

	[DisplayName("追逐移动速率")]
	[UProperty]
	[Category("Pursuit")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SpeedRateType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("追逐移动MotionMatching模式")]
	[Category("Pursuit")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:MotionMatchingMoveMode")]
	public EState_MM MotionMatchingMoveMode
	{
		get
		{
			CheckDestroyed();
			if (!MotionMatchingMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:MotionMatchingMoveMode");
				return EState_MM.None;
			}
			return EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(base.Address, MotionMatchingMoveMode_Offset), 0, MotionMatchingMoveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MotionMatchingMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:MotionMatchingMoveMode");
			}
			else
			{
				EnumMarshaler<EState_MM>.ToNative(IntPtr.Add(base.Address, MotionMatchingMoveMode_Offset), 0, MotionMatchingMoveMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Pursuit")]
	[DisplayName("追逐移动朝向模式")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:MoveAIType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("追逐移动抵达半径包括类型")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:MoveAcceptableRadiusType")]
	public EBGUMoveAcceptableRadiusType MoveAcceptableRadiusType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAcceptableRadiusType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:MoveAcceptableRadiusType");
				return EBGUMoveAcceptableRadiusType.NoInclude;
			}
			return EnumMarshaler<EBGUMoveAcceptableRadiusType>.FromNative(IntPtr.Add(base.Address, MoveAcceptableRadiusType_Offset), 0, MoveAcceptableRadiusType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAcceptableRadiusType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:MoveAcceptableRadiusType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAcceptableRadiusType>.ToNative(IntPtr.Add(base.Address, MoveAcceptableRadiusType_Offset), 0, MoveAcceptableRadiusType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("追逐前开始旋转角度")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "180")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:BeginRotateAngle")]
	public float BeginRotateAngle
	{
		get
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:BeginRotateAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:BeginRotateAngle");
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
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsUseSkillForTurn")]
	public bool IsUseSkillForTurn
	{
		get
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsUseSkillForTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsUseSkillForTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("是否使用技能位移")]
	[Tooltip("对应位移技能在表格里填写")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsUseSkillForMove")]
	public bool IsUseSkillForMove
	{
		get
		{
			CheckDestroyed();
			if (!IsUseSkillForMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsUseSkillForMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseSkillForMove_Offset), 0, IsUseSkillForMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseSkillForMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsUseSkillForMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseSkillForMove_Offset), 0, IsUseSkillForMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("追逐前位移距离")]
	[Tooltip("只有使用技能位移才生效，如果距离小于这个值不释放技能")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "IsUseSkillForMove")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:BeginMoveDistanceWhenUseSkill")]
	public float BeginMoveDistanceWhenUseSkill
	{
		get
		{
			CheckDestroyed();
			if (!BeginMoveDistanceWhenUseSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:BeginMoveDistanceWhenUseSkill");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginMoveDistanceWhenUseSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginMoveDistanceWhenUseSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:BeginMoveDistanceWhenUseSkill");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginMoveDistanceWhenUseSkill_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("技能释放失败后，退出Combo节点节点时是否减少连招套数")]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:EnableInterruptReduceCBNum")]
	public bool EnableInterruptReduceCBNum
	{
		get
		{
			CheckDestroyed();
			if (!EnableInterruptReduceCBNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:EnableInterruptReduceCBNum");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableInterruptReduceCBNum_Offset), 0, EnableInterruptReduceCBNum_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableInterruptReduceCBNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:EnableInterruptReduceCBNum");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableInterruptReduceCBNum_Offset), 0, EnableInterruptReduceCBNum_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("是否需要射线检测")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:NeedTraceHitTargetBefore")]
	public bool NeedTraceHitTargetBefore
	{
		get
		{
			CheckDestroyed();
			if (!NeedTraceHitTargetBefore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:NeedTraceHitTargetBefore");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedTraceHitTargetBefore_Offset), 0, NeedTraceHitTargetBefore_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedTraceHitTargetBefore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:NeedTraceHitTargetBefore");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedTraceHitTargetBefore_Offset), 0, NeedTraceHitTargetBefore_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否开启强制连招关系")]
	[Category("Skill")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:EnableForceComboRelation")]
	public bool EnableForceComboRelation
	{
		get
		{
			CheckDestroyed();
			if (!EnableForceComboRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:EnableForceComboRelation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableForceComboRelation_Offset), 0, EnableForceComboRelation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableForceComboRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:EnableForceComboRelation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableForceComboRelation_Offset), 0, EnableForceComboRelation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("是否屏蔽连招内放过技能")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:EnableComboCondition")]
	public bool EnableComboCondition
	{
		get
		{
			CheckDestroyed();
			if (!EnableComboCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:EnableComboCondition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableComboCondition_Offset), 0, EnableComboCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableComboCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:EnableComboCondition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableComboCondition_Offset), 0, EnableComboCondition_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Skill")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("射线检测距离")]
	[UMeta(MDProp.EditCondition, "NeedTraceHitTargetBefore")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:TraceDistance")]
	public float TraceDistance
	{
		get
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:TraceDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:TraceDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("射线检测通道")]
	[UMeta(MDProp.EditCondition, "NeedTraceHitTargetBefore")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:TraceTypeQuery")]
	public ETraceTypeQuery TraceTypeQuery
	{
		get
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:TraceTypeQuery");
				return ETraceTypeQuery.TraceTypeQuery1;
			}
			return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:TraceTypeQuery");
			}
			else
			{
				EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否随机获取算分顶部技能")]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsGetTopRandomSkill")]
	public bool IsGetTopRandomSkill
	{
		get
		{
			CheckDestroyed();
			if (!IsGetTopRandomSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsGetTopRandomSkill");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsGetTopRandomSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsGetTopRandomSkill");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Skill")]
	[DisplayName("算分顶部随机选取技能万分比")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "10000")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:TopRandomSkillPercent")]
	public int TopRandomSkillPercent
	{
		get
		{
			CheckDestroyed();
			if (!TopRandomSkillPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:TopRandomSkillPercent");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TopRandomSkillPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TopRandomSkillPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:TopRandomSkillPercent");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TopRandomSkillPercent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("连招技能池")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SkillArray")]
	public TArrayReadWrite<FComboSkill> SkillArray
	{
		get
		{
			CheckDestroyed();
			if (!SkillArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SkillArray");
				return null;
			}
			if (SkillArray_Marshaler == null)
			{
				SkillArray_Marshaler = new TArrayReadWriteMarshaler<FComboSkill>(1, SkillArray_PropertyAddress, CachedMarshalingDelegates<FComboSkill, FComboSkill>.FromNative, CachedMarshalingDelegates<FComboSkill, FComboSkill>.ToNative);
			}
			return SkillArray_Marshaler.FromNative(IntPtr.Add(base.Address, SkillArray_Offset));
		}
	}

	[Category("Skill")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否获取提前算好的随机连招长度")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsGetAdvanceComboLength")]
	public bool IsGetAdvanceComboLength
	{
		get
		{
			CheckDestroyed();
			if (!IsGetAdvanceComboLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsGetAdvanceComboLength");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsGetAdvanceComboLength_Offset), 0, IsGetAdvanceComboLength_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsGetAdvanceComboLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IsGetAdvanceComboLength");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsGetAdvanceComboLength_Offset), 0, IsGetAdvanceComboLength_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("连招长度信息")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:ComboSkillNumInfo")]
	public TArrayReadWrite<FComboSkillNumInfo> ComboSkillNumInfo
	{
		get
		{
			CheckDestroyed();
			if (!ComboSkillNumInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:ComboSkillNumInfo");
				return null;
			}
			if (ComboSkillNumInfo_Marshaler == null)
			{
				ComboSkillNumInfo_Marshaler = new TArrayReadWriteMarshaler<FComboSkillNumInfo>(1, ComboSkillNumInfo_PropertyAddress, CachedMarshalingDelegates<FComboSkillNumInfo, BlittableTypeMarshaler<FComboSkillNumInfo>>.FromNative, CachedMarshalingDelegates<FComboSkillNumInfo, BlittableTypeMarshaler<FComboSkillNumInfo>>.ToNative);
			}
			return ComboSkillNumInfo_Marshaler.FromNative(IntPtr.Add(base.Address, ComboSkillNumInfo_Offset));
		}
	}

	[UProperty]
	[Category("Skill")]
	[BlueprintReadWrite]
	[DisplayName("技能是否可以被强制打断")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:bCanBeForceAbort")]
	public bool bCanBeForceAbort
	{
		get
		{
			CheckDestroyed();
			if (!bCanBeForceAbort_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:bCanBeForceAbort");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanBeForceAbort_Offset), 0, bCanBeForceAbort_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanBeForceAbort_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:bCanBeForceAbort");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanBeForceAbort_Offset), 0, bCanBeForceAbort_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("Combo是否可以被反击技打断")]
	[Tooltip("Combo连招默认不会被预反击状态打断")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:bCanBeInterruptedByHRCounterattack")]
	public bool bCanBeInterruptedByHRCounterattack
	{
		get
		{
			CheckDestroyed();
			if (!bCanBeInterruptedByHRCounterattack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:bCanBeInterruptedByHRCounterattack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanBeInterruptedByHRCounterattack_Offset), 0, bCanBeInterruptedByHRCounterattack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanBeInterruptedByHRCounterattack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:bCanBeInterruptedByHRCounterattack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanBeInterruptedByHRCounterattack_Offset), 0, bCanBeInterruptedByHRCounterattack_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Skill")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否使用Socket替代角色朝向")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:UseSocketDirection")]
	public bool UseSocketDirection
	{
		get
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:UseSocketDirection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:UseSocketDirection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Skill")]
	[DisplayName("朝向基准Socket")]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:DirectionBaseSocket")]
	public FName DirectionBaseSocket
	{
		get
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:DirectionBaseSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:DirectionBaseSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Skill")]
	[DisplayName("前向Socket")]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:ForwardSocket")]
	public FName ForwardSocket
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:ForwardSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ForwardSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:ForwardSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ForwardSocket_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[DisplayName("右向Socket")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:RightSocket")]
	public FName RightSocket
	{
		get
		{
			CheckDestroyed();
			if (!RightSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:RightSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RightSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:RightSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RightSocket_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AvoidObstacle")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SkillConfigMode")]
	public EEscapeSkillConfigMode SkillConfigMode
	{
		get
		{
			CheckDestroyed();
			if (!SkillConfigMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SkillConfigMode");
				return EEscapeSkillConfigMode.None;
			}
			return EnumMarshaler<EEscapeSkillConfigMode>.FromNative(IntPtr.Add(base.Address, SkillConfigMode_Offset), 0, SkillConfigMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkillConfigMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SkillConfigMode");
			}
			else
			{
				EnumMarshaler<EEscapeSkillConfigMode>.ToNative(IntPtr.Add(base.Address, SkillConfigMode_Offset), 0, SkillConfigMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("AvoidObstacle")]
	[DisplayName("单方向技能列表")]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Single")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SingleDirectionSkills")]
	public TArrayReadWrite<int> SingleDirectionSkills
	{
		get
		{
			CheckDestroyed();
			if (!SingleDirectionSkills_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SingleDirectionSkills");
				return null;
			}
			if (SingleDirectionSkills_Marshaler == null)
			{
				SingleDirectionSkills_Marshaler = new TArrayReadWriteMarshaler<int>(1, SingleDirectionSkills_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SingleDirectionSkills_Marshaler.FromNative(IntPtr.Add(base.Address, SingleDirectionSkills_Offset));
		}
	}

	[UMeta(MDProp.ClampMin, 1)]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AvoidObstacle")]
	[DisplayName("脱困技能扇区数")]
	[UMeta(MDProp.ClampMax, 8)]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:AvoidObstacleSectionNum")]
	public int AvoidObstacleSectionNum
	{
		get
		{
			CheckDestroyed();
			if (!AvoidObstacleSectionNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:AvoidObstacleSectionNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AvoidObstacleSectionNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AvoidObstacleSectionNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:AvoidObstacleSectionNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AvoidObstacleSectionNum_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("起始扇区角度")]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[Category("AvoidObstacle")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SectionsStartAngle")]
	public float SectionsStartAngle
	{
		get
		{
			CheckDestroyed();
			if (!SectionsStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SectionsStartAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SectionsStartAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectionsStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:SectionsStartAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SectionsStartAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[Category("AvoidObstacle")]
	[DisplayName("每个扇区的角度大小")]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IntervalAngle")]
	public float IntervalAngle
	{
		get
		{
			CheckDestroyed();
			if (!IntervalAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IntervalAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IntervalAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntervalAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:IntervalAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IntervalAngle_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[VisibleAnywhere]
	[DisplayName("扇区脱困技能")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[Category("AvoidObstacle")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:AvoidObstacleSections")]
	public TArrayReadWrite<FAvoidObstacleSection> AvoidObstacleSections
	{
		get
		{
			CheckDestroyed();
			if (!AvoidObstacleSections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig:AvoidObstacleSections");
				return null;
			}
			if (AvoidObstacleSections_Marshaler == null)
			{
				AvoidObstacleSections_Marshaler = new TArrayReadWriteMarshaler<FAvoidObstacleSection>(1, AvoidObstacleSections_PropertyAddress, CachedMarshalingDelegates<FAvoidObstacleSection, FAvoidObstacleSection>.FromNative, CachedMarshalingDelegates<FAvoidObstacleSection, FAvoidObstacleSection>.ToNative);
			}
			return AvoidObstacleSections_Marshaler.FromNative(IntPtr.Add(base.Address, AvoidObstacleSections_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AutoTestComboConfig");
		NativeReflection.GetPropertyRef(ref SkillSourceType_PropertyAddress, unrealStruct, "SkillSourceType");
		SkillSourceType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillSourceType");
		SkillSourceType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillSourceType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PursuitAnyWhere_PropertyAddress, unrealStruct, "PursuitAnyWhere");
		PursuitAnyWhere_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PursuitAnyWhere");
		PursuitAnyWhere_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PursuitAnyWhere", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PursuitInAllSkill_PropertyAddress, unrealStruct, "PursuitInAllSkill");
		PursuitInAllSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PursuitInAllSkill");
		PursuitInAllSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PursuitInAllSkill", Classes.FBoolProperty);
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
		NativeReflection.GetPropertyRef(ref bCanBeForceAbort_PropertyAddress, unrealStruct, "bCanBeForceAbort");
		bCanBeForceAbort_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCanBeForceAbort");
		bCanBeForceAbort_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCanBeForceAbort", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCanBeInterruptedByHRCounterattack_PropertyAddress, unrealStruct, "bCanBeInterruptedByHRCounterattack");
		bCanBeInterruptedByHRCounterattack_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCanBeInterruptedByHRCounterattack");
		bCanBeInterruptedByHRCounterattack_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCanBeInterruptedByHRCounterattack", Classes.FBoolProperty);
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

	static BGWDataAsset_AutoTestComboConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AutoTestComboConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AutoTestComboConfig));
	}
}
