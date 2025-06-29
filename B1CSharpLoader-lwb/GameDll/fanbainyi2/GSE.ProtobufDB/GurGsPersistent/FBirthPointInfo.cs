using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class FBirthPointInfo : IMessage<FBirthPointInfo>, IMessage, IEquatable<FBirthPointInfo>, IDeepCloneable<FBirthPointInfo>
{
	private static readonly MessageParser<FBirthPointInfo> _parser = new MessageParser<FBirthPointInfo>(() => new FBirthPointInfo());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int pointType_;

	private int pointID_;

	public static MessageParser<FBirthPointInfo> Parser => _parser;

	public int PointType
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return pointType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			pointType_ = value;
		}
	}

	public bool HasPointType => (_hasBits0 & 1) != 0;

	public int PointID
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return pointID_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			pointID_ = value;
		}
	}

	public bool HasPointID => (_hasBits0 & 2) != 0;

	public FBirthPointInfo()
	{
	}

	public FBirthPointInfo(FBirthPointInfo other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		pointType_ = other.pointType_;
		pointID_ = other.pointID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FBirthPointInfo Clone()
	{
		return new FBirthPointInfo(this);
	}

	public void ClearPointType()
	{
		_hasBits0 &= -2;
	}

	public void ClearPointID()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as FBirthPointInfo);
	}

	public bool Equals(FBirthPointInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PointType != other.PointType)
		{
			return false;
		}
		if (PointID != other.PointID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasPointType)
		{
			num ^= PointType.GetHashCode();
		}
		if (HasPointID)
		{
			num ^= PointID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasPointType)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PointType);
		}
		if (HasPointID)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PointID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasPointType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PointType);
		}
		if (HasPointID)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PointID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FBirthPointInfo other)
	{
		if (other != null)
		{
			if (other.HasPointType)
			{
				PointType = other.PointType;
			}
			if (other.HasPointID)
			{
				PointID = other.PointID;
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
				PointType = input.ReadInt32();
				break;
			case 16u:
				PointID = input.ReadInt32();
				break;
			}
		}
	}
}
