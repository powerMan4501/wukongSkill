using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStDropItemDesc : IMessage<FUStDropItemDesc>, IMessage, IEquatable<FUStDropItemDesc>, IDeepCloneable<FUStDropItemDesc>
{
	private static readonly MessageParser<FUStDropItemDesc> _parser = new MessageParser<FUStDropItemDesc>(() => new FUStDropItemDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string displayName_ = "";

	private string resPath_ = "";

	private EItemQualityColor qualityColor_;

	public static MessageParser<FUStDropItemDesc> Parser => _parser;

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

	public string DisplayName
	{
		get
		{
			return displayName_;
		}
		set
		{
			displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ResPath
	{
		get
		{
			return resPath_;
		}
		set
		{
			resPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EItemQualityColor QualityColor
	{
		get
		{
			return qualityColor_;
		}
		set
		{
			qualityColor_ = value;
		}
	}

	public FUStDropItemDesc()
	{
	}

	public FUStDropItemDesc(FUStDropItemDesc other)
		: this()
	{
		iD_ = other.iD_;
		displayName_ = other.displayName_;
		resPath_ = other.resPath_;
		qualityColor_ = other.qualityColor_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDropItemDesc Clone()
	{
		return new FUStDropItemDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDropItemDesc);
	}

	public bool Equals(FUStDropItemDesc other)
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
		if (DisplayName != other.DisplayName)
		{
			return false;
		}
		if (ResPath != other.ResPath)
		{
			return false;
		}
		if (QualityColor != other.QualityColor)
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
		if (DisplayName.Length != 0)
		{
			num ^= DisplayName.GetHashCode();
		}
		if (ResPath.Length != 0)
		{
			num ^= ResPath.GetHashCode();
		}
		if (QualityColor != EItemQualityColor.White)
		{
			num ^= QualityColor.GetHashCode();
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
		if (DisplayName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DisplayName);
		}
		if (ResPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ResPath);
		}
		if (QualityColor != EItemQualityColor.White)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)QualityColor);
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
		if (DisplayName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
		}
		if (ResPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResPath);
		}
		if (QualityColor != EItemQualityColor.White)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)QualityColor);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDropItemDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.DisplayName.Length != 0)
			{
				DisplayName = other.DisplayName;
			}
			if (other.ResPath.Length != 0)
			{
				ResPath = other.ResPath;
			}
			if (other.QualityColor != EItemQualityColor.White)
			{
				QualityColor = other.QualityColor;
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
				DisplayName = input.ReadString();
				break;
			case 26u:
				ResPath = input.ReadString();
				break;
			case 32u:
				QualityColor = (EItemQualityColor)input.ReadEnum();
				break;
			}
		}
	}
}
