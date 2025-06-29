using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_Combo : IMessage<BehaviorCustom_Combo>, IMessage, IEquatable<BehaviorCustom_Combo>, IDeepCloneable<BehaviorCustom_Combo>
{
	private static readonly MessageParser<BehaviorCustom_Combo> _parser = new MessageParser<BehaviorCustom_Combo>(() => new BehaviorCustom_Combo());

	private UnknownFieldSet _unknownFields;

	private int comboTargetType_;

	private int skillSourceType_;

	private bool pursuitInAllSkill_;

	private bool pursuitAnyWhere_;

	private bool forceCastSkillAfterPursuitFailed_;

	private float pursuitRangePos_;

	private int speedRateType_;

	private int motionMatchingMoveMode_;

	private int moveAIType_;

	private int moveAcceptableRadiusType_;

	private float beginRotateAngle_;

	private bool isUseSkillForTurn_;

	private bool isUseSkillForMove_;

	private float beginMoveDistanceWhenUseSkill_;

	private bool enableInterruptReduceCBNum_;

	private bool needTraceHitTargetBefore_;

	private bool enableForceComboRelation_;

	private bool enableComboCondition_;

	private float traceDistance_;

	private int traceTypeQuery_;

	private bool isGetTopRandomSkill_;

	private int topRandomSkillPercent_;

	private static readonly FieldCodec<BehaviorCustom_ComboSkill> _repeated_skillArray_codec = FieldCodec.ForMessage(186u, BehaviorCustom_ComboSkill.Parser);

	private readonly RepeatedField<BehaviorCustom_ComboSkill> skillArray_ = new RepeatedField<BehaviorCustom_ComboSkill>();

	private bool isGetAdvanceComboLength_;

	private static readonly FieldCodec<BehaviorCustom_ComboSkillNumInfo> _repeated_comboSkillNumInfo_codec = FieldCodec.ForMessage(202u, BehaviorCustom_ComboSkillNumInfo.Parser);

	private readonly RepeatedField<BehaviorCustom_ComboSkillNumInfo> comboSkillNumInfo_ = new RepeatedField<BehaviorCustom_ComboSkillNumInfo>();

	private bool isCanBeForceAbort_;

	private bool useSocketDirection_;

	private string directionBaseSocket_ = "";

	private string forwardSocket_ = "";

	private string rightSocket_ = "";

	private int skillConfigMode_;

	private static readonly FieldCodec<int> _repeated_singleDirectionSkills_codec = FieldCodec.ForInt32(258u);

	private readonly RepeatedField<int> singleDirectionSkills_ = new RepeatedField<int>();

	private int avoidObstacleSectionNum_;

	private float sectionsStartAngle_;

	private float intervalAngle_;

	private static readonly FieldCodec<BehaviorCustom_AvoidObstacleSection> _repeated_avoidObstacleSections_codec = FieldCodec.ForMessage(290u, BehaviorCustom_AvoidObstacleSection.Parser);

	private readonly RepeatedField<BehaviorCustom_AvoidObstacleSection> avoidObstacleSections_ = new RepeatedField<BehaviorCustom_AvoidObstacleSection>();

	public static MessageParser<BehaviorCustom_Combo> Parser => _parser;

	public int ComboTargetType
	{
		get
		{
			return comboTargetType_;
		}
		set
		{
			comboTargetType_ = value;
		}
	}

	public int SkillSourceType
	{
		get
		{
			return skillSourceType_;
		}
		set
		{
			skillSourceType_ = value;
		}
	}

	public bool PursuitInAllSkill
	{
		get
		{
			return pursuitInAllSkill_;
		}
		set
		{
			pursuitInAllSkill_ = value;
		}
	}

	public bool PursuitAnyWhere
	{
		get
		{
			return pursuitAnyWhere_;
		}
		set
		{
			pursuitAnyWhere_ = value;
		}
	}

	public bool ForceCastSkillAfterPursuitFailed
	{
		get
		{
			return forceCastSkillAfterPursuitFailed_;
		}
		set
		{
			forceCastSkillAfterPursuitFailed_ = value;
		}
	}

	public float PursuitRangePos
	{
		get
		{
			return pursuitRangePos_;
		}
		set
		{
			pursuitRangePos_ = value;
		}
	}

	public int SpeedRateType
	{
		get
		{
			return speedRateType_;
		}
		set
		{
			speedRateType_ = value;
		}
	}

	public int MotionMatchingMoveMode
	{
		get
		{
			return motionMatchingMoveMode_;
		}
		set
		{
			motionMatchingMoveMode_ = value;
		}
	}

	public int MoveAIType
	{
		get
		{
			return moveAIType_;
		}
		set
		{
			moveAIType_ = value;
		}
	}

	public int MoveAcceptableRadiusType
	{
		get
		{
			return moveAcceptableRadiusType_;
		}
		set
		{
			moveAcceptableRadiusType_ = value;
		}
	}

	public float BeginRotateAngle
	{
		get
		{
			return beginRotateAngle_;
		}
		set
		{
			beginRotateAngle_ = value;
		}
	}

	public bool IsUseSkillForTurn
	{
		get
		{
			return isUseSkillForTurn_;
		}
		set
		{
			isUseSkillForTurn_ = value;
		}
	}

	public bool IsUseSkillForMove
	{
		get
		{
			return isUseSkillForMove_;
		}
		set
		{
			isUseSkillForMove_ = value;
		}
	}

	public float BeginMoveDistanceWhenUseSkill
	{
		get
		{
			return beginMoveDistanceWhenUseSkill_;
		}
		set
		{
			beginMoveDistanceWhenUseSkill_ = value;
		}
	}

	public bool EnableInterruptReduceCBNum
	{
		get
		{
			return enableInterruptReduceCBNum_;
		}
		set
		{
			enableInterruptReduceCBNum_ = value;
		}
	}

	public bool NeedTraceHitTargetBefore
	{
		get
		{
			return needTraceHitTargetBefore_;
		}
		set
		{
			needTraceHitTargetBefore_ = value;
		}
	}

	public bool EnableForceComboRelation
	{
		get
		{
			return enableForceComboRelation_;
		}
		set
		{
			enableForceComboRelation_ = value;
		}
	}

	public bool EnableComboCondition
	{
		get
		{
			return enableComboCondition_;
		}
		set
		{
			enableComboCondition_ = value;
		}
	}

	public float TraceDistance
	{
		get
		{
			return traceDistance_;
		}
		set
		{
			traceDistance_ = value;
		}
	}

	public int TraceTypeQuery
	{
		get
		{
			return traceTypeQuery_;
		}
		set
		{
			traceTypeQuery_ = value;
		}
	}

	public bool IsGetTopRandomSkill
	{
		get
		{
			return isGetTopRandomSkill_;
		}
		set
		{
			isGetTopRandomSkill_ = value;
		}
	}

	public int TopRandomSkillPercent
	{
		get
		{
			return topRandomSkillPercent_;
		}
		set
		{
			topRandomSkillPercent_ = value;
		}
	}

	public RepeatedField<BehaviorCustom_ComboSkill> SkillArray => skillArray_;

	public bool IsGetAdvanceComboLength
	{
		get
		{
			return isGetAdvanceComboLength_;
		}
		set
		{
			isGetAdvanceComboLength_ = value;
		}
	}

	public RepeatedField<BehaviorCustom_ComboSkillNumInfo> ComboSkillNumInfo => comboSkillNumInfo_;

	public bool IsCanBeForceAbort
	{
		get
		{
			return isCanBeForceAbort_;
		}
		set
		{
			isCanBeForceAbort_ = value;
		}
	}

	public bool UseSocketDirection
	{
		get
		{
			return useSocketDirection_;
		}
		set
		{
			useSocketDirection_ = value;
		}
	}

	public string DirectionBaseSocket
	{
		get
		{
			return directionBaseSocket_;
		}
		set
		{
			directionBaseSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ForwardSocket
	{
		get
		{
			return forwardSocket_;
		}
		set
		{
			forwardSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RightSocket
	{
		get
		{
			return rightSocket_;
		}
		set
		{
			rightSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SkillConfigMode
	{
		get
		{
			return skillConfigMode_;
		}
		set
		{
			skillConfigMode_ = value;
		}
	}

	public RepeatedField<int> SingleDirectionSkills => singleDirectionSkills_;

	public int AvoidObstacleSectionNum
	{
		get
		{
			return avoidObstacleSectionNum_;
		}
		set
		{
			avoidObstacleSectionNum_ = value;
		}
	}

	public float SectionsStartAngle
	{
		get
		{
			return sectionsStartAngle_;
		}
		set
		{
			sectionsStartAngle_ = value;
		}
	}

	public float IntervalAngle
	{
		get
		{
			return intervalAngle_;
		}
		set
		{
			intervalAngle_ = value;
		}
	}

	public RepeatedField<BehaviorCustom_AvoidObstacleSection> AvoidObstacleSections => avoidObstacleSections_;

	public BehaviorCustom_Combo()
	{
	}

	public BehaviorCustom_Combo(BehaviorCustom_Combo other)
		: this()
	{
		comboTargetType_ = other.comboTargetType_;
		skillSourceType_ = other.skillSourceType_;
		pursuitInAllSkill_ = other.pursuitInAllSkill_;
		pursuitAnyWhere_ = other.pursuitAnyWhere_;
		forceCastSkillAfterPursuitFailed_ = other.forceCastSkillAfterPursuitFailed_;
		pursuitRangePos_ = other.pursuitRangePos_;
		speedRateType_ = other.speedRateType_;
		motionMatchingMoveMode_ = other.motionMatchingMoveMode_;
		moveAIType_ = other.moveAIType_;
		moveAcceptableRadiusType_ = other.moveAcceptableRadiusType_;
		beginRotateAngle_ = other.beginRotateAngle_;
		isUseSkillForTurn_ = other.isUseSkillForTurn_;
		isUseSkillForMove_ = other.isUseSkillForMove_;
		beginMoveDistanceWhenUseSkill_ = other.beginMoveDistanceWhenUseSkill_;
		enableInterruptReduceCBNum_ = other.enableInterruptReduceCBNum_;
		needTraceHitTargetBefore_ = other.needTraceHitTargetBefore_;
		enableForceComboRelation_ = other.enableForceComboRelation_;
		enableComboCondition_ = other.enableComboCondition_;
		traceDistance_ = other.traceDistance_;
		traceTypeQuery_ = other.traceTypeQuery_;
		isGetTopRandomSkill_ = other.isGetTopRandomSkill_;
		topRandomSkillPercent_ = other.topRandomSkillPercent_;
		skillArray_ = other.skillArray_.Clone();
		isGetAdvanceComboLength_ = other.isGetAdvanceComboLength_;
		comboSkillNumInfo_ = other.comboSkillNumInfo_.Clone();
		isCanBeForceAbort_ = other.isCanBeForceAbort_;
		useSocketDirection_ = other.useSocketDirection_;
		directionBaseSocket_ = other.directionBaseSocket_;
		forwardSocket_ = other.forwardSocket_;
		rightSocket_ = other.rightSocket_;
		skillConfigMode_ = other.skillConfigMode_;
		singleDirectionSkills_ = other.singleDirectionSkills_.Clone();
		avoidObstacleSectionNum_ = other.avoidObstacleSectionNum_;
		sectionsStartAngle_ = other.sectionsStartAngle_;
		intervalAngle_ = other.intervalAngle_;
		avoidObstacleSections_ = other.avoidObstacleSections_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_Combo Clone()
	{
		return new BehaviorCustom_Combo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_Combo);
	}

	public bool Equals(BehaviorCustom_Combo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ComboTargetType != other.ComboTargetType)
		{
			return false;
		}
		if (SkillSourceType != other.SkillSourceType)
		{
			return false;
		}
		if (PursuitInAllSkill != other.PursuitInAllSkill)
		{
			return false;
		}
		if (PursuitAnyWhere != other.PursuitAnyWhere)
		{
			return false;
		}
		if (ForceCastSkillAfterPursuitFailed != other.ForceCastSkillAfterPursuitFailed)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PursuitRangePos, other.PursuitRangePos))
		{
			return false;
		}
		if (SpeedRateType != other.SpeedRateType)
		{
			return false;
		}
		if (MotionMatchingMoveMode != other.MotionMatchingMoveMode)
		{
			return false;
		}
		if (MoveAIType != other.MoveAIType)
		{
			return false;
		}
		if (MoveAcceptableRadiusType != other.MoveAcceptableRadiusType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BeginRotateAngle, other.BeginRotateAngle))
		{
			return false;
		}
		if (IsUseSkillForTurn != other.IsUseSkillForTurn)
		{
			return false;
		}
		if (IsUseSkillForMove != other.IsUseSkillForMove)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BeginMoveDistanceWhenUseSkill, other.BeginMoveDistanceWhenUseSkill))
		{
			return false;
		}
		if (EnableInterruptReduceCBNum != other.EnableInterruptReduceCBNum)
		{
			return false;
		}
		if (NeedTraceHitTargetBefore != other.NeedTraceHitTargetBefore)
		{
			return false;
		}
		if (EnableForceComboRelation != other.EnableForceComboRelation)
		{
			return false;
		}
		if (EnableComboCondition != other.EnableComboCondition)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TraceDistance, other.TraceDistance))
		{
			return false;
		}
		if (TraceTypeQuery != other.TraceTypeQuery)
		{
			return false;
		}
		if (IsGetTopRandomSkill != other.IsGetTopRandomSkill)
		{
			return false;
		}
		if (TopRandomSkillPercent != other.TopRandomSkillPercent)
		{
			return false;
		}
		if (!skillArray_.Equals(other.skillArray_))
		{
			return false;
		}
		if (IsGetAdvanceComboLength != other.IsGetAdvanceComboLength)
		{
			return false;
		}
		if (!comboSkillNumInfo_.Equals(other.comboSkillNumInfo_))
		{
			return false;
		}
		if (IsCanBeForceAbort != other.IsCanBeForceAbort)
		{
			return false;
		}
		if (UseSocketDirection != other.UseSocketDirection)
		{
			return false;
		}
		if (DirectionBaseSocket != other.DirectionBaseSocket)
		{
			return false;
		}
		if (ForwardSocket != other.ForwardSocket)
		{
			return false;
		}
		if (RightSocket != other.RightSocket)
		{
			return false;
		}
		if (SkillConfigMode != other.SkillConfigMode)
		{
			return false;
		}
		if (!singleDirectionSkills_.Equals(other.singleDirectionSkills_))
		{
			return false;
		}
		if (AvoidObstacleSectionNum != other.AvoidObstacleSectionNum)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SectionsStartAngle, other.SectionsStartAngle))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(IntervalAngle, other.IntervalAngle))
		{
			return false;
		}
		if (!avoidObstacleSections_.Equals(other.avoidObstacleSections_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ComboTargetType != 0)
		{
			num ^= ComboTargetType.GetHashCode();
		}
		if (SkillSourceType != 0)
		{
			num ^= SkillSourceType.GetHashCode();
		}
		if (PursuitInAllSkill)
		{
			num ^= PursuitInAllSkill.GetHashCode();
		}
		if (PursuitAnyWhere)
		{
			num ^= PursuitAnyWhere.GetHashCode();
		}
		if (ForceCastSkillAfterPursuitFailed)
		{
			num ^= ForceCastSkillAfterPursuitFailed.GetHashCode();
		}
		if (PursuitRangePos != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PursuitRangePos);
		}
		if (SpeedRateType != 0)
		{
			num ^= SpeedRateType.GetHashCode();
		}
		if (MotionMatchingMoveMode != 0)
		{
			num ^= MotionMatchingMoveMode.GetHashCode();
		}
		if (MoveAIType != 0)
		{
			num ^= MoveAIType.GetHashCode();
		}
		if (MoveAcceptableRadiusType != 0)
		{
			num ^= MoveAcceptableRadiusType.GetHashCode();
		}
		if (BeginRotateAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BeginRotateAngle);
		}
		if (IsUseSkillForTurn)
		{
			num ^= IsUseSkillForTurn.GetHashCode();
		}
		if (IsUseSkillForMove)
		{
			num ^= IsUseSkillForMove.GetHashCode();
		}
		if (BeginMoveDistanceWhenUseSkill != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BeginMoveDistanceWhenUseSkill);
		}
		if (EnableInterruptReduceCBNum)
		{
			num ^= EnableInterruptReduceCBNum.GetHashCode();
		}
		if (NeedTraceHitTargetBefore)
		{
			num ^= NeedTraceHitTargetBefore.GetHashCode();
		}
		if (EnableForceComboRelation)
		{
			num ^= EnableForceComboRelation.GetHashCode();
		}
		if (EnableComboCondition)
		{
			num ^= EnableComboCondition.GetHashCode();
		}
		if (TraceDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TraceDistance);
		}
		if (TraceTypeQuery != 0)
		{
			num ^= TraceTypeQuery.GetHashCode();
		}
		if (IsGetTopRandomSkill)
		{
			num ^= IsGetTopRandomSkill.GetHashCode();
		}
		if (TopRandomSkillPercent != 0)
		{
			num ^= TopRandomSkillPercent.GetHashCode();
		}
		num ^= skillArray_.GetHashCode();
		if (IsGetAdvanceComboLength)
		{
			num ^= IsGetAdvanceComboLength.GetHashCode();
		}
		num ^= comboSkillNumInfo_.GetHashCode();
		if (IsCanBeForceAbort)
		{
			num ^= IsCanBeForceAbort.GetHashCode();
		}
		if (UseSocketDirection)
		{
			num ^= UseSocketDirection.GetHashCode();
		}
		if (DirectionBaseSocket.Length != 0)
		{
			num ^= DirectionBaseSocket.GetHashCode();
		}
		if (ForwardSocket.Length != 0)
		{
			num ^= ForwardSocket.GetHashCode();
		}
		if (RightSocket.Length != 0)
		{
			num ^= RightSocket.GetHashCode();
		}
		if (SkillConfigMode != 0)
		{
			num ^= SkillConfigMode.GetHashCode();
		}
		num ^= singleDirectionSkills_.GetHashCode();
		if (AvoidObstacleSectionNum != 0)
		{
			num ^= AvoidObstacleSectionNum.GetHashCode();
		}
		if (SectionsStartAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SectionsStartAngle);
		}
		if (IntervalAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(IntervalAngle);
		}
		num ^= avoidObstacleSections_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ComboTargetType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ComboTargetType);
		}
		if (SkillSourceType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SkillSourceType);
		}
		if (PursuitInAllSkill)
		{
			output.WriteRawTag(24);
			output.WriteBool(PursuitInAllSkill);
		}
		if (PursuitAnyWhere)
		{
			output.WriteRawTag(32);
			output.WriteBool(PursuitAnyWhere);
		}
		if (ForceCastSkillAfterPursuitFailed)
		{
			output.WriteRawTag(40);
			output.WriteBool(ForceCastSkillAfterPursuitFailed);
		}
		if (PursuitRangePos != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(PursuitRangePos);
		}
		if (SpeedRateType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SpeedRateType);
		}
		if (MotionMatchingMoveMode != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(MotionMatchingMoveMode);
		}
		if (MoveAIType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MoveAIType);
		}
		if (MoveAcceptableRadiusType != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(MoveAcceptableRadiusType);
		}
		if (BeginRotateAngle != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(BeginRotateAngle);
		}
		if (IsUseSkillForTurn)
		{
			output.WriteRawTag(96);
			output.WriteBool(IsUseSkillForTurn);
		}
		if (IsUseSkillForMove)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsUseSkillForMove);
		}
		if (BeginMoveDistanceWhenUseSkill != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(BeginMoveDistanceWhenUseSkill);
		}
		if (EnableInterruptReduceCBNum)
		{
			output.WriteRawTag(120);
			output.WriteBool(EnableInterruptReduceCBNum);
		}
		if (NeedTraceHitTargetBefore)
		{
			output.WriteRawTag(128, 1);
			output.WriteBool(NeedTraceHitTargetBefore);
		}
		if (EnableForceComboRelation)
		{
			output.WriteRawTag(136, 1);
			output.WriteBool(EnableForceComboRelation);
		}
		if (EnableComboCondition)
		{
			output.WriteRawTag(144, 1);
			output.WriteBool(EnableComboCondition);
		}
		if (TraceDistance != 0f)
		{
			output.WriteRawTag(157, 1);
			output.WriteFloat(TraceDistance);
		}
		if (TraceTypeQuery != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(TraceTypeQuery);
		}
		if (IsGetTopRandomSkill)
		{
			output.WriteRawTag(168, 1);
			output.WriteBool(IsGetTopRandomSkill);
		}
		if (TopRandomSkillPercent != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(TopRandomSkillPercent);
		}
		skillArray_.WriteTo(output, _repeated_skillArray_codec);
		if (IsGetAdvanceComboLength)
		{
			output.WriteRawTag(192, 1);
			output.WriteBool(IsGetAdvanceComboLength);
		}
		comboSkillNumInfo_.WriteTo(output, _repeated_comboSkillNumInfo_codec);
		if (IsCanBeForceAbort)
		{
			output.WriteRawTag(208, 1);
			output.WriteBool(IsCanBeForceAbort);
		}
		if (UseSocketDirection)
		{
			output.WriteRawTag(216, 1);
			output.WriteBool(UseSocketDirection);
		}
		if (DirectionBaseSocket.Length != 0)
		{
			output.WriteRawTag(226, 1);
			output.WriteString(DirectionBaseSocket);
		}
		if (ForwardSocket.Length != 0)
		{
			output.WriteRawTag(234, 1);
			output.WriteString(ForwardSocket);
		}
		if (RightSocket.Length != 0)
		{
			output.WriteRawTag(242, 1);
			output.WriteString(RightSocket);
		}
		if (SkillConfigMode != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(SkillConfigMode);
		}
		singleDirectionSkills_.WriteTo(output, _repeated_singleDirectionSkills_codec);
		if (AvoidObstacleSectionNum != 0)
		{
			output.WriteRawTag(136, 2);
			output.WriteInt32(AvoidObstacleSectionNum);
		}
		if (SectionsStartAngle != 0f)
		{
			output.WriteRawTag(149, 2);
			output.WriteFloat(SectionsStartAngle);
		}
		if (IntervalAngle != 0f)
		{
			output.WriteRawTag(157, 2);
			output.WriteFloat(IntervalAngle);
		}
		avoidObstacleSections_.WriteTo(output, _repeated_avoidObstacleSections_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ComboTargetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ComboTargetType);
		}
		if (SkillSourceType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillSourceType);
		}
		if (PursuitInAllSkill)
		{
			num += 2;
		}
		if (PursuitAnyWhere)
		{
			num += 2;
		}
		if (ForceCastSkillAfterPursuitFailed)
		{
			num += 2;
		}
		if (PursuitRangePos != 0f)
		{
			num += 5;
		}
		if (SpeedRateType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpeedRateType);
		}
		if (MotionMatchingMoveMode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MotionMatchingMoveMode);
		}
		if (MoveAIType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MoveAIType);
		}
		if (MoveAcceptableRadiusType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MoveAcceptableRadiusType);
		}
		if (BeginRotateAngle != 0f)
		{
			num += 5;
		}
		if (IsUseSkillForTurn)
		{
			num += 2;
		}
		if (IsUseSkillForMove)
		{
			num += 2;
		}
		if (BeginMoveDistanceWhenUseSkill != 0f)
		{
			num += 5;
		}
		if (EnableInterruptReduceCBNum)
		{
			num += 2;
		}
		if (NeedTraceHitTargetBefore)
		{
			num += 3;
		}
		if (EnableForceComboRelation)
		{
			num += 3;
		}
		if (EnableComboCondition)
		{
			num += 3;
		}
		if (TraceDistance != 0f)
		{
			num += 6;
		}
		if (TraceTypeQuery != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TraceTypeQuery);
		}
		if (IsGetTopRandomSkill)
		{
			num += 3;
		}
		if (TopRandomSkillPercent != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TopRandomSkillPercent);
		}
		num += skillArray_.CalculateSize(_repeated_skillArray_codec);
		if (IsGetAdvanceComboLength)
		{
			num += 3;
		}
		num += comboSkillNumInfo_.CalculateSize(_repeated_comboSkillNumInfo_codec);
		if (IsCanBeForceAbort)
		{
			num += 3;
		}
		if (UseSocketDirection)
		{
			num += 3;
		}
		if (DirectionBaseSocket.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(DirectionBaseSocket);
		}
		if (ForwardSocket.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ForwardSocket);
		}
		if (RightSocket.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(RightSocket);
		}
		if (SkillConfigMode != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SkillConfigMode);
		}
		num += singleDirectionSkills_.CalculateSize(_repeated_singleDirectionSkills_codec);
		if (AvoidObstacleSectionNum != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AvoidObstacleSectionNum);
		}
		if (SectionsStartAngle != 0f)
		{
			num += 6;
		}
		if (IntervalAngle != 0f)
		{
			num += 6;
		}
		num += avoidObstacleSections_.CalculateSize(_repeated_avoidObstacleSections_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_Combo other)
	{
		if (other != null)
		{
			if (other.ComboTargetType != 0)
			{
				ComboTargetType = other.ComboTargetType;
			}
			if (other.SkillSourceType != 0)
			{
				SkillSourceType = other.SkillSourceType;
			}
			if (other.PursuitInAllSkill)
			{
				PursuitInAllSkill = other.PursuitInAllSkill;
			}
			if (other.PursuitAnyWhere)
			{
				PursuitAnyWhere = other.PursuitAnyWhere;
			}
			if (other.ForceCastSkillAfterPursuitFailed)
			{
				ForceCastSkillAfterPursuitFailed = other.ForceCastSkillAfterPursuitFailed;
			}
			if (other.PursuitRangePos != 0f)
			{
				PursuitRangePos = other.PursuitRangePos;
			}
			if (other.SpeedRateType != 0)
			{
				SpeedRateType = other.SpeedRateType;
			}
			if (other.MotionMatchingMoveMode != 0)
			{
				MotionMatchingMoveMode = other.MotionMatchingMoveMode;
			}
			if (other.MoveAIType != 0)
			{
				MoveAIType = other.MoveAIType;
			}
			if (other.MoveAcceptableRadiusType != 0)
			{
				MoveAcceptableRadiusType = other.MoveAcceptableRadiusType;
			}
			if (other.BeginRotateAngle != 0f)
			{
				BeginRotateAngle = other.BeginRotateAngle;
			}
			if (other.IsUseSkillForTurn)
			{
				IsUseSkillForTurn = other.IsUseSkillForTurn;
			}
			if (other.IsUseSkillForMove)
			{
				IsUseSkillForMove = other.IsUseSkillForMove;
			}
			if (other.BeginMoveDistanceWhenUseSkill != 0f)
			{
				BeginMoveDistanceWhenUseSkill = other.BeginMoveDistanceWhenUseSkill;
			}
			if (other.EnableInterruptReduceCBNum)
			{
				EnableInterruptReduceCBNum = other.EnableInterruptReduceCBNum;
			}
			if (other.NeedTraceHitTargetBefore)
			{
				NeedTraceHitTargetBefore = other.NeedTraceHitTargetBefore;
			}
			if (other.EnableForceComboRelation)
			{
				EnableForceComboRelation = other.EnableForceComboRelation;
			}
			if (other.EnableComboCondition)
			{
				EnableComboCondition = other.EnableComboCondition;
			}
			if (other.TraceDistance != 0f)
			{
				TraceDistance = other.TraceDistance;
			}
			if (other.TraceTypeQuery != 0)
			{
				TraceTypeQuery = other.TraceTypeQuery;
			}
			if (other.IsGetTopRandomSkill)
			{
				IsGetTopRandomSkill = other.IsGetTopRandomSkill;
			}
			if (other.TopRandomSkillPercent != 0)
			{
				TopRandomSkillPercent = other.TopRandomSkillPercent;
			}
			skillArray_.Add(other.skillArray_);
			if (other.IsGetAdvanceComboLength)
			{
				IsGetAdvanceComboLength = other.IsGetAdvanceComboLength;
			}
			comboSkillNumInfo_.Add(other.comboSkillNumInfo_);
			if (other.IsCanBeForceAbort)
			{
				IsCanBeForceAbort = other.IsCanBeForceAbort;
			}
			if (other.UseSocketDirection)
			{
				UseSocketDirection = other.UseSocketDirection;
			}
			if (other.DirectionBaseSocket.Length != 0)
			{
				DirectionBaseSocket = other.DirectionBaseSocket;
			}
			if (other.ForwardSocket.Length != 0)
			{
				ForwardSocket = other.ForwardSocket;
			}
			if (other.RightSocket.Length != 0)
			{
				RightSocket = other.RightSocket;
			}
			if (other.SkillConfigMode != 0)
			{
				SkillConfigMode = other.SkillConfigMode;
			}
			singleDirectionSkills_.Add(other.singleDirectionSkills_);
			if (other.AvoidObstacleSectionNum != 0)
			{
				AvoidObstacleSectionNum = other.AvoidObstacleSectionNum;
			}
			if (other.SectionsStartAngle != 0f)
			{
				SectionsStartAngle = other.SectionsStartAngle;
			}
			if (other.IntervalAngle != 0f)
			{
				IntervalAngle = other.IntervalAngle;
			}
			avoidObstacleSections_.Add(other.avoidObstacleSections_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				ComboTargetType = input.ReadInt32();
				break;
			case 16u:
				SkillSourceType = input.ReadInt32();
				break;
			case 24u:
				PursuitInAllSkill = input.ReadBool();
				break;
			case 32u:
				PursuitAnyWhere = input.ReadBool();
				break;
			case 40u:
				ForceCastSkillAfterPursuitFailed = input.ReadBool();
				break;
			case 53u:
				PursuitRangePos = input.ReadFloat();
				break;
			case 56u:
				SpeedRateType = input.ReadInt32();
				break;
			case 64u:
				MotionMatchingMoveMode = input.ReadInt32();
				break;
			case 72u:
				MoveAIType = input.ReadInt32();
				break;
			case 80u:
				MoveAcceptableRadiusType = input.ReadInt32();
				break;
			case 93u:
				BeginRotateAngle = input.ReadFloat();
				break;
			case 96u:
				IsUseSkillForTurn = input.ReadBool();
				break;
			case 104u:
				IsUseSkillForMove = input.ReadBool();
				break;
			case 117u:
				BeginMoveDistanceWhenUseSkill = input.ReadFloat();
				break;
			case 120u:
				EnableInterruptReduceCBNum = input.ReadBool();
				break;
			case 128u:
				NeedTraceHitTargetBefore = input.ReadBool();
				break;
			case 136u:
				EnableForceComboRelation = input.ReadBool();
				break;
			case 144u:
				EnableComboCondition = input.ReadBool();
				break;
			case 157u:
				TraceDistance = input.ReadFloat();
				break;
			case 160u:
				TraceTypeQuery = input.ReadInt32();
				break;
			case 168u:
				IsGetTopRandomSkill = input.ReadBool();
				break;
			case 176u:
				TopRandomSkillPercent = input.ReadInt32();
				break;
			case 186u:
				skillArray_.AddEntriesFrom(input, _repeated_skillArray_codec);
				break;
			case 192u:
				IsGetAdvanceComboLength = input.ReadBool();
				break;
			case 202u:
				comboSkillNumInfo_.AddEntriesFrom(input, _repeated_comboSkillNumInfo_codec);
				break;
			case 208u:
				IsCanBeForceAbort = input.ReadBool();
				break;
			case 216u:
				UseSocketDirection = input.ReadBool();
				break;
			case 226u:
				DirectionBaseSocket = input.ReadString();
				break;
			case 234u:
				ForwardSocket = input.ReadString();
				break;
			case 242u:
				RightSocket = input.ReadString();
				break;
			case 248u:
				SkillConfigMode = input.ReadInt32();
				break;
			case 256u:
			case 258u:
				singleDirectionSkills_.AddEntriesFrom(input, _repeated_singleDirectionSkills_codec);
				break;
			case 264u:
				AvoidObstacleSectionNum = input.ReadInt32();
				break;
			case 277u:
				SectionsStartAngle = input.ReadFloat();
				break;
			case 285u:
				IntervalAngle = input.ReadFloat();
				break;
			case 290u:
				avoidObstacleSections_.AddEntriesFrom(input, _repeated_avoidObstacleSections_codec);
				break;
			}
		}
	}
}
