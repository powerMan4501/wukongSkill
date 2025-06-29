using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStAiConversationEventDesc : IMessage<TBFUStAiConversationEventDesc>, IMessage, IEquatable<TBFUStAiConversationEventDesc>, IDeepCloneable<TBFUStAiConversationEventDesc>
{
	private static readonly MessageParser<TBFUStAiConversationEventDesc> _parser = new MessageParser<TBFUStAiConversationEventDesc>(() => new TBFUStAiConversationEventDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAiConversationEventDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAiConversationEventDesc.Parser);

	private readonly RepeatedField<FUStAiConversationEventDesc> list_ = new RepeatedField<FUStAiConversationEventDesc>();

	public static MessageParser<TBFUStAiConversationEventDesc> Parser => _parser;

	public RepeatedField<FUStAiConversationEventDesc> List => list_;

	public TBFUStAiConversationEventDesc()
	{
	}

	public TBFUStAiConversationEventDesc(TBFUStAiConversationEventDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAiConversationEventDesc Clone()
	{
		return new TBFUStAiConversationEventDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAiConversationEventDesc);
	}

	public bool Equals(TBFUStAiConversationEventDesc other)
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

	public void MergeFrom(TBFUStAiConversationEventDesc other)
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
