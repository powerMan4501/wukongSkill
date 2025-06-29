using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportRoleBase : IMessage<ReportRoleBase>, IMessage, IEquatable<ReportRoleBase>, IDeepCloneable<ReportRoleBase>
{
	private static readonly MessageParser<ReportRoleBase> _parser = new MessageParser<ReportRoleBase>(() => new ReportRoleBase());

	private UnknownFieldSet _unknownFields;

	private int roleLv_;

	private string blevel_ = "";

	private int slevel_;

	private int lvProg_;

	private string revPoint_ = "";

	private int locX_;

	private int locY_;

	private int locZ_;

	private int playTime_;

	private int hardLv_;

	private PlayType playType_;

	private string name_ = "";

	private int curChapter_;

	private static readonly FieldCodec<ChapterPlayTime> _repeated_chapterPlayTime_codec = FieldCodec.ForMessage(114u, OssB1.ChapterPlayTime.Parser);

	private readonly RepeatedField<ChapterPlayTime> chapterPlayTime_ = new RepeatedField<ChapterPlayTime>();

	private static readonly FieldCodec<LevelPlayTime> _repeated_consoleLevelPlayTime_codec = FieldCodec.ForMessage(122u, LevelPlayTime.Parser);

	private readonly RepeatedField<LevelPlayTime> consoleLevelPlayTime_ = new RepeatedField<LevelPlayTime>();

	private int isGameComplete_;

	private string archiveUid_ = "";

	private string originSharedArchiveUid_ = "";

	private string originSdkUid_ = "";

	private int chapterLevel_;

	private int dieTimes_;

	public static MessageParser<ReportRoleBase> Parser => _parser;

	public int RoleLv
	{
		get
		{
			return roleLv_;
		}
		set
		{
			roleLv_ = value;
		}
	}

	public string Blevel
	{
		get
		{
			return blevel_;
		}
		set
		{
			blevel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Slevel
	{
		get
		{
			return slevel_;
		}
		set
		{
			slevel_ = value;
		}
	}

	public int LvProg
	{
		get
		{
			return lvProg_;
		}
		set
		{
			lvProg_ = value;
		}
	}

	public string RevPoint
	{
		get
		{
			return revPoint_;
		}
		set
		{
			revPoint_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LocX
	{
		get
		{
			return locX_;
		}
		set
		{
			locX_ = value;
		}
	}

	public int LocY
	{
		get
		{
			return locY_;
		}
		set
		{
			locY_ = value;
		}
	}

	public int LocZ
	{
		get
		{
			return locZ_;
		}
		set
		{
			locZ_ = value;
		}
	}

	public int PlayTime
	{
		get
		{
			return playTime_;
		}
		set
		{
			playTime_ = value;
		}
	}

	public int HardLv
	{
		get
		{
			return hardLv_;
		}
		set
		{
			hardLv_ = value;
		}
	}

	public PlayType PlayType
	{
		get
		{
			return playType_;
		}
		set
		{
			playType_ = value;
		}
	}

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int CurChapter
	{
		get
		{
			return curChapter_;
		}
		set
		{
			curChapter_ = value;
		}
	}

	public RepeatedField<ChapterPlayTime> ChapterPlayTime => chapterPlayTime_;

	public RepeatedField<LevelPlayTime> ConsoleLevelPlayTime => consoleLevelPlayTime_;

	public int IsGameComplete
	{
		get
		{
			return isGameComplete_;
		}
		set
		{
			isGameComplete_ = value;
		}
	}

	public string ArchiveUid
	{
		get
		{
			return archiveUid_;
		}
		set
		{
			archiveUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string OriginSharedArchiveUid
	{
		get
		{
			return originSharedArchiveUid_;
		}
		set
		{
			originSharedArchiveUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string OriginSdkUid
	{
		get
		{
			return originSdkUid_;
		}
		set
		{
			originSdkUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ChapterLevel
	{
		get
		{
			return chapterLevel_;
		}
		set
		{
			chapterLevel_ = value;
		}
	}

	public int DieTimes
	{
		get
		{
			return dieTimes_;
		}
		set
		{
			dieTimes_ = value;
		}
	}

	public ReportRoleBase()
	{
	}

	public ReportRoleBase(ReportRoleBase other)
		: this()
	{
		roleLv_ = other.roleLv_;
		blevel_ = other.blevel_;
		slevel_ = other.slevel_;
		lvProg_ = other.lvProg_;
		revPoint_ = other.revPoint_;
		locX_ = other.locX_;
		locY_ = other.locY_;
		locZ_ = other.locZ_;
		playTime_ = other.playTime_;
		hardLv_ = other.hardLv_;
		playType_ = other.playType_;
		name_ = other.name_;
		curChapter_ = other.curChapter_;
		chapterPlayTime_ = other.chapterPlayTime_.Clone();
		consoleLevelPlayTime_ = other.consoleLevelPlayTime_.Clone();
		isGameComplete_ = other.isGameComplete_;
		archiveUid_ = other.archiveUid_;
		originSharedArchiveUid_ = other.originSharedArchiveUid_;
		originSdkUid_ = other.originSdkUid_;
		chapterLevel_ = other.chapterLevel_;
		dieTimes_ = other.dieTimes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportRoleBase Clone()
	{
		return new ReportRoleBase(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportRoleBase);
	}

	public bool Equals(ReportRoleBase other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleLv != other.RoleLv)
		{
			return false;
		}
		if (Blevel != other.Blevel)
		{
			return false;
		}
		if (Slevel != other.Slevel)
		{
			return false;
		}
		if (LvProg != other.LvProg)
		{
			return false;
		}
		if (RevPoint != other.RevPoint)
		{
			return false;
		}
		if (LocX != other.LocX)
		{
			return false;
		}
		if (LocY != other.LocY)
		{
			return false;
		}
		if (LocZ != other.LocZ)
		{
			return false;
		}
		if (PlayTime != other.PlayTime)
		{
			return false;
		}
		if (HardLv != other.HardLv)
		{
			return false;
		}
		if (PlayType != other.PlayType)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (CurChapter != other.CurChapter)
		{
			return false;
		}
		if (!chapterPlayTime_.Equals(other.chapterPlayTime_))
		{
			return false;
		}
		if (!consoleLevelPlayTime_.Equals(other.consoleLevelPlayTime_))
		{
			return false;
		}
		if (IsGameComplete != other.IsGameComplete)
		{
			return false;
		}
		if (ArchiveUid != other.ArchiveUid)
		{
			return false;
		}
		if (OriginSharedArchiveUid != other.OriginSharedArchiveUid)
		{
			return false;
		}
		if (OriginSdkUid != other.OriginSdkUid)
		{
			return false;
		}
		if (ChapterLevel != other.ChapterLevel)
		{
			return false;
		}
		if (DieTimes != other.DieTimes)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleLv != 0)
		{
			num ^= RoleLv.GetHashCode();
		}
		if (Blevel.Length != 0)
		{
			num ^= Blevel.GetHashCode();
		}
		if (Slevel != 0)
		{
			num ^= Slevel.GetHashCode();
		}
		if (LvProg != 0)
		{
			num ^= LvProg.GetHashCode();
		}
		if (RevPoint.Length != 0)
		{
			num ^= RevPoint.GetHashCode();
		}
		if (LocX != 0)
		{
			num ^= LocX.GetHashCode();
		}
		if (LocY != 0)
		{
			num ^= LocY.GetHashCode();
		}
		if (LocZ != 0)
		{
			num ^= LocZ.GetHashCode();
		}
		if (PlayTime != 0)
		{
			num ^= PlayTime.GetHashCode();
		}
		if (HardLv != 0)
		{
			num ^= HardLv.GetHashCode();
		}
		if (PlayType != PlayType.Single)
		{
			num ^= PlayType.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (CurChapter != 0)
		{
			num ^= CurChapter.GetHashCode();
		}
		num ^= chapterPlayTime_.GetHashCode();
		num ^= consoleLevelPlayTime_.GetHashCode();
		if (IsGameComplete != 0)
		{
			num ^= IsGameComplete.GetHashCode();
		}
		if (ArchiveUid.Length != 0)
		{
			num ^= ArchiveUid.GetHashCode();
		}
		if (OriginSharedArchiveUid.Length != 0)
		{
			num ^= OriginSharedArchiveUid.GetHashCode();
		}
		if (OriginSdkUid.Length != 0)
		{
			num ^= OriginSdkUid.GetHashCode();
		}
		if (ChapterLevel != 0)
		{
			num ^= ChapterLevel.GetHashCode();
		}
		if (DieTimes != 0)
		{
			num ^= DieTimes.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleLv != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(RoleLv);
		}
		if (Blevel.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Blevel);
		}
		if (Slevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Slevel);
		}
		if (LvProg != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LvProg);
		}
		if (RevPoint.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(RevPoint);
		}
		if (LocX != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LocX);
		}
		if (LocY != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(LocY);
		}
		if (LocZ != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LocZ);
		}
		if (PlayTime != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PlayTime);
		}
		if (HardLv != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(HardLv);
		}
		if (PlayType != PlayType.Single)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)PlayType);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(Name);
		}
		if (CurChapter != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(CurChapter);
		}
		chapterPlayTime_.WriteTo(output, _repeated_chapterPlayTime_codec);
		consoleLevelPlayTime_.WriteTo(output, _repeated_consoleLevelPlayTime_codec);
		if (IsGameComplete != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(IsGameComplete);
		}
		if (ArchiveUid.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(ArchiveUid);
		}
		if (OriginSharedArchiveUid.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(OriginSharedArchiveUid);
		}
		if (OriginSdkUid.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(OriginSdkUid);
		}
		if (ChapterLevel != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(ChapterLevel);
		}
		if (DieTimes != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(DieTimes);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleLv != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RoleLv);
		}
		if (Blevel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Blevel);
		}
		if (Slevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Slevel);
		}
		if (LvProg != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LvProg);
		}
		if (RevPoint.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RevPoint);
		}
		if (LocX != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocX);
		}
		if (LocY != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocY);
		}
		if (LocZ != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocZ);
		}
		if (PlayTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayTime);
		}
		if (HardLv != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HardLv);
		}
		if (PlayType != PlayType.Single)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PlayType);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (CurChapter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurChapter);
		}
		num += chapterPlayTime_.CalculateSize(_repeated_chapterPlayTime_codec);
		num += consoleLevelPlayTime_.CalculateSize(_repeated_consoleLevelPlayTime_codec);
		if (IsGameComplete != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IsGameComplete);
		}
		if (ArchiveUid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ArchiveUid);
		}
		if (OriginSharedArchiveUid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(OriginSharedArchiveUid);
		}
		if (OriginSdkUid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(OriginSdkUid);
		}
		if (ChapterLevel != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ChapterLevel);
		}
		if (DieTimes != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DieTimes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportRoleBase other)
	{
		if (other != null)
		{
			if (other.RoleLv != 0)
			{
				RoleLv = other.RoleLv;
			}
			if (other.Blevel.Length != 0)
			{
				Blevel = other.Blevel;
			}
			if (other.Slevel != 0)
			{
				Slevel = other.Slevel;
			}
			if (other.LvProg != 0)
			{
				LvProg = other.LvProg;
			}
			if (other.RevPoint.Length != 0)
			{
				RevPoint = other.RevPoint;
			}
			if (other.LocX != 0)
			{
				LocX = other.LocX;
			}
			if (other.LocY != 0)
			{
				LocY = other.LocY;
			}
			if (other.LocZ != 0)
			{
				LocZ = other.LocZ;
			}
			if (other.PlayTime != 0)
			{
				PlayTime = other.PlayTime;
			}
			if (other.HardLv != 0)
			{
				HardLv = other.HardLv;
			}
			if (other.PlayType != PlayType.Single)
			{
				PlayType = other.PlayType;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.CurChapter != 0)
			{
				CurChapter = other.CurChapter;
			}
			chapterPlayTime_.Add(other.chapterPlayTime_);
			consoleLevelPlayTime_.Add(other.consoleLevelPlayTime_);
			if (other.IsGameComplete != 0)
			{
				IsGameComplete = other.IsGameComplete;
			}
			if (other.ArchiveUid.Length != 0)
			{
				ArchiveUid = other.ArchiveUid;
			}
			if (other.OriginSharedArchiveUid.Length != 0)
			{
				OriginSharedArchiveUid = other.OriginSharedArchiveUid;
			}
			if (other.OriginSdkUid.Length != 0)
			{
				OriginSdkUid = other.OriginSdkUid;
			}
			if (other.ChapterLevel != 0)
			{
				ChapterLevel = other.ChapterLevel;
			}
			if (other.DieTimes != 0)
			{
				DieTimes = other.DieTimes;
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
				RoleLv = input.ReadInt32();
				break;
			case 18u:
				Blevel = input.ReadString();
				break;
			case 24u:
				Slevel = input.ReadInt32();
				break;
			case 32u:
				LvProg = input.ReadInt32();
				break;
			case 42u:
				RevPoint = input.ReadString();
				break;
			case 48u:
				LocX = input.ReadInt32();
				break;
			case 56u:
				LocY = input.ReadInt32();
				break;
			case 64u:
				LocZ = input.ReadInt32();
				break;
			case 72u:
				PlayTime = input.ReadInt32();
				break;
			case 80u:
				HardLv = input.ReadInt32();
				break;
			case 88u:
				PlayType = (PlayType)input.ReadEnum();
				break;
			case 98u:
				Name = input.ReadString();
				break;
			case 104u:
				CurChapter = input.ReadInt32();
				break;
			case 114u:
				chapterPlayTime_.AddEntriesFrom(input, _repeated_chapterPlayTime_codec);
				break;
			case 122u:
				consoleLevelPlayTime_.AddEntriesFrom(input, _repeated_consoleLevelPlayTime_codec);
				break;
			case 128u:
				IsGameComplete = input.ReadInt32();
				break;
			case 138u:
				ArchiveUid = input.ReadString();
				break;
			case 146u:
				OriginSharedArchiveUid = input.ReadString();
				break;
			case 154u:
				OriginSdkUid = input.ReadString();
				break;
			case 160u:
				ChapterLevel = input.ReadInt32();
				break;
			case 168u:
				DieTimes = input.ReadInt32();
				break;
			}
		}
	}
}
