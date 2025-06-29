using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MailInnerTypeTupleWrapper : IMessage<MailInnerTypeTupleWrapper>, IMessage, IEquatable<MailInnerTypeTupleWrapper>, IDeepCloneable<MailInnerTypeTupleWrapper>
{
	private static readonly MessageParser<MailInnerTypeTupleWrapper> _parser = new MessageParser<MailInnerTypeTupleWrapper>(() => new MailInnerTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private MailInnerType item1_;

	private MailInnerType item2_;

	public static MessageParser<MailInnerTypeTupleWrapper> Parser => _parser;

	public MailInnerType Item1
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

	public MailInnerType Item2
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

	public MailInnerTypeTupleWrapper()
	{
	}

	public MailInnerTypeTupleWrapper(MailInnerTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailInnerTypeTupleWrapper Clone()
	{
		return new MailInnerTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailInnerTypeTupleWrapper);
	}

	public bool Equals(MailInnerTypeTupleWrapper other)
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
		if (Item1 != MailInnerType.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != MailInnerType.Default)
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
		if (Item1 != MailInnerType.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != MailInnerType.Default)
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
		if (Item1 != MailInnerType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != MailInnerType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailInnerTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != MailInnerType.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != MailInnerType.Default)
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
				Item1 = (MailInnerType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (MailInnerType)input.ReadEnum();
				break;
			}
		}
	}
}
