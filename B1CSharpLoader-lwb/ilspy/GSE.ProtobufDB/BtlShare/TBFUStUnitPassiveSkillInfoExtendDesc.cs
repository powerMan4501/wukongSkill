using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStUnitPassiveSkillInfoExtendDesc : IMessage<TBFUStUnitPassiveSkillInfoExtendDesc>, IMessage, IEquatable<TBFUStUnitPassiveSkillInfoExtendDesc>, IDeepCloneable<TBFUStUnitPassiveSkillInfoExtendDesc>
{
	private static readonly MessageParser<TBFUStUnitPassiveSkillInfoExtendDesc> _parser = new MessageParser<TBFUStUnitPassiveSkillInfoExtendDesc>(() => new TBFUStUnitPassiveSkillInfoExtendDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStUnitPassiveSkillInfoExtendDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStUnitPassiveSkillInfoExtendDesc.Parser);

	private readonly RepeatedField<FUStUnitPassiveSkillInfoExtendDesc> list_ = new RepeatedField<FUStUnitPassiveSkillInfoExtendDesc>();

	public static MessageParser<TBFUStUnitPassiveSkillInfoExtendDesc> Parser => _parser;

	public RepeatedField<FUStUnitPassiveSkillInfoExtendDesc> List => list_;

	public TBFUStUnitPassiveSkillInfoExtendDesc()
	{
	}

	public TBFUStUnitPassiveSkillInfoExtendDesc(TBFUStUnitPassiveSkillInfoExtendDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStUnitPassiveSkillInfoExtendDesc Clone()
	{
		return new TBFUStUnitPassiveSkillInfoExtendDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStUnitPassiveSkillInfoExtendDesc);
	}

	public bool Equals(TBFUStUnitPassiveSkillInfoExtendDesc other)
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

	public void MergeFrom(TBFUStUnitPassiveSkillInfoExtendDesc other)
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
