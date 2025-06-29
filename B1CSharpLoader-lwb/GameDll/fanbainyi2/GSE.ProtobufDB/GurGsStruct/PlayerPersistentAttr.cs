using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class PlayerPersistentAttr : IMessage<PlayerPersistentAttr>, IMessage, IEquatable<PlayerPersistentAttr>, IDeepCloneable<PlayerPersistentAttr>
{
	private static readonly MessageParser<PlayerPersistentAttr> _parser = new MessageParser<PlayerPersistentAttr>(() => new PlayerPersistentAttr());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<PlayerPersistentAttr> Parser => _parser;

	public PlayerPersistentAttr()
	{
	}

	public PlayerPersistentAttr(PlayerPersistentAttr other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerPersistentAttr Clone()
	{
		return new PlayerPersistentAttr(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerPersistentAttr);
	}

	public bool Equals(PlayerPersistentAttr other)
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

	public void MergeFrom(PlayerPersistentAttr other)
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
