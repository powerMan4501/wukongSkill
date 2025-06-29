using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_CustomFsmState : IMessage<CalliopeCustom_DetectCondition_CustomFsmState>, IMessage, IEquatable<CalliopeCustom_DetectCondition_CustomFsmState>, IDeepCloneable<CalliopeCustom_DetectCondition_CustomFsmState>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_CustomFsmState> _parser = new MessageParser<CalliopeCustom_DetectCondition_CustomFsmState>(() => new CalliopeCustom_DetectCondition_CustomFsmState());

	private UnknownFieldSet _unknownFields;

	private string customFsmState_;

	public static MessageParser<CalliopeCustom_DetectCondition_CustomFsmState> Parser => _parser;

	public string CustomFsmState
	{
		get
		{
			return customFsmState_ ?? "";
		}
		set
		{
			customFsmState_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasCustomFsmState => customFsmState_ != null;

	public CalliopeCustom_DetectCondition_CustomFsmState()
	{
	}

	public CalliopeCustom_DetectCondition_CustomFsmState(CalliopeCustom_DetectCondition_CustomFsmState other)
		: this()
	{
		customFsmState_ = other.customFsmState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_CustomFsmState Clone()
	{
		return new CalliopeCustom_DetectCondition_CustomFsmState(this);
	}

	public void ClearCustomFsmState()
	{
		customFsmState_ = null;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_CustomFsmState);
	}

	public bool Equals(CalliopeCustom_DetectCondition_CustomFsmState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CustomFsmState != other.CustomFsmState)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasCustomFsmState)
		{
			num ^= CustomFsmState.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasCustomFsmState)
		{
			output.WriteRawTag(10);
			output.WriteString(CustomFsmState);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasCustomFsmState)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CustomFsmState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_CustomFsmState other)
	{
		if (other != null)
		{
			if (other.HasCustomFsmState)
			{
				CustomFsmState = other.CustomFsmState;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				CustomFsmState = input.ReadString();
			}
		}
	}
}
