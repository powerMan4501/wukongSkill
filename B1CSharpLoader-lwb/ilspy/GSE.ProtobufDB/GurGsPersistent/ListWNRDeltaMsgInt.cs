using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class ListWNRDeltaMsgInt : IMessage<ListWNRDeltaMsgInt>, IMessage, IEquatable<ListWNRDeltaMsgInt>, IDeepCloneable<ListWNRDeltaMsgInt>
{
	private static readonly MessageParser<ListWNRDeltaMsgInt> _parser = new MessageParser<ListWNRDeltaMsgInt>(() => new ListWNRDeltaMsgInt());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int value_;

	public static MessageParser<ListWNRDeltaMsgInt> Parser => _parser;

	public int Value
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return value_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			value_ = value;
		}
	}

	public bool HasValue => (_hasBits0 & 1) != 0;

	public ListWNRDeltaMsgInt()
	{
	}

	public ListWNRDeltaMsgInt(ListWNRDeltaMsgInt other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListWNRDeltaMsgInt Clone()
	{
		return new ListWNRDeltaMsgInt(this);
	}

	public void ClearValue()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListWNRDeltaMsgInt);
	}

	public bool Equals(ListWNRDeltaMsgInt other)
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
			output.WriteInt32(Value);
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
			num += 1 + CodedOutputStream.ComputeInt32Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListWNRDeltaMsgInt other)
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
				Value = input.ReadInt32();
			}
		}
	}
}
