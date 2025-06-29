using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class MonsterCollectionSyncWrapper : IMessage<MonsterCollectionSyncWrapper>, IMessage, IEquatable<MonsterCollectionSyncWrapper>, IDeepCloneable<MonsterCollectionSyncWrapper>
{
	private static readonly MessageParser<MonsterCollectionSyncWrapper> _parser = new MessageParser<MonsterCollectionSyncWrapper>(() => new MonsterCollectionSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper id_;

	private CardStoryStatusSyncWrapper storyStatus_;

	private CardPortraitStatusSyncWrapper portraitStatus_;

	public static MessageParser<MonsterCollectionSyncWrapper> Parser => _parser;

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

	public CardStoryStatusSyncWrapper StoryStatus
	{
		get
		{
			return storyStatus_;
		}
		set
		{
			storyStatus_ = value;
		}
	}

	public CardPortraitStatusSyncWrapper PortraitStatus
	{
		get
		{
			return portraitStatus_;
		}
		set
		{
			portraitStatus_ = value;
		}
	}

	public MonsterCollectionSyncWrapper()
	{
	}

	public MonsterCollectionSyncWrapper(MonsterCollectionSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		id_ = ((other.id_ != null) ? other.id_.Clone() : null);
		storyStatus_ = ((other.storyStatus_ != null) ? other.storyStatus_.Clone() : null);
		portraitStatus_ = ((other.portraitStatus_ != null) ? other.portraitStatus_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MonsterCollectionSyncWrapper Clone()
	{
		return new MonsterCollectionSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MonsterCollectionSyncWrapper);
	}

	public bool Equals(MonsterCollectionSyncWrapper other)
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
		if (!object.Equals(StoryStatus, other.StoryStatus))
		{
			return false;
		}
		if (!object.Equals(PortraitStatus, other.PortraitStatus))
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
		if (storyStatus_ != null)
		{
			num ^= StoryStatus.GetHashCode();
		}
		if (portraitStatus_ != null)
		{
			num ^= PortraitStatus.GetHashCode();
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
		if (storyStatus_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(StoryStatus);
		}
		if (portraitStatus_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(PortraitStatus);
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
		if (storyStatus_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StoryStatus);
		}
		if (portraitStatus_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PortraitStatus);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MonsterCollectionSyncWrapper other)
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
		if (other.storyStatus_ != null)
		{
			if (storyStatus_ == null)
			{
				StoryStatus = new CardStoryStatusSyncWrapper();
			}
			StoryStatus.MergeFrom(other.StoryStatus);
		}
		if (other.portraitStatus_ != null)
		{
			if (portraitStatus_ == null)
			{
				PortraitStatus = new CardPortraitStatusSyncWrapper();
			}
			PortraitStatus.MergeFrom(other.PortraitStatus);
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
			case 50u:
				if (storyStatus_ == null)
				{
					StoryStatus = new CardStoryStatusSyncWrapper();
				}
				input.ReadMessage(StoryStatus);
				break;
			case 58u:
				if (portraitStatus_ == null)
				{
					PortraitStatus = new CardPortraitStatusSyncWrapper();
				}
				input.ReadMessage(PortraitStatus);
				break;
			}
		}
	}
}
