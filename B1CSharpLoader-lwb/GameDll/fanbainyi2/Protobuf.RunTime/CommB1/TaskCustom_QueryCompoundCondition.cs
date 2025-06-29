using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class TaskCustom_QueryCompoundCondition : IMessage<TaskCustom_QueryCompoundCondition>, IMessage, IEquatable<TaskCustom_QueryCompoundCondition>, IDeepCloneable<TaskCustom_QueryCompoundCondition>
{
	private static readonly MessageParser<TaskCustom_QueryCompoundCondition> _parser = new MessageParser<TaskCustom_QueryCompoundCondition>(() => new TaskCustom_QueryCompoundCondition());

	private UnknownFieldSet _unknownFields;

	private bool isReverseCondition_;

	private LogicRelationType conditionRelationType_;

	private static readonly FieldCodec<OneQueryCompoundConditionInfo> _repeated_conditionInfoList_codec = FieldCodec.ForMessage(26u, OneQueryCompoundConditionInfo.Parser);

	private readonly RepeatedField<OneQueryCompoundConditionInfo> conditionInfoList_ = new RepeatedField<OneQueryCompoundConditionInfo>();

	public static MessageParser<TaskCustom_QueryCompoundCondition> Parser => _parser;

	public bool IsReverseCondition
	{
		get
		{
			return isReverseCondition_;
		}
		set
		{
			isReverseCondition_ = value;
		}
	}

	public LogicRelationType ConditionRelationType
	{
		get
		{
			return conditionRelationType_;
		}
		set
		{
			conditionRelationType_ = value;
		}
	}

	public RepeatedField<OneQueryCompoundConditionInfo> ConditionInfoList => conditionInfoList_;

	public TaskCustom_QueryCompoundCondition()
	{
	}

	public TaskCustom_QueryCompoundCondition(TaskCustom_QueryCompoundCondition other)
		: this()
	{
		isReverseCondition_ = other.isReverseCondition_;
		conditionRelationType_ = other.conditionRelationType_;
		conditionInfoList_ = other.conditionInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskCustom_QueryCompoundCondition Clone()
	{
		return new TaskCustom_QueryCompoundCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskCustom_QueryCompoundCondition);
	}

	public bool Equals(TaskCustom_QueryCompoundCondition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (ConditionRelationType != other.ConditionRelationType)
		{
			return false;
		}
		if (!conditionInfoList_.Equals(other.conditionInfoList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		if (ConditionRelationType != LogicRelationType.LogicRelationAnd)
		{
			num ^= ConditionRelationType.GetHashCode();
		}
		num ^= conditionInfoList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsReverseCondition)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsReverseCondition);
		}
		if (ConditionRelationType != LogicRelationType.LogicRelationAnd)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ConditionRelationType);
		}
		conditionInfoList_.WriteTo(output, _repeated_conditionInfoList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (ConditionRelationType != LogicRelationType.LogicRelationAnd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConditionRelationType);
		}
		num += conditionInfoList_.CalculateSize(_repeated_conditionInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TaskCustom_QueryCompoundCondition other)
	{
		if (other != null)
		{
			if (other.IsReverseCondition)
			{
				IsReverseCondition = other.IsReverseCondition;
			}
			if (other.ConditionRelationType != LogicRelationType.LogicRelationAnd)
			{
				ConditionRelationType = other.ConditionRelationType;
			}
			conditionInfoList_.Add(other.conditionInfoList_);
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
				IsReverseCondition = input.ReadBool();
				break;
			case 16u:
				ConditionRelationType = (LogicRelationType)input.ReadEnum();
				break;
			case 26u:
				conditionInfoList_.AddEntriesFrom(input, _repeated_conditionInfoList_codec);
				break;
			}
		}
	}
}
