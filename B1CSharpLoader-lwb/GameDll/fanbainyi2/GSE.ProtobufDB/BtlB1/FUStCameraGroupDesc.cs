using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStCameraGroupDesc : IMessage<FUStCameraGroupDesc>, IMessage, IEquatable<FUStCameraGroupDesc>, IDeepCloneable<FUStCameraGroupDesc>
{
	private static readonly MessageParser<FUStCameraGroupDesc> _parser = new MessageParser<FUStCameraGroupDesc>(() => new FUStCameraGroupDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int cameraGroupID_;

	private int playerResID_;

	private static readonly FieldCodec<int> _repeated_playerStateCameraIDList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> playerStateCameraIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_playerSkillCameraIDList_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> playerSkillCameraIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<FUStUnitSoulCamera> _repeated_relativeUnitList_codec = FieldCodec.ForMessage(50u, FUStUnitSoulCamera.Parser);

	private readonly RepeatedField<FUStUnitSoulCamera> relativeUnitList_ = new RepeatedField<FUStUnitSoulCamera>();

	public static MessageParser<FUStCameraGroupDesc> Parser => _parser;

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

	public int CameraGroupID
	{
		get
		{
			return cameraGroupID_;
		}
		set
		{
			cameraGroupID_ = value;
		}
	}

	public int PlayerResID
	{
		get
		{
			return playerResID_;
		}
		set
		{
			playerResID_ = value;
		}
	}

	public RepeatedField<int> PlayerStateCameraIDList => playerStateCameraIDList_;

	public RepeatedField<int> PlayerSkillCameraIDList => playerSkillCameraIDList_;

	public RepeatedField<FUStUnitSoulCamera> RelativeUnitList => relativeUnitList_;

	public FUStCameraGroupDesc()
	{
	}

	public FUStCameraGroupDesc(FUStCameraGroupDesc other)
		: this()
	{
		iD_ = other.iD_;
		cameraGroupID_ = other.cameraGroupID_;
		playerResID_ = other.playerResID_;
		playerStateCameraIDList_ = other.playerStateCameraIDList_.Clone();
		playerSkillCameraIDList_ = other.playerSkillCameraIDList_.Clone();
		relativeUnitList_ = other.relativeUnitList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStCameraGroupDesc Clone()
	{
		return new FUStCameraGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStCameraGroupDesc);
	}

	public bool Equals(FUStCameraGroupDesc other)
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
		if (CameraGroupID != other.CameraGroupID)
		{
			return false;
		}
		if (PlayerResID != other.PlayerResID)
		{
			return false;
		}
		if (!playerStateCameraIDList_.Equals(other.playerStateCameraIDList_))
		{
			return false;
		}
		if (!playerSkillCameraIDList_.Equals(other.playerSkillCameraIDList_))
		{
			return false;
		}
		if (!relativeUnitList_.Equals(other.relativeUnitList_))
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
		if (CameraGroupID != 0)
		{
			num ^= CameraGroupID.GetHashCode();
		}
		if (PlayerResID != 0)
		{
			num ^= PlayerResID.GetHashCode();
		}
		num ^= playerStateCameraIDList_.GetHashCode();
		num ^= playerSkillCameraIDList_.GetHashCode();
		num ^= relativeUnitList_.GetHashCode();
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
		if (CameraGroupID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CameraGroupID);
		}
		if (PlayerResID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PlayerResID);
		}
		playerStateCameraIDList_.WriteTo(output, _repeated_playerStateCameraIDList_codec);
		playerSkillCameraIDList_.WriteTo(output, _repeated_playerSkillCameraIDList_codec);
		relativeUnitList_.WriteTo(output, _repeated_relativeUnitList_codec);
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
		if (CameraGroupID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CameraGroupID);
		}
		if (PlayerResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayerResID);
		}
		num += playerStateCameraIDList_.CalculateSize(_repeated_playerStateCameraIDList_codec);
		num += playerSkillCameraIDList_.CalculateSize(_repeated_playerSkillCameraIDList_codec);
		num += relativeUnitList_.CalculateSize(_repeated_relativeUnitList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStCameraGroupDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.CameraGroupID != 0)
			{
				CameraGroupID = other.CameraGroupID;
			}
			if (other.PlayerResID != 0)
			{
				PlayerResID = other.PlayerResID;
			}
			playerStateCameraIDList_.Add(other.playerStateCameraIDList_);
			playerSkillCameraIDList_.Add(other.playerSkillCameraIDList_);
			relativeUnitList_.Add(other.relativeUnitList_);
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
				CameraGroupID = input.ReadInt32();
				break;
			case 24u:
				PlayerResID = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				playerStateCameraIDList_.AddEntriesFrom(input, _repeated_playerStateCameraIDList_codec);
				break;
			case 40u:
			case 42u:
				playerSkillCameraIDList_.AddEntriesFrom(input, _repeated_playerSkillCameraIDList_codec);
				break;
			case 50u:
				relativeUnitList_.AddEntriesFrom(input, _repeated_relativeUnitList_codec);
				break;
			}
		}
	}
}
