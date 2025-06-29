using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class PlayerLifeSavingHairInfo : IMessage<PlayerLifeSavingHairInfo>, IMessage, IEquatable<PlayerLifeSavingHairInfo>, IDeepCloneable<PlayerLifeSavingHairInfo>
{
	private static readonly MessageParser<PlayerLifeSavingHairInfo> _parser = new MessageParser<PlayerLifeSavingHairInfo>(() => new PlayerLifeSavingHairInfo());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float coolDown_;

	public static MessageParser<PlayerLifeSavingHairInfo> Parser => _parser;

	public float CoolDown
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return coolDown_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			coolDown_ = value;
		}
	}

	public bool HasCoolDown => (_hasBits0 & 1) != 0;

	public PlayerLifeSavingHairInfo()
	{
	}

	public PlayerLifeSavingHairInfo(PlayerLifeSavingHairInfo other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		coolDown_ = other.coolDown_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerLifeSavingHairInfo Clone()
	{
		return new PlayerLifeSavingHairInfo(this);
	}

	public void ClearCoolDown()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerLifeSavingHairInfo);
	}

	public bool Equals(PlayerLifeSavingHairInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (HasCoolDown)
		{
			output.WriteRawTag(13);
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

	public void MergeFrom(PlayerLifeSavingHairInfo other)
	{
		if (other != null)
		{
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
			if (num != 13)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				CoolDown = input.ReadFloat();
			}
		}
	}
}
