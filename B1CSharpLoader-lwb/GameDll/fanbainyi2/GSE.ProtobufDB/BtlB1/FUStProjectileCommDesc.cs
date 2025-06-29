using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStProjectileCommDesc : IMessage<FUStProjectileCommDesc>, IMessage, IEquatable<FUStProjectileCommDesc>, IDeepCloneable<FUStProjectileCommDesc>
{
	private static readonly MessageParser<FUStProjectileCommDesc> _parser = new MessageParser<FUStProjectileCommDesc>(() => new FUStProjectileCommDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string projectileBPTemplatePath_ = "";

	private EGSYesNo projectileIsFresh_;

	private EBGUBulletType projectileType_;

	private float projectileTypeParam_;

	private float projectileDelayDestroyTime_;

	private float projectileLifeTime_;

	private float projectileLifeSpeed_;

	private EGSYesNo lifeOverWithDetach_;

	private string projectileAnimPath_ = "";

	private int projectileNumLimit_;

	private int beHitedProjectileSwitchID_;

	private static readonly FieldCodec<int> _repeated_beHitedTriggerEffectIDs_codec = FieldCodec.ForInt32(106u);

	private readonly RepeatedField<int> beHitedTriggerEffectIDs_ = new RepeatedField<int>();

	private string projectileSweepReactionDataAssetPath_ = "";

	private EGSYesNo projectileMeshIsFacingTarget_;

	private FUStBulletAffectArea bulletSkillArea_;

	private EProjectileScaleCurveXAxisType scaleCurveXAxisType_;

	private EProjectileScaleCurveYAxisType scaleCurveYAxisType_;

	private string projectileScaleCurvePath_ = "";

	private string projectileInnerRadiusCurvePath_ = "";

	private EGSYesNo scaleOnlyApplyToCheck_;

	private static readonly FieldCodec<int> _repeated_birthBuff_codec = FieldCodec.ForInt32(178u);

	private readonly RepeatedField<int> birthBuff_ = new RepeatedField<int>();

	public static MessageParser<FUStProjectileCommDesc> Parser => _parser;

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

	public string ProjectileBPTemplatePath
	{
		get
		{
			return projectileBPTemplatePath_;
		}
		set
		{
			projectileBPTemplatePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo ProjectileIsFresh
	{
		get
		{
			return projectileIsFresh_;
		}
		set
		{
			projectileIsFresh_ = value;
		}
	}

	public EBGUBulletType ProjectileType
	{
		get
		{
			return projectileType_;
		}
		set
		{
			projectileType_ = value;
		}
	}

	public float ProjectileTypeParam
	{
		get
		{
			return projectileTypeParam_;
		}
		set
		{
			projectileTypeParam_ = value;
		}
	}

	public float ProjectileDelayDestroyTime
	{
		get
		{
			return projectileDelayDestroyTime_;
		}
		set
		{
			projectileDelayDestroyTime_ = value;
		}
	}

	public float ProjectileLifeTime
	{
		get
		{
			return projectileLifeTime_;
		}
		set
		{
			projectileLifeTime_ = value;
		}
	}

	public float ProjectileLifeSpeed
	{
		get
		{
			return projectileLifeSpeed_;
		}
		set
		{
			projectileLifeSpeed_ = value;
		}
	}

	public EGSYesNo LifeOverWithDetach
	{
		get
		{
			return lifeOverWithDetach_;
		}
		set
		{
			lifeOverWithDetach_ = value;
		}
	}

	public string ProjectileAnimPath
	{
		get
		{
			return projectileAnimPath_;
		}
		set
		{
			projectileAnimPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ProjectileNumLimit
	{
		get
		{
			return projectileNumLimit_;
		}
		set
		{
			projectileNumLimit_ = value;
		}
	}

	public int BeHitedProjectileSwitchID
	{
		get
		{
			return beHitedProjectileSwitchID_;
		}
		set
		{
			beHitedProjectileSwitchID_ = value;
		}
	}

	public RepeatedField<int> BeHitedTriggerEffectIDs => beHitedTriggerEffectIDs_;

	public string ProjectileSweepReactionDataAssetPath
	{
		get
		{
			return projectileSweepReactionDataAssetPath_;
		}
		set
		{
			projectileSweepReactionDataAssetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo ProjectileMeshIsFacingTarget
	{
		get
		{
			return projectileMeshIsFacingTarget_;
		}
		set
		{
			projectileMeshIsFacingTarget_ = value;
		}
	}

	public FUStBulletAffectArea BulletSkillArea
	{
		get
		{
			return bulletSkillArea_;
		}
		set
		{
			bulletSkillArea_ = value;
		}
	}

	public EProjectileScaleCurveXAxisType ScaleCurveXAxisType
	{
		get
		{
			return scaleCurveXAxisType_;
		}
		set
		{
			scaleCurveXAxisType_ = value;
		}
	}

	public EProjectileScaleCurveYAxisType ScaleCurveYAxisType
	{
		get
		{
			return scaleCurveYAxisType_;
		}
		set
		{
			scaleCurveYAxisType_ = value;
		}
	}

	public string ProjectileScaleCurvePath
	{
		get
		{
			return projectileScaleCurvePath_;
		}
		set
		{
			projectileScaleCurvePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ProjectileInnerRadiusCurvePath
	{
		get
		{
			return projectileInnerRadiusCurvePath_;
		}
		set
		{
			projectileInnerRadiusCurvePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo ScaleOnlyApplyToCheck
	{
		get
		{
			return scaleOnlyApplyToCheck_;
		}
		set
		{
			scaleOnlyApplyToCheck_ = value;
		}
	}

	public RepeatedField<int> BirthBuff => birthBuff_;

	public FUStProjectileCommDesc()
	{
	}

	public FUStProjectileCommDesc(FUStProjectileCommDesc other)
		: this()
	{
		iD_ = other.iD_;
		projectileBPTemplatePath_ = other.projectileBPTemplatePath_;
		projectileIsFresh_ = other.projectileIsFresh_;
		projectileType_ = other.projectileType_;
		projectileTypeParam_ = other.projectileTypeParam_;
		projectileDelayDestroyTime_ = other.projectileDelayDestroyTime_;
		projectileLifeTime_ = other.projectileLifeTime_;
		projectileLifeSpeed_ = other.projectileLifeSpeed_;
		lifeOverWithDetach_ = other.lifeOverWithDetach_;
		projectileAnimPath_ = other.projectileAnimPath_;
		projectileNumLimit_ = other.projectileNumLimit_;
		beHitedProjectileSwitchID_ = other.beHitedProjectileSwitchID_;
		beHitedTriggerEffectIDs_ = other.beHitedTriggerEffectIDs_.Clone();
		projectileSweepReactionDataAssetPath_ = other.projectileSweepReactionDataAssetPath_;
		projectileMeshIsFacingTarget_ = other.projectileMeshIsFacingTarget_;
		bulletSkillArea_ = ((other.bulletSkillArea_ != null) ? other.bulletSkillArea_.Clone() : null);
		scaleCurveXAxisType_ = other.scaleCurveXAxisType_;
		scaleCurveYAxisType_ = other.scaleCurveYAxisType_;
		projectileScaleCurvePath_ = other.projectileScaleCurvePath_;
		projectileInnerRadiusCurvePath_ = other.projectileInnerRadiusCurvePath_;
		scaleOnlyApplyToCheck_ = other.scaleOnlyApplyToCheck_;
		birthBuff_ = other.birthBuff_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStProjectileCommDesc Clone()
	{
		return new FUStProjectileCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStProjectileCommDesc);
	}

	public bool Equals(FUStProjectileCommDesc other)
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
		if (ProjectileBPTemplatePath != other.ProjectileBPTemplatePath)
		{
			return false;
		}
		if (ProjectileIsFresh != other.ProjectileIsFresh)
		{
			return false;
		}
		if (ProjectileType != other.ProjectileType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ProjectileTypeParam, other.ProjectileTypeParam))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ProjectileDelayDestroyTime, other.ProjectileDelayDestroyTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ProjectileLifeTime, other.ProjectileLifeTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ProjectileLifeSpeed, other.ProjectileLifeSpeed))
		{
			return false;
		}
		if (LifeOverWithDetach != other.LifeOverWithDetach)
		{
			return false;
		}
		if (ProjectileAnimPath != other.ProjectileAnimPath)
		{
			return false;
		}
		if (ProjectileNumLimit != other.ProjectileNumLimit)
		{
			return false;
		}
		if (BeHitedProjectileSwitchID != other.BeHitedProjectileSwitchID)
		{
			return false;
		}
		if (!beHitedTriggerEffectIDs_.Equals(other.beHitedTriggerEffectIDs_))
		{
			return false;
		}
		if (ProjectileSweepReactionDataAssetPath != other.ProjectileSweepReactionDataAssetPath)
		{
			return false;
		}
		if (ProjectileMeshIsFacingTarget != other.ProjectileMeshIsFacingTarget)
		{
			return false;
		}
		if (!object.Equals(BulletSkillArea, other.BulletSkillArea))
		{
			return false;
		}
		if (ScaleCurveXAxisType != other.ScaleCurveXAxisType)
		{
			return false;
		}
		if (ScaleCurveYAxisType != other.ScaleCurveYAxisType)
		{
			return false;
		}
		if (ProjectileScaleCurvePath != other.ProjectileScaleCurvePath)
		{
			return false;
		}
		if (ProjectileInnerRadiusCurvePath != other.ProjectileInnerRadiusCurvePath)
		{
			return false;
		}
		if (ScaleOnlyApplyToCheck != other.ScaleOnlyApplyToCheck)
		{
			return false;
		}
		if (!birthBuff_.Equals(other.birthBuff_))
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
		if (ProjectileBPTemplatePath.Length != 0)
		{
			num ^= ProjectileBPTemplatePath.GetHashCode();
		}
		if (ProjectileIsFresh != EGSYesNo.No)
		{
			num ^= ProjectileIsFresh.GetHashCode();
		}
		if (ProjectileType != EBGUBulletType.NormalSpawn)
		{
			num ^= ProjectileType.GetHashCode();
		}
		if (ProjectileTypeParam != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ProjectileTypeParam);
		}
		if (ProjectileDelayDestroyTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ProjectileDelayDestroyTime);
		}
		if (ProjectileLifeTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ProjectileLifeTime);
		}
		if (ProjectileLifeSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ProjectileLifeSpeed);
		}
		if (LifeOverWithDetach != EGSYesNo.No)
		{
			num ^= LifeOverWithDetach.GetHashCode();
		}
		if (ProjectileAnimPath.Length != 0)
		{
			num ^= ProjectileAnimPath.GetHashCode();
		}
		if (ProjectileNumLimit != 0)
		{
			num ^= ProjectileNumLimit.GetHashCode();
		}
		if (BeHitedProjectileSwitchID != 0)
		{
			num ^= BeHitedProjectileSwitchID.GetHashCode();
		}
		num ^= beHitedTriggerEffectIDs_.GetHashCode();
		if (ProjectileSweepReactionDataAssetPath.Length != 0)
		{
			num ^= ProjectileSweepReactionDataAssetPath.GetHashCode();
		}
		if (ProjectileMeshIsFacingTarget != EGSYesNo.No)
		{
			num ^= ProjectileMeshIsFacingTarget.GetHashCode();
		}
		if (bulletSkillArea_ != null)
		{
			num ^= BulletSkillArea.GetHashCode();
		}
		if (ScaleCurveXAxisType != EProjectileScaleCurveXAxisType.None)
		{
			num ^= ScaleCurveXAxisType.GetHashCode();
		}
		if (ScaleCurveYAxisType != EProjectileScaleCurveYAxisType.None)
		{
			num ^= ScaleCurveYAxisType.GetHashCode();
		}
		if (ProjectileScaleCurvePath.Length != 0)
		{
			num ^= ProjectileScaleCurvePath.GetHashCode();
		}
		if (ProjectileInnerRadiusCurvePath.Length != 0)
		{
			num ^= ProjectileInnerRadiusCurvePath.GetHashCode();
		}
		if (ScaleOnlyApplyToCheck != EGSYesNo.No)
		{
			num ^= ScaleOnlyApplyToCheck.GetHashCode();
		}
		num ^= birthBuff_.GetHashCode();
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
		if (ProjectileBPTemplatePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ProjectileBPTemplatePath);
		}
		if (ProjectileIsFresh != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ProjectileIsFresh);
		}
		if (ProjectileType != EBGUBulletType.NormalSpawn)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ProjectileType);
		}
		if (ProjectileTypeParam != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(ProjectileTypeParam);
		}
		if (ProjectileDelayDestroyTime != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(ProjectileDelayDestroyTime);
		}
		if (ProjectileLifeTime != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(ProjectileLifeTime);
		}
		if (ProjectileLifeSpeed != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(ProjectileLifeSpeed);
		}
		if (LifeOverWithDetach != EGSYesNo.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)LifeOverWithDetach);
		}
		if (ProjectileAnimPath.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(ProjectileAnimPath);
		}
		if (ProjectileNumLimit != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ProjectileNumLimit);
		}
		if (BeHitedProjectileSwitchID != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(BeHitedProjectileSwitchID);
		}
		beHitedTriggerEffectIDs_.WriteTo(output, _repeated_beHitedTriggerEffectIDs_codec);
		if (ProjectileSweepReactionDataAssetPath.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(ProjectileSweepReactionDataAssetPath);
		}
		if (ProjectileMeshIsFacingTarget != EGSYesNo.No)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)ProjectileMeshIsFacingTarget);
		}
		if (bulletSkillArea_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(BulletSkillArea);
		}
		if (ScaleCurveXAxisType != EProjectileScaleCurveXAxisType.None)
		{
			output.WriteRawTag(136, 1);
			output.WriteEnum((int)ScaleCurveXAxisType);
		}
		if (ScaleCurveYAxisType != EProjectileScaleCurveYAxisType.None)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)ScaleCurveYAxisType);
		}
		if (ProjectileScaleCurvePath.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(ProjectileScaleCurvePath);
		}
		if (ProjectileInnerRadiusCurvePath.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(ProjectileInnerRadiusCurvePath);
		}
		if (ScaleOnlyApplyToCheck != EGSYesNo.No)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)ScaleOnlyApplyToCheck);
		}
		birthBuff_.WriteTo(output, _repeated_birthBuff_codec);
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
		if (ProjectileBPTemplatePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ProjectileBPTemplatePath);
		}
		if (ProjectileIsFresh != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ProjectileIsFresh);
		}
		if (ProjectileType != EBGUBulletType.NormalSpawn)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ProjectileType);
		}
		if (ProjectileTypeParam != 0f)
		{
			num += 5;
		}
		if (ProjectileDelayDestroyTime != 0f)
		{
			num += 5;
		}
		if (ProjectileLifeTime != 0f)
		{
			num += 5;
		}
		if (ProjectileLifeSpeed != 0f)
		{
			num += 5;
		}
		if (LifeOverWithDetach != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LifeOverWithDetach);
		}
		if (ProjectileAnimPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ProjectileAnimPath);
		}
		if (ProjectileNumLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ProjectileNumLimit);
		}
		if (BeHitedProjectileSwitchID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BeHitedProjectileSwitchID);
		}
		num += beHitedTriggerEffectIDs_.CalculateSize(_repeated_beHitedTriggerEffectIDs_codec);
		if (ProjectileSweepReactionDataAssetPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ProjectileSweepReactionDataAssetPath);
		}
		if (ProjectileMeshIsFacingTarget != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ProjectileMeshIsFacingTarget);
		}
		if (bulletSkillArea_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BulletSkillArea);
		}
		if (ScaleCurveXAxisType != EProjectileScaleCurveXAxisType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ScaleCurveXAxisType);
		}
		if (ScaleCurveYAxisType != EProjectileScaleCurveYAxisType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ScaleCurveYAxisType);
		}
		if (ProjectileScaleCurvePath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ProjectileScaleCurvePath);
		}
		if (ProjectileInnerRadiusCurvePath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ProjectileInnerRadiusCurvePath);
		}
		if (ScaleOnlyApplyToCheck != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ScaleOnlyApplyToCheck);
		}
		num += birthBuff_.CalculateSize(_repeated_birthBuff_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStProjectileCommDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.ProjectileBPTemplatePath.Length != 0)
		{
			ProjectileBPTemplatePath = other.ProjectileBPTemplatePath;
		}
		if (other.ProjectileIsFresh != EGSYesNo.No)
		{
			ProjectileIsFresh = other.ProjectileIsFresh;
		}
		if (other.ProjectileType != EBGUBulletType.NormalSpawn)
		{
			ProjectileType = other.ProjectileType;
		}
		if (other.ProjectileTypeParam != 0f)
		{
			ProjectileTypeParam = other.ProjectileTypeParam;
		}
		if (other.ProjectileDelayDestroyTime != 0f)
		{
			ProjectileDelayDestroyTime = other.ProjectileDelayDestroyTime;
		}
		if (other.ProjectileLifeTime != 0f)
		{
			ProjectileLifeTime = other.ProjectileLifeTime;
		}
		if (other.ProjectileLifeSpeed != 0f)
		{
			ProjectileLifeSpeed = other.ProjectileLifeSpeed;
		}
		if (other.LifeOverWithDetach != EGSYesNo.No)
		{
			LifeOverWithDetach = other.LifeOverWithDetach;
		}
		if (other.ProjectileAnimPath.Length != 0)
		{
			ProjectileAnimPath = other.ProjectileAnimPath;
		}
		if (other.ProjectileNumLimit != 0)
		{
			ProjectileNumLimit = other.ProjectileNumLimit;
		}
		if (other.BeHitedProjectileSwitchID != 0)
		{
			BeHitedProjectileSwitchID = other.BeHitedProjectileSwitchID;
		}
		beHitedTriggerEffectIDs_.Add(other.beHitedTriggerEffectIDs_);
		if (other.ProjectileSweepReactionDataAssetPath.Length != 0)
		{
			ProjectileSweepReactionDataAssetPath = other.ProjectileSweepReactionDataAssetPath;
		}
		if (other.ProjectileMeshIsFacingTarget != EGSYesNo.No)
		{
			ProjectileMeshIsFacingTarget = other.ProjectileMeshIsFacingTarget;
		}
		if (other.bulletSkillArea_ != null)
		{
			if (bulletSkillArea_ == null)
			{
				BulletSkillArea = new FUStBulletAffectArea();
			}
			BulletSkillArea.MergeFrom(other.BulletSkillArea);
		}
		if (other.ScaleCurveXAxisType != EProjectileScaleCurveXAxisType.None)
		{
			ScaleCurveXAxisType = other.ScaleCurveXAxisType;
		}
		if (other.ScaleCurveYAxisType != EProjectileScaleCurveYAxisType.None)
		{
			ScaleCurveYAxisType = other.ScaleCurveYAxisType;
		}
		if (other.ProjectileScaleCurvePath.Length != 0)
		{
			ProjectileScaleCurvePath = other.ProjectileScaleCurvePath;
		}
		if (other.ProjectileInnerRadiusCurvePath.Length != 0)
		{
			ProjectileInnerRadiusCurvePath = other.ProjectileInnerRadiusCurvePath;
		}
		if (other.ScaleOnlyApplyToCheck != EGSYesNo.No)
		{
			ScaleOnlyApplyToCheck = other.ScaleOnlyApplyToCheck;
		}
		birthBuff_.Add(other.birthBuff_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				ProjectileBPTemplatePath = input.ReadString();
				break;
			case 24u:
				ProjectileIsFresh = (EGSYesNo)input.ReadEnum();
				break;
			case 32u:
				ProjectileType = (EBGUBulletType)input.ReadEnum();
				break;
			case 45u:
				ProjectileTypeParam = input.ReadFloat();
				break;
			case 53u:
				ProjectileDelayDestroyTime = input.ReadFloat();
				break;
			case 61u:
				ProjectileLifeTime = input.ReadFloat();
				break;
			case 69u:
				ProjectileLifeSpeed = input.ReadFloat();
				break;
			case 72u:
				LifeOverWithDetach = (EGSYesNo)input.ReadEnum();
				break;
			case 82u:
				ProjectileAnimPath = input.ReadString();
				break;
			case 88u:
				ProjectileNumLimit = input.ReadInt32();
				break;
			case 96u:
				BeHitedProjectileSwitchID = input.ReadInt32();
				break;
			case 104u:
			case 106u:
				beHitedTriggerEffectIDs_.AddEntriesFrom(input, _repeated_beHitedTriggerEffectIDs_codec);
				break;
			case 114u:
				ProjectileSweepReactionDataAssetPath = input.ReadString();
				break;
			case 120u:
				ProjectileMeshIsFacingTarget = (EGSYesNo)input.ReadEnum();
				break;
			case 130u:
				if (bulletSkillArea_ == null)
				{
					BulletSkillArea = new FUStBulletAffectArea();
				}
				input.ReadMessage(BulletSkillArea);
				break;
			case 136u:
				ScaleCurveXAxisType = (EProjectileScaleCurveXAxisType)input.ReadEnum();
				break;
			case 144u:
				ScaleCurveYAxisType = (EProjectileScaleCurveYAxisType)input.ReadEnum();
				break;
			case 154u:
				ProjectileScaleCurvePath = input.ReadString();
				break;
			case 162u:
				ProjectileInnerRadiusCurvePath = input.ReadString();
				break;
			case 168u:
				ScaleOnlyApplyToCheck = (EGSYesNo)input.ReadEnum();
				break;
			case 176u:
			case 178u:
				birthBuff_.AddEntriesFrom(input, _repeated_birthBuff_codec);
				break;
			}
		}
	}
}
