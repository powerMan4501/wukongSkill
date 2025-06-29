using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class SoulSkillDropRecordSyncWrapper : IMessage<SoulSkillDropRecordSyncWrapper>, IMessage, IEquatable<SoulSkillDropRecordSyncWrapper>, IDeepCloneable<SoulSkillDropRecordSyncWrapper>
{
	private static readonly MessageParser<SoulSkillDropRecordSyncWrapper> _parser = new MessageParser<SoulSkillDropRecordSyncWrapper>(() => new SoulSkillDropRecordSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper soulSkillId_;

	private Uint32SyncWrapper dropCount_;

	private SoulSkillDropStatusSyncWrapper state_;

	public static MessageParser<SoulSkillDropRecordSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper SoulSkillId
	{
		get
		{
			return soulSkillId_;
		}
		set
		{
			soulSkillId_ = value;
		}
	}

	public Uint32SyncWrapper DropCount
	{
		get
		{
			return dropCount_;
		}
		set
		{
			dropCount_ = value;
		}
	}

	public SoulSkillDropStatusSyncWrapper State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	public SoulSkillDropRecordSyncWrapper()
	{
	}

	public SoulSkillDropRecordSyncWrapper(SoulSkillDropRecordSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		soulSkillId_ = ((other.soulSkillId_ != null) ? other.soulSkillId_.Clone() : null);
		dropCount_ = ((other.dropCount_ != null) ? other.dropCount_.Clone() : null);
		state_ = ((other.state_ != null) ? other.state_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SoulSkillDropRecordSyncWrapper Clone()
	{
		return new SoulSkillDropRecordSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SoulSkillDropRecordSyncWrapper);
	}

	public bool Equals(SoulSkillDropRecordSyncWrapper other)
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
		if (!object.Equals(SoulSkillId, other.SoulSkillId))
		{
			return false;
		}
		if (!object.Equals(DropCount, other.DropCount))
		{
			return false;
		}
		if (!object.Equals(State, other.State))
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
		if (soulSkillId_ != null)
		{
			num ^= SoulSkillId.GetHashCode();
		}
		if (dropCount_ != null)
		{
			num ^= DropCount.GetHashCode();
		}
		if (state_ != null)
		{
			num ^= State.GetHashCode();
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
		if (soulSkillId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SoulSkillId);
		}
		if (dropCount_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(DropCount);
		}
		if (state_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(State);
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
		if (soulSkillId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SoulSkillId);
		}
		if (dropCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DropCount);
		}
		if (state_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SoulSkillDropRecordSyncWrapper other)
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
		if (other.soulSkillId_ != null)
		{
			if (soulSkillId_ == null)
			{
				SoulSkillId = new Int32SyncWrapper();
			}
			SoulSkillId.MergeFrom(other.SoulSkillId);
		}
		if (other.dropCount_ != null)
		{
			if (dropCount_ == null)
			{
				DropCount = new Uint32SyncWrapper();
			}
			DropCount.MergeFrom(other.DropCount);
		}
		if (other.state_ != null)
		{
			if (state_ == null)
			{
				State = new SoulSkillDropStatusSyncWrapper();
			}
			State.MergeFrom(other.State);
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
				if (soulSkillId_ == null)
				{
					SoulSkillId = new Int32SyncWrapper();
				}
				input.ReadMessage(SoulSkillId);
				break;
			case 34u:
				if (dropCount_ == null)
				{
					DropCount = new Uint32SyncWrapper();
				}
				input.ReadMessage(DropCount);
				break;
			case 42u:
				if (state_ == null)
				{
					State = new SoulSkillDropStatusSyncWrapper();
				}
				input.ReadMessage(State);
				break;
			}
		}
	}
}
