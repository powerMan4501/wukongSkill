using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class ShortcutItemSyncWrapper : IMessage<ShortcutItemSyncWrapper>, IMessage, IEquatable<ShortcutItemSyncWrapper>, IDeepCloneable<ShortcutItemSyncWrapper>
{
	private static readonly MessageParser<ShortcutItemSyncWrapper> _parser = new MessageParser<ShortcutItemSyncWrapper>(() => new ShortcutItemSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper itemId_;

	private Int32SyncWrapper position_;

	public static MessageParser<ShortcutItemSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	public ShortcutItemSyncWrapper()
	{
	}

	public ShortcutItemSyncWrapper(ShortcutItemSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		itemId_ = ((other.itemId_ != null) ? other.itemId_.Clone() : null);
		position_ = ((other.position_ != null) ? other.position_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShortcutItemSyncWrapper Clone()
	{
		return new ShortcutItemSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShortcutItemSyncWrapper);
	}

	public bool Equals(ShortcutItemSyncWrapper other)
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
		if (!object.Equals(Position, other.Position))
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
		if (position_ != null)
		{
			num ^= Position.GetHashCode();
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
		if (position_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Position);
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
		if (position_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Position);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShortcutItemSyncWrapper other)
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
		if (other.position_ != null)
		{
			if (position_ == null)
			{
				Position = new Int32SyncWrapper();
			}
			Position.MergeFrom(other.Position);
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
				if (position_ == null)
				{
					Position = new Int32SyncWrapper();
				}
				input.ReadMessage(Position);
				break;
			}
		}
	}
}
