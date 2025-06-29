using System;
using Google.Protobuf;

namespace ResB1;

public sealed class PS5ActivityTaskDesc : IMessage<PS5ActivityTaskDesc>, IMessage, IEquatable<PS5ActivityTaskDesc>, IDeepCloneable<PS5ActivityTaskDesc>
{
	private static readonly MessageParser<PS5ActivityTaskDesc> _parser = new MessageParser<PS5ActivityTaskDesc>(() => new PS5ActivityTaskDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private int activityId_;

	private int taskStageId_;

	private int extendId_;

	private YesNoType isRequiredForCompletion_;

	private YesNoType isHidden_;

	private int localizationTag_;

	public static MessageParser<PS5ActivityTaskDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ActivityId
	{
		get
		{
			return activityId_;
		}
		set
		{
			activityId_ = value;
		}
	}

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

	public int ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
		}
	}

	public YesNoType IsRequiredForCompletion
	{
		get
		{
			return isRequiredForCompletion_;
		}
		set
		{
			isRequiredForCompletion_ = value;
		}
	}

	public YesNoType IsHidden
	{
		get
		{
			return isHidden_;
		}
		set
		{
			isHidden_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public PS5ActivityTaskDesc()
	{
	}

	public PS5ActivityTaskDesc(PS5ActivityTaskDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		activityId_ = other.activityId_;
		taskStageId_ = other.taskStageId_;
		extendId_ = other.extendId_;
		isRequiredForCompletion_ = other.isRequiredForCompletion_;
		isHidden_ = other.isHidden_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PS5ActivityTaskDesc Clone()
	{
		return new PS5ActivityTaskDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PS5ActivityTaskDesc);
	}

	public bool Equals(PS5ActivityTaskDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (ActivityId != other.ActivityId)
		{
			return false;
		}
		if (TaskStageId != other.TaskStageId)
		{
			return false;
		}
		if (ExtendId != other.ExtendId)
		{
			return false;
		}
		if (IsRequiredForCompletion != other.IsRequiredForCompletion)
		{
			return false;
		}
		if (IsHidden != other.IsHidden)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (ActivityId != 0)
		{
			num ^= ActivityId.GetHashCode();
		}
		if (TaskStageId != 0)
		{
			num ^= TaskStageId.GetHashCode();
		}
		if (ExtendId != 0)
		{
			num ^= ExtendId.GetHashCode();
		}
		if (IsRequiredForCompletion != YesNoType.No)
		{
			num ^= IsRequiredForCompletion.GetHashCode();
		}
		if (IsHidden != YesNoType.No)
		{
			num ^= IsHidden.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (ActivityId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ActivityId);
		}
		if (TaskStageId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TaskStageId);
		}
		if (ExtendId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ExtendId);
		}
		if (IsRequiredForCompletion != YesNoType.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)IsRequiredForCompletion);
		}
		if (IsHidden != YesNoType.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)IsHidden);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (ActivityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ActivityId);
		}
		if (TaskStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskStageId);
		}
		if (ExtendId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtendId);
		}
		if (IsRequiredForCompletion != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsRequiredForCompletion);
		}
		if (IsHidden != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsHidden);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PS5ActivityTaskDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.ActivityId != 0)
			{
				ActivityId = other.ActivityId;
			}
			if (other.TaskStageId != 0)
			{
				TaskStageId = other.TaskStageId;
			}
			if (other.ExtendId != 0)
			{
				ExtendId = other.ExtendId;
			}
			if (other.IsRequiredForCompletion != YesNoType.No)
			{
				IsRequiredForCompletion = other.IsRequiredForCompletion;
			}
			if (other.IsHidden != YesNoType.No)
			{
				IsHidden = other.IsHidden;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				ActivityId = input.ReadInt32();
				break;
			case 32u:
				TaskStageId = input.ReadInt32();
				break;
			case 40u:
				ExtendId = input.ReadInt32();
				break;
			case 48u:
				IsRequiredForCompletion = (YesNoType)input.ReadEnum();
				break;
			case 56u:
				IsHidden = (YesNoType)input.ReadEnum();
				break;
			case 64u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
