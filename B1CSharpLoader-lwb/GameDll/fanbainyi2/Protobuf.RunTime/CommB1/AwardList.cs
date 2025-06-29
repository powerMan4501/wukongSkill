using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class AwardList : IMessage<AwardList>, IMessage, IEquatable<AwardList>, IDeepCloneable<AwardList>
{
	private static readonly MessageParser<AwardList> _parser = new MessageParser<AwardList>(() => new AwardList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ItemOne> _repeated_awards_codec = FieldCodec.ForMessage(10u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> awards_ = new RepeatedField<ItemOne>();

	public static MessageParser<AwardList> Parser => _parser;

	public RepeatedField<ItemOne> Awards => awards_;

	public AwardList()
	{
	}

	public AwardList(AwardList other)
		: this()
	{
		awards_ = other.awards_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AwardList Clone()
	{
		return new AwardList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AwardList);
	}

	public bool Equals(AwardList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!awards_.Equals(other.awards_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= awards_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		awards_.WriteTo(output, _repeated_awards_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += awards_.CalculateSize(_repeated_awards_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AwardList other)
	{
		if (other != null)
		{
			awards_.Add(other.awards_);
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
				awards_.AddEntriesFrom(input, _repeated_awards_codec);
			}
		}
	}
}
