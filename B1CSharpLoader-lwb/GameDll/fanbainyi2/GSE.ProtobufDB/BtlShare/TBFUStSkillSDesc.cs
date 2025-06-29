using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStSkillSDesc : IMessage<TBFUStSkillSDesc>, IMessage, IEquatable<TBFUStSkillSDesc>, IDeepCloneable<TBFUStSkillSDesc>
{
	private static readonly MessageParser<TBFUStSkillSDesc> _parser = new MessageParser<TBFUStSkillSDesc>(() => new TBFUStSkillSDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStSkillSDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStSkillSDesc.Parser);

	private readonly RepeatedField<FUStSkillSDesc> list_ = new RepeatedField<FUStSkillSDesc>();

	public static MessageParser<TBFUStSkillSDesc> Parser => _parser;

	public RepeatedField<FUStSkillSDesc> List => list_;

	public TBFUStSkillSDesc()
	{
	}

	public TBFUStSkillSDesc(TBFUStSkillSDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStSkillSDesc Clone()
	{
		return new TBFUStSkillSDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStSkillSDesc);
	}

	public bool Equals(TBFUStSkillSDesc other)
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

	public void MergeFrom(TBFUStSkillSDesc other)
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
