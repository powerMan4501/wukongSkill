using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBulletSwitchDesc : IMessage<FUStBulletSwitchDesc>, IMessage, IEquatable<FUStBulletSwitchDesc>, IDeepCloneable<FUStBulletSwitchDesc>
{
	private static readonly MessageParser<FUStBulletSwitchDesc> _parser = new MessageParser<FUStBulletSwitchDesc>(() => new FUStBulletSwitchDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int bulletID_;

	private EProjectileResetTargetType resetTargetType_;

	private string targetSocket_ = "";

	private string targetEQSTemplate_ = "";

	private int targetPointSetCachedReqID_;

	private EProjectileResetDirType resetDirectionType_;

	private float newDirRoll_;

	private float newDirPitch_;

	private float newDirYaw_;

	private EGSYesNo resetMoveProperty_;

	private static readonly FieldCodec<float> _repeated_bulletMoveModeFlySpdFloatParam_codec = FieldCodec.ForFloat(98u);

	private readonly RepeatedField<float> bulletMoveModeFlySpdFloatParam_ = new RepeatedField<float>();

	private string bulletMoveModeFlySpdCurvePath_ = "";

	private static readonly FieldCodec<float> _repeated_bulletMoveModeRotSpdFloatParam_codec = FieldCodec.ForFloat(114u);

	private readonly RepeatedField<float> bulletMoveModeRotSpdFloatParam_ = new RepeatedField<float>();

	private string bulletMoveModeRotSpdCurvePath_ = "";

	private static readonly FieldCodec<int> _repeated_attachBuffID_codec = FieldCodec.ForInt32(130u);

	private readonly RepeatedField<int> attachBuffID_ = new RepeatedField<int>();

	public static MessageParser<FUStBulletSwitchDesc> Parser => _parser;

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

	public int BulletID
	{
		get
		{
			return bulletID_;
		}
		set
		{
			bulletID_ = value;
		}
	}

	public EProjectileResetTargetType ResetTargetType
	{
		get
		{
			return resetTargetType_;
		}
		set
		{
			resetTargetType_ = value;
		}
	}

	public string TargetSocket
	{
		get
		{
			return targetSocket_;
		}
		set
		{
			targetSocket_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string TargetEQSTemplate
	{
		get
		{
			return targetEQSTemplate_;
		}
		set
		{
			targetEQSTemplate_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TargetPointSetCachedReqID
	{
		get
		{
			return targetPointSetCachedReqID_;
		}
		set
		{
			targetPointSetCachedReqID_ = value;
		}
	}

	public EProjectileResetDirType ResetDirectionType
	{
		get
		{
			return resetDirectionType_;
		}
		set
		{
			resetDirectionType_ = value;
		}
	}

	public float NewDirRoll
	{
		get
		{
			return newDirRoll_;
		}
		set
		{
			newDirRoll_ = value;
		}
	}

	public float NewDirPitch
	{
		get
		{
			return newDirPitch_;
		}
		set
		{
			newDirPitch_ = value;
		}
	}

	public float NewDirYaw
	{
		get
		{
			return newDirYaw_;
		}
		set
		{
			newDirYaw_ = value;
		}
	}

	public EGSYesNo ResetMoveProperty
	{
		get
		{
			return resetMoveProperty_;
		}
		set
		{
			resetMoveProperty_ = value;
		}
	}

	public RepeatedField<float> BulletMoveModeFlySpdFloatParam => bulletMoveModeFlySpdFloatParam_;

	public string BulletMoveModeFlySpdCurvePath
	{
		get
		{
			return bulletMoveModeFlySpdCurvePath_;
		}
		set
		{
			bulletMoveModeFlySpdCurvePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<float> BulletMoveModeRotSpdFloatParam => bulletMoveModeRotSpdFloatParam_;

	public string BulletMoveModeRotSpdCurvePath
	{
		get
		{
			return bulletMoveModeRotSpdCurvePath_;
		}
		set
		{
			bulletMoveModeRotSpdCurvePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> AttachBuffID => attachBuffID_;

	public FUStBulletSwitchDesc()
	{
	}

	public FUStBulletSwitchDesc(FUStBulletSwitchDesc other)
		: this()
	{
		iD_ = other.iD_;
		bulletID_ = other.bulletID_;
		resetTargetType_ = other.resetTargetType_;
		targetSocket_ = other.targetSocket_;
		targetEQSTemplate_ = other.targetEQSTemplate_;
		targetPointSetCachedReqID_ = other.targetPointSetCachedReqID_;
		resetDirectionType_ = other.resetDirectionType_;
		newDirRoll_ = other.newDirRoll_;
		newDirPitch_ = other.newDirPitch_;
		newDirYaw_ = other.newDirYaw_;
		resetMoveProperty_ = other.resetMoveProperty_;
		bulletMoveModeFlySpdFloatParam_ = other.bulletMoveModeFlySpdFloatParam_.Clone();
		bulletMoveModeFlySpdCurvePath_ = other.bulletMoveModeFlySpdCurvePath_;
		bulletMoveModeRotSpdFloatParam_ = other.bulletMoveModeRotSpdFloatParam_.Clone();
		bulletMoveModeRotSpdCurvePath_ = other.bulletMoveModeRotSpdCurvePath_;
		attachBuffID_ = other.attachBuffID_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBulletSwitchDesc Clone()
	{
		return new FUStBulletSwitchDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBulletSwitchDesc);
	}

	public bool Equals(FUStBulletSwitchDesc other)
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
		if (BulletID != other.BulletID)
		{
			return false;
		}
		if (ResetTargetType != other.ResetTargetType)
		{
			return false;
		}
		if (TargetSocket != other.TargetSocket)
		{
			return false;
		}
		if (TargetEQSTemplate != other.TargetEQSTemplate)
		{
			return false;
		}
		if (TargetPointSetCachedReqID != other.TargetPointSetCachedReqID)
		{
			return false;
		}
		if (ResetDirectionType != other.ResetDirectionType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(NewDirRoll, other.NewDirRoll))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(NewDirPitch, other.NewDirPitch))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(NewDirYaw, other.NewDirYaw))
		{
			return false;
		}
		if (ResetMoveProperty != other.ResetMoveProperty)
		{
			return false;
		}
		if (!bulletMoveModeFlySpdFloatParam_.Equals(other.bulletMoveModeFlySpdFloatParam_))
		{
			return false;
		}
		if (BulletMoveModeFlySpdCurvePath != other.BulletMoveModeFlySpdCurvePath)
		{
			return false;
		}
		if (!bulletMoveModeRotSpdFloatParam_.Equals(other.bulletMoveModeRotSpdFloatParam_))
		{
			return false;
		}
		if (BulletMoveModeRotSpdCurvePath != other.BulletMoveModeRotSpdCurvePath)
		{
			return false;
		}
		if (!attachBuffID_.Equals(other.attachBuffID_))
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
		if (BulletID != 0)
		{
			num ^= BulletID.GetHashCode();
		}
		if (ResetTargetType != EProjectileResetTargetType.None)
		{
			num ^= ResetTargetType.GetHashCode();
		}
		if (TargetSocket.Length != 0)
		{
			num ^= TargetSocket.GetHashCode();
		}
		if (TargetEQSTemplate.Length != 0)
		{
			num ^= TargetEQSTemplate.GetHashCode();
		}
		if (TargetPointSetCachedReqID != 0)
		{
			num ^= TargetPointSetCachedReqID.GetHashCode();
		}
		if (ResetDirectionType != EProjectileResetDirType.None)
		{
			num ^= ResetDirectionType.GetHashCode();
		}
		if (NewDirRoll != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(NewDirRoll);
		}
		if (NewDirPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(NewDirPitch);
		}
		if (NewDirYaw != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(NewDirYaw);
		}
		if (ResetMoveProperty != EGSYesNo.No)
		{
			num ^= ResetMoveProperty.GetHashCode();
		}
		num ^= bulletMoveModeFlySpdFloatParam_.GetHashCode();
		if (BulletMoveModeFlySpdCurvePath.Length != 0)
		{
			num ^= BulletMoveModeFlySpdCurvePath.GetHashCode();
		}
		num ^= bulletMoveModeRotSpdFloatParam_.GetHashCode();
		if (BulletMoveModeRotSpdCurvePath.Length != 0)
		{
			num ^= BulletMoveModeRotSpdCurvePath.GetHashCode();
		}
		num ^= attachBuffID_.GetHashCode();
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
		if (BulletID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BulletID);
		}
		if (ResetTargetType != EProjectileResetTargetType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ResetTargetType);
		}
		if (TargetSocket.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(TargetSocket);
		}
		if (TargetEQSTemplate.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(TargetEQSTemplate);
		}
		if (TargetPointSetCachedReqID != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TargetPointSetCachedReqID);
		}
		if (ResetDirectionType != EProjectileResetDirType.None)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)ResetDirectionType);
		}
		if (NewDirRoll != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(NewDirRoll);
		}
		if (NewDirPitch != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(NewDirPitch);
		}
		if (NewDirYaw != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(NewDirYaw);
		}
		if (ResetMoveProperty != EGSYesNo.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)ResetMoveProperty);
		}
		bulletMoveModeFlySpdFloatParam_.WriteTo(output, _repeated_bulletMoveModeFlySpdFloatParam_codec);
		if (BulletMoveModeFlySpdCurvePath.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(BulletMoveModeFlySpdCurvePath);
		}
		bulletMoveModeRotSpdFloatParam_.WriteTo(output, _repeated_bulletMoveModeRotSpdFloatParam_codec);
		if (BulletMoveModeRotSpdCurvePath.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(BulletMoveModeRotSpdCurvePath);
		}
		attachBuffID_.WriteTo(output, _repeated_attachBuffID_codec);
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
		if (BulletID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BulletID);
		}
		if (ResetTargetType != EProjectileResetTargetType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResetTargetType);
		}
		if (TargetSocket.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TargetSocket);
		}
		if (TargetEQSTemplate.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TargetEQSTemplate);
		}
		if (TargetPointSetCachedReqID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetPointSetCachedReqID);
		}
		if (ResetDirectionType != EProjectileResetDirType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResetDirectionType);
		}
		if (NewDirRoll != 0f)
		{
			num += 5;
		}
		if (NewDirPitch != 0f)
		{
			num += 5;
		}
		if (NewDirYaw != 0f)
		{
			num += 5;
		}
		if (ResetMoveProperty != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResetMoveProperty);
		}
		num += bulletMoveModeFlySpdFloatParam_.CalculateSize(_repeated_bulletMoveModeFlySpdFloatParam_codec);
		if (BulletMoveModeFlySpdCurvePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BulletMoveModeFlySpdCurvePath);
		}
		num += bulletMoveModeRotSpdFloatParam_.CalculateSize(_repeated_bulletMoveModeRotSpdFloatParam_codec);
		if (BulletMoveModeRotSpdCurvePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BulletMoveModeRotSpdCurvePath);
		}
		num += attachBuffID_.CalculateSize(_repeated_attachBuffID_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBulletSwitchDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BulletID != 0)
			{
				BulletID = other.BulletID;
			}
			if (other.ResetTargetType != EProjectileResetTargetType.None)
			{
				ResetTargetType = other.ResetTargetType;
			}
			if (other.TargetSocket.Length != 0)
			{
				TargetSocket = other.TargetSocket;
			}
			if (other.TargetEQSTemplate.Length != 0)
			{
				TargetEQSTemplate = other.TargetEQSTemplate;
			}
			if (other.TargetPointSetCachedReqID != 0)
			{
				TargetPointSetCachedReqID = other.TargetPointSetCachedReqID;
			}
			if (other.ResetDirectionType != EProjectileResetDirType.None)
			{
				ResetDirectionType = other.ResetDirectionType;
			}
			if (other.NewDirRoll != 0f)
			{
				NewDirRoll = other.NewDirRoll;
			}
			if (other.NewDirPitch != 0f)
			{
				NewDirPitch = other.NewDirPitch;
			}
			if (other.NewDirYaw != 0f)
			{
				NewDirYaw = other.NewDirYaw;
			}
			if (other.ResetMoveProperty != EGSYesNo.No)
			{
				ResetMoveProperty = other.ResetMoveProperty;
			}
			bulletMoveModeFlySpdFloatParam_.Add(other.bulletMoveModeFlySpdFloatParam_);
			if (other.BulletMoveModeFlySpdCurvePath.Length != 0)
			{
				BulletMoveModeFlySpdCurvePath = other.BulletMoveModeFlySpdCurvePath;
			}
			bulletMoveModeRotSpdFloatParam_.Add(other.bulletMoveModeRotSpdFloatParam_);
			if (other.BulletMoveModeRotSpdCurvePath.Length != 0)
			{
				BulletMoveModeRotSpdCurvePath = other.BulletMoveModeRotSpdCurvePath;
			}
			attachBuffID_.Add(other.attachBuffID_);
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
				BulletID = input.ReadInt32();
				break;
			case 24u:
				ResetTargetType = (EProjectileResetTargetType)input.ReadEnum();
				break;
			case 34u:
				TargetSocket = input.ReadString();
				break;
			case 42u:
				TargetEQSTemplate = input.ReadString();
				break;
			case 48u:
				TargetPointSetCachedReqID = input.ReadInt32();
				break;
			case 56u:
				ResetDirectionType = (EProjectileResetDirType)input.ReadEnum();
				break;
			case 69u:
				NewDirRoll = input.ReadFloat();
				break;
			case 77u:
				NewDirPitch = input.ReadFloat();
				break;
			case 85u:
				NewDirYaw = input.ReadFloat();
				break;
			case 88u:
				ResetMoveProperty = (EGSYesNo)input.ReadEnum();
				break;
			case 98u:
			case 101u:
				bulletMoveModeFlySpdFloatParam_.AddEntriesFrom(input, _repeated_bulletMoveModeFlySpdFloatParam_codec);
				break;
			case 106u:
				BulletMoveModeFlySpdCurvePath = input.ReadString();
				break;
			case 114u:
			case 117u:
				bulletMoveModeRotSpdFloatParam_.AddEntriesFrom(input, _repeated_bulletMoveModeRotSpdFloatParam_codec);
				break;
			case 122u:
				BulletMoveModeRotSpdCurvePath = input.ReadString();
				break;
			case 128u:
			case 130u:
				attachBuffID_.AddEntriesFrom(input, _repeated_attachBuffID_codec);
				break;
			}
		}
	}
}
