using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class GeoInfoCustomData : IMessage<GeoInfoCustomData>, IMessage, IEquatable<GeoInfoCustomData>, IDeepCloneable<GeoInfoCustomData>
{
	private static readonly MessageParser<GeoInfoCustomData> _parser = new MessageParser<GeoInfoCustomData>(() => new GeoInfoCustomData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int mapId_;

	private float posX_;

	private float posY_;

	private int geoInfoCustomType_;

	private int id_;

	public static MessageParser<GeoInfoCustomData> Parser => _parser;

	public int MapId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return mapId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			mapId_ = value;
		}
	}

	public bool HasMapId => (_hasBits0 & 1) != 0;

	public float PosX
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return posX_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			posX_ = value;
		}
	}

	public bool HasPosX => (_hasBits0 & 2) != 0;

	public float PosY
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return posY_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 4;
			posY_ = value;
		}
	}

	public bool HasPosY => (_hasBits0 & 4) != 0;

	public int GeoInfoCustomType
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return geoInfoCustomType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8;
			geoInfoCustomType_ = value;
		}
	}

	public bool HasGeoInfoCustomType => (_hasBits0 & 8) != 0;

	public int Id
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return id_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 16;
			id_ = value;
		}
	}

	public bool HasId => (_hasBits0 & 0x10) != 0;

	public GeoInfoCustomData()
	{
	}

	public GeoInfoCustomData(GeoInfoCustomData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		mapId_ = other.mapId_;
		posX_ = other.posX_;
		posY_ = other.posY_;
		geoInfoCustomType_ = other.geoInfoCustomType_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GeoInfoCustomData Clone()
	{
		return new GeoInfoCustomData(this);
	}

	public void ClearMapId()
	{
		_hasBits0 &= -2;
	}

	public void ClearPosX()
	{
		_hasBits0 &= -3;
	}

	public void ClearPosY()
	{
		_hasBits0 &= -5;
	}

	public void ClearGeoInfoCustomType()
	{
		_hasBits0 &= -9;
	}

	public void ClearId()
	{
		_hasBits0 &= -17;
	}

	public override bool Equals(object other)
	{
		return Equals(other as GeoInfoCustomData);
	}

	public bool Equals(GeoInfoCustomData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosX, other.PosX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosY, other.PosY))
		{
			return false;
		}
		if (GeoInfoCustomType != other.GeoInfoCustomType)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasMapId)
		{
			num ^= MapId.GetHashCode();
		}
		if (HasPosX)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosX);
		}
		if (HasPosY)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosY);
		}
		if (HasGeoInfoCustomType)
		{
			num ^= GeoInfoCustomType.GetHashCode();
		}
		if (HasId)
		{
			num ^= Id.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasMapId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MapId);
		}
		if (HasPosX)
		{
			output.WriteRawTag(21);
			output.WriteFloat(PosX);
		}
		if (HasPosY)
		{
			output.WriteRawTag(29);
			output.WriteFloat(PosY);
		}
		if (HasGeoInfoCustomType)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GeoInfoCustomType);
		}
		if (HasId)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Id);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasMapId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (HasPosX)
		{
			num += 5;
		}
		if (HasPosY)
		{
			num += 5;
		}
		if (HasGeoInfoCustomType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GeoInfoCustomType);
		}
		if (HasId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GeoInfoCustomData other)
	{
		if (other != null)
		{
			if (other.HasMapId)
			{
				MapId = other.MapId;
			}
			if (other.HasPosX)
			{
				PosX = other.PosX;
			}
			if (other.HasPosY)
			{
				PosY = other.PosY;
			}
			if (other.HasGeoInfoCustomType)
			{
				GeoInfoCustomType = other.GeoInfoCustomType;
			}
			if (other.HasId)
			{
				Id = other.Id;
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
				MapId = input.ReadInt32();
				break;
			case 21u:
				PosX = input.ReadFloat();
				break;
			case 29u:
				PosY = input.ReadFloat();
				break;
			case 32u:
				GeoInfoCustomType = input.ReadInt32();
				break;
			case 40u:
				Id = input.ReadInt32();
				break;
			}
		}
	}
}
