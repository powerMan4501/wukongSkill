using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActivitiesResumeRes : IMessage<CSMsgActivitiesResumeRes>, IMessage, IEquatable<CSMsgActivitiesResumeRes>, IDeepCloneable<CSMsgActivitiesResumeRes>
{
	private static readonly MessageParser<CSMsgActivitiesResumeRes> _parser = new MessageParser<CSMsgActivitiesResumeRes>(() => new CSMsgActivitiesResumeRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActivitiesResumeRes> Parser => _parser;

	public CSMsgActivitiesResumeRes()
	{
	}

	public CSMsgActivitiesResumeRes(CSMsgActivitiesResumeRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActivitiesResumeRes Clone()
	{
		return new CSMsgActivitiesResumeRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActivitiesResumeRes);
	}

	public bool Equals(CSMsgActivitiesResumeRes other)
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

	public void MergeFrom(CSMsgActivitiesResumeRes other)
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
