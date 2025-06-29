using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel : IMessage<CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel>, IMessage, IEquatable<CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel>, IDeepCloneable<CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel> _parser = new MessageParser<CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel>(() => new CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel> Parser => _parser;

	public CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel()
	{
	}

	public CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel(CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel Clone()
	{
		return new CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel);
	}

	public bool Equals(CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel other)
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

	public void MergeFrom(CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel other)
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
