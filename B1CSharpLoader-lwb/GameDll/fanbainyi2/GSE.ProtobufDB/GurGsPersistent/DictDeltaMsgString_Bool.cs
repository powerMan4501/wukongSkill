using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class DictDeltaMsgString_Bool : IMessage<DictDeltaMsgString_Bool>, IMessage, IEquatable<DictDeltaMsgString_Bool>, IDeepCloneable<DictDeltaMsgString_Bool>
{
	private static readonly MessageParser<DictDeltaMsgString_Bool> _parser = new MessageParser<DictDeltaMsgString_Bool>(() => new DictDeltaMsgString_Bool());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private string key_ = "";

	private bool value_;

	public static MessageParser<DictDeltaMsgString_Bool> Parser => _parser;

	public string Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool Value
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return value_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 1;
			value_ = value;
		}
	}

	public bool HasValue => (_hasBits0 & 1) != 0;

	public DictDeltaMsgString_Bool()
	{
	}

	public DictDeltaMsgString_Bool(DictDeltaMsgString_Bool other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		key_ = other.key_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgString_Bool Clone()
	{
		return new DictDeltaMsgString_Bool(this);
	}

	public void ClearValue()
	{
		_hasBits0 &= -2;
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
		if (Key.Length != 0)
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
		if (Key.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Key);
		}
		if (HasValue)
		{
			output.WriteRawTag(16);
			output.WriteBool(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Key.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Key);
		}
		if (HasValue)
		{
			num += 2;
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
			if (other.Key.Length != 0)
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
			case 10u:
				Key = input.ReadString();
				break;
			case 16u:
				Value = input.ReadBool();
				break;
			}
		}
	}
}
