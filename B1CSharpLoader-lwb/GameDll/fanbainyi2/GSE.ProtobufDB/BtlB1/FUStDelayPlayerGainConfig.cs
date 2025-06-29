using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStDelayPlayerGainConfig : IMessage<FUStDelayPlayerGainConfig>, IMessage, IEquatable<FUStDelayPlayerGainConfig>, IDeepCloneable<FUStDelayPlayerGainConfig>
{
	private static readonly MessageParser<FUStDelayPlayerGainConfig> _parser = new MessageParser<FUStDelayPlayerGainConfig>(() => new FUStDelayPlayerGainConfig());

	private UnknownFieldSet _unknownFields;

	private int buffID_;

	private int performanceBuffL1_;

	private int performanceBuffL2_;

	private int performanceBuffL3_;

	private int performanceBuffL4_;

	private float distance_;

	public static MessageParser<FUStDelayPlayerGainConfig> Parser => _parser;

	public int BuffID
	{
		get
		{
			return buffID_;
		}
		set
		{
			buffID_ = value;
		}
	}

	public int PerformanceBuffL1
	{
		get
		{
			return performanceBuffL1_;
		}
		set
		{
			performanceBuffL1_ = value;
		}
	}

	public int PerformanceBuffL2
	{
		get
		{
			return performanceBuffL2_;
		}
		set
		{
			performanceBuffL2_ = value;
		}
	}

	public int PerformanceBuffL3
	{
		get
		{
			return performanceBuffL3_;
		}
		set
		{
			performanceBuffL3_ = value;
		}
	}

	public int PerformanceBuffL4
	{
		get
		{
			return performanceBuffL4_;
		}
		set
		{
			performanceBuffL4_ = value;
		}
	}

	public float Distance
	{
		get
		{
			return distance_;
		}
		set
		{
			distance_ = value;
		}
	}

	public FUStDelayPlayerGainConfig()
	{
	}

	public FUStDelayPlayerGainConfig(FUStDelayPlayerGainConfig other)
		: this()
	{
		buffID_ = other.buffID_;
		performanceBuffL1_ = other.performanceBuffL1_;
		performanceBuffL2_ = other.performanceBuffL2_;
		performanceBuffL3_ = other.performanceBuffL3_;
		performanceBuffL4_ = other.performanceBuffL4_;
		distance_ = other.distance_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDelayPlayerGainConfig Clone()
	{
		return new FUStDelayPlayerGainConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDelayPlayerGainConfig);
	}

	public bool Equals(FUStDelayPlayerGainConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffID != other.BuffID)
		{
			return false;
		}
		if (PerformanceBuffL1 != other.PerformanceBuffL1)
		{
			return false;
		}
		if (PerformanceBuffL2 != other.PerformanceBuffL2)
		{
			return false;
		}
		if (PerformanceBuffL3 != other.PerformanceBuffL3)
		{
			return false;
		}
		if (PerformanceBuffL4 != other.PerformanceBuffL4)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Distance, other.Distance))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BuffID != 0)
		{
			num ^= BuffID.GetHashCode();
		}
		if (PerformanceBuffL1 != 0)
		{
			num ^= PerformanceBuffL1.GetHashCode();
		}
		if (PerformanceBuffL2 != 0)
		{
			num ^= PerformanceBuffL2.GetHashCode();
		}
		if (PerformanceBuffL3 != 0)
		{
			num ^= PerformanceBuffL3.GetHashCode();
		}
		if (PerformanceBuffL4 != 0)
		{
			num ^= PerformanceBuffL4.GetHashCode();
		}
		if (Distance != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Distance);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BuffID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuffID);
		}
		if (PerformanceBuffL1 != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PerformanceBuffL1);
		}
		if (PerformanceBuffL2 != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PerformanceBuffL2);
		}
		if (PerformanceBuffL3 != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PerformanceBuffL3);
		}
		if (PerformanceBuffL4 != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(PerformanceBuffL4);
		}
		if (Distance != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(Distance);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffID);
		}
		if (PerformanceBuffL1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PerformanceBuffL1);
		}
		if (PerformanceBuffL2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PerformanceBuffL2);
		}
		if (PerformanceBuffL3 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PerformanceBuffL3);
		}
		if (PerformanceBuffL4 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PerformanceBuffL4);
		}
		if (Distance != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDelayPlayerGainConfig other)
	{
		if (other != null)
		{
			if (other.BuffID != 0)
			{
				BuffID = other.BuffID;
			}
			if (other.PerformanceBuffL1 != 0)
			{
				PerformanceBuffL1 = other.PerformanceBuffL1;
			}
			if (other.PerformanceBuffL2 != 0)
			{
				PerformanceBuffL2 = other.PerformanceBuffL2;
			}
			if (other.PerformanceBuffL3 != 0)
			{
				PerformanceBuffL3 = other.PerformanceBuffL3;
			}
			if (other.PerformanceBuffL4 != 0)
			{
				PerformanceBuffL4 = other.PerformanceBuffL4;
			}
			if (other.Distance != 0f)
			{
				Distance = other.Distance;
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
				BuffID = input.ReadInt32();
				break;
			case 16u:
				PerformanceBuffL1 = input.ReadInt32();
				break;
			case 24u:
				PerformanceBuffL2 = input.ReadInt32();
				break;
			case 32u:
				PerformanceBuffL3 = input.ReadInt32();
				break;
			case 40u:
				PerformanceBuffL4 = input.ReadInt32();
				break;
			case 53u:
				Distance = input.ReadFloat();
				break;
			}
		}
	}
}
