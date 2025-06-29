using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStEnemyCameraDesc : IMessage<FUStEnemyCameraDesc>, IMessage, IEquatable<FUStEnemyCameraDesc>, IDeepCloneable<FUStEnemyCameraDesc>
{
	private static readonly MessageParser<FUStEnemyCameraDesc> _parser = new MessageParser<FUStEnemyCameraDesc>(() => new FUStEnemyCameraDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int camID_;

	private int playerUnitResID_;

	private ECameraType cameraType_;

	private float springArmRLX_;

	private float springArmRLY_;

	private float springArmRLZ_;

	private float enterTargetRefLerpSpeed_;

	private float enterPlayerRefLerpSpeed_;

	private float enterArmAcceleration_;

	private float armSpeed_;

	private float exitArmAcceleration_;

	private static readonly FieldCodec<int> _repeated_cameraParamInt_codec = FieldCodec.ForInt32(106u);

	private readonly RepeatedField<int> cameraParamInt_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_cameraParamFloat_codec = FieldCodec.ForFloat(114u);

	private readonly RepeatedField<float> cameraParamFloat_ = new RepeatedField<float>();

	private static readonly FieldCodec<string> _repeated_cameraParamString_codec = FieldCodec.ForString(122u);

	private readonly RepeatedField<string> cameraParamString_ = new RepeatedField<string>();

	public static MessageParser<FUStEnemyCameraDesc> Parser => _parser;

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

	public ECameraType CameraType
	{
		get
		{
			return cameraType_;
		}
		set
		{
			cameraType_ = value;
		}
	}

	public float SpringArmRLX
	{
		get
		{
			return springArmRLX_;
		}
		set
		{
			springArmRLX_ = value;
		}
	}

	public float SpringArmRLY
	{
		get
		{
			return springArmRLY_;
		}
		set
		{
			springArmRLY_ = value;
		}
	}

	public float SpringArmRLZ
	{
		get
		{
			return springArmRLZ_;
		}
		set
		{
			springArmRLZ_ = value;
		}
	}

	public float EnterTargetRefLerpSpeed
	{
		get
		{
			return enterTargetRefLerpSpeed_;
		}
		set
		{
			enterTargetRefLerpSpeed_ = value;
		}
	}

	public float EnterPlayerRefLerpSpeed
	{
		get
		{
			return enterPlayerRefLerpSpeed_;
		}
		set
		{
			enterPlayerRefLerpSpeed_ = value;
		}
	}

	public float EnterArmAcceleration
	{
		get
		{
			return enterArmAcceleration_;
		}
		set
		{
			enterArmAcceleration_ = value;
		}
	}

	public float ArmSpeed
	{
		get
		{
			return armSpeed_;
		}
		set
		{
			armSpeed_ = value;
		}
	}

	public float ExitArmAcceleration
	{
		get
		{
			return exitArmAcceleration_;
		}
		set
		{
			exitArmAcceleration_ = value;
		}
	}

	public RepeatedField<int> CameraParamInt => cameraParamInt_;

	public RepeatedField<float> CameraParamFloat => cameraParamFloat_;

	public RepeatedField<string> CameraParamString => cameraParamString_;

	public FUStEnemyCameraDesc()
	{
	}

	public FUStEnemyCameraDesc(FUStEnemyCameraDesc other)
		: this()
	{
		iD_ = other.iD_;
		camID_ = other.camID_;
		playerUnitResID_ = other.playerUnitResID_;
		cameraType_ = other.cameraType_;
		springArmRLX_ = other.springArmRLX_;
		springArmRLY_ = other.springArmRLY_;
		springArmRLZ_ = other.springArmRLZ_;
		enterTargetRefLerpSpeed_ = other.enterTargetRefLerpSpeed_;
		enterPlayerRefLerpSpeed_ = other.enterPlayerRefLerpSpeed_;
		enterArmAcceleration_ = other.enterArmAcceleration_;
		armSpeed_ = other.armSpeed_;
		exitArmAcceleration_ = other.exitArmAcceleration_;
		cameraParamInt_ = other.cameraParamInt_.Clone();
		cameraParamFloat_ = other.cameraParamFloat_.Clone();
		cameraParamString_ = other.cameraParamString_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStEnemyCameraDesc Clone()
	{
		return new FUStEnemyCameraDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStEnemyCameraDesc);
	}

	public bool Equals(FUStEnemyCameraDesc other)
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
		if (CameraType != other.CameraType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SpringArmRLX, other.SpringArmRLX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SpringArmRLY, other.SpringArmRLY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SpringArmRLZ, other.SpringArmRLZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(EnterTargetRefLerpSpeed, other.EnterTargetRefLerpSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(EnterPlayerRefLerpSpeed, other.EnterPlayerRefLerpSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(EnterArmAcceleration, other.EnterArmAcceleration))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArmSpeed, other.ArmSpeed))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExitArmAcceleration, other.ExitArmAcceleration))
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
		if (CameraType != ECameraType.None)
		{
			num ^= CameraType.GetHashCode();
		}
		if (SpringArmRLX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SpringArmRLX);
		}
		if (SpringArmRLY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SpringArmRLY);
		}
		if (SpringArmRLZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SpringArmRLZ);
		}
		if (EnterTargetRefLerpSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EnterTargetRefLerpSpeed);
		}
		if (EnterPlayerRefLerpSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EnterPlayerRefLerpSpeed);
		}
		if (EnterArmAcceleration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EnterArmAcceleration);
		}
		if (ArmSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArmSpeed);
		}
		if (ExitArmAcceleration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExitArmAcceleration);
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
		if (CameraType != ECameraType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)CameraType);
		}
		if (SpringArmRLX != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(SpringArmRLX);
		}
		if (SpringArmRLY != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(SpringArmRLY);
		}
		if (SpringArmRLZ != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(SpringArmRLZ);
		}
		if (EnterTargetRefLerpSpeed != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(EnterTargetRefLerpSpeed);
		}
		if (EnterPlayerRefLerpSpeed != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(EnterPlayerRefLerpSpeed);
		}
		if (EnterArmAcceleration != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(EnterArmAcceleration);
		}
		if (ArmSpeed != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(ArmSpeed);
		}
		if (ExitArmAcceleration != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(ExitArmAcceleration);
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
		if (CameraType != ECameraType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CameraType);
		}
		if (SpringArmRLX != 0f)
		{
			num += 5;
		}
		if (SpringArmRLY != 0f)
		{
			num += 5;
		}
		if (SpringArmRLZ != 0f)
		{
			num += 5;
		}
		if (EnterTargetRefLerpSpeed != 0f)
		{
			num += 5;
		}
		if (EnterPlayerRefLerpSpeed != 0f)
		{
			num += 5;
		}
		if (EnterArmAcceleration != 0f)
		{
			num += 5;
		}
		if (ArmSpeed != 0f)
		{
			num += 5;
		}
		if (ExitArmAcceleration != 0f)
		{
			num += 5;
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

	public void MergeFrom(FUStEnemyCameraDesc other)
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
			if (other.CameraType != ECameraType.None)
			{
				CameraType = other.CameraType;
			}
			if (other.SpringArmRLX != 0f)
			{
				SpringArmRLX = other.SpringArmRLX;
			}
			if (other.SpringArmRLY != 0f)
			{
				SpringArmRLY = other.SpringArmRLY;
			}
			if (other.SpringArmRLZ != 0f)
			{
				SpringArmRLZ = other.SpringArmRLZ;
			}
			if (other.EnterTargetRefLerpSpeed != 0f)
			{
				EnterTargetRefLerpSpeed = other.EnterTargetRefLerpSpeed;
			}
			if (other.EnterPlayerRefLerpSpeed != 0f)
			{
				EnterPlayerRefLerpSpeed = other.EnterPlayerRefLerpSpeed;
			}
			if (other.EnterArmAcceleration != 0f)
			{
				EnterArmAcceleration = other.EnterArmAcceleration;
			}
			if (other.ArmSpeed != 0f)
			{
				ArmSpeed = other.ArmSpeed;
			}
			if (other.ExitArmAcceleration != 0f)
			{
				ExitArmAcceleration = other.ExitArmAcceleration;
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
				CameraType = (ECameraType)input.ReadEnum();
				break;
			case 45u:
				SpringArmRLX = input.ReadFloat();
				break;
			case 53u:
				SpringArmRLY = input.ReadFloat();
				break;
			case 61u:
				SpringArmRLZ = input.ReadFloat();
				break;
			case 69u:
				EnterTargetRefLerpSpeed = input.ReadFloat();
				break;
			case 77u:
				EnterPlayerRefLerpSpeed = input.ReadFloat();
				break;
			case 85u:
				EnterArmAcceleration = input.ReadFloat();
				break;
			case 93u:
				ArmSpeed = input.ReadFloat();
				break;
			case 101u:
				ExitArmAcceleration = input.ReadFloat();
				break;
			case 104u:
			case 106u:
				cameraParamInt_.AddEntriesFrom(input, _repeated_cameraParamInt_codec);
				break;
			case 114u:
			case 117u:
				cameraParamFloat_.AddEntriesFrom(input, _repeated_cameraParamFloat_codec);
				break;
			case 122u:
				cameraParamString_.AddEntriesFrom(input, _repeated_cameraParamString_codec);
				break;
			}
		}
	}
}
