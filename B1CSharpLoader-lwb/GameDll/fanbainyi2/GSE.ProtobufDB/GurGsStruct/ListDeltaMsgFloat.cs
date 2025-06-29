using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class ListDeltaMsgFloat : IMessage<ListDeltaMsgFloat>, IMessage, IEquatable<ListDeltaMsgFloat>, IDeepCloneable<ListDeltaMsgFloat>
{
	private static readonly MessageParser<ListDeltaMsgFloat> _parser = new MessageParser<ListDeltaMsgFloat>(() => new ListDeltaMsgFloat());

	private UnknownFieldSet _unknownFields;

	private uint idx_;

	private float value_;

	private OPType op_;

	private uint version_;

	public static MessageParser<ListDeltaMsgFloat> Parser => _parser;

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

	public float Value
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

	public ListDeltaMsgFloat()
	{
	}

	public ListDeltaMsgFloat(ListDeltaMsgFloat other)
		: this()
	{
		idx_ = other.idx_;
		value_ = other.value_;
		op_ = other.op_;
		version_ = other.version_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgFloat Clone()
	{
		return new ListDeltaMsgFloat(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgFloat);
	}

	public bool Equals(ListDeltaMsgFloat other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Value, other.Value))
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
		if (Value != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Value);
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
			output.WriteUInt32(Idx);
		}
		if (Value != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Value);
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
			num += 1 + CodedOutputStream.ComputeUInt32Size(Idx);
		}
		if (Value != 0f)
		{
			num += 5;
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

	public void MergeFrom(ListDeltaMsgFloat other)
	{
		if (other != null)
		{
			if (other.Idx != 0)
			{
				Idx = other.Idx;
			}
			if (other.Value != 0f)
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
				Idx = input.ReadUInt32();
				break;
			case 21u:
				Value = input.ReadFloat();
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
