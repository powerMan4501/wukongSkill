using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStTalentLvUpCfgDesc : IMessage<TBFUStTalentLvUpCfgDesc>, IMessage, IEquatable<TBFUStTalentLvUpCfgDesc>, IDeepCloneable<TBFUStTalentLvUpCfgDesc>
{
	private static readonly MessageParser<TBFUStTalentLvUpCfgDesc> _parser = new MessageParser<TBFUStTalentLvUpCfgDesc>(() => new TBFUStTalentLvUpCfgDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStTalentLvUpCfgDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStTalentLvUpCfgDesc.Parser);

	private readonly RepeatedField<FUStTalentLvUpCfgDesc> list_ = new RepeatedField<FUStTalentLvUpCfgDesc>();

	public static MessageParser<TBFUStTalentLvUpCfgDesc> Parser => _parser;

	public RepeatedField<FUStTalentLvUpCfgDesc> List => list_;

	public TBFUStTalentLvUpCfgDesc()
	{
	}

	public TBFUStTalentLvUpCfgDesc(TBFUStTalentLvUpCfgDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStTalentLvUpCfgDesc Clone()
	{
		return new TBFUStTalentLvUpCfgDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStTalentLvUpCfgDesc);
	}

	public bool Equals(TBFUStTalentLvUpCfgDesc other)
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

	public void MergeFrom(TBFUStTalentLvUpCfgDesc other)
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
