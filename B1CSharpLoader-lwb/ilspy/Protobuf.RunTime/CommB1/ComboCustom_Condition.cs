using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ComboCustom_Condition : IMessage<ComboCustom_Condition>, IMessage, IEquatable<ComboCustom_Condition>, IDeepCloneable<ComboCustom_Condition>
{
	private static readonly MessageParser<ComboCustom_Condition> _parser = new MessageParser<ComboCustom_Condition>(() => new ComboCustom_Condition());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CalliopeCustom_ComboCondition> _repeated_comboConditions_codec = FieldCodec.ForMessage(10u, CalliopeCustom_ComboCondition.Parser);

	private readonly RepeatedField<CalliopeCustom_ComboCondition> comboConditions_ = new RepeatedField<CalliopeCustom_ComboCondition>();

	public static MessageParser<ComboCustom_Condition> Parser => _parser;

	public RepeatedField<CalliopeCustom_ComboCondition> ComboConditions => comboConditions_;

	public ComboCustom_Condition()
	{
	}

	public ComboCustom_Condition(ComboCustom_Condition other)
		: this()
	{
		comboConditions_ = other.comboConditions_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ComboCustom_Condition Clone()
	{
		return new ComboCustom_Condition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ComboCustom_Condition);
	}

	public bool Equals(ComboCustom_Condition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!comboConditions_.Equals(other.comboConditions_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= comboConditions_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		comboConditions_.WriteTo(output, _repeated_comboConditions_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += comboConditions_.CalculateSize(_repeated_comboConditions_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ComboCustom_Condition other)
	{
		if (other != null)
		{
			comboConditions_.Add(other.comboConditions_);
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
				comboConditions_.AddEntriesFrom(input, _repeated_comboConditions_codec);
			}
		}
	}
}
