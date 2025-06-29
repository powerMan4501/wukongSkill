using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class AlchemyNpcCommunicationStatusSyncWrapper : IMessage<AlchemyNpcCommunicationStatusSyncWrapper>, IMessage, IEquatable<AlchemyNpcCommunicationStatusSyncWrapper>, IDeepCloneable<AlchemyNpcCommunicationStatusSyncWrapper>
{
	private static readonly MessageParser<AlchemyNpcCommunicationStatusSyncWrapper> _parser = new MessageParser<AlchemyNpcCommunicationStatusSyncWrapper>(() => new AlchemyNpcCommunicationStatusSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private FloatSyncWrapper lastCommunicationTime_;

	private BoolSyncWrapper canGetAward_;

	public static MessageParser<AlchemyNpcCommunicationStatusSyncWrapper> Parser => _parser;

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

	public FloatSyncWrapper LastCommunicationTime
	{
		get
		{
			return lastCommunicationTime_;
		}
		set
		{
			lastCommunicationTime_ = value;
		}
	}

	public BoolSyncWrapper CanGetAward
	{
		get
		{
			return canGetAward_;
		}
		set
		{
			canGetAward_ = value;
		}
	}

	public AlchemyNpcCommunicationStatusSyncWrapper()
	{
	}

	public AlchemyNpcCommunicationStatusSyncWrapper(AlchemyNpcCommunicationStatusSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		lastCommunicationTime_ = ((other.lastCommunicationTime_ != null) ? other.lastCommunicationTime_.Clone() : null);
		canGetAward_ = ((other.canGetAward_ != null) ? other.canGetAward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AlchemyNpcCommunicationStatusSyncWrapper Clone()
	{
		return new AlchemyNpcCommunicationStatusSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AlchemyNpcCommunicationStatusSyncWrapper);
	}

	public bool Equals(AlchemyNpcCommunicationStatusSyncWrapper other)
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
		if (!object.Equals(LastCommunicationTime, other.LastCommunicationTime))
		{
			return false;
		}
		if (!object.Equals(CanGetAward, other.CanGetAward))
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
		if (lastCommunicationTime_ != null)
		{
			num ^= LastCommunicationTime.GetHashCode();
		}
		if (canGetAward_ != null)
		{
			num ^= CanGetAward.GetHashCode();
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
		if (lastCommunicationTime_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LastCommunicationTime);
		}
		if (canGetAward_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CanGetAward);
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
		if (lastCommunicationTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LastCommunicationTime);
		}
		if (canGetAward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CanGetAward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AlchemyNpcCommunicationStatusSyncWrapper other)
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
		if (other.lastCommunicationTime_ != null)
		{
			if (lastCommunicationTime_ == null)
			{
				LastCommunicationTime = new FloatSyncWrapper();
			}
			LastCommunicationTime.MergeFrom(other.LastCommunicationTime);
		}
		if (other.canGetAward_ != null)
		{
			if (canGetAward_ == null)
			{
				CanGetAward = new BoolSyncWrapper();
			}
			CanGetAward.MergeFrom(other.CanGetAward);
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
				if (lastCommunicationTime_ == null)
				{
					LastCommunicationTime = new FloatSyncWrapper();
				}
				input.ReadMessage(LastCommunicationTime);
				break;
			case 34u:
				if (canGetAward_ == null)
				{
					CanGetAward = new BoolSyncWrapper();
				}
				input.ReadMessage(CanGetAward);
				break;
			}
		}
	}
}
