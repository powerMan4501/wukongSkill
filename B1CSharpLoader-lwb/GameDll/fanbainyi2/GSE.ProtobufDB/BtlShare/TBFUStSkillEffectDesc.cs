using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStSkillEffectDesc : IMessage<TBFUStSkillEffectDesc>, IMessage, IEquatable<TBFUStSkillEffectDesc>, IDeepCloneable<TBFUStSkillEffectDesc>
{
	private static readonly MessageParser<TBFUStSkillEffectDesc> _parser = new MessageParser<TBFUStSkillEffectDesc>(() => new TBFUStSkillEffectDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStSkillEffectDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStSkillEffectDesc.Parser);

	private readonly RepeatedField<FUStSkillEffectDesc> list_ = new RepeatedField<FUStSkillEffectDesc>();

	public static MessageParser<TBFUStSkillEffectDesc> Parser => _parser;

	public RepeatedField<FUStSkillEffectDesc> List => list_;

	public TBFUStSkillEffectDesc()
	{
	}

	public TBFUStSkillEffectDesc(TBFUStSkillEffectDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStSkillEffectDesc Clone()
	{
		return new TBFUStSkillEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStSkillEffectDesc);
	}

	public bool Equals(TBFUStSkillEffectDesc other)
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

	public void MergeFrom(TBFUStSkillEffectDesc other)
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
