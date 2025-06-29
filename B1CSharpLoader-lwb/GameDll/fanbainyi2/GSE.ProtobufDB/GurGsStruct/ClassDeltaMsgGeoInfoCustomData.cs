using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class ClassDeltaMsgGeoInfoCustomData : IMessage<ClassDeltaMsgGeoInfoCustomData>, IMessage, IEquatable<ClassDeltaMsgGeoInfoCustomData>, IDeepCloneable<ClassDeltaMsgGeoInfoCustomData>
{
	private static readonly MessageParser<ClassDeltaMsgGeoInfoCustomData> _parser = new MessageParser<ClassDeltaMsgGeoInfoCustomData>(() => new ClassDeltaMsgGeoInfoCustomData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private GeoInfoCustomData value_;

	private OPType op_;

	private uint version_;

	public static MessageParser<ClassDeltaMsgGeoInfoCustomData> Parser => _parser;

	public GeoInfoCustomData Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public OPType Op
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return op_;
			}
			return OPType.Add;
		}
		set
		{
			_hasBits0 |= 1;
			op_ = value;
		}
	}

	public bool HasOp => (_hasBits0 & 1) != 0;

	public uint Version
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return version_;
			}
			return 0u;
		}
		set
		{
			_hasBits0 |= 2;
			version_ = value;
		}
	}

	public bool HasVersion => (_hasBits0 & 2) != 0;

	public ClassDeltaMsgGeoInfoCustomData()
	{
	}

	public ClassDeltaMsgGeoInfoCustomData(ClassDeltaMsgGeoInfoCustomData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		op_ = other.op_;
		version_ = other.version_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ClassDeltaMsgGeoInfoCustomData Clone()
	{
		return new ClassDeltaMsgGeoInfoCustomData(this);
	}

	public void ClearOp()
	{
		_hasBits0 &= -2;
	}

	public void ClearVersion()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ClassDeltaMsgGeoInfoCustomData);
	}

	public bool Equals(ClassDeltaMsgGeoInfoCustomData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Value, other.Value))
		{
			return false;
		}
		if (Op != other.Op)
		{
			return false;
		}
		if (Version != other.Version)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (value_ != null)
		{
			num ^= Value.GetHashCode();
		}
		if (HasOp)
		{
			num ^= Op.GetHashCode();
		}
		if (HasVersion)
		{
			num ^= Version.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (value_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Value);
		}
		if (HasOp)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Op);
		}
		if (HasVersion)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Version);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (value_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
		}
		if (HasOp)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Op);
		}
		if (HasVersion)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Version);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ClassDeltaMsgGeoInfoCustomData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				Value = new GeoInfoCustomData();
			}
			Value.MergeFrom(other.Value);
		}
		if (other.HasOp)
		{
			Op = other.Op;
		}
		if (other.HasVersion)
		{
			Version = other.Version;
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
			case 10u:
				if (value_ == null)
				{
					Value = new GeoInfoCustomData();
				}
				input.ReadMessage(Value);
				break;
			case 16u:
				Op = (OPType)input.ReadEnum();
				break;
			case 24u:
				Version = input.ReadUInt32();
				break;
			}
		}
	}
}
