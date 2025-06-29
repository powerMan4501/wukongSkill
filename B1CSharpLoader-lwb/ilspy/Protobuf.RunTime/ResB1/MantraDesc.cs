using System;
using BtlB1;
using Google.Protobuf;

namespace ResB1;

public sealed class MantraDesc : IMessage<MantraDesc>, IMessage, IEquatable<MantraDesc>, IDeepCloneable<MantraDesc>
{
	private static readonly MessageParser<MantraDesc> _parser = new MessageParser<MantraDesc>(() => new MantraDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private ItemQuality quality_;

	private MantraType type_;

	private EquipPosition position_;

	private YesNoType onlyEffective_;

	private int talentId_;

	private int equipAttrId_;

	private string desc_ = "";

	public static MessageParser<MantraDesc> Parser => _parser;

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

	public ItemQuality Quality
	{
		get
		{
			return quality_;
		}
		set
		{
			quality_ = value;
		}
	}

	public MantraType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public EquipPosition Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	public YesNoType OnlyEffective
	{
		get
		{
			return onlyEffective_;
		}
		set
		{
			onlyEffective_ = value;
		}
	}

	public int TalentId
	{
		get
		{
			return talentId_;
		}
		set
		{
			talentId_ = value;
		}
	}

	public int EquipAttrId
	{
		get
		{
			return equipAttrId_;
		}
		set
		{
			equipAttrId_ = value;
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

	public MantraDesc()
	{
	}

	public MantraDesc(MantraDesc other)
		: this()
	{
		id_ = other.id_;
		quality_ = other.quality_;
		type_ = other.type_;
		position_ = other.position_;
		onlyEffective_ = other.onlyEffective_;
		talentId_ = other.talentId_;
		equipAttrId_ = other.equipAttrId_;
		desc_ = other.desc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MantraDesc Clone()
	{
		return new MantraDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MantraDesc);
	}

	public bool Equals(MantraDesc other)
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
		if (Quality != other.Quality)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Position != other.Position)
		{
			return false;
		}
		if (OnlyEffective != other.OnlyEffective)
		{
			return false;
		}
		if (TalentId != other.TalentId)
		{
			return false;
		}
		if (EquipAttrId != other.EquipAttrId)
		{
			return false;
		}
		if (Desc != other.Desc)
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
		if (Quality != ItemQuality.Init)
		{
			num ^= Quality.GetHashCode();
		}
		if (Type != MantraType.Min)
		{
			num ^= Type.GetHashCode();
		}
		if (Position != EquipPosition.Head)
		{
			num ^= Position.GetHashCode();
		}
		if (OnlyEffective != YesNoType.No)
		{
			num ^= OnlyEffective.GetHashCode();
		}
		if (TalentId != 0)
		{
			num ^= TalentId.GetHashCode();
		}
		if (EquipAttrId != 0)
		{
			num ^= EquipAttrId.GetHashCode();
		}
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
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
		if (Quality != ItemQuality.Init)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Quality);
		}
		if (Type != MantraType.Min)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Type);
		}
		if (Position != EquipPosition.Head)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Position);
		}
		if (OnlyEffective != YesNoType.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)OnlyEffective);
		}
		if (TalentId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TalentId);
		}
		if (EquipAttrId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(EquipAttrId);
		}
		if (Desc.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(Desc);
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
		if (Quality != ItemQuality.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Quality);
		}
		if (Type != MantraType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Position != EquipPosition.Head)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Position);
		}
		if (OnlyEffective != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OnlyEffective);
		}
		if (TalentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentId);
		}
		if (EquipAttrId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EquipAttrId);
		}
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MantraDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Quality != ItemQuality.Init)
			{
				Quality = other.Quality;
			}
			if (other.Type != MantraType.Min)
			{
				Type = other.Type;
			}
			if (other.Position != EquipPosition.Head)
			{
				Position = other.Position;
			}
			if (other.OnlyEffective != YesNoType.No)
			{
				OnlyEffective = other.OnlyEffective;
			}
			if (other.TalentId != 0)
			{
				TalentId = other.TalentId;
			}
			if (other.EquipAttrId != 0)
			{
				EquipAttrId = other.EquipAttrId;
			}
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
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
			case 16u:
				Quality = (ItemQuality)input.ReadEnum();
				break;
			case 24u:
				Type = (MantraType)input.ReadEnum();
				break;
			case 32u:
				Position = (EquipPosition)input.ReadEnum();
				break;
			case 40u:
				OnlyEffective = (YesNoType)input.ReadEnum();
				break;
			case 48u:
				TalentId = input.ReadInt32();
				break;
			case 56u:
				EquipAttrId = input.ReadInt32();
				break;
			case 66u:
				Desc = input.ReadString();
				break;
			}
		}
	}
}
