using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MailTypeTupleWrapper : IMessage<MailTypeTupleWrapper>, IMessage, IEquatable<MailTypeTupleWrapper>, IDeepCloneable<MailTypeTupleWrapper>
{
	private static readonly MessageParser<MailTypeTupleWrapper> _parser = new MessageParser<MailTypeTupleWrapper>(() => new MailTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private MailType item1_;

	private MailType item2_;

	public static MessageParser<MailTypeTupleWrapper> Parser => _parser;

	public MailType Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public MailType Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public MailTypeTupleWrapper()
	{
	}

	public MailTypeTupleWrapper(MailTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailTypeTupleWrapper Clone()
	{
		return new MailTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailTypeTupleWrapper);
	}

	public bool Equals(MailTypeTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != MailType.Comm)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != MailType.Comm)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != MailType.Comm)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != MailType.Comm)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != MailType.Comm)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != MailType.Comm)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != MailType.Comm)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != MailType.Comm)
			{
				Item2 = other.Item2;
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
				Item1 = (MailType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (MailType)input.ReadEnum();
				break;
			}
		}
	}
}
