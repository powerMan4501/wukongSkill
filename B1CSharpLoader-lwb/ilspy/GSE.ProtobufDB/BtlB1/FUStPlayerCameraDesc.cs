using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPlayerCameraDesc : IMessage<FUStPlayerCameraDesc>, IMessage, IEquatable<FUStPlayerCameraDesc>, IDeepCloneable<FUStPlayerCameraDesc>
{
	private static readonly MessageParser<FUStPlayerCameraDesc> _parser = new MessageParser<FUStPlayerCameraDesc>(() => new FUStPlayerCameraDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private int camID_;

	private float armLengthDefault_;

	private float armLengthClose_;

	private float armLengthMid_;

	private float armLengthFar_;

	private float armLengthSpeed_;

	private float freeCameraArmLengthMin_;

	private float freeCameraArmLengthMax_;

	private float armRelativeLocationX_;

	private float armRelativeLocationY_;

	private float armRelativeLocationZ_;

	private float armRelativeLocationSpeed_;

	private float armSocketOffsetX_;

	private float armSocketOffsetY_;

	private float armSocketOffsetZ_;

	private float armSocketOffsetSpeed_;

	private float inverseOffsetX_;

	private float inverseOffsetSpeedX_;

	private float inverseOffsetResetSpeedX_;

	private float inverseOffsetY_;

	private float inverseOffsetSpeedY_;

	private float inverseOffsetResetSpeedY_;

	private float inverseOffsetZ_;

	private float inverseOffsetSpeedZ_;

	private float inverseOffsetResetSpeedZ_;

	private float meshZOffsetLimit_;

	private float focalDistance_;

	private float depthBlurKM_;

	private float depthBlurRadius_;

	private float fOV_;

	private float fOVSpeed_;

	private float minPitch_;

	private float maxPitch_;

	private float minYaw_;

	private float maxYaw_;

	public static MessageParser<FUStPlayerCameraDesc> Parser => _parser;

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

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
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

	public float ArmLengthDefault
	{
		get
		{
			return armLengthDefault_;
		}
		set
		{
			armLengthDefault_ = value;
		}
	}

	public float ArmLengthClose
	{
		get
		{
			return armLengthClose_;
		}
		set
		{
			armLengthClose_ = value;
		}
	}

	public float ArmLengthMid
	{
		get
		{
			return armLengthMid_;
		}
		set
		{
			armLengthMid_ = value;
		}
	}

	public float ArmLengthFar
	{
		get
		{
			return armLengthFar_;
		}
		set
		{
			armLengthFar_ = value;
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

	public float FreeCameraArmLengthMin
	{
		get
		{
			return freeCameraArmLengthMin_;
		}
		set
		{
			freeCameraArmLengthMin_ = value;
		}
	}

	public float FreeCameraArmLengthMax
	{
		get
		{
			return freeCameraArmLengthMax_;
		}
		set
		{
			freeCameraArmLengthMax_ = value;
		}
	}

	public float ArmRelativeLocationX
	{
		get
		{
			return armRelativeLocationX_;
		}
		set
		{
			armRelativeLocationX_ = value;
		}
	}

	public float ArmRelativeLocationY
	{
		get
		{
			return armRelativeLocationY_;
		}
		set
		{
			armRelativeLocationY_ = value;
		}
	}

	public float ArmRelativeLocationZ
	{
		get
		{
			return armRelativeLocationZ_;
		}
		set
		{
			armRelativeLocationZ_ = value;
		}
	}

	public float ArmRelativeLocationSpeed
	{
		get
		{
			return armRelativeLocationSpeed_;
		}
		set
		{
			armRelativeLocationSpeed_ = value;
		}
	}

	public float ArmSocketOffsetX
	{
		get
		{
			return armSocketOffsetX_;
		}
		set
		{
			armSocketOffsetX_ = value;
		}
	}

	public float ArmSocketOffsetY
	{
		get
		{
			return armSocketOffsetY_;
		}
		set
		{
			armSocketOffsetY_ = value;
		}
	}

	public float ArmSocketOffsetZ
	{
		get
		{
			return armSocketOffsetZ_;
		}
		set
		{
			armSocketOffsetZ_ = value;
		}
	}

	public float ArmSocketOffsetSpeed
	{
		get
		{
			return armSocketOffsetSpeed_;
		}
		set
		{
			armSocketOffsetSpeed_ = value;
		}
	}

	public float InverseOffsetX
	{
		get
		{
			return inverseOffsetX_;
		}
		set
		{
			inverseOffsetX_ = value;
		}
	}

	public float InverseOffsetSpeedX
	{
		get
		{
			return inverseOffsetSpeedX_;
		}
		set
		{
			inverseOffsetSpeedX_ = value;
		}
	}

	public float InverseOffsetResetSpeedX
	{
		get
		{
			return inverseOffsetResetSpeedX_;
		}
		set
		{
			inverseOffsetResetSpeedX_ = value;
		}
	}

	public float InverseOffsetY
	{
		get
		{
			return inverseOffsetY_;
		}
		set
		{
			inverseOffsetY_ = value;
		}
	}

	public float InverseOffsetSpeedY
	{
		get
		{
			return inverseOffsetSpeedY_;
		}
		set
		{
			inverseOffsetSpeedY_ = value;
		}
	}

	public float InverseOffsetResetSpeedY
	{
		get
		{
			return inverseOffsetResetSpeedY_;
		}
		set
		{
			inverseOffsetResetSpeedY_ = value;
		}
	}

	public float InverseOffsetZ
	{
		get
		{
			return inverseOffsetZ_;
		}
		set
		{
			inverseOffsetZ_ = value;
		}
	}

	public float InverseOffsetSpeedZ
	{
		get
		{
			return inverseOffsetSpeedZ_;
		}
		set
		{
			inverseOffsetSpeedZ_ = value;
		}
	}

	public float InverseOffsetResetSpeedZ
	{
		get
		{
			return inverseOffsetResetSpeedZ_;
		}
		set
		{
			inverseOffsetResetSpeedZ_ = value;
		}
	}

	public float MeshZOffsetLimit
	{
		get
		{
			return meshZOffsetLimit_;
		}
		set
		{
			meshZOffsetLimit_ = value;
		}
	}

	public float FocalDistance
	{
		get
		{
			return focalDistance_;
		}
		set
		{
			focalDistance_ = value;
		}
	}

	public float DepthBlurKM
	{
		get
		{
			return depthBlurKM_;
		}
		set
		{
			depthBlurKM_ = value;
		}
	}

	public float DepthBlurRadius
	{
		get
		{
			return depthBlurRadius_;
		}
		set
		{
			depthBlurRadius_ = value;
		}
	}

	public float FOV
	{
		get
		{
			return fOV_;
		}
		set
		{
			fOV_ = value;
		}
	}

	public float FOVSpeed
	{
		get
		{
			return fOVSpeed_;
		}
		set
		{
			fOVSpeed_ = value;
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

	public float MinYaw
	{
		get
		{
			return minYaw_;
		}
		set
		{
			minYaw_ = value;
		}
	}

	public float MaxYaw
	{
		get
		{
			return maxYaw_;
		}
		set
		{
			maxYaw_ = value;
		}
	}

	public FUStPlayerCameraDesc()
	{
	}

	public FUStPlayerCameraDesc(FUStPlayerCameraDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		camID_ = other.camID_;
		armLengthDefault_ = other.armLengthDefault_;
		armLengthClose_ = other.armLengthClose_;
		armLengthMid_ = other.armLengthMid_;
		armLengthFar_ = other.armLengthFar_;
		armLengthSpeed_ = other.armLengthSpeed_;
		freeCameraArmLengthMin_ = other.freeCameraArmLengthMin_;
		freeCameraArmLengthMax_ = other.freeCameraArmLengthMax_;
		armRelativeLocationX_ = other.armRelativeLocationX_;
		armRelativeLocationY_ = other.armRelativeLocationY_;
		armRelativeLocationZ_ = other.armRelativeLocationZ_;
		armRelativeLocationSpeed_ = other.armRelativeLocationSpeed_;
		armSocketOffsetX_ = other.armSocketOffsetX_;
		armSocketOffsetY_ = other.armSocketOffsetY_;
		armSocketOffsetZ_ = other.armSocketOffsetZ_;
		armSocketOffsetSpeed_ = other.armSocketOffsetSpeed_;
		inverseOffsetX_ = other.inverseOffsetX_;
		inverseOffsetSpeedX_ = other.inverseOffsetSpeedX_;
		inverseOffsetResetSpeedX_ = other.inverseOffsetResetSpeedX_;
		inverseOffsetY_ = other.inverseOffsetY_;
		inverseOffsetSpeedY_ = other.inverseOffsetSpeedY_;
		inverseOffsetResetSpeedY_ = other.inverseOffsetResetSpeedY_;
		inverseOffsetZ_ = other.inverseOffsetZ_;
		inverseOffsetSpeedZ_ = other.inverseOffsetSpeedZ_;
		inverseOffsetResetSpeedZ_ = other.inverseOffsetResetSpeedZ_;
		meshZOffsetLimit_ = other.meshZOffsetLimit_;
		focalDistance_ = other.focalDistance_;
		depthBlurKM_ = other.depthBlurKM_;
		depthBlurRadius_ = other.depthBlurRadius_;
		fOV_ = other.fOV_;
		fOVSpeed_ = other.fOVSpeed_;
		minPitch_ = other.minPitch_;
		maxPitch_ = other.maxPitch_;
		minYaw_ = other.minYaw_;
		maxYaw_ = other.maxYaw_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPlayerCameraDesc Clone()
	{
		return new FUStPlayerCameraDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPlayerCameraDesc);
	}

	public bool Equals(FUStPlayerCameraDesc other)
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
		if (ResID != other.ResID)
		{
			return false;
		}
		if (CamID != other.CamID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmLengthDefault, other.ArmLengthDefault))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmLengthClose, other.ArmLengthClose))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmLengthMid, other.ArmLengthMid))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmLengthFar, other.ArmLengthFar))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmLengthSpeed, other.ArmLengthSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FreeCameraArmLengthMin, other.FreeCameraArmLengthMin))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FreeCameraArmLengthMax, other.FreeCameraArmLengthMax))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmRelativeLocationX, other.ArmRelativeLocationX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmRelativeLocationY, other.ArmRelativeLocationY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmRelativeLocationZ, other.ArmRelativeLocationZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmRelativeLocationSpeed, other.ArmRelativeLocationSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmSocketOffsetX, other.ArmSocketOffsetX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmSocketOffsetY, other.ArmSocketOffsetY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmSocketOffsetZ, other.ArmSocketOffsetZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmSocketOffsetSpeed, other.ArmSocketOffsetSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InverseOffsetX, other.InverseOffsetX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InverseOffsetSpeedX, other.InverseOffsetSpeedX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InverseOffsetResetSpeedX, other.InverseOffsetResetSpeedX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InverseOffsetY, other.InverseOffsetY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InverseOffsetSpeedY, other.InverseOffsetSpeedY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InverseOffsetResetSpeedY, other.InverseOffsetResetSpeedY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InverseOffsetZ, other.InverseOffsetZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InverseOffsetSpeedZ, other.InverseOffsetSpeedZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InverseOffsetResetSpeedZ, other.InverseOffsetResetSpeedZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MeshZOffsetLimit, other.MeshZOffsetLimit))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FocalDistance, other.FocalDistance))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DepthBlurKM, other.DepthBlurKM))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DepthBlurRadius, other.DepthBlurRadius))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FOV, other.FOV))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FOVSpeed, other.FOVSpeed))
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinYaw, other.MinYaw))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxYaw, other.MaxYaw))
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
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (CamID != 0)
		{
			num ^= CamID.GetHashCode();
		}
		if (ArmLengthDefault != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmLengthDefault);
		}
		if (ArmLengthClose != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmLengthClose);
		}
		if (ArmLengthMid != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmLengthMid);
		}
		if (ArmLengthFar != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmLengthFar);
		}
		if (ArmLengthSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmLengthSpeed);
		}
		if (FreeCameraArmLengthMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FreeCameraArmLengthMin);
		}
		if (FreeCameraArmLengthMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FreeCameraArmLengthMax);
		}
		if (ArmRelativeLocationX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmRelativeLocationX);
		}
		if (ArmRelativeLocationY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmRelativeLocationY);
		}
		if (ArmRelativeLocationZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmRelativeLocationZ);
		}
		if (ArmRelativeLocationSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmRelativeLocationSpeed);
		}
		if (ArmSocketOffsetX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmSocketOffsetX);
		}
		if (ArmSocketOffsetY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmSocketOffsetY);
		}
		if (ArmSocketOffsetZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmSocketOffsetZ);
		}
		if (ArmSocketOffsetSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmSocketOffsetSpeed);
		}
		if (InverseOffsetX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InverseOffsetX);
		}
		if (InverseOffsetSpeedX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InverseOffsetSpeedX);
		}
		if (InverseOffsetResetSpeedX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InverseOffsetResetSpeedX);
		}
		if (InverseOffsetY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InverseOffsetY);
		}
		if (InverseOffsetSpeedY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InverseOffsetSpeedY);
		}
		if (InverseOffsetResetSpeedY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InverseOffsetResetSpeedY);
		}
		if (InverseOffsetZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InverseOffsetZ);
		}
		if (InverseOffsetSpeedZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InverseOffsetSpeedZ);
		}
		if (InverseOffsetResetSpeedZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InverseOffsetResetSpeedZ);
		}
		if (MeshZOffsetLimit != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MeshZOffsetLimit);
		}
		if (FocalDistance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FocalDistance);
		}
		if (DepthBlurKM != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DepthBlurKM);
		}
		if (DepthBlurRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DepthBlurRadius);
		}
		if (FOV != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FOV);
		}
		if (FOVSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FOVSpeed);
		}
		if (MinPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinPitch);
		}
		if (MaxPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxPitch);
		}
		if (MinYaw != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinYaw);
		}
		if (MaxYaw != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxYaw);
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
		if (ResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResID);
		}
		if (CamID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CamID);
		}
		if (ArmLengthDefault != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(ArmLengthDefault);
		}
		if (ArmLengthClose != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(ArmLengthClose);
		}
		if (ArmLengthMid != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(ArmLengthMid);
		}
		if (ArmLengthFar != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(ArmLengthFar);
		}
		if (ArmLengthSpeed != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(ArmLengthSpeed);
		}
		if (FreeCameraArmLengthMin != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(FreeCameraArmLengthMin);
		}
		if (FreeCameraArmLengthMax != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(FreeCameraArmLengthMax);
		}
		if (ArmRelativeLocationX != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(ArmRelativeLocationX);
		}
		if (ArmRelativeLocationY != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(ArmRelativeLocationY);
		}
		if (ArmRelativeLocationZ != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(ArmRelativeLocationZ);
		}
		if (ArmRelativeLocationSpeed != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(ArmRelativeLocationSpeed);
		}
		if (ArmSocketOffsetX != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(ArmSocketOffsetX);
		}
		if (ArmSocketOffsetY != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(ArmSocketOffsetY);
		}
		if (ArmSocketOffsetZ != 0f)
		{
			output.WriteRawTag(141, 1);
			output.WriteFloat(ArmSocketOffsetZ);
		}
		if (ArmSocketOffsetSpeed != 0f)
		{
			output.WriteRawTag(149, 1);
			output.WriteFloat(ArmSocketOffsetSpeed);
		}
		if (InverseOffsetX != 0f)
		{
			output.WriteRawTag(157, 1);
			output.WriteFloat(InverseOffsetX);
		}
		if (InverseOffsetSpeedX != 0f)
		{
			output.WriteRawTag(165, 1);
			output.WriteFloat(InverseOffsetSpeedX);
		}
		if (InverseOffsetResetSpeedX != 0f)
		{
			output.WriteRawTag(173, 1);
			output.WriteFloat(InverseOffsetResetSpeedX);
		}
		if (InverseOffsetY != 0f)
		{
			output.WriteRawTag(181, 1);
			output.WriteFloat(InverseOffsetY);
		}
		if (InverseOffsetSpeedY != 0f)
		{
			output.WriteRawTag(189, 1);
			output.WriteFloat(InverseOffsetSpeedY);
		}
		if (InverseOffsetResetSpeedY != 0f)
		{
			output.WriteRawTag(197, 1);
			output.WriteFloat(InverseOffsetResetSpeedY);
		}
		if (InverseOffsetZ != 0f)
		{
			output.WriteRawTag(205, 1);
			output.WriteFloat(InverseOffsetZ);
		}
		if (InverseOffsetSpeedZ != 0f)
		{
			output.WriteRawTag(213, 1);
			output.WriteFloat(InverseOffsetSpeedZ);
		}
		if (InverseOffsetResetSpeedZ != 0f)
		{
			output.WriteRawTag(221, 1);
			output.WriteFloat(InverseOffsetResetSpeedZ);
		}
		if (MeshZOffsetLimit != 0f)
		{
			output.WriteRawTag(229, 1);
			output.WriteFloat(MeshZOffsetLimit);
		}
		if (FocalDistance != 0f)
		{
			output.WriteRawTag(237, 1);
			output.WriteFloat(FocalDistance);
		}
		if (DepthBlurKM != 0f)
		{
			output.WriteRawTag(245, 1);
			output.WriteFloat(DepthBlurKM);
		}
		if (DepthBlurRadius != 0f)
		{
			output.WriteRawTag(253, 1);
			output.WriteFloat(DepthBlurRadius);
		}
		if (FOV != 0f)
		{
			output.WriteRawTag(133, 2);
			output.WriteFloat(FOV);
		}
		if (FOVSpeed != 0f)
		{
			output.WriteRawTag(141, 2);
			output.WriteFloat(FOVSpeed);
		}
		if (MinPitch != 0f)
		{
			output.WriteRawTag(149, 2);
			output.WriteFloat(MinPitch);
		}
		if (MaxPitch != 0f)
		{
			output.WriteRawTag(157, 2);
			output.WriteFloat(MaxPitch);
		}
		if (MinYaw != 0f)
		{
			output.WriteRawTag(165, 2);
			output.WriteFloat(MinYaw);
		}
		if (MaxYaw != 0f)
		{
			output.WriteRawTag(173, 2);
			output.WriteFloat(MaxYaw);
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
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (CamID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CamID);
		}
		if (ArmLengthDefault != 0f)
		{
			num += 5;
		}
		if (ArmLengthClose != 0f)
		{
			num += 5;
		}
		if (ArmLengthMid != 0f)
		{
			num += 5;
		}
		if (ArmLengthFar != 0f)
		{
			num += 5;
		}
		if (ArmLengthSpeed != 0f)
		{
			num += 5;
		}
		if (FreeCameraArmLengthMin != 0f)
		{
			num += 5;
		}
		if (FreeCameraArmLengthMax != 0f)
		{
			num += 5;
		}
		if (ArmRelativeLocationX != 0f)
		{
			num += 5;
		}
		if (ArmRelativeLocationY != 0f)
		{
			num += 5;
		}
		if (ArmRelativeLocationZ != 0f)
		{
			num += 5;
		}
		if (ArmRelativeLocationSpeed != 0f)
		{
			num += 5;
		}
		if (ArmSocketOffsetX != 0f)
		{
			num += 5;
		}
		if (ArmSocketOffsetY != 0f)
		{
			num += 6;
		}
		if (ArmSocketOffsetZ != 0f)
		{
			num += 6;
		}
		if (ArmSocketOffsetSpeed != 0f)
		{
			num += 6;
		}
		if (InverseOffsetX != 0f)
		{
			num += 6;
		}
		if (InverseOffsetSpeedX != 0f)
		{
			num += 6;
		}
		if (InverseOffsetResetSpeedX != 0f)
		{
			num += 6;
		}
		if (InverseOffsetY != 0f)
		{
			num += 6;
		}
		if (InverseOffsetSpeedY != 0f)
		{
			num += 6;
		}
		if (InverseOffsetResetSpeedY != 0f)
		{
			num += 6;
		}
		if (InverseOffsetZ != 0f)
		{
			num += 6;
		}
		if (InverseOffsetSpeedZ != 0f)
		{
			num += 6;
		}
		if (InverseOffsetResetSpeedZ != 0f)
		{
			num += 6;
		}
		if (MeshZOffsetLimit != 0f)
		{
			num += 6;
		}
		if (FocalDistance != 0f)
		{
			num += 6;
		}
		if (DepthBlurKM != 0f)
		{
			num += 6;
		}
		if (DepthBlurRadius != 0f)
		{
			num += 6;
		}
		if (FOV != 0f)
		{
			num += 6;
		}
		if (FOVSpeed != 0f)
		{
			num += 6;
		}
		if (MinPitch != 0f)
		{
			num += 6;
		}
		if (MaxPitch != 0f)
		{
			num += 6;
		}
		if (MinYaw != 0f)
		{
			num += 6;
		}
		if (MaxYaw != 0f)
		{
			num += 6;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPlayerCameraDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.CamID != 0)
			{
				CamID = other.CamID;
			}
			if (other.ArmLengthDefault != 0f)
			{
				ArmLengthDefault = other.ArmLengthDefault;
			}
			if (other.ArmLengthClose != 0f)
			{
				ArmLengthClose = other.ArmLengthClose;
			}
			if (other.ArmLengthMid != 0f)
			{
				ArmLengthMid = other.ArmLengthMid;
			}
			if (other.ArmLengthFar != 0f)
			{
				ArmLengthFar = other.ArmLengthFar;
			}
			if (other.ArmLengthSpeed != 0f)
			{
				ArmLengthSpeed = other.ArmLengthSpeed;
			}
			if (other.FreeCameraArmLengthMin != 0f)
			{
				FreeCameraArmLengthMin = other.FreeCameraArmLengthMin;
			}
			if (other.FreeCameraArmLengthMax != 0f)
			{
				FreeCameraArmLengthMax = other.FreeCameraArmLengthMax;
			}
			if (other.ArmRelativeLocationX != 0f)
			{
				ArmRelativeLocationX = other.ArmRelativeLocationX;
			}
			if (other.ArmRelativeLocationY != 0f)
			{
				ArmRelativeLocationY = other.ArmRelativeLocationY;
			}
			if (other.ArmRelativeLocationZ != 0f)
			{
				ArmRelativeLocationZ = other.ArmRelativeLocationZ;
			}
			if (other.ArmRelativeLocationSpeed != 0f)
			{
				ArmRelativeLocationSpeed = other.ArmRelativeLocationSpeed;
			}
			if (other.ArmSocketOffsetX != 0f)
			{
				ArmSocketOffsetX = other.ArmSocketOffsetX;
			}
			if (other.ArmSocketOffsetY != 0f)
			{
				ArmSocketOffsetY = other.ArmSocketOffsetY;
			}
			if (other.ArmSocketOffsetZ != 0f)
			{
				ArmSocketOffsetZ = other.ArmSocketOffsetZ;
			}
			if (other.ArmSocketOffsetSpeed != 0f)
			{
				ArmSocketOffsetSpeed = other.ArmSocketOffsetSpeed;
			}
			if (other.InverseOffsetX != 0f)
			{
				InverseOffsetX = other.InverseOffsetX;
			}
			if (other.InverseOffsetSpeedX != 0f)
			{
				InverseOffsetSpeedX = other.InverseOffsetSpeedX;
			}
			if (other.InverseOffsetResetSpeedX != 0f)
			{
				InverseOffsetResetSpeedX = other.InverseOffsetResetSpeedX;
			}
			if (other.InverseOffsetY != 0f)
			{
				InverseOffsetY = other.InverseOffsetY;
			}
			if (other.InverseOffsetSpeedY != 0f)
			{
				InverseOffsetSpeedY = other.InverseOffsetSpeedY;
			}
			if (other.InverseOffsetResetSpeedY != 0f)
			{
				InverseOffsetResetSpeedY = other.InverseOffsetResetSpeedY;
			}
			if (other.InverseOffsetZ != 0f)
			{
				InverseOffsetZ = other.InverseOffsetZ;
			}
			if (other.InverseOffsetSpeedZ != 0f)
			{
				InverseOffsetSpeedZ = other.InverseOffsetSpeedZ;
			}
			if (other.InverseOffsetResetSpeedZ != 0f)
			{
				InverseOffsetResetSpeedZ = other.InverseOffsetResetSpeedZ;
			}
			if (other.MeshZOffsetLimit != 0f)
			{
				MeshZOffsetLimit = other.MeshZOffsetLimit;
			}
			if (other.FocalDistance != 0f)
			{
				FocalDistance = other.FocalDistance;
			}
			if (other.DepthBlurKM != 0f)
			{
				DepthBlurKM = other.DepthBlurKM;
			}
			if (other.DepthBlurRadius != 0f)
			{
				DepthBlurRadius = other.DepthBlurRadius;
			}
			if (other.FOV != 0f)
			{
				FOV = other.FOV;
			}
			if (other.FOVSpeed != 0f)
			{
				FOVSpeed = other.FOVSpeed;
			}
			if (other.MinPitch != 0f)
			{
				MinPitch = other.MinPitch;
			}
			if (other.MaxPitch != 0f)
			{
				MaxPitch = other.MaxPitch;
			}
			if (other.MinYaw != 0f)
			{
				MinYaw = other.MinYaw;
			}
			if (other.MaxYaw != 0f)
			{
				MaxYaw = other.MaxYaw;
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
				ResID = input.ReadInt32();
				break;
			case 24u:
				CamID = input.ReadInt32();
				break;
			case 37u:
				ArmLengthDefault = input.ReadFloat();
				break;
			case 45u:
				ArmLengthClose = input.ReadFloat();
				break;
			case 53u:
				ArmLengthMid = input.ReadFloat();
				break;
			case 61u:
				ArmLengthFar = input.ReadFloat();
				break;
			case 69u:
				ArmLengthSpeed = input.ReadFloat();
				break;
			case 77u:
				FreeCameraArmLengthMin = input.ReadFloat();
				break;
			case 85u:
				FreeCameraArmLengthMax = input.ReadFloat();
				break;
			case 93u:
				ArmRelativeLocationX = input.ReadFloat();
				break;
			case 101u:
				ArmRelativeLocationY = input.ReadFloat();
				break;
			case 109u:
				ArmRelativeLocationZ = input.ReadFloat();
				break;
			case 117u:
				ArmRelativeLocationSpeed = input.ReadFloat();
				break;
			case 125u:
				ArmSocketOffsetX = input.ReadFloat();
				break;
			case 133u:
				ArmSocketOffsetY = input.ReadFloat();
				break;
			case 141u:
				ArmSocketOffsetZ = input.ReadFloat();
				break;
			case 149u:
				ArmSocketOffsetSpeed = input.ReadFloat();
				break;
			case 157u:
				InverseOffsetX = input.ReadFloat();
				break;
			case 165u:
				InverseOffsetSpeedX = input.ReadFloat();
				break;
			case 173u:
				InverseOffsetResetSpeedX = input.ReadFloat();
				break;
			case 181u:
				InverseOffsetY = input.ReadFloat();
				break;
			case 189u:
				InverseOffsetSpeedY = input.ReadFloat();
				break;
			case 197u:
				InverseOffsetResetSpeedY = input.ReadFloat();
				break;
			case 205u:
				InverseOffsetZ = input.ReadFloat();
				break;
			case 213u:
				InverseOffsetSpeedZ = input.ReadFloat();
				break;
			case 221u:
				InverseOffsetResetSpeedZ = input.ReadFloat();
				break;
			case 229u:
				MeshZOffsetLimit = input.ReadFloat();
				break;
			case 237u:
				FocalDistance = input.ReadFloat();
				break;
			case 245u:
				DepthBlurKM = input.ReadFloat();
				break;
			case 253u:
				DepthBlurRadius = input.ReadFloat();
				break;
			case 261u:
				FOV = input.ReadFloat();
				break;
			case 269u:
				FOVSpeed = input.ReadFloat();
				break;
			case 277u:
				MinPitch = input.ReadFloat();
				break;
			case 285u:
				MaxPitch = input.ReadFloat();
				break;
			case 293u:
				MinYaw = input.ReadFloat();
				break;
			case 301u:
				MaxYaw = input.ReadFloat();
				break;
			}
		}
	}
}
