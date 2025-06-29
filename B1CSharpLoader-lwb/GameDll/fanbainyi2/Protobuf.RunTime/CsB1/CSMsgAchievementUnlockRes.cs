using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAchievementUnlockRes : IMessage<CSMsgAchievementUnlockRes>, IMessage, IEquatable<CSMsgAchievementUnlockRes>, IDeepCloneable<CSMsgAchievementUnlockRes>
{
	private static readonly MessageParser<CSMsgAchievementUnlockRes> _parser = new MessageParser<CSMsgAchievementUnlockRes>(() => new CSMsgAchievementUnlockRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAchievementUnlockRes> Parser => _parser;

	public CSMsgAchievementUnlockRes()
	{
	}

	public CSMsgAchievementUnlockRes(CSMsgAchievementUnlockRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAchievementUnlockRes Clone()
	{
		return new CSMsgAchievementUnlockRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAchievementUnlockRes);
	}

	public bool Equals(CSMsgAchievementUnlockRes other)
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

	public void MergeFrom(CSMsgAchievementUnlockRes other)
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
