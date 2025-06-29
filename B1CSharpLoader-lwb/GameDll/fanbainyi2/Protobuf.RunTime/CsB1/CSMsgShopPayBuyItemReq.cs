using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgShopPayBuyItemReq : IMessage<CSMsgShopPayBuyItemReq>, IMessage, IEquatable<CSMsgShopPayBuyItemReq>, IDeepCloneable<CSMsgShopPayBuyItemReq>
{
	private static readonly MessageParser<CSMsgShopPayBuyItemReq> _parser = new MessageParser<CSMsgShopPayBuyItemReq>(() => new CSMsgShopPayBuyItemReq());

	private UnknownFieldSet _unknownFields;

	private int shopId_;

	private int shopItemId_;

	private int buyNum_;

	private bool isBuyEquip_;

	public static MessageParser<CSMsgShopPayBuyItemReq> Parser => _parser;

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

	public int ShopItemId
	{
		get
		{
			return shopItemId_;
		}
		set
		{
			shopItemId_ = value;
		}
	}

	public int BuyNum
	{
		get
		{
			return buyNum_;
		}
		set
		{
			buyNum_ = value;
		}
	}

	public bool IsBuyEquip
	{
		get
		{
			return isBuyEquip_;
		}
		set
		{
			isBuyEquip_ = value;
		}
	}

	public CSMsgShopPayBuyItemReq()
	{
	}

	public CSMsgShopPayBuyItemReq(CSMsgShopPayBuyItemReq other)
		: this()
	{
		shopId_ = other.shopId_;
		shopItemId_ = other.shopItemId_;
		buyNum_ = other.buyNum_;
		isBuyEquip_ = other.isBuyEquip_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgShopPayBuyItemReq Clone()
	{
		return new CSMsgShopPayBuyItemReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgShopPayBuyItemReq);
	}

	public bool Equals(CSMsgShopPayBuyItemReq other)
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
		if (ShopItemId != other.ShopItemId)
		{
			return false;
		}
		if (BuyNum != other.BuyNum)
		{
			return false;
		}
		if (IsBuyEquip != other.IsBuyEquip)
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
		if (ShopItemId != 0)
		{
			num ^= ShopItemId.GetHashCode();
		}
		if (BuyNum != 0)
		{
			num ^= BuyNum.GetHashCode();
		}
		if (IsBuyEquip)
		{
			num ^= IsBuyEquip.GetHashCode();
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
		if (ShopItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ShopItemId);
		}
		if (BuyNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuyNum);
		}
		if (IsBuyEquip)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsBuyEquip);
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
		if (ShopItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopItemId);
		}
		if (BuyNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuyNum);
		}
		if (IsBuyEquip)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgShopPayBuyItemReq other)
	{
		if (other != null)
		{
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
			}
			if (other.ShopItemId != 0)
			{
				ShopItemId = other.ShopItemId;
			}
			if (other.BuyNum != 0)
			{
				BuyNum = other.BuyNum;
			}
			if (other.IsBuyEquip)
			{
				IsBuyEquip = other.IsBuyEquip;
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
				ShopItemId = input.ReadInt32();
				break;
			case 24u:
				BuyNum = input.ReadInt32();
				break;
			case 32u:
				IsBuyEquip = input.ReadBool();
				break;
			}
		}
	}
}
