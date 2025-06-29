using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class RebirthPointPosDesc : IMessage<RebirthPointPosDesc>, IMessage, IEquatable<RebirthPointPosDesc>, IDeepCloneable<RebirthPointPosDesc>
{
	private static readonly MessageParser<RebirthPointPosDesc> _parser = new MessageParser<RebirthPointPosDesc>(() => new RebirthPointPosDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int mapSpriteId_;

	private float posX_;

	private float posY_;

	public static MessageParser<RebirthPointPosDesc> Parser => _parser;

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

	public float PosX
	{
		get
		{
			return posX_;
		}
		set
		{
			posX_ = value;
		}
	}

	public float PosY
	{
		get
		{
			return posY_;
		}
		set
		{
			posY_ = value;
		}
	}

	public RebirthPointPosDesc()
	{
	}

	public RebirthPointPosDesc(RebirthPointPosDesc other)
		: this()
	{
		id_ = other.id_;
		mapSpriteId_ = other.mapSpriteId_;
		posX_ = other.posX_;
		posY_ = other.posY_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RebirthPointPosDesc Clone()
	{
		return new RebirthPointPosDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RebirthPointPosDesc);
	}

	public bool Equals(RebirthPointPosDesc other)
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
		if (MapSpriteId != other.MapSpriteId)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MapSpriteId != 0)
		{
			num ^= MapSpriteId.GetHashCode();
		}
		if (PosX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosX);
		}
		if (PosY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosY);
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
		if (MapSpriteId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MapSpriteId);
		}
		if (PosX != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(PosX);
		}
		if (PosY != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(PosY);
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
		if (MapSpriteId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapSpriteId);
		}
		if (PosX != 0f)
		{
			num += 5;
		}
		if (PosY != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RebirthPointPosDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MapSpriteId != 0)
			{
				MapSpriteId = other.MapSpriteId;
			}
			if (other.PosX != 0f)
			{
				PosX = other.PosX;
			}
			if (other.PosY != 0f)
			{
				PosY = other.PosY;
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
				MapSpriteId = input.ReadInt32();
				break;
			case 29u:
				PosX = input.ReadFloat();
				break;
			case 37u:
				PosY = input.ReadFloat();
				break;
			}
		}
	}
}
