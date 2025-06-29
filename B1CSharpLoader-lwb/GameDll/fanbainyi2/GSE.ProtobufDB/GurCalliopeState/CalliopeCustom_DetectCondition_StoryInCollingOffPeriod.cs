using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_StoryInCollingOffPeriod : IMessage<CalliopeCustom_DetectCondition_StoryInCollingOffPeriod>, IMessage, IEquatable<CalliopeCustom_DetectCondition_StoryInCollingOffPeriod>, IDeepCloneable<CalliopeCustom_DetectCondition_StoryInCollingOffPeriod>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_StoryInCollingOffPeriod> _parser = new MessageParser<CalliopeCustom_DetectCondition_StoryInCollingOffPeriod>(() => new CalliopeCustom_DetectCondition_StoryInCollingOffPeriod());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CalliopeCustom_DetectCondition_StoryInCollingOffPeriod> Parser => _parser;

	public CalliopeCustom_DetectCondition_StoryInCollingOffPeriod()
	{
	}

	public CalliopeCustom_DetectCondition_StoryInCollingOffPeriod(CalliopeCustom_DetectCondition_StoryInCollingOffPeriod other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_StoryInCollingOffPeriod Clone()
	{
		return new CalliopeCustom_DetectCondition_StoryInCollingOffPeriod(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_StoryInCollingOffPeriod);
	}

	public bool Equals(CalliopeCustom_DetectCondition_StoryInCollingOffPeriod other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_StoryInCollingOffPeriod other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
