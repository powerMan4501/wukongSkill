using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class FUStB2DUnitDeadDispDesc : IMessage<FUStB2DUnitDeadDispDesc>, IMessage, IEquatable<FUStB2DUnitDeadDispDesc>, IDeepCloneable<FUStB2DUnitDeadDispDesc>
{
	private static readonly MessageParser<FUStB2DUnitDeadDispDesc> _parser = new MessageParser<FUStB2DUnitDeadDispDesc>(() => new FUStB2DUnitDeadDispDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private EB2DDeadReason deadReason_;

	private string assetPath_ = "";

	private string montagePath_ = "";

	private int bodyExistTime_;

	private int bodyDownSpd_;

	private int destroyTime_;

	public static MessageParser<FUStB2DUnitDeadDispDesc> Parser => _parser;

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

	public EB2DDeadReason DeadReason
	{
		get
		{
			return deadReason_;
		}
		set
		{
			deadReason_ = value;
		}
	}

	public string AssetPath
	{
		get
		{
			return assetPath_;
		}
		set
		{
			assetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MontagePath
	{
		get
		{
			return montagePath_;
		}
		set
		{
			montagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int BodyExistTime
	{
		get
		{
			return bodyExistTime_;
		}
		set
		{
			bodyExistTime_ = value;
		}
	}

	public int BodyDownSpd
	{
		get
		{
			return bodyDownSpd_;
		}
		set
		{
			bodyDownSpd_ = value;
		}
	}

	public int DestroyTime
	{
		get
		{
			return destroyTime_;
		}
		set
		{
			destroyTime_ = value;
		}
	}

	public FUStB2DUnitDeadDispDesc()
	{
	}

	public FUStB2DUnitDeadDispDesc(FUStB2DUnitDeadDispDesc other)
		: this()
	{
		id_ = other.id_;
		deadReason_ = other.deadReason_;
		assetPath_ = other.assetPath_;
		montagePath_ = other.montagePath_;
		bodyExistTime_ = other.bodyExistTime_;
		bodyDownSpd_ = other.bodyDownSpd_;
		destroyTime_ = other.destroyTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DUnitDeadDispDesc Clone()
	{
		return new FUStB2DUnitDeadDispDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DUnitDeadDispDesc);
	}

	public bool Equals(FUStB2DUnitDeadDispDesc other)
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
		if (DeadReason != other.DeadReason)
		{
			return false;
		}
		if (AssetPath != other.AssetPath)
		{
			return false;
		}
		if (MontagePath != other.MontagePath)
		{
			return false;
		}
		if (BodyExistTime != other.BodyExistTime)
		{
			return false;
		}
		if (BodyDownSpd != other.BodyDownSpd)
		{
			return false;
		}
		if (DestroyTime != other.DestroyTime)
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
		if (DeadReason != EB2DDeadReason.None)
		{
			num ^= DeadReason.GetHashCode();
		}
		if (AssetPath.Length != 0)
		{
			num ^= AssetPath.GetHashCode();
		}
		if (MontagePath.Length != 0)
		{
			num ^= MontagePath.GetHashCode();
		}
		if (BodyExistTime != 0)
		{
			num ^= BodyExistTime.GetHashCode();
		}
		if (BodyDownSpd != 0)
		{
			num ^= BodyDownSpd.GetHashCode();
		}
		if (DestroyTime != 0)
		{
			num ^= DestroyTime.GetHashCode();
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
		if (DeadReason != EB2DDeadReason.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DeadReason);
		}
		if (AssetPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AssetPath);
		}
		if (MontagePath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(MontagePath);
		}
		if (BodyExistTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BodyExistTime);
		}
		if (BodyDownSpd != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BodyDownSpd);
		}
		if (DestroyTime != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DestroyTime);
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
		if (DeadReason != EB2DDeadReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DeadReason);
		}
		if (AssetPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AssetPath);
		}
		if (MontagePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MontagePath);
		}
		if (BodyExistTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BodyExistTime);
		}
		if (BodyDownSpd != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BodyDownSpd);
		}
		if (DestroyTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DestroyTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DUnitDeadDispDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.DeadReason != EB2DDeadReason.None)
			{
				DeadReason = other.DeadReason;
			}
			if (other.AssetPath.Length != 0)
			{
				AssetPath = other.AssetPath;
			}
			if (other.MontagePath.Length != 0)
			{
				MontagePath = other.MontagePath;
			}
			if (other.BodyExistTime != 0)
			{
				BodyExistTime = other.BodyExistTime;
			}
			if (other.BodyDownSpd != 0)
			{
				BodyDownSpd = other.BodyDownSpd;
			}
			if (other.DestroyTime != 0)
			{
				DestroyTime = other.DestroyTime;
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
				DeadReason = (EB2DDeadReason)input.ReadEnum();
				break;
			case 26u:
				AssetPath = input.ReadString();
				break;
			case 34u:
				MontagePath = input.ReadString();
				break;
			case 40u:
				BodyExistTime = input.ReadInt32();
				break;
			case 48u:
				BodyDownSpd = input.ReadInt32();
				break;
			case 56u:
				DestroyTime = input.ReadInt32();
				break;
			}
		}
	}
}
