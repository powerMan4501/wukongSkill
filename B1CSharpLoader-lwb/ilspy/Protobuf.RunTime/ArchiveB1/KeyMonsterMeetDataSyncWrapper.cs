using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class KeyMonsterMeetDataSyncWrapper : IMessage<KeyMonsterMeetDataSyncWrapper>, IMessage, IEquatable<KeyMonsterMeetDataSyncWrapper>, IDeepCloneable<KeyMonsterMeetDataSyncWrapper>
{
	private static readonly MessageParser<KeyMonsterMeetDataSyncWrapper> _parser = new MessageParser<KeyMonsterMeetDataSyncWrapper>(() => new KeyMonsterMeetDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper extendId_;

	private Int32SyncWrapper inToBattleCount_;

	private StringSyncWrapper guid_;

	public static MessageParser<KeyMonsterMeetDataSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
		}
	}

	public Int32SyncWrapper InToBattleCount
	{
		get
		{
			return inToBattleCount_;
		}
		set
		{
			inToBattleCount_ = value;
		}
	}

	public StringSyncWrapper Guid
	{
		get
		{
			return guid_;
		}
		set
		{
			guid_ = value;
		}
	}

	public KeyMonsterMeetDataSyncWrapper()
	{
	}

	public KeyMonsterMeetDataSyncWrapper(KeyMonsterMeetDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		extendId_ = ((other.extendId_ != null) ? other.extendId_.Clone() : null);
		inToBattleCount_ = ((other.inToBattleCount_ != null) ? other.inToBattleCount_.Clone() : null);
		guid_ = ((other.guid_ != null) ? other.guid_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public KeyMonsterMeetDataSyncWrapper Clone()
	{
		return new KeyMonsterMeetDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as KeyMonsterMeetDataSyncWrapper);
	}

	public bool Equals(KeyMonsterMeetDataSyncWrapper other)
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
		if (!object.Equals(ExtendId, other.ExtendId))
		{
			return false;
		}
		if (!object.Equals(InToBattleCount, other.InToBattleCount))
		{
			return false;
		}
		if (!object.Equals(Guid, other.Guid))
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
		if (extendId_ != null)
		{
			num ^= ExtendId.GetHashCode();
		}
		if (inToBattleCount_ != null)
		{
			num ^= InToBattleCount.GetHashCode();
		}
		if (guid_ != null)
		{
			num ^= Guid.GetHashCode();
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
		if (extendId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ExtendId);
		}
		if (inToBattleCount_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(InToBattleCount);
		}
		if (guid_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Guid);
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
		if (extendId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExtendId);
		}
		if (inToBattleCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(InToBattleCount);
		}
		if (guid_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Guid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(KeyMonsterMeetDataSyncWrapper other)
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
		if (other.extendId_ != null)
		{
			if (extendId_ == null)
			{
				ExtendId = new Int32SyncWrapper();
			}
			ExtendId.MergeFrom(other.ExtendId);
		}
		if (other.inToBattleCount_ != null)
		{
			if (inToBattleCount_ == null)
			{
				InToBattleCount = new Int32SyncWrapper();
			}
			InToBattleCount.MergeFrom(other.InToBattleCount);
		}
		if (other.guid_ != null)
		{
			if (guid_ == null)
			{
				Guid = new StringSyncWrapper();
			}
			Guid.MergeFrom(other.Guid);
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
				if (extendId_ == null)
				{
					ExtendId = new Int32SyncWrapper();
				}
				input.ReadMessage(ExtendId);
				break;
			case 34u:
				if (inToBattleCount_ == null)
				{
					InToBattleCount = new Int32SyncWrapper();
				}
				input.ReadMessage(InToBattleCount);
				break;
			case 42u:
				if (guid_ == null)
				{
					Guid = new StringSyncWrapper();
				}
				input.ReadMessage(Guid);
				break;
			}
		}
	}
}
