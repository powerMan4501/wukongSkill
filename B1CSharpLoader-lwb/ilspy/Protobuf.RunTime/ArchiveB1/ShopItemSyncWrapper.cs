using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class ShopItemSyncWrapper : IMessage<ShopItemSyncWrapper>, IMessage, IEquatable<ShopItemSyncWrapper>, IDeepCloneable<ShopItemSyncWrapper>
{
	private static readonly MessageParser<ShopItemSyncWrapper> _parser = new MessageParser<ShopItemSyncWrapper>(() => new ShopItemSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper id_;

	private Int32SyncWrapper itemId_;

	private Int32SyncWrapper storeNum_;

	private Int32SyncWrapper appendCount_;

	public static MessageParser<ShopItemSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper Id
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

	public Int32SyncWrapper ItemId
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

	public Int32SyncWrapper StoreNum
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

	public Int32SyncWrapper AppendCount
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

	public ShopItemSyncWrapper()
	{
	}

	public ShopItemSyncWrapper(ShopItemSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		id_ = ((other.id_ != null) ? other.id_.Clone() : null);
		itemId_ = ((other.itemId_ != null) ? other.itemId_.Clone() : null);
		storeNum_ = ((other.storeNum_ != null) ? other.storeNum_.Clone() : null);
		appendCount_ = ((other.appendCount_ != null) ? other.appendCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShopItemSyncWrapper Clone()
	{
		return new ShopItemSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShopItemSyncWrapper);
	}

	public bool Equals(ShopItemSyncWrapper other)
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
		if (!object.Equals(Id, other.Id))
		{
			return false;
		}
		if (!object.Equals(ItemId, other.ItemId))
		{
			return false;
		}
		if (!object.Equals(StoreNum, other.StoreNum))
		{
			return false;
		}
		if (!object.Equals(AppendCount, other.AppendCount))
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
		if (id_ != null)
		{
			num ^= Id.GetHashCode();
		}
		if (itemId_ != null)
		{
			num ^= ItemId.GetHashCode();
		}
		if (storeNum_ != null)
		{
			num ^= StoreNum.GetHashCode();
		}
		if (appendCount_ != null)
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
		if (id_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Id);
		}
		if (itemId_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ItemId);
		}
		if (storeNum_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(StoreNum);
		}
		if (appendCount_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(AppendCount);
		}
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
		if (id_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Id);
		}
		if (itemId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemId);
		}
		if (storeNum_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StoreNum);
		}
		if (appendCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AppendCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShopItemSyncWrapper other)
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
		if (other.id_ != null)
		{
			if (id_ == null)
			{
				Id = new Int32SyncWrapper();
			}
			Id.MergeFrom(other.Id);
		}
		if (other.itemId_ != null)
		{
			if (itemId_ == null)
			{
				ItemId = new Int32SyncWrapper();
			}
			ItemId.MergeFrom(other.ItemId);
		}
		if (other.storeNum_ != null)
		{
			if (storeNum_ == null)
			{
				StoreNum = new Int32SyncWrapper();
			}
			StoreNum.MergeFrom(other.StoreNum);
		}
		if (other.appendCount_ != null)
		{
			if (appendCount_ == null)
			{
				AppendCount = new Int32SyncWrapper();
			}
			AppendCount.MergeFrom(other.AppendCount);
		}
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
				if (id_ == null)
				{
					Id = new Int32SyncWrapper();
				}
				input.ReadMessage(Id);
				break;
			case 34u:
				if (itemId_ == null)
				{
					ItemId = new Int32SyncWrapper();
				}
				input.ReadMessage(ItemId);
				break;
			case 42u:
				if (storeNum_ == null)
				{
					StoreNum = new Int32SyncWrapper();
				}
				input.ReadMessage(StoreNum);
				break;
			case 58u:
				if (appendCount_ == null)
				{
					AppendCount = new Int32SyncWrapper();
				}
				input.ReadMessage(AppendCount);
				break;
			}
		}
	}
}
