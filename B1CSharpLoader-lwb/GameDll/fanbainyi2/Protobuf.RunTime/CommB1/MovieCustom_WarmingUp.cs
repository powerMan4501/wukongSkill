using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_WarmingUp : IMessage<MovieCustom_WarmingUp>, IMessage, IEquatable<MovieCustom_WarmingUp>, IDeepCloneable<MovieCustom_WarmingUp>
{
	private static readonly MessageParser<MovieCustom_WarmingUp> _parser = new MessageParser<MovieCustom_WarmingUp>(() => new MovieCustom_WarmingUp());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CalliopeCustom_LevelSequenceConfig> _repeated_startSequences_codec = FieldCodec.ForMessage(10u, CalliopeCustom_LevelSequenceConfig.Parser);

	private readonly RepeatedField<CalliopeCustom_LevelSequenceConfig> startSequences_ = new RepeatedField<CalliopeCustom_LevelSequenceConfig>();

	private bool isUseMarkFrameLoop_;

	private bool isUseCinematicCamera_;

	private float cameraBlendInTime_;

	private int cameraBlendInFunc_;

	private float cameraBlendInExp_;

	private static readonly FieldCodec<string> _repeated_streamingLevelNameList_codec = FieldCodec.ForString(58u);

	private readonly RepeatedField<string> streamingLevelNameList_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_performers_codec = FieldCodec.ForString(66u);

	private readonly RepeatedField<string> performers_ = new RepeatedField<string>();

	private bool isUseBlockLoad_;

	public static MessageParser<MovieCustom_WarmingUp> Parser => _parser;

	public RepeatedField<CalliopeCustom_LevelSequenceConfig> StartSequences => startSequences_;

	public bool IsUseMarkFrameLoop
	{
		get
		{
			return isUseMarkFrameLoop_;
		}
		set
		{
			isUseMarkFrameLoop_ = value;
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

	public RepeatedField<string> StreamingLevelNameList => streamingLevelNameList_;

	public RepeatedField<string> Performers => performers_;

	public bool IsUseBlockLoad
	{
		get
		{
			return isUseBlockLoad_;
		}
		set
		{
			isUseBlockLoad_ = value;
		}
	}

	public MovieCustom_WarmingUp()
	{
	}

	public MovieCustom_WarmingUp(MovieCustom_WarmingUp other)
		: this()
	{
		startSequences_ = other.startSequences_.Clone();
		isUseMarkFrameLoop_ = other.isUseMarkFrameLoop_;
		isUseCinematicCamera_ = other.isUseCinematicCamera_;
		cameraBlendInTime_ = other.cameraBlendInTime_;
		cameraBlendInFunc_ = other.cameraBlendInFunc_;
		cameraBlendInExp_ = other.cameraBlendInExp_;
		streamingLevelNameList_ = other.streamingLevelNameList_.Clone();
		performers_ = other.performers_.Clone();
		isUseBlockLoad_ = other.isUseBlockLoad_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_WarmingUp Clone()
	{
		return new MovieCustom_WarmingUp(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_WarmingUp);
	}

	public bool Equals(MovieCustom_WarmingUp other)
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
		if (IsUseMarkFrameLoop != other.IsUseMarkFrameLoop)
		{
			return false;
		}
		if (IsUseCinematicCamera != other.IsUseCinematicCamera)
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
		if (!streamingLevelNameList_.Equals(other.streamingLevelNameList_))
		{
			return false;
		}
		if (!performers_.Equals(other.performers_))
		{
			return false;
		}
		if (IsUseBlockLoad != other.IsUseBlockLoad)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= startSequences_.GetHashCode();
		if (IsUseMarkFrameLoop)
		{
			num ^= IsUseMarkFrameLoop.GetHashCode();
		}
		if (IsUseCinematicCamera)
		{
			num ^= IsUseCinematicCamera.GetHashCode();
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
		num ^= streamingLevelNameList_.GetHashCode();
		num ^= performers_.GetHashCode();
		if (IsUseBlockLoad)
		{
			num ^= IsUseBlockLoad.GetHashCode();
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
		if (IsUseMarkFrameLoop)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsUseMarkFrameLoop);
		}
		if (IsUseCinematicCamera)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsUseCinematicCamera);
		}
		if (CameraBlendInTime != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(CameraBlendInTime);
		}
		if (CameraBlendInFunc != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CameraBlendInFunc);
		}
		if (CameraBlendInExp != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(CameraBlendInExp);
		}
		streamingLevelNameList_.WriteTo(output, _repeated_streamingLevelNameList_codec);
		performers_.WriteTo(output, _repeated_performers_codec);
		if (IsUseBlockLoad)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsUseBlockLoad);
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
		if (IsUseMarkFrameLoop)
		{
			num += 2;
		}
		if (IsUseCinematicCamera)
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
		num += streamingLevelNameList_.CalculateSize(_repeated_streamingLevelNameList_codec);
		num += performers_.CalculateSize(_repeated_performers_codec);
		if (IsUseBlockLoad)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_WarmingUp other)
	{
		if (other != null)
		{
			startSequences_.Add(other.startSequences_);
			if (other.IsUseMarkFrameLoop)
			{
				IsUseMarkFrameLoop = other.IsUseMarkFrameLoop;
			}
			if (other.IsUseCinematicCamera)
			{
				IsUseCinematicCamera = other.IsUseCinematicCamera;
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
			streamingLevelNameList_.Add(other.streamingLevelNameList_);
			performers_.Add(other.performers_);
			if (other.IsUseBlockLoad)
			{
				IsUseBlockLoad = other.IsUseBlockLoad;
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
			case 16u:
				IsUseMarkFrameLoop = input.ReadBool();
				break;
			case 24u:
				IsUseCinematicCamera = input.ReadBool();
				break;
			case 37u:
				CameraBlendInTime = input.ReadFloat();
				break;
			case 40u:
				CameraBlendInFunc = input.ReadInt32();
				break;
			case 53u:
				CameraBlendInExp = input.ReadFloat();
				break;
			case 58u:
				streamingLevelNameList_.AddEntriesFrom(input, _repeated_streamingLevelNameList_codec);
				break;
			case 66u:
				performers_.AddEntriesFrom(input, _repeated_performers_codec);
				break;
			case 72u:
				IsUseBlockLoad = input.ReadBool();
				break;
			}
		}
	}
}
