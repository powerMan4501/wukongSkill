using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStStreamingLevelStateDesc : IMessage<FUStStreamingLevelStateDesc>, IMessage, IEquatable<FUStStreamingLevelStateDesc>, IDeepCloneable<FUStStreamingLevelStateDesc>
{
	private static readonly MessageParser<FUStStreamingLevelStateDesc> _parser = new MessageParser<FUStStreamingLevelStateDesc>(() => new FUStStreamingLevelStateDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string dataAssetPath_ = "";

	public static MessageParser<FUStStreamingLevelStateDesc> Parser => _parser;

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

	public string DataAssetPath
	{
		get
		{
			return dataAssetPath_;
		}
		set
		{
			dataAssetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStStreamingLevelStateDesc()
	{
	}

	public FUStStreamingLevelStateDesc(FUStStreamingLevelStateDesc other)
		: this()
	{
		iD_ = other.iD_;
		dataAssetPath_ = other.dataAssetPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStStreamingLevelStateDesc Clone()
	{
		return new FUStStreamingLevelStateDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStStreamingLevelStateDesc);
	}

	public bool Equals(FUStStreamingLevelStateDesc other)
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
		if (DataAssetPath != other.DataAssetPath)
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
		if (DataAssetPath.Length != 0)
		{
			num ^= DataAssetPath.GetHashCode();
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
		if (DataAssetPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DataAssetPath);
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
		if (DataAssetPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DataAssetPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStStreamingLevelStateDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.DataAssetPath.Length != 0)
			{
				DataAssetPath = other.DataAssetPath;
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
				DataAssetPath = input.ReadString();
				break;
			}
		}
	}
}
