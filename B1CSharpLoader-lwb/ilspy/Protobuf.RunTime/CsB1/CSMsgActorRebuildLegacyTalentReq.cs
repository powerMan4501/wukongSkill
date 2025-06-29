using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorRebuildLegacyTalentReq : IMessage<CSMsgActorRebuildLegacyTalentReq>, IMessage, IEquatable<CSMsgActorRebuildLegacyTalentReq>, IDeepCloneable<CSMsgActorRebuildLegacyTalentReq>
{
	private static readonly MessageParser<CSMsgActorRebuildLegacyTalentReq> _parser = new MessageParser<CSMsgActorRebuildLegacyTalentReq>(() => new CSMsgActorRebuildLegacyTalentReq());

	private UnknownFieldSet _unknownFields;

	private LegacyRebuildType rebuildType_;

	private int legacyId_;

	private int talentId_;

	public static MessageParser<CSMsgActorRebuildLegacyTalentReq> Parser => _parser;

	public LegacyRebuildType RebuildType
	{
		get
		{
			return rebuildType_;
		}
		set
		{
			rebuildType_ = value;
		}
	}

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

	public CSMsgActorRebuildLegacyTalentReq()
	{
	}

	public CSMsgActorRebuildLegacyTalentReq(CSMsgActorRebuildLegacyTalentReq other)
		: this()
	{
		rebuildType_ = other.rebuildType_;
		legacyId_ = other.legacyId_;
		talentId_ = other.talentId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorRebuildLegacyTalentReq Clone()
	{
		return new CSMsgActorRebuildLegacyTalentReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorRebuildLegacyTalentReq);
	}

	public bool Equals(CSMsgActorRebuildLegacyTalentReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RebuildType != other.RebuildType)
		{
			return false;
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
		if (RebuildType != LegacyRebuildType.TalentId)
		{
			num ^= RebuildType.GetHashCode();
		}
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
		if (RebuildType != LegacyRebuildType.TalentId)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)RebuildType);
		}
		if (LegacyId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LegacyId);
		}
		if (TalentId != 0)
		{
			output.WriteRawTag(24);
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
		if (RebuildType != LegacyRebuildType.TalentId)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RebuildType);
		}
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

	public void MergeFrom(CSMsgActorRebuildLegacyTalentReq other)
	{
		if (other != null)
		{
			if (other.RebuildType != LegacyRebuildType.TalentId)
			{
				RebuildType = other.RebuildType;
			}
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
				RebuildType = (LegacyRebuildType)input.ReadEnum();
				break;
			case 16u:
				LegacyId = input.ReadInt32();
				break;
			case 24u:
				TalentId = input.ReadInt32();
				break;
			}
		}
	}
}
