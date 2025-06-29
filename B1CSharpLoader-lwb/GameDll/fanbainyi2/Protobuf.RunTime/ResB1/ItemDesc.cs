using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ItemDesc : IMessage<ItemDesc>, IMessage, IEquatable<ItemDesc>, IDeepCloneable<ItemDesc>
{
	private static readonly MessageParser<ItemDesc> _parser = new MessageParser<ItemDesc>(() => new ItemDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private int sortId_;

	private string typeName_ = "";

	private ItemType itemType_;

	private ItemQuality quality_;

	private int carryMax_;

	private string briefDesc_ = "";

	private string desc_ = "";

	private string dropTemplete_ = "";

	private int param1_;

	private GainPerformanceType gainPerformance_;

	private FillToHUDType fillType_;

	private YesNoType isLevelItem_;

	private string effectDesc_ = "";

	private uint sellPrice_;

	private string source_ = "";

	private ItemPackageType packageType_;

	private YesNoType isShieldGain_;

	private YesNoType isShowFull_;

	private YesNoType isLoseFalldying_;

	private int localizationTag_;

	private int imageId_;

	private string hudEffectDesc_ = "";

	private int param2_;

	public static MessageParser<ItemDesc> Parser => _parser;

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

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public string TypeName
	{
		get
		{
			return typeName_;
		}
		set
		{
			typeName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ItemType ItemType
	{
		get
		{
			return itemType_;
		}
		set
		{
			itemType_ = value;
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

	public int CarryMax
	{
		get
		{
			return carryMax_;
		}
		set
		{
			carryMax_ = value;
		}
	}

	public string BriefDesc
	{
		get
		{
			return briefDesc_;
		}
		set
		{
			briefDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public string DropTemplete
	{
		get
		{
			return dropTemplete_;
		}
		set
		{
			dropTemplete_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Param1
	{
		get
		{
			return param1_;
		}
		set
		{
			param1_ = value;
		}
	}

	public GainPerformanceType GainPerformance
	{
		get
		{
			return gainPerformance_;
		}
		set
		{
			gainPerformance_ = value;
		}
	}

	public FillToHUDType FillType
	{
		get
		{
			return fillType_;
		}
		set
		{
			fillType_ = value;
		}
	}

	public YesNoType IsLevelItem
	{
		get
		{
			return isLevelItem_;
		}
		set
		{
			isLevelItem_ = value;
		}
	}

	public string EffectDesc
	{
		get
		{
			return effectDesc_;
		}
		set
		{
			effectDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint SellPrice
	{
		get
		{
			return sellPrice_;
		}
		set
		{
			sellPrice_ = value;
		}
	}

	public string Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ItemPackageType PackageType
	{
		get
		{
			return packageType_;
		}
		set
		{
			packageType_ = value;
		}
	}

	public YesNoType IsShieldGain
	{
		get
		{
			return isShieldGain_;
		}
		set
		{
			isShieldGain_ = value;
		}
	}

	public YesNoType IsShowFull
	{
		get
		{
			return isShowFull_;
		}
		set
		{
			isShowFull_ = value;
		}
	}

	public YesNoType IsLoseFalldying
	{
		get
		{
			return isLoseFalldying_;
		}
		set
		{
			isLoseFalldying_ = value;
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

	public int ImageId
	{
		get
		{
			return imageId_;
		}
		set
		{
			imageId_ = value;
		}
	}

	public string HudEffectDesc
	{
		get
		{
			return hudEffectDesc_;
		}
		set
		{
			hudEffectDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Param2
	{
		get
		{
			return param2_;
		}
		set
		{
			param2_ = value;
		}
	}

	public ItemDesc()
	{
	}

	public ItemDesc(ItemDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		sortId_ = other.sortId_;
		typeName_ = other.typeName_;
		itemType_ = other.itemType_;
		quality_ = other.quality_;
		carryMax_ = other.carryMax_;
		briefDesc_ = other.briefDesc_;
		desc_ = other.desc_;
		dropTemplete_ = other.dropTemplete_;
		param1_ = other.param1_;
		gainPerformance_ = other.gainPerformance_;
		fillType_ = other.fillType_;
		isLevelItem_ = other.isLevelItem_;
		effectDesc_ = other.effectDesc_;
		sellPrice_ = other.sellPrice_;
		source_ = other.source_;
		packageType_ = other.packageType_;
		isShieldGain_ = other.isShieldGain_;
		isShowFull_ = other.isShowFull_;
		isLoseFalldying_ = other.isLoseFalldying_;
		localizationTag_ = other.localizationTag_;
		imageId_ = other.imageId_;
		hudEffectDesc_ = other.hudEffectDesc_;
		param2_ = other.param2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ItemDesc Clone()
	{
		return new ItemDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ItemDesc);
	}

	public bool Equals(ItemDesc other)
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
		if (SortId != other.SortId)
		{
			return false;
		}
		if (TypeName != other.TypeName)
		{
			return false;
		}
		if (ItemType != other.ItemType)
		{
			return false;
		}
		if (Quality != other.Quality)
		{
			return false;
		}
		if (CarryMax != other.CarryMax)
		{
			return false;
		}
		if (BriefDesc != other.BriefDesc)
		{
			return false;
		}
		if (Desc != other.Desc)
		{
			return false;
		}
		if (DropTemplete != other.DropTemplete)
		{
			return false;
		}
		if (Param1 != other.Param1)
		{
			return false;
		}
		if (GainPerformance != other.GainPerformance)
		{
			return false;
		}
		if (FillType != other.FillType)
		{
			return false;
		}
		if (IsLevelItem != other.IsLevelItem)
		{
			return false;
		}
		if (EffectDesc != other.EffectDesc)
		{
			return false;
		}
		if (SellPrice != other.SellPrice)
		{
			return false;
		}
		if (Source != other.Source)
		{
			return false;
		}
		if (PackageType != other.PackageType)
		{
			return false;
		}
		if (IsShieldGain != other.IsShieldGain)
		{
			return false;
		}
		if (IsShowFull != other.IsShowFull)
		{
			return false;
		}
		if (IsLoseFalldying != other.IsLoseFalldying)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (ImageId != other.ImageId)
		{
			return false;
		}
		if (HudEffectDesc != other.HudEffectDesc)
		{
			return false;
		}
		if (Param2 != other.Param2)
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
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (TypeName.Length != 0)
		{
			num ^= TypeName.GetHashCode();
		}
		if (ItemType != ItemType.None)
		{
			num ^= ItemType.GetHashCode();
		}
		if (Quality != ItemQuality.Init)
		{
			num ^= Quality.GetHashCode();
		}
		if (CarryMax != 0)
		{
			num ^= CarryMax.GetHashCode();
		}
		if (BriefDesc.Length != 0)
		{
			num ^= BriefDesc.GetHashCode();
		}
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
		}
		if (DropTemplete.Length != 0)
		{
			num ^= DropTemplete.GetHashCode();
		}
		if (Param1 != 0)
		{
			num ^= Param1.GetHashCode();
		}
		if (GainPerformance != GainPerformanceType.Min)
		{
			num ^= GainPerformance.GetHashCode();
		}
		if (FillType != FillToHUDType.Min)
		{
			num ^= FillType.GetHashCode();
		}
		if (IsLevelItem != YesNoType.No)
		{
			num ^= IsLevelItem.GetHashCode();
		}
		if (EffectDesc.Length != 0)
		{
			num ^= EffectDesc.GetHashCode();
		}
		if (SellPrice != 0)
		{
			num ^= SellPrice.GetHashCode();
		}
		if (Source.Length != 0)
		{
			num ^= Source.GetHashCode();
		}
		if (PackageType != ItemPackageType.None)
		{
			num ^= PackageType.GetHashCode();
		}
		if (IsShieldGain != YesNoType.No)
		{
			num ^= IsShieldGain.GetHashCode();
		}
		if (IsShowFull != YesNoType.No)
		{
			num ^= IsShowFull.GetHashCode();
		}
		if (IsLoseFalldying != YesNoType.No)
		{
			num ^= IsLoseFalldying.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (ImageId != 0)
		{
			num ^= ImageId.GetHashCode();
		}
		if (HudEffectDesc.Length != 0)
		{
			num ^= HudEffectDesc.GetHashCode();
		}
		if (Param2 != 0)
		{
			num ^= Param2.GetHashCode();
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
		if (SortId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SortId);
		}
		if (TypeName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(TypeName);
		}
		if (ItemType != ItemType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)ItemType);
		}
		if (Quality != ItemQuality.Init)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Quality);
		}
		if (CarryMax != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CarryMax);
		}
		if (BriefDesc.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(BriefDesc);
		}
		if (Desc.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(Desc);
		}
		if (DropTemplete.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(DropTemplete);
		}
		if (Param1 != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(Param1);
		}
		if (GainPerformance != GainPerformanceType.Min)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)GainPerformance);
		}
		if (FillType != FillToHUDType.Min)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)FillType);
		}
		if (IsLevelItem != YesNoType.No)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)IsLevelItem);
		}
		if (EffectDesc.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(EffectDesc);
		}
		if (SellPrice != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteUInt32(SellPrice);
		}
		if (Source.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(Source);
		}
		if (PackageType != ItemPackageType.None)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)PackageType);
		}
		if (IsShieldGain != YesNoType.No)
		{
			output.WriteRawTag(152, 1);
			output.WriteEnum((int)IsShieldGain);
		}
		if (IsShowFull != YesNoType.No)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)IsShowFull);
		}
		if (IsLoseFalldying != YesNoType.No)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)IsLoseFalldying);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(LocalizationTag);
		}
		if (ImageId != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(ImageId);
		}
		if (HudEffectDesc.Length != 0)
		{
			output.WriteRawTag(194, 1);
			output.WriteString(HudEffectDesc);
		}
		if (Param2 != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(Param2);
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
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (TypeName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TypeName);
		}
		if (ItemType != ItemType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ItemType);
		}
		if (Quality != ItemQuality.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Quality);
		}
		if (CarryMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CarryMax);
		}
		if (BriefDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BriefDesc);
		}
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (DropTemplete.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DropTemplete);
		}
		if (Param1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param1);
		}
		if (GainPerformance != GainPerformanceType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GainPerformance);
		}
		if (FillType != FillToHUDType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FillType);
		}
		if (IsLevelItem != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsLevelItem);
		}
		if (EffectDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EffectDesc);
		}
		if (SellPrice != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(SellPrice);
		}
		if (Source.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Source);
		}
		if (PackageType != ItemPackageType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)PackageType);
		}
		if (IsShieldGain != YesNoType.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsShieldGain);
		}
		if (IsShowFull != YesNoType.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsShowFull);
		}
		if (IsLoseFalldying != YesNoType.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsLoseFalldying);
		}
		if (LocalizationTag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (ImageId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ImageId);
		}
		if (HudEffectDesc.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(HudEffectDesc);
		}
		if (Param2 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Param2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ItemDesc other)
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
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.TypeName.Length != 0)
			{
				TypeName = other.TypeName;
			}
			if (other.ItemType != ItemType.None)
			{
				ItemType = other.ItemType;
			}
			if (other.Quality != ItemQuality.Init)
			{
				Quality = other.Quality;
			}
			if (other.CarryMax != 0)
			{
				CarryMax = other.CarryMax;
			}
			if (other.BriefDesc.Length != 0)
			{
				BriefDesc = other.BriefDesc;
			}
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
			}
			if (other.DropTemplete.Length != 0)
			{
				DropTemplete = other.DropTemplete;
			}
			if (other.Param1 != 0)
			{
				Param1 = other.Param1;
			}
			if (other.GainPerformance != GainPerformanceType.Min)
			{
				GainPerformance = other.GainPerformance;
			}
			if (other.FillType != FillToHUDType.Min)
			{
				FillType = other.FillType;
			}
			if (other.IsLevelItem != YesNoType.No)
			{
				IsLevelItem = other.IsLevelItem;
			}
			if (other.EffectDesc.Length != 0)
			{
				EffectDesc = other.EffectDesc;
			}
			if (other.SellPrice != 0)
			{
				SellPrice = other.SellPrice;
			}
			if (other.Source.Length != 0)
			{
				Source = other.Source;
			}
			if (other.PackageType != ItemPackageType.None)
			{
				PackageType = other.PackageType;
			}
			if (other.IsShieldGain != YesNoType.No)
			{
				IsShieldGain = other.IsShieldGain;
			}
			if (other.IsShowFull != YesNoType.No)
			{
				IsShowFull = other.IsShowFull;
			}
			if (other.IsLoseFalldying != YesNoType.No)
			{
				IsLoseFalldying = other.IsLoseFalldying;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.ImageId != 0)
			{
				ImageId = other.ImageId;
			}
			if (other.HudEffectDesc.Length != 0)
			{
				HudEffectDesc = other.HudEffectDesc;
			}
			if (other.Param2 != 0)
			{
				Param2 = other.Param2;
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
			case 24u:
				SortId = input.ReadInt32();
				break;
			case 34u:
				TypeName = input.ReadString();
				break;
			case 40u:
				ItemType = (ItemType)input.ReadEnum();
				break;
			case 48u:
				Quality = (ItemQuality)input.ReadEnum();
				break;
			case 56u:
				CarryMax = input.ReadInt32();
				break;
			case 66u:
				BriefDesc = input.ReadString();
				break;
			case 74u:
				Desc = input.ReadString();
				break;
			case 82u:
				DropTemplete = input.ReadString();
				break;
			case 88u:
				Param1 = input.ReadInt32();
				break;
			case 96u:
				GainPerformance = (GainPerformanceType)input.ReadEnum();
				break;
			case 104u:
				FillType = (FillToHUDType)input.ReadEnum();
				break;
			case 112u:
				IsLevelItem = (YesNoType)input.ReadEnum();
				break;
			case 122u:
				EffectDesc = input.ReadString();
				break;
			case 128u:
				SellPrice = input.ReadUInt32();
				break;
			case 138u:
				Source = input.ReadString();
				break;
			case 144u:
				PackageType = (ItemPackageType)input.ReadEnum();
				break;
			case 152u:
				IsShieldGain = (YesNoType)input.ReadEnum();
				break;
			case 160u:
				IsShowFull = (YesNoType)input.ReadEnum();
				break;
			case 168u:
				IsLoseFalldying = (YesNoType)input.ReadEnum();
				break;
			case 176u:
				LocalizationTag = input.ReadInt32();
				break;
			case 184u:
				ImageId = input.ReadInt32();
				break;
			case 194u:
				HudEffectDesc = input.ReadString();
				break;
			case 200u:
				Param2 = input.ReadInt32();
				break;
			}
		}
	}
}
