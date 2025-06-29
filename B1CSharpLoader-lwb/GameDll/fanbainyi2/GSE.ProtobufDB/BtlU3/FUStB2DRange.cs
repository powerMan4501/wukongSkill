using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DRange : IMessage<FUStB2DRange>, IMessage, IEquatable<FUStB2DRange>, IDeepCloneable<FUStB2DRange>
{
	private static readonly MessageParser<FUStB2DRange> _parser = new MessageParser<FUStB2DRange>(() => new FUStB2DRange());

	private UnknownFieldSet _unknownFields;

	private EB2DRangeType rangeType_;

	private static readonly FieldCodec<int> _repeated_rangeParam_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> rangeParam_ = new RepeatedField<int>();

	public static MessageParser<FUStB2DRange> Parser => _parser;

	public EB2DRangeType RangeType
	{
		get
		{
			return rangeType_;
		}
		set
		{
			rangeType_ = value;
		}
	}

	public RepeatedField<int> RangeParam => rangeParam_;

	public FUStB2DRange()
	{
	}

	public FUStB2DRange(FUStB2DRange other)
		: this()
	{
		rangeType_ = other.rangeType_;
		rangeParam_ = other.rangeParam_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DRange Clone()
	{
		return new FUStB2DRange(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DRange);
	}

	public bool Equals(FUStB2DRange other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RangeType != other.RangeType)
		{
			return false;
		}
		if (!rangeParam_.Equals(other.rangeParam_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RangeType != EB2DRangeType.TargetBaseObj)
		{
			num ^= RangeType.GetHashCode();
		}
		num ^= rangeParam_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RangeType != EB2DRangeType.TargetBaseObj)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)RangeType);
		}
		rangeParam_.WriteTo(output, _repeated_rangeParam_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RangeType != EB2DRangeType.TargetBaseObj)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RangeType);
		}
		num += rangeParam_.CalculateSize(_repeated_rangeParam_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DRange other)
	{
		if (other != null)
		{
			if (other.RangeType != EB2DRangeType.TargetBaseObj)
			{
				RangeType = other.RangeType;
			}
			rangeParam_.Add(other.rangeParam_);
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
				RangeType = (EB2DRangeType)input.ReadEnum();
				break;
			case 16u:
			case 18u:
				rangeParam_.AddEntriesFrom(input, _repeated_rangeParam_codec);
				break;
			}
		}
	}
}
