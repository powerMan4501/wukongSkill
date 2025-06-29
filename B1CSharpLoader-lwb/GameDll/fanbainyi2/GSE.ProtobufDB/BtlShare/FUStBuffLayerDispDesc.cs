using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStBuffLayerDispDesc : IMessage<FUStBuffLayerDispDesc>, IMessage, IEquatable<FUStBuffLayerDispDesc>, IDeepCloneable<FUStBuffLayerDispDesc>
{
	private static readonly MessageParser<FUStBuffLayerDispDesc> _parser = new MessageParser<FUStBuffLayerDispDesc>(() => new FUStBuffLayerDispDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int buffID_;

	private int casterResID_;

	private int ownerResID_;

	private static readonly FieldCodec<FUStBuffLayerDispConfig> _repeated_config_codec = FieldCodec.ForMessage(42u, FUStBuffLayerDispConfig.Parser);

	private readonly RepeatedField<FUStBuffLayerDispConfig> config_ = new RepeatedField<FUStBuffLayerDispConfig>();

	public static MessageParser<FUStBuffLayerDispDesc> Parser => _parser;

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

	public int BuffID
	{
		get
		{
			return buffID_;
		}
		set
		{
			buffID_ = value;
		}
	}

	public int CasterResID
	{
		get
		{
			return casterResID_;
		}
		set
		{
			casterResID_ = value;
		}
	}

	public int OwnerResID
	{
		get
		{
			return ownerResID_;
		}
		set
		{
			ownerResID_ = value;
		}
	}

	public RepeatedField<FUStBuffLayerDispConfig> Config => config_;

	public FUStBuffLayerDispDesc()
	{
	}

	public FUStBuffLayerDispDesc(FUStBuffLayerDispDesc other)
		: this()
	{
		iD_ = other.iD_;
		buffID_ = other.buffID_;
		casterResID_ = other.casterResID_;
		ownerResID_ = other.ownerResID_;
		config_ = other.config_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffLayerDispDesc Clone()
	{
		return new FUStBuffLayerDispDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffLayerDispDesc);
	}

	public bool Equals(FUStBuffLayerDispDesc other)
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
		if (BuffID != other.BuffID)
		{
			return false;
		}
		if (CasterResID != other.CasterResID)
		{
			return false;
		}
		if (OwnerResID != other.OwnerResID)
		{
			return false;
		}
		if (!config_.Equals(other.config_))
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
		if (BuffID != 0)
		{
			num ^= BuffID.GetHashCode();
		}
		if (CasterResID != 0)
		{
			num ^= CasterResID.GetHashCode();
		}
		if (OwnerResID != 0)
		{
			num ^= OwnerResID.GetHashCode();
		}
		num ^= config_.GetHashCode();
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
		if (BuffID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffID);
		}
		if (CasterResID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CasterResID);
		}
		if (OwnerResID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(OwnerResID);
		}
		config_.WriteTo(output, _repeated_config_codec);
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
		if (BuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffID);
		}
		if (CasterResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CasterResID);
		}
		if (OwnerResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OwnerResID);
		}
		num += config_.CalculateSize(_repeated_config_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffLayerDispDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BuffID != 0)
			{
				BuffID = other.BuffID;
			}
			if (other.CasterResID != 0)
			{
				CasterResID = other.CasterResID;
			}
			if (other.OwnerResID != 0)
			{
				OwnerResID = other.OwnerResID;
			}
			config_.Add(other.config_);
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
				BuffID = input.ReadInt32();
				break;
			case 24u:
				CasterResID = input.ReadInt32();
				break;
			case 32u:
				OwnerResID = input.ReadInt32();
				break;
			case 42u:
				config_.AddEntriesFrom(input, _repeated_config_codec);
				break;
			}
		}
	}
}
