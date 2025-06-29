using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class MeditationPointDesc : IMessage<MeditationPointDesc>, IMessage, IEquatable<MeditationPointDesc>, IDeepCloneable<MeditationPointDesc>
{
	private static readonly MessageParser<MeditationPointDesc> _parser = new MessageParser<MeditationPointDesc>(() => new MeditationPointDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private int mapId_;

	private string sceneName_ = "";

	private int sequenceId_;

	private static readonly FieldCodec<ItemOne> _repeated_awardList_codec = FieldCodec.ForMessage(50u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> awardList_ = new RepeatedField<ItemOne>();

	private string desc_ = "";

	private string akEventPath_ = "";

	private int localizationTag_;

	public static MessageParser<MeditationPointDesc> Parser => _parser;

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

	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	public string SceneName
	{
		get
		{
			return sceneName_;
		}
		set
		{
			sceneName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SequenceId
	{
		get
		{
			return sequenceId_;
		}
		set
		{
			sequenceId_ = value;
		}
	}

	public RepeatedField<ItemOne> AwardList => awardList_;

	public string Desc
	{
		get
		{
			return desc_;
		}
		set
		{
			desc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AkEventPath
	{
		get
		{
			return akEventPath_;
		}
		set
		{
			akEventPath_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public MeditationPointDesc()
	{
	}

	public MeditationPointDesc(MeditationPointDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		mapId_ = other.mapId_;
		sceneName_ = other.sceneName_;
		sequenceId_ = other.sequenceId_;
		awardList_ = other.awardList_.Clone();
		desc_ = other.desc_;
		akEventPath_ = other.akEventPath_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MeditationPointDesc Clone()
	{
		return new MeditationPointDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MeditationPointDesc);
	}

	public bool Equals(MeditationPointDesc other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (SceneName != other.SceneName)
		{
			return false;
		}
		if (SequenceId != other.SequenceId)
		{
			return false;
		}
		if (!awardList_.Equals(other.awardList_))
		{
			return false;
		}
		if (Desc != other.Desc)
		{
			return false;
		}
		if (AkEventPath != other.AkEventPath)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (SceneName.Length != 0)
		{
			num ^= SceneName.GetHashCode();
		}
		if (SequenceId != 0)
		{
			num ^= SequenceId.GetHashCode();
		}
		num ^= awardList_.GetHashCode();
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
		}
		if (AkEventPath.Length != 0)
		{
			num ^= AkEventPath.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MapId);
		}
		if (SceneName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SceneName);
		}
		if (SequenceId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SequenceId);
		}
		awardList_.WriteTo(output, _repeated_awardList_codec);
		if (Desc.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Desc);
		}
		if (AkEventPath.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(AkEventPath);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(72);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (SceneName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SceneName);
		}
		if (SequenceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SequenceId);
		}
		num += awardList_.CalculateSize(_repeated_awardList_codec);
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (AkEventPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AkEventPath);
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

	public void MergeFrom(MeditationPointDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.SceneName.Length != 0)
			{
				SceneName = other.SceneName;
			}
			if (other.SequenceId != 0)
			{
				SequenceId = other.SequenceId;
			}
			awardList_.Add(other.awardList_);
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
			}
			if (other.AkEventPath.Length != 0)
			{
				AkEventPath = other.AkEventPath;
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
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				MapId = input.ReadInt32();
				break;
			case 34u:
				SceneName = input.ReadString();
				break;
			case 40u:
				SequenceId = input.ReadInt32();
				break;
			case 50u:
				awardList_.AddEntriesFrom(input, _repeated_awardList_codec);
				break;
			case 58u:
				Desc = input.ReadString();
				break;
			case 66u:
				AkEventPath = input.ReadString();
				break;
			case 72u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
