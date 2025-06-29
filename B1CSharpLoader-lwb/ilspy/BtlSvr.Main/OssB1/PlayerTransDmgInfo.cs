using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class PlayerTransDmgInfo : IMessage<PlayerTransDmgInfo>, IMessage, IEquatable<PlayerTransDmgInfo>, IDeepCloneable<PlayerTransDmgInfo>
{
	private static readonly MessageParser<PlayerTransDmgInfo> _parser = new MessageParser<PlayerTransDmgInfo>(() => new PlayerTransDmgInfo());

	private UnknownFieldSet _unknownFields;

	private int skillId_;

	private float dmgValue_;

	public static MessageParser<PlayerTransDmgInfo> Parser => _parser;

	public int SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	public float DmgValue
	{
		get
		{
			return dmgValue_;
		}
		set
		{
			dmgValue_ = value;
		}
	}

	public PlayerTransDmgInfo()
	{
	}

	public PlayerTransDmgInfo(PlayerTransDmgInfo other)
		: this()
	{
		skillId_ = other.skillId_;
		dmgValue_ = other.dmgValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerTransDmgInfo Clone()
	{
		return new PlayerTransDmgInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerTransDmgInfo);
	}

	public bool Equals(PlayerTransDmgInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DmgValue, other.DmgValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (DmgValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DmgValue);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SkillId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SkillId);
		}
		if (DmgValue != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(DmgValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (DmgValue != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerTransDmgInfo other)
	{
		if (other != null)
		{
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.DmgValue != 0f)
			{
				DmgValue = other.DmgValue;
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
				SkillId = input.ReadInt32();
				break;
			case 21u:
				DmgValue = input.ReadFloat();
				break;
			}
		}
	}
}
