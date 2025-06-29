using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class RoleItemSyncWrapper : IMessage<RoleItemSyncWrapper>, IMessage, IEquatable<RoleItemSyncWrapper>, IDeepCloneable<RoleItemSyncWrapper>
{
	private static readonly MessageParser<RoleItemSyncWrapper> _parser = new MessageParser<RoleItemSyncWrapper>(() => new RoleItemSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper itemId_;

	private Int32SyncWrapper num_;

	private Int32SyncWrapper storeNum_;

	public static MessageParser<RoleItemSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper Num
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

	public RoleItemSyncWrapper()
	{
	}

	public RoleItemSyncWrapper(RoleItemSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		itemId_ = ((other.itemId_ != null) ? other.itemId_.Clone() : null);
		num_ = ((other.num_ != null) ? other.num_.Clone() : null);
		storeNum_ = ((other.storeNum_ != null) ? other.storeNum_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleItemSyncWrapper Clone()
	{
		return new RoleItemSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleItemSyncWrapper);
	}

	public bool Equals(RoleItemSyncWrapper other)
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
		if (!object.Equals(ItemId, other.ItemId))
		{
			return false;
		}
		if (!object.Equals(Num, other.Num))
		{
			return false;
		}
		if (!object.Equals(StoreNum, other.StoreNum))
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
		if (itemId_ != null)
		{
			num ^= ItemId.GetHashCode();
		}
		if (num_ != null)
		{
			num ^= Num.GetHashCode();
		}
		if (storeNum_ != null)
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
		if (itemId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ItemId);
		}
		if (num_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Num);
		}
		if (storeNum_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(StoreNum);
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
		if (itemId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemId);
		}
		if (num_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Num);
		}
		if (storeNum_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StoreNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleItemSyncWrapper other)
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
		if (other.itemId_ != null)
		{
			if (itemId_ == null)
			{
				ItemId = new Int32SyncWrapper();
			}
			ItemId.MergeFrom(other.ItemId);
		}
		if (other.num_ != null)
		{
			if (num_ == null)
			{
				Num = new Int32SyncWrapper();
			}
			Num.MergeFrom(other.Num);
		}
		if (other.storeNum_ != null)
		{
			if (storeNum_ == null)
			{
				StoreNum = new Int32SyncWrapper();
			}
			StoreNum.MergeFrom(other.StoreNum);
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
				if (itemId_ == null)
				{
					ItemId = new Int32SyncWrapper();
				}
				input.ReadMessage(ItemId);
				break;
			case 34u:
				if (num_ == null)
				{
					Num = new Int32SyncWrapper();
				}
				input.ReadMessage(Num);
				break;
			case 42u:
				if (storeNum_ == null)
				{
					StoreNum = new Int32SyncWrapper();
				}
				input.ReadMessage(StoreNum);
				break;
			}
		}
	}
}
