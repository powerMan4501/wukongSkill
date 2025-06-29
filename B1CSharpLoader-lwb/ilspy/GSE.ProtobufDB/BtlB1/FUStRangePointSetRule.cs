using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStRangePointSetRule : IMessage<FUStRangePointSetRule>, IMessage, IEquatable<FUStRangePointSetRule>, IDeepCloneable<FUStRangePointSetRule>
{
	private static readonly MessageParser<FUStRangePointSetRule> _parser = new MessageParser<FUStRangePointSetRule>(() => new FUStRangePointSetRule());

	private UnknownFieldSet _unknownFields;

	private int rangePointSetType_;

	private int matrixDensity_;

	private float circleRadius_;

	private float innerCircleRadius_;

	public static MessageParser<FUStRangePointSetRule> Parser => _parser;

	public int RangePointSetType
	{
		get
		{
			return rangePointSetType_;
		}
		set
		{
			rangePointSetType_ = value;
		}
	}

	public int MatrixDensity
	{
		get
		{
			return matrixDensity_;
		}
		set
		{
			matrixDensity_ = value;
		}
	}

	public float CircleRadius
	{
		get
		{
			return circleRadius_;
		}
		set
		{
			circleRadius_ = value;
		}
	}

	public float InnerCircleRadius
	{
		get
		{
			return innerCircleRadius_;
		}
		set
		{
			innerCircleRadius_ = value;
		}
	}

	public FUStRangePointSetRule()
	{
	}

	public FUStRangePointSetRule(FUStRangePointSetRule other)
		: this()
	{
		rangePointSetType_ = other.rangePointSetType_;
		matrixDensity_ = other.matrixDensity_;
		circleRadius_ = other.circleRadius_;
		innerCircleRadius_ = other.innerCircleRadius_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStRangePointSetRule Clone()
	{
		return new FUStRangePointSetRule(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStRangePointSetRule);
	}

	public bool Equals(FUStRangePointSetRule other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RangePointSetType != other.RangePointSetType)
		{
			return false;
		}
		if (MatrixDensity != other.MatrixDensity)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CircleRadius, other.CircleRadius))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InnerCircleRadius, other.InnerCircleRadius))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RangePointSetType != 0)
		{
			num ^= RangePointSetType.GetHashCode();
		}
		if (MatrixDensity != 0)
		{
			num ^= MatrixDensity.GetHashCode();
		}
		if (CircleRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CircleRadius);
		}
		if (InnerCircleRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InnerCircleRadius);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RangePointSetType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(RangePointSetType);
		}
		if (MatrixDensity != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MatrixDensity);
		}
		if (CircleRadius != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(CircleRadius);
		}
		if (InnerCircleRadius != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(InnerCircleRadius);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RangePointSetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RangePointSetType);
		}
		if (MatrixDensity != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MatrixDensity);
		}
		if (CircleRadius != 0f)
		{
			num += 5;
		}
		if (InnerCircleRadius != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStRangePointSetRule other)
	{
		if (other != null)
		{
			if (other.RangePointSetType != 0)
			{
				RangePointSetType = other.RangePointSetType;
			}
			if (other.MatrixDensity != 0)
			{
				MatrixDensity = other.MatrixDensity;
			}
			if (other.CircleRadius != 0f)
			{
				CircleRadius = other.CircleRadius;
			}
			if (other.InnerCircleRadius != 0f)
			{
				InnerCircleRadius = other.InnerCircleRadius;
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
				RangePointSetType = input.ReadInt32();
				break;
			case 16u:
				MatrixDensity = input.ReadInt32();
				break;
			case 29u:
				CircleRadius = input.ReadFloat();
				break;
			case 37u:
				InnerCircleRadius = input.ReadFloat();
				break;
			}
		}
	}
}
