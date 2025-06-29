using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class SkillMappingConfig : IMessage<SkillMappingConfig>, IMessage, IEquatable<SkillMappingConfig>, IDeepCloneable<SkillMappingConfig>
{
	private static readonly MessageParser<SkillMappingConfig> _parser = new MessageParser<SkillMappingConfig>(() => new SkillMappingConfig());

	private UnknownFieldSet _unknownFields;

	private ESkillMappingConditionType skillMappingConditionType_;

	private static readonly FieldCodec<int> _repeated_intParams_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> intParams_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_floatParams_codec = FieldCodec.ForFloat(26u);

	private readonly RepeatedField<float> floatParams_ = new RepeatedField<float>();

	private static readonly FieldCodec<int> _repeated_skillIDs_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> skillIDs_ = new RepeatedField<int>();

	private static readonly FieldCodec<string> _repeated_montagePaths_codec = FieldCodec.ForString(42u);

	private readonly RepeatedField<string> montagePaths_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_sectionNameList_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> sectionNameList_ = new RepeatedField<string>();

	public static MessageParser<SkillMappingConfig> Parser => _parser;

	public ESkillMappingConditionType SkillMappingConditionType
	{
		get
		{
			return skillMappingConditionType_;
		}
		set
		{
			skillMappingConditionType_ = value;
		}
	}

	public RepeatedField<int> IntParams => intParams_;

	public RepeatedField<float> FloatParams => floatParams_;

	public RepeatedField<int> SkillIDs => skillIDs_;

	public RepeatedField<string> MontagePaths => montagePaths_;

	public RepeatedField<string> SectionNameList => sectionNameList_;

	public SkillMappingConfig()
	{
	}

	public SkillMappingConfig(SkillMappingConfig other)
		: this()
	{
		skillMappingConditionType_ = other.skillMappingConditionType_;
		intParams_ = other.intParams_.Clone();
		floatParams_ = other.floatParams_.Clone();
		skillIDs_ = other.skillIDs_.Clone();
		montagePaths_ = other.montagePaths_.Clone();
		sectionNameList_ = other.sectionNameList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SkillMappingConfig Clone()
	{
		return new SkillMappingConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SkillMappingConfig);
	}

	public bool Equals(SkillMappingConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillMappingConditionType != other.SkillMappingConditionType)
		{
			return false;
		}
		if (!intParams_.Equals(other.intParams_))
		{
			return false;
		}
		if (!floatParams_.Equals(other.floatParams_))
		{
			return false;
		}
		if (!skillIDs_.Equals(other.skillIDs_))
		{
			return false;
		}
		if (!montagePaths_.Equals(other.montagePaths_))
		{
			return false;
		}
		if (!sectionNameList_.Equals(other.sectionNameList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SkillMappingConditionType != ESkillMappingConditionType.Any)
		{
			num ^= SkillMappingConditionType.GetHashCode();
		}
		num ^= intParams_.GetHashCode();
		num ^= floatParams_.GetHashCode();
		num ^= skillIDs_.GetHashCode();
		num ^= montagePaths_.GetHashCode();
		num ^= sectionNameList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SkillMappingConditionType != ESkillMappingConditionType.Any)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)SkillMappingConditionType);
		}
		intParams_.WriteTo(output, _repeated_intParams_codec);
		floatParams_.WriteTo(output, _repeated_floatParams_codec);
		skillIDs_.WriteTo(output, _repeated_skillIDs_codec);
		montagePaths_.WriteTo(output, _repeated_montagePaths_codec);
		sectionNameList_.WriteTo(output, _repeated_sectionNameList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SkillMappingConditionType != ESkillMappingConditionType.Any)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkillMappingConditionType);
		}
		num += intParams_.CalculateSize(_repeated_intParams_codec);
		num += floatParams_.CalculateSize(_repeated_floatParams_codec);
		num += skillIDs_.CalculateSize(_repeated_skillIDs_codec);
		num += montagePaths_.CalculateSize(_repeated_montagePaths_codec);
		num += sectionNameList_.CalculateSize(_repeated_sectionNameList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SkillMappingConfig other)
	{
		if (other != null)
		{
			if (other.SkillMappingConditionType != ESkillMappingConditionType.Any)
			{
				SkillMappingConditionType = other.SkillMappingConditionType;
			}
			intParams_.Add(other.intParams_);
			floatParams_.Add(other.floatParams_);
			skillIDs_.Add(other.skillIDs_);
			montagePaths_.Add(other.montagePaths_);
			sectionNameList_.Add(other.sectionNameList_);
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
				SkillMappingConditionType = (ESkillMappingConditionType)input.ReadEnum();
				break;
			case 16u:
			case 18u:
				intParams_.AddEntriesFrom(input, _repeated_intParams_codec);
				break;
			case 26u:
			case 29u:
				floatParams_.AddEntriesFrom(input, _repeated_floatParams_codec);
				break;
			case 32u:
			case 34u:
				skillIDs_.AddEntriesFrom(input, _repeated_skillIDs_codec);
				break;
			case 42u:
				montagePaths_.AddEntriesFrom(input, _repeated_montagePaths_codec);
				break;
			case 50u:
				sectionNameList_.AddEntriesFrom(input, _repeated_sectionNameList_codec);
				break;
			}
		}
	}
}
