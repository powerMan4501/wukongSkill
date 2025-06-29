using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAchievementUnlockReq : IMessage<CSMsgAchievementUnlockReq>, IMessage, IEquatable<CSMsgAchievementUnlockReq>, IDeepCloneable<CSMsgAchievementUnlockReq>
{
	private static readonly MessageParser<CSMsgAchievementUnlockReq> _parser = new MessageParser<CSMsgAchievementUnlockReq>(() => new CSMsgAchievementUnlockReq());

	private UnknownFieldSet _unknownFields;

	private int requiredId_;

	public static MessageParser<CSMsgAchievementUnlockReq> Parser => _parser;

	public int RequiredId
	{
		get
		{
			return requiredId_;
		}
		set
		{
			requiredId_ = value;
		}
	}

	public CSMsgAchievementUnlockReq()
	{
	}

	public CSMsgAchievementUnlockReq(CSMsgAchievementUnlockReq other)
		: this()
	{
		requiredId_ = other.requiredId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAchievementUnlockReq Clone()
	{
		return new CSMsgAchievementUnlockReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAchievementUnlockReq);
	}

	public bool Equals(CSMsgAchievementUnlockReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RequiredId != other.RequiredId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RequiredId != 0)
		{
			num ^= RequiredId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RequiredId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(RequiredId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RequiredId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RequiredId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAchievementUnlockReq other)
	{
		if (other != null)
		{
			if (other.RequiredId != 0)
			{
				RequiredId = other.RequiredId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				RequiredId = input.ReadInt32();
			}
		}
	}
}
