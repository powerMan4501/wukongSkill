using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStBuffIconDesc : IMessage<TBFUStBuffIconDesc>, IMessage, IEquatable<TBFUStBuffIconDesc>, IDeepCloneable<TBFUStBuffIconDesc>
{
	private static readonly MessageParser<TBFUStBuffIconDesc> _parser = new MessageParser<TBFUStBuffIconDesc>(() => new TBFUStBuffIconDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStBuffIconDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStBuffIconDesc.Parser);

	private readonly RepeatedField<FUStBuffIconDesc> list_ = new RepeatedField<FUStBuffIconDesc>();

	public static MessageParser<TBFUStBuffIconDesc> Parser => _parser;

	public RepeatedField<FUStBuffIconDesc> List => list_;

	public TBFUStBuffIconDesc()
	{
	}

	public TBFUStBuffIconDesc(TBFUStBuffIconDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStBuffIconDesc Clone()
	{
		return new TBFUStBuffIconDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStBuffIconDesc);
	}

	public bool Equals(TBFUStBuffIconDesc other)
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

	public void MergeFrom(TBFUStBuffIconDesc other)
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
