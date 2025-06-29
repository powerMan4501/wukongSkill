using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkCustomJsonConfig : IMessage<GssdkCustomJsonConfig>, IMessage, IEquatable<GssdkCustomJsonConfig>, IDeepCloneable<GssdkCustomJsonConfig>
{
	private static readonly MessageParser<GssdkCustomJsonConfig> _parser = new MessageParser<GssdkCustomJsonConfig>(() => new GssdkCustomJsonConfig());

	private UnknownFieldSet _unknownFields;

	private long id_;

	private string env_ = "";

	private string branch_ = "";

	private GssdkJsonConfigDataType cfgType_;

	private GssdkJsonConfigType type_;

	private string value_ = "";

	private string channel_ = "";

	private string cfg_ = "";

	private string cuser_ = "";

	private uint ctime_;

	private string uuser_ = "";

	private uint utime_;

	private int ver_;

	public static MessageParser<GssdkCustomJsonConfig> Parser => _parser;

	public long Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

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

	public GssdkJsonConfigDataType CfgType
	{
		get
		{
			return cfgType_;
		}
		set
		{
			cfgType_ = value;
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

	public string Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public string Cuser
	{
		get
		{
			return cuser_;
		}
		set
		{
			cuser_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint Ctime
	{
		get
		{
			return ctime_;
		}
		set
		{
			ctime_ = value;
		}
	}

	public string Uuser
	{
		get
		{
			return uuser_;
		}
		set
		{
			uuser_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint Utime
	{
		get
		{
			return utime_;
		}
		set
		{
			utime_ = value;
		}
	}

	public int Ver
	{
		get
		{
			return ver_;
		}
		set
		{
			ver_ = value;
		}
	}

	public GssdkCustomJsonConfig()
	{
	}

	public GssdkCustomJsonConfig(GssdkCustomJsonConfig other)
		: this()
	{
		id_ = other.id_;
		env_ = other.env_;
		branch_ = other.branch_;
		cfgType_ = other.cfgType_;
		type_ = other.type_;
		value_ = other.value_;
		channel_ = other.channel_;
		cfg_ = other.cfg_;
		cuser_ = other.cuser_;
		ctime_ = other.ctime_;
		uuser_ = other.uuser_;
		utime_ = other.utime_;
		ver_ = other.ver_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkCustomJsonConfig Clone()
	{
		return new GssdkCustomJsonConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkCustomJsonConfig);
	}

	public bool Equals(GssdkCustomJsonConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Env != other.Env)
		{
			return false;
		}
		if (Branch != other.Branch)
		{
			return false;
		}
		if (CfgType != other.CfgType)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Value != other.Value)
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
		if (Cuser != other.Cuser)
		{
			return false;
		}
		if (Ctime != other.Ctime)
		{
			return false;
		}
		if (Uuser != other.Uuser)
		{
			return false;
		}
		if (Utime != other.Utime)
		{
			return false;
		}
		if (Ver != other.Ver)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0L)
		{
			num ^= Id.GetHashCode();
		}
		if (Env.Length != 0)
		{
			num ^= Env.GetHashCode();
		}
		if (Branch.Length != 0)
		{
			num ^= Branch.GetHashCode();
		}
		if (CfgType != GssdkJsonConfigDataType.Default)
		{
			num ^= CfgType.GetHashCode();
		}
		if (Type != GssdkJsonConfigType.GcctGlobal)
		{
			num ^= Type.GetHashCode();
		}
		if (Value.Length != 0)
		{
			num ^= Value.GetHashCode();
		}
		if (Channel.Length != 0)
		{
			num ^= Channel.GetHashCode();
		}
		if (Cfg.Length != 0)
		{
			num ^= Cfg.GetHashCode();
		}
		if (Cuser.Length != 0)
		{
			num ^= Cuser.GetHashCode();
		}
		if (Ctime != 0)
		{
			num ^= Ctime.GetHashCode();
		}
		if (Uuser.Length != 0)
		{
			num ^= Uuser.GetHashCode();
		}
		if (Utime != 0)
		{
			num ^= Utime.GetHashCode();
		}
		if (Ver != 0)
		{
			num ^= Ver.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Id);
		}
		if (Env.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Env);
		}
		if (Branch.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Branch);
		}
		if (CfgType != GssdkJsonConfigDataType.Default)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)CfgType);
		}
		if (Type != GssdkJsonConfigType.GcctGlobal)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Type);
		}
		if (Value.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Value);
		}
		if (Channel.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Channel);
		}
		if (Cfg.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(Cfg);
		}
		if (Cuser.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(Cuser);
		}
		if (Ctime != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Ctime);
		}
		if (Uuser.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Uuser);
		}
		if (Utime != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Utime);
		}
		if (Ver != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(Ver);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Id);
		}
		if (Env.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Env);
		}
		if (Branch.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Branch);
		}
		if (CfgType != GssdkJsonConfigDataType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CfgType);
		}
		if (Type != GssdkJsonConfigType.GcctGlobal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Value.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Value);
		}
		if (Channel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Channel);
		}
		if (Cfg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Cfg);
		}
		if (Cuser.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Cuser);
		}
		if (Ctime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Ctime);
		}
		if (Uuser.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Uuser);
		}
		if (Utime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Utime);
		}
		if (Ver != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Ver);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkCustomJsonConfig other)
	{
		if (other != null)
		{
			if (other.Id != 0L)
			{
				Id = other.Id;
			}
			if (other.Env.Length != 0)
			{
				Env = other.Env;
			}
			if (other.Branch.Length != 0)
			{
				Branch = other.Branch;
			}
			if (other.CfgType != GssdkJsonConfigDataType.Default)
			{
				CfgType = other.CfgType;
			}
			if (other.Type != GssdkJsonConfigType.GcctGlobal)
			{
				Type = other.Type;
			}
			if (other.Value.Length != 0)
			{
				Value = other.Value;
			}
			if (other.Channel.Length != 0)
			{
				Channel = other.Channel;
			}
			if (other.Cfg.Length != 0)
			{
				Cfg = other.Cfg;
			}
			if (other.Cuser.Length != 0)
			{
				Cuser = other.Cuser;
			}
			if (other.Ctime != 0)
			{
				Ctime = other.Ctime;
			}
			if (other.Uuser.Length != 0)
			{
				Uuser = other.Uuser;
			}
			if (other.Utime != 0)
			{
				Utime = other.Utime;
			}
			if (other.Ver != 0)
			{
				Ver = other.Ver;
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
				Id = input.ReadInt64();
				break;
			case 18u:
				Env = input.ReadString();
				break;
			case 26u:
				Branch = input.ReadString();
				break;
			case 32u:
				CfgType = (GssdkJsonConfigDataType)input.ReadEnum();
				break;
			case 40u:
				Type = (GssdkJsonConfigType)input.ReadEnum();
				break;
			case 50u:
				Value = input.ReadString();
				break;
			case 58u:
				Channel = input.ReadString();
				break;
			case 66u:
				Cfg = input.ReadString();
				break;
			case 74u:
				Cuser = input.ReadString();
				break;
			case 80u:
				Ctime = input.ReadUInt32();
				break;
			case 90u:
				Uuser = input.ReadString();
				break;
			case 96u:
				Utime = input.ReadUInt32();
				break;
			case 104u:
				Ver = input.ReadInt32();
				break;
			}
		}
	}
}
