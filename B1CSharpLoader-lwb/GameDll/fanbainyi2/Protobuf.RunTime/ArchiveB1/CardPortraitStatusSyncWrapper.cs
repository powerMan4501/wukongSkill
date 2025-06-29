using System;
using BtlShare;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class CardPortraitStatusSyncWrapper : IMessage<CardPortraitStatusSyncWrapper>, IMessage, IEquatable<CardPortraitStatusSyncWrapper>, IDeepCloneable<CardPortraitStatusSyncWrapper>
{
	private static readonly MessageParser<CardPortraitStatusSyncWrapper> _parser = new MessageParser<CardPortraitStatusSyncWrapper>(() => new CardPortraitStatusSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private ECollectionPortraitStageSyncWrapper portraitStage_;

	private BoolSyncWrapper isRead_;

	public static MessageParser<CardPortraitStatusSyncWrapper> Parser => _parser;

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

	public ECollectionPortraitStageSyncWrapper PortraitStage
	{
		get
		{
			return portraitStage_;
		}
		set
		{
			portraitStage_ = value;
		}
	}

	public BoolSyncWrapper IsRead
	{
		get
		{
			return isRead_;
		}
		set
		{
			isRead_ = value;
		}
	}

	public CardPortraitStatusSyncWrapper()
	{
	}

	public CardPortraitStatusSyncWrapper(CardPortraitStatusSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		portraitStage_ = ((other.portraitStage_ != null) ? other.portraitStage_.Clone() : null);
		isRead_ = ((other.isRead_ != null) ? other.isRead_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CardPortraitStatusSyncWrapper Clone()
	{
		return new CardPortraitStatusSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CardPortraitStatusSyncWrapper);
	}

	public bool Equals(CardPortraitStatusSyncWrapper other)
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
		if (!object.Equals(PortraitStage, other.PortraitStage))
		{
			return false;
		}
		if (!object.Equals(IsRead, other.IsRead))
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
		if (portraitStage_ != null)
		{
			num ^= PortraitStage.GetHashCode();
		}
		if (isRead_ != null)
		{
			num ^= IsRead.GetHashCode();
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
		if (portraitStage_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(PortraitStage);
		}
		if (isRead_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(IsRead);
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
		if (portraitStage_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PortraitStage);
		}
		if (isRead_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IsRead);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CardPortraitStatusSyncWrapper other)
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
		if (other.portraitStage_ != null)
		{
			if (portraitStage_ == null)
			{
				PortraitStage = new ECollectionPortraitStageSyncWrapper();
			}
			PortraitStage.MergeFrom(other.PortraitStage);
		}
		if (other.isRead_ != null)
		{
			if (isRead_ == null)
			{
				IsRead = new BoolSyncWrapper();
			}
			IsRead.MergeFrom(other.IsRead);
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
				if (portraitStage_ == null)
				{
					PortraitStage = new ECollectionPortraitStageSyncWrapper();
				}
				input.ReadMessage(PortraitStage);
				break;
			case 34u:
				if (isRead_ == null)
				{
					IsRead = new BoolSyncWrapper();
				}
				input.ReadMessage(IsRead);
				break;
			}
		}
	}
}
