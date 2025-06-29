using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class PartyTaskSyncWrapper : IMessage<PartyTaskSyncWrapper>, IMessage, IEquatable<PartyTaskSyncWrapper>, IDeepCloneable<PartyTaskSyncWrapper>
{
	private static readonly MessageParser<PartyTaskSyncWrapper> _parser = new MessageParser<PartyTaskSyncWrapper>(() => new PartyTaskSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint64SyncWrapper taskId_;

	private PartyTaskParamSyncWrapper taskParam_;

	private PartyTaskStateSyncWrapper taskState_;

	private StringSyncWrapper gameSession_;

	private Uint32SyncWrapper createTime_;

	private Uint32SyncWrapper lastActivityTime_;

	private PartyHelpSyncWrapper help_;

	private static readonly FieldCodec<Uint64SyncWrapper> _repeated_readyMemberList_codec = FieldCodec.ForMessage(82u, Uint64SyncWrapper.Parser);

	private readonly RepeatedField<Uint64SyncWrapper> readyMemberList_ = new RepeatedField<Uint64SyncWrapper>();

	public static MessageParser<PartyTaskSyncWrapper> Parser => _parser;

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

	public Uint64SyncWrapper TaskId
	{
		get
		{
			return taskId_;
		}
		set
		{
			taskId_ = value;
		}
	}

	public PartyTaskParamSyncWrapper TaskParam
	{
		get
		{
			return taskParam_;
		}
		set
		{
			taskParam_ = value;
		}
	}

	public PartyTaskStateSyncWrapper TaskState
	{
		get
		{
			return taskState_;
		}
		set
		{
			taskState_ = value;
		}
	}

	public StringSyncWrapper GameSession
	{
		get
		{
			return gameSession_;
		}
		set
		{
			gameSession_ = value;
		}
	}

	public Uint32SyncWrapper CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	public Uint32SyncWrapper LastActivityTime
	{
		get
		{
			return lastActivityTime_;
		}
		set
		{
			lastActivityTime_ = value;
		}
	}

	public PartyHelpSyncWrapper Help
	{
		get
		{
			return help_;
		}
		set
		{
			help_ = value;
		}
	}

	public RepeatedField<Uint64SyncWrapper> ReadyMemberList => readyMemberList_;

	public PartyTaskSyncWrapper()
	{
	}

	public PartyTaskSyncWrapper(PartyTaskSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		taskId_ = ((other.taskId_ != null) ? other.taskId_.Clone() : null);
		taskParam_ = ((other.taskParam_ != null) ? other.taskParam_.Clone() : null);
		taskState_ = ((other.taskState_ != null) ? other.taskState_.Clone() : null);
		gameSession_ = ((other.gameSession_ != null) ? other.gameSession_.Clone() : null);
		createTime_ = ((other.createTime_ != null) ? other.createTime_.Clone() : null);
		lastActivityTime_ = ((other.lastActivityTime_ != null) ? other.lastActivityTime_.Clone() : null);
		help_ = ((other.help_ != null) ? other.help_.Clone() : null);
		readyMemberList_ = other.readyMemberList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyTaskSyncWrapper Clone()
	{
		return new PartyTaskSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyTaskSyncWrapper);
	}

	public bool Equals(PartyTaskSyncWrapper other)
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
		if (!object.Equals(TaskId, other.TaskId))
		{
			return false;
		}
		if (!object.Equals(TaskParam, other.TaskParam))
		{
			return false;
		}
		if (!object.Equals(TaskState, other.TaskState))
		{
			return false;
		}
		if (!object.Equals(GameSession, other.GameSession))
		{
			return false;
		}
		if (!object.Equals(CreateTime, other.CreateTime))
		{
			return false;
		}
		if (!object.Equals(LastActivityTime, other.LastActivityTime))
		{
			return false;
		}
		if (!object.Equals(Help, other.Help))
		{
			return false;
		}
		if (!readyMemberList_.Equals(other.readyMemberList_))
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
		if (taskId_ != null)
		{
			num ^= TaskId.GetHashCode();
		}
		if (taskParam_ != null)
		{
			num ^= TaskParam.GetHashCode();
		}
		if (taskState_ != null)
		{
			num ^= TaskState.GetHashCode();
		}
		if (gameSession_ != null)
		{
			num ^= GameSession.GetHashCode();
		}
		if (createTime_ != null)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (lastActivityTime_ != null)
		{
			num ^= LastActivityTime.GetHashCode();
		}
		if (help_ != null)
		{
			num ^= Help.GetHashCode();
		}
		num ^= readyMemberList_.GetHashCode();
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
		if (taskId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(TaskId);
		}
		if (taskParam_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(TaskParam);
		}
		if (taskState_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(TaskState);
		}
		if (gameSession_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(GameSession);
		}
		if (createTime_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(CreateTime);
		}
		if (lastActivityTime_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(LastActivityTime);
		}
		if (help_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Help);
		}
		readyMemberList_.WriteTo(output, _repeated_readyMemberList_codec);
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
		if (taskId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskId);
		}
		if (taskParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskParam);
		}
		if (taskState_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskState);
		}
		if (gameSession_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GameSession);
		}
		if (createTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CreateTime);
		}
		if (lastActivityTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LastActivityTime);
		}
		if (help_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Help);
		}
		num += readyMemberList_.CalculateSize(_repeated_readyMemberList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyTaskSyncWrapper other)
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
		if (other.taskId_ != null)
		{
			if (taskId_ == null)
			{
				TaskId = new Uint64SyncWrapper();
			}
			TaskId.MergeFrom(other.TaskId);
		}
		if (other.taskParam_ != null)
		{
			if (taskParam_ == null)
			{
				TaskParam = new PartyTaskParamSyncWrapper();
			}
			TaskParam.MergeFrom(other.TaskParam);
		}
		if (other.taskState_ != null)
		{
			if (taskState_ == null)
			{
				TaskState = new PartyTaskStateSyncWrapper();
			}
			TaskState.MergeFrom(other.TaskState);
		}
		if (other.gameSession_ != null)
		{
			if (gameSession_ == null)
			{
				GameSession = new StringSyncWrapper();
			}
			GameSession.MergeFrom(other.GameSession);
		}
		if (other.createTime_ != null)
		{
			if (createTime_ == null)
			{
				CreateTime = new Uint32SyncWrapper();
			}
			CreateTime.MergeFrom(other.CreateTime);
		}
		if (other.lastActivityTime_ != null)
		{
			if (lastActivityTime_ == null)
			{
				LastActivityTime = new Uint32SyncWrapper();
			}
			LastActivityTime.MergeFrom(other.LastActivityTime);
		}
		if (other.help_ != null)
		{
			if (help_ == null)
			{
				Help = new PartyHelpSyncWrapper();
			}
			Help.MergeFrom(other.Help);
		}
		readyMemberList_.Add(other.readyMemberList_);
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
				if (taskId_ == null)
				{
					TaskId = new Uint64SyncWrapper();
				}
				input.ReadMessage(TaskId);
				break;
			case 34u:
				if (taskParam_ == null)
				{
					TaskParam = new PartyTaskParamSyncWrapper();
				}
				input.ReadMessage(TaskParam);
				break;
			case 42u:
				if (taskState_ == null)
				{
					TaskState = new PartyTaskStateSyncWrapper();
				}
				input.ReadMessage(TaskState);
				break;
			case 50u:
				if (gameSession_ == null)
				{
					GameSession = new StringSyncWrapper();
				}
				input.ReadMessage(GameSession);
				break;
			case 58u:
				if (createTime_ == null)
				{
					CreateTime = new Uint32SyncWrapper();
				}
				input.ReadMessage(CreateTime);
				break;
			case 66u:
				if (lastActivityTime_ == null)
				{
					LastActivityTime = new Uint32SyncWrapper();
				}
				input.ReadMessage(LastActivityTime);
				break;
			case 74u:
				if (help_ == null)
				{
					Help = new PartyHelpSyncWrapper();
				}
				input.ReadMessage(Help);
				break;
			case 82u:
				readyMemberList_.AddEntriesFrom(input, _repeated_readyMemberList_codec);
				break;
			}
		}
	}
}
