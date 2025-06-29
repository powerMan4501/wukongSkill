using System;
using Google.Protobuf;

namespace OssB1;

public sealed class DieTypeTupleWrapper : IMessage<DieTypeTupleWrapper>, IMessage, IEquatable<DieTypeTupleWrapper>, IDeepCloneable<DieTypeTupleWrapper>
{
	private static readonly MessageParser<DieTypeTupleWrapper> _parser = new MessageParser<DieTypeTupleWrapper>(() => new DieTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private DieType item1_;

	private DieType item2_;

	public static MessageParser<DieTypeTupleWrapper> Parser => _parser;

	public DieType Item1
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

	public DieType Item2
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

	public DieTypeTupleWrapper()
	{
	}

	public DieTypeTupleWrapper(DieTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DieTypeTupleWrapper Clone()
	{
		return new DieTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DieTypeTupleWrapper);
	}

	public bool Equals(DieTypeTupleWrapper other)
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
		if (Item1 != DieType.Killed)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != DieType.Killed)
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
		if (Item1 != DieType.Killed)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != DieType.Killed)
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
		if (Item1 != DieType.Killed)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != DieType.Killed)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DieTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != DieType.Killed)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != DieType.Killed)
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
				Item1 = (DieType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (DieType)input.ReadEnum();
				break;
			}
		}
	}
}
