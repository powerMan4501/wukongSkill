using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStProjectileMoveDesc : IMessage<FUStProjectileMoveDesc>, IMessage, IEquatable<FUStProjectileMoveDesc>, IDeepCloneable<FUStProjectileMoveDesc>
{
	private static readonly MessageParser<FUStProjectileMoveDesc> _parser = new MessageParser<FUStProjectileMoveDesc>(() => new FUStProjectileMoveDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EBulletOrMagicFieldMoveModeType projectileMoveModeType_;

	private EProjectileObjSpdType projectileSpdType_;

	private float projectileFlyTime_;

	private static readonly FieldCodec<int> _repeated_projectileMoveModeIntParam_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> projectileMoveModeIntParam_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_projectileMoveModeFloatParam_codec = FieldCodec.ForFloat(50u);

	private readonly RepeatedField<float> projectileMoveModeFloatParam_ = new RepeatedField<float>();

	private static readonly FieldCodec<EGSYesNo> _repeated_projectileMoveModeYoNParam_codec = FieldCodec.ForEnum(58u, (EGSYesNo x) => (int)x, (int x) => (EGSYesNo)x);

	private readonly RepeatedField<EGSYesNo> projectileMoveModeYoNParam_ = new RepeatedField<EGSYesNo>();

	private static readonly FieldCodec<string> _repeated_projectileMoveModeStrParam_codec = FieldCodec.ForString(66u);

	private readonly RepeatedField<string> projectileMoveModeStrParam_ = new RepeatedField<string>();

	private EGSYesNo moveClampToLand_;

	private EGSYesNo moveAlignToLand_;

	private string guard_ = "";

	public static MessageParser<FUStProjectileMoveDesc> Parser => _parser;

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

	public EBulletOrMagicFieldMoveModeType ProjectileMoveModeType
	{
		get
		{
			return projectileMoveModeType_;
		}
		set
		{
			projectileMoveModeType_ = value;
		}
	}

	public EProjectileObjSpdType ProjectileSpdType
	{
		get
		{
			return projectileSpdType_;
		}
		set
		{
			projectileSpdType_ = value;
		}
	}

	public float ProjectileFlyTime
	{
		get
		{
			return projectileFlyTime_;
		}
		set
		{
			projectileFlyTime_ = value;
		}
	}

	public RepeatedField<int> ProjectileMoveModeIntParam => projectileMoveModeIntParam_;

	public RepeatedField<float> ProjectileMoveModeFloatParam => projectileMoveModeFloatParam_;

	public RepeatedField<EGSYesNo> ProjectileMoveModeYoNParam => projectileMoveModeYoNParam_;

	public RepeatedField<string> ProjectileMoveModeStrParam => projectileMoveModeStrParam_;

	public EGSYesNo MoveClampToLand
	{
		get
		{
			return moveClampToLand_;
		}
		set
		{
			moveClampToLand_ = value;
		}
	}

	public EGSYesNo MoveAlignToLand
	{
		get
		{
			return moveAlignToLand_;
		}
		set
		{
			moveAlignToLand_ = value;
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

	public FUStProjectileMoveDesc()
	{
	}

	public FUStProjectileMoveDesc(FUStProjectileMoveDesc other)
		: this()
	{
		iD_ = other.iD_;
		projectileMoveModeType_ = other.projectileMoveModeType_;
		projectileSpdType_ = other.projectileSpdType_;
		projectileFlyTime_ = other.projectileFlyTime_;
		projectileMoveModeIntParam_ = other.projectileMoveModeIntParam_.Clone();
		projectileMoveModeFloatParam_ = other.projectileMoveModeFloatParam_.Clone();
		projectileMoveModeYoNParam_ = other.projectileMoveModeYoNParam_.Clone();
		projectileMoveModeStrParam_ = other.projectileMoveModeStrParam_.Clone();
		moveClampToLand_ = other.moveClampToLand_;
		moveAlignToLand_ = other.moveAlignToLand_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStProjectileMoveDesc Clone()
	{
		return new FUStProjectileMoveDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStProjectileMoveDesc);
	}

	public bool Equals(FUStProjectileMoveDesc other)
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
		if (ProjectileMoveModeType != other.ProjectileMoveModeType)
		{
			return false;
		}
		if (ProjectileSpdType != other.ProjectileSpdType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ProjectileFlyTime, other.ProjectileFlyTime))
		{
			return false;
		}
		if (!projectileMoveModeIntParam_.Equals(other.projectileMoveModeIntParam_))
		{
			return false;
		}
		if (!projectileMoveModeFloatParam_.Equals(other.projectileMoveModeFloatParam_))
		{
			return false;
		}
		if (!projectileMoveModeYoNParam_.Equals(other.projectileMoveModeYoNParam_))
		{
			return false;
		}
		if (!projectileMoveModeStrParam_.Equals(other.projectileMoveModeStrParam_))
		{
			return false;
		}
		if (MoveClampToLand != other.MoveClampToLand)
		{
			return false;
		}
		if (MoveAlignToLand != other.MoveAlignToLand)
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
		if (ProjectileMoveModeType != EBulletOrMagicFieldMoveModeType.None)
		{
			num ^= ProjectileMoveModeType.GetHashCode();
		}
		if (ProjectileSpdType != EProjectileObjSpdType.None)
		{
			num ^= ProjectileSpdType.GetHashCode();
		}
		if (ProjectileFlyTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ProjectileFlyTime);
		}
		num ^= projectileMoveModeIntParam_.GetHashCode();
		num ^= projectileMoveModeFloatParam_.GetHashCode();
		num ^= projectileMoveModeYoNParam_.GetHashCode();
		num ^= projectileMoveModeStrParam_.GetHashCode();
		if (MoveClampToLand != EGSYesNo.No)
		{
			num ^= MoveClampToLand.GetHashCode();
		}
		if (MoveAlignToLand != EGSYesNo.No)
		{
			num ^= MoveAlignToLand.GetHashCode();
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
		if (ProjectileMoveModeType != EBulletOrMagicFieldMoveModeType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ProjectileMoveModeType);
		}
		if (ProjectileSpdType != EProjectileObjSpdType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ProjectileSpdType);
		}
		if (ProjectileFlyTime != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(ProjectileFlyTime);
		}
		projectileMoveModeIntParam_.WriteTo(output, _repeated_projectileMoveModeIntParam_codec);
		projectileMoveModeFloatParam_.WriteTo(output, _repeated_projectileMoveModeFloatParam_codec);
		projectileMoveModeYoNParam_.WriteTo(output, _repeated_projectileMoveModeYoNParam_codec);
		projectileMoveModeStrParam_.WriteTo(output, _repeated_projectileMoveModeStrParam_codec);
		if (MoveClampToLand != EGSYesNo.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)MoveClampToLand);
		}
		if (MoveAlignToLand != EGSYesNo.No)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)MoveAlignToLand);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(90);
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
		if (ProjectileMoveModeType != EBulletOrMagicFieldMoveModeType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ProjectileMoveModeType);
		}
		if (ProjectileSpdType != EProjectileObjSpdType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ProjectileSpdType);
		}
		if (ProjectileFlyTime != 0f)
		{
			num += 5;
		}
		num += projectileMoveModeIntParam_.CalculateSize(_repeated_projectileMoveModeIntParam_codec);
		num += projectileMoveModeFloatParam_.CalculateSize(_repeated_projectileMoveModeFloatParam_codec);
		num += projectileMoveModeYoNParam_.CalculateSize(_repeated_projectileMoveModeYoNParam_codec);
		num += projectileMoveModeStrParam_.CalculateSize(_repeated_projectileMoveModeStrParam_codec);
		if (MoveClampToLand != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MoveClampToLand);
		}
		if (MoveAlignToLand != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MoveAlignToLand);
		}
		if (Guard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStProjectileMoveDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ProjectileMoveModeType != EBulletOrMagicFieldMoveModeType.None)
			{
				ProjectileMoveModeType = other.ProjectileMoveModeType;
			}
			if (other.ProjectileSpdType != EProjectileObjSpdType.None)
			{
				ProjectileSpdType = other.ProjectileSpdType;
			}
			if (other.ProjectileFlyTime != 0f)
			{
				ProjectileFlyTime = other.ProjectileFlyTime;
			}
			projectileMoveModeIntParam_.Add(other.projectileMoveModeIntParam_);
			projectileMoveModeFloatParam_.Add(other.projectileMoveModeFloatParam_);
			projectileMoveModeYoNParam_.Add(other.projectileMoveModeYoNParam_);
			projectileMoveModeStrParam_.Add(other.projectileMoveModeStrParam_);
			if (other.MoveClampToLand != EGSYesNo.No)
			{
				MoveClampToLand = other.MoveClampToLand;
			}
			if (other.MoveAlignToLand != EGSYesNo.No)
			{
				MoveAlignToLand = other.MoveAlignToLand;
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
				ProjectileMoveModeType = (EBulletOrMagicFieldMoveModeType)input.ReadEnum();
				break;
			case 24u:
				ProjectileSpdType = (EProjectileObjSpdType)input.ReadEnum();
				break;
			case 37u:
				ProjectileFlyTime = input.ReadFloat();
				break;
			case 40u:
			case 42u:
				projectileMoveModeIntParam_.AddEntriesFrom(input, _repeated_projectileMoveModeIntParam_codec);
				break;
			case 50u:
			case 53u:
				projectileMoveModeFloatParam_.AddEntriesFrom(input, _repeated_projectileMoveModeFloatParam_codec);
				break;
			case 56u:
			case 58u:
				projectileMoveModeYoNParam_.AddEntriesFrom(input, _repeated_projectileMoveModeYoNParam_codec);
				break;
			case 66u:
				projectileMoveModeStrParam_.AddEntriesFrom(input, _repeated_projectileMoveModeStrParam_codec);
				break;
			case 72u:
				MoveClampToLand = (EGSYesNo)input.ReadEnum();
				break;
			case 80u:
				MoveAlignToLand = (EGSYesNo)input.ReadEnum();
				break;
			case 90u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
