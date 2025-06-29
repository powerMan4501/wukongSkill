using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStHitVEffectDesc : IMessage<TBFUStHitVEffectDesc>, IMessage, IEquatable<TBFUStHitVEffectDesc>, IDeepCloneable<TBFUStHitVEffectDesc>
{
	private static readonly MessageParser<TBFUStHitVEffectDesc> _parser = new MessageParser<TBFUStHitVEffectDesc>(() => new TBFUStHitVEffectDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStHitVEffectDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStHitVEffectDesc.Parser);

	private readonly RepeatedField<FUStHitVEffectDesc> list_ = new RepeatedField<FUStHitVEffectDesc>();

	public static MessageParser<TBFUStHitVEffectDesc> Parser => _parser;

	public RepeatedField<FUStHitVEffectDesc> List => list_;

	public TBFUStHitVEffectDesc()
	{
	}

	public TBFUStHitVEffectDesc(TBFUStHitVEffectDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStHitVEffectDesc Clone()
	{
		return new TBFUStHitVEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStHitVEffectDesc);
	}

	public bool Equals(TBFUStHitVEffectDesc other)
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

	public void MergeFrom(TBFUStHitVEffectDesc other)
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
