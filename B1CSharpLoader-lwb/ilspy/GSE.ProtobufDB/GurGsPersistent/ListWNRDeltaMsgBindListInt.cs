using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class ListWNRDeltaMsgBindListInt : IMessage<ListWNRDeltaMsgBindListInt>, IMessage, IEquatable<ListWNRDeltaMsgBindListInt>, IDeepCloneable<ListWNRDeltaMsgBindListInt>
{
	private static readonly MessageParser<ListWNRDeltaMsgBindListInt> _parser = new MessageParser<ListWNRDeltaMsgBindListInt>(() => new ListWNRDeltaMsgBindListInt());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_value_codec = FieldCodec.ForMessage(10u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> value_ = new RepeatedField<ListDeltaMsgInt>();

	public static MessageParser<ListWNRDeltaMsgBindListInt> Parser => _parser;

	public RepeatedField<ListDeltaMsgInt> Value => value_;

	public ListWNRDeltaMsgBindListInt()
	{
	}

	public ListWNRDeltaMsgBindListInt(ListWNRDeltaMsgBindListInt other)
		: this()
	{
		value_ = other.value_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListWNRDeltaMsgBindListInt Clone()
	{
		return new ListWNRDeltaMsgBindListInt(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListWNRDeltaMsgBindListInt);
	}

	public bool Equals(ListWNRDeltaMsgBindListInt other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		num ^= value_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		value_.WriteTo(output, _repeated_value_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += value_.CalculateSize(_repeated_value_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListWNRDeltaMsgBindListInt other)
	{
		if (other != null)
		{
			value_.Add(other.value_);
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
				value_.AddEntriesFrom(input, _repeated_value_codec);
			}
		}
	}
}
