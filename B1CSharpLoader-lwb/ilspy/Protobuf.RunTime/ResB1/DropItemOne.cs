using System;
using Google.Protobuf;

namespace ResB1;

public sealed class DropItemOne : IMessage<DropItemOne>, IMessage, IEquatable<DropItemOne>, IDeepCloneable<DropItemOne>
{
	private static readonly MessageParser<DropItemOne> _parser = new MessageParser<DropItemOne>(() => new DropItemOne());

	private UnknownFieldSet _unknownFields;

	private int itemId_;

	private int minNum_;

	private int maxNum_;

	private int rate_;

	public static MessageParser<DropItemOne> Parser => _parser;

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

	public int MinNum
	{
		get
		{
			return minNum_;
		}
		set
		{
			minNum_ = value;
		}
	}

	public int MaxNum
	{
		get
		{
			return maxNum_;
		}
		set
		{
			maxNum_ = value;
		}
	}

	public int Rate
	{
		get
		{
			return rate_;
		}
		set
		{
			rate_ = value;
		}
	}

	public DropItemOne()
	{
	}

	public DropItemOne(DropItemOne other)
		: this()
	{
		itemId_ = other.itemId_;
		minNum_ = other.minNum_;
		maxNum_ = other.maxNum_;
		rate_ = other.rate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DropItemOne Clone()
	{
		return new DropItemOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DropItemOne);
	}

	public bool Equals(DropItemOne other)
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
		if (MinNum != other.MinNum)
		{
			return false;
		}
		if (MaxNum != other.MaxNum)
		{
			return false;
		}
		if (Rate != other.Rate)
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
		if (MinNum != 0)
		{
			num ^= MinNum.GetHashCode();
		}
		if (MaxNum != 0)
		{
			num ^= MaxNum.GetHashCode();
		}
		if (Rate != 0)
		{
			num ^= Rate.GetHashCode();
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
		if (MinNum != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MinNum);
		}
		if (MaxNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MaxNum);
		}
		if (Rate != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Rate);
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
		if (MinNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MinNum);
		}
		if (MaxNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxNum);
		}
		if (Rate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rate);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DropItemOne other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.MinNum != 0)
			{
				MinNum = other.MinNum;
			}
			if (other.MaxNum != 0)
			{
				MaxNum = other.MaxNum;
			}
			if (other.Rate != 0)
			{
				Rate = other.Rate;
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
				MinNum = input.ReadInt32();
				break;
			case 24u:
				MaxNum = input.ReadInt32();
				break;
			case 32u:
				Rate = input.ReadInt32();
				break;
			}
		}
	}
}
