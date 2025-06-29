using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleTask : IMessage<RoleTask>, IMessage, IEquatable<RoleTask>, IDeepCloneable<RoleTask>
{
	private static readonly MessageParser<RoleTask> _parser = new MessageParser<RoleTask>(() => new RoleTask());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<QuestStageOne> _repeated_questList_codec = FieldCodec.ForMessage(10u, QuestStageOne.Parser);

	private readonly RepeatedField<QuestStageOne> questList_ = new RepeatedField<QuestStageOne>();

	public static MessageParser<RoleTask> Parser => _parser;

	public RepeatedField<QuestStageOne> QuestList => questList_;

	public RoleTask()
	{
	}

	public RoleTask(RoleTask other)
		: this()
	{
		questList_ = other.questList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleTask Clone()
	{
		return new RoleTask(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleTask);
	}

	public bool Equals(RoleTask other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!questList_.Equals(other.questList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= questList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		questList_.WriteTo(output, _repeated_questList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += questList_.CalculateSize(_repeated_questList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleTask other)
	{
		if (other != null)
		{
			questList_.Add(other.questList_);
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
				questList_.AddEntriesFrom(input, _repeated_questList_codec);
			}
		}
	}
}
