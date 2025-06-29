using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStCollectionSpawnGroupDesc : IMessage<TBFUStCollectionSpawnGroupDesc>, IMessage, IEquatable<TBFUStCollectionSpawnGroupDesc>, IDeepCloneable<TBFUStCollectionSpawnGroupDesc>
{
	private static readonly MessageParser<TBFUStCollectionSpawnGroupDesc> _parser = new MessageParser<TBFUStCollectionSpawnGroupDesc>(() => new TBFUStCollectionSpawnGroupDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStCollectionSpawnGroupDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStCollectionSpawnGroupDesc.Parser);

	private readonly RepeatedField<FUStCollectionSpawnGroupDesc> list_ = new RepeatedField<FUStCollectionSpawnGroupDesc>();

	public static MessageParser<TBFUStCollectionSpawnGroupDesc> Parser => _parser;

	public RepeatedField<FUStCollectionSpawnGroupDesc> List => list_;

	public TBFUStCollectionSpawnGroupDesc()
	{
	}

	public TBFUStCollectionSpawnGroupDesc(TBFUStCollectionSpawnGroupDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStCollectionSpawnGroupDesc Clone()
	{
		return new TBFUStCollectionSpawnGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStCollectionSpawnGroupDesc);
	}

	public bool Equals(TBFUStCollectionSpawnGroupDesc other)
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

	public void MergeFrom(TBFUStCollectionSpawnGroupDesc other)
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
