using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class LevelStaticsDataOneSyncWrapper : IMessage<LevelStaticsDataOneSyncWrapper>, IMessage, IEquatable<LevelStaticsDataOneSyncWrapper>, IDeepCloneable<LevelStaticsDataOneSyncWrapper>
{
	private static readonly MessageParser<LevelStaticsDataOneSyncWrapper> _parser = new MessageParser<LevelStaticsDataOneSyncWrapper>(() => new LevelStaticsDataOneSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper levelId_;

	private FloatSyncWrapper playTime_;

	public static MessageParser<LevelStaticsDataOneSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public FloatSyncWrapper PlayTime
	{
		get
		{
			return playTime_;
		}
		set
		{
			playTime_ = value;
		}
	}

	public LevelStaticsDataOneSyncWrapper()
	{
	}

	public LevelStaticsDataOneSyncWrapper(LevelStaticsDataOneSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		levelId_ = ((other.levelId_ != null) ? other.levelId_.Clone() : null);
		playTime_ = ((other.playTime_ != null) ? other.playTime_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelStaticsDataOneSyncWrapper Clone()
	{
		return new LevelStaticsDataOneSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelStaticsDataOneSyncWrapper);
	}

	public bool Equals(LevelStaticsDataOneSyncWrapper other)
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
		if (!object.Equals(LevelId, other.LevelId))
		{
			return false;
		}
		if (!object.Equals(PlayTime, other.PlayTime))
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
		if (levelId_ != null)
		{
			num ^= LevelId.GetHashCode();
		}
		if (playTime_ != null)
		{
			num ^= PlayTime.GetHashCode();
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
		if (levelId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LevelId);
		}
		if (playTime_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PlayTime);
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
		if (levelId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LevelId);
		}
		if (playTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelStaticsDataOneSyncWrapper other)
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
		if (other.levelId_ != null)
		{
			if (levelId_ == null)
			{
				LevelId = new Int32SyncWrapper();
			}
			LevelId.MergeFrom(other.LevelId);
		}
		if (other.playTime_ != null)
		{
			if (playTime_ == null)
			{
				PlayTime = new FloatSyncWrapper();
			}
			PlayTime.MergeFrom(other.PlayTime);
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
				if (levelId_ == null)
				{
					LevelId = new Int32SyncWrapper();
				}
				input.ReadMessage(LevelId);
				break;
			case 34u:
				if (playTime_ == null)
				{
					PlayTime = new FloatSyncWrapper();
				}
				input.ReadMessage(PlayTime);
				break;
			}
		}
	}
}
