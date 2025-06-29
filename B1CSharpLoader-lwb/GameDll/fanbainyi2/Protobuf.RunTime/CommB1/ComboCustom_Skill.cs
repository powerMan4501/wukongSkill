using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ComboCustom_Skill : IMessage<ComboCustom_Skill>, IMessage, IEquatable<ComboCustom_Skill>, IDeepCloneable<ComboCustom_Skill>
{
	private static readonly MessageParser<ComboCustom_Skill> _parser = new MessageParser<ComboCustom_Skill>(() => new ComboCustom_Skill());

	private UnknownFieldSet _unknownFields;

	private int skillId_;

	private static readonly FieldCodec<int> _repeated_skillMappingRuleIdList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> skillMappingRuleIdList_ = new RepeatedField<int>();

	public static MessageParser<ComboCustom_Skill> Parser => _parser;

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

	public RepeatedField<int> SkillMappingRuleIdList => skillMappingRuleIdList_;

	public ComboCustom_Skill()
	{
	}

	public ComboCustom_Skill(ComboCustom_Skill other)
		: this()
	{
		skillId_ = other.skillId_;
		skillMappingRuleIdList_ = other.skillMappingRuleIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ComboCustom_Skill Clone()
	{
		return new ComboCustom_Skill(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ComboCustom_Skill);
	}

	public bool Equals(ComboCustom_Skill other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (!skillMappingRuleIdList_.Equals(other.skillMappingRuleIdList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		num ^= skillMappingRuleIdList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SkillId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SkillId);
		}
		skillMappingRuleIdList_.WriteTo(output, _repeated_skillMappingRuleIdList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		num += skillMappingRuleIdList_.CalculateSize(_repeated_skillMappingRuleIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ComboCustom_Skill other)
	{
		if (other != null)
		{
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			skillMappingRuleIdList_.Add(other.skillMappingRuleIdList_);
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
				SkillId = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				skillMappingRuleIdList_.AddEntriesFrom(input, _repeated_skillMappingRuleIdList_codec);
				break;
			}
		}
	}
}
