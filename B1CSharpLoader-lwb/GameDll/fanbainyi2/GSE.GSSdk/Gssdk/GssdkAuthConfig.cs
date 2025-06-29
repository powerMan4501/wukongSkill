using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class GssdkAuthConfig : IMessage<GssdkAuthConfig>, IMessage, IEquatable<GssdkAuthConfig>, IDeepCloneable<GssdkAuthConfig>
{
	private static readonly MessageParser<GssdkAuthConfig> _parser = new MessageParser<GssdkAuthConfig>(() => new GssdkAuthConfig());

	private UnknownFieldSet _unknownFields;

	private string aeskey_ = "";

	private string md5Salt_ = "";

	private int tokenExpiredTime_;

	private string privKeyFile_ = "";

	private static readonly FieldCodec<string> _repeated_cfgEnvs_codec = FieldCodec.ForString(42u);

	private readonly RepeatedField<string> cfgEnvs_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_cfgBranches_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> cfgBranches_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_cfgPlatforms_codec = FieldCodec.ForString(58u);

	private readonly RepeatedField<string> cfgPlatforms_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_cfgChannels_codec = FieldCodec.ForString(66u);

	private readonly RepeatedField<string> cfgChannels_ = new RepeatedField<string>();

	private int clusterId_;

	private GssdkChannelAuthSteamConfig steamCfg_;

	private GssdkChannelAuthXblConfig xblCfg_;

	private GssdkChannelAuthWegameConfig wegameCfg_;

	private int withCrypt_;

	private string netProxy_ = "";

	private GssdkChannelAuthSteamConfig steamCfgBm_;

	private int withDataLog_;

	private GssdkChannelAuthPsnConfig psnCfg_;

	public static MessageParser<GssdkAuthConfig> Parser => _parser;

	public string Aeskey
	{
		get
		{
			return aeskey_;
		}
		set
		{
			aeskey_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Md5Salt
	{
		get
		{
			return md5Salt_;
		}
		set
		{
			md5Salt_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TokenExpiredTime
	{
		get
		{
			return tokenExpiredTime_;
		}
		set
		{
			tokenExpiredTime_ = value;
		}
	}

	public string PrivKeyFile
	{
		get
		{
			return privKeyFile_;
		}
		set
		{
			privKeyFile_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> CfgEnvs => cfgEnvs_;

	public RepeatedField<string> CfgBranches => cfgBranches_;

	public RepeatedField<string> CfgPlatforms => cfgPlatforms_;

	public RepeatedField<string> CfgChannels => cfgChannels_;

	public int ClusterId
	{
		get
		{
			return clusterId_;
		}
		set
		{
			clusterId_ = value;
		}
	}

	public GssdkChannelAuthSteamConfig SteamCfg
	{
		get
		{
			return steamCfg_;
		}
		set
		{
			steamCfg_ = value;
		}
	}

	public GssdkChannelAuthXblConfig XblCfg
	{
		get
		{
			return xblCfg_;
		}
		set
		{
			xblCfg_ = value;
		}
	}

	public GssdkChannelAuthWegameConfig WegameCfg
	{
		get
		{
			return wegameCfg_;
		}
		set
		{
			wegameCfg_ = value;
		}
	}

	public int WithCrypt
	{
		get
		{
			return withCrypt_;
		}
		set
		{
			withCrypt_ = value;
		}
	}

	public string NetProxy
	{
		get
		{
			return netProxy_;
		}
		set
		{
			netProxy_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkChannelAuthSteamConfig SteamCfgBm
	{
		get
		{
			return steamCfgBm_;
		}
		set
		{
			steamCfgBm_ = value;
		}
	}

	public int WithDataLog
	{
		get
		{
			return withDataLog_;
		}
		set
		{
			withDataLog_ = value;
		}
	}

	public GssdkChannelAuthPsnConfig PsnCfg
	{
		get
		{
			return psnCfg_;
		}
		set
		{
			psnCfg_ = value;
		}
	}

	public GssdkAuthConfig()
	{
	}

	public GssdkAuthConfig(GssdkAuthConfig other)
		: this()
	{
		aeskey_ = other.aeskey_;
		md5Salt_ = other.md5Salt_;
		tokenExpiredTime_ = other.tokenExpiredTime_;
		privKeyFile_ = other.privKeyFile_;
		cfgEnvs_ = other.cfgEnvs_.Clone();
		cfgBranches_ = other.cfgBranches_.Clone();
		cfgPlatforms_ = other.cfgPlatforms_.Clone();
		cfgChannels_ = other.cfgChannels_.Clone();
		clusterId_ = other.clusterId_;
		steamCfg_ = ((other.steamCfg_ != null) ? other.steamCfg_.Clone() : null);
		xblCfg_ = ((other.xblCfg_ != null) ? other.xblCfg_.Clone() : null);
		wegameCfg_ = ((other.wegameCfg_ != null) ? other.wegameCfg_.Clone() : null);
		withCrypt_ = other.withCrypt_;
		netProxy_ = other.netProxy_;
		steamCfgBm_ = ((other.steamCfgBm_ != null) ? other.steamCfgBm_.Clone() : null);
		withDataLog_ = other.withDataLog_;
		psnCfg_ = ((other.psnCfg_ != null) ? other.psnCfg_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkAuthConfig Clone()
	{
		return new GssdkAuthConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkAuthConfig);
	}

	public bool Equals(GssdkAuthConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Aeskey != other.Aeskey)
		{
			return false;
		}
		if (Md5Salt != other.Md5Salt)
		{
			return false;
		}
		if (TokenExpiredTime != other.TokenExpiredTime)
		{
			return false;
		}
		if (PrivKeyFile != other.PrivKeyFile)
		{
			return false;
		}
		if (!cfgEnvs_.Equals(other.cfgEnvs_))
		{
			return false;
		}
		if (!cfgBranches_.Equals(other.cfgBranches_))
		{
			return false;
		}
		if (!cfgPlatforms_.Equals(other.cfgPlatforms_))
		{
			return false;
		}
		if (!cfgChannels_.Equals(other.cfgChannels_))
		{
			return false;
		}
		if (ClusterId != other.ClusterId)
		{
			return false;
		}
		if (!object.Equals(SteamCfg, other.SteamCfg))
		{
			return false;
		}
		if (!object.Equals(XblCfg, other.XblCfg))
		{
			return false;
		}
		if (!object.Equals(WegameCfg, other.WegameCfg))
		{
			return false;
		}
		if (WithCrypt != other.WithCrypt)
		{
			return false;
		}
		if (NetProxy != other.NetProxy)
		{
			return false;
		}
		if (!object.Equals(SteamCfgBm, other.SteamCfgBm))
		{
			return false;
		}
		if (WithDataLog != other.WithDataLog)
		{
			return false;
		}
		if (!object.Equals(PsnCfg, other.PsnCfg))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Aeskey.Length != 0)
		{
			num ^= Aeskey.GetHashCode();
		}
		if (Md5Salt.Length != 0)
		{
			num ^= Md5Salt.GetHashCode();
		}
		if (TokenExpiredTime != 0)
		{
			num ^= TokenExpiredTime.GetHashCode();
		}
		if (PrivKeyFile.Length != 0)
		{
			num ^= PrivKeyFile.GetHashCode();
		}
		num ^= cfgEnvs_.GetHashCode();
		num ^= cfgBranches_.GetHashCode();
		num ^= cfgPlatforms_.GetHashCode();
		num ^= cfgChannels_.GetHashCode();
		if (ClusterId != 0)
		{
			num ^= ClusterId.GetHashCode();
		}
		if (steamCfg_ != null)
		{
			num ^= SteamCfg.GetHashCode();
		}
		if (xblCfg_ != null)
		{
			num ^= XblCfg.GetHashCode();
		}
		if (wegameCfg_ != null)
		{
			num ^= WegameCfg.GetHashCode();
		}
		if (WithCrypt != 0)
		{
			num ^= WithCrypt.GetHashCode();
		}
		if (NetProxy.Length != 0)
		{
			num ^= NetProxy.GetHashCode();
		}
		if (steamCfgBm_ != null)
		{
			num ^= SteamCfgBm.GetHashCode();
		}
		if (WithDataLog != 0)
		{
			num ^= WithDataLog.GetHashCode();
		}
		if (psnCfg_ != null)
		{
			num ^= PsnCfg.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Aeskey.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Aeskey);
		}
		if (Md5Salt.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Md5Salt);
		}
		if (TokenExpiredTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TokenExpiredTime);
		}
		if (PrivKeyFile.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(PrivKeyFile);
		}
		cfgEnvs_.WriteTo(output, _repeated_cfgEnvs_codec);
		cfgBranches_.WriteTo(output, _repeated_cfgBranches_codec);
		cfgPlatforms_.WriteTo(output, _repeated_cfgPlatforms_codec);
		cfgChannels_.WriteTo(output, _repeated_cfgChannels_codec);
		if (ClusterId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ClusterId);
		}
		if (steamCfg_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(SteamCfg);
		}
		if (xblCfg_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(XblCfg);
		}
		if (wegameCfg_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(WegameCfg);
		}
		if (WithCrypt != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(WithCrypt);
		}
		if (NetProxy.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(NetProxy);
		}
		if (steamCfgBm_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(SteamCfgBm);
		}
		if (WithDataLog != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(WithDataLog);
		}
		if (psnCfg_ != null)
		{
			output.WriteRawTag(138, 1);
			output.WriteMessage(PsnCfg);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Aeskey.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Aeskey);
		}
		if (Md5Salt.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Md5Salt);
		}
		if (TokenExpiredTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TokenExpiredTime);
		}
		if (PrivKeyFile.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PrivKeyFile);
		}
		num += cfgEnvs_.CalculateSize(_repeated_cfgEnvs_codec);
		num += cfgBranches_.CalculateSize(_repeated_cfgBranches_codec);
		num += cfgPlatforms_.CalculateSize(_repeated_cfgPlatforms_codec);
		num += cfgChannels_.CalculateSize(_repeated_cfgChannels_codec);
		if (ClusterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClusterId);
		}
		if (steamCfg_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SteamCfg);
		}
		if (xblCfg_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(XblCfg);
		}
		if (wegameCfg_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WegameCfg);
		}
		if (WithCrypt != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WithCrypt);
		}
		if (NetProxy.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NetProxy);
		}
		if (steamCfgBm_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SteamCfgBm);
		}
		if (WithDataLog != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WithDataLog);
		}
		if (psnCfg_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PsnCfg);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkAuthConfig other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Aeskey.Length != 0)
		{
			Aeskey = other.Aeskey;
		}
		if (other.Md5Salt.Length != 0)
		{
			Md5Salt = other.Md5Salt;
		}
		if (other.TokenExpiredTime != 0)
		{
			TokenExpiredTime = other.TokenExpiredTime;
		}
		if (other.PrivKeyFile.Length != 0)
		{
			PrivKeyFile = other.PrivKeyFile;
		}
		cfgEnvs_.Add(other.cfgEnvs_);
		cfgBranches_.Add(other.cfgBranches_);
		cfgPlatforms_.Add(other.cfgPlatforms_);
		cfgChannels_.Add(other.cfgChannels_);
		if (other.ClusterId != 0)
		{
			ClusterId = other.ClusterId;
		}
		if (other.steamCfg_ != null)
		{
			if (steamCfg_ == null)
			{
				SteamCfg = new GssdkChannelAuthSteamConfig();
			}
			SteamCfg.MergeFrom(other.SteamCfg);
		}
		if (other.xblCfg_ != null)
		{
			if (xblCfg_ == null)
			{
				XblCfg = new GssdkChannelAuthXblConfig();
			}
			XblCfg.MergeFrom(other.XblCfg);
		}
		if (other.wegameCfg_ != null)
		{
			if (wegameCfg_ == null)
			{
				WegameCfg = new GssdkChannelAuthWegameConfig();
			}
			WegameCfg.MergeFrom(other.WegameCfg);
		}
		if (other.WithCrypt != 0)
		{
			WithCrypt = other.WithCrypt;
		}
		if (other.NetProxy.Length != 0)
		{
			NetProxy = other.NetProxy;
		}
		if (other.steamCfgBm_ != null)
		{
			if (steamCfgBm_ == null)
			{
				SteamCfgBm = new GssdkChannelAuthSteamConfig();
			}
			SteamCfgBm.MergeFrom(other.SteamCfgBm);
		}
		if (other.WithDataLog != 0)
		{
			WithDataLog = other.WithDataLog;
		}
		if (other.psnCfg_ != null)
		{
			if (psnCfg_ == null)
			{
				PsnCfg = new GssdkChannelAuthPsnConfig();
			}
			PsnCfg.MergeFrom(other.PsnCfg);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Aeskey = input.ReadString();
				break;
			case 18u:
				Md5Salt = input.ReadString();
				break;
			case 24u:
				TokenExpiredTime = input.ReadInt32();
				break;
			case 34u:
				PrivKeyFile = input.ReadString();
				break;
			case 42u:
				cfgEnvs_.AddEntriesFrom(input, _repeated_cfgEnvs_codec);
				break;
			case 50u:
				cfgBranches_.AddEntriesFrom(input, _repeated_cfgBranches_codec);
				break;
			case 58u:
				cfgPlatforms_.AddEntriesFrom(input, _repeated_cfgPlatforms_codec);
				break;
			case 66u:
				cfgChannels_.AddEntriesFrom(input, _repeated_cfgChannels_codec);
				break;
			case 72u:
				ClusterId = input.ReadInt32();
				break;
			case 82u:
				if (steamCfg_ == null)
				{
					SteamCfg = new GssdkChannelAuthSteamConfig();
				}
				input.ReadMessage(SteamCfg);
				break;
			case 90u:
				if (xblCfg_ == null)
				{
					XblCfg = new GssdkChannelAuthXblConfig();
				}
				input.ReadMessage(XblCfg);
				break;
			case 98u:
				if (wegameCfg_ == null)
				{
					WegameCfg = new GssdkChannelAuthWegameConfig();
				}
				input.ReadMessage(WegameCfg);
				break;
			case 104u:
				WithCrypt = input.ReadInt32();
				break;
			case 114u:
				NetProxy = input.ReadString();
				break;
			case 122u:
				if (steamCfgBm_ == null)
				{
					SteamCfgBm = new GssdkChannelAuthSteamConfig();
				}
				input.ReadMessage(SteamCfgBm);
				break;
			case 128u:
				WithDataLog = input.ReadInt32();
				break;
			case 138u:
				if (psnCfg_ == null)
				{
					PsnCfg = new GssdkChannelAuthPsnConfig();
				}
				input.ReadMessage(PsnCfg);
				break;
			}
		}
	}
}
