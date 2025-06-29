using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace X2.Base;

public sealed class TBFUStB2DVictoryConditionsDesc : IMessage<TBFUStB2DVictoryConditionsDesc>, IMessage, IEquatable<TBFUStB2DVictoryConditionsDesc>, IDeepCloneable<TBFUStB2DVictoryConditionsDesc>
{
	private static readonly MessageParser<TBFUStB2DVictoryConditionsDesc> _parser = new MessageParser<TBFUStB2DVictoryConditionsDesc>(() => new TBFUStB2DVictoryConditionsDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStB2DVictoryConditionsDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStB2DVictoryConditionsDesc.Parser);

	private readonly RepeatedField<FUStB2DVictoryConditionsDesc> list_ = new RepeatedField<FUStB2DVictoryConditionsDesc>();

	public static MessageParser<TBFUStB2DVictoryConditionsDesc> Parser => _parser;

	public RepeatedField<FUStB2DVictoryConditionsDesc> List => list_;

	public TBFUStB2DVictoryConditionsDesc()
	{
	}

	public TBFUStB2DVictoryConditionsDesc(TBFUStB2DVictoryConditionsDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStB2DVictoryConditionsDesc Clone()
	{
		return new TBFUStB2DVictoryConditionsDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStB2DVictoryConditionsDesc);
	}

	public bool Equals(TBFUStB2DVictoryConditionsDesc other)
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

	public void MergeFrom(TBFUStB2DVictoryConditionsDesc other)
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
