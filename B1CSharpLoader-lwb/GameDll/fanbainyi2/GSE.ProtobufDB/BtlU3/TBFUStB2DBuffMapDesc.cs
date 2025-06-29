using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class TBFUStB2DBuffMapDesc : IMessage<TBFUStB2DBuffMapDesc>, IMessage, IEquatable<TBFUStB2DBuffMapDesc>, IDeepCloneable<TBFUStB2DBuffMapDesc>
{
	private static readonly MessageParser<TBFUStB2DBuffMapDesc> _parser = new MessageParser<TBFUStB2DBuffMapDesc>(() => new TBFUStB2DBuffMapDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStB2DBuffMapDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStB2DBuffMapDesc.Parser);

	private readonly RepeatedField<FUStB2DBuffMapDesc> list_ = new RepeatedField<FUStB2DBuffMapDesc>();

	public static MessageParser<TBFUStB2DBuffMapDesc> Parser => _parser;

	public RepeatedField<FUStB2DBuffMapDesc> List => list_;

	public TBFUStB2DBuffMapDesc()
	{
	}

	public TBFUStB2DBuffMapDesc(TBFUStB2DBuffMapDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStB2DBuffMapDesc Clone()
	{
		return new TBFUStB2DBuffMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStB2DBuffMapDesc);
	}

	public bool Equals(TBFUStB2DBuffMapDesc other)
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

	public void MergeFrom(TBFUStB2DBuffMapDesc other)
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
