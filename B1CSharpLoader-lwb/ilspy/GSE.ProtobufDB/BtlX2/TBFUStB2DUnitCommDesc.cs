using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class TBFUStB2DUnitCommDesc : IMessage<TBFUStB2DUnitCommDesc>, IMessage, IEquatable<TBFUStB2DUnitCommDesc>, IDeepCloneable<TBFUStB2DUnitCommDesc>
{
	private static readonly MessageParser<TBFUStB2DUnitCommDesc> _parser = new MessageParser<TBFUStB2DUnitCommDesc>(() => new TBFUStB2DUnitCommDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStB2DUnitCommDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStB2DUnitCommDesc.Parser);

	private readonly RepeatedField<FUStB2DUnitCommDesc> list_ = new RepeatedField<FUStB2DUnitCommDesc>();

	public static MessageParser<TBFUStB2DUnitCommDesc> Parser => _parser;

	public RepeatedField<FUStB2DUnitCommDesc> List => list_;

	public TBFUStB2DUnitCommDesc()
	{
	}

	public TBFUStB2DUnitCommDesc(TBFUStB2DUnitCommDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStB2DUnitCommDesc Clone()
	{
		return new TBFUStB2DUnitCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStB2DUnitCommDesc);
	}

	public bool Equals(TBFUStB2DUnitCommDesc other)
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

	public void MergeFrom(TBFUStB2DUnitCommDesc other)
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
