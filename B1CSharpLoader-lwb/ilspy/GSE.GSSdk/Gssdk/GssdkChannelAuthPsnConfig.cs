using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkChannelAuthPsnConfig : IMessage<GssdkChannelAuthPsnConfig>, IMessage, IEquatable<GssdkChannelAuthPsnConfig>, IDeepCloneable<GssdkChannelAuthPsnConfig>
{
	private static readonly MessageParser<GssdkChannelAuthPsnConfig> _parser = new MessageParser<GssdkChannelAuthPsnConfig>(() => new GssdkChannelAuthPsnConfig());

	private UnknownFieldSet _unknownFields;

	private string pubKey_ = "";

	public static MessageParser<GssdkChannelAuthPsnConfig> Parser => _parser;

	public string PubKey
	{
		get
		{
			return pubKey_;
		}
		set
		{
			pubKey_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkChannelAuthPsnConfig()
	{
	}

	public GssdkChannelAuthPsnConfig(GssdkChannelAuthPsnConfig other)
		: this()
	{
		pubKey_ = other.pubKey_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkChannelAuthPsnConfig Clone()
	{
		return new GssdkChannelAuthPsnConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkChannelAuthPsnConfig);
	}

	public bool Equals(GssdkChannelAuthPsnConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PubKey != other.PubKey)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PubKey.Length != 0)
		{
			num ^= PubKey.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PubKey.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PubKey);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PubKey.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PubKey);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkChannelAuthPsnConfig other)
	{
		if (other != null)
		{
			if (other.PubKey.Length != 0)
			{
				PubKey = other.PubKey;
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
				PubKey = input.ReadString();
			}
		}
	}
}
