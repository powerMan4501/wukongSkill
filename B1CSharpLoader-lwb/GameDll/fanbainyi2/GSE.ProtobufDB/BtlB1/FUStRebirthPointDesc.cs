using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStRebirthPointDesc : IMessage<FUStRebirthPointDesc>, IMessage, IEquatable<FUStRebirthPointDesc>, IDeepCloneable<FUStRebirthPointDesc>
{
	private static readonly MessageParser<FUStRebirthPointDesc> _parser = new MessageParser<FUStRebirthPointDesc>(() => new FUStRebirthPointDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string name_ = "";

	private int groupMapID_;

	private int groupAreaID_;

	private EGSYesNo isDefault_;

	private EGSYesNo isActive_;

	private string sceneComponentName_ = "";

	private string activeMontage_ = "";

	private string activeStateMontage_ = "";

	private EGSYesNo canTeleport_;

	private int mapID_;

	private int sortID_;

	private int localizationTag_;

	private int navigationRange_;

	private int navigationAxisZRange_;

	private int navigationPriority_;

	private string rebirthPointDBCWhenPlayerRebirth_ = "";

	private EGSYesNo isZhaoHunFan_;

	private int relatedRebirthPointIdToHiddenThis_;

	private string mainMenuAudioEvent_ = "";

	private int transId_;

	private int disableTransTaskId_;

	private int allowTransBackMaunl_;

	private string playNavAudioEvent_ = "";

	private string stopNavAudioEvent_ = "";

	private string playResidentAudioEvent_ = "";

	private string stopResidentAudioEvent_ = "";

	public static MessageParser<FUStRebirthPointDesc> Parser => _parser;

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

	public int GroupMapID
	{
		get
		{
			return groupMapID_;
		}
		set
		{
			groupMapID_ = value;
		}
	}

	public int GroupAreaID
	{
		get
		{
			return groupAreaID_;
		}
		set
		{
			groupAreaID_ = value;
		}
	}

	public EGSYesNo IsDefault
	{
		get
		{
			return isDefault_;
		}
		set
		{
			isDefault_ = value;
		}
	}

	public EGSYesNo IsActive
	{
		get
		{
			return isActive_;
		}
		set
		{
			isActive_ = value;
		}
	}

	public string SceneComponentName
	{
		get
		{
			return sceneComponentName_;
		}
		set
		{
			sceneComponentName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ActiveMontage
	{
		get
		{
			return activeMontage_;
		}
		set
		{
			activeMontage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ActiveStateMontage
	{
		get
		{
			return activeStateMontage_;
		}
		set
		{
			activeStateMontage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo CanTeleport
	{
		get
		{
			return canTeleport_;
		}
		set
		{
			canTeleport_ = value;
		}
	}

	public int MapID
	{
		get
		{
			return mapID_;
		}
		set
		{
			mapID_ = value;
		}
	}

	public int SortID
	{
		get
		{
			return sortID_;
		}
		set
		{
			sortID_ = value;
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

	public int NavigationRange
	{
		get
		{
			return navigationRange_;
		}
		set
		{
			navigationRange_ = value;
		}
	}

	public int NavigationAxisZRange
	{
		get
		{
			return navigationAxisZRange_;
		}
		set
		{
			navigationAxisZRange_ = value;
		}
	}

	public int NavigationPriority
	{
		get
		{
			return navigationPriority_;
		}
		set
		{
			navigationPriority_ = value;
		}
	}

	public string RebirthPointDBCWhenPlayerRebirth
	{
		get
		{
			return rebirthPointDBCWhenPlayerRebirth_;
		}
		set
		{
			rebirthPointDBCWhenPlayerRebirth_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo IsZhaoHunFan
	{
		get
		{
			return isZhaoHunFan_;
		}
		set
		{
			isZhaoHunFan_ = value;
		}
	}

	public int RelatedRebirthPointIdToHiddenThis
	{
		get
		{
			return relatedRebirthPointIdToHiddenThis_;
		}
		set
		{
			relatedRebirthPointIdToHiddenThis_ = value;
		}
	}

	public string MainMenuAudioEvent
	{
		get
		{
			return mainMenuAudioEvent_;
		}
		set
		{
			mainMenuAudioEvent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TransId
	{
		get
		{
			return transId_;
		}
		set
		{
			transId_ = value;
		}
	}

	public int DisableTransTaskId
	{
		get
		{
			return disableTransTaskId_;
		}
		set
		{
			disableTransTaskId_ = value;
		}
	}

	public int AllowTransBackMaunl
	{
		get
		{
			return allowTransBackMaunl_;
		}
		set
		{
			allowTransBackMaunl_ = value;
		}
	}

	public string PlayNavAudioEvent
	{
		get
		{
			return playNavAudioEvent_;
		}
		set
		{
			playNavAudioEvent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string StopNavAudioEvent
	{
		get
		{
			return stopNavAudioEvent_;
		}
		set
		{
			stopNavAudioEvent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PlayResidentAudioEvent
	{
		get
		{
			return playResidentAudioEvent_;
		}
		set
		{
			playResidentAudioEvent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string StopResidentAudioEvent
	{
		get
		{
			return stopResidentAudioEvent_;
		}
		set
		{
			stopResidentAudioEvent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStRebirthPointDesc()
	{
	}

	public FUStRebirthPointDesc(FUStRebirthPointDesc other)
		: this()
	{
		iD_ = other.iD_;
		name_ = other.name_;
		groupMapID_ = other.groupMapID_;
		groupAreaID_ = other.groupAreaID_;
		isDefault_ = other.isDefault_;
		isActive_ = other.isActive_;
		sceneComponentName_ = other.sceneComponentName_;
		activeMontage_ = other.activeMontage_;
		activeStateMontage_ = other.activeStateMontage_;
		canTeleport_ = other.canTeleport_;
		mapID_ = other.mapID_;
		sortID_ = other.sortID_;
		localizationTag_ = other.localizationTag_;
		navigationRange_ = other.navigationRange_;
		navigationAxisZRange_ = other.navigationAxisZRange_;
		navigationPriority_ = other.navigationPriority_;
		rebirthPointDBCWhenPlayerRebirth_ = other.rebirthPointDBCWhenPlayerRebirth_;
		isZhaoHunFan_ = other.isZhaoHunFan_;
		relatedRebirthPointIdToHiddenThis_ = other.relatedRebirthPointIdToHiddenThis_;
		mainMenuAudioEvent_ = other.mainMenuAudioEvent_;
		transId_ = other.transId_;
		disableTransTaskId_ = other.disableTransTaskId_;
		allowTransBackMaunl_ = other.allowTransBackMaunl_;
		playNavAudioEvent_ = other.playNavAudioEvent_;
		stopNavAudioEvent_ = other.stopNavAudioEvent_;
		playResidentAudioEvent_ = other.playResidentAudioEvent_;
		stopResidentAudioEvent_ = other.stopResidentAudioEvent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStRebirthPointDesc Clone()
	{
		return new FUStRebirthPointDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStRebirthPointDesc);
	}

	public bool Equals(FUStRebirthPointDesc other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (GroupMapID != other.GroupMapID)
		{
			return false;
		}
		if (GroupAreaID != other.GroupAreaID)
		{
			return false;
		}
		if (IsDefault != other.IsDefault)
		{
			return false;
		}
		if (IsActive != other.IsActive)
		{
			return false;
		}
		if (SceneComponentName != other.SceneComponentName)
		{
			return false;
		}
		if (ActiveMontage != other.ActiveMontage)
		{
			return false;
		}
		if (ActiveStateMontage != other.ActiveStateMontage)
		{
			return false;
		}
		if (CanTeleport != other.CanTeleport)
		{
			return false;
		}
		if (MapID != other.MapID)
		{
			return false;
		}
		if (SortID != other.SortID)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (NavigationRange != other.NavigationRange)
		{
			return false;
		}
		if (NavigationAxisZRange != other.NavigationAxisZRange)
		{
			return false;
		}
		if (NavigationPriority != other.NavigationPriority)
		{
			return false;
		}
		if (RebirthPointDBCWhenPlayerRebirth != other.RebirthPointDBCWhenPlayerRebirth)
		{
			return false;
		}
		if (IsZhaoHunFan != other.IsZhaoHunFan)
		{
			return false;
		}
		if (RelatedRebirthPointIdToHiddenThis != other.RelatedRebirthPointIdToHiddenThis)
		{
			return false;
		}
		if (MainMenuAudioEvent != other.MainMenuAudioEvent)
		{
			return false;
		}
		if (TransId != other.TransId)
		{
			return false;
		}
		if (DisableTransTaskId != other.DisableTransTaskId)
		{
			return false;
		}
		if (AllowTransBackMaunl != other.AllowTransBackMaunl)
		{
			return false;
		}
		if (PlayNavAudioEvent != other.PlayNavAudioEvent)
		{
			return false;
		}
		if (StopNavAudioEvent != other.StopNavAudioEvent)
		{
			return false;
		}
		if (PlayResidentAudioEvent != other.PlayResidentAudioEvent)
		{
			return false;
		}
		if (StopResidentAudioEvent != other.StopResidentAudioEvent)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (GroupMapID != 0)
		{
			num ^= GroupMapID.GetHashCode();
		}
		if (GroupAreaID != 0)
		{
			num ^= GroupAreaID.GetHashCode();
		}
		if (IsDefault != EGSYesNo.No)
		{
			num ^= IsDefault.GetHashCode();
		}
		if (IsActive != EGSYesNo.No)
		{
			num ^= IsActive.GetHashCode();
		}
		if (SceneComponentName.Length != 0)
		{
			num ^= SceneComponentName.GetHashCode();
		}
		if (ActiveMontage.Length != 0)
		{
			num ^= ActiveMontage.GetHashCode();
		}
		if (ActiveStateMontage.Length != 0)
		{
			num ^= ActiveStateMontage.GetHashCode();
		}
		if (CanTeleport != EGSYesNo.No)
		{
			num ^= CanTeleport.GetHashCode();
		}
		if (MapID != 0)
		{
			num ^= MapID.GetHashCode();
		}
		if (SortID != 0)
		{
			num ^= SortID.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (NavigationRange != 0)
		{
			num ^= NavigationRange.GetHashCode();
		}
		if (NavigationAxisZRange != 0)
		{
			num ^= NavigationAxisZRange.GetHashCode();
		}
		if (NavigationPriority != 0)
		{
			num ^= NavigationPriority.GetHashCode();
		}
		if (RebirthPointDBCWhenPlayerRebirth.Length != 0)
		{
			num ^= RebirthPointDBCWhenPlayerRebirth.GetHashCode();
		}
		if (IsZhaoHunFan != EGSYesNo.No)
		{
			num ^= IsZhaoHunFan.GetHashCode();
		}
		if (RelatedRebirthPointIdToHiddenThis != 0)
		{
			num ^= RelatedRebirthPointIdToHiddenThis.GetHashCode();
		}
		if (MainMenuAudioEvent.Length != 0)
		{
			num ^= MainMenuAudioEvent.GetHashCode();
		}
		if (TransId != 0)
		{
			num ^= TransId.GetHashCode();
		}
		if (DisableTransTaskId != 0)
		{
			num ^= DisableTransTaskId.GetHashCode();
		}
		if (AllowTransBackMaunl != 0)
		{
			num ^= AllowTransBackMaunl.GetHashCode();
		}
		if (PlayNavAudioEvent.Length != 0)
		{
			num ^= PlayNavAudioEvent.GetHashCode();
		}
		if (StopNavAudioEvent.Length != 0)
		{
			num ^= StopNavAudioEvent.GetHashCode();
		}
		if (PlayResidentAudioEvent.Length != 0)
		{
			num ^= PlayResidentAudioEvent.GetHashCode();
		}
		if (StopResidentAudioEvent.Length != 0)
		{
			num ^= StopResidentAudioEvent.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (GroupMapID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupMapID);
		}
		if (GroupAreaID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupAreaID);
		}
		if (IsDefault != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsDefault);
		}
		if (IsActive != EGSYesNo.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)IsActive);
		}
		if (SceneComponentName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(SceneComponentName);
		}
		if (ActiveMontage.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(ActiveMontage);
		}
		if (ActiveStateMontage.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(ActiveStateMontage);
		}
		if (CanTeleport != EGSYesNo.No)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)CanTeleport);
		}
		if (MapID != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(MapID);
		}
		if (SortID != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(SortID);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(LocalizationTag);
		}
		if (NavigationRange != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(NavigationRange);
		}
		if (NavigationAxisZRange != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(NavigationAxisZRange);
		}
		if (NavigationPriority != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(NavigationPriority);
		}
		if (RebirthPointDBCWhenPlayerRebirth.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(RebirthPointDBCWhenPlayerRebirth);
		}
		if (IsZhaoHunFan != EGSYesNo.No)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)IsZhaoHunFan);
		}
		if (RelatedRebirthPointIdToHiddenThis != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(RelatedRebirthPointIdToHiddenThis);
		}
		if (MainMenuAudioEvent.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(MainMenuAudioEvent);
		}
		if (TransId != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(TransId);
		}
		if (DisableTransTaskId != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(DisableTransTaskId);
		}
		if (AllowTransBackMaunl != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(AllowTransBackMaunl);
		}
		if (PlayNavAudioEvent.Length != 0)
		{
			output.WriteRawTag(194, 1);
			output.WriteString(PlayNavAudioEvent);
		}
		if (StopNavAudioEvent.Length != 0)
		{
			output.WriteRawTag(202, 1);
			output.WriteString(StopNavAudioEvent);
		}
		if (PlayResidentAudioEvent.Length != 0)
		{
			output.WriteRawTag(210, 1);
			output.WriteString(PlayResidentAudioEvent);
		}
		if (StopResidentAudioEvent.Length != 0)
		{
			output.WriteRawTag(218, 1);
			output.WriteString(StopResidentAudioEvent);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (GroupMapID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupMapID);
		}
		if (GroupAreaID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupAreaID);
		}
		if (IsDefault != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsDefault);
		}
		if (IsActive != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsActive);
		}
		if (SceneComponentName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SceneComponentName);
		}
		if (ActiveMontage.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ActiveMontage);
		}
		if (ActiveStateMontage.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ActiveStateMontage);
		}
		if (CanTeleport != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanTeleport);
		}
		if (MapID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapID);
		}
		if (SortID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortID);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (NavigationRange != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NavigationRange);
		}
		if (NavigationAxisZRange != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NavigationAxisZRange);
		}
		if (NavigationPriority != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NavigationPriority);
		}
		if (RebirthPointDBCWhenPlayerRebirth.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(RebirthPointDBCWhenPlayerRebirth);
		}
		if (IsZhaoHunFan != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsZhaoHunFan);
		}
		if (RelatedRebirthPointIdToHiddenThis != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RelatedRebirthPointIdToHiddenThis);
		}
		if (MainMenuAudioEvent.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MainMenuAudioEvent);
		}
		if (TransId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TransId);
		}
		if (DisableTransTaskId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(DisableTransTaskId);
		}
		if (AllowTransBackMaunl != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AllowTransBackMaunl);
		}
		if (PlayNavAudioEvent.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PlayNavAudioEvent);
		}
		if (StopNavAudioEvent.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(StopNavAudioEvent);
		}
		if (PlayResidentAudioEvent.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(PlayResidentAudioEvent);
		}
		if (StopResidentAudioEvent.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(StopResidentAudioEvent);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStRebirthPointDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.GroupMapID != 0)
			{
				GroupMapID = other.GroupMapID;
			}
			if (other.GroupAreaID != 0)
			{
				GroupAreaID = other.GroupAreaID;
			}
			if (other.IsDefault != EGSYesNo.No)
			{
				IsDefault = other.IsDefault;
			}
			if (other.IsActive != EGSYesNo.No)
			{
				IsActive = other.IsActive;
			}
			if (other.SceneComponentName.Length != 0)
			{
				SceneComponentName = other.SceneComponentName;
			}
			if (other.ActiveMontage.Length != 0)
			{
				ActiveMontage = other.ActiveMontage;
			}
			if (other.ActiveStateMontage.Length != 0)
			{
				ActiveStateMontage = other.ActiveStateMontage;
			}
			if (other.CanTeleport != EGSYesNo.No)
			{
				CanTeleport = other.CanTeleport;
			}
			if (other.MapID != 0)
			{
				MapID = other.MapID;
			}
			if (other.SortID != 0)
			{
				SortID = other.SortID;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.NavigationRange != 0)
			{
				NavigationRange = other.NavigationRange;
			}
			if (other.NavigationAxisZRange != 0)
			{
				NavigationAxisZRange = other.NavigationAxisZRange;
			}
			if (other.NavigationPriority != 0)
			{
				NavigationPriority = other.NavigationPriority;
			}
			if (other.RebirthPointDBCWhenPlayerRebirth.Length != 0)
			{
				RebirthPointDBCWhenPlayerRebirth = other.RebirthPointDBCWhenPlayerRebirth;
			}
			if (other.IsZhaoHunFan != EGSYesNo.No)
			{
				IsZhaoHunFan = other.IsZhaoHunFan;
			}
			if (other.RelatedRebirthPointIdToHiddenThis != 0)
			{
				RelatedRebirthPointIdToHiddenThis = other.RelatedRebirthPointIdToHiddenThis;
			}
			if (other.MainMenuAudioEvent.Length != 0)
			{
				MainMenuAudioEvent = other.MainMenuAudioEvent;
			}
			if (other.TransId != 0)
			{
				TransId = other.TransId;
			}
			if (other.DisableTransTaskId != 0)
			{
				DisableTransTaskId = other.DisableTransTaskId;
			}
			if (other.AllowTransBackMaunl != 0)
			{
				AllowTransBackMaunl = other.AllowTransBackMaunl;
			}
			if (other.PlayNavAudioEvent.Length != 0)
			{
				PlayNavAudioEvent = other.PlayNavAudioEvent;
			}
			if (other.StopNavAudioEvent.Length != 0)
			{
				StopNavAudioEvent = other.StopNavAudioEvent;
			}
			if (other.PlayResidentAudioEvent.Length != 0)
			{
				PlayResidentAudioEvent = other.PlayResidentAudioEvent;
			}
			if (other.StopResidentAudioEvent.Length != 0)
			{
				StopResidentAudioEvent = other.StopResidentAudioEvent;
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
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				GroupMapID = input.ReadInt32();
				break;
			case 32u:
				GroupAreaID = input.ReadInt32();
				break;
			case 40u:
				IsDefault = (EGSYesNo)input.ReadEnum();
				break;
			case 48u:
				IsActive = (EGSYesNo)input.ReadEnum();
				break;
			case 58u:
				SceneComponentName = input.ReadString();
				break;
			case 66u:
				ActiveMontage = input.ReadString();
				break;
			case 74u:
				ActiveStateMontage = input.ReadString();
				break;
			case 80u:
				CanTeleport = (EGSYesNo)input.ReadEnum();
				break;
			case 88u:
				MapID = input.ReadInt32();
				break;
			case 96u:
				SortID = input.ReadInt32();
				break;
			case 104u:
				LocalizationTag = input.ReadInt32();
				break;
			case 112u:
				NavigationRange = input.ReadInt32();
				break;
			case 120u:
				NavigationAxisZRange = input.ReadInt32();
				break;
			case 128u:
				NavigationPriority = input.ReadInt32();
				break;
			case 138u:
				RebirthPointDBCWhenPlayerRebirth = input.ReadString();
				break;
			case 144u:
				IsZhaoHunFan = (EGSYesNo)input.ReadEnum();
				break;
			case 152u:
				RelatedRebirthPointIdToHiddenThis = input.ReadInt32();
				break;
			case 162u:
				MainMenuAudioEvent = input.ReadString();
				break;
			case 168u:
				TransId = input.ReadInt32();
				break;
			case 176u:
				DisableTransTaskId = input.ReadInt32();
				break;
			case 184u:
				AllowTransBackMaunl = input.ReadInt32();
				break;
			case 194u:
				PlayNavAudioEvent = input.ReadString();
				break;
			case 202u:
				StopNavAudioEvent = input.ReadString();
				break;
			case 210u:
				PlayResidentAudioEvent = input.ReadString();
				break;
			case 218u:
				StopResidentAudioEvent = input.ReadString();
				break;
			}
		}
	}
}
