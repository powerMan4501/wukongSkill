using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_ActorYawRotation : IMessage<CalliopeCustom_DetectCondition_ActorYawRotation>, IMessage, IEquatable<CalliopeCustom_DetectCondition_ActorYawRotation>, IDeepCloneable<CalliopeCustom_DetectCondition_ActorYawRotation>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_ActorYawRotation> _parser = new MessageParser<CalliopeCustom_DetectCondition_ActorYawRotation>(() => new CalliopeCustom_DetectCondition_ActorYawRotation());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int baseDirection_;

	private float minYawAngle_;

	private float maxYawAngle_;

	public static MessageParser<CalliopeCustom_DetectCondition_ActorYawRotation> Parser => _parser;

	public int BaseDirection
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return baseDirection_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			baseDirection_ = value;
		}
	}

	public bool HasBaseDirection => (_hasBits0 & 1) != 0;

	public float MinYawAngle
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return minYawAngle_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			minYawAngle_ = value;
		}
	}

	public bool HasMinYawAngle => (_hasBits0 & 2) != 0;

	public float MaxYawAngle
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return maxYawAngle_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 4;
			maxYawAngle_ = value;
		}
	}

	public bool HasMaxYawAngle => (_hasBits0 & 4) != 0;

	public CalliopeCustom_DetectCondition_ActorYawRotation()
	{
	}

	public CalliopeCustom_DetectCondition_ActorYawRotation(CalliopeCustom_DetectCondition_ActorYawRotation other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		baseDirection_ = other.baseDirection_;
		minYawAngle_ = other.minYawAngle_;
		maxYawAngle_ = other.maxYawAngle_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_ActorYawRotation Clone()
	{
		return new CalliopeCustom_DetectCondition_ActorYawRotation(this);
	}

	public void ClearBaseDirection()
	{
		_hasBits0 &= -2;
	}

	public void ClearMinYawAngle()
	{
		_hasBits0 &= -3;
	}

	public void ClearMaxYawAngle()
	{
		_hasBits0 &= -5;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_ActorYawRotation);
	}

	public bool Equals(CalliopeCustom_DetectCondition_ActorYawRotation other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BaseDirection != other.BaseDirection)
		{
			return false;
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
		if (HasBaseDirection)
		{
			num ^= BaseDirection.GetHashCode();
		}
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
		if (HasBaseDirection)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BaseDirection);
		}
		if (HasMinYawAngle)
		{
			output.WriteRawTag(21);
			output.WriteFloat(MinYawAngle);
		}
		if (HasMaxYawAngle)
		{
			output.WriteRawTag(29);
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
		if (HasBaseDirection)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BaseDirection);
		}
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

	public void MergeFrom(CalliopeCustom_DetectCondition_ActorYawRotation other)
	{
		if (other != null)
		{
			if (other.HasBaseDirection)
			{
				BaseDirection = other.BaseDirection;
			}
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
			case 8u:
				BaseDirection = input.ReadInt32();
				break;
			case 21u:
				MinYawAngle = input.ReadFloat();
				break;
			case 29u:
				MaxYawAngle = input.ReadFloat();
				break;
			}
		}
	}
}
