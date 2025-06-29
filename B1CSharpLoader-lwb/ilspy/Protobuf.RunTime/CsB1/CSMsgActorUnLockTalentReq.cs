using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnLockTalentReq : IMessage<CSMsgActorUnLockTalentReq>, IMessage, IEquatable<CSMsgActorUnLockTalentReq>, IDeepCloneable<CSMsgActorUnLockTalentReq>
{
	private static readonly MessageParser<CSMsgActorUnLockTalentReq> _parser = new MessageParser<CSMsgActorUnLockTalentReq>(() => new CSMsgActorUnLockTalentReq());

	private UnknownFieldSet _unknownFields;

	private int talentId_;

	public static MessageParser<CSMsgActorUnLockTalentReq> Parser => _parser;

	public int TalentId
	{
		get
		{
			return talentId_;
		}
		set
		{
			talentId_ = value;
		}
	}

	public CSMsgActorUnLockTalentReq()
	{
	}

	public CSMsgActorUnLockTalentReq(CSMsgActorUnLockTalentReq other)
		: this()
	{
		talentId_ = other.talentId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnLockTalentReq Clone()
	{
		return new CSMsgActorUnLockTalentReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnLockTalentReq);
	}

	public bool Equals(CSMsgActorUnLockTalentReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TalentId != other.TalentId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TalentId != 0)
		{
			num ^= TalentId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TalentId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TalentId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TalentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorUnLockTalentReq other)
	{
		if (other != null)
		{
			if (other.TalentId != 0)
			{
				TalentId = other.TalentId;
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
				TalentId = input.ReadInt32();
			}
		}
	}
}
