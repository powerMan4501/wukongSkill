using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_QueryGameState : IMessage<QuestCustom_QueryGameState>, IMessage, IEquatable<QuestCustom_QueryGameState>, IDeepCloneable<QuestCustom_QueryGameState>
{
	private static readonly MessageParser<QuestCustom_QueryGameState> _parser = new MessageParser<QuestCustom_QueryGameState>(() => new QuestCustom_QueryGameState());

	private UnknownFieldSet _unknownFields;

	private int queryCondition_;

	public static MessageParser<QuestCustom_QueryGameState> Parser => _parser;

	public int QueryCondition
	{
		get
		{
			return queryCondition_;
		}
		set
		{
			queryCondition_ = value;
		}
	}

	public QuestCustom_QueryGameState()
	{
	}

	public QuestCustom_QueryGameState(QuestCustom_QueryGameState other)
		: this()
	{
		queryCondition_ = other.queryCondition_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_QueryGameState Clone()
	{
		return new QuestCustom_QueryGameState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_QueryGameState);
	}

	public bool Equals(QuestCustom_QueryGameState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QueryCondition != other.QueryCondition)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (QueryCondition != 0)
		{
			num ^= QueryCondition.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (QueryCondition != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(QueryCondition);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (QueryCondition != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QueryCondition);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_QueryGameState other)
	{
		if (other != null)
		{
			if (other.QueryCondition != 0)
			{
				QueryCondition = other.QueryCondition;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				QueryCondition = input.ReadInt32();
			}
		}
	}
}
