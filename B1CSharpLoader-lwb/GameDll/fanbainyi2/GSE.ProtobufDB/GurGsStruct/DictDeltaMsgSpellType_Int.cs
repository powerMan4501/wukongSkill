using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class DictDeltaMsgSpellType_Int : IMessage<DictDeltaMsgSpellType_Int>, IMessage, IEquatable<DictDeltaMsgSpellType_Int>, IDeepCloneable<DictDeltaMsgSpellType_Int>
{
	private static readonly MessageParser<DictDeltaMsgSpellType_Int> _parser = new MessageParser<DictDeltaMsgSpellType_Int>(() => new DictDeltaMsgSpellType_Int());

	private UnknownFieldSet _unknownFields;

	private int idx_;

	private int value_;

	private OPType op_;

	private uint version_;

	public static MessageParser<DictDeltaMsgSpellType_Int> Parser => _parser;

	public int Idx
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

	public int Value
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

	public DictDeltaMsgSpellType_Int()
	{
	}

	public DictDeltaMsgSpellType_Int(DictDeltaMsgSpellType_Int other)
		: this()
	{
		idx_ = other.idx_;
		value_ = other.value_;
		op_ = other.op_;
		version_ = other.version_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgSpellType_Int Clone()
	{
		return new DictDeltaMsgSpellType_Int(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgSpellType_Int);
	}

	public bool Equals(DictDeltaMsgSpellType_Int other)
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
		if (Idx != 0)
		{
			num ^= Idx.GetHashCode();
		}
		if (Value != 0)
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
		if (Idx != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Idx);
		}
		if (Value != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Value);
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
		if (Idx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Idx);
		}
		if (Value != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Value);
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

	public void MergeFrom(DictDeltaMsgSpellType_Int other)
	{
		if (other != null)
		{
			if (other.Idx != 0)
			{
				Idx = other.Idx;
			}
			if (other.Value != 0)
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
			case 8u:
				Idx = input.ReadInt32();
				break;
			case 16u:
				Value = input.ReadInt32();
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
