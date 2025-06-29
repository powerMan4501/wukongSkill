using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStQTEDesc : IMessage<FUStQTEDesc>, IMessage, IEquatable<FUStQTEDesc>, IDeepCloneable<FUStQTEDesc>
{
	private static readonly MessageParser<FUStQTEDesc> _parser = new MessageParser<FUStQTEDesc>(() => new FUStQTEDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int targetResID_;

	private int firstSkillID_;

	private int secondSkillID_;

	private string targetMontage_ = "";

	private float firstSyncPlayerSpeed_;

	private EGSQTESyncType secondSyncType_;

	private float secondSyncPlayerSpeed_;

	private float secondSyncPlayerRotateSpeed_;

	private float secondSyncPlayerStartTime_;

	private float secondSyncEnemySpeed_;

	private float secondSyncEnemyRotateSpeed_;

	private float secondSyncEnemyStartTime_;

	private EGSYesNo isSyncFixedZ_;

	public static MessageParser<FUStQTEDesc> Parser => _parser;

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

	public int TargetResID
	{
		get
		{
			return targetResID_;
		}
		set
		{
			targetResID_ = value;
		}
	}

	public int FirstSkillID
	{
		get
		{
			return firstSkillID_;
		}
		set
		{
			firstSkillID_ = value;
		}
	}

	public int SecondSkillID
	{
		get
		{
			return secondSkillID_;
		}
		set
		{
			secondSkillID_ = value;
		}
	}

	public string TargetMontage
	{
		get
		{
			return targetMontage_;
		}
		set
		{
			targetMontage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float FirstSyncPlayerSpeed
	{
		get
		{
			return firstSyncPlayerSpeed_;
		}
		set
		{
			firstSyncPlayerSpeed_ = value;
		}
	}

	public EGSQTESyncType SecondSyncType
	{
		get
		{
			return secondSyncType_;
		}
		set
		{
			secondSyncType_ = value;
		}
	}

	public float SecondSyncPlayerSpeed
	{
		get
		{
			return secondSyncPlayerSpeed_;
		}
		set
		{
			secondSyncPlayerSpeed_ = value;
		}
	}

	public float SecondSyncPlayerRotateSpeed
	{
		get
		{
			return secondSyncPlayerRotateSpeed_;
		}
		set
		{
			secondSyncPlayerRotateSpeed_ = value;
		}
	}

	public float SecondSyncPlayerStartTime
	{
		get
		{
			return secondSyncPlayerStartTime_;
		}
		set
		{
			secondSyncPlayerStartTime_ = value;
		}
	}

	public float SecondSyncEnemySpeed
	{
		get
		{
			return secondSyncEnemySpeed_;
		}
		set
		{
			secondSyncEnemySpeed_ = value;
		}
	}

	public float SecondSyncEnemyRotateSpeed
	{
		get
		{
			return secondSyncEnemyRotateSpeed_;
		}
		set
		{
			secondSyncEnemyRotateSpeed_ = value;
		}
	}

	public float SecondSyncEnemyStartTime
	{
		get
		{
			return secondSyncEnemyStartTime_;
		}
		set
		{
			secondSyncEnemyStartTime_ = value;
		}
	}

	public EGSYesNo IsSyncFixedZ
	{
		get
		{
			return isSyncFixedZ_;
		}
		set
		{
			isSyncFixedZ_ = value;
		}
	}

	public FUStQTEDesc()
	{
	}

	public FUStQTEDesc(FUStQTEDesc other)
		: this()
	{
		iD_ = other.iD_;
		targetResID_ = other.targetResID_;
		firstSkillID_ = other.firstSkillID_;
		secondSkillID_ = other.secondSkillID_;
		targetMontage_ = other.targetMontage_;
		firstSyncPlayerSpeed_ = other.firstSyncPlayerSpeed_;
		secondSyncType_ = other.secondSyncType_;
		secondSyncPlayerSpeed_ = other.secondSyncPlayerSpeed_;
		secondSyncPlayerRotateSpeed_ = other.secondSyncPlayerRotateSpeed_;
		secondSyncPlayerStartTime_ = other.secondSyncPlayerStartTime_;
		secondSyncEnemySpeed_ = other.secondSyncEnemySpeed_;
		secondSyncEnemyRotateSpeed_ = other.secondSyncEnemyRotateSpeed_;
		secondSyncEnemyStartTime_ = other.secondSyncEnemyStartTime_;
		isSyncFixedZ_ = other.isSyncFixedZ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStQTEDesc Clone()
	{
		return new FUStQTEDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStQTEDesc);
	}

	public bool Equals(FUStQTEDesc other)
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
		if (TargetResID != other.TargetResID)
		{
			return false;
		}
		if (FirstSkillID != other.FirstSkillID)
		{
			return false;
		}
		if (SecondSkillID != other.SecondSkillID)
		{
			return false;
		}
		if (TargetMontage != other.TargetMontage)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FirstSyncPlayerSpeed, other.FirstSyncPlayerSpeed))
		{
			return false;
		}
		if (SecondSyncType != other.SecondSyncType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SecondSyncPlayerSpeed, other.SecondSyncPlayerSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SecondSyncPlayerRotateSpeed, other.SecondSyncPlayerRotateSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SecondSyncPlayerStartTime, other.SecondSyncPlayerStartTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SecondSyncEnemySpeed, other.SecondSyncEnemySpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SecondSyncEnemyRotateSpeed, other.SecondSyncEnemyRotateSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SecondSyncEnemyStartTime, other.SecondSyncEnemyStartTime))
		{
			return false;
		}
		if (IsSyncFixedZ != other.IsSyncFixedZ)
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
		if (TargetResID != 0)
		{
			num ^= TargetResID.GetHashCode();
		}
		if (FirstSkillID != 0)
		{
			num ^= FirstSkillID.GetHashCode();
		}
		if (SecondSkillID != 0)
		{
			num ^= SecondSkillID.GetHashCode();
		}
		if (TargetMontage.Length != 0)
		{
			num ^= TargetMontage.GetHashCode();
		}
		if (FirstSyncPlayerSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FirstSyncPlayerSpeed);
		}
		if (SecondSyncType != EGSQTESyncType.None)
		{
			num ^= SecondSyncType.GetHashCode();
		}
		if (SecondSyncPlayerSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SecondSyncPlayerSpeed);
		}
		if (SecondSyncPlayerRotateSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SecondSyncPlayerRotateSpeed);
		}
		if (SecondSyncPlayerStartTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SecondSyncPlayerStartTime);
		}
		if (SecondSyncEnemySpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SecondSyncEnemySpeed);
		}
		if (SecondSyncEnemyRotateSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SecondSyncEnemyRotateSpeed);
		}
		if (SecondSyncEnemyStartTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SecondSyncEnemyStartTime);
		}
		if (IsSyncFixedZ != EGSYesNo.No)
		{
			num ^= IsSyncFixedZ.GetHashCode();
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
		if (TargetResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TargetResID);
		}
		if (FirstSkillID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(FirstSkillID);
		}
		if (SecondSkillID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SecondSkillID);
		}
		if (TargetMontage.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(TargetMontage);
		}
		if (FirstSyncPlayerSpeed != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(FirstSyncPlayerSpeed);
		}
		if (SecondSyncType != EGSQTESyncType.None)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)SecondSyncType);
		}
		if (SecondSyncPlayerSpeed != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(SecondSyncPlayerSpeed);
		}
		if (SecondSyncPlayerRotateSpeed != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(SecondSyncPlayerRotateSpeed);
		}
		if (SecondSyncPlayerStartTime != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(SecondSyncPlayerStartTime);
		}
		if (SecondSyncEnemySpeed != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(SecondSyncEnemySpeed);
		}
		if (SecondSyncEnemyRotateSpeed != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(SecondSyncEnemyRotateSpeed);
		}
		if (SecondSyncEnemyStartTime != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(SecondSyncEnemyStartTime);
		}
		if (IsSyncFixedZ != EGSYesNo.No)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)IsSyncFixedZ);
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
		if (TargetResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetResID);
		}
		if (FirstSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FirstSkillID);
		}
		if (SecondSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SecondSkillID);
		}
		if (TargetMontage.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TargetMontage);
		}
		if (FirstSyncPlayerSpeed != 0f)
		{
			num += 5;
		}
		if (SecondSyncType != EGSQTESyncType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SecondSyncType);
		}
		if (SecondSyncPlayerSpeed != 0f)
		{
			num += 5;
		}
		if (SecondSyncPlayerRotateSpeed != 0f)
		{
			num += 5;
		}
		if (SecondSyncPlayerStartTime != 0f)
		{
			num += 5;
		}
		if (SecondSyncEnemySpeed != 0f)
		{
			num += 5;
		}
		if (SecondSyncEnemyRotateSpeed != 0f)
		{
			num += 5;
		}
		if (SecondSyncEnemyStartTime != 0f)
		{
			num += 5;
		}
		if (IsSyncFixedZ != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsSyncFixedZ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStQTEDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.TargetResID != 0)
			{
				TargetResID = other.TargetResID;
			}
			if (other.FirstSkillID != 0)
			{
				FirstSkillID = other.FirstSkillID;
			}
			if (other.SecondSkillID != 0)
			{
				SecondSkillID = other.SecondSkillID;
			}
			if (other.TargetMontage.Length != 0)
			{
				TargetMontage = other.TargetMontage;
			}
			if (other.FirstSyncPlayerSpeed != 0f)
			{
				FirstSyncPlayerSpeed = other.FirstSyncPlayerSpeed;
			}
			if (other.SecondSyncType != EGSQTESyncType.None)
			{
				SecondSyncType = other.SecondSyncType;
			}
			if (other.SecondSyncPlayerSpeed != 0f)
			{
				SecondSyncPlayerSpeed = other.SecondSyncPlayerSpeed;
			}
			if (other.SecondSyncPlayerRotateSpeed != 0f)
			{
				SecondSyncPlayerRotateSpeed = other.SecondSyncPlayerRotateSpeed;
			}
			if (other.SecondSyncPlayerStartTime != 0f)
			{
				SecondSyncPlayerStartTime = other.SecondSyncPlayerStartTime;
			}
			if (other.SecondSyncEnemySpeed != 0f)
			{
				SecondSyncEnemySpeed = other.SecondSyncEnemySpeed;
			}
			if (other.SecondSyncEnemyRotateSpeed != 0f)
			{
				SecondSyncEnemyRotateSpeed = other.SecondSyncEnemyRotateSpeed;
			}
			if (other.SecondSyncEnemyStartTime != 0f)
			{
				SecondSyncEnemyStartTime = other.SecondSyncEnemyStartTime;
			}
			if (other.IsSyncFixedZ != EGSYesNo.No)
			{
				IsSyncFixedZ = other.IsSyncFixedZ;
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
				TargetResID = input.ReadInt32();
				break;
			case 24u:
				FirstSkillID = input.ReadInt32();
				break;
			case 32u:
				SecondSkillID = input.ReadInt32();
				break;
			case 42u:
				TargetMontage = input.ReadString();
				break;
			case 53u:
				FirstSyncPlayerSpeed = input.ReadFloat();
				break;
			case 56u:
				SecondSyncType = (EGSQTESyncType)input.ReadEnum();
				break;
			case 69u:
				SecondSyncPlayerSpeed = input.ReadFloat();
				break;
			case 77u:
				SecondSyncPlayerRotateSpeed = input.ReadFloat();
				break;
			case 85u:
				SecondSyncPlayerStartTime = input.ReadFloat();
				break;
			case 93u:
				SecondSyncEnemySpeed = input.ReadFloat();
				break;
			case 101u:
				SecondSyncEnemyRotateSpeed = input.ReadFloat();
				break;
			case 109u:
				SecondSyncEnemyStartTime = input.ReadFloat();
				break;
			case 112u:
				IsSyncFixedZ = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
