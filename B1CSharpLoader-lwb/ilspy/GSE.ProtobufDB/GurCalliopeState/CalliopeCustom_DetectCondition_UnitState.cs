using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_UnitState : IMessage<CalliopeCustom_DetectCondition_UnitState>, IMessage, IEquatable<CalliopeCustom_DetectCondition_UnitState>, IDeepCloneable<CalliopeCustom_DetectCondition_UnitState>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_UnitState> _parser = new MessageParser<CalliopeCustom_DetectCondition_UnitState>(() => new CalliopeCustom_DetectCondition_UnitState());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int unitState_;

	public static MessageParser<CalliopeCustom_DetectCondition_UnitState> Parser => _parser;

	public int UnitState
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return unitState_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			unitState_ = value;
		}
	}

	public bool HasUnitState => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_UnitState()
	{
	}

	public CalliopeCustom_DetectCondition_UnitState(CalliopeCustom_DetectCondition_UnitState other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		unitState_ = other.unitState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_UnitState Clone()
	{
		return new CalliopeCustom_DetectCondition_UnitState(this);
	}

	public void ClearUnitState()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_UnitState);
	}

	public bool Equals(CalliopeCustom_DetectCondition_UnitState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitState != other.UnitState)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasUnitState)
		{
			num ^= UnitState.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasUnitState)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UnitState);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasUnitState)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_UnitState other)
	{
		if (other != null)
		{
			if (other.HasUnitState)
			{
				UnitState = other.UnitState;
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
				UnitState = input.ReadInt32();
			}
		}
	}
}
