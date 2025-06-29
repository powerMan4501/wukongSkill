using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_ObserveUnitsDeadWithOrder : IMessage<QuestCustom_ObserveUnitsDeadWithOrder>, IMessage, IEquatable<QuestCustom_ObserveUnitsDeadWithOrder>, IDeepCloneable<QuestCustom_ObserveUnitsDeadWithOrder>
{
	private static readonly MessageParser<QuestCustom_ObserveUnitsDeadWithOrder> _parser = new MessageParser<QuestCustom_ObserveUnitsDeadWithOrder>(() => new QuestCustom_ObserveUnitsDeadWithOrder());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<string> _repeated_observeActorGuid_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> observeActorGuid_ = new RepeatedField<string>();

	public static MessageParser<QuestCustom_ObserveUnitsDeadWithOrder> Parser => _parser;

	public RepeatedField<string> ObserveActorGuid => observeActorGuid_;

	public QuestCustom_ObserveUnitsDeadWithOrder()
	{
	}

	public QuestCustom_ObserveUnitsDeadWithOrder(QuestCustom_ObserveUnitsDeadWithOrder other)
		: this()
	{
		observeActorGuid_ = other.observeActorGuid_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_ObserveUnitsDeadWithOrder Clone()
	{
		return new QuestCustom_ObserveUnitsDeadWithOrder(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_ObserveUnitsDeadWithOrder);
	}

	public bool Equals(QuestCustom_ObserveUnitsDeadWithOrder other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!observeActorGuid_.Equals(other.observeActorGuid_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= observeActorGuid_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		observeActorGuid_.WriteTo(output, _repeated_observeActorGuid_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += observeActorGuid_.CalculateSize(_repeated_observeActorGuid_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_ObserveUnitsDeadWithOrder other)
	{
		if (other != null)
		{
			observeActorGuid_.Add(other.observeActorGuid_);
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
				observeActorGuid_.AddEntriesFrom(input, _repeated_observeActorGuid_codec);
			}
		}
	}
}
