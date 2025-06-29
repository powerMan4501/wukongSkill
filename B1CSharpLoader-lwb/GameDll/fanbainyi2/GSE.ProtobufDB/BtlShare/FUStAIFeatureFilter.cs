using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStAIFeatureFilter : IMessage<FUStAIFeatureFilter>, IMessage, IEquatable<FUStAIFeatureFilter>, IDeepCloneable<FUStAIFeatureFilter>
{
	private static readonly MessageParser<FUStAIFeatureFilter> _parser = new MessageParser<FUStAIFeatureFilter>(() => new FUStAIFeatureFilter());

	private UnknownFieldSet _unknownFields;

	private EFilterType filterType_;

	private static readonly FieldCodec<int> _repeated_filterInputs_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> filterInputs_ = new RepeatedField<int>();

	private EGSYesNo inverse_;

	private static readonly FieldCodec<int> _repeated_filterParams_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> filterParams_ = new RepeatedField<int>();

	public static MessageParser<FUStAIFeatureFilter> Parser => _parser;

	public EFilterType FilterType
	{
		get
		{
			return filterType_;
		}
		set
		{
			filterType_ = value;
		}
	}

	public RepeatedField<int> FilterInputs => filterInputs_;

	public EGSYesNo Inverse
	{
		get
		{
			return inverse_;
		}
		set
		{
			inverse_ = value;
		}
	}

	public RepeatedField<int> FilterParams => filterParams_;

	public FUStAIFeatureFilter()
	{
	}

	public FUStAIFeatureFilter(FUStAIFeatureFilter other)
		: this()
	{
		filterType_ = other.filterType_;
		filterInputs_ = other.filterInputs_.Clone();
		inverse_ = other.inverse_;
		filterParams_ = other.filterParams_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAIFeatureFilter Clone()
	{
		return new FUStAIFeatureFilter(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAIFeatureFilter);
	}

	public bool Equals(FUStAIFeatureFilter other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FilterType != other.FilterType)
		{
			return false;
		}
		if (!filterInputs_.Equals(other.filterInputs_))
		{
			return false;
		}
		if (Inverse != other.Inverse)
		{
			return false;
		}
		if (!filterParams_.Equals(other.filterParams_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (FilterType != EFilterType.CheckAngle)
		{
			num ^= FilterType.GetHashCode();
		}
		num ^= filterInputs_.GetHashCode();
		if (Inverse != EGSYesNo.No)
		{
			num ^= Inverse.GetHashCode();
		}
		num ^= filterParams_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (FilterType != EFilterType.CheckAngle)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)FilterType);
		}
		filterInputs_.WriteTo(output, _repeated_filterInputs_codec);
		if (Inverse != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Inverse);
		}
		filterParams_.WriteTo(output, _repeated_filterParams_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (FilterType != EFilterType.CheckAngle)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FilterType);
		}
		num += filterInputs_.CalculateSize(_repeated_filterInputs_codec);
		if (Inverse != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Inverse);
		}
		num += filterParams_.CalculateSize(_repeated_filterParams_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAIFeatureFilter other)
	{
		if (other != null)
		{
			if (other.FilterType != EFilterType.CheckAngle)
			{
				FilterType = other.FilterType;
			}
			filterInputs_.Add(other.filterInputs_);
			if (other.Inverse != EGSYesNo.No)
			{
				Inverse = other.Inverse;
			}
			filterParams_.Add(other.filterParams_);
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
				FilterType = (EFilterType)input.ReadEnum();
				break;
			case 16u:
			case 18u:
				filterInputs_.AddEntriesFrom(input, _repeated_filterInputs_codec);
				break;
			case 24u:
				Inverse = (EGSYesNo)input.ReadEnum();
				break;
			case 32u:
			case 34u:
				filterParams_.AddEntriesFrom(input, _repeated_filterParams_codec);
				break;
			}
		}
	}
}
