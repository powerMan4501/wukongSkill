using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStShiningDesc : IMessage<FUStShiningDesc>, IMessage, IEquatable<FUStShiningDesc>, IDeepCloneable<FUStShiningDesc>
{
	private static readonly MessageParser<FUStShiningDesc> _parser = new MessageParser<FUStShiningDesc>(() => new FUStShiningDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int step_;

	private int stage_;

	private float needShining_;

	private float consumeSpeed_;

	private int skillID_;

	public static MessageParser<FUStShiningDesc> Parser => _parser;

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

	public int Step
	{
		get
		{
			return step_;
		}
		set
		{
			step_ = value;
		}
	}

	public int Stage
	{
		get
		{
			return stage_;
		}
		set
		{
			stage_ = value;
		}
	}

	public float NeedShining
	{
		get
		{
			return needShining_;
		}
		set
		{
			needShining_ = value;
		}
	}

	public float ConsumeSpeed
	{
		get
		{
			return consumeSpeed_;
		}
		set
		{
			consumeSpeed_ = value;
		}
	}

	public int SkillID
	{
		get
		{
			return skillID_;
		}
		set
		{
			skillID_ = value;
		}
	}

	public FUStShiningDesc()
	{
	}

	public FUStShiningDesc(FUStShiningDesc other)
		: this()
	{
		iD_ = other.iD_;
		step_ = other.step_;
		stage_ = other.stage_;
		needShining_ = other.needShining_;
		consumeSpeed_ = other.consumeSpeed_;
		skillID_ = other.skillID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStShiningDesc Clone()
	{
		return new FUStShiningDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStShiningDesc);
	}

	public bool Equals(FUStShiningDesc other)
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
		if (Step != other.Step)
		{
			return false;
		}
		if (Stage != other.Stage)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(NeedShining, other.NeedShining))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ConsumeSpeed, other.ConsumeSpeed))
		{
			return false;
		}
		if (SkillID != other.SkillID)
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
		if (Step != 0)
		{
			num ^= Step.GetHashCode();
		}
		if (Stage != 0)
		{
			num ^= Stage.GetHashCode();
		}
		if (NeedShining != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(NeedShining);
		}
		if (ConsumeSpeed != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ConsumeSpeed);
		}
		if (SkillID != 0)
		{
			num ^= SkillID.GetHashCode();
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
		if (Step != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Step);
		}
		if (Stage != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Stage);
		}
		if (NeedShining != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(NeedShining);
		}
		if (ConsumeSpeed != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(ConsumeSpeed);
		}
		if (SkillID != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SkillID);
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
		if (Step != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Step);
		}
		if (Stage != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Stage);
		}
		if (NeedShining != 0f)
		{
			num += 5;
		}
		if (ConsumeSpeed != 0f)
		{
			num += 5;
		}
		if (SkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStShiningDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Step != 0)
			{
				Step = other.Step;
			}
			if (other.Stage != 0)
			{
				Stage = other.Stage;
			}
			if (other.NeedShining != 0f)
			{
				NeedShining = other.NeedShining;
			}
			if (other.ConsumeSpeed != 0f)
			{
				ConsumeSpeed = other.ConsumeSpeed;
			}
			if (other.SkillID != 0)
			{
				SkillID = other.SkillID;
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
			case 16u:
				Step = input.ReadInt32();
				break;
			case 24u:
				Stage = input.ReadInt32();
				break;
			case 37u:
				NeedShining = input.ReadFloat();
				break;
			case 45u:
				ConsumeSpeed = input.ReadFloat();
				break;
			case 48u:
				SkillID = input.ReadInt32();
				break;
			}
		}
	}
}
