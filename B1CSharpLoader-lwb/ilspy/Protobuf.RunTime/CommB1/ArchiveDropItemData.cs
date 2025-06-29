using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ArchiveDropItemData : IMessage<ArchiveDropItemData>, IMessage, IEquatable<ArchiveDropItemData>, IDeepCloneable<ArchiveDropItemData>
{
	private static readonly MessageParser<ArchiveDropItemData> _parser = new MessageParser<ArchiveDropItemData>(() => new ArchiveDropItemData());

	private UnknownFieldSet _unknownFields;

	private string bpClass_ = "";

	private float bornPosX_;

	private float bornPosY_;

	private float bornPosZ_;

	private int resid_;

	public static MessageParser<ArchiveDropItemData> Parser => _parser;

	public string BpClass
	{
		get
		{
			return bpClass_;
		}
		set
		{
			bpClass_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float BornPosX
	{
		get
		{
			return bornPosX_;
		}
		set
		{
			bornPosX_ = value;
		}
	}

	public float BornPosY
	{
		get
		{
			return bornPosY_;
		}
		set
		{
			bornPosY_ = value;
		}
	}

	public float BornPosZ
	{
		get
		{
			return bornPosZ_;
		}
		set
		{
			bornPosZ_ = value;
		}
	}

	public int Resid
	{
		get
		{
			return resid_;
		}
		set
		{
			resid_ = value;
		}
	}

	public ArchiveDropItemData()
	{
	}

	public ArchiveDropItemData(ArchiveDropItemData other)
		: this()
	{
		bpClass_ = other.bpClass_;
		bornPosX_ = other.bornPosX_;
		bornPosY_ = other.bornPosY_;
		bornPosZ_ = other.bornPosZ_;
		resid_ = other.resid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArchiveDropItemData Clone()
	{
		return new ArchiveDropItemData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArchiveDropItemData);
	}

	public bool Equals(ArchiveDropItemData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BpClass != other.BpClass)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BornPosX, other.BornPosX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BornPosY, other.BornPosY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BornPosZ, other.BornPosZ))
		{
			return false;
		}
		if (Resid != other.Resid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BpClass.Length != 0)
		{
			num ^= BpClass.GetHashCode();
		}
		if (BornPosX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BornPosX);
		}
		if (BornPosY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BornPosY);
		}
		if (BornPosZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BornPosZ);
		}
		if (Resid != 0)
		{
			num ^= Resid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BpClass.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BpClass);
		}
		if (BornPosX != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(BornPosX);
		}
		if (BornPosY != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(BornPosY);
		}
		if (BornPosZ != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(BornPosZ);
		}
		if (Resid != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Resid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BpClass.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BpClass);
		}
		if (BornPosX != 0f)
		{
			num += 5;
		}
		if (BornPosY != 0f)
		{
			num += 5;
		}
		if (BornPosZ != 0f)
		{
			num += 5;
		}
		if (Resid != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Resid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArchiveDropItemData other)
	{
		if (other != null)
		{
			if (other.BpClass.Length != 0)
			{
				BpClass = other.BpClass;
			}
			if (other.BornPosX != 0f)
			{
				BornPosX = other.BornPosX;
			}
			if (other.BornPosY != 0f)
			{
				BornPosY = other.BornPosY;
			}
			if (other.BornPosZ != 0f)
			{
				BornPosZ = other.BornPosZ;
			}
			if (other.Resid != 0)
			{
				Resid = other.Resid;
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
				BpClass = input.ReadString();
				break;
			case 21u:
				BornPosX = input.ReadFloat();
				break;
			case 29u:
				BornPosY = input.ReadFloat();
				break;
			case 37u:
				BornPosZ = input.ReadFloat();
				break;
			case 40u:
				Resid = input.ReadInt32();
				break;
			}
		}
	}
}
