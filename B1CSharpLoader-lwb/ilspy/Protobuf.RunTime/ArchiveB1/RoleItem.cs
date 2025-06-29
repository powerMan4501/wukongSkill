using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleItem : IMessage<RoleItem>, IMessage, IEquatable<RoleItem>, IDeepCloneable<RoleItem>
{
	private static readonly MessageParser<RoleItem> _parser = new MessageParser<RoleItem>(() => new RoleItem());

	private UnknownFieldSet _unknownFields;

	private int itemId_;

	private int num_;

	private int storeNum_;

	public static MessageParser<RoleItem> Parser => _parser;

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

	public int Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
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

	public RoleItem()
	{
	}

	public RoleItem(RoleItem other)
		: this()
	{
		itemId_ = other.itemId_;
		num_ = other.num_;
		storeNum_ = other.storeNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleItem Clone()
	{
		return new RoleItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleItem);
	}

	public bool Equals(RoleItem other)
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
		if (Num != other.Num)
		{
			return false;
		}
		if (StoreNum != other.StoreNum)
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
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (StoreNum != 0)
		{
			num ^= StoreNum.GetHashCode();
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
		if (Num != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Num);
		}
		if (StoreNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(StoreNum);
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
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Num);
		}
		if (StoreNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StoreNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleItem other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.StoreNum != 0)
			{
				StoreNum = other.StoreNum;
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
				Num = input.ReadInt32();
				break;
			case 24u:
				StoreNum = input.ReadInt32();
				break;
			}
		}
	}
}
