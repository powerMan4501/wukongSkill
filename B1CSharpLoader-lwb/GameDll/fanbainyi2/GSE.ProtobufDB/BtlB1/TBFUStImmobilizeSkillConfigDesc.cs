using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStImmobilizeSkillConfigDesc : IMessage<TBFUStImmobilizeSkillConfigDesc>, IMessage, IEquatable<TBFUStImmobilizeSkillConfigDesc>, IDeepCloneable<TBFUStImmobilizeSkillConfigDesc>
{
	private static readonly MessageParser<TBFUStImmobilizeSkillConfigDesc> _parser = new MessageParser<TBFUStImmobilizeSkillConfigDesc>(() => new TBFUStImmobilizeSkillConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStImmobilizeSkillConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStImmobilizeSkillConfigDesc.Parser);

	private readonly RepeatedField<FUStImmobilizeSkillConfigDesc> list_ = new RepeatedField<FUStImmobilizeSkillConfigDesc>();

	public static MessageParser<TBFUStImmobilizeSkillConfigDesc> Parser => _parser;

	public RepeatedField<FUStImmobilizeSkillConfigDesc> List => list_;

	public TBFUStImmobilizeSkillConfigDesc()
	{
	}

	public TBFUStImmobilizeSkillConfigDesc(TBFUStImmobilizeSkillConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStImmobilizeSkillConfigDesc Clone()
	{
		return new TBFUStImmobilizeSkillConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStImmobilizeSkillConfigDesc);
	}

	public bool Equals(TBFUStImmobilizeSkillConfigDesc other)
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

	public void MergeFrom(TBFUStImmobilizeSkillConfigDesc other)
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
