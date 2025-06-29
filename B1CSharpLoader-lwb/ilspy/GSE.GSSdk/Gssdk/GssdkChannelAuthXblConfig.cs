using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkChannelAuthXblConfig : IMessage<GssdkChannelAuthXblConfig>, IMessage, IEquatable<GssdkChannelAuthXblConfig>, IDeepCloneable<GssdkChannelAuthXblConfig>
{
	private static readonly MessageParser<GssdkChannelAuthXblConfig> _parser = new MessageParser<GssdkChannelAuthXblConfig>(() => new GssdkChannelAuthXblConfig());

	private UnknownFieldSet _unknownFields;

	private string prvPemFile_ = "";

	public static MessageParser<GssdkChannelAuthXblConfig> Parser => _parser;

	public string PrvPemFile
	{
		get
		{
			return prvPemFile_;
		}
		set
		{
			prvPemFile_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkChannelAuthXblConfig()
	{
	}

	public GssdkChannelAuthXblConfig(GssdkChannelAuthXblConfig other)
		: this()
	{
		prvPemFile_ = other.prvPemFile_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkChannelAuthXblConfig Clone()
	{
		return new GssdkChannelAuthXblConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkChannelAuthXblConfig);
	}

	public bool Equals(GssdkChannelAuthXblConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PrvPemFile != other.PrvPemFile)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PrvPemFile.Length != 0)
		{
			num ^= PrvPemFile.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PrvPemFile.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PrvPemFile);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PrvPemFile.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PrvPemFile);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkChannelAuthXblConfig other)
	{
		if (other != null)
		{
			if (other.PrvPemFile.Length != 0)
			{
				PrvPemFile = other.PrvPemFile;
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
				PrvPemFile = input.ReadString();
			}
		}
	}
}
