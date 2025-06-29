using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStAttrEffectDesc : IMessage<TBFUStAttrEffectDesc>, IMessage, IEquatable<TBFUStAttrEffectDesc>, IDeepCloneable<TBFUStAttrEffectDesc>
{
	private static readonly MessageParser<TBFUStAttrEffectDesc> _parser = new MessageParser<TBFUStAttrEffectDesc>(() => new TBFUStAttrEffectDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAttrEffectDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAttrEffectDesc.Parser);

	private readonly RepeatedField<FUStAttrEffectDesc> list_ = new RepeatedField<FUStAttrEffectDesc>();

	public static MessageParser<TBFUStAttrEffectDesc> Parser => _parser;

	public RepeatedField<FUStAttrEffectDesc> List => list_;

	public TBFUStAttrEffectDesc()
	{
	}

	public TBFUStAttrEffectDesc(TBFUStAttrEffectDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAttrEffectDesc Clone()
	{
		return new TBFUStAttrEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAttrEffectDesc);
	}

	public bool Equals(TBFUStAttrEffectDesc other)
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

	public void MergeFrom(TBFUStAttrEffectDesc other)
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
