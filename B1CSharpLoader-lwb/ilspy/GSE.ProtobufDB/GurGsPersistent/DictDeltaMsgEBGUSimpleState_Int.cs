using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class DictDeltaMsgEBGUSimpleState_Int : IMessage<DictDeltaMsgEBGUSimpleState_Int>, IMessage, IEquatable<DictDeltaMsgEBGUSimpleState_Int>, IDeepCloneable<DictDeltaMsgEBGUSimpleState_Int>
{
	private static readonly MessageParser<DictDeltaMsgEBGUSimpleState_Int> _parser = new MessageParser<DictDeltaMsgEBGUSimpleState_Int>(() => new DictDeltaMsgEBGUSimpleState_Int());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int key_;

	private int value_;

	public static MessageParser<DictDeltaMsgEBGUSimpleState_Int> Parser => _parser;

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

	public int Value
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return value_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			value_ = value;
		}
	}

	public bool HasValue => (_hasBits0 & 1) != 0;

	public DictDeltaMsgEBGUSimpleState_Int()
	{
	}

	public DictDeltaMsgEBGUSimpleState_Int(DictDeltaMsgEBGUSimpleState_Int other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		key_ = other.key_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgEBGUSimpleState_Int Clone()
	{
		return new DictDeltaMsgEBGUSimpleState_Int(this);
	}

	public void ClearValue()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgEBGUSimpleState_Int);
	}

	public bool Equals(DictDeltaMsgEBGUSimpleState_Int other)
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
			output.WriteInt32(Value);
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
			num += 1 + CodedOutputStream.ComputeInt32Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DictDeltaMsgEBGUSimpleState_Int other)
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
				Value = input.ReadInt32();
				break;
			}
		}
	}
}
