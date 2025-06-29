using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BaseU3;

public sealed class FUStB2DRelicBuffDesc : IMessage<FUStB2DRelicBuffDesc>, IMessage, IEquatable<FUStB2DRelicBuffDesc>, IDeepCloneable<FUStB2DRelicBuffDesc>
{
	private static readonly MessageParser<FUStB2DRelicBuffDesc> _parser = new MessageParser<FUStB2DRelicBuffDesc>(() => new FUStB2DRelicBuffDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private string desc_ = "";

	private ColorType color_;

	private CardType limitCardType_;

	private CardRaceType limitCardRace_;

	private int bpAddPercent_;

	private RelicType relicType_;

	private static readonly FieldCodec<int> _repeated_effectParam_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> effectParam_ = new RepeatedField<int>();

	private string iconPath_ = "";

	public static MessageParser<FUStB2DRelicBuffDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Desc
	{
		get
		{
			return desc_;
		}
		set
		{
			desc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ColorType Color
	{
		get
		{
			return color_;
		}
		set
		{
			color_ = value;
		}
	}

	public CardType LimitCardType
	{
		get
		{
			return limitCardType_;
		}
		set
		{
			limitCardType_ = value;
		}
	}

	public CardRaceType LimitCardRace
	{
		get
		{
			return limitCardRace_;
		}
		set
		{
			limitCardRace_ = value;
		}
	}

	public int BpAddPercent
	{
		get
		{
			return bpAddPercent_;
		}
		set
		{
			bpAddPercent_ = value;
		}
	}

	public RelicType RelicType
	{
		get
		{
			return relicType_;
		}
		set
		{
			relicType_ = value;
		}
	}

	public RepeatedField<int> EffectParam => effectParam_;

	public string IconPath
	{
		get
		{
			return iconPath_;
		}
		set
		{
			iconPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStB2DRelicBuffDesc()
	{
	}

	public FUStB2DRelicBuffDesc(FUStB2DRelicBuffDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		desc_ = other.desc_;
		color_ = other.color_;
		limitCardType_ = other.limitCardType_;
		limitCardRace_ = other.limitCardRace_;
		bpAddPercent_ = other.bpAddPercent_;
		relicType_ = other.relicType_;
		effectParam_ = other.effectParam_.Clone();
		iconPath_ = other.iconPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DRelicBuffDesc Clone()
	{
		return new FUStB2DRelicBuffDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DRelicBuffDesc);
	}

	public bool Equals(FUStB2DRelicBuffDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Desc != other.Desc)
		{
			return false;
		}
		if (Color != other.Color)
		{
			return false;
		}
		if (LimitCardType != other.LimitCardType)
		{
			return false;
		}
		if (LimitCardRace != other.LimitCardRace)
		{
			return false;
		}
		if (BpAddPercent != other.BpAddPercent)
		{
			return false;
		}
		if (RelicType != other.RelicType)
		{
			return false;
		}
		if (!effectParam_.Equals(other.effectParam_))
		{
			return false;
		}
		if (IconPath != other.IconPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
		}
		if (Color != ColorType.Init)
		{
			num ^= Color.GetHashCode();
		}
		if (LimitCardType != CardType.Init)
		{
			num ^= LimitCardType.GetHashCode();
		}
		if (LimitCardRace != CardRaceType.None)
		{
			num ^= LimitCardRace.GetHashCode();
		}
		if (BpAddPercent != 0)
		{
			num ^= BpAddPercent.GetHashCode();
		}
		if (RelicType != RelicType.None)
		{
			num ^= RelicType.GetHashCode();
		}
		num ^= effectParam_.GetHashCode();
		if (IconPath.Length != 0)
		{
			num ^= IconPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Desc.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Desc);
		}
		if (Color != ColorType.Init)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Color);
		}
		if (LimitCardType != CardType.Init)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)LimitCardType);
		}
		if (LimitCardRace != CardRaceType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)LimitCardRace);
		}
		if (BpAddPercent != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(BpAddPercent);
		}
		if (RelicType != RelicType.None)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)RelicType);
		}
		effectParam_.WriteTo(output, _repeated_effectParam_codec);
		if (IconPath.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(IconPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (Color != ColorType.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Color);
		}
		if (LimitCardType != CardType.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LimitCardType);
		}
		if (LimitCardRace != CardRaceType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LimitCardRace);
		}
		if (BpAddPercent != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BpAddPercent);
		}
		if (RelicType != RelicType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RelicType);
		}
		num += effectParam_.CalculateSize(_repeated_effectParam_codec);
		if (IconPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IconPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DRelicBuffDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
			}
			if (other.Color != ColorType.Init)
			{
				Color = other.Color;
			}
			if (other.LimitCardType != CardType.Init)
			{
				LimitCardType = other.LimitCardType;
			}
			if (other.LimitCardRace != CardRaceType.None)
			{
				LimitCardRace = other.LimitCardRace;
			}
			if (other.BpAddPercent != 0)
			{
				BpAddPercent = other.BpAddPercent;
			}
			if (other.RelicType != RelicType.None)
			{
				RelicType = other.RelicType;
			}
			effectParam_.Add(other.effectParam_);
			if (other.IconPath.Length != 0)
			{
				IconPath = other.IconPath;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 26u:
				Desc = input.ReadString();
				break;
			case 32u:
				Color = (ColorType)input.ReadEnum();
				break;
			case 40u:
				LimitCardType = (CardType)input.ReadEnum();
				break;
			case 48u:
				LimitCardRace = (CardRaceType)input.ReadEnum();
				break;
			case 56u:
				BpAddPercent = input.ReadInt32();
				break;
			case 64u:
				RelicType = (RelicType)input.ReadEnum();
				break;
			case 72u:
			case 74u:
				effectParam_.AddEntriesFrom(input, _repeated_effectParam_codec);
				break;
			case 82u:
				IconPath = input.ReadString();
				break;
			}
		}
	}
}
