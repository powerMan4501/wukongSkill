using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_SetCameraTransform : IMessage<QuestCustom_SetCameraTransform>, IMessage, IEquatable<QuestCustom_SetCameraTransform>, IDeepCloneable<QuestCustom_SetCameraTransform>
{
	private static readonly MessageParser<QuestCustom_SetCameraTransform> _parser = new MessageParser<QuestCustom_SetCameraTransform>(() => new QuestCustom_SetCameraTransform());

	private UnknownFieldSet _unknownFields;

	private string cameraTag_ = "";

	private bool isCineCamera_;

	private float cameraTransformX_;

	private float cameraTransformY_;

	private float cameraTransformZ_;

	private float cameraTransformPitch_;

	private float cameraTransformYaw_;

	private float cameraTransformRoll_;

	private float cameraTransformSx_;

	private float cameraTransformSy_;

	private float cameraTransformSz_;

	public static MessageParser<QuestCustom_SetCameraTransform> Parser => _parser;

	public string CameraTag
	{
		get
		{
			return cameraTag_;
		}
		set
		{
			cameraTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsCineCamera
	{
		get
		{
			return isCineCamera_;
		}
		set
		{
			isCineCamera_ = value;
		}
	}

	public float CameraTransformX
	{
		get
		{
			return cameraTransformX_;
		}
		set
		{
			cameraTransformX_ = value;
		}
	}

	public float CameraTransformY
	{
		get
		{
			return cameraTransformY_;
		}
		set
		{
			cameraTransformY_ = value;
		}
	}

	public float CameraTransformZ
	{
		get
		{
			return cameraTransformZ_;
		}
		set
		{
			cameraTransformZ_ = value;
		}
	}

	public float CameraTransformPitch
	{
		get
		{
			return cameraTransformPitch_;
		}
		set
		{
			cameraTransformPitch_ = value;
		}
	}

	public float CameraTransformYaw
	{
		get
		{
			return cameraTransformYaw_;
		}
		set
		{
			cameraTransformYaw_ = value;
		}
	}

	public float CameraTransformRoll
	{
		get
		{
			return cameraTransformRoll_;
		}
		set
		{
			cameraTransformRoll_ = value;
		}
	}

	public float CameraTransformSx
	{
		get
		{
			return cameraTransformSx_;
		}
		set
		{
			cameraTransformSx_ = value;
		}
	}

	public float CameraTransformSy
	{
		get
		{
			return cameraTransformSy_;
		}
		set
		{
			cameraTransformSy_ = value;
		}
	}

	public float CameraTransformSz
	{
		get
		{
			return cameraTransformSz_;
		}
		set
		{
			cameraTransformSz_ = value;
		}
	}

	public QuestCustom_SetCameraTransform()
	{
	}

	public QuestCustom_SetCameraTransform(QuestCustom_SetCameraTransform other)
		: this()
	{
		cameraTag_ = other.cameraTag_;
		isCineCamera_ = other.isCineCamera_;
		cameraTransformX_ = other.cameraTransformX_;
		cameraTransformY_ = other.cameraTransformY_;
		cameraTransformZ_ = other.cameraTransformZ_;
		cameraTransformPitch_ = other.cameraTransformPitch_;
		cameraTransformYaw_ = other.cameraTransformYaw_;
		cameraTransformRoll_ = other.cameraTransformRoll_;
		cameraTransformSx_ = other.cameraTransformSx_;
		cameraTransformSy_ = other.cameraTransformSy_;
		cameraTransformSz_ = other.cameraTransformSz_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_SetCameraTransform Clone()
	{
		return new QuestCustom_SetCameraTransform(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_SetCameraTransform);
	}

	public bool Equals(QuestCustom_SetCameraTransform other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CameraTag != other.CameraTag)
		{
			return false;
		}
		if (IsCineCamera != other.IsCineCamera)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraTransformX, other.CameraTransformX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraTransformY, other.CameraTransformY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraTransformZ, other.CameraTransformZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraTransformPitch, other.CameraTransformPitch))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraTransformYaw, other.CameraTransformYaw))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraTransformRoll, other.CameraTransformRoll))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraTransformSx, other.CameraTransformSx))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraTransformSy, other.CameraTransformSy))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraTransformSz, other.CameraTransformSz))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CameraTag.Length != 0)
		{
			num ^= CameraTag.GetHashCode();
		}
		if (IsCineCamera)
		{
			num ^= IsCineCamera.GetHashCode();
		}
		if (CameraTransformX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraTransformX);
		}
		if (CameraTransformY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraTransformY);
		}
		if (CameraTransformZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraTransformZ);
		}
		if (CameraTransformPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraTransformPitch);
		}
		if (CameraTransformYaw != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraTransformYaw);
		}
		if (CameraTransformRoll != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraTransformRoll);
		}
		if (CameraTransformSx != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraTransformSx);
		}
		if (CameraTransformSy != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraTransformSy);
		}
		if (CameraTransformSz != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraTransformSz);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CameraTag.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(CameraTag);
		}
		if (IsCineCamera)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsCineCamera);
		}
		if (CameraTransformX != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(CameraTransformX);
		}
		if (CameraTransformY != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(CameraTransformY);
		}
		if (CameraTransformZ != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(CameraTransformZ);
		}
		if (CameraTransformPitch != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(CameraTransformPitch);
		}
		if (CameraTransformYaw != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(CameraTransformYaw);
		}
		if (CameraTransformRoll != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(CameraTransformRoll);
		}
		if (CameraTransformSx != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(CameraTransformSx);
		}
		if (CameraTransformSy != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(CameraTransformSy);
		}
		if (CameraTransformSz != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(CameraTransformSz);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CameraTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CameraTag);
		}
		if (IsCineCamera)
		{
			num += 2;
		}
		if (CameraTransformX != 0f)
		{
			num += 5;
		}
		if (CameraTransformY != 0f)
		{
			num += 5;
		}
		if (CameraTransformZ != 0f)
		{
			num += 5;
		}
		if (CameraTransformPitch != 0f)
		{
			num += 5;
		}
		if (CameraTransformYaw != 0f)
		{
			num += 5;
		}
		if (CameraTransformRoll != 0f)
		{
			num += 5;
		}
		if (CameraTransformSx != 0f)
		{
			num += 5;
		}
		if (CameraTransformSy != 0f)
		{
			num += 5;
		}
		if (CameraTransformSz != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_SetCameraTransform other)
	{
		if (other != null)
		{
			if (other.CameraTag.Length != 0)
			{
				CameraTag = other.CameraTag;
			}
			if (other.IsCineCamera)
			{
				IsCineCamera = other.IsCineCamera;
			}
			if (other.CameraTransformX != 0f)
			{
				CameraTransformX = other.CameraTransformX;
			}
			if (other.CameraTransformY != 0f)
			{
				CameraTransformY = other.CameraTransformY;
			}
			if (other.CameraTransformZ != 0f)
			{
				CameraTransformZ = other.CameraTransformZ;
			}
			if (other.CameraTransformPitch != 0f)
			{
				CameraTransformPitch = other.CameraTransformPitch;
			}
			if (other.CameraTransformYaw != 0f)
			{
				CameraTransformYaw = other.CameraTransformYaw;
			}
			if (other.CameraTransformRoll != 0f)
			{
				CameraTransformRoll = other.CameraTransformRoll;
			}
			if (other.CameraTransformSx != 0f)
			{
				CameraTransformSx = other.CameraTransformSx;
			}
			if (other.CameraTransformSy != 0f)
			{
				CameraTransformSy = other.CameraTransformSy;
			}
			if (other.CameraTransformSz != 0f)
			{
				CameraTransformSz = other.CameraTransformSz;
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
				CameraTag = input.ReadString();
				break;
			case 16u:
				IsCineCamera = input.ReadBool();
				break;
			case 29u:
				CameraTransformX = input.ReadFloat();
				break;
			case 37u:
				CameraTransformY = input.ReadFloat();
				break;
			case 45u:
				CameraTransformZ = input.ReadFloat();
				break;
			case 53u:
				CameraTransformPitch = input.ReadFloat();
				break;
			case 61u:
				CameraTransformYaw = input.ReadFloat();
				break;
			case 69u:
				CameraTransformRoll = input.ReadFloat();
				break;
			case 77u:
				CameraTransformSx = input.ReadFloat();
				break;
			case 85u:
				CameraTransformSy = input.ReadFloat();
				break;
			case 93u:
				CameraTransformSz = input.ReadFloat();
				break;
			}
		}
	}
}
