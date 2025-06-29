using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStEffectiveHitProjectileEffectDesc : IMessage<TBFUStEffectiveHitProjectileEffectDesc>, IMessage, IEquatable<TBFUStEffectiveHitProjectileEffectDesc>, IDeepCloneable<TBFUStEffectiveHitProjectileEffectDesc>
{
	private static readonly MessageParser<TBFUStEffectiveHitProjectileEffectDesc> _parser = new MessageParser<TBFUStEffectiveHitProjectileEffectDesc>(() => new TBFUStEffectiveHitProjectileEffectDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStEffectiveHitProjectileEffectDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStEffectiveHitProjectileEffectDesc.Parser);

	private readonly RepeatedField<FUStEffectiveHitProjectileEffectDesc> list_ = new RepeatedField<FUStEffectiveHitProjectileEffectDesc>();

	public static MessageParser<TBFUStEffectiveHitProjectileEffectDesc> Parser => _parser;

	public RepeatedField<FUStEffectiveHitProjectileEffectDesc> List => list_;

	public TBFUStEffectiveHitProjectileEffectDesc()
	{
	}

	public TBFUStEffectiveHitProjectileEffectDesc(TBFUStEffectiveHitProjectileEffectDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStEffectiveHitProjectileEffectDesc Clone()
	{
		return new TBFUStEffectiveHitProjectileEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStEffectiveHitProjectileEffectDesc);
	}

	public bool Equals(TBFUStEffectiveHitProjectileEffectDesc other)
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

	public void MergeFrom(TBFUStEffectiveHitProjectileEffectDesc other)
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
