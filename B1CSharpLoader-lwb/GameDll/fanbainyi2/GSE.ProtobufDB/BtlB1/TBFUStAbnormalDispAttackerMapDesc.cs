using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStAbnormalDispAttackerMapDesc : IMessage<TBFUStAbnormalDispAttackerMapDesc>, IMessage, IEquatable<TBFUStAbnormalDispAttackerMapDesc>, IDeepCloneable<TBFUStAbnormalDispAttackerMapDesc>
{
	private static readonly MessageParser<TBFUStAbnormalDispAttackerMapDesc> _parser = new MessageParser<TBFUStAbnormalDispAttackerMapDesc>(() => new TBFUStAbnormalDispAttackerMapDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAbnormalDispAttackerMapDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAbnormalDispAttackerMapDesc.Parser);

	private readonly RepeatedField<FUStAbnormalDispAttackerMapDesc> list_ = new RepeatedField<FUStAbnormalDispAttackerMapDesc>();

	public static MessageParser<TBFUStAbnormalDispAttackerMapDesc> Parser => _parser;

	public RepeatedField<FUStAbnormalDispAttackerMapDesc> List => list_;

	public TBFUStAbnormalDispAttackerMapDesc()
	{
	}

	public TBFUStAbnormalDispAttackerMapDesc(TBFUStAbnormalDispAttackerMapDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAbnormalDispAttackerMapDesc Clone()
	{
		return new TBFUStAbnormalDispAttackerMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAbnormalDispAttackerMapDesc);
	}

	public bool Equals(TBFUStAbnormalDispAttackerMapDesc other)
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

	public void MergeFrom(TBFUStAbnormalDispAttackerMapDesc other)
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
