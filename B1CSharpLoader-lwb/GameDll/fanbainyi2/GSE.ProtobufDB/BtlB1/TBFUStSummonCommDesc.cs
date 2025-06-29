using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStSummonCommDesc : IMessage<TBFUStSummonCommDesc>, IMessage, IEquatable<TBFUStSummonCommDesc>, IDeepCloneable<TBFUStSummonCommDesc>
{
	private static readonly MessageParser<TBFUStSummonCommDesc> _parser = new MessageParser<TBFUStSummonCommDesc>(() => new TBFUStSummonCommDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStSummonCommDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStSummonCommDesc.Parser);

	private readonly RepeatedField<FUStSummonCommDesc> list_ = new RepeatedField<FUStSummonCommDesc>();

	public static MessageParser<TBFUStSummonCommDesc> Parser => _parser;

	public RepeatedField<FUStSummonCommDesc> List => list_;

	public TBFUStSummonCommDesc()
	{
	}

	public TBFUStSummonCommDesc(TBFUStSummonCommDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStSummonCommDesc Clone()
	{
		return new TBFUStSummonCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStSummonCommDesc);
	}

	public bool Equals(TBFUStSummonCommDesc other)
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

	public void MergeFrom(TBFUStSummonCommDesc other)
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
