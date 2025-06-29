using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStExplosiveInfo : IMessage<FUStExplosiveInfo>, IMessage, IEquatable<FUStExplosiveInfo>, IDeepCloneable<FUStExplosiveInfo>
{
	private static readonly MessageParser<FUStExplosiveInfo> _parser = new MessageParser<FUStExplosiveInfo>(() => new FUStExplosiveInfo());

	private UnknownFieldSet _unknownFields;

	private int explosiveDamageBuff_;

	private float explosiveRadius_;

	private int explosiveLevel_;

	private int playerGainBuff_;

	private float playerGainRadius_;

	public static MessageParser<FUStExplosiveInfo> Parser => _parser;

	public int ExplosiveDamageBuff
	{
		get
		{
			return explosiveDamageBuff_;
		}
		set
		{
			explosiveDamageBuff_ = value;
		}
	}

	public float ExplosiveRadius
	{
		get
		{
			return explosiveRadius_;
		}
		set
		{
			explosiveRadius_ = value;
		}
	}

	public int ExplosiveLevel
	{
		get
		{
			return explosiveLevel_;
		}
		set
		{
			explosiveLevel_ = value;
		}
	}

	public int PlayerGainBuff
	{
		get
		{
			return playerGainBuff_;
		}
		set
		{
			playerGainBuff_ = value;
		}
	}

	public float PlayerGainRadius
	{
		get
		{
			return playerGainRadius_;
		}
		set
		{
			playerGainRadius_ = value;
		}
	}

	public FUStExplosiveInfo()
	{
	}

	public FUStExplosiveInfo(FUStExplosiveInfo other)
		: this()
	{
		explosiveDamageBuff_ = other.explosiveDamageBuff_;
		explosiveRadius_ = other.explosiveRadius_;
		explosiveLevel_ = other.explosiveLevel_;
		playerGainBuff_ = other.playerGainBuff_;
		playerGainRadius_ = other.playerGainRadius_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStExplosiveInfo Clone()
	{
		return new FUStExplosiveInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStExplosiveInfo);
	}

	public bool Equals(FUStExplosiveInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ExplosiveDamageBuff != other.ExplosiveDamageBuff)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExplosiveRadius, other.ExplosiveRadius))
		{
			return false;
		}
		if (ExplosiveLevel != other.ExplosiveLevel)
		{
			return false;
		}
		if (PlayerGainBuff != other.PlayerGainBuff)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerGainRadius, other.PlayerGainRadius))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ExplosiveDamageBuff != 0)
		{
			num ^= ExplosiveDamageBuff.GetHashCode();
		}
		if (ExplosiveRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExplosiveRadius);
		}
		if (ExplosiveLevel != 0)
		{
			num ^= ExplosiveLevel.GetHashCode();
		}
		if (PlayerGainBuff != 0)
		{
			num ^= PlayerGainBuff.GetHashCode();
		}
		if (PlayerGainRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerGainRadius);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ExplosiveDamageBuff != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ExplosiveDamageBuff);
		}
		if (ExplosiveRadius != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(ExplosiveRadius);
		}
		if (ExplosiveLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ExplosiveLevel);
		}
		if (PlayerGainBuff != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PlayerGainBuff);
		}
		if (PlayerGainRadius != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(PlayerGainRadius);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ExplosiveDamageBuff != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExplosiveDamageBuff);
		}
		if (ExplosiveRadius != 0f)
		{
			num += 5;
		}
		if (ExplosiveLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExplosiveLevel);
		}
		if (PlayerGainBuff != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayerGainBuff);
		}
		if (PlayerGainRadius != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStExplosiveInfo other)
	{
		if (other != null)
		{
			if (other.ExplosiveDamageBuff != 0)
			{
				ExplosiveDamageBuff = other.ExplosiveDamageBuff;
			}
			if (other.ExplosiveRadius != 0f)
			{
				ExplosiveRadius = other.ExplosiveRadius;
			}
			if (other.ExplosiveLevel != 0)
			{
				ExplosiveLevel = other.ExplosiveLevel;
			}
			if (other.PlayerGainBuff != 0)
			{
				PlayerGainBuff = other.PlayerGainBuff;
			}
			if (other.PlayerGainRadius != 0f)
			{
				PlayerGainRadius = other.PlayerGainRadius;
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
				ExplosiveDamageBuff = input.ReadInt32();
				break;
			case 21u:
				ExplosiveRadius = input.ReadFloat();
				break;
			case 24u:
				ExplosiveLevel = input.ReadInt32();
				break;
			case 32u:
				PlayerGainBuff = input.ReadInt32();
				break;
			case 45u:
				PlayerGainRadius = input.ReadFloat();
				break;
			}
		}
	}
}
