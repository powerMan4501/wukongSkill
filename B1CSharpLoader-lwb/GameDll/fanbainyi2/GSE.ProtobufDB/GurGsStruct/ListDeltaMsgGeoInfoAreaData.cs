using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class ListDeltaMsgGeoInfoAreaData : IMessage<ListDeltaMsgGeoInfoAreaData>, IMessage, IEquatable<ListDeltaMsgGeoInfoAreaData>, IDeepCloneable<ListDeltaMsgGeoInfoAreaData>
{
	private static readonly MessageParser<ListDeltaMsgGeoInfoAreaData> _parser = new MessageParser<ListDeltaMsgGeoInfoAreaData>(() => new ListDeltaMsgGeoInfoAreaData());

	private UnknownFieldSet _unknownFields;

	private uint idx_;

	private static readonly FieldCodec<ClassDeltaMsgGeoInfoAreaData> _repeated_value_codec = FieldCodec.ForMessage(18u, ClassDeltaMsgGeoInfoAreaData.Parser);

	private readonly RepeatedField<ClassDeltaMsgGeoInfoAreaData> value_ = new RepeatedField<ClassDeltaMsgGeoInfoAreaData>();

	private OPType op_;

	private uint version_;

	public static MessageParser<ListDeltaMsgGeoInfoAreaData> Parser => _parser;

	public uint Idx
	{
		get
		{
			return idx_;
		}
		set
		{
			idx_ = value;
		}
	}

	public RepeatedField<ClassDeltaMsgGeoInfoAreaData> Value => value_;

	public OPType Op
	{
		get
		{
			return op_;
		}
		set
		{
			op_ = value;
		}
	}

	public uint Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = value;
		}
	}

	public ListDeltaMsgGeoInfoAreaData()
	{
	}

	public ListDeltaMsgGeoInfoAreaData(ListDeltaMsgGeoInfoAreaData other)
		: this()
	{
		idx_ = other.idx_;
		value_ = other.value_.Clone();
		op_ = other.op_;
		version_ = other.version_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgGeoInfoAreaData Clone()
	{
		return new ListDeltaMsgGeoInfoAreaData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgGeoInfoAreaData);
	}

	public bool Equals(ListDeltaMsgGeoInfoAreaData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Idx != other.Idx)
		{
			return false;
		}
		if (!value_.Equals(other.value_))
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
		if (Idx != 0)
		{
			num ^= Idx.GetHashCode();
		}
		num ^= value_.GetHashCode();
		if (Op != OPType.Add)
		{
			num ^= Op.GetHashCode();
		}
		if (Version != 0)
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
		if (Idx != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Idx);
		}
		value_.WriteTo(output, _repeated_value_codec);
		if (Op != OPType.Add)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Op);
		}
		if (Version != 0)
		{
			output.WriteRawTag(32);
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
		if (Idx != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Idx);
		}
		num += value_.CalculateSize(_repeated_value_codec);
		if (Op != OPType.Add)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Op);
		}
		if (Version != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Version);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListDeltaMsgGeoInfoAreaData other)
	{
		if (other != null)
		{
			if (other.Idx != 0)
			{
				Idx = other.Idx;
			}
			value_.Add(other.value_);
			if (other.Op != OPType.Add)
			{
				Op = other.Op;
			}
			if (other.Version != 0)
			{
				Version = other.Version;
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
				Idx = input.ReadUInt32();
				break;
			case 18u:
				value_.AddEntriesFrom(input, _repeated_value_codec);
				break;
			case 24u:
				Op = (OPType)input.ReadEnum();
				break;
			case 32u:
				Version = input.ReadUInt32();
				break;
			}
		}
	}
}
