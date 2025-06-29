using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitDeadOldDesc : IMessage<FUStUnitDeadOldDesc>, IMessage, IEquatable<FUStUnitDeadOldDesc>, IDeepCloneable<FUStUnitDeadOldDesc>
{
	private static readonly MessageParser<FUStUnitDeadOldDesc> _parser = new MessageParser<FUStUnitDeadOldDesc>(() => new FUStUnitDeadOldDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int unitResID_;

	private ESkillDamageType skillDamageType_;

	private string defaultDeadMontagePath_ = "";

	private string deadMontagePathLightFront_ = "";

	private string deadMontagePathLightLeft_ = "";

	private string deadMontagePathLightRight_ = "";

	private string deadMontagePathLightBehind_ = "";

	private string deadMontagePathHeavyFront_ = "";

	private string deadMontagePathHeavyLeft_ = "";

	private string deadMontagePathHeavyRight_ = "";

	private string deadMontagePathHeavyBehind_ = "";

	private string deadMontagePathFlyFront_ = "";

	private string deadMontagePathFlyLeft_ = "";

	private string deadMontagePathFlyRight_ = "";

	private string deadMontagePathFlyBehind_ = "";

	private string deadMontagePathCut_ = "";

	private string deadMontagePathSuicide_ = "";

	private string guard_ = "";

	public static MessageParser<FUStUnitDeadOldDesc> Parser => _parser;

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

	public int UnitResID
	{
		get
		{
			return unitResID_;
		}
		set
		{
			unitResID_ = value;
		}
	}

	public ESkillDamageType SkillDamageType
	{
		get
		{
			return skillDamageType_;
		}
		set
		{
			skillDamageType_ = value;
		}
	}

	public string DefaultDeadMontagePath
	{
		get
		{
			return defaultDeadMontagePath_;
		}
		set
		{
			defaultDeadMontagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathLightFront
	{
		get
		{
			return deadMontagePathLightFront_;
		}
		set
		{
			deadMontagePathLightFront_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathLightLeft
	{
		get
		{
			return deadMontagePathLightLeft_;
		}
		set
		{
			deadMontagePathLightLeft_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathLightRight
	{
		get
		{
			return deadMontagePathLightRight_;
		}
		set
		{
			deadMontagePathLightRight_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathLightBehind
	{
		get
		{
			return deadMontagePathLightBehind_;
		}
		set
		{
			deadMontagePathLightBehind_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathHeavyFront
	{
		get
		{
			return deadMontagePathHeavyFront_;
		}
		set
		{
			deadMontagePathHeavyFront_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathHeavyLeft
	{
		get
		{
			return deadMontagePathHeavyLeft_;
		}
		set
		{
			deadMontagePathHeavyLeft_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathHeavyRight
	{
		get
		{
			return deadMontagePathHeavyRight_;
		}
		set
		{
			deadMontagePathHeavyRight_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathHeavyBehind
	{
		get
		{
			return deadMontagePathHeavyBehind_;
		}
		set
		{
			deadMontagePathHeavyBehind_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathFlyFront
	{
		get
		{
			return deadMontagePathFlyFront_;
		}
		set
		{
			deadMontagePathFlyFront_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathFlyLeft
	{
		get
		{
			return deadMontagePathFlyLeft_;
		}
		set
		{
			deadMontagePathFlyLeft_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathFlyRight
	{
		get
		{
			return deadMontagePathFlyRight_;
		}
		set
		{
			deadMontagePathFlyRight_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathFlyBehind
	{
		get
		{
			return deadMontagePathFlyBehind_;
		}
		set
		{
			deadMontagePathFlyBehind_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathCut
	{
		get
		{
			return deadMontagePathCut_;
		}
		set
		{
			deadMontagePathCut_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadMontagePathSuicide
	{
		get
		{
			return deadMontagePathSuicide_;
		}
		set
		{
			deadMontagePathSuicide_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public FUStUnitDeadOldDesc()
	{
	}

	public FUStUnitDeadOldDesc(FUStUnitDeadOldDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitResID_ = other.unitResID_;
		skillDamageType_ = other.skillDamageType_;
		defaultDeadMontagePath_ = other.defaultDeadMontagePath_;
		deadMontagePathLightFront_ = other.deadMontagePathLightFront_;
		deadMontagePathLightLeft_ = other.deadMontagePathLightLeft_;
		deadMontagePathLightRight_ = other.deadMontagePathLightRight_;
		deadMontagePathLightBehind_ = other.deadMontagePathLightBehind_;
		deadMontagePathHeavyFront_ = other.deadMontagePathHeavyFront_;
		deadMontagePathHeavyLeft_ = other.deadMontagePathHeavyLeft_;
		deadMontagePathHeavyRight_ = other.deadMontagePathHeavyRight_;
		deadMontagePathHeavyBehind_ = other.deadMontagePathHeavyBehind_;
		deadMontagePathFlyFront_ = other.deadMontagePathFlyFront_;
		deadMontagePathFlyLeft_ = other.deadMontagePathFlyLeft_;
		deadMontagePathFlyRight_ = other.deadMontagePathFlyRight_;
		deadMontagePathFlyBehind_ = other.deadMontagePathFlyBehind_;
		deadMontagePathCut_ = other.deadMontagePathCut_;
		deadMontagePathSuicide_ = other.deadMontagePathSuicide_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitDeadOldDesc Clone()
	{
		return new FUStUnitDeadOldDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitDeadOldDesc);
	}

	public bool Equals(FUStUnitDeadOldDesc other)
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
		if (UnitResID != other.UnitResID)
		{
			return false;
		}
		if (SkillDamageType != other.SkillDamageType)
		{
			return false;
		}
		if (DefaultDeadMontagePath != other.DefaultDeadMontagePath)
		{
			return false;
		}
		if (DeadMontagePathLightFront != other.DeadMontagePathLightFront)
		{
			return false;
		}
		if (DeadMontagePathLightLeft != other.DeadMontagePathLightLeft)
		{
			return false;
		}
		if (DeadMontagePathLightRight != other.DeadMontagePathLightRight)
		{
			return false;
		}
		if (DeadMontagePathLightBehind != other.DeadMontagePathLightBehind)
		{
			return false;
		}
		if (DeadMontagePathHeavyFront != other.DeadMontagePathHeavyFront)
		{
			return false;
		}
		if (DeadMontagePathHeavyLeft != other.DeadMontagePathHeavyLeft)
		{
			return false;
		}
		if (DeadMontagePathHeavyRight != other.DeadMontagePathHeavyRight)
		{
			return false;
		}
		if (DeadMontagePathHeavyBehind != other.DeadMontagePathHeavyBehind)
		{
			return false;
		}
		if (DeadMontagePathFlyFront != other.DeadMontagePathFlyFront)
		{
			return false;
		}
		if (DeadMontagePathFlyLeft != other.DeadMontagePathFlyLeft)
		{
			return false;
		}
		if (DeadMontagePathFlyRight != other.DeadMontagePathFlyRight)
		{
			return false;
		}
		if (DeadMontagePathFlyBehind != other.DeadMontagePathFlyBehind)
		{
			return false;
		}
		if (DeadMontagePathCut != other.DeadMontagePathCut)
		{
			return false;
		}
		if (DeadMontagePathSuicide != other.DeadMontagePathSuicide)
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
		if (UnitResID != 0)
		{
			num ^= UnitResID.GetHashCode();
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			num ^= SkillDamageType.GetHashCode();
		}
		if (DefaultDeadMontagePath.Length != 0)
		{
			num ^= DefaultDeadMontagePath.GetHashCode();
		}
		if (DeadMontagePathLightFront.Length != 0)
		{
			num ^= DeadMontagePathLightFront.GetHashCode();
		}
		if (DeadMontagePathLightLeft.Length != 0)
		{
			num ^= DeadMontagePathLightLeft.GetHashCode();
		}
		if (DeadMontagePathLightRight.Length != 0)
		{
			num ^= DeadMontagePathLightRight.GetHashCode();
		}
		if (DeadMontagePathLightBehind.Length != 0)
		{
			num ^= DeadMontagePathLightBehind.GetHashCode();
		}
		if (DeadMontagePathHeavyFront.Length != 0)
		{
			num ^= DeadMontagePathHeavyFront.GetHashCode();
		}
		if (DeadMontagePathHeavyLeft.Length != 0)
		{
			num ^= DeadMontagePathHeavyLeft.GetHashCode();
		}
		if (DeadMontagePathHeavyRight.Length != 0)
		{
			num ^= DeadMontagePathHeavyRight.GetHashCode();
		}
		if (DeadMontagePathHeavyBehind.Length != 0)
		{
			num ^= DeadMontagePathHeavyBehind.GetHashCode();
		}
		if (DeadMontagePathFlyFront.Length != 0)
		{
			num ^= DeadMontagePathFlyFront.GetHashCode();
		}
		if (DeadMontagePathFlyLeft.Length != 0)
		{
			num ^= DeadMontagePathFlyLeft.GetHashCode();
		}
		if (DeadMontagePathFlyRight.Length != 0)
		{
			num ^= DeadMontagePathFlyRight.GetHashCode();
		}
		if (DeadMontagePathFlyBehind.Length != 0)
		{
			num ^= DeadMontagePathFlyBehind.GetHashCode();
		}
		if (DeadMontagePathCut.Length != 0)
		{
			num ^= DeadMontagePathCut.GetHashCode();
		}
		if (DeadMontagePathSuicide.Length != 0)
		{
			num ^= DeadMontagePathSuicide.GetHashCode();
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
		if (UnitResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UnitResID);
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)SkillDamageType);
		}
		if (DefaultDeadMontagePath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DefaultDeadMontagePath);
		}
		if (DeadMontagePathLightFront.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(DeadMontagePathLightFront);
		}
		if (DeadMontagePathLightLeft.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(DeadMontagePathLightLeft);
		}
		if (DeadMontagePathLightRight.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(DeadMontagePathLightRight);
		}
		if (DeadMontagePathLightBehind.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(DeadMontagePathLightBehind);
		}
		if (DeadMontagePathHeavyFront.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(DeadMontagePathHeavyFront);
		}
		if (DeadMontagePathHeavyLeft.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(DeadMontagePathHeavyLeft);
		}
		if (DeadMontagePathHeavyRight.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(DeadMontagePathHeavyRight);
		}
		if (DeadMontagePathHeavyBehind.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(DeadMontagePathHeavyBehind);
		}
		if (DeadMontagePathFlyFront.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(DeadMontagePathFlyFront);
		}
		if (DeadMontagePathFlyLeft.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(DeadMontagePathFlyLeft);
		}
		if (DeadMontagePathFlyRight.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(DeadMontagePathFlyRight);
		}
		if (DeadMontagePathFlyBehind.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(DeadMontagePathFlyBehind);
		}
		if (DeadMontagePathCut.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(DeadMontagePathCut);
		}
		if (DeadMontagePathSuicide.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(DeadMontagePathSuicide);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(154, 1);
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
		if (UnitResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitResID);
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkillDamageType);
		}
		if (DefaultDeadMontagePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DefaultDeadMontagePath);
		}
		if (DeadMontagePathLightFront.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathLightFront);
		}
		if (DeadMontagePathLightLeft.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathLightLeft);
		}
		if (DeadMontagePathLightRight.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathLightRight);
		}
		if (DeadMontagePathLightBehind.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathLightBehind);
		}
		if (DeadMontagePathHeavyFront.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathHeavyFront);
		}
		if (DeadMontagePathHeavyLeft.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathHeavyLeft);
		}
		if (DeadMontagePathHeavyRight.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathHeavyRight);
		}
		if (DeadMontagePathHeavyBehind.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathHeavyBehind);
		}
		if (DeadMontagePathFlyFront.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathFlyFront);
		}
		if (DeadMontagePathFlyLeft.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathFlyLeft);
		}
		if (DeadMontagePathFlyRight.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadMontagePathFlyRight);
		}
		if (DeadMontagePathFlyBehind.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(DeadMontagePathFlyBehind);
		}
		if (DeadMontagePathCut.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(DeadMontagePathCut);
		}
		if (DeadMontagePathSuicide.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(DeadMontagePathSuicide);
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

	public void MergeFrom(FUStUnitDeadOldDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitResID != 0)
			{
				UnitResID = other.UnitResID;
			}
			if (other.SkillDamageType != ESkillDamageType.NoneEffectAtk)
			{
				SkillDamageType = other.SkillDamageType;
			}
			if (other.DefaultDeadMontagePath.Length != 0)
			{
				DefaultDeadMontagePath = other.DefaultDeadMontagePath;
			}
			if (other.DeadMontagePathLightFront.Length != 0)
			{
				DeadMontagePathLightFront = other.DeadMontagePathLightFront;
			}
			if (other.DeadMontagePathLightLeft.Length != 0)
			{
				DeadMontagePathLightLeft = other.DeadMontagePathLightLeft;
			}
			if (other.DeadMontagePathLightRight.Length != 0)
			{
				DeadMontagePathLightRight = other.DeadMontagePathLightRight;
			}
			if (other.DeadMontagePathLightBehind.Length != 0)
			{
				DeadMontagePathLightBehind = other.DeadMontagePathLightBehind;
			}
			if (other.DeadMontagePathHeavyFront.Length != 0)
			{
				DeadMontagePathHeavyFront = other.DeadMontagePathHeavyFront;
			}
			if (other.DeadMontagePathHeavyLeft.Length != 0)
			{
				DeadMontagePathHeavyLeft = other.DeadMontagePathHeavyLeft;
			}
			if (other.DeadMontagePathHeavyRight.Length != 0)
			{
				DeadMontagePathHeavyRight = other.DeadMontagePathHeavyRight;
			}
			if (other.DeadMontagePathHeavyBehind.Length != 0)
			{
				DeadMontagePathHeavyBehind = other.DeadMontagePathHeavyBehind;
			}
			if (other.DeadMontagePathFlyFront.Length != 0)
			{
				DeadMontagePathFlyFront = other.DeadMontagePathFlyFront;
			}
			if (other.DeadMontagePathFlyLeft.Length != 0)
			{
				DeadMontagePathFlyLeft = other.DeadMontagePathFlyLeft;
			}
			if (other.DeadMontagePathFlyRight.Length != 0)
			{
				DeadMontagePathFlyRight = other.DeadMontagePathFlyRight;
			}
			if (other.DeadMontagePathFlyBehind.Length != 0)
			{
				DeadMontagePathFlyBehind = other.DeadMontagePathFlyBehind;
			}
			if (other.DeadMontagePathCut.Length != 0)
			{
				DeadMontagePathCut = other.DeadMontagePathCut;
			}
			if (other.DeadMontagePathSuicide.Length != 0)
			{
				DeadMontagePathSuicide = other.DeadMontagePathSuicide;
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
				UnitResID = input.ReadInt32();
				break;
			case 24u:
				SkillDamageType = (ESkillDamageType)input.ReadEnum();
				break;
			case 34u:
				DefaultDeadMontagePath = input.ReadString();
				break;
			case 42u:
				DeadMontagePathLightFront = input.ReadString();
				break;
			case 50u:
				DeadMontagePathLightLeft = input.ReadString();
				break;
			case 58u:
				DeadMontagePathLightRight = input.ReadString();
				break;
			case 66u:
				DeadMontagePathLightBehind = input.ReadString();
				break;
			case 74u:
				DeadMontagePathHeavyFront = input.ReadString();
				break;
			case 82u:
				DeadMontagePathHeavyLeft = input.ReadString();
				break;
			case 90u:
				DeadMontagePathHeavyRight = input.ReadString();
				break;
			case 98u:
				DeadMontagePathHeavyBehind = input.ReadString();
				break;
			case 106u:
				DeadMontagePathFlyFront = input.ReadString();
				break;
			case 114u:
				DeadMontagePathFlyLeft = input.ReadString();
				break;
			case 122u:
				DeadMontagePathFlyRight = input.ReadString();
				break;
			case 130u:
				DeadMontagePathFlyBehind = input.ReadString();
				break;
			case 138u:
				DeadMontagePathCut = input.ReadString();
				break;
			case 146u:
				DeadMontagePathSuicide = input.ReadString();
				break;
			case 154u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
