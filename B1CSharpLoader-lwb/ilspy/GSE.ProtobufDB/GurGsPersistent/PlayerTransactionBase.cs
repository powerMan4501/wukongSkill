using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class PlayerTransactionBase : IMessage<PlayerTransactionBase>, IMessage, IEquatable<PlayerTransactionBase>, IDeepCloneable<PlayerTransactionBase>
{
	private static readonly MessageParser<PlayerTransactionBase> _parser = new MessageParser<PlayerTransactionBase>(() => new PlayerTransactionBase());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<PlayerTransactionBase> Parser => _parser;

	public PlayerTransactionBase()
	{
	}

	public PlayerTransactionBase(PlayerTransactionBase other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerTransactionBase Clone()
	{
		return new PlayerTransactionBase(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerTransactionBase);
	}

	public bool Equals(PlayerTransactionBase other)
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

	public void MergeFrom(PlayerTransactionBase other)
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
