using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStDiagonalCamDesc : IMessage<FUStDiagonalCamDesc>, IMessage, IEquatable<FUStDiagonalCamDesc>, IDeepCloneable<FUStDiagonalCamDesc>
{
	private static readonly MessageParser<FUStDiagonalCamDesc> _parser = new MessageParser<FUStDiagonalCamDesc>(() => new FUStDiagonalCamDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int camID_;

	private int playerUnitResID_;

	private float pRef_;

	private float eRef_;

	private float refOffsetBase_;

	private float refOffsetDis_;

	private float p2TRatio_;

	private float posLerpSpd_;

	private float angleOffset_;

	private float pitchBase_;

	private float pitchFadeDis_;

	private float rotLerpSpdLow_;

	private float rotLerpSpdHigh_;

	private float armMin_;

	private float armMax_;

	private float armChangeValue_;

	private float armLerpSpd_;

	public static MessageParser<FUStDiagonalCamDesc> Parser => _parser;

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

	public float PRef
	{
		get
		{
			return pRef_;
		}
		set
		{
			pRef_ = value;
		}
	}

	public float ERef
	{
		get
		{
			return eRef_;
		}
		set
		{
			eRef_ = value;
		}
	}

	public float RefOffsetBase
	{
		get
		{
			return refOffsetBase_;
		}
		set
		{
			refOffsetBase_ = value;
		}
	}

	public float RefOffsetDis
	{
		get
		{
			return refOffsetDis_;
		}
		set
		{
			refOffsetDis_ = value;
		}
	}

	public float P2TRatio
	{
		get
		{
			return p2TRatio_;
		}
		set
		{
			p2TRatio_ = value;
		}
	}

	public float PosLerpSpd
	{
		get
		{
			return posLerpSpd_;
		}
		set
		{
			posLerpSpd_ = value;
		}
	}

	public float AngleOffset
	{
		get
		{
			return angleOffset_;
		}
		set
		{
			angleOffset_ = value;
		}
	}

	public float PitchBase
	{
		get
		{
			return pitchBase_;
		}
		set
		{
			pitchBase_ = value;
		}
	}

	public float PitchFadeDis
	{
		get
		{
			return pitchFadeDis_;
		}
		set
		{
			pitchFadeDis_ = value;
		}
	}

	public float RotLerpSpdLow
	{
		get
		{
			return rotLerpSpdLow_;
		}
		set
		{
			rotLerpSpdLow_ = value;
		}
	}

	public float RotLerpSpdHigh
	{
		get
		{
			return rotLerpSpdHigh_;
		}
		set
		{
			rotLerpSpdHigh_ = value;
		}
	}

	public float ArmMin
	{
		get
		{
			return armMin_;
		}
		set
		{
			armMin_ = value;
		}
	}

	public float ArmMax
	{
		get
		{
			return armMax_;
		}
		set
		{
			armMax_ = value;
		}
	}

	public float ArmChangeValue
	{
		get
		{
			return armChangeValue_;
		}
		set
		{
			armChangeValue_ = value;
		}
	}

	public float ArmLerpSpd
	{
		get
		{
			return armLerpSpd_;
		}
		set
		{
			armLerpSpd_ = value;
		}
	}

	public FUStDiagonalCamDesc()
	{
	}

	public FUStDiagonalCamDesc(FUStDiagonalCamDesc other)
		: this()
	{
		iD_ = other.iD_;
		camID_ = other.camID_;
		playerUnitResID_ = other.playerUnitResID_;
		pRef_ = other.pRef_;
		eRef_ = other.eRef_;
		refOffsetBase_ = other.refOffsetBase_;
		refOffsetDis_ = other.refOffsetDis_;
		p2TRatio_ = other.p2TRatio_;
		posLerpSpd_ = other.posLerpSpd_;
		angleOffset_ = other.angleOffset_;
		pitchBase_ = other.pitchBase_;
		pitchFadeDis_ = other.pitchFadeDis_;
		rotLerpSpdLow_ = other.rotLerpSpdLow_;
		rotLerpSpdHigh_ = other.rotLerpSpdHigh_;
		armMin_ = other.armMin_;
		armMax_ = other.armMax_;
		armChangeValue_ = other.armChangeValue_;
		armLerpSpd_ = other.armLerpSpd_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDiagonalCamDesc Clone()
	{
		return new FUStDiagonalCamDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDiagonalCamDesc);
	}

	public bool Equals(FUStDiagonalCamDesc other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PRef, other.PRef))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ERef, other.ERef))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RefOffsetBase, other.RefOffsetBase))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RefOffsetDis, other.RefOffsetDis))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(P2TRatio, other.P2TRatio))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosLerpSpd, other.PosLerpSpd))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AngleOffset, other.AngleOffset))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PitchBase, other.PitchBase))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PitchFadeDis, other.PitchFadeDis))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RotLerpSpdLow, other.RotLerpSpdLow))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RotLerpSpdHigh, other.RotLerpSpdHigh))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmMin, other.ArmMin))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmMax, other.ArmMax))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmChangeValue, other.ArmChangeValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmLerpSpd, other.ArmLerpSpd))
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
		if (PRef != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PRef);
		}
		if (ERef != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ERef);
		}
		if (RefOffsetBase != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RefOffsetBase);
		}
		if (RefOffsetDis != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RefOffsetDis);
		}
		if (P2TRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(P2TRatio);
		}
		if (PosLerpSpd != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosLerpSpd);
		}
		if (AngleOffset != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AngleOffset);
		}
		if (PitchBase != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PitchBase);
		}
		if (PitchFadeDis != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PitchFadeDis);
		}
		if (RotLerpSpdLow != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RotLerpSpdLow);
		}
		if (RotLerpSpdHigh != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RotLerpSpdHigh);
		}
		if (ArmMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmMin);
		}
		if (ArmMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmMax);
		}
		if (ArmChangeValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmChangeValue);
		}
		if (ArmLerpSpd != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmLerpSpd);
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
		if (PRef != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(PRef);
		}
		if (ERef != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(ERef);
		}
		if (RefOffsetBase != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(RefOffsetBase);
		}
		if (RefOffsetDis != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(RefOffsetDis);
		}
		if (P2TRatio != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(P2TRatio);
		}
		if (PosLerpSpd != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(PosLerpSpd);
		}
		if (AngleOffset != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(AngleOffset);
		}
		if (PitchBase != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(PitchBase);
		}
		if (PitchFadeDis != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(PitchFadeDis);
		}
		if (RotLerpSpdLow != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(RotLerpSpdLow);
		}
		if (RotLerpSpdHigh != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(RotLerpSpdHigh);
		}
		if (ArmMin != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(ArmMin);
		}
		if (ArmMax != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(ArmMax);
		}
		if (ArmChangeValue != 0f)
		{
			output.WriteRawTag(141, 1);
			output.WriteFloat(ArmChangeValue);
		}
		if (ArmLerpSpd != 0f)
		{
			output.WriteRawTag(149, 1);
			output.WriteFloat(ArmLerpSpd);
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
		if (PRef != 0f)
		{
			num += 5;
		}
		if (ERef != 0f)
		{
			num += 5;
		}
		if (RefOffsetBase != 0f)
		{
			num += 5;
		}
		if (RefOffsetDis != 0f)
		{
			num += 5;
		}
		if (P2TRatio != 0f)
		{
			num += 5;
		}
		if (PosLerpSpd != 0f)
		{
			num += 5;
		}
		if (AngleOffset != 0f)
		{
			num += 5;
		}
		if (PitchBase != 0f)
		{
			num += 5;
		}
		if (PitchFadeDis != 0f)
		{
			num += 5;
		}
		if (RotLerpSpdLow != 0f)
		{
			num += 5;
		}
		if (RotLerpSpdHigh != 0f)
		{
			num += 5;
		}
		if (ArmMin != 0f)
		{
			num += 5;
		}
		if (ArmMax != 0f)
		{
			num += 6;
		}
		if (ArmChangeValue != 0f)
		{
			num += 6;
		}
		if (ArmLerpSpd != 0f)
		{
			num += 6;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDiagonalCamDesc other)
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
			if (other.PRef != 0f)
			{
				PRef = other.PRef;
			}
			if (other.ERef != 0f)
			{
				ERef = other.ERef;
			}
			if (other.RefOffsetBase != 0f)
			{
				RefOffsetBase = other.RefOffsetBase;
			}
			if (other.RefOffsetDis != 0f)
			{
				RefOffsetDis = other.RefOffsetDis;
			}
			if (other.P2TRatio != 0f)
			{
				P2TRatio = other.P2TRatio;
			}
			if (other.PosLerpSpd != 0f)
			{
				PosLerpSpd = other.PosLerpSpd;
			}
			if (other.AngleOffset != 0f)
			{
				AngleOffset = other.AngleOffset;
			}
			if (other.PitchBase != 0f)
			{
				PitchBase = other.PitchBase;
			}
			if (other.PitchFadeDis != 0f)
			{
				PitchFadeDis = other.PitchFadeDis;
			}
			if (other.RotLerpSpdLow != 0f)
			{
				RotLerpSpdLow = other.RotLerpSpdLow;
			}
			if (other.RotLerpSpdHigh != 0f)
			{
				RotLerpSpdHigh = other.RotLerpSpdHigh;
			}
			if (other.ArmMin != 0f)
			{
				ArmMin = other.ArmMin;
			}
			if (other.ArmMax != 0f)
			{
				ArmMax = other.ArmMax;
			}
			if (other.ArmChangeValue != 0f)
			{
				ArmChangeValue = other.ArmChangeValue;
			}
			if (other.ArmLerpSpd != 0f)
			{
				ArmLerpSpd = other.ArmLerpSpd;
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
				PRef = input.ReadFloat();
				break;
			case 45u:
				ERef = input.ReadFloat();
				break;
			case 53u:
				RefOffsetBase = input.ReadFloat();
				break;
			case 61u:
				RefOffsetDis = input.ReadFloat();
				break;
			case 69u:
				P2TRatio = input.ReadFloat();
				break;
			case 77u:
				PosLerpSpd = input.ReadFloat();
				break;
			case 85u:
				AngleOffset = input.ReadFloat();
				break;
			case 93u:
				PitchBase = input.ReadFloat();
				break;
			case 101u:
				PitchFadeDis = input.ReadFloat();
				break;
			case 109u:
				RotLerpSpdLow = input.ReadFloat();
				break;
			case 117u:
				RotLerpSpdHigh = input.ReadFloat();
				break;
			case 125u:
				ArmMin = input.ReadFloat();
				break;
			case 133u:
				ArmMax = input.ReadFloat();
				break;
			case 141u:
				ArmChangeValue = input.ReadFloat();
				break;
			case 149u:
				ArmLerpSpd = input.ReadFloat();
				break;
			}
		}
	}
}
