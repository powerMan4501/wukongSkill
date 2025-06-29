using System;
using Google.Protobuf;

namespace ResB1;

public sealed class CricketUnitAttrDesc : IMessage<CricketUnitAttrDesc>, IMessage, IEquatable<CricketUnitAttrDesc>, IDeepCloneable<CricketUnitAttrDesc>
{
	private static readonly MessageParser<CricketUnitAttrDesc> _parser = new MessageParser<CricketUnitAttrDesc>(() => new CricketUnitAttrDesc());

	private UnknownFieldSet _unknownFields;

	private int extentBattleId_;

	private int hpBase_;

	private int atkBase_;

	private int defBase_;

	private int critRateBase_;

	private int critMultiplierBase_;

	private int critRateDefBase_;

	private int critDmgMulDefBase_;

	private int dmgAdditionBase_;

	private int dmgDefBase_;

	private int freezeAtkBase_;

	private int burnAtkBase_;

	private int poisonAtkBase_;

	private int thunderAtkBase_;

	private int freezeDefBase_;

	private int burnDefBase_;

	private int poisonDefBase_;

	private int thunderDefBase_;

	private int tenacityBase_;

	public static MessageParser<CricketUnitAttrDesc> Parser => _parser;

	public int ExtentBattleId
	{
		get
		{
			return extentBattleId_;
		}
		set
		{
			extentBattleId_ = value;
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

	public int CritRateDefBase
	{
		get
		{
			return critRateDefBase_;
		}
		set
		{
			critRateDefBase_ = value;
		}
	}

	public int CritDmgMulDefBase
	{
		get
		{
			return critDmgMulDefBase_;
		}
		set
		{
			critDmgMulDefBase_ = value;
		}
	}

	public int DmgAdditionBase
	{
		get
		{
			return dmgAdditionBase_;
		}
		set
		{
			dmgAdditionBase_ = value;
		}
	}

	public int DmgDefBase
	{
		get
		{
			return dmgDefBase_;
		}
		set
		{
			dmgDefBase_ = value;
		}
	}

	public int FreezeAtkBase
	{
		get
		{
			return freezeAtkBase_;
		}
		set
		{
			freezeAtkBase_ = value;
		}
	}

	public int BurnAtkBase
	{
		get
		{
			return burnAtkBase_;
		}
		set
		{
			burnAtkBase_ = value;
		}
	}

	public int PoisonAtkBase
	{
		get
		{
			return poisonAtkBase_;
		}
		set
		{
			poisonAtkBase_ = value;
		}
	}

	public int ThunderAtkBase
	{
		get
		{
			return thunderAtkBase_;
		}
		set
		{
			thunderAtkBase_ = value;
		}
	}

	public int FreezeDefBase
	{
		get
		{
			return freezeDefBase_;
		}
		set
		{
			freezeDefBase_ = value;
		}
	}

	public int BurnDefBase
	{
		get
		{
			return burnDefBase_;
		}
		set
		{
			burnDefBase_ = value;
		}
	}

	public int PoisonDefBase
	{
		get
		{
			return poisonDefBase_;
		}
		set
		{
			poisonDefBase_ = value;
		}
	}

	public int ThunderDefBase
	{
		get
		{
			return thunderDefBase_;
		}
		set
		{
			thunderDefBase_ = value;
		}
	}

	public int TenacityBase
	{
		get
		{
			return tenacityBase_;
		}
		set
		{
			tenacityBase_ = value;
		}
	}

	public CricketUnitAttrDesc()
	{
	}

	public CricketUnitAttrDesc(CricketUnitAttrDesc other)
		: this()
	{
		extentBattleId_ = other.extentBattleId_;
		hpBase_ = other.hpBase_;
		atkBase_ = other.atkBase_;
		defBase_ = other.defBase_;
		critRateBase_ = other.critRateBase_;
		critMultiplierBase_ = other.critMultiplierBase_;
		critRateDefBase_ = other.critRateDefBase_;
		critDmgMulDefBase_ = other.critDmgMulDefBase_;
		dmgAdditionBase_ = other.dmgAdditionBase_;
		dmgDefBase_ = other.dmgDefBase_;
		freezeAtkBase_ = other.freezeAtkBase_;
		burnAtkBase_ = other.burnAtkBase_;
		poisonAtkBase_ = other.poisonAtkBase_;
		thunderAtkBase_ = other.thunderAtkBase_;
		freezeDefBase_ = other.freezeDefBase_;
		burnDefBase_ = other.burnDefBase_;
		poisonDefBase_ = other.poisonDefBase_;
		thunderDefBase_ = other.thunderDefBase_;
		tenacityBase_ = other.tenacityBase_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CricketUnitAttrDesc Clone()
	{
		return new CricketUnitAttrDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CricketUnitAttrDesc);
	}

	public bool Equals(CricketUnitAttrDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ExtentBattleId != other.ExtentBattleId)
		{
			return false;
		}
		if (HpBase != other.HpBase)
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
		if (CritRateDefBase != other.CritRateDefBase)
		{
			return false;
		}
		if (CritDmgMulDefBase != other.CritDmgMulDefBase)
		{
			return false;
		}
		if (DmgAdditionBase != other.DmgAdditionBase)
		{
			return false;
		}
		if (DmgDefBase != other.DmgDefBase)
		{
			return false;
		}
		if (FreezeAtkBase != other.FreezeAtkBase)
		{
			return false;
		}
		if (BurnAtkBase != other.BurnAtkBase)
		{
			return false;
		}
		if (PoisonAtkBase != other.PoisonAtkBase)
		{
			return false;
		}
		if (ThunderAtkBase != other.ThunderAtkBase)
		{
			return false;
		}
		if (FreezeDefBase != other.FreezeDefBase)
		{
			return false;
		}
		if (BurnDefBase != other.BurnDefBase)
		{
			return false;
		}
		if (PoisonDefBase != other.PoisonDefBase)
		{
			return false;
		}
		if (ThunderDefBase != other.ThunderDefBase)
		{
			return false;
		}
		if (TenacityBase != other.TenacityBase)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ExtentBattleId != 0)
		{
			num ^= ExtentBattleId.GetHashCode();
		}
		if (HpBase != 0)
		{
			num ^= HpBase.GetHashCode();
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
		if (CritRateDefBase != 0)
		{
			num ^= CritRateDefBase.GetHashCode();
		}
		if (CritDmgMulDefBase != 0)
		{
			num ^= CritDmgMulDefBase.GetHashCode();
		}
		if (DmgAdditionBase != 0)
		{
			num ^= DmgAdditionBase.GetHashCode();
		}
		if (DmgDefBase != 0)
		{
			num ^= DmgDefBase.GetHashCode();
		}
		if (FreezeAtkBase != 0)
		{
			num ^= FreezeAtkBase.GetHashCode();
		}
		if (BurnAtkBase != 0)
		{
			num ^= BurnAtkBase.GetHashCode();
		}
		if (PoisonAtkBase != 0)
		{
			num ^= PoisonAtkBase.GetHashCode();
		}
		if (ThunderAtkBase != 0)
		{
			num ^= ThunderAtkBase.GetHashCode();
		}
		if (FreezeDefBase != 0)
		{
			num ^= FreezeDefBase.GetHashCode();
		}
		if (BurnDefBase != 0)
		{
			num ^= BurnDefBase.GetHashCode();
		}
		if (PoisonDefBase != 0)
		{
			num ^= PoisonDefBase.GetHashCode();
		}
		if (ThunderDefBase != 0)
		{
			num ^= ThunderDefBase.GetHashCode();
		}
		if (TenacityBase != 0)
		{
			num ^= TenacityBase.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ExtentBattleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ExtentBattleId);
		}
		if (HpBase != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(HpBase);
		}
		if (AtkBase != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AtkBase);
		}
		if (DefBase != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DefBase);
		}
		if (CritRateBase != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CritRateBase);
		}
		if (CritMultiplierBase != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(CritMultiplierBase);
		}
		if (CritRateDefBase != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CritRateDefBase);
		}
		if (CritDmgMulDefBase != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(CritDmgMulDefBase);
		}
		if (DmgAdditionBase != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(DmgAdditionBase);
		}
		if (DmgDefBase != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(DmgDefBase);
		}
		if (FreezeAtkBase != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(FreezeAtkBase);
		}
		if (BurnAtkBase != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(BurnAtkBase);
		}
		if (PoisonAtkBase != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(PoisonAtkBase);
		}
		if (ThunderAtkBase != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(ThunderAtkBase);
		}
		if (FreezeDefBase != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(FreezeDefBase);
		}
		if (BurnDefBase != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(BurnDefBase);
		}
		if (PoisonDefBase != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(PoisonDefBase);
		}
		if (ThunderDefBase != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(ThunderDefBase);
		}
		if (TenacityBase != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(TenacityBase);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ExtentBattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtentBattleId);
		}
		if (HpBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HpBase);
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
		if (CritRateDefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritRateDefBase);
		}
		if (CritDmgMulDefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CritDmgMulDefBase);
		}
		if (DmgAdditionBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgAdditionBase);
		}
		if (DmgDefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgDefBase);
		}
		if (FreezeAtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FreezeAtkBase);
		}
		if (BurnAtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BurnAtkBase);
		}
		if (PoisonAtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PoisonAtkBase);
		}
		if (ThunderAtkBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ThunderAtkBase);
		}
		if (FreezeDefBase != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FreezeDefBase);
		}
		if (BurnDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BurnDefBase);
		}
		if (PoisonDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(PoisonDefBase);
		}
		if (ThunderDefBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ThunderDefBase);
		}
		if (TenacityBase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TenacityBase);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CricketUnitAttrDesc other)
	{
		if (other != null)
		{
			if (other.ExtentBattleId != 0)
			{
				ExtentBattleId = other.ExtentBattleId;
			}
			if (other.HpBase != 0)
			{
				HpBase = other.HpBase;
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
			if (other.CritRateDefBase != 0)
			{
				CritRateDefBase = other.CritRateDefBase;
			}
			if (other.CritDmgMulDefBase != 0)
			{
				CritDmgMulDefBase = other.CritDmgMulDefBase;
			}
			if (other.DmgAdditionBase != 0)
			{
				DmgAdditionBase = other.DmgAdditionBase;
			}
			if (other.DmgDefBase != 0)
			{
				DmgDefBase = other.DmgDefBase;
			}
			if (other.FreezeAtkBase != 0)
			{
				FreezeAtkBase = other.FreezeAtkBase;
			}
			if (other.BurnAtkBase != 0)
			{
				BurnAtkBase = other.BurnAtkBase;
			}
			if (other.PoisonAtkBase != 0)
			{
				PoisonAtkBase = other.PoisonAtkBase;
			}
			if (other.ThunderAtkBase != 0)
			{
				ThunderAtkBase = other.ThunderAtkBase;
			}
			if (other.FreezeDefBase != 0)
			{
				FreezeDefBase = other.FreezeDefBase;
			}
			if (other.BurnDefBase != 0)
			{
				BurnDefBase = other.BurnDefBase;
			}
			if (other.PoisonDefBase != 0)
			{
				PoisonDefBase = other.PoisonDefBase;
			}
			if (other.ThunderDefBase != 0)
			{
				ThunderDefBase = other.ThunderDefBase;
			}
			if (other.TenacityBase != 0)
			{
				TenacityBase = other.TenacityBase;
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
				ExtentBattleId = input.ReadInt32();
				break;
			case 16u:
				HpBase = input.ReadInt32();
				break;
			case 24u:
				AtkBase = input.ReadInt32();
				break;
			case 32u:
				DefBase = input.ReadInt32();
				break;
			case 40u:
				CritRateBase = input.ReadInt32();
				break;
			case 48u:
				CritMultiplierBase = input.ReadInt32();
				break;
			case 56u:
				CritRateDefBase = input.ReadInt32();
				break;
			case 64u:
				CritDmgMulDefBase = input.ReadInt32();
				break;
			case 72u:
				DmgAdditionBase = input.ReadInt32();
				break;
			case 80u:
				DmgDefBase = input.ReadInt32();
				break;
			case 88u:
				FreezeAtkBase = input.ReadInt32();
				break;
			case 96u:
				BurnAtkBase = input.ReadInt32();
				break;
			case 104u:
				PoisonAtkBase = input.ReadInt32();
				break;
			case 112u:
				ThunderAtkBase = input.ReadInt32();
				break;
			case 120u:
				FreezeDefBase = input.ReadInt32();
				break;
			case 128u:
				BurnDefBase = input.ReadInt32();
				break;
			case 136u:
				PoisonDefBase = input.ReadInt32();
				break;
			case 144u:
				ThunderDefBase = input.ReadInt32();
				break;
			case 152u:
				TenacityBase = input.ReadInt32();
				break;
			}
		}
	}
}
