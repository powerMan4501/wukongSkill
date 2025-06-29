using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class TBFUStB2DSkillLevelMapDesc : IMessage<TBFUStB2DSkillLevelMapDesc>, IMessage, IEquatable<TBFUStB2DSkillLevelMapDesc>, IDeepCloneable<TBFUStB2DSkillLevelMapDesc>
{
	private static readonly MessageParser<TBFUStB2DSkillLevelMapDesc> _parser = new MessageParser<TBFUStB2DSkillLevelMapDesc>(() => new TBFUStB2DSkillLevelMapDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStB2DSkillLevelMapDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStB2DSkillLevelMapDesc.Parser);

	private readonly RepeatedField<FUStB2DSkillLevelMapDesc> list_ = new RepeatedField<FUStB2DSkillLevelMapDesc>();

	public static MessageParser<TBFUStB2DSkillLevelMapDesc> Parser => _parser;

	public RepeatedField<FUStB2DSkillLevelMapDesc> List => list_;

	public TBFUStB2DSkillLevelMapDesc()
	{
	}

	public TBFUStB2DSkillLevelMapDesc(TBFUStB2DSkillLevelMapDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStB2DSkillLevelMapDesc Clone()
	{
		return new TBFUStB2DSkillLevelMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStB2DSkillLevelMapDesc);
	}

	public bool Equals(TBFUStB2DSkillLevelMapDesc other)
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

	public void MergeFrom(TBFUStB2DSkillLevelMapDesc other)
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
