using System;
using Google.Protobuf;

namespace OssB1;

public sealed class TaskStageStateTupleWrapper : IMessage<TaskStageStateTupleWrapper>, IMessage, IEquatable<TaskStageStateTupleWrapper>, IDeepCloneable<TaskStageStateTupleWrapper>
{
	private static readonly MessageParser<TaskStageStateTupleWrapper> _parser = new MessageParser<TaskStageStateTupleWrapper>(() => new TaskStageStateTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private TaskStageState item1_;

	private TaskStageState item2_;

	public static MessageParser<TaskStageStateTupleWrapper> Parser => _parser;

	public TaskStageState Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public TaskStageState Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public TaskStageStateTupleWrapper()
	{
	}

	public TaskStageStateTupleWrapper(TaskStageStateTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskStageStateTupleWrapper Clone()
	{
		return new TaskStageStateTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskStageStateTupleWrapper);
	}

	public bool Equals(TaskStageStateTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != TaskStageState.Begin)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != TaskStageState.Begin)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != TaskStageState.Begin)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != TaskStageState.Begin)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != TaskStageState.Begin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != TaskStageState.Begin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TaskStageStateTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != TaskStageState.Begin)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != TaskStageState.Begin)
			{
				Item2 = other.Item2;
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
				Item1 = (TaskStageState)input.ReadEnum();
				break;
			case 16u:
				Item2 = (TaskStageState)input.ReadEnum();
				break;
			}
		}
	}
}
