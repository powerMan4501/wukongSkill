using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStMagicFieldCommDesc : IMessage<TBFUStMagicFieldCommDesc>, IMessage, IEquatable<TBFUStMagicFieldCommDesc>, IDeepCloneable<TBFUStMagicFieldCommDesc>
{
	private static readonly MessageParser<TBFUStMagicFieldCommDesc> _parser = new MessageParser<TBFUStMagicFieldCommDesc>(() => new TBFUStMagicFieldCommDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStMagicFieldCommDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStMagicFieldCommDesc.Parser);

	private readonly RepeatedField<FUStMagicFieldCommDesc> list_ = new RepeatedField<FUStMagicFieldCommDesc>();

	public static MessageParser<TBFUStMagicFieldCommDesc> Parser => _parser;

	public RepeatedField<FUStMagicFieldCommDesc> List => list_;

	public TBFUStMagicFieldCommDesc()
	{
	}

	public TBFUStMagicFieldCommDesc(TBFUStMagicFieldCommDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStMagicFieldCommDesc Clone()
	{
		return new TBFUStMagicFieldCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStMagicFieldCommDesc);
	}

	public bool Equals(TBFUStMagicFieldCommDesc other)
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

	public void MergeFrom(TBFUStMagicFieldCommDesc other)
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
