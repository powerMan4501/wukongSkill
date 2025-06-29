using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkDirConfig : IMessage<GssdkDirConfig>, IMessage, IEquatable<GssdkDirConfig>, IDeepCloneable<GssdkDirConfig>
{
	private static readonly MessageParser<GssdkDirConfig> _parser = new MessageParser<GssdkDirConfig>(() => new GssdkDirConfig());

	private UnknownFieldSet _unknownFields;

	private string oaddrs_ = "";

	public static MessageParser<GssdkDirConfig> Parser => _parser;

	public string Oaddrs
	{
		get
		{
			return oaddrs_;
		}
		set
		{
			oaddrs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkDirConfig()
	{
	}

	public GssdkDirConfig(GssdkDirConfig other)
		: this()
	{
		oaddrs_ = other.oaddrs_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkDirConfig Clone()
	{
		return new GssdkDirConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkDirConfig);
	}

	public bool Equals(GssdkDirConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Oaddrs != other.Oaddrs)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Oaddrs.Length != 0)
		{
			num ^= Oaddrs.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Oaddrs.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Oaddrs);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Oaddrs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Oaddrs);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkDirConfig other)
	{
		if (other != null)
		{
			if (other.Oaddrs.Length != 0)
			{
				Oaddrs = other.Oaddrs;
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
				Oaddrs = input.ReadString();
			}
		}
	}
}
