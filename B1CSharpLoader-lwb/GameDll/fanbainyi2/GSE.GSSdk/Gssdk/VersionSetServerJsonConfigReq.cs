using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionSetServerJsonConfigReq : IMessage<VersionSetServerJsonConfigReq>, IMessage, IEquatable<VersionSetServerJsonConfigReq>, IDeepCloneable<VersionSetServerJsonConfigReq>
{
	private static readonly MessageParser<VersionSetServerJsonConfigReq> _parser = new MessageParser<VersionSetServerJsonConfigReq>(() => new VersionSetServerJsonConfigReq());

	private UnknownFieldSet _unknownFields;

	private string env_ = "";

	private string branch_ = "";

	private GssdkJsonConfigType type_;

	private string tpValue_ = "";

	private string channel_ = "";

	private string cfg_ = "";

	public static MessageParser<VersionSetServerJsonConfigReq> Parser => _parser;

	public string Env
	{
		get
		{
			return env_;
		}
		set
		{
			env_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Branch
	{
		get
		{
			return branch_;
		}
		set
		{
			branch_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkJsonConfigType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public string TpValue
	{
		get
		{
			return tpValue_;
		}
		set
		{
			tpValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Channel
	{
		get
		{
			return channel_;
		}
		set
		{
			channel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Cfg
	{
		get
		{
			return cfg_;
		}
		set
		{
			cfg_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public VersionSetServerJsonConfigReq()
	{
	}

	public VersionSetServerJsonConfigReq(VersionSetServerJsonConfigReq other)
		: this()
	{
		env_ = other.env_;
		branch_ = other.branch_;
		type_ = other.type_;
		tpValue_ = other.tpValue_;
		channel_ = other.channel_;
		cfg_ = other.cfg_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionSetServerJsonConfigReq Clone()
	{
		return new VersionSetServerJsonConfigReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionSetServerJsonConfigReq);
	}

	public bool Equals(VersionSetServerJsonConfigReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Env != other.Env)
		{
			return false;
		}
		if (Branch != other.Branch)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (TpValue != other.TpValue)
		{
			return false;
		}
		if (Channel != other.Channel)
		{
			return false;
		}
		if (Cfg != other.Cfg)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Env.Length != 0)
		{
			num ^= Env.GetHashCode();
		}
		if (Branch.Length != 0)
		{
			num ^= Branch.GetHashCode();
		}
		if (Type != GssdkJsonConfigType.GcctGlobal)
		{
			num ^= Type.GetHashCode();
		}
		if (TpValue.Length != 0)
		{
			num ^= TpValue.GetHashCode();
		}
		if (Channel.Length != 0)
		{
			num ^= Channel.GetHashCode();
		}
		if (Cfg.Length != 0)
		{
			num ^= Cfg.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Env.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Env);
		}
		if (Branch.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Branch);
		}
		if (Type != GssdkJsonConfigType.GcctGlobal)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Type);
		}
		if (TpValue.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(TpValue);
		}
		if (Channel.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Channel);
		}
		if (Cfg.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Cfg);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Env.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Env);
		}
		if (Branch.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Branch);
		}
		if (Type != GssdkJsonConfigType.GcctGlobal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (TpValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TpValue);
		}
		if (Channel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Channel);
		}
		if (Cfg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Cfg);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionSetServerJsonConfigReq other)
	{
		if (other != null)
		{
			if (other.Env.Length != 0)
			{
				Env = other.Env;
			}
			if (other.Branch.Length != 0)
			{
				Branch = other.Branch;
			}
			if (other.Type != GssdkJsonConfigType.GcctGlobal)
			{
				Type = other.Type;
			}
			if (other.TpValue.Length != 0)
			{
				TpValue = other.TpValue;
			}
			if (other.Channel.Length != 0)
			{
				Channel = other.Channel;
			}
			if (other.Cfg.Length != 0)
			{
				Cfg = other.Cfg;
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
			case 10u:
				Env = input.ReadString();
				break;
			case 18u:
				Branch = input.ReadString();
				break;
			case 24u:
				Type = (GssdkJsonConfigType)input.ReadEnum();
				break;
			case 34u:
				TpValue = input.ReadString();
				break;
			case 42u:
				Channel = input.ReadString();
				break;
			case 50u:
				Cfg = input.ReadString();
				break;
			}
		}
	}
}
