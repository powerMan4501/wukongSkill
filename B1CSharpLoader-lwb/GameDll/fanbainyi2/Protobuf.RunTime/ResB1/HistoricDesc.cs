using System;
using Google.Protobuf;

namespace ResB1;

public sealed class HistoricDesc : IMessage<HistoricDesc>, IMessage, IEquatable<HistoricDesc>, IDeepCloneable<HistoricDesc>
{
	private static readonly MessageParser<HistoricDesc> _parser = new MessageParser<HistoricDesc>(() => new HistoricDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int sortId_;

	private HistoricType type_;

	private ItemPackageType packageType_;

	private string desc_ = "";

	private int localizationTag_;

	public static MessageParser<HistoricDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public HistoricType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public ItemPackageType PackageType
	{
		get
		{
			return packageType_;
		}
		set
		{
			packageType_ = value;
		}
	}

	public string Desc
	{
		get
		{
			return desc_;
		}
		set
		{
			desc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public HistoricDesc()
	{
	}

	public HistoricDesc(HistoricDesc other)
		: this()
	{
		id_ = other.id_;
		sortId_ = other.sortId_;
		type_ = other.type_;
		packageType_ = other.packageType_;
		desc_ = other.desc_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public HistoricDesc Clone()
	{
		return new HistoricDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as HistoricDesc);
	}

	public bool Equals(HistoricDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (PackageType != other.PackageType)
		{
			return false;
		}
		if (Desc != other.Desc)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (Type != HistoricType.None)
		{
			num ^= Type.GetHashCode();
		}
		if (PackageType != ItemPackageType.None)
		{
			num ^= PackageType.GetHashCode();
		}
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SortId);
		}
		if (Type != HistoricType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Type);
		}
		if (PackageType != ItemPackageType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)PackageType);
		}
		if (Desc.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Desc);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (Type != HistoricType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (PackageType != ItemPackageType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PackageType);
		}
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(HistoricDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.Type != HistoricType.None)
			{
				Type = other.Type;
			}
			if (other.PackageType != ItemPackageType.None)
			{
				PackageType = other.PackageType;
			}
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				SortId = input.ReadInt32();
				break;
			case 24u:
				Type = (HistoricType)input.ReadEnum();
				break;
			case 32u:
				PackageType = (ItemPackageType)input.ReadEnum();
				break;
			case 42u:
				Desc = input.ReadString();
				break;
			case 48u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
