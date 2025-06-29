using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class ListDeltaMsgString : IMessage<ListDeltaMsgString>, IMessage, IEquatable<ListDeltaMsgString>, IDeepCloneable<ListDeltaMsgString>
{
	private static readonly MessageParser<ListDeltaMsgString> _parser = new MessageParser<ListDeltaMsgString>(() => new ListDeltaMsgString());

	private UnknownFieldSet _unknownFields;

	private string value_;

	public static MessageParser<ListDeltaMsgString> Parser => _parser;

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

	public ListDeltaMsgString()
	{
	}

	public ListDeltaMsgString(ListDeltaMsgString other)
		: this()
	{
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgString Clone()
	{
		return new ListDeltaMsgString(this);
	}

	public void ClearValue()
	{
		value_ = null;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgString);
	}

	public bool Equals(ListDeltaMsgString other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (HasValue)
		{
			output.WriteRawTag(10);
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

	public void MergeFrom(ListDeltaMsgString other)
	{
		if (other != null)
		{
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Value = input.ReadString();
			}
		}
	}
}
