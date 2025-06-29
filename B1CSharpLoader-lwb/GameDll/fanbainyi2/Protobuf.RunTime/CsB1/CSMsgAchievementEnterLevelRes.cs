using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAchievementEnterLevelRes : IMessage<CSMsgAchievementEnterLevelRes>, IMessage, IEquatable<CSMsgAchievementEnterLevelRes>, IDeepCloneable<CSMsgAchievementEnterLevelRes>
{
	private static readonly MessageParser<CSMsgAchievementEnterLevelRes> _parser = new MessageParser<CSMsgAchievementEnterLevelRes>(() => new CSMsgAchievementEnterLevelRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAchievementEnterLevelRes> Parser => _parser;

	public CSMsgAchievementEnterLevelRes()
	{
	}

	public CSMsgAchievementEnterLevelRes(CSMsgAchievementEnterLevelRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAchievementEnterLevelRes Clone()
	{
		return new CSMsgAchievementEnterLevelRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAchievementEnterLevelRes);
	}

	public bool Equals(CSMsgAchievementEnterLevelRes other)
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

	public void MergeFrom(CSMsgAchievementEnterLevelRes other)
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
