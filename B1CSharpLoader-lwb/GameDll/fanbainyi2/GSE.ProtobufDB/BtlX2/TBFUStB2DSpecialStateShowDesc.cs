using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class TBFUStB2DSpecialStateShowDesc : IMessage<TBFUStB2DSpecialStateShowDesc>, IMessage, IEquatable<TBFUStB2DSpecialStateShowDesc>, IDeepCloneable<TBFUStB2DSpecialStateShowDesc>
{
	private static readonly MessageParser<TBFUStB2DSpecialStateShowDesc> _parser = new MessageParser<TBFUStB2DSpecialStateShowDesc>(() => new TBFUStB2DSpecialStateShowDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStB2DSpecialStateShowDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStB2DSpecialStateShowDesc.Parser);

	private readonly RepeatedField<FUStB2DSpecialStateShowDesc> list_ = new RepeatedField<FUStB2DSpecialStateShowDesc>();

	public static MessageParser<TBFUStB2DSpecialStateShowDesc> Parser => _parser;

	public RepeatedField<FUStB2DSpecialStateShowDesc> List => list_;

	public TBFUStB2DSpecialStateShowDesc()
	{
	}

	public TBFUStB2DSpecialStateShowDesc(TBFUStB2DSpecialStateShowDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStB2DSpecialStateShowDesc Clone()
	{
		return new TBFUStB2DSpecialStateShowDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStB2DSpecialStateShowDesc);
	}

	public bool Equals(TBFUStB2DSpecialStateShowDesc other)
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

	public void MergeFrom(TBFUStB2DSpecialStateShowDesc other)
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
