using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStTROStrategyConfigDesc : IMessage<TBFUStTROStrategyConfigDesc>, IMessage, IEquatable<TBFUStTROStrategyConfigDesc>, IDeepCloneable<TBFUStTROStrategyConfigDesc>
{
	private static readonly MessageParser<TBFUStTROStrategyConfigDesc> _parser = new MessageParser<TBFUStTROStrategyConfigDesc>(() => new TBFUStTROStrategyConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStTROStrategyConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStTROStrategyConfigDesc.Parser);

	private readonly RepeatedField<FUStTROStrategyConfigDesc> list_ = new RepeatedField<FUStTROStrategyConfigDesc>();

	public static MessageParser<TBFUStTROStrategyConfigDesc> Parser => _parser;

	public RepeatedField<FUStTROStrategyConfigDesc> List => list_;

	public TBFUStTROStrategyConfigDesc()
	{
	}

	public TBFUStTROStrategyConfigDesc(TBFUStTROStrategyConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStTROStrategyConfigDesc Clone()
	{
		return new TBFUStTROStrategyConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStTROStrategyConfigDesc);
	}

	public bool Equals(TBFUStTROStrategyConfigDesc other)
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

	public void MergeFrom(TBFUStTROStrategyConfigDesc other)
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
