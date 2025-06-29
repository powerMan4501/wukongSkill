using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class PlayerTransactionTaskBase : IMessage<PlayerTransactionTaskBase>, IMessage, IEquatable<PlayerTransactionTaskBase>, IDeepCloneable<PlayerTransactionTaskBase>
{
	private static readonly MessageParser<PlayerTransactionTaskBase> _parser = new MessageParser<PlayerTransactionTaskBase>(() => new PlayerTransactionTaskBase());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int taskType_;

	private int taskState_;

	private int gSRepSubClassIdx_;

	public static MessageParser<PlayerTransactionTaskBase> Parser => _parser;

	public int TaskType
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return taskType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			taskType_ = value;
		}
	}

	public bool HasTaskType => (_hasBits0 & 1) != 0;

	public int TaskState
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return taskState_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			taskState_ = value;
		}
	}

	public bool HasTaskState => (_hasBits0 & 2) != 0;

	public int GSRepSubClassIdx
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return gSRepSubClassIdx_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			gSRepSubClassIdx_ = value;
		}
	}

	public bool HasGSRepSubClassIdx => (_hasBits0 & 4) != 0;

	public PlayerTransactionTaskBase()
	{
	}

	public PlayerTransactionTaskBase(PlayerTransactionTaskBase other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		taskType_ = other.taskType_;
		taskState_ = other.taskState_;
		gSRepSubClassIdx_ = other.gSRepSubClassIdx_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerTransactionTaskBase Clone()
	{
		return new PlayerTransactionTaskBase(this);
	}

	public void ClearTaskType()
	{
		_hasBits0 &= -2;
	}

	public void ClearTaskState()
	{
		_hasBits0 &= -3;
	}

	public void ClearGSRepSubClassIdx()
	{
		_hasBits0 &= -5;
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerTransactionTaskBase);
	}

	public bool Equals(PlayerTransactionTaskBase other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TaskType != other.TaskType)
		{
			return false;
		}
		if (TaskState != other.TaskState)
		{
			return false;
		}
		if (GSRepSubClassIdx != other.GSRepSubClassIdx)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasTaskType)
		{
			num ^= TaskType.GetHashCode();
		}
		if (HasTaskState)
		{
			num ^= TaskState.GetHashCode();
		}
		if (HasGSRepSubClassIdx)
		{
			num ^= GSRepSubClassIdx.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasTaskType)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TaskType);
		}
		if (HasTaskState)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TaskState);
		}
		if (HasGSRepSubClassIdx)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GSRepSubClassIdx);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasTaskType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskType);
		}
		if (HasTaskState)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskState);
		}
		if (HasGSRepSubClassIdx)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GSRepSubClassIdx);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerTransactionTaskBase other)
	{
		if (other != null)
		{
			if (other.HasTaskType)
			{
				TaskType = other.TaskType;
			}
			if (other.HasTaskState)
			{
				TaskState = other.TaskState;
			}
			if (other.HasGSRepSubClassIdx)
			{
				GSRepSubClassIdx = other.GSRepSubClassIdx;
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
				TaskType = input.ReadInt32();
				break;
			case 16u:
				TaskState = input.ReadInt32();
				break;
			case 24u:
				GSRepSubClassIdx = input.ReadInt32();
				break;
			}
		}
	}
}
