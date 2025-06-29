using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStSoulSkillMimicryDesc : IMessage<FUStSoulSkillMimicryDesc>, IMessage, IEquatable<FUStSoulSkillMimicryDesc>, IDeepCloneable<FUStSoulSkillMimicryDesc>
{
	private static readonly MessageParser<FUStSoulSkillMimicryDesc> _parser = new MessageParser<FUStSoulSkillMimicryDesc>(() => new FUStSoulSkillMimicryDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int soulSkillID_;

	private int levelID_;

	private string dAPath_ = "";

	private int buff_;

	private int overrideAbnormalDispIDAttacker_;

	private int overrideAbnormalDispIDVictim_;

	public static MessageParser<FUStSoulSkillMimicryDesc> Parser => _parser;

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

	public int SoulSkillID
	{
		get
		{
			return soulSkillID_;
		}
		set
		{
			soulSkillID_ = value;
		}
	}

	public int LevelID
	{
		get
		{
			return levelID_;
		}
		set
		{
			levelID_ = value;
		}
	}

	public string DAPath
	{
		get
		{
			return dAPath_;
		}
		set
		{
			dAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Buff
	{
		get
		{
			return buff_;
		}
		set
		{
			buff_ = value;
		}
	}

	public int OverrideAbnormalDispIDAttacker
	{
		get
		{
			return overrideAbnormalDispIDAttacker_;
		}
		set
		{
			overrideAbnormalDispIDAttacker_ = value;
		}
	}

	public int OverrideAbnormalDispIDVictim
	{
		get
		{
			return overrideAbnormalDispIDVictim_;
		}
		set
		{
			overrideAbnormalDispIDVictim_ = value;
		}
	}

	public FUStSoulSkillMimicryDesc()
	{
	}

	public FUStSoulSkillMimicryDesc(FUStSoulSkillMimicryDesc other)
		: this()
	{
		iD_ = other.iD_;
		soulSkillID_ = other.soulSkillID_;
		levelID_ = other.levelID_;
		dAPath_ = other.dAPath_;
		buff_ = other.buff_;
		overrideAbnormalDispIDAttacker_ = other.overrideAbnormalDispIDAttacker_;
		overrideAbnormalDispIDVictim_ = other.overrideAbnormalDispIDVictim_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSoulSkillMimicryDesc Clone()
	{
		return new FUStSoulSkillMimicryDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSoulSkillMimicryDesc);
	}

	public bool Equals(FUStSoulSkillMimicryDesc other)
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
		if (SoulSkillID != other.SoulSkillID)
		{
			return false;
		}
		if (LevelID != other.LevelID)
		{
			return false;
		}
		if (DAPath != other.DAPath)
		{
			return false;
		}
		if (Buff != other.Buff)
		{
			return false;
		}
		if (OverrideAbnormalDispIDAttacker != other.OverrideAbnormalDispIDAttacker)
		{
			return false;
		}
		if (OverrideAbnormalDispIDVictim != other.OverrideAbnormalDispIDVictim)
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
		if (SoulSkillID != 0)
		{
			num ^= SoulSkillID.GetHashCode();
		}
		if (LevelID != 0)
		{
			num ^= LevelID.GetHashCode();
		}
		if (DAPath.Length != 0)
		{
			num ^= DAPath.GetHashCode();
		}
		if (Buff != 0)
		{
			num ^= Buff.GetHashCode();
		}
		if (OverrideAbnormalDispIDAttacker != 0)
		{
			num ^= OverrideAbnormalDispIDAttacker.GetHashCode();
		}
		if (OverrideAbnormalDispIDVictim != 0)
		{
			num ^= OverrideAbnormalDispIDVictim.GetHashCode();
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
		if (SoulSkillID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SoulSkillID);
		}
		if (LevelID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LevelID);
		}
		if (DAPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DAPath);
		}
		if (Buff != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Buff);
		}
		if (OverrideAbnormalDispIDAttacker != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(OverrideAbnormalDispIDAttacker);
		}
		if (OverrideAbnormalDispIDVictim != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(OverrideAbnormalDispIDVictim);
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
		if (SoulSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoulSkillID);
		}
		if (LevelID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelID);
		}
		if (DAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DAPath);
		}
		if (Buff != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Buff);
		}
		if (OverrideAbnormalDispIDAttacker != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OverrideAbnormalDispIDAttacker);
		}
		if (OverrideAbnormalDispIDVictim != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OverrideAbnormalDispIDVictim);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSoulSkillMimicryDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SoulSkillID != 0)
			{
				SoulSkillID = other.SoulSkillID;
			}
			if (other.LevelID != 0)
			{
				LevelID = other.LevelID;
			}
			if (other.DAPath.Length != 0)
			{
				DAPath = other.DAPath;
			}
			if (other.Buff != 0)
			{
				Buff = other.Buff;
			}
			if (other.OverrideAbnormalDispIDAttacker != 0)
			{
				OverrideAbnormalDispIDAttacker = other.OverrideAbnormalDispIDAttacker;
			}
			if (other.OverrideAbnormalDispIDVictim != 0)
			{
				OverrideAbnormalDispIDVictim = other.OverrideAbnormalDispIDVictim;
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
				SoulSkillID = input.ReadInt32();
				break;
			case 24u:
				LevelID = input.ReadInt32();
				break;
			case 34u:
				DAPath = input.ReadString();
				break;
			case 40u:
				Buff = input.ReadInt32();
				break;
			case 48u:
				OverrideAbnormalDispIDAttacker = input.ReadInt32();
				break;
			case 56u:
				OverrideAbnormalDispIDVictim = input.ReadInt32();
				break;
			}
		}
	}
}
