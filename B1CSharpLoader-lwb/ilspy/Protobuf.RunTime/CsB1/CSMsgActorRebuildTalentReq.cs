using System;
using BtlB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorRebuildTalentReq : IMessage<CSMsgActorRebuildTalentReq>, IMessage, IEquatable<CSMsgActorRebuildTalentReq>, IDeepCloneable<CSMsgActorRebuildTalentReq>
{
	private static readonly MessageParser<CSMsgActorRebuildTalentReq> _parser = new MessageParser<CSMsgActorRebuildTalentReq>(() => new CSMsgActorRebuildTalentReq());

	private UnknownFieldSet _unknownFields;

	private TalentRebuildType rebuildType_;

	private SpellType talentCollection_;

	private int talentId_;

	public static MessageParser<CSMsgActorRebuildTalentReq> Parser => _parser;

	public TalentRebuildType RebuildType
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

	public SpellType TalentCollection
	{
		get
		{
			return talentCollection_;
		}
		set
		{
			talentCollection_ = value;
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

	public CSMsgActorRebuildTalentReq()
	{
	}

	public CSMsgActorRebuildTalentReq(CSMsgActorRebuildTalentReq other)
		: this()
	{
		rebuildType_ = other.rebuildType_;
		talentCollection_ = other.talentCollection_;
		talentId_ = other.talentId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorRebuildTalentReq Clone()
	{
		return new CSMsgActorRebuildTalentReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorRebuildTalentReq);
	}

	public bool Equals(CSMsgActorRebuildTalentReq other)
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
		if (TalentCollection != other.TalentCollection)
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
		if (RebuildType != TalentRebuildType.All)
		{
			num ^= RebuildType.GetHashCode();
		}
		if (TalentCollection != SpellType.Min)
		{
			num ^= TalentCollection.GetHashCode();
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
		if (RebuildType != TalentRebuildType.All)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)RebuildType);
		}
		if (TalentCollection != SpellType.Min)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)TalentCollection);
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
		if (RebuildType != TalentRebuildType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RebuildType);
		}
		if (TalentCollection != SpellType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TalentCollection);
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

	public void MergeFrom(CSMsgActorRebuildTalentReq other)
	{
		if (other != null)
		{
			if (other.RebuildType != TalentRebuildType.All)
			{
				RebuildType = other.RebuildType;
			}
			if (other.TalentCollection != SpellType.Min)
			{
				TalentCollection = other.TalentCollection;
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
				RebuildType = (TalentRebuildType)input.ReadEnum();
				break;
			case 16u:
				TalentCollection = (SpellType)input.ReadEnum();
				break;
			case 24u:
				TalentId = input.ReadInt32();
				break;
			}
		}
	}
}
