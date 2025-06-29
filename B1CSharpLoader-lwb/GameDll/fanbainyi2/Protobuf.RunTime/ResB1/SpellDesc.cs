using System;
using BtlB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class SpellDesc : IMessage<SpellDesc>, IMessage, IEquatable<SpellDesc>, IDeepCloneable<SpellDesc>
{
	private static readonly MessageParser<SpellDesc> _parser = new MessageParser<SpellDesc>(() => new SpellDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private SpellType type_;

	private int skillId_;

	private YesNoType isPassive_;

	private static readonly FieldCodec<float> _repeated_floatParam_codec = FieldCodec.ForFloat(50u);

	private readonly RepeatedField<float> floatParam_ = new RepeatedField<float>();

	private SpellEffectType effectType_;

	private SpellNameEnum nameEnum_;

	private YesNoType isReal_;

	private string inputDesc_ = "";

	private int localizationTag_;

	public static MessageParser<SpellDesc> Parser => _parser;

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

	public SpellType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public int SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	public YesNoType IsPassive
	{
		get
		{
			return isPassive_;
		}
		set
		{
			isPassive_ = value;
		}
	}

	public RepeatedField<float> FloatParam => floatParam_;

	public SpellEffectType EffectType
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

	public SpellNameEnum NameEnum
	{
		get
		{
			return nameEnum_;
		}
		set
		{
			nameEnum_ = value;
		}
	}

	public YesNoType IsReal
	{
		get
		{
			return isReal_;
		}
		set
		{
			isReal_ = value;
		}
	}

	public string InputDesc
	{
		get
		{
			return inputDesc_;
		}
		set
		{
			inputDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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

	public SpellDesc()
	{
	}

	public SpellDesc(SpellDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		type_ = other.type_;
		skillId_ = other.skillId_;
		isPassive_ = other.isPassive_;
		floatParam_ = other.floatParam_.Clone();
		effectType_ = other.effectType_;
		nameEnum_ = other.nameEnum_;
		isReal_ = other.isReal_;
		inputDesc_ = other.inputDesc_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SpellDesc Clone()
	{
		return new SpellDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SpellDesc);
	}

	public bool Equals(SpellDesc other)
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
		if (Type != other.Type)
		{
			return false;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (IsPassive != other.IsPassive)
		{
			return false;
		}
		if (!floatParam_.Equals(other.floatParam_))
		{
			return false;
		}
		if (EffectType != other.EffectType)
		{
			return false;
		}
		if (NameEnum != other.NameEnum)
		{
			return false;
		}
		if (IsReal != other.IsReal)
		{
			return false;
		}
		if (InputDesc != other.InputDesc)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Type != SpellType.Min)
		{
			num ^= Type.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (IsPassive != YesNoType.No)
		{
			num ^= IsPassive.GetHashCode();
		}
		num ^= floatParam_.GetHashCode();
		if (EffectType != SpellEffectType.CastSkill)
		{
			num ^= EffectType.GetHashCode();
		}
		if (NameEnum != SpellNameEnum.None)
		{
			num ^= NameEnum.GetHashCode();
		}
		if (IsReal != YesNoType.No)
		{
			num ^= IsReal.GetHashCode();
		}
		if (InputDesc.Length != 0)
		{
			num ^= InputDesc.GetHashCode();
		}
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Type != SpellType.Min)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Type);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SkillId);
		}
		if (IsPassive != YesNoType.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsPassive);
		}
		floatParam_.WriteTo(output, _repeated_floatParam_codec);
		if (EffectType != SpellEffectType.CastSkill)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)EffectType);
		}
		if (NameEnum != SpellNameEnum.None)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)NameEnum);
		}
		if (IsReal != YesNoType.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)IsReal);
		}
		if (InputDesc.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(InputDesc);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(88);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Type != SpellType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (IsPassive != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsPassive);
		}
		num += floatParam_.CalculateSize(_repeated_floatParam_codec);
		if (EffectType != SpellEffectType.CastSkill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectType);
		}
		if (NameEnum != SpellNameEnum.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NameEnum);
		}
		if (IsReal != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsReal);
		}
		if (InputDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InputDesc);
		}
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

	public void MergeFrom(SpellDesc other)
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
			if (other.Type != SpellType.Min)
			{
				Type = other.Type;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.IsPassive != YesNoType.No)
			{
				IsPassive = other.IsPassive;
			}
			floatParam_.Add(other.floatParam_);
			if (other.EffectType != SpellEffectType.CastSkill)
			{
				EffectType = other.EffectType;
			}
			if (other.NameEnum != SpellNameEnum.None)
			{
				NameEnum = other.NameEnum;
			}
			if (other.IsReal != YesNoType.No)
			{
				IsReal = other.IsReal;
			}
			if (other.InputDesc.Length != 0)
			{
				InputDesc = other.InputDesc;
			}
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
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				Type = (SpellType)input.ReadEnum();
				break;
			case 32u:
				SkillId = input.ReadInt32();
				break;
			case 40u:
				IsPassive = (YesNoType)input.ReadEnum();
				break;
			case 50u:
			case 53u:
				floatParam_.AddEntriesFrom(input, _repeated_floatParam_codec);
				break;
			case 56u:
				EffectType = (SpellEffectType)input.ReadEnum();
				break;
			case 64u:
				NameEnum = (SpellNameEnum)input.ReadEnum();
				break;
			case 72u:
				IsReal = (YesNoType)input.ReadEnum();
				break;
			case 82u:
				InputDesc = input.ReadString();
				break;
			case 88u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
