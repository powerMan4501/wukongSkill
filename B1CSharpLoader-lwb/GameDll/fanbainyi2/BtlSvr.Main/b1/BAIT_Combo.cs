using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Combo")]
[USharpPath("/Script/b1-Managed.BAIT_Combo")]
public class BAIT_Combo : BAIT_Base
{
	private class SkillTreeNode
	{
		public readonly int SkillID;

		public readonly int Stage;

		public List<SkillTreeNode> Children;

		public SkillTreeNode Parent;

		public SkillTreeNode(int SkillID, int Stage, SkillTreeNode Parent)
		{
			this.SkillID = SkillID;
			this.Stage = Stage;
			this.Parent = Parent;
			Children = new List<SkillTreeNode>();
		}
	}

	private static bool ComboTargetType_IsValid;

	private static int ComboTargetType_Offset;

	private static FFieldAddress ComboTargetType_PropertyAddress;

	private static bool SkillSourceType_IsValid;

	private static int SkillSourceType_Offset;

	private static FFieldAddress SkillSourceType_PropertyAddress;

	private static bool CanUpdateComboTargetWhenPursuit_IsValid;

	private static int CanUpdateComboTargetWhenPursuit_Offset;

	private static FFieldAddress CanUpdateComboTargetWhenPursuit_PropertyAddress;

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

	private static bool CanCheckCastSkillDuringWholeComboWindow_IsValid;

	private static int CanCheckCastSkillDuringWholeComboWindow_Offset;

	private static FFieldAddress CanCheckCastSkillDuringWholeComboWindow_PropertyAddress;

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

	private static bool QACalcSkillArray_IsValid;

	private static IntPtr QACalcSkillArray_FunctionAddress;

	private static int QACalcSkillArray_ParamsSize;

	private static bool QACalcSkillArray_ReturnValue_IsValid;

	private static int QACalcSkillArray_ReturnValue_Offset;

	private static FFieldAddress QACalcSkillArray_ReturnValue_PropertyAddress;

	private static bool QACalcTrueComboArray_IsValid;

	private static IntPtr QACalcTrueComboArray_FunctionAddress;

	private static int QACalcTrueComboArray_ParamsSize;

	private static bool QACalcTrueComboArray_ReturnValue_IsValid;

	private static int QACalcTrueComboArray_ReturnValue_Offset;

