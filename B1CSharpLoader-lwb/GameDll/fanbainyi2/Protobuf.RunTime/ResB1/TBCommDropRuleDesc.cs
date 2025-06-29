using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBCommDropRuleDesc : IMessage<TBCommDropRuleDesc>, IMessage, IEquatable<TBCommDropRuleDesc>, IDeepCloneable<TBCommDropRuleDesc>
{
	private static readonly MessageParser<TBCommDropRuleDesc> _parser = new MessageParser<TBCommDropRuleDesc>(() => new TBCommDropRuleDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CommDropRuleDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, CommDropRuleDesc.Parser);

	private readonly RepeatedField<CommDropRuleDesc> list_ = new RepeatedField<CommDropRuleDesc>();

	public static MessageParser<TBCommDropRuleDesc> Parser => _parser;

	public RepeatedField<CommDropRuleDesc> List => list_;

	public TBCommDropRuleDesc()
	{
	}

	public TBCommDropRuleDesc(TBCommDropRuleDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBCommDropRuleDesc Clone()
	{
		return new TBCommDropRuleDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBCommDropRuleDesc);
	}

	public bool Equals(TBCommDropRuleDesc other)
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

	public void MergeFrom(TBCommDropRuleDesc other)
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
