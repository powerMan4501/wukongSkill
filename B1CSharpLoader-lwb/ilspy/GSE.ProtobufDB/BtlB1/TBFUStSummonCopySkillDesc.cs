using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStSummonCopySkillDesc : IMessage<TBFUStSummonCopySkillDesc>, IMessage, IEquatable<TBFUStSummonCopySkillDesc>, IDeepCloneable<TBFUStSummonCopySkillDesc>
{
	private static readonly MessageParser<TBFUStSummonCopySkillDesc> _parser = new MessageParser<TBFUStSummonCopySkillDesc>(() => new TBFUStSummonCopySkillDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStSummonCopySkillDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStSummonCopySkillDesc.Parser);

	private readonly RepeatedField<FUStSummonCopySkillDesc> list_ = new RepeatedField<FUStSummonCopySkillDesc>();

	public static MessageParser<TBFUStSummonCopySkillDesc> Parser => _parser;

	public RepeatedField<FUStSummonCopySkillDesc> List => list_;

	public TBFUStSummonCopySkillDesc()
	{
	}

	public TBFUStSummonCopySkillDesc(TBFUStSummonCopySkillDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStSummonCopySkillDesc Clone()
	{
		return new TBFUStSummonCopySkillDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStSummonCopySkillDesc);
	}

	public bool Equals(TBFUStSummonCopySkillDesc other)
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

	public void MergeFrom(TBFUStSummonCopySkillDesc other)
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
