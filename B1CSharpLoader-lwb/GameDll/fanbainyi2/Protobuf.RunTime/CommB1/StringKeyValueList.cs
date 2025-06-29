using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class StringKeyValueList : IMessage<StringKeyValueList>, IMessage, IEquatable<StringKeyValueList>, IDeepCloneable<StringKeyValueList>
{
	private static readonly MessageParser<StringKeyValueList> _parser = new MessageParser<StringKeyValueList>(() => new StringKeyValueList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<StringKeyValue> _repeated_kvList_codec = FieldCodec.ForMessage(10u, StringKeyValue.Parser);

	private readonly RepeatedField<StringKeyValue> kvList_ = new RepeatedField<StringKeyValue>();

	public static MessageParser<StringKeyValueList> Parser => _parser;

	public RepeatedField<StringKeyValue> KvList => kvList_;

	public StringKeyValueList()
	{
	}

	public StringKeyValueList(StringKeyValueList other)
		: this()
	{
		kvList_ = other.kvList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public StringKeyValueList Clone()
	{
		return new StringKeyValueList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as StringKeyValueList);
	}

	public bool Equals(StringKeyValueList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kvList_.Equals(other.kvList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= kvList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		kvList_.WriteTo(output, _repeated_kvList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += kvList_.CalculateSize(_repeated_kvList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(StringKeyValueList other)
	{
		if (other != null)
		{
			kvList_.Add(other.kvList_);
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
				kvList_.AddEntriesFrom(input, _repeated_kvList_codec);
			}
		}
	}
}
