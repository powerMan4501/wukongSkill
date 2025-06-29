using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStBuffTickRuleBySimpleStateDesc : IMessage<TBFUStBuffTickRuleBySimpleStateDesc>, IMessage, IEquatable<TBFUStBuffTickRuleBySimpleStateDesc>, IDeepCloneable<TBFUStBuffTickRuleBySimpleStateDesc>
{
	private static readonly MessageParser<TBFUStBuffTickRuleBySimpleStateDesc> _parser = new MessageParser<TBFUStBuffTickRuleBySimpleStateDesc>(() => new TBFUStBuffTickRuleBySimpleStateDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStBuffTickRuleBySimpleStateDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStBuffTickRuleBySimpleStateDesc.Parser);

	private readonly RepeatedField<FUStBuffTickRuleBySimpleStateDesc> list_ = new RepeatedField<FUStBuffTickRuleBySimpleStateDesc>();

	public static MessageParser<TBFUStBuffTickRuleBySimpleStateDesc> Parser => _parser;

	public RepeatedField<FUStBuffTickRuleBySimpleStateDesc> List => list_;

	public TBFUStBuffTickRuleBySimpleStateDesc()
	{
	}

	public TBFUStBuffTickRuleBySimpleStateDesc(TBFUStBuffTickRuleBySimpleStateDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStBuffTickRuleBySimpleStateDesc Clone()
	{
		return new TBFUStBuffTickRuleBySimpleStateDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStBuffTickRuleBySimpleStateDesc);
	}

	public bool Equals(TBFUStBuffTickRuleBySimpleStateDesc other)
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

	public void MergeFrom(TBFUStBuffTickRuleBySimpleStateDesc other)
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
