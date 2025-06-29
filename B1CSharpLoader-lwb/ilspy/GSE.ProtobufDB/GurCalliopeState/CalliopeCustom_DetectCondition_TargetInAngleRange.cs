using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_TargetInAngleRange : IMessage<CalliopeCustom_DetectCondition_TargetInAngleRange>, IMessage, IEquatable<CalliopeCustom_DetectCondition_TargetInAngleRange>, IDeepCloneable<CalliopeCustom_DetectCondition_TargetInAngleRange>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_TargetInAngleRange> _parser = new MessageParser<CalliopeCustom_DetectCondition_TargetInAngleRange>(() => new CalliopeCustom_DetectCondition_TargetInAngleRange());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float minYawAngle_;

	private float maxYawAngle_;

	public static MessageParser<CalliopeCustom_DetectCondition_TargetInAngleRange> Parser => _parser;

	public float MinYawAngle
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return minYawAngle_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			minYawAngle_ = value;
		}
	}

	public bool HasMinYawAngle => (_hasBits0 & 1) != 0;

	public float MaxYawAngle
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return maxYawAngle_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			maxYawAngle_ = value;
		}
	}

	public bool HasMaxYawAngle => (_hasBits0 & 2) != 0;

	public CalliopeCustom_DetectCondition_TargetInAngleRange()
	{
	}

	public CalliopeCustom_DetectCondition_TargetInAngleRange(CalliopeCustom_DetectCondition_TargetInAngleRange other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		minYawAngle_ = other.minYawAngle_;
		maxYawAngle_ = other.maxYawAngle_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_TargetInAngleRange Clone()
	{
		return new CalliopeCustom_DetectCondition_TargetInAngleRange(this);
	}

	public void ClearMinYawAngle()
	{
		_hasBits0 &= -2;
	}

	public void ClearMaxYawAngle()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_TargetInAngleRange);
	}

	public bool Equals(CalliopeCustom_DetectCondition_TargetInAngleRange other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinYawAngle, other.MinYawAngle))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxYawAngle, other.MaxYawAngle))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasMinYawAngle)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinYawAngle);
		}
		if (HasMaxYawAngle)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxYawAngle);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasMinYawAngle)
		{
			output.WriteRawTag(13);
			output.WriteFloat(MinYawAngle);
		}
		if (HasMaxYawAngle)
		{
			output.WriteRawTag(21);
			output.WriteFloat(MaxYawAngle);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasMinYawAngle)
		{
			num += 5;
		}
		if (HasMaxYawAngle)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_TargetInAngleRange other)
	{
		if (other != null)
		{
			if (other.HasMinYawAngle)
			{
				MinYawAngle = other.MinYawAngle;
			}
			if (other.HasMaxYawAngle)
			{
				MaxYawAngle = other.MaxYawAngle;
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
			case 13u:
				MinYawAngle = input.ReadFloat();
				break;
			case 21u:
				MaxYawAngle = input.ReadFloat();
				break;
			}
		}
	}
}
