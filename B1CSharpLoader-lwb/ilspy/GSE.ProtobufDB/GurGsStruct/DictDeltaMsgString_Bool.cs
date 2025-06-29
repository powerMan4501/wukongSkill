using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class DictDeltaMsgString_Bool : IMessage<DictDeltaMsgString_Bool>, IMessage, IEquatable<DictDeltaMsgString_Bool>, IDeepCloneable<DictDeltaMsgString_Bool>
{
	private static readonly MessageParser<DictDeltaMsgString_Bool> _parser = new MessageParser<DictDeltaMsgString_Bool>(() => new DictDeltaMsgString_Bool());

	private UnknownFieldSet _unknownFields;

	private string idx_ = "";

	private bool value_;

	private OPType op_;

	private uint version_;

	public static MessageParser<DictDeltaMsgString_Bool> Parser => _parser;

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

	public bool Value
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

	public DictDeltaMsgString_Bool()
	{
	}

	public DictDeltaMsgString_Bool(DictDeltaMsgString_Bool other)
		: this()
	{
		idx_ = other.idx_;
		value_ = other.value_;
		op_ = other.op_;
		version_ = other.version_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgString_Bool Clone()
	{
		return new DictDeltaMsgString_Bool(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgString_Bool);
	}

	public bool Equals(DictDeltaMsgString_Bool other)
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
		if (Value != other.Value)
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
		if (Value)
		{
			num ^= Value.GetHashCode();
		}
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
		if (Value)
		{
			output.WriteRawTag(16);
			output.WriteBool(Value);
		}
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
		if (Value)
		{
			num += 2;
		}
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

	public void MergeFrom(DictDeltaMsgString_Bool other)
	{
		if (other != null)
		{
			if (other.Idx.Length != 0)
			{
				Idx = other.Idx;
			}
			if (other.Value)
			{
				Value = other.Value;
			}
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
			case 16u:
				Value = input.ReadBool();
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
