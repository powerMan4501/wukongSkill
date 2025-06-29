using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_Random : IMessage<CalliopeCustom_DetectCondition_Random>, IMessage, IEquatable<CalliopeCustom_DetectCondition_Random>, IDeepCloneable<CalliopeCustom_DetectCondition_Random>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_Random> _parser = new MessageParser<CalliopeCustom_DetectCondition_Random>(() => new CalliopeCustom_DetectCondition_Random());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float successRate_;

	public static MessageParser<CalliopeCustom_DetectCondition_Random> Parser => _parser;

	public float SuccessRate
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return successRate_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			successRate_ = value;
		}
	}

	public bool HasSuccessRate => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_Random()
	{
	}

	public CalliopeCustom_DetectCondition_Random(CalliopeCustom_DetectCondition_Random other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		successRate_ = other.successRate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_Random Clone()
	{
		return new CalliopeCustom_DetectCondition_Random(this);
	}

	public void ClearSuccessRate()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_Random);
	}

	public bool Equals(CalliopeCustom_DetectCondition_Random other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SuccessRate, other.SuccessRate))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasSuccessRate)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SuccessRate);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasSuccessRate)
		{
			output.WriteRawTag(13);
			output.WriteFloat(SuccessRate);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasSuccessRate)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_Random other)
	{
		if (other != null)
		{
			if (other.HasSuccessRate)
			{
				SuccessRate = other.SuccessRate;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 13)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				SuccessRate = input.ReadFloat();
			}
		}
	}
}
