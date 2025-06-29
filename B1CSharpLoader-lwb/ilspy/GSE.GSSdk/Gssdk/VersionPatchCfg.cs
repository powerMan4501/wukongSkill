using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionPatchCfg : IMessage<VersionPatchCfg>, IMessage, IEquatable<VersionPatchCfg>, IDeepCloneable<VersionPatchCfg>
{
	private static readonly MessageParser<VersionPatchCfg> _parser = new MessageParser<VersionPatchCfg>(() => new VersionPatchCfg());

	private UnknownFieldSet _unknownFields;

	private string tag_ = "";

	private string verCurrent_ = "";

	private string md5_ = "";

	private string verBase_ = "";

	public static MessageParser<VersionPatchCfg> Parser => _parser;

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

	public VersionPatchCfg()
	{
	}

	public VersionPatchCfg(VersionPatchCfg other)
		: this()
	{
		tag_ = other.tag_;
		verCurrent_ = other.verCurrent_;
		md5_ = other.md5_;
		verBase_ = other.verBase_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionPatchCfg Clone()
	{
		return new VersionPatchCfg(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionPatchCfg);
	}

	public bool Equals(VersionPatchCfg other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Tag != other.Tag)
		{
			return false;
		}
		if (VerCurrent != other.VerCurrent)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Tag.Length != 0)
		{
			num ^= Tag.GetHashCode();
		}
		if (VerCurrent.Length != 0)
		{
			num ^= VerCurrent.GetHashCode();
		}
		if (Md5.Length != 0)
		{
			num ^= Md5.GetHashCode();
		}
		if (VerBase.Length != 0)
		{
			num ^= VerBase.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Tag.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Tag);
		}
		if (VerCurrent.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(VerCurrent);
		}
		if (Md5.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Md5);
		}
		if (VerBase.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(VerBase);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Tag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Tag);
		}
		if (VerCurrent.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerCurrent);
		}
		if (Md5.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Md5);
		}
		if (VerBase.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(VerBase);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionPatchCfg other)
	{
		if (other != null)
		{
			if (other.Tag.Length != 0)
			{
				Tag = other.Tag;
			}
			if (other.VerCurrent.Length != 0)
			{
				VerCurrent = other.VerCurrent;
			}
			if (other.Md5.Length != 0)
			{
				Md5 = other.Md5;
			}
			if (other.VerBase.Length != 0)
			{
				VerBase = other.VerBase;
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
				Tag = input.ReadString();
				break;
			case 18u:
				VerCurrent = input.ReadString();
				break;
			case 26u:
				Md5 = input.ReadString();
				break;
			case 34u:
				VerBase = input.ReadString();
				break;
			}
		}
	}
}
