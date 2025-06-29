using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBossRoomConfigDesc : IMessage<FUStBossRoomConfigDesc>, IMessage, IEquatable<FUStBossRoomConfigDesc>, IDeepCloneable<FUStBossRoomConfigDesc>
{
	private static readonly MessageParser<FUStBossRoomConfigDesc> _parser = new MessageParser<FUStBossRoomConfigDesc>(() => new FUStBossRoomConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int levelID_;

	private EGSYesNo isEnable_;

	private static readonly FieldCodec<string> _repeated_bossGuid_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> bossGuid_ = new RepeatedField<string>();

	private EGSYesNo isEnableCheckOutOfBossRoom_;

	private string teleportSceneItemTagName_ = "";

	public static MessageParser<FUStBossRoomConfigDesc> Parser => _parser;

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

	public int LevelID
	{
		get
		{
			return levelID_;
		}
		set
		{
			levelID_ = value;
		}
	}

	public EGSYesNo IsEnable
	{
		get
		{
			return isEnable_;
		}
		set
		{
			isEnable_ = value;
		}
	}

	public RepeatedField<string> BossGuid => bossGuid_;

	public EGSYesNo IsEnableCheckOutOfBossRoom
	{
		get
		{
			return isEnableCheckOutOfBossRoom_;
		}
		set
		{
			isEnableCheckOutOfBossRoom_ = value;
		}
	}

	public string TeleportSceneItemTagName
	{
		get
		{
			return teleportSceneItemTagName_;
		}
		set
		{
			teleportSceneItemTagName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStBossRoomConfigDesc()
	{
	}

	public FUStBossRoomConfigDesc(FUStBossRoomConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		levelID_ = other.levelID_;
		isEnable_ = other.isEnable_;
		bossGuid_ = other.bossGuid_.Clone();
		isEnableCheckOutOfBossRoom_ = other.isEnableCheckOutOfBossRoom_;
		teleportSceneItemTagName_ = other.teleportSceneItemTagName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBossRoomConfigDesc Clone()
	{
		return new FUStBossRoomConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBossRoomConfigDesc);
	}

	public bool Equals(FUStBossRoomConfigDesc other)
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
		if (LevelID != other.LevelID)
		{
			return false;
		}
		if (IsEnable != other.IsEnable)
		{
			return false;
		}
		if (!bossGuid_.Equals(other.bossGuid_))
		{
			return false;
		}
		if (IsEnableCheckOutOfBossRoom != other.IsEnableCheckOutOfBossRoom)
		{
			return false;
		}
		if (TeleportSceneItemTagName != other.TeleportSceneItemTagName)
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
		if (LevelID != 0)
		{
			num ^= LevelID.GetHashCode();
		}
		if (IsEnable != EGSYesNo.No)
		{
			num ^= IsEnable.GetHashCode();
		}
		num ^= bossGuid_.GetHashCode();
		if (IsEnableCheckOutOfBossRoom != EGSYesNo.No)
		{
			num ^= IsEnableCheckOutOfBossRoom.GetHashCode();
		}
		if (TeleportSceneItemTagName.Length != 0)
		{
			num ^= TeleportSceneItemTagName.GetHashCode();
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
		if (LevelID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LevelID);
		}
		if (IsEnable != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IsEnable);
		}
		bossGuid_.WriteTo(output, _repeated_bossGuid_codec);
		if (IsEnableCheckOutOfBossRoom != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsEnableCheckOutOfBossRoom);
		}
		if (TeleportSceneItemTagName.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(TeleportSceneItemTagName);
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
		if (LevelID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelID);
		}
		if (IsEnable != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsEnable);
		}
		num += bossGuid_.CalculateSize(_repeated_bossGuid_codec);
		if (IsEnableCheckOutOfBossRoom != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsEnableCheckOutOfBossRoom);
		}
		if (TeleportSceneItemTagName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TeleportSceneItemTagName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBossRoomConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.LevelID != 0)
			{
				LevelID = other.LevelID;
			}
			if (other.IsEnable != EGSYesNo.No)
			{
				IsEnable = other.IsEnable;
			}
			bossGuid_.Add(other.bossGuid_);
			if (other.IsEnableCheckOutOfBossRoom != EGSYesNo.No)
			{
				IsEnableCheckOutOfBossRoom = other.IsEnableCheckOutOfBossRoom;
			}
			if (other.TeleportSceneItemTagName.Length != 0)
			{
				TeleportSceneItemTagName = other.TeleportSceneItemTagName;
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
				LevelID = input.ReadInt32();
				break;
			case 24u:
				IsEnable = (EGSYesNo)input.ReadEnum();
				break;
			case 34u:
				bossGuid_.AddEntriesFrom(input, _repeated_bossGuid_codec);
				break;
			case 40u:
				IsEnableCheckOutOfBossRoom = (EGSYesNo)input.ReadEnum();
				break;
			case 50u:
				TeleportSceneItemTagName = input.ReadString();
				break;
			}
		}
	}
}
