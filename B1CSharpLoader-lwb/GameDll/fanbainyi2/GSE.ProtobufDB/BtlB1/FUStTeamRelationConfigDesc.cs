using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStTeamRelationConfigDesc : IMessage<FUStTeamRelationConfigDesc>, IMessage, IEquatable<FUStTeamRelationConfigDesc>, IDeepCloneable<FUStTeamRelationConfigDesc>
{
	private static readonly MessageParser<FUStTeamRelationConfigDesc> _parser = new MessageParser<FUStTeamRelationConfigDesc>(() => new FUStTeamRelationConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int relationRuleType_;

	private string antiRuleTeamIDs_ = "";

	private string teamDamageReductionConfig_ = "";

	public static MessageParser<FUStTeamRelationConfigDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public int RelationRuleType
	{
		get
		{
			return relationRuleType_;
		}
		set
		{
			relationRuleType_ = value;
		}
	}

	public string AntiRuleTeamIDs
	{
		get
		{
			return antiRuleTeamIDs_;
		}
		set
		{
			antiRuleTeamIDs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string TeamDamageReductionConfig
	{
		get
		{
			return teamDamageReductionConfig_;
		}
		set
		{
			teamDamageReductionConfig_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStTeamRelationConfigDesc()
	{
	}

	public FUStTeamRelationConfigDesc(FUStTeamRelationConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		relationRuleType_ = other.relationRuleType_;
		antiRuleTeamIDs_ = other.antiRuleTeamIDs_;
		teamDamageReductionConfig_ = other.teamDamageReductionConfig_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTeamRelationConfigDesc Clone()
	{
		return new FUStTeamRelationConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTeamRelationConfigDesc);
	}

	public bool Equals(FUStTeamRelationConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (RelationRuleType != other.RelationRuleType)
		{
			return false;
		}
		if (AntiRuleTeamIDs != other.AntiRuleTeamIDs)
		{
			return false;
		}
		if (TeamDamageReductionConfig != other.TeamDamageReductionConfig)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (RelationRuleType != 0)
		{
			num ^= RelationRuleType.GetHashCode();
		}
		if (AntiRuleTeamIDs.Length != 0)
		{
			num ^= AntiRuleTeamIDs.GetHashCode();
		}
		if (TeamDamageReductionConfig.Length != 0)
		{
			num ^= TeamDamageReductionConfig.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (RelationRuleType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RelationRuleType);
		}
		if (AntiRuleTeamIDs.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AntiRuleTeamIDs);
		}
		if (TeamDamageReductionConfig.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(TeamDamageReductionConfig);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (RelationRuleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RelationRuleType);
		}
		if (AntiRuleTeamIDs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AntiRuleTeamIDs);
		}
		if (TeamDamageReductionConfig.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TeamDamageReductionConfig);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStTeamRelationConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.RelationRuleType != 0)
			{
				RelationRuleType = other.RelationRuleType;
			}
			if (other.AntiRuleTeamIDs.Length != 0)
			{
				AntiRuleTeamIDs = other.AntiRuleTeamIDs;
			}
			if (other.TeamDamageReductionConfig.Length != 0)
			{
				TeamDamageReductionConfig = other.TeamDamageReductionConfig;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				RelationRuleType = input.ReadInt32();
				break;
			case 26u:
				AntiRuleTeamIDs = input.ReadString();
				break;
			case 34u:
				TeamDamageReductionConfig = input.ReadString();
				break;
			}
		}
	}
}
