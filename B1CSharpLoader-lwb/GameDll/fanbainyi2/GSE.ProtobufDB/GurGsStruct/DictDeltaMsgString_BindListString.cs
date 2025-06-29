using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class DictDeltaMsgString_BindListString : IMessage<DictDeltaMsgString_BindListString>, IMessage, IEquatable<DictDeltaMsgString_BindListString>, IDeepCloneable<DictDeltaMsgString_BindListString>
{
	private static readonly MessageParser<DictDeltaMsgString_BindListString> _parser = new MessageParser<DictDeltaMsgString_BindListString>(() => new DictDeltaMsgString_BindListString());

	private UnknownFieldSet _unknownFields;

	private string idx_ = "";

	private static readonly FieldCodec<ListDeltaMsgString> _repeated_value_codec = FieldCodec.ForMessage(18u, ListDeltaMsgString.Parser);

	private readonly RepeatedField<ListDeltaMsgString> value_ = new RepeatedField<ListDeltaMsgString>();

	private OPType op_;

	private uint version_;

	public static MessageParser<DictDeltaMsgString_BindListString> Parser => _parser;

	public string Idx
	{
		get
		{
			return idx_;
		}
		set
		{
			idx_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<ListDeltaMsgString> Value => value_;

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

	public DictDeltaMsgString_BindListString()
	{
	}

	public DictDeltaMsgString_BindListString(DictDeltaMsgString_BindListString other)
		: this()
	{
		idx_ = other.idx_;
		value_ = other.value_.Clone();
		op_ = other.op_;
		version_ = other.version_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgString_BindListString Clone()
	{
		return new DictDeltaMsgString_BindListString(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgString_BindListString);
	}

	public bool Equals(DictDeltaMsgString_BindListString other)
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
		if (Idx.Length != 0)
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
		if (Idx.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Idx);
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
		if (Idx.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Idx);
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

	public void MergeFrom(DictDeltaMsgString_BindListString other)
	{
		if (other != null)
		{
			if (other.Idx.Length != 0)
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
			case 10u:
				Idx = input.ReadString();
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
