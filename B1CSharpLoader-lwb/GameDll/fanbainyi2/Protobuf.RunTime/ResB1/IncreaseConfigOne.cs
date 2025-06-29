using System;
using Google.Protobuf;

namespace ResB1;

public sealed class IncreaseConfigOne : IMessage<IncreaseConfigOne>, IMessage, IEquatable<IncreaseConfigOne>, IDeepCloneable<IncreaseConfigOne>
{
	private static readonly MessageParser<IncreaseConfigOne> _parser = new MessageParser<IncreaseConfigOne>(() => new IncreaseConfigOne());

	private UnknownFieldSet _unknownFields;

	private int value_;

	public static MessageParser<IncreaseConfigOne> Parser => _parser;

	public int Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public IncreaseConfigOne()
	{
	}

	public IncreaseConfigOne(IncreaseConfigOne other)
		: this()
	{
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public IncreaseConfigOne Clone()
	{
		return new IncreaseConfigOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as IncreaseConfigOne);
	}

	public bool Equals(IncreaseConfigOne other)
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
		if (Value != 0)
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
		if (Value != 0)
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
		if (Value != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(IncreaseConfigOne other)
	{
		if (other != null)
		{
			if (other.Value != 0)
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
