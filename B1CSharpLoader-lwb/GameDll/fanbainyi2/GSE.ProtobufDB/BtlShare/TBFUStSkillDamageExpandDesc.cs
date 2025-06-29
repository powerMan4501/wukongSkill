using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStSkillDamageExpandDesc : IMessage<TBFUStSkillDamageExpandDesc>, IMessage, IEquatable<TBFUStSkillDamageExpandDesc>, IDeepCloneable<TBFUStSkillDamageExpandDesc>
{
	private static readonly MessageParser<TBFUStSkillDamageExpandDesc> _parser = new MessageParser<TBFUStSkillDamageExpandDesc>(() => new TBFUStSkillDamageExpandDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStSkillDamageExpandDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStSkillDamageExpandDesc.Parser);

	private readonly RepeatedField<FUStSkillDamageExpandDesc> list_ = new RepeatedField<FUStSkillDamageExpandDesc>();

	public static MessageParser<TBFUStSkillDamageExpandDesc> Parser => _parser;

	public RepeatedField<FUStSkillDamageExpandDesc> List => list_;

	public TBFUStSkillDamageExpandDesc()
	{
	}

	public TBFUStSkillDamageExpandDesc(TBFUStSkillDamageExpandDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStSkillDamageExpandDesc Clone()
	{
		return new TBFUStSkillDamageExpandDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStSkillDamageExpandDesc);
	}

	public bool Equals(TBFUStSkillDamageExpandDesc other)
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

	public void MergeFrom(TBFUStSkillDamageExpandDesc other)
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
