using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TimeInt : IMessage<TimeInt>, IMessage, IEquatable<TimeInt>, IDeepCloneable<TimeInt>
{
	private static readonly MessageParser<TimeInt> _parser = new MessageParser<TimeInt>(() => new TimeInt());

	private UnknownFieldSet _unknownFields;

	private TimeType type_;

	private uint begin_;

	private uint end_;

	public static MessageParser<TimeInt> Parser => _parser;

	public TimeType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public uint Begin
	{
		get
		{
			return begin_;
		}
		set
		{
			begin_ = value;
		}
	}

	public uint End
	{
		get
		{
			return end_;
		}
		set
		{
			end_ = value;
		}
	}

	public TimeInt()
	{
	}

	public TimeInt(TimeInt other)
		: this()
	{
		type_ = other.type_;
		begin_ = other.begin_;
		end_ = other.end_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TimeInt Clone()
	{
		return new TimeInt(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TimeInt);
	}

	public bool Equals(TimeInt other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Begin != other.Begin)
		{
			return false;
		}
		if (End != other.End)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Type != TimeType.Abs)
		{
			num ^= Type.GetHashCode();
		}
		if (Begin != 0)
		{
			num ^= Begin.GetHashCode();
		}
		if (End != 0)
		{
			num ^= End.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Type != TimeType.Abs)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (Begin != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Begin);
		}
		if (End != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(End);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Type != TimeType.Abs)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Begin != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Begin);
		}
		if (End != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(End);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TimeInt other)
	{
		if (other != null)
		{
			if (other.Type != TimeType.Abs)
			{
				Type = other.Type;
			}
			if (other.Begin != 0)
			{
				Begin = other.Begin;
			}
			if (other.End != 0)
			{
				End = other.End;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				Type = (TimeType)input.ReadEnum();
				break;
			case 16u:
				Begin = input.ReadUInt32();
				break;
			case 24u:
				End = input.ReadUInt32();
				break;
			}
		}
	}
}
