using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class RandomNameList : IMessage<RandomNameList>, IMessage, IEquatable<RandomNameList>, IDeepCloneable<RandomNameList>
{
	private static readonly MessageParser<RandomNameList> _parser = new MessageParser<RandomNameList>(() => new RandomNameList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<string> _repeated_name_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> name_ = new RepeatedField<string>();

	public static MessageParser<RandomNameList> Parser => _parser;

	public RepeatedField<string> Name => name_;

	public RandomNameList()
	{
	}

	public RandomNameList(RandomNameList other)
		: this()
	{
		name_ = other.name_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RandomNameList Clone()
	{
		return new RandomNameList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RandomNameList);
	}

	public bool Equals(RandomNameList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!name_.Equals(other.name_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= name_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		name_.WriteTo(output, _repeated_name_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += name_.CalculateSize(_repeated_name_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RandomNameList other)
	{
		if (other != null)
		{
			name_.Add(other.name_);
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
				name_.AddEntriesFrom(input, _repeated_name_codec);
			}
		}
	}
}
