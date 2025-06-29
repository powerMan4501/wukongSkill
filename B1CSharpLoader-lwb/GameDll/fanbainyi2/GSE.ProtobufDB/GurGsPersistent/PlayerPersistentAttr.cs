using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class PlayerPersistentAttr : IMessage<PlayerPersistentAttr>, IMessage, IEquatable<PlayerPersistentAttr>, IDeepCloneable<PlayerPersistentAttr>
{
	private static readonly MessageParser<PlayerPersistentAttr> _parser = new MessageParser<PlayerPersistentAttr>(() => new PlayerPersistentAttr());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int attrId_;

	private int attrMaxId_;

	private float attrValue_;

	private int attrValueType_;

	public static MessageParser<PlayerPersistentAttr> Parser => _parser;

	public int AttrId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return attrId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			attrId_ = value;
		}
	}

	public bool HasAttrId => (_hasBits0 & 1) != 0;

	public int AttrMaxId
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return attrMaxId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			attrMaxId_ = value;
		}
	}

	public bool HasAttrMaxId => (_hasBits0 & 2) != 0;

	public float AttrValue
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return attrValue_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 4;
			attrValue_ = value;
		}
	}

	public bool HasAttrValue => (_hasBits0 & 4) != 0;

	public int AttrValueType
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return attrValueType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8;
			attrValueType_ = value;
		}
	}

	public bool HasAttrValueType => (_hasBits0 & 8) != 0;

	public PlayerPersistentAttr()
	{
	}

	public PlayerPersistentAttr(PlayerPersistentAttr other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		attrId_ = other.attrId_;
		attrMaxId_ = other.attrMaxId_;
		attrValue_ = other.attrValue_;
		attrValueType_ = other.attrValueType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerPersistentAttr Clone()
	{
		return new PlayerPersistentAttr(this);
	}

	public void ClearAttrId()
	{
		_hasBits0 &= -2;
	}

	public void ClearAttrMaxId()
	{
		_hasBits0 &= -3;
	}

	public void ClearAttrValue()
	{
		_hasBits0 &= -5;
	}

	public void ClearAttrValueType()
	{
		_hasBits0 &= -9;
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerPersistentAttr);
	}

	public bool Equals(PlayerPersistentAttr other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AttrId != other.AttrId)
		{
			return false;
		}
		if (AttrMaxId != other.AttrMaxId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttrValue, other.AttrValue))
		{
			return false;
		}
		if (AttrValueType != other.AttrValueType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasAttrId)
		{
			num ^= AttrId.GetHashCode();
		}
		if (HasAttrMaxId)
		{
			num ^= AttrMaxId.GetHashCode();
		}
		if (HasAttrValue)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttrValue);
		}
		if (HasAttrValueType)
		{
			num ^= AttrValueType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasAttrId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AttrId);
		}
		if (HasAttrMaxId)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AttrMaxId);
		}
		if (HasAttrValue)
		{
			output.WriteRawTag(29);
			output.WriteFloat(AttrValue);
		}
		if (HasAttrValueType)
		{
			output.WriteRawTag(32);
			output.WriteInt32(AttrValueType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasAttrId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrId);
		}
		if (HasAttrMaxId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrMaxId);
		}
		if (HasAttrValue)
		{
			num += 5;
		}
		if (HasAttrValueType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrValueType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerPersistentAttr other)
	{
		if (other != null)
		{
			if (other.HasAttrId)
			{
				AttrId = other.AttrId;
			}
			if (other.HasAttrMaxId)
			{
				AttrMaxId = other.AttrMaxId;
			}
			if (other.HasAttrValue)
			{
				AttrValue = other.AttrValue;
			}
			if (other.HasAttrValueType)
			{
				AttrValueType = other.AttrValueType;
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
				AttrId = input.ReadInt32();
				break;
			case 16u:
				AttrMaxId = input.ReadInt32();
				break;
			case 29u:
				AttrValue = input.ReadFloat();
				break;
			case 32u:
				AttrValueType = input.ReadInt32();
				break;
			}
		}
	}
}
