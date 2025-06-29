using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ShareArchiveInfo : IMessage<ShareArchiveInfo>, IMessage, IEquatable<ShareArchiveInfo>, IDeepCloneable<ShareArchiveInfo>
{
	private static readonly MessageParser<ShareArchiveInfo> _parser = new MessageParser<ShareArchiveInfo>(() => new ShareArchiveInfo());

	private UnknownFieldSet _unknownFields;

	private string shareArchiveUid_ = "";

	private string md5Str_ = "";

	private bool enableEncrypt_;

	public static MessageParser<ShareArchiveInfo> Parser => _parser;

	public string ShareArchiveUid
	{
		get
		{
			return shareArchiveUid_;
		}
		set
		{
			shareArchiveUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Md5Str
	{
		get
		{
			return md5Str_;
		}
		set
		{
			md5Str_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool EnableEncrypt
	{
		get
		{
			return enableEncrypt_;
		}
		set
		{
			enableEncrypt_ = value;
		}
	}

	public ShareArchiveInfo()
	{
	}

	public ShareArchiveInfo(ShareArchiveInfo other)
		: this()
	{
		shareArchiveUid_ = other.shareArchiveUid_;
		md5Str_ = other.md5Str_;
		enableEncrypt_ = other.enableEncrypt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShareArchiveInfo Clone()
	{
		return new ShareArchiveInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShareArchiveInfo);
	}

	public bool Equals(ShareArchiveInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ShareArchiveUid != other.ShareArchiveUid)
		{
			return false;
		}
		if (Md5Str != other.Md5Str)
		{
			return false;
		}
		if (EnableEncrypt != other.EnableEncrypt)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ShareArchiveUid.Length != 0)
		{
			num ^= ShareArchiveUid.GetHashCode();
		}
		if (Md5Str.Length != 0)
		{
			num ^= Md5Str.GetHashCode();
		}
		if (EnableEncrypt)
		{
			num ^= EnableEncrypt.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ShareArchiveUid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ShareArchiveUid);
		}
		if (Md5Str.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Md5Str);
		}
		if (EnableEncrypt)
		{
			output.WriteRawTag(24);
			output.WriteBool(EnableEncrypt);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ShareArchiveUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ShareArchiveUid);
		}
		if (Md5Str.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Md5Str);
		}
		if (EnableEncrypt)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShareArchiveInfo other)
	{
		if (other != null)
		{
			if (other.ShareArchiveUid.Length != 0)
			{
				ShareArchiveUid = other.ShareArchiveUid;
			}
			if (other.Md5Str.Length != 0)
			{
				Md5Str = other.Md5Str;
			}
			if (other.EnableEncrypt)
			{
				EnableEncrypt = other.EnableEncrypt;
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
				ShareArchiveUid = input.ReadString();
				break;
			case 18u:
				Md5Str = input.ReadString();
				break;
			case 24u:
				EnableEncrypt = input.ReadBool();
				break;
			}
		}
	}
}
