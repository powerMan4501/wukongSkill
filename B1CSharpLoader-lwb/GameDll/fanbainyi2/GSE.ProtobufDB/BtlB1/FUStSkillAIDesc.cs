using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSkillAIDesc : IMessage<FUStSkillAIDesc>, IMessage, IEquatable<FUStSkillAIDesc>, IDeepCloneable<FUStSkillAIDesc>
{
	private static readonly MessageParser<FUStSkillAIDesc> _parser = new MessageParser<FUStSkillAIDesc>(() => new FUStSkillAIDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string targetResIDList_ = "";

	private EGSYesNo canUseInGroupAIAttack_;

	private string canUseInGroupAIBuffConditions_ = "";

	private EGroupAIAttackBias attackBias_;

	private float preferRangeMin_;

	private float preferRangeMax_;

	private float preferHeightDis_;

	private float optimalDisMin_;

	private float optimalDisMax_;

	private int optimalDisAddScore_;

	private int coolDownAddtion_;

	private int coolDownAdditionMax_;

	private int angleScoreSector0To45_;

	private int angleScoreSector45To90_;

	private int angleScoreSector90To135_;

	private int angleScoreSector135To180_;

	private int angleScoreSector180ToNeg135_;

	private int angleScoreSectorNeg135ToNeg90_;

	private int angleScoreSectorNeg90ToNeg45_;

	private int angleScoreSectorNeg45To0_;

	private int generalSkillDirection_;

	private static readonly FieldCodec<int> _repeated_nextSkillList_codec = FieldCodec.ForInt32(186u);

	private readonly RepeatedField<int> nextSkillList_ = new RepeatedField<int>();

	private string guard_ = "";

	public static MessageParser<FUStSkillAIDesc> Parser => _parser;

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

	public string TargetResIDList
	{
		get
		{
			return targetResIDList_;
		}
		set
		{
			targetResIDList_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo CanUseInGroupAIAttack
	{
		get
		{
			return canUseInGroupAIAttack_;
		}
		set
		{
			canUseInGroupAIAttack_ = value;
		}
	}

	public string CanUseInGroupAIBuffConditions
	{
		get
		{
			return canUseInGroupAIBuffConditions_;
		}
		set
		{
			canUseInGroupAIBuffConditions_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGroupAIAttackBias AttackBias
	{
		get
		{
			return attackBias_;
		}
		set
		{
			attackBias_ = value;
		}
	}

	public float PreferRangeMin
	{
		get
		{
			return preferRangeMin_;
		}
		set
		{
			preferRangeMin_ = value;
		}
	}

	public float PreferRangeMax
	{
		get
		{
			return preferRangeMax_;
		}
		set
		{
			preferRangeMax_ = value;
		}
	}

	public float PreferHeightDis
	{
		get
		{
			return preferHeightDis_;
		}
		set
		{
			preferHeightDis_ = value;
		}
	}

	public float OptimalDisMin
	{
		get
		{
			return optimalDisMin_;
		}
		set
		{
			optimalDisMin_ = value;
		}
	}

	public float OptimalDisMax
	{
		get
		{
			return optimalDisMax_;
		}
		set
		{
			optimalDisMax_ = value;
		}
	}

	public int OptimalDisAddScore
	{
		get
		{
			return optimalDisAddScore_;
		}
		set
		{
			optimalDisAddScore_ = value;
		}
	}

	public int CoolDownAddtion
	{
		get
		{
			return coolDownAddtion_;
		}
		set
		{
			coolDownAddtion_ = value;
		}
	}

	public int CoolDownAdditionMax
	{
		get
		{
			return coolDownAdditionMax_;
		}
		set
		{
			coolDownAdditionMax_ = value;
		}
	}

	public int AngleScoreSector0To45
	{
		get
		{
			return angleScoreSector0To45_;
		}
		set
		{
			angleScoreSector0To45_ = value;
		}
	}

	public int AngleScoreSector45To90
	{
		get
		{
			return angleScoreSector45To90_;
		}
		set
		{
			angleScoreSector45To90_ = value;
		}
	}

	public int AngleScoreSector90To135
	{
		get
		{
			return angleScoreSector90To135_;
		}
		set
		{
			angleScoreSector90To135_ = value;
		}
	}

	public int AngleScoreSector135To180
	{
		get
		{
			return angleScoreSector135To180_;
		}
		set
		{
			angleScoreSector135To180_ = value;
		}
	}

	public int AngleScoreSector180ToNeg135
	{
		get
		{
			return angleScoreSector180ToNeg135_;
		}
		set
		{
			angleScoreSector180ToNeg135_ = value;
		}
	}

	public int AngleScoreSectorNeg135ToNeg90
	{
		get
		{
			return angleScoreSectorNeg135ToNeg90_;
		}
		set
		{
			angleScoreSectorNeg135ToNeg90_ = value;
		}
	}

	public int AngleScoreSectorNeg90ToNeg45
	{
		get
		{
			return angleScoreSectorNeg90ToNeg45_;
		}
		set
		{
			angleScoreSectorNeg90ToNeg45_ = value;
		}
	}

	public int AngleScoreSectorNeg45To0
	{
		get
		{
			return angleScoreSectorNeg45To0_;
		}
		set
		{
			angleScoreSectorNeg45To0_ = value;
		}
	}

	public int GeneralSkillDirection
	{
		get
		{
			return generalSkillDirection_;
		}
		set
		{
			generalSkillDirection_ = value;
		}
	}

	public RepeatedField<int> NextSkillList => nextSkillList_;

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

	public FUStSkillAIDesc()
	{
	}

	public FUStSkillAIDesc(FUStSkillAIDesc other)
		: this()
	{
		iD_ = other.iD_;
		targetResIDList_ = other.targetResIDList_;
		canUseInGroupAIAttack_ = other.canUseInGroupAIAttack_;
		canUseInGroupAIBuffConditions_ = other.canUseInGroupAIBuffConditions_;
		attackBias_ = other.attackBias_;
		preferRangeMin_ = other.preferRangeMin_;
		preferRangeMax_ = other.preferRangeMax_;
		preferHeightDis_ = other.preferHeightDis_;
		optimalDisMin_ = other.optimalDisMin_;
		optimalDisMax_ = other.optimalDisMax_;
		optimalDisAddScore_ = other.optimalDisAddScore_;
		coolDownAddtion_ = other.coolDownAddtion_;
		coolDownAdditionMax_ = other.coolDownAdditionMax_;
		angleScoreSector0To45_ = other.angleScoreSector0To45_;
		angleScoreSector45To90_ = other.angleScoreSector45To90_;
		angleScoreSector90To135_ = other.angleScoreSector90To135_;
		angleScoreSector135To180_ = other.angleScoreSector135To180_;
		angleScoreSector180ToNeg135_ = other.angleScoreSector180ToNeg135_;
		angleScoreSectorNeg135ToNeg90_ = other.angleScoreSectorNeg135ToNeg90_;
		angleScoreSectorNeg90ToNeg45_ = other.angleScoreSectorNeg90ToNeg45_;
		angleScoreSectorNeg45To0_ = other.angleScoreSectorNeg45To0_;
		generalSkillDirection_ = other.generalSkillDirection_;
		nextSkillList_ = other.nextSkillList_.Clone();
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSkillAIDesc Clone()
	{
		return new FUStSkillAIDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSkillAIDesc);
	}

	public bool Equals(FUStSkillAIDesc other)
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
		if (TargetResIDList != other.TargetResIDList)
		{
			return false;
		}
		if (CanUseInGroupAIAttack != other.CanUseInGroupAIAttack)
		{
			return false;
		}
		if (CanUseInGroupAIBuffConditions != other.CanUseInGroupAIBuffConditions)
		{
			return false;
		}
		if (AttackBias != other.AttackBias)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PreferRangeMin, other.PreferRangeMin))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PreferRangeMax, other.PreferRangeMax))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PreferHeightDis, other.PreferHeightDis))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(OptimalDisMin, other.OptimalDisMin))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(OptimalDisMax, other.OptimalDisMax))
		{
			return false;
		}
		if (OptimalDisAddScore != other.OptimalDisAddScore)
		{
			return false;
		}
		if (CoolDownAddtion != other.CoolDownAddtion)
		{
			return false;
		}
		if (CoolDownAdditionMax != other.CoolDownAdditionMax)
		{
			return false;
		}
		if (AngleScoreSector0To45 != other.AngleScoreSector0To45)
		{
			return false;
		}
		if (AngleScoreSector45To90 != other.AngleScoreSector45To90)
		{
			return false;
		}
		if (AngleScoreSector90To135 != other.AngleScoreSector90To135)
		{
			return false;
		}
		if (AngleScoreSector135To180 != other.AngleScoreSector135To180)
		{
			return false;
		}
		if (AngleScoreSector180ToNeg135 != other.AngleScoreSector180ToNeg135)
		{
			return false;
		}
		if (AngleScoreSectorNeg135ToNeg90 != other.AngleScoreSectorNeg135ToNeg90)
		{
			return false;
		}
		if (AngleScoreSectorNeg90ToNeg45 != other.AngleScoreSectorNeg90ToNeg45)
		{
			return false;
		}
		if (AngleScoreSectorNeg45To0 != other.AngleScoreSectorNeg45To0)
		{
			return false;
		}
		if (GeneralSkillDirection != other.GeneralSkillDirection)
		{
			return false;
		}
		if (!nextSkillList_.Equals(other.nextSkillList_))
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
		if (TargetResIDList.Length != 0)
		{
			num ^= TargetResIDList.GetHashCode();
		}
		if (CanUseInGroupAIAttack != EGSYesNo.No)
		{
			num ^= CanUseInGroupAIAttack.GetHashCode();
		}
		if (CanUseInGroupAIBuffConditions.Length != 0)
		{
			num ^= CanUseInGroupAIBuffConditions.GetHashCode();
		}
		if (AttackBias != EGroupAIAttackBias.None)
		{
			num ^= AttackBias.GetHashCode();
		}
		if (PreferRangeMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PreferRangeMin);
		}
		if (PreferRangeMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PreferRangeMax);
		}
		if (PreferHeightDis != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PreferHeightDis);
		}
		if (OptimalDisMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(OptimalDisMin);
		}
		if (OptimalDisMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(OptimalDisMax);
		}
		if (OptimalDisAddScore != 0)
		{
			num ^= OptimalDisAddScore.GetHashCode();
		}
		if (CoolDownAddtion != 0)
		{
			num ^= CoolDownAddtion.GetHashCode();
		}
		if (CoolDownAdditionMax != 0)
		{
			num ^= CoolDownAdditionMax.GetHashCode();
		}
		if (AngleScoreSector0To45 != 0)
		{
			num ^= AngleScoreSector0To45.GetHashCode();
		}
		if (AngleScoreSector45To90 != 0)
		{
			num ^= AngleScoreSector45To90.GetHashCode();
		}
		if (AngleScoreSector90To135 != 0)
		{
			num ^= AngleScoreSector90To135.GetHashCode();
		}
		if (AngleScoreSector135To180 != 0)
		{
			num ^= AngleScoreSector135To180.GetHashCode();
		}
		if (AngleScoreSector180ToNeg135 != 0)
		{
			num ^= AngleScoreSector180ToNeg135.GetHashCode();
		}
		if (AngleScoreSectorNeg135ToNeg90 != 0)
		{
			num ^= AngleScoreSectorNeg135ToNeg90.GetHashCode();
		}
		if (AngleScoreSectorNeg90ToNeg45 != 0)
		{
			num ^= AngleScoreSectorNeg90ToNeg45.GetHashCode();
		}
		if (AngleScoreSectorNeg45To0 != 0)
		{
			num ^= AngleScoreSectorNeg45To0.GetHashCode();
		}
		if (GeneralSkillDirection != 0)
		{
			num ^= GeneralSkillDirection.GetHashCode();
		}
		num ^= nextSkillList_.GetHashCode();
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
		if (TargetResIDList.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(TargetResIDList);
		}
		if (CanUseInGroupAIAttack != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)CanUseInGroupAIAttack);
		}
		if (CanUseInGroupAIBuffConditions.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(CanUseInGroupAIBuffConditions);
		}
		if (AttackBias != EGroupAIAttackBias.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)AttackBias);
		}
		if (PreferRangeMin != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(PreferRangeMin);
		}
		if (PreferRangeMax != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(PreferRangeMax);
		}
		if (PreferHeightDis != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(PreferHeightDis);
		}
		if (OptimalDisMin != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(OptimalDisMin);
		}
		if (OptimalDisMax != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(OptimalDisMax);
		}
		if (OptimalDisAddScore != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(OptimalDisAddScore);
		}
		if (CoolDownAddtion != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(CoolDownAddtion);
		}
		if (CoolDownAdditionMax != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(CoolDownAdditionMax);
		}
		if (AngleScoreSector0To45 != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(AngleScoreSector0To45);
		}
		if (AngleScoreSector45To90 != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(AngleScoreSector45To90);
		}
		if (AngleScoreSector90To135 != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(AngleScoreSector90To135);
		}
		if (AngleScoreSector135To180 != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(AngleScoreSector135To180);
		}
		if (AngleScoreSector180ToNeg135 != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(AngleScoreSector180ToNeg135);
		}
		if (AngleScoreSectorNeg135ToNeg90 != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(AngleScoreSectorNeg135ToNeg90);
		}
		if (AngleScoreSectorNeg90ToNeg45 != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(AngleScoreSectorNeg90ToNeg45);
		}
		if (AngleScoreSectorNeg45To0 != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(AngleScoreSectorNeg45To0);
		}
		if (GeneralSkillDirection != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(GeneralSkillDirection);
		}
		nextSkillList_.WriteTo(output, _repeated_nextSkillList_codec);
		if (Guard.Length != 0)
		{
			output.WriteRawTag(194, 1);
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
		if (TargetResIDList.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TargetResIDList);
		}
		if (CanUseInGroupAIAttack != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanUseInGroupAIAttack);
		}
		if (CanUseInGroupAIBuffConditions.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CanUseInGroupAIBuffConditions);
		}
		if (AttackBias != EGroupAIAttackBias.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AttackBias);
		}
		if (PreferRangeMin != 0f)
		{
			num += 5;
		}
		if (PreferRangeMax != 0f)
		{
			num += 5;
		}
		if (PreferHeightDis != 0f)
		{
			num += 5;
		}
		if (OptimalDisMin != 0f)
		{
			num += 5;
		}
		if (OptimalDisMax != 0f)
		{
			num += 5;
		}
		if (OptimalDisAddScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OptimalDisAddScore);
		}
		if (CoolDownAddtion != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CoolDownAddtion);
		}
		if (CoolDownAdditionMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CoolDownAdditionMax);
		}
		if (AngleScoreSector0To45 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AngleScoreSector0To45);
		}
		if (AngleScoreSector45To90 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AngleScoreSector45To90);
		}
		if (AngleScoreSector90To135 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AngleScoreSector90To135);
		}
		if (AngleScoreSector135To180 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AngleScoreSector135To180);
		}
		if (AngleScoreSector180ToNeg135 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AngleScoreSector180ToNeg135);
		}
		if (AngleScoreSectorNeg135ToNeg90 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AngleScoreSectorNeg135ToNeg90);
		}
		if (AngleScoreSectorNeg90ToNeg45 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AngleScoreSectorNeg90ToNeg45);
		}
		if (AngleScoreSectorNeg45To0 != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AngleScoreSectorNeg45To0);
		}
		if (GeneralSkillDirection != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GeneralSkillDirection);
		}
		num += nextSkillList_.CalculateSize(_repeated_nextSkillList_codec);
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

	public void MergeFrom(FUStSkillAIDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.TargetResIDList.Length != 0)
			{
				TargetResIDList = other.TargetResIDList;
			}
			if (other.CanUseInGroupAIAttack != EGSYesNo.No)
			{
				CanUseInGroupAIAttack = other.CanUseInGroupAIAttack;
			}
			if (other.CanUseInGroupAIBuffConditions.Length != 0)
			{
				CanUseInGroupAIBuffConditions = other.CanUseInGroupAIBuffConditions;
			}
			if (other.AttackBias != EGroupAIAttackBias.None)
			{
				AttackBias = other.AttackBias;
			}
			if (other.PreferRangeMin != 0f)
			{
				PreferRangeMin = other.PreferRangeMin;
			}
			if (other.PreferRangeMax != 0f)
			{
				PreferRangeMax = other.PreferRangeMax;
			}
			if (other.PreferHeightDis != 0f)
			{
				PreferHeightDis = other.PreferHeightDis;
			}
			if (other.OptimalDisMin != 0f)
			{
				OptimalDisMin = other.OptimalDisMin;
			}
			if (other.OptimalDisMax != 0f)
			{
				OptimalDisMax = other.OptimalDisMax;
			}
			if (other.OptimalDisAddScore != 0)
			{
				OptimalDisAddScore = other.OptimalDisAddScore;
			}
			if (other.CoolDownAddtion != 0)
			{
				CoolDownAddtion = other.CoolDownAddtion;
			}
			if (other.CoolDownAdditionMax != 0)
			{
				CoolDownAdditionMax = other.CoolDownAdditionMax;
			}
			if (other.AngleScoreSector0To45 != 0)
			{
				AngleScoreSector0To45 = other.AngleScoreSector0To45;
			}
			if (other.AngleScoreSector45To90 != 0)
			{
				AngleScoreSector45To90 = other.AngleScoreSector45To90;
			}
			if (other.AngleScoreSector90To135 != 0)
			{
				AngleScoreSector90To135 = other.AngleScoreSector90To135;
			}
			if (other.AngleScoreSector135To180 != 0)
			{
				AngleScoreSector135To180 = other.AngleScoreSector135To180;
			}
			if (other.AngleScoreSector180ToNeg135 != 0)
			{
				AngleScoreSector180ToNeg135 = other.AngleScoreSector180ToNeg135;
			}
			if (other.AngleScoreSectorNeg135ToNeg90 != 0)
			{
				AngleScoreSectorNeg135ToNeg90 = other.AngleScoreSectorNeg135ToNeg90;
			}
			if (other.AngleScoreSectorNeg90ToNeg45 != 0)
			{
				AngleScoreSectorNeg90ToNeg45 = other.AngleScoreSectorNeg90ToNeg45;
			}
			if (other.AngleScoreSectorNeg45To0 != 0)
			{
				AngleScoreSectorNeg45To0 = other.AngleScoreSectorNeg45To0;
			}
			if (other.GeneralSkillDirection != 0)
			{
				GeneralSkillDirection = other.GeneralSkillDirection;
			}
			nextSkillList_.Add(other.nextSkillList_);
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
			case 18u:
				TargetResIDList = input.ReadString();
				break;
			case 24u:
				CanUseInGroupAIAttack = (EGSYesNo)input.ReadEnum();
				break;
			case 34u:
				CanUseInGroupAIBuffConditions = input.ReadString();
				break;
			case 40u:
				AttackBias = (EGroupAIAttackBias)input.ReadEnum();
				break;
			case 53u:
				PreferRangeMin = input.ReadFloat();
				break;
			case 61u:
				PreferRangeMax = input.ReadFloat();
				break;
			case 69u:
				PreferHeightDis = input.ReadFloat();
				break;
			case 77u:
				OptimalDisMin = input.ReadFloat();
				break;
			case 85u:
				OptimalDisMax = input.ReadFloat();
				break;
			case 88u:
				OptimalDisAddScore = input.ReadInt32();
				break;
			case 96u:
				CoolDownAddtion = input.ReadInt32();
				break;
			case 104u:
				CoolDownAdditionMax = input.ReadInt32();
				break;
			case 112u:
				AngleScoreSector0To45 = input.ReadInt32();
				break;
			case 120u:
				AngleScoreSector45To90 = input.ReadInt32();
				break;
			case 128u:
				AngleScoreSector90To135 = input.ReadInt32();
				break;
			case 136u:
				AngleScoreSector135To180 = input.ReadInt32();
				break;
			case 144u:
				AngleScoreSector180ToNeg135 = input.ReadInt32();
				break;
			case 152u:
				AngleScoreSectorNeg135ToNeg90 = input.ReadInt32();
				break;
			case 160u:
				AngleScoreSectorNeg90ToNeg45 = input.ReadInt32();
				break;
			case 168u:
				AngleScoreSectorNeg45To0 = input.ReadInt32();
				break;
			case 176u:
				GeneralSkillDirection = input.ReadInt32();
				break;
			case 184u:
			case 186u:
				nextSkillList_.AddEntriesFrom(input, _repeated_nextSkillList_codec);
				break;
			case 194u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
