using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorActivateLegacyTalentReq : IMessage<CSMsgActorActivateLegacyTalentReq>, IMessage, IEquatable<CSMsgActorActivateLegacyTalentReq>, IDeepCloneable<CSMsgActorActivateLegacyTalentReq>
{
	private static readonly MessageParser<CSMsgActorActivateLegacyTalentReq> _parser = new MessageParser<CSMsgActorActivateLegacyTalentReq>(() => new CSMsgActorActivateLegacyTalentReq());

	private UnknownFieldSet _unknownFields;

	private int legacyId_;

	private int talentId_;

	public static MessageParser<CSMsgActorActivateLegacyTalentReq> Parser => _parser;

	public int LegacyId
	{
		get
		{
			return legacyId_;
		}
		set
		{
			legacyId_ = value;
		}
	}

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

	public CSMsgActorActivateLegacyTalentReq()
	{
	}

	public CSMsgActorActivateLegacyTalentReq(CSMsgActorActivateLegacyTalentReq other)
		: this()
	{
		legacyId_ = other.legacyId_;
		talentId_ = other.talentId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorActivateLegacyTalentReq Clone()
	{
		return new CSMsgActorActivateLegacyTalentReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorActivateLegacyTalentReq);
	}

	public bool Equals(CSMsgActorActivateLegacyTalentReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LegacyId != other.LegacyId)
		{
			return false;
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
		if (LegacyId != 0)
		{
			num ^= LegacyId.GetHashCode();
		}
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
		if (LegacyId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LegacyId);
		}
		if (TalentId != 0)
		{
			output.WriteRawTag(16);
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
		if (LegacyId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LegacyId);
		}
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

	public void MergeFrom(CSMsgActorActivateLegacyTalentReq other)
	{
		if (other != null)
		{
			if (other.LegacyId != 0)
			{
				LegacyId = other.LegacyId;
			}
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				LegacyId = input.ReadInt32();
				break;
			case 16u:
				TalentId = input.ReadInt32();
				break;
			}
		}
	}
}
