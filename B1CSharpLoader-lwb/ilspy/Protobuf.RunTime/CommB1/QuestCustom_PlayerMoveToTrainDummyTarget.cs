using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_PlayerMoveToTrainDummyTarget : IMessage<QuestCustom_PlayerMoveToTrainDummyTarget>, IMessage, IEquatable<QuestCustom_PlayerMoveToTrainDummyTarget>, IDeepCloneable<QuestCustom_PlayerMoveToTrainDummyTarget>
{
	private static readonly MessageParser<QuestCustom_PlayerMoveToTrainDummyTarget> _parser = new MessageParser<QuestCustom_PlayerMoveToTrainDummyTarget>(() => new QuestCustom_PlayerMoveToTrainDummyTarget());

	private UnknownFieldSet _unknownFields;

	private float moveFinishDistance_;

	public static MessageParser<QuestCustom_PlayerMoveToTrainDummyTarget> Parser => _parser;

	public float MoveFinishDistance
	{
		get
		{
			return moveFinishDistance_;
		}
		set
		{
			moveFinishDistance_ = value;
		}
	}

	public QuestCustom_PlayerMoveToTrainDummyTarget()
	{
	}

	public QuestCustom_PlayerMoveToTrainDummyTarget(QuestCustom_PlayerMoveToTrainDummyTarget other)
		: this()
	{
		moveFinishDistance_ = other.moveFinishDistance_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayerMoveToTrainDummyTarget Clone()
	{
		return new QuestCustom_PlayerMoveToTrainDummyTarget(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayerMoveToTrainDummyTarget);
	}

	public bool Equals(QuestCustom_PlayerMoveToTrainDummyTarget other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MoveFinishDistance, other.MoveFinishDistance))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MoveFinishDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveFinishDistance);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MoveFinishDistance != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(MoveFinishDistance);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MoveFinishDistance != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PlayerMoveToTrainDummyTarget other)
	{
		if (other != null)
		{
			if (other.MoveFinishDistance != 0f)
			{
				MoveFinishDistance = other.MoveFinishDistance;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 13)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				MoveFinishDistance = input.ReadFloat();
			}
		}
	}
}
