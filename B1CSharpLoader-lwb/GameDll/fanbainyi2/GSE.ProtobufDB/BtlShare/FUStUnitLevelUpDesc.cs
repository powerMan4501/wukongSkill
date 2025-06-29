using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class FUStUnitLevelUpDesc : IMessage<FUStUnitLevelUpDesc>, IMessage, IEquatable<FUStUnitLevelUpDesc>, IDeepCloneable<FUStUnitLevelUpDesc>
{
	private static readonly MessageParser<FUStUnitLevelUpDesc> _parser = new MessageParser<FUStUnitLevelUpDesc>(() => new FUStUnitLevelUpDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EUnitQualityType qualityType_;

	private int tenacity_;

	private int levelNumericalStrength_;

	private int hpBase_;

	private int mpBase_;

	private int atkBase_;

	private int defBase_;

	private int critRateBase_;

	private int critMultiplierBase_;

	private int critRateDef_;

	private int critDmgMulDef_;

	private int dmgAddition_;

	private int dmgDef_;

	private int dmgDefInSSA_;

	private string commAbnormalAttrConfigPath_ = "";

	private int expDropNum_;

	private int spiritDropRate_;

	private int spiritDropMin_;

	private int spiritDropMax_;

	private string guard_ = "";

	public static MessageParser<FUStUnitLevelUpDesc> Parser => _parser;

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

	public EUnitQualityType QualityType
	{
		get
		{
			return qualityType_;
		}
		set
		{
			qualityType_ = value;
		}
	}

	public int Tenacity
	{
		get
		{
			return tenacity_;
		}
		set
		{
			tenacity_ = value;
		}
	}

	public int LevelNumericalStrength
	{
		get
		{
			return levelNumericalStrength_;
		}
		set
		{
			levelNumericalStrength_ = value;
		}
	}

	public int HpBase
	{
		get
		{
			return hpBase_;
		}
		set
		{
			hpBase_ = value;
		}
	}

	public int MpBase
	{
		get
		{
			return mpBase_;
		}
		set
		{
			mpBase_ = value;
		}
	}

	public int AtkBase
	{
		get
		{
			return atkBase_;
		}
		set
		{
			atkBase_ = value;
		}
	}

	public int DefBase
	{
		get
		{
			return defBase_;
		}
		set
		{
			defBase_ = value;
		}
	}

	public int CritRateBase
	{
		get
		{
			return critRateBase_;
		}
		set
		{
			critRateBase_ = value;
		}
	}

	public int CritMultiplierBase
	{
		get
		{
			return critMultiplierBase_;
		}
		set
		{
			critMultiplierBase_ = value;
		}
	}

	public int CritRateDef
	{
		get
		{
			return critRateDef_;
		}
		set
		{
			critRateDef_ = value;
		}
	}

	public int CritDmgMulDef
	{
		get
		{
			return critDmgMulDef_;
		}
		set
		{
			critDmgMulDef_ = value;
		}
	}

	public int DmgAddition
	{
		get
		{
			return dmgAddition_;
		}
		set
		{
			dmgAddition_ = value;
		}
	}

	public int DmgDef
	{
		get
		{
			return dmgDef_;
		}
		set
		{
			dmgDef_ = value;
		}
	}

	public int DmgDefInSSA
	{
		get
		{
			return dmgDefInSSA_;
		}
		set
		{
			dmgDefInSSA_ = value;
		}
	}

	public string CommAbnormalAttrConfigPath
	{
		get
		{
			return commAbnormalAttrConfigPath_;
		}
		set
		{
			commAbnormalAttrConfigPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ExpDropNum
	{
		get
		{
			return expDropNum_;
		}
		set
		{
			expDropNum_ = value;
		}
	}

	public int SpiritDropRate
	{
		get
		{
			return spiritDropRate_;
		}
		set
		{
			spiritDropRate_ = value;
		}
	}

	public int SpiritDropMin
	{
		get
		{
			return spiritDropMin_;
		}
		set
		{
			spiritDropMin_ = value;
		}
	}

	public int SpiritDropMax
	{
		get
		{
			return spiritDropMax_;
		}
		set
		{
			spiritDropMax_ = value;
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStUnitLevelUpDesc()
	{
	}

	public FUStUnitLevelUpDesc(FUStUnitLevelUpDesc other)
		: this()
	{
		iD_ = other.iD_;
		qualityType_ = other.qualityType_;
		tenacity_ = other.tenacity_;
		levelNumericalStrength_ = other.levelNumericalStrength_;
		hpBase_ = other.hpBase_;
		mpBase_ = other.mpBase_;
		atkBase_ = other.atkBase_;
		defBase_ = other.defBase_;
		critRateBase_ = other.critRateBase_;
		critMultiplierBase_ = other.critMultiplierBase_;
		critRateDef_ = other.critRateDef_;
		critDmgMulDef_ = other.critDmgMulDef_;
		dmgAddition_ = other.dmgAddition_;
		dmgDef_ = other.dmgDef_;
		dmgDefInSSA_ = other.dmgDefInSSA_;
		commAbnormalAttrConfigPath_ = other.commAbnormalAttrConfigPath_;
		expDropNum_ = other.expDropNum_;
		spiritDropRate_ = other.spiritDropRate_;
		spiritDropMin_ = other.spiritDropMin_;
		spiritDropMax_ = other.spiritDropMax_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitLevelUpDesc Clone()
	{
		return new FUStUnitLevelUpDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitLevelUpDesc);
	}

	public bool Equals(FUStUnitLevelUpDesc other)
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
		if (QualityType != other.QualityType)
		{
			return false;
		}
		if (Tenacity != other.Tenacity)
		{
			return false;
		}
		if (LevelNumericalStrength != other.LevelNumericalStrength)
		{
			return false;
		}
		if (HpBase != other.HpBase)
		{
			return false;
		}
		if (MpBase != other.MpBase)
		{
			return false;
		}
		if (AtkBase != other.AtkBase)
		{
			return false;
		}
		if (DefBase != other.DefBase)
		{
			return false;
		}
		if (CritRateBase != other.CritRateBase)
		{
			return false;
		}
		if (CritMultiplierBase != other.CritMultiplierBase)
		{
			return false;
		}
		if (CritRateDef != other.CritRateDef)
		{
			return false;
		}
		if (CritDmgMulDef != other.CritDmgMulDef)
		{
			return false;
		}
		if (DmgAddition != other.DmgAddition)
		{
			return false;
		}
		if (DmgDef != other.DmgDef)
		{
			return false;
		}
		if (DmgDefInSSA != other.DmgDefInSSA)
		{
			return false;
		}
		if (CommAbnormalAttrConfigPath != other.CommAbnormalAttrConfigPath)
		{
			return false;
		}
		if (ExpDropNum != other.ExpDropNum)
		{
			return false;
		}
		if (SpiritDropRate != other.SpiritDropRate)
		{
			return false;
		}
		if (SpiritDropMin != other.SpiritDropMin)
		{
			return false;
		}
		if (SpiritDropMax != other.SpiritDropMax)
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (QualityType != EUnitQualityType.None)
		{
			num ^= QualityType.GetHashCode();
		}
		if (Tenacity != 0)
		{
			num ^= Tenacity.GetHashCode();
		}
		if (LevelNumericalStrength != 0)
		{
			num ^= LevelNumericalStrength.GetHashCode();
		}
		if (HpBase != 0)
		{
			num ^= HpBase.GetHashCode();
		}
		if (MpBase != 0)
		{
			num ^= MpBase.GetHashCode();
		}
		if (AtkBase != 0)
		{
			num ^= AtkBase.GetHashCode();
		}
		if (DefBase != 0)
		{
			num ^= DefBase.GetHashCode();
		}
		if (CritRateBase != 0)
		{
			num ^= CritRateBase.GetHashCode();
		}
		if (CritMultiplierBase != 0)
		{
			num ^= CritMultiplierBase.GetHashCode();
		}
		if (CritRateDef != 0)
		{
			num ^= CritRateDef.GetHashCode();
		}
		if (CritDmgMulDef != 0)
		{
			num ^= CritDmgMulDef.GetHashCode();
		}
		if (DmgAddition != 0)
		{
			num ^= DmgAddition.GetHashCode();
		}
		if (DmgDef != 0)
		{
			num ^= DmgDef.GetHashCode();
		}
		if (DmgDefInSSA != 0)
		{
			num ^= DmgDefInSSA.GetHashCode();
		}
		if (CommAbnormalAttrConfigPath.Length != 0)
		{
			num ^= CommAbnormalAttrConfigPath.GetHashCode();
		}
		if (ExpDropNum != 0)
		{
			num ^= ExpDropNum.GetHashCode();
		}
		if (SpiritDropRate != 0)
		{
			num ^= SpiritDropRate.GetHashCode();
		}
		if (SpiritDropMin != 0)
		{
			num ^= SpiritDropMin.GetHashCode();
		}
		if (SpiritDropMax != 0)
		{
			num ^= SpiritDropMax.GetHashCode();
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
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
		if (QualityType != EUnitQualityType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)QualityType);
		}
		if (Tenacity != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Tenacity);
		}
		if (LevelNumericalStrength != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LevelNumericalStrength);
		}
		if (HpBase != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(HpBase);
		}
		if (MpBase != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MpBase);
		}
		if (AtkBase != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(AtkBase);
		}
		if (DefBase != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(DefBase);
		}
		if (CritRateBase != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(CritRateBase);
		}
		if (CritMultiplierBase != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(CritMultiplierBase);
		}
		if (CritRateDef != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(CritRateDef);
		}
		if (CritDmgMulDef != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(CritDmgMulDef);
		}
		if (DmgAddition != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(DmgAddition);
		}
		if (DmgDef != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(DmgDef);
		}
		if (DmgDefInSSA != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(DmgDefInSSA);
		}
		if (CommAbnormalAttrConfigPath.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(CommAbnormalAttrConfigPath);
		}
		if (ExpDropNum != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(ExpDropNum);
		}
		if (SpiritDropRate != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(SpiritDropRate);
		}
		if (SpiritDropMin != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(SpiritDropMin);
		}
		if (SpiritDropMax != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(SpiritDropMax);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(170, 1);
			output.WriteString(Guard);
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
		if (QualityType != EUnitQualityType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)QualityType);
		}
		if (Tenacity != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Tenacity);
		}
		if (LevelNumericalStrength != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelNumericalStrength);
		}
		if (HpBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HpBase);
		}
		if (MpBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MpBase);
		}
		if (AtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AtkBase);
		}
		if (DefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefBase);
		}
		if (CritRateBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritRateBase);
		}
		if (CritMultiplierBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritMultiplierBase);
		}
		if (CritRateDef != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritRateDef);
		}
		if (CritDmgMulDef != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritDmgMulDef);
		}
		if (DmgAddition != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgAddition);
		}
		if (DmgDef != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgDef);
		}
		if (DmgDefInSSA != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgDefInSSA);
		}
		if (CommAbnormalAttrConfigPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(CommAbnormalAttrConfigPath);
		}
		if (ExpDropNum != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ExpDropNum);
		}
		if (SpiritDropRate != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpiritDropRate);
		}
		if (SpiritDropMin != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpiritDropMin);
		}
		if (SpiritDropMax != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SpiritDropMax);
		}
		if (Guard.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitLevelUpDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.QualityType != EUnitQualityType.None)
			{
				QualityType = other.QualityType;
			}
			if (other.Tenacity != 0)
			{
				Tenacity = other.Tenacity;
			}
			if (other.LevelNumericalStrength != 0)
			{
				LevelNumericalStrength = other.LevelNumericalStrength;
			}
			if (other.HpBase != 0)
			{
				HpBase = other.HpBase;
			}
			if (other.MpBase != 0)
			{
				MpBase = other.MpBase;
			}
			if (other.AtkBase != 0)
			{
				AtkBase = other.AtkBase;
			}
			if (other.DefBase != 0)
			{
				DefBase = other.DefBase;
			}
			if (other.CritRateBase != 0)
			{
				CritRateBase = other.CritRateBase;
			}
			if (other.CritMultiplierBase != 0)
			{
				CritMultiplierBase = other.CritMultiplierBase;
			}
			if (other.CritRateDef != 0)
			{
				CritRateDef = other.CritRateDef;
			}
			if (other.CritDmgMulDef != 0)
			{
				CritDmgMulDef = other.CritDmgMulDef;
			}
			if (other.DmgAddition != 0)
			{
				DmgAddition = other.DmgAddition;
			}
			if (other.DmgDef != 0)
			{
				DmgDef = other.DmgDef;
			}
			if (other.DmgDefInSSA != 0)
			{
				DmgDefInSSA = other.DmgDefInSSA;
			}
			if (other.CommAbnormalAttrConfigPath.Length != 0)
			{
				CommAbnormalAttrConfigPath = other.CommAbnormalAttrConfigPath;
			}
			if (other.ExpDropNum != 0)
			{
				ExpDropNum = other.ExpDropNum;
			}
			if (other.SpiritDropRate != 0)
			{
				SpiritDropRate = other.SpiritDropRate;
			}
			if (other.SpiritDropMin != 0)
			{
				SpiritDropMin = other.SpiritDropMin;
			}
			if (other.SpiritDropMax != 0)
			{
				SpiritDropMax = other.SpiritDropMax;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
			case 16u:
				QualityType = (EUnitQualityType)input.ReadEnum();
				break;
			case 24u:
				Tenacity = input.ReadInt32();
				break;
			case 32u:
				LevelNumericalStrength = input.ReadInt32();
				break;
			case 40u:
				HpBase = input.ReadInt32();
				break;
			case 48u:
				MpBase = input.ReadInt32();
				break;
			case 56u:
				AtkBase = input.ReadInt32();
				break;
			case 64u:
				DefBase = input.ReadInt32();
				break;
			case 72u:
				CritRateBase = input.ReadInt32();
				break;
			case 80u:
				CritMultiplierBase = input.ReadInt32();
				break;
			case 88u:
				CritRateDef = input.ReadInt32();
				break;
			case 96u:
				CritDmgMulDef = input.ReadInt32();
				break;
			case 104u:
				DmgAddition = input.ReadInt32();
				break;
			case 112u:
				DmgDef = input.ReadInt32();
				break;
			case 120u:
				DmgDefInSSA = input.ReadInt32();
				break;
			case 130u:
				CommAbnormalAttrConfigPath = input.ReadString();
				break;
			case 136u:
				ExpDropNum = input.ReadInt32();
				break;
			case 144u:
				SpiritDropRate = input.ReadInt32();
				break;
			case 152u:
				SpiritDropMin = input.ReadInt32();
				break;
			case 160u:
				SpiritDropMax = input.ReadInt32();
				break;
			case 170u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
