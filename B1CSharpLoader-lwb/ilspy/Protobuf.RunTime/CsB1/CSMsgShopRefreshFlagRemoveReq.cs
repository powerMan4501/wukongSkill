using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgShopRefreshFlagRemoveReq : IMessage<CSMsgShopRefreshFlagRemoveReq>, IMessage, IEquatable<CSMsgShopRefreshFlagRemoveReq>, IDeepCloneable<CSMsgShopRefreshFlagRemoveReq>
{
	private static readonly MessageParser<CSMsgShopRefreshFlagRemoveReq> _parser = new MessageParser<CSMsgShopRefreshFlagRemoveReq>(() => new CSMsgShopRefreshFlagRemoveReq());

	private UnknownFieldSet _unknownFields;

	private int shopId_;

	public static MessageParser<CSMsgShopRefreshFlagRemoveReq> Parser => _parser;

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

	public CSMsgShopRefreshFlagRemoveReq()
	{
	}

	public CSMsgShopRefreshFlagRemoveReq(CSMsgShopRefreshFlagRemoveReq other)
		: this()
	{
		shopId_ = other.shopId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgShopRefreshFlagRemoveReq Clone()
	{
		return new CSMsgShopRefreshFlagRemoveReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgShopRefreshFlagRemoveReq);
	}

	public bool Equals(CSMsgShopRefreshFlagRemoveReq other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
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
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgShopRefreshFlagRemoveReq other)
	{
		if (other != null)
		{
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				ShopId = input.ReadInt32();
			}
		}
	}
}
