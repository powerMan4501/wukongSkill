using System;
using Google.Protobuf;

namespace ResB1;

public sealed class MantraTypeTupleWrapper : IMessage<MantraTypeTupleWrapper>, IMessage, IEquatable<MantraTypeTupleWrapper>, IDeepCloneable<MantraTypeTupleWrapper>
{
	private static readonly MessageParser<MantraTypeTupleWrapper> _parser = new MessageParser<MantraTypeTupleWrapper>(() => new MantraTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private MantraType item1_;

	private MantraType item2_;

	public static MessageParser<MantraTypeTupleWrapper> Parser => _parser;

	public MantraType Item1
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

	public MantraType Item2
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

	public MantraTypeTupleWrapper()
	{
	}

	public MantraTypeTupleWrapper(MantraTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MantraTypeTupleWrapper Clone()
	{
		return new MantraTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MantraTypeTupleWrapper);
	}

	public bool Equals(MantraTypeTupleWrapper other)
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
		if (Item1 != MantraType.Min)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != MantraType.Min)
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
		if (Item1 != MantraType.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != MantraType.Min)
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
		if (Item1 != MantraType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != MantraType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MantraTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != MantraType.Min)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != MantraType.Min)
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
				Item1 = (MantraType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (MantraType)input.ReadEnum();
				break;
			}
		}
	}
}
