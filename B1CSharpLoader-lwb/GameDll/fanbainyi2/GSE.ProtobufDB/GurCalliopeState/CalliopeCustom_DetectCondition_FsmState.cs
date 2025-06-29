using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_FsmState : IMessage<CalliopeCustom_DetectCondition_FsmState>, IMessage, IEquatable<CalliopeCustom_DetectCondition_FsmState>, IDeepCloneable<CalliopeCustom_DetectCondition_FsmState>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_FsmState> _parser = new MessageParser<CalliopeCustom_DetectCondition_FsmState>(() => new CalliopeCustom_DetectCondition_FsmState());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int fsmState_;

	public static MessageParser<CalliopeCustom_DetectCondition_FsmState> Parser => _parser;

	public int FsmState
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return fsmState_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			fsmState_ = value;
		}
	}

	public bool HasFsmState => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_FsmState()
	{
	}

	public CalliopeCustom_DetectCondition_FsmState(CalliopeCustom_DetectCondition_FsmState other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		fsmState_ = other.fsmState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_FsmState Clone()
	{
		return new CalliopeCustom_DetectCondition_FsmState(this);
	}

	public void ClearFsmState()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_FsmState);
	}

	public bool Equals(CalliopeCustom_DetectCondition_FsmState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FsmState != other.FsmState)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasFsmState)
		{
			num ^= FsmState.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasFsmState)
		{
			output.WriteRawTag(8);
			output.WriteInt32(FsmState);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasFsmState)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FsmState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_FsmState other)
	{
		if (other != null)
		{
			if (other.HasFsmState)
			{
				FsmState = other.FsmState;
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
				FsmState = input.ReadInt32();
			}
		}
	}
}
