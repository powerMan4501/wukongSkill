using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class FUStB2DMultiKillEnegyDesc : IMessage<FUStB2DMultiKillEnegyDesc>, IMessage, IEquatable<FUStB2DMultiKillEnegyDesc>, IDeepCloneable<FUStB2DMultiKillEnegyDesc>
{
	private static readonly MessageParser<FUStB2DMultiKillEnegyDesc> _parser = new MessageParser<FUStB2DMultiKillEnegyDesc>(() => new FUStB2DMultiKillEnegyDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int multiKillCount_;

	private int multiKillInterval_;

	private float multiKillAddEnergy_;

	private float multiKillAddEnergyByManual_;

	public static MessageParser<FUStB2DMultiKillEnegyDesc> Parser => _parser;

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

	public int MultiKillCount
	{
		get
		{
			return multiKillCount_;
		}
		set
		{
			multiKillCount_ = value;
		}
	}

	public int MultiKillInterval
	{
		get
		{
			return multiKillInterval_;
		}
		set
		{
			multiKillInterval_ = value;
		}
	}

	public float MultiKillAddEnergy
	{
		get
		{
			return multiKillAddEnergy_;
		}
		set
		{
			multiKillAddEnergy_ = value;
		}
	}

	public float MultiKillAddEnergyByManual
	{
		get
		{
			return multiKillAddEnergyByManual_;
		}
		set
		{
			multiKillAddEnergyByManual_ = value;
		}
	}

	public FUStB2DMultiKillEnegyDesc()
	{
	}

	public FUStB2DMultiKillEnegyDesc(FUStB2DMultiKillEnegyDesc other)
		: this()
	{
		id_ = other.id_;
		multiKillCount_ = other.multiKillCount_;
		multiKillInterval_ = other.multiKillInterval_;
		multiKillAddEnergy_ = other.multiKillAddEnergy_;
		multiKillAddEnergyByManual_ = other.multiKillAddEnergyByManual_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DMultiKillEnegyDesc Clone()
	{
		return new FUStB2DMultiKillEnegyDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DMultiKillEnegyDesc);
	}

	public bool Equals(FUStB2DMultiKillEnegyDesc other)
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
		if (MultiKillCount != other.MultiKillCount)
		{
			return false;
		}
		if (MultiKillInterval != other.MultiKillInterval)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MultiKillAddEnergy, other.MultiKillAddEnergy))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MultiKillAddEnergyByManual, other.MultiKillAddEnergyByManual))
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
		if (MultiKillCount != 0)
		{
			num ^= MultiKillCount.GetHashCode();
		}
		if (MultiKillInterval != 0)
		{
			num ^= MultiKillInterval.GetHashCode();
		}
		if (MultiKillAddEnergy != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MultiKillAddEnergy);
		}
		if (MultiKillAddEnergyByManual != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MultiKillAddEnergyByManual);
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
		if (MultiKillCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MultiKillCount);
		}
		if (MultiKillInterval != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MultiKillInterval);
		}
		if (MultiKillAddEnergy != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(MultiKillAddEnergy);
		}
		if (MultiKillAddEnergyByManual != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(MultiKillAddEnergyByManual);
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
		if (MultiKillCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MultiKillCount);
		}
		if (MultiKillInterval != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MultiKillInterval);
		}
		if (MultiKillAddEnergy != 0f)
		{
			num += 5;
		}
		if (MultiKillAddEnergyByManual != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DMultiKillEnegyDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MultiKillCount != 0)
			{
				MultiKillCount = other.MultiKillCount;
			}
			if (other.MultiKillInterval != 0)
			{
				MultiKillInterval = other.MultiKillInterval;
			}
			if (other.MultiKillAddEnergy != 0f)
			{
				MultiKillAddEnergy = other.MultiKillAddEnergy;
			}
			if (other.MultiKillAddEnergyByManual != 0f)
			{
				MultiKillAddEnergyByManual = other.MultiKillAddEnergyByManual;
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
				MultiKillCount = input.ReadInt32();
				break;
			case 24u:
				MultiKillInterval = input.ReadInt32();
				break;
			case 37u:
				MultiKillAddEnergy = input.ReadFloat();
				break;
			case 45u:
				MultiKillAddEnergyByManual = input.ReadFloat();
				break;
			}
		}
	}
}
