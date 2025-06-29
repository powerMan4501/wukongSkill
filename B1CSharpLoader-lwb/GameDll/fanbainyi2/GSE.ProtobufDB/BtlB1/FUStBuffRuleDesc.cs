using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBuffRuleDesc : IMessage<FUStBuffRuleDesc>, IMessage, IEquatable<FUStBuffRuleDesc>, IDeepCloneable<FUStBuffRuleDesc>
{
	private static readonly MessageParser<FUStBuffRuleDesc> _parser = new MessageParser<FUStBuffRuleDesc>(() => new FUStBuffRuleDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int buffID_;

	private EBuffRuleType buffRuleType_;

	private static readonly FieldCodec<int> _repeated_buffIDList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> buffIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_composedBuffID_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> composedBuffID_ = new RepeatedField<int>();

	private EGSYesNo composedKeepOldBuff_;

	private EGSYesNo withTriggerRemmoveEffect_;

	public static MessageParser<FUStBuffRuleDesc> Parser => _parser;

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

	public EBuffRuleType BuffRuleType
	{
		get
		{
			return buffRuleType_;
		}
		set
		{
			buffRuleType_ = value;
		}
	}

	public RepeatedField<int> BuffIDList => buffIDList_;

	public RepeatedField<int> ComposedBuffID => composedBuffID_;

	public EGSYesNo ComposedKeepOldBuff
	{
		get
		{
			return composedKeepOldBuff_;
		}
		set
		{
			composedKeepOldBuff_ = value;
		}
	}

	public EGSYesNo WithTriggerRemmoveEffect
	{
		get
		{
			return withTriggerRemmoveEffect_;
		}
		set
		{
			withTriggerRemmoveEffect_ = value;
		}
	}

	public FUStBuffRuleDesc()
	{
	}

	public FUStBuffRuleDesc(FUStBuffRuleDesc other)
		: this()
	{
		iD_ = other.iD_;
		buffID_ = other.buffID_;
		buffRuleType_ = other.buffRuleType_;
		buffIDList_ = other.buffIDList_.Clone();
		composedBuffID_ = other.composedBuffID_.Clone();
		composedKeepOldBuff_ = other.composedKeepOldBuff_;
		withTriggerRemmoveEffect_ = other.withTriggerRemmoveEffect_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffRuleDesc Clone()
	{
		return new FUStBuffRuleDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffRuleDesc);
	}

	public bool Equals(FUStBuffRuleDesc other)
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
		if (BuffID != other.BuffID)
		{
			return false;
		}
		if (BuffRuleType != other.BuffRuleType)
		{
			return false;
		}
		if (!buffIDList_.Equals(other.buffIDList_))
		{
			return false;
		}
		if (!composedBuffID_.Equals(other.composedBuffID_))
		{
			return false;
		}
		if (ComposedKeepOldBuff != other.ComposedKeepOldBuff)
		{
			return false;
		}
		if (WithTriggerRemmoveEffect != other.WithTriggerRemmoveEffect)
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
		if (BuffID != 0)
		{
			num ^= BuffID.GetHashCode();
		}
		if (BuffRuleType != EBuffRuleType.BuffRuleNone)
		{
			num ^= BuffRuleType.GetHashCode();
		}
		num ^= buffIDList_.GetHashCode();
		num ^= composedBuffID_.GetHashCode();
		if (ComposedKeepOldBuff != EGSYesNo.No)
		{
			num ^= ComposedKeepOldBuff.GetHashCode();
		}
		if (WithTriggerRemmoveEffect != EGSYesNo.No)
		{
			num ^= WithTriggerRemmoveEffect.GetHashCode();
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
		if (BuffID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffID);
		}
		if (BuffRuleType != EBuffRuleType.BuffRuleNone)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)BuffRuleType);
		}
		buffIDList_.WriteTo(output, _repeated_buffIDList_codec);
		composedBuffID_.WriteTo(output, _repeated_composedBuffID_codec);
		if (ComposedKeepOldBuff != EGSYesNo.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)ComposedKeepOldBuff);
		}
		if (WithTriggerRemmoveEffect != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)WithTriggerRemmoveEffect);
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
		if (BuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffID);
		}
		if (BuffRuleType != EBuffRuleType.BuffRuleNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BuffRuleType);
		}
		num += buffIDList_.CalculateSize(_repeated_buffIDList_codec);
		num += composedBuffID_.CalculateSize(_repeated_composedBuffID_codec);
		if (ComposedKeepOldBuff != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ComposedKeepOldBuff);
		}
		if (WithTriggerRemmoveEffect != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)WithTriggerRemmoveEffect);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffRuleDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BuffID != 0)
			{
				BuffID = other.BuffID;
			}
			if (other.BuffRuleType != EBuffRuleType.BuffRuleNone)
			{
				BuffRuleType = other.BuffRuleType;
			}
			buffIDList_.Add(other.buffIDList_);
			composedBuffID_.Add(other.composedBuffID_);
			if (other.ComposedKeepOldBuff != EGSYesNo.No)
			{
				ComposedKeepOldBuff = other.ComposedKeepOldBuff;
			}
			if (other.WithTriggerRemmoveEffect != EGSYesNo.No)
			{
				WithTriggerRemmoveEffect = other.WithTriggerRemmoveEffect;
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
				BuffID = input.ReadInt32();
				break;
			case 24u:
				BuffRuleType = (EBuffRuleType)input.ReadEnum();
				break;
			case 32u:
			case 34u:
				buffIDList_.AddEntriesFrom(input, _repeated_buffIDList_codec);
				break;
			case 40u:
			case 42u:
				composedBuffID_.AddEntriesFrom(input, _repeated_composedBuffID_codec);
				break;
			case 48u:
				ComposedKeepOldBuff = (EGSYesNo)input.ReadEnum();
				break;
			case 56u:
				WithTriggerRemmoveEffect = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
