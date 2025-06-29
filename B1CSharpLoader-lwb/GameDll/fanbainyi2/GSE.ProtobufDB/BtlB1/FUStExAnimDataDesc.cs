using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStExAnimDataDesc : IMessage<FUStExAnimDataDesc>, IMessage, IEquatable<FUStExAnimDataDesc>, IDeepCloneable<FUStExAnimDataDesc>
{
	private static readonly MessageParser<FUStExAnimDataDesc> _parser = new MessageParser<FUStExAnimDataDesc>(() => new FUStExAnimDataDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string exAnimDataPath_ = "";

	public static MessageParser<FUStExAnimDataDesc> Parser => _parser;

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

	public string ExAnimDataPath
	{
		get
		{
			return exAnimDataPath_;
		}
		set
		{
			exAnimDataPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStExAnimDataDesc()
	{
	}

	public FUStExAnimDataDesc(FUStExAnimDataDesc other)
		: this()
	{
		iD_ = other.iD_;
		exAnimDataPath_ = other.exAnimDataPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStExAnimDataDesc Clone()
	{
		return new FUStExAnimDataDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStExAnimDataDesc);
	}

	public bool Equals(FUStExAnimDataDesc other)
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
		if (ExAnimDataPath != other.ExAnimDataPath)
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
		if (ExAnimDataPath.Length != 0)
		{
			num ^= ExAnimDataPath.GetHashCode();
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
		if (ExAnimDataPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ExAnimDataPath);
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
		if (ExAnimDataPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ExAnimDataPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStExAnimDataDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ExAnimDataPath.Length != 0)
			{
				ExAnimDataPath = other.ExAnimDataPath;
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
				ExAnimDataPath = input.ReadString();
				break;
			}
		}
	}
}
