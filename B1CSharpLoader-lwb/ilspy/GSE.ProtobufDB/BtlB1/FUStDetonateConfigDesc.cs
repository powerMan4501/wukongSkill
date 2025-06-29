using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStDetonateConfigDesc : IMessage<FUStDetonateConfigDesc>, IMessage, IEquatable<FUStDetonateConfigDesc>, IDeepCloneable<FUStDetonateConfigDesc>
{
	private static readonly MessageParser<FUStDetonateConfigDesc> _parser = new MessageParser<FUStDetonateConfigDesc>(() => new FUStDetonateConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int buffID_;

	private float explosive_;

	private string explosiveDBCPath_ = "";

	private static readonly FieldCodec<FUStExplosiveInfo> _repeated_adsortLevelDamageList_codec = FieldCodec.ForMessage(42u, FUStExplosiveInfo.Parser);

	private readonly RepeatedField<FUStExplosiveInfo> adsortLevelDamageList_ = new RepeatedField<FUStExplosiveInfo>();

	private static readonly FieldCodec<FUStDelayPlayerGainConfig> _repeated_delayPlayerGainConfig_codec = FieldCodec.ForMessage(50u, FUStDelayPlayerGainConfig.Parser);

	private readonly RepeatedField<FUStDelayPlayerGainConfig> delayPlayerGainConfig_ = new RepeatedField<FUStDelayPlayerGainConfig>();

	public static MessageParser<FUStDetonateConfigDesc> Parser => _parser;

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

	public float Explosive
	{
		get
		{
			return explosive_;
		}
		set
		{
			explosive_ = value;
		}
	}

	public string ExplosiveDBCPath
	{
		get
		{
			return explosiveDBCPath_;
		}
		set
		{
			explosiveDBCPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<FUStExplosiveInfo> AdsortLevelDamageList => adsortLevelDamageList_;

	public RepeatedField<FUStDelayPlayerGainConfig> DelayPlayerGainConfig => delayPlayerGainConfig_;

	public FUStDetonateConfigDesc()
	{
	}

	public FUStDetonateConfigDesc(FUStDetonateConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		buffID_ = other.buffID_;
		explosive_ = other.explosive_;
		explosiveDBCPath_ = other.explosiveDBCPath_;
		adsortLevelDamageList_ = other.adsortLevelDamageList_.Clone();
		delayPlayerGainConfig_ = other.delayPlayerGainConfig_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDetonateConfigDesc Clone()
	{
		return new FUStDetonateConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDetonateConfigDesc);
	}

	public bool Equals(FUStDetonateConfigDesc other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Explosive, other.Explosive))
		{
			return false;
		}
		if (ExplosiveDBCPath != other.ExplosiveDBCPath)
		{
			return false;
		}
		if (!adsortLevelDamageList_.Equals(other.adsortLevelDamageList_))
		{
			return false;
		}
		if (!delayPlayerGainConfig_.Equals(other.delayPlayerGainConfig_))
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
		if (Explosive != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Explosive);
		}
		if (ExplosiveDBCPath.Length != 0)
		{
			num ^= ExplosiveDBCPath.GetHashCode();
		}
		num ^= adsortLevelDamageList_.GetHashCode();
		num ^= delayPlayerGainConfig_.GetHashCode();
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
		if (Explosive != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(Explosive);
		}
		if (ExplosiveDBCPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ExplosiveDBCPath);
		}
		adsortLevelDamageList_.WriteTo(output, _repeated_adsortLevelDamageList_codec);
		delayPlayerGainConfig_.WriteTo(output, _repeated_delayPlayerGainConfig_codec);
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
		if (Explosive != 0f)
		{
			num += 5;
		}
		if (ExplosiveDBCPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ExplosiveDBCPath);
		}
		num += adsortLevelDamageList_.CalculateSize(_repeated_adsortLevelDamageList_codec);
		num += delayPlayerGainConfig_.CalculateSize(_repeated_delayPlayerGainConfig_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDetonateConfigDesc other)
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
			if (other.Explosive != 0f)
			{
				Explosive = other.Explosive;
			}
			if (other.ExplosiveDBCPath.Length != 0)
			{
				ExplosiveDBCPath = other.ExplosiveDBCPath;
			}
			adsortLevelDamageList_.Add(other.adsortLevelDamageList_);
			delayPlayerGainConfig_.Add(other.delayPlayerGainConfig_);
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
			case 29u:
				Explosive = input.ReadFloat();
				break;
			case 34u:
				ExplosiveDBCPath = input.ReadString();
				break;
			case 42u:
				adsortLevelDamageList_.AddEntriesFrom(input, _repeated_adsortLevelDamageList_codec);
				break;
			case 50u:
				delayPlayerGainConfig_.AddEntriesFrom(input, _repeated_delayPlayerGainConfig_codec);
				break;
			}
		}
	}
}
