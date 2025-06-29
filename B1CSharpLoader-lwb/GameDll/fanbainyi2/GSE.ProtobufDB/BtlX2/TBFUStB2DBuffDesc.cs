using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class TBFUStB2DBuffDesc : IMessage<TBFUStB2DBuffDesc>, IMessage, IEquatable<TBFUStB2DBuffDesc>, IDeepCloneable<TBFUStB2DBuffDesc>
{
	private static readonly MessageParser<TBFUStB2DBuffDesc> _parser = new MessageParser<TBFUStB2DBuffDesc>(() => new TBFUStB2DBuffDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStB2DBuffDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStB2DBuffDesc.Parser);

	private readonly RepeatedField<FUStB2DBuffDesc> list_ = new RepeatedField<FUStB2DBuffDesc>();

	public static MessageParser<TBFUStB2DBuffDesc> Parser => _parser;

	public RepeatedField<FUStB2DBuffDesc> List => list_;

	public TBFUStB2DBuffDesc()
	{
	}

	public TBFUStB2DBuffDesc(TBFUStB2DBuffDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStB2DBuffDesc Clone()
	{
		return new TBFUStB2DBuffDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStB2DBuffDesc);
	}

	public bool Equals(TBFUStB2DBuffDesc other)
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

	public void MergeFrom(TBFUStB2DBuffDesc other)
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
