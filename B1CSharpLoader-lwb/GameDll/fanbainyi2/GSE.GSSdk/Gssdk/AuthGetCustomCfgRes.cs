using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class AuthGetCustomCfgRes : IMessage<AuthGetCustomCfgRes>, IMessage, IEquatable<AuthGetCustomCfgRes>, IDeepCloneable<AuthGetCustomCfgRes>
{
	private static readonly MessageParser<AuthGetCustomCfgRes> _parser = new MessageParser<AuthGetCustomCfgRes>(() => new AuthGetCustomCfgRes());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<string> _repeated_cfgPlatforms_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> cfgPlatforms_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_cfgChannels_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> cfgChannels_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_cfgEnvs_codec = FieldCodec.ForString(26u);

	private readonly RepeatedField<string> cfgEnvs_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_cfgBranches_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> cfgBranches_ = new RepeatedField<string>();

	public static MessageParser<AuthGetCustomCfgRes> Parser => _parser;

	public RepeatedField<string> CfgPlatforms => cfgPlatforms_;

	public RepeatedField<string> CfgChannels => cfgChannels_;

	public RepeatedField<string> CfgEnvs => cfgEnvs_;

	public RepeatedField<string> CfgBranches => cfgBranches_;

	public AuthGetCustomCfgRes()
	{
	}

	public AuthGetCustomCfgRes(AuthGetCustomCfgRes other)
		: this()
	{
		cfgPlatforms_ = other.cfgPlatforms_.Clone();
		cfgChannels_ = other.cfgChannels_.Clone();
		cfgEnvs_ = other.cfgEnvs_.Clone();
		cfgBranches_ = other.cfgBranches_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthGetCustomCfgRes Clone()
	{
		return new AuthGetCustomCfgRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthGetCustomCfgRes);
	}

	public bool Equals(AuthGetCustomCfgRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cfgPlatforms_.Equals(other.cfgPlatforms_))
		{
			return false;
		}
		if (!cfgChannels_.Equals(other.cfgChannels_))
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= cfgPlatforms_.GetHashCode();
		num ^= cfgChannels_.GetHashCode();
		num ^= cfgEnvs_.GetHashCode();
		num ^= cfgBranches_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		cfgPlatforms_.WriteTo(output, _repeated_cfgPlatforms_codec);
		cfgChannels_.WriteTo(output, _repeated_cfgChannels_codec);
		cfgEnvs_.WriteTo(output, _repeated_cfgEnvs_codec);
		cfgBranches_.WriteTo(output, _repeated_cfgBranches_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += cfgPlatforms_.CalculateSize(_repeated_cfgPlatforms_codec);
		num += cfgChannels_.CalculateSize(_repeated_cfgChannels_codec);
		num += cfgEnvs_.CalculateSize(_repeated_cfgEnvs_codec);
		num += cfgBranches_.CalculateSize(_repeated_cfgBranches_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthGetCustomCfgRes other)
	{
		if (other != null)
		{
			cfgPlatforms_.Add(other.cfgPlatforms_);
			cfgChannels_.Add(other.cfgChannels_);
			cfgEnvs_.Add(other.cfgEnvs_);
			cfgBranches_.Add(other.cfgBranches_);
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
				cfgPlatforms_.AddEntriesFrom(input, _repeated_cfgPlatforms_codec);
				break;
			case 18u:
				cfgChannels_.AddEntriesFrom(input, _repeated_cfgChannels_codec);
				break;
			case 26u:
				cfgEnvs_.AddEntriesFrom(input, _repeated_cfgEnvs_codec);
				break;
			case 34u:
				cfgBranches_.AddEntriesFrom(input, _repeated_cfgBranches_codec);
				break;
			}
		}
	}
}
