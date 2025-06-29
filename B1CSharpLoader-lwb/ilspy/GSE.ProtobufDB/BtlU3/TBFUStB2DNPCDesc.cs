using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class TBFUStB2DNPCDesc : IMessage<TBFUStB2DNPCDesc>, IMessage, IEquatable<TBFUStB2DNPCDesc>, IDeepCloneable<TBFUStB2DNPCDesc>
{
	private static readonly MessageParser<TBFUStB2DNPCDesc> _parser = new MessageParser<TBFUStB2DNPCDesc>(() => new TBFUStB2DNPCDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStB2DNPCDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStB2DNPCDesc.Parser);

	private readonly RepeatedField<FUStB2DNPCDesc> list_ = new RepeatedField<FUStB2DNPCDesc>();

	public static MessageParser<TBFUStB2DNPCDesc> Parser => _parser;

	public RepeatedField<FUStB2DNPCDesc> List => list_;

	public TBFUStB2DNPCDesc()
	{
	}

	public TBFUStB2DNPCDesc(TBFUStB2DNPCDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStB2DNPCDesc Clone()
	{
		return new TBFUStB2DNPCDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStB2DNPCDesc);
	}

	public bool Equals(TBFUStB2DNPCDesc other)
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

	public void MergeFrom(TBFUStB2DNPCDesc other)
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
