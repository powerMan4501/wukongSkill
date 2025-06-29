using System;
using Google.Protobuf;

namespace ResB1;

public sealed class IncreaseTypeTupleWrapper : IMessage<IncreaseTypeTupleWrapper>, IMessage, IEquatable<IncreaseTypeTupleWrapper>, IDeepCloneable<IncreaseTypeTupleWrapper>
{
	private static readonly MessageParser<IncreaseTypeTupleWrapper> _parser = new MessageParser<IncreaseTypeTupleWrapper>(() => new IncreaseTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private IncreaseType item1_;

	private IncreaseType item2_;

	public static MessageParser<IncreaseTypeTupleWrapper> Parser => _parser;

	public IncreaseType Item1
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

	public IncreaseType Item2
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

	public IncreaseTypeTupleWrapper()
	{
	}

	public IncreaseTypeTupleWrapper(IncreaseTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public IncreaseTypeTupleWrapper Clone()
	{
		return new IncreaseTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as IncreaseTypeTupleWrapper);
	}

	public bool Equals(IncreaseTypeTupleWrapper other)
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
		if (Item1 != IncreaseType.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != IncreaseType.Default)
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
		if (Item1 != IncreaseType.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != IncreaseType.Default)
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
		if (Item1 != IncreaseType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != IncreaseType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(IncreaseTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != IncreaseType.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != IncreaseType.Default)
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
				Item1 = (IncreaseType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (IncreaseType)input.ReadEnum();
				break;
			}
		}
	}
}
