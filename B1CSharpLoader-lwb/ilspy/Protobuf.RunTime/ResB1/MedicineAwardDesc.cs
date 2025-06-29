using System;
using Google.Protobuf;

namespace ResB1;

public sealed class MedicineAwardDesc : IMessage<MedicineAwardDesc>, IMessage, IEquatable<MedicineAwardDesc>, IDeepCloneable<MedicineAwardDesc>
{
	private static readonly MessageParser<MedicineAwardDesc> _parser = new MessageParser<MedicineAwardDesc>(() => new MedicineAwardDesc());

	private UnknownFieldSet _unknownFields;

	private int dropId_;

	private int taskStageId_;

	private int newGamePlusCount_;

	public static MessageParser<MedicineAwardDesc> Parser => _parser;

	public int DropId
	{
		get
		{
			return dropId_;
		}
		set
		{
			dropId_ = value;
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

	public int NewGamePlusCount
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

	public MedicineAwardDesc()
	{
	}

	public MedicineAwardDesc(MedicineAwardDesc other)
		: this()
	{
		dropId_ = other.dropId_;
		taskStageId_ = other.taskStageId_;
		newGamePlusCount_ = other.newGamePlusCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MedicineAwardDesc Clone()
	{
		return new MedicineAwardDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MedicineAwardDesc);
	}

	public bool Equals(MedicineAwardDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DropId != other.DropId)
		{
			return false;
		}
		if (TaskStageId != other.TaskStageId)
		{
			return false;
		}
		if (NewGamePlusCount != other.NewGamePlusCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DropId != 0)
		{
			num ^= DropId.GetHashCode();
		}
		if (TaskStageId != 0)
		{
			num ^= TaskStageId.GetHashCode();
		}
		if (NewGamePlusCount != 0)
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
		if (DropId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DropId);
		}
		if (TaskStageId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TaskStageId);
		}
		if (NewGamePlusCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(NewGamePlusCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropId);
		}
		if (TaskStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskStageId);
		}
		if (NewGamePlusCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NewGamePlusCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MedicineAwardDesc other)
	{
		if (other != null)
		{
			if (other.DropId != 0)
			{
				DropId = other.DropId;
			}
			if (other.TaskStageId != 0)
			{
				TaskStageId = other.TaskStageId;
			}
			if (other.NewGamePlusCount != 0)
			{
				NewGamePlusCount = other.NewGamePlusCount;
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
				DropId = input.ReadInt32();
				break;
			case 16u:
				TaskStageId = input.ReadInt32();
				break;
			case 24u:
				NewGamePlusCount = input.ReadInt32();
				break;
			}
		}
	}
}
