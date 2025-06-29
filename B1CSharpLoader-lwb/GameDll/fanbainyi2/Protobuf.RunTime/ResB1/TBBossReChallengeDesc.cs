using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBBossReChallengeDesc : IMessage<TBBossReChallengeDesc>, IMessage, IEquatable<TBBossReChallengeDesc>, IDeepCloneable<TBBossReChallengeDesc>
{
	private static readonly MessageParser<TBBossReChallengeDesc> _parser = new MessageParser<TBBossReChallengeDesc>(() => new TBBossReChallengeDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<BossReChallengeDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, BossReChallengeDesc.Parser);

	private readonly RepeatedField<BossReChallengeDesc> list_ = new RepeatedField<BossReChallengeDesc>();

	public static MessageParser<TBBossReChallengeDesc> Parser => _parser;

	public RepeatedField<BossReChallengeDesc> List => list_;

	public TBBossReChallengeDesc()
	{
	}

	public TBBossReChallengeDesc(TBBossReChallengeDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBBossReChallengeDesc Clone()
	{
		return new TBBossReChallengeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBBossReChallengeDesc);
	}

	public bool Equals(TBBossReChallengeDesc other)
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

	public void MergeFrom(TBBossReChallengeDesc other)
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
