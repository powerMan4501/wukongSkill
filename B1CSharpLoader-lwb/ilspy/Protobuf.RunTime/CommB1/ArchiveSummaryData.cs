using System;
using ArchiveB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ArchiveSummaryData : IMessage<ArchiveSummaryData>, IMessage, IEquatable<ArchiveSummaryData>, IDeepCloneable<ArchiveSummaryData>
{
	private static readonly MessageParser<ArchiveSummaryData> _parser = new MessageParser<ArchiveSummaryData>(() => new ArchiveSummaryData());

	private UnknownFieldSet _unknownFields;

	private int archiveId_;

	private int mapId_;

	private int roleLevel_;

	private ulong lastGameTime_;

	private uint gameTotalTime_;

	private int mapAreaId_;

	private bool newGameplusReady_;

	private int newGameplusCount_;

	private int chapterId_;

	private static readonly FieldCodec<int> _repeated_surpriseIdList_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> surpriseIdList_ = new RepeatedField<int>();

	private ReadArchiveResult readArchiveResult_;

	private int rebirthPointId_;

	private string archiveUid_ = "";

	private string sdkUid_ = "";

	private string sharedArchiveUid_ = "";

	private int dataSize_;

	private ulong createTime_;

	public static MessageParser<ArchiveSummaryData> Parser => _parser;

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

	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	public int RoleLevel
	{
		get
		{
			return roleLevel_;
		}
		set
		{
			roleLevel_ = value;
		}
	}

	public ulong LastGameTime
	{
		get
		{
			return lastGameTime_;
		}
		set
		{
			lastGameTime_ = value;
		}
	}

	public uint GameTotalTime
	{
		get
		{
			return gameTotalTime_;
		}
		set
		{
			gameTotalTime_ = value;
		}
	}

	public int MapAreaId
	{
		get
		{
			return mapAreaId_;
		}
		set
		{
			mapAreaId_ = value;
		}
	}

	public bool NewGameplusReady
	{
		get
		{
			return newGameplusReady_;
		}
		set
		{
			newGameplusReady_ = value;
		}
	}

	public int NewGameplusCount
	{
		get
		{
			return newGameplusCount_;
		}
		set
		{
			newGameplusCount_ = value;
		}
	}

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
		}
	}

	public RepeatedField<int> SurpriseIdList => surpriseIdList_;

	public ReadArchiveResult ReadArchiveResult
	{
		get
		{
			return readArchiveResult_;
		}
		set
		{
			readArchiveResult_ = value;
		}
	}

	public int RebirthPointId
	{
		get
		{
			return rebirthPointId_;
		}
		set
		{
			rebirthPointId_ = value;
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

	public string SdkUid
	{
		get
		{
			return sdkUid_;
		}
		set
		{
			sdkUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SharedArchiveUid
	{
		get
		{
			return sharedArchiveUid_;
		}
		set
		{
			sharedArchiveUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DataSize
	{
		get
		{
			return dataSize_;
		}
		set
		{
			dataSize_ = value;
		}
	}

	public ulong CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	public ArchiveSummaryData()
	{
	}

	public ArchiveSummaryData(ArchiveSummaryData other)
		: this()
	{
		archiveId_ = other.archiveId_;
		mapId_ = other.mapId_;
		roleLevel_ = other.roleLevel_;
		lastGameTime_ = other.lastGameTime_;
		gameTotalTime_ = other.gameTotalTime_;
		mapAreaId_ = other.mapAreaId_;
		newGameplusReady_ = other.newGameplusReady_;
		newGameplusCount_ = other.newGameplusCount_;
		chapterId_ = other.chapterId_;
		surpriseIdList_ = other.surpriseIdList_.Clone();
		readArchiveResult_ = other.readArchiveResult_;
		rebirthPointId_ = other.rebirthPointId_;
		archiveUid_ = other.archiveUid_;
		sdkUid_ = other.sdkUid_;
		sharedArchiveUid_ = other.sharedArchiveUid_;
		dataSize_ = other.dataSize_;
		createTime_ = other.createTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArchiveSummaryData Clone()
	{
		return new ArchiveSummaryData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArchiveSummaryData);
	}

	public bool Equals(ArchiveSummaryData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ArchiveId != other.ArchiveId)
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (RoleLevel != other.RoleLevel)
		{
			return false;
		}
		if (LastGameTime != other.LastGameTime)
		{
			return false;
		}
		if (GameTotalTime != other.GameTotalTime)
		{
			return false;
		}
		if (MapAreaId != other.MapAreaId)
		{
			return false;
		}
		if (NewGameplusReady != other.NewGameplusReady)
		{
			return false;
		}
		if (NewGameplusCount != other.NewGameplusCount)
		{
			return false;
		}
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		if (!surpriseIdList_.Equals(other.surpriseIdList_))
		{
			return false;
		}
		if (ReadArchiveResult != other.ReadArchiveResult)
		{
			return false;
		}
		if (RebirthPointId != other.RebirthPointId)
		{
			return false;
		}
		if (ArchiveUid != other.ArchiveUid)
		{
			return false;
		}
		if (SdkUid != other.SdkUid)
		{
			return false;
		}
		if (SharedArchiveUid != other.SharedArchiveUid)
		{
			return false;
		}
		if (DataSize != other.DataSize)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ArchiveId != 0)
		{
			num ^= ArchiveId.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (RoleLevel != 0)
		{
			num ^= RoleLevel.GetHashCode();
		}
		if (LastGameTime != 0L)
		{
			num ^= LastGameTime.GetHashCode();
		}
		if (GameTotalTime != 0)
		{
			num ^= GameTotalTime.GetHashCode();
		}
		if (MapAreaId != 0)
		{
			num ^= MapAreaId.GetHashCode();
		}
		if (NewGameplusReady)
		{
			num ^= NewGameplusReady.GetHashCode();
		}
		if (NewGameplusCount != 0)
		{
			num ^= NewGameplusCount.GetHashCode();
		}
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		num ^= surpriseIdList_.GetHashCode();
		if (ReadArchiveResult != ReadArchiveResult.Success)
		{
			num ^= ReadArchiveResult.GetHashCode();
		}
		if (RebirthPointId != 0)
		{
			num ^= RebirthPointId.GetHashCode();
		}
		if (ArchiveUid.Length != 0)
		{
			num ^= ArchiveUid.GetHashCode();
		}
		if (SdkUid.Length != 0)
		{
			num ^= SdkUid.GetHashCode();
		}
		if (SharedArchiveUid.Length != 0)
		{
			num ^= SharedArchiveUid.GetHashCode();
		}
		if (DataSize != 0)
		{
			num ^= DataSize.GetHashCode();
		}
		if (CreateTime != 0L)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ArchiveId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ArchiveId);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MapId);
		}
		if (RoleLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RoleLevel);
		}
		if (LastGameTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(LastGameTime);
		}
		if (GameTotalTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GameTotalTime);
		}
		if (MapAreaId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MapAreaId);
		}
		if (NewGameplusReady)
		{
			output.WriteRawTag(56);
			output.WriteBool(NewGameplusReady);
		}
		if (NewGameplusCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(NewGameplusCount);
		}
		if (ChapterId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ChapterId);
		}
		surpriseIdList_.WriteTo(output, _repeated_surpriseIdList_codec);
		if (ReadArchiveResult != ReadArchiveResult.Success)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)ReadArchiveResult);
		}
		if (RebirthPointId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(RebirthPointId);
		}
		if (ArchiveUid.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(ArchiveUid);
		}
		if (SdkUid.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(SdkUid);
		}
		if (SharedArchiveUid.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(SharedArchiveUid);
		}
		if (DataSize != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(DataSize);
		}
		if (CreateTime != 0L)
		{
			output.WriteRawTag(144, 1);
			output.WriteUInt64(CreateTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ArchiveId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ArchiveId);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (RoleLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RoleLevel);
		}
		if (LastGameTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(LastGameTime);
		}
		if (GameTotalTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameTotalTime);
		}
		if (MapAreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapAreaId);
		}
		if (NewGameplusReady)
		{
			num += 2;
		}
		if (NewGameplusCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NewGameplusCount);
		}
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		num += surpriseIdList_.CalculateSize(_repeated_surpriseIdList_codec);
		if (ReadArchiveResult != ReadArchiveResult.Success)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ReadArchiveResult);
		}
		if (RebirthPointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RebirthPointId);
		}
		if (ArchiveUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveUid);
		}
		if (SdkUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SdkUid);
		}
		if (SharedArchiveUid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(SharedArchiveUid);
		}
		if (DataSize != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DataSize);
		}
		if (CreateTime != 0L)
		{
			num += 2 + CodedOutputStream.ComputeUInt64Size(CreateTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArchiveSummaryData other)
	{
		if (other != null)
		{
			if (other.ArchiveId != 0)
			{
				ArchiveId = other.ArchiveId;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.RoleLevel != 0)
			{
				RoleLevel = other.RoleLevel;
			}
			if (other.LastGameTime != 0L)
			{
				LastGameTime = other.LastGameTime;
			}
			if (other.GameTotalTime != 0)
			{
				GameTotalTime = other.GameTotalTime;
			}
			if (other.MapAreaId != 0)
			{
				MapAreaId = other.MapAreaId;
			}
			if (other.NewGameplusReady)
			{
				NewGameplusReady = other.NewGameplusReady;
			}
			if (other.NewGameplusCount != 0)
			{
				NewGameplusCount = other.NewGameplusCount;
			}
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
			}
			surpriseIdList_.Add(other.surpriseIdList_);
			if (other.ReadArchiveResult != ReadArchiveResult.Success)
			{
				ReadArchiveResult = other.ReadArchiveResult;
			}
			if (other.RebirthPointId != 0)
			{
				RebirthPointId = other.RebirthPointId;
			}
			if (other.ArchiveUid.Length != 0)
			{
				ArchiveUid = other.ArchiveUid;
			}
			if (other.SdkUid.Length != 0)
			{
				SdkUid = other.SdkUid;
			}
			if (other.SharedArchiveUid.Length != 0)
			{
				SharedArchiveUid = other.SharedArchiveUid;
			}
			if (other.DataSize != 0)
			{
				DataSize = other.DataSize;
			}
			if (other.CreateTime != 0L)
			{
				CreateTime = other.CreateTime;
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
				ArchiveId = input.ReadInt32();
				break;
			case 16u:
				MapId = input.ReadInt32();
				break;
			case 24u:
				RoleLevel = input.ReadInt32();
				break;
			case 32u:
				LastGameTime = input.ReadUInt64();
				break;
			case 40u:
				GameTotalTime = input.ReadUInt32();
				break;
			case 48u:
				MapAreaId = input.ReadInt32();
				break;
			case 56u:
				NewGameplusReady = input.ReadBool();
				break;
			case 64u:
				NewGameplusCount = input.ReadInt32();
				break;
			case 72u:
				ChapterId = input.ReadInt32();
				break;
			case 80u:
			case 82u:
				surpriseIdList_.AddEntriesFrom(input, _repeated_surpriseIdList_codec);
				break;
			case 96u:
				ReadArchiveResult = (ReadArchiveResult)input.ReadEnum();
				break;
			case 104u:
				RebirthPointId = input.ReadInt32();
				break;
			case 114u:
				ArchiveUid = input.ReadString();
				break;
			case 122u:
				SdkUid = input.ReadString();
				break;
			case 130u:
				SharedArchiveUid = input.ReadString();
				break;
			case 136u:
				DataSize = input.ReadInt32();
				break;
			case 144u:
				CreateTime = input.ReadUInt64();
				break;
			}
		}
	}
}
