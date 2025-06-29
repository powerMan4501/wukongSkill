using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStAttackHitAudioInfoDesc : IMessage<FUStAttackHitAudioInfoDesc>, IMessage, IEquatable<FUStAttackHitAudioInfoDesc>, IDeepCloneable<FUStAttackHitAudioInfoDesc>
{
	private static readonly MessageParser<FUStAttackHitAudioInfoDesc> _parser = new MessageParser<FUStAttackHitAudioInfoDesc>(() => new FUStAttackHitAudioInfoDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int baseID_;

	private int audioMappingID_;

	private string audioFolderPath_ = "";

	private string preAkEventName_ = "";

	public static MessageParser<FUStAttackHitAudioInfoDesc> Parser => _parser;

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

	public int BaseID
	{
		get
		{
			return baseID_;
		}
		set
		{
			baseID_ = value;
		}
	}

	public int AudioMappingID
	{
		get
		{
			return audioMappingID_;
		}
		set
		{
			audioMappingID_ = value;
		}
	}

	public string AudioFolderPath
	{
		get
		{
			return audioFolderPath_;
		}
		set
		{
			audioFolderPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PreAkEventName
	{
		get
		{
			return preAkEventName_;
		}
		set
		{
			preAkEventName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStAttackHitAudioInfoDesc()
	{
	}

	public FUStAttackHitAudioInfoDesc(FUStAttackHitAudioInfoDesc other)
		: this()
	{
		iD_ = other.iD_;
		baseID_ = other.baseID_;
		audioMappingID_ = other.audioMappingID_;
		audioFolderPath_ = other.audioFolderPath_;
		preAkEventName_ = other.preAkEventName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAttackHitAudioInfoDesc Clone()
	{
		return new FUStAttackHitAudioInfoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAttackHitAudioInfoDesc);
	}

	public bool Equals(FUStAttackHitAudioInfoDesc other)
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
		if (BaseID != other.BaseID)
		{
			return false;
		}
		if (AudioMappingID != other.AudioMappingID)
		{
			return false;
		}
		if (AudioFolderPath != other.AudioFolderPath)
		{
			return false;
		}
		if (PreAkEventName != other.PreAkEventName)
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
		if (BaseID != 0)
		{
			num ^= BaseID.GetHashCode();
		}
		if (AudioMappingID != 0)
		{
			num ^= AudioMappingID.GetHashCode();
		}
		if (AudioFolderPath.Length != 0)
		{
			num ^= AudioFolderPath.GetHashCode();
		}
		if (PreAkEventName.Length != 0)
		{
			num ^= PreAkEventName.GetHashCode();
		}
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
		if (BaseID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BaseID);
		}
		if (AudioMappingID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AudioMappingID);
		}
		if (AudioFolderPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(AudioFolderPath);
		}
		if (PreAkEventName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(PreAkEventName);
		}
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
		if (BaseID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BaseID);
		}
		if (AudioMappingID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AudioMappingID);
		}
		if (AudioFolderPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AudioFolderPath);
		}
		if (PreAkEventName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PreAkEventName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAttackHitAudioInfoDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BaseID != 0)
			{
				BaseID = other.BaseID;
			}
			if (other.AudioMappingID != 0)
			{
				AudioMappingID = other.AudioMappingID;
			}
			if (other.AudioFolderPath.Length != 0)
			{
				AudioFolderPath = other.AudioFolderPath;
			}
			if (other.PreAkEventName.Length != 0)
			{
				PreAkEventName = other.PreAkEventName;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				BaseID = input.ReadInt32();
				break;
			case 24u:
				AudioMappingID = input.ReadInt32();
				break;
			case 34u:
				AudioFolderPath = input.ReadString();
				break;
			case 42u:
				PreAkEventName = input.ReadString();
				break;
			}
		}
	}
}
