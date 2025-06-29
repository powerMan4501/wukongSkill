using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class TaskCustom_ObserveUnitsDeadWithOrder : IMessage<TaskCustom_ObserveUnitsDeadWithOrder>, IMessage, IEquatable<TaskCustom_ObserveUnitsDeadWithOrder>, IDeepCloneable<TaskCustom_ObserveUnitsDeadWithOrder>
{
	private static readonly MessageParser<TaskCustom_ObserveUnitsDeadWithOrder> _parser = new MessageParser<TaskCustom_ObserveUnitsDeadWithOrder>(() => new TaskCustom_ObserveUnitsDeadWithOrder());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<string> _repeated_observeActorGuid_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> observeActorGuid_ = new RepeatedField<string>();

	public static MessageParser<TaskCustom_ObserveUnitsDeadWithOrder> Parser => _parser;

	public RepeatedField<string> ObserveActorGuid => observeActorGuid_;

	public TaskCustom_ObserveUnitsDeadWithOrder()
	{
	}

	public TaskCustom_ObserveUnitsDeadWithOrder(TaskCustom_ObserveUnitsDeadWithOrder other)
		: this()
	{
		observeActorGuid_ = other.observeActorGuid_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskCustom_ObserveUnitsDeadWithOrder Clone()
	{
		return new TaskCustom_ObserveUnitsDeadWithOrder(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskCustom_ObserveUnitsDeadWithOrder);
	}

	public bool Equals(TaskCustom_ObserveUnitsDeadWithOrder other)
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

	public void MergeFrom(TaskCustom_ObserveUnitsDeadWithOrder other)
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
