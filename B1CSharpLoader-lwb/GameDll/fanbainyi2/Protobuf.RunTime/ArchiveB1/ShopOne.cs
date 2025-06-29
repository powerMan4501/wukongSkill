using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class ShopOne : IMessage<ShopOne>, IMessage, IEquatable<ShopOne>, IDeepCloneable<ShopOne>
{
	private static readonly MessageParser<ShopOne> _parser = new MessageParser<ShopOne>(() => new ShopOne());

	private UnknownFieldSet _unknownFields;

	private int shopId_;

	private static readonly FieldCodec<ShopItem> _repeated_itemList_codec = FieldCodec.ForMessage(26u, ShopItem.Parser);

	private readonly RepeatedField<ShopItem> itemList_ = new RepeatedField<ShopItem>();

	private bool shopRefreshFlag_;

	private static readonly FieldCodec<ShopItem> _repeated_hideItemList_codec = FieldCodec.ForMessage(42u, ShopItem.Parser);

	private readonly RepeatedField<ShopItem> hideItemList_ = new RepeatedField<ShopItem>();

	public static MessageParser<ShopOne> Parser => _parser;

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

	public RepeatedField<ShopItem> ItemList => itemList_;

	public bool ShopRefreshFlag
	{
		get
		{
			return shopRefreshFlag_;
		}
		set
		{
			shopRefreshFlag_ = value;
		}
	}

	public RepeatedField<ShopItem> HideItemList => hideItemList_;

	public ShopOne()
	{
	}

	public ShopOne(ShopOne other)
		: this()
	{
		shopId_ = other.shopId_;
		itemList_ = other.itemList_.Clone();
		shopRefreshFlag_ = other.shopRefreshFlag_;
		hideItemList_ = other.hideItemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShopOne Clone()
	{
		return new ShopOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShopOne);
	}

	public bool Equals(ShopOne other)
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
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (ShopRefreshFlag != other.ShopRefreshFlag)
		{
			return false;
		}
		if (!hideItemList_.Equals(other.hideItemList_))
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
		num ^= itemList_.GetHashCode();
		if (ShopRefreshFlag)
		{
			num ^= ShopRefreshFlag.GetHashCode();
		}
		num ^= hideItemList_.GetHashCode();
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
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (ShopRefreshFlag)
		{
			output.WriteRawTag(32);
			output.WriteBool(ShopRefreshFlag);
		}
		hideItemList_.WriteTo(output, _repeated_hideItemList_codec);
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
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (ShopRefreshFlag)
		{
			num += 2;
		}
		num += hideItemList_.CalculateSize(_repeated_hideItemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShopOne other)
	{
		if (other != null)
		{
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
			}
			itemList_.Add(other.itemList_);
			if (other.ShopRefreshFlag)
			{
				ShopRefreshFlag = other.ShopRefreshFlag;
			}
			hideItemList_.Add(other.hideItemList_);
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
			case 26u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			case 32u:
				ShopRefreshFlag = input.ReadBool();
				break;
			case 42u:
				hideItemList_.AddEntriesFrom(input, _repeated_hideItemList_codec);
				break;
			}
		}
	}
}
