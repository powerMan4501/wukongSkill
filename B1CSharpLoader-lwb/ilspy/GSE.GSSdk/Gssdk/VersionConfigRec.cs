using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionConfigRec : IMessage<VersionConfigRec>, IMessage, IEquatable<VersionConfigRec>, IDeepCloneable<VersionConfigRec>
{
	private static readonly MessageParser<VersionConfigRec> _parser = new MessageParser<VersionConfigRec>(() => new VersionConfigRec());

	private UnknownFieldSet _unknownFields;

	private long id_;

	private string config_ = "";

	private string ctime_ = "";

	public static MessageParser<VersionConfigRec> Parser => _parser;

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

	public string Config
	{
		get
		{
			return config_;
		}
		set
		{
			config_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Ctime
	{
		get
		{
			return ctime_;
		}
		set
		{
			ctime_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public VersionConfigRec()
	{
	}

	public VersionConfigRec(VersionConfigRec other)
		: this()
	{
		id_ = other.id_;
		config_ = other.config_;
		ctime_ = other.ctime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionConfigRec Clone()
	{
		return new VersionConfigRec(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionConfigRec);
	}

	public bool Equals(VersionConfigRec other)
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
		if (Config != other.Config)
		{
			return false;
		}
		if (Ctime != other.Ctime)
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
		if (Config.Length != 0)
		{
			num ^= Config.GetHashCode();
		}
		if (Ctime.Length != 0)
		{
			num ^= Ctime.GetHashCode();
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
		if (Config.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Config);
		}
		if (Ctime.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Ctime);
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
		if (Config.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Config);
		}
		if (Ctime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ctime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionConfigRec other)
	{
		if (other != null)
		{
			if (other.Id != 0L)
			{
				Id = other.Id;
			}
			if (other.Config.Length != 0)
			{
				Config = other.Config;
			}
			if (other.Ctime.Length != 0)
			{
				Ctime = other.Ctime;
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
				Config = input.ReadString();
				break;
			case 26u:
				Ctime = input.ReadString();
				break;
			}
		}
	}
}
