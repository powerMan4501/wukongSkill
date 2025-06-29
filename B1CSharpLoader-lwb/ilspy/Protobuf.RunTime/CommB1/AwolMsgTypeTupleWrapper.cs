using System;
using Google.Protobuf;

namespace CommB1;

public sealed class AwolMsgTypeTupleWrapper : IMessage<AwolMsgTypeTupleWrapper>, IMessage, IEquatable<AwolMsgTypeTupleWrapper>, IDeepCloneable<AwolMsgTypeTupleWrapper>
{
	private static readonly MessageParser<AwolMsgTypeTupleWrapper> _parser = new MessageParser<AwolMsgTypeTupleWrapper>(() => new AwolMsgTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private AwolMsgType item1_;

	private AwolMsgType item2_;

	public static MessageParser<AwolMsgTypeTupleWrapper> Parser => _parser;

	public AwolMsgType Item1
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

	public AwolMsgType Item2
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

	public AwolMsgTypeTupleWrapper()
	{
	}

	public AwolMsgTypeTupleWrapper(AwolMsgTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AwolMsgTypeTupleWrapper Clone()
	{
		return new AwolMsgTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AwolMsgTypeTupleWrapper);
	}

	public bool Equals(AwolMsgTypeTupleWrapper other)
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
		if (Item1 != AwolMsgType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != AwolMsgType.None)
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
		if (Item1 != AwolMsgType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != AwolMsgType.None)
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
		if (Item1 != AwolMsgType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != AwolMsgType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AwolMsgTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != AwolMsgType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != AwolMsgType.None)
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
				Item1 = (AwolMsgType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (AwolMsgType)input.ReadEnum();
				break;
			}
		}
	}
}
