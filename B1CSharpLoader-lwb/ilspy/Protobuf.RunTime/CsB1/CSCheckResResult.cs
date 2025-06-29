using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSCheckResResult : IMessage<CSCheckResResult>, IMessage, IEquatable<CSCheckResResult>, IDeepCloneable<CSCheckResResult>
{
	private static readonly MessageParser<CSCheckResResult> _parser = new MessageParser<CSCheckResResult>(() => new CSCheckResResult());

	private UnknownFieldSet _unknownFields;

	private string path_ = "";

	private string md5Sum_ = "";

	public static MessageParser<CSCheckResResult> Parser => _parser;

	public string Path
	{
		get
		{
			return path_;
		}
		set
		{
			path_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Md5Sum
	{
		get
		{
			return md5Sum_;
		}
		set
		{
			md5Sum_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CSCheckResResult()
	{
	}

	public CSCheckResResult(CSCheckResResult other)
		: this()
	{
		path_ = other.path_;
		md5Sum_ = other.md5Sum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSCheckResResult Clone()
	{
		return new CSCheckResResult(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSCheckResResult);
	}

	public bool Equals(CSCheckResResult other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Path != other.Path)
		{
			return false;
		}
		if (Md5Sum != other.Md5Sum)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Path.Length != 0)
		{
			num ^= Path.GetHashCode();
		}
		if (Md5Sum.Length != 0)
		{
			num ^= Md5Sum.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Path.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Path);
		}
		if (Md5Sum.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Md5Sum);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Path.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Path);
		}
		if (Md5Sum.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Md5Sum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSCheckResResult other)
	{
		if (other != null)
		{
			if (other.Path.Length != 0)
			{
				Path = other.Path;
			}
			if (other.Md5Sum.Length != 0)
			{
				Md5Sum = other.Md5Sum;
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
				Path = input.ReadString();
				break;
			case 18u:
				Md5Sum = input.ReadString();
				break;
			}
		}
	}
}
