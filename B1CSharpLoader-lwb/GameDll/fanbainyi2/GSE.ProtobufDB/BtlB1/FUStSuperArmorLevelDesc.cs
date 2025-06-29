using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSuperArmorLevelDesc : IMessage<FUStSuperArmorLevelDesc>, IMessage, IEquatable<FUStSuperArmorLevelDesc>, IDeepCloneable<FUStSuperArmorLevelDesc>
{
	private static readonly MessageParser<FUStSuperArmorLevelDesc> _parser = new MessageParser<FUStSuperArmorLevelDesc>(() => new FUStSuperArmorLevelDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string superArmorLevelName_ = "";

	private float superArmorValue_;

	public static MessageParser<FUStSuperArmorLevelDesc> Parser => _parser;

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

	public string SuperArmorLevelName
	{
		get
		{
			return superArmorLevelName_;
		}
		set
		{
			superArmorLevelName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float SuperArmorValue
	{
		get
		{
			return superArmorValue_;
		}
		set
		{
			superArmorValue_ = value;
		}
	}

	public FUStSuperArmorLevelDesc()
	{
	}

	public FUStSuperArmorLevelDesc(FUStSuperArmorLevelDesc other)
		: this()
	{
		iD_ = other.iD_;
		superArmorLevelName_ = other.superArmorLevelName_;
		superArmorValue_ = other.superArmorValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSuperArmorLevelDesc Clone()
	{
		return new FUStSuperArmorLevelDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSuperArmorLevelDesc);
	}

	public bool Equals(FUStSuperArmorLevelDesc other)
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
		if (SuperArmorLevelName != other.SuperArmorLevelName)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SuperArmorValue, other.SuperArmorValue))
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
		if (SuperArmorLevelName.Length != 0)
		{
			num ^= SuperArmorLevelName.GetHashCode();
		}
		if (SuperArmorValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SuperArmorValue);
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
		if (SuperArmorLevelName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SuperArmorLevelName);
		}
		if (SuperArmorValue != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(SuperArmorValue);
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
		if (SuperArmorLevelName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SuperArmorLevelName);
		}
		if (SuperArmorValue != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSuperArmorLevelDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SuperArmorLevelName.Length != 0)
			{
				SuperArmorLevelName = other.SuperArmorLevelName;
			}
			if (other.SuperArmorValue != 0f)
			{
				SuperArmorValue = other.SuperArmorValue;
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
				SuperArmorLevelName = input.ReadString();
				break;
			case 29u:
				SuperArmorValue = input.ReadFloat();
				break;
			}
		}
	}
}
