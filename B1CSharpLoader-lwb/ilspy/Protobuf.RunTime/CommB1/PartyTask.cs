using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class PartyTask : IMessage<PartyTask>, IMessage, IEquatable<PartyTask>, IDeepCloneable<PartyTask>
{
	private static readonly MessageParser<PartyTask> _parser = new MessageParser<PartyTask>(() => new PartyTask());

	private UnknownFieldSet _unknownFields;

	private ulong taskId_;

	private PartyTaskParam taskParam_;

	private PartyTaskState taskState_;

	private string gameSession_ = "";

	private uint createTime_;

	private uint lastActivityTime_;

	private PartyHelp help_;

	private static readonly FieldCodec<ulong> _repeated_readyMemberList_codec = FieldCodec.ForUInt64(66u);

	private readonly RepeatedField<ulong> readyMemberList_ = new RepeatedField<ulong>();

	public static MessageParser<PartyTask> Parser => _parser;

	public ulong TaskId
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

	public PartyTaskParam TaskParam
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

	public PartyTaskState TaskState
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

	public string GameSession
	{
		get
		{
			return gameSession_;
		}
		set
		{
			gameSession_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint CreateTime
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

	public uint LastActivityTime
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

	public PartyHelp Help
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

	public RepeatedField<ulong> ReadyMemberList => readyMemberList_;

	public PartyTask()
	{
	}

	public PartyTask(PartyTask other)
		: this()
	{
		taskId_ = other.taskId_;
		taskParam_ = ((other.taskParam_ != null) ? other.taskParam_.Clone() : null);
		taskState_ = other.taskState_;
		gameSession_ = other.gameSession_;
		createTime_ = other.createTime_;
		lastActivityTime_ = other.lastActivityTime_;
		help_ = ((other.help_ != null) ? other.help_.Clone() : null);
		readyMemberList_ = other.readyMemberList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyTask Clone()
	{
		return new PartyTask(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyTask);
	}

	public bool Equals(PartyTask other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TaskId != other.TaskId)
		{
			return false;
		}
		if (!object.Equals(TaskParam, other.TaskParam))
		{
			return false;
		}
		if (TaskState != other.TaskState)
		{
			return false;
		}
		if (GameSession != other.GameSession)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (LastActivityTime != other.LastActivityTime)
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
		if (TaskId != 0L)
		{
			num ^= TaskId.GetHashCode();
		}
		if (taskParam_ != null)
		{
			num ^= TaskParam.GetHashCode();
		}
		if (TaskState != PartyTaskState.None)
		{
			num ^= TaskState.GetHashCode();
		}
		if (GameSession.Length != 0)
		{
			num ^= GameSession.GetHashCode();
		}
		if (CreateTime != 0)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (LastActivityTime != 0)
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
		if (TaskId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(TaskId);
		}
		if (taskParam_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(TaskParam);
		}
		if (TaskState != PartyTaskState.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)TaskState);
		}
		if (GameSession.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(GameSession);
		}
		if (CreateTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CreateTime);
		}
		if (LastActivityTime != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LastActivityTime);
		}
		if (help_ != null)
		{
			output.WriteRawTag(58);
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
		if (TaskId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(TaskId);
		}
		if (taskParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskParam);
		}
		if (TaskState != PartyTaskState.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TaskState);
		}
		if (GameSession.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GameSession);
		}
		if (CreateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CreateTime);
		}
		if (LastActivityTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LastActivityTime);
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

	public void MergeFrom(PartyTask other)
	{
		if (other == null)
		{
			return;
		}
		if (other.TaskId != 0L)
		{
			TaskId = other.TaskId;
		}
		if (other.taskParam_ != null)
		{
			if (taskParam_ == null)
			{
				TaskParam = new PartyTaskParam();
			}
			TaskParam.MergeFrom(other.TaskParam);
		}
		if (other.TaskState != PartyTaskState.None)
		{
			TaskState = other.TaskState;
		}
		if (other.GameSession.Length != 0)
		{
			GameSession = other.GameSession;
		}
		if (other.CreateTime != 0)
		{
			CreateTime = other.CreateTime;
		}
		if (other.LastActivityTime != 0)
		{
			LastActivityTime = other.LastActivityTime;
		}
		if (other.help_ != null)
		{
			if (help_ == null)
			{
				Help = new PartyHelp();
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
				TaskId = input.ReadUInt64();
				break;
			case 18u:
				if (taskParam_ == null)
				{
					TaskParam = new PartyTaskParam();
				}
				input.ReadMessage(TaskParam);
				break;
			case 24u:
				TaskState = (PartyTaskState)input.ReadEnum();
				break;
			case 34u:
				GameSession = input.ReadString();
				break;
			case 40u:
				CreateTime = input.ReadUInt32();
				break;
			case 48u:
				LastActivityTime = input.ReadUInt32();
				break;
			case 58u:
				if (help_ == null)
				{
					Help = new PartyHelp();
				}
				input.ReadMessage(Help);
				break;
			case 64u:
			case 66u:
				readyMemberList_.AddEntriesFrom(input, _repeated_readyMemberList_codec);
				break;
			}
		}
	}
}
