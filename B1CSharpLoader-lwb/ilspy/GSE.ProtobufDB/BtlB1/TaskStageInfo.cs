using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class TaskStageInfo : IMessage<TaskStageInfo>, IMessage, IEquatable<TaskStageInfo>, IDeepCloneable<TaskStageInfo>
{
	private static readonly MessageParser<TaskStageInfo> _parser = new MessageParser<TaskStageInfo>(() => new TaskStageInfo());

	private UnknownFieldSet _unknownFields;

	private int taskStageID_;

	private ETaskStageState taskStageState_;

	public static MessageParser<TaskStageInfo> Parser => _parser;

	public int TaskStageID
	{
		get
		{
			return taskStageID_;
		}
		set
		{
			taskStageID_ = value;
		}
	}

	public ETaskStageState TaskStageState
	{
		get
		{
			return taskStageState_;
		}
		set
		{
			taskStageState_ = value;
		}
	}

	public TaskStageInfo()
	{
	}

	public TaskStageInfo(TaskStageInfo other)
		: this()
	{
		taskStageID_ = other.taskStageID_;
		taskStageState_ = other.taskStageState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskStageInfo Clone()
	{
		return new TaskStageInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskStageInfo);
	}

	public bool Equals(TaskStageInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TaskStageID != other.TaskStageID)
		{
			return false;
		}
		if (TaskStageState != other.TaskStageState)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TaskStageID != 0)
		{
			num ^= TaskStageID.GetHashCode();
		}
		if (TaskStageState != ETaskStageState.Default)
		{
			num ^= TaskStageState.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TaskStageID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TaskStageID);
		}
		if (TaskStageState != ETaskStageState.Default)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)TaskStageState);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TaskStageID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskStageID);
		}
		if (TaskStageState != ETaskStageState.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TaskStageState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TaskStageInfo other)
	{
		if (other != null)
		{
			if (other.TaskStageID != 0)
			{
				TaskStageID = other.TaskStageID;
			}
			if (other.TaskStageState != ETaskStageState.Default)
			{
				TaskStageState = other.TaskStageState;
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
				TaskStageID = input.ReadInt32();
				break;
			case 16u:
				TaskStageState = (ETaskStageState)input.ReadEnum();
				break;
			}
		}
	}
}
