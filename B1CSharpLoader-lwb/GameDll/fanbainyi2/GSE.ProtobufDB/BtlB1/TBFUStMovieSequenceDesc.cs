using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStMovieSequenceDesc : IMessage<TBFUStMovieSequenceDesc>, IMessage, IEquatable<TBFUStMovieSequenceDesc>, IDeepCloneable<TBFUStMovieSequenceDesc>
{
	private static readonly MessageParser<TBFUStMovieSequenceDesc> _parser = new MessageParser<TBFUStMovieSequenceDesc>(() => new TBFUStMovieSequenceDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStMovieSequenceDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStMovieSequenceDesc.Parser);

	private readonly RepeatedField<FUStMovieSequenceDesc> list_ = new RepeatedField<FUStMovieSequenceDesc>();

	public static MessageParser<TBFUStMovieSequenceDesc> Parser => _parser;

	public RepeatedField<FUStMovieSequenceDesc> List => list_;

	public TBFUStMovieSequenceDesc()
	{
	}

	public TBFUStMovieSequenceDesc(TBFUStMovieSequenceDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStMovieSequenceDesc Clone()
	{
		return new TBFUStMovieSequenceDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStMovieSequenceDesc);
	}

	public bool Equals(TBFUStMovieSequenceDesc other)
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

	public void MergeFrom(TBFUStMovieSequenceDesc other)
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
