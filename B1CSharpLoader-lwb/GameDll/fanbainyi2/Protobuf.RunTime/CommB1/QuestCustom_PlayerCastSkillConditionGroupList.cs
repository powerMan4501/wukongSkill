using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_PlayerCastSkillConditionGroupList : IMessage<QuestCustom_PlayerCastSkillConditionGroupList>, IMessage, IEquatable<QuestCustom_PlayerCastSkillConditionGroupList>, IDeepCloneable<QuestCustom_PlayerCastSkillConditionGroupList>
{
	private static readonly MessageParser<QuestCustom_PlayerCastSkillConditionGroupList> _parser = new MessageParser<QuestCustom_PlayerCastSkillConditionGroupList>(() => new QuestCustom_PlayerCastSkillConditionGroupList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<QuestCustom_PlayerCastSkillConditionGroup> _repeated_conditionGroups_codec = FieldCodec.ForMessage(10u, QuestCustom_PlayerCastSkillConditionGroup.Parser);

	private readonly RepeatedField<QuestCustom_PlayerCastSkillConditionGroup> conditionGroups_ = new RepeatedField<QuestCustom_PlayerCastSkillConditionGroup>();

	public static MessageParser<QuestCustom_PlayerCastSkillConditionGroupList> Parser => _parser;

	public RepeatedField<QuestCustom_PlayerCastSkillConditionGroup> ConditionGroups => conditionGroups_;

	public QuestCustom_PlayerCastSkillConditionGroupList()
	{
	}

	public QuestCustom_PlayerCastSkillConditionGroupList(QuestCustom_PlayerCastSkillConditionGroupList other)
		: this()
	{
		conditionGroups_ = other.conditionGroups_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayerCastSkillConditionGroupList Clone()
	{
		return new QuestCustom_PlayerCastSkillConditionGroupList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayerCastSkillConditionGroupList);
	}

	public bool Equals(QuestCustom_PlayerCastSkillConditionGroupList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!conditionGroups_.Equals(other.conditionGroups_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= conditionGroups_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		conditionGroups_.WriteTo(output, _repeated_conditionGroups_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += conditionGroups_.CalculateSize(_repeated_conditionGroups_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PlayerCastSkillConditionGroupList other)
	{
		if (other != null)
		{
			conditionGroups_.Add(other.conditionGroups_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				conditionGroups_.AddEntriesFrom(input, _repeated_conditionGroups_codec);
			}
		}
	}
}
