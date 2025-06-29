using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class SimpleStateData : IMessage<SimpleStateData>, IMessage, IEquatable<SimpleStateData>, IDeepCloneable<SimpleStateData>
{
	private static readonly MessageParser<SimpleStateData> _parser = new MessageParser<SimpleStateData>(() => new SimpleStateData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListWNRDeltaMsgInt> _repeated_simpleStates_codec = FieldCodec.ForMessage(10u, ListWNRDeltaMsgInt.Parser);

	private readonly RepeatedField<ListWNRDeltaMsgInt> simpleStates_ = new RepeatedField<ListWNRDeltaMsgInt>();

	public static MessageParser<SimpleStateData> Parser => _parser;

	public RepeatedField<ListWNRDeltaMsgInt> SimpleStates => simpleStates_;

	public SimpleStateData()
	{
	}

	public SimpleStateData(SimpleStateData other)
		: this()
	{
		simpleStates_ = other.simpleStates_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SimpleStateData Clone()
	{
		return new SimpleStateData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SimpleStateData);
	}

	public bool Equals(SimpleStateData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!simpleStates_.Equals(other.simpleStates_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= simpleStates_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		simpleStates_.WriteTo(output, _repeated_simpleStates_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += simpleStates_.CalculateSize(_repeated_simpleStates_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SimpleStateData other)
	{
		if (other != null)
		{
			simpleStates_.Add(other.simpleStates_);
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
				simpleStates_.AddEntriesFrom(input, _repeated_simpleStates_codec);
			}
		}
	}
}
