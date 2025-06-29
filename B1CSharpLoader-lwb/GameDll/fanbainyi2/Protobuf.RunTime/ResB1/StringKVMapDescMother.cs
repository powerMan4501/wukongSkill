using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class StringKVMapDescMother : IMessage<StringKVMapDescMother>, IMessage, IEquatable<StringKVMapDescMother>, IDeepCloneable<StringKVMapDescMother>
{
	private static readonly MessageParser<StringKVMapDescMother> _parser = new MessageParser<StringKVMapDescMother>(() => new StringKVMapDescMother());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<StringKVMapDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, StringKVMapDesc.Parser);

	private readonly RepeatedField<StringKVMapDesc> list_ = new RepeatedField<StringKVMapDesc>();

	public static MessageParser<StringKVMapDescMother> Parser => _parser;

	public RepeatedField<StringKVMapDesc> List => list_;

	public StringKVMapDescMother()
	{
	}

	public StringKVMapDescMother(StringKVMapDescMother other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public StringKVMapDescMother Clone()
	{
		return new StringKVMapDescMother(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as StringKVMapDescMother);
	}

	public bool Equals(StringKVMapDescMother other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!list_.Equals(other.list_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= list_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		list_.WriteTo(output, _repeated_list_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += list_.CalculateSize(_repeated_list_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(StringKVMapDescMother other)
	{
		if (other != null)
		{
			list_.Add(other.list_);
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
				list_.AddEntriesFrom(input, _repeated_list_codec);
			}
		}
	}
}
