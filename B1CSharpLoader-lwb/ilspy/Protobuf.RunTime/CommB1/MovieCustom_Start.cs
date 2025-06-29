using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_Start : IMessage<MovieCustom_Start>, IMessage, IEquatable<MovieCustom_Start>, IDeepCloneable<MovieCustom_Start>
{
	private static readonly MessageParser<MovieCustom_Start> _parser = new MessageParser<MovieCustom_Start>(() => new MovieCustom_Start());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CalliopeCustom_LevelSequenceConfig> _repeated_startSequences_codec = FieldCodec.ForMessage(10u, CalliopeCustom_LevelSequenceConfig.Parser);

	private readonly RepeatedField<CalliopeCustom_LevelSequenceConfig> startSequences_ = new RepeatedField<CalliopeCustom_LevelSequenceConfig>();

	private float startTimeSeconds_;

	private bool isUseCinematicCamera_;

	private bool isUseRail_;

	private bool isUseCrane_;

	private float cameraBlendInTime_;

	private int cameraBlendInFunc_;

	private float cameraBlendInExp_;

	private bool isLoopPlay_;

	public static MessageParser<MovieCustom_Start> Parser => _parser;

	public RepeatedField<CalliopeCustom_LevelSequenceConfig> StartSequences => startSequences_;

	public float StartTimeSeconds
	{
		get
		{
			return startTimeSeconds_;
		}
		set
		{
			startTimeSeconds_ = value;
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

	public float CameraBlendInTime
	{
		get
		{
			return cameraBlendInTime_;
		}
		set
		{
			cameraBlendInTime_ = value;
		}
	}

	public int CameraBlendInFunc
	{
		get
		{
			return cameraBlendInFunc_;
		}
		set
		{
			cameraBlendInFunc_ = value;
		}
	}

	public float CameraBlendInExp
	{
		get
		{
			return cameraBlendInExp_;
		}
		set
		{
			cameraBlendInExp_ = value;
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

	public MovieCustom_Start()
	{
	}

	public MovieCustom_Start(MovieCustom_Start other)
		: this()
	{
		startSequences_ = other.startSequences_.Clone();
		startTimeSeconds_ = other.startTimeSeconds_;
		isUseCinematicCamera_ = other.isUseCinematicCamera_;
		isUseRail_ = other.isUseRail_;
		isUseCrane_ = other.isUseCrane_;
		cameraBlendInTime_ = other.cameraBlendInTime_;
		cameraBlendInFunc_ = other.cameraBlendInFunc_;
		cameraBlendInExp_ = other.cameraBlendInExp_;
		isLoopPlay_ = other.isLoopPlay_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_Start Clone()
	{
		return new MovieCustom_Start(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_Start);
	}

	public bool Equals(MovieCustom_Start other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!startSequences_.Equals(other.startSequences_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(StartTimeSeconds, other.StartTimeSeconds))
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraBlendInTime, other.CameraBlendInTime))
		{
			return false;
		}
		if (CameraBlendInFunc != other.CameraBlendInFunc)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraBlendInExp, other.CameraBlendInExp))
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
		num ^= startSequences_.GetHashCode();
		if (StartTimeSeconds != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(StartTimeSeconds);
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
		if (CameraBlendInTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraBlendInTime);
		}
		if (CameraBlendInFunc != 0)
		{
			num ^= CameraBlendInFunc.GetHashCode();
		}
		if (CameraBlendInExp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraBlendInExp);
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
		startSequences_.WriteTo(output, _repeated_startSequences_codec);
		if (StartTimeSeconds != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(StartTimeSeconds);
		}
		if (IsUseCinematicCamera)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsUseCinematicCamera);
		}
		if (IsUseRail)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsUseRail);
		}
		if (IsUseCrane)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsUseCrane);
		}
		if (CameraBlendInTime != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(CameraBlendInTime);
		}
		if (CameraBlendInFunc != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CameraBlendInFunc);
		}
		if (CameraBlendInExp != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(CameraBlendInExp);
		}
		if (IsLoopPlay)
		{
			output.WriteRawTag(72);
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
		num += startSequences_.CalculateSize(_repeated_startSequences_codec);
		if (StartTimeSeconds != 0f)
		{
			num += 5;
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
		if (CameraBlendInTime != 0f)
		{
			num += 5;
		}
		if (CameraBlendInFunc != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CameraBlendInFunc);
		}
		if (CameraBlendInExp != 0f)
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

	public void MergeFrom(MovieCustom_Start other)
	{
		if (other != null)
		{
			startSequences_.Add(other.startSequences_);
			if (other.StartTimeSeconds != 0f)
			{
				StartTimeSeconds = other.StartTimeSeconds;
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
			if (other.CameraBlendInTime != 0f)
			{
				CameraBlendInTime = other.CameraBlendInTime;
			}
			if (other.CameraBlendInFunc != 0)
			{
				CameraBlendInFunc = other.CameraBlendInFunc;
			}
			if (other.CameraBlendInExp != 0f)
			{
				CameraBlendInExp = other.CameraBlendInExp;
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
				startSequences_.AddEntriesFrom(input, _repeated_startSequences_codec);
				break;
			case 21u:
				StartTimeSeconds = input.ReadFloat();
				break;
			case 24u:
				IsUseCinematicCamera = input.ReadBool();
				break;
			case 32u:
				IsUseRail = input.ReadBool();
				break;
			case 40u:
				IsUseCrane = input.ReadBool();
				break;
			case 53u:
				CameraBlendInTime = input.ReadFloat();
				break;
			case 56u:
				CameraBlendInFunc = input.ReadInt32();
				break;
			case 69u:
				CameraBlendInExp = input.ReadFloat();
				break;
			case 72u:
				IsLoopPlay = input.ReadBool();
				break;
			}
		}
	}
}
