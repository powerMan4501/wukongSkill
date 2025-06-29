using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_Teleport : IMessage<QuestCustom_Teleport>, IMessage, IEquatable<QuestCustom_Teleport>, IDeepCloneable<QuestCustom_Teleport>
{
	private static readonly MessageParser<QuestCustom_Teleport> _parser = new MessageParser<QuestCustom_Teleport>(() => new QuestCustom_Teleport());

	private UnknownFieldSet _unknownFields;

	private string pointName_ = "";

	private bool isDropTeleportPoint_;

	private string droppedTeleportPointId_ = "";

	private string beforeTeleportMontagePath_ = "";

	private string afterTeleportMontagePath_ = "";

	private bool isTeleportToOtherLevel_;

	private int targetLevelId_;

	private bool isSaveArchiveAfterTeleport_;

	private string archiveLabel_ = "";

	private int targetRebirthPointId_;

	private bool dontResetPlayerState_;

	private int loadingScreenType_;

	public static MessageParser<QuestCustom_Teleport> Parser => _parser;

	public string PointName
	{
		get
		{
			return pointName_;
		}
		set
		{
			pointName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsDropTeleportPoint
	{
		get
		{
			return isDropTeleportPoint_;
		}
		set
		{
			isDropTeleportPoint_ = value;
		}
	}

	public string DroppedTeleportPointId
	{
		get
		{
			return droppedTeleportPointId_;
		}
		set
		{
			droppedTeleportPointId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BeforeTeleportMontagePath
	{
		get
		{
			return beforeTeleportMontagePath_;
		}
		set
		{
			beforeTeleportMontagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AfterTeleportMontagePath
	{
		get
		{
			return afterTeleportMontagePath_;
		}
		set
		{
			afterTeleportMontagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsTeleportToOtherLevel
	{
		get
		{
			return isTeleportToOtherLevel_;
		}
		set
		{
			isTeleportToOtherLevel_ = value;
		}
	}

	public int TargetLevelId
	{
		get
		{
			return targetLevelId_;
		}
		set
		{
			targetLevelId_ = value;
		}
	}

	public bool IsSaveArchiveAfterTeleport
	{
		get
		{
			return isSaveArchiveAfterTeleport_;
		}
		set
		{
			isSaveArchiveAfterTeleport_ = value;
		}
	}

	public string ArchiveLabel
	{
		get
		{
			return archiveLabel_;
		}
		set
		{
			archiveLabel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TargetRebirthPointId
	{
		get
		{
			return targetRebirthPointId_;
		}
		set
		{
			targetRebirthPointId_ = value;
		}
	}

	public bool DontResetPlayerState
	{
		get
		{
			return dontResetPlayerState_;
		}
		set
		{
			dontResetPlayerState_ = value;
		}
	}

	public int LoadingScreenType
	{
		get
		{
			return loadingScreenType_;
		}
		set
		{
			loadingScreenType_ = value;
		}
	}

	public QuestCustom_Teleport()
	{
	}

	public QuestCustom_Teleport(QuestCustom_Teleport other)
		: this()
	{
		pointName_ = other.pointName_;
		isDropTeleportPoint_ = other.isDropTeleportPoint_;
		droppedTeleportPointId_ = other.droppedTeleportPointId_;
		beforeTeleportMontagePath_ = other.beforeTeleportMontagePath_;
		afterTeleportMontagePath_ = other.afterTeleportMontagePath_;
		isTeleportToOtherLevel_ = other.isTeleportToOtherLevel_;
		targetLevelId_ = other.targetLevelId_;
		isSaveArchiveAfterTeleport_ = other.isSaveArchiveAfterTeleport_;
		archiveLabel_ = other.archiveLabel_;
		targetRebirthPointId_ = other.targetRebirthPointId_;
		dontResetPlayerState_ = other.dontResetPlayerState_;
		loadingScreenType_ = other.loadingScreenType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_Teleport Clone()
	{
		return new QuestCustom_Teleport(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_Teleport);
	}

	public bool Equals(QuestCustom_Teleport other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PointName != other.PointName)
		{
			return false;
		}
		if (IsDropTeleportPoint != other.IsDropTeleportPoint)
		{
			return false;
		}
		if (DroppedTeleportPointId != other.DroppedTeleportPointId)
		{
			return false;
		}
		if (BeforeTeleportMontagePath != other.BeforeTeleportMontagePath)
		{
			return false;
		}
		if (AfterTeleportMontagePath != other.AfterTeleportMontagePath)
		{
			return false;
		}
		if (IsTeleportToOtherLevel != other.IsTeleportToOtherLevel)
		{
			return false;
		}
		if (TargetLevelId != other.TargetLevelId)
		{
			return false;
		}
		if (IsSaveArchiveAfterTeleport != other.IsSaveArchiveAfterTeleport)
		{
			return false;
		}
		if (ArchiveLabel != other.ArchiveLabel)
		{
			return false;
		}
		if (TargetRebirthPointId != other.TargetRebirthPointId)
		{
			return false;
		}
		if (DontResetPlayerState != other.DontResetPlayerState)
		{
			return false;
		}
		if (LoadingScreenType != other.LoadingScreenType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PointName.Length != 0)
		{
			num ^= PointName.GetHashCode();
		}
		if (IsDropTeleportPoint)
		{
			num ^= IsDropTeleportPoint.GetHashCode();
		}
		if (DroppedTeleportPointId.Length != 0)
		{
			num ^= DroppedTeleportPointId.GetHashCode();
		}
		if (BeforeTeleportMontagePath.Length != 0)
		{
			num ^= BeforeTeleportMontagePath.GetHashCode();
		}
		if (AfterTeleportMontagePath.Length != 0)
		{
			num ^= AfterTeleportMontagePath.GetHashCode();
		}
		if (IsTeleportToOtherLevel)
		{
			num ^= IsTeleportToOtherLevel.GetHashCode();
		}
		if (TargetLevelId != 0)
		{
			num ^= TargetLevelId.GetHashCode();
		}
		if (IsSaveArchiveAfterTeleport)
		{
			num ^= IsSaveArchiveAfterTeleport.GetHashCode();
		}
		if (ArchiveLabel.Length != 0)
		{
			num ^= ArchiveLabel.GetHashCode();
		}
		if (TargetRebirthPointId != 0)
		{
			num ^= TargetRebirthPointId.GetHashCode();
		}
		if (DontResetPlayerState)
		{
			num ^= DontResetPlayerState.GetHashCode();
		}
		if (LoadingScreenType != 0)
		{
			num ^= LoadingScreenType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PointName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PointName);
		}
		if (IsDropTeleportPoint)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsDropTeleportPoint);
		}
		if (DroppedTeleportPointId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(DroppedTeleportPointId);
		}
		if (BeforeTeleportMontagePath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(BeforeTeleportMontagePath);
		}
		if (AfterTeleportMontagePath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(AfterTeleportMontagePath);
		}
		if (IsTeleportToOtherLevel)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsTeleportToOtherLevel);
		}
		if (TargetLevelId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TargetLevelId);
		}
		if (IsSaveArchiveAfterTeleport)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsSaveArchiveAfterTeleport);
		}
		if (ArchiveLabel.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(ArchiveLabel);
		}
		if (TargetRebirthPointId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(TargetRebirthPointId);
		}
		if (DontResetPlayerState)
		{
			output.WriteRawTag(88);
			output.WriteBool(DontResetPlayerState);
		}
		if (LoadingScreenType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(LoadingScreenType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PointName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PointName);
		}
		if (IsDropTeleportPoint)
		{
			num += 2;
		}
		if (DroppedTeleportPointId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DroppedTeleportPointId);
		}
		if (BeforeTeleportMontagePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BeforeTeleportMontagePath);
		}
		if (AfterTeleportMontagePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AfterTeleportMontagePath);
		}
		if (IsTeleportToOtherLevel)
		{
			num += 2;
		}
		if (TargetLevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetLevelId);
		}
		if (IsSaveArchiveAfterTeleport)
		{
			num += 2;
		}
		if (ArchiveLabel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveLabel);
		}
		if (TargetRebirthPointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetRebirthPointId);
		}
		if (DontResetPlayerState)
		{
			num += 2;
		}
		if (LoadingScreenType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LoadingScreenType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_Teleport other)
	{
		if (other != null)
		{
			if (other.PointName.Length != 0)
			{
				PointName = other.PointName;
			}
			if (other.IsDropTeleportPoint)
			{
				IsDropTeleportPoint = other.IsDropTeleportPoint;
			}
			if (other.DroppedTeleportPointId.Length != 0)
			{
				DroppedTeleportPointId = other.DroppedTeleportPointId;
			}
			if (other.BeforeTeleportMontagePath.Length != 0)
			{
				BeforeTeleportMontagePath = other.BeforeTeleportMontagePath;
			}
			if (other.AfterTeleportMontagePath.Length != 0)
			{
				AfterTeleportMontagePath = other.AfterTeleportMontagePath;
			}
			if (other.IsTeleportToOtherLevel)
			{
				IsTeleportToOtherLevel = other.IsTeleportToOtherLevel;
			}
			if (other.TargetLevelId != 0)
			{
				TargetLevelId = other.TargetLevelId;
			}
			if (other.IsSaveArchiveAfterTeleport)
			{
				IsSaveArchiveAfterTeleport = other.IsSaveArchiveAfterTeleport;
			}
			if (other.ArchiveLabel.Length != 0)
			{
				ArchiveLabel = other.ArchiveLabel;
			}
			if (other.TargetRebirthPointId != 0)
			{
				TargetRebirthPointId = other.TargetRebirthPointId;
			}
			if (other.DontResetPlayerState)
			{
				DontResetPlayerState = other.DontResetPlayerState;
			}
			if (other.LoadingScreenType != 0)
			{
				LoadingScreenType = other.LoadingScreenType;
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
			case 10u:
				PointName = input.ReadString();
				break;
			case 16u:
				IsDropTeleportPoint = input.ReadBool();
				break;
			case 26u:
				DroppedTeleportPointId = input.ReadString();
				break;
			case 34u:
				BeforeTeleportMontagePath = input.ReadString();
				break;
			case 42u:
				AfterTeleportMontagePath = input.ReadString();
				break;
			case 48u:
				IsTeleportToOtherLevel = input.ReadBool();
				break;
			case 56u:
				TargetLevelId = input.ReadInt32();
				break;
			case 64u:
				IsSaveArchiveAfterTeleport = input.ReadBool();
				break;
			case 74u:
				ArchiveLabel = input.ReadString();
				break;
			case 80u:
				TargetRebirthPointId = input.ReadInt32();
				break;
			case 88u:
				DontResetPlayerState = input.ReadBool();
				break;
			case 96u:
				LoadingScreenType = input.ReadInt32();
				break;
			}
		}
	}
}
