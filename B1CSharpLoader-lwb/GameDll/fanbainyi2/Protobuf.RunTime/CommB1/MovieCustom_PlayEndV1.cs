using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_PlayEndV1 : IMessage<MovieCustom_PlayEndV1>, IMessage, IEquatable<MovieCustom_PlayEndV1>, IDeepCloneable<MovieCustom_PlayEndV1>
{
	private static readonly MessageParser<MovieCustom_PlayEndV1> _parser = new MessageParser<MovieCustom_PlayEndV1>(() => new MovieCustom_PlayEndV1());

	private UnknownFieldSet _unknownFields;

	private float cameraBlendOutTime_;

	private int cameraBlendOutFunc_;

	private float cameraBlendOutExp_;

	private bool blendOutBeforeCamera_;

	private int resetSpringArmRotationWay_;

	private float customControllerRotationPitch_;

	private float customControllerRotationYaw_;

	private float customControllerRotationRoll_;

	public static MessageParser<MovieCustom_PlayEndV1> Parser => _parser;

	public float CameraBlendOutTime
	{
		get
		{
			return cameraBlendOutTime_;
		}
		set
		{
			cameraBlendOutTime_ = value;
		}
	}

	public int CameraBlendOutFunc
	{
		get
		{
			return cameraBlendOutFunc_;
		}
		set
		{
			cameraBlendOutFunc_ = value;
		}
	}

	public float CameraBlendOutExp
	{
		get
		{
			return cameraBlendOutExp_;
		}
		set
		{
			cameraBlendOutExp_ = value;
		}
	}

	public bool BlendOutBeforeCamera
	{
		get
		{
			return blendOutBeforeCamera_;
		}
		set
		{
			blendOutBeforeCamera_ = value;
		}
	}

	public int ResetSpringArmRotationWay
	{
		get
		{
			return resetSpringArmRotationWay_;
		}
		set
		{
			resetSpringArmRotationWay_ = value;
		}
	}

	public float CustomControllerRotationPitch
	{
		get
		{
			return customControllerRotationPitch_;
		}
		set
		{
			customControllerRotationPitch_ = value;
		}
	}

	public float CustomControllerRotationYaw
	{
		get
		{
			return customControllerRotationYaw_;
		}
		set
		{
			customControllerRotationYaw_ = value;
		}
	}

	public float CustomControllerRotationRoll
	{
		get
		{
			return customControllerRotationRoll_;
		}
		set
		{
			customControllerRotationRoll_ = value;
		}
	}

	public MovieCustom_PlayEndV1()
	{
	}

	public MovieCustom_PlayEndV1(MovieCustom_PlayEndV1 other)
		: this()
	{
		cameraBlendOutTime_ = other.cameraBlendOutTime_;
		cameraBlendOutFunc_ = other.cameraBlendOutFunc_;
		cameraBlendOutExp_ = other.cameraBlendOutExp_;
		blendOutBeforeCamera_ = other.blendOutBeforeCamera_;
		resetSpringArmRotationWay_ = other.resetSpringArmRotationWay_;
		customControllerRotationPitch_ = other.customControllerRotationPitch_;
		customControllerRotationYaw_ = other.customControllerRotationYaw_;
		customControllerRotationRoll_ = other.customControllerRotationRoll_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PlayEndV1 Clone()
	{
		return new MovieCustom_PlayEndV1(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PlayEndV1);
	}

	public bool Equals(MovieCustom_PlayEndV1 other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraBlendOutTime, other.CameraBlendOutTime))
		{
			return false;
		}
		if (CameraBlendOutFunc != other.CameraBlendOutFunc)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraBlendOutExp, other.CameraBlendOutExp))
		{
			return false;
		}
		if (BlendOutBeforeCamera != other.BlendOutBeforeCamera)
		{
			return false;
		}
		if (ResetSpringArmRotationWay != other.ResetSpringArmRotationWay)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CustomControllerRotationPitch, other.CustomControllerRotationPitch))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CustomControllerRotationYaw, other.CustomControllerRotationYaw))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CustomControllerRotationRoll, other.CustomControllerRotationRoll))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CameraBlendOutTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraBlendOutTime);
		}
		if (CameraBlendOutFunc != 0)
		{
			num ^= CameraBlendOutFunc.GetHashCode();
		}
		if (CameraBlendOutExp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraBlendOutExp);
		}
		if (BlendOutBeforeCamera)
		{
			num ^= BlendOutBeforeCamera.GetHashCode();
		}
		if (ResetSpringArmRotationWay != 0)
		{
			num ^= ResetSpringArmRotationWay.GetHashCode();
		}
		if (CustomControllerRotationPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CustomControllerRotationPitch);
		}
		if (CustomControllerRotationYaw != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CustomControllerRotationYaw);
		}
		if (CustomControllerRotationRoll != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CustomControllerRotationRoll);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CameraBlendOutTime != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(CameraBlendOutTime);
		}
		if (CameraBlendOutFunc != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CameraBlendOutFunc);
		}
		if (CameraBlendOutExp != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(CameraBlendOutExp);
		}
		if (BlendOutBeforeCamera)
		{
			output.WriteRawTag(32);
			output.WriteBool(BlendOutBeforeCamera);
		}
		if (ResetSpringArmRotationWay != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ResetSpringArmRotationWay);
		}
		if (CustomControllerRotationPitch != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(CustomControllerRotationPitch);
		}
		if (CustomControllerRotationYaw != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(CustomControllerRotationYaw);
		}
		if (CustomControllerRotationRoll != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(CustomControllerRotationRoll);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CameraBlendOutTime != 0f)
		{
			num += 5;
		}
		if (CameraBlendOutFunc != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CameraBlendOutFunc);
		}
		if (CameraBlendOutExp != 0f)
		{
			num += 5;
		}
		if (BlendOutBeforeCamera)
		{
			num += 2;
		}
		if (ResetSpringArmRotationWay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResetSpringArmRotationWay);
		}
		if (CustomControllerRotationPitch != 0f)
		{
			num += 5;
		}
		if (CustomControllerRotationYaw != 0f)
		{
			num += 5;
		}
		if (CustomControllerRotationRoll != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PlayEndV1 other)
	{
		if (other != null)
		{
			if (other.CameraBlendOutTime != 0f)
			{
				CameraBlendOutTime = other.CameraBlendOutTime;
			}
			if (other.CameraBlendOutFunc != 0)
			{
				CameraBlendOutFunc = other.CameraBlendOutFunc;
			}
			if (other.CameraBlendOutExp != 0f)
			{
				CameraBlendOutExp = other.CameraBlendOutExp;
			}
			if (other.BlendOutBeforeCamera)
			{
				BlendOutBeforeCamera = other.BlendOutBeforeCamera;
			}
			if (other.ResetSpringArmRotationWay != 0)
			{
				ResetSpringArmRotationWay = other.ResetSpringArmRotationWay;
			}
			if (other.CustomControllerRotationPitch != 0f)
			{
				CustomControllerRotationPitch = other.CustomControllerRotationPitch;
			}
			if (other.CustomControllerRotationYaw != 0f)
			{
				CustomControllerRotationYaw = other.CustomControllerRotationYaw;
			}
			if (other.CustomControllerRotationRoll != 0f)
			{
				CustomControllerRotationRoll = other.CustomControllerRotationRoll;
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
			case 13u:
				CameraBlendOutTime = input.ReadFloat();
				break;
			case 16u:
				CameraBlendOutFunc = input.ReadInt32();
				break;
			case 29u:
				CameraBlendOutExp = input.ReadFloat();
				break;
			case 32u:
				BlendOutBeforeCamera = input.ReadBool();
				break;
			case 40u:
				ResetSpringArmRotationWay = input.ReadInt32();
				break;
			case 53u:
				CustomControllerRotationPitch = input.ReadFloat();
				break;
			case 61u:
				CustomControllerRotationYaw = input.ReadFloat();
				break;
			case 69u:
				CustomControllerRotationRoll = input.ReadFloat();
				break;
			}
		}
	}
}
