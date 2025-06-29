using System;
using ArchiveB1;
using Google.Protobuf;

namespace CommB1;

public sealed class TaskConditionOutpinInfo : IMessage<TaskConditionOutpinInfo>, IMessage, IEquatable<TaskConditionOutpinInfo>, IDeepCloneable<TaskConditionOutpinInfo>
{
	private static readonly MessageParser<TaskConditionOutpinInfo> _parser = new MessageParser<TaskConditionOutpinInfo>(() => new TaskConditionOutpinInfo());

	private UnknownFieldSet _unknownFields;

	private QuestStageOne taskConditionInfo_;

	private string outpinName_ = "";

	public static MessageParser<TaskConditionOutpinInfo> Parser => _parser;

	public QuestStageOne TaskConditionInfo
	{
		get
		{
			return taskConditionInfo_;
		}
		set
		{
			taskConditionInfo_ = value;
		}
	}

	public string OutpinName
	{
		get
		{
			return outpinName_;
		}
		set
		{
			outpinName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public TaskConditionOutpinInfo()
	{
	}

	public TaskConditionOutpinInfo(TaskConditionOutpinInfo other)
		: this()
	{
		taskConditionInfo_ = ((other.taskConditionInfo_ != null) ? other.taskConditionInfo_.Clone() : null);
		outpinName_ = other.outpinName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskConditionOutpinInfo Clone()
	{
		return new TaskConditionOutpinInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskConditionOutpinInfo);
	}

	public bool Equals(TaskConditionOutpinInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(TaskConditionInfo, other.TaskConditionInfo))
		{
			return false;
		}
		if (OutpinName != other.OutpinName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (taskConditionInfo_ != null)
		{
			num ^= TaskConditionInfo.GetHashCode();
		}
		if (OutpinName.Length != 0)
		{
			num ^= OutpinName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (taskConditionInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(TaskConditionInfo);
		}
		if (OutpinName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(OutpinName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (taskConditionInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TaskConditionInfo);
		}
		if (OutpinName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OutpinName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TaskConditionOutpinInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.taskConditionInfo_ != null)
		{
			if (taskConditionInfo_ == null)
			{
				TaskConditionInfo = new QuestStageOne();
			}
			TaskConditionInfo.MergeFrom(other.TaskConditionInfo);
		}
		if (other.OutpinName.Length != 0)
		{
			OutpinName = other.OutpinName;
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
			case 10u:
				if (taskConditionInfo_ == null)
				{
					TaskConditionInfo = new QuestStageOne();
				}
				input.ReadMessage(TaskConditionInfo);
				break;
			case 18u:
				OutpinName = input.ReadString();
				break;
			}
		}
	}
}
