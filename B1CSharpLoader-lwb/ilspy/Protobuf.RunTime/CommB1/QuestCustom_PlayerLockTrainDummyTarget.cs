using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_PlayerLockTrainDummyTarget : IMessage<QuestCustom_PlayerLockTrainDummyTarget>, IMessage, IEquatable<QuestCustom_PlayerLockTrainDummyTarget>, IDeepCloneable<QuestCustom_PlayerLockTrainDummyTarget>
{
	private static readonly MessageParser<QuestCustom_PlayerLockTrainDummyTarget> _parser = new MessageParser<QuestCustom_PlayerLockTrainDummyTarget>(() => new QuestCustom_PlayerLockTrainDummyTarget());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<QuestCustom_PlayerLockTrainDummyTarget> Parser => _parser;

	public QuestCustom_PlayerLockTrainDummyTarget()
	{
	}

	public QuestCustom_PlayerLockTrainDummyTarget(QuestCustom_PlayerLockTrainDummyTarget other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayerLockTrainDummyTarget Clone()
	{
		return new QuestCustom_PlayerLockTrainDummyTarget(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayerLockTrainDummyTarget);
	}

	public bool Equals(QuestCustom_PlayerLockTrainDummyTarget other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PlayerLockTrainDummyTarget other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
