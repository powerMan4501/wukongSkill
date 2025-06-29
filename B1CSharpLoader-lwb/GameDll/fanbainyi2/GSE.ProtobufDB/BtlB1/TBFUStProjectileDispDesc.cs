using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStProjectileDispDesc : IMessage<TBFUStProjectileDispDesc>, IMessage, IEquatable<TBFUStProjectileDispDesc>, IDeepCloneable<TBFUStProjectileDispDesc>
{
	private static readonly MessageParser<TBFUStProjectileDispDesc> _parser = new MessageParser<TBFUStProjectileDispDesc>(() => new TBFUStProjectileDispDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStProjectileDispDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStProjectileDispDesc.Parser);

	private readonly RepeatedField<FUStProjectileDispDesc> list_ = new RepeatedField<FUStProjectileDispDesc>();

	public static MessageParser<TBFUStProjectileDispDesc> Parser => _parser;

	public RepeatedField<FUStProjectileDispDesc> List => list_;

	public TBFUStProjectileDispDesc()
	{
	}

	public TBFUStProjectileDispDesc(TBFUStProjectileDispDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStProjectileDispDesc Clone()
	{
		return new TBFUStProjectileDispDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStProjectileDispDesc);
	}

	public bool Equals(TBFUStProjectileDispDesc other)
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

	public void MergeFrom(TBFUStProjectileDispDesc other)
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
