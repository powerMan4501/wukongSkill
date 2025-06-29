using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStAIThinkDesc : IMessage<TBFUStAIThinkDesc>, IMessage, IEquatable<TBFUStAIThinkDesc>, IDeepCloneable<TBFUStAIThinkDesc>
{
	private static readonly MessageParser<TBFUStAIThinkDesc> _parser = new MessageParser<TBFUStAIThinkDesc>(() => new TBFUStAIThinkDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAIThinkDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAIThinkDesc.Parser);

	private readonly RepeatedField<FUStAIThinkDesc> list_ = new RepeatedField<FUStAIThinkDesc>();

	public static MessageParser<TBFUStAIThinkDesc> Parser => _parser;

	public RepeatedField<FUStAIThinkDesc> List => list_;

	public TBFUStAIThinkDesc()
	{
	}

	public TBFUStAIThinkDesc(TBFUStAIThinkDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAIThinkDesc Clone()
	{
		return new TBFUStAIThinkDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAIThinkDesc);
	}

	public bool Equals(TBFUStAIThinkDesc other)
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

	public void MergeFrom(TBFUStAIThinkDesc other)
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
