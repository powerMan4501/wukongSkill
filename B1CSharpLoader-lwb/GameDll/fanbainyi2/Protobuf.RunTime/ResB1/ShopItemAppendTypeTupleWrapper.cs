using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ShopItemAppendTypeTupleWrapper : IMessage<ShopItemAppendTypeTupleWrapper>, IMessage, IEquatable<ShopItemAppendTypeTupleWrapper>, IDeepCloneable<ShopItemAppendTypeTupleWrapper>
{
	private static readonly MessageParser<ShopItemAppendTypeTupleWrapper> _parser = new MessageParser<ShopItemAppendTypeTupleWrapper>(() => new ShopItemAppendTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ShopItemAppendType item1_;

	private ShopItemAppendType item2_;

	public static MessageParser<ShopItemAppendTypeTupleWrapper> Parser => _parser;

	public ShopItemAppendType Item1
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

	public ShopItemAppendType Item2
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

	public ShopItemAppendTypeTupleWrapper()
	{
	}

	public ShopItemAppendTypeTupleWrapper(ShopItemAppendTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShopItemAppendTypeTupleWrapper Clone()
	{
		return new ShopItemAppendTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShopItemAppendTypeTupleWrapper);
	}

	public bool Equals(ShopItemAppendTypeTupleWrapper other)
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
		if (Item1 != ShopItemAppendType.Add)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ShopItemAppendType.Add)
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
		if (Item1 != ShopItemAppendType.Add)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ShopItemAppendType.Add)
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
		if (Item1 != ShopItemAppendType.Add)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ShopItemAppendType.Add)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShopItemAppendTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ShopItemAppendType.Add)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ShopItemAppendType.Add)
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
				Item1 = (ShopItemAppendType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ShopItemAppendType)input.ReadEnum();
				break;
			}
		}
	}
}
