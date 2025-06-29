using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStUnitAIDesc : IMessage<TBFUStUnitAIDesc>, IMessage, IEquatable<TBFUStUnitAIDesc>, IDeepCloneable<TBFUStUnitAIDesc>
{
	private static readonly MessageParser<TBFUStUnitAIDesc> _parser = new MessageParser<TBFUStUnitAIDesc>(() => new TBFUStUnitAIDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStUnitAIDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStUnitAIDesc.Parser);

	private readonly RepeatedField<FUStUnitAIDesc> list_ = new RepeatedField<FUStUnitAIDesc>();

	public static MessageParser<TBFUStUnitAIDesc> Parser => _parser;

	public RepeatedField<FUStUnitAIDesc> List => list_;

	public TBFUStUnitAIDesc()
	{
	}

	public TBFUStUnitAIDesc(TBFUStUnitAIDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStUnitAIDesc Clone()
	{
		return new TBFUStUnitAIDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStUnitAIDesc);
	}

	public bool Equals(TBFUStUnitAIDesc other)
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

	public void MergeFrom(TBFUStUnitAIDesc other)
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
