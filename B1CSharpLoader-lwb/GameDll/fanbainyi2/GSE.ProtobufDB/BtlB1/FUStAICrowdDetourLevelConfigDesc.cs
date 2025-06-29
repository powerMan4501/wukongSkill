using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAICrowdDetourLevelConfigDesc : IMessage<FUStAICrowdDetourLevelConfigDesc>, IMessage, IEquatable<FUStAICrowdDetourLevelConfigDesc>, IDeepCloneable<FUStAICrowdDetourLevelConfigDesc>
{
	private static readonly MessageParser<FUStAICrowdDetourLevelConfigDesc> _parser = new MessageParser<FUStAICrowdDetourLevelConfigDesc>(() => new FUStAICrowdDetourLevelConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EUnitAIDetourCrowdType detourCrowdType_;

	private EUnitAICrowdQualityLevel unitAICrowdQualityLevel_;

	private float separationWeight_;

	private float collisionQueryRange_;

	private float pathOptimizationRange_;

	public static MessageParser<FUStAICrowdDetourLevelConfigDesc> Parser => _parser;

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

	public EUnitAIDetourCrowdType DetourCrowdType
	{
		get
		{
			return detourCrowdType_;
		}
		set
		{
			detourCrowdType_ = value;
		}
	}

	public EUnitAICrowdQualityLevel UnitAICrowdQualityLevel
	{
		get
		{
			return unitAICrowdQualityLevel_;
		}
		set
		{
			unitAICrowdQualityLevel_ = value;
		}
	}

	public float SeparationWeight
	{
		get
		{
			return separationWeight_;
		}
		set
		{
			separationWeight_ = value;
		}
	}

	public float CollisionQueryRange
	{
		get
		{
			return collisionQueryRange_;
		}
		set
		{
			collisionQueryRange_ = value;
		}
	}

	public float PathOptimizationRange
	{
		get
		{
			return pathOptimizationRange_;
		}
		set
		{
			pathOptimizationRange_ = value;
		}
	}

	public FUStAICrowdDetourLevelConfigDesc()
	{
	}

	public FUStAICrowdDetourLevelConfigDesc(FUStAICrowdDetourLevelConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		detourCrowdType_ = other.detourCrowdType_;
		unitAICrowdQualityLevel_ = other.unitAICrowdQualityLevel_;
		separationWeight_ = other.separationWeight_;
		collisionQueryRange_ = other.collisionQueryRange_;
		pathOptimizationRange_ = other.pathOptimizationRange_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAICrowdDetourLevelConfigDesc Clone()
	{
		return new FUStAICrowdDetourLevelConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAICrowdDetourLevelConfigDesc);
	}

	public bool Equals(FUStAICrowdDetourLevelConfigDesc other)
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
		if (DetourCrowdType != other.DetourCrowdType)
		{
			return false;
		}
		if (UnitAICrowdQualityLevel != other.UnitAICrowdQualityLevel)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SeparationWeight, other.SeparationWeight))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CollisionQueryRange, other.CollisionQueryRange))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PathOptimizationRange, other.PathOptimizationRange))
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
		if (DetourCrowdType != EUnitAIDetourCrowdType.None)
		{
			num ^= DetourCrowdType.GetHashCode();
		}
		if (UnitAICrowdQualityLevel != EUnitAICrowdQualityLevel.Low)
		{
			num ^= UnitAICrowdQualityLevel.GetHashCode();
		}
		if (SeparationWeight != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SeparationWeight);
		}
		if (CollisionQueryRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CollisionQueryRange);
		}
		if (PathOptimizationRange != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PathOptimizationRange);
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
		if (DetourCrowdType != EUnitAIDetourCrowdType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DetourCrowdType);
		}
		if (UnitAICrowdQualityLevel != EUnitAICrowdQualityLevel.Low)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)UnitAICrowdQualityLevel);
		}
		if (SeparationWeight != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(SeparationWeight);
		}
		if (CollisionQueryRange != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(CollisionQueryRange);
		}
		if (PathOptimizationRange != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(PathOptimizationRange);
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
		if (DetourCrowdType != EUnitAIDetourCrowdType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DetourCrowdType);
		}
		if (UnitAICrowdQualityLevel != EUnitAICrowdQualityLevel.Low)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnitAICrowdQualityLevel);
		}
		if (SeparationWeight != 0f)
		{
			num += 5;
		}
		if (CollisionQueryRange != 0f)
		{
			num += 5;
		}
		if (PathOptimizationRange != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAICrowdDetourLevelConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.DetourCrowdType != EUnitAIDetourCrowdType.None)
			{
				DetourCrowdType = other.DetourCrowdType;
			}
			if (other.UnitAICrowdQualityLevel != EUnitAICrowdQualityLevel.Low)
			{
				UnitAICrowdQualityLevel = other.UnitAICrowdQualityLevel;
			}
			if (other.SeparationWeight != 0f)
			{
				SeparationWeight = other.SeparationWeight;
			}
			if (other.CollisionQueryRange != 0f)
			{
				CollisionQueryRange = other.CollisionQueryRange;
			}
			if (other.PathOptimizationRange != 0f)
			{
				PathOptimizationRange = other.PathOptimizationRange;
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
				DetourCrowdType = (EUnitAIDetourCrowdType)input.ReadEnum();
				break;
			case 24u:
				UnitAICrowdQualityLevel = (EUnitAICrowdQualityLevel)input.ReadEnum();
				break;
			case 37u:
				SeparationWeight = input.ReadFloat();
				break;
			case 45u:
				CollisionQueryRange = input.ReadFloat();
				break;
			case 53u:
				PathOptimizationRange = input.ReadFloat();
				break;
			}
		}
	}
}
