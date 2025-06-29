using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStGlobalCannotDeadExtraConfigDesc : IMessage<TBFUStGlobalCannotDeadExtraConfigDesc>, IMessage, IEquatable<TBFUStGlobalCannotDeadExtraConfigDesc>, IDeepCloneable<TBFUStGlobalCannotDeadExtraConfigDesc>
{
	private static readonly MessageParser<TBFUStGlobalCannotDeadExtraConfigDesc> _parser = new MessageParser<TBFUStGlobalCannotDeadExtraConfigDesc>(() => new TBFUStGlobalCannotDeadExtraConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStGlobalCannotDeadExtraConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStGlobalCannotDeadExtraConfigDesc.Parser);

	private readonly RepeatedField<FUStGlobalCannotDeadExtraConfigDesc> list_ = new RepeatedField<FUStGlobalCannotDeadExtraConfigDesc>();

	public static MessageParser<TBFUStGlobalCannotDeadExtraConfigDesc> Parser => _parser;

	public RepeatedField<FUStGlobalCannotDeadExtraConfigDesc> List => list_;

	public TBFUStGlobalCannotDeadExtraConfigDesc()
	{
	}

	public TBFUStGlobalCannotDeadExtraConfigDesc(TBFUStGlobalCannotDeadExtraConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStGlobalCannotDeadExtraConfigDesc Clone()
	{
		return new TBFUStGlobalCannotDeadExtraConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStGlobalCannotDeadExtraConfigDesc);
	}

	public bool Equals(TBFUStGlobalCannotDeadExtraConfigDesc other)
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

	public void MergeFrom(TBFUStGlobalCannotDeadExtraConfigDesc other)
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
