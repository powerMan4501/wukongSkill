using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSettingDetailDesc : IMessage<FUStSettingDetailDesc>, IMessage, IEquatable<FUStSettingDetailDesc>, IDeepCloneable<FUStSettingDetailDesc>
{
	private static readonly MessageParser<FUStSettingDetailDesc> _parser = new MessageParser<FUStSettingDetailDesc>(() => new FUStSettingDetailDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int sortOrder_;

	private int classID_;

	private ESettingOPType oPType_;

	private string gName_ = "";

	private static readonly FieldCodec<string> _repeated_valueDesc_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> valueDesc_ = new RepeatedField<string>();

	public static MessageParser<FUStSettingDetailDesc> Parser => _parser;

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

	public int SortOrder
	{
		get
		{
			return sortOrder_;
		}
		set
		{
			sortOrder_ = value;
		}
	}

	public int ClassID
	{
		get
		{
			return classID_;
		}
		set
		{
			classID_ = value;
		}
	}

	public ESettingOPType OPType
	{
		get
		{
			return oPType_;
		}
		set
		{
			oPType_ = value;
		}
	}

	public string GName
	{
		get
		{
			return gName_;
		}
		set
		{
			gName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> ValueDesc => valueDesc_;

	public FUStSettingDetailDesc()
	{
	}

	public FUStSettingDetailDesc(FUStSettingDetailDesc other)
		: this()
	{
		iD_ = other.iD_;
		sortOrder_ = other.sortOrder_;
		classID_ = other.classID_;
		oPType_ = other.oPType_;
		gName_ = other.gName_;
		valueDesc_ = other.valueDesc_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSettingDetailDesc Clone()
	{
		return new FUStSettingDetailDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSettingDetailDesc);
	}

	public bool Equals(FUStSettingDetailDesc other)
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
		if (SortOrder != other.SortOrder)
		{
			return false;
		}
		if (ClassID != other.ClassID)
		{
			return false;
		}
		if (OPType != other.OPType)
		{
			return false;
		}
		if (GName != other.GName)
		{
			return false;
		}
		if (!valueDesc_.Equals(other.valueDesc_))
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
		if (SortOrder != 0)
		{
			num ^= SortOrder.GetHashCode();
		}
		if (ClassID != 0)
		{
			num ^= ClassID.GetHashCode();
		}
		if (OPType != ESettingOPType.Default)
		{
			num ^= OPType.GetHashCode();
		}
		if (GName.Length != 0)
		{
			num ^= GName.GetHashCode();
		}
		num ^= valueDesc_.GetHashCode();
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
		if (SortOrder != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SortOrder);
		}
		if (ClassID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ClassID);
		}
		if (OPType != ESettingOPType.Default)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)OPType);
		}
		if (GName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(GName);
		}
		valueDesc_.WriteTo(output, _repeated_valueDesc_codec);
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
		if (SortOrder != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortOrder);
		}
		if (ClassID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClassID);
		}
		if (OPType != ESettingOPType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OPType);
		}
		if (GName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GName);
		}
		num += valueDesc_.CalculateSize(_repeated_valueDesc_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSettingDetailDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SortOrder != 0)
			{
				SortOrder = other.SortOrder;
			}
			if (other.ClassID != 0)
			{
				ClassID = other.ClassID;
			}
			if (other.OPType != ESettingOPType.Default)
			{
				OPType = other.OPType;
			}
			if (other.GName.Length != 0)
			{
				GName = other.GName;
			}
			valueDesc_.Add(other.valueDesc_);
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
			case 16u:
				SortOrder = input.ReadInt32();
				break;
			case 24u:
				ClassID = input.ReadInt32();
				break;
			case 32u:
				OPType = (ESettingOPType)input.ReadEnum();
				break;
			case 42u:
				GName = input.ReadString();
				break;
			case 50u:
				valueDesc_.AddEntriesFrom(input, _repeated_valueDesc_codec);
				break;
			}
		}
	}
}
