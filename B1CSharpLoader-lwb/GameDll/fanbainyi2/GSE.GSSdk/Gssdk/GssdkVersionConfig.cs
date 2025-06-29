using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class GssdkVersionConfig : IMessage<GssdkVersionConfig>, IMessage, IEquatable<GssdkVersionConfig>, IDeepCloneable<GssdkVersionConfig>
{
	private static readonly MessageParser<GssdkVersionConfig> _parser = new MessageParser<GssdkVersionConfig>(() => new GssdkVersionConfig());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<GssdkCdnUnit> _repeated_cdns_codec = FieldCodec.ForMessage(10u, GssdkCdnUnit.Parser);

	private readonly RepeatedField<GssdkCdnUnit> cdns_ = new RepeatedField<GssdkCdnUnit>();

	private static readonly FieldCodec<string> _repeated_cfgEnvs_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> cfgEnvs_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_cfgBranches_codec = FieldCodec.ForString(26u);

	private readonly RepeatedField<string> cfgBranches_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_cfgPlatforms_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> cfgPlatforms_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_cfgChannels_codec = FieldCodec.ForString(42u);

	private readonly RepeatedField<string> cfgChannels_ = new RepeatedField<string>();

	private int withCrypt_;

	private int withDataLog_;

	public static MessageParser<GssdkVersionConfig> Parser => _parser;

	public RepeatedField<GssdkCdnUnit> Cdns => cdns_;

	public RepeatedField<string> CfgEnvs => cfgEnvs_;

	public RepeatedField<string> CfgBranches => cfgBranches_;

	public RepeatedField<string> CfgPlatforms => cfgPlatforms_;

	public RepeatedField<string> CfgChannels => cfgChannels_;

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

	public GssdkVersionConfig()
	{
	}

	public GssdkVersionConfig(GssdkVersionConfig other)
		: this()
	{
		cdns_ = other.cdns_.Clone();
		cfgEnvs_ = other.cfgEnvs_.Clone();
		cfgBranches_ = other.cfgBranches_.Clone();
		cfgPlatforms_ = other.cfgPlatforms_.Clone();
		cfgChannels_ = other.cfgChannels_.Clone();
		withCrypt_ = other.withCrypt_;
		withDataLog_ = other.withDataLog_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkVersionConfig Clone()
	{
		return new GssdkVersionConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkVersionConfig);
	}

	public bool Equals(GssdkVersionConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cdns_.Equals(other.cdns_))
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
		if (WithCrypt != other.WithCrypt)
		{
			return false;
		}
		if (WithDataLog != other.WithDataLog)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= cdns_.GetHashCode();
		num ^= cfgEnvs_.GetHashCode();
		num ^= cfgBranches_.GetHashCode();
		num ^= cfgPlatforms_.GetHashCode();
		num ^= cfgChannels_.GetHashCode();
		if (WithCrypt != 0)
		{
			num ^= WithCrypt.GetHashCode();
		}
		if (WithDataLog != 0)
		{
			num ^= WithDataLog.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		cdns_.WriteTo(output, _repeated_cdns_codec);
		cfgEnvs_.WriteTo(output, _repeated_cfgEnvs_codec);
		cfgBranches_.WriteTo(output, _repeated_cfgBranches_codec);
		cfgPlatforms_.WriteTo(output, _repeated_cfgPlatforms_codec);
		cfgChannels_.WriteTo(output, _repeated_cfgChannels_codec);
		if (WithCrypt != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(WithCrypt);
		}
		if (WithDataLog != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(WithDataLog);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += cdns_.CalculateSize(_repeated_cdns_codec);
		num += cfgEnvs_.CalculateSize(_repeated_cfgEnvs_codec);
		num += cfgBranches_.CalculateSize(_repeated_cfgBranches_codec);
		num += cfgPlatforms_.CalculateSize(_repeated_cfgPlatforms_codec);
		num += cfgChannels_.CalculateSize(_repeated_cfgChannels_codec);
		if (WithCrypt != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WithCrypt);
		}
		if (WithDataLog != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WithDataLog);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkVersionConfig other)
	{
		if (other != null)
		{
			cdns_.Add(other.cdns_);
			cfgEnvs_.Add(other.cfgEnvs_);
			cfgBranches_.Add(other.cfgBranches_);
			cfgPlatforms_.Add(other.cfgPlatforms_);
			cfgChannels_.Add(other.cfgChannels_);
			if (other.WithCrypt != 0)
			{
				WithCrypt = other.WithCrypt;
			}
			if (other.WithDataLog != 0)
			{
				WithDataLog = other.WithDataLog;
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
				cdns_.AddEntriesFrom(input, _repeated_cdns_codec);
				break;
			case 18u:
				cfgEnvs_.AddEntriesFrom(input, _repeated_cfgEnvs_codec);
				break;
			case 26u:
				cfgBranches_.AddEntriesFrom(input, _repeated_cfgBranches_codec);
				break;
			case 34u:
				cfgPlatforms_.AddEntriesFrom(input, _repeated_cfgPlatforms_codec);
				break;
			case 42u:
				cfgChannels_.AddEntriesFrom(input, _repeated_cfgChannels_codec);
				break;
			case 48u:
				WithCrypt = input.ReadInt32();
				break;
			case 56u:
				WithDataLog = input.ReadInt32();
				break;
			}
		}
	}
}
