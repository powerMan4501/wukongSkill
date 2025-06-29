using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class TalentDisplayCfg : IMessage<TalentDisplayCfg>, IMessage, IEquatable<TalentDisplayCfg>, IDeepCloneable<TalentDisplayCfg>
{
	private static readonly MessageParser<TalentDisplayCfg> _parser = new MessageParser<TalentDisplayCfg>(() => new TalentDisplayCfg());

	private UnknownFieldSet _unknownFields;

	private int level_;

	private string name_ = "";

	private string effectDesc_ = "";

	private string nextDesc_ = "";

	public static MessageParser<TalentDisplayCfg> Parser => _parser;

	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string EffectDesc
	{
		get
		{
			return effectDesc_;
		}
		set
		{
			effectDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NextDesc
	{
		get
		{
			return nextDesc_;
		}
		set
		{
			nextDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public TalentDisplayCfg()
	{
	}

	public TalentDisplayCfg(TalentDisplayCfg other)
		: this()
	{
		level_ = other.level_;
		name_ = other.name_;
		effectDesc_ = other.effectDesc_;
		nextDesc_ = other.nextDesc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TalentDisplayCfg Clone()
	{
		return new TalentDisplayCfg(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TalentDisplayCfg);
	}

	public bool Equals(TalentDisplayCfg other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (EffectDesc != other.EffectDesc)
		{
			return false;
		}
		if (NextDesc != other.NextDesc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (EffectDesc.Length != 0)
		{
			num ^= EffectDesc.GetHashCode();
		}
		if (NextDesc.Length != 0)
		{
			num ^= NextDesc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Level != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Level);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (EffectDesc.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(EffectDesc);
		}
		if (NextDesc.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(NextDesc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (EffectDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EffectDesc);
		}
		if (NextDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NextDesc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TalentDisplayCfg other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.EffectDesc.Length != 0)
			{
				EffectDesc = other.EffectDesc;
			}
			if (other.NextDesc.Length != 0)
			{
				NextDesc = other.NextDesc;
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
				Level = input.ReadInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 26u:
				EffectDesc = input.ReadString();
				break;
			case 34u:
				NextDesc = input.ReadString();
				break;
			}
		}
	}
}
