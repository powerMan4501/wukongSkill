using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_WeightRandom : IMessage<BehaviorCustom_WeightRandom>, IMessage, IEquatable<BehaviorCustom_WeightRandom>, IDeepCloneable<BehaviorCustom_WeightRandom>
{
	private static readonly MessageParser<BehaviorCustom_WeightRandom> _parser = new MessageParser<BehaviorCustom_WeightRandom>(() => new BehaviorCustom_WeightRandom());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<BehaviorCustom_WeightPin> _repeated_weightPins_codec = FieldCodec.ForMessage(10u, BehaviorCustom_WeightPin.Parser);

	private readonly RepeatedField<BehaviorCustom_WeightPin> weightPins_ = new RepeatedField<BehaviorCustom_WeightPin>();

	public static MessageParser<BehaviorCustom_WeightRandom> Parser => _parser;

	public RepeatedField<BehaviorCustom_WeightPin> WeightPins => weightPins_;

	public BehaviorCustom_WeightRandom()
	{
	}

	public BehaviorCustom_WeightRandom(BehaviorCustom_WeightRandom other)
		: this()
	{
		weightPins_ = other.weightPins_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_WeightRandom Clone()
	{
		return new BehaviorCustom_WeightRandom(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_WeightRandom);
	}

	public bool Equals(BehaviorCustom_WeightRandom other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!weightPins_.Equals(other.weightPins_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= weightPins_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		weightPins_.WriteTo(output, _repeated_weightPins_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += weightPins_.CalculateSize(_repeated_weightPins_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_WeightRandom other)
	{
		if (other != null)
		{
			weightPins_.Add(other.weightPins_);
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
				weightPins_.AddEntriesFrom(input, _repeated_weightPins_codec);
			}
		}
	}
}
