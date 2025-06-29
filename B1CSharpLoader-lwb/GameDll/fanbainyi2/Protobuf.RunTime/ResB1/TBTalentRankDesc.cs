using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBTalentRankDesc : IMessage<TBTalentRankDesc>, IMessage, IEquatable<TBTalentRankDesc>, IDeepCloneable<TBTalentRankDesc>
{
	private static readonly MessageParser<TBTalentRankDesc> _parser = new MessageParser<TBTalentRankDesc>(() => new TBTalentRankDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<TalentRankDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, TalentRankDesc.Parser);

	private readonly RepeatedField<TalentRankDesc> list_ = new RepeatedField<TalentRankDesc>();

	public static MessageParser<TBTalentRankDesc> Parser => _parser;

	public RepeatedField<TalentRankDesc> List => list_;

	public TBTalentRankDesc()
	{
	}

	public TBTalentRankDesc(TBTalentRankDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBTalentRankDesc Clone()
	{
		return new TBTalentRankDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBTalentRankDesc);
	}

	public bool Equals(TBTalentRankDesc other)
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

	public void MergeFrom(TBTalentRankDesc other)
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
