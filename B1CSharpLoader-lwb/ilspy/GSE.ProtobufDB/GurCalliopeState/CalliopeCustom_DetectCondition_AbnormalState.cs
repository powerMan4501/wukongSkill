using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_AbnormalState : IMessage<CalliopeCustom_DetectCondition_AbnormalState>, IMessage, IEquatable<CalliopeCustom_DetectCondition_AbnormalState>, IDeepCloneable<CalliopeCustom_DetectCondition_AbnormalState>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_AbnormalState> _parser = new MessageParser<CalliopeCustom_DetectCondition_AbnormalState>(() => new CalliopeCustom_DetectCondition_AbnormalState());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int abnormalStateType_;

	public static MessageParser<CalliopeCustom_DetectCondition_AbnormalState> Parser => _parser;

	public int AbnormalStateType
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return abnormalStateType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			abnormalStateType_ = value;
		}
	}

	public bool HasAbnormalStateType => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_AbnormalState()
	{
	}

	public CalliopeCustom_DetectCondition_AbnormalState(CalliopeCustom_DetectCondition_AbnormalState other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		abnormalStateType_ = other.abnormalStateType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_AbnormalState Clone()
	{
		return new CalliopeCustom_DetectCondition_AbnormalState(this);
	}

	public void ClearAbnormalStateType()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_AbnormalState);
	}

	public bool Equals(CalliopeCustom_DetectCondition_AbnormalState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AbnormalStateType != other.AbnormalStateType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasAbnormalStateType)
		{
			num ^= AbnormalStateType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasAbnormalStateType)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AbnormalStateType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasAbnormalStateType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AbnormalStateType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_AbnormalState other)
	{
		if (other != null)
		{
			if (other.HasAbnormalStateType)
			{
				AbnormalStateType = other.AbnormalStateType;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				AbnormalStateType = input.ReadInt32();
			}
		}
	}
}
