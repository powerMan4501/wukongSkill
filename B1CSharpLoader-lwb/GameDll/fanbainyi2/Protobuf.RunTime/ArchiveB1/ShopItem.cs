using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ShopItem : IMessage<ShopItem>, IMessage, IEquatable<ShopItem>, IDeepCloneable<ShopItem>
{
	private static readonly MessageParser<ShopItem> _parser = new MessageParser<ShopItem>(() => new ShopItem());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int itemId_;

	private int storeNum_;

	private int appendCount_;

	public static MessageParser<ShopItem> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

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

	public int StoreNum
	{
		get
		{
			return storeNum_;
		}
		set
		{
			storeNum_ = value;
		}
	}

	public int AppendCount
	{
		get
		{
			return appendCount_;
		}
		set
		{
			appendCount_ = value;
		}
	}

	public ShopItem()
	{
	}

	public ShopItem(ShopItem other)
		: this()
	{
		id_ = other.id_;
		itemId_ = other.itemId_;
		storeNum_ = other.storeNum_;
		appendCount_ = other.appendCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShopItem Clone()
	{
		return new ShopItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShopItem);
	}

	public bool Equals(ShopItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (StoreNum != other.StoreNum)
		{
			return false;
		}
		if (AppendCount != other.AppendCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (StoreNum != 0)
		{
			num ^= StoreNum.GetHashCode();
		}
		if (AppendCount != 0)
		{
			num ^= AppendCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemId);
		}
		if (StoreNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(StoreNum);
		}
		if (AppendCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(AppendCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (StoreNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StoreNum);
		}
		if (AppendCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AppendCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShopItem other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.StoreNum != 0)
			{
				StoreNum = other.StoreNum;
			}
			if (other.AppendCount != 0)
			{
				AppendCount = other.AppendCount;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				ItemId = input.ReadInt32();
				break;
			case 24u:
				StoreNum = input.ReadInt32();
				break;
			case 40u:
				AppendCount = input.ReadInt32();
				break;
			}
		}
	}
}
