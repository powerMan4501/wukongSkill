using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStAIFeatureDesc : IMessage<FUStAIFeatureDesc>, IMessage, IEquatable<FUStAIFeatureDesc>, IDeepCloneable<FUStAIFeatureDesc>
{
	private static readonly MessageParser<FUStAIFeatureDesc> _parser = new MessageParser<FUStAIFeatureDesc>(() => new FUStAIFeatureDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int mainInputID_;

	private static readonly FieldCodec<FUStAIFeatureFilter> _repeated_featureFilters_codec = FieldCodec.ForMessage(26u, FUStAIFeatureFilter.Parser);

	private readonly RepeatedField<FUStAIFeatureFilter> featureFilters_ = new RepeatedField<FUStAIFeatureFilter>();

	public static MessageParser<FUStAIFeatureDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public int MainInputID
	{
		get
		{
			return mainInputID_;
		}
		set
		{
			mainInputID_ = value;
		}
	}

	public RepeatedField<FUStAIFeatureFilter> FeatureFilters => featureFilters_;

	public FUStAIFeatureDesc()
	{
	}

	public FUStAIFeatureDesc(FUStAIFeatureDesc other)
		: this()
	{
		iD_ = other.iD_;
		mainInputID_ = other.mainInputID_;
		featureFilters_ = other.featureFilters_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAIFeatureDesc Clone()
	{
		return new FUStAIFeatureDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAIFeatureDesc);
	}

	public bool Equals(FUStAIFeatureDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (MainInputID != other.MainInputID)
		{
			return false;
		}
		if (!featureFilters_.Equals(other.featureFilters_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (MainInputID != 0)
		{
			num ^= MainInputID.GetHashCode();
		}
		num ^= featureFilters_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (MainInputID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MainInputID);
		}
		featureFilters_.WriteTo(output, _repeated_featureFilters_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (MainInputID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MainInputID);
		}
		num += featureFilters_.CalculateSize(_repeated_featureFilters_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAIFeatureDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.MainInputID != 0)
			{
				MainInputID = other.MainInputID;
			}
			featureFilters_.Add(other.featureFilters_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
				MainInputID = input.ReadInt32();
				break;
			case 26u:
				featureFilters_.AddEntriesFrom(input, _repeated_featureFilters_codec);
				break;
			}
		}
	}
}
