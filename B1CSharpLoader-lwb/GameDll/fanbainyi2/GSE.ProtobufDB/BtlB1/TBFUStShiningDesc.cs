using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStShiningDesc : IMessage<TBFUStShiningDesc>, IMessage, IEquatable<TBFUStShiningDesc>, IDeepCloneable<TBFUStShiningDesc>
{
	private static readonly MessageParser<TBFUStShiningDesc> _parser = new MessageParser<TBFUStShiningDesc>(() => new TBFUStShiningDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStShiningDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStShiningDesc.Parser);

	private readonly RepeatedField<FUStShiningDesc> list_ = new RepeatedField<FUStShiningDesc>();

	public static MessageParser<TBFUStShiningDesc> Parser => _parser;

	public RepeatedField<FUStShiningDesc> List => list_;

	public TBFUStShiningDesc()
	{
	}

	public TBFUStShiningDesc(TBFUStShiningDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStShiningDesc Clone()
	{
		return new TBFUStShiningDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStShiningDesc);
	}

	public bool Equals(TBFUStShiningDesc other)
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

	public void MergeFrom(TBFUStShiningDesc other)
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
