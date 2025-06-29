using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleShop : IMessage<RoleShop>, IMessage, IEquatable<RoleShop>, IDeepCloneable<RoleShop>
{
	private static readonly MessageParser<RoleShop> _parser = new MessageParser<RoleShop>(() => new RoleShop());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ShopOne> _repeated_shopList_codec = FieldCodec.ForMessage(10u, ShopOne.Parser);

	private readonly RepeatedField<ShopOne> shopList_ = new RepeatedField<ShopOne>();

	private static readonly FieldCodec<ShopBuyRecord> _repeated_buyRecords_codec = FieldCodec.ForMessage(18u, ShopBuyRecord.Parser);

	private readonly RepeatedField<ShopBuyRecord> buyRecords_ = new RepeatedField<ShopBuyRecord>();

	public static MessageParser<RoleShop> Parser => _parser;

	public RepeatedField<ShopOne> ShopList => shopList_;

	public RepeatedField<ShopBuyRecord> BuyRecords => buyRecords_;

	public RoleShop()
	{
	}

	public RoleShop(RoleShop other)
		: this()
	{
		shopList_ = other.shopList_.Clone();
		buyRecords_ = other.buyRecords_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleShop Clone()
	{
		return new RoleShop(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleShop);
	}

	public bool Equals(RoleShop other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!shopList_.Equals(other.shopList_))
		{
			return false;
		}
		if (!buyRecords_.Equals(other.buyRecords_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= shopList_.GetHashCode();
		num ^= buyRecords_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		shopList_.WriteTo(output, _repeated_shopList_codec);
		buyRecords_.WriteTo(output, _repeated_buyRecords_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += shopList_.CalculateSize(_repeated_shopList_codec);
		num += buyRecords_.CalculateSize(_repeated_buyRecords_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleShop other)
	{
		if (other != null)
		{
			shopList_.Add(other.shopList_);
			buyRecords_.Add(other.buyRecords_);
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
			case 10u:
				shopList_.AddEntriesFrom(input, _repeated_shopList_codec);
				break;
			case 18u:
				buyRecords_.AddEntriesFrom(input, _repeated_buyRecords_codec);
				break;
			}
		}
	}
}
