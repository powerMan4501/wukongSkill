using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStTalentDisplayDesc : IMessage<FUStTalentDisplayDesc>, IMessage, IEquatable<FUStTalentDisplayDesc>, IDeepCloneable<FUStTalentDisplayDesc>
{
	private static readonly MessageParser<FUStTalentDisplayDesc> _parser = new MessageParser<FUStTalentDisplayDesc>(() => new FUStTalentDisplayDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string inputDesc_ = "";

	private static readonly FieldCodec<TalentDisplayCfg> _repeated_displayCfg_codec = FieldCodec.ForMessage(26u, TalentDisplayCfg.Parser);

	private readonly RepeatedField<TalentDisplayCfg> displayCfg_ = new RepeatedField<TalentDisplayCfg>();

	private int talentType_;

	private int localizationTag_;

	public static MessageParser<FUStTalentDisplayDesc> Parser => _parser;

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

	public string InputDesc
	{
		get
		{
			return inputDesc_;
		}
		set
		{
			inputDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<TalentDisplayCfg> DisplayCfg => displayCfg_;

	public int TalentType
	{
		get
		{
			return talentType_;
		}
		set
		{
			talentType_ = value;
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

	public FUStTalentDisplayDesc()
	{
	}

	public FUStTalentDisplayDesc(FUStTalentDisplayDesc other)
		: this()
	{
		iD_ = other.iD_;
		inputDesc_ = other.inputDesc_;
		displayCfg_ = other.displayCfg_.Clone();
		talentType_ = other.talentType_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTalentDisplayDesc Clone()
	{
		return new FUStTalentDisplayDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTalentDisplayDesc);
	}

	public bool Equals(FUStTalentDisplayDesc other)
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
		if (InputDesc != other.InputDesc)
		{
			return false;
		}
		if (!displayCfg_.Equals(other.displayCfg_))
		{
			return false;
		}
		if (TalentType != other.TalentType)
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
		if (InputDesc.Length != 0)
		{
			num ^= InputDesc.GetHashCode();
		}
		num ^= displayCfg_.GetHashCode();
		if (TalentType != 0)
		{
			num ^= TalentType.GetHashCode();
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
		if (InputDesc.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(InputDesc);
		}
		displayCfg_.WriteTo(output, _repeated_displayCfg_codec);
		if (TalentType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TalentType);
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
		if (InputDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InputDesc);
		}
		num += displayCfg_.CalculateSize(_repeated_displayCfg_codec);
		if (TalentType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentType);
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

	public void MergeFrom(FUStTalentDisplayDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.InputDesc.Length != 0)
			{
				InputDesc = other.InputDesc;
			}
			displayCfg_.Add(other.displayCfg_);
			if (other.TalentType != 0)
			{
				TalentType = other.TalentType;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				ID = input.ReadInt32();
				break;
			case 18u:
				InputDesc = input.ReadString();
				break;
			case 26u:
				displayCfg_.AddEntriesFrom(input, _repeated_displayCfg_codec);
				break;
			case 32u:
				TalentType = input.ReadInt32();
				break;
			case 40u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
