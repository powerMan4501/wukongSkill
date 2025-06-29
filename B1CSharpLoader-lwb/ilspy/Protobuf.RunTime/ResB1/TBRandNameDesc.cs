using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBRandNameDesc : IMessage<TBRandNameDesc>, IMessage, IEquatable<TBRandNameDesc>, IDeepCloneable<TBRandNameDesc>
{
	private static readonly MessageParser<TBRandNameDesc> _parser = new MessageParser<TBRandNameDesc>(() => new TBRandNameDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<RandNameDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, RandNameDesc.Parser);

	private readonly RepeatedField<RandNameDesc> list_ = new RepeatedField<RandNameDesc>();

	public static MessageParser<TBRandNameDesc> Parser => _parser;

	public RepeatedField<RandNameDesc> List => list_;

	public TBRandNameDesc()
	{
	}

	public TBRandNameDesc(TBRandNameDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBRandNameDesc Clone()
	{
		return new TBRandNameDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBRandNameDesc);
	}

	public bool Equals(TBRandNameDesc other)
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

	public void MergeFrom(TBRandNameDesc other)
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
