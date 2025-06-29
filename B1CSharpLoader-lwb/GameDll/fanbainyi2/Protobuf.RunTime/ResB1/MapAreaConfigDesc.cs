using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class MapAreaConfigDesc : IMessage<MapAreaConfigDesc>, IMessage, IEquatable<MapAreaConfigDesc>, IDeepCloneable<MapAreaConfigDesc>
{
	private static readonly MessageParser<MapAreaConfigDesc> _parser = new MessageParser<MapAreaConfigDesc>(() => new MapAreaConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int levelId_;

	private int areaId_;

	private string areaName_ = "";

	private string areaColor_ = "";

	private int areaMonsterCount_;

	private int mapLayer_;

	private int zAxisLower_;

	private int zAxisUpper_;

	private int localizationTag_;

	private int mapSpriteId_;

	private EMapPositioningType mapPositioningType_;

	private int rebirthPointAreaId_;

	private float xOffset_;

	private float yOffset_;

	private float rotationOffset_;

	public static MessageParser<MapAreaConfigDesc> Parser => _parser;

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

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public int AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	public string AreaName
	{
		get
		{
			return areaName_;
		}
		set
		{
			areaName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AreaColor
	{
		get
		{
			return areaColor_;
		}
		set
		{
			areaColor_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int AreaMonsterCount
	{
		get
		{
			return areaMonsterCount_;
		}
		set
		{
			areaMonsterCount_ = value;
		}
	}

	public int MapLayer
	{
		get
		{
			return mapLayer_;
		}
		set
		{
			mapLayer_ = value;
		}
	}

	public int ZAxisLower
	{
		get
		{
			return zAxisLower_;
		}
		set
		{
			zAxisLower_ = value;
		}
	}

	public int ZAxisUpper
	{
		get
		{
			return zAxisUpper_;
		}
		set
		{
			zAxisUpper_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public int MapSpriteId
	{
		get
		{
			return mapSpriteId_;
		}
		set
		{
			mapSpriteId_ = value;
		}
	}

	public EMapPositioningType MapPositioningType
	{
		get
		{
			return mapPositioningType_;
		}
		set
		{
			mapPositioningType_ = value;
		}
	}

	public int RebirthPointAreaId
	{
		get
		{
			return rebirthPointAreaId_;
		}
		set
		{
			rebirthPointAreaId_ = value;
		}
	}

	public float XOffset
	{
		get
		{
			return xOffset_;
		}
		set
		{
			xOffset_ = value;
		}
	}

	public float YOffset
	{
		get
		{
			return yOffset_;
		}
		set
		{
			yOffset_ = value;
		}
	}

	public float RotationOffset
	{
		get
		{
			return rotationOffset_;
		}
		set
		{
			rotationOffset_ = value;
		}
	}

	public MapAreaConfigDesc()
	{
	}

	public MapAreaConfigDesc(MapAreaConfigDesc other)
		: this()
	{
		id_ = other.id_;
		levelId_ = other.levelId_;
		areaId_ = other.areaId_;
		areaName_ = other.areaName_;
		areaColor_ = other.areaColor_;
		areaMonsterCount_ = other.areaMonsterCount_;
		mapLayer_ = other.mapLayer_;
		zAxisLower_ = other.zAxisLower_;
		zAxisUpper_ = other.zAxisUpper_;
		localizationTag_ = other.localizationTag_;
		mapSpriteId_ = other.mapSpriteId_;
		mapPositioningType_ = other.mapPositioningType_;
		rebirthPointAreaId_ = other.rebirthPointAreaId_;
		xOffset_ = other.xOffset_;
		yOffset_ = other.yOffset_;
		rotationOffset_ = other.rotationOffset_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MapAreaConfigDesc Clone()
	{
		return new MapAreaConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MapAreaConfigDesc);
	}

	public bool Equals(MapAreaConfigDesc other)
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
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (AreaName != other.AreaName)
		{
			return false;
		}
		if (AreaColor != other.AreaColor)
		{
			return false;
		}
		if (AreaMonsterCount != other.AreaMonsterCount)
		{
			return false;
		}
		if (MapLayer != other.MapLayer)
		{
			return false;
		}
		if (ZAxisLower != other.ZAxisLower)
		{
			return false;
		}
		if (ZAxisUpper != other.ZAxisUpper)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (MapSpriteId != other.MapSpriteId)
		{
			return false;
		}
		if (MapPositioningType != other.MapPositioningType)
		{
			return false;
		}
		if (RebirthPointAreaId != other.RebirthPointAreaId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(XOffset, other.XOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(YOffset, other.YOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RotationOffset, other.RotationOffset))
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
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (AreaName.Length != 0)
		{
			num ^= AreaName.GetHashCode();
		}
		if (AreaColor.Length != 0)
		{
			num ^= AreaColor.GetHashCode();
		}
		if (AreaMonsterCount != 0)
		{
			num ^= AreaMonsterCount.GetHashCode();
		}
		if (MapLayer != 0)
		{
			num ^= MapLayer.GetHashCode();
		}
		if (ZAxisLower != 0)
		{
			num ^= ZAxisLower.GetHashCode();
		}
		if (ZAxisUpper != 0)
		{
			num ^= ZAxisUpper.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (MapSpriteId != 0)
		{
			num ^= MapSpriteId.GetHashCode();
		}
		if (MapPositioningType != EMapPositioningType.None)
		{
			num ^= MapPositioningType.GetHashCode();
		}
		if (RebirthPointAreaId != 0)
		{
			num ^= RebirthPointAreaId.GetHashCode();
		}
		if (XOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(XOffset);
		}
		if (YOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(YOffset);
		}
		if (RotationOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RotationOffset);
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
		if (LevelId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LevelId);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AreaId);
		}
		if (AreaName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(AreaName);
		}
		if (AreaColor.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(AreaColor);
		}
		if (AreaMonsterCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(AreaMonsterCount);
		}
		if (MapLayer != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(MapLayer);
		}
		if (ZAxisLower != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(ZAxisLower);
		}
		if (ZAxisUpper != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ZAxisUpper);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(LocalizationTag);
		}
		if (MapSpriteId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(MapSpriteId);
		}
		if (MapPositioningType != EMapPositioningType.None)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)MapPositioningType);
		}
		if (RebirthPointAreaId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(RebirthPointAreaId);
		}
		if (XOffset != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(XOffset);
		}
		if (YOffset != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(YOffset);
		}
		if (RotationOffset != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(RotationOffset);
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
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AreaId);
		}
		if (AreaName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AreaName);
		}
		if (AreaColor.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AreaColor);
		}
		if (AreaMonsterCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AreaMonsterCount);
		}
		if (MapLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapLayer);
		}
		if (ZAxisLower != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ZAxisLower);
		}
		if (ZAxisUpper != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ZAxisUpper);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (MapSpriteId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapSpriteId);
		}
		if (MapPositioningType != EMapPositioningType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MapPositioningType);
		}
		if (RebirthPointAreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RebirthPointAreaId);
		}
		if (XOffset != 0f)
		{
			num += 5;
		}
		if (YOffset != 0f)
		{
			num += 5;
		}
		if (RotationOffset != 0f)
		{
			num += 6;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MapAreaConfigDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			if (other.AreaName.Length != 0)
			{
				AreaName = other.AreaName;
			}
			if (other.AreaColor.Length != 0)
			{
				AreaColor = other.AreaColor;
			}
			if (other.AreaMonsterCount != 0)
			{
				AreaMonsterCount = other.AreaMonsterCount;
			}
			if (other.MapLayer != 0)
			{
				MapLayer = other.MapLayer;
			}
			if (other.ZAxisLower != 0)
			{
				ZAxisLower = other.ZAxisLower;
			}
			if (other.ZAxisUpper != 0)
			{
				ZAxisUpper = other.ZAxisUpper;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.MapSpriteId != 0)
			{
				MapSpriteId = other.MapSpriteId;
			}
			if (other.MapPositioningType != EMapPositioningType.None)
			{
				MapPositioningType = other.MapPositioningType;
			}
			if (other.RebirthPointAreaId != 0)
			{
				RebirthPointAreaId = other.RebirthPointAreaId;
			}
			if (other.XOffset != 0f)
			{
				XOffset = other.XOffset;
			}
			if (other.YOffset != 0f)
			{
				YOffset = other.YOffset;
			}
			if (other.RotationOffset != 0f)
			{
				RotationOffset = other.RotationOffset;
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
			case 16u:
				LevelId = input.ReadInt32();
				break;
			case 24u:
				AreaId = input.ReadInt32();
				break;
			case 34u:
				AreaName = input.ReadString();
				break;
			case 42u:
				AreaColor = input.ReadString();
				break;
			case 48u:
				AreaMonsterCount = input.ReadInt32();
				break;
			case 56u:
				MapLayer = input.ReadInt32();
				break;
			case 64u:
				ZAxisLower = input.ReadInt32();
				break;
			case 72u:
				ZAxisUpper = input.ReadInt32();
				break;
			case 80u:
				LocalizationTag = input.ReadInt32();
				break;
			case 88u:
				MapSpriteId = input.ReadInt32();
				break;
			case 96u:
				MapPositioningType = (EMapPositioningType)input.ReadEnum();
				break;
			case 104u:
				RebirthPointAreaId = input.ReadInt32();
				break;
			case 117u:
				XOffset = input.ReadFloat();
				break;
			case 125u:
				YOffset = input.ReadFloat();
				break;
			case 133u:
				RotationOffset = input.ReadFloat();
				break;
			}
		}
	}
}
