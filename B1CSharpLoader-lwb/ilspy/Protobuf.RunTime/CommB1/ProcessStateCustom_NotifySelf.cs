using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessStateCustom_NotifySelf : IMessage<ProcessStateCustom_NotifySelf>, IMessage, IEquatable<ProcessStateCustom_NotifySelf>, IDeepCloneable<ProcessStateCustom_NotifySelf>
{
	private static readonly MessageParser<ProcessStateCustom_NotifySelf> _parser = new MessageParser<ProcessStateCustom_NotifySelf>(() => new ProcessStateCustom_NotifySelf());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<string> _repeated_notifyTagStrings_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> notifyTagStrings_ = new RepeatedField<string>();

	public static MessageParser<ProcessStateCustom_NotifySelf> Parser => _parser;

	public RepeatedField<string> NotifyTagStrings => notifyTagStrings_;

	public ProcessStateCustom_NotifySelf()
	{
	}

	public ProcessStateCustom_NotifySelf(ProcessStateCustom_NotifySelf other)
		: this()
	{
		notifyTagStrings_ = other.notifyTagStrings_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_NotifySelf Clone()
	{
		return new ProcessStateCustom_NotifySelf(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_NotifySelf);
	}

	public bool Equals(ProcessStateCustom_NotifySelf other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!notifyTagStrings_.Equals(other.notifyTagStrings_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= notifyTagStrings_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		notifyTagStrings_.WriteTo(output, _repeated_notifyTagStrings_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += notifyTagStrings_.CalculateSize(_repeated_notifyTagStrings_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_NotifySelf other)
	{
		if (other != null)
		{
			notifyTagStrings_.Add(other.notifyTagStrings_);
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
				notifyTagStrings_.AddEntriesFrom(input, _repeated_notifyTagStrings_codec);
			}
		}
	}
}
