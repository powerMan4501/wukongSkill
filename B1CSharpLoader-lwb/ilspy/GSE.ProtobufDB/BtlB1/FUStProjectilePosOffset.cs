using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStProjectilePosOffset : IMessage<FUStProjectilePosOffset>, IMessage, IEquatable<FUStProjectilePosOffset>, IDeepCloneable<FUStProjectilePosOffset>
{
	private static readonly MessageParser<FUStProjectilePosOffset> _parser = new MessageParser<FUStProjectilePosOffset>(() => new FUStProjectilePosOffset());

	private UnknownFieldSet _unknownFields;

	private int posOffsetType_;

	private int offsetSpace_;

	private static readonly FieldCodec<float> _repeated_posOffset_codec = FieldCodec.ForFloat(26u);

	private readonly RepeatedField<float> posOffset_ = new RepeatedField<float>();

	private FUStRangePointSetRule rangeOffsetInfo_;

	public static MessageParser<FUStProjectilePosOffset> Parser => _parser;

	public int PosOffsetType
	{
		get
		{
			return posOffsetType_;
		}
		set
		{
			posOffsetType_ = value;
		}
	}

	public int OffsetSpace
	{
		get
		{
			return offsetSpace_;
		}
		set
		{
			offsetSpace_ = value;
		}
	}

	public RepeatedField<float> PosOffset => posOffset_;

	public FUStRangePointSetRule RangeOffsetInfo
	{
		get
		{
			return rangeOffsetInfo_;
		}
		set
		{
			rangeOffsetInfo_ = value;
		}
	}

	public FUStProjectilePosOffset()
	{
	}

	public FUStProjectilePosOffset(FUStProjectilePosOffset other)
		: this()
	{
		posOffsetType_ = other.posOffsetType_;
		offsetSpace_ = other.offsetSpace_;
		posOffset_ = other.posOffset_.Clone();
		rangeOffsetInfo_ = ((other.rangeOffsetInfo_ != null) ? other.rangeOffsetInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStProjectilePosOffset Clone()
	{
		return new FUStProjectilePosOffset(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStProjectilePosOffset);
	}

	public bool Equals(FUStProjectilePosOffset other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PosOffsetType != other.PosOffsetType)
		{
			return false;
		}
		if (OffsetSpace != other.OffsetSpace)
		{
			return false;
		}
		if (!posOffset_.Equals(other.posOffset_))
		{
			return false;
		}
		if (!object.Equals(RangeOffsetInfo, other.RangeOffsetInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PosOffsetType != 0)
		{
			num ^= PosOffsetType.GetHashCode();
		}
		if (OffsetSpace != 0)
		{
			num ^= OffsetSpace.GetHashCode();
		}
		num ^= posOffset_.GetHashCode();
		if (rangeOffsetInfo_ != null)
		{
			num ^= RangeOffsetInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PosOffsetType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PosOffsetType);
		}
		if (OffsetSpace != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OffsetSpace);
		}
		posOffset_.WriteTo(output, _repeated_posOffset_codec);
		if (rangeOffsetInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RangeOffsetInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PosOffsetType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PosOffsetType);
		}
		if (OffsetSpace != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OffsetSpace);
		}
		num += posOffset_.CalculateSize(_repeated_posOffset_codec);
		if (rangeOffsetInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RangeOffsetInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStProjectilePosOffset other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PosOffsetType != 0)
		{
			PosOffsetType = other.PosOffsetType;
		}
		if (other.OffsetSpace != 0)
		{
			OffsetSpace = other.OffsetSpace;
		}
		posOffset_.Add(other.posOffset_);
		if (other.rangeOffsetInfo_ != null)
		{
			if (rangeOffsetInfo_ == null)
			{
				RangeOffsetInfo = new FUStRangePointSetRule();
			}
			RangeOffsetInfo.MergeFrom(other.RangeOffsetInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				PosOffsetType = input.ReadInt32();
				break;
			case 16u:
				OffsetSpace = input.ReadInt32();
				break;
			case 26u:
			case 29u:
				posOffset_.AddEntriesFrom(input, _repeated_posOffset_codec);
				break;
			case 34u:
				if (rangeOffsetInfo_ == null)
				{
					RangeOffsetInfo = new FUStRangePointSetRule();
				}
				input.ReadMessage(RangeOffsetInfo);
				break;
			}
		}
	}
}
