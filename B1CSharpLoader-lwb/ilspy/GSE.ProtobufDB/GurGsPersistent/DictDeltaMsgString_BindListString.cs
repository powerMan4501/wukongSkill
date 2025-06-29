using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class DictDeltaMsgString_BindListString : IMessage<DictDeltaMsgString_BindListString>, IMessage, IEquatable<DictDeltaMsgString_BindListString>, IDeepCloneable<DictDeltaMsgString_BindListString>
{
	private static readonly MessageParser<DictDeltaMsgString_BindListString> _parser = new MessageParser<DictDeltaMsgString_BindListString>(() => new DictDeltaMsgString_BindListString());

	private UnknownFieldSet _unknownFields;

	private string key_ = "";

	private static readonly FieldCodec<ListDeltaMsgString> _repeated_value_codec = FieldCodec.ForMessage(18u, ListDeltaMsgString.Parser);

	private readonly RepeatedField<ListDeltaMsgString> value_ = new RepeatedField<ListDeltaMsgString>();

	public static MessageParser<DictDeltaMsgString_BindListString> Parser => _parser;

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

	public RepeatedField<ListDeltaMsgString> Value => value_;

	public DictDeltaMsgString_BindListString()
	{
	}

	public DictDeltaMsgString_BindListString(DictDeltaMsgString_BindListString other)
		: this()
	{
		key_ = other.key_;
		value_ = other.value_.Clone();
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
		if (Key != other.Key)
		{
			return false;
		}
		if (!value_.Equals(other.value_))
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
		num ^= value_.GetHashCode();
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
		value_.WriteTo(output, _repeated_value_codec);
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
		num += value_.CalculateSize(_repeated_value_codec);
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
			if (other.Key.Length != 0)
			{
				Key = other.Key;
			}
			value_.Add(other.value_);
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
				value_.AddEntriesFrom(input, _repeated_value_codec);
				break;
			}
		}
	}
}
