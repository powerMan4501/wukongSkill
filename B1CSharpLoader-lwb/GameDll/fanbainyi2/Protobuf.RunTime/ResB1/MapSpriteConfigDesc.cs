using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class MapSpriteConfigDesc : IMessage<MapSpriteConfigDesc>, IMessage, IEquatable<MapSpriteConfigDesc>, IDeepCloneable<MapSpriteConfigDesc>
{
	private static readonly MessageParser<MapSpriteConfigDesc> _parser = new MessageParser<MapSpriteConfigDesc>(() => new MapSpriteConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int mapAtlasId_;

	private int chapterId_;

	private float zoomOffset_;

	private float scale_;

	private float xOffset_;

	private float yOffset_;

	public static MessageParser<MapSpriteConfigDesc> Parser => _parser;

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

	public int MapAtlasId
	{
		get
		{
			return mapAtlasId_;
		}
		set
		{
			mapAtlasId_ = value;
		}
	}

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
		}
	}

	public float ZoomOffset
	{
		get
		{
			return zoomOffset_;
		}
		set
		{
			zoomOffset_ = value;
		}
	}

	public float Scale
	{
		get
		{
			return scale_;
		}
		set
		{
			scale_ = value;
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

	public MapSpriteConfigDesc()
	{
	}

	public MapSpriteConfigDesc(MapSpriteConfigDesc other)
		: this()
	{
		id_ = other.id_;
		mapAtlasId_ = other.mapAtlasId_;
		chapterId_ = other.chapterId_;
		zoomOffset_ = other.zoomOffset_;
		scale_ = other.scale_;
		xOffset_ = other.xOffset_;
		yOffset_ = other.yOffset_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MapSpriteConfigDesc Clone()
	{
		return new MapSpriteConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MapSpriteConfigDesc);
	}

	public bool Equals(MapSpriteConfigDesc other)
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
		if (MapAtlasId != other.MapAtlasId)
		{
			return false;
		}
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ZoomOffset, other.ZoomOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Scale, other.Scale))
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MapAtlasId != 0)
		{
			num ^= MapAtlasId.GetHashCode();
		}
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		if (ZoomOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ZoomOffset);
		}
		if (Scale != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Scale);
		}
		if (XOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(XOffset);
		}
		if (YOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(YOffset);
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
		if (MapAtlasId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MapAtlasId);
		}
		if (ChapterId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ChapterId);
		}
		if (ZoomOffset != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(ZoomOffset);
		}
		if (Scale != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(Scale);
		}
		if (XOffset != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(XOffset);
		}
		if (YOffset != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(YOffset);
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
		if (MapAtlasId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapAtlasId);
		}
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		if (ZoomOffset != 0f)
		{
			num += 5;
		}
		if (Scale != 0f)
		{
			num += 5;
		}
		if (XOffset != 0f)
		{
			num += 5;
		}
		if (YOffset != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MapSpriteConfigDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MapAtlasId != 0)
			{
				MapAtlasId = other.MapAtlasId;
			}
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
			}
			if (other.ZoomOffset != 0f)
			{
				ZoomOffset = other.ZoomOffset;
			}
			if (other.Scale != 0f)
			{
				Scale = other.Scale;
			}
			if (other.XOffset != 0f)
			{
				XOffset = other.XOffset;
			}
			if (other.YOffset != 0f)
			{
				YOffset = other.YOffset;
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
				MapAtlasId = input.ReadInt32();
				break;
			case 24u:
				ChapterId = input.ReadInt32();
				break;
			case 37u:
				ZoomOffset = input.ReadFloat();
				break;
			case 45u:
				Scale = input.ReadFloat();
				break;
			case 53u:
				XOffset = input.ReadFloat();
				break;
			case 61u:
				YOffset = input.ReadFloat();
				break;
			}
		}
	}
}
