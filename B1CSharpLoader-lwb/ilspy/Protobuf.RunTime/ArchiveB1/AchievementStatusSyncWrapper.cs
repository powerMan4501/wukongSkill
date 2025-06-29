using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class AchievementStatusSyncWrapper : IMessage<AchievementStatusSyncWrapper>, IMessage, IEquatable<AchievementStatusSyncWrapper>, IDeepCloneable<AchievementStatusSyncWrapper>
{
	private static readonly MessageParser<AchievementStatusSyncWrapper> _parser = new MessageParser<AchievementStatusSyncWrapper>(() => new AchievementStatusSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper id_;

	private DoubleSyncWrapper progress_;

	public static MessageParser<AchievementStatusSyncWrapper> Parser => _parser;

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

	public DoubleSyncWrapper Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	public AchievementStatusSyncWrapper()
	{
	}

	public AchievementStatusSyncWrapper(AchievementStatusSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		id_ = ((other.id_ != null) ? other.id_.Clone() : null);
		progress_ = ((other.progress_ != null) ? other.progress_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementStatusSyncWrapper Clone()
	{
		return new AchievementStatusSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementStatusSyncWrapper);
	}

	public bool Equals(AchievementStatusSyncWrapper other)
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
		if (!object.Equals(Progress, other.Progress))
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
		if (progress_ != null)
		{
			num ^= Progress.GetHashCode();
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
		if (progress_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Progress);
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
		if (progress_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Progress);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementStatusSyncWrapper other)
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
		if (other.progress_ != null)
		{
			if (progress_ == null)
			{
				Progress = new DoubleSyncWrapper();
			}
			Progress.MergeFrom(other.Progress);
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
				if (progress_ == null)
				{
					Progress = new DoubleSyncWrapper();
				}
				input.ReadMessage(Progress);
				break;
			}
		}
	}
}
