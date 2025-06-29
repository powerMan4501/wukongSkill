using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_SimpleState : IMessage<CalliopeCustom_DetectCondition_SimpleState>, IMessage, IEquatable<CalliopeCustom_DetectCondition_SimpleState>, IDeepCloneable<CalliopeCustom_DetectCondition_SimpleState>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_SimpleState> _parser = new MessageParser<CalliopeCustom_DetectCondition_SimpleState>(() => new CalliopeCustom_DetectCondition_SimpleState());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int simpleState_;

	public static MessageParser<CalliopeCustom_DetectCondition_SimpleState> Parser => _parser;

	public int SimpleState
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return simpleState_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			simpleState_ = value;
		}
	}

	public bool HasSimpleState => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_SimpleState()
	{
	}

	public CalliopeCustom_DetectCondition_SimpleState(CalliopeCustom_DetectCondition_SimpleState other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		simpleState_ = other.simpleState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_SimpleState Clone()
	{
		return new CalliopeCustom_DetectCondition_SimpleState(this);
	}

	public void ClearSimpleState()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_SimpleState);
	}

	public bool Equals(CalliopeCustom_DetectCondition_SimpleState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SimpleState != other.SimpleState)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasSimpleState)
		{
			num ^= SimpleState.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasSimpleState)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SimpleState);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasSimpleState)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SimpleState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_SimpleState other)
	{
		if (other != null)
		{
			if (other.HasSimpleState)
			{
				SimpleState = other.SimpleState;
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
				SimpleState = input.ReadInt32();
			}
		}
	}
}
