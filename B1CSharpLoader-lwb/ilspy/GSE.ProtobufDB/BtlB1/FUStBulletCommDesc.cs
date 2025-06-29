using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBulletCommDesc : IMessage<FUStBulletCommDesc>, IMessage, IEquatable<FUStBulletCommDesc>, IDeepCloneable<FUStBulletCommDesc>
{
	private static readonly MessageParser<FUStBulletCommDesc> _parser = new MessageParser<FUStBulletCommDesc>(() => new FUStBulletCommDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string bulletBPTemplatePath_ = "";

	private EGSYesNo bulletIsFresh_;

	private EGSYesNo bulletIsForMerge_;

	private EGSYesNo bulletIsMergeChild_;

	private string bulletMergeTag_ = "";

	private EGSYesNo bulletIsFacingTarget_;

	private EBGUBulletType bulletType_;

	private float bulletTypeParam_;

	private float bulletDelayDestroyTime_;

	private float bulletLifeTime_;

	private float bulletLifeSpeed_;

	private static readonly FieldCodec<int> _repeated_lifeOverEffectID_codec = FieldCodec.ForInt32(106u);

	private readonly RepeatedField<int> lifeOverEffectID_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_hitUnitEffectsforSelf_codec = FieldCodec.ForInt32(114u);

	private readonly RepeatedField<int> hitUnitEffectsforSelf_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_hitItemEffectsforSelf_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> hitItemEffectsforSelf_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_hitEffectsforActor_codec = FieldCodec.ForInt32(130u);

	private readonly RepeatedField<int> hitEffectsforActor_ = new RepeatedField<int>();

	private EBGUBulletSweepCheckType bulletSweepCheckType_;

	private float bulletSweepCheckGap_;

	private float bulletSweepCheckDelayTime_;

	private EGSYesNo bulletIsOnlyHitTarget_;

	private EGSYesNo bulletCanThroughBlockage_;

	private string bulletAnimPath_ = "";

	private EBulletOrMagicFieldMoveModeType bulletMoveModeType_;

	private EProjectileObjSpdType bulletSpdType_;

	private float bulletFlyTime_;

	private int bulletEQSID_;

	private static readonly FieldCodec<int> _repeated_bulletMoveModeIntParam_codec = FieldCodec.ForInt32(218u);

	private readonly RepeatedField<int> bulletMoveModeIntParam_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_bulletMoveModeFloatParam_codec = FieldCodec.ForFloat(226u);

	private readonly RepeatedField<float> bulletMoveModeFloatParam_ = new RepeatedField<float>();

	private static readonly FieldCodec<EGSYesNo> _repeated_bulletMoveModeYoNParam_codec = FieldCodec.ForEnum(234u, (EGSYesNo x) => (int)x, (int x) => (EGSYesNo)x);

	private readonly RepeatedField<EGSYesNo> bulletMoveModeYoNParam_ = new RepeatedField<EGSYesNo>();

	private static readonly FieldCodec<string> _repeated_bulletMoveModeStrParam_codec = FieldCodec.ForString(242u);

	private readonly RepeatedField<string> bulletMoveModeStrParam_ = new RepeatedField<string>();

	private float bulletPStoSpawnInterval_;

	private float bulletLowestSpdCanPlayPS_;

	private int beHitedBulletSwitchID_;

	private string fXDestroyImmediatelyTag_ = "";

	private string beHitedBulletPostAKPath_ = "";

	private EGSYesNo bulletFXUseDBC_;

	private string bulletSpawnPSPath_ = "";

	private string bulletSelfSpawnDBCPath_ = "";

	private string bulletHitItemPSPath_ = "";

	private string bulletHitUnitPSPath_ = "";

	private string bulletLifeOverPSPath_ = "";

	private string beHitedBulletPlayFXPath_ = "";

	private EGSYesNo isLaserType_;

	private float laserMaxLength_;

	private int bulletNumLimit_;

	private string guard_ = "";

	public static MessageParser<FUStBulletCommDesc> Parser => _parser;

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

	public string BulletBPTemplatePath
	{
		get
		{
			return bulletBPTemplatePath_;
		}
		set
		{
			bulletBPTemplatePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo BulletIsFresh
	{
		get
		{
			return bulletIsFresh_;
		}
		set
		{
			bulletIsFresh_ = value;
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

	public EGSYesNo BulletIsFacingTarget
	{
		get
		{
			return bulletIsFacingTarget_;
		}
		set
		{
			bulletIsFacingTarget_ = value;
		}
	}

	public EBGUBulletType BulletType
	{
		get
		{
			return bulletType_;
		}
		set
		{
			bulletType_ = value;
		}
	}

	public float BulletTypeParam
	{
		get
		{
			return bulletTypeParam_;
		}
		set
		{
			bulletTypeParam_ = value;
		}
	}

	public float BulletDelayDestroyTime
	{
		get
		{
			return bulletDelayDestroyTime_;
		}
		set
		{
			bulletDelayDestroyTime_ = value;
		}
	}

	public float BulletLifeTime
	{
		get
		{
			return bulletLifeTime_;
		}
		set
		{
			bulletLifeTime_ = value;
		}
	}

	public float BulletLifeSpeed
	{
		get
		{
			return bulletLifeSpeed_;
		}
		set
		{
			bulletLifeSpeed_ = value;
		}
	}

	public RepeatedField<int> LifeOverEffectID => lifeOverEffectID_;

	public RepeatedField<int> HitUnitEffectsforSelf => hitUnitEffectsforSelf_;

	public RepeatedField<int> HitItemEffectsforSelf => hitItemEffectsforSelf_;

	public RepeatedField<int> HitEffectsforActor => hitEffectsforActor_;

	public EBGUBulletSweepCheckType BulletSweepCheckType
	{
		get
		{
			return bulletSweepCheckType_;
		}
		set
		{
			bulletSweepCheckType_ = value;
		}
	}

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

	public string BulletAnimPath
	{
		get
		{
			return bulletAnimPath_;
		}
		set
		{
			bulletAnimPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EBulletOrMagicFieldMoveModeType BulletMoveModeType
	{
		get
		{
			return bulletMoveModeType_;
		}
		set
		{
			bulletMoveModeType_ = value;
		}
	}

	public EProjectileObjSpdType BulletSpdType
	{
		get
		{
			return bulletSpdType_;
		}
		set
		{
			bulletSpdType_ = value;
		}
	}

	public float BulletFlyTime
	{
		get
		{
			return bulletFlyTime_;
		}
		set
		{
			bulletFlyTime_ = value;
		}
	}

	public int BulletEQSID
	{
		get
		{
			return bulletEQSID_;
		}
		set
		{
			bulletEQSID_ = value;
		}
	}

	public RepeatedField<int> BulletMoveModeIntParam => bulletMoveModeIntParam_;

	public RepeatedField<float> BulletMoveModeFloatParam => bulletMoveModeFloatParam_;

	public RepeatedField<EGSYesNo> BulletMoveModeYoNParam => bulletMoveModeYoNParam_;

	public RepeatedField<string> BulletMoveModeStrParam => bulletMoveModeStrParam_;

	public float BulletPStoSpawnInterval
	{
		get
		{
			return bulletPStoSpawnInterval_;
		}
		set
		{
			bulletPStoSpawnInterval_ = value;
		}
	}

	public float BulletLowestSpdCanPlayPS
	{
		get
		{
			return bulletLowestSpdCanPlayPS_;
		}
		set
		{
			bulletLowestSpdCanPlayPS_ = value;
		}
	}

	public int BeHitedBulletSwitchID
	{
		get
		{
			return beHitedBulletSwitchID_;
		}
		set
		{
			beHitedBulletSwitchID_ = value;
		}
	}

	public string FXDestroyImmediatelyTag
	{
		get
		{
			return fXDestroyImmediatelyTag_;
		}
		set
		{
			fXDestroyImmediatelyTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BeHitedBulletPostAKPath
	{
		get
		{
			return beHitedBulletPostAKPath_;
		}
		set
		{
			beHitedBulletPostAKPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo BulletFXUseDBC
	{
		get
		{
			return bulletFXUseDBC_;
		}
		set
		{
			bulletFXUseDBC_ = value;
		}
	}

	public string BulletSpawnPSPath
	{
		get
		{
			return bulletSpawnPSPath_;
		}
		set
		{
			bulletSpawnPSPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BulletSelfSpawnDBCPath
	{
		get
		{
			return bulletSelfSpawnDBCPath_;
		}
		set
		{
			bulletSelfSpawnDBCPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BulletHitItemPSPath
	{
		get
		{
			return bulletHitItemPSPath_;
		}
		set
		{
			bulletHitItemPSPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BulletHitUnitPSPath
	{
		get
		{
			return bulletHitUnitPSPath_;
		}
		set
		{
			bulletHitUnitPSPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BulletLifeOverPSPath
	{
		get
		{
			return bulletLifeOverPSPath_;
		}
		set
		{
			bulletLifeOverPSPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BeHitedBulletPlayFXPath
	{
		get
		{
			return beHitedBulletPlayFXPath_;
		}
		set
		{
			beHitedBulletPlayFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int BulletNumLimit
	{
		get
		{
			return bulletNumLimit_;
		}
		set
		{
			bulletNumLimit_ = value;
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

	public FUStBulletCommDesc()
	{
	}

	public FUStBulletCommDesc(FUStBulletCommDesc other)
		: this()
	{
		iD_ = other.iD_;
		bulletBPTemplatePath_ = other.bulletBPTemplatePath_;
		bulletIsFresh_ = other.bulletIsFresh_;
		bulletIsForMerge_ = other.bulletIsForMerge_;
		bulletIsMergeChild_ = other.bulletIsMergeChild_;
		bulletMergeTag_ = other.bulletMergeTag_;
		bulletIsFacingTarget_ = other.bulletIsFacingTarget_;
		bulletType_ = other.bulletType_;
		bulletTypeParam_ = other.bulletTypeParam_;
		bulletDelayDestroyTime_ = other.bulletDelayDestroyTime_;
		bulletLifeTime_ = other.bulletLifeTime_;
		bulletLifeSpeed_ = other.bulletLifeSpeed_;
		lifeOverEffectID_ = other.lifeOverEffectID_.Clone();
		hitUnitEffectsforSelf_ = other.hitUnitEffectsforSelf_.Clone();
		hitItemEffectsforSelf_ = other.hitItemEffectsforSelf_.Clone();
		hitEffectsforActor_ = other.hitEffectsforActor_.Clone();
		bulletSweepCheckType_ = other.bulletSweepCheckType_;
		bulletSweepCheckGap_ = other.bulletSweepCheckGap_;
		bulletSweepCheckDelayTime_ = other.bulletSweepCheckDelayTime_;
		bulletIsOnlyHitTarget_ = other.bulletIsOnlyHitTarget_;
		bulletCanThroughBlockage_ = other.bulletCanThroughBlockage_;
		bulletAnimPath_ = other.bulletAnimPath_;
		bulletMoveModeType_ = other.bulletMoveModeType_;
		bulletSpdType_ = other.bulletSpdType_;
		bulletFlyTime_ = other.bulletFlyTime_;
		bulletEQSID_ = other.bulletEQSID_;
		bulletMoveModeIntParam_ = other.bulletMoveModeIntParam_.Clone();
		bulletMoveModeFloatParam_ = other.bulletMoveModeFloatParam_.Clone();
		bulletMoveModeYoNParam_ = other.bulletMoveModeYoNParam_.Clone();
		bulletMoveModeStrParam_ = other.bulletMoveModeStrParam_.Clone();
		bulletPStoSpawnInterval_ = other.bulletPStoSpawnInterval_;
		bulletLowestSpdCanPlayPS_ = other.bulletLowestSpdCanPlayPS_;
		beHitedBulletSwitchID_ = other.beHitedBulletSwitchID_;
		fXDestroyImmediatelyTag_ = other.fXDestroyImmediatelyTag_;
		beHitedBulletPostAKPath_ = other.beHitedBulletPostAKPath_;
		bulletFXUseDBC_ = other.bulletFXUseDBC_;
		bulletSpawnPSPath_ = other.bulletSpawnPSPath_;
		bulletSelfSpawnDBCPath_ = other.bulletSelfSpawnDBCPath_;
		bulletHitItemPSPath_ = other.bulletHitItemPSPath_;
		bulletHitUnitPSPath_ = other.bulletHitUnitPSPath_;
		bulletLifeOverPSPath_ = other.bulletLifeOverPSPath_;
		beHitedBulletPlayFXPath_ = other.beHitedBulletPlayFXPath_;
		isLaserType_ = other.isLaserType_;
		laserMaxLength_ = other.laserMaxLength_;
		bulletNumLimit_ = other.bulletNumLimit_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBulletCommDesc Clone()
	{
		return new FUStBulletCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBulletCommDesc);
	}

	public bool Equals(FUStBulletCommDesc other)
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
		if (BulletBPTemplatePath != other.BulletBPTemplatePath)
		{
			return false;
		}
		if (BulletIsFresh != other.BulletIsFresh)
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
		if (BulletIsFacingTarget != other.BulletIsFacingTarget)
		{
			return false;
		}
		if (BulletType != other.BulletType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletTypeParam, other.BulletTypeParam))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletDelayDestroyTime, other.BulletDelayDestroyTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletLifeTime, other.BulletLifeTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletLifeSpeed, other.BulletLifeSpeed))
		{
			return false;
		}
		if (!lifeOverEffectID_.Equals(other.lifeOverEffectID_))
		{
			return false;
		}
		if (!hitUnitEffectsforSelf_.Equals(other.hitUnitEffectsforSelf_))
		{
			return false;
		}
		if (!hitItemEffectsforSelf_.Equals(other.hitItemEffectsforSelf_))
		{
			return false;
		}
		if (!hitEffectsforActor_.Equals(other.hitEffectsforActor_))
		{
			return false;
		}
		if (BulletSweepCheckType != other.BulletSweepCheckType)
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
		if (BulletAnimPath != other.BulletAnimPath)
		{
			return false;
		}
		if (BulletMoveModeType != other.BulletMoveModeType)
		{
			return false;
		}
		if (BulletSpdType != other.BulletSpdType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletFlyTime, other.BulletFlyTime))
		{
			return false;
		}
		if (BulletEQSID != other.BulletEQSID)
		{
			return false;
		}
		if (!bulletMoveModeIntParam_.Equals(other.bulletMoveModeIntParam_))
		{
			return false;
		}
		if (!bulletMoveModeFloatParam_.Equals(other.bulletMoveModeFloatParam_))
		{
			return false;
		}
		if (!bulletMoveModeYoNParam_.Equals(other.bulletMoveModeYoNParam_))
		{
			return false;
		}
		if (!bulletMoveModeStrParam_.Equals(other.bulletMoveModeStrParam_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletPStoSpawnInterval, other.BulletPStoSpawnInterval))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletLowestSpdCanPlayPS, other.BulletLowestSpdCanPlayPS))
		{
			return false;
		}
		if (BeHitedBulletSwitchID != other.BeHitedBulletSwitchID)
		{
			return false;
		}
		if (FXDestroyImmediatelyTag != other.FXDestroyImmediatelyTag)
		{
			return false;
		}
		if (BeHitedBulletPostAKPath != other.BeHitedBulletPostAKPath)
		{
			return false;
		}
		if (BulletFXUseDBC != other.BulletFXUseDBC)
		{
			return false;
		}
		if (BulletSpawnPSPath != other.BulletSpawnPSPath)
		{
			return false;
		}
		if (BulletSelfSpawnDBCPath != other.BulletSelfSpawnDBCPath)
		{
			return false;
		}
		if (BulletHitItemPSPath != other.BulletHitItemPSPath)
		{
			return false;
		}
		if (BulletHitUnitPSPath != other.BulletHitUnitPSPath)
		{
			return false;
		}
		if (BulletLifeOverPSPath != other.BulletLifeOverPSPath)
		{
			return false;
		}
		if (BeHitedBulletPlayFXPath != other.BeHitedBulletPlayFXPath)
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
		if (BulletNumLimit != other.BulletNumLimit)
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
		if (BulletBPTemplatePath.Length != 0)
		{
			num ^= BulletBPTemplatePath.GetHashCode();
		}
		if (BulletIsFresh != EGSYesNo.No)
		{
			num ^= BulletIsFresh.GetHashCode();
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
		if (BulletIsFacingTarget != EGSYesNo.No)
		{
			num ^= BulletIsFacingTarget.GetHashCode();
		}
		if (BulletType != EBGUBulletType.NormalSpawn)
		{
			num ^= BulletType.GetHashCode();
		}
		if (BulletTypeParam != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletTypeParam);
		}
		if (BulletDelayDestroyTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletDelayDestroyTime);
		}
		if (BulletLifeTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletLifeTime);
		}
		if (BulletLifeSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletLifeSpeed);
		}
		num ^= lifeOverEffectID_.GetHashCode();
		num ^= hitUnitEffectsforSelf_.GetHashCode();
		num ^= hitItemEffectsforSelf_.GetHashCode();
		num ^= hitEffectsforActor_.GetHashCode();
		if (BulletSweepCheckType != EBGUBulletSweepCheckType.BoxShape)
		{
			num ^= BulletSweepCheckType.GetHashCode();
		}
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
		if (BulletAnimPath.Length != 0)
		{
			num ^= BulletAnimPath.GetHashCode();
		}
		if (BulletMoveModeType != EBulletOrMagicFieldMoveModeType.None)
		{
			num ^= BulletMoveModeType.GetHashCode();
		}
		if (BulletSpdType != EProjectileObjSpdType.None)
		{
			num ^= BulletSpdType.GetHashCode();
		}
		if (BulletFlyTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletFlyTime);
		}
		if (BulletEQSID != 0)
		{
			num ^= BulletEQSID.GetHashCode();
		}
		num ^= bulletMoveModeIntParam_.GetHashCode();
		num ^= bulletMoveModeFloatParam_.GetHashCode();
		num ^= bulletMoveModeYoNParam_.GetHashCode();
		num ^= bulletMoveModeStrParam_.GetHashCode();
		if (BulletPStoSpawnInterval != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletPStoSpawnInterval);
		}
		if (BulletLowestSpdCanPlayPS != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletLowestSpdCanPlayPS);
		}
		if (BeHitedBulletSwitchID != 0)
		{
			num ^= BeHitedBulletSwitchID.GetHashCode();
		}
		if (FXDestroyImmediatelyTag.Length != 0)
		{
			num ^= FXDestroyImmediatelyTag.GetHashCode();
		}
		if (BeHitedBulletPostAKPath.Length != 0)
		{
			num ^= BeHitedBulletPostAKPath.GetHashCode();
		}
		if (BulletFXUseDBC != EGSYesNo.No)
		{
			num ^= BulletFXUseDBC.GetHashCode();
		}
		if (BulletSpawnPSPath.Length != 0)
		{
			num ^= BulletSpawnPSPath.GetHashCode();
		}
		if (BulletSelfSpawnDBCPath.Length != 0)
		{
			num ^= BulletSelfSpawnDBCPath.GetHashCode();
		}
		if (BulletHitItemPSPath.Length != 0)
		{
			num ^= BulletHitItemPSPath.GetHashCode();
		}
		if (BulletHitUnitPSPath.Length != 0)
		{
			num ^= BulletHitUnitPSPath.GetHashCode();
		}
		if (BulletLifeOverPSPath.Length != 0)
		{
			num ^= BulletLifeOverPSPath.GetHashCode();
		}
		if (BeHitedBulletPlayFXPath.Length != 0)
		{
			num ^= BeHitedBulletPlayFXPath.GetHashCode();
		}
		if (IsLaserType != EGSYesNo.No)
		{
			num ^= IsLaserType.GetHashCode();
		}
		if (LaserMaxLength != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LaserMaxLength);
		}
		if (BulletNumLimit != 0)
		{
			num ^= BulletNumLimit.GetHashCode();
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
		if (BulletBPTemplatePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BulletBPTemplatePath);
		}
		if (BulletIsFresh != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)BulletIsFresh);
		}
		if (BulletIsForMerge != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)BulletIsForMerge);
		}
		if (BulletIsMergeChild != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)BulletIsMergeChild);
		}
		if (BulletMergeTag.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(BulletMergeTag);
		}
		if (BulletIsFacingTarget != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)BulletIsFacingTarget);
		}
		if (BulletType != EBGUBulletType.NormalSpawn)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)BulletType);
		}
		if (BulletTypeParam != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(BulletTypeParam);
		}
		if (BulletDelayDestroyTime != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(BulletDelayDestroyTime);
		}
		if (BulletLifeTime != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(BulletLifeTime);
		}
		if (BulletLifeSpeed != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(BulletLifeSpeed);
		}
		lifeOverEffectID_.WriteTo(output, _repeated_lifeOverEffectID_codec);
		hitUnitEffectsforSelf_.WriteTo(output, _repeated_hitUnitEffectsforSelf_codec);
		hitItemEffectsforSelf_.WriteTo(output, _repeated_hitItemEffectsforSelf_codec);
		hitEffectsforActor_.WriteTo(output, _repeated_hitEffectsforActor_codec);
		if (BulletSweepCheckType != EBGUBulletSweepCheckType.BoxShape)
		{
			output.WriteRawTag(136, 1);
			output.WriteEnum((int)BulletSweepCheckType);
		}
		if (BulletSweepCheckGap != 0f)
		{
			output.WriteRawTag(149, 1);
			output.WriteFloat(BulletSweepCheckGap);
		}
		if (BulletSweepCheckDelayTime != 0f)
		{
			output.WriteRawTag(157, 1);
			output.WriteFloat(BulletSweepCheckDelayTime);
		}
		if (BulletIsOnlyHitTarget != EGSYesNo.No)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)BulletIsOnlyHitTarget);
		}
		if (BulletCanThroughBlockage != EGSYesNo.No)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)BulletCanThroughBlockage);
		}
		if (BulletAnimPath.Length != 0)
		{
			output.WriteRawTag(178, 1);
			output.WriteString(BulletAnimPath);
		}
		if (BulletMoveModeType != EBulletOrMagicFieldMoveModeType.None)
		{
			output.WriteRawTag(184, 1);
			output.WriteEnum((int)BulletMoveModeType);
		}
		if (BulletSpdType != EProjectileObjSpdType.None)
		{
			output.WriteRawTag(192, 1);
			output.WriteEnum((int)BulletSpdType);
		}
		if (BulletFlyTime != 0f)
		{
			output.WriteRawTag(205, 1);
			output.WriteFloat(BulletFlyTime);
		}
		if (BulletEQSID != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(BulletEQSID);
		}
		bulletMoveModeIntParam_.WriteTo(output, _repeated_bulletMoveModeIntParam_codec);
		bulletMoveModeFloatParam_.WriteTo(output, _repeated_bulletMoveModeFloatParam_codec);
		bulletMoveModeYoNParam_.WriteTo(output, _repeated_bulletMoveModeYoNParam_codec);
		bulletMoveModeStrParam_.WriteTo(output, _repeated_bulletMoveModeStrParam_codec);
		if (BulletPStoSpawnInterval != 0f)
		{
			output.WriteRawTag(253, 1);
			output.WriteFloat(BulletPStoSpawnInterval);
		}
		if (BulletLowestSpdCanPlayPS != 0f)
		{
			output.WriteRawTag(133, 2);
			output.WriteFloat(BulletLowestSpdCanPlayPS);
		}
		if (BeHitedBulletSwitchID != 0)
		{
			output.WriteRawTag(136, 2);
			output.WriteInt32(BeHitedBulletSwitchID);
		}
		if (FXDestroyImmediatelyTag.Length != 0)
		{
			output.WriteRawTag(146, 2);
			output.WriteString(FXDestroyImmediatelyTag);
		}
		if (BeHitedBulletPostAKPath.Length != 0)
		{
			output.WriteRawTag(154, 2);
			output.WriteString(BeHitedBulletPostAKPath);
		}
		if (BulletFXUseDBC != EGSYesNo.No)
		{
			output.WriteRawTag(160, 2);
			output.WriteEnum((int)BulletFXUseDBC);
		}
		if (BulletSpawnPSPath.Length != 0)
		{
			output.WriteRawTag(170, 2);
			output.WriteString(BulletSpawnPSPath);
		}
		if (BulletSelfSpawnDBCPath.Length != 0)
		{
			output.WriteRawTag(178, 2);
			output.WriteString(BulletSelfSpawnDBCPath);
		}
		if (BulletHitItemPSPath.Length != 0)
		{
			output.WriteRawTag(186, 2);
			output.WriteString(BulletHitItemPSPath);
		}
		if (BulletHitUnitPSPath.Length != 0)
		{
			output.WriteRawTag(194, 2);
			output.WriteString(BulletHitUnitPSPath);
		}
		if (BulletLifeOverPSPath.Length != 0)
		{
			output.WriteRawTag(202, 2);
			output.WriteString(BulletLifeOverPSPath);
		}
		if (BeHitedBulletPlayFXPath.Length != 0)
		{
			output.WriteRawTag(210, 2);
			output.WriteString(BeHitedBulletPlayFXPath);
		}
		if (IsLaserType != EGSYesNo.No)
		{
			output.WriteRawTag(216, 2);
			output.WriteEnum((int)IsLaserType);
		}
		if (LaserMaxLength != 0f)
		{
			output.WriteRawTag(229, 2);
			output.WriteFloat(LaserMaxLength);
		}
		if (BulletNumLimit != 0)
		{
			output.WriteRawTag(232, 2);
			output.WriteInt32(BulletNumLimit);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(242, 2);
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
		if (BulletBPTemplatePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BulletBPTemplatePath);
		}
		if (BulletIsFresh != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BulletIsFresh);
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
		if (BulletIsFacingTarget != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BulletIsFacingTarget);
		}
		if (BulletType != EBGUBulletType.NormalSpawn)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BulletType);
		}
		if (BulletTypeParam != 0f)
		{
			num += 5;
		}
		if (BulletDelayDestroyTime != 0f)
		{
			num += 5;
		}
		if (BulletLifeTime != 0f)
		{
			num += 5;
		}
		if (BulletLifeSpeed != 0f)
		{
			num += 5;
		}
		num += lifeOverEffectID_.CalculateSize(_repeated_lifeOverEffectID_codec);
		num += hitUnitEffectsforSelf_.CalculateSize(_repeated_hitUnitEffectsforSelf_codec);
		num += hitItemEffectsforSelf_.CalculateSize(_repeated_hitItemEffectsforSelf_codec);
		num += hitEffectsforActor_.CalculateSize(_repeated_hitEffectsforActor_codec);
		if (BulletSweepCheckType != EBGUBulletSweepCheckType.BoxShape)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BulletSweepCheckType);
		}
		if (BulletSweepCheckGap != 0f)
		{
			num += 6;
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
		if (BulletAnimPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BulletAnimPath);
		}
		if (BulletMoveModeType != EBulletOrMagicFieldMoveModeType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BulletMoveModeType);
		}
		if (BulletSpdType != EProjectileObjSpdType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BulletSpdType);
		}
		if (BulletFlyTime != 0f)
		{
			num += 6;
		}
		if (BulletEQSID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BulletEQSID);
		}
		num += bulletMoveModeIntParam_.CalculateSize(_repeated_bulletMoveModeIntParam_codec);
		num += bulletMoveModeFloatParam_.CalculateSize(_repeated_bulletMoveModeFloatParam_codec);
		num += bulletMoveModeYoNParam_.CalculateSize(_repeated_bulletMoveModeYoNParam_codec);
		num += bulletMoveModeStrParam_.CalculateSize(_repeated_bulletMoveModeStrParam_codec);
		if (BulletPStoSpawnInterval != 0f)
		{
			num += 6;
		}
		if (BulletLowestSpdCanPlayPS != 0f)
		{
			num += 6;
		}
		if (BeHitedBulletSwitchID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BeHitedBulletSwitchID);
		}
		if (FXDestroyImmediatelyTag.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(FXDestroyImmediatelyTag);
		}
		if (BeHitedBulletPostAKPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BeHitedBulletPostAKPath);
		}
		if (BulletFXUseDBC != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)BulletFXUseDBC);
		}
		if (BulletSpawnPSPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BulletSpawnPSPath);
		}
		if (BulletSelfSpawnDBCPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BulletSelfSpawnDBCPath);
		}
		if (BulletHitItemPSPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BulletHitItemPSPath);
		}
		if (BulletHitUnitPSPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BulletHitUnitPSPath);
		}
		if (BulletLifeOverPSPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BulletLifeOverPSPath);
		}
		if (BeHitedBulletPlayFXPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(BeHitedBulletPlayFXPath);
		}
		if (IsLaserType != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsLaserType);
		}
		if (LaserMaxLength != 0f)
		{
			num += 6;
		}
		if (BulletNumLimit != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BulletNumLimit);
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

	public void MergeFrom(FUStBulletCommDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BulletBPTemplatePath.Length != 0)
			{
				BulletBPTemplatePath = other.BulletBPTemplatePath;
			}
			if (other.BulletIsFresh != EGSYesNo.No)
			{
				BulletIsFresh = other.BulletIsFresh;
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
			if (other.BulletIsFacingTarget != EGSYesNo.No)
			{
				BulletIsFacingTarget = other.BulletIsFacingTarget;
			}
			if (other.BulletType != EBGUBulletType.NormalSpawn)
			{
				BulletType = other.BulletType;
			}
			if (other.BulletTypeParam != 0f)
			{
				BulletTypeParam = other.BulletTypeParam;
			}
			if (other.BulletDelayDestroyTime != 0f)
			{
				BulletDelayDestroyTime = other.BulletDelayDestroyTime;
			}
			if (other.BulletLifeTime != 0f)
			{
				BulletLifeTime = other.BulletLifeTime;
			}
			if (other.BulletLifeSpeed != 0f)
			{
				BulletLifeSpeed = other.BulletLifeSpeed;
			}
			lifeOverEffectID_.Add(other.lifeOverEffectID_);
			hitUnitEffectsforSelf_.Add(other.hitUnitEffectsforSelf_);
			hitItemEffectsforSelf_.Add(other.hitItemEffectsforSelf_);
			hitEffectsforActor_.Add(other.hitEffectsforActor_);
			if (other.BulletSweepCheckType != EBGUBulletSweepCheckType.BoxShape)
			{
				BulletSweepCheckType = other.BulletSweepCheckType;
			}
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
			if (other.BulletAnimPath.Length != 0)
			{
				BulletAnimPath = other.BulletAnimPath;
			}
			if (other.BulletMoveModeType != EBulletOrMagicFieldMoveModeType.None)
			{
				BulletMoveModeType = other.BulletMoveModeType;
			}
			if (other.BulletSpdType != EProjectileObjSpdType.None)
			{
				BulletSpdType = other.BulletSpdType;
			}
			if (other.BulletFlyTime != 0f)
			{
				BulletFlyTime = other.BulletFlyTime;
			}
			if (other.BulletEQSID != 0)
			{
				BulletEQSID = other.BulletEQSID;
			}
			bulletMoveModeIntParam_.Add(other.bulletMoveModeIntParam_);
			bulletMoveModeFloatParam_.Add(other.bulletMoveModeFloatParam_);
			bulletMoveModeYoNParam_.Add(other.bulletMoveModeYoNParam_);
			bulletMoveModeStrParam_.Add(other.bulletMoveModeStrParam_);
			if (other.BulletPStoSpawnInterval != 0f)
			{
				BulletPStoSpawnInterval = other.BulletPStoSpawnInterval;
			}
			if (other.BulletLowestSpdCanPlayPS != 0f)
			{
				BulletLowestSpdCanPlayPS = other.BulletLowestSpdCanPlayPS;
			}
			if (other.BeHitedBulletSwitchID != 0)
			{
				BeHitedBulletSwitchID = other.BeHitedBulletSwitchID;
			}
			if (other.FXDestroyImmediatelyTag.Length != 0)
			{
				FXDestroyImmediatelyTag = other.FXDestroyImmediatelyTag;
			}
			if (other.BeHitedBulletPostAKPath.Length != 0)
			{
				BeHitedBulletPostAKPath = other.BeHitedBulletPostAKPath;
			}
			if (other.BulletFXUseDBC != EGSYesNo.No)
			{
				BulletFXUseDBC = other.BulletFXUseDBC;
			}
			if (other.BulletSpawnPSPath.Length != 0)
			{
				BulletSpawnPSPath = other.BulletSpawnPSPath;
			}
			if (other.BulletSelfSpawnDBCPath.Length != 0)
			{
				BulletSelfSpawnDBCPath = other.BulletSelfSpawnDBCPath;
			}
			if (other.BulletHitItemPSPath.Length != 0)
			{
				BulletHitItemPSPath = other.BulletHitItemPSPath;
			}
			if (other.BulletHitUnitPSPath.Length != 0)
			{
				BulletHitUnitPSPath = other.BulletHitUnitPSPath;
			}
			if (other.BulletLifeOverPSPath.Length != 0)
			{
				BulletLifeOverPSPath = other.BulletLifeOverPSPath;
			}
			if (other.BeHitedBulletPlayFXPath.Length != 0)
			{
				BeHitedBulletPlayFXPath = other.BeHitedBulletPlayFXPath;
			}
			if (other.IsLaserType != EGSYesNo.No)
			{
				IsLaserType = other.IsLaserType;
			}
			if (other.LaserMaxLength != 0f)
			{
				LaserMaxLength = other.LaserMaxLength;
			}
			if (other.BulletNumLimit != 0)
			{
				BulletNumLimit = other.BulletNumLimit;
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
			case 18u:
				BulletBPTemplatePath = input.ReadString();
				break;
			case 24u:
				BulletIsFresh = (EGSYesNo)input.ReadEnum();
				break;
			case 32u:
				BulletIsForMerge = (EGSYesNo)input.ReadEnum();
				break;
			case 40u:
				BulletIsMergeChild = (EGSYesNo)input.ReadEnum();
				break;
			case 50u:
				BulletMergeTag = input.ReadString();
				break;
			case 56u:
				BulletIsFacingTarget = (EGSYesNo)input.ReadEnum();
				break;
			case 64u:
				BulletType = (EBGUBulletType)input.ReadEnum();
				break;
			case 77u:
				BulletTypeParam = input.ReadFloat();
				break;
			case 85u:
				BulletDelayDestroyTime = input.ReadFloat();
				break;
			case 93u:
				BulletLifeTime = input.ReadFloat();
				break;
			case 101u:
				BulletLifeSpeed = input.ReadFloat();
				break;
			case 104u:
			case 106u:
				lifeOverEffectID_.AddEntriesFrom(input, _repeated_lifeOverEffectID_codec);
				break;
			case 112u:
			case 114u:
				hitUnitEffectsforSelf_.AddEntriesFrom(input, _repeated_hitUnitEffectsforSelf_codec);
				break;
			case 120u:
			case 122u:
				hitItemEffectsforSelf_.AddEntriesFrom(input, _repeated_hitItemEffectsforSelf_codec);
				break;
			case 128u:
			case 130u:
				hitEffectsforActor_.AddEntriesFrom(input, _repeated_hitEffectsforActor_codec);
				break;
			case 136u:
				BulletSweepCheckType = (EBGUBulletSweepCheckType)input.ReadEnum();
				break;
			case 149u:
				BulletSweepCheckGap = input.ReadFloat();
				break;
			case 157u:
				BulletSweepCheckDelayTime = input.ReadFloat();
				break;
			case 160u:
				BulletIsOnlyHitTarget = (EGSYesNo)input.ReadEnum();
				break;
			case 168u:
				BulletCanThroughBlockage = (EGSYesNo)input.ReadEnum();
				break;
			case 178u:
				BulletAnimPath = input.ReadString();
				break;
			case 184u:
				BulletMoveModeType = (EBulletOrMagicFieldMoveModeType)input.ReadEnum();
				break;
			case 192u:
				BulletSpdType = (EProjectileObjSpdType)input.ReadEnum();
				break;
			case 205u:
				BulletFlyTime = input.ReadFloat();
				break;
			case 208u:
				BulletEQSID = input.ReadInt32();
				break;
			case 216u:
			case 218u:
				bulletMoveModeIntParam_.AddEntriesFrom(input, _repeated_bulletMoveModeIntParam_codec);
				break;
			case 226u:
			case 229u:
				bulletMoveModeFloatParam_.AddEntriesFrom(input, _repeated_bulletMoveModeFloatParam_codec);
				break;
			case 232u:
			case 234u:
				bulletMoveModeYoNParam_.AddEntriesFrom(input, _repeated_bulletMoveModeYoNParam_codec);
				break;
			case 242u:
				bulletMoveModeStrParam_.AddEntriesFrom(input, _repeated_bulletMoveModeStrParam_codec);
				break;
			case 253u:
				BulletPStoSpawnInterval = input.ReadFloat();
				break;
			case 261u:
				BulletLowestSpdCanPlayPS = input.ReadFloat();
				break;
			case 264u:
				BeHitedBulletSwitchID = input.ReadInt32();
				break;
			case 274u:
				FXDestroyImmediatelyTag = input.ReadString();
				break;
			case 282u:
				BeHitedBulletPostAKPath = input.ReadString();
				break;
			case 288u:
				BulletFXUseDBC = (EGSYesNo)input.ReadEnum();
				break;
			case 298u:
				BulletSpawnPSPath = input.ReadString();
				break;
			case 306u:
				BulletSelfSpawnDBCPath = input.ReadString();
				break;
			case 314u:
				BulletHitItemPSPath = input.ReadString();
				break;
			case 322u:
				BulletHitUnitPSPath = input.ReadString();
				break;
			case 330u:
				BulletLifeOverPSPath = input.ReadString();
				break;
			case 338u:
				BeHitedBulletPlayFXPath = input.ReadString();
				break;
			case 344u:
				IsLaserType = (EGSYesNo)input.ReadEnum();
				break;
			case 357u:
				LaserMaxLength = input.ReadFloat();
				break;
			case 360u:
				BulletNumLimit = input.ReadInt32();
				break;
			case 370u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
