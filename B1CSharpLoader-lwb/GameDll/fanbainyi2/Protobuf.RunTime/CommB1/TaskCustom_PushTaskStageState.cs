using System;
using Google.Protobuf;

namespace CommB1;

public sealed class TaskCustom_PushTaskStageState : IMessage<TaskCustom_PushTaskStageState>, IMessage, IEquatable<TaskCustom_PushTaskStageState>, IDeepCloneable<TaskCustom_PushTaskStageState>
{
	private static readonly MessageParser<TaskCustom_PushTaskStageState> _parser = new MessageParser<TaskCustom_PushTaskStageState>(() => new TaskCustom_PushTaskStageState());

	private UnknownFieldSet _unknownFields;

	private int taskStageId_;

	private bool isPushToEnd_;

	private bool isTriggerSaveArchive_;

	private string archiveLabel_ = "";

	public static MessageParser<TaskCustom_PushTaskStageState> Parser => _parser;

	public int TaskStageId
	{
		get
		{
			return taskStageId_;
		}
		set
		{
			taskStageId_ = value;
		}
	}

	public bool IsPushToEnd
	{
		get
		{
			return isPushToEnd_;
		}
		set
		{
			isPushToEnd_ = value;
		}
	}

	public bool IsTriggerSaveArchive
	{
		get
		{
			return isTriggerSaveArchive_;
		}
		set
		{
			isTriggerSaveArchive_ = value;
		}
	}

	public string ArchiveLabel
	{
		get
		{
			return archiveLabel_;
		}
		set
		{
			archiveLabel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public TaskCustom_PushTaskStageState()
	{
	}

	public TaskCustom_PushTaskStageState(TaskCustom_PushTaskStageState other)
		: this()
	{
		taskStageId_ = other.taskStageId_;
		isPushToEnd_ = other.isPushToEnd_;
		isTriggerSaveArchive_ = other.isTriggerSaveArchive_;
		archiveLabel_ = other.archiveLabel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskCustom_PushTaskStageState Clone()
	{
		return new TaskCustom_PushTaskStageState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskCustom_PushTaskStageState);
	}

	public bool Equals(TaskCustom_PushTaskStageState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TaskStageId != other.TaskStageId)
		{
			return false;
		}
		if (IsPushToEnd != other.IsPushToEnd)
		{
			return false;
		}
		if (IsTriggerSaveArchive != other.IsTriggerSaveArchive)
		{
			return false;
		}
		if (ArchiveLabel != other.ArchiveLabel)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TaskStageId != 0)
		{
			num ^= TaskStageId.GetHashCode();
		}
		if (IsPushToEnd)
		{
			num ^= IsPushToEnd.GetHashCode();
		}
		if (IsTriggerSaveArchive)
		{
			num ^= IsTriggerSaveArchive.GetHashCode();
		}
		if (ArchiveLabel.Length != 0)
		{
			num ^= ArchiveLabel.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TaskStageId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TaskStageId);
		}
		if (IsPushToEnd)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsPushToEnd);
		}
		if (IsTriggerSaveArchive)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsTriggerSaveArchive);
		}
		if (ArchiveLabel.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ArchiveLabel);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TaskStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskStageId);
		}
		if (IsPushToEnd)
		{
			num += 2;
		}
		if (IsTriggerSaveArchive)
		{
			num += 2;
		}
		if (ArchiveLabel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveLabel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TaskCustom_PushTaskStageState other)
	{
		if (other != null)
		{
			if (other.TaskStageId != 0)
			{
				TaskStageId = other.TaskStageId;
			}
			if (other.IsPushToEnd)
			{
				IsPushToEnd = other.IsPushToEnd;
			}
			if (other.IsTriggerSaveArchive)
			{
				IsTriggerSaveArchive = other.IsTriggerSaveArchive;
			}
			if (other.ArchiveLabel.Length != 0)
			{
				ArchiveLabel = other.ArchiveLabel;
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
				TaskStageId = input.ReadInt32();
				break;
			case 16u:
				IsPushToEnd = input.ReadBool();
				break;
			case 24u:
				IsTriggerSaveArchive = input.ReadBool();
				break;
			case 34u:
				ArchiveLabel = input.ReadString();
				break;
			}
		}
	}
}
