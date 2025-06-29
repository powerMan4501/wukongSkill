using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBulletExpandDesc : IMessage<FUStBulletExpandDesc>, IMessage, IEquatable<FUStBulletExpandDesc>, IDeepCloneable<FUStBulletExpandDesc>
{
	private static readonly MessageParser<FUStBulletExpandDesc> _parser = new MessageParser<FUStBulletExpandDesc>(() => new FUStBulletExpandDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo bulletIsForMerge_;

	private EGSYesNo bulletIsMergeChild_;

	private string bulletMergeTag_ = "";

	private static readonly FieldCodec<int> _repeated_lifeOverEffectID_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> lifeOverEffectID_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_hitChrEffectsforSelf_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> hitChrEffectsforSelf_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_hitProjectileEffectsforSelf_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> hitProjectileEffectsforSelf_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_hitItemEffectsforSelf_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> hitItemEffectsforSelf_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_hitEffectsforChr_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> hitEffectsforChr_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_hitEffectsforProjectile_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> hitEffectsforProjectile_ = new RepeatedField<int>();

	private EHitDestructibleStrengthType hitDestructibleStrengthType_;

	private EHitDestructibleDirType hitDestructibleDirectionType_;

	private static readonly FieldCodec<FUStDelayTriggerEffects> _repeated_delayTriggerEffects_codec = FieldCodec.ForMessage(106u, FUStDelayTriggerEffects.Parser);

	private readonly RepeatedField<FUStDelayTriggerEffects> delayTriggerEffects_ = new RepeatedField<FUStDelayTriggerEffects>();

	private static readonly FieldCodec<int> _repeated_hitDestructibleEffectsforSelf_codec = FieldCodec.ForInt32(114u);

	private readonly RepeatedField<int> hitDestructibleEffectsforSelf_ = new RepeatedField<int>();

	private float bulletSweepCheckGap_;

	private float bulletSweepCheckDelayTime_;

	private EGSYesNo bulletIsOnlyHitTarget_;

	private EGSYesNo bulletCanThroughBlockage_;

	private EGSYesNo isLaserType_;

	private float laserMaxLength_;

	private float laserLengthSpeed_;

	private string laserLengthSpeedCurvePath_ = "";

	private string guard_ = "";

	public static MessageParser<FUStBulletExpandDesc> Parser => _parser;

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

	public EGSYesNo BulletIsForMerge
	{
		get
		{
			return bulletIsForMerge_;
		}
		set
		{
			bulletIsForMerge_ = value;
		}
	}

	public EGSYesNo BulletIsMergeChild
	{
		get
		{
			return bulletIsMergeChild_;
		}
		set
		{
			bulletIsMergeChild_ = value;
		}
	}

	public string BulletMergeTag
	{
		get
		{
			return bulletMergeTag_;
		}
		set
		{
			bulletMergeTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> LifeOverEffectID => lifeOverEffectID_;

	public RepeatedField<int> HitChrEffectsforSelf => hitChrEffectsforSelf_;

	public RepeatedField<int> HitProjectileEffectsforSelf => hitProjectileEffectsforSelf_;

	public RepeatedField<int> HitItemEffectsforSelf => hitItemEffectsforSelf_;

	public RepeatedField<int> HitEffectsforChr => hitEffectsforChr_;

	public RepeatedField<int> HitEffectsforProjectile => hitEffectsforProjectile_;

	public EHitDestructibleStrengthType HitDestructibleStrengthType
	{
		get
		{
			return hitDestructibleStrengthType_;
		}
		set
		{
			hitDestructibleStrengthType_ = value;
		}
	}

	public EHitDestructibleDirType HitDestructibleDirectionType
	{
		get
		{
			return hitDestructibleDirectionType_;
		}
		set
		{
			hitDestructibleDirectionType_ = value;
		}
	}

	public RepeatedField<FUStDelayTriggerEffects> DelayTriggerEffects => delayTriggerEffects_;

	public RepeatedField<int> HitDestructibleEffectsforSelf => hitDestructibleEffectsforSelf_;

	public float BulletSweepCheckGap
	{
		get
		{
			return bulletSweepCheckGap_;
		}
		set
		{
			bulletSweepCheckGap_ = value;
		}
	}

	public float BulletSweepCheckDelayTime
	{
		get
		{
			return bulletSweepCheckDelayTime_;
		}
		set
		{
			bulletSweepCheckDelayTime_ = value;
		}
	}

	public EGSYesNo BulletIsOnlyHitTarget
	{
		get
		{
			return bulletIsOnlyHitTarget_;
		}
		set
		{
			bulletIsOnlyHitTarget_ = value;
		}
	}

	public EGSYesNo BulletCanThroughBlockage
	{
		get
		{
			return bulletCanThroughBlockage_;
		}
		set
		{
			bulletCanThroughBlockage_ = value;
		}
	}

	public EGSYesNo IsLaserType
	{
		get
		{
			return isLaserType_;
		}
		set
		{
			isLaserType_ = value;
		}
	}

	public float LaserMaxLength
	{
		get
		{
			return laserMaxLength_;
		}
		set
		{
			laserMaxLength_ = value;
		}
	}

	public float LaserLengthSpeed
	{
		get
		{
			return laserLengthSpeed_;
		}
		set
		{
			laserLengthSpeed_ = value;
		}
	}

	public string LaserLengthSpeedCurvePath
	{
		get
		{
			return laserLengthSpeedCurvePath_;
		}
		set
		{
			laserLengthSpeedCurvePath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public FUStBulletExpandDesc()
	{
	}

	public FUStBulletExpandDesc(FUStBulletExpandDesc other)
		: this()
	{
		iD_ = other.iD_;
		bulletIsForMerge_ = other.bulletIsForMerge_;
		bulletIsMergeChild_ = other.bulletIsMergeChild_;
		bulletMergeTag_ = other.bulletMergeTag_;
		lifeOverEffectID_ = other.lifeOverEffectID_.Clone();
		hitChrEffectsforSelf_ = other.hitChrEffectsforSelf_.Clone();
		hitProjectileEffectsforSelf_ = other.hitProjectileEffectsforSelf_.Clone();
		hitItemEffectsforSelf_ = other.hitItemEffectsforSelf_.Clone();
		hitEffectsforChr_ = other.hitEffectsforChr_.Clone();
		hitEffectsforProjectile_ = other.hitEffectsforProjectile_.Clone();
		hitDestructibleStrengthType_ = other.hitDestructibleStrengthType_;
		hitDestructibleDirectionType_ = other.hitDestructibleDirectionType_;
		delayTriggerEffects_ = other.delayTriggerEffects_.Clone();
		hitDestructibleEffectsforSelf_ = other.hitDestructibleEffectsforSelf_.Clone();
		bulletSweepCheckGap_ = other.bulletSweepCheckGap_;
		bulletSweepCheckDelayTime_ = other.bulletSweepCheckDelayTime_;
		bulletIsOnlyHitTarget_ = other.bulletIsOnlyHitTarget_;
		bulletCanThroughBlockage_ = other.bulletCanThroughBlockage_;
		isLaserType_ = other.isLaserType_;
		laserMaxLength_ = other.laserMaxLength_;
		laserLengthSpeed_ = other.laserLengthSpeed_;
		laserLengthSpeedCurvePath_ = other.laserLengthSpeedCurvePath_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBulletExpandDesc Clone()
	{
		return new FUStBulletExpandDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBulletExpandDesc);
	}

	public bool Equals(FUStBulletExpandDesc other)
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
		if (BulletIsForMerge != other.BulletIsForMerge)
		{
			return false;
		}
		if (BulletIsMergeChild != other.BulletIsMergeChild)
		{
			return false;
		}
		if (BulletMergeTag != other.BulletMergeTag)
		{
			return false;
		}
		if (!lifeOverEffectID_.Equals(other.lifeOverEffectID_))
		{
			return false;
		}
		if (!hitChrEffectsforSelf_.Equals(other.hitChrEffectsforSelf_))
		{
			return false;
		}
		if (!hitProjectileEffectsforSelf_.Equals(other.hitProjectileEffectsforSelf_))
		{
			return false;
		}
		if (!hitItemEffectsforSelf_.Equals(other.hitItemEffectsforSelf_))
		{
			return false;
		}
		if (!hitEffectsforChr_.Equals(other.hitEffectsforChr_))
		{
			return false;
		}
		if (!hitEffectsforProjectile_.Equals(other.hitEffectsforProjectile_))
		{
			return false;
		}
		if (HitDestructibleStrengthType != other.HitDestructibleStrengthType)
		{
			return false;
		}
		if (HitDestructibleDirectionType != other.HitDestructibleDirectionType)
		{
			return false;
		}
		if (!delayTriggerEffects_.Equals(other.delayTriggerEffects_))
		{
			return false;
		}
		if (!hitDestructibleEffectsforSelf_.Equals(other.hitDestructibleEffectsforSelf_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletSweepCheckGap, other.BulletSweepCheckGap))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletSweepCheckDelayTime, other.BulletSweepCheckDelayTime))
		{
			return false;
		}
		if (BulletIsOnlyHitTarget != other.BulletIsOnlyHitTarget)
		{
			return false;
		}
		if (BulletCanThroughBlockage != other.BulletCanThroughBlockage)
		{
			return false;
		}
		if (IsLaserType != other.IsLaserType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LaserMaxLength, other.LaserMaxLength))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LaserLengthSpeed, other.LaserLengthSpeed))
		{
			return false;
		}
		if (LaserLengthSpeedCurvePath != other.LaserLengthSpeedCurvePath)
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
		if (BulletIsForMerge != EGSYesNo.No)
		{
			num ^= BulletIsForMerge.GetHashCode();
		}
		if (BulletIsMergeChild != EGSYesNo.No)
		{
			num ^= BulletIsMergeChild.GetHashCode();
		}
		if (BulletMergeTag.Length != 0)
		{
			num ^= BulletMergeTag.GetHashCode();
		}
		num ^= lifeOverEffectID_.GetHashCode();
		num ^= hitChrEffectsforSelf_.GetHashCode();
		num ^= hitProjectileEffectsforSelf_.GetHashCode();
		num ^= hitItemEffectsforSelf_.GetHashCode();
		num ^= hitEffectsforChr_.GetHashCode();
		num ^= hitEffectsforProjectile_.GetHashCode();
		if (HitDestructibleStrengthType != EHitDestructibleStrengthType.None)
		{
			num ^= HitDestructibleStrengthType.GetHashCode();
		}
		if (HitDestructibleDirectionType != EHitDestructibleDirType.DestructibleDirection)
		{
			num ^= HitDestructibleDirectionType.GetHashCode();
		}
		num ^= delayTriggerEffects_.GetHashCode();
		num ^= hitDestructibleEffectsforSelf_.GetHashCode();
		if (BulletSweepCheckGap != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletSweepCheckGap);
		}
		if (BulletSweepCheckDelayTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletSweepCheckDelayTime);
		}
		if (BulletIsOnlyHitTarget != EGSYesNo.No)
		{
			num ^= BulletIsOnlyHitTarget.GetHashCode();
		}
		if (BulletCanThroughBlockage != EGSYesNo.No)
		{
			num ^= BulletCanThroughBlockage.GetHashCode();
		}
		if (IsLaserType != EGSYesNo.No)
		{
			num ^= IsLaserType.GetHashCode();
		}
		if (LaserMaxLength != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LaserMaxLength);
		}
		if (LaserLengthSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LaserLengthSpeed);
		}
		if (LaserLengthSpeedCurvePath.Length != 0)
		{
			num ^= LaserLengthSpeedCurvePath.GetHashCode();
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
		if (BulletIsForMerge != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)BulletIsForMerge);
		}
		if (BulletIsMergeChild != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)BulletIsMergeChild);
		}
		if (BulletMergeTag.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(BulletMergeTag);
		}
		lifeOverEffectID_.WriteTo(output, _repeated_lifeOverEffectID_codec);
		hitChrEffectsforSelf_.WriteTo(output, _repeated_hitChrEffectsforSelf_codec);
		hitProjectileEffectsforSelf_.WriteTo(output, _repeated_hitProjectileEffectsforSelf_codec);
		hitItemEffectsforSelf_.WriteTo(output, _repeated_hitItemEffectsforSelf_codec);
		hitEffectsforChr_.WriteTo(output, _repeated_hitEffectsforChr_codec);
		hitEffectsforProjectile_.WriteTo(output, _repeated_hitEffectsforProjectile_codec);
		if (HitDestructibleStrengthType != EHitDestructibleStrengthType.None)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)HitDestructibleStrengthType);
		}
		if (HitDestructibleDirectionType != EHitDestructibleDirType.DestructibleDirection)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)HitDestructibleDirectionType);
		}
		delayTriggerEffects_.WriteTo(output, _repeated_delayTriggerEffects_codec);
		hitDestructibleEffectsforSelf_.WriteTo(output, _repeated_hitDestructibleEffectsforSelf_codec);
		if (BulletSweepCheckGap != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(BulletSweepCheckGap);
		}
		if (BulletSweepCheckDelayTime != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(BulletSweepCheckDelayTime);
		}
		if (BulletIsOnlyHitTarget != EGSYesNo.No)
		{
			output.WriteRawTag(136, 1);
			output.WriteEnum((int)BulletIsOnlyHitTarget);
		}
		if (BulletCanThroughBlockage != EGSYesNo.No)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)BulletCanThroughBlockage);
		}
		if (IsLaserType != EGSYesNo.No)
		{
			output.WriteRawTag(152, 1);
			output.WriteEnum((int)IsLaserType);
		}
		if (LaserMaxLength != 0f)
		{
			output.WriteRawTag(165, 1);
			output.WriteFloat(LaserMaxLength);
		}
		if (LaserLengthSpeed != 0f)
		{
			output.WriteRawTag(173, 1);
			output.WriteFloat(LaserLengthSpeed);
		}
		if (LaserLengthSpeedCurvePath.Length != 0)
		{
			output.WriteRawTag(178, 1);
			output.WriteString(LaserLengthSpeedCurvePath);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(186, 1);
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
		if (BulletIsForMerge != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BulletIsForMerge);
		}
		if (BulletIsMergeChild != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BulletIsMergeChild);
		}
		if (BulletMergeTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BulletMergeTag);
		}
		num += lifeOverEffectID_.CalculateSize(_repeated_lifeOverEffectID_codec);
		num += hitChrEffectsforSelf_.CalculateSize(_repeated_hitChrEffectsforSelf_codec);
		num += hitProjectileEffectsforSelf_.CalculateSize(_repeated_hitProjectileEffectsforSelf_codec);
		num += hitItemEffectsforSelf_.CalculateSize(_repeated_hitItemEffectsforSelf_codec);
		num += hitEffectsforChr_.CalculateSize(_repeated_hitEffectsforChr_codec);
		num += hitEffectsforProjectile_.CalculateSize(_repeated_hitEffectsforProjectile_codec);
		if (HitDestructibleStrengthType != EHitDestructibleStrengthType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitDestructibleStrengthType);
		}
		if (HitDestructibleDirectionType != EHitDestructibleDirType.DestructibleDirection)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HitDestructibleDirectionType);
		}
		num += delayTriggerEffects_.CalculateSize(_repeated_delayTriggerEffects_codec);
		num += hitDestructibleEffectsforSelf_.CalculateSize(_repeated_hitDestructibleEffectsforSelf_codec);
		if (BulletSweepCheckGap != 0f)
		{
			num += 5;
		}
		if (BulletSweepCheckDelayTime != 0f)
		{
			num += 6;
		}
		if (BulletIsOnlyHitTarget != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BulletIsOnlyHitTarget);
		}
		if (BulletCanThroughBlockage != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BulletCanThroughBlockage);
		}
		if (IsLaserType != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsLaserType);
		}
		if (LaserMaxLength != 0f)
		{
			num += 6;
		}
		if (LaserLengthSpeed != 0f)
		{
			num += 6;
		}
		if (LaserLengthSpeedCurvePath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LaserLengthSpeedCurvePath);
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

	public void MergeFrom(FUStBulletExpandDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BulletIsForMerge != EGSYesNo.No)
			{
				BulletIsForMerge = other.BulletIsForMerge;
			}
			if (other.BulletIsMergeChild != EGSYesNo.No)
			{
				BulletIsMergeChild = other.BulletIsMergeChild;
			}
			if (other.BulletMergeTag.Length != 0)
			{
				BulletMergeTag = other.BulletMergeTag;
			}
			lifeOverEffectID_.Add(other.lifeOverEffectID_);
			hitChrEffectsforSelf_.Add(other.hitChrEffectsforSelf_);
			hitProjectileEffectsforSelf_.Add(other.hitProjectileEffectsforSelf_);
			hitItemEffectsforSelf_.Add(other.hitItemEffectsforSelf_);
			hitEffectsforChr_.Add(other.hitEffectsforChr_);
			hitEffectsforProjectile_.Add(other.hitEffectsforProjectile_);
			if (other.HitDestructibleStrengthType != EHitDestructibleStrengthType.None)
			{
				HitDestructibleStrengthType = other.HitDestructibleStrengthType;
			}
			if (other.HitDestructibleDirectionType != EHitDestructibleDirType.DestructibleDirection)
			{
				HitDestructibleDirectionType = other.HitDestructibleDirectionType;
			}
			delayTriggerEffects_.Add(other.delayTriggerEffects_);
			hitDestructibleEffectsforSelf_.Add(other.hitDestructibleEffectsforSelf_);
			if (other.BulletSweepCheckGap != 0f)
			{
				BulletSweepCheckGap = other.BulletSweepCheckGap;
			}
			if (other.BulletSweepCheckDelayTime != 0f)
			{
				BulletSweepCheckDelayTime = other.BulletSweepCheckDelayTime;
			}
			if (other.BulletIsOnlyHitTarget != EGSYesNo.No)
			{
				BulletIsOnlyHitTarget = other.BulletIsOnlyHitTarget;
			}
			if (other.BulletCanThroughBlockage != EGSYesNo.No)
			{
				BulletCanThroughBlockage = other.BulletCanThroughBlockage;
			}
			if (other.IsLaserType != EGSYesNo.No)
			{
				IsLaserType = other.IsLaserType;
			}
			if (other.LaserMaxLength != 0f)
			{
				LaserMaxLength = other.LaserMaxLength;
			}
			if (other.LaserLengthSpeed != 0f)
			{
				LaserLengthSpeed = other.LaserLengthSpeed;
			}
			if (other.LaserLengthSpeedCurvePath.Length != 0)
			{
				LaserLengthSpeedCurvePath = other.LaserLengthSpeedCurvePath;
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
				BulletIsForMerge = (EGSYesNo)input.ReadEnum();
				break;
			case 24u:
				BulletIsMergeChild = (EGSYesNo)input.ReadEnum();
				break;
			case 34u:
				BulletMergeTag = input.ReadString();
				break;
			case 40u:
			case 42u:
				lifeOverEffectID_.AddEntriesFrom(input, _repeated_lifeOverEffectID_codec);
				break;
			case 48u:
			case 50u:
				hitChrEffectsforSelf_.AddEntriesFrom(input, _repeated_hitChrEffectsforSelf_codec);
				break;
			case 56u:
			case 58u:
				hitProjectileEffectsforSelf_.AddEntriesFrom(input, _repeated_hitProjectileEffectsforSelf_codec);
				break;
			case 64u:
			case 66u:
				hitItemEffectsforSelf_.AddEntriesFrom(input, _repeated_hitItemEffectsforSelf_codec);
				break;
			case 72u:
			case 74u:
				hitEffectsforChr_.AddEntriesFrom(input, _repeated_hitEffectsforChr_codec);
				break;
			case 80u:
			case 82u:
				hitEffectsforProjectile_.AddEntriesFrom(input, _repeated_hitEffectsforProjectile_codec);
				break;
			case 88u:
				HitDestructibleStrengthType = (EHitDestructibleStrengthType)input.ReadEnum();
				break;
			case 96u:
				HitDestructibleDirectionType = (EHitDestructibleDirType)input.ReadEnum();
				break;
			case 106u:
				delayTriggerEffects_.AddEntriesFrom(input, _repeated_delayTriggerEffects_codec);
				break;
			case 112u:
			case 114u:
				hitDestructibleEffectsforSelf_.AddEntriesFrom(input, _repeated_hitDestructibleEffectsforSelf_codec);
				break;
			case 125u:
				BulletSweepCheckGap = input.ReadFloat();
				break;
			case 133u:
				BulletSweepCheckDelayTime = input.ReadFloat();
				break;
			case 136u:
				BulletIsOnlyHitTarget = (EGSYesNo)input.ReadEnum();
				break;
			case 144u:
				BulletCanThroughBlockage = (EGSYesNo)input.ReadEnum();
				break;
			case 152u:
				IsLaserType = (EGSYesNo)input.ReadEnum();
				break;
			case 165u:
				LaserMaxLength = input.ReadFloat();
				break;
			case 173u:
				LaserLengthSpeed = input.ReadFloat();
				break;
			case 178u:
				LaserLengthSpeedCurvePath = input.ReadString();
				break;
			case 186u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
