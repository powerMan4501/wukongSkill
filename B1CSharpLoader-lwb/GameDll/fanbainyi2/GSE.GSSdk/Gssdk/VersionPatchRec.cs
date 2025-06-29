using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionPatchRec : IMessage<VersionPatchRec>, IMessage, IEquatable<VersionPatchRec>, IDeepCloneable<VersionPatchRec>
{
	private static readonly MessageParser<VersionPatchRec> _parser = new MessageParser<VersionPatchRec>(() => new VersionPatchRec());

	private UnknownFieldSet _unknownFields;

	private string verCurrent_ = "";

	private string ctime_ = "";

	private string uptime_ = "";

	private string tag_ = "";

	private string md5_ = "";

	private string verBase_ = "";

	private string env_ = "";

	private string plist_ = "";

	private int status_;

	public static MessageParser<VersionPatchRec> Parser => _parser;

	public string VerCurrent
	{
		get
		{
			return verCurrent_;
		}
		set
		{
			verCurrent_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public string Uptime
	{
		get
		{
			return uptime_;
		}
		set
		{
			uptime_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Tag
	{
		get
		{
			return tag_;
		}
		set
		{
			tag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Md5
	{
		get
		{
			return md5_;
		}
		set
		{
			md5_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string VerBase
	{
		get
		{
			return verBase_;
		}
		set
		{
			verBase_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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

	public string Plist
	{
		get
		{
			return plist_;
		}
		set
		{
			plist_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	public VersionPatchRec()
	{
	}

	public VersionPatchRec(VersionPatchRec other)
		: this()
	{
		verCurrent_ = other.verCurrent_;
		ctime_ = other.ctime_;
		uptime_ = other.uptime_;
		tag_ = other.tag_;
		md5_ = other.md5_;
		verBase_ = other.verBase_;
		env_ = other.env_;
		plist_ = other.plist_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionPatchRec Clone()
	{
		return new VersionPatchRec(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionPatchRec);
	}

	public bool Equals(VersionPatchRec other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VerCurrent != other.VerCurrent)
		{
			return false;
		}
		if (Ctime != other.Ctime)
		{
			return false;
		}
		if (Uptime != other.Uptime)
		{
			return false;
		}
		if (Tag != other.Tag)
		{
			return false;
		}
		if (Md5 != other.Md5)
		{
			return false;
		}
		if (VerBase != other.VerBase)
		{
			return false;
		}
		if (Env != other.Env)
		{
			return false;
		}
		if (Plist != other.Plist)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (VerCurrent.Length != 0)
		{
			num ^= VerCurrent.GetHashCode();
		}
		if (Ctime.Length != 0)
		{
			num ^= Ctime.GetHashCode();
		}
		if (Uptime.Length != 0)
		{
			num ^= Uptime.GetHashCode();
		}
		if (Tag.Length != 0)
		{
			num ^= Tag.GetHashCode();
		}
		if (Md5.Length != 0)
		{
			num ^= Md5.GetHashCode();
		}
		if (VerBase.Length != 0)
		{
			num ^= VerBase.GetHashCode();
		}
		if (Env.Length != 0)
		{
			num ^= Env.GetHashCode();
		}
		if (Plist.Length != 0)
		{
			num ^= Plist.GetHashCode();
		}
		if (Status != 0)
		{
			num ^= Status.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (VerCurrent.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(VerCurrent);
		}
		if (Ctime.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Ctime);
		}
		if (Uptime.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Uptime);
		}
		if (Tag.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Tag);
		}
		if (Md5.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Md5);
		}
		if (VerBase.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(VerBase);
		}
		if (Env.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Env);
		}
		if (Plist.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(Plist);
		}
		if (Status != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Status);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (VerCurrent.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerCurrent);
		}
		if (Ctime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ctime);
		}
		if (Uptime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Uptime);
		}
		if (Tag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Tag);
		}
		if (Md5.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Md5);
		}
		if (VerBase.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerBase);
		}
		if (Env.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Env);
		}
		if (Plist.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Plist);
		}
		if (Status != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionPatchRec other)
	{
		if (other != null)
		{
			if (other.VerCurrent.Length != 0)
			{
				VerCurrent = other.VerCurrent;
			}
			if (other.Ctime.Length != 0)
			{
				Ctime = other.Ctime;
			}
			if (other.Uptime.Length != 0)
			{
				Uptime = other.Uptime;
			}
			if (other.Tag.Length != 0)
			{
				Tag = other.Tag;
			}
			if (other.Md5.Length != 0)
			{
				Md5 = other.Md5;
			}
			if (other.VerBase.Length != 0)
			{
				VerBase = other.VerBase;
			}
			if (other.Env.Length != 0)
			{
				Env = other.Env;
			}
			if (other.Plist.Length != 0)
			{
				Plist = other.Plist;
			}
			if (other.Status != 0)
			{
				Status = other.Status;
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
				VerCurrent = input.ReadString();
				break;
			case 18u:
				Ctime = input.ReadString();
				break;
			case 26u:
				Uptime = input.ReadString();
				break;
			case 34u:
				Tag = input.ReadString();
				break;
			case 42u:
				Md5 = input.ReadString();
				break;
			case 50u:
				VerBase = input.ReadString();
				break;
			case 58u:
				Env = input.ReadString();
				break;
			case 66u:
				Plist = input.ReadString();
				break;
			case 72u:
				Status = input.ReadInt32();
				break;
			}
		}
	}
}
