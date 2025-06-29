using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class VersionTestCheckConfigRes : IMessage<VersionTestCheckConfigRes>, IMessage, IEquatable<VersionTestCheckConfigRes>, IDeepCloneable<VersionTestCheckConfigRes>
{
	private static readonly MessageParser<VersionTestCheckConfigRes> _parser = new MessageParser<VersionTestCheckConfigRes>(() => new VersionTestCheckConfigRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private string jsonExConfig_ = "";

	private static readonly FieldCodec<string> _repeated_serverJsonConfig_codec = FieldCodec.ForString(26u);

	private readonly RepeatedField<string> serverJsonConfig_ = new RepeatedField<string>();

	public static MessageParser<VersionTestCheckConfigRes> Parser => _parser;

	public GssdkRet Ret
	{
		get
		{
			return ret_;
		}
		set
		{
			ret_ = value;
		}
	}

	public string JsonExConfig
	{
		get
		{
			return jsonExConfig_;
		}
		set
		{
			jsonExConfig_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> ServerJsonConfig => serverJsonConfig_;

	public VersionTestCheckConfigRes()
	{
	}

	public VersionTestCheckConfigRes(VersionTestCheckConfigRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		jsonExConfig_ = other.jsonExConfig_;
		serverJsonConfig_ = other.serverJsonConfig_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionTestCheckConfigRes Clone()
	{
		return new VersionTestCheckConfigRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionTestCheckConfigRes);
	}

	public bool Equals(VersionTestCheckConfigRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Ret, other.Ret))
		{
			return false;
		}
		if (JsonExConfig != other.JsonExConfig)
		{
			return false;
		}
		if (!serverJsonConfig_.Equals(other.serverJsonConfig_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ret_ != null)
		{
			num ^= Ret.GetHashCode();
		}
		if (JsonExConfig.Length != 0)
		{
			num ^= JsonExConfig.GetHashCode();
		}
		num ^= serverJsonConfig_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ret_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Ret);
		}
		if (JsonExConfig.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(JsonExConfig);
		}
		serverJsonConfig_.WriteTo(output, _repeated_serverJsonConfig_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ret_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Ret);
		}
		if (JsonExConfig.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(JsonExConfig);
		}
		num += serverJsonConfig_.CalculateSize(_repeated_serverJsonConfig_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionTestCheckConfigRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ret_ != null)
		{
			if (ret_ == null)
			{
				Ret = new GssdkRet();
			}
			Ret.MergeFrom(other.Ret);
		}
		if (other.JsonExConfig.Length != 0)
		{
			JsonExConfig = other.JsonExConfig;
		}
		serverJsonConfig_.Add(other.serverJsonConfig_);
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
				if (ret_ == null)
				{
					Ret = new GssdkRet();
				}
				input.ReadMessage(Ret);
				break;
			case 18u:
				JsonExConfig = input.ReadString();
				break;
			case 26u:
				serverJsonConfig_.AddEntriesFrom(input, _repeated_serverJsonConfig_codec);
				break;
			}
		}
	}
}
