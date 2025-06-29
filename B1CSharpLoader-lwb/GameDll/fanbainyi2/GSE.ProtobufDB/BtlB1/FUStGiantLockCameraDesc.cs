using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStGiantLockCameraDesc : IMessage<FUStGiantLockCameraDesc>, IMessage, IEquatable<FUStGiantLockCameraDesc>, IDeepCloneable<FUStGiantLockCameraDesc>
{
	private static readonly MessageParser<FUStGiantLockCameraDesc> _parser = new MessageParser<FUStGiantLockCameraDesc>(() => new FUStGiantLockCameraDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int camID_;

	private int playerUnitResID_;

	private float armLength_;

	private float armLengthSpeed_;

	private float targetRefHeightOffset_;

	private float playerRefHeightOffset_;

	private float targetRefHeightOffsetSpeed_;

	private float playerRefHeightOffsetSpeed_;

	private float targetHeightThreshold_;

	private float minPitch_;

	private float maxPitch_;

	private float pitchLerpSpeed_;

	private float targetScreenMaxRatio_;

	private float playerScreenRatio_;

	private float cameraOffsetLerpSpeed_;

	private string targetRefHeightOffsetCurve_ = "";

	public static MessageParser<FUStGiantLockCameraDesc> Parser => _parser;

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

	public int CamID
	{
		get
		{
			return camID_;
		}
		set
		{
			camID_ = value;
		}
	}

	public int PlayerUnitResID
	{
		get
		{
			return playerUnitResID_;
		}
		set
		{
			playerUnitResID_ = value;
		}
	}

	public float ArmLength
	{
		get
		{
			return armLength_;
		}
		set
		{
			armLength_ = value;
		}
	}

	public float ArmLengthSpeed
	{
		get
		{
			return armLengthSpeed_;
		}
		set
		{
			armLengthSpeed_ = value;
		}
	}

	public float TargetRefHeightOffset
	{
		get
		{
			return targetRefHeightOffset_;
		}
		set
		{
			targetRefHeightOffset_ = value;
		}
	}

	public float PlayerRefHeightOffset
	{
		get
		{
			return playerRefHeightOffset_;
		}
		set
		{
			playerRefHeightOffset_ = value;
		}
	}

	public float TargetRefHeightOffsetSpeed
	{
		get
		{
			return targetRefHeightOffsetSpeed_;
		}
		set
		{
			targetRefHeightOffsetSpeed_ = value;
		}
	}

	public float PlayerRefHeightOffsetSpeed
	{
		get
		{
			return playerRefHeightOffsetSpeed_;
		}
		set
		{
			playerRefHeightOffsetSpeed_ = value;
		}
	}

	public float TargetHeightThreshold
	{
		get
		{
			return targetHeightThreshold_;
		}
		set
		{
			targetHeightThreshold_ = value;
		}
	}

	public float MinPitch
	{
		get
		{
			return minPitch_;
		}
		set
		{
			minPitch_ = value;
		}
	}

	public float MaxPitch
	{
		get
		{
			return maxPitch_;
		}
		set
		{
			maxPitch_ = value;
		}
	}

	public float PitchLerpSpeed
	{
		get
		{
			return pitchLerpSpeed_;
		}
		set
		{
			pitchLerpSpeed_ = value;
		}
	}

	public float TargetScreenMaxRatio
	{
		get
		{
			return targetScreenMaxRatio_;
		}
		set
		{
			targetScreenMaxRatio_ = value;
		}
	}

	public float PlayerScreenRatio
	{
		get
		{
			return playerScreenRatio_;
		}
		set
		{
			playerScreenRatio_ = value;
		}
	}

	public float CameraOffsetLerpSpeed
	{
		get
		{
			return cameraOffsetLerpSpeed_;
		}
		set
		{
			cameraOffsetLerpSpeed_ = value;
		}
	}

	public string TargetRefHeightOffsetCurve
	{
		get
		{
			return targetRefHeightOffsetCurve_;
		}
		set
		{
			targetRefHeightOffsetCurve_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStGiantLockCameraDesc()
	{
	}

	public FUStGiantLockCameraDesc(FUStGiantLockCameraDesc other)
		: this()
	{
		iD_ = other.iD_;
		camID_ = other.camID_;
		playerUnitResID_ = other.playerUnitResID_;
		armLength_ = other.armLength_;
		armLengthSpeed_ = other.armLengthSpeed_;
		targetRefHeightOffset_ = other.targetRefHeightOffset_;
		playerRefHeightOffset_ = other.playerRefHeightOffset_;
		targetRefHeightOffsetSpeed_ = other.targetRefHeightOffsetSpeed_;
		playerRefHeightOffsetSpeed_ = other.playerRefHeightOffsetSpeed_;
		targetHeightThreshold_ = other.targetHeightThreshold_;
		minPitch_ = other.minPitch_;
		maxPitch_ = other.maxPitch_;
		pitchLerpSpeed_ = other.pitchLerpSpeed_;
		targetScreenMaxRatio_ = other.targetScreenMaxRatio_;
		playerScreenRatio_ = other.playerScreenRatio_;
		cameraOffsetLerpSpeed_ = other.cameraOffsetLerpSpeed_;
		targetRefHeightOffsetCurve_ = other.targetRefHeightOffsetCurve_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStGiantLockCameraDesc Clone()
	{
		return new FUStGiantLockCameraDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStGiantLockCameraDesc);
	}

	public bool Equals(FUStGiantLockCameraDesc other)
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
		if (CamID != other.CamID)
		{
			return false;
		}
		if (PlayerUnitResID != other.PlayerUnitResID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmLength, other.ArmLength))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmLengthSpeed, other.ArmLengthSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TargetRefHeightOffset, other.TargetRefHeightOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerRefHeightOffset, other.PlayerRefHeightOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TargetRefHeightOffsetSpeed, other.TargetRefHeightOffsetSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerRefHeightOffsetSpeed, other.PlayerRefHeightOffsetSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TargetHeightThreshold, other.TargetHeightThreshold))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinPitch, other.MinPitch))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxPitch, other.MaxPitch))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PitchLerpSpeed, other.PitchLerpSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TargetScreenMaxRatio, other.TargetScreenMaxRatio))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerScreenRatio, other.PlayerScreenRatio))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraOffsetLerpSpeed, other.CameraOffsetLerpSpeed))
		{
			return false;
		}
		if (TargetRefHeightOffsetCurve != other.TargetRefHeightOffsetCurve)
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
		if (CamID != 0)
		{
			num ^= CamID.GetHashCode();
		}
		if (PlayerUnitResID != 0)
		{
			num ^= PlayerUnitResID.GetHashCode();
		}
		if (ArmLength != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmLength);
		}
		if (ArmLengthSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmLengthSpeed);
		}
		if (TargetRefHeightOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TargetRefHeightOffset);
		}
		if (PlayerRefHeightOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerRefHeightOffset);
		}
		if (TargetRefHeightOffsetSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TargetRefHeightOffsetSpeed);
		}
		if (PlayerRefHeightOffsetSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerRefHeightOffsetSpeed);
		}
		if (TargetHeightThreshold != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TargetHeightThreshold);
		}
		if (MinPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinPitch);
		}
		if (MaxPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxPitch);
		}
		if (PitchLerpSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PitchLerpSpeed);
		}
		if (TargetScreenMaxRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TargetScreenMaxRatio);
		}
		if (PlayerScreenRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerScreenRatio);
		}
		if (CameraOffsetLerpSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraOffsetLerpSpeed);
		}
		if (TargetRefHeightOffsetCurve.Length != 0)
		{
			num ^= TargetRefHeightOffsetCurve.GetHashCode();
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
		if (CamID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CamID);
		}
		if (PlayerUnitResID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PlayerUnitResID);
		}
		if (ArmLength != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(ArmLength);
		}
		if (ArmLengthSpeed != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(ArmLengthSpeed);
		}
		if (TargetRefHeightOffset != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(TargetRefHeightOffset);
		}
		if (PlayerRefHeightOffset != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(PlayerRefHeightOffset);
		}
		if (TargetRefHeightOffsetSpeed != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(TargetRefHeightOffsetSpeed);
		}
		if (PlayerRefHeightOffsetSpeed != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(PlayerRefHeightOffsetSpeed);
		}
		if (TargetHeightThreshold != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(TargetHeightThreshold);
		}
		if (MinPitch != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(MinPitch);
		}
		if (MaxPitch != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(MaxPitch);
		}
		if (PitchLerpSpeed != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(PitchLerpSpeed);
		}
		if (TargetScreenMaxRatio != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(TargetScreenMaxRatio);
		}
		if (PlayerScreenRatio != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(PlayerScreenRatio);
		}
		if (CameraOffsetLerpSpeed != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(CameraOffsetLerpSpeed);
		}
		if (TargetRefHeightOffsetCurve.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(TargetRefHeightOffsetCurve);
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
		if (CamID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CamID);
		}
		if (PlayerUnitResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayerUnitResID);
		}
		if (ArmLength != 0f)
		{
			num += 5;
		}
		if (ArmLengthSpeed != 0f)
		{
			num += 5;
		}
		if (TargetRefHeightOffset != 0f)
		{
			num += 5;
		}
		if (PlayerRefHeightOffset != 0f)
		{
			num += 5;
		}
		if (TargetRefHeightOffsetSpeed != 0f)
		{
			num += 5;
		}
		if (PlayerRefHeightOffsetSpeed != 0f)
		{
			num += 5;
		}
		if (TargetHeightThreshold != 0f)
		{
			num += 5;
		}
		if (MinPitch != 0f)
		{
			num += 5;
		}
		if (MaxPitch != 0f)
		{
			num += 5;
		}
		if (PitchLerpSpeed != 0f)
		{
			num += 5;
		}
		if (TargetScreenMaxRatio != 0f)
		{
			num += 5;
		}
		if (PlayerScreenRatio != 0f)
		{
			num += 5;
		}
		if (CameraOffsetLerpSpeed != 0f)
		{
			num += 6;
		}
		if (TargetRefHeightOffsetCurve.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(TargetRefHeightOffsetCurve);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStGiantLockCameraDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.CamID != 0)
			{
				CamID = other.CamID;
			}
			if (other.PlayerUnitResID != 0)
			{
				PlayerUnitResID = other.PlayerUnitResID;
			}
			if (other.ArmLength != 0f)
			{
				ArmLength = other.ArmLength;
			}
			if (other.ArmLengthSpeed != 0f)
			{
				ArmLengthSpeed = other.ArmLengthSpeed;
			}
			if (other.TargetRefHeightOffset != 0f)
			{
				TargetRefHeightOffset = other.TargetRefHeightOffset;
			}
			if (other.PlayerRefHeightOffset != 0f)
			{
				PlayerRefHeightOffset = other.PlayerRefHeightOffset;
			}
			if (other.TargetRefHeightOffsetSpeed != 0f)
			{
				TargetRefHeightOffsetSpeed = other.TargetRefHeightOffsetSpeed;
			}
			if (other.PlayerRefHeightOffsetSpeed != 0f)
			{
				PlayerRefHeightOffsetSpeed = other.PlayerRefHeightOffsetSpeed;
			}
			if (other.TargetHeightThreshold != 0f)
			{
				TargetHeightThreshold = other.TargetHeightThreshold;
			}
			if (other.MinPitch != 0f)
			{
				MinPitch = other.MinPitch;
			}
			if (other.MaxPitch != 0f)
			{
				MaxPitch = other.MaxPitch;
			}
			if (other.PitchLerpSpeed != 0f)
			{
				PitchLerpSpeed = other.PitchLerpSpeed;
			}
			if (other.TargetScreenMaxRatio != 0f)
			{
				TargetScreenMaxRatio = other.TargetScreenMaxRatio;
			}
			if (other.PlayerScreenRatio != 0f)
			{
				PlayerScreenRatio = other.PlayerScreenRatio;
			}
			if (other.CameraOffsetLerpSpeed != 0f)
			{
				CameraOffsetLerpSpeed = other.CameraOffsetLerpSpeed;
			}
			if (other.TargetRefHeightOffsetCurve.Length != 0)
			{
				TargetRefHeightOffsetCurve = other.TargetRefHeightOffsetCurve;
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
				CamID = input.ReadInt32();
				break;
			case 24u:
				PlayerUnitResID = input.ReadInt32();
				break;
			case 37u:
				ArmLength = input.ReadFloat();
				break;
			case 45u:
				ArmLengthSpeed = input.ReadFloat();
				break;
			case 53u:
				TargetRefHeightOffset = input.ReadFloat();
				break;
			case 61u:
				PlayerRefHeightOffset = input.ReadFloat();
				break;
			case 69u:
				TargetRefHeightOffsetSpeed = input.ReadFloat();
				break;
			case 77u:
				PlayerRefHeightOffsetSpeed = input.ReadFloat();
				break;
			case 85u:
				TargetHeightThreshold = input.ReadFloat();
				break;
			case 93u:
				MinPitch = input.ReadFloat();
				break;
			case 101u:
				MaxPitch = input.ReadFloat();
				break;
			case 109u:
				PitchLerpSpeed = input.ReadFloat();
				break;
			case 117u:
				TargetScreenMaxRatio = input.ReadFloat();
				break;
			case 125u:
				PlayerScreenRatio = input.ReadFloat();
				break;
			case 133u:
				CameraOffsetLerpSpeed = input.ReadFloat();
				break;
			case 138u:
				TargetRefHeightOffsetCurve = input.ReadString();
				break;
			}
		}
	}
}
