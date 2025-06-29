using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class PlayerTransactionTaskBase : IMessage<PlayerTransactionTaskBase>, IMessage, IEquatable<PlayerTransactionTaskBase>, IDeepCloneable<PlayerTransactionTaskBase>
{
	private static readonly MessageParser<PlayerTransactionTaskBase> _parser = new MessageParser<PlayerTransactionTaskBase>(() => new PlayerTransactionTaskBase());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<PlayerTransactionTaskBase> Parser => _parser;

	public PlayerTransactionTaskBase()
	{
	}

	public PlayerTransactionTaskBase(PlayerTransactionTaskBase other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerTransactionTaskBase Clone()
	{
		return new PlayerTransactionTaskBase(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerTransactionTaskBase);
	}

	public bool Equals(PlayerTransactionTaskBase other)
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

	public void MergeFrom(PlayerTransactionTaskBase other)
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
