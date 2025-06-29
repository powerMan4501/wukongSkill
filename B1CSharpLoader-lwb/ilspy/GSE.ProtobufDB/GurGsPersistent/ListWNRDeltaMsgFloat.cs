using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class ListWNRDeltaMsgFloat : IMessage<ListWNRDeltaMsgFloat>, IMessage, IEquatable<ListWNRDeltaMsgFloat>, IDeepCloneable<ListWNRDeltaMsgFloat>
{
	private static readonly MessageParser<ListWNRDeltaMsgFloat> _parser = new MessageParser<ListWNRDeltaMsgFloat>(() => new ListWNRDeltaMsgFloat());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float value_;

	public static MessageParser<ListWNRDeltaMsgFloat> Parser => _parser;

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

	public ListWNRDeltaMsgFloat()
	{
	}

	public ListWNRDeltaMsgFloat(ListWNRDeltaMsgFloat other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListWNRDeltaMsgFloat Clone()
	{
		return new ListWNRDeltaMsgFloat(this);
	}

	public void ClearValue()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListWNRDeltaMsgFloat);
	}

	public bool Equals(ListWNRDeltaMsgFloat other)
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

	public void MergeFrom(ListWNRDeltaMsgFloat other)
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
