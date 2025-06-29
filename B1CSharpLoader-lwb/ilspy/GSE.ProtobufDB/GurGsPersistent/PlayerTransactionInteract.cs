using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class PlayerTransactionInteract : IMessage<PlayerTransactionInteract>, IMessage, IEquatable<PlayerTransactionInteract>, IDeepCloneable<PlayerTransactionInteract>
{
	private static readonly MessageParser<PlayerTransactionInteract> _parser = new MessageParser<PlayerTransactionInteract>(() => new PlayerTransactionInteract());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<PlayerTransactionInteract> Parser => _parser;

	public PlayerTransactionInteract()
	{
	}

	public PlayerTransactionInteract(PlayerTransactionInteract other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerTransactionInteract Clone()
	{
		return new PlayerTransactionInteract(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerTransactionInteract);
	}

	public bool Equals(PlayerTransactionInteract other)
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

	public void MergeFrom(PlayerTransactionInteract other)
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
