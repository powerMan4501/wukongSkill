using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStAudioExtendDesc : IMessage<FUStAudioExtendDesc>, IMessage, IEquatable<FUStAudioExtendDesc>, IDeepCloneable<FUStAudioExtendDesc>
{
	private static readonly MessageParser<FUStAudioExtendDesc> _parser = new MessageParser<FUStAudioExtendDesc>(() => new FUStAudioExtendDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EquipPosition equipPosition_;

	private int actionTypeID_;

	private ESceneItemSurfaceType sceneItemSurfaceType_;

	private int audioMappingID_;

	private string audioPath_ = "";

	public static MessageParser<FUStAudioExtendDesc> Parser => _parser;

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

	public EquipPosition EquipPosition
	{
		get
		{
			return equipPosition_;
		}
		set
		{
			equipPosition_ = value;
		}
	}

	public int ActionTypeID
	{
		get
		{
			return actionTypeID_;
		}
		set
		{
			actionTypeID_ = value;
		}
	}

	public ESceneItemSurfaceType SceneItemSurfaceType
	{
		get
		{
			return sceneItemSurfaceType_;
		}
		set
		{
			sceneItemSurfaceType_ = value;
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

	public string AudioPath
	{
		get
		{
			return audioPath_;
		}
		set
		{
			audioPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStAudioExtendDesc()
	{
	}

	public FUStAudioExtendDesc(FUStAudioExtendDesc other)
		: this()
	{
		iD_ = other.iD_;
		equipPosition_ = other.equipPosition_;
		actionTypeID_ = other.actionTypeID_;
		sceneItemSurfaceType_ = other.sceneItemSurfaceType_;
		audioMappingID_ = other.audioMappingID_;
		audioPath_ = other.audioPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAudioExtendDesc Clone()
	{
		return new FUStAudioExtendDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAudioExtendDesc);
	}

	public bool Equals(FUStAudioExtendDesc other)
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
		if (EquipPosition != other.EquipPosition)
		{
			return false;
		}
		if (ActionTypeID != other.ActionTypeID)
		{
			return false;
		}
		if (SceneItemSurfaceType != other.SceneItemSurfaceType)
		{
			return false;
		}
		if (AudioMappingID != other.AudioMappingID)
		{
			return false;
		}
		if (AudioPath != other.AudioPath)
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
		if (EquipPosition != EquipPosition.Head)
		{
			num ^= EquipPosition.GetHashCode();
		}
		if (ActionTypeID != 0)
		{
			num ^= ActionTypeID.GetHashCode();
		}
		if (SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			num ^= SceneItemSurfaceType.GetHashCode();
		}
		if (AudioMappingID != 0)
		{
			num ^= AudioMappingID.GetHashCode();
		}
		if (AudioPath.Length != 0)
		{
			num ^= AudioPath.GetHashCode();
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
		if (EquipPosition != EquipPosition.Head)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EquipPosition);
		}
		if (ActionTypeID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ActionTypeID);
		}
		if (SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)SceneItemSurfaceType);
		}
		if (AudioMappingID != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(AudioMappingID);
		}
		if (AudioPath.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(AudioPath);
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
		if (EquipPosition != EquipPosition.Head)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EquipPosition);
		}
		if (ActionTypeID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ActionTypeID);
		}
		if (SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SceneItemSurfaceType);
		}
		if (AudioMappingID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AudioMappingID);
		}
		if (AudioPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AudioPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAudioExtendDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.EquipPosition != EquipPosition.Head)
			{
				EquipPosition = other.EquipPosition;
			}
			if (other.ActionTypeID != 0)
			{
				ActionTypeID = other.ActionTypeID;
			}
			if (other.SceneItemSurfaceType != ESceneItemSurfaceType.DefaultSurface)
			{
				SceneItemSurfaceType = other.SceneItemSurfaceType;
			}
			if (other.AudioMappingID != 0)
			{
				AudioMappingID = other.AudioMappingID;
			}
			if (other.AudioPath.Length != 0)
			{
				AudioPath = other.AudioPath;
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
				EquipPosition = (EquipPosition)input.ReadEnum();
				break;
			case 24u:
				ActionTypeID = input.ReadInt32();
				break;
			case 32u:
				SceneItemSurfaceType = (ESceneItemSurfaceType)input.ReadEnum();
				break;
			case 40u:
				AudioMappingID = input.ReadInt32();
				break;
			case 50u:
				AudioPath = input.ReadString();
				break;
			}
		}
	}
}
