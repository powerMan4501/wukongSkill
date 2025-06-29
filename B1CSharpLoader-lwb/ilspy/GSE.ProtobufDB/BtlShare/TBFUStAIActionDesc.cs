using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStAIActionDesc : IMessage<TBFUStAIActionDesc>, IMessage, IEquatable<TBFUStAIActionDesc>, IDeepCloneable<TBFUStAIActionDesc>
{
	private static readonly MessageParser<TBFUStAIActionDesc> _parser = new MessageParser<TBFUStAIActionDesc>(() => new TBFUStAIActionDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAIActionDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAIActionDesc.Parser);

	private readonly RepeatedField<FUStAIActionDesc> list_ = new RepeatedField<FUStAIActionDesc>();

	public static MessageParser<TBFUStAIActionDesc> Parser => _parser;

	public RepeatedField<FUStAIActionDesc> List => list_;

	public TBFUStAIActionDesc()
	{
	}

	public TBFUStAIActionDesc(TBFUStAIActionDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAIActionDesc Clone()
	{
		return new TBFUStAIActionDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAIActionDesc);
	}

	public bool Equals(TBFUStAIActionDesc other)
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

	public void MergeFrom(TBFUStAIActionDesc other)
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
