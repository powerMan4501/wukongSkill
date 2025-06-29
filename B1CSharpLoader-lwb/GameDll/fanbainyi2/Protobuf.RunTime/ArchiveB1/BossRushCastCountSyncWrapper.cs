using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class BossRushCastCountSyncWrapper : IMessage<BossRushCastCountSyncWrapper>, IMessage, IEquatable<BossRushCastCountSyncWrapper>, IDeepCloneable<BossRushCastCountSyncWrapper>
{
	private static readonly MessageParser<BossRushCastCountSyncWrapper> _parser = new MessageParser<BossRushCastCountSyncWrapper>(() => new BossRushCastCountSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper castId_;

	private Int32SyncWrapper castCount_;

	public static MessageParser<BossRushCastCountSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper CastId
	{
		get
		{
			return castId_;
		}
		set
		{
			castId_ = value;
		}
	}

	public Int32SyncWrapper CastCount
	{
		get
		{
			return castCount_;
		}
		set
		{
			castCount_ = value;
		}
	}

	public BossRushCastCountSyncWrapper()
	{
	}

	public BossRushCastCountSyncWrapper(BossRushCastCountSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		castId_ = ((other.castId_ != null) ? other.castId_.Clone() : null);
		castCount_ = ((other.castCount_ != null) ? other.castCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushCastCountSyncWrapper Clone()
	{
		return new BossRushCastCountSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushCastCountSyncWrapper);
	}

	public bool Equals(BossRushCastCountSyncWrapper other)
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
		if (!object.Equals(CastId, other.CastId))
		{
			return false;
		}
		if (!object.Equals(CastCount, other.CastCount))
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
		if (castId_ != null)
		{
			num ^= CastId.GetHashCode();
		}
		if (castCount_ != null)
		{
			num ^= CastCount.GetHashCode();
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
		if (castId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CastId);
		}
		if (castCount_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CastCount);
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
		if (castId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CastId);
		}
		if (castCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CastCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushCastCountSyncWrapper other)
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
		if (other.castId_ != null)
		{
			if (castId_ == null)
			{
				CastId = new Int32SyncWrapper();
			}
			CastId.MergeFrom(other.CastId);
		}
		if (other.castCount_ != null)
		{
			if (castCount_ == null)
			{
				CastCount = new Int32SyncWrapper();
			}
			CastCount.MergeFrom(other.CastCount);
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
				if (castId_ == null)
				{
					CastId = new Int32SyncWrapper();
				}
				input.ReadMessage(CastId);
				break;
			case 34u:
				if (castCount_ == null)
				{
					CastCount = new Int32SyncWrapper();
				}
				input.ReadMessage(CastCount);
				break;
			}
		}
	}
}
