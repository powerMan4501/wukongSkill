using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class UnitStateData : IMessage<UnitStateData>, IMessage, IEquatable<UnitStateData>, IDeepCloneable<UnitStateData>
{
	private static readonly MessageParser<UnitStateData> _parser = new MessageParser<UnitStateData>(() => new UnitStateData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListWNRDeltaMsgFloat> _repeated_unitStates_codec = FieldCodec.ForMessage(10u, ListWNRDeltaMsgFloat.Parser);

	private readonly RepeatedField<ListWNRDeltaMsgFloat> unitStates_ = new RepeatedField<ListWNRDeltaMsgFloat>();

	public static MessageParser<UnitStateData> Parser => _parser;

	public RepeatedField<ListWNRDeltaMsgFloat> UnitStates => unitStates_;

	public UnitStateData()
	{
	}

	public UnitStateData(UnitStateData other)
		: this()
	{
		unitStates_ = other.unitStates_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitStateData Clone()
	{
		return new UnitStateData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitStateData);
	}

	public bool Equals(UnitStateData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!unitStates_.Equals(other.unitStates_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= unitStates_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		unitStates_.WriteTo(output, _repeated_unitStates_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += unitStates_.CalculateSize(_repeated_unitStates_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UnitStateData other)
	{
		if (other != null)
		{
			unitStates_.Add(other.unitStates_);
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
				unitStates_.AddEntriesFrom(input, _repeated_unitStates_codec);
			}
		}
	}
}
