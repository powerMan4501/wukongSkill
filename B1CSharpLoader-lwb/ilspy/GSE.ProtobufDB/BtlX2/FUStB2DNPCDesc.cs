using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class FUStB2DNPCDesc : IMessage<FUStB2DNPCDesc>, IMessage, IEquatable<FUStB2DNPCDesc>, IDeepCloneable<FUStB2DNPCDesc>
{
	private static readonly MessageParser<FUStB2DNPCDesc> _parser = new MessageParser<FUStB2DNPCDesc>(() => new FUStB2DNPCDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string npcName_ = "";

	private string btName_ = "";

	private int teamId_;

	private int archiveId_;

	private int resId_;

	public static MessageParser<FUStB2DNPCDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string NpcName
	{
		get
		{
			return npcName_;
		}
		set
		{
			npcName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BtName
	{
		get
		{
			return btName_;
		}
		set
		{
			btName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TeamId
	{
		get
		{
			return teamId_;
		}
		set
		{
			teamId_ = value;
		}
	}

	public int ArchiveId
	{
		get
		{
			return archiveId_;
		}
		set
		{
			archiveId_ = value;
		}
	}

	public int ResId
	{
		get
		{
			return resId_;
		}
		set
		{
			resId_ = value;
		}
	}

	public FUStB2DNPCDesc()
	{
	}

	public FUStB2DNPCDesc(FUStB2DNPCDesc other)
		: this()
	{
		id_ = other.id_;
		npcName_ = other.npcName_;
		btName_ = other.btName_;
		teamId_ = other.teamId_;
		archiveId_ = other.archiveId_;
		resId_ = other.resId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DNPCDesc Clone()
	{
		return new FUStB2DNPCDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DNPCDesc);
	}

	public bool Equals(FUStB2DNPCDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (NpcName != other.NpcName)
		{
			return false;
		}
		if (BtName != other.BtName)
		{
			return false;
		}
		if (TeamId != other.TeamId)
		{
			return false;
		}
		if (ArchiveId != other.ArchiveId)
		{
			return false;
		}
		if (ResId != other.ResId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NpcName.Length != 0)
		{
			num ^= NpcName.GetHashCode();
		}
		if (BtName.Length != 0)
		{
			num ^= BtName.GetHashCode();
		}
		if (TeamId != 0)
		{
			num ^= TeamId.GetHashCode();
		}
		if (ArchiveId != 0)
		{
			num ^= ArchiveId.GetHashCode();
		}
		if (ResId != 0)
		{
			num ^= ResId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (NpcName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(NpcName);
		}
		if (BtName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BtName);
		}
		if (TeamId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TeamId);
		}
		if (ArchiveId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ArchiveId);
		}
		if (ResId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ResId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NpcName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NpcName);
		}
		if (BtName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BtName);
		}
		if (TeamId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TeamId);
		}
		if (ArchiveId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ArchiveId);
		}
		if (ResId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DNPCDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NpcName.Length != 0)
			{
				NpcName = other.NpcName;
			}
			if (other.BtName.Length != 0)
			{
				BtName = other.BtName;
			}
			if (other.TeamId != 0)
			{
				TeamId = other.TeamId;
			}
			if (other.ArchiveId != 0)
			{
				ArchiveId = other.ArchiveId;
			}
			if (other.ResId != 0)
			{
				ResId = other.ResId;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				NpcName = input.ReadString();
				break;
			case 26u:
				BtName = input.ReadString();
				break;
			case 32u:
				TeamId = input.ReadInt32();
				break;
			case 40u:
				ArchiveId = input.ReadInt32();
				break;
			case 48u:
				ResId = input.ReadInt32();
				break;
			}
		}
	}
}
