using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgShopRefreshReq : IMessage<CSMsgShopRefreshReq>, IMessage, IEquatable<CSMsgShopRefreshReq>, IDeepCloneable<CSMsgShopRefreshReq>
{
	private static readonly MessageParser<CSMsgShopRefreshReq> _parser = new MessageParser<CSMsgShopRefreshReq>(() => new CSMsgShopRefreshReq());

	private UnknownFieldSet _unknownFields;

	private int shopRefreshId_;

	public static MessageParser<CSMsgShopRefreshReq> Parser => _parser;

	public int ShopRefreshId
	{
		get
		{
			return shopRefreshId_;
		}
		set
		{
			shopRefreshId_ = value;
		}
	}

	public CSMsgShopRefreshReq()
	{
	}

	public CSMsgShopRefreshReq(CSMsgShopRefreshReq other)
		: this()
	{
		shopRefreshId_ = other.shopRefreshId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgShopRefreshReq Clone()
	{
		return new CSMsgShopRefreshReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgShopRefreshReq);
	}

	public bool Equals(CSMsgShopRefreshReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ShopRefreshId != other.ShopRefreshId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ShopRefreshId != 0)
		{
			num ^= ShopRefreshId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ShopRefreshId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ShopRefreshId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ShopRefreshId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopRefreshId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgShopRefreshReq other)
	{
		if (other != null)
		{
			if (other.ShopRefreshId != 0)
			{
				ShopRefreshId = other.ShopRefreshId;
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
				ShopRefreshId = input.ReadInt32();
			}
		}
	}
}
