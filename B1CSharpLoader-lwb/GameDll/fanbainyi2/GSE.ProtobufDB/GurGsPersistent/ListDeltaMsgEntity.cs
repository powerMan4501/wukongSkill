using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class ListDeltaMsgEntity : IMessage<ListDeltaMsgEntity>, IMessage, IEquatable<ListDeltaMsgEntity>, IDeepCloneable<ListDeltaMsgEntity>
{
	private static readonly MessageParser<ListDeltaMsgEntity> _parser = new MessageParser<ListDeltaMsgEntity>(() => new ListDeltaMsgEntity());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private uint value_;

	public static MessageParser<ListDeltaMsgEntity> Parser => _parser;

	public uint Value
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return value_;
			}
			return 0u;
		}
		set
		{
			_hasBits0 |= 1;
			value_ = value;
		}
	}

	public bool HasValue => (_hasBits0 & 1) != 0;

	public ListDeltaMsgEntity()
	{
	}

	public ListDeltaMsgEntity(ListDeltaMsgEntity other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgEntity Clone()
	{
		return new ListDeltaMsgEntity(this);
	}

	public void ClearValue()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgEntity);
	}

	public bool Equals(ListDeltaMsgEntity other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Value != other.Value)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasValue)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasValue)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasValue)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListDeltaMsgEntity other)
	{
		if (other != null)
		{
			if (other.HasValue)
			{
				Value = other.Value;
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
				Value = input.ReadUInt32();
			}
		}
	}
}
