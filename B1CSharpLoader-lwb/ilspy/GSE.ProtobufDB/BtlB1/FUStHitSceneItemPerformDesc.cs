using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStHitSceneItemPerformDesc : IMessage<FUStHitSceneItemPerformDesc>, IMessage, IEquatable<FUStHitSceneItemPerformDesc>, IDeepCloneable<FUStHitSceneItemPerformDesc>
{
	private static readonly MessageParser<FUStHitSceneItemPerformDesc> _parser = new MessageParser<FUStHitSceneItemPerformDesc>(() => new FUStHitSceneItemPerformDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int skillEffectID_;

	private int unitResID_;

	private ESkillDamageType skillDamageType_;

	private ESceneItemSurfaceType sceneItemSurfaceType_;

	private string hitWorldItemFXPath_ = "";

	private string hitWorldItemDecalPath_ = "";

	private string hitGroundFXPath_ = "";

	private string hitGroundDirectionFXPath_ = "";

	private string hitGroundDecalPath_ = "";

	private string hitWorldItemAKPath_ = "";

	public static MessageParser<FUStHitSceneItemPerformDesc> Parser => _parser;

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

	public int SkillEffectID
	{
		get
		{
			return skillEffectID_;
		}
		set
		{
			skillEffectID_ = value;
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

	public ESceneItemSurfaceType SceneItemSurfaceType
	{
		get
		{
			return sceneItemSurfaceType_;
		}
		set
		{
			sceneItemSurfaceType_ = value;
		}
	}

	public string HitWorldItemFXPath
	{
		get
		{
			return hitWorldItemFXPath_;
		}
		set
		{
			hitWorldItemFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HitWorldItemDecalPath
	{
		get
		{
			return hitWorldItemDecalPath_;
		}
		set
		{
			hitWorldItemDecalPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HitGroundFXPath
	{
		get
		{
			return hitGroundFXPath_;
		}
		set
		{
			hitGroundFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HitGroundDirectionFXPath
	{
		get
		{
			return hitGroundDirectionFXPath_;
		}
		set
		{
			hitGroundDirectionFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HitGroundDecalPath
	{
		get
		{
			return hitGroundDecalPath_;
		}
		set
		{
			hitGroundDecalPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HitWorldItemAKPath
	{
		get
		{
			return hitWorldItemAKPath_;
		}
		set
		{
			hitWorldItemAKPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStHitSceneItemPerformDesc()
	{
	}

	public FUStHitSceneItemPerformDesc(FUStHitSceneItemPerformDesc other)
		: this()
	{
		iD_ = other.iD_;
		skillEffectID_ = other.skillEffectID_;
		unitResID_ = other.unitResID_;
		skillDamageType_ = other.skillDamageType_;
		sceneItemSurfaceType_ = other.sceneItemSurfaceType_;
		hitWorldItemFXPath_ = other.hitWorldItemFXPath_;
		hitWorldItemDecalPath_ = other.hitWorldItemDecalPath_;
		hitGroundFXPath_ = other.hitGroundFXPath_;
		hitGroundDirectionFXPath_ = other.hitGroundDirectionFXPath_;
		hitGroundDecalPath_ = other.hitGroundDecalPath_;
		hitWorldItemAKPath_ = other.hitWorldItemAKPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStHitSceneItemPerformDesc Clone()
	{
		return new FUStHitSceneItemPerformDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStHitSceneItemPerformDesc);
	}

	public bool Equals(FUStHitSceneItemPerformDesc other)
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
		if (SkillEffectID != other.SkillEffectID)
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
		if (SceneItemSurfaceType != other.SceneItemSurfaceType)
		{
			return false;
		}
		if (HitWorldItemFXPath != other.HitWorldItemFXPath)
		{
			return false;
		}
		if (HitWorldItemDecalPath != other.HitWorldItemDecalPath)
		{
			return false;
		}
		if (HitGroundFXPath != other.HitGroundFXPath)
		{
			return false;
		}
		if (HitGroundDirectionFXPath != other.HitGroundDirectionFXPath)
		{
			return false;
		}
		if (HitGroundDecalPath != other.HitGroundDecalPath)
		{
			return false;
		}
		if (HitWorldItemAKPath != other.HitWorldItemAKPath)
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
		if (SkillEffectID != 0)
		{
			num ^= SkillEffectID.GetHashCode();
		}
		if (UnitResID != 0)
		{
			num ^= UnitResID.GetHashCode();
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			num ^= SkillDamageType.GetHashCode();
		}
		if (SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			num ^= SceneItemSurfaceType.GetHashCode();
		}
		if (HitWorldItemFXPath.Length != 0)
		{
			num ^= HitWorldItemFXPath.GetHashCode();
		}
		if (HitWorldItemDecalPath.Length != 0)
		{
			num ^= HitWorldItemDecalPath.GetHashCode();
		}
		if (HitGroundFXPath.Length != 0)
		{
			num ^= HitGroundFXPath.GetHashCode();
		}
		if (HitGroundDirectionFXPath.Length != 0)
		{
			num ^= HitGroundDirectionFXPath.GetHashCode();
		}
		if (HitGroundDecalPath.Length != 0)
		{
			num ^= HitGroundDecalPath.GetHashCode();
		}
		if (HitWorldItemAKPath.Length != 0)
		{
			num ^= HitWorldItemAKPath.GetHashCode();
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
		if (SkillEffectID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SkillEffectID);
		}
		if (UnitResID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UnitResID);
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)SkillDamageType);
		}
		if (SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)SceneItemSurfaceType);
		}
		if (HitWorldItemFXPath.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(HitWorldItemFXPath);
		}
		if (HitWorldItemDecalPath.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(HitWorldItemDecalPath);
		}
		if (HitGroundFXPath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(HitGroundFXPath);
		}
		if (HitGroundDirectionFXPath.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(HitGroundDirectionFXPath);
		}
		if (HitGroundDecalPath.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(HitGroundDecalPath);
		}
		if (HitWorldItemAKPath.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(HitWorldItemAKPath);
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
		if (SkillEffectID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillEffectID);
		}
		if (UnitResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitResID);
		}
		if (SkillDamageType != ESkillDamageType.NoneEffectAtk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkillDamageType);
		}
		if (SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SceneItemSurfaceType);
		}
		if (HitWorldItemFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HitWorldItemFXPath);
		}
		if (HitWorldItemDecalPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HitWorldItemDecalPath);
		}
		if (HitGroundFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HitGroundFXPath);
		}
		if (HitGroundDirectionFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HitGroundDirectionFXPath);
		}
		if (HitGroundDecalPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HitGroundDecalPath);
		}
		if (HitWorldItemAKPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HitWorldItemAKPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStHitSceneItemPerformDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SkillEffectID != 0)
			{
				SkillEffectID = other.SkillEffectID;
			}
			if (other.UnitResID != 0)
			{
				UnitResID = other.UnitResID;
			}
			if (other.SkillDamageType != ESkillDamageType.NoneEffectAtk)
			{
				SkillDamageType = other.SkillDamageType;
			}
			if (other.SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
			{
				SceneItemSurfaceType = other.SceneItemSurfaceType;
			}
			if (other.HitWorldItemFXPath.Length != 0)
			{
				HitWorldItemFXPath = other.HitWorldItemFXPath;
			}
			if (other.HitWorldItemDecalPath.Length != 0)
			{
				HitWorldItemDecalPath = other.HitWorldItemDecalPath;
			}
			if (other.HitGroundFXPath.Length != 0)
			{
				HitGroundFXPath = other.HitGroundFXPath;
			}
			if (other.HitGroundDirectionFXPath.Length != 0)
			{
				HitGroundDirectionFXPath = other.HitGroundDirectionFXPath;
			}
			if (other.HitGroundDecalPath.Length != 0)
			{
				HitGroundDecalPath = other.HitGroundDecalPath;
			}
			if (other.HitWorldItemAKPath.Length != 0)
			{
				HitWorldItemAKPath = other.HitWorldItemAKPath;
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
				SkillEffectID = input.ReadInt32();
				break;
			case 24u:
				UnitResID = input.ReadInt32();
				break;
			case 32u:
				SkillDamageType = (ESkillDamageType)input.ReadEnum();
				break;
			case 40u:
				SceneItemSurfaceType = (ESceneItemSurfaceType)input.ReadEnum();
				break;
			case 50u:
				HitWorldItemFXPath = input.ReadString();
				break;
			case 58u:
				HitWorldItemDecalPath = input.ReadString();
				break;
			case 66u:
				HitGroundFXPath = input.ReadString();
				break;
			case 74u:
				HitGroundDirectionFXPath = input.ReadString();
				break;
			case 82u:
				HitGroundDecalPath = input.ReadString();
				break;
			case 90u:
				HitWorldItemAKPath = input.ReadString();
				break;
			}
		}
	}
}
