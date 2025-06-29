using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_DistanceFromTarget : IMessage<CalliopeCustom_DetectCondition_DistanceFromTarget>, IMessage, IEquatable<CalliopeCustom_DetectCondition_DistanceFromTarget>, IDeepCloneable<CalliopeCustom_DetectCondition_DistanceFromTarget>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_DistanceFromTarget> _parser = new MessageParser<CalliopeCustom_DetectCondition_DistanceFromTarget>(() => new CalliopeCustom_DetectCondition_DistanceFromTarget());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int distanceCompareOperations_;

	private float distanceCompareValue_;

	public static MessageParser<CalliopeCustom_DetectCondition_DistanceFromTarget> Parser => _parser;

	public int DistanceCompareOperations
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return distanceCompareOperations_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			distanceCompareOperations_ = value;
		}
	}

	public bool HasDistanceCompareOperations => (_hasBits0 & 1) != 0;

	public float DistanceCompareValue
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return distanceCompareValue_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			distanceCompareValue_ = value;
		}
	}

	public bool HasDistanceCompareValue => (_hasBits0 & 2) != 0;

	public CalliopeCustom_DetectCondition_DistanceFromTarget()
	{
	}

	public CalliopeCustom_DetectCondition_DistanceFromTarget(CalliopeCustom_DetectCondition_DistanceFromTarget other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		distanceCompareOperations_ = other.distanceCompareOperations_;
		distanceCompareValue_ = other.distanceCompareValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_DistanceFromTarget Clone()
	{
		return new CalliopeCustom_DetectCondition_DistanceFromTarget(this);
	}

	public void ClearDistanceCompareOperations()
	{
		_hasBits0 &= -2;
	}

	public void ClearDistanceCompareValue()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_DistanceFromTarget);
	}

	public bool Equals(CalliopeCustom_DetectCondition_DistanceFromTarget other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DistanceCompareOperations != other.DistanceCompareOperations)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DistanceCompareValue, other.DistanceCompareValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasDistanceCompareOperations)
		{
			num ^= DistanceCompareOperations.GetHashCode();
		}
		if (HasDistanceCompareValue)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DistanceCompareValue);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasDistanceCompareOperations)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DistanceCompareOperations);
		}
		if (HasDistanceCompareValue)
		{
			output.WriteRawTag(21);
			output.WriteFloat(DistanceCompareValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasDistanceCompareOperations)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DistanceCompareOperations);
		}
		if (HasDistanceCompareValue)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_DistanceFromTarget other)
	{
		if (other != null)
		{
			if (other.HasDistanceCompareOperations)
			{
				DistanceCompareOperations = other.DistanceCompareOperations;
			}
			if (other.HasDistanceCompareValue)
			{
				DistanceCompareValue = other.DistanceCompareValue;
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
				DistanceCompareOperations = input.ReadInt32();
				break;
			case 21u:
				DistanceCompareValue = input.ReadFloat();
				break;
			}
		}
	}
}
