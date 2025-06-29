using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitChangeMaterialByAttrDesc : IMessage<FUStUnitChangeMaterialByAttrDesc>, IMessage, IEquatable<FUStUnitChangeMaterialByAttrDesc>, IDeepCloneable<FUStUnitChangeMaterialByAttrDesc>
{
	private static readonly MessageParser<FUStUnitChangeMaterialByAttrDesc> _parser = new MessageParser<FUStUnitChangeMaterialByAttrDesc>(() => new FUStUnitChangeMaterialByAttrDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string configDAPath_ = "";

	public static MessageParser<FUStUnitChangeMaterialByAttrDesc> Parser => _parser;

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

	public string ConfigDAPath
	{
		get
		{
			return configDAPath_;
		}
		set
		{
			configDAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStUnitChangeMaterialByAttrDesc()
	{
	}

	public FUStUnitChangeMaterialByAttrDesc(FUStUnitChangeMaterialByAttrDesc other)
		: this()
	{
		iD_ = other.iD_;
		configDAPath_ = other.configDAPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitChangeMaterialByAttrDesc Clone()
	{
		return new FUStUnitChangeMaterialByAttrDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitChangeMaterialByAttrDesc);
	}

	public bool Equals(FUStUnitChangeMaterialByAttrDesc other)
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
		if (ConfigDAPath != other.ConfigDAPath)
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
		if (ConfigDAPath.Length != 0)
		{
			num ^= ConfigDAPath.GetHashCode();
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
		if (ConfigDAPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ConfigDAPath);
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
		if (ConfigDAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConfigDAPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitChangeMaterialByAttrDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ConfigDAPath.Length != 0)
			{
				ConfigDAPath = other.ConfigDAPath;
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
				ConfigDAPath = input.ReadString();
				break;
			}
		}
	}
}
