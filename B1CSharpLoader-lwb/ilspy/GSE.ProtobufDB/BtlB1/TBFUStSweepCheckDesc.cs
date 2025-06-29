using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStSweepCheckDesc : IMessage<TBFUStSweepCheckDesc>, IMessage, IEquatable<TBFUStSweepCheckDesc>, IDeepCloneable<TBFUStSweepCheckDesc>
{
	private static readonly MessageParser<TBFUStSweepCheckDesc> _parser = new MessageParser<TBFUStSweepCheckDesc>(() => new TBFUStSweepCheckDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStSweepCheckDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStSweepCheckDesc.Parser);

	private readonly RepeatedField<FUStSweepCheckDesc> list_ = new RepeatedField<FUStSweepCheckDesc>();

	public static MessageParser<TBFUStSweepCheckDesc> Parser => _parser;

	public RepeatedField<FUStSweepCheckDesc> List => list_;

	public TBFUStSweepCheckDesc()
	{
	}

	public TBFUStSweepCheckDesc(TBFUStSweepCheckDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStSweepCheckDesc Clone()
	{
		return new TBFUStSweepCheckDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStSweepCheckDesc);
	}

	public bool Equals(TBFUStSweepCheckDesc other)
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

	public void MergeFrom(TBFUStSweepCheckDesc other)
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
