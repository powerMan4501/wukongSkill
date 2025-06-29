using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class ShopOneSyncWrapper : IMessage<ShopOneSyncWrapper>, IMessage, IEquatable<ShopOneSyncWrapper>, IDeepCloneable<ShopOneSyncWrapper>
{
	private static readonly MessageParser<ShopOneSyncWrapper> _parser = new MessageParser<ShopOneSyncWrapper>(() => new ShopOneSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper shopId_;

	private static readonly FieldCodec<ShopItemSyncWrapper> _repeated_itemList_codec = FieldCodec.ForMessage(42u, ShopItemSyncWrapper.Parser);

	private readonly RepeatedField<ShopItemSyncWrapper> itemList_ = new RepeatedField<ShopItemSyncWrapper>();

	private BoolSyncWrapper shopRefreshFlag_;

	private static readonly FieldCodec<ShopItemSyncWrapper> _repeated_hideItemList_codec = FieldCodec.ForMessage(58u, ShopItemSyncWrapper.Parser);

	private readonly RepeatedField<ShopItemSyncWrapper> hideItemList_ = new RepeatedField<ShopItemSyncWrapper>();

	public static MessageParser<ShopOneSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public Int32SyncWrapper ShopId
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

	public RepeatedField<ShopItemSyncWrapper> ItemList => itemList_;

	public BoolSyncWrapper ShopRefreshFlag
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

	public RepeatedField<ShopItemSyncWrapper> HideItemList => hideItemList_;

	public ShopOneSyncWrapper()
	{
	}

	public ShopOneSyncWrapper(ShopOneSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		shopId_ = ((other.shopId_ != null) ? other.shopId_.Clone() : null);
		itemList_ = other.itemList_.Clone();
		shopRefreshFlag_ = ((other.shopRefreshFlag_ != null) ? other.shopRefreshFlag_.Clone() : null);
		hideItemList_ = other.hideItemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShopOneSyncWrapper Clone()
	{
		return new ShopOneSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShopOneSyncWrapper);
	}

	public bool Equals(ShopOneSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(ShopId, other.ShopId))
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (!object.Equals(ShopRefreshFlag, other.ShopRefreshFlag))
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
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (shopId_ != null)
		{
			num ^= ShopId.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (shopRefreshFlag_ != null)
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
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (shopId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ShopId);
		}
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (shopRefreshFlag_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ShopRefreshFlag);
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
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (shopId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShopId);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (shopRefreshFlag_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShopRefreshFlag);
		}
		num += hideItemList_.CalculateSize(_repeated_hideItemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShopOneSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.shopId_ != null)
		{
			if (shopId_ == null)
			{
				ShopId = new Int32SyncWrapper();
			}
			ShopId.MergeFrom(other.ShopId);
		}
		itemList_.Add(other.itemList_);
		if (other.shopRefreshFlag_ != null)
		{
			if (shopRefreshFlag_ == null)
			{
				ShopRefreshFlag = new BoolSyncWrapper();
			}
			ShopRefreshFlag.MergeFrom(other.ShopRefreshFlag);
		}
		hideItemList_.Add(other.hideItemList_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (shopId_ == null)
				{
					ShopId = new Int32SyncWrapper();
				}
				input.ReadMessage(ShopId);
				break;
			case 42u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			case 50u:
				if (shopRefreshFlag_ == null)
				{
					ShopRefreshFlag = new BoolSyncWrapper();
				}
				input.ReadMessage(ShopRefreshFlag);
				break;
			case 58u:
				hideItemList_.AddEntriesFrom(input, _repeated_hideItemList_codec);
				break;
			}
		}
	}
}
