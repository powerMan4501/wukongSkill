using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_Cut : IMessage<MovieCustom_Cut>, IMessage, IEquatable<MovieCustom_Cut>, IDeepCloneable<MovieCustom_Cut>
{
	private static readonly MessageParser<MovieCustom_Cut> _parser = new MessageParser<MovieCustom_Cut>(() => new MovieCustom_Cut());

	private UnknownFieldSet _unknownFields;

	private string cutSequencePath_ = "";

	private string cameraTag_ = "";

	private string railTag_ = "";

	private string craneTag_ = "";

	private bool isUseCinematicCamera_;

	private bool isUseRail_;

	private bool isUseCrane_;

	private float cameraBlendTime_;

	private int cameraBlendFunc_;

	private float cameraBlendExp_;

	private bool isLoopPlay_;

	public static MessageParser<MovieCustom_Cut> Parser => _parser;

	public string CutSequencePath
	{
		get
		{
			return cutSequencePath_;
		}
		set
		{
			cutSequencePath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public string RailTag
	{
		get
		{
			return railTag_;
		}
		set
		{
			railTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string CraneTag
	{
		get
		{
			return craneTag_;
		}
		set
		{
			craneTag_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public bool IsUseRail
	{
		get
		{
			return isUseRail_;
		}
		set
		{
			isUseRail_ = value;
		}
	}

	public bool IsUseCrane
	{
		get
		{
			return isUseCrane_;
		}
		set
		{
			isUseCrane_ = value;
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

	public bool IsLoopPlay
	{
		get
		{
			return isLoopPlay_;
		}
		set
		{
			isLoopPlay_ = value;
		}
	}

	public MovieCustom_Cut()
	{
	}

	public MovieCustom_Cut(MovieCustom_Cut other)
		: this()
	{
		cutSequencePath_ = other.cutSequencePath_;
		cameraTag_ = other.cameraTag_;
		railTag_ = other.railTag_;
		craneTag_ = other.craneTag_;
		isUseCinematicCamera_ = other.isUseCinematicCamera_;
		isUseRail_ = other.isUseRail_;
		isUseCrane_ = other.isUseCrane_;
		cameraBlendTime_ = other.cameraBlendTime_;
		cameraBlendFunc_ = other.cameraBlendFunc_;
		cameraBlendExp_ = other.cameraBlendExp_;
		isLoopPlay_ = other.isLoopPlay_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_Cut Clone()
	{
		return new MovieCustom_Cut(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_Cut);
	}

	public bool Equals(MovieCustom_Cut other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CutSequencePath != other.CutSequencePath)
		{
			return false;
		}
		if (CameraTag != other.CameraTag)
		{
			return false;
		}
		if (RailTag != other.RailTag)
		{
			return false;
		}
		if (CraneTag != other.CraneTag)
		{
			return false;
		}
		if (IsUseCinematicCamera != other.IsUseCinematicCamera)
		{
			return false;
		}
		if (IsUseRail != other.IsUseRail)
		{
			return false;
		}
		if (IsUseCrane != other.IsUseCrane)
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
		if (IsLoopPlay != other.IsLoopPlay)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CutSequencePath.Length != 0)
		{
			num ^= CutSequencePath.GetHashCode();
		}
		if (CameraTag.Length != 0)
		{
			num ^= CameraTag.GetHashCode();
		}
		if (RailTag.Length != 0)
		{
			num ^= RailTag.GetHashCode();
		}
		if (CraneTag.Length != 0)
		{
			num ^= CraneTag.GetHashCode();
		}
		if (IsUseCinematicCamera)
		{
			num ^= IsUseCinematicCamera.GetHashCode();
		}
		if (IsUseRail)
		{
			num ^= IsUseRail.GetHashCode();
		}
		if (IsUseCrane)
		{
			num ^= IsUseCrane.GetHashCode();
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
		if (IsLoopPlay)
		{
			num ^= IsLoopPlay.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CutSequencePath.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(CutSequencePath);
		}
		if (CameraTag.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(CameraTag);
		}
		if (RailTag.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(RailTag);
		}
		if (CraneTag.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(CraneTag);
		}
		if (IsUseCinematicCamera)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsUseCinematicCamera);
		}
		if (IsUseRail)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsUseRail);
		}
		if (IsUseCrane)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsUseCrane);
		}
		if (CameraBlendTime != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(CameraBlendTime);
		}
		if (CameraBlendFunc != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(CameraBlendFunc);
		}
		if (CameraBlendExp != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(CameraBlendExp);
		}
		if (IsLoopPlay)
		{
			output.WriteRawTag(88);
			output.WriteBool(IsLoopPlay);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CutSequencePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CutSequencePath);
		}
		if (CameraTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CameraTag);
		}
		if (RailTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RailTag);
		}
		if (CraneTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CraneTag);
		}
		if (IsUseCinematicCamera)
		{
			num += 2;
		}
		if (IsUseRail)
		{
			num += 2;
		}
		if (IsUseCrane)
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
		if (IsLoopPlay)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_Cut other)
	{
		if (other != null)
		{
			if (other.CutSequencePath.Length != 0)
			{
				CutSequencePath = other.CutSequencePath;
			}
			if (other.CameraTag.Length != 0)
			{
				CameraTag = other.CameraTag;
			}
			if (other.RailTag.Length != 0)
			{
				RailTag = other.RailTag;
			}
			if (other.CraneTag.Length != 0)
			{
				CraneTag = other.CraneTag;
			}
			if (other.IsUseCinematicCamera)
			{
				IsUseCinematicCamera = other.IsUseCinematicCamera;
			}
			if (other.IsUseRail)
			{
				IsUseRail = other.IsUseRail;
			}
			if (other.IsUseCrane)
			{
				IsUseCrane = other.IsUseCrane;
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
			if (other.IsLoopPlay)
			{
				IsLoopPlay = other.IsLoopPlay;
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
				CutSequencePath = input.ReadString();
				break;
			case 18u:
				CameraTag = input.ReadString();
				break;
			case 26u:
				RailTag = input.ReadString();
				break;
			case 34u:
				CraneTag = input.ReadString();
				break;
			case 40u:
				IsUseCinematicCamera = input.ReadBool();
				break;
			case 48u:
				IsUseRail = input.ReadBool();
				break;
			case 56u:
				IsUseCrane = input.ReadBool();
				break;
			case 69u:
				CameraBlendTime = input.ReadFloat();
				break;
			case 72u:
				CameraBlendFunc = input.ReadInt32();
				break;
			case 85u:
				CameraBlendExp = input.ReadFloat();
				break;
			case 88u:
				IsLoopPlay = input.ReadBool();
				break;
			}
		}
	}
}
