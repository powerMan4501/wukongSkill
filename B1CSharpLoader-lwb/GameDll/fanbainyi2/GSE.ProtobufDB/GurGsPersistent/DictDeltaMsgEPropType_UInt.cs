using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class DictDeltaMsgEPropType_UInt : IMessage<DictDeltaMsgEPropType_UInt>, IMessage, IEquatable<DictDeltaMsgEPropType_UInt>, IDeepCloneable<DictDeltaMsgEPropType_UInt>
{
	private static readonly MessageParser<DictDeltaMsgEPropType_UInt> _parser = new MessageParser<DictDeltaMsgEPropType_UInt>(() => new DictDeltaMsgEPropType_UInt());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int key_;

	private uint value_;

	public static MessageParser<DictDeltaMsgEPropType_UInt> Parser => _parser;

	public int Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = value;
		}
	}

	public uint Value
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return value_;
			}
			return 0u;
		}
		set
		{
			_hasBits0 |= 1;
			value_ = value;
		}
	}

	public bool HasValue => (_hasBits0 & 1) != 0;

	public DictDeltaMsgEPropType_UInt()
	{
	}

	public DictDeltaMsgEPropType_UInt(DictDeltaMsgEPropType_UInt other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		key_ = other.key_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgEPropType_UInt Clone()
	{
		return new DictDeltaMsgEPropType_UInt(this);
	}

	public void ClearValue()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgEPropType_UInt);
	}

	public bool Equals(DictDeltaMsgEPropType_UInt other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Key != other.Key)
		{
			return false;
		}
		if (Value != other.Value)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Key != 0)
		{
			num ^= Key.GetHashCode();
		}
		if (HasValue)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Key != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Key);
		}
		if (HasValue)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Key != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Key);
		}
		if (HasValue)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DictDeltaMsgEPropType_UInt other)
	{
		if (other != null)
		{
			if (other.Key != 0)
			{
				Key = other.Key;
			}
			if (other.HasValue)
			{
				Value = other.Value;
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
				Key = input.ReadInt32();
				break;
			case 16u:
				Value = input.ReadUInt32();
				break;
			}
		}
	}
}
