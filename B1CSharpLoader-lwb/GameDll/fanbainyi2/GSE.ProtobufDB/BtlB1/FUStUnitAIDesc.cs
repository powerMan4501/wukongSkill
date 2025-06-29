using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStUnitAIDesc : IMessage<FUStUnitAIDesc>, IMessage, IEquatable<FUStUnitAIDesc>, IDeepCloneable<FUStUnitAIDesc>
{
	private static readonly MessageParser<FUStUnitAIDesc> _parser = new MessageParser<FUStUnitAIDesc>(() => new FUStUnitAIDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EUnitAIAttackType unitAIAttackType_;

	private EFsmSolverType fsmSolverType_;

	private EGSYesNo isSkipOnFightWhenBeAttack_;

	private float defaultAIWatchTimeMin_;

	private float defaultAIWatchTimeMax_;

	private EGSYesNo isBeHitResetAIWatchTime_;

	private float pursuitRange_;

	private EUnitAIDetourCrowdType detourCrowdType_;

	private float hearRange_;

	private EGSYesNo enableLoSVisualization_;

	private float sightRange_;

	private float visionAngleDegrees_;

	private EGSYesNo isUseMultipointLock_;

	private float multipointLockMaxAngle_;

	private float multipointLockDistanceScoreRatingMin_;

	private float multipointLockDistanceScoreRatingMax_;

	private int defaultLeftSmallTurnSkillID_;

	private int defaultRightSmallTurnSkillID_;

	private int defaultLeftBigTurnSkillID_;

	private int defaultRightBigTurnSkillID_;

	private int defaultLeftSmallMoveSkillID_;

	private int defaultRightSmallMoveSkillID_;

	private int defaultLeftBigMoveSkillID_;

	private int defaultRightBigMoveSkillID_;

	private int hatredTargetRandomSelectNum_;

	private EGSYesNo canSearchTargetWhenSetTeamID_;

	private EFsmStateLogicTriggerType gazeAndSurroundTriggerType_;

	private EFsmMoveLogicType gazeAndSurroundMoveType_;

	private string gazeAndSurroundEQSPath_ = "";

	private EFsmStateLogicTriggerType stalemateTriggerType_;

	private EFsmMoveLogicType stalemateMoveType_;

	private EFsmStateLogicTriggerType returnHomeTriggerType_;

	private EFsmMoveLogicType returnHomeMoveType_;

	private int returnHomeSkill_;

	private int returnHomeBuff_;

	private float strongPerceptionDistance_;

	private EGSYesNo canEffectPlayerBattleState_;

	private string guard_ = "";

	public static MessageParser<FUStUnitAIDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public EUnitAIAttackType UnitAIAttackType
	{
		get
		{
			return unitAIAttackType_;
		}
		set
		{
			unitAIAttackType_ = value;
		}
	}

	public EFsmSolverType FsmSolverType
	{
		get
		{
			return fsmSolverType_;
		}
		set
		{
			fsmSolverType_ = value;
		}
	}

	public EGSYesNo IsSkipOnFightWhenBeAttack
	{
		get
		{
			return isSkipOnFightWhenBeAttack_;
		}
		set
		{
			isSkipOnFightWhenBeAttack_ = value;
		}
	}

	public float DefaultAIWatchTimeMin
	{
		get
		{
			return defaultAIWatchTimeMin_;
		}
		set
		{
			defaultAIWatchTimeMin_ = value;
		}
	}

	public float DefaultAIWatchTimeMax
	{
		get
		{
			return defaultAIWatchTimeMax_;
		}
		set
		{
			defaultAIWatchTimeMax_ = value;
		}
	}

	public EGSYesNo IsBeHitResetAIWatchTime
	{
		get
		{
			return isBeHitResetAIWatchTime_;
		}
		set
		{
			isBeHitResetAIWatchTime_ = value;
		}
	}

	public float PursuitRange
	{
		get
		{
			return pursuitRange_;
		}
		set
		{
			pursuitRange_ = value;
		}
	}

	public EUnitAIDetourCrowdType DetourCrowdType
	{
		get
		{
			return detourCrowdType_;
		}
		set
		{
			detourCrowdType_ = value;
		}
	}

	public float HearRange
	{
		get
		{
			return hearRange_;
		}
		set
		{
			hearRange_ = value;
		}
	}

	public EGSYesNo EnableLoSVisualization
	{
		get
		{
			return enableLoSVisualization_;
		}
		set
		{
			enableLoSVisualization_ = value;
		}
	}

	public float SightRange
	{
		get
		{
			return sightRange_;
		}
		set
		{
			sightRange_ = value;
		}
	}

	public float VisionAngleDegrees
	{
		get
		{
			return visionAngleDegrees_;
		}
		set
		{
			visionAngleDegrees_ = value;
		}
	}

	public EGSYesNo IsUseMultipointLock
	{
		get
		{
			return isUseMultipointLock_;
		}
		set
		{
			isUseMultipointLock_ = value;
		}
	}

	public float MultipointLockMaxAngle
	{
		get
		{
			return multipointLockMaxAngle_;
		}
		set
		{
			multipointLockMaxAngle_ = value;
		}
	}

	public float MultipointLockDistanceScoreRatingMin
	{
		get
		{
			return multipointLockDistanceScoreRatingMin_;
		}
		set
		{
			multipointLockDistanceScoreRatingMin_ = value;
		}
	}

	public float MultipointLockDistanceScoreRatingMax
	{
		get
		{
			return multipointLockDistanceScoreRatingMax_;
		}
		set
		{
			multipointLockDistanceScoreRatingMax_ = value;
		}
	}

	public int DefaultLeftSmallTurnSkillID
	{
		get
		{
			return defaultLeftSmallTurnSkillID_;
		}
		set
		{
			defaultLeftSmallTurnSkillID_ = value;
		}
	}

	public int DefaultRightSmallTurnSkillID
	{
		get
		{
			return defaultRightSmallTurnSkillID_;
		}
		set
		{
			defaultRightSmallTurnSkillID_ = value;
		}
	}

	public int DefaultLeftBigTurnSkillID
	{
		get
		{
			return defaultLeftBigTurnSkillID_;
		}
		set
		{
			defaultLeftBigTurnSkillID_ = value;
		}
	}

	public int DefaultRightBigTurnSkillID
	{
		get
		{
			return defaultRightBigTurnSkillID_;
		}
		set
		{
			defaultRightBigTurnSkillID_ = value;
		}
	}

	public int DefaultLeftSmallMoveSkillID
	{
		get
		{
			return defaultLeftSmallMoveSkillID_;
		}
		set
		{
			defaultLeftSmallMoveSkillID_ = value;
		}
	}

	public int DefaultRightSmallMoveSkillID
	{
		get
		{
			return defaultRightSmallMoveSkillID_;
		}
		set
		{
			defaultRightSmallMoveSkillID_ = value;
		}
	}

	public int DefaultLeftBigMoveSkillID
	{
		get
		{
			return defaultLeftBigMoveSkillID_;
		}
		set
		{
			defaultLeftBigMoveSkillID_ = value;
		}
	}

	public int DefaultRightBigMoveSkillID
	{
		get
		{
			return defaultRightBigMoveSkillID_;
		}
		set
		{
			defaultRightBigMoveSkillID_ = value;
		}
	}

	public int HatredTargetRandomSelectNum
	{
		get
		{
			return hatredTargetRandomSelectNum_;
		}
		set
		{
			hatredTargetRandomSelectNum_ = value;
		}
	}

	public EGSYesNo CanSearchTargetWhenSetTeamID
	{
		get
		{
			return canSearchTargetWhenSetTeamID_;
		}
		set
		{
			canSearchTargetWhenSetTeamID_ = value;
		}
	}

	public EFsmStateLogicTriggerType GazeAndSurroundTriggerType
	{
		get
		{
			return gazeAndSurroundTriggerType_;
		}
		set
		{
			gazeAndSurroundTriggerType_ = value;
		}
	}

	public EFsmMoveLogicType GazeAndSurroundMoveType
	{
		get
		{
			return gazeAndSurroundMoveType_;
		}
		set
		{
			gazeAndSurroundMoveType_ = value;
		}
	}

	public string GazeAndSurroundEQSPath
	{
		get
		{
			return gazeAndSurroundEQSPath_;
		}
		set
		{
			gazeAndSurroundEQSPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EFsmStateLogicTriggerType StalemateTriggerType
	{
		get
		{
			return stalemateTriggerType_;
		}
		set
		{
			stalemateTriggerType_ = value;
		}
	}

	public EFsmMoveLogicType StalemateMoveType
	{
		get
		{
			return stalemateMoveType_;
		}
		set
		{
			stalemateMoveType_ = value;
		}
	}

	public EFsmStateLogicTriggerType ReturnHomeTriggerType
	{
		get
		{
			return returnHomeTriggerType_;
		}
		set
		{
			returnHomeTriggerType_ = value;
		}
	}

	public EFsmMoveLogicType ReturnHomeMoveType
	{
		get
		{
			return returnHomeMoveType_;
		}
		set
		{
			returnHomeMoveType_ = value;
		}
	}

	public int ReturnHomeSkill
	{
		get
		{
			return returnHomeSkill_;
		}
		set
		{
			returnHomeSkill_ = value;
		}
	}

	public int ReturnHomeBuff
	{
		get
		{
			return returnHomeBuff_;
		}
		set
		{
			returnHomeBuff_ = value;
		}
	}

	public float StrongPerceptionDistance
	{
		get
		{
			return strongPerceptionDistance_;
		}
		set
		{
			strongPerceptionDistance_ = value;
		}
	}

	public EGSYesNo CanEffectPlayerBattleState
	{
		get
		{
			return canEffectPlayerBattleState_;
		}
		set
		{
			canEffectPlayerBattleState_ = value;
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStUnitAIDesc()
	{
	}

	public FUStUnitAIDesc(FUStUnitAIDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitAIAttackType_ = other.unitAIAttackType_;
		fsmSolverType_ = other.fsmSolverType_;
		isSkipOnFightWhenBeAttack_ = other.isSkipOnFightWhenBeAttack_;
		defaultAIWatchTimeMin_ = other.defaultAIWatchTimeMin_;
		defaultAIWatchTimeMax_ = other.defaultAIWatchTimeMax_;
		isBeHitResetAIWatchTime_ = other.isBeHitResetAIWatchTime_;
		pursuitRange_ = other.pursuitRange_;
		detourCrowdType_ = other.detourCrowdType_;
		hearRange_ = other.hearRange_;
		enableLoSVisualization_ = other.enableLoSVisualization_;
		sightRange_ = other.sightRange_;
		visionAngleDegrees_ = other.visionAngleDegrees_;
		isUseMultipointLock_ = other.isUseMultipointLock_;
		multipointLockMaxAngle_ = other.multipointLockMaxAngle_;
		multipointLockDistanceScoreRatingMin_ = other.multipointLockDistanceScoreRatingMin_;
		multipointLockDistanceScoreRatingMax_ = other.multipointLockDistanceScoreRatingMax_;
		defaultLeftSmallTurnSkillID_ = other.defaultLeftSmallTurnSkillID_;
		defaultRightSmallTurnSkillID_ = other.defaultRightSmallTurnSkillID_;
		defaultLeftBigTurnSkillID_ = other.defaultLeftBigTurnSkillID_;
		defaultRightBigTurnSkillID_ = other.defaultRightBigTurnSkillID_;
		defaultLeftSmallMoveSkillID_ = other.defaultLeftSmallMoveSkillID_;
		defaultRightSmallMoveSkillID_ = other.defaultRightSmallMoveSkillID_;
		defaultLeftBigMoveSkillID_ = other.defaultLeftBigMoveSkillID_;
		defaultRightBigMoveSkillID_ = other.defaultRightBigMoveSkillID_;
		hatredTargetRandomSelectNum_ = other.hatredTargetRandomSelectNum_;
		canSearchTargetWhenSetTeamID_ = other.canSearchTargetWhenSetTeamID_;
		gazeAndSurroundTriggerType_ = other.gazeAndSurroundTriggerType_;
		gazeAndSurroundMoveType_ = other.gazeAndSurroundMoveType_;
		gazeAndSurroundEQSPath_ = other.gazeAndSurroundEQSPath_;
		stalemateTriggerType_ = other.stalemateTriggerType_;
		stalemateMoveType_ = other.stalemateMoveType_;
		returnHomeTriggerType_ = other.returnHomeTriggerType_;
		returnHomeMoveType_ = other.returnHomeMoveType_;
		returnHomeSkill_ = other.returnHomeSkill_;
		returnHomeBuff_ = other.returnHomeBuff_;
		strongPerceptionDistance_ = other.strongPerceptionDistance_;
		canEffectPlayerBattleState_ = other.canEffectPlayerBattleState_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitAIDesc Clone()
	{
		return new FUStUnitAIDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitAIDesc);
	}

	public bool Equals(FUStUnitAIDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (UnitAIAttackType != other.UnitAIAttackType)
		{
			return false;
		}
		if (FsmSolverType != other.FsmSolverType)
		{
			return false;
		}
		if (IsSkipOnFightWhenBeAttack != other.IsSkipOnFightWhenBeAttack)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DefaultAIWatchTimeMin, other.DefaultAIWatchTimeMin))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DefaultAIWatchTimeMax, other.DefaultAIWatchTimeMax))
		{
			return false;
		}
		if (IsBeHitResetAIWatchTime != other.IsBeHitResetAIWatchTime)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PursuitRange, other.PursuitRange))
		{
			return false;
		}
		if (DetourCrowdType != other.DetourCrowdType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HearRange, other.HearRange))
		{
			return false;
		}
		if (EnableLoSVisualization != other.EnableLoSVisualization)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SightRange, other.SightRange))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(VisionAngleDegrees, other.VisionAngleDegrees))
		{
			return false;
		}
		if (IsUseMultipointLock != other.IsUseMultipointLock)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MultipointLockMaxAngle, other.MultipointLockMaxAngle))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MultipointLockDistanceScoreRatingMin, other.MultipointLockDistanceScoreRatingMin))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MultipointLockDistanceScoreRatingMax, other.MultipointLockDistanceScoreRatingMax))
		{
			return false;
		}
		if (DefaultLeftSmallTurnSkillID != other.DefaultLeftSmallTurnSkillID)
		{
			return false;
		}
		if (DefaultRightSmallTurnSkillID != other.DefaultRightSmallTurnSkillID)
		{
			return false;
		}
		if (DefaultLeftBigTurnSkillID != other.DefaultLeftBigTurnSkillID)
		{
			return false;
		}
		if (DefaultRightBigTurnSkillID != other.DefaultRightBigTurnSkillID)
		{
			return false;
		}
		if (DefaultLeftSmallMoveSkillID != other.DefaultLeftSmallMoveSkillID)
		{
			return false;
		}
		if (DefaultRightSmallMoveSkillID != other.DefaultRightSmallMoveSkillID)
		{
			return false;
		}
		if (DefaultLeftBigMoveSkillID != other.DefaultLeftBigMoveSkillID)
		{
			return false;
		}
		if (DefaultRightBigMoveSkillID != other.DefaultRightBigMoveSkillID)
		{
			return false;
		}
		if (HatredTargetRandomSelectNum != other.HatredTargetRandomSelectNum)
		{
			return false;
		}
		if (CanSearchTargetWhenSetTeamID != other.CanSearchTargetWhenSetTeamID)
		{
			return false;
		}
		if (GazeAndSurroundTriggerType != other.GazeAndSurroundTriggerType)
		{
			return false;
		}
		if (GazeAndSurroundMoveType != other.GazeAndSurroundMoveType)
		{
			return false;
		}
		if (GazeAndSurroundEQSPath != other.GazeAndSurroundEQSPath)
		{
			return false;
		}
		if (StalemateTriggerType != other.StalemateTriggerType)
		{
			return false;
		}
		if (StalemateMoveType != other.StalemateMoveType)
		{
			return false;
		}
		if (ReturnHomeTriggerType != other.ReturnHomeTriggerType)
		{
			return false;
		}
		if (ReturnHomeMoveType != other.ReturnHomeMoveType)
		{
			return false;
		}
		if (ReturnHomeSkill != other.ReturnHomeSkill)
		{
			return false;
		}
		if (ReturnHomeBuff != other.ReturnHomeBuff)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StrongPerceptionDistance, other.StrongPerceptionDistance))
		{
			return false;
		}
		if (CanEffectPlayerBattleState != other.CanEffectPlayerBattleState)
		{
			return false;
		}
		if (Guard != other.Guard)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (UnitAIAttackType != EUnitAIAttackType.ActiveAttack)
		{
			num ^= UnitAIAttackType.GetHashCode();
		}
		if (FsmSolverType != EFsmSolverType.Normal)
		{
			num ^= FsmSolverType.GetHashCode();
		}
		if (IsSkipOnFightWhenBeAttack != EGSYesNo.No)
		{
			num ^= IsSkipOnFightWhenBeAttack.GetHashCode();
		}
		if (DefaultAIWatchTimeMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DefaultAIWatchTimeMin);
		}
		if (DefaultAIWatchTimeMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DefaultAIWatchTimeMax);
		}
		if (IsBeHitResetAIWatchTime != EGSYesNo.No)
		{
			num ^= IsBeHitResetAIWatchTime.GetHashCode();
		}
		if (PursuitRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PursuitRange);
		}
		if (DetourCrowdType != EUnitAIDetourCrowdType.None)
		{
			num ^= DetourCrowdType.GetHashCode();
		}
		if (HearRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HearRange);
		}
		if (EnableLoSVisualization != EGSYesNo.No)
		{
			num ^= EnableLoSVisualization.GetHashCode();
		}
		if (SightRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SightRange);
		}
		if (VisionAngleDegrees != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(VisionAngleDegrees);
		}
		if (IsUseMultipointLock != EGSYesNo.No)
		{
			num ^= IsUseMultipointLock.GetHashCode();
		}
		if (MultipointLockMaxAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MultipointLockMaxAngle);
		}
		if (MultipointLockDistanceScoreRatingMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MultipointLockDistanceScoreRatingMin);
		}
		if (MultipointLockDistanceScoreRatingMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MultipointLockDistanceScoreRatingMax);
		}
		if (DefaultLeftSmallTurnSkillID != 0)
		{
			num ^= DefaultLeftSmallTurnSkillID.GetHashCode();
		}
		if (DefaultRightSmallTurnSkillID != 0)
		{
			num ^= DefaultRightSmallTurnSkillID.GetHashCode();
		}
		if (DefaultLeftBigTurnSkillID != 0)
		{
			num ^= DefaultLeftBigTurnSkillID.GetHashCode();
		}
		if (DefaultRightBigTurnSkillID != 0)
		{
			num ^= DefaultRightBigTurnSkillID.GetHashCode();
		}
		if (DefaultLeftSmallMoveSkillID != 0)
		{
			num ^= DefaultLeftSmallMoveSkillID.GetHashCode();
		}
		if (DefaultRightSmallMoveSkillID != 0)
		{
			num ^= DefaultRightSmallMoveSkillID.GetHashCode();
		}
		if (DefaultLeftBigMoveSkillID != 0)
		{
			num ^= DefaultLeftBigMoveSkillID.GetHashCode();
		}
		if (DefaultRightBigMoveSkillID != 0)
		{
			num ^= DefaultRightBigMoveSkillID.GetHashCode();
		}
		if (HatredTargetRandomSelectNum != 0)
		{
			num ^= HatredTargetRandomSelectNum.GetHashCode();
		}
		if (CanSearchTargetWhenSetTeamID != EGSYesNo.No)
		{
			num ^= CanSearchTargetWhenSetTeamID.GetHashCode();
		}
		if (GazeAndSurroundTriggerType != EFsmStateLogicTriggerType.Auto)
		{
			num ^= GazeAndSurroundTriggerType.GetHashCode();
		}
		if (GazeAndSurroundMoveType != EFsmMoveLogicType.Auto)
		{
			num ^= GazeAndSurroundMoveType.GetHashCode();
		}
		if (GazeAndSurroundEQSPath.Length != 0)
		{
			num ^= GazeAndSurroundEQSPath.GetHashCode();
		}
		if (StalemateTriggerType != EFsmStateLogicTriggerType.Auto)
		{
			num ^= StalemateTriggerType.GetHashCode();
		}
		if (StalemateMoveType != EFsmMoveLogicType.Auto)
		{
			num ^= StalemateMoveType.GetHashCode();
		}
		if (ReturnHomeTriggerType != EFsmStateLogicTriggerType.Auto)
		{
			num ^= ReturnHomeTriggerType.GetHashCode();
		}
		if (ReturnHomeMoveType != EFsmMoveLogicType.Auto)
		{
			num ^= ReturnHomeMoveType.GetHashCode();
		}
		if (ReturnHomeSkill != 0)
		{
			num ^= ReturnHomeSkill.GetHashCode();
		}
		if (ReturnHomeBuff != 0)
		{
			num ^= ReturnHomeBuff.GetHashCode();
		}
		if (StrongPerceptionDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StrongPerceptionDistance);
		}
		if (CanEffectPlayerBattleState != EGSYesNo.No)
		{
			num ^= CanEffectPlayerBattleState.GetHashCode();
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (UnitAIAttackType != EUnitAIAttackType.ActiveAttack)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)UnitAIAttackType);
		}
		if (FsmSolverType != EFsmSolverType.Normal)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)FsmSolverType);
		}
		if (IsSkipOnFightWhenBeAttack != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)IsSkipOnFightWhenBeAttack);
		}
		if (DefaultAIWatchTimeMin != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(DefaultAIWatchTimeMin);
		}
		if (DefaultAIWatchTimeMax != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(DefaultAIWatchTimeMax);
		}
		if (IsBeHitResetAIWatchTime != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)IsBeHitResetAIWatchTime);
		}
		if (PursuitRange != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(PursuitRange);
		}
		if (DetourCrowdType != EUnitAIDetourCrowdType.None)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)DetourCrowdType);
		}
		if (HearRange != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(HearRange);
		}
		if (EnableLoSVisualization != EGSYesNo.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)EnableLoSVisualization);
		}
		if (SightRange != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(SightRange);
		}
		if (VisionAngleDegrees != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(VisionAngleDegrees);
		}
		if (IsUseMultipointLock != EGSYesNo.No)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)IsUseMultipointLock);
		}
		if (MultipointLockMaxAngle != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(MultipointLockMaxAngle);
		}
		if (MultipointLockDistanceScoreRatingMin != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(MultipointLockDistanceScoreRatingMin);
		}
		if (MultipointLockDistanceScoreRatingMax != 0f)
		{
			output.WriteRawTag(141, 1);
			output.WriteFloat(MultipointLockDistanceScoreRatingMax);
		}
		if (DefaultLeftSmallTurnSkillID != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(DefaultLeftSmallTurnSkillID);
		}
		if (DefaultRightSmallTurnSkillID != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(DefaultRightSmallTurnSkillID);
		}
		if (DefaultLeftBigTurnSkillID != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(DefaultLeftBigTurnSkillID);
		}
		if (DefaultRightBigTurnSkillID != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(DefaultRightBigTurnSkillID);
		}
		if (DefaultLeftSmallMoveSkillID != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(DefaultLeftSmallMoveSkillID);
		}
		if (DefaultRightSmallMoveSkillID != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(DefaultRightSmallMoveSkillID);
		}
		if (DefaultLeftBigMoveSkillID != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(DefaultLeftBigMoveSkillID);
		}
		if (DefaultRightBigMoveSkillID != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(DefaultRightBigMoveSkillID);
		}
		if (HatredTargetRandomSelectNum != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(HatredTargetRandomSelectNum);
		}
		if (CanSearchTargetWhenSetTeamID != EGSYesNo.No)
		{
			output.WriteRawTag(216, 1);
			output.WriteEnum((int)CanSearchTargetWhenSetTeamID);
		}
		if (GazeAndSurroundTriggerType != EFsmStateLogicTriggerType.Auto)
		{
			output.WriteRawTag(224, 1);
			output.WriteEnum((int)GazeAndSurroundTriggerType);
		}
		if (GazeAndSurroundMoveType != EFsmMoveLogicType.Auto)
		{
			output.WriteRawTag(232, 1);
			output.WriteEnum((int)GazeAndSurroundMoveType);
		}
		if (GazeAndSurroundEQSPath.Length != 0)
		{
			output.WriteRawTag(242, 1);
			output.WriteString(GazeAndSurroundEQSPath);
		}
		if (StalemateTriggerType != EFsmStateLogicTriggerType.Auto)
		{
			output.WriteRawTag(248, 1);
			output.WriteEnum((int)StalemateTriggerType);
		}
		if (StalemateMoveType != EFsmMoveLogicType.Auto)
		{
			output.WriteRawTag(128, 2);
			output.WriteEnum((int)StalemateMoveType);
		}
		if (ReturnHomeTriggerType != EFsmStateLogicTriggerType.Auto)
		{
			output.WriteRawTag(136, 2);
			output.WriteEnum((int)ReturnHomeTriggerType);
		}
		if (ReturnHomeMoveType != EFsmMoveLogicType.Auto)
		{
			output.WriteRawTag(144, 2);
			output.WriteEnum((int)ReturnHomeMoveType);
		}
		if (ReturnHomeSkill != 0)
		{
			output.WriteRawTag(152, 2);
			output.WriteInt32(ReturnHomeSkill);
		}
		if (ReturnHomeBuff != 0)
		{
			output.WriteRawTag(160, 2);
			output.WriteInt32(ReturnHomeBuff);
		}
		if (StrongPerceptionDistance != 0f)
		{
			output.WriteRawTag(173, 2);
			output.WriteFloat(StrongPerceptionDistance);
		}
		if (CanEffectPlayerBattleState != EGSYesNo.No)
		{
			output.WriteRawTag(176, 2);
			output.WriteEnum((int)CanEffectPlayerBattleState);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(186, 2);
			output.WriteString(Guard);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (UnitAIAttackType != EUnitAIAttackType.ActiveAttack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnitAIAttackType);
		}
		if (FsmSolverType != EFsmSolverType.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FsmSolverType);
		}
		if (IsSkipOnFightWhenBeAttack != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsSkipOnFightWhenBeAttack);
		}
		if (DefaultAIWatchTimeMin != 0f)
		{
			num += 5;
		}
		if (DefaultAIWatchTimeMax != 0f)
		{
			num += 5;
		}
		if (IsBeHitResetAIWatchTime != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsBeHitResetAIWatchTime);
		}
		if (PursuitRange != 0f)
		{
			num += 5;
		}
		if (DetourCrowdType != EUnitAIDetourCrowdType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DetourCrowdType);
		}
		if (HearRange != 0f)
		{
			num += 5;
		}
		if (EnableLoSVisualization != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EnableLoSVisualization);
		}
		if (SightRange != 0f)
		{
			num += 5;
		}
		if (VisionAngleDegrees != 0f)
		{
			num += 5;
		}
		if (IsUseMultipointLock != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsUseMultipointLock);
		}
		if (MultipointLockMaxAngle != 0f)
		{
			num += 5;
		}
		if (MultipointLockDistanceScoreRatingMin != 0f)
		{
			num += 6;
		}
		if (MultipointLockDistanceScoreRatingMax != 0f)
		{
			num += 6;
		}
		if (DefaultLeftSmallTurnSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultLeftSmallTurnSkillID);
		}
		if (DefaultRightSmallTurnSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultRightSmallTurnSkillID);
		}
		if (DefaultLeftBigTurnSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultLeftBigTurnSkillID);
		}
		if (DefaultRightBigTurnSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultRightBigTurnSkillID);
		}
		if (DefaultLeftSmallMoveSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultLeftSmallMoveSkillID);
		}
		if (DefaultRightSmallMoveSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultRightSmallMoveSkillID);
		}
		if (DefaultLeftBigMoveSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultLeftBigMoveSkillID);
		}
		if (DefaultRightBigMoveSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DefaultRightBigMoveSkillID);
		}
		if (HatredTargetRandomSelectNum != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(HatredTargetRandomSelectNum);
		}
		if (CanSearchTargetWhenSetTeamID != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CanSearchTargetWhenSetTeamID);
		}
		if (GazeAndSurroundTriggerType != EFsmStateLogicTriggerType.Auto)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)GazeAndSurroundTriggerType);
		}
		if (GazeAndSurroundMoveType != EFsmMoveLogicType.Auto)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)GazeAndSurroundMoveType);
		}
		if (GazeAndSurroundEQSPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(GazeAndSurroundEQSPath);
		}
		if (StalemateTriggerType != EFsmStateLogicTriggerType.Auto)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)StalemateTriggerType);
		}
		if (StalemateMoveType != EFsmMoveLogicType.Auto)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)StalemateMoveType);
		}
		if (ReturnHomeTriggerType != EFsmStateLogicTriggerType.Auto)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ReturnHomeTriggerType);
		}
		if (ReturnHomeMoveType != EFsmMoveLogicType.Auto)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ReturnHomeMoveType);
		}
		if (ReturnHomeSkill != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReturnHomeSkill);
		}
		if (ReturnHomeBuff != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReturnHomeBuff);
		}
		if (StrongPerceptionDistance != 0f)
		{
			num += 6;
		}
		if (CanEffectPlayerBattleState != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CanEffectPlayerBattleState);
		}
		if (Guard.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitAIDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitAIAttackType != EUnitAIAttackType.ActiveAttack)
			{
				UnitAIAttackType = other.UnitAIAttackType;
			}
			if (other.FsmSolverType != EFsmSolverType.Normal)
			{
				FsmSolverType = other.FsmSolverType;
			}
			if (other.IsSkipOnFightWhenBeAttack != EGSYesNo.No)
			{
				IsSkipOnFightWhenBeAttack = other.IsSkipOnFightWhenBeAttack;
			}
			if (other.DefaultAIWatchTimeMin != 0f)
			{
				DefaultAIWatchTimeMin = other.DefaultAIWatchTimeMin;
			}
			if (other.DefaultAIWatchTimeMax != 0f)
			{
				DefaultAIWatchTimeMax = other.DefaultAIWatchTimeMax;
			}
			if (other.IsBeHitResetAIWatchTime != EGSYesNo.No)
			{
				IsBeHitResetAIWatchTime = other.IsBeHitResetAIWatchTime;
			}
			if (other.PursuitRange != 0f)
			{
				PursuitRange = other.PursuitRange;
			}
			if (other.DetourCrowdType != EUnitAIDetourCrowdType.None)
			{
				DetourCrowdType = other.DetourCrowdType;
			}
			if (other.HearRange != 0f)
			{
				HearRange = other.HearRange;
			}
			if (other.EnableLoSVisualization != EGSYesNo.No)
			{
				EnableLoSVisualization = other.EnableLoSVisualization;
			}
			if (other.SightRange != 0f)
			{
				SightRange = other.SightRange;
			}
			if (other.VisionAngleDegrees != 0f)
			{
				VisionAngleDegrees = other.VisionAngleDegrees;
			}
			if (other.IsUseMultipointLock != EGSYesNo.No)
			{
				IsUseMultipointLock = other.IsUseMultipointLock;
			}
			if (other.MultipointLockMaxAngle != 0f)
			{
				MultipointLockMaxAngle = other.MultipointLockMaxAngle;
			}
			if (other.MultipointLockDistanceScoreRatingMin != 0f)
			{
				MultipointLockDistanceScoreRatingMin = other.MultipointLockDistanceScoreRatingMin;
			}
			if (other.MultipointLockDistanceScoreRatingMax != 0f)
			{
				MultipointLockDistanceScoreRatingMax = other.MultipointLockDistanceScoreRatingMax;
			}
			if (other.DefaultLeftSmallTurnSkillID != 0)
			{
				DefaultLeftSmallTurnSkillID = other.DefaultLeftSmallTurnSkillID;
			}
			if (other.DefaultRightSmallTurnSkillID != 0)
			{
				DefaultRightSmallTurnSkillID = other.DefaultRightSmallTurnSkillID;
			}
			if (other.DefaultLeftBigTurnSkillID != 0)
			{
				DefaultLeftBigTurnSkillID = other.DefaultLeftBigTurnSkillID;
			}
			if (other.DefaultRightBigTurnSkillID != 0)
			{
				DefaultRightBigTurnSkillID = other.DefaultRightBigTurnSkillID;
			}
			if (other.DefaultLeftSmallMoveSkillID != 0)
			{
				DefaultLeftSmallMoveSkillID = other.DefaultLeftSmallMoveSkillID;
			}
			if (other.DefaultRightSmallMoveSkillID != 0)
			{
				DefaultRightSmallMoveSkillID = other.DefaultRightSmallMoveSkillID;
			}
			if (other.DefaultLeftBigMoveSkillID != 0)
			{
				DefaultLeftBigMoveSkillID = other.DefaultLeftBigMoveSkillID;
			}
			if (other.DefaultRightBigMoveSkillID != 0)
			{
				DefaultRightBigMoveSkillID = other.DefaultRightBigMoveSkillID;
			}
			if (other.HatredTargetRandomSelectNum != 0)
			{
				HatredTargetRandomSelectNum = other.HatredTargetRandomSelectNum;
			}
			if (other.CanSearchTargetWhenSetTeamID != EGSYesNo.No)
			{
				CanSearchTargetWhenSetTeamID = other.CanSearchTargetWhenSetTeamID;
			}
			if (other.GazeAndSurroundTriggerType != EFsmStateLogicTriggerType.Auto)
			{
				GazeAndSurroundTriggerType = other.GazeAndSurroundTriggerType;
			}
			if (other.GazeAndSurroundMoveType != EFsmMoveLogicType.Auto)
			{
				GazeAndSurroundMoveType = other.GazeAndSurroundMoveType;
			}
			if (other.GazeAndSurroundEQSPath.Length != 0)
			{
				GazeAndSurroundEQSPath = other.GazeAndSurroundEQSPath;
			}
			if (other.StalemateTriggerType != EFsmStateLogicTriggerType.Auto)
			{
				StalemateTriggerType = other.StalemateTriggerType;
			}
			if (other.StalemateMoveType != EFsmMoveLogicType.Auto)
			{
				StalemateMoveType = other.StalemateMoveType;
			}
			if (other.ReturnHomeTriggerType != EFsmStateLogicTriggerType.Auto)
			{
				ReturnHomeTriggerType = other.ReturnHomeTriggerType;
			}
			if (other.ReturnHomeMoveType != EFsmMoveLogicType.Auto)
			{
				ReturnHomeMoveType = other.ReturnHomeMoveType;
			}
			if (other.ReturnHomeSkill != 0)
			{
				ReturnHomeSkill = other.ReturnHomeSkill;
			}
			if (other.ReturnHomeBuff != 0)
			{
				ReturnHomeBuff = other.ReturnHomeBuff;
			}
			if (other.StrongPerceptionDistance != 0f)
			{
				StrongPerceptionDistance = other.StrongPerceptionDistance;
			}
			if (other.CanEffectPlayerBattleState != EGSYesNo.No)
			{
				CanEffectPlayerBattleState = other.CanEffectPlayerBattleState;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
			}
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
				ID = input.ReadInt32();
				break;
			case 16u:
				UnitAIAttackType = (EUnitAIAttackType)input.ReadEnum();
				break;
			case 24u:
				FsmSolverType = (EFsmSolverType)input.ReadEnum();
				break;
			case 32u:
				IsSkipOnFightWhenBeAttack = (EGSYesNo)input.ReadEnum();
				break;
			case 45u:
				DefaultAIWatchTimeMin = input.ReadFloat();
				break;
			case 53u:
				DefaultAIWatchTimeMax = input.ReadFloat();
				break;
			case 56u:
				IsBeHitResetAIWatchTime = (EGSYesNo)input.ReadEnum();
				break;
			case 69u:
				PursuitRange = input.ReadFloat();
				break;
			case 72u:
				DetourCrowdType = (EUnitAIDetourCrowdType)input.ReadEnum();
				break;
			case 85u:
				HearRange = input.ReadFloat();
				break;
			case 88u:
				EnableLoSVisualization = (EGSYesNo)input.ReadEnum();
				break;
			case 101u:
				SightRange = input.ReadFloat();
				break;
			case 109u:
				VisionAngleDegrees = input.ReadFloat();
				break;
			case 112u:
				IsUseMultipointLock = (EGSYesNo)input.ReadEnum();
				break;
			case 125u:
				MultipointLockMaxAngle = input.ReadFloat();
				break;
			case 133u:
				MultipointLockDistanceScoreRatingMin = input.ReadFloat();
				break;
			case 141u:
				MultipointLockDistanceScoreRatingMax = input.ReadFloat();
				break;
			case 144u:
				DefaultLeftSmallTurnSkillID = input.ReadInt32();
				break;
			case 152u:
				DefaultRightSmallTurnSkillID = input.ReadInt32();
				break;
			case 160u:
				DefaultLeftBigTurnSkillID = input.ReadInt32();
				break;
			case 168u:
				DefaultRightBigTurnSkillID = input.ReadInt32();
				break;
			case 176u:
				DefaultLeftSmallMoveSkillID = input.ReadInt32();
				break;
			case 184u:
				DefaultRightSmallMoveSkillID = input.ReadInt32();
				break;
			case 192u:
				DefaultLeftBigMoveSkillID = input.ReadInt32();
				break;
			case 200u:
				DefaultRightBigMoveSkillID = input.ReadInt32();
				break;
			case 208u:
				HatredTargetRandomSelectNum = input.ReadInt32();
				break;
			case 216u:
				CanSearchTargetWhenSetTeamID = (EGSYesNo)input.ReadEnum();
				break;
			case 224u:
				GazeAndSurroundTriggerType = (EFsmStateLogicTriggerType)input.ReadEnum();
				break;
			case 232u:
				GazeAndSurroundMoveType = (EFsmMoveLogicType)input.ReadEnum();
				break;
			case 242u:
				GazeAndSurroundEQSPath = input.ReadString();
				break;
			case 248u:
				StalemateTriggerType = (EFsmStateLogicTriggerType)input.ReadEnum();
				break;
			case 256u:
				StalemateMoveType = (EFsmMoveLogicType)input.ReadEnum();
				break;
			case 264u:
				ReturnHomeTriggerType = (EFsmStateLogicTriggerType)input.ReadEnum();
				break;
			case 272u:
				ReturnHomeMoveType = (EFsmMoveLogicType)input.ReadEnum();
				break;
			case 280u:
				ReturnHomeSkill = input.ReadInt32();
				break;
			case 288u:
				ReturnHomeBuff = input.ReadInt32();
				break;
			case 301u:
				StrongPerceptionDistance = input.ReadFloat();
				break;
			case 304u:
				CanEffectPlayerBattleState = (EGSYesNo)input.ReadEnum();
				break;
			case 314u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
