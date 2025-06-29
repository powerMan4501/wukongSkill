using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class PlayerTransactionTask_RequestInteractObjLock : IMessage<PlayerTransactionTask_RequestInteractObjLock>, IMessage, IEquatable<PlayerTransactionTask_RequestInteractObjLock>, IDeepCloneable<PlayerTransactionTask_RequestInteractObjLock>
{
	private static readonly MessageParser<PlayerTransactionTask_RequestInteractObjLock> _parser = new MessageParser<PlayerTransactionTask_RequestInteractObjLock>(() => new PlayerTransactionTask_RequestInteractObjLock());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<PlayerTransactionTask_RequestInteractObjLock> Parser => _parser;

	public PlayerTransactionTask_RequestInteractObjLock()
	{
	}

	public PlayerTransactionTask_RequestInteractObjLock(PlayerTransactionTask_RequestInteractObjLock other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerTransactionTask_RequestInteractObjLock Clone()
	{
		return new PlayerTransactionTask_RequestInteractObjLock(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerTransactionTask_RequestInteractObjLock);
	}

	public bool Equals(PlayerTransactionTask_RequestInteractObjLock other)
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

	public void MergeFrom(PlayerTransactionTask_RequestInteractObjLock other)
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
