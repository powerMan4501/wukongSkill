using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStEffectiveHitProjectileEffectDesc : IMessage<FUStEffectiveHitProjectileEffectDesc>, IMessage, IEquatable<FUStEffectiveHitProjectileEffectDesc>, IDeepCloneable<FUStEffectiveHitProjectileEffectDesc>
{
	private static readonly MessageParser<FUStEffectiveHitProjectileEffectDesc> _parser = new MessageParser<FUStEffectiveHitProjectileEffectDesc>(() => new FUStEffectiveHitProjectileEffectDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float pEValueSwitchRatio_;

	private FProjectileBeHittedCostAttr costAttr_;

	private float increaseBaseValue_;

	private string guard_ = "";

	public static MessageParser<FUStEffectiveHitProjectileEffectDesc> Parser => _parser;

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

	public float PEValueSwitchRatio
	{
		get
		{
			return pEValueSwitchRatio_;
		}
		set
		{
			pEValueSwitchRatio_ = value;
		}
	}

	public FProjectileBeHittedCostAttr CostAttr
	{
		get
		{
			return costAttr_;
		}
		set
		{
			costAttr_ = value;
		}
	}

	public float IncreaseBaseValue
	{
		get
		{
			return increaseBaseValue_;
		}
		set
		{
			increaseBaseValue_ = value;
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStEffectiveHitProjectileEffectDesc()
	{
	}

	public FUStEffectiveHitProjectileEffectDesc(FUStEffectiveHitProjectileEffectDesc other)
		: this()
	{
		iD_ = other.iD_;
		pEValueSwitchRatio_ = other.pEValueSwitchRatio_;
		costAttr_ = ((other.costAttr_ != null) ? other.costAttr_.Clone() : null);
		increaseBaseValue_ = other.increaseBaseValue_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStEffectiveHitProjectileEffectDesc Clone()
	{
		return new FUStEffectiveHitProjectileEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStEffectiveHitProjectileEffectDesc);
	}

	public bool Equals(FUStEffectiveHitProjectileEffectDesc other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PEValueSwitchRatio, other.PEValueSwitchRatio))
		{
			return false;
		}
		if (!object.Equals(CostAttr, other.CostAttr))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(IncreaseBaseValue, other.IncreaseBaseValue))
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (PEValueSwitchRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PEValueSwitchRatio);
		}
		if (costAttr_ != null)
		{
			num ^= CostAttr.GetHashCode();
		}
		if (IncreaseBaseValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(IncreaseBaseValue);
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
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
		if (PEValueSwitchRatio != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(PEValueSwitchRatio);
		}
		if (costAttr_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CostAttr);
		}
		if (IncreaseBaseValue != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(IncreaseBaseValue);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Guard);
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
		if (PEValueSwitchRatio != 0f)
		{
			num += 5;
		}
		if (costAttr_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostAttr);
		}
		if (IncreaseBaseValue != 0f)
		{
			num += 5;
		}
		if (Guard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStEffectiveHitProjectileEffectDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.PEValueSwitchRatio != 0f)
		{
			PEValueSwitchRatio = other.PEValueSwitchRatio;
		}
		if (other.costAttr_ != null)
		{
			if (costAttr_ == null)
			{
				CostAttr = new FProjectileBeHittedCostAttr();
			}
			CostAttr.MergeFrom(other.CostAttr);
		}
		if (other.IncreaseBaseValue != 0f)
		{
			IncreaseBaseValue = other.IncreaseBaseValue;
		}
		if (other.Guard.Length != 0)
		{
			Guard = other.Guard;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 21u:
				PEValueSwitchRatio = input.ReadFloat();
				break;
			case 26u:
				if (costAttr_ == null)
				{
					CostAttr = new FProjectileBeHittedCostAttr();
				}
				input.ReadMessage(CostAttr);
				break;
			case 37u:
				IncreaseBaseValue = input.ReadFloat();
				break;
			case 42u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
