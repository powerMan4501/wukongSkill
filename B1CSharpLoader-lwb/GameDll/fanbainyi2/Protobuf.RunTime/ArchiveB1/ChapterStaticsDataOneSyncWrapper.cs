using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class ChapterStaticsDataOneSyncWrapper : IMessage<ChapterStaticsDataOneSyncWrapper>, IMessage, IEquatable<ChapterStaticsDataOneSyncWrapper>, IDeepCloneable<ChapterStaticsDataOneSyncWrapper>
{
	private static readonly MessageParser<ChapterStaticsDataOneSyncWrapper> _parser = new MessageParser<ChapterStaticsDataOneSyncWrapper>(() => new ChapterStaticsDataOneSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper chapterId_;

	private FloatSyncWrapper playTime_;

	public static MessageParser<ChapterStaticsDataOneSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
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

	public ChapterStaticsDataOneSyncWrapper()
	{
	}

	public ChapterStaticsDataOneSyncWrapper(ChapterStaticsDataOneSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		chapterId_ = ((other.chapterId_ != null) ? other.chapterId_.Clone() : null);
		playTime_ = ((other.playTime_ != null) ? other.playTime_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChapterStaticsDataOneSyncWrapper Clone()
	{
		return new ChapterStaticsDataOneSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChapterStaticsDataOneSyncWrapper);
	}

	public bool Equals(ChapterStaticsDataOneSyncWrapper other)
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
		if (!object.Equals(ChapterId, other.ChapterId))
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
		if (chapterId_ != null)
		{
			num ^= ChapterId.GetHashCode();
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
		if (chapterId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ChapterId);
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
		if (chapterId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChapterId);
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

	public void MergeFrom(ChapterStaticsDataOneSyncWrapper other)
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
		if (other.chapterId_ != null)
		{
			if (chapterId_ == null)
			{
				ChapterId = new Int32SyncWrapper();
			}
			ChapterId.MergeFrom(other.ChapterId);
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
				if (chapterId_ == null)
				{
					ChapterId = new Int32SyncWrapper();
				}
				input.ReadMessage(ChapterId);
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
