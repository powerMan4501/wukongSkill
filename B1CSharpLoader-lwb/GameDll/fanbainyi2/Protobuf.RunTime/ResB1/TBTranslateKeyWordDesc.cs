using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBTranslateKeyWordDesc : IMessage<TBTranslateKeyWordDesc>, IMessage, IEquatable<TBTranslateKeyWordDesc>, IDeepCloneable<TBTranslateKeyWordDesc>
{
	private static readonly MessageParser<TBTranslateKeyWordDesc> _parser = new MessageParser<TBTranslateKeyWordDesc>(() => new TBTranslateKeyWordDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<TranslateKeyWordDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, TranslateKeyWordDesc.Parser);

	private readonly RepeatedField<TranslateKeyWordDesc> list_ = new RepeatedField<TranslateKeyWordDesc>();

	public static MessageParser<TBTranslateKeyWordDesc> Parser => _parser;

	public RepeatedField<TranslateKeyWordDesc> List => list_;

	public TBTranslateKeyWordDesc()
	{
	}

	public TBTranslateKeyWordDesc(TBTranslateKeyWordDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBTranslateKeyWordDesc Clone()
	{
		return new TBTranslateKeyWordDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBTranslateKeyWordDesc);
	}

	public bool Equals(TBTranslateKeyWordDesc other)
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

	public void MergeFrom(TBTranslateKeyWordDesc other)
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
