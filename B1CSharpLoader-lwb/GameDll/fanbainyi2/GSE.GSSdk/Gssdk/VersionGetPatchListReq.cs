using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionGetPatchListReq : IMessage<VersionGetPatchListReq>, IMessage, IEquatable<VersionGetPatchListReq>, IDeepCloneable<VersionGetPatchListReq>
{
	private static readonly MessageParser<VersionGetPatchListReq> _parser = new MessageParser<VersionGetPatchListReq>(() => new VersionGetPatchListReq());

	private UnknownFieldSet _unknownFields;

	private string env_ = "";

	private string platform_ = "";

	public static MessageParser<VersionGetPatchListReq> Parser => _parser;

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

	public string Platform
	{
		get
		{
			return platform_;
		}
		set
		{
			platform_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public VersionGetPatchListReq()
	{
	}

	public VersionGetPatchListReq(VersionGetPatchListReq other)
		: this()
	{
		env_ = other.env_;
		platform_ = other.platform_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionGetPatchListReq Clone()
	{
		return new VersionGetPatchListReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionGetPatchListReq);
	}

	public bool Equals(VersionGetPatchListReq other)
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
		if (Platform != other.Platform)
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
		if (Platform.Length != 0)
		{
			num ^= Platform.GetHashCode();
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
		if (Platform.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Platform);
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
		if (Platform.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Platform);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionGetPatchListReq other)
	{
		if (other != null)
		{
			if (other.Env.Length != 0)
			{
				Env = other.Env;
			}
			if (other.Platform.Length != 0)
			{
				Platform = other.Platform;
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
				Platform = input.ReadString();
				break;
			}
		}
	}
}
