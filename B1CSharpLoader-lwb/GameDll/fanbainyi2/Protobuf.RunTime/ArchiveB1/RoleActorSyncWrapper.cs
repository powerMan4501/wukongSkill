using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class RoleActorSyncWrapper : IMessage<RoleActorSyncWrapper>, IMessage, IEquatable<RoleActorSyncWrapper>, IDeepCloneable<RoleActorSyncWrapper>
{
	private static readonly MessageParser<RoleActorSyncWrapper> _parser = new MessageParser<RoleActorSyncWrapper>(() => new RoleActorSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private ActorWearSyncWrapper wear_;

	private ActorProgressSyncWrapper progress_;

	private Int32SyncWrapper newGamePlusCount_;

	public static MessageParser<RoleActorSyncWrapper> Parser => _parser;

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

	public ActorWearSyncWrapper Wear
	{
		get
		{
			return wear_;
		}
		set
		{
			wear_ = value;
		}
	}

	public ActorProgressSyncWrapper Progress
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

	public Int32SyncWrapper NewGamePlusCount
	{
		get
		{
			return newGamePlusCount_;
		}
		set
		{
			newGamePlusCount_ = value;
		}
	}

	public RoleActorSyncWrapper()
	{
	}

	public RoleActorSyncWrapper(RoleActorSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		wear_ = ((other.wear_ != null) ? other.wear_.Clone() : null);
		progress_ = ((other.progress_ != null) ? other.progress_.Clone() : null);
		newGamePlusCount_ = ((other.newGamePlusCount_ != null) ? other.newGamePlusCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleActorSyncWrapper Clone()
	{
		return new RoleActorSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleActorSyncWrapper);
	}

	public bool Equals(RoleActorSyncWrapper other)
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
		if (!object.Equals(Wear, other.Wear))
		{
			return false;
		}
		if (!object.Equals(Progress, other.Progress))
		{
			return false;
		}
		if (!object.Equals(NewGamePlusCount, other.NewGamePlusCount))
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
		if (wear_ != null)
		{
			num ^= Wear.GetHashCode();
		}
		if (progress_ != null)
		{
			num ^= Progress.GetHashCode();
		}
		if (newGamePlusCount_ != null)
		{
			num ^= NewGamePlusCount.GetHashCode();
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
		if (wear_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Wear);
		}
		if (progress_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Progress);
		}
		if (newGamePlusCount_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NewGamePlusCount);
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
		if (wear_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Wear);
		}
		if (progress_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Progress);
		}
		if (newGamePlusCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NewGamePlusCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleActorSyncWrapper other)
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
		if (other.wear_ != null)
		{
			if (wear_ == null)
			{
				Wear = new ActorWearSyncWrapper();
			}
			Wear.MergeFrom(other.Wear);
		}
		if (other.progress_ != null)
		{
			if (progress_ == null)
			{
				Progress = new ActorProgressSyncWrapper();
			}
			Progress.MergeFrom(other.Progress);
		}
		if (other.newGamePlusCount_ != null)
		{
			if (newGamePlusCount_ == null)
			{
				NewGamePlusCount = new Int32SyncWrapper();
			}
			NewGamePlusCount.MergeFrom(other.NewGamePlusCount);
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
				if (wear_ == null)
				{
					Wear = new ActorWearSyncWrapper();
				}
				input.ReadMessage(Wear);
				break;
			case 34u:
				if (progress_ == null)
				{
					Progress = new ActorProgressSyncWrapper();
				}
				input.ReadMessage(Progress);
				break;
			case 42u:
				if (newGamePlusCount_ == null)
				{
					NewGamePlusCount = new Int32SyncWrapper();
				}
				input.ReadMessage(NewGamePlusCount);
				break;
			}
		}
	}
}
