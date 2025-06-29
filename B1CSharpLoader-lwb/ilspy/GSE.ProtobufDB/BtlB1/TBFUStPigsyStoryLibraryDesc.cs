using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStPigsyStoryLibraryDesc : IMessage<TBFUStPigsyStoryLibraryDesc>, IMessage, IEquatable<TBFUStPigsyStoryLibraryDesc>, IDeepCloneable<TBFUStPigsyStoryLibraryDesc>
{
	private static readonly MessageParser<TBFUStPigsyStoryLibraryDesc> _parser = new MessageParser<TBFUStPigsyStoryLibraryDesc>(() => new TBFUStPigsyStoryLibraryDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStPigsyStoryLibraryDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStPigsyStoryLibraryDesc.Parser);

	private readonly RepeatedField<FUStPigsyStoryLibraryDesc> list_ = new RepeatedField<FUStPigsyStoryLibraryDesc>();

	public static MessageParser<TBFUStPigsyStoryLibraryDesc> Parser => _parser;

	public RepeatedField<FUStPigsyStoryLibraryDesc> List => list_;

	public TBFUStPigsyStoryLibraryDesc()
	{
	}

	public TBFUStPigsyStoryLibraryDesc(TBFUStPigsyStoryLibraryDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStPigsyStoryLibraryDesc Clone()
	{
		return new TBFUStPigsyStoryLibraryDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStPigsyStoryLibraryDesc);
	}

	public bool Equals(TBFUStPigsyStoryLibraryDesc other)
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

	public void MergeFrom(TBFUStPigsyStoryLibraryDesc other)
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
