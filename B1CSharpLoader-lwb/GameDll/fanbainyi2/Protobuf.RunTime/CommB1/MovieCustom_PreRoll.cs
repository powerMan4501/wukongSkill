using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_PreRoll : IMessage<MovieCustom_PreRoll>, IMessage, IEquatable<MovieCustom_PreRoll>, IDeepCloneable<MovieCustom_PreRoll>
{
	private static readonly MessageParser<MovieCustom_PreRoll> _parser = new MessageParser<MovieCustom_PreRoll>(() => new MovieCustom_PreRoll());

	private UnknownFieldSet _unknownFields;

	private string preRollSequencePath_ = "";

	private string cameraTag_ = "";

	private bool isUseCinematicCamera_;

	private float cameraBlendTime_;

	private int cameraBlendFunc_;

	private float cameraBlendExp_;

	private bool isStopPreRollWhenFinish_;

	public static MessageParser<MovieCustom_PreRoll> Parser => _parser;

	public string PreRollSequencePath
	{
		get
		{
			return preRollSequencePath_;
		}
		set
		{
			preRollSequencePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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

	public bool IsUseCinematicCamera
	{
		get
		{
			return isUseCinematicCamera_;
		}
		set
		{
			isUseCinematicCamera_ = value;
		}
	}

	public float CameraBlendTime
	{
		get
		{
			return cameraBlendTime_;
		}
		set
		{
			cameraBlendTime_ = value;
		}
	}

	public int CameraBlendFunc
	{
		get
		{
			return cameraBlendFunc_;
		}
		set
		{
			cameraBlendFunc_ = value;
		}
	}

	public float CameraBlendExp
	{
		get
		{
			return cameraBlendExp_;
		}
		set
		{
			cameraBlendExp_ = value;
		}
	}

	public bool IsStopPreRollWhenFinish
	{
		get
		{
			return isStopPreRollWhenFinish_;
		}
		set
		{
			isStopPreRollWhenFinish_ = value;
		}
	}

	public MovieCustom_PreRoll()
	{
	}

	public MovieCustom_PreRoll(MovieCustom_PreRoll other)
		: this()
	{
		preRollSequencePath_ = other.preRollSequencePath_;
		cameraTag_ = other.cameraTag_;
		isUseCinematicCamera_ = other.isUseCinematicCamera_;
		cameraBlendTime_ = other.cameraBlendTime_;
		cameraBlendFunc_ = other.cameraBlendFunc_;
		cameraBlendExp_ = other.cameraBlendExp_;
		isStopPreRollWhenFinish_ = other.isStopPreRollWhenFinish_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PreRoll Clone()
	{
		return new MovieCustom_PreRoll(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PreRoll);
	}

	public bool Equals(MovieCustom_PreRoll other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PreRollSequencePath != other.PreRollSequencePath)
		{
			return false;
		}
		if (CameraTag != other.CameraTag)
		{
			return false;
		}
		if (IsUseCinematicCamera != other.IsUseCinematicCamera)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraBlendTime, other.CameraBlendTime))
		{
			return false;
		}
		if (CameraBlendFunc != other.CameraBlendFunc)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraBlendExp, other.CameraBlendExp))
		{
			return false;
		}
		if (IsStopPreRollWhenFinish != other.IsStopPreRollWhenFinish)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PreRollSequencePath.Length != 0)
		{
			num ^= PreRollSequencePath.GetHashCode();
		}
		if (CameraTag.Length != 0)
		{
			num ^= CameraTag.GetHashCode();
		}
		if (IsUseCinematicCamera)
		{
			num ^= IsUseCinematicCamera.GetHashCode();
		}
		if (CameraBlendTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraBlendTime);
		}
		if (CameraBlendFunc != 0)
		{
			num ^= CameraBlendFunc.GetHashCode();
		}
		if (CameraBlendExp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraBlendExp);
		}
		if (IsStopPreRollWhenFinish)
		{
			num ^= IsStopPreRollWhenFinish.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PreRollSequencePath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PreRollSequencePath);
		}
		if (CameraTag.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(CameraTag);
		}
		if (IsUseCinematicCamera)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsUseCinematicCamera);
		}
		if (CameraBlendTime != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(CameraBlendTime);
		}
		if (CameraBlendFunc != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CameraBlendFunc);
		}
		if (CameraBlendExp != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(CameraBlendExp);
		}
		if (IsStopPreRollWhenFinish)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsStopPreRollWhenFinish);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PreRollSequencePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PreRollSequencePath);
		}
		if (CameraTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CameraTag);
		}
		if (IsUseCinematicCamera)
		{
			num += 2;
		}
		if (CameraBlendTime != 0f)
		{
			num += 5;
		}
		if (CameraBlendFunc != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CameraBlendFunc);
		}
		if (CameraBlendExp != 0f)
		{
			num += 5;
		}
		if (IsStopPreRollWhenFinish)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PreRoll other)
	{
		if (other != null)
		{
			if (other.PreRollSequencePath.Length != 0)
			{
				PreRollSequencePath = other.PreRollSequencePath;
			}
			if (other.CameraTag.Length != 0)
			{
				CameraTag = other.CameraTag;
			}
			if (other.IsUseCinematicCamera)
			{
				IsUseCinematicCamera = other.IsUseCinematicCamera;
			}
			if (other.CameraBlendTime != 0f)
			{
				CameraBlendTime = other.CameraBlendTime;
			}
			if (other.CameraBlendFunc != 0)
			{
				CameraBlendFunc = other.CameraBlendFunc;
			}
			if (other.CameraBlendExp != 0f)
			{
				CameraBlendExp = other.CameraBlendExp;
			}
			if (other.IsStopPreRollWhenFinish)
			{
				IsStopPreRollWhenFinish = other.IsStopPreRollWhenFinish;
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
				PreRollSequencePath = input.ReadString();
				break;
			case 18u:
				CameraTag = input.ReadString();
				break;
			case 24u:
				IsUseCinematicCamera = input.ReadBool();
				break;
			case 37u:
				CameraBlendTime = input.ReadFloat();
				break;
			case 40u:
				CameraBlendFunc = input.ReadInt32();
				break;
			case 53u:
				CameraBlendExp = input.ReadFloat();
				break;
			case 56u:
				IsStopPreRollWhenFinish = input.ReadBool();
				break;
			}
		}
	}
}
