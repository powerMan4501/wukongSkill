using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStUnitTransCommDesc : IMessage<FUStUnitTransCommDesc>, IMessage, IEquatable<FUStUnitTransCommDesc>, IDeepCloneable<FUStUnitTransCommDesc>
{
	private static readonly MessageParser<FUStUnitTransCommDesc> _parser = new MessageParser<FUStUnitTransCommDesc>(() => new FUStUnitTransCommDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string bPPath_ = "";

	private string tamerPath_ = "";

	private EGSYesNo isInheritBuffInSpawnNew_;

	private int unitBornSkillID_;

	private int newUnitBornSkillID_;

	private float unitSpawnScale_;

	private float newUnitSpawnScale_;

	private EGSYesNo isUseEQS_;

	private string unitSpawnLocationOffset_ = "";

	private string newUnitSpawnLocationOffset_ = "";

	private float possessBlendTime_;

	private int possessBlendFunc_;

	private float possessBlendExp_;

	public static MessageParser<FUStUnitTransCommDesc> Parser => _parser;

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

	public string BPPath
	{
		get
		{
			return bPPath_;
		}
		set
		{
			bPPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string TamerPath
	{
		get
		{
			return tamerPath_;
		}
		set
		{
			tamerPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo IsInheritBuffInSpawnNew
	{
		get
		{
			return isInheritBuffInSpawnNew_;
		}
		set
		{
			isInheritBuffInSpawnNew_ = value;
		}
	}

	public int UnitBornSkillID
	{
		get
		{
			return unitBornSkillID_;
		}
		set
		{
			unitBornSkillID_ = value;
		}
	}

	public int NewUnitBornSkillID
	{
		get
		{
			return newUnitBornSkillID_;
		}
		set
		{
			newUnitBornSkillID_ = value;
		}
	}

	public float UnitSpawnScale
	{
		get
		{
			return unitSpawnScale_;
		}
		set
		{
			unitSpawnScale_ = value;
		}
	}

	public float NewUnitSpawnScale
	{
		get
		{
			return newUnitSpawnScale_;
		}
		set
		{
			newUnitSpawnScale_ = value;
		}
	}

	public EGSYesNo IsUseEQS
	{
		get
		{
			return isUseEQS_;
		}
		set
		{
			isUseEQS_ = value;
		}
	}

	public string UnitSpawnLocationOffset
	{
		get
		{
			return unitSpawnLocationOffset_;
		}
		set
		{
			unitSpawnLocationOffset_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NewUnitSpawnLocationOffset
	{
		get
		{
			return newUnitSpawnLocationOffset_;
		}
		set
		{
			newUnitSpawnLocationOffset_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float PossessBlendTime
	{
		get
		{
			return possessBlendTime_;
		}
		set
		{
			possessBlendTime_ = value;
		}
	}

	public int PossessBlendFunc
	{
		get
		{
			return possessBlendFunc_;
		}
		set
		{
			possessBlendFunc_ = value;
		}
	}

	public float PossessBlendExp
	{
		get
		{
			return possessBlendExp_;
		}
		set
		{
			possessBlendExp_ = value;
		}
	}

	public FUStUnitTransCommDesc()
	{
	}

	public FUStUnitTransCommDesc(FUStUnitTransCommDesc other)
		: this()
	{
		iD_ = other.iD_;
		bPPath_ = other.bPPath_;
		tamerPath_ = other.tamerPath_;
		isInheritBuffInSpawnNew_ = other.isInheritBuffInSpawnNew_;
		unitBornSkillID_ = other.unitBornSkillID_;
		newUnitBornSkillID_ = other.newUnitBornSkillID_;
		unitSpawnScale_ = other.unitSpawnScale_;
		newUnitSpawnScale_ = other.newUnitSpawnScale_;
		isUseEQS_ = other.isUseEQS_;
		unitSpawnLocationOffset_ = other.unitSpawnLocationOffset_;
		newUnitSpawnLocationOffset_ = other.newUnitSpawnLocationOffset_;
		possessBlendTime_ = other.possessBlendTime_;
		possessBlendFunc_ = other.possessBlendFunc_;
		possessBlendExp_ = other.possessBlendExp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitTransCommDesc Clone()
	{
		return new FUStUnitTransCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitTransCommDesc);
	}

	public bool Equals(FUStUnitTransCommDesc other)
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
		if (BPPath != other.BPPath)
		{
			return false;
		}
		if (TamerPath != other.TamerPath)
		{
			return false;
		}
		if (IsInheritBuffInSpawnNew != other.IsInheritBuffInSpawnNew)
		{
			return false;
		}
		if (UnitBornSkillID != other.UnitBornSkillID)
		{
			return false;
		}
		if (NewUnitBornSkillID != other.NewUnitBornSkillID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(UnitSpawnScale, other.UnitSpawnScale))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(NewUnitSpawnScale, other.NewUnitSpawnScale))
		{
			return false;
		}
		if (IsUseEQS != other.IsUseEQS)
		{
			return false;
		}
		if (UnitSpawnLocationOffset != other.UnitSpawnLocationOffset)
		{
			return false;
		}
		if (NewUnitSpawnLocationOffset != other.NewUnitSpawnLocationOffset)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PossessBlendTime, other.PossessBlendTime))
		{
			return false;
		}
		if (PossessBlendFunc != other.PossessBlendFunc)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PossessBlendExp, other.PossessBlendExp))
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
		if (BPPath.Length != 0)
		{
			num ^= BPPath.GetHashCode();
		}
		if (TamerPath.Length != 0)
		{
			num ^= TamerPath.GetHashCode();
		}
		if (IsInheritBuffInSpawnNew != EGSYesNo.No)
		{
			num ^= IsInheritBuffInSpawnNew.GetHashCode();
		}
		if (UnitBornSkillID != 0)
		{
			num ^= UnitBornSkillID.GetHashCode();
		}
		if (NewUnitBornSkillID != 0)
		{
			num ^= NewUnitBornSkillID.GetHashCode();
		}
		if (UnitSpawnScale != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(UnitSpawnScale);
		}
		if (NewUnitSpawnScale != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(NewUnitSpawnScale);
		}
		if (IsUseEQS != EGSYesNo.No)
		{
			num ^= IsUseEQS.GetHashCode();
		}
		if (UnitSpawnLocationOffset.Length != 0)
		{
			num ^= UnitSpawnLocationOffset.GetHashCode();
		}
		if (NewUnitSpawnLocationOffset.Length != 0)
		{
			num ^= NewUnitSpawnLocationOffset.GetHashCode();
		}
		if (PossessBlendTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PossessBlendTime);
		}
		if (PossessBlendFunc != 0)
		{
			num ^= PossessBlendFunc.GetHashCode();
		}
		if (PossessBlendExp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PossessBlendExp);
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
		if (BPPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BPPath);
		}
		if (TamerPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TamerPath);
		}
		if (IsInheritBuffInSpawnNew != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)IsInheritBuffInSpawnNew);
		}
		if (UnitBornSkillID != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(UnitBornSkillID);
		}
		if (NewUnitBornSkillID != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(NewUnitBornSkillID);
		}
		if (UnitSpawnScale != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(UnitSpawnScale);
		}
		if (NewUnitSpawnScale != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(NewUnitSpawnScale);
		}
		if (IsUseEQS != EGSYesNo.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)IsUseEQS);
		}
		if (UnitSpawnLocationOffset.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(UnitSpawnLocationOffset);
		}
		if (NewUnitSpawnLocationOffset.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(NewUnitSpawnLocationOffset);
		}
		if (PossessBlendTime != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(PossessBlendTime);
		}
		if (PossessBlendFunc != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(PossessBlendFunc);
		}
		if (PossessBlendExp != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(PossessBlendExp);
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
		if (BPPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BPPath);
		}
		if (TamerPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TamerPath);
		}
		if (IsInheritBuffInSpawnNew != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsInheritBuffInSpawnNew);
		}
		if (UnitBornSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitBornSkillID);
		}
		if (NewUnitBornSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NewUnitBornSkillID);
		}
		if (UnitSpawnScale != 0f)
		{
			num += 5;
		}
		if (NewUnitSpawnScale != 0f)
		{
			num += 5;
		}
		if (IsUseEQS != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsUseEQS);
		}
		if (UnitSpawnLocationOffset.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitSpawnLocationOffset);
		}
		if (NewUnitSpawnLocationOffset.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NewUnitSpawnLocationOffset);
		}
		if (PossessBlendTime != 0f)
		{
			num += 5;
		}
		if (PossessBlendFunc != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PossessBlendFunc);
		}
		if (PossessBlendExp != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitTransCommDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BPPath.Length != 0)
			{
				BPPath = other.BPPath;
			}
			if (other.TamerPath.Length != 0)
			{
				TamerPath = other.TamerPath;
			}
			if (other.IsInheritBuffInSpawnNew != EGSYesNo.No)
			{
				IsInheritBuffInSpawnNew = other.IsInheritBuffInSpawnNew;
			}
			if (other.UnitBornSkillID != 0)
			{
				UnitBornSkillID = other.UnitBornSkillID;
			}
			if (other.NewUnitBornSkillID != 0)
			{
				NewUnitBornSkillID = other.NewUnitBornSkillID;
			}
			if (other.UnitSpawnScale != 0f)
			{
				UnitSpawnScale = other.UnitSpawnScale;
			}
			if (other.NewUnitSpawnScale != 0f)
			{
				NewUnitSpawnScale = other.NewUnitSpawnScale;
			}
			if (other.IsUseEQS != EGSYesNo.No)
			{
				IsUseEQS = other.IsUseEQS;
			}
			if (other.UnitSpawnLocationOffset.Length != 0)
			{
				UnitSpawnLocationOffset = other.UnitSpawnLocationOffset;
			}
			if (other.NewUnitSpawnLocationOffset.Length != 0)
			{
				NewUnitSpawnLocationOffset = other.NewUnitSpawnLocationOffset;
			}
			if (other.PossessBlendTime != 0f)
			{
				PossessBlendTime = other.PossessBlendTime;
			}
			if (other.PossessBlendFunc != 0)
			{
				PossessBlendFunc = other.PossessBlendFunc;
			}
			if (other.PossessBlendExp != 0f)
			{
				PossessBlendExp = other.PossessBlendExp;
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
				BPPath = input.ReadString();
				break;
			case 26u:
				TamerPath = input.ReadString();
				break;
			case 32u:
				IsInheritBuffInSpawnNew = (EGSYesNo)input.ReadEnum();
				break;
			case 40u:
				UnitBornSkillID = input.ReadInt32();
				break;
			case 48u:
				NewUnitBornSkillID = input.ReadInt32();
				break;
			case 61u:
				UnitSpawnScale = input.ReadFloat();
				break;
			case 69u:
				NewUnitSpawnScale = input.ReadFloat();
				break;
			case 72u:
				IsUseEQS = (EGSYesNo)input.ReadEnum();
				break;
			case 82u:
				UnitSpawnLocationOffset = input.ReadString();
				break;
			case 90u:
				NewUnitSpawnLocationOffset = input.ReadString();
				break;
			case 101u:
				PossessBlendTime = input.ReadFloat();
				break;
			case 104u:
				PossessBlendFunc = input.ReadInt32();
				break;
			case 117u:
				PossessBlendExp = input.ReadFloat();
				break;
			}
		}
	}
}
