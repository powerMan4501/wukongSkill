using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class LevelDesc : IMessage<LevelDesc>, IMessage, IEquatable<LevelDesc>, IDeepCloneable<LevelDesc>
{
	private static readonly MessageParser<LevelDesc> _parser = new MessageParser<LevelDesc>(() => new LevelDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private YesNoType isOnlineLevel_;

	private YesNoType isVersionLevel_;

	private string name_ = "";

	private string path_ = "";

	private string desc_ = "";

	private string rebirthGroupName_ = "";

	private string rootQuestGraphPath_ = "";

	private string levelGroupPatrolDataAssetPath_ = "";

	private string levelDefaultBgmConfigPath_ = "";

	private int levelStreamingDefaultConfigId_;

	private int travelLevelLoadingScreenImageId_;

	private string levelHatredBattleConfig_ = "";

	private int roleDataConfId_;

	private string passlevelUrl_ = "";

	private string levelUiConfigPath_ = "";

	private int localizationTag_;

	private YesNoType isFormalLevel_;

	private int levelChapter_;

	private int rebirthSortId_;

	private int rtxEnable_;

	private static readonly FieldCodec<float> _repeated_playerDesiredHp_codec = FieldCodec.ForFloat(178u);

	private readonly RepeatedField<float> playerDesiredHp_ = new RepeatedField<float>();

	public static MessageParser<LevelDesc> Parser => _parser;

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

	public YesNoType IsOnlineLevel
	{
		get
		{
			return isOnlineLevel_;
		}
		set
		{
			isOnlineLevel_ = value;
		}
	}

	public YesNoType IsVersionLevel
	{
		get
		{
			return isVersionLevel_;
		}
		set
		{
			isVersionLevel_ = value;
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

	public string Path
	{
		get
		{
			return path_;
		}
		set
		{
			path_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Desc
	{
		get
		{
			return desc_;
		}
		set
		{
			desc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RebirthGroupName
	{
		get
		{
			return rebirthGroupName_;
		}
		set
		{
			rebirthGroupName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RootQuestGraphPath
	{
		get
		{
			return rootQuestGraphPath_;
		}
		set
		{
			rootQuestGraphPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LevelGroupPatrolDataAssetPath
	{
		get
		{
			return levelGroupPatrolDataAssetPath_;
		}
		set
		{
			levelGroupPatrolDataAssetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LevelDefaultBgmConfigPath
	{
		get
		{
			return levelDefaultBgmConfigPath_;
		}
		set
		{
			levelDefaultBgmConfigPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LevelStreamingDefaultConfigId
	{
		get
		{
			return levelStreamingDefaultConfigId_;
		}
		set
		{
			levelStreamingDefaultConfigId_ = value;
		}
	}

	public int TravelLevelLoadingScreenImageId
	{
		get
		{
			return travelLevelLoadingScreenImageId_;
		}
		set
		{
			travelLevelLoadingScreenImageId_ = value;
		}
	}

	public string LevelHatredBattleConfig
	{
		get
		{
			return levelHatredBattleConfig_;
		}
		set
		{
			levelHatredBattleConfig_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int RoleDataConfId
	{
		get
		{
			return roleDataConfId_;
		}
		set
		{
			roleDataConfId_ = value;
		}
	}

	public string PasslevelUrl
	{
		get
		{
			return passlevelUrl_;
		}
		set
		{
			passlevelUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LevelUiConfigPath
	{
		get
		{
			return levelUiConfigPath_;
		}
		set
		{
			levelUiConfigPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public YesNoType IsFormalLevel
	{
		get
		{
			return isFormalLevel_;
		}
		set
		{
			isFormalLevel_ = value;
		}
	}

	public int LevelChapter
	{
		get
		{
			return levelChapter_;
		}
		set
		{
			levelChapter_ = value;
		}
	}

	public int RebirthSortId
	{
		get
		{
			return rebirthSortId_;
		}
		set
		{
			rebirthSortId_ = value;
		}
	}

	public int RtxEnable
	{
		get
		{
			return rtxEnable_;
		}
		set
		{
			rtxEnable_ = value;
		}
	}

	public RepeatedField<float> PlayerDesiredHp => playerDesiredHp_;

	public LevelDesc()
	{
	}

	public LevelDesc(LevelDesc other)
		: this()
	{
		id_ = other.id_;
		isOnlineLevel_ = other.isOnlineLevel_;
		isVersionLevel_ = other.isVersionLevel_;
		name_ = other.name_;
		path_ = other.path_;
		desc_ = other.desc_;
		rebirthGroupName_ = other.rebirthGroupName_;
		rootQuestGraphPath_ = other.rootQuestGraphPath_;
		levelGroupPatrolDataAssetPath_ = other.levelGroupPatrolDataAssetPath_;
		levelDefaultBgmConfigPath_ = other.levelDefaultBgmConfigPath_;
		levelStreamingDefaultConfigId_ = other.levelStreamingDefaultConfigId_;
		travelLevelLoadingScreenImageId_ = other.travelLevelLoadingScreenImageId_;
		levelHatredBattleConfig_ = other.levelHatredBattleConfig_;
		roleDataConfId_ = other.roleDataConfId_;
		passlevelUrl_ = other.passlevelUrl_;
		levelUiConfigPath_ = other.levelUiConfigPath_;
		localizationTag_ = other.localizationTag_;
		isFormalLevel_ = other.isFormalLevel_;
		levelChapter_ = other.levelChapter_;
		rebirthSortId_ = other.rebirthSortId_;
		rtxEnable_ = other.rtxEnable_;
		playerDesiredHp_ = other.playerDesiredHp_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelDesc Clone()
	{
		return new LevelDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelDesc);
	}

	public bool Equals(LevelDesc other)
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
		if (IsOnlineLevel != other.IsOnlineLevel)
		{
			return false;
		}
		if (IsVersionLevel != other.IsVersionLevel)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Path != other.Path)
		{
			return false;
		}
		if (Desc != other.Desc)
		{
			return false;
		}
		if (RebirthGroupName != other.RebirthGroupName)
		{
			return false;
		}
		if (RootQuestGraphPath != other.RootQuestGraphPath)
		{
			return false;
		}
		if (LevelGroupPatrolDataAssetPath != other.LevelGroupPatrolDataAssetPath)
		{
			return false;
		}
		if (LevelDefaultBgmConfigPath != other.LevelDefaultBgmConfigPath)
		{
			return false;
		}
		if (LevelStreamingDefaultConfigId != other.LevelStreamingDefaultConfigId)
		{
			return false;
		}
		if (TravelLevelLoadingScreenImageId != other.TravelLevelLoadingScreenImageId)
		{
			return false;
		}
		if (LevelHatredBattleConfig != other.LevelHatredBattleConfig)
		{
			return false;
		}
		if (RoleDataConfId != other.RoleDataConfId)
		{
			return false;
		}
		if (PasslevelUrl != other.PasslevelUrl)
		{
			return false;
		}
		if (LevelUiConfigPath != other.LevelUiConfigPath)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (IsFormalLevel != other.IsFormalLevel)
		{
			return false;
		}
		if (LevelChapter != other.LevelChapter)
		{
			return false;
		}
		if (RebirthSortId != other.RebirthSortId)
		{
			return false;
		}
		if (RtxEnable != other.RtxEnable)
		{
			return false;
		}
		if (!playerDesiredHp_.Equals(other.playerDesiredHp_))
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
		if (IsOnlineLevel != YesNoType.No)
		{
			num ^= IsOnlineLevel.GetHashCode();
		}
		if (IsVersionLevel != YesNoType.No)
		{
			num ^= IsVersionLevel.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Path.Length != 0)
		{
			num ^= Path.GetHashCode();
		}
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
		}
		if (RebirthGroupName.Length != 0)
		{
			num ^= RebirthGroupName.GetHashCode();
		}
		if (RootQuestGraphPath.Length != 0)
		{
			num ^= RootQuestGraphPath.GetHashCode();
		}
		if (LevelGroupPatrolDataAssetPath.Length != 0)
		{
			num ^= LevelGroupPatrolDataAssetPath.GetHashCode();
		}
		if (LevelDefaultBgmConfigPath.Length != 0)
		{
			num ^= LevelDefaultBgmConfigPath.GetHashCode();
		}
		if (LevelStreamingDefaultConfigId != 0)
		{
			num ^= LevelStreamingDefaultConfigId.GetHashCode();
		}
		if (TravelLevelLoadingScreenImageId != 0)
		{
			num ^= TravelLevelLoadingScreenImageId.GetHashCode();
		}
		if (LevelHatredBattleConfig.Length != 0)
		{
			num ^= LevelHatredBattleConfig.GetHashCode();
		}
		if (RoleDataConfId != 0)
		{
			num ^= RoleDataConfId.GetHashCode();
		}
		if (PasslevelUrl.Length != 0)
		{
			num ^= PasslevelUrl.GetHashCode();
		}
		if (LevelUiConfigPath.Length != 0)
		{
			num ^= LevelUiConfigPath.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (IsFormalLevel != YesNoType.No)
		{
			num ^= IsFormalLevel.GetHashCode();
		}
		if (LevelChapter != 0)
		{
			num ^= LevelChapter.GetHashCode();
		}
		if (RebirthSortId != 0)
		{
			num ^= RebirthSortId.GetHashCode();
		}
		if (RtxEnable != 0)
		{
			num ^= RtxEnable.GetHashCode();
		}
		num ^= playerDesiredHp_.GetHashCode();
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
		if (IsOnlineLevel != YesNoType.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsOnlineLevel);
		}
		if (IsVersionLevel != YesNoType.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IsVersionLevel);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Name);
		}
		if (Path.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Path);
		}
		if (Desc.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Desc);
		}
		if (RebirthGroupName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(RebirthGroupName);
		}
		if (RootQuestGraphPath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(RootQuestGraphPath);
		}
		if (LevelGroupPatrolDataAssetPath.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(LevelGroupPatrolDataAssetPath);
		}
		if (LevelDefaultBgmConfigPath.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(LevelDefaultBgmConfigPath);
		}
		if (LevelStreamingDefaultConfigId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(LevelStreamingDefaultConfigId);
		}
		if (TravelLevelLoadingScreenImageId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(TravelLevelLoadingScreenImageId);
		}
		if (LevelHatredBattleConfig.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(LevelHatredBattleConfig);
		}
		if (RoleDataConfId != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(RoleDataConfId);
		}
		if (PasslevelUrl.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(PasslevelUrl);
		}
		if (LevelUiConfigPath.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(LevelUiConfigPath);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(LocalizationTag);
		}
		if (IsFormalLevel != YesNoType.No)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)IsFormalLevel);
		}
		if (LevelChapter != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(LevelChapter);
		}
		if (RebirthSortId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(RebirthSortId);
		}
		if (RtxEnable != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(RtxEnable);
		}
		playerDesiredHp_.WriteTo(output, _repeated_playerDesiredHp_codec);
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
		if (IsOnlineLevel != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsOnlineLevel);
		}
		if (IsVersionLevel != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsVersionLevel);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Path.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Path);
		}
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (RebirthGroupName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RebirthGroupName);
		}
		if (RootQuestGraphPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RootQuestGraphPath);
		}
		if (LevelGroupPatrolDataAssetPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LevelGroupPatrolDataAssetPath);
		}
		if (LevelDefaultBgmConfigPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LevelDefaultBgmConfigPath);
		}
		if (LevelStreamingDefaultConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelStreamingDefaultConfigId);
		}
		if (TravelLevelLoadingScreenImageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TravelLevelLoadingScreenImageId);
		}
		if (LevelHatredBattleConfig.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LevelHatredBattleConfig);
		}
		if (RoleDataConfId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RoleDataConfId);
		}
		if (PasslevelUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PasslevelUrl);
		}
		if (LevelUiConfigPath.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(LevelUiConfigPath);
		}
		if (LocalizationTag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (IsFormalLevel != YesNoType.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsFormalLevel);
		}
		if (LevelChapter != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LevelChapter);
		}
		if (RebirthSortId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RebirthSortId);
		}
		if (RtxEnable != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RtxEnable);
		}
		num += playerDesiredHp_.CalculateSize(_repeated_playerDesiredHp_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsOnlineLevel != YesNoType.No)
			{
				IsOnlineLevel = other.IsOnlineLevel;
			}
			if (other.IsVersionLevel != YesNoType.No)
			{
				IsVersionLevel = other.IsVersionLevel;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Path.Length != 0)
			{
				Path = other.Path;
			}
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
			}
			if (other.RebirthGroupName.Length != 0)
			{
				RebirthGroupName = other.RebirthGroupName;
			}
			if (other.RootQuestGraphPath.Length != 0)
			{
				RootQuestGraphPath = other.RootQuestGraphPath;
			}
			if (other.LevelGroupPatrolDataAssetPath.Length != 0)
			{
				LevelGroupPatrolDataAssetPath = other.LevelGroupPatrolDataAssetPath;
			}
			if (other.LevelDefaultBgmConfigPath.Length != 0)
			{
				LevelDefaultBgmConfigPath = other.LevelDefaultBgmConfigPath;
			}
			if (other.LevelStreamingDefaultConfigId != 0)
			{
				LevelStreamingDefaultConfigId = other.LevelStreamingDefaultConfigId;
			}
			if (other.TravelLevelLoadingScreenImageId != 0)
			{
				TravelLevelLoadingScreenImageId = other.TravelLevelLoadingScreenImageId;
			}
			if (other.LevelHatredBattleConfig.Length != 0)
			{
				LevelHatredBattleConfig = other.LevelHatredBattleConfig;
			}
			if (other.RoleDataConfId != 0)
			{
				RoleDataConfId = other.RoleDataConfId;
			}
			if (other.PasslevelUrl.Length != 0)
			{
				PasslevelUrl = other.PasslevelUrl;
			}
			if (other.LevelUiConfigPath.Length != 0)
			{
				LevelUiConfigPath = other.LevelUiConfigPath;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.IsFormalLevel != YesNoType.No)
			{
				IsFormalLevel = other.IsFormalLevel;
			}
			if (other.LevelChapter != 0)
			{
				LevelChapter = other.LevelChapter;
			}
			if (other.RebirthSortId != 0)
			{
				RebirthSortId = other.RebirthSortId;
			}
			if (other.RtxEnable != 0)
			{
				RtxEnable = other.RtxEnable;
			}
			playerDesiredHp_.Add(other.playerDesiredHp_);
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
				IsOnlineLevel = (YesNoType)input.ReadEnum();
				break;
			case 24u:
				IsVersionLevel = (YesNoType)input.ReadEnum();
				break;
			case 34u:
				Name = input.ReadString();
				break;
			case 42u:
				Path = input.ReadString();
				break;
			case 50u:
				Desc = input.ReadString();
				break;
			case 58u:
				RebirthGroupName = input.ReadString();
				break;
			case 66u:
				RootQuestGraphPath = input.ReadString();
				break;
			case 74u:
				LevelGroupPatrolDataAssetPath = input.ReadString();
				break;
			case 82u:
				LevelDefaultBgmConfigPath = input.ReadString();
				break;
			case 88u:
				LevelStreamingDefaultConfigId = input.ReadInt32();
				break;
			case 96u:
				TravelLevelLoadingScreenImageId = input.ReadInt32();
				break;
			case 106u:
				LevelHatredBattleConfig = input.ReadString();
				break;
			case 112u:
				RoleDataConfId = input.ReadInt32();
				break;
			case 122u:
				PasslevelUrl = input.ReadString();
				break;
			case 130u:
				LevelUiConfigPath = input.ReadString();
				break;
			case 136u:
				LocalizationTag = input.ReadInt32();
				break;
			case 144u:
				IsFormalLevel = (YesNoType)input.ReadEnum();
				break;
			case 152u:
				LevelChapter = input.ReadInt32();
				break;
			case 160u:
				RebirthSortId = input.ReadInt32();
				break;
			case 168u:
				RtxEnable = input.ReadInt32();
				break;
			case 178u:
			case 181u:
				playerDesiredHp_.AddEntriesFrom(input, _repeated_playerDesiredHp_codec);
				break;
			}
		}
	}
}
