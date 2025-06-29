using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStChallengeDesc : IMessage<TBFUStChallengeDesc>, IMessage, IEquatable<TBFUStChallengeDesc>, IDeepCloneable<TBFUStChallengeDesc>
{
	private static readonly MessageParser<TBFUStChallengeDesc> _parser = new MessageParser<TBFUStChallengeDesc>(() => new TBFUStChallengeDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStChallengeDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStChallengeDesc.Parser);

	private readonly RepeatedField<FUStChallengeDesc> list_ = new RepeatedField<FUStChallengeDesc>();

	public static MessageParser<TBFUStChallengeDesc> Parser => _parser;

	public RepeatedField<FUStChallengeDesc> List => list_;

	public TBFUStChallengeDesc()
	{
	}

	public TBFUStChallengeDesc(TBFUStChallengeDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStChallengeDesc Clone()
	{
		return new TBFUStChallengeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStChallengeDesc);
	}

	public bool Equals(TBFUStChallengeDesc other)
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

	public void MergeFrom(TBFUStChallengeDesc other)
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
