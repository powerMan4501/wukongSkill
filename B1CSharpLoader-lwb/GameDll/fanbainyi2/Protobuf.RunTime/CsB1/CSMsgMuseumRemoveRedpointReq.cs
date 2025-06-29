using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMuseumRemoveRedpointReq : IMessage<CSMsgMuseumRemoveRedpointReq>, IMessage, IEquatable<CSMsgMuseumRemoveRedpointReq>, IDeepCloneable<CSMsgMuseumRemoveRedpointReq>
{
	private static readonly MessageParser<CSMsgMuseumRemoveRedpointReq> _parser = new MessageParser<CSMsgMuseumRemoveRedpointReq>(() => new CSMsgMuseumRemoveRedpointReq());

	private UnknownFieldSet _unknownFields;

	private MuseumRedPointType type_;

	private int pointId_;

	public static MessageParser<CSMsgMuseumRemoveRedpointReq> Parser => _parser;

	public MuseumRedPointType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public int PointId
	{
		get
		{
			return pointId_;
		}
		set
		{
			pointId_ = value;
		}
	}

	public CSMsgMuseumRemoveRedpointReq()
	{
	}

	public CSMsgMuseumRemoveRedpointReq(CSMsgMuseumRemoveRedpointReq other)
		: this()
	{
		type_ = other.type_;
		pointId_ = other.pointId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMuseumRemoveRedpointReq Clone()
	{
		return new CSMsgMuseumRemoveRedpointReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMuseumRemoveRedpointReq);
	}

	public bool Equals(CSMsgMuseumRemoveRedpointReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (PointId != other.PointId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Type != MuseumRedPointType.None)
		{
			num ^= Type.GetHashCode();
		}
		if (PointId != 0)
		{
			num ^= PointId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Type != MuseumRedPointType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (PointId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PointId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Type != MuseumRedPointType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (PointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PointId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMuseumRemoveRedpointReq other)
	{
		if (other != null)
		{
			if (other.Type != MuseumRedPointType.None)
			{
				Type = other.Type;
			}
			if (other.PointId != 0)
			{
				PointId = other.PointId;
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
				Type = (MuseumRedPointType)input.ReadEnum();
				break;
			case 16u:
				PointId = input.ReadInt32();
				break;
			}
		}
	}
}
