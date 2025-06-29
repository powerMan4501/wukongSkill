using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStUnitLevelUpDesc : IMessage<TBFUStUnitLevelUpDesc>, IMessage, IEquatable<TBFUStUnitLevelUpDesc>, IDeepCloneable<TBFUStUnitLevelUpDesc>
{
	private static readonly MessageParser<TBFUStUnitLevelUpDesc> _parser = new MessageParser<TBFUStUnitLevelUpDesc>(() => new TBFUStUnitLevelUpDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStUnitLevelUpDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStUnitLevelUpDesc.Parser);

	private readonly RepeatedField<FUStUnitLevelUpDesc> list_ = new RepeatedField<FUStUnitLevelUpDesc>();

	public static MessageParser<TBFUStUnitLevelUpDesc> Parser => _parser;

	public RepeatedField<FUStUnitLevelUpDesc> List => list_;

	public TBFUStUnitLevelUpDesc()
	{
	}

	public TBFUStUnitLevelUpDesc(TBFUStUnitLevelUpDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStUnitLevelUpDesc Clone()
	{
		return new TBFUStUnitLevelUpDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStUnitLevelUpDesc);
	}

	public bool Equals(TBFUStUnitLevelUpDesc other)
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

	public void MergeFrom(TBFUStUnitLevelUpDesc other)
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
