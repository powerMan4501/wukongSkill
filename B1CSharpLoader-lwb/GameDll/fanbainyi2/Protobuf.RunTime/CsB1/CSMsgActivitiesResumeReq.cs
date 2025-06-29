using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActivitiesResumeReq : IMessage<CSMsgActivitiesResumeReq>, IMessage, IEquatable<CSMsgActivitiesResumeReq>, IDeepCloneable<CSMsgActivitiesResumeReq>
{
	private static readonly MessageParser<CSMsgActivitiesResumeReq> _parser = new MessageParser<CSMsgActivitiesResumeReq>(() => new CSMsgActivitiesResumeReq());

	private UnknownFieldSet _unknownFields;

	private int levelId_;

	public static MessageParser<CSMsgActivitiesResumeReq> Parser => _parser;

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public CSMsgActivitiesResumeReq()
	{
	}

	public CSMsgActivitiesResumeReq(CSMsgActivitiesResumeReq other)
		: this()
	{
		levelId_ = other.levelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActivitiesResumeReq Clone()
	{
		return new CSMsgActivitiesResumeReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActivitiesResumeReq);
	}

	public bool Equals(CSMsgActivitiesResumeReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LevelId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LevelId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActivitiesResumeReq other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
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
				LevelId = input.ReadInt32();
			}
		}
	}
}
