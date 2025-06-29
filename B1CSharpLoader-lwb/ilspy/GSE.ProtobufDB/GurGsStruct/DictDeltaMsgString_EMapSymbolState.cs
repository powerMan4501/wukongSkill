using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class DictDeltaMsgString_EMapSymbolState : IMessage<DictDeltaMsgString_EMapSymbolState>, IMessage, IEquatable<DictDeltaMsgString_EMapSymbolState>, IDeepCloneable<DictDeltaMsgString_EMapSymbolState>
{
	private static readonly MessageParser<DictDeltaMsgString_EMapSymbolState> _parser = new MessageParser<DictDeltaMsgString_EMapSymbolState>(() => new DictDeltaMsgString_EMapSymbolState());

	private UnknownFieldSet _unknownFields;

	private string idx_ = "";

	private int value_;

	private OPType op_;

	private uint version_;

	public static MessageParser<DictDeltaMsgString_EMapSymbolState> Parser => _parser;

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

	public DictDeltaMsgString_EMapSymbolState()
	{
	}

	public DictDeltaMsgString_EMapSymbolState(DictDeltaMsgString_EMapSymbolState other)
		: this()
	{
		idx_ = other.idx_;
		value_ = other.value_;
		op_ = other.op_;
		version_ = other.version_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgString_EMapSymbolState Clone()
	{
		return new DictDeltaMsgString_EMapSymbolState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgString_EMapSymbolState);
	}

	public bool Equals(DictDeltaMsgString_EMapSymbolState other)
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
		if (Idx.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Idx);
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
		if (Idx.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Idx);
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

	public void MergeFrom(DictDeltaMsgString_EMapSymbolState other)
	{
		if (other != null)
		{
			if (other.Idx.Length != 0)
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
			case 10u:
				Idx = input.ReadString();
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
