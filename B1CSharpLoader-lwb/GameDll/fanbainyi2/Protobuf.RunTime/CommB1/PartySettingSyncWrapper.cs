using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class PartySettingSyncWrapper : IMessage<PartySettingSyncWrapper>, IMessage, IEquatable<PartySettingSyncWrapper>, IDeepCloneable<PartySettingSyncWrapper>
{
	private static readonly MessageParser<PartySettingSyncWrapper> _parser = new MessageParser<PartySettingSyncWrapper>(() => new PartySettingSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint32SyncWrapper maxMemberNum_;

	private PartyAdvertiseTypeSyncWrapper advertiseType_;

	private StringSyncWrapper password_;

	private Int32SyncWrapper taskType_;

	public static MessageParser<PartySettingSyncWrapper> Parser => _parser;

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

	public Uint32SyncWrapper MaxMemberNum
	{
		get
		{
			return maxMemberNum_;
		}
		set
		{
			maxMemberNum_ = value;
		}
	}

	public PartyAdvertiseTypeSyncWrapper AdvertiseType
	{
		get
		{
			return advertiseType_;
		}
		set
		{
			advertiseType_ = value;
		}
	}

	public StringSyncWrapper Password
	{
		get
		{
			return password_;
		}
		set
		{
			password_ = value;
		}
	}

	public Int32SyncWrapper TaskType
	{
		get
		{
			return taskType_;
		}
		set
		{
			taskType_ = value;
		}
	}

	public PartySettingSyncWrapper()
	{
	}

	public PartySettingSyncWrapper(PartySettingSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		maxMemberNum_ = ((other.maxMemberNum_ != null) ? other.maxMemberNum_.Clone() : null);
		advertiseType_ = ((other.advertiseType_ != null) ? other.advertiseType_.Clone() : null);
		password_ = ((other.password_ != null) ? other.password_.Clone() : null);
		taskType_ = ((other.taskType_ != null) ? other.taskType_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartySettingSyncWrapper Clone()
	{
		return new PartySettingSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartySettingSyncWrapper);
	}

	public bool Equals(PartySettingSyncWrapper other)
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
		if (!object.Equals(MaxMemberNum, other.MaxMemberNum))
		{
			return false;
		}
		if (!object.Equals(AdvertiseType, other.AdvertiseType))
		{
			return false;
		}
		if (!object.Equals(Password, other.Password))
		{
			return false;
		}
		if (!object.Equals(TaskType, other.TaskType))
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
		if (maxMemberNum_ != null)
		{
			num ^= MaxMemberNum.GetHashCode();
		}
		if (advertiseType_ != null)
		{
			num ^= AdvertiseType.GetHashCode();
		}
		if (password_ != null)
		{
			num ^= Password.GetHashCode();
		}
		if (taskType_ != null)
		{
			num ^= TaskType.GetHashCode();
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
		if (maxMemberNum_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MaxMemberNum);
		}
		if (advertiseType_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(AdvertiseType);
		}
		if (password_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Password);
		}
		if (taskType_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(TaskType);
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
		if (maxMemberNum_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MaxMemberNum);
		}
		if (advertiseType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AdvertiseType);
		}
		if (password_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Password);
		}
		if (taskType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartySettingSyncWrapper other)
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
		if (other.maxMemberNum_ != null)
		{
			if (maxMemberNum_ == null)
			{
				MaxMemberNum = new Uint32SyncWrapper();
			}
			MaxMemberNum.MergeFrom(other.MaxMemberNum);
		}
		if (other.advertiseType_ != null)
		{
			if (advertiseType_ == null)
			{
				AdvertiseType = new PartyAdvertiseTypeSyncWrapper();
			}
			AdvertiseType.MergeFrom(other.AdvertiseType);
		}
		if (other.password_ != null)
		{
			if (password_ == null)
			{
				Password = new StringSyncWrapper();
			}
			Password.MergeFrom(other.Password);
		}
		if (other.taskType_ != null)
		{
			if (taskType_ == null)
			{
				TaskType = new Int32SyncWrapper();
			}
			TaskType.MergeFrom(other.TaskType);
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
				if (maxMemberNum_ == null)
				{
					MaxMemberNum = new Uint32SyncWrapper();
				}
				input.ReadMessage(MaxMemberNum);
				break;
			case 34u:
				if (advertiseType_ == null)
				{
					AdvertiseType = new PartyAdvertiseTypeSyncWrapper();
				}
				input.ReadMessage(AdvertiseType);
				break;
			case 42u:
				if (password_ == null)
				{
					Password = new StringSyncWrapper();
				}
				input.ReadMessage(Password);
				break;
			case 50u:
				if (taskType_ == null)
				{
					TaskType = new Int32SyncWrapper();
				}
				input.ReadMessage(TaskType);
				break;
			}
		}
	}
}
