using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class FUStB2DBulletCommDesc : IMessage<FUStB2DBulletCommDesc>, IMessage, IEquatable<FUStB2DBulletCommDesc>, IDeepCloneable<FUStB2DBulletCommDesc>
{
	private static readonly MessageParser<FUStB2DBulletCommDesc> _parser = new MessageParser<FUStB2DBulletCommDesc>(() => new FUStB2DBulletCommDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string bulletBP_ = "";

	private EB2DBulletType bulletType_;

	private EB2DBulletShape bulletShape_;

	private int bulletRangeParam1_;

	private int bulletRangeParam2_;

	private int flySpeed_;

	private int destroyOnHit_;

	private int flyTimeMax_;

	private string bulletBornAnchor_ = "";

	private float dispDestroyDelay_;

	private string hitEfxPath_ = "";

	private int bulletShootDelay_;

	private int bulletShootToFloor_;

	private string extraEfxPath_ = "";

	private int noRepeatDamage_;

	public static MessageParser<FUStB2DBulletCommDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string BulletBP
	{
		get
		{
			return bulletBP_;
		}
		set
		{
			bulletBP_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EB2DBulletType BulletType
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

	public EB2DBulletShape BulletShape
	{
		get
		{
			return bulletShape_;
		}
		set
		{
			bulletShape_ = value;
		}
	}

	public int BulletRangeParam1
	{
		get
		{
			return bulletRangeParam1_;
		}
		set
		{
			bulletRangeParam1_ = value;
		}
	}

	public int BulletRangeParam2
	{
		get
		{
			return bulletRangeParam2_;
		}
		set
		{
			bulletRangeParam2_ = value;
		}
	}

	public int FlySpeed
	{
		get
		{
			return flySpeed_;
		}
		set
		{
			flySpeed_ = value;
		}
	}

	public int DestroyOnHit
	{
		get
		{
			return destroyOnHit_;
		}
		set
		{
			destroyOnHit_ = value;
		}
	}

	public int FlyTimeMax
	{
		get
		{
			return flyTimeMax_;
		}
		set
		{
			flyTimeMax_ = value;
		}
	}

	public string BulletBornAnchor
	{
		get
		{
			return bulletBornAnchor_;
		}
		set
		{
			bulletBornAnchor_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float DispDestroyDelay
	{
		get
		{
			return dispDestroyDelay_;
		}
		set
		{
			dispDestroyDelay_ = value;
		}
	}

	public string HitEfxPath
	{
		get
		{
			return hitEfxPath_;
		}
		set
		{
			hitEfxPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int BulletShootDelay
	{
		get
		{
			return bulletShootDelay_;
		}
		set
		{
			bulletShootDelay_ = value;
		}
	}

	public int BulletShootToFloor
	{
		get
		{
			return bulletShootToFloor_;
		}
		set
		{
			bulletShootToFloor_ = value;
		}
	}

	public string ExtraEfxPath
	{
		get
		{
			return extraEfxPath_;
		}
		set
		{
			extraEfxPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int NoRepeatDamage
	{
		get
		{
			return noRepeatDamage_;
		}
		set
		{
			noRepeatDamage_ = value;
		}
	}

	public FUStB2DBulletCommDesc()
	{
	}

	public FUStB2DBulletCommDesc(FUStB2DBulletCommDesc other)
		: this()
	{
		id_ = other.id_;
		bulletBP_ = other.bulletBP_;
		bulletType_ = other.bulletType_;
		bulletShape_ = other.bulletShape_;
		bulletRangeParam1_ = other.bulletRangeParam1_;
		bulletRangeParam2_ = other.bulletRangeParam2_;
		flySpeed_ = other.flySpeed_;
		destroyOnHit_ = other.destroyOnHit_;
		flyTimeMax_ = other.flyTimeMax_;
		bulletBornAnchor_ = other.bulletBornAnchor_;
		dispDestroyDelay_ = other.dispDestroyDelay_;
		hitEfxPath_ = other.hitEfxPath_;
		bulletShootDelay_ = other.bulletShootDelay_;
		bulletShootToFloor_ = other.bulletShootToFloor_;
		extraEfxPath_ = other.extraEfxPath_;
		noRepeatDamage_ = other.noRepeatDamage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DBulletCommDesc Clone()
	{
		return new FUStB2DBulletCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DBulletCommDesc);
	}

	public bool Equals(FUStB2DBulletCommDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (BulletBP != other.BulletBP)
		{
			return false;
		}
		if (BulletType != other.BulletType)
		{
			return false;
		}
		if (BulletShape != other.BulletShape)
		{
			return false;
		}
		if (BulletRangeParam1 != other.BulletRangeParam1)
		{
			return false;
		}
		if (BulletRangeParam2 != other.BulletRangeParam2)
		{
			return false;
		}
		if (FlySpeed != other.FlySpeed)
		{
			return false;
		}
		if (DestroyOnHit != other.DestroyOnHit)
		{
			return false;
		}
		if (FlyTimeMax != other.FlyTimeMax)
		{
			return false;
		}
		if (BulletBornAnchor != other.BulletBornAnchor)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DispDestroyDelay, other.DispDestroyDelay))
		{
			return false;
		}
		if (HitEfxPath != other.HitEfxPath)
		{
			return false;
		}
		if (BulletShootDelay != other.BulletShootDelay)
		{
			return false;
		}
		if (BulletShootToFloor != other.BulletShootToFloor)
		{
			return false;
		}
		if (ExtraEfxPath != other.ExtraEfxPath)
		{
			return false;
		}
		if (NoRepeatDamage != other.NoRepeatDamage)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (BulletBP.Length != 0)
		{
			num ^= BulletBP.GetHashCode();
		}
		if (BulletType != EB2DBulletType.FixSpd)
		{
			num ^= BulletType.GetHashCode();
		}
		if (BulletShape != EB2DBulletShape.Circle)
		{
			num ^= BulletShape.GetHashCode();
		}
		if (BulletRangeParam1 != 0)
		{
			num ^= BulletRangeParam1.GetHashCode();
		}
		if (BulletRangeParam2 != 0)
		{
			num ^= BulletRangeParam2.GetHashCode();
		}
		if (FlySpeed != 0)
		{
			num ^= FlySpeed.GetHashCode();
		}
		if (DestroyOnHit != 0)
		{
			num ^= DestroyOnHit.GetHashCode();
		}
		if (FlyTimeMax != 0)
		{
			num ^= FlyTimeMax.GetHashCode();
		}
		if (BulletBornAnchor.Length != 0)
		{
			num ^= BulletBornAnchor.GetHashCode();
		}
		if (DispDestroyDelay != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DispDestroyDelay);
		}
		if (HitEfxPath.Length != 0)
		{
			num ^= HitEfxPath.GetHashCode();
		}
		if (BulletShootDelay != 0)
		{
			num ^= BulletShootDelay.GetHashCode();
		}
		if (BulletShootToFloor != 0)
		{
			num ^= BulletShootToFloor.GetHashCode();
		}
		if (ExtraEfxPath.Length != 0)
		{
			num ^= ExtraEfxPath.GetHashCode();
		}
		if (NoRepeatDamage != 0)
		{
			num ^= NoRepeatDamage.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (BulletBP.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BulletBP);
		}
		if (BulletType != EB2DBulletType.FixSpd)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)BulletType);
		}
		if (BulletShape != EB2DBulletShape.Circle)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)BulletShape);
		}
		if (BulletRangeParam1 != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BulletRangeParam1);
		}
		if (BulletRangeParam2 != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BulletRangeParam2);
		}
		if (FlySpeed != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(FlySpeed);
		}
		if (DestroyOnHit != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(DestroyOnHit);
		}
		if (FlyTimeMax != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(FlyTimeMax);
		}
		if (BulletBornAnchor.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(BulletBornAnchor);
		}
		if (DispDestroyDelay != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(DispDestroyDelay);
		}
		if (HitEfxPath.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(HitEfxPath);
		}
		if (BulletShootDelay != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(BulletShootDelay);
		}
		if (BulletShootToFloor != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(BulletShootToFloor);
		}
		if (ExtraEfxPath.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(ExtraEfxPath);
		}
		if (NoRepeatDamage != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(NoRepeatDamage);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (BulletBP.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BulletBP);
		}
		if (BulletType != EB2DBulletType.FixSpd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BulletType);
		}
		if (BulletShape != EB2DBulletShape.Circle)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BulletShape);
		}
		if (BulletRangeParam1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BulletRangeParam1);
		}
		if (BulletRangeParam2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BulletRangeParam2);
		}
		if (FlySpeed != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FlySpeed);
		}
		if (DestroyOnHit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DestroyOnHit);
		}
		if (FlyTimeMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FlyTimeMax);
		}
		if (BulletBornAnchor.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BulletBornAnchor);
		}
		if (DispDestroyDelay != 0f)
		{
			num += 5;
		}
		if (HitEfxPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HitEfxPath);
		}
		if (BulletShootDelay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BulletShootDelay);
		}
		if (BulletShootToFloor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BulletShootToFloor);
		}
		if (ExtraEfxPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ExtraEfxPath);
		}
		if (NoRepeatDamage != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NoRepeatDamage);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DBulletCommDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.BulletBP.Length != 0)
			{
				BulletBP = other.BulletBP;
			}
			if (other.BulletType != EB2DBulletType.FixSpd)
			{
				BulletType = other.BulletType;
			}
			if (other.BulletShape != EB2DBulletShape.Circle)
			{
				BulletShape = other.BulletShape;
			}
			if (other.BulletRangeParam1 != 0)
			{
				BulletRangeParam1 = other.BulletRangeParam1;
			}
			if (other.BulletRangeParam2 != 0)
			{
				BulletRangeParam2 = other.BulletRangeParam2;
			}
			if (other.FlySpeed != 0)
			{
				FlySpeed = other.FlySpeed;
			}
			if (other.DestroyOnHit != 0)
			{
				DestroyOnHit = other.DestroyOnHit;
			}
			if (other.FlyTimeMax != 0)
			{
				FlyTimeMax = other.FlyTimeMax;
			}
			if (other.BulletBornAnchor.Length != 0)
			{
				BulletBornAnchor = other.BulletBornAnchor;
			}
			if (other.DispDestroyDelay != 0f)
			{
				DispDestroyDelay = other.DispDestroyDelay;
			}
			if (other.HitEfxPath.Length != 0)
			{
				HitEfxPath = other.HitEfxPath;
			}
			if (other.BulletShootDelay != 0)
			{
				BulletShootDelay = other.BulletShootDelay;
			}
			if (other.BulletShootToFloor != 0)
			{
				BulletShootToFloor = other.BulletShootToFloor;
			}
			if (other.ExtraEfxPath.Length != 0)
			{
				ExtraEfxPath = other.ExtraEfxPath;
			}
			if (other.NoRepeatDamage != 0)
			{
				NoRepeatDamage = other.NoRepeatDamage;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				BulletBP = input.ReadString();
				break;
			case 24u:
				BulletType = (EB2DBulletType)input.ReadEnum();
				break;
			case 32u:
				BulletShape = (EB2DBulletShape)input.ReadEnum();
				break;
			case 40u:
				BulletRangeParam1 = input.ReadInt32();
				break;
			case 48u:
				BulletRangeParam2 = input.ReadInt32();
				break;
			case 56u:
				FlySpeed = input.ReadInt32();
				break;
			case 64u:
				DestroyOnHit = input.ReadInt32();
				break;
			case 72u:
				FlyTimeMax = input.ReadInt32();
				break;
			case 82u:
				BulletBornAnchor = input.ReadString();
				break;
			case 93u:
				DispDestroyDelay = input.ReadFloat();
				break;
			case 98u:
				HitEfxPath = input.ReadString();
				break;
			case 104u:
				BulletShootDelay = input.ReadInt32();
				break;
			case 112u:
				BulletShootToFloor = input.ReadInt32();
				break;
			case 122u:
				ExtraEfxPath = input.ReadString();
				break;
			case 128u:
				NoRepeatDamage = input.ReadInt32();
				break;
			}
		}
	}
}
