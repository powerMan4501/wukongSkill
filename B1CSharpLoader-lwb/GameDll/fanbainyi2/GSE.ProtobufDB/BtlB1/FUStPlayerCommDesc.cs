using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPlayerCommDesc : IMessage<FUStPlayerCommDesc>, IMessage, IEquatable<FUStPlayerCommDesc>, IDeepCloneable<FUStPlayerCommDesc>
{
	private static readonly MessageParser<FUStPlayerCommDesc> _parser = new MessageParser<FUStPlayerCommDesc>(() => new FUStPlayerCommDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int defaultCameraGroupID_;

	private int jumpSkillID_;

	private int dodgeStartSkillID_;

	private int preciseDodgeStartSkillID_;

	private EGSYesNo enableMultipointLockMode_;

	private EGSYesNo autoLockIgnoreInput_;

	private int glideJumpSkillID_;

	private int bloodBottomNum_;

	private int maxShield_;

	private float staminaMaxBase_;

	private float staminaRecoverBase_;

	private float staminaCostMoveFast_;

	private float staminaDepletedLimitBase_;

	private int noStaminaBuffID_;

	private int rebirthSkillID_;

	private float moveBackSpeedRate_;

	private float jumpSpeedNormal_;

	private float jumpSpeedFast_;

	private float jumpHorFixedMaxOffset_;

	private float jumpHorFixedSpd_;

	private float jumpVerFixedMaxOffset_;

	private float jumpVerFixedSpd_;

	private float lockJumpRotSpdF_;

	private float lockJumpRotSpdB_;

	private float lockJumpRotSpdL_;

	private float lockJumpRotSpdR_;

	private float airAtkJumpProtectTime_;

	private float airAtkFallingProtectTime_;

	private float fallingDamageMultiplier_;

	private static readonly FieldCodec<int> _repeated_jumpBuffID_codec = FieldCodec.ForInt32(250u);

	private readonly RepeatedField<int> jumpBuffID_ = new RepeatedField<int>();

	private float manualSplineMoveMaxInputAngle_;

	private float manualSplineMoveCameraTraceSpeedRate_;

	private float manualSplineMoveCameraPauseTime_;

	private int teleportSkillID_;

	private EGSYesNo disableWalk_;

	private int unFreezeCount_;

	private float unFreezeEventGap_;

	private string unFreezeAdditiveAMPath_ = "";

	private string unFreezeFXPath_ = "";

	private float moveInputFilterTime_;

	public static MessageParser<FUStPlayerCommDesc> Parser => _parser;

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

	public int DefaultCameraGroupID
	{
		get
		{
			return defaultCameraGroupID_;
		}
		set
		{
			defaultCameraGroupID_ = value;
		}
	}

	public int JumpSkillID
	{
		get
		{
			return jumpSkillID_;
		}
		set
		{
			jumpSkillID_ = value;
		}
	}

	public int DodgeStartSkillID
	{
		get
		{
			return dodgeStartSkillID_;
		}
		set
		{
			dodgeStartSkillID_ = value;
		}
	}

	public int PreciseDodgeStartSkillID
	{
		get
		{
			return preciseDodgeStartSkillID_;
		}
		set
		{
			preciseDodgeStartSkillID_ = value;
		}
	}

	public EGSYesNo EnableMultipointLockMode
	{
		get
		{
			return enableMultipointLockMode_;
		}
		set
		{
			enableMultipointLockMode_ = value;
		}
	}

	public EGSYesNo AutoLockIgnoreInput
	{
		get
		{
			return autoLockIgnoreInput_;
		}
		set
		{
			autoLockIgnoreInput_ = value;
		}
	}

	public int GlideJumpSkillID
	{
		get
		{
			return glideJumpSkillID_;
		}
		set
		{
			glideJumpSkillID_ = value;
		}
	}

	public int BloodBottomNum
	{
		get
		{
			return bloodBottomNum_;
		}
		set
		{
			bloodBottomNum_ = value;
		}
	}

	public int MaxShield
	{
		get
		{
			return maxShield_;
		}
		set
		{
			maxShield_ = value;
		}
	}

	public float StaminaMaxBase
	{
		get
		{
			return staminaMaxBase_;
		}
		set
		{
			staminaMaxBase_ = value;
		}
	}

	public float StaminaRecoverBase
	{
		get
		{
			return staminaRecoverBase_;
		}
		set
		{
			staminaRecoverBase_ = value;
		}
	}

	public float StaminaCostMoveFast
	{
		get
		{
			return staminaCostMoveFast_;
		}
		set
		{
			staminaCostMoveFast_ = value;
		}
	}

	public float StaminaDepletedLimitBase
	{
		get
		{
			return staminaDepletedLimitBase_;
		}
		set
		{
			staminaDepletedLimitBase_ = value;
		}
	}

	public int NoStaminaBuffID
	{
		get
		{
			return noStaminaBuffID_;
		}
		set
		{
			noStaminaBuffID_ = value;
		}
	}

	public int RebirthSkillID
	{
		get
		{
			return rebirthSkillID_;
		}
		set
		{
			rebirthSkillID_ = value;
		}
	}

	public float MoveBackSpeedRate
	{
		get
		{
			return moveBackSpeedRate_;
		}
		set
		{
			moveBackSpeedRate_ = value;
		}
	}

	public float JumpSpeedNormal
	{
		get
		{
			return jumpSpeedNormal_;
		}
		set
		{
			jumpSpeedNormal_ = value;
		}
	}

	public float JumpSpeedFast
	{
		get
		{
			return jumpSpeedFast_;
		}
		set
		{
			jumpSpeedFast_ = value;
		}
	}

	public float JumpHorFixedMaxOffset
	{
		get
		{
			return jumpHorFixedMaxOffset_;
		}
		set
		{
			jumpHorFixedMaxOffset_ = value;
		}
	}

	public float JumpHorFixedSpd
	{
		get
		{
			return jumpHorFixedSpd_;
		}
		set
		{
			jumpHorFixedSpd_ = value;
		}
	}

	public float JumpVerFixedMaxOffset
	{
		get
		{
			return jumpVerFixedMaxOffset_;
		}
		set
		{
			jumpVerFixedMaxOffset_ = value;
		}
	}

	public float JumpVerFixedSpd
	{
		get
		{
			return jumpVerFixedSpd_;
		}
		set
		{
			jumpVerFixedSpd_ = value;
		}
	}

	public float LockJumpRotSpdF
	{
		get
		{
			return lockJumpRotSpdF_;
		}
		set
		{
			lockJumpRotSpdF_ = value;
		}
	}

	public float LockJumpRotSpdB
	{
		get
		{
			return lockJumpRotSpdB_;
		}
		set
		{
			lockJumpRotSpdB_ = value;
		}
	}

	public float LockJumpRotSpdL
	{
		get
		{
			return lockJumpRotSpdL_;
		}
		set
		{
			lockJumpRotSpdL_ = value;
		}
	}

	public float LockJumpRotSpdR
	{
		get
		{
			return lockJumpRotSpdR_;
		}
		set
		{
			lockJumpRotSpdR_ = value;
		}
	}

	public float AirAtkJumpProtectTime
	{
		get
		{
			return airAtkJumpProtectTime_;
		}
		set
		{
			airAtkJumpProtectTime_ = value;
		}
	}

	public float AirAtkFallingProtectTime
	{
		get
		{
			return airAtkFallingProtectTime_;
		}
		set
		{
			airAtkFallingProtectTime_ = value;
		}
	}

	public float FallingDamageMultiplier
	{
		get
		{
			return fallingDamageMultiplier_;
		}
		set
		{
			fallingDamageMultiplier_ = value;
		}
	}

	public RepeatedField<int> JumpBuffID => jumpBuffID_;

	public float ManualSplineMoveMaxInputAngle
	{
		get
		{
			return manualSplineMoveMaxInputAngle_;
		}
		set
		{
			manualSplineMoveMaxInputAngle_ = value;
		}
	}

	public float ManualSplineMoveCameraTraceSpeedRate
	{
		get
		{
			return manualSplineMoveCameraTraceSpeedRate_;
		}
		set
		{
			manualSplineMoveCameraTraceSpeedRate_ = value;
		}
	}

	public float ManualSplineMoveCameraPauseTime
	{
		get
		{
			return manualSplineMoveCameraPauseTime_;
		}
		set
		{
			manualSplineMoveCameraPauseTime_ = value;
		}
	}

	public int TeleportSkillID
	{
		get
		{
			return teleportSkillID_;
		}
		set
		{
			teleportSkillID_ = value;
		}
	}

	public EGSYesNo DisableWalk
	{
		get
		{
			return disableWalk_;
		}
		set
		{
			disableWalk_ = value;
		}
	}

	public int UnFreezeCount
	{
		get
		{
			return unFreezeCount_;
		}
		set
		{
			unFreezeCount_ = value;
		}
	}

	public float UnFreezeEventGap
	{
		get
		{
			return unFreezeEventGap_;
		}
		set
		{
			unFreezeEventGap_ = value;
		}
	}

	public string UnFreezeAdditiveAMPath
	{
		get
		{
			return unFreezeAdditiveAMPath_;
		}
		set
		{
			unFreezeAdditiveAMPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string UnFreezeFXPath
	{
		get
		{
			return unFreezeFXPath_;
		}
		set
		{
			unFreezeFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float MoveInputFilterTime
	{
		get
		{
			return moveInputFilterTime_;
		}
		set
		{
			moveInputFilterTime_ = value;
		}
	}

	public FUStPlayerCommDesc()
	{
	}

	public FUStPlayerCommDesc(FUStPlayerCommDesc other)
		: this()
	{
		iD_ = other.iD_;
		defaultCameraGroupID_ = other.defaultCameraGroupID_;
		jumpSkillID_ = other.jumpSkillID_;
		dodgeStartSkillID_ = other.dodgeStartSkillID_;
		preciseDodgeStartSkillID_ = other.preciseDodgeStartSkillID_;
		enableMultipointLockMode_ = other.enableMultipointLockMode_;
		autoLockIgnoreInput_ = other.autoLockIgnoreInput_;
		glideJumpSkillID_ = other.glideJumpSkillID_;
		bloodBottomNum_ = other.bloodBottomNum_;
		maxShield_ = other.maxShield_;
		staminaMaxBase_ = other.staminaMaxBase_;
		staminaRecoverBase_ = other.staminaRecoverBase_;
		staminaCostMoveFast_ = other.staminaCostMoveFast_;
		staminaDepletedLimitBase_ = other.staminaDepletedLimitBase_;
		noStaminaBuffID_ = other.noStaminaBuffID_;
		rebirthSkillID_ = other.rebirthSkillID_;
		moveBackSpeedRate_ = other.moveBackSpeedRate_;
		jumpSpeedNormal_ = other.jumpSpeedNormal_;
		jumpSpeedFast_ = other.jumpSpeedFast_;
		jumpHorFixedMaxOffset_ = other.jumpHorFixedMaxOffset_;
		jumpHorFixedSpd_ = other.jumpHorFixedSpd_;
		jumpVerFixedMaxOffset_ = other.jumpVerFixedMaxOffset_;
		jumpVerFixedSpd_ = other.jumpVerFixedSpd_;
		lockJumpRotSpdF_ = other.lockJumpRotSpdF_;
		lockJumpRotSpdB_ = other.lockJumpRotSpdB_;
		lockJumpRotSpdL_ = other.lockJumpRotSpdL_;
		lockJumpRotSpdR_ = other.lockJumpRotSpdR_;
		airAtkJumpProtectTime_ = other.airAtkJumpProtectTime_;
		airAtkFallingProtectTime_ = other.airAtkFallingProtectTime_;
		fallingDamageMultiplier_ = other.fallingDamageMultiplier_;
		jumpBuffID_ = other.jumpBuffID_.Clone();
		manualSplineMoveMaxInputAngle_ = other.manualSplineMoveMaxInputAngle_;
		manualSplineMoveCameraTraceSpeedRate_ = other.manualSplineMoveCameraTraceSpeedRate_;
		manualSplineMoveCameraPauseTime_ = other.manualSplineMoveCameraPauseTime_;
		teleportSkillID_ = other.teleportSkillID_;
		disableWalk_ = other.disableWalk_;
		unFreezeCount_ = other.unFreezeCount_;
		unFreezeEventGap_ = other.unFreezeEventGap_;
		unFreezeAdditiveAMPath_ = other.unFreezeAdditiveAMPath_;
		unFreezeFXPath_ = other.unFreezeFXPath_;
		moveInputFilterTime_ = other.moveInputFilterTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPlayerCommDesc Clone()
	{
		return new FUStPlayerCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPlayerCommDesc);
	}

	public bool Equals(FUStPlayerCommDesc other)
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
		if (DefaultCameraGroupID != other.DefaultCameraGroupID)
		{
			return false;
		}
		if (JumpSkillID != other.JumpSkillID)
		{
			return false;
		}
		if (DodgeStartSkillID != other.DodgeStartSkillID)
		{
			return false;
		}
		if (PreciseDodgeStartSkillID != other.PreciseDodgeStartSkillID)
		{
			return false;
		}
		if (EnableMultipointLockMode != other.EnableMultipointLockMode)
		{
			return false;
		}
		if (AutoLockIgnoreInput != other.AutoLockIgnoreInput)
		{
			return false;
		}
		if (GlideJumpSkillID != other.GlideJumpSkillID)
		{
			return false;
		}
		if (BloodBottomNum != other.BloodBottomNum)
		{
			return false;
		}
		if (MaxShield != other.MaxShield)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StaminaMaxBase, other.StaminaMaxBase))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StaminaRecoverBase, other.StaminaRecoverBase))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StaminaCostMoveFast, other.StaminaCostMoveFast))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StaminaDepletedLimitBase, other.StaminaDepletedLimitBase))
		{
			return false;
		}
		if (NoStaminaBuffID != other.NoStaminaBuffID)
		{
			return false;
		}
		if (RebirthSkillID != other.RebirthSkillID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MoveBackSpeedRate, other.MoveBackSpeedRate))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(JumpSpeedNormal, other.JumpSpeedNormal))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(JumpSpeedFast, other.JumpSpeedFast))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(JumpHorFixedMaxOffset, other.JumpHorFixedMaxOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(JumpHorFixedSpd, other.JumpHorFixedSpd))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(JumpVerFixedMaxOffset, other.JumpVerFixedMaxOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(JumpVerFixedSpd, other.JumpVerFixedSpd))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LockJumpRotSpdF, other.LockJumpRotSpdF))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LockJumpRotSpdB, other.LockJumpRotSpdB))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LockJumpRotSpdL, other.LockJumpRotSpdL))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LockJumpRotSpdR, other.LockJumpRotSpdR))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AirAtkJumpProtectTime, other.AirAtkJumpProtectTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AirAtkFallingProtectTime, other.AirAtkFallingProtectTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FallingDamageMultiplier, other.FallingDamageMultiplier))
		{
			return false;
		}
		if (!jumpBuffID_.Equals(other.jumpBuffID_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ManualSplineMoveMaxInputAngle, other.ManualSplineMoveMaxInputAngle))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ManualSplineMoveCameraTraceSpeedRate, other.ManualSplineMoveCameraTraceSpeedRate))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ManualSplineMoveCameraPauseTime, other.ManualSplineMoveCameraPauseTime))
		{
			return false;
		}
		if (TeleportSkillID != other.TeleportSkillID)
		{
			return false;
		}
		if (DisableWalk != other.DisableWalk)
		{
			return false;
		}
		if (UnFreezeCount != other.UnFreezeCount)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(UnFreezeEventGap, other.UnFreezeEventGap))
		{
			return false;
		}
		if (UnFreezeAdditiveAMPath != other.UnFreezeAdditiveAMPath)
		{
			return false;
		}
		if (UnFreezeFXPath != other.UnFreezeFXPath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MoveInputFilterTime, other.MoveInputFilterTime))
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
		if (DefaultCameraGroupID != 0)
		{
			num ^= DefaultCameraGroupID.GetHashCode();
		}
		if (JumpSkillID != 0)
		{
			num ^= JumpSkillID.GetHashCode();
		}
		if (DodgeStartSkillID != 0)
		{
			num ^= DodgeStartSkillID.GetHashCode();
		}
		if (PreciseDodgeStartSkillID != 0)
		{
			num ^= PreciseDodgeStartSkillID.GetHashCode();
		}
		if (EnableMultipointLockMode != EGSYesNo.No)
		{
			num ^= EnableMultipointLockMode.GetHashCode();
		}
		if (AutoLockIgnoreInput != EGSYesNo.No)
		{
			num ^= AutoLockIgnoreInput.GetHashCode();
		}
		if (GlideJumpSkillID != 0)
		{
			num ^= GlideJumpSkillID.GetHashCode();
		}
		if (BloodBottomNum != 0)
		{
			num ^= BloodBottomNum.GetHashCode();
		}
		if (MaxShield != 0)
		{
			num ^= MaxShield.GetHashCode();
		}
		if (StaminaMaxBase != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StaminaMaxBase);
		}
		if (StaminaRecoverBase != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StaminaRecoverBase);
		}
		if (StaminaCostMoveFast != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StaminaCostMoveFast);
		}
		if (StaminaDepletedLimitBase != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StaminaDepletedLimitBase);
		}
		if (NoStaminaBuffID != 0)
		{
			num ^= NoStaminaBuffID.GetHashCode();
		}
		if (RebirthSkillID != 0)
		{
			num ^= RebirthSkillID.GetHashCode();
		}
		if (MoveBackSpeedRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveBackSpeedRate);
		}
		if (JumpSpeedNormal != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(JumpSpeedNormal);
		}
		if (JumpSpeedFast != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(JumpSpeedFast);
		}
		if (JumpHorFixedMaxOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(JumpHorFixedMaxOffset);
		}
		if (JumpHorFixedSpd != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(JumpHorFixedSpd);
		}
		if (JumpVerFixedMaxOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(JumpVerFixedMaxOffset);
		}
		if (JumpVerFixedSpd != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(JumpVerFixedSpd);
		}
		if (LockJumpRotSpdF != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LockJumpRotSpdF);
		}
		if (LockJumpRotSpdB != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LockJumpRotSpdB);
		}
		if (LockJumpRotSpdL != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LockJumpRotSpdL);
		}
		if (LockJumpRotSpdR != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LockJumpRotSpdR);
		}
		if (AirAtkJumpProtectTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AirAtkJumpProtectTime);
		}
		if (AirAtkFallingProtectTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AirAtkFallingProtectTime);
		}
		if (FallingDamageMultiplier != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FallingDamageMultiplier);
		}
		num ^= jumpBuffID_.GetHashCode();
		if (ManualSplineMoveMaxInputAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ManualSplineMoveMaxInputAngle);
		}
		if (ManualSplineMoveCameraTraceSpeedRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ManualSplineMoveCameraTraceSpeedRate);
		}
		if (ManualSplineMoveCameraPauseTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ManualSplineMoveCameraPauseTime);
		}
		if (TeleportSkillID != 0)
		{
			num ^= TeleportSkillID.GetHashCode();
		}
		if (DisableWalk != EGSYesNo.No)
		{
			num ^= DisableWalk.GetHashCode();
		}
		if (UnFreezeCount != 0)
		{
			num ^= UnFreezeCount.GetHashCode();
		}
		if (UnFreezeEventGap != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(UnFreezeEventGap);
		}
		if (UnFreezeAdditiveAMPath.Length != 0)
		{
			num ^= UnFreezeAdditiveAMPath.GetHashCode();
		}
		if (UnFreezeFXPath.Length != 0)
		{
			num ^= UnFreezeFXPath.GetHashCode();
		}
		if (MoveInputFilterTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveInputFilterTime);
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
		if (DefaultCameraGroupID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DefaultCameraGroupID);
		}
		if (JumpSkillID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(JumpSkillID);
		}
		if (DodgeStartSkillID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DodgeStartSkillID);
		}
		if (PreciseDodgeStartSkillID != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(PreciseDodgeStartSkillID);
		}
		if (EnableMultipointLockMode != EGSYesNo.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)EnableMultipointLockMode);
		}
		if (AutoLockIgnoreInput != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)AutoLockIgnoreInput);
		}
		if (GlideJumpSkillID != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(GlideJumpSkillID);
		}
		if (BloodBottomNum != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(BloodBottomNum);
		}
		if (MaxShield != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(MaxShield);
		}
		if (StaminaMaxBase != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(StaminaMaxBase);
		}
		if (StaminaRecoverBase != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(StaminaRecoverBase);
		}
		if (StaminaCostMoveFast != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(StaminaCostMoveFast);
		}
		if (StaminaDepletedLimitBase != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(StaminaDepletedLimitBase);
		}
		if (NoStaminaBuffID != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(NoStaminaBuffID);
		}
		if (RebirthSkillID != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(RebirthSkillID);
		}
		if (MoveBackSpeedRate != 0f)
		{
			output.WriteRawTag(141, 1);
			output.WriteFloat(MoveBackSpeedRate);
		}
		if (JumpSpeedNormal != 0f)
		{
			output.WriteRawTag(149, 1);
			output.WriteFloat(JumpSpeedNormal);
		}
		if (JumpSpeedFast != 0f)
		{
			output.WriteRawTag(157, 1);
			output.WriteFloat(JumpSpeedFast);
		}
		if (JumpHorFixedMaxOffset != 0f)
		{
			output.WriteRawTag(165, 1);
			output.WriteFloat(JumpHorFixedMaxOffset);
		}
		if (JumpHorFixedSpd != 0f)
		{
			output.WriteRawTag(173, 1);
			output.WriteFloat(JumpHorFixedSpd);
		}
		if (JumpVerFixedMaxOffset != 0f)
		{
			output.WriteRawTag(181, 1);
			output.WriteFloat(JumpVerFixedMaxOffset);
		}
		if (JumpVerFixedSpd != 0f)
		{
			output.WriteRawTag(189, 1);
			output.WriteFloat(JumpVerFixedSpd);
		}
		if (LockJumpRotSpdF != 0f)
		{
			output.WriteRawTag(197, 1);
			output.WriteFloat(LockJumpRotSpdF);
		}
		if (LockJumpRotSpdB != 0f)
		{
			output.WriteRawTag(205, 1);
			output.WriteFloat(LockJumpRotSpdB);
		}
		if (LockJumpRotSpdL != 0f)
		{
			output.WriteRawTag(213, 1);
			output.WriteFloat(LockJumpRotSpdL);
		}
		if (LockJumpRotSpdR != 0f)
		{
			output.WriteRawTag(221, 1);
			output.WriteFloat(LockJumpRotSpdR);
		}
		if (AirAtkJumpProtectTime != 0f)
		{
			output.WriteRawTag(229, 1);
			output.WriteFloat(AirAtkJumpProtectTime);
		}
		if (AirAtkFallingProtectTime != 0f)
		{
			output.WriteRawTag(237, 1);
			output.WriteFloat(AirAtkFallingProtectTime);
		}
		if (FallingDamageMultiplier != 0f)
		{
			output.WriteRawTag(245, 1);
			output.WriteFloat(FallingDamageMultiplier);
		}
		jumpBuffID_.WriteTo(output, _repeated_jumpBuffID_codec);
		if (ManualSplineMoveMaxInputAngle != 0f)
		{
			output.WriteRawTag(133, 2);
			output.WriteFloat(ManualSplineMoveMaxInputAngle);
		}
		if (ManualSplineMoveCameraTraceSpeedRate != 0f)
		{
			output.WriteRawTag(141, 2);
			output.WriteFloat(ManualSplineMoveCameraTraceSpeedRate);
		}
		if (ManualSplineMoveCameraPauseTime != 0f)
		{
			output.WriteRawTag(149, 2);
			output.WriteFloat(ManualSplineMoveCameraPauseTime);
		}
		if (TeleportSkillID != 0)
		{
			output.WriteRawTag(152, 2);
			output.WriteInt32(TeleportSkillID);
		}
		if (DisableWalk != EGSYesNo.No)
		{
			output.WriteRawTag(160, 2);
			output.WriteEnum((int)DisableWalk);
		}
		if (UnFreezeCount != 0)
		{
			output.WriteRawTag(168, 2);
			output.WriteInt32(UnFreezeCount);
		}
		if (UnFreezeEventGap != 0f)
		{
			output.WriteRawTag(181, 2);
			output.WriteFloat(UnFreezeEventGap);
		}
		if (UnFreezeAdditiveAMPath.Length != 0)
		{
			output.WriteRawTag(186, 2);
			output.WriteString(UnFreezeAdditiveAMPath);
		}
		if (UnFreezeFXPath.Length != 0)
		{
			output.WriteRawTag(194, 2);
			output.WriteString(UnFreezeFXPath);
		}
		if (MoveInputFilterTime != 0f)
		{
			output.WriteRawTag(205, 2);
			output.WriteFloat(MoveInputFilterTime);
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
		if (DefaultCameraGroupID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultCameraGroupID);
		}
		if (JumpSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(JumpSkillID);
		}
		if (DodgeStartSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DodgeStartSkillID);
		}
		if (PreciseDodgeStartSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PreciseDodgeStartSkillID);
		}
		if (EnableMultipointLockMode != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EnableMultipointLockMode);
		}
		if (AutoLockIgnoreInput != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AutoLockIgnoreInput);
		}
		if (GlideJumpSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GlideJumpSkillID);
		}
		if (BloodBottomNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BloodBottomNum);
		}
		if (MaxShield != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxShield);
		}
		if (StaminaMaxBase != 0f)
		{
			num += 5;
		}
		if (StaminaRecoverBase != 0f)
		{
			num += 5;
		}
		if (StaminaCostMoveFast != 0f)
		{
			num += 5;
		}
		if (StaminaDepletedLimitBase != 0f)
		{
			num += 5;
		}
		if (NoStaminaBuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NoStaminaBuffID);
		}
		if (RebirthSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RebirthSkillID);
		}
		if (MoveBackSpeedRate != 0f)
		{
			num += 6;
		}
		if (JumpSpeedNormal != 0f)
		{
			num += 6;
		}
		if (JumpSpeedFast != 0f)
		{
			num += 6;
		}
		if (JumpHorFixedMaxOffset != 0f)
		{
			num += 6;
		}
		if (JumpHorFixedSpd != 0f)
		{
			num += 6;
		}
		if (JumpVerFixedMaxOffset != 0f)
		{
			num += 6;
		}
		if (JumpVerFixedSpd != 0f)
		{
			num += 6;
		}
		if (LockJumpRotSpdF != 0f)
		{
			num += 6;
		}
		if (LockJumpRotSpdB != 0f)
		{
			num += 6;
		}
		if (LockJumpRotSpdL != 0f)
		{
			num += 6;
		}
		if (LockJumpRotSpdR != 0f)
		{
			num += 6;
		}
		if (AirAtkJumpProtectTime != 0f)
		{
			num += 6;
		}
		if (AirAtkFallingProtectTime != 0f)
		{
			num += 6;
		}
		if (FallingDamageMultiplier != 0f)
		{
			num += 6;
		}
		num += jumpBuffID_.CalculateSize(_repeated_jumpBuffID_codec);
		if (ManualSplineMoveMaxInputAngle != 0f)
		{
			num += 6;
		}
		if (ManualSplineMoveCameraTraceSpeedRate != 0f)
		{
			num += 6;
		}
		if (ManualSplineMoveCameraPauseTime != 0f)
		{
			num += 6;
		}
		if (TeleportSkillID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TeleportSkillID);
		}
		if (DisableWalk != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)DisableWalk);
		}
		if (UnFreezeCount != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UnFreezeCount);
		}
		if (UnFreezeEventGap != 0f)
		{
			num += 6;
		}
		if (UnFreezeAdditiveAMPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(UnFreezeAdditiveAMPath);
		}
		if (UnFreezeFXPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(UnFreezeFXPath);
		}
		if (MoveInputFilterTime != 0f)
		{
			num += 6;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPlayerCommDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.DefaultCameraGroupID != 0)
			{
				DefaultCameraGroupID = other.DefaultCameraGroupID;
			}
			if (other.JumpSkillID != 0)
			{
				JumpSkillID = other.JumpSkillID;
			}
			if (other.DodgeStartSkillID != 0)
			{
				DodgeStartSkillID = other.DodgeStartSkillID;
			}
			if (other.PreciseDodgeStartSkillID != 0)
			{
				PreciseDodgeStartSkillID = other.PreciseDodgeStartSkillID;
			}
			if (other.EnableMultipointLockMode != EGSYesNo.No)
			{
				EnableMultipointLockMode = other.EnableMultipointLockMode;
			}
			if (other.AutoLockIgnoreInput != EGSYesNo.No)
			{
				AutoLockIgnoreInput = other.AutoLockIgnoreInput;
			}
			if (other.GlideJumpSkillID != 0)
			{
				GlideJumpSkillID = other.GlideJumpSkillID;
			}
			if (other.BloodBottomNum != 0)
			{
				BloodBottomNum = other.BloodBottomNum;
			}
			if (other.MaxShield != 0)
			{
				MaxShield = other.MaxShield;
			}
			if (other.StaminaMaxBase != 0f)
			{
				StaminaMaxBase = other.StaminaMaxBase;
			}
			if (other.StaminaRecoverBase != 0f)
			{
				StaminaRecoverBase = other.StaminaRecoverBase;
			}
			if (other.StaminaCostMoveFast != 0f)
			{
				StaminaCostMoveFast = other.StaminaCostMoveFast;
			}
			if (other.StaminaDepletedLimitBase != 0f)
			{
				StaminaDepletedLimitBase = other.StaminaDepletedLimitBase;
			}
			if (other.NoStaminaBuffID != 0)
			{
				NoStaminaBuffID = other.NoStaminaBuffID;
			}
			if (other.RebirthSkillID != 0)
			{
				RebirthSkillID = other.RebirthSkillID;
			}
			if (other.MoveBackSpeedRate != 0f)
			{
				MoveBackSpeedRate = other.MoveBackSpeedRate;
			}
			if (other.JumpSpeedNormal != 0f)
			{
				JumpSpeedNormal = other.JumpSpeedNormal;
			}
			if (other.JumpSpeedFast != 0f)
			{
				JumpSpeedFast = other.JumpSpeedFast;
			}
			if (other.JumpHorFixedMaxOffset != 0f)
			{
				JumpHorFixedMaxOffset = other.JumpHorFixedMaxOffset;
			}
			if (other.JumpHorFixedSpd != 0f)
			{
				JumpHorFixedSpd = other.JumpHorFixedSpd;
			}
			if (other.JumpVerFixedMaxOffset != 0f)
			{
				JumpVerFixedMaxOffset = other.JumpVerFixedMaxOffset;
			}
			if (other.JumpVerFixedSpd != 0f)
			{
				JumpVerFixedSpd = other.JumpVerFixedSpd;
			}
			if (other.LockJumpRotSpdF != 0f)
			{
				LockJumpRotSpdF = other.LockJumpRotSpdF;
			}
			if (other.LockJumpRotSpdB != 0f)
			{
				LockJumpRotSpdB = other.LockJumpRotSpdB;
			}
			if (other.LockJumpRotSpdL != 0f)
			{
				LockJumpRotSpdL = other.LockJumpRotSpdL;
			}
			if (other.LockJumpRotSpdR != 0f)
			{
				LockJumpRotSpdR = other.LockJumpRotSpdR;
			}
			if (other.AirAtkJumpProtectTime != 0f)
			{
				AirAtkJumpProtectTime = other.AirAtkJumpProtectTime;
			}
			if (other.AirAtkFallingProtectTime != 0f)
			{
				AirAtkFallingProtectTime = other.AirAtkFallingProtectTime;
			}
			if (other.FallingDamageMultiplier != 0f)
			{
				FallingDamageMultiplier = other.FallingDamageMultiplier;
			}
			jumpBuffID_.Add(other.jumpBuffID_);
			if (other.ManualSplineMoveMaxInputAngle != 0f)
			{
				ManualSplineMoveMaxInputAngle = other.ManualSplineMoveMaxInputAngle;
			}
			if (other.ManualSplineMoveCameraTraceSpeedRate != 0f)
			{
				ManualSplineMoveCameraTraceSpeedRate = other.ManualSplineMoveCameraTraceSpeedRate;
			}
			if (other.ManualSplineMoveCameraPauseTime != 0f)
			{
				ManualSplineMoveCameraPauseTime = other.ManualSplineMoveCameraPauseTime;
			}
			if (other.TeleportSkillID != 0)
			{
				TeleportSkillID = other.TeleportSkillID;
			}
			if (other.DisableWalk != EGSYesNo.No)
			{
				DisableWalk = other.DisableWalk;
			}
			if (other.UnFreezeCount != 0)
			{
				UnFreezeCount = other.UnFreezeCount;
			}
			if (other.UnFreezeEventGap != 0f)
			{
				UnFreezeEventGap = other.UnFreezeEventGap;
			}
			if (other.UnFreezeAdditiveAMPath.Length != 0)
			{
				UnFreezeAdditiveAMPath = other.UnFreezeAdditiveAMPath;
			}
			if (other.UnFreezeFXPath.Length != 0)
			{
				UnFreezeFXPath = other.UnFreezeFXPath;
			}
			if (other.MoveInputFilterTime != 0f)
			{
				MoveInputFilterTime = other.MoveInputFilterTime;
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
				DefaultCameraGroupID = input.ReadInt32();
				break;
			case 24u:
				JumpSkillID = input.ReadInt32();
				break;
			case 32u:
				DodgeStartSkillID = input.ReadInt32();
				break;
			case 40u:
				PreciseDodgeStartSkillID = input.ReadInt32();
				break;
			case 48u:
				EnableMultipointLockMode = (EGSYesNo)input.ReadEnum();
				break;
			case 56u:
				AutoLockIgnoreInput = (EGSYesNo)input.ReadEnum();
				break;
			case 64u:
				GlideJumpSkillID = input.ReadInt32();
				break;
			case 72u:
				BloodBottomNum = input.ReadInt32();
				break;
			case 80u:
				MaxShield = input.ReadInt32();
				break;
			case 93u:
				StaminaMaxBase = input.ReadFloat();
				break;
			case 101u:
				StaminaRecoverBase = input.ReadFloat();
				break;
			case 109u:
				StaminaCostMoveFast = input.ReadFloat();
				break;
			case 117u:
				StaminaDepletedLimitBase = input.ReadFloat();
				break;
			case 120u:
				NoStaminaBuffID = input.ReadInt32();
				break;
			case 128u:
				RebirthSkillID = input.ReadInt32();
				break;
			case 141u:
				MoveBackSpeedRate = input.ReadFloat();
				break;
			case 149u:
				JumpSpeedNormal = input.ReadFloat();
				break;
			case 157u:
				JumpSpeedFast = input.ReadFloat();
				break;
			case 165u:
				JumpHorFixedMaxOffset = input.ReadFloat();
				break;
			case 173u:
				JumpHorFixedSpd = input.ReadFloat();
				break;
			case 181u:
				JumpVerFixedMaxOffset = input.ReadFloat();
				break;
			case 189u:
				JumpVerFixedSpd = input.ReadFloat();
				break;
			case 197u:
				LockJumpRotSpdF = input.ReadFloat();
				break;
			case 205u:
				LockJumpRotSpdB = input.ReadFloat();
				break;
			case 213u:
				LockJumpRotSpdL = input.ReadFloat();
				break;
			case 221u:
				LockJumpRotSpdR = input.ReadFloat();
				break;
			case 229u:
				AirAtkJumpProtectTime = input.ReadFloat();
				break;
			case 237u:
				AirAtkFallingProtectTime = input.ReadFloat();
				break;
			case 245u:
				FallingDamageMultiplier = input.ReadFloat();
				break;
			case 248u:
			case 250u:
				jumpBuffID_.AddEntriesFrom(input, _repeated_jumpBuffID_codec);
				break;
			case 261u:
				ManualSplineMoveMaxInputAngle = input.ReadFloat();
				break;
			case 269u:
				ManualSplineMoveCameraTraceSpeedRate = input.ReadFloat();
				break;
			case 277u:
				ManualSplineMoveCameraPauseTime = input.ReadFloat();
				break;
			case 280u:
				TeleportSkillID = input.ReadInt32();
				break;
			case 288u:
				DisableWalk = (EGSYesNo)input.ReadEnum();
				break;
			case 296u:
				UnFreezeCount = input.ReadInt32();
				break;
			case 309u:
				UnFreezeEventGap = input.ReadFloat();
				break;
			case 314u:
				UnFreezeAdditiveAMPath = input.ReadString();
				break;
			case 322u:
				UnFreezeFXPath = input.ReadString();
				break;
			case 333u:
				MoveInputFilterTime = input.ReadFloat();
				break;
			}
		}
	}
}
