using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStEQSSettingDesc : IMessage<FUStEQSSettingDesc>, IMessage, IEquatable<FUStEQSSettingDesc>, IDeepCloneable<FUStEQSSettingDesc>
{
	private static readonly MessageParser<FUStEQSSettingDesc> _parser = new MessageParser<FUStEQSSettingDesc>(() => new FUStEQSSettingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EEQSGenerator eQSGenerator_;

	private int pointNum_;

	private static readonly FieldCodec<float> _repeated_eQSPatternParams_codec = FieldCodec.ForFloat(34u);

	private readonly RepeatedField<float> eQSPatternParams_ = new RepeatedField<float>();

	private static readonly FieldCodec<float> _repeated_eQSFilerParams_codec = FieldCodec.ForFloat(42u);

	private readonly RepeatedField<float> eQSFilerParams_ = new RepeatedField<float>();

	public static MessageParser<FUStEQSSettingDesc> Parser => _parser;

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

	public EEQSGenerator EQSGenerator
	{
		get
		{
			return eQSGenerator_;
		}
		set
		{
			eQSGenerator_ = value;
		}
	}

	public int PointNum
	{
		get
		{
			return pointNum_;
		}
		set
		{
			pointNum_ = value;
		}
	}

	public RepeatedField<float> EQSPatternParams => eQSPatternParams_;

	public RepeatedField<float> EQSFilerParams => eQSFilerParams_;

	public FUStEQSSettingDesc()
	{
	}

	public FUStEQSSettingDesc(FUStEQSSettingDesc other)
		: this()
	{
		iD_ = other.iD_;
		eQSGenerator_ = other.eQSGenerator_;
		pointNum_ = other.pointNum_;
		eQSPatternParams_ = other.eQSPatternParams_.Clone();
		eQSFilerParams_ = other.eQSFilerParams_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStEQSSettingDesc Clone()
	{
		return new FUStEQSSettingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStEQSSettingDesc);
	}

	public bool Equals(FUStEQSSettingDesc other)
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
		if (EQSGenerator != other.EQSGenerator)
		{
			return false;
		}
		if (PointNum != other.PointNum)
		{
			return false;
		}
		if (!eQSPatternParams_.Equals(other.eQSPatternParams_))
		{
			return false;
		}
		if (!eQSFilerParams_.Equals(other.eQSFilerParams_))
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
		if (EQSGenerator != EEQSGenerator.None)
		{
			num ^= EQSGenerator.GetHashCode();
		}
		if (PointNum != 0)
		{
			num ^= PointNum.GetHashCode();
		}
		num ^= eQSPatternParams_.GetHashCode();
		num ^= eQSFilerParams_.GetHashCode();
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
		if (EQSGenerator != EEQSGenerator.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EQSGenerator);
		}
		if (PointNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PointNum);
		}
		eQSPatternParams_.WriteTo(output, _repeated_eQSPatternParams_codec);
		eQSFilerParams_.WriteTo(output, _repeated_eQSFilerParams_codec);
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
		if (EQSGenerator != EEQSGenerator.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EQSGenerator);
		}
		if (PointNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PointNum);
		}
		num += eQSPatternParams_.CalculateSize(_repeated_eQSPatternParams_codec);
		num += eQSFilerParams_.CalculateSize(_repeated_eQSFilerParams_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStEQSSettingDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.EQSGenerator != EEQSGenerator.None)
			{
				EQSGenerator = other.EQSGenerator;
			}
			if (other.PointNum != 0)
			{
				PointNum = other.PointNum;
			}
			eQSPatternParams_.Add(other.eQSPatternParams_);
			eQSFilerParams_.Add(other.eQSFilerParams_);
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
				EQSGenerator = (EEQSGenerator)input.ReadEnum();
				break;
			case 24u:
				PointNum = input.ReadInt32();
				break;
			case 34u:
			case 37u:
				eQSPatternParams_.AddEntriesFrom(input, _repeated_eQSPatternParams_codec);
				break;
			case 42u:
			case 45u:
				eQSFilerParams_.AddEntriesFrom(input, _repeated_eQSFilerParams_codec);
				break;
			}
		}
	}
}
