using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class Demo820GameSave : IMessage<Demo820GameSave>, IMessage, IEquatable<Demo820GameSave>, IDeepCloneable<Demo820GameSave>
{
	private static readonly MessageParser<Demo820GameSave> _parser = new MessageParser<Demo820GameSave>(() => new Demo820GameSave());

	private UnknownFieldSet _unknownFields;

	private float gamePlayTime_;

	private static readonly FieldCodec<int> _repeated_levelPassList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> levelPassList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_levelAwardList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> levelAwardList_ = new RepeatedField<int>();

	private static readonly FieldCodec<Demo820LevelPlaytime> _repeated_levelPlayTimeList_codec = FieldCodec.ForMessage(34u, Demo820LevelPlaytime.Parser);

	private readonly RepeatedField<Demo820LevelPlaytime> levelPlayTimeList_ = new RepeatedField<Demo820LevelPlaytime>();

	private string hasEmailReport_ = "";

	private bool ossEndPlayReport_;

	private static readonly FieldCodec<int> _repeated_levelPassStateList_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> levelPassStateList_ = new RepeatedField<int>();

	public static MessageParser<Demo820GameSave> Parser => _parser;

	public float GamePlayTime
	{
		get
		{
			return gamePlayTime_;
		}
		set
		{
			gamePlayTime_ = value;
		}
	}

	public RepeatedField<int> LevelPassList => levelPassList_;

	public RepeatedField<int> LevelAwardList => levelAwardList_;

	public RepeatedField<Demo820LevelPlaytime> LevelPlayTimeList => levelPlayTimeList_;

	public string HasEmailReport
	{
		get
		{
			return hasEmailReport_;
		}
		set
		{
			hasEmailReport_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool OssEndPlayReport
	{
		get
		{
			return ossEndPlayReport_;
		}
		set
		{
			ossEndPlayReport_ = value;
		}
	}

	public RepeatedField<int> LevelPassStateList => levelPassStateList_;

	public Demo820GameSave()
	{
	}

	public Demo820GameSave(Demo820GameSave other)
		: this()
	{
		gamePlayTime_ = other.gamePlayTime_;
		levelPassList_ = other.levelPassList_.Clone();
		levelAwardList_ = other.levelAwardList_.Clone();
		levelPlayTimeList_ = other.levelPlayTimeList_.Clone();
		hasEmailReport_ = other.hasEmailReport_;
		ossEndPlayReport_ = other.ossEndPlayReport_;
		levelPassStateList_ = other.levelPassStateList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Demo820GameSave Clone()
	{
		return new Demo820GameSave(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Demo820GameSave);
	}

	public bool Equals(Demo820GameSave other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GamePlayTime, other.GamePlayTime))
		{
			return false;
		}
		if (!levelPassList_.Equals(other.levelPassList_))
		{
			return false;
		}
		if (!levelAwardList_.Equals(other.levelAwardList_))
		{
			return false;
		}
		if (!levelPlayTimeList_.Equals(other.levelPlayTimeList_))
		{
			return false;
		}
		if (HasEmailReport != other.HasEmailReport)
		{
			return false;
		}
		if (OssEndPlayReport != other.OssEndPlayReport)
		{
			return false;
		}
		if (!levelPassStateList_.Equals(other.levelPassStateList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GamePlayTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GamePlayTime);
		}
		num ^= levelPassList_.GetHashCode();
		num ^= levelAwardList_.GetHashCode();
		num ^= levelPlayTimeList_.GetHashCode();
		if (HasEmailReport.Length != 0)
		{
			num ^= HasEmailReport.GetHashCode();
		}
		if (OssEndPlayReport)
		{
			num ^= OssEndPlayReport.GetHashCode();
		}
		num ^= levelPassStateList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GamePlayTime != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(GamePlayTime);
		}
		levelPassList_.WriteTo(output, _repeated_levelPassList_codec);
		levelAwardList_.WriteTo(output, _repeated_levelAwardList_codec);
		levelPlayTimeList_.WriteTo(output, _repeated_levelPlayTimeList_codec);
		if (HasEmailReport.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(HasEmailReport);
		}
		if (OssEndPlayReport)
		{
			output.WriteRawTag(48);
			output.WriteBool(OssEndPlayReport);
		}
		levelPassStateList_.WriteTo(output, _repeated_levelPassStateList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GamePlayTime != 0f)
		{
			num += 5;
		}
		num += levelPassList_.CalculateSize(_repeated_levelPassList_codec);
		num += levelAwardList_.CalculateSize(_repeated_levelAwardList_codec);
		num += levelPlayTimeList_.CalculateSize(_repeated_levelPlayTimeList_codec);
		if (HasEmailReport.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HasEmailReport);
		}
		if (OssEndPlayReport)
		{
			num += 2;
		}
		num += levelPassStateList_.CalculateSize(_repeated_levelPassStateList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Demo820GameSave other)
	{
		if (other != null)
		{
			if (other.GamePlayTime != 0f)
			{
				GamePlayTime = other.GamePlayTime;
			}
			levelPassList_.Add(other.levelPassList_);
			levelAwardList_.Add(other.levelAwardList_);
			levelPlayTimeList_.Add(other.levelPlayTimeList_);
			if (other.HasEmailReport.Length != 0)
			{
				HasEmailReport = other.HasEmailReport;
			}
			if (other.OssEndPlayReport)
			{
				OssEndPlayReport = other.OssEndPlayReport;
			}
			levelPassStateList_.Add(other.levelPassStateList_);
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
				GamePlayTime = input.ReadFloat();
				break;
			case 16u:
			case 18u:
				levelPassList_.AddEntriesFrom(input, _repeated_levelPassList_codec);
				break;
			case 24u:
			case 26u:
				levelAwardList_.AddEntriesFrom(input, _repeated_levelAwardList_codec);
				break;
			case 34u:
				levelPlayTimeList_.AddEntriesFrom(input, _repeated_levelPlayTimeList_codec);
				break;
			case 42u:
				HasEmailReport = input.ReadString();
				break;
			case 48u:
				OssEndPlayReport = input.ReadBool();
				break;
			case 56u:
			case 58u:
				levelPassStateList_.AddEntriesFrom(input, _repeated_levelPassStateList_codec);
				break;
			}
		}
	}
}
