using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class ArchiveStaticsOneSyncWrapper : IMessage<ArchiveStaticsOneSyncWrapper>, IMessage, IEquatable<ArchiveStaticsOneSyncWrapper>, IDeepCloneable<ArchiveStaticsOneSyncWrapper>
{
	private static readonly MessageParser<ArchiveStaticsOneSyncWrapper> _parser = new MessageParser<ArchiveStaticsOneSyncWrapper>(() => new ArchiveStaticsOneSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper gamePlusId_;

	private FloatSyncWrapper gameTotalTime_;

	public static MessageParser<ArchiveStaticsOneSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper GamePlusId
	{
		get
		{
			return gamePlusId_;
		}
		set
		{
			gamePlusId_ = value;
		}
	}

	public FloatSyncWrapper GameTotalTime
	{
		get
		{
			return gameTotalTime_;
		}
		set
		{
			gameTotalTime_ = value;
		}
	}

	public ArchiveStaticsOneSyncWrapper()
	{
	}

	public ArchiveStaticsOneSyncWrapper(ArchiveStaticsOneSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		gamePlusId_ = ((other.gamePlusId_ != null) ? other.gamePlusId_.Clone() : null);
		gameTotalTime_ = ((other.gameTotalTime_ != null) ? other.gameTotalTime_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArchiveStaticsOneSyncWrapper Clone()
	{
		return new ArchiveStaticsOneSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArchiveStaticsOneSyncWrapper);
	}

	public bool Equals(ArchiveStaticsOneSyncWrapper other)
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
		if (!object.Equals(GamePlusId, other.GamePlusId))
		{
			return false;
		}
		if (!object.Equals(GameTotalTime, other.GameTotalTime))
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
		if (gamePlusId_ != null)
		{
			num ^= GamePlusId.GetHashCode();
		}
		if (gameTotalTime_ != null)
		{
			num ^= GameTotalTime.GetHashCode();
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
		if (gamePlusId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(GamePlusId);
		}
		if (gameTotalTime_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(GameTotalTime);
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
		if (gamePlusId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GamePlusId);
		}
		if (gameTotalTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GameTotalTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArchiveStaticsOneSyncWrapper other)
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
		if (other.gamePlusId_ != null)
		{
			if (gamePlusId_ == null)
			{
				GamePlusId = new Int32SyncWrapper();
			}
			GamePlusId.MergeFrom(other.GamePlusId);
		}
		if (other.gameTotalTime_ != null)
		{
			if (gameTotalTime_ == null)
			{
				GameTotalTime = new FloatSyncWrapper();
			}
			GameTotalTime.MergeFrom(other.GameTotalTime);
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
				if (gamePlusId_ == null)
				{
					GamePlusId = new Int32SyncWrapper();
				}
				input.ReadMessage(GamePlusId);
				break;
			case 34u:
				if (gameTotalTime_ == null)
				{
					GameTotalTime = new FloatSyncWrapper();
				}
				input.ReadMessage(GameTotalTime);
				break;
			}
		}
	}
}
