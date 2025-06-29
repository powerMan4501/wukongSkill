using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TimeStr : IMessage<TimeStr>, IMessage, IEquatable<TimeStr>, IDeepCloneable<TimeStr>
{
	private static readonly MessageParser<TimeStr> _parser = new MessageParser<TimeStr>(() => new TimeStr());

	private UnknownFieldSet _unknownFields;

	private TimeType type_;

	private string begin_ = "";

	private string end_ = "";

	public static MessageParser<TimeStr> Parser => _parser;

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

	public string Begin
	{
		get
		{
			return begin_;
		}
		set
		{
			begin_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string End
	{
		get
		{
			return end_;
		}
		set
		{
			end_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public TimeStr()
	{
	}

	public TimeStr(TimeStr other)
		: this()
	{
		type_ = other.type_;
		begin_ = other.begin_;
		end_ = other.end_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TimeStr Clone()
	{
		return new TimeStr(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TimeStr);
	}

	public bool Equals(TimeStr other)
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
		if (Begin.Length != 0)
		{
			num ^= Begin.GetHashCode();
		}
		if (End.Length != 0)
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
		if (Begin.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Begin);
		}
		if (End.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(End);
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
		if (Begin.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Begin);
		}
		if (End.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(End);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TimeStr other)
	{
		if (other != null)
		{
			if (other.Type != TimeType.Abs)
			{
				Type = other.Type;
			}
			if (other.Begin.Length != 0)
			{
				Begin = other.Begin;
			}
			if (other.End.Length != 0)
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
			case 18u:
				Begin = input.ReadString();
				break;
			case 26u:
				End = input.ReadString();
				break;
			}
		}
	}
}
