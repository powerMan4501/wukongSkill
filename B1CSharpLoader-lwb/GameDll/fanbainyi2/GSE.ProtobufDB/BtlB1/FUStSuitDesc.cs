using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSuitDesc : IMessage<FUStSuitDesc>, IMessage, IEquatable<FUStSuitDesc>, IDeepCloneable<FUStSuitDesc>
{
	private static readonly MessageParser<FUStSuitDesc> _parser = new MessageParser<FUStSuitDesc>(() => new FUStSuitDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string suitName_ = "";

	private static readonly FieldCodec<FUStSuitInfo> _repeated_suitInfo_codec = FieldCodec.ForMessage(26u, FUStSuitInfo.Parser);

	private readonly RepeatedField<FUStSuitInfo> suitInfo_ = new RepeatedField<FUStSuitInfo>();

	private FUStRedQualityInfo redQualityInfo_;

	private int localizationTag_;

	public static MessageParser<FUStSuitDesc> Parser => _parser;

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

	public string SuitName
	{
		get
		{
			return suitName_;
		}
		set
		{
			suitName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<FUStSuitInfo> SuitInfo => suitInfo_;

	public FUStRedQualityInfo RedQualityInfo
	{
		get
		{
			return redQualityInfo_;
		}
		set
		{
			redQualityInfo_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public FUStSuitDesc()
	{
	}

	public FUStSuitDesc(FUStSuitDesc other)
		: this()
	{
		iD_ = other.iD_;
		suitName_ = other.suitName_;
		suitInfo_ = other.suitInfo_.Clone();
		redQualityInfo_ = ((other.redQualityInfo_ != null) ? other.redQualityInfo_.Clone() : null);
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSuitDesc Clone()
	{
		return new FUStSuitDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSuitDesc);
	}

	public bool Equals(FUStSuitDesc other)
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
		if (SuitName != other.SuitName)
		{
			return false;
		}
		if (!suitInfo_.Equals(other.suitInfo_))
		{
			return false;
		}
		if (!object.Equals(RedQualityInfo, other.RedQualityInfo))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (SuitName.Length != 0)
		{
			num ^= SuitName.GetHashCode();
		}
		num ^= suitInfo_.GetHashCode();
		if (redQualityInfo_ != null)
		{
			num ^= RedQualityInfo.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
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
		if (SuitName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SuitName);
		}
		suitInfo_.WriteTo(output, _repeated_suitInfo_codec);
		if (redQualityInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RedQualityInfo);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(LocalizationTag);
		}
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
		if (SuitName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SuitName);
		}
		num += suitInfo_.CalculateSize(_repeated_suitInfo_codec);
		if (redQualityInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RedQualityInfo);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSuitDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.SuitName.Length != 0)
		{
			SuitName = other.SuitName;
		}
		suitInfo_.Add(other.suitInfo_);
		if (other.redQualityInfo_ != null)
		{
			if (redQualityInfo_ == null)
			{
				RedQualityInfo = new FUStRedQualityInfo();
			}
			RedQualityInfo.MergeFrom(other.RedQualityInfo);
		}
		if (other.LocalizationTag != 0)
		{
			LocalizationTag = other.LocalizationTag;
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
				ID = input.ReadInt32();
				break;
			case 18u:
				SuitName = input.ReadString();
				break;
			case 26u:
				suitInfo_.AddEntriesFrom(input, _repeated_suitInfo_codec);
				break;
			case 34u:
				if (redQualityInfo_ == null)
				{
					RedQualityInfo = new FUStRedQualityInfo();
				}
				input.ReadMessage(RedQualityInfo);
				break;
			case 40u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
