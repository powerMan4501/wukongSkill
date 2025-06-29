using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagSellItemReq : IMessage<CSMsgBagSellItemReq>, IMessage, IEquatable<CSMsgBagSellItemReq>, IDeepCloneable<CSMsgBagSellItemReq>
{
	private static readonly MessageParser<CSMsgBagSellItemReq> _parser = new MessageParser<CSMsgBagSellItemReq>(() => new CSMsgBagSellItemReq());

	private UnknownFieldSet _unknownFields;

	private int shopId_;

	private int itemId_;

	private int sellNum_;

	public static MessageParser<CSMsgBagSellItemReq> Parser => _parser;

	public int ShopId
	{
		get
		{
			return shopId_;
		}
		set
		{
			shopId_ = value;
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

	public int SellNum
	{
		get
		{
			return sellNum_;
		}
		set
		{
			sellNum_ = value;
		}
	}

	public CSMsgBagSellItemReq()
	{
	}

	public CSMsgBagSellItemReq(CSMsgBagSellItemReq other)
		: this()
	{
		shopId_ = other.shopId_;
		itemId_ = other.itemId_;
		sellNum_ = other.sellNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagSellItemReq Clone()
	{
		return new CSMsgBagSellItemReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagSellItemReq);
	}

	public bool Equals(CSMsgBagSellItemReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ShopId != other.ShopId)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (SellNum != other.SellNum)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (SellNum != 0)
		{
			num ^= SellNum.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ShopId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ShopId);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemId);
		}
		if (SellNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SellNum);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopId);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (SellNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SellNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagSellItemReq other)
	{
		if (other != null)
		{
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.SellNum != 0)
			{
				SellNum = other.SellNum;
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
				ShopId = input.ReadInt32();
				break;
			case 16u:
				ItemId = input.ReadInt32();
				break;
			case 24u:
				SellNum = input.ReadInt32();
				break;
			}
		}
	}
}
