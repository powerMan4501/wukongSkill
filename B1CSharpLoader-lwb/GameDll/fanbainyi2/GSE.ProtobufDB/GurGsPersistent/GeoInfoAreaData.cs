using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class GeoInfoAreaData : IMessage<GeoInfoAreaData>, IMessage, IEquatable<GeoInfoAreaData>, IDeepCloneable<GeoInfoAreaData>
{
	private static readonly MessageParser<GeoInfoAreaData> _parser = new MessageParser<GeoInfoAreaData>(() => new GeoInfoAreaData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int levelId_;

	private int areaId_;

	private int geoAreaState_;

	private int mapSpriteId_;

	private double exploredTime_;

	public static MessageParser<GeoInfoAreaData> Parser => _parser;

	public int LevelId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return levelId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			levelId_ = value;
		}
	}

	public bool HasLevelId => (_hasBits0 & 1) != 0;

	public int AreaId
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return areaId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			areaId_ = value;
		}
	}

	public bool HasAreaId => (_hasBits0 & 2) != 0;

	public int GeoAreaState
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return geoAreaState_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			geoAreaState_ = value;
		}
	}

	public bool HasGeoAreaState => (_hasBits0 & 4) != 0;

	public int MapSpriteId
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return mapSpriteId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8;
			mapSpriteId_ = value;
		}
	}

	public bool HasMapSpriteId => (_hasBits0 & 8) != 0;

	public double ExploredTime
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return exploredTime_;
			}
			return 0.0;
		}
		set
		{
			_hasBits0 |= 16;
			exploredTime_ = value;
		}
	}

	public bool HasExploredTime => (_hasBits0 & 0x10) != 0;

	public GeoInfoAreaData()
	{
	}

	public GeoInfoAreaData(GeoInfoAreaData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		levelId_ = other.levelId_;
		areaId_ = other.areaId_;
		geoAreaState_ = other.geoAreaState_;
		mapSpriteId_ = other.mapSpriteId_;
		exploredTime_ = other.exploredTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GeoInfoAreaData Clone()
	{
		return new GeoInfoAreaData(this);
	}

	public void ClearLevelId()
	{
		_hasBits0 &= -2;
	}

	public void ClearAreaId()
	{
		_hasBits0 &= -3;
	}

	public void ClearGeoAreaState()
	{
		_hasBits0 &= -5;
	}

	public void ClearMapSpriteId()
	{
		_hasBits0 &= -9;
	}

	public void ClearExploredTime()
	{
		_hasBits0 &= -17;
	}

	public override bool Equals(object other)
	{
		return Equals(other as GeoInfoAreaData);
	}

	public bool Equals(GeoInfoAreaData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (GeoAreaState != other.GeoAreaState)
		{
			return false;
		}
		if (MapSpriteId != other.MapSpriteId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ExploredTime, other.ExploredTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasLevelId)
		{
			num ^= LevelId.GetHashCode();
		}
		if (HasAreaId)
		{
			num ^= AreaId.GetHashCode();
		}
		if (HasGeoAreaState)
		{
			num ^= GeoAreaState.GetHashCode();
		}
		if (HasMapSpriteId)
		{
			num ^= MapSpriteId.GetHashCode();
		}
		if (HasExploredTime)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ExploredTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasLevelId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LevelId);
		}
		if (HasAreaId)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AreaId);
		}
		if (HasGeoAreaState)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GeoAreaState);
		}
		if (HasMapSpriteId)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MapSpriteId);
		}
		if (HasExploredTime)
		{
			output.WriteRawTag(41);
			output.WriteDouble(ExploredTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasLevelId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (HasAreaId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AreaId);
		}
		if (HasGeoAreaState)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GeoAreaState);
		}
		if (HasMapSpriteId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapSpriteId);
		}
		if (HasExploredTime)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GeoInfoAreaData other)
	{
		if (other != null)
		{
			if (other.HasLevelId)
			{
				LevelId = other.LevelId;
			}
			if (other.HasAreaId)
			{
				AreaId = other.AreaId;
			}
			if (other.HasGeoAreaState)
			{
				GeoAreaState = other.GeoAreaState;
			}
			if (other.HasMapSpriteId)
			{
				MapSpriteId = other.MapSpriteId;
			}
			if (other.HasExploredTime)
			{
				ExploredTime = other.ExploredTime;
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
				LevelId = input.ReadInt32();
				break;
			case 16u:
				AreaId = input.ReadInt32();
				break;
			case 24u:
				GeoAreaState = input.ReadInt32();
				break;
			case 32u:
				MapSpriteId = input.ReadInt32();
				break;
			case 41u:
				ExploredTime = input.ReadDouble();
				break;
			}
		}
	}
}
