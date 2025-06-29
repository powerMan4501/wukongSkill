using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStCBGTemplateDesc : IMessage<FUStCBGTemplateDesc>, IMessage, IEquatable<FUStCBGTemplateDesc>, IDeepCloneable<FUStCBGTemplateDesc>
{
	private static readonly MessageParser<FUStCBGTemplateDesc> _parser = new MessageParser<FUStCBGTemplateDesc>(() => new FUStCBGTemplateDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string path_ = "";

	public static MessageParser<FUStCBGTemplateDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

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

	public FUStCBGTemplateDesc()
	{
	}

	public FUStCBGTemplateDesc(FUStCBGTemplateDesc other)
		: this()
	{
		iD_ = other.iD_;
		path_ = other.path_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStCBGTemplateDesc Clone()
	{
		return new FUStCBGTemplateDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStCBGTemplateDesc);
	}

	public bool Equals(FUStCBGTemplateDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (Path != other.Path)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (Path.Length != 0)
		{
			num ^= Path.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (Path.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Path);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (Path.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Path);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStCBGTemplateDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Path.Length != 0)
			{
				Path = other.Path;
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
				ID = input.ReadInt32();
				break;
			case 18u:
				Path = input.ReadString();
				break;
			}
		}
	}
}
