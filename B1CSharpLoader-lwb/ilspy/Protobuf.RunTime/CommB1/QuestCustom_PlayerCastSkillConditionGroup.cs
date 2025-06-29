using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_PlayerCastSkillConditionGroup : IMessage<QuestCustom_PlayerCastSkillConditionGroup>, IMessage, IEquatable<QuestCustom_PlayerCastSkillConditionGroup>, IDeepCloneable<QuestCustom_PlayerCastSkillConditionGroup>
{
	private static readonly MessageParser<QuestCustom_PlayerCastSkillConditionGroup> _parser = new MessageParser<QuestCustom_PlayerCastSkillConditionGroup>(() => new QuestCustom_PlayerCastSkillConditionGroup());

	private UnknownFieldSet _unknownFields;

	private string describe_ = "";

	private static readonly FieldCodec<QuestCustom_PlayerCastSkillConditionConfig> _repeated_conditionConfigs_codec = FieldCodec.ForMessage(18u, QuestCustom_PlayerCastSkillConditionConfig.Parser);

	private readonly RepeatedField<QuestCustom_PlayerCastSkillConditionConfig> conditionConfigs_ = new RepeatedField<QuestCustom_PlayerCastSkillConditionConfig>();

	public static MessageParser<QuestCustom_PlayerCastSkillConditionGroup> Parser => _parser;

	public string Describe
	{
		get
		{
			return describe_;
		}
		set
		{
			describe_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<QuestCustom_PlayerCastSkillConditionConfig> ConditionConfigs => conditionConfigs_;

	public QuestCustom_PlayerCastSkillConditionGroup()
	{
	}

	public QuestCustom_PlayerCastSkillConditionGroup(QuestCustom_PlayerCastSkillConditionGroup other)
		: this()
	{
		describe_ = other.describe_;
		conditionConfigs_ = other.conditionConfigs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayerCastSkillConditionGroup Clone()
	{
		return new QuestCustom_PlayerCastSkillConditionGroup(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayerCastSkillConditionGroup);
	}

	public bool Equals(QuestCustom_PlayerCastSkillConditionGroup other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Describe != other.Describe)
		{
			return false;
		}
		if (!conditionConfigs_.Equals(other.conditionConfigs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Describe.Length != 0)
		{
			num ^= Describe.GetHashCode();
		}
		num ^= conditionConfigs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Describe.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Describe);
		}
		conditionConfigs_.WriteTo(output, _repeated_conditionConfigs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Describe.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Describe);
		}
		num += conditionConfigs_.CalculateSize(_repeated_conditionConfigs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PlayerCastSkillConditionGroup other)
	{
		if (other != null)
		{
			if (other.Describe.Length != 0)
			{
				Describe = other.Describe;
			}
			conditionConfigs_.Add(other.conditionConfigs_);
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
			case 10u:
				Describe = input.ReadString();
				break;
			case 18u:
				conditionConfigs_.AddEntriesFrom(input, _repeated_conditionConfigs_codec);
				break;
			}
		}
	}
}
