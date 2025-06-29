using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class DictDeltaMsgString_String : IMessage<DictDeltaMsgString_String>, IMessage, IEquatable<DictDeltaMsgString_String>, IDeepCloneable<DictDeltaMsgString_String>
{
	private static readonly MessageParser<DictDeltaMsgString_String> _parser = new MessageParser<DictDeltaMsgString_String>(() => new DictDeltaMsgString_String());

	private UnknownFieldSet _unknownFields;

	private string key_ = "";

	private string value_;

	public static MessageParser<DictDeltaMsgString_String> Parser => _parser;

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

	public string Value
	{
		get
		{
			return value_ ?? "";
		}
		set
		{
			value_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasValue => value_ != null;

	public DictDeltaMsgString_String()
	{
	}

	public DictDeltaMsgString_String(DictDeltaMsgString_String other)
		: this()
	{
		key_ = other.key_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgString_String Clone()
	{
		return new DictDeltaMsgString_String(this);
	}

	public void ClearValue()
	{
		value_ = null;
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgString_String);
	}

	public bool Equals(DictDeltaMsgString_String other)
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
			output.WriteRawTag(18);
			output.WriteString(Value);
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
			num += 1 + CodedOutputStream.ComputeStringSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DictDeltaMsgString_String other)
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
			case 18u:
				Value = input.ReadString();
				break;
			}
		}
	}
}
