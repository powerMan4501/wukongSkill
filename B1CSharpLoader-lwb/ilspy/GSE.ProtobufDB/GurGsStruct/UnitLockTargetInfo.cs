using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class UnitLockTargetInfo : IMessage<UnitLockTargetInfo>, IMessage, IEquatable<UnitLockTargetInfo>, IDeepCloneable<UnitLockTargetInfo>
{
	private static readonly MessageParser<UnitLockTargetInfo> _parser = new MessageParser<UnitLockTargetInfo>(() => new UnitLockTargetInfo());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private uint lockTargetEntity_;

	private int lockTargetWayType_;

	private int lockTargetType_;

	private string lockTargetSceneCompName_;

	private string lockTargetSkeletonSocketName_;

	private FVector lockPointLocation_;

	private int sourceType_;

	public static MessageParser<UnitLockTargetInfo> Parser => _parser;

	public uint LockTargetEntity
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return lockTargetEntity_;
			}
			return 0u;
		}
		set
		{
			_hasBits0 |= 1;
			lockTargetEntity_ = value;
		}
	}

	public bool HasLockTargetEntity => (_hasBits0 & 1) != 0;

	public int LockTargetWayType
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return lockTargetWayType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			lockTargetWayType_ = value;
		}
	}

	public bool HasLockTargetWayType => (_hasBits0 & 2) != 0;

	public int LockTargetType
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return lockTargetType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			lockTargetType_ = value;
		}
	}

	public bool HasLockTargetType => (_hasBits0 & 4) != 0;

	public string LockTargetSceneCompName
	{
		get
		{
			return lockTargetSceneCompName_ ?? "";
		}
		set
		{
			lockTargetSceneCompName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasLockTargetSceneCompName => lockTargetSceneCompName_ != null;

	public string LockTargetSkeletonSocketName
	{
		get
		{
			return lockTargetSkeletonSocketName_ ?? "";
		}
		set
		{
			lockTargetSkeletonSocketName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasLockTargetSkeletonSocketName => lockTargetSkeletonSocketName_ != null;

	public FVector LockPointLocation
	{
		get
		{
			return lockPointLocation_;
		}
		set
		{
			lockPointLocation_ = value;
		}
	}

	public int SourceType
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return sourceType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8;
			sourceType_ = value;
		}
	}

	public bool HasSourceType => (_hasBits0 & 8) != 0;

	public UnitLockTargetInfo()
	{
	}

	public UnitLockTargetInfo(UnitLockTargetInfo other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		lockTargetEntity_ = other.lockTargetEntity_;
		lockTargetWayType_ = other.lockTargetWayType_;
		lockTargetType_ = other.lockTargetType_;
		lockTargetSceneCompName_ = other.lockTargetSceneCompName_;
		lockTargetSkeletonSocketName_ = other.lockTargetSkeletonSocketName_;
		lockPointLocation_ = ((other.lockPointLocation_ != null) ? other.lockPointLocation_.Clone() : null);
		sourceType_ = other.sourceType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitLockTargetInfo Clone()
	{
		return new UnitLockTargetInfo(this);
	}

	public void ClearLockTargetEntity()
	{
		_hasBits0 &= -2;
	}

	public void ClearLockTargetWayType()
	{
		_hasBits0 &= -3;
	}

	public void ClearLockTargetType()
	{
		_hasBits0 &= -5;
	}

	public void ClearLockTargetSceneCompName()
	{
		lockTargetSceneCompName_ = null;
	}

	public void ClearLockTargetSkeletonSocketName()
	{
		lockTargetSkeletonSocketName_ = null;
	}

	public void ClearSourceType()
	{
		_hasBits0 &= -9;
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitLockTargetInfo);
	}

	public bool Equals(UnitLockTargetInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LockTargetEntity != other.LockTargetEntity)
		{
			return false;
		}
		if (LockTargetWayType != other.LockTargetWayType)
		{
			return false;
		}
		if (LockTargetType != other.LockTargetType)
		{
			return false;
		}
		if (LockTargetSceneCompName != other.LockTargetSceneCompName)
		{
			return false;
		}
		if (LockTargetSkeletonSocketName != other.LockTargetSkeletonSocketName)
		{
			return false;
		}
		if (!object.Equals(LockPointLocation, other.LockPointLocation))
		{
			return false;
		}
		if (SourceType != other.SourceType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasLockTargetEntity)
		{
			num ^= LockTargetEntity.GetHashCode();
		}
		if (HasLockTargetWayType)
		{
			num ^= LockTargetWayType.GetHashCode();
		}
		if (HasLockTargetType)
		{
			num ^= LockTargetType.GetHashCode();
		}
		if (HasLockTargetSceneCompName)
		{
			num ^= LockTargetSceneCompName.GetHashCode();
		}
		if (HasLockTargetSkeletonSocketName)
		{
			num ^= LockTargetSkeletonSocketName.GetHashCode();
		}
		if (lockPointLocation_ != null)
		{
			num ^= LockPointLocation.GetHashCode();
		}
		if (HasSourceType)
		{
			num ^= SourceType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasLockTargetEntity)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LockTargetEntity);
		}
		if (HasLockTargetWayType)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LockTargetWayType);
		}
		if (HasLockTargetType)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LockTargetType);
		}
		if (HasLockTargetSceneCompName)
		{
			output.WriteRawTag(34);
			output.WriteString(LockTargetSceneCompName);
		}
		if (HasLockTargetSkeletonSocketName)
		{
			output.WriteRawTag(42);
			output.WriteString(LockTargetSkeletonSocketName);
		}
		if (lockPointLocation_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(LockPointLocation);
		}
		if (HasSourceType)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SourceType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasLockTargetEntity)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LockTargetEntity);
		}
		if (HasLockTargetWayType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LockTargetWayType);
		}
		if (HasLockTargetType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LockTargetType);
		}
		if (HasLockTargetSceneCompName)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LockTargetSceneCompName);
		}
		if (HasLockTargetSkeletonSocketName)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LockTargetSkeletonSocketName);
		}
		if (lockPointLocation_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LockPointLocation);
		}
		if (HasSourceType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SourceType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UnitLockTargetInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HasLockTargetEntity)
		{
			LockTargetEntity = other.LockTargetEntity;
		}
		if (other.HasLockTargetWayType)
		{
			LockTargetWayType = other.LockTargetWayType;
		}
		if (other.HasLockTargetType)
		{
			LockTargetType = other.LockTargetType;
		}
		if (other.HasLockTargetSceneCompName)
		{
			LockTargetSceneCompName = other.LockTargetSceneCompName;
		}
		if (other.HasLockTargetSkeletonSocketName)
		{
			LockTargetSkeletonSocketName = other.LockTargetSkeletonSocketName;
		}
		if (other.lockPointLocation_ != null)
		{
			if (lockPointLocation_ == null)
			{
				LockPointLocation = new FVector();
			}
			LockPointLocation.MergeFrom(other.LockPointLocation);
		}
		if (other.HasSourceType)
		{
			SourceType = other.SourceType;
		}
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
				LockTargetEntity = input.ReadUInt32();
				break;
			case 16u:
				LockTargetWayType = input.ReadInt32();
				break;
			case 24u:
				LockTargetType = input.ReadInt32();
				break;
			case 34u:
				LockTargetSceneCompName = input.ReadString();
				break;
			case 42u:
				LockTargetSkeletonSocketName = input.ReadString();
				break;
			case 50u:
				if (lockPointLocation_ == null)
				{
					LockPointLocation = new FVector();
				}
				input.ReadMessage(LockPointLocation);
				break;
			case 56u:
				SourceType = input.ReadInt32();
				break;
			}
		}
	}
}
