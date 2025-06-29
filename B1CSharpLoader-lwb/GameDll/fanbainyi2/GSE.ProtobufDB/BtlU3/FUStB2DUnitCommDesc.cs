using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DUnitCommDesc : IMessage<FUStB2DUnitCommDesc>, IMessage, IEquatable<FUStB2DUnitCommDesc>, IDeepCloneable<FUStB2DUnitCommDesc>
{
	private static readonly MessageParser<FUStB2DUnitCommDesc> _parser = new MessageParser<FUStB2DUnitCommDesc>(() => new FUStB2DUnitCommDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private string bPPath_ = "";

	private int radius_;

	private int unitFilter_;

	private int aITargetFilter_;

	private int delayDestroyActorTime_;

	private string deadRes_ = "";

	private int scaleRatio_;

	private int beDmgMpAddRate_;

	private int beDmgMpAddExtra_;

	private int mspd_;

	private int visionRange_;

	private int height_;

	private string stunRes_ = "";

	private string knockupRes_ = "";

	private EBGUBloodBarType bloodBar_;

	private EBGUBloodBarShowType bloodBarShow_;

	private float skillHideTime_;

	private int turnSpd_;

	private static readonly FieldCodec<int> _repeated_skills_codec = FieldCodec.ForInt32(170u);

	private readonly RepeatedField<int> skills_ = new RepeatedField<int>();

	private string beatbackRes_ = "";

	private int isTrapUnit_;

	private string soundPrefix_ = "";

	private string btName_ = "";

	private EBehitType beHitType_;

	private float beHitRate_;

	private int battleVisionRange_;

	private EB2DUnitThreatenType threatenType_;

	private int careerHatredCoefficient_;

	private int heroBornBuff_;

	private int isFollowUp_;

	private float delayFollowUpTime_;

	public static MessageParser<FUStB2DUnitCommDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BPPath
	{
		get
		{
			return bPPath_;
		}
		set
		{
			bPPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Radius
	{
		get
		{
			return radius_;
		}
		set
		{
			radius_ = value;
		}
	}

	public int UnitFilter
	{
		get
		{
			return unitFilter_;
		}
		set
		{
			unitFilter_ = value;
		}
	}

	public int AITargetFilter
	{
		get
		{
			return aITargetFilter_;
		}
		set
		{
			aITargetFilter_ = value;
		}
	}

	public int DelayDestroyActorTime
	{
		get
		{
			return delayDestroyActorTime_;
		}
		set
		{
			delayDestroyActorTime_ = value;
		}
	}

	public string DeadRes
	{
		get
		{
			return deadRes_;
		}
		set
		{
			deadRes_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ScaleRatio
	{
		get
		{
			return scaleRatio_;
		}
		set
		{
			scaleRatio_ = value;
		}
	}

	public int BeDmgMpAddRate
	{
		get
		{
			return beDmgMpAddRate_;
		}
		set
		{
			beDmgMpAddRate_ = value;
		}
	}

	public int BeDmgMpAddExtra
	{
		get
		{
			return beDmgMpAddExtra_;
		}
		set
		{
			beDmgMpAddExtra_ = value;
		}
	}

	public int Mspd
	{
		get
		{
			return mspd_;
		}
		set
		{
			mspd_ = value;
		}
	}

	public int VisionRange
	{
		get
		{
			return visionRange_;
		}
		set
		{
			visionRange_ = value;
		}
	}

	public int Height
	{
		get
		{
			return height_;
		}
		set
		{
			height_ = value;
		}
	}

	public string StunRes
	{
		get
		{
			return stunRes_;
		}
		set
		{
			stunRes_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string KnockupRes
	{
		get
		{
			return knockupRes_;
		}
		set
		{
			knockupRes_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EBGUBloodBarType BloodBar
	{
		get
		{
			return bloodBar_;
		}
		set
		{
			bloodBar_ = value;
		}
	}

	public EBGUBloodBarShowType BloodBarShow
	{
		get
		{
			return bloodBarShow_;
		}
		set
		{
			bloodBarShow_ = value;
		}
	}

	public float SkillHideTime
	{
		get
		{
			return skillHideTime_;
		}
		set
		{
			skillHideTime_ = value;
		}
	}

	public int TurnSpd
	{
		get
		{
			return turnSpd_;
		}
		set
		{
			turnSpd_ = value;
		}
	}

	public RepeatedField<int> Skills => skills_;

	public string BeatbackRes
	{
		get
		{
			return beatbackRes_;
		}
		set
		{
			beatbackRes_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int IsTrapUnit
	{
		get
		{
			return isTrapUnit_;
		}
		set
		{
			isTrapUnit_ = value;
		}
	}

	public string SoundPrefix
	{
		get
		{
			return soundPrefix_;
		}
		set
		{
			soundPrefix_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BtName
	{
		get
		{
			return btName_;
		}
		set
		{
			btName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EBehitType BeHitType
	{
		get
		{
			return beHitType_;
		}
		set
		{
			beHitType_ = value;
		}
	}

	public float BeHitRate
	{
		get
		{
			return beHitRate_;
		}
		set
		{
			beHitRate_ = value;
		}
	}

	public int BattleVisionRange
	{
		get
		{
			return battleVisionRange_;
		}
		set
		{
			battleVisionRange_ = value;
		}
	}

	public EB2DUnitThreatenType ThreatenType
	{
		get
		{
			return threatenType_;
		}
		set
		{
			threatenType_ = value;
		}
	}

	public int CareerHatredCoefficient
	{
		get
		{
			return careerHatredCoefficient_;
		}
		set
		{
			careerHatredCoefficient_ = value;
		}
	}

	public int HeroBornBuff
	{
		get
		{
			return heroBornBuff_;
		}
		set
		{
			heroBornBuff_ = value;
		}
	}

	public int IsFollowUp
	{
		get
		{
			return isFollowUp_;
		}
		set
		{
			isFollowUp_ = value;
		}
	}

	public float DelayFollowUpTime
	{
		get
		{
			return delayFollowUpTime_;
		}
		set
		{
			delayFollowUpTime_ = value;
		}
	}

	public FUStB2DUnitCommDesc()
	{
	}

	public FUStB2DUnitCommDesc(FUStB2DUnitCommDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		bPPath_ = other.bPPath_;
		radius_ = other.radius_;
		unitFilter_ = other.unitFilter_;
		aITargetFilter_ = other.aITargetFilter_;
		delayDestroyActorTime_ = other.delayDestroyActorTime_;
		deadRes_ = other.deadRes_;
		scaleRatio_ = other.scaleRatio_;
		beDmgMpAddRate_ = other.beDmgMpAddRate_;
		beDmgMpAddExtra_ = other.beDmgMpAddExtra_;
		mspd_ = other.mspd_;
		visionRange_ = other.visionRange_;
		height_ = other.height_;
		stunRes_ = other.stunRes_;
		knockupRes_ = other.knockupRes_;
		bloodBar_ = other.bloodBar_;
		bloodBarShow_ = other.bloodBarShow_;
		skillHideTime_ = other.skillHideTime_;
		turnSpd_ = other.turnSpd_;
		skills_ = other.skills_.Clone();
		beatbackRes_ = other.beatbackRes_;
		isTrapUnit_ = other.isTrapUnit_;
		soundPrefix_ = other.soundPrefix_;
		btName_ = other.btName_;
		beHitType_ = other.beHitType_;
		beHitRate_ = other.beHitRate_;
		battleVisionRange_ = other.battleVisionRange_;
		threatenType_ = other.threatenType_;
		careerHatredCoefficient_ = other.careerHatredCoefficient_;
		heroBornBuff_ = other.heroBornBuff_;
		isFollowUp_ = other.isFollowUp_;
		delayFollowUpTime_ = other.delayFollowUpTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DUnitCommDesc Clone()
	{
		return new FUStB2DUnitCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DUnitCommDesc);
	}

	public bool Equals(FUStB2DUnitCommDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (BPPath != other.BPPath)
		{
			return false;
		}
		if (Radius != other.Radius)
		{
			return false;
		}
		if (UnitFilter != other.UnitFilter)
		{
			return false;
		}
		if (AITargetFilter != other.AITargetFilter)
		{
			return false;
		}
		if (DelayDestroyActorTime != other.DelayDestroyActorTime)
		{
			return false;
		}
		if (DeadRes != other.DeadRes)
		{
			return false;
		}
		if (ScaleRatio != other.ScaleRatio)
		{
			return false;
		}
		if (BeDmgMpAddRate != other.BeDmgMpAddRate)
		{
			return false;
		}
		if (BeDmgMpAddExtra != other.BeDmgMpAddExtra)
		{
			return false;
		}
		if (Mspd != other.Mspd)
		{
			return false;
		}
		if (VisionRange != other.VisionRange)
		{
			return false;
		}
		if (Height != other.Height)
		{
			return false;
		}
		if (StunRes != other.StunRes)
		{
			return false;
		}
		if (KnockupRes != other.KnockupRes)
		{
			return false;
		}
		if (BloodBar != other.BloodBar)
		{
			return false;
		}
		if (BloodBarShow != other.BloodBarShow)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SkillHideTime, other.SkillHideTime))
		{
			return false;
		}
		if (TurnSpd != other.TurnSpd)
		{
			return false;
		}
		if (!skills_.Equals(other.skills_))
		{
			return false;
		}
		if (BeatbackRes != other.BeatbackRes)
		{
			return false;
		}
		if (IsTrapUnit != other.IsTrapUnit)
		{
			return false;
		}
		if (SoundPrefix != other.SoundPrefix)
		{
			return false;
		}
		if (BtName != other.BtName)
		{
			return false;
		}
		if (BeHitType != other.BeHitType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BeHitRate, other.BeHitRate))
		{
			return false;
		}
		if (BattleVisionRange != other.BattleVisionRange)
		{
			return false;
		}
		if (ThreatenType != other.ThreatenType)
		{
			return false;
		}
		if (CareerHatredCoefficient != other.CareerHatredCoefficient)
		{
			return false;
		}
		if (HeroBornBuff != other.HeroBornBuff)
		{
			return false;
		}
		if (IsFollowUp != other.IsFollowUp)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DelayFollowUpTime, other.DelayFollowUpTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (BPPath.Length != 0)
		{
			num ^= BPPath.GetHashCode();
		}
		if (Radius != 0)
		{
			num ^= Radius.GetHashCode();
		}
		if (UnitFilter != 0)
		{
			num ^= UnitFilter.GetHashCode();
		}
		if (AITargetFilter != 0)
		{
			num ^= AITargetFilter.GetHashCode();
		}
		if (DelayDestroyActorTime != 0)
		{
			num ^= DelayDestroyActorTime.GetHashCode();
		}
		if (DeadRes.Length != 0)
		{
			num ^= DeadRes.GetHashCode();
		}
		if (ScaleRatio != 0)
		{
			num ^= ScaleRatio.GetHashCode();
		}
		if (BeDmgMpAddRate != 0)
		{
			num ^= BeDmgMpAddRate.GetHashCode();
		}
		if (BeDmgMpAddExtra != 0)
		{
			num ^= BeDmgMpAddExtra.GetHashCode();
		}
		if (Mspd != 0)
		{
			num ^= Mspd.GetHashCode();
		}
		if (VisionRange != 0)
		{
			num ^= VisionRange.GetHashCode();
		}
		if (Height != 0)
		{
			num ^= Height.GetHashCode();
		}
		if (StunRes.Length != 0)
		{
			num ^= StunRes.GetHashCode();
		}
		if (KnockupRes.Length != 0)
		{
			num ^= KnockupRes.GetHashCode();
		}
		if (BloodBar != EBGUBloodBarType.None)
		{
			num ^= BloodBar.GetHashCode();
		}
		if (BloodBarShow != EBGUBloodBarShowType.Hide)
		{
			num ^= BloodBarShow.GetHashCode();
		}
		if (SkillHideTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SkillHideTime);
		}
		if (TurnSpd != 0)
		{
			num ^= TurnSpd.GetHashCode();
		}
		num ^= skills_.GetHashCode();
		if (BeatbackRes.Length != 0)
		{
			num ^= BeatbackRes.GetHashCode();
		}
		if (IsTrapUnit != 0)
		{
			num ^= IsTrapUnit.GetHashCode();
		}
		if (SoundPrefix.Length != 0)
		{
			num ^= SoundPrefix.GetHashCode();
		}
		if (BtName.Length != 0)
		{
			num ^= BtName.GetHashCode();
		}
		if (BeHitType != EBehitType.Biology)
		{
			num ^= BeHitType.GetHashCode();
		}
		if (BeHitRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BeHitRate);
		}
		if (BattleVisionRange != 0)
		{
			num ^= BattleVisionRange.GetHashCode();
		}
		if (ThreatenType != EB2DUnitThreatenType.Distance)
		{
			num ^= ThreatenType.GetHashCode();
		}
		if (CareerHatredCoefficient != 0)
		{
			num ^= CareerHatredCoefficient.GetHashCode();
		}
		if (HeroBornBuff != 0)
		{
			num ^= HeroBornBuff.GetHashCode();
		}
		if (IsFollowUp != 0)
		{
			num ^= IsFollowUp.GetHashCode();
		}
		if (DelayFollowUpTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DelayFollowUpTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (BPPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BPPath);
		}
		if (Radius != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Radius);
		}
		if (UnitFilter != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(UnitFilter);
		}
		if (AITargetFilter != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(AITargetFilter);
		}
		if (DelayDestroyActorTime != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DelayDestroyActorTime);
		}
		if (DeadRes.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(DeadRes);
		}
		if (ScaleRatio != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ScaleRatio);
		}
		if (BeDmgMpAddRate != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(BeDmgMpAddRate);
		}
		if (BeDmgMpAddExtra != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(BeDmgMpAddExtra);
		}
		if (Mspd != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Mspd);
		}
		if (VisionRange != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(VisionRange);
		}
		if (Height != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(Height);
		}
		if (StunRes.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(StunRes);
		}
		if (KnockupRes.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(KnockupRes);
		}
		if (BloodBar != EBGUBloodBarType.None)
		{
			output.WriteRawTag(136, 1);
			output.WriteEnum((int)BloodBar);
		}
		if (BloodBarShow != EBGUBloodBarShowType.Hide)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)BloodBarShow);
		}
		if (SkillHideTime != 0f)
		{
			output.WriteRawTag(157, 1);
			output.WriteFloat(SkillHideTime);
		}
		if (TurnSpd != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(TurnSpd);
		}
		skills_.WriteTo(output, _repeated_skills_codec);
		if (BeatbackRes.Length != 0)
		{
			output.WriteRawTag(178, 1);
			output.WriteString(BeatbackRes);
		}
		if (IsTrapUnit != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(IsTrapUnit);
		}
		if (SoundPrefix.Length != 0)
		{
			output.WriteRawTag(194, 1);
			output.WriteString(SoundPrefix);
		}
		if (BtName.Length != 0)
		{
			output.WriteRawTag(202, 1);
			output.WriteString(BtName);
		}
		if (BeHitType != EBehitType.Biology)
		{
			output.WriteRawTag(208, 1);
			output.WriteEnum((int)BeHitType);
		}
		if (BeHitRate != 0f)
		{
			output.WriteRawTag(221, 1);
			output.WriteFloat(BeHitRate);
		}
		if (BattleVisionRange != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(BattleVisionRange);
		}
		if (ThreatenType != EB2DUnitThreatenType.Distance)
		{
			output.WriteRawTag(232, 1);
			output.WriteEnum((int)ThreatenType);
		}
		if (CareerHatredCoefficient != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(CareerHatredCoefficient);
		}
		if (HeroBornBuff != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(HeroBornBuff);
		}
		if (IsFollowUp != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(IsFollowUp);
		}
		if (DelayFollowUpTime != 0f)
		{
			output.WriteRawTag(141, 2);
			output.WriteFloat(DelayFollowUpTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (BPPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BPPath);
		}
		if (Radius != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Radius);
		}
		if (UnitFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitFilter);
		}
		if (AITargetFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AITargetFilter);
		}
		if (DelayDestroyActorTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DelayDestroyActorTime);
		}
		if (DeadRes.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadRes);
		}
		if (ScaleRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScaleRatio);
		}
		if (BeDmgMpAddRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BeDmgMpAddRate);
		}
		if (BeDmgMpAddExtra != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BeDmgMpAddExtra);
		}
		if (Mspd != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Mspd);
		}
		if (VisionRange != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(VisionRange);
		}
		if (Height != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Height);
		}
		if (StunRes.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StunRes);
		}
		if (KnockupRes.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(KnockupRes);
		}
		if (BloodBar != EBGUBloodBarType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BloodBar);
		}
		if (BloodBarShow != EBGUBloodBarShowType.Hide)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BloodBarShow);
		}
		if (SkillHideTime != 0f)
		{
			num += 6;
		}
		if (TurnSpd != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TurnSpd);
		}
		num += skills_.CalculateSize(_repeated_skills_codec);
		if (BeatbackRes.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BeatbackRes);
		}
		if (IsTrapUnit != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IsTrapUnit);
		}
		if (SoundPrefix.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(SoundPrefix);
		}
		if (BtName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BtName);
		}
		if (BeHitType != EBehitType.Biology)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BeHitType);
		}
		if (BeHitRate != 0f)
		{
			num += 6;
		}
		if (BattleVisionRange != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BattleVisionRange);
		}
		if (ThreatenType != EB2DUnitThreatenType.Distance)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ThreatenType);
		}
		if (CareerHatredCoefficient != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CareerHatredCoefficient);
		}
		if (HeroBornBuff != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(HeroBornBuff);
		}
		if (IsFollowUp != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IsFollowUp);
		}
		if (DelayFollowUpTime != 0f)
		{
			num += 6;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DUnitCommDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.BPPath.Length != 0)
			{
				BPPath = other.BPPath;
			}
			if (other.Radius != 0)
			{
				Radius = other.Radius;
			}
			if (other.UnitFilter != 0)
			{
				UnitFilter = other.UnitFilter;
			}
			if (other.AITargetFilter != 0)
			{
				AITargetFilter = other.AITargetFilter;
			}
			if (other.DelayDestroyActorTime != 0)
			{
				DelayDestroyActorTime = other.DelayDestroyActorTime;
			}
			if (other.DeadRes.Length != 0)
			{
				DeadRes = other.DeadRes;
			}
			if (other.ScaleRatio != 0)
			{
				ScaleRatio = other.ScaleRatio;
			}
			if (other.BeDmgMpAddRate != 0)
			{
				BeDmgMpAddRate = other.BeDmgMpAddRate;
			}
			if (other.BeDmgMpAddExtra != 0)
			{
				BeDmgMpAddExtra = other.BeDmgMpAddExtra;
			}
			if (other.Mspd != 0)
			{
				Mspd = other.Mspd;
			}
			if (other.VisionRange != 0)
			{
				VisionRange = other.VisionRange;
			}
			if (other.Height != 0)
			{
				Height = other.Height;
			}
			if (other.StunRes.Length != 0)
			{
				StunRes = other.StunRes;
			}
			if (other.KnockupRes.Length != 0)
			{
				KnockupRes = other.KnockupRes;
			}
			if (other.BloodBar != EBGUBloodBarType.None)
			{
				BloodBar = other.BloodBar;
			}
			if (other.BloodBarShow != EBGUBloodBarShowType.Hide)
			{
				BloodBarShow = other.BloodBarShow;
			}
			if (other.SkillHideTime != 0f)
			{
				SkillHideTime = other.SkillHideTime;
			}
			if (other.TurnSpd != 0)
			{
				TurnSpd = other.TurnSpd;
			}
			skills_.Add(other.skills_);
			if (other.BeatbackRes.Length != 0)
			{
				BeatbackRes = other.BeatbackRes;
			}
			if (other.IsTrapUnit != 0)
			{
				IsTrapUnit = other.IsTrapUnit;
			}
			if (other.SoundPrefix.Length != 0)
			{
				SoundPrefix = other.SoundPrefix;
			}
			if (other.BtName.Length != 0)
			{
				BtName = other.BtName;
			}
			if (other.BeHitType != EBehitType.Biology)
			{
				BeHitType = other.BeHitType;
			}
			if (other.BeHitRate != 0f)
			{
				BeHitRate = other.BeHitRate;
			}
			if (other.BattleVisionRange != 0)
			{
				BattleVisionRange = other.BattleVisionRange;
			}
			if (other.ThreatenType != EB2DUnitThreatenType.Distance)
			{
				ThreatenType = other.ThreatenType;
			}
			if (other.CareerHatredCoefficient != 0)
			{
				CareerHatredCoefficient = other.CareerHatredCoefficient;
			}
			if (other.HeroBornBuff != 0)
			{
				HeroBornBuff = other.HeroBornBuff;
			}
			if (other.IsFollowUp != 0)
			{
				IsFollowUp = other.IsFollowUp;
			}
			if (other.DelayFollowUpTime != 0f)
			{
				DelayFollowUpTime = other.DelayFollowUpTime;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 26u:
				BPPath = input.ReadString();
				break;
			case 32u:
				Radius = input.ReadInt32();
				break;
			case 40u:
				UnitFilter = input.ReadInt32();
				break;
			case 48u:
				AITargetFilter = input.ReadInt32();
				break;
			case 56u:
				DelayDestroyActorTime = input.ReadInt32();
				break;
			case 66u:
				DeadRes = input.ReadString();
				break;
			case 72u:
				ScaleRatio = input.ReadInt32();
				break;
			case 80u:
				BeDmgMpAddRate = input.ReadInt32();
				break;
			case 88u:
				BeDmgMpAddExtra = input.ReadInt32();
				break;
			case 96u:
				Mspd = input.ReadInt32();
				break;
			case 104u:
				VisionRange = input.ReadInt32();
				break;
			case 112u:
				Height = input.ReadInt32();
				break;
			case 122u:
				StunRes = input.ReadString();
				break;
			case 130u:
				KnockupRes = input.ReadString();
				break;
			case 136u:
				BloodBar = (EBGUBloodBarType)input.ReadEnum();
				break;
			case 144u:
				BloodBarShow = (EBGUBloodBarShowType)input.ReadEnum();
				break;
			case 157u:
				SkillHideTime = input.ReadFloat();
				break;
			case 160u:
				TurnSpd = input.ReadInt32();
				break;
			case 168u:
			case 170u:
				skills_.AddEntriesFrom(input, _repeated_skills_codec);
				break;
			case 178u:
				BeatbackRes = input.ReadString();
				break;
			case 184u:
				IsTrapUnit = input.ReadInt32();
				break;
			case 194u:
				SoundPrefix = input.ReadString();
				break;
			case 202u:
				BtName = input.ReadString();
				break;
			case 208u:
				BeHitType = (EBehitType)input.ReadEnum();
				break;
			case 221u:
				BeHitRate = input.ReadFloat();
				break;
			case 224u:
				BattleVisionRange = input.ReadInt32();
				break;
			case 232u:
				ThreatenType = (EB2DUnitThreatenType)input.ReadEnum();
				break;
			case 240u:
				CareerHatredCoefficient = input.ReadInt32();
				break;
			case 248u:
				HeroBornBuff = input.ReadInt32();
				break;
			case 256u:
				IsFollowUp = input.ReadInt32();
				break;
			case 269u:
				DelayFollowUpTime = input.ReadFloat();
				break;
			}
		}
	}
}
