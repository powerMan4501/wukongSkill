using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStSummonCopySkillDesc : IMessage<FUStSummonCopySkillDesc>, IMessage, IEquatable<FUStSummonCopySkillDesc>, IDeepCloneable<FUStSummonCopySkillDesc>
{
	private static readonly MessageParser<FUStSummonCopySkillDesc> _parser = new MessageParser<FUStSummonCopySkillDesc>(() => new FUStSummonCopySkillDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string summonUnitMontagePath_ = "";

	public static MessageParser<FUStSummonCopySkillDesc> Parser => _parser;

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

	public string SummonUnitMontagePath
	{
		get
		{
			return summonUnitMontagePath_;
		}
		set
		{
			summonUnitMontagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStSummonCopySkillDesc()
	{
	}

	public FUStSummonCopySkillDesc(FUStSummonCopySkillDesc other)
		: this()
	{
		iD_ = other.iD_;
		summonUnitMontagePath_ = other.summonUnitMontagePath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSummonCopySkillDesc Clone()
	{
		return new FUStSummonCopySkillDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSummonCopySkillDesc);
	}

	public bool Equals(FUStSummonCopySkillDesc other)
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
		if (SummonUnitMontagePath != other.SummonUnitMontagePath)
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
		if (SummonUnitMontagePath.Length != 0)
		{
			num ^= SummonUnitMontagePath.GetHashCode();
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
		if (SummonUnitMontagePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SummonUnitMontagePath);
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
		if (SummonUnitMontagePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SummonUnitMontagePath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSummonCopySkillDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SummonUnitMontagePath.Length != 0)
			{
				SummonUnitMontagePath = other.SummonUnitMontagePath;
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
				SummonUnitMontagePath = input.ReadString();
				break;
			}
		}
	}
}
