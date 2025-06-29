using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStDeadSeqUnitConfigDesc : IMessage<TBFUStDeadSeqUnitConfigDesc>, IMessage, IEquatable<TBFUStDeadSeqUnitConfigDesc>, IDeepCloneable<TBFUStDeadSeqUnitConfigDesc>
{
	private static readonly MessageParser<TBFUStDeadSeqUnitConfigDesc> _parser = new MessageParser<TBFUStDeadSeqUnitConfigDesc>(() => new TBFUStDeadSeqUnitConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStDeadSeqUnitConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStDeadSeqUnitConfigDesc.Parser);

	private readonly RepeatedField<FUStDeadSeqUnitConfigDesc> list_ = new RepeatedField<FUStDeadSeqUnitConfigDesc>();

	public static MessageParser<TBFUStDeadSeqUnitConfigDesc> Parser => _parser;

	public RepeatedField<FUStDeadSeqUnitConfigDesc> List => list_;

	public TBFUStDeadSeqUnitConfigDesc()
	{
	}

	public TBFUStDeadSeqUnitConfigDesc(TBFUStDeadSeqUnitConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStDeadSeqUnitConfigDesc Clone()
	{
		return new TBFUStDeadSeqUnitConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStDeadSeqUnitConfigDesc);
	}

	public bool Equals(TBFUStDeadSeqUnitConfigDesc other)
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

	public void MergeFrom(TBFUStDeadSeqUnitConfigDesc other)
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
