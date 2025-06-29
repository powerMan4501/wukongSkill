using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStProjectileDispDesc : IMessage<FUStProjectileDispDesc>, IMessage, IEquatable<FUStProjectileDispDesc>, IDeepCloneable<FUStProjectileDispDesc>
{
	private static readonly MessageParser<FUStProjectileDispDesc> _parser = new MessageParser<FUStProjectileDispDesc>(() => new FUStProjectileDispDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo projectileFXUseDBC_;

	private string projectileSpawnPSPath_ = "";

	private string projectileSelfSpawnDBCPath_ = "";

	private float spawnPStoSpawnInterval_;

	private float bulletLowestSpdCanPlayPS_;

	private string bulletHitItemPSPath_ = "";

	private string bulletHitUnitPSPath_ = "";

	private string bulletLifeOverPSPath_ = "";

	private string beHitedProjectilePlayFXPath_ = "";

	private string beHitedProjectilePostAKPath_ = "";

	private string fXDestroyImmediatelyTag_ = "";

	private int hitChrAudioID_;

	private string guard_ = "";

	public static MessageParser<FUStProjectileDispDesc> Parser => _parser;

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

	public EGSYesNo ProjectileFXUseDBC
	{
		get
		{
			return projectileFXUseDBC_;
		}
		set
		{
			projectileFXUseDBC_ = value;
		}
	}

	public string ProjectileSpawnPSPath
	{
		get
		{
			return projectileSpawnPSPath_;
		}
		set
		{
			projectileSpawnPSPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ProjectileSelfSpawnDBCPath
	{
		get
		{
			return projectileSelfSpawnDBCPath_;
		}
		set
		{
			projectileSelfSpawnDBCPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float SpawnPStoSpawnInterval
	{
		get
		{
			return spawnPStoSpawnInterval_;
		}
		set
		{
			spawnPStoSpawnInterval_ = value;
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

	public string BeHitedProjectilePlayFXPath
	{
		get
		{
			return beHitedProjectilePlayFXPath_;
		}
		set
		{
			beHitedProjectilePlayFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BeHitedProjectilePostAKPath
	{
		get
		{
			return beHitedProjectilePostAKPath_;
		}
		set
		{
			beHitedProjectilePostAKPath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int HitChrAudioID
	{
		get
		{
			return hitChrAudioID_;
		}
		set
		{
			hitChrAudioID_ = value;
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

	public FUStProjectileDispDesc()
	{
	}

	public FUStProjectileDispDesc(FUStProjectileDispDesc other)
		: this()
	{
		iD_ = other.iD_;
		projectileFXUseDBC_ = other.projectileFXUseDBC_;
		projectileSpawnPSPath_ = other.projectileSpawnPSPath_;
		projectileSelfSpawnDBCPath_ = other.projectileSelfSpawnDBCPath_;
		spawnPStoSpawnInterval_ = other.spawnPStoSpawnInterval_;
		bulletLowestSpdCanPlayPS_ = other.bulletLowestSpdCanPlayPS_;
		bulletHitItemPSPath_ = other.bulletHitItemPSPath_;
		bulletHitUnitPSPath_ = other.bulletHitUnitPSPath_;
		bulletLifeOverPSPath_ = other.bulletLifeOverPSPath_;
		beHitedProjectilePlayFXPath_ = other.beHitedProjectilePlayFXPath_;
		beHitedProjectilePostAKPath_ = other.beHitedProjectilePostAKPath_;
		fXDestroyImmediatelyTag_ = other.fXDestroyImmediatelyTag_;
		hitChrAudioID_ = other.hitChrAudioID_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStProjectileDispDesc Clone()
	{
		return new FUStProjectileDispDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStProjectileDispDesc);
	}

	public bool Equals(FUStProjectileDispDesc other)
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
		if (ProjectileFXUseDBC != other.ProjectileFXUseDBC)
		{
			return false;
		}
		if (ProjectileSpawnPSPath != other.ProjectileSpawnPSPath)
		{
			return false;
		}
		if (ProjectileSelfSpawnDBCPath != other.ProjectileSelfSpawnDBCPath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SpawnPStoSpawnInterval, other.SpawnPStoSpawnInterval))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BulletLowestSpdCanPlayPS, other.BulletLowestSpdCanPlayPS))
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
		if (BeHitedProjectilePlayFXPath != other.BeHitedProjectilePlayFXPath)
		{
			return false;
		}
		if (BeHitedProjectilePostAKPath != other.BeHitedProjectilePostAKPath)
		{
			return false;
		}
		if (FXDestroyImmediatelyTag != other.FXDestroyImmediatelyTag)
		{
			return false;
		}
		if (HitChrAudioID != other.HitChrAudioID)
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
		if (ProjectileFXUseDBC != EGSYesNo.No)
		{
			num ^= ProjectileFXUseDBC.GetHashCode();
		}
		if (ProjectileSpawnPSPath.Length != 0)
		{
			num ^= ProjectileSpawnPSPath.GetHashCode();
		}
		if (ProjectileSelfSpawnDBCPath.Length != 0)
		{
			num ^= ProjectileSelfSpawnDBCPath.GetHashCode();
		}
		if (SpawnPStoSpawnInterval != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SpawnPStoSpawnInterval);
		}
		if (BulletLowestSpdCanPlayPS != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BulletLowestSpdCanPlayPS);
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
		if (BeHitedProjectilePlayFXPath.Length != 0)
		{
			num ^= BeHitedProjectilePlayFXPath.GetHashCode();
		}
		if (BeHitedProjectilePostAKPath.Length != 0)
		{
			num ^= BeHitedProjectilePostAKPath.GetHashCode();
		}
		if (FXDestroyImmediatelyTag.Length != 0)
		{
			num ^= FXDestroyImmediatelyTag.GetHashCode();
		}
		if (HitChrAudioID != 0)
		{
			num ^= HitChrAudioID.GetHashCode();
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
		if (ProjectileFXUseDBC != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ProjectileFXUseDBC);
		}
		if (ProjectileSpawnPSPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ProjectileSpawnPSPath);
		}
		if (ProjectileSelfSpawnDBCPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ProjectileSelfSpawnDBCPath);
		}
		if (SpawnPStoSpawnInterval != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(SpawnPStoSpawnInterval);
		}
		if (BulletLowestSpdCanPlayPS != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(BulletLowestSpdCanPlayPS);
		}
		if (BulletHitItemPSPath.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(BulletHitItemPSPath);
		}
		if (BulletHitUnitPSPath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(BulletHitUnitPSPath);
		}
		if (BulletLifeOverPSPath.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(BulletLifeOverPSPath);
		}
		if (BeHitedProjectilePlayFXPath.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(BeHitedProjectilePlayFXPath);
		}
		if (BeHitedProjectilePostAKPath.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(BeHitedProjectilePostAKPath);
		}
		if (FXDestroyImmediatelyTag.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(FXDestroyImmediatelyTag);
		}
		if (HitChrAudioID != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(HitChrAudioID);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(114);
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
		if (ProjectileFXUseDBC != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ProjectileFXUseDBC);
		}
		if (ProjectileSpawnPSPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ProjectileSpawnPSPath);
		}
		if (ProjectileSelfSpawnDBCPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ProjectileSelfSpawnDBCPath);
		}
		if (SpawnPStoSpawnInterval != 0f)
		{
			num += 5;
		}
		if (BulletLowestSpdCanPlayPS != 0f)
		{
			num += 5;
		}
		if (BulletHitItemPSPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BulletHitItemPSPath);
		}
		if (BulletHitUnitPSPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BulletHitUnitPSPath);
		}
		if (BulletLifeOverPSPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BulletLifeOverPSPath);
		}
		if (BeHitedProjectilePlayFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BeHitedProjectilePlayFXPath);
		}
		if (BeHitedProjectilePostAKPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BeHitedProjectilePostAKPath);
		}
		if (FXDestroyImmediatelyTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FXDestroyImmediatelyTag);
		}
		if (HitChrAudioID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HitChrAudioID);
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

	public void MergeFrom(FUStProjectileDispDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ProjectileFXUseDBC != EGSYesNo.No)
			{
				ProjectileFXUseDBC = other.ProjectileFXUseDBC;
			}
			if (other.ProjectileSpawnPSPath.Length != 0)
			{
				ProjectileSpawnPSPath = other.ProjectileSpawnPSPath;
			}
			if (other.ProjectileSelfSpawnDBCPath.Length != 0)
			{
				ProjectileSelfSpawnDBCPath = other.ProjectileSelfSpawnDBCPath;
			}
			if (other.SpawnPStoSpawnInterval != 0f)
			{
				SpawnPStoSpawnInterval = other.SpawnPStoSpawnInterval;
			}
			if (other.BulletLowestSpdCanPlayPS != 0f)
			{
				BulletLowestSpdCanPlayPS = other.BulletLowestSpdCanPlayPS;
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
			if (other.BeHitedProjectilePlayFXPath.Length != 0)
			{
				BeHitedProjectilePlayFXPath = other.BeHitedProjectilePlayFXPath;
			}
			if (other.BeHitedProjectilePostAKPath.Length != 0)
			{
				BeHitedProjectilePostAKPath = other.BeHitedProjectilePostAKPath;
			}
			if (other.FXDestroyImmediatelyTag.Length != 0)
			{
				FXDestroyImmediatelyTag = other.FXDestroyImmediatelyTag;
			}
			if (other.HitChrAudioID != 0)
			{
				HitChrAudioID = other.HitChrAudioID;
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
				ProjectileFXUseDBC = (EGSYesNo)input.ReadEnum();
				break;
			case 26u:
				ProjectileSpawnPSPath = input.ReadString();
				break;
			case 34u:
				ProjectileSelfSpawnDBCPath = input.ReadString();
				break;
			case 45u:
				SpawnPStoSpawnInterval = input.ReadFloat();
				break;
			case 53u:
				BulletLowestSpdCanPlayPS = input.ReadFloat();
				break;
			case 58u:
				BulletHitItemPSPath = input.ReadString();
				break;
			case 66u:
				BulletHitUnitPSPath = input.ReadString();
				break;
			case 74u:
				BulletLifeOverPSPath = input.ReadString();
				break;
			case 82u:
				BeHitedProjectilePlayFXPath = input.ReadString();
				break;
			case 90u:
				BeHitedProjectilePostAKPath = input.ReadString();
				break;
			case 98u:
				FXDestroyImmediatelyTag = input.ReadString();
				break;
			case 104u:
				HitChrAudioID = input.ReadInt32();
				break;
			case 114u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
