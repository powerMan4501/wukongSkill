using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class EquipFaBaoAttrDesc : IMessage<EquipFaBaoAttrDesc>, IMessage, IEquatable<EquipFaBaoAttrDesc>, IDeepCloneable<EquipFaBaoAttrDesc>
{
	private static readonly MessageParser<EquipFaBaoAttrDesc> _parser = new MessageParser<EquipFaBaoAttrDesc>(() => new EquipFaBaoAttrDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int castSkillId_;

	private string hasBuff_ = "";

	private float duration_;

	private float castEnergy_;

	private static readonly FieldCodec<int> _repeated_castBuffId_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> castBuffId_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_carryBuffId_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> carryBuffId_ = new RepeatedField<int>();

	private YesNoType carryBuffActiveWhenCasting_;

	private static readonly FieldCodec<string> _repeated_carryEffectDesc_codec = FieldCodec.ForString(74u);

	private readonly RepeatedField<string> carryEffectDesc_ = new RepeatedField<string>();

	private int localizationTag_;

	public static MessageParser<EquipFaBaoAttrDesc> Parser => _parser;

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

	public int CastSkillId
	{
		get
		{
			return castSkillId_;
		}
		set
		{
			castSkillId_ = value;
		}
	}

	public string HasBuff
	{
		get
		{
			return hasBuff_;
		}
		set
		{
			hasBuff_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float Duration
	{
		get
		{
			return duration_;
		}
		set
		{
			duration_ = value;
		}
	}

	public float CastEnergy
	{
		get
		{
			return castEnergy_;
		}
		set
		{
			castEnergy_ = value;
		}
	}

	public RepeatedField<int> CastBuffId => castBuffId_;

	public RepeatedField<int> CarryBuffId => carryBuffId_;

	public YesNoType CarryBuffActiveWhenCasting
	{
		get
		{
			return carryBuffActiveWhenCasting_;
		}
		set
		{
			carryBuffActiveWhenCasting_ = value;
		}
	}

	public RepeatedField<string> CarryEffectDesc => carryEffectDesc_;

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public EquipFaBaoAttrDesc()
	{
	}

	public EquipFaBaoAttrDesc(EquipFaBaoAttrDesc other)
		: this()
	{
		id_ = other.id_;
		castSkillId_ = other.castSkillId_;
		hasBuff_ = other.hasBuff_;
		duration_ = other.duration_;
		castEnergy_ = other.castEnergy_;
		castBuffId_ = other.castBuffId_.Clone();
		carryBuffId_ = other.carryBuffId_.Clone();
		carryBuffActiveWhenCasting_ = other.carryBuffActiveWhenCasting_;
		carryEffectDesc_ = other.carryEffectDesc_.Clone();
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EquipFaBaoAttrDesc Clone()
	{
		return new EquipFaBaoAttrDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EquipFaBaoAttrDesc);
	}

	public bool Equals(EquipFaBaoAttrDesc other)
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
		if (CastSkillId != other.CastSkillId)
		{
			return false;
		}
		if (HasBuff != other.HasBuff)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Duration, other.Duration))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CastEnergy, other.CastEnergy))
		{
			return false;
		}
		if (!castBuffId_.Equals(other.castBuffId_))
		{
			return false;
		}
		if (!carryBuffId_.Equals(other.carryBuffId_))
		{
			return false;
		}
		if (CarryBuffActiveWhenCasting != other.CarryBuffActiveWhenCasting)
		{
			return false;
		}
		if (!carryEffectDesc_.Equals(other.carryEffectDesc_))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (CastSkillId != 0)
		{
			num ^= CastSkillId.GetHashCode();
		}
		if (HasBuff.Length != 0)
		{
			num ^= HasBuff.GetHashCode();
		}
		if (Duration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Duration);
		}
		if (CastEnergy != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CastEnergy);
		}
		num ^= castBuffId_.GetHashCode();
		num ^= carryBuffId_.GetHashCode();
		if (CarryBuffActiveWhenCasting != YesNoType.No)
		{
			num ^= CarryBuffActiveWhenCasting.GetHashCode();
		}
		num ^= carryEffectDesc_.GetHashCode();
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
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
		if (CastSkillId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CastSkillId);
		}
		if (HasBuff.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(HasBuff);
		}
		if (Duration != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(Duration);
		}
		if (CastEnergy != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(CastEnergy);
		}
		castBuffId_.WriteTo(output, _repeated_castBuffId_codec);
		carryBuffId_.WriteTo(output, _repeated_carryBuffId_codec);
		if (CarryBuffActiveWhenCasting != YesNoType.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)CarryBuffActiveWhenCasting);
		}
		carryEffectDesc_.WriteTo(output, _repeated_carryEffectDesc_codec);
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(LocalizationTag);
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
		if (CastSkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CastSkillId);
		}
		if (HasBuff.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HasBuff);
		}
		if (Duration != 0f)
		{
			num += 5;
		}
		if (CastEnergy != 0f)
		{
			num += 5;
		}
		num += castBuffId_.CalculateSize(_repeated_castBuffId_codec);
		num += carryBuffId_.CalculateSize(_repeated_carryBuffId_codec);
		if (CarryBuffActiveWhenCasting != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CarryBuffActiveWhenCasting);
		}
		num += carryEffectDesc_.CalculateSize(_repeated_carryEffectDesc_codec);
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EquipFaBaoAttrDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.CastSkillId != 0)
			{
				CastSkillId = other.CastSkillId;
			}
			if (other.HasBuff.Length != 0)
			{
				HasBuff = other.HasBuff;
			}
			if (other.Duration != 0f)
			{
				Duration = other.Duration;
			}
			if (other.CastEnergy != 0f)
			{
				CastEnergy = other.CastEnergy;
			}
			castBuffId_.Add(other.castBuffId_);
			carryBuffId_.Add(other.carryBuffId_);
			if (other.CarryBuffActiveWhenCasting != YesNoType.No)
			{
				CarryBuffActiveWhenCasting = other.CarryBuffActiveWhenCasting;
			}
			carryEffectDesc_.Add(other.carryEffectDesc_);
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
			case 16u:
				CastSkillId = input.ReadInt32();
				break;
			case 26u:
				HasBuff = input.ReadString();
				break;
			case 37u:
				Duration = input.ReadFloat();
				break;
			case 45u:
				CastEnergy = input.ReadFloat();
				break;
			case 48u:
			case 50u:
				castBuffId_.AddEntriesFrom(input, _repeated_castBuffId_codec);
				break;
			case 56u:
			case 58u:
				carryBuffId_.AddEntriesFrom(input, _repeated_carryBuffId_codec);
				break;
			case 64u:
				CarryBuffActiveWhenCasting = (YesNoType)input.ReadEnum();
				break;
			case 74u:
				carryEffectDesc_.AddEntriesFrom(input, _repeated_carryEffectDesc_codec);
				break;
			case 80u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
