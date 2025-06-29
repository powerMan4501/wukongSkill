using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStRange : IMessage<FUStRange>, IMessage, IEquatable<FUStRange>, IDeepCloneable<FUStRange>
{
	private static readonly MessageParser<FUStRange> _parser = new MessageParser<FUStRange>(() => new FUStRange());

	private UnknownFieldSet _unknownFields;

	private ERangeType rangeType_;

	private EEffectRangeCenterType rangeCenterType_;

	private static readonly FieldCodec<int> _repeated_rangeParam_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> rangeParam_ = new RepeatedField<int>();

	public static MessageParser<FUStRange> Parser => _parser;

	public ERangeType RangeType
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

	public EEffectRangeCenterType RangeCenterType
	{
		get
		{
			return rangeCenterType_;
		}
		set
		{
			rangeCenterType_ = value;
		}
	}

	public RepeatedField<int> RangeParam => rangeParam_;

	public FUStRange()
	{
	}

	public FUStRange(FUStRange other)
		: this()
	{
		rangeType_ = other.rangeType_;
		rangeCenterType_ = other.rangeCenterType_;
		rangeParam_ = other.rangeParam_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStRange Clone()
	{
		return new FUStRange(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStRange);
	}

	public bool Equals(FUStRange other)
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
		if (RangeCenterType != other.RangeCenterType)
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
		if (RangeType != ERangeType.TargetBaseObj)
		{
			num ^= RangeType.GetHashCode();
		}
		if (RangeCenterType != EEffectRangeCenterType.ActorPosition)
		{
			num ^= RangeCenterType.GetHashCode();
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
		if (RangeType != ERangeType.TargetBaseObj)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)RangeType);
		}
		if (RangeCenterType != EEffectRangeCenterType.ActorPosition)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)RangeCenterType);
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
		if (RangeType != ERangeType.TargetBaseObj)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RangeType);
		}
		if (RangeCenterType != EEffectRangeCenterType.ActorPosition)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RangeCenterType);
		}
		num += rangeParam_.CalculateSize(_repeated_rangeParam_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStRange other)
	{
		if (other != null)
		{
			if (other.RangeType != ERangeType.TargetBaseObj)
			{
				RangeType = other.RangeType;
			}
			if (other.RangeCenterType != EEffectRangeCenterType.ActorPosition)
			{
				RangeCenterType = other.RangeCenterType;
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
				RangeType = (ERangeType)input.ReadEnum();
				break;
			case 16u:
				RangeCenterType = (EEffectRangeCenterType)input.ReadEnum();
				break;
			case 24u:
			case 26u:
				rangeParam_.AddEntriesFrom(input, _repeated_rangeParam_codec);
				break;
			}
		}
	}
}
