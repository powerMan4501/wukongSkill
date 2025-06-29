using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionUpdateConfigReq : IMessage<VersionUpdateConfigReq>, IMessage, IEquatable<VersionUpdateConfigReq>, IDeepCloneable<VersionUpdateConfigReq>
{
	private static readonly MessageParser<VersionUpdateConfigReq> _parser = new MessageParser<VersionUpdateConfigReq>(() => new VersionUpdateConfigReq());

	private UnknownFieldSet _unknownFields;

	private string versionConfig_ = "";

	public static MessageParser<VersionUpdateConfigReq> Parser => _parser;

	public string VersionConfig
	{
		get
		{
			return versionConfig_;
		}
		set
		{
			versionConfig_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public VersionUpdateConfigReq()
	{
	}

	public VersionUpdateConfigReq(VersionUpdateConfigReq other)
		: this()
	{
		versionConfig_ = other.versionConfig_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionUpdateConfigReq Clone()
	{
		return new VersionUpdateConfigReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionUpdateConfigReq);
	}

	public bool Equals(VersionUpdateConfigReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VersionConfig != other.VersionConfig)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (VersionConfig.Length != 0)
		{
			num ^= VersionConfig.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (VersionConfig.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(VersionConfig);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (VersionConfig.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VersionConfig);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionUpdateConfigReq other)
	{
		if (other != null)
		{
			if (other.VersionConfig.Length != 0)
			{
				VersionConfig = other.VersionConfig;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				VersionConfig = input.ReadString();
			}
		}
	}
}
