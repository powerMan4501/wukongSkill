using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MailStateTupleWrapper : IMessage<MailStateTupleWrapper>, IMessage, IEquatable<MailStateTupleWrapper>, IDeepCloneable<MailStateTupleWrapper>
{
	private static readonly MessageParser<MailStateTupleWrapper> _parser = new MessageParser<MailStateTupleWrapper>(() => new MailStateTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private MailState item1_;

	private MailState item2_;

	public static MessageParser<MailStateTupleWrapper> Parser => _parser;

	public MailState Item1
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

	public MailState Item2
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

	public MailStateTupleWrapper()
	{
	}

	public MailStateTupleWrapper(MailStateTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailStateTupleWrapper Clone()
	{
		return new MailStateTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailStateTupleWrapper);
	}

	public bool Equals(MailStateTupleWrapper other)
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
		if (Item1 != MailState.Init)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != MailState.Init)
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
		if (Item1 != MailState.Init)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != MailState.Init)
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
		if (Item1 != MailState.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != MailState.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailStateTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != MailState.Init)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != MailState.Init)
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
				Item1 = (MailState)input.ReadEnum();
				break;
			case 16u:
				Item2 = (MailState)input.ReadEnum();
				break;
			}
		}
	}
}
