using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStStraightCamDesc : IMessage<FUStStraightCamDesc>, IMessage, IEquatable<FUStStraightCamDesc>, IDeepCloneable<FUStStraightCamDesc>
{
	private static readonly MessageParser<FUStStraightCamDesc> _parser = new MessageParser<FUStStraightCamDesc>(() => new FUStStraightCamDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int camID_;

	private int playerUnitResID_;

	private ECamRefType camRefType_;

	private float armLengthDefault_;

	private float armLengthClose_;

	private float armLengthMid_;

	private float armLengthFar_;

	private float armLengthSpeed_;

	private float targetRefHeightOffset_;

	private float playerRefHeightOffset_;

	private float targetRefHeightOffsetSpeed_;

	private float playerRefHeightOffsetSpeed_;

	private float heightThreshold_;

	private ESlowTraceSolution slowTraceSolution_;

	private float maxTraceTargetRefDist_;

	private float traceTargetRefSpeed_;

	private float yawTraceSpeed_;

	private float pitchTraceSpeed_;

	private float slowTraceTargetRefMaxYaw_;

	private string slowTraceSpeedCurve_ = "";

	private float minPitch_;

	private float maxPitch_;

	private float heightScaleFactor_;

	private float closestDist_;

	private float heightScaleFurthestDist_;

	private static readonly FieldCodec<int> _repeated_cameraParamInt_codec = FieldCodec.ForInt32(218u);

	private readonly RepeatedField<int> cameraParamInt_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_cameraParamFloat_codec = FieldCodec.ForFloat(226u);

	private readonly RepeatedField<float> cameraParamFloat_ = new RepeatedField<float>();

	private static readonly FieldCodec<string> _repeated_cameraParamString_codec = FieldCodec.ForString(234u);

	private readonly RepeatedField<string> cameraParamString_ = new RepeatedField<string>();

	public static MessageParser<FUStStraightCamDesc> Parser => _parser;

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

	public ECamRefType CamRefType
	{
		get
		{
			return camRefType_;
		}
		set
		{
			camRefType_ = value;
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

	public float HeightThreshold
	{
		get
		{
			return heightThreshold_;
		}
		set
		{
			heightThreshold_ = value;
		}
	}

	public ESlowTraceSolution SlowTraceSolution
	{
		get
		{
			return slowTraceSolution_;
		}
		set
		{
			slowTraceSolution_ = value;
		}
	}

	public float MaxTraceTargetRefDist
	{
		get
		{
			return maxTraceTargetRefDist_;
		}
		set
		{
			maxTraceTargetRefDist_ = value;
		}
	}

	public float TraceTargetRefSpeed
	{
		get
		{
			return traceTargetRefSpeed_;
		}
		set
		{
			traceTargetRefSpeed_ = value;
		}
	}

	public float YawTraceSpeed
	{
		get
		{
			return yawTraceSpeed_;
		}
		set
		{
			yawTraceSpeed_ = value;
		}
	}

	public float PitchTraceSpeed
	{
		get
		{
			return pitchTraceSpeed_;
		}
		set
		{
			pitchTraceSpeed_ = value;
		}
	}

	public float SlowTraceTargetRefMaxYaw
	{
		get
		{
			return slowTraceTargetRefMaxYaw_;
		}
		set
		{
			slowTraceTargetRefMaxYaw_ = value;
		}
	}

	public string SlowTraceSpeedCurve
	{
		get
		{
			return slowTraceSpeedCurve_;
		}
		set
		{
			slowTraceSpeedCurve_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public float HeightScaleFactor
	{
		get
		{
			return heightScaleFactor_;
		}
		set
		{
			heightScaleFactor_ = value;
		}
	}

	public float ClosestDist
	{
		get
		{
			return closestDist_;
		}
		set
		{
			closestDist_ = value;
		}
	}

	public float HeightScaleFurthestDist
	{
		get
		{
			return heightScaleFurthestDist_;
		}
		set
		{
			heightScaleFurthestDist_ = value;
		}
	}

	public RepeatedField<int> CameraParamInt => cameraParamInt_;

	public RepeatedField<float> CameraParamFloat => cameraParamFloat_;

	public RepeatedField<string> CameraParamString => cameraParamString_;

	public FUStStraightCamDesc()
	{
	}

	public FUStStraightCamDesc(FUStStraightCamDesc other)
		: this()
	{
		iD_ = other.iD_;
		camID_ = other.camID_;
		playerUnitResID_ = other.playerUnitResID_;
		camRefType_ = other.camRefType_;
		armLengthDefault_ = other.armLengthDefault_;
		armLengthClose_ = other.armLengthClose_;
		armLengthMid_ = other.armLengthMid_;
		armLengthFar_ = other.armLengthFar_;
		armLengthSpeed_ = other.armLengthSpeed_;
		targetRefHeightOffset_ = other.targetRefHeightOffset_;
		playerRefHeightOffset_ = other.playerRefHeightOffset_;
		targetRefHeightOffsetSpeed_ = other.targetRefHeightOffsetSpeed_;
		playerRefHeightOffsetSpeed_ = other.playerRefHeightOffsetSpeed_;
		heightThreshold_ = other.heightThreshold_;
		slowTraceSolution_ = other.slowTraceSolution_;
		maxTraceTargetRefDist_ = other.maxTraceTargetRefDist_;
		traceTargetRefSpeed_ = other.traceTargetRefSpeed_;
		yawTraceSpeed_ = other.yawTraceSpeed_;
		pitchTraceSpeed_ = other.pitchTraceSpeed_;
		slowTraceTargetRefMaxYaw_ = other.slowTraceTargetRefMaxYaw_;
		slowTraceSpeedCurve_ = other.slowTraceSpeedCurve_;
		minPitch_ = other.minPitch_;
		maxPitch_ = other.maxPitch_;
		heightScaleFactor_ = other.heightScaleFactor_;
		closestDist_ = other.closestDist_;
		heightScaleFurthestDist_ = other.heightScaleFurthestDist_;
		cameraParamInt_ = other.cameraParamInt_.Clone();
		cameraParamFloat_ = other.cameraParamFloat_.Clone();
		cameraParamString_ = other.cameraParamString_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStStraightCamDesc Clone()
	{
		return new FUStStraightCamDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStStraightCamDesc);
	}

	public bool Equals(FUStStraightCamDesc other)
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
		if (CamRefType != other.CamRefType)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HeightThreshold, other.HeightThreshold))
		{
			return false;
		}
		if (SlowTraceSolution != other.SlowTraceSolution)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxTraceTargetRefDist, other.MaxTraceTargetRefDist))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TraceTargetRefSpeed, other.TraceTargetRefSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(YawTraceSpeed, other.YawTraceSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PitchTraceSpeed, other.PitchTraceSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SlowTraceTargetRefMaxYaw, other.SlowTraceTargetRefMaxYaw))
		{
			return false;
		}
		if (SlowTraceSpeedCurve != other.SlowTraceSpeedCurve)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HeightScaleFactor, other.HeightScaleFactor))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ClosestDist, other.ClosestDist))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HeightScaleFurthestDist, other.HeightScaleFurthestDist))
		{
			return false;
		}
		if (!cameraParamInt_.Equals(other.cameraParamInt_))
		{
			return false;
		}
		if (!cameraParamFloat_.Equals(other.cameraParamFloat_))
		{
			return false;
		}
		if (!cameraParamString_.Equals(other.cameraParamString_))
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
		if (CamRefType != ECamRefType.None)
		{
			num ^= CamRefType.GetHashCode();
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
		if (HeightThreshold != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HeightThreshold);
		}
		if (SlowTraceSolution != ESlowTraceSolution.None)
		{
			num ^= SlowTraceSolution.GetHashCode();
		}
		if (MaxTraceTargetRefDist != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxTraceTargetRefDist);
		}
		if (TraceTargetRefSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TraceTargetRefSpeed);
		}
		if (YawTraceSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(YawTraceSpeed);
		}
		if (PitchTraceSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PitchTraceSpeed);
		}
		if (SlowTraceTargetRefMaxYaw != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SlowTraceTargetRefMaxYaw);
		}
		if (SlowTraceSpeedCurve.Length != 0)
		{
			num ^= SlowTraceSpeedCurve.GetHashCode();
		}
		if (MinPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinPitch);
		}
		if (MaxPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxPitch);
		}
		if (HeightScaleFactor != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HeightScaleFactor);
		}
		if (ClosestDist != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ClosestDist);
		}
		if (HeightScaleFurthestDist != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HeightScaleFurthestDist);
		}
		num ^= cameraParamInt_.GetHashCode();
		num ^= cameraParamFloat_.GetHashCode();
		num ^= cameraParamString_.GetHashCode();
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
		if (CamRefType != ECamRefType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)CamRefType);
		}
		if (ArmLengthDefault != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(ArmLengthDefault);
		}
		if (ArmLengthClose != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(ArmLengthClose);
		}
		if (ArmLengthMid != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(ArmLengthMid);
		}
		if (ArmLengthFar != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(ArmLengthFar);
		}
		if (ArmLengthSpeed != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(ArmLengthSpeed);
		}
		if (TargetRefHeightOffset != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(TargetRefHeightOffset);
		}
		if (PlayerRefHeightOffset != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(PlayerRefHeightOffset);
		}
		if (TargetRefHeightOffsetSpeed != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(TargetRefHeightOffsetSpeed);
		}
		if (PlayerRefHeightOffsetSpeed != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(PlayerRefHeightOffsetSpeed);
		}
		if (HeightThreshold != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(HeightThreshold);
		}
		if (SlowTraceSolution != ESlowTraceSolution.None)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)SlowTraceSolution);
		}
		if (MaxTraceTargetRefDist != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(MaxTraceTargetRefDist);
		}
		if (TraceTargetRefSpeed != 0f)
		{
			output.WriteRawTag(141, 1);
			output.WriteFloat(TraceTargetRefSpeed);
		}
		if (YawTraceSpeed != 0f)
		{
			output.WriteRawTag(149, 1);
			output.WriteFloat(YawTraceSpeed);
		}
		if (PitchTraceSpeed != 0f)
		{
			output.WriteRawTag(157, 1);
			output.WriteFloat(PitchTraceSpeed);
		}
		if (SlowTraceTargetRefMaxYaw != 0f)
		{
			output.WriteRawTag(165, 1);
			output.WriteFloat(SlowTraceTargetRefMaxYaw);
		}
		if (SlowTraceSpeedCurve.Length != 0)
		{
			output.WriteRawTag(170, 1);
			output.WriteString(SlowTraceSpeedCurve);
		}
		if (MinPitch != 0f)
		{
			output.WriteRawTag(181, 1);
			output.WriteFloat(MinPitch);
		}
		if (MaxPitch != 0f)
		{
			output.WriteRawTag(189, 1);
			output.WriteFloat(MaxPitch);
		}
		if (HeightScaleFactor != 0f)
		{
			output.WriteRawTag(197, 1);
			output.WriteFloat(HeightScaleFactor);
		}
		if (ClosestDist != 0f)
		{
			output.WriteRawTag(205, 1);
			output.WriteFloat(ClosestDist);
		}
		if (HeightScaleFurthestDist != 0f)
		{
			output.WriteRawTag(213, 1);
			output.WriteFloat(HeightScaleFurthestDist);
		}
		cameraParamInt_.WriteTo(output, _repeated_cameraParamInt_codec);
		cameraParamFloat_.WriteTo(output, _repeated_cameraParamFloat_codec);
		cameraParamString_.WriteTo(output, _repeated_cameraParamString_codec);
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
		if (CamRefType != ECamRefType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CamRefType);
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
		if (HeightThreshold != 0f)
		{
			num += 5;
		}
		if (SlowTraceSolution != ESlowTraceSolution.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SlowTraceSolution);
		}
		if (MaxTraceTargetRefDist != 0f)
		{
			num += 6;
		}
		if (TraceTargetRefSpeed != 0f)
		{
			num += 6;
		}
		if (YawTraceSpeed != 0f)
		{
			num += 6;
		}
		if (PitchTraceSpeed != 0f)
		{
			num += 6;
		}
		if (SlowTraceTargetRefMaxYaw != 0f)
		{
			num += 6;
		}
		if (SlowTraceSpeedCurve.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(SlowTraceSpeedCurve);
		}
		if (MinPitch != 0f)
		{
			num += 6;
		}
		if (MaxPitch != 0f)
		{
			num += 6;
		}
		if (HeightScaleFactor != 0f)
		{
			num += 6;
		}
		if (ClosestDist != 0f)
		{
			num += 6;
		}
		if (HeightScaleFurthestDist != 0f)
		{
			num += 6;
		}
		num += cameraParamInt_.CalculateSize(_repeated_cameraParamInt_codec);
		num += cameraParamFloat_.CalculateSize(_repeated_cameraParamFloat_codec);
		num += cameraParamString_.CalculateSize(_repeated_cameraParamString_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStStraightCamDesc other)
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
			if (other.CamRefType != ECamRefType.None)
			{
				CamRefType = other.CamRefType;
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
			if (other.HeightThreshold != 0f)
			{
				HeightThreshold = other.HeightThreshold;
			}
			if (other.SlowTraceSolution != ESlowTraceSolution.None)
			{
				SlowTraceSolution = other.SlowTraceSolution;
			}
			if (other.MaxTraceTargetRefDist != 0f)
			{
				MaxTraceTargetRefDist = other.MaxTraceTargetRefDist;
			}
			if (other.TraceTargetRefSpeed != 0f)
			{
				TraceTargetRefSpeed = other.TraceTargetRefSpeed;
			}
			if (other.YawTraceSpeed != 0f)
			{
				YawTraceSpeed = other.YawTraceSpeed;
			}
			if (other.PitchTraceSpeed != 0f)
			{
				PitchTraceSpeed = other.PitchTraceSpeed;
			}
			if (other.SlowTraceTargetRefMaxYaw != 0f)
			{
				SlowTraceTargetRefMaxYaw = other.SlowTraceTargetRefMaxYaw;
			}
			if (other.SlowTraceSpeedCurve.Length != 0)
			{
				SlowTraceSpeedCurve = other.SlowTraceSpeedCurve;
			}
			if (other.MinPitch != 0f)
			{
				MinPitch = other.MinPitch;
			}
			if (other.MaxPitch != 0f)
			{
				MaxPitch = other.MaxPitch;
			}
			if (other.HeightScaleFactor != 0f)
			{
				HeightScaleFactor = other.HeightScaleFactor;
			}
			if (other.ClosestDist != 0f)
			{
				ClosestDist = other.ClosestDist;
			}
			if (other.HeightScaleFurthestDist != 0f)
			{
				HeightScaleFurthestDist = other.HeightScaleFurthestDist;
			}
			cameraParamInt_.Add(other.cameraParamInt_);
			cameraParamFloat_.Add(other.cameraParamFloat_);
			cameraParamString_.Add(other.cameraParamString_);
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
			case 32u:
				CamRefType = (ECamRefType)input.ReadEnum();
				break;
			case 45u:
				ArmLengthDefault = input.ReadFloat();
				break;
			case 53u:
				ArmLengthClose = input.ReadFloat();
				break;
			case 61u:
				ArmLengthMid = input.ReadFloat();
				break;
			case 69u:
				ArmLengthFar = input.ReadFloat();
				break;
			case 77u:
				ArmLengthSpeed = input.ReadFloat();
				break;
			case 85u:
				TargetRefHeightOffset = input.ReadFloat();
				break;
			case 93u:
				PlayerRefHeightOffset = input.ReadFloat();
				break;
			case 101u:
				TargetRefHeightOffsetSpeed = input.ReadFloat();
				break;
			case 109u:
				PlayerRefHeightOffsetSpeed = input.ReadFloat();
				break;
			case 117u:
				HeightThreshold = input.ReadFloat();
				break;
			case 120u:
				SlowTraceSolution = (ESlowTraceSolution)input.ReadEnum();
				break;
			case 133u:
				MaxTraceTargetRefDist = input.ReadFloat();
				break;
			case 141u:
				TraceTargetRefSpeed = input.ReadFloat();
				break;
			case 149u:
				YawTraceSpeed = input.ReadFloat();
				break;
			case 157u:
				PitchTraceSpeed = input.ReadFloat();
				break;
			case 165u:
				SlowTraceTargetRefMaxYaw = input.ReadFloat();
				break;
			case 170u:
				SlowTraceSpeedCurve = input.ReadString();
				break;
			case 181u:
				MinPitch = input.ReadFloat();
				break;
			case 189u:
				MaxPitch = input.ReadFloat();
				break;
			case 197u:
				HeightScaleFactor = input.ReadFloat();
				break;
			case 205u:
				ClosestDist = input.ReadFloat();
				break;
			case 213u:
				HeightScaleFurthestDist = input.ReadFloat();
				break;
			case 216u:
			case 218u:
				cameraParamInt_.AddEntriesFrom(input, _repeated_cameraParamInt_codec);
				break;
			case 226u:
			case 229u:
				cameraParamFloat_.AddEntriesFrom(input, _repeated_cameraParamFloat_codec);
				break;
			case 234u:
				cameraParamString_.AddEntriesFrom(input, _repeated_cameraParamString_codec);
				break;
			}
		}
	}
}
