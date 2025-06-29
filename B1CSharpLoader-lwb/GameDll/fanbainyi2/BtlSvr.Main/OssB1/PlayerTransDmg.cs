using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class PlayerTransDmg : IMessage<PlayerTransDmg>, IMessage, IEquatable<PlayerTransDmg>, IDeepCloneable<PlayerTransDmg>
{
	private static readonly MessageParser<PlayerTransDmg> _parser = new MessageParser<PlayerTransDmg>(() => new PlayerTransDmg());

	private UnknownFieldSet _unknownFields;

	private string guid_ = "";

	private int extendId_;

	private int hpMax_;

	private static readonly FieldCodec<PlayerTransDmgInfo> _repeated_dmgInfo_codec = FieldCodec.ForMessage(34u, PlayerTransDmgInfo.Parser);

	private readonly RepeatedField<PlayerTransDmgInfo> dmgInfo_ = new RepeatedField<PlayerTransDmgInfo>();

	public static MessageParser<PlayerTransDmg> Parser => _parser;

	public string Guid
	{
		get
		{
			return guid_;
		}
		set
		{
			guid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
		}
	}

	public int HpMax
	{
		get
		{
			return hpMax_;
		}
		set
		{
			hpMax_ = value;
		}
	}

	public RepeatedField<PlayerTransDmgInfo> DmgInfo => dmgInfo_;

	public PlayerTransDmg()
	{
	}

	public PlayerTransDmg(PlayerTransDmg other)
		: this()
	{
		guid_ = other.guid_;
		extendId_ = other.extendId_;
		hpMax_ = other.hpMax_;
		dmgInfo_ = other.dmgInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerTransDmg Clone()
	{
		return new PlayerTransDmg(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerTransDmg);
	}

	public bool Equals(PlayerTransDmg other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Guid != other.Guid)
		{
			return false;
		}
		if (ExtendId != other.ExtendId)
		{
			return false;
		}
		if (HpMax != other.HpMax)
		{
			return false;
		}
		if (!dmgInfo_.Equals(other.dmgInfo_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Guid.Length != 0)
		{
			num ^= Guid.GetHashCode();
		}
		if (ExtendId != 0)
		{
			num ^= ExtendId.GetHashCode();
		}
		if (HpMax != 0)
		{
			num ^= HpMax.GetHashCode();
		}
		num ^= dmgInfo_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Guid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Guid);
		}
		if (ExtendId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ExtendId);
		}
		if (HpMax != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(HpMax);
		}
		dmgInfo_.WriteTo(output, _repeated_dmgInfo_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Guid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		if (ExtendId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtendId);
		}
		if (HpMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HpMax);
		}
		num += dmgInfo_.CalculateSize(_repeated_dmgInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerTransDmg other)
	{
		if (other != null)
		{
			if (other.Guid.Length != 0)
			{
				Guid = other.Guid;
			}
			if (other.ExtendId != 0)
			{
				ExtendId = other.ExtendId;
			}
			if (other.HpMax != 0)
			{
				HpMax = other.HpMax;
			}
			dmgInfo_.Add(other.dmgInfo_);
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
			case 10u:
				Guid = input.ReadString();
				break;
			case 16u:
				ExtendId = input.ReadInt32();
				break;
			case 24u:
				HpMax = input.ReadInt32();
				break;
			case 34u:
				dmgInfo_.AddEntriesFrom(input, _repeated_dmgInfo_codec);
				break;
			}
		}
	}
}
