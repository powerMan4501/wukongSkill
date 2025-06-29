using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStMapMobConfigDesc : IMessage<FUStMapMobConfigDesc>, IMessage, IEquatable<FUStMapMobConfigDesc>, IDeepCloneable<FUStMapMobConfigDesc>
{
	private static readonly MessageParser<FUStMapMobConfigDesc> _parser = new MessageParser<FUStMapMobConfigDesc>(() => new FUStMapMobConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int buffConfigID_;

	private int eliteStartPhase_;

	private int maxEliteNum_;

	private int maxEliteNumPerPoint_;

	private float baseEliteChance_;

	private float eliteChanceIncrement_;

	private float marginEliteChance_;

	private int specialStartPhase_;

	private int maxSpecialNum_;

	private int maxSpecialNumPerPoint_;

	private float baseSpecialChance_;

	private float specialChanceIncrement_;

	private float marginSpecialChance_;

	private static readonly FieldCodec<FUStPhaseSpawnWaveConfig> _repeated_phaseConfig_codec = FieldCodec.ForMessage(122u, FUStPhaseSpawnWaveConfig.Parser);

	private readonly RepeatedField<FUStPhaseSpawnWaveConfig> phaseConfig_ = new RepeatedField<FUStPhaseSpawnWaveConfig>();

	private static readonly FieldCodec<FUStPhaseMobConfig> _repeated_generalMobConfig_codec = FieldCodec.ForMessage(130u, FUStPhaseMobConfig.Parser);

	private readonly RepeatedField<FUStPhaseMobConfig> generalMobConfig_ = new RepeatedField<FUStPhaseMobConfig>();

	public static MessageParser<FUStMapMobConfigDesc> Parser => _parser;

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

	public int BuffConfigID
	{
		get
		{
			return buffConfigID_;
		}
		set
		{
			buffConfigID_ = value;
		}
	}

	public int EliteStartPhase
	{
		get
		{
			return eliteStartPhase_;
		}
		set
		{
			eliteStartPhase_ = value;
		}
	}

	public int MaxEliteNum
	{
		get
		{
			return maxEliteNum_;
		}
		set
		{
			maxEliteNum_ = value;
		}
	}

	public int MaxEliteNumPerPoint
	{
		get
		{
			return maxEliteNumPerPoint_;
		}
		set
		{
			maxEliteNumPerPoint_ = value;
		}
	}

	public float BaseEliteChance
	{
		get
		{
			return baseEliteChance_;
		}
		set
		{
			baseEliteChance_ = value;
		}
	}

	public float EliteChanceIncrement
	{
		get
		{
			return eliteChanceIncrement_;
		}
		set
		{
			eliteChanceIncrement_ = value;
		}
	}

	public float MarginEliteChance
	{
		get
		{
			return marginEliteChance_;
		}
		set
		{
			marginEliteChance_ = value;
		}
	}

	public int SpecialStartPhase
	{
		get
		{
			return specialStartPhase_;
		}
		set
		{
			specialStartPhase_ = value;
		}
	}

	public int MaxSpecialNum
	{
		get
		{
			return maxSpecialNum_;
		}
		set
		{
			maxSpecialNum_ = value;
		}
	}

	public int MaxSpecialNumPerPoint
	{
		get
		{
			return maxSpecialNumPerPoint_;
		}
		set
		{
			maxSpecialNumPerPoint_ = value;
		}
	}

	public float BaseSpecialChance
	{
		get
		{
			return baseSpecialChance_;
		}
		set
		{
			baseSpecialChance_ = value;
		}
	}

	public float SpecialChanceIncrement
	{
		get
		{
			return specialChanceIncrement_;
		}
		set
		{
			specialChanceIncrement_ = value;
		}
	}

	public float MarginSpecialChance
	{
		get
		{
			return marginSpecialChance_;
		}
		set
		{
			marginSpecialChance_ = value;
		}
	}

	public RepeatedField<FUStPhaseSpawnWaveConfig> PhaseConfig => phaseConfig_;

	public RepeatedField<FUStPhaseMobConfig> GeneralMobConfig => generalMobConfig_;

	public FUStMapMobConfigDesc()
	{
	}

	public FUStMapMobConfigDesc(FUStMapMobConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		buffConfigID_ = other.buffConfigID_;
		eliteStartPhase_ = other.eliteStartPhase_;
		maxEliteNum_ = other.maxEliteNum_;
		maxEliteNumPerPoint_ = other.maxEliteNumPerPoint_;
		baseEliteChance_ = other.baseEliteChance_;
		eliteChanceIncrement_ = other.eliteChanceIncrement_;
		marginEliteChance_ = other.marginEliteChance_;
		specialStartPhase_ = other.specialStartPhase_;
		maxSpecialNum_ = other.maxSpecialNum_;
		maxSpecialNumPerPoint_ = other.maxSpecialNumPerPoint_;
		baseSpecialChance_ = other.baseSpecialChance_;
		specialChanceIncrement_ = other.specialChanceIncrement_;
		marginSpecialChance_ = other.marginSpecialChance_;
		phaseConfig_ = other.phaseConfig_.Clone();
		generalMobConfig_ = other.generalMobConfig_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMapMobConfigDesc Clone()
	{
		return new FUStMapMobConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMapMobConfigDesc);
	}

	public bool Equals(FUStMapMobConfigDesc other)
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
		if (BuffConfigID != other.BuffConfigID)
		{
			return false;
		}
		if (EliteStartPhase != other.EliteStartPhase)
		{
			return false;
		}
		if (MaxEliteNum != other.MaxEliteNum)
		{
			return false;
		}
		if (MaxEliteNumPerPoint != other.MaxEliteNumPerPoint)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BaseEliteChance, other.BaseEliteChance))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(EliteChanceIncrement, other.EliteChanceIncrement))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MarginEliteChance, other.MarginEliteChance))
		{
			return false;
		}
		if (SpecialStartPhase != other.SpecialStartPhase)
		{
			return false;
		}
		if (MaxSpecialNum != other.MaxSpecialNum)
		{
			return false;
		}
		if (MaxSpecialNumPerPoint != other.MaxSpecialNumPerPoint)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BaseSpecialChance, other.BaseSpecialChance))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SpecialChanceIncrement, other.SpecialChanceIncrement))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MarginSpecialChance, other.MarginSpecialChance))
		{
			return false;
		}
		if (!phaseConfig_.Equals(other.phaseConfig_))
		{
			return false;
		}
		if (!generalMobConfig_.Equals(other.generalMobConfig_))
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
		if (BuffConfigID != 0)
		{
			num ^= BuffConfigID.GetHashCode();
		}
		if (EliteStartPhase != 0)
		{
			num ^= EliteStartPhase.GetHashCode();
		}
		if (MaxEliteNum != 0)
		{
			num ^= MaxEliteNum.GetHashCode();
		}
		if (MaxEliteNumPerPoint != 0)
		{
			num ^= MaxEliteNumPerPoint.GetHashCode();
		}
		if (BaseEliteChance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BaseEliteChance);
		}
		if (EliteChanceIncrement != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EliteChanceIncrement);
		}
		if (MarginEliteChance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MarginEliteChance);
		}
		if (SpecialStartPhase != 0)
		{
			num ^= SpecialStartPhase.GetHashCode();
		}
		if (MaxSpecialNum != 0)
		{
			num ^= MaxSpecialNum.GetHashCode();
		}
		if (MaxSpecialNumPerPoint != 0)
		{
			num ^= MaxSpecialNumPerPoint.GetHashCode();
		}
		if (BaseSpecialChance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BaseSpecialChance);
		}
		if (SpecialChanceIncrement != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SpecialChanceIncrement);
		}
		if (MarginSpecialChance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MarginSpecialChance);
		}
		num ^= phaseConfig_.GetHashCode();
		num ^= generalMobConfig_.GetHashCode();
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
		if (BuffConfigID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffConfigID);
		}
		if (EliteStartPhase != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(EliteStartPhase);
		}
		if (MaxEliteNum != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MaxEliteNum);
		}
		if (MaxEliteNumPerPoint != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MaxEliteNumPerPoint);
		}
		if (BaseEliteChance != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(BaseEliteChance);
		}
		if (EliteChanceIncrement != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(EliteChanceIncrement);
		}
		if (MarginEliteChance != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(MarginEliteChance);
		}
		if (SpecialStartPhase != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(SpecialStartPhase);
		}
		if (MaxSpecialNum != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(MaxSpecialNum);
		}
		if (MaxSpecialNumPerPoint != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(MaxSpecialNumPerPoint);
		}
		if (BaseSpecialChance != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(BaseSpecialChance);
		}
		if (SpecialChanceIncrement != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(SpecialChanceIncrement);
		}
		if (MarginSpecialChance != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(MarginSpecialChance);
		}
		phaseConfig_.WriteTo(output, _repeated_phaseConfig_codec);
		generalMobConfig_.WriteTo(output, _repeated_generalMobConfig_codec);
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
		if (BuffConfigID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffConfigID);
		}
		if (EliteStartPhase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EliteStartPhase);
		}
		if (MaxEliteNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxEliteNum);
		}
		if (MaxEliteNumPerPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxEliteNumPerPoint);
		}
		if (BaseEliteChance != 0f)
		{
			num += 5;
		}
		if (EliteChanceIncrement != 0f)
		{
			num += 5;
		}
		if (MarginEliteChance != 0f)
		{
			num += 5;
		}
		if (SpecialStartPhase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpecialStartPhase);
		}
		if (MaxSpecialNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxSpecialNum);
		}
		if (MaxSpecialNumPerPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxSpecialNumPerPoint);
		}
		if (BaseSpecialChance != 0f)
		{
			num += 5;
		}
		if (SpecialChanceIncrement != 0f)
		{
			num += 5;
		}
		if (MarginSpecialChance != 0f)
		{
			num += 5;
		}
		num += phaseConfig_.CalculateSize(_repeated_phaseConfig_codec);
		num += generalMobConfig_.CalculateSize(_repeated_generalMobConfig_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStMapMobConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BuffConfigID != 0)
			{
				BuffConfigID = other.BuffConfigID;
			}
			if (other.EliteStartPhase != 0)
			{
				EliteStartPhase = other.EliteStartPhase;
			}
			if (other.MaxEliteNum != 0)
			{
				MaxEliteNum = other.MaxEliteNum;
			}
			if (other.MaxEliteNumPerPoint != 0)
			{
				MaxEliteNumPerPoint = other.MaxEliteNumPerPoint;
			}
			if (other.BaseEliteChance != 0f)
			{
				BaseEliteChance = other.BaseEliteChance;
			}
			if (other.EliteChanceIncrement != 0f)
			{
				EliteChanceIncrement = other.EliteChanceIncrement;
			}
			if (other.MarginEliteChance != 0f)
			{
				MarginEliteChance = other.MarginEliteChance;
			}
			if (other.SpecialStartPhase != 0)
			{
				SpecialStartPhase = other.SpecialStartPhase;
			}
			if (other.MaxSpecialNum != 0)
			{
				MaxSpecialNum = other.MaxSpecialNum;
			}
			if (other.MaxSpecialNumPerPoint != 0)
			{
				MaxSpecialNumPerPoint = other.MaxSpecialNumPerPoint;
			}
			if (other.BaseSpecialChance != 0f)
			{
				BaseSpecialChance = other.BaseSpecialChance;
			}
			if (other.SpecialChanceIncrement != 0f)
			{
				SpecialChanceIncrement = other.SpecialChanceIncrement;
			}
			if (other.MarginSpecialChance != 0f)
			{
				MarginSpecialChance = other.MarginSpecialChance;
			}
			phaseConfig_.Add(other.phaseConfig_);
			generalMobConfig_.Add(other.generalMobConfig_);
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
				BuffConfigID = input.ReadInt32();
				break;
			case 24u:
				EliteStartPhase = input.ReadInt32();
				break;
			case 32u:
				MaxEliteNum = input.ReadInt32();
				break;
			case 40u:
				MaxEliteNumPerPoint = input.ReadInt32();
				break;
			case 53u:
				BaseEliteChance = input.ReadFloat();
				break;
			case 61u:
				EliteChanceIncrement = input.ReadFloat();
				break;
			case 69u:
				MarginEliteChance = input.ReadFloat();
				break;
			case 72u:
				SpecialStartPhase = input.ReadInt32();
				break;
			case 80u:
				MaxSpecialNum = input.ReadInt32();
				break;
			case 88u:
				MaxSpecialNumPerPoint = input.ReadInt32();
				break;
			case 101u:
				BaseSpecialChance = input.ReadFloat();
				break;
			case 109u:
				SpecialChanceIncrement = input.ReadFloat();
				break;
			case 117u:
				MarginSpecialChance = input.ReadFloat();
				break;
			case 122u:
				phaseConfig_.AddEntriesFrom(input, _repeated_phaseConfig_codec);
				break;
			case 130u:
				generalMobConfig_.AddEntriesFrom(input, _repeated_generalMobConfig_codec);
				break;
			}
		}
	}
}
