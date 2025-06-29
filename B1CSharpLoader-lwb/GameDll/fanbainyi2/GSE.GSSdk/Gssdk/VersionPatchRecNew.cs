using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionPatchRecNew : IMessage<VersionPatchRecNew>, IMessage, IEquatable<VersionPatchRecNew>, IDeepCloneable<VersionPatchRecNew>
{
	private static readonly MessageParser<VersionPatchRecNew> _parser = new MessageParser<VersionPatchRecNew>(() => new VersionPatchRecNew());

	private UnknownFieldSet _unknownFields;

	private string verBase_ = "";

	private string verCurrent_ = "";

	private string tag_ = "";

	private string env_ = "";

	private string patchFile_ = "";

	private string md5_ = "";

	private long size_;

	private int status_;

	private string ctime_ = "";

	private string uptime_ = "";

	public static MessageParser<VersionPatchRecNew> Parser => _parser;

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

	public string PatchFile
	{
		get
		{
			return patchFile_;
		}
		set
		{
			patchFile_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public long Size
	{
		get
		{
			return size_;
		}
		set
		{
			size_ = value;
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

	public VersionPatchRecNew()
	{
	}

	public VersionPatchRecNew(VersionPatchRecNew other)
		: this()
	{
		verBase_ = other.verBase_;
		verCurrent_ = other.verCurrent_;
		tag_ = other.tag_;
		env_ = other.env_;
		patchFile_ = other.patchFile_;
		md5_ = other.md5_;
		size_ = other.size_;
		status_ = other.status_;
		ctime_ = other.ctime_;
		uptime_ = other.uptime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionPatchRecNew Clone()
	{
		return new VersionPatchRecNew(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionPatchRecNew);
	}

	public bool Equals(VersionPatchRecNew other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VerBase != other.VerBase)
		{
			return false;
		}
		if (VerCurrent != other.VerCurrent)
		{
			return false;
		}
		if (Tag != other.Tag)
		{
			return false;
		}
		if (Env != other.Env)
		{
			return false;
		}
		if (PatchFile != other.PatchFile)
		{
			return false;
		}
		if (Md5 != other.Md5)
		{
			return false;
		}
		if (Size != other.Size)
		{
			return false;
		}
		if (Status != other.Status)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (VerBase.Length != 0)
		{
			num ^= VerBase.GetHashCode();
		}
		if (VerCurrent.Length != 0)
		{
			num ^= VerCurrent.GetHashCode();
		}
		if (Tag.Length != 0)
		{
			num ^= Tag.GetHashCode();
		}
		if (Env.Length != 0)
		{
			num ^= Env.GetHashCode();
		}
		if (PatchFile.Length != 0)
		{
			num ^= PatchFile.GetHashCode();
		}
		if (Md5.Length != 0)
		{
			num ^= Md5.GetHashCode();
		}
		if (Size != 0L)
		{
			num ^= Size.GetHashCode();
		}
		if (Status != 0)
		{
			num ^= Status.GetHashCode();
		}
		if (Ctime.Length != 0)
		{
			num ^= Ctime.GetHashCode();
		}
		if (Uptime.Length != 0)
		{
			num ^= Uptime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (VerBase.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(VerBase);
		}
		if (VerCurrent.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(VerCurrent);
		}
		if (Tag.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Tag);
		}
		if (Env.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Env);
		}
		if (PatchFile.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(PatchFile);
		}
		if (Md5.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Md5);
		}
		if (Size != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(Size);
		}
		if (Status != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Status);
		}
		if (Ctime.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(Ctime);
		}
		if (Uptime.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(Uptime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (VerBase.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerBase);
		}
		if (VerCurrent.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerCurrent);
		}
		if (Tag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Tag);
		}
		if (Env.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Env);
		}
		if (PatchFile.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PatchFile);
		}
		if (Md5.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Md5);
		}
		if (Size != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Size);
		}
		if (Status != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Status);
		}
		if (Ctime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ctime);
		}
		if (Uptime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Uptime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionPatchRecNew other)
	{
		if (other != null)
		{
			if (other.VerBase.Length != 0)
			{
				VerBase = other.VerBase;
			}
			if (other.VerCurrent.Length != 0)
			{
				VerCurrent = other.VerCurrent;
			}
			if (other.Tag.Length != 0)
			{
				Tag = other.Tag;
			}
			if (other.Env.Length != 0)
			{
				Env = other.Env;
			}
			if (other.PatchFile.Length != 0)
			{
				PatchFile = other.PatchFile;
			}
			if (other.Md5.Length != 0)
			{
				Md5 = other.Md5;
			}
			if (other.Size != 0L)
			{
				Size = other.Size;
			}
			if (other.Status != 0)
			{
				Status = other.Status;
			}
			if (other.Ctime.Length != 0)
			{
				Ctime = other.Ctime;
			}
			if (other.Uptime.Length != 0)
			{
				Uptime = other.Uptime;
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
				VerBase = input.ReadString();
				break;
			case 18u:
				VerCurrent = input.ReadString();
				break;
			case 26u:
				Tag = input.ReadString();
				break;
			case 34u:
				Env = input.ReadString();
				break;
			case 42u:
				PatchFile = input.ReadString();
				break;
			case 50u:
				Md5 = input.ReadString();
				break;
			case 56u:
				Size = input.ReadInt64();
				break;
			case 64u:
				Status = input.ReadInt32();
				break;
			case 74u:
				Ctime = input.ReadString();
				break;
			case 82u:
				Uptime = input.ReadString();
				break;
			}
		}
	}
}
