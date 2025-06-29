using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSummonCommDesc : IMessage<FUStSummonCommDesc>, IMessage, IEquatable<FUStSummonCommDesc>, IDeepCloneable<FUStSummonCommDesc>
{
	private static readonly MessageParser<FUStSummonCommDesc> _parser = new MessageParser<FUStSummonCommDesc>(() => new FUStSummonCommDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private float summonAliveTime_;

	private string summonTamerTemplatePath_ = "";

	private string summonBPTemplatePath_ = "";

	private ESummonUnitRotationType summonUnitRotationType_;

	private ESummonUnitLocationType summonUnitLocationType_;

	private EGSYesNo selectPointRandom_;

	private int pointSetCachedReqID_;

	private string summonDataAssetsPath_ = "";

	private string summonSpawnEQSPath_ = "";

	private string summonSpawnSceneItemTag_ = "";

	private string bornEffectPath_ = "";

	private EGSYesNo useBornSkill_;

	private static readonly FieldCodec<string> _repeated_bornMontagePathList_codec = FieldCodec.ForString(122u);

	private readonly RepeatedField<string> bornMontagePathList_ = new RepeatedField<string>();

	private static readonly FieldCodec<int> _repeated_bornSkillList_codec = FieldCodec.ForInt32(130u);

	private readonly RepeatedField<int> bornSkillList_ = new RepeatedField<int>();

	private static readonly FieldCodec<string> _repeated_disappearMontagePathList_codec = FieldCodec.ForString(138u);

	private readonly RepeatedField<string> disappearMontagePathList_ = new RepeatedField<string>();

	private float bornDelayTime_;

	private ESummonTargetMethod summonTargetMethod_;

	private float bornEffDisplayTime_;

	private float destroyDelayTime_;

	private static readonly FieldCodec<int> _repeated_buffList_codec = FieldCodec.ForInt32(178u);

	private readonly RepeatedField<int> buffList_ = new RepeatedField<int>();

	private float initSpeed_;

	private EGSYesNo syncBattleSC_;

	private EGSYesNo isCopyEquip_;

	private int copyAttrConfigID_;

	private EGSYesNo isDestroyWhenSummonerDead_;

	private EGSYesNo isSummonerAsMaster_;

	private float beforeBornTime_;

	public static MessageParser<FUStSummonCommDesc> Parser => _parser;

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

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public float SummonAliveTime
	{
		get
		{
			return summonAliveTime_;
		}
		set
		{
			summonAliveTime_ = value;
		}
	}

	public string SummonTamerTemplatePath
	{
		get
		{
			return summonTamerTemplatePath_;
		}
		set
		{
			summonTamerTemplatePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SummonBPTemplatePath
	{
		get
		{
			return summonBPTemplatePath_;
		}
		set
		{
			summonBPTemplatePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ESummonUnitRotationType SummonUnitRotationType
	{
		get
		{
			return summonUnitRotationType_;
		}
		set
		{
			summonUnitRotationType_ = value;
		}
	}

	public ESummonUnitLocationType SummonUnitLocationType
	{
		get
		{
			return summonUnitLocationType_;
		}
		set
		{
			summonUnitLocationType_ = value;
		}
	}

	public EGSYesNo SelectPointRandom
	{
		get
		{
			return selectPointRandom_;
		}
		set
		{
			selectPointRandom_ = value;
		}
	}

	public int PointSetCachedReqID
	{
		get
		{
			return pointSetCachedReqID_;
		}
		set
		{
			pointSetCachedReqID_ = value;
		}
	}

	public string SummonDataAssetsPath
	{
		get
		{
			return summonDataAssetsPath_;
		}
		set
		{
			summonDataAssetsPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SummonSpawnEQSPath
	{
		get
		{
			return summonSpawnEQSPath_;
		}
		set
		{
			summonSpawnEQSPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SummonSpawnSceneItemTag
	{
		get
		{
			return summonSpawnSceneItemTag_;
		}
		set
		{
			summonSpawnSceneItemTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BornEffectPath
	{
		get
		{
			return bornEffectPath_;
		}
		set
		{
			bornEffectPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo UseBornSkill
	{
		get
		{
			return useBornSkill_;
		}
		set
		{
			useBornSkill_ = value;
		}
	}

	public RepeatedField<string> BornMontagePathList => bornMontagePathList_;

	public RepeatedField<int> BornSkillList => bornSkillList_;

	public RepeatedField<string> DisappearMontagePathList => disappearMontagePathList_;

	public float BornDelayTime
	{
		get
		{
			return bornDelayTime_;
		}
		set
		{
			bornDelayTime_ = value;
		}
	}

	public ESummonTargetMethod SummonTargetMethod
	{
		get
		{
			return summonTargetMethod_;
		}
		set
		{
			summonTargetMethod_ = value;
		}
	}

	public float BornEffDisplayTime
	{
		get
		{
			return bornEffDisplayTime_;
		}
		set
		{
			bornEffDisplayTime_ = value;
		}
	}

	public float DestroyDelayTime
	{
		get
		{
			return destroyDelayTime_;
		}
		set
		{
			destroyDelayTime_ = value;
		}
	}

	public RepeatedField<int> BuffList => buffList_;

	public float InitSpeed
	{
		get
		{
			return initSpeed_;
		}
		set
		{
			initSpeed_ = value;
		}
	}

	public EGSYesNo SyncBattleSC
	{
		get
		{
			return syncBattleSC_;
		}
		set
		{
			syncBattleSC_ = value;
		}
	}

	public EGSYesNo IsCopyEquip
	{
		get
		{
			return isCopyEquip_;
		}
		set
		{
			isCopyEquip_ = value;
		}
	}

	public int CopyAttrConfigID
	{
		get
		{
			return copyAttrConfigID_;
		}
		set
		{
			copyAttrConfigID_ = value;
		}
	}

	public EGSYesNo IsDestroyWhenSummonerDead
	{
		get
		{
			return isDestroyWhenSummonerDead_;
		}
		set
		{
			isDestroyWhenSummonerDead_ = value;
		}
	}

	public EGSYesNo IsSummonerAsMaster
	{
		get
		{
			return isSummonerAsMaster_;
		}
		set
		{
			isSummonerAsMaster_ = value;
		}
	}

	public float BeforeBornTime
	{
		get
		{
			return beforeBornTime_;
		}
		set
		{
			beforeBornTime_ = value;
		}
	}

	public FUStSummonCommDesc()
	{
	}

	public FUStSummonCommDesc(FUStSummonCommDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		summonAliveTime_ = other.summonAliveTime_;
		summonTamerTemplatePath_ = other.summonTamerTemplatePath_;
		summonBPTemplatePath_ = other.summonBPTemplatePath_;
		summonUnitRotationType_ = other.summonUnitRotationType_;
		summonUnitLocationType_ = other.summonUnitLocationType_;
		selectPointRandom_ = other.selectPointRandom_;
		pointSetCachedReqID_ = other.pointSetCachedReqID_;
		summonDataAssetsPath_ = other.summonDataAssetsPath_;
		summonSpawnEQSPath_ = other.summonSpawnEQSPath_;
		summonSpawnSceneItemTag_ = other.summonSpawnSceneItemTag_;
		bornEffectPath_ = other.bornEffectPath_;
		useBornSkill_ = other.useBornSkill_;
		bornMontagePathList_ = other.bornMontagePathList_.Clone();
		bornSkillList_ = other.bornSkillList_.Clone();
		disappearMontagePathList_ = other.disappearMontagePathList_.Clone();
		bornDelayTime_ = other.bornDelayTime_;
		summonTargetMethod_ = other.summonTargetMethod_;
		bornEffDisplayTime_ = other.bornEffDisplayTime_;
		destroyDelayTime_ = other.destroyDelayTime_;
		buffList_ = other.buffList_.Clone();
		initSpeed_ = other.initSpeed_;
		syncBattleSC_ = other.syncBattleSC_;
		isCopyEquip_ = other.isCopyEquip_;
		copyAttrConfigID_ = other.copyAttrConfigID_;
		isDestroyWhenSummonerDead_ = other.isDestroyWhenSummonerDead_;
		isSummonerAsMaster_ = other.isSummonerAsMaster_;
		beforeBornTime_ = other.beforeBornTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSummonCommDesc Clone()
	{
		return new FUStSummonCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSummonCommDesc);
	}

	public bool Equals(FUStSummonCommDesc other)
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
		if (ResID != other.ResID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SummonAliveTime, other.SummonAliveTime))
		{
			return false;
		}
		if (SummonTamerTemplatePath != other.SummonTamerTemplatePath)
		{
			return false;
		}
		if (SummonBPTemplatePath != other.SummonBPTemplatePath)
		{
			return false;
		}
		if (SummonUnitRotationType != other.SummonUnitRotationType)
		{
			return false;
		}
		if (SummonUnitLocationType != other.SummonUnitLocationType)
		{
			return false;
		}
		if (SelectPointRandom != other.SelectPointRandom)
		{
			return false;
		}
		if (PointSetCachedReqID != other.PointSetCachedReqID)
		{
			return false;
		}
		if (SummonDataAssetsPath != other.SummonDataAssetsPath)
		{
			return false;
		}
		if (SummonSpawnEQSPath != other.SummonSpawnEQSPath)
		{
			return false;
		}
		if (SummonSpawnSceneItemTag != other.SummonSpawnSceneItemTag)
		{
			return false;
		}
		if (BornEffectPath != other.BornEffectPath)
		{
			return false;
		}
		if (UseBornSkill != other.UseBornSkill)
		{
			return false;
		}
		if (!bornMontagePathList_.Equals(other.bornMontagePathList_))
		{
			return false;
		}
		if (!bornSkillList_.Equals(other.bornSkillList_))
		{
			return false;
		}
		if (!disappearMontagePathList_.Equals(other.disappearMontagePathList_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BornDelayTime, other.BornDelayTime))
		{
			return false;
		}
		if (SummonTargetMethod != other.SummonTargetMethod)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BornEffDisplayTime, other.BornEffDisplayTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DestroyDelayTime, other.DestroyDelayTime))
		{
			return false;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InitSpeed, other.InitSpeed))
		{
			return false;
		}
		if (SyncBattleSC != other.SyncBattleSC)
		{
			return false;
		}
		if (IsCopyEquip != other.IsCopyEquip)
		{
			return false;
		}
		if (CopyAttrConfigID != other.CopyAttrConfigID)
		{
			return false;
		}
		if (IsDestroyWhenSummonerDead != other.IsDestroyWhenSummonerDead)
		{
			return false;
		}
		if (IsSummonerAsMaster != other.IsSummonerAsMaster)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BeforeBornTime, other.BeforeBornTime))
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
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (SummonAliveTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SummonAliveTime);
		}
		if (SummonTamerTemplatePath.Length != 0)
		{
			num ^= SummonTamerTemplatePath.GetHashCode();
		}
		if (SummonBPTemplatePath.Length != 0)
		{
			num ^= SummonBPTemplatePath.GetHashCode();
		}
		if (SummonUnitRotationType != ESummonUnitRotationType.None)
		{
			num ^= SummonUnitRotationType.GetHashCode();
		}
		if (SummonUnitLocationType != ESummonUnitLocationType.UsePointSetCached)
		{
			num ^= SummonUnitLocationType.GetHashCode();
		}
		if (SelectPointRandom != EGSYesNo.No)
		{
			num ^= SelectPointRandom.GetHashCode();
		}
		if (PointSetCachedReqID != 0)
		{
			num ^= PointSetCachedReqID.GetHashCode();
		}
		if (SummonDataAssetsPath.Length != 0)
		{
			num ^= SummonDataAssetsPath.GetHashCode();
		}
		if (SummonSpawnEQSPath.Length != 0)
		{
			num ^= SummonSpawnEQSPath.GetHashCode();
		}
		if (SummonSpawnSceneItemTag.Length != 0)
		{
			num ^= SummonSpawnSceneItemTag.GetHashCode();
		}
		if (BornEffectPath.Length != 0)
		{
			num ^= BornEffectPath.GetHashCode();
		}
		if (UseBornSkill != EGSYesNo.No)
		{
			num ^= UseBornSkill.GetHashCode();
		}
		num ^= bornMontagePathList_.GetHashCode();
		num ^= bornSkillList_.GetHashCode();
		num ^= disappearMontagePathList_.GetHashCode();
		if (BornDelayTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BornDelayTime);
		}
		if (SummonTargetMethod != ESummonTargetMethod.SyncFromMaster)
		{
			num ^= SummonTargetMethod.GetHashCode();
		}
		if (BornEffDisplayTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BornEffDisplayTime);
		}
		if (DestroyDelayTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DestroyDelayTime);
		}
		num ^= buffList_.GetHashCode();
		if (InitSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InitSpeed);
		}
		if (SyncBattleSC != EGSYesNo.No)
		{
			num ^= SyncBattleSC.GetHashCode();
		}
		if (IsCopyEquip != EGSYesNo.No)
		{
			num ^= IsCopyEquip.GetHashCode();
		}
		if (CopyAttrConfigID != 0)
		{
			num ^= CopyAttrConfigID.GetHashCode();
		}
		if (IsDestroyWhenSummonerDead != EGSYesNo.No)
		{
			num ^= IsDestroyWhenSummonerDead.GetHashCode();
		}
		if (IsSummonerAsMaster != EGSYesNo.No)
		{
			num ^= IsSummonerAsMaster.GetHashCode();
		}
		if (BeforeBornTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BeforeBornTime);
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
		if (ResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResID);
		}
		if (SummonAliveTime != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(SummonAliveTime);
		}
		if (SummonTamerTemplatePath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SummonTamerTemplatePath);
		}
		if (SummonBPTemplatePath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(SummonBPTemplatePath);
		}
		if (SummonUnitRotationType != ESummonUnitRotationType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)SummonUnitRotationType);
		}
		if (SummonUnitLocationType != ESummonUnitLocationType.UsePointSetCached)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)SummonUnitLocationType);
		}
		if (SelectPointRandom != EGSYesNo.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)SelectPointRandom);
		}
		if (PointSetCachedReqID != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PointSetCachedReqID);
		}
		if (SummonDataAssetsPath.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(SummonDataAssetsPath);
		}
		if (SummonSpawnEQSPath.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(SummonSpawnEQSPath);
		}
		if (SummonSpawnSceneItemTag.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(SummonSpawnSceneItemTag);
		}
		if (BornEffectPath.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(BornEffectPath);
		}
		if (UseBornSkill != EGSYesNo.No)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)UseBornSkill);
		}
		bornMontagePathList_.WriteTo(output, _repeated_bornMontagePathList_codec);
		bornSkillList_.WriteTo(output, _repeated_bornSkillList_codec);
		disappearMontagePathList_.WriteTo(output, _repeated_disappearMontagePathList_codec);
		if (BornDelayTime != 0f)
		{
			output.WriteRawTag(149, 1);
			output.WriteFloat(BornDelayTime);
		}
		if (SummonTargetMethod != ESummonTargetMethod.SyncFromMaster)
		{
			output.WriteRawTag(152, 1);
			output.WriteEnum((int)SummonTargetMethod);
		}
		if (BornEffDisplayTime != 0f)
		{
			output.WriteRawTag(165, 1);
			output.WriteFloat(BornEffDisplayTime);
		}
		if (DestroyDelayTime != 0f)
		{
			output.WriteRawTag(173, 1);
			output.WriteFloat(DestroyDelayTime);
		}
		buffList_.WriteTo(output, _repeated_buffList_codec);
		if (InitSpeed != 0f)
		{
			output.WriteRawTag(189, 1);
			output.WriteFloat(InitSpeed);
		}
		if (SyncBattleSC != EGSYesNo.No)
		{
			output.WriteRawTag(192, 1);
			output.WriteEnum((int)SyncBattleSC);
		}
		if (IsCopyEquip != EGSYesNo.No)
		{
			output.WriteRawTag(200, 1);
			output.WriteEnum((int)IsCopyEquip);
		}
		if (CopyAttrConfigID != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(CopyAttrConfigID);
		}
		if (IsDestroyWhenSummonerDead != EGSYesNo.No)
		{
			output.WriteRawTag(216, 1);
			output.WriteEnum((int)IsDestroyWhenSummonerDead);
		}
		if (IsSummonerAsMaster != EGSYesNo.No)
		{
			output.WriteRawTag(224, 1);
			output.WriteEnum((int)IsSummonerAsMaster);
		}
		if (BeforeBornTime != 0f)
		{
			output.WriteRawTag(237, 1);
			output.WriteFloat(BeforeBornTime);
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
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (SummonAliveTime != 0f)
		{
			num += 5;
		}
		if (SummonTamerTemplatePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SummonTamerTemplatePath);
		}
		if (SummonBPTemplatePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SummonBPTemplatePath);
		}
		if (SummonUnitRotationType != ESummonUnitRotationType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SummonUnitRotationType);
		}
		if (SummonUnitLocationType != ESummonUnitLocationType.UsePointSetCached)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SummonUnitLocationType);
		}
		if (SelectPointRandom != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SelectPointRandom);
		}
		if (PointSetCachedReqID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PointSetCachedReqID);
		}
		if (SummonDataAssetsPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SummonDataAssetsPath);
		}
		if (SummonSpawnEQSPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SummonSpawnEQSPath);
		}
		if (SummonSpawnSceneItemTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SummonSpawnSceneItemTag);
		}
		if (BornEffectPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BornEffectPath);
		}
		if (UseBornSkill != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UseBornSkill);
		}
		num += bornMontagePathList_.CalculateSize(_repeated_bornMontagePathList_codec);
		num += bornSkillList_.CalculateSize(_repeated_bornSkillList_codec);
		num += disappearMontagePathList_.CalculateSize(_repeated_disappearMontagePathList_codec);
		if (BornDelayTime != 0f)
		{
			num += 6;
		}
		if (SummonTargetMethod != ESummonTargetMethod.SyncFromMaster)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)SummonTargetMethod);
		}
		if (BornEffDisplayTime != 0f)
		{
			num += 6;
		}
		if (DestroyDelayTime != 0f)
		{
			num += 6;
		}
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (InitSpeed != 0f)
		{
			num += 6;
		}
		if (SyncBattleSC != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)SyncBattleSC);
		}
		if (IsCopyEquip != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsCopyEquip);
		}
		if (CopyAttrConfigID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(CopyAttrConfigID);
		}
		if (IsDestroyWhenSummonerDead != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsDestroyWhenSummonerDead);
		}
		if (IsSummonerAsMaster != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsSummonerAsMaster);
		}
		if (BeforeBornTime != 0f)
		{
			num += 6;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSummonCommDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.SummonAliveTime != 0f)
			{
				SummonAliveTime = other.SummonAliveTime;
			}
			if (other.SummonTamerTemplatePath.Length != 0)
			{
				SummonTamerTemplatePath = other.SummonTamerTemplatePath;
			}
			if (other.SummonBPTemplatePath.Length != 0)
			{
				SummonBPTemplatePath = other.SummonBPTemplatePath;
			}
			if (other.SummonUnitRotationType != ESummonUnitRotationType.None)
			{
				SummonUnitRotationType = other.SummonUnitRotationType;
			}
			if (other.SummonUnitLocationType != ESummonUnitLocationType.UsePointSetCached)
			{
				SummonUnitLocationType = other.SummonUnitLocationType;
			}
			if (other.SelectPointRandom != EGSYesNo.No)
			{
				SelectPointRandom = other.SelectPointRandom;
			}
			if (other.PointSetCachedReqID != 0)
			{
				PointSetCachedReqID = other.PointSetCachedReqID;
			}
			if (other.SummonDataAssetsPath.Length != 0)
			{
				SummonDataAssetsPath = other.SummonDataAssetsPath;
			}
			if (other.SummonSpawnEQSPath.Length != 0)
			{
				SummonSpawnEQSPath = other.SummonSpawnEQSPath;
			}
			if (other.SummonSpawnSceneItemTag.Length != 0)
			{
				SummonSpawnSceneItemTag = other.SummonSpawnSceneItemTag;
			}
			if (other.BornEffectPath.Length != 0)
			{
				BornEffectPath = other.BornEffectPath;
			}
			if (other.UseBornSkill != EGSYesNo.No)
			{
				UseBornSkill = other.UseBornSkill;
			}
			bornMontagePathList_.Add(other.bornMontagePathList_);
			bornSkillList_.Add(other.bornSkillList_);
			disappearMontagePathList_.Add(other.disappearMontagePathList_);
			if (other.BornDelayTime != 0f)
			{
				BornDelayTime = other.BornDelayTime;
			}
			if (other.SummonTargetMethod != ESummonTargetMethod.SyncFromMaster)
			{
				SummonTargetMethod = other.SummonTargetMethod;
			}
			if (other.BornEffDisplayTime != 0f)
			{
				BornEffDisplayTime = other.BornEffDisplayTime;
			}
			if (other.DestroyDelayTime != 0f)
			{
				DestroyDelayTime = other.DestroyDelayTime;
			}
			buffList_.Add(other.buffList_);
			if (other.InitSpeed != 0f)
			{
				InitSpeed = other.InitSpeed;
			}
			if (other.SyncBattleSC != EGSYesNo.No)
			{
				SyncBattleSC = other.SyncBattleSC;
			}
			if (other.IsCopyEquip != EGSYesNo.No)
			{
				IsCopyEquip = other.IsCopyEquip;
			}
			if (other.CopyAttrConfigID != 0)
			{
				CopyAttrConfigID = other.CopyAttrConfigID;
			}
			if (other.IsDestroyWhenSummonerDead != EGSYesNo.No)
			{
				IsDestroyWhenSummonerDead = other.IsDestroyWhenSummonerDead;
			}
			if (other.IsSummonerAsMaster != EGSYesNo.No)
			{
				IsSummonerAsMaster = other.IsSummonerAsMaster;
			}
			if (other.BeforeBornTime != 0f)
			{
				BeforeBornTime = other.BeforeBornTime;
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
				ResID = input.ReadInt32();
				break;
			case 29u:
				SummonAliveTime = input.ReadFloat();
				break;
			case 34u:
				SummonTamerTemplatePath = input.ReadString();
				break;
			case 42u:
				SummonBPTemplatePath = input.ReadString();
				break;
			case 48u:
				SummonUnitRotationType = (ESummonUnitRotationType)input.ReadEnum();
				break;
			case 56u:
				SummonUnitLocationType = (ESummonUnitLocationType)input.ReadEnum();
				break;
			case 64u:
				SelectPointRandom = (EGSYesNo)input.ReadEnum();
				break;
			case 72u:
				PointSetCachedReqID = input.ReadInt32();
				break;
			case 82u:
				SummonDataAssetsPath = input.ReadString();
				break;
			case 90u:
				SummonSpawnEQSPath = input.ReadString();
				break;
			case 98u:
				SummonSpawnSceneItemTag = input.ReadString();
				break;
			case 106u:
				BornEffectPath = input.ReadString();
				break;
			case 112u:
				UseBornSkill = (EGSYesNo)input.ReadEnum();
				break;
			case 122u:
				bornMontagePathList_.AddEntriesFrom(input, _repeated_bornMontagePathList_codec);
				break;
			case 128u:
			case 130u:
				bornSkillList_.AddEntriesFrom(input, _repeated_bornSkillList_codec);
				break;
			case 138u:
				disappearMontagePathList_.AddEntriesFrom(input, _repeated_disappearMontagePathList_codec);
				break;
			case 149u:
				BornDelayTime = input.ReadFloat();
				break;
			case 152u:
				SummonTargetMethod = (ESummonTargetMethod)input.ReadEnum();
				break;
			case 165u:
				BornEffDisplayTime = input.ReadFloat();
				break;
			case 173u:
				DestroyDelayTime = input.ReadFloat();
				break;
			case 176u:
			case 178u:
				buffList_.AddEntriesFrom(input, _repeated_buffList_codec);
				break;
			case 189u:
				InitSpeed = input.ReadFloat();
				break;
			case 192u:
				SyncBattleSC = (EGSYesNo)input.ReadEnum();
				break;
			case 200u:
				IsCopyEquip = (EGSYesNo)input.ReadEnum();
				break;
			case 208u:
				CopyAttrConfigID = input.ReadInt32();
				break;
			case 216u:
				IsDestroyWhenSummonerDead = (EGSYesNo)input.ReadEnum();
				break;
			case 224u:
				IsSummonerAsMaster = (EGSYesNo)input.ReadEnum();
				break;
			case 237u:
				BeforeBornTime = input.ReadFloat();
				break;
			}
		}
	}
}
