using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class WinePartnerSyncWrapper : IMessage<WinePartnerSyncWrapper>, IMessage, IEquatable<WinePartnerSyncWrapper>, IDeepCloneable<WinePartnerSyncWrapper>
{
	private static readonly MessageParser<WinePartnerSyncWrapper> _parser = new MessageParser<WinePartnerSyncWrapper>(() => new WinePartnerSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper pos_;

	private Int32SyncWrapper itemId_;

	public static MessageParser<WinePartnerSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
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

	public WinePartnerSyncWrapper()
	{
	}

	public WinePartnerSyncWrapper(WinePartnerSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
		itemId_ = ((other.itemId_ != null) ? other.itemId_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WinePartnerSyncWrapper Clone()
	{
		return new WinePartnerSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WinePartnerSyncWrapper);
	}

	public bool Equals(WinePartnerSyncWrapper other)
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
		if (!object.Equals(Pos, other.Pos))
		{
			return false;
		}
		if (!object.Equals(ItemId, other.ItemId))
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
		if (pos_ != null)
		{
			num ^= Pos.GetHashCode();
		}
		if (itemId_ != null)
		{
			num ^= ItemId.GetHashCode();
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
		if (pos_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Pos);
		}
		if (itemId_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ItemId);
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
		if (pos_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Pos);
		}
		if (itemId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WinePartnerSyncWrapper other)
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
		if (other.pos_ != null)
		{
			if (pos_ == null)
			{
				Pos = new Int32SyncWrapper();
			}
			Pos.MergeFrom(other.Pos);
		}
		if (other.itemId_ != null)
		{
			if (itemId_ == null)
			{
				ItemId = new Int32SyncWrapper();
			}
			ItemId.MergeFrom(other.ItemId);
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
				if (pos_ == null)
				{
					Pos = new Int32SyncWrapper();
				}
				input.ReadMessage(Pos);
				break;
			case 34u:
				if (itemId_ == null)
				{
					ItemId = new Int32SyncWrapper();
				}
				input.ReadMessage(ItemId);
				break;
			}
		}
	}
}
