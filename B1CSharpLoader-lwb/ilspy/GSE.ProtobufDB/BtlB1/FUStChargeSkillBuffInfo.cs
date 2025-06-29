using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStChargeSkillBuffInfo : IMessage<FUStChargeSkillBuffInfo>, IMessage, IEquatable<FUStChargeSkillBuffInfo>, IDeepCloneable<FUStChargeSkillBuffInfo>
{
	private static readonly MessageParser<FUStChargeSkillBuffInfo> _parser = new MessageParser<FUStChargeSkillBuffInfo>(() => new FUStChargeSkillBuffInfo());

	private UnknownFieldSet _unknownFields;

	private int buffID_;

	private float beginTimeInBeginStage_;

	private float endTimeInEndStage_;

	public static MessageParser<FUStChargeSkillBuffInfo> Parser => _parser;

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

	public float BeginTimeInBeginStage
	{
		get
		{
			return beginTimeInBeginStage_;
		}
		set
		{
			beginTimeInBeginStage_ = value;
		}
	}

	public float EndTimeInEndStage
	{
		get
		{
			return endTimeInEndStage_;
		}
		set
		{
			endTimeInEndStage_ = value;
		}
	}

	public FUStChargeSkillBuffInfo()
	{
	}

	public FUStChargeSkillBuffInfo(FUStChargeSkillBuffInfo other)
		: this()
	{
		buffID_ = other.buffID_;
		beginTimeInBeginStage_ = other.beginTimeInBeginStage_;
		endTimeInEndStage_ = other.endTimeInEndStage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStChargeSkillBuffInfo Clone()
	{
		return new FUStChargeSkillBuffInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStChargeSkillBuffInfo);
	}

	public bool Equals(FUStChargeSkillBuffInfo other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BeginTimeInBeginStage, other.BeginTimeInBeginStage))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(EndTimeInEndStage, other.EndTimeInEndStage))
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
		if (BeginTimeInBeginStage != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BeginTimeInBeginStage);
		}
		if (EndTimeInEndStage != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EndTimeInEndStage);
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
		if (BeginTimeInBeginStage != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(BeginTimeInBeginStage);
		}
		if (EndTimeInEndStage != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(EndTimeInEndStage);
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
		if (BeginTimeInBeginStage != 0f)
		{
			num += 5;
		}
		if (EndTimeInEndStage != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStChargeSkillBuffInfo other)
	{
		if (other != null)
		{
			if (other.BuffID != 0)
			{
				BuffID = other.BuffID;
			}
			if (other.BeginTimeInBeginStage != 0f)
			{
				BeginTimeInBeginStage = other.BeginTimeInBeginStage;
			}
			if (other.EndTimeInEndStage != 0f)
			{
				EndTimeInEndStage = other.EndTimeInEndStage;
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
			case 21u:
				BeginTimeInBeginStage = input.ReadFloat();
				break;
			case 29u:
				EndTimeInEndStage = input.ReadFloat();
				break;
			}
		}
	}
}
