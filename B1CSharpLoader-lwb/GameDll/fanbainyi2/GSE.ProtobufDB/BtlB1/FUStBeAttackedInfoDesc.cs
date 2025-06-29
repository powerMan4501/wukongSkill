using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBeAttackedInfoDesc : IMessage<FUStBeAttackedInfoDesc>, IMessage, IEquatable<FUStBeAttackedInfoDesc>, IDeepCloneable<FUStBeAttackedInfoDesc>
{
	private static readonly MessageParser<FUStBeAttackedInfoDesc> _parser = new MessageParser<FUStBeAttackedInfoDesc>(() => new FUStBeAttackedInfoDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int unitBeAttackedBlendType_;

	private float physAnimImpulseScale_;

	private int minHitIntoCliffLevel_;

	private int maxHitIntoCliffLevel_;

	private string beAttackedPhysAnimAsset_ = "";

	private string unitBeAttackedConfigPath_ = "";

	private string guard_ = "";

	public static MessageParser<FUStBeAttackedInfoDesc> Parser => _parser;

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

	public int UnitBeAttackedBlendType
	{
		get
		{
			return unitBeAttackedBlendType_;
		}
		set
		{
			unitBeAttackedBlendType_ = value;
		}
	}

	public float PhysAnimImpulseScale
	{
		get
		{
			return physAnimImpulseScale_;
		}
		set
		{
			physAnimImpulseScale_ = value;
		}
	}

	public int MinHitIntoCliffLevel
	{
		get
		{
			return minHitIntoCliffLevel_;
		}
		set
		{
			minHitIntoCliffLevel_ = value;
		}
	}

	public int MaxHitIntoCliffLevel
	{
		get
		{
			return maxHitIntoCliffLevel_;
		}
		set
		{
			maxHitIntoCliffLevel_ = value;
		}
	}

	public string BeAttackedPhysAnimAsset
	{
		get
		{
			return beAttackedPhysAnimAsset_;
		}
		set
		{
			beAttackedPhysAnimAsset_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string UnitBeAttackedConfigPath
	{
		get
		{
			return unitBeAttackedConfigPath_;
		}
		set
		{
			unitBeAttackedConfigPath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public FUStBeAttackedInfoDesc()
	{
	}

	public FUStBeAttackedInfoDesc(FUStBeAttackedInfoDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitBeAttackedBlendType_ = other.unitBeAttackedBlendType_;
		physAnimImpulseScale_ = other.physAnimImpulseScale_;
		minHitIntoCliffLevel_ = other.minHitIntoCliffLevel_;
		maxHitIntoCliffLevel_ = other.maxHitIntoCliffLevel_;
		beAttackedPhysAnimAsset_ = other.beAttackedPhysAnimAsset_;
		unitBeAttackedConfigPath_ = other.unitBeAttackedConfigPath_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBeAttackedInfoDesc Clone()
	{
		return new FUStBeAttackedInfoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBeAttackedInfoDesc);
	}

	public bool Equals(FUStBeAttackedInfoDesc other)
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
		if (UnitBeAttackedBlendType != other.UnitBeAttackedBlendType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PhysAnimImpulseScale, other.PhysAnimImpulseScale))
		{
			return false;
		}
		if (MinHitIntoCliffLevel != other.MinHitIntoCliffLevel)
		{
			return false;
		}
		if (MaxHitIntoCliffLevel != other.MaxHitIntoCliffLevel)
		{
			return false;
		}
		if (BeAttackedPhysAnimAsset != other.BeAttackedPhysAnimAsset)
		{
			return false;
		}
		if (UnitBeAttackedConfigPath != other.UnitBeAttackedConfigPath)
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
		if (UnitBeAttackedBlendType != 0)
		{
			num ^= UnitBeAttackedBlendType.GetHashCode();
		}
		if (PhysAnimImpulseScale != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PhysAnimImpulseScale);
		}
		if (MinHitIntoCliffLevel != 0)
		{
			num ^= MinHitIntoCliffLevel.GetHashCode();
		}
		if (MaxHitIntoCliffLevel != 0)
		{
			num ^= MaxHitIntoCliffLevel.GetHashCode();
		}
		if (BeAttackedPhysAnimAsset.Length != 0)
		{
			num ^= BeAttackedPhysAnimAsset.GetHashCode();
		}
		if (UnitBeAttackedConfigPath.Length != 0)
		{
			num ^= UnitBeAttackedConfigPath.GetHashCode();
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
		if (UnitBeAttackedBlendType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UnitBeAttackedBlendType);
		}
		if (PhysAnimImpulseScale != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(PhysAnimImpulseScale);
		}
		if (MinHitIntoCliffLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MinHitIntoCliffLevel);
		}
		if (MaxHitIntoCliffLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MaxHitIntoCliffLevel);
		}
		if (BeAttackedPhysAnimAsset.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(BeAttackedPhysAnimAsset);
		}
		if (UnitBeAttackedConfigPath.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(UnitBeAttackedConfigPath);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(66);
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
		if (UnitBeAttackedBlendType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitBeAttackedBlendType);
		}
		if (PhysAnimImpulseScale != 0f)
		{
			num += 5;
		}
		if (MinHitIntoCliffLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MinHitIntoCliffLevel);
		}
		if (MaxHitIntoCliffLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxHitIntoCliffLevel);
		}
		if (BeAttackedPhysAnimAsset.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BeAttackedPhysAnimAsset);
		}
		if (UnitBeAttackedConfigPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitBeAttackedConfigPath);
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

	public void MergeFrom(FUStBeAttackedInfoDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitBeAttackedBlendType != 0)
			{
				UnitBeAttackedBlendType = other.UnitBeAttackedBlendType;
			}
			if (other.PhysAnimImpulseScale != 0f)
			{
				PhysAnimImpulseScale = other.PhysAnimImpulseScale;
			}
			if (other.MinHitIntoCliffLevel != 0)
			{
				MinHitIntoCliffLevel = other.MinHitIntoCliffLevel;
			}
			if (other.MaxHitIntoCliffLevel != 0)
			{
				MaxHitIntoCliffLevel = other.MaxHitIntoCliffLevel;
			}
			if (other.BeAttackedPhysAnimAsset.Length != 0)
			{
				BeAttackedPhysAnimAsset = other.BeAttackedPhysAnimAsset;
			}
			if (other.UnitBeAttackedConfigPath.Length != 0)
			{
				UnitBeAttackedConfigPath = other.UnitBeAttackedConfigPath;
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
				UnitBeAttackedBlendType = input.ReadInt32();
				break;
			case 29u:
				PhysAnimImpulseScale = input.ReadFloat();
				break;
			case 32u:
				MinHitIntoCliffLevel = input.ReadInt32();
				break;
			case 40u:
				MaxHitIntoCliffLevel = input.ReadInt32();
				break;
			case 50u:
				BeAttackedPhysAnimAsset = input.ReadString();
				break;
			case 58u:
				UnitBeAttackedConfigPath = input.ReadString();
				break;
			case 66u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