	private static FFieldAddress QACalcTrueComboArray_ReturnValue_PropertyAddress;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	[Category("CommSetting")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Combo期间目标类型")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:ComboTargetType")]
	public EComboTargetType ComboTargetType
	{
		get
		{
			CheckDestroyed();
			if (!ComboTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:ComboTargetType");
				return EComboTargetType.None;
			}
			return EnumMarshaler<EComboTargetType>.FromNative(IntPtr.Add(base.Address, ComboTargetType_Offset), 0, ComboTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComboTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:ComboTargetType");
			}
			else
			{
				EnumMarshaler<EComboTargetType>.ToNative(IntPtr.Add(base.Address, ComboTargetType_Offset), 0, ComboTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("技能来源")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("CommSetting")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:SkillSourceType")]
	public EZatoichiSkillSourceType SkillSourceType
	{
		get
		{
			CheckDestroyed();
			if (!SkillSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SkillSourceType");
				return EZatoichiSkillSourceType.None;
			}
			return EnumMarshaler<EZatoichiSkillSourceType>.FromNative(IntPtr.Add(base.Address, SkillSourceType_Offset), 0, SkillSourceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkillSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SkillSourceType");
			}
			else
			{
				EnumMarshaler<EZatoichiSkillSourceType>.ToNative(IntPtr.Add(base.Address, SkillSourceType_Offset), 0, SkillSourceType_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "ComboTargetType == ComboTargetType::CurrentAITarget")]
	[DisplayName("追逐过程中是否更新Combo目标")]
	[Category("Pursuit")]
	[Tooltip("【不勾选】则Combo目标在一开始就会确定不会改变；【勾选】需要ComboTargetType == CurrentAITarget才会生效")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:CanUpdateComboTargetWhenPursuit")]
	public bool CanUpdateComboTargetWhenPursuit
	{
		get
		{
			CheckDestroyed();
			if (!CanUpdateComboTargetWhenPursuit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:CanUpdateComboTargetWhenPursuit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanUpdateComboTargetWhenPursuit_Offset), 0, CanUpdateComboTargetWhenPursuit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanUpdateComboTargetWhenPursuit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:CanUpdateComboTargetWhenPursuit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanUpdateComboTargetWhenPursuit_Offset), 0, CanUpdateComboTargetWhenPursuit_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("是否全部技能前都会追逐")]
	[Tooltip("不勾选则只有第一次技能释放前才会触发追逐逻辑")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:PursuitInAllSkill")]
	public bool PursuitInAllSkill
	{
		get
		{
			CheckDestroyed();
			if (!PursuitInAllSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:PursuitInAllSkill");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PursuitInAllSkill_Offset), 0, PursuitInAllSkill_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PursuitInAllSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:PursuitInAllSkill");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PursuitInAllSkill_Offset), 0, PursuitInAllSkill_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("主要是处理由于导航网格缺失带来的追逐异常")]
	[DisplayName("寻路中断后是否仍然追逐")]
	[Category("Pursuit")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:PursuitAnyWhere")]
	public bool PursuitAnyWhere
	{
		get
		{
			CheckDestroyed();
			if (!PursuitAnyWhere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:PursuitAnyWhere");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PursuitAnyWhere_Offset), 0, PursuitAnyWhere_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PursuitAnyWhere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:PursuitAnyWhere");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PursuitAnyWhere_Offset), 0, PursuitAnyWhere_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("主要是处理配置技能转身和技能位移后触发失效，导致长时间卡死AI的问题")]
	[Category("Pursuit")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("追逐失效后是否强行释放技能")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:ForceCastSkillAfterPursuitFailed")]
	public bool ForceCastSkillAfterPursuitFailed
	{
		get
		{
			CheckDestroyed();
			if (!ForceCastSkillAfterPursuitFailed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:ForceCastSkillAfterPursuitFailed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceCastSkillAfterPursuitFailed_Offset), 0, ForceCastSkillAfterPursuitFailed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceCastSkillAfterPursuitFailed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:ForceCastSkillAfterPursuitFailed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceCastSkillAfterPursuitFailed_Offset), 0, ForceCastSkillAfterPursuitFailed_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.ClampMax, "1")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("追逐距离计算偏向")]
	[UMeta(MDProp.ClampMin, "0")]
	[Tooltip("0.5就是选择追逐到技能释放距离区域的中部")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:PursuitRangePos")]
	public float PursuitRangePos
	{
		get
		{
			CheckDestroyed();
			if (!PursuitRangePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:PursuitRangePos");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PursuitRangePos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PursuitRangePos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:PursuitRangePos");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PursuitRangePos_Offset), value);
			}
		}
	}

	[Category("Pursuit")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("追逐移动速率")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SpeedRateType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("追逐移动MotionMatching模式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Pursuit")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:MotionMatchingMoveMode")]
	public EState_MM MotionMatchingMoveMode
	{
		get
		{
			CheckDestroyed();
			if (!MotionMatchingMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:MotionMatchingMoveMode");
				return EState_MM.None;
			}
			return EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(base.Address, MotionMatchingMoveMode_Offset), 0, MotionMatchingMoveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MotionMatchingMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:MotionMatchingMoveMode");
			}
			else
			{
				EnumMarshaler<EState_MM>.ToNative(IntPtr.Add(base.Address, MotionMatchingMoveMode_Offset), 0, MotionMatchingMoveMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("追逐移动朝向模式")]
	[Category("Pursuit")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:MoveAIType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("追逐移动抵达半径包括类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Pursuit")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:MoveAcceptableRadiusType")]
	public EBGUMoveAcceptableRadiusType MoveAcceptableRadiusType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAcceptableRadiusType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:MoveAcceptableRadiusType");
				return EBGUMoveAcceptableRadiusType.NoInclude;
			}
			return EnumMarshaler<EBGUMoveAcceptableRadiusType>.FromNative(IntPtr.Add(base.Address, MoveAcceptableRadiusType_Offset), 0, MoveAcceptableRadiusType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAcceptableRadiusType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:MoveAcceptableRadiusType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAcceptableRadiusType>.ToNative(IntPtr.Add(base.Address, MoveAcceptableRadiusType_Offset), 0, MoveAcceptableRadiusType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("追逐前开始旋转角度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "180")]
	[Category("Pursuit")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:BeginRotateAngle")]
	public float BeginRotateAngle
	{
		get
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:BeginRotateAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:BeginRotateAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("是否使用技能旋转")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[Tooltip("对应旋转技能在表格里填写")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:IsUseSkillForTurn")]
	public bool IsUseSkillForTurn
	{
		get
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IsUseSkillForTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IsUseSkillForTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("对应位移技能在表格里填写")]
	[UProperty]
	[DisplayName("是否使用技能位移")]
	[EditAnywhere]
	[Category("Pursuit")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:IsUseSkillForMove")]
	public bool IsUseSkillForMove
	{
		get
		{
			CheckDestroyed();
			if (!IsUseSkillForMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IsUseSkillForMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseSkillForMove_Offset), 0, IsUseSkillForMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseSkillForMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IsUseSkillForMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseSkillForMove_Offset), 0, IsUseSkillForMove_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "IsUseSkillForMove")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Pursuit")]
	[DisplayName("追逐前位移距离")]
	[Tooltip("只有使用技能位移才生效，如果距离小于这个值不释放技能")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:BeginMoveDistanceWhenUseSkill")]
	public float BeginMoveDistanceWhenUseSkill
	{
		get
		{
			CheckDestroyed();
			if (!BeginMoveDistanceWhenUseSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:BeginMoveDistanceWhenUseSkill");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginMoveDistanceWhenUseSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginMoveDistanceWhenUseSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:BeginMoveDistanceWhenUseSkill");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginMoveDistanceWhenUseSkill_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("是否整个ComboWindow都判断能否释放技能")]
	[Tooltip("不勾选则在同一个AM里，遇到ComboWindow只会判断一次能否释放技能")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:CanCheckCastSkillDuringWholeComboWindow")]
	public bool CanCheckCastSkillDuringWholeComboWindow
	{
		get
		{
			CheckDestroyed();
			if (!CanCheckCastSkillDuringWholeComboWindow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:CanCheckCastSkillDuringWholeComboWindow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanCheckCastSkillDuringWholeComboWindow_Offset), 0, CanCheckCastSkillDuringWholeComboWindow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanCheckCastSkillDuringWholeComboWindow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:CanCheckCastSkillDuringWholeComboWindow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanCheckCastSkillDuringWholeComboWindow_Offset), 0, CanCheckCastSkillDuringWholeComboWindow_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Skill")]
	[DisplayName("技能释放失败后，退出Combo节点节点时是否减少连招套数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:EnableInterruptReduceCBNum")]
	public bool EnableInterruptReduceCBNum
	{
		get
		{
			CheckDestroyed();
			if (!EnableInterruptReduceCBNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:EnableInterruptReduceCBNum");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableInterruptReduceCBNum_Offset), 0, EnableInterruptReduceCBNum_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableInterruptReduceCBNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:EnableInterruptReduceCBNum");
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
	[Tooltip("只有在第一招释放前会检测")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:NeedTraceHitTargetBefore")]
	public bool NeedTraceHitTargetBefore
	{
		get
		{
			CheckDestroyed();
			if (!NeedTraceHitTargetBefore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:NeedTraceHitTargetBefore");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedTraceHitTargetBefore_Offset), 0, NeedTraceHitTargetBefore_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedTraceHitTargetBefore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:NeedTraceHitTargetBefore");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedTraceHitTargetBefore_Offset), 0, NeedTraceHitTargetBefore_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("是否开启强制连招关系")]
	[Tooltip("是强制连招关系，不是强制真连招")]
	[Category("Skill")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:EnableForceComboRelation")]
	public bool EnableForceComboRelation
	{
		get
		{
			CheckDestroyed();
			if (!EnableForceComboRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:EnableForceComboRelation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableForceComboRelation_Offset), 0, EnableForceComboRelation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableForceComboRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:EnableForceComboRelation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableForceComboRelation_Offset), 0, EnableForceComboRelation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("是否屏蔽连招内放过技能")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:EnableComboCondition")]
	public bool EnableComboCondition
	{
		get
		{
			CheckDestroyed();
			if (!EnableComboCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:EnableComboCondition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableComboCondition_Offset), 0, EnableComboCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableComboCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:EnableComboCondition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableComboCondition_Offset), 0, EnableComboCondition_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "NeedTraceHitTargetBefore")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("射线检测距离")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:TraceDistance")]
	public float TraceDistance
	{
		get
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:TraceDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:TraceDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceDistance_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "NeedTraceHitTargetBefore")]
	[Category("Skill")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("射线检测通道")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:TraceTypeQuery")]
	public ETraceTypeQuery TraceTypeQuery
	{
		get
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:TraceTypeQuery");
				return ETraceTypeQuery.TraceTypeQuery1;
			}
			return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:TraceTypeQuery");
			}
			else
			{
				EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("不勾选则选择分数最高的技能")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("是否随机获取算分顶部技能")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:IsGetTopRandomSkill")]
	public bool IsGetTopRandomSkill
	{
		get
		{
			CheckDestroyed();
			if (!IsGetTopRandomSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IsGetTopRandomSkill");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsGetTopRandomSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IsGetTopRandomSkill");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsGetTopRandomSkill_Offset), 0, IsGetTopRandomSkill_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.ClampMax, "10000")]
	[UMeta(MDProp.EditCondition, "IsGetTopRandomSkill")]
	[UMeta(MDProp.ClampMin, "0")]
	[DisplayName("算分顶部随机选取技能万分比")]
	[Category("Skill")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:TopRandomSkillPercent")]
	public int TopRandomSkillPercent
	{
		get
		{
			CheckDestroyed();
			if (!TopRandomSkillPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:TopRandomSkillPercent");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TopRandomSkillPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TopRandomSkillPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:TopRandomSkillPercent");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TopRandomSkillPercent_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("连招技能池")]
	[Category("Skill")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:SkillArray")]
	public TArrayReadWrite<FComboSkill> SkillArray
	{
		get
		{
			CheckDestroyed();
			if (!SkillArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SkillArray");
				return null;
			}
			if (SkillArray_Marshaler == null)
			{
				SkillArray_Marshaler = new TArrayReadWriteMarshaler<FComboSkill>(1, SkillArray_PropertyAddress, CachedMarshalingDelegates<FComboSkill, FComboSkill>.FromNative, CachedMarshalingDelegates<FComboSkill, FComboSkill>.ToNative);
			}
			return SkillArray_Marshaler.FromNative(IntPtr.Add(base.Address, SkillArray_Offset));
		}
	}

	[DisplayName("是否获取提前算好的随机连招长度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:IsGetAdvanceComboLength")]
	public bool IsGetAdvanceComboLength
	{
		get
		{
			CheckDestroyed();
			if (!IsGetAdvanceComboLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IsGetAdvanceComboLength");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsGetAdvanceComboLength_Offset), 0, IsGetAdvanceComboLength_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsGetAdvanceComboLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IsGetAdvanceComboLength");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsGetAdvanceComboLength_Offset), 0, IsGetAdvanceComboLength_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("连招长度信息")]
	[Category("Skill")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:ComboSkillNumInfo")]
	public TArrayReadWrite<FComboSkillNumInfo> ComboSkillNumInfo
	{
		get
		{
			CheckDestroyed();
			if (!ComboSkillNumInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:ComboSkillNumInfo");
				return null;
			}
			if (ComboSkillNumInfo_Marshaler == null)
			{
				ComboSkillNumInfo_Marshaler = new TArrayReadWriteMarshaler<FComboSkillNumInfo>(1, ComboSkillNumInfo_PropertyAddress, CachedMarshalingDelegates<FComboSkillNumInfo, BlittableTypeMarshaler<FComboSkillNumInfo>>.FromNative, CachedMarshalingDelegates<FComboSkillNumInfo, BlittableTypeMarshaler<FComboSkillNumInfo>>.ToNative);
			}
			return ComboSkillNumInfo_Marshaler.FromNative(IntPtr.Add(base.Address, ComboSkillNumInfo_Offset));
		}
	}

	[Tooltip("默认是需要等待AttackState结束才会响应Abort")]
	[UProperty]
	[Category("Skill")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Combo是否可以被BTNodeAbort强制打断")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:bCanBeForceAbort")]
	public bool bCanBeForceAbort
	{
		get
		{
			CheckDestroyed();
			if (!bCanBeForceAbort_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:bCanBeForceAbort");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanBeForceAbort_Offset), 0, bCanBeForceAbort_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanBeForceAbort_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:bCanBeForceAbort");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanBeForceAbort_Offset), 0, bCanBeForceAbort_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Combo是否可以被反击技打断")]
	[Tooltip("Combo连招默认不会被预反击状态打断")]
	[Category("Skill")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:bCanBeInterruptedByHRCounterattack")]
	public bool bCanBeInterruptedByHRCounterattack
	{
		get
		{
			CheckDestroyed();
			if (!bCanBeInterruptedByHRCounterattack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:bCanBeInterruptedByHRCounterattack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanBeInterruptedByHRCounterattack_Offset), 0, bCanBeInterruptedByHRCounterattack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanBeInterruptedByHRCounterattack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:bCanBeInterruptedByHRCounterattack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanBeInterruptedByHRCounterattack_Offset), 0, bCanBeInterruptedByHRCounterattack_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("是否使用Socket替代角色朝向")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:UseSocketDirection")]
	public bool UseSocketDirection
	{
		get
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:UseSocketDirection");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSocketDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:UseSocketDirection");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSocketDirection_Offset), 0, UseSocketDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Skill")]
	[DisplayName("朝向基准Socket")]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:DirectionBaseSocket")]
	public FName DirectionBaseSocket
	{
		get
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:DirectionBaseSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DirectionBaseSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionBaseSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:DirectionBaseSocket");
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
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:ForwardSocket")]
	public FName ForwardSocket
	{
		get
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:ForwardSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ForwardSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:ForwardSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ForwardSocket_Offset), value);
			}
		}
	}

	[Category("Skill")]
	[DisplayName("右向Socket")]
	[UMeta(MDProp.EditCondition, "UseSocketDirection")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:RightSocket")]
	public FName RightSocket
	{
		get
		{
			CheckDestroyed();
			if (!RightSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:RightSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, RightSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:RightSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, RightSocket_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("AvoidObstacle")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:SkillConfigMode")]
	public EEscapeSkillConfigMode SkillConfigMode
	{
		get
		{
			CheckDestroyed();
			if (!SkillConfigMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SkillConfigMode");
				return EEscapeSkillConfigMode.None;
			}
			return EnumMarshaler<EEscapeSkillConfigMode>.FromNative(IntPtr.Add(base.Address, SkillConfigMode_Offset), 0, SkillConfigMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkillConfigMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SkillConfigMode");
			}
			else
			{
				EnumMarshaler<EEscapeSkillConfigMode>.ToNative(IntPtr.Add(base.Address, SkillConfigMode_Offset), 0, SkillConfigMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("AvoidObstacle")]
	[DisplayName("单方向技能列表")]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Single")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:SingleDirectionSkills")]
	public TArrayReadWrite<int> SingleDirectionSkills
	{
		get
		{
			CheckDestroyed();
			if (!SingleDirectionSkills_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SingleDirectionSkills");
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
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[UMeta(MDProp.ClampMin, 1)]
	[UMeta(MDProp.ClampMax, 8)]
	[DisplayName("脱困技能扇区数")]
	[Category("AvoidObstacle")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:AvoidObstacleSectionNum")]
	public int AvoidObstacleSectionNum
	{
		get
		{
			CheckDestroyed();
			if (!AvoidObstacleSectionNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:AvoidObstacleSectionNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AvoidObstacleSectionNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AvoidObstacleSectionNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:AvoidObstacleSectionNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AvoidObstacleSectionNum_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[Category("AvoidObstacle")]
	[DisplayName("起始扇区角度")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:SectionsStartAngle")]
	public float SectionsStartAngle
	{
		get
		{
			CheckDestroyed();
			if (!SectionsStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SectionsStartAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SectionsStartAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectionsStartAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:SectionsStartAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SectionsStartAngle_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[DisplayName("每个扇区的角度大小")]
	[UProperty]
	[Category("AvoidObstacle")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:IntervalAngle")]
	public float IntervalAngle
	{
		get
		{
			CheckDestroyed();
			if (!IntervalAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IntervalAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IntervalAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntervalAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:IntervalAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IntervalAngle_Offset), value);
			}
		}
	}

	[VisibleAnywhere]
	[BlueprintReadOnly]
	[Category("AvoidObstacle")]
	[DisplayName("扇区脱困技能")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "SkillConfigMode == EEscapeSkillConfigMode::Multiple")]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:AvoidObstacleSections")]
	public TArrayReadWrite<FAvoidObstacleSection> AvoidObstacleSections
	{
		get
		{
			CheckDestroyed();
			if (!AvoidObstacleSections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_Combo:AvoidObstacleSections");
				return null;
			}
			if (AvoidObstacleSections_Marshaler == null)
			{
				AvoidObstacleSections_Marshaler = new TArrayReadWriteMarshaler<FAvoidObstacleSection>(1, AvoidObstacleSections_PropertyAddress, CachedMarshalingDelegates<FAvoidObstacleSection, FAvoidObstacleSection>.FromNative, CachedMarshalingDelegates<FAvoidObstacleSection, FAvoidObstacleSection>.ToNative);
			}
			return AvoidObstacleSections_Marshaler.FromNative(IntPtr.Add(base.Address, AvoidObstacleSections_Offset));
		}
	}

	private void ConstructTree(SkillTreeNode RootNode, List<FComboSkill> SkillPool, int CurrentStage, List<List<List<int>>> ComboList)
	{
		List<int> list = new List<int>();
		SkillTreeNode skillTreeNode = RootNode;
		list.Add(skillTreeNode.SkillID);
		while (skillTreeNode.Parent != null)
		{
			skillTreeNode = skillTreeNode.Parent;
			list.Add(skillTreeNode.SkillID);
		}
		list.Reverse();
		ComboList[CurrentStage].Add(list);
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(RootNode.SkillID);
		if (skillAIDesc == null || skillAIDesc.NextSkillList == null || CurrentStage + 1 >= SkillPool.Count)
		{
			return;
		}
		foreach (int nextSkill in skillAIDesc.NextSkillList)
		{
			if (SkillPool[CurrentStage + 1].SkillID.Contains(nextSkill) && (EnableComboCondition || !list.Contains(nextSkill)))
			{
				SkillTreeNode skillTreeNode2 = new SkillTreeNode(nextSkill, CurrentStage + 1, RootNode);
				RootNode.Children.Add(skillTreeNode2);
				ConstructTree(skillTreeNode2, SkillPool, CurrentStage + 1, ComboList);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:QACalcSkillArray")]
	public string QACalcSkillArray()
	{
		string text = "行为树" + GetOuter().GetName() + "\n";
		text = text + "Combo节点" + GetName() + "\n";
		text = text + "是否开启强制连招关系：" + EnableForceComboRelation + "\n";
		text += "连招长度信息：\n";
		foreach (FComboSkillNumInfo item in ComboSkillNumInfo)
		{
			string[] obj = new string[5] { text, null, null, null, null };
			int comboNum = item.ComboNum;
			obj[1] = comboNum.ToString();
			obj[2] = " ";
			comboNum = item.ComboPercenRatio;
			obj[3] = comboNum.ToString();
			obj[4] = "\n";
			text = string.Concat(obj);
		}
		List<FComboSkill> list = SkillArray.ToList();
		List<List<List<int>>> list2 = new List<List<List<int>>>();
		for (int i = 0; i < list.Count; i++)
		{
			list2.Add(new List<List<int>>());
		}
		foreach (int item2 in list[0].SkillID)
		{
			ConstructTree(new SkillTreeNode(item2, 0, null), list, 0, list2);
		}
		text += "连招技能池：\n";
		foreach (List<List<int>> item3 in list2)
		{
			foreach (List<int> item4 in item3)
			{
				text = text + string.Join("->", item4) + "\n";
			}
		}
		return text + "================================\n";
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BAIT_Combo:QACalcTrueComboArray")]
	public List<string> QACalcTrueComboArray()
	{
		List<string> list = new List<string>();
		List<FComboSkill> list2 = SkillArray.ToList();
		if (EnableForceComboRelation)
		{
			List<List<List<int>>> list3 = new List<List<List<int>>>();
			for (int i = 0; i < list2.Count; i++)
			{
				list3.Add(new List<List<int>>());
			}
			foreach (int item in list2[0].SkillID)
			{
				ConstructTree(new SkillTreeNode(item, 0, null), list2, 0, list3);
			}
			foreach (List<List<int>> item2 in list3)
			{
				foreach (List<int> item3 in item2)
				{
					list.Add(string.Join("->", item3));
				}
			}
		}
		else
		{
			foreach (FComboSkill item4 in list2)
			{
				foreach (int item5 in item4.SkillID)
				{
					list.Add(item5.ToString());
				}
			}
		}
		return list;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		ComboTargetType = EComboTargetType.CurrentAITarget;
		SkillSourceType = EZatoichiSkillSourceType.UseWithSkillCategory;
		NeedTraceHitTargetBefore = false;
		EnableForceComboRelation = false;
		MoveAcceptableRadiusType = EBGUMoveAcceptableRadiusType.IncludeTarget;
		SpeedRateType = EAIMoveSpeedType.SPRINT;
		MotionMatchingMoveMode = EState_MM.Free;
		MoveAIType = EBGUMoveAIType.KeepFacingTarget;
		PursuitInAllSkill = false;
		ForceCastSkillAfterPursuitFailed = false;
		EnableComboCondition = true;
		UseSocketDirection = false;
		IsUseSkillForMove = false;
		IsUseSkillForTurn = false;
		PursuitRangePos = 1f;
		SkillConfigMode = EEscapeSkillConfigMode.Single;
		AvoidObstacleSectionNum = 1;
		CanUpdateComboTargetWhenPursuit = false;
		CanCheckCastSkillDuringWholeComboWindow = false;
		for (int i = 0; i < AvoidObstacleSectionNum; i++)
		{
			AvoidObstacleSections.Add(default(FAvoidObstacleSection));
		}
		AdjustSectionsAngleRange();
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.Combo, new AINodeAction_ComboParamInfo
				{
					CanUpdateComboTargetWhenPursuit = CanUpdateComboTargetWhenPursuit,
					CanCheckCastSkillDuringWholeComboWindow = CanCheckCastSkillDuringWholeComboWindow,
					ComboTargetType = ComboTargetType,
					SkillSourceType = SkillSourceType,
					ForceCastSkillAfterPursuitFailed = ForceCastSkillAfterPursuitFailed,
					PursuitAnyWhere = PursuitAnyWhere,
					PursuitInAllSkill = PursuitInAllSkill,
					PursuitRangePos = PursuitRangePos,
					SpeedRateType = SpeedRateType,
					MotionMatchingMoveMode = MotionMatchingMoveMode,
					MoveAIType = MoveAIType,
					MoveAcceptableRadiusType = MoveAcceptableRadiusType,
					BeginRotateAngle = BeginRotateAngle,
					IsUseSkillForTurn = IsUseSkillForTurn,
					IsUseSkillForMove = IsUseSkillForMove,
					BeginMoveDistanceWhenUseSkill = BeginMoveDistanceWhenUseSkill,
					EnableInterruptReduceCBNum = EnableInterruptReduceCBNum,
					NeedTraceHitTargetBefore = NeedTraceHitTargetBefore,
					EnableForceComboRelation = EnableForceComboRelation,
					EnableComboCondition = EnableComboCondition,
					TraceDistance = TraceDistance,
					TraceTypeQuery = TraceTypeQuery,
					IsGetTopRandomSkill = IsGetTopRandomSkill,
					TopRandomSkillPercent = TopRandomSkillPercent,
					IsGetAdvanceComboLength = IsGetAdvanceComboLength,
					bCanBeForceAbort = bCanBeForceAbort,
					bCanBeInterruptedByHRCounterattack = bCanBeInterruptedByHRCounterattack,
					UseSocketDirection = UseSocketDirection,
					DirectionBaseSocket = DirectionBaseSocket,
					ForwardSocket = ForwardSocket,
					RightSocket = RightSocket,
					SkillConfigMode = SkillConfigMode,
					AvoidObstacleSectionNum = AvoidObstacleSectionNum,
					SectionsStartAngle = SectionsStartAngle,
					IntervalAngle = IntervalAngle,
					SkillArray = SkillArray.ToList(),
					ComboSkillNumInfo = ComboSkillNumInfo.ToList(),
					SingleDirectionSkills = SingleDirectionSkills.ToList(),
					AvoidObstacleSections = AvoidObstacleSections.ToList()
				});
			}
		}
	}

	private void AdjustSectionsAngleRange()
	{
		IntervalAngle = 360f / (float)AvoidObstacleSectionNum;
		int i;
		for (i = 0; i < AvoidObstacleSections.Count; i++)
		{
			FAvoidObstacleSection value = AvoidObstacleSections[i];
			value.StartAngle = SectionsStartAngle + IntervalAngle * (float)i;
			value.EndAngle = value.StartAngle + IntervalAngle;
			AvoidObstacleSections[i] = value;
		}
		FAvoidObstacleSection value2 = AvoidObstacleSections[0];
		value2.StartAngle = MathLib.ClampAxis(SectionsStartAngle);
		AvoidObstacleSections[0] = value2;
		FAvoidObstacleSection value3 = AvoidObstacleSections[--i];
		value3.EndAngle = MathLib.ClampAxis(SectionsStartAngle - 1E-08f);
		AvoidObstacleSections[i] = value3;
	}

	[USharpPath("/Script/b1-Managed.BAIT_Combo:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("AvoidObstacleSectionNum"))
		{
			int count = AvoidObstacleSections.Count;
			int num = AvoidObstacleSectionNum - count;
			if (num == 0)
			{
				return;
			}
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					AvoidObstacleSections.Add(default(FAvoidObstacleSection));
				}
			}
			else
			{
				for (int num2 = count - 1; num2 >= AvoidObstacleSectionNum; num2--)
				{
					AvoidObstacleSections.RemoveAt(num2);
				}
			}
			AdjustSectionsAngleRange();
		}
		if (PropertyName.Equals("SectionsStartAngle"))
		{
			AdjustSectionsAngleRange();
		}
		if (PropertyName.Equals("SkillSourceType"))
		{
			ForceRefreshDetailView();
			if (SkillSourceType == EZatoichiSkillSourceType.UseWithAvoidObstacle)
			{
				AdjustSectionsAngleRange();
				BeginRotateAngle = 180f;
			}
		}
		if (PropertyName.Equals("SkillConfigMode"))
		{
			ForceRefreshDetailView();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAIT_Combo:QACalcSkillArray")]
	private static void QACalcSkillArray__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAIT_Combo bAIT_Combo = GCHelper.Find<BAIT_Combo>(obj);
		string value = bAIT_Combo.QACalcSkillArray();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QACalcSkillArray_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAIT_Combo:QACalcTrueComboArray")]
	private static void QACalcTrueComboArray__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAIT_Combo bAIT_Combo = GCHelper.Find<BAIT_Combo>(obj);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, QACalcTrueComboArray_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> value = bAIT_Combo.QACalcTrueComboArray();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, QACalcTrueComboArray_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAIT_Combo:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAIT_Combo bAIT_Combo = GCHelper.Find<BAIT_Combo>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		bAIT_Combo.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_Combo");
		NativeReflection.GetPropertyRef(ref ComboTargetType_PropertyAddress, intPtr, "ComboTargetType");
		ComboTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ComboTargetType");
		ComboTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ComboTargetType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SkillSourceType_PropertyAddress, intPtr, "SkillSourceType");
		SkillSourceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillSourceType");
		SkillSourceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillSourceType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CanUpdateComboTargetWhenPursuit_PropertyAddress, intPtr, "CanUpdateComboTargetWhenPursuit");
		CanUpdateComboTargetWhenPursuit_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanUpdateComboTargetWhenPursuit");
		CanUpdateComboTargetWhenPursuit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanUpdateComboTargetWhenPursuit", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PursuitInAllSkill_PropertyAddress, intPtr, "PursuitInAllSkill");
		PursuitInAllSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "PursuitInAllSkill");
		PursuitInAllSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PursuitInAllSkill", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PursuitAnyWhere_PropertyAddress, intPtr, "PursuitAnyWhere");
		PursuitAnyWhere_Offset = NativeReflection.GetPropertyOffset(intPtr, "PursuitAnyWhere");
		PursuitAnyWhere_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PursuitAnyWhere", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ForceCastSkillAfterPursuitFailed_PropertyAddress, intPtr, "ForceCastSkillAfterPursuitFailed");
		ForceCastSkillAfterPursuitFailed_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceCastSkillAfterPursuitFailed");
		ForceCastSkillAfterPursuitFailed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceCastSkillAfterPursuitFailed", Classes.FBoolProperty);
		PursuitRangePos_Offset = NativeReflection.GetPropertyOffset(intPtr, "PursuitRangePos");
		PursuitRangePos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PursuitRangePos", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SpeedRateType_PropertyAddress, intPtr, "SpeedRateType");
		SpeedRateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpeedRateType");
		SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpeedRateType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MotionMatchingMoveMode_PropertyAddress, intPtr, "MotionMatchingMoveMode");
		MotionMatchingMoveMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "MotionMatchingMoveMode");
		MotionMatchingMoveMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MotionMatchingMoveMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, intPtr, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveAcceptableRadiusType_PropertyAddress, intPtr, "MoveAcceptableRadiusType");
		MoveAcceptableRadiusType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveAcceptableRadiusType");
		MoveAcceptableRadiusType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveAcceptableRadiusType", Classes.FEnumProperty);
		BeginRotateAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeginRotateAngle");
		BeginRotateAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeginRotateAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsUseSkillForTurn_PropertyAddress, intPtr, "IsUseSkillForTurn");
		IsUseSkillForTurn_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUseSkillForTurn");
		IsUseSkillForTurn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUseSkillForTurn", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsUseSkillForMove_PropertyAddress, intPtr, "IsUseSkillForMove");
		IsUseSkillForMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsUseSkillForMove");
		IsUseSkillForMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsUseSkillForMove", Classes.FBoolProperty);
		BeginMoveDistanceWhenUseSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeginMoveDistanceWhenUseSkill");
		BeginMoveDistanceWhenUseSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeginMoveDistanceWhenUseSkill", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CanCheckCastSkillDuringWholeComboWindow_PropertyAddress, intPtr, "CanCheckCastSkillDuringWholeComboWindow");
		CanCheckCastSkillDuringWholeComboWindow_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanCheckCastSkillDuringWholeComboWindow");
		CanCheckCastSkillDuringWholeComboWindow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanCheckCastSkillDuringWholeComboWindow", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableInterruptReduceCBNum_PropertyAddress, intPtr, "EnableInterruptReduceCBNum");
		EnableInterruptReduceCBNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableInterruptReduceCBNum");
		EnableInterruptReduceCBNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableInterruptReduceCBNum", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedTraceHitTargetBefore_PropertyAddress, intPtr, "NeedTraceHitTargetBefore");
		NeedTraceHitTargetBefore_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedTraceHitTargetBefore");
		NeedTraceHitTargetBefore_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedTraceHitTargetBefore", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableForceComboRelation_PropertyAddress, intPtr, "EnableForceComboRelation");
		EnableForceComboRelation_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableForceComboRelation");
		EnableForceComboRelation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableForceComboRelation", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableComboCondition_PropertyAddress, intPtr, "EnableComboCondition");
		EnableComboCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableComboCondition");
		EnableComboCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableComboCondition", Classes.FBoolProperty);
		TraceDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceDistance");
		TraceDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TraceTypeQuery_PropertyAddress, intPtr, "TraceTypeQuery");
		TraceTypeQuery_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceTypeQuery");
		TraceTypeQuery_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceTypeQuery", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsGetTopRandomSkill_PropertyAddress, intPtr, "IsGetTopRandomSkill");
		IsGetTopRandomSkill_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsGetTopRandomSkill");
		IsGetTopRandomSkill_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsGetTopRandomSkill", Classes.FBoolProperty);
		TopRandomSkillPercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "TopRandomSkillPercent");
		TopRandomSkillPercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TopRandomSkillPercent", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SkillArray_PropertyAddress, intPtr, "SkillArray");
		SkillArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillArray");
		SkillArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillArray", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IsGetAdvanceComboLength_PropertyAddress, intPtr, "IsGetAdvanceComboLength");
		IsGetAdvanceComboLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsGetAdvanceComboLength");
		IsGetAdvanceComboLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsGetAdvanceComboLength", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ComboSkillNumInfo_PropertyAddress, intPtr, "ComboSkillNumInfo");
		ComboSkillNumInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "ComboSkillNumInfo");
		ComboSkillNumInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ComboSkillNumInfo", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bCanBeForceAbort_PropertyAddress, intPtr, "bCanBeForceAbort");
		bCanBeForceAbort_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCanBeForceAbort");
		bCanBeForceAbort_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCanBeForceAbort", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCanBeInterruptedByHRCounterattack_PropertyAddress, intPtr, "bCanBeInterruptedByHRCounterattack");
		bCanBeInterruptedByHRCounterattack_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCanBeInterruptedByHRCounterattack");
		bCanBeInterruptedByHRCounterattack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCanBeInterruptedByHRCounterattack", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseSocketDirection_PropertyAddress, intPtr, "UseSocketDirection");
		UseSocketDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseSocketDirection");
		UseSocketDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseSocketDirection", Classes.FBoolProperty);
		DirectionBaseSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "DirectionBaseSocket");
		DirectionBaseSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DirectionBaseSocket", Classes.FNameProperty);
		ForwardSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForwardSocket");
		ForwardSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForwardSocket", Classes.FNameProperty);
		RightSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightSocket");
		RightSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightSocket", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SkillConfigMode_PropertyAddress, intPtr, "SkillConfigMode");
		SkillConfigMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillConfigMode");
		SkillConfigMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillConfigMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SingleDirectionSkills_PropertyAddress, intPtr, "SingleDirectionSkills");
		SingleDirectionSkills_Offset = NativeReflection.GetPropertyOffset(intPtr, "SingleDirectionSkills");
		SingleDirectionSkills_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SingleDirectionSkills", Classes.FArrayProperty);
		AvoidObstacleSectionNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "AvoidObstacleSectionNum");
		AvoidObstacleSectionNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AvoidObstacleSectionNum", Classes.FIntProperty);
		SectionsStartAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "SectionsStartAngle");
		SectionsStartAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SectionsStartAngle", Classes.FFloatProperty);
		IntervalAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "IntervalAngle");
		IntervalAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IntervalAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AvoidObstacleSections_PropertyAddress, intPtr, "AvoidObstacleSections");
		AvoidObstacleSections_Offset = NativeReflection.GetPropertyOffset(intPtr, "AvoidObstacleSections");
		AvoidObstacleSections_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AvoidObstacleSections", Classes.FArrayProperty);
		QACalcSkillArray_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "QACalcSkillArray");
		QACalcSkillArray_ParamsSize = NativeReflection.GetFunctionParamsSize(QACalcSkillArray_FunctionAddress);
		NativeReflection.GetPropertyRef(ref QACalcSkillArray_ReturnValue_PropertyAddress, QACalcSkillArray_FunctionAddress, "ReturnValue");
		QACalcSkillArray_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QACalcSkillArray_FunctionAddress, "ReturnValue");
		QACalcSkillArray_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QACalcSkillArray_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QACalcSkillArray_IsValid = QACalcSkillArray_FunctionAddress != IntPtr.Zero && QACalcSkillArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAIT_Combo:QACalcSkillArray", QACalcSkillArray_IsValid);
		QACalcTrueComboArray_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "QACalcTrueComboArray");
		QACalcTrueComboArray_ParamsSize = NativeReflection.GetFunctionParamsSize(QACalcTrueComboArray_FunctionAddress);
		NativeReflection.GetPropertyRef(ref QACalcTrueComboArray_ReturnValue_PropertyAddress, QACalcTrueComboArray_FunctionAddress, "ReturnValue");
		QACalcTrueComboArray_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QACalcTrueComboArray_FunctionAddress, "ReturnValue");
		QACalcTrueComboArray_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QACalcTrueComboArray_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		QACalcTrueComboArray_IsValid = QACalcTrueComboArray_FunctionAddress != IntPtr.Zero && QACalcTrueComboArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAIT_Combo:QACalcTrueComboArray", QACalcTrueComboArray_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAIT_Combo:OnPropertyChanged", OnPropertyChanged_IsValid);
	}

	static BAIT_Combo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAIT_Combo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAIT_Combo));
	}
}
