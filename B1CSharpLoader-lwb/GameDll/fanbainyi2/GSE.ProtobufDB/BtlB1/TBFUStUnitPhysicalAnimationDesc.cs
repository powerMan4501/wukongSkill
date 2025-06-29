using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStUnitPhysicalAnimationDesc : IMessage<TBFUStUnitPhysicalAnimationDesc>, IMessage, IEquatable<TBFUStUnitPhysicalAnimationDesc>, IDeepCloneable<TBFUStUnitPhysicalAnimationDesc>
{
	private static readonly MessageParser<TBFUStUnitPhysicalAnimationDesc> _parser = new MessageParser<TBFUStUnitPhysicalAnimationDesc>(() => new TBFUStUnitPhysicalAnimationDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStUnitPhysicalAnimationDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStUnitPhysicalAnimationDesc.Parser);

	private readonly RepeatedField<FUStUnitPhysicalAnimationDesc> list_ = new RepeatedField<FUStUnitPhysicalAnimationDesc>();

	public static MessageParser<TBFUStUnitPhysicalAnimationDesc> Parser => _parser;

	public RepeatedField<FUStUnitPhysicalAnimationDesc> List => list_;

	public TBFUStUnitPhysicalAnimationDesc()
	{
	}

	public TBFUStUnitPhysicalAnimationDesc(TBFUStUnitPhysicalAnimationDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStUnitPhysicalAnimationDesc Clone()
	{
		return new TBFUStUnitPhysicalAnimationDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStUnitPhysicalAnimationDesc);
	}

	public bool Equals(TBFUStUnitPhysicalAnimationDesc other)
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

	public void MergeFrom(TBFUStUnitPhysicalAnimationDesc other)
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
