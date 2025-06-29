using System;
using Google.Protobuf;

namespace ResB1;

public sealed class CricketBattleUnitDesc : IMessage<CricketBattleUnitDesc>, IMessage, IEquatable<CricketBattleUnitDesc>, IDeepCloneable<CricketBattleUnitDesc>
{
	private static readonly MessageParser<CricketBattleUnitDesc> _parser = new MessageParser<CricketBattleUnitDesc>(() => new CricketBattleUnitDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int extentBattleId_;

	private string tamerPath_ = "";

	private int nameId_;

	private string showAMPath_ = "";

	private int winnerSeqId_;

	private int spawnPosPixF_;

	private int spawnPosPixR_;

	public static MessageParser<CricketBattleUnitDesc> Parser => _parser;

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

	public int ExtentBattleId
	{
		get
		{
			return extentBattleId_;
		}
		set
		{
			extentBattleId_ = value;
		}
	}

	public string TamerPath
	{
		get
		{
			return tamerPath_;
		}
		set
		{
			tamerPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int NameId
	{
		get
		{
			return nameId_;
		}
		set
		{
			nameId_ = value;
		}
	}

	public string ShowAMPath
	{
		get
		{
			return showAMPath_;
		}
		set
		{
			showAMPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int WinnerSeqId
	{
		get
		{
			return winnerSeqId_;
		}
		set
		{
			winnerSeqId_ = value;
		}
	}

	public int SpawnPosPixF
	{
		get
		{
			return spawnPosPixF_;
		}
		set
		{
			spawnPosPixF_ = value;
		}
	}

	public int SpawnPosPixR
	{
		get
		{
			return spawnPosPixR_;
		}
		set
		{
			spawnPosPixR_ = value;
		}
	}

	public CricketBattleUnitDesc()
	{
	}

	public CricketBattleUnitDesc(CricketBattleUnitDesc other)
		: this()
	{
		id_ = other.id_;
		extentBattleId_ = other.extentBattleId_;
		tamerPath_ = other.tamerPath_;
		nameId_ = other.nameId_;
		showAMPath_ = other.showAMPath_;
		winnerSeqId_ = other.winnerSeqId_;
		spawnPosPixF_ = other.spawnPosPixF_;
		spawnPosPixR_ = other.spawnPosPixR_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CricketBattleUnitDesc Clone()
	{
		return new CricketBattleUnitDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CricketBattleUnitDesc);
	}

	public bool Equals(CricketBattleUnitDesc other)
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
		if (ExtentBattleId != other.ExtentBattleId)
		{
			return false;
		}
		if (TamerPath != other.TamerPath)
		{
			return false;
		}
		if (NameId != other.NameId)
		{
			return false;
		}
		if (ShowAMPath != other.ShowAMPath)
		{
			return false;
		}
		if (WinnerSeqId != other.WinnerSeqId)
		{
			return false;
		}
		if (SpawnPosPixF != other.SpawnPosPixF)
		{
			return false;
		}
		if (SpawnPosPixR != other.SpawnPosPixR)
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
		if (ExtentBattleId != 0)
		{
			num ^= ExtentBattleId.GetHashCode();
		}
		if (TamerPath.Length != 0)
		{
			num ^= TamerPath.GetHashCode();
		}
		if (NameId != 0)
		{
			num ^= NameId.GetHashCode();
		}
		if (ShowAMPath.Length != 0)
		{
			num ^= ShowAMPath.GetHashCode();
		}
		if (WinnerSeqId != 0)
		{
			num ^= WinnerSeqId.GetHashCode();
		}
		if (SpawnPosPixF != 0)
		{
			num ^= SpawnPosPixF.GetHashCode();
		}
		if (SpawnPosPixR != 0)
		{
			num ^= SpawnPosPixR.GetHashCode();
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
		if (ExtentBattleId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ExtentBattleId);
		}
		if (TamerPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TamerPath);
		}
		if (NameId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(NameId);
		}
		if (ShowAMPath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ShowAMPath);
		}
		if (WinnerSeqId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(WinnerSeqId);
		}
		if (SpawnPosPixF != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SpawnPosPixF);
		}
		if (SpawnPosPixR != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SpawnPosPixR);
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
		if (ExtentBattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtentBattleId);
		}
		if (TamerPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TamerPath);
		}
		if (NameId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NameId);
		}
		if (ShowAMPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ShowAMPath);
		}
		if (WinnerSeqId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WinnerSeqId);
		}
		if (SpawnPosPixF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpawnPosPixF);
		}
		if (SpawnPosPixR != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpawnPosPixR);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CricketBattleUnitDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ExtentBattleId != 0)
			{
				ExtentBattleId = other.ExtentBattleId;
			}
			if (other.TamerPath.Length != 0)
			{
				TamerPath = other.TamerPath;
			}
			if (other.NameId != 0)
			{
				NameId = other.NameId;
			}
			if (other.ShowAMPath.Length != 0)
			{
				ShowAMPath = other.ShowAMPath;
			}
			if (other.WinnerSeqId != 0)
			{
				WinnerSeqId = other.WinnerSeqId;
			}
			if (other.SpawnPosPixF != 0)
			{
				SpawnPosPixF = other.SpawnPosPixF;
			}
			if (other.SpawnPosPixR != 0)
			{
				SpawnPosPixR = other.SpawnPosPixR;
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
			case 16u:
				ExtentBattleId = input.ReadInt32();
				break;
			case 26u:
				TamerPath = input.ReadString();
				break;
			case 32u:
				NameId = input.ReadInt32();
				break;
			case 42u:
				ShowAMPath = input.ReadString();
				break;
			case 48u:
				WinnerSeqId = input.ReadInt32();
				break;
			case 56u:
				SpawnPosPixF = input.ReadInt32();
				break;
			case 64u:
				SpawnPosPixR = input.ReadInt32();
				break;
			}
		}
	}
}
