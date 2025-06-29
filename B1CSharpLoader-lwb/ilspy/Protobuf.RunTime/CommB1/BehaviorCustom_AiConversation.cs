using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_AiConversation : IMessage<BehaviorCustom_AiConversation>, IMessage, IEquatable<BehaviorCustom_AiConversation>, IDeepCloneable<BehaviorCustom_AiConversation>
{
	private static readonly MessageParser<BehaviorCustom_AiConversation> _parser = new MessageParser<BehaviorCustom_AiConversation>(() => new BehaviorCustom_AiConversation());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<int> _repeated_contentIdList_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> contentIdList_ = new RepeatedField<int>();

	public static MessageParser<BehaviorCustom_AiConversation> Parser => _parser;

	public RepeatedField<int> ContentIdList => contentIdList_;

	public BehaviorCustom_AiConversation()
	{
	}

	public BehaviorCustom_AiConversation(BehaviorCustom_AiConversation other)
		: this()
	{
		contentIdList_ = other.contentIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_AiConversation Clone()
	{
		return new BehaviorCustom_AiConversation(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_AiConversation);
	}

	public bool Equals(BehaviorCustom_AiConversation other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!contentIdList_.Equals(other.contentIdList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= contentIdList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		contentIdList_.WriteTo(output, _repeated_contentIdList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += contentIdList_.CalculateSize(_repeated_contentIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_AiConversation other)
	{
		if (other != null)
		{
			contentIdList_.Add(other.contentIdList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				contentIdList_.AddEntriesFrom(input, _repeated_contentIdList_codec);
			}
		}
	}
}
