using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStProjectileMulTargetRule : IMessage<FUStProjectileMulTargetRule>, IMessage, IEquatable<FUStProjectileMulTargetRule>, IDeepCloneable<FUStProjectileMulTargetRule>
{
	private static readonly MessageParser<FUStProjectileMulTargetRule> _parser = new MessageParser<FUStProjectileMulTargetRule>(() => new FUStProjectileMulTargetRule());

	private UnknownFieldSet _unknownFields;

	private float halfAngle_;

	private float maxDistance_;

	private int maxTargetNum_;

	public static MessageParser<FUStProjectileMulTargetRule> Parser => _parser;

	public float HalfAngle
	{
		get
		{
			return halfAngle_;
		}
		set
		{
			halfAngle_ = value;
		}
	}

	public float MaxDistance
	{
		get
		{
			return maxDistance_;
		}
		set
		{
			maxDistance_ = value;
		}
	}

	public int MaxTargetNum
	{
		get
		{
			return maxTargetNum_;
		}
		set
		{
			maxTargetNum_ = value;
		}
	}

	public FUStProjectileMulTargetRule()
	{
	}

	public FUStProjectileMulTargetRule(FUStProjectileMulTargetRule other)
		: this()
	{
		halfAngle_ = other.halfAngle_;
		maxDistance_ = other.maxDistance_;
		maxTargetNum_ = other.maxTargetNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStProjectileMulTargetRule Clone()
	{
		return new FUStProjectileMulTargetRule(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStProjectileMulTargetRule);
	}

	public bool Equals(FUStProjectileMulTargetRule other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HalfAngle, other.HalfAngle))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxDistance, other.MaxDistance))
		{
			return false;
		}
		if (MaxTargetNum != other.MaxTargetNum)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HalfAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HalfAngle);
		}
		if (MaxDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxDistance);
		}
		if (MaxTargetNum != 0)
		{
			num ^= MaxTargetNum.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HalfAngle != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(HalfAngle);
		}
		if (MaxDistance != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(MaxDistance);
		}
		if (MaxTargetNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MaxTargetNum);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HalfAngle != 0f)
		{
			num += 5;
		}
		if (MaxDistance != 0f)
		{
			num += 5;
		}
		if (MaxTargetNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxTargetNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStProjectileMulTargetRule other)
	{
		if (other != null)
		{
			if (other.HalfAngle != 0f)
			{
				HalfAngle = other.HalfAngle;
			}
			if (other.MaxDistance != 0f)
			{
				MaxDistance = other.MaxDistance;
			}
			if (other.MaxTargetNum != 0)
			{
				MaxTargetNum = other.MaxTargetNum;
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
				HalfAngle = input.ReadFloat();
				break;
			case 21u:
				MaxDistance = input.ReadFloat();
				break;
			case 24u:
				MaxTargetNum = input.ReadInt32();
				break;
			}
		}
	}
}
