using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class SoundTrackDesc : IMessage<SoundTrackDesc>, IMessage, IEquatable<SoundTrackDesc>, IDeepCloneable<SoundTrackDesc>
{
	private static readonly MessageParser<SoundTrackDesc> _parser = new MessageParser<SoundTrackDesc>(() => new SoundTrackDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int sortId_;

	private string name_ = "";

	private float audioDuration_;

	private string lyricist_ = "";

	private string arranger_ = "";

	private ResUnlockType unlockCondition_;

	private int localizationTag_;

	public static MessageParser<SoundTrackDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float AudioDuration
	{
		get
		{
			return audioDuration_;
		}
		set
		{
			audioDuration_ = value;
		}
	}

	public string Lyricist
	{
		get
		{
			return lyricist_;
		}
		set
		{
			lyricist_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Arranger
	{
		get
		{
			return arranger_;
		}
		set
		{
			arranger_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ResUnlockType UnlockCondition
	{
		get
		{
			return unlockCondition_;
		}
		set
		{
			unlockCondition_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public SoundTrackDesc()
	{
	}

	public SoundTrackDesc(SoundTrackDesc other)
		: this()
	{
		id_ = other.id_;
		sortId_ = other.sortId_;
		name_ = other.name_;
		audioDuration_ = other.audioDuration_;
		lyricist_ = other.lyricist_;
		arranger_ = other.arranger_;
		unlockCondition_ = other.unlockCondition_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SoundTrackDesc Clone()
	{
		return new SoundTrackDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SoundTrackDesc);
	}

	public bool Equals(SoundTrackDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AudioDuration, other.AudioDuration))
		{
			return false;
		}
		if (Lyricist != other.Lyricist)
		{
			return false;
		}
		if (Arranger != other.Arranger)
		{
			return false;
		}
		if (UnlockCondition != other.UnlockCondition)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (AudioDuration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AudioDuration);
		}
		if (Lyricist.Length != 0)
		{
			num ^= Lyricist.GetHashCode();
		}
		if (Arranger.Length != 0)
		{
			num ^= Arranger.GetHashCode();
		}
		if (UnlockCondition != ResUnlockType.None)
		{
			num ^= UnlockCondition.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SortId);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Name);
		}
		if (AudioDuration != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(AudioDuration);
		}
		if (Lyricist.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Lyricist);
		}
		if (Arranger.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Arranger);
		}
		if (UnlockCondition != ResUnlockType.None)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)UnlockCondition);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (AudioDuration != 0f)
		{
			num += 5;
		}
		if (Lyricist.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Lyricist);
		}
		if (Arranger.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Arranger);
		}
		if (UnlockCondition != ResUnlockType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnlockCondition);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SoundTrackDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.AudioDuration != 0f)
			{
				AudioDuration = other.AudioDuration;
			}
			if (other.Lyricist.Length != 0)
			{
				Lyricist = other.Lyricist;
			}
			if (other.Arranger.Length != 0)
			{
				Arranger = other.Arranger;
			}
			if (other.UnlockCondition != ResUnlockType.None)
			{
				UnlockCondition = other.UnlockCondition;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				SortId = input.ReadInt32();
				break;
			case 26u:
				Name = input.ReadString();
				break;
			case 37u:
				AudioDuration = input.ReadFloat();
				break;
			case 42u:
				Lyricist = input.ReadString();
				break;
			case 50u:
				Arranger = input.ReadString();
				break;
			case 56u:
				UnlockCondition = (ResUnlockType)input.ReadEnum();
				break;
			case 64u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
