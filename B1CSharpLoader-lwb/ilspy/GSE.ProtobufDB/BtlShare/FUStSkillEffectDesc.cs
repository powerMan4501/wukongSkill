using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStSkillEffectDesc : IMessage<FUStSkillEffectDesc>, IMessage, IEquatable<FUStSkillEffectDesc>, IDeepCloneable<FUStSkillEffectDesc>
{
	private static readonly MessageParser<FUStSkillEffectDesc> _parser = new MessageParser<FUStSkillEffectDesc>(() => new FUStSkillEffectDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private FUStBuffEffectActiveCondition effectActiveCondition_;

	private EBuffAndSkillEffectType effectType_;

	private EBuffAndSkillEffectCategory effectCategory_;

	private EEffectTargetBase targetBase_;

	private int targetCount_;

	private int targetFilter_;

	private int targetTypeFilter_;

	private int affiliationTypeFilter_;

	private FUStRange range_;

	private EGSYesNo fXTransUseConfig_;

	private string playFXSocketName_ = "";

	private float playFXLocalDirX_;

	private float playFXLocalDirY_;

	private float playFXLocalDirZ_;

	private float fXCameraOffset_;

	private EHitActionDir hitActionDir_;

	private EHitOrientationType hitOrientationType_;

	private string hitOriBaseCompName_ = "";

	private EGSYesNo canFractureVictim_;

	private EGSYesNo canCutVictim_;

	private static readonly FieldCodec<int> _repeated_effectParamsInt_codec = FieldCodec.ForInt32(178u);

	private readonly RepeatedField<int> effectParamsInt_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_effectParamsFloat_codec = FieldCodec.ForFloat(186u);

	private readonly RepeatedField<float> effectParamsFloat_ = new RepeatedField<float>();

	private static readonly FieldCodec<string> _repeated_effectParamsStr_codec = FieldCodec.ForString(194u);

	private readonly RepeatedField<string> effectParamsStr_ = new RepeatedField<string>();

	private string guard_ = "";

	public static MessageParser<FUStSkillEffectDesc> Parser => _parser;

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

	public FUStBuffEffectActiveCondition EffectActiveCondition
	{
		get
		{
			return effectActiveCondition_;
		}
		set
		{
			effectActiveCondition_ = value;
		}
	}

	public EBuffAndSkillEffectType EffectType
	{
		get
		{
			return effectType_;
		}
		set
		{
			effectType_ = value;
		}
	}

	public EBuffAndSkillEffectCategory EffectCategory
	{
		get
		{
			return effectCategory_;
		}
		set
		{
			effectCategory_ = value;
		}
	}

	public EEffectTargetBase TargetBase
	{
		get
		{
			return targetBase_;
		}
		set
		{
			targetBase_ = value;
		}
	}

	public int TargetCount
	{
		get
		{
			return targetCount_;
		}
		set
		{
			targetCount_ = value;
		}
	}

	public int TargetFilter
	{
		get
		{
			return targetFilter_;
		}
		set
		{
			targetFilter_ = value;
		}
	}

	public int TargetTypeFilter
	{
		get
		{
			return targetTypeFilter_;
		}
		set
		{
			targetTypeFilter_ = value;
		}
	}

	public int AffiliationTypeFilter
	{
		get
		{
			return affiliationTypeFilter_;
		}
		set
		{
			affiliationTypeFilter_ = value;
		}
	}

	public FUStRange Range
	{
		get
		{
			return range_;
		}
		set
		{
			range_ = value;
		}
	}

	public EGSYesNo FXTransUseConfig
	{
		get
		{
			return fXTransUseConfig_;
		}
		set
		{
			fXTransUseConfig_ = value;
		}
	}

	public string PlayFXSocketName
	{
		get
		{
			return playFXSocketName_;
		}
		set
		{
			playFXSocketName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float PlayFXLocalDirX
	{
		get
		{
			return playFXLocalDirX_;
		}
		set
		{
			playFXLocalDirX_ = value;
		}
	}

	public float PlayFXLocalDirY
	{
		get
		{
			return playFXLocalDirY_;
		}
		set
		{
			playFXLocalDirY_ = value;
		}
	}

	public float PlayFXLocalDirZ
	{
		get
		{
			return playFXLocalDirZ_;
		}
		set
		{
			playFXLocalDirZ_ = value;
		}
	}

	public float FXCameraOffset
	{
		get
		{
			return fXCameraOffset_;
		}
		set
		{
			fXCameraOffset_ = value;
		}
	}

	public EHitActionDir HitActionDir
	{
		get
		{
			return hitActionDir_;
		}
		set
		{
			hitActionDir_ = value;
		}
	}

	public EHitOrientationType HitOrientationType
	{
		get
		{
			return hitOrientationType_;
		}
		set
		{
			hitOrientationType_ = value;
		}
	}

	public string HitOriBaseCompName
	{
		get
		{
			return hitOriBaseCompName_;
		}
		set
		{
			hitOriBaseCompName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo CanFractureVictim
	{
		get
		{
			return canFractureVictim_;
		}
		set
		{
			canFractureVictim_ = value;
		}
	}

	public EGSYesNo CanCutVictim
	{
		get
		{
			return canCutVictim_;
		}
		set
		{
			canCutVictim_ = value;
		}
	}

	public RepeatedField<int> EffectParamsInt => effectParamsInt_;

	public RepeatedField<float> EffectParamsFloat => effectParamsFloat_;

	public RepeatedField<string> EffectParamsStr => effectParamsStr_;

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

	public FUStSkillEffectDesc()
	{
	}

	public FUStSkillEffectDesc(FUStSkillEffectDesc other)
		: this()
	{
		iD_ = other.iD_;
		effectActiveCondition_ = ((other.effectActiveCondition_ != null) ? other.effectActiveCondition_.Clone() : null);
		effectType_ = other.effectType_;
		effectCategory_ = other.effectCategory_;
		targetBase_ = other.targetBase_;
		targetCount_ = other.targetCount_;
		targetFilter_ = other.targetFilter_;
		targetTypeFilter_ = other.targetTypeFilter_;
		affiliationTypeFilter_ = other.affiliationTypeFilter_;
		range_ = ((other.range_ != null) ? other.range_.Clone() : null);
		fXTransUseConfig_ = other.fXTransUseConfig_;
		playFXSocketName_ = other.playFXSocketName_;
		playFXLocalDirX_ = other.playFXLocalDirX_;
		playFXLocalDirY_ = other.playFXLocalDirY_;
		playFXLocalDirZ_ = other.playFXLocalDirZ_;
		fXCameraOffset_ = other.fXCameraOffset_;
		hitActionDir_ = other.hitActionDir_;
		hitOrientationType_ = other.hitOrientationType_;
		hitOriBaseCompName_ = other.hitOriBaseCompName_;
		canFractureVictim_ = other.canFractureVictim_;
		canCutVictim_ = other.canCutVictim_;
		effectParamsInt_ = other.effectParamsInt_.Clone();
		effectParamsFloat_ = other.effectParamsFloat_.Clone();
		effectParamsStr_ = other.effectParamsStr_.Clone();
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSkillEffectDesc Clone()
	{
		return new FUStSkillEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSkillEffectDesc);
	}

	public bool Equals(FUStSkillEffectDesc other)
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
		if (!object.Equals(EffectActiveCondition, other.EffectActiveCondition))
		{
			return false;
		}
		if (EffectType != other.EffectType)
		{
			return false;
		}
		if (EffectCategory != other.EffectCategory)
		{
			return false;
		}
		if (TargetBase != other.TargetBase)
		{
			return false;
		}
		if (TargetCount != other.TargetCount)
		{
			return false;
		}
		if (TargetFilter != other.TargetFilter)
		{
			return false;
		}
		if (TargetTypeFilter != other.TargetTypeFilter)
		{
			return false;
		}
		if (AffiliationTypeFilter != other.AffiliationTypeFilter)
		{
			return false;
		}
		if (!object.Equals(Range, other.Range))
		{
			return false;
		}
		if (FXTransUseConfig != other.FXTransUseConfig)
		{
			return false;
		}
		if (PlayFXSocketName != other.PlayFXSocketName)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayFXLocalDirX, other.PlayFXLocalDirX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayFXLocalDirY, other.PlayFXLocalDirY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayFXLocalDirZ, other.PlayFXLocalDirZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FXCameraOffset, other.FXCameraOffset))
		{
			return false;
		}
		if (HitActionDir != other.HitActionDir)
		{
			return false;
		}
		if (HitOrientationType != other.HitOrientationType)
		{
			return false;
		}
		if (HitOriBaseCompName != other.HitOriBaseCompName)
		{
			return false;
		}
		if (CanFractureVictim != other.CanFractureVictim)
		{
			return false;
		}
		if (CanCutVictim != other.CanCutVictim)
		{
			return false;
		}
		if (!effectParamsInt_.Equals(other.effectParamsInt_))
		{
			return false;
		}
		if (!effectParamsFloat_.Equals(other.effectParamsFloat_))
		{
			return false;
		}
		if (!effectParamsStr_.Equals(other.effectParamsStr_))
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
		if (effectActiveCondition_ != null)
		{
			num ^= EffectActiveCondition.GetHashCode();
		}
		if (EffectType != EBuffAndSkillEffectType.None)
		{
			num ^= EffectType.GetHashCode();
		}
		if (EffectCategory != EBuffAndSkillEffectCategory.Neutral)
		{
			num ^= EffectCategory.GetHashCode();
		}
		if (TargetBase != EEffectTargetBase.Self)
		{
			num ^= TargetBase.GetHashCode();
		}
		if (TargetCount != 0)
		{
			num ^= TargetCount.GetHashCode();
		}
		if (TargetFilter != 0)
		{
			num ^= TargetFilter.GetHashCode();
		}
		if (TargetTypeFilter != 0)
		{
			num ^= TargetTypeFilter.GetHashCode();
		}
		if (AffiliationTypeFilter != 0)
		{
			num ^= AffiliationTypeFilter.GetHashCode();
		}
		if (range_ != null)
		{
			num ^= Range.GetHashCode();
		}
		if (FXTransUseConfig != EGSYesNo.No)
		{
			num ^= FXTransUseConfig.GetHashCode();
		}
		if (PlayFXSocketName.Length != 0)
		{
			num ^= PlayFXSocketName.GetHashCode();
		}
		if (PlayFXLocalDirX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayFXLocalDirX);
		}
		if (PlayFXLocalDirY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayFXLocalDirY);
		}
		if (PlayFXLocalDirZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayFXLocalDirZ);
		}
		if (FXCameraOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FXCameraOffset);
		}
		if (HitActionDir != EHitActionDir.Default)
		{
			num ^= HitActionDir.GetHashCode();
		}
		if (HitOrientationType != EHitOrientationType.None)
		{
			num ^= HitOrientationType.GetHashCode();
		}
		if (HitOriBaseCompName.Length != 0)
		{
			num ^= HitOriBaseCompName.GetHashCode();
		}
		if (CanFractureVictim != EGSYesNo.No)
		{
			num ^= CanFractureVictim.GetHashCode();
		}
		if (CanCutVictim != EGSYesNo.No)
		{
			num ^= CanCutVictim.GetHashCode();
		}
		num ^= effectParamsInt_.GetHashCode();
		num ^= effectParamsFloat_.GetHashCode();
		num ^= effectParamsStr_.GetHashCode();
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
		if (effectActiveCondition_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EffectActiveCondition);
		}
		if (EffectType != EBuffAndSkillEffectType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)EffectType);
		}
		if (EffectCategory != EBuffAndSkillEffectCategory.Neutral)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)EffectCategory);
		}
		if (TargetBase != EEffectTargetBase.Self)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)TargetBase);
		}
		if (TargetCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TargetCount);
		}
		if (TargetFilter != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TargetFilter);
		}
		if (TargetTypeFilter != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TargetTypeFilter);
		}
		if (AffiliationTypeFilter != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(AffiliationTypeFilter);
		}
		if (range_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Range);
		}
		if (FXTransUseConfig != EGSYesNo.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)FXTransUseConfig);
		}
		if (PlayFXSocketName.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(PlayFXSocketName);
		}
		if (PlayFXLocalDirX != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(PlayFXLocalDirX);
		}
		if (PlayFXLocalDirY != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(PlayFXLocalDirY);
		}
		if (PlayFXLocalDirZ != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(PlayFXLocalDirZ);
		}
		if (FXCameraOffset != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(FXCameraOffset);
		}
		if (HitActionDir != EHitActionDir.Default)
		{
			output.WriteRawTag(136, 1);
			output.WriteEnum((int)HitActionDir);
		}
		if (HitOrientationType != EHitOrientationType.None)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)HitOrientationType);
		}
		if (HitOriBaseCompName.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(HitOriBaseCompName);
		}
		if (CanFractureVictim != EGSYesNo.No)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)CanFractureVictim);
		}
		if (CanCutVictim != EGSYesNo.No)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)CanCutVictim);
		}
		effectParamsInt_.WriteTo(output, _repeated_effectParamsInt_codec);
		effectParamsFloat_.WriteTo(output, _repeated_effectParamsFloat_codec);
		effectParamsStr_.WriteTo(output, _repeated_effectParamsStr_codec);
		if (Guard.Length != 0)
		{
			output.WriteRawTag(202, 1);
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
		if (effectActiveCondition_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EffectActiveCondition);
		}
		if (EffectType != EBuffAndSkillEffectType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectType);
		}
		if (EffectCategory != EBuffAndSkillEffectCategory.Neutral)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectCategory);
		}
		if (TargetBase != EEffectTargetBase.Self)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TargetBase);
		}
		if (TargetCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetCount);
		}
		if (TargetFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetFilter);
		}
		if (TargetTypeFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetTypeFilter);
		}
		if (AffiliationTypeFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AffiliationTypeFilter);
		}
		if (range_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Range);
		}
		if (FXTransUseConfig != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FXTransUseConfig);
		}
		if (PlayFXSocketName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PlayFXSocketName);
		}
		if (PlayFXLocalDirX != 0f)
		{
			num += 5;
		}
		if (PlayFXLocalDirY != 0f)
		{
			num += 5;
		}
		if (PlayFXLocalDirZ != 0f)
		{
			num += 5;
		}
		if (FXCameraOffset != 0f)
		{
			num += 6;
		}
		if (HitActionDir != EHitActionDir.Default)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)HitActionDir);
		}
		if (HitOrientationType != EHitOrientationType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)HitOrientationType);
		}
		if (HitOriBaseCompName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(HitOriBaseCompName);
		}
		if (CanFractureVictim != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CanFractureVictim);
		}
		if (CanCutVictim != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CanCutVictim);
		}
		num += effectParamsInt_.CalculateSize(_repeated_effectParamsInt_codec);
		num += effectParamsFloat_.CalculateSize(_repeated_effectParamsFloat_codec);
		num += effectParamsStr_.CalculateSize(_repeated_effectParamsStr_codec);
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

	public void MergeFrom(FUStSkillEffectDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.effectActiveCondition_ != null)
		{
			if (effectActiveCondition_ == null)
			{
				EffectActiveCondition = new FUStBuffEffectActiveCondition();
			}
			EffectActiveCondition.MergeFrom(other.EffectActiveCondition);
		}
		if (other.EffectType != EBuffAndSkillEffectType.None)
		{
			EffectType = other.EffectType;
		}
		if (other.EffectCategory != EBuffAndSkillEffectCategory.Neutral)
		{
			EffectCategory = other.EffectCategory;
		}
		if (other.TargetBase != EEffectTargetBase.Self)
		{
			TargetBase = other.TargetBase;
		}
		if (other.TargetCount != 0)
		{
			TargetCount = other.TargetCount;
		}
		if (other.TargetFilter != 0)
		{
			TargetFilter = other.TargetFilter;
		}
		if (other.TargetTypeFilter != 0)
		{
			TargetTypeFilter = other.TargetTypeFilter;
		}
		if (other.AffiliationTypeFilter != 0)
		{
			AffiliationTypeFilter = other.AffiliationTypeFilter;
		}
		if (other.range_ != null)
		{
			if (range_ == null)
			{
				Range = new FUStRange();
			}
			Range.MergeFrom(other.Range);
		}
		if (other.FXTransUseConfig != EGSYesNo.No)
		{
			FXTransUseConfig = other.FXTransUseConfig;
		}
		if (other.PlayFXSocketName.Length != 0)
		{
			PlayFXSocketName = other.PlayFXSocketName;
		}
		if (other.PlayFXLocalDirX != 0f)
		{
			PlayFXLocalDirX = other.PlayFXLocalDirX;
		}
		if (other.PlayFXLocalDirY != 0f)
		{
			PlayFXLocalDirY = other.PlayFXLocalDirY;
		}
		if (other.PlayFXLocalDirZ != 0f)
		{
			PlayFXLocalDirZ = other.PlayFXLocalDirZ;
		}
		if (other.FXCameraOffset != 0f)
		{
			FXCameraOffset = other.FXCameraOffset;
		}
		if (other.HitActionDir != EHitActionDir.Default)
		{
			HitActionDir = other.HitActionDir;
		}
		if (other.HitOrientationType != EHitOrientationType.None)
		{
			HitOrientationType = other.HitOrientationType;
		}
		if (other.HitOriBaseCompName.Length != 0)
		{
			HitOriBaseCompName = other.HitOriBaseCompName;
		}
		if (other.CanFractureVictim != EGSYesNo.No)
		{
			CanFractureVictim = other.CanFractureVictim;
		}
		if (other.CanCutVictim != EGSYesNo.No)
		{
			CanCutVictim = other.CanCutVictim;
		}
		effectParamsInt_.Add(other.effectParamsInt_);
		effectParamsFloat_.Add(other.effectParamsFloat_);
		effectParamsStr_.Add(other.effectParamsStr_);
		if (other.Guard.Length != 0)
		{
			Guard = other.Guard;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				if (effectActiveCondition_ == null)
				{
					EffectActiveCondition = new FUStBuffEffectActiveCondition();
				}
				input.ReadMessage(EffectActiveCondition);
				break;
			case 24u:
				EffectType = (EBuffAndSkillEffectType)input.ReadEnum();
				break;
			case 32u:
				EffectCategory = (EBuffAndSkillEffectCategory)input.ReadEnum();
				break;
			case 40u:
				TargetBase = (EEffectTargetBase)input.ReadEnum();
				break;
			case 48u:
				TargetCount = input.ReadInt32();
				break;
			case 56u:
				TargetFilter = input.ReadInt32();
				break;
			case 64u:
				TargetTypeFilter = input.ReadInt32();
				break;
			case 72u:
				AffiliationTypeFilter = input.ReadInt32();
				break;
			case 82u:
				if (range_ == null)
				{
					Range = new FUStRange();
				}
				input.ReadMessage(Range);
				break;
			case 88u:
				FXTransUseConfig = (EGSYesNo)input.ReadEnum();
				break;
			case 98u:
				PlayFXSocketName = input.ReadString();
				break;
			case 109u:
				PlayFXLocalDirX = input.ReadFloat();
				break;
			case 117u:
				PlayFXLocalDirY = input.ReadFloat();
				break;
			case 125u:
				PlayFXLocalDirZ = input.ReadFloat();
				break;
			case 133u:
				FXCameraOffset = input.ReadFloat();
				break;
			case 136u:
				HitActionDir = (EHitActionDir)input.ReadEnum();
				break;
			case 144u:
				HitOrientationType = (EHitOrientationType)input.ReadEnum();
				break;
			case 154u:
				HitOriBaseCompName = input.ReadString();
				break;
			case 160u:
				CanFractureVictim = (EGSYesNo)input.ReadEnum();
				break;
			case 168u:
				CanCutVictim = (EGSYesNo)input.ReadEnum();
				break;
			case 176u:
			case 178u:
				effectParamsInt_.AddEntriesFrom(input, _repeated_effectParamsInt_codec);
				break;
			case 186u:
			case 189u:
				effectParamsFloat_.AddEntriesFrom(input, _repeated_effectParamsFloat_codec);
				break;
			case 194u:
				effectParamsStr_.AddEntriesFrom(input, _repeated_effectParamsStr_codec);
				break;
			case 202u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
