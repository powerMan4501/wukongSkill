using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MailTempParam : IMessage<MailTempParam>, IMessage, IEquatable<MailTempParam>, IDeepCloneable<MailTempParam>
{
	private static readonly MessageParser<MailTempParam> _parser = new MessageParser<MailTempParam>(() => new MailTempParam());

	private UnknownFieldSet _unknownFields;

	private int intParam1_;

	private int intParam2_;

	public static MessageParser<MailTempParam> Parser => _parser;

	public int IntParam1
	{
		get
		{
			return intParam1_;
		}
		set
		{
			intParam1_ = value;
		}
	}

	public int IntParam2
	{
		get
		{
			return intParam2_;
		}
		set
		{
			intParam2_ = value;
		}
	}

	public MailTempParam()
	{
	}

	public MailTempParam(MailTempParam other)
		: this()
	{
		intParam1_ = other.intParam1_;
		intParam2_ = other.intParam2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailTempParam Clone()
	{
		return new MailTempParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailTempParam);
	}

	public bool Equals(MailTempParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IntParam1 != other.IntParam1)
		{
			return false;
		}
		if (IntParam2 != other.IntParam2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IntParam1 != 0)
		{
			num ^= IntParam1.GetHashCode();
		}
		if (IntParam2 != 0)
		{
			num ^= IntParam2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IntParam1 != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(IntParam1);
		}
		if (IntParam2 != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(IntParam2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IntParam1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IntParam1);
		}
		if (IntParam2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IntParam2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailTempParam other)
	{
		if (other != null)
		{
			if (other.IntParam1 != 0)
			{
				IntParam1 = other.IntParam1;
			}
			if (other.IntParam2 != 0)
			{
				IntParam2 = other.IntParam2;
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
				IntParam1 = input.ReadInt32();
				break;
			case 16u:
				IntParam2 = input.ReadInt32();
				break;
			}
		}
	}
}
