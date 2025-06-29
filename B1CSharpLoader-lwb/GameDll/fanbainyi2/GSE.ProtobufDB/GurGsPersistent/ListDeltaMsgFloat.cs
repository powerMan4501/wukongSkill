using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class ListDeltaMsgFloat : IMessage<ListDeltaMsgFloat>, IMessage, IEquatable<ListDeltaMsgFloat>, IDeepCloneable<ListDeltaMsgFloat>
{
	private static readonly MessageParser<ListDeltaMsgFloat> _parser = new MessageParser<ListDeltaMsgFloat>(() => new ListDeltaMsgFloat());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float value_;

	public static MessageParser<ListDeltaMsgFloat> Parser => _parser;

	public float Value
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return value_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			value_ = value;
		}
	}

	public bool HasValue => (_hasBits0 & 1) != 0;

	public ListDeltaMsgFloat()
	{
	}

	public ListDeltaMsgFloat(ListDeltaMsgFloat other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgFloat Clone()
	{
		return new ListDeltaMsgFloat(this);
	}

	public void ClearValue()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgFloat);
	}

	public bool Equals(ListDeltaMsgFloat other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Value, other.Value))
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
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Value);
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
			output.WriteRawTag(13);
			output.WriteFloat(Value);
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
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListDeltaMsgFloat other)
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
			if (num != 13)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Value = input.ReadFloat();
			}
		}
	}
}
