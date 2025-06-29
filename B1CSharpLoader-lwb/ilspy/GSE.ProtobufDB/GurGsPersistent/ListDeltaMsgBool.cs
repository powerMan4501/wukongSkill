using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class ListDeltaMsgBool : IMessage<ListDeltaMsgBool>, IMessage, IEquatable<ListDeltaMsgBool>, IDeepCloneable<ListDeltaMsgBool>
{
	private static readonly MessageParser<ListDeltaMsgBool> _parser = new MessageParser<ListDeltaMsgBool>(() => new ListDeltaMsgBool());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private bool value_;

	public static MessageParser<ListDeltaMsgBool> Parser => _parser;

	public bool Value
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return value_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 1;
			value_ = value;
		}
	}

	public bool HasValue => (_hasBits0 & 1) != 0;

	public ListDeltaMsgBool()
	{
	}

	public ListDeltaMsgBool(ListDeltaMsgBool other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgBool Clone()
	{
		return new ListDeltaMsgBool(this);
	}

	public void ClearValue()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgBool);
	}

	public bool Equals(ListDeltaMsgBool other)
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
			output.WriteBool(Value);
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
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListDeltaMsgBool other)
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
				Value = input.ReadBool();
			}
		}
	}
}
