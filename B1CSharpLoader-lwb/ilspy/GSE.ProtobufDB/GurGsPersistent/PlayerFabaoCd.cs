using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class PlayerFabaoCd : IMessage<PlayerFabaoCd>, IMessage, IEquatable<PlayerFabaoCd>, IDeepCloneable<PlayerFabaoCd>
{
	private static readonly MessageParser<PlayerFabaoCd> _parser = new MessageParser<PlayerFabaoCd>(() => new PlayerFabaoCd());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int fabaoId_;

	private float coolDown_;

	public static MessageParser<PlayerFabaoCd> Parser => _parser;

	public int FabaoId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return fabaoId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			fabaoId_ = value;
		}
	}

	public bool HasFabaoId => (_hasBits0 & 1) != 0;

	public float CoolDown
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return coolDown_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			coolDown_ = value;
		}
	}

	public bool HasCoolDown => (_hasBits0 & 2) != 0;

	public PlayerFabaoCd()
	{
	}

	public PlayerFabaoCd(PlayerFabaoCd other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		fabaoId_ = other.fabaoId_;
		coolDown_ = other.coolDown_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerFabaoCd Clone()
	{
		return new PlayerFabaoCd(this);
	}

	public void ClearFabaoId()
	{
		_hasBits0 &= -2;
	}

	public void ClearCoolDown()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerFabaoCd);
	}

	public bool Equals(PlayerFabaoCd other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FabaoId != other.FabaoId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CoolDown, other.CoolDown))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasFabaoId)
		{
			num ^= FabaoId.GetHashCode();
		}
		if (HasCoolDown)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CoolDown);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasFabaoId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(FabaoId);
		}
		if (HasCoolDown)
		{
			output.WriteRawTag(21);
			output.WriteFloat(CoolDown);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasFabaoId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FabaoId);
		}
		if (HasCoolDown)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerFabaoCd other)
	{
		if (other != null)
		{
			if (other.HasFabaoId)
			{
				FabaoId = other.FabaoId;
			}
			if (other.HasCoolDown)
			{
				CoolDown = other.CoolDown;
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
				FabaoId = input.ReadInt32();
				break;
			case 21u:
				CoolDown = input.ReadFloat();
				break;
			}
		}
	}
}
