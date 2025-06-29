using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventTask : IMessage<ReportEventTask>, IMessage, IEquatable<ReportEventTask>, IDeepCloneable<ReportEventTask>
{
	private static readonly MessageParser<ReportEventTask> _parser = new MessageParser<ReportEventTask>(() => new ReportEventTask());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private int taskId_;

	private int stage_;

	private TaskStageState state_;

	private string stageNote_ = "";

	public static MessageParser<ReportEventTask> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public int TaskId
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

	public int Stage
	{
		get
		{
			return stage_;
		}
		set
		{
			stage_ = value;
		}
	}

	public TaskStageState State
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

	public string StageNote
	{
		get
		{
			return stageNote_;
		}
		set
		{
			stageNote_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventTask()
	{
	}

	public ReportEventTask(ReportEventTask other)
		: this()
	{
		roleId_ = other.roleId_;
		taskId_ = other.taskId_;
		stage_ = other.stage_;
		state_ = other.state_;
		stageNote_ = other.stageNote_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventTask Clone()
	{
		return new ReportEventTask(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventTask);
	}

	public bool Equals(ReportEventTask other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (TaskId != other.TaskId)
		{
			return false;
		}
		if (Stage != other.Stage)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (StageNote != other.StageNote)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (TaskId != 0)
		{
			num ^= TaskId.GetHashCode();
		}
		if (Stage != 0)
		{
			num ^= Stage.GetHashCode();
		}
		if (State != TaskStageState.Begin)
		{
			num ^= State.GetHashCode();
		}
		if (StageNote.Length != 0)
		{
			num ^= StageNote.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		if (TaskId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TaskId);
		}
		if (Stage != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Stage);
		}
		if (State != TaskStageState.Begin)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)State);
		}
		if (StageNote.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(StageNote);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (TaskId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskId);
		}
		if (Stage != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Stage);
		}
		if (State != TaskStageState.Begin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (StageNote.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StageNote);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventTask other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.TaskId != 0)
			{
				TaskId = other.TaskId;
			}
			if (other.Stage != 0)
			{
				Stage = other.Stage;
			}
			if (other.State != TaskStageState.Begin)
			{
				State = other.State;
			}
			if (other.StageNote.Length != 0)
			{
				StageNote = other.StageNote;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				RoleId = input.ReadUInt64();
				break;
			case 16u:
				TaskId = input.ReadInt32();
				break;
			case 24u:
				Stage = input.ReadInt32();
				break;
			case 32u:
				State = (TaskStageState)input.ReadEnum();
				break;
			case 42u:
				StageNote = input.ReadString();
				break;
			}
		}
	}
}
