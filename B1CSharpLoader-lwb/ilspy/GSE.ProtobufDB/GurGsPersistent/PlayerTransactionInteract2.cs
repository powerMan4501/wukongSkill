using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class PlayerTransactionInteract2 : IMessage<PlayerTransactionInteract2>, IMessage, IEquatable<PlayerTransactionInteract2>, IDeepCloneable<PlayerTransactionInteract2>
{
	private static readonly MessageParser<PlayerTransactionInteract2> _parser = new MessageParser<PlayerTransactionInteract2>(() => new PlayerTransactionInteract2());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<PlayerTransactionInteract2> Parser => _parser;

	public PlayerTransactionInteract2()
	{
	}

	public PlayerTransactionInteract2(PlayerTransactionInteract2 other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerTransactionInteract2 Clone()
	{
		return new PlayerTransactionInteract2(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerTransactionInteract2);
	}

	public bool Equals(PlayerTransactionInteract2 other)
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

	public void MergeFrom(PlayerTransactionInteract2 other)
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
