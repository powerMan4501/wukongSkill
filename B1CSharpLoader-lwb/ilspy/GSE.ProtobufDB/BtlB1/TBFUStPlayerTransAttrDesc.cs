using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStPlayerTransAttrDesc : IMessage<TBFUStPlayerTransAttrDesc>, IMessage, IEquatable<TBFUStPlayerTransAttrDesc>, IDeepCloneable<TBFUStPlayerTransAttrDesc>
{
	private static readonly MessageParser<TBFUStPlayerTransAttrDesc> _parser = new MessageParser<TBFUStPlayerTransAttrDesc>(() => new TBFUStPlayerTransAttrDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStPlayerTransAttrDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStPlayerTransAttrDesc.Parser);

	private readonly RepeatedField<FUStPlayerTransAttrDesc> list_ = new RepeatedField<FUStPlayerTransAttrDesc>();

	public static MessageParser<TBFUStPlayerTransAttrDesc> Parser => _parser;

	public RepeatedField<FUStPlayerTransAttrDesc> List => list_;

	public TBFUStPlayerTransAttrDesc()
	{
	}

	public TBFUStPlayerTransAttrDesc(TBFUStPlayerTransAttrDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStPlayerTransAttrDesc Clone()
	{
		return new TBFUStPlayerTransAttrDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStPlayerTransAttrDesc);
	}

	public bool Equals(TBFUStPlayerTransAttrDesc other)
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

	public void MergeFrom(TBFUStPlayerTransAttrDesc other)
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
