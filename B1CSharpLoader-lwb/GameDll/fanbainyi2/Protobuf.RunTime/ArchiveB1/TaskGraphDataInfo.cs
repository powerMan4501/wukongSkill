using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class TaskGraphDataInfo : IMessage<TaskGraphDataInfo>, IMessage, IEquatable<TaskGraphDataInfo>, IDeepCloneable<TaskGraphDataInfo>
{
	private static readonly MessageParser<TaskGraphDataInfo> _parser = new MessageParser<TaskGraphDataInfo>(() => new TaskGraphDataInfo());

	private UnknownFieldSet _unknownFields;

	private int taskLineId_;

	private LevelArchiveQuestData taskGraphData_;

	public static MessageParser<TaskGraphDataInfo> Parser => _parser;

	public int TaskLineId
	{
		get
		{
			return taskLineId_;
		}
		set
		{
			taskLineId_ = value;
		}
	}

	public LevelArchiveQuestData TaskGraphData
	{
		get
		{
			return taskGraphData_;
		}
		set
		{
			taskGraphData_ = value;
		}
	}

	public TaskGraphDataInfo()
	{
	}

	public TaskGraphDataInfo(TaskGraphDataInfo other)
		: this()
	{
		taskLineId_ = other.taskLineId_;
		taskGraphData_ = ((other.taskGraphData_ != null) ? other.taskGraphData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskGraphDataInfo Clone()
	{
		return new TaskGraphDataInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskGraphDataInfo);
	}

	public bool Equals(TaskGraphDataInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TaskLineId != other.TaskLineId)
		{
			return false;
		}
		if (!object.Equals(TaskGraphData, other.TaskGraphData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TaskLineId != 0)
		{
			num ^= TaskLineId.GetHashCode();
		}
		if (taskGraphData_ != null)
		{
			num ^= TaskGraphData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TaskLineId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TaskLineId);
		}
		if (taskGraphData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(TaskGraphData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TaskLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskLineId);
		}
		if (taskGraphData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskGraphData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TaskGraphDataInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.TaskLineId != 0)
		{
			TaskLineId = other.TaskLineId;
		}
		if (other.taskGraphData_ != null)
		{
			if (taskGraphData_ == null)
			{
				TaskGraphData = new LevelArchiveQuestData();
			}
			TaskGraphData.MergeFrom(other.TaskGraphData);
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
				TaskLineId = input.ReadInt32();
				break;
			case 18u:
				if (taskGraphData_ == null)
				{
					TaskGraphData = new LevelArchiveQuestData();
				}
				input.ReadMessage(TaskGraphData);
				break;
			}
		}
	}
}
