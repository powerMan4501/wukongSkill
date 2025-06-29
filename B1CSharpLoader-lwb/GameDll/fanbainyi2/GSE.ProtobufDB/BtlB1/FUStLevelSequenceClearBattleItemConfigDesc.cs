using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStLevelSequenceClearBattleItemConfigDesc : IMessage<FUStLevelSequenceClearBattleItemConfigDesc>, IMessage, IEquatable<FUStLevelSequenceClearBattleItemConfigDesc>, IDeepCloneable<FUStLevelSequenceClearBattleItemConfigDesc>
{
	private static readonly MessageParser<FUStLevelSequenceClearBattleItemConfigDesc> _parser = new MessageParser<FUStLevelSequenceClearBattleItemConfigDesc>(() => new FUStLevelSequenceClearBattleItemConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int projectileID_;

	private int summonID_;

	public static MessageParser<FUStLevelSequenceClearBattleItemConfigDesc> Parser => _parser;

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

	public int ProjectileID
	{
		get
		{
			return projectileID_;
		}
		set
		{
			projectileID_ = value;
		}
	}

	public int SummonID
	{
		get
		{
			return summonID_;
		}
		set
		{
			summonID_ = value;
		}
	}

	public FUStLevelSequenceClearBattleItemConfigDesc()
	{
	}

	public FUStLevelSequenceClearBattleItemConfigDesc(FUStLevelSequenceClearBattleItemConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		projectileID_ = other.projectileID_;
		summonID_ = other.summonID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStLevelSequenceClearBattleItemConfigDesc Clone()
	{
		return new FUStLevelSequenceClearBattleItemConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStLevelSequenceClearBattleItemConfigDesc);
	}

	public bool Equals(FUStLevelSequenceClearBattleItemConfigDesc other)
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
		if (ProjectileID != other.ProjectileID)
		{
			return false;
		}
		if (SummonID != other.SummonID)
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
		if (ProjectileID != 0)
		{
			num ^= ProjectileID.GetHashCode();
		}
		if (SummonID != 0)
		{
			num ^= SummonID.GetHashCode();
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
		if (ProjectileID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ProjectileID);
		}
		if (SummonID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SummonID);
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
		if (ProjectileID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ProjectileID);
		}
		if (SummonID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SummonID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStLevelSequenceClearBattleItemConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ProjectileID != 0)
			{
				ProjectileID = other.ProjectileID;
			}
			if (other.SummonID != 0)
			{
				SummonID = other.SummonID;
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
				ProjectileID = input.ReadInt32();
				break;
			case 24u:
				SummonID = input.ReadInt32();
				break;
			}
		}
	}
}
