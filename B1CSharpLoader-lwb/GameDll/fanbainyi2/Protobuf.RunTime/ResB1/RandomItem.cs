using System;
using Google.Protobuf;

namespace ResB1;

public sealed class RandomItem : IMessage<RandomItem>, IMessage, IEquatable<RandomItem>, IDeepCloneable<RandomItem>
{
	private static readonly MessageParser<RandomItem> _parser = new MessageParser<RandomItem>(() => new RandomItem());

	private UnknownFieldSet _unknownFields;

	private int itemId_;

	private int itemNum_;

	private int weight_;

	public static MessageParser<RandomItem> Parser => _parser;

	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	public int ItemNum
	{
		get
		{
			return itemNum_;
		}
		set
		{
			itemNum_ = value;
		}
	}

	public int Weight
	{
		get
		{
			return weight_;
		}
		set
		{
			weight_ = value;
		}
	}

	public RandomItem()
	{
	}

	public RandomItem(RandomItem other)
		: this()
	{
		itemId_ = other.itemId_;
		itemNum_ = other.itemNum_;
		weight_ = other.weight_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RandomItem Clone()
	{
		return new RandomItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RandomItem);
	}

	public bool Equals(RandomItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (ItemNum != other.ItemNum)
		{
			return false;
		}
		if (Weight != other.Weight)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (ItemNum != 0)
		{
			num ^= ItemNum.GetHashCode();
		}
		if (Weight != 0)
		{
			num ^= Weight.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ItemId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ItemId);
		}
		if (ItemNum != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemNum);
		}
		if (Weight != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Weight);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (ItemNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemNum);
		}
		if (Weight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Weight);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RandomItem other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.ItemNum != 0)
			{
				ItemNum = other.ItemNum;
			}
			if (other.Weight != 0)
			{
				Weight = other.Weight;
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
				ItemId = input.ReadInt32();
				break;
			case 16u:
				ItemNum = input.ReadInt32();
				break;
			case 24u:
				Weight = input.ReadInt32();
				break;
			}
		}
	}
}
