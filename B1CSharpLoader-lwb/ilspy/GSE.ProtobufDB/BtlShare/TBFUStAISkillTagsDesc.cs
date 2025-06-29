using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStAISkillTagsDesc : IMessage<TBFUStAISkillTagsDesc>, IMessage, IEquatable<TBFUStAISkillTagsDesc>, IDeepCloneable<TBFUStAISkillTagsDesc>
{
	private static readonly MessageParser<TBFUStAISkillTagsDesc> _parser = new MessageParser<TBFUStAISkillTagsDesc>(() => new TBFUStAISkillTagsDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAISkillTagsDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAISkillTagsDesc.Parser);

	private readonly RepeatedField<FUStAISkillTagsDesc> list_ = new RepeatedField<FUStAISkillTagsDesc>();

	public static MessageParser<TBFUStAISkillTagsDesc> Parser => _parser;

	public RepeatedField<FUStAISkillTagsDesc> List => list_;

	public TBFUStAISkillTagsDesc()
	{
	}

	public TBFUStAISkillTagsDesc(TBFUStAISkillTagsDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAISkillTagsDesc Clone()
	{
		return new TBFUStAISkillTagsDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAISkillTagsDesc);
	}

	public bool Equals(TBFUStAISkillTagsDesc other)
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

	public void MergeFrom(TBFUStAISkillTagsDesc other)
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
