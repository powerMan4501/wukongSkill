using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BossRushCustom_TableOverride : IMessage<BossRushCustom_TableOverride>, IMessage, IEquatable<BossRushCustom_TableOverride>, IDeepCloneable<BossRushCustom_TableOverride>
{
	private static readonly MessageParser<BossRushCustom_TableOverride> _parser = new MessageParser<BossRushCustom_TableOverride>(() => new BossRushCustom_TableOverride());

	private UnknownFieldSet _unknownFields;

	private EBossRushModifyTableMethod modifyMethod_;

	private int mainId_;

	private int subId_;

	private int thirdId_;

	private int intValue_;

	private float floatValue_;

	private string stringValue_ = "";

	public static MessageParser<BossRushCustom_TableOverride> Parser => _parser;

	public EBossRushModifyTableMethod ModifyMethod
	{
		get
		{
			return modifyMethod_;
		}
		set
		{
			modifyMethod_ = value;
		}
	}

	public int MainId
	{
		get
		{
			return mainId_;
		}
		set
		{
			mainId_ = value;
		}
	}

	public int SubId
	{
		get
		{
			return subId_;
		}
		set
		{
			subId_ = value;
		}
	}

	public int ThirdId
	{
		get
		{
			return thirdId_;
		}
		set
		{
			thirdId_ = value;
		}
	}

	public int IntValue
	{
		get
		{
			return intValue_;
		}
		set
		{
			intValue_ = value;
		}
	}

	public float FloatValue
	{
		get
		{
			return floatValue_;
		}
		set
		{
			floatValue_ = value;
		}
	}

	public string StringValue
	{
		get
		{
			return stringValue_;
		}
		set
		{
			stringValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BossRushCustom_TableOverride()
	{
	}

	public BossRushCustom_TableOverride(BossRushCustom_TableOverride other)
		: this()
	{
		modifyMethod_ = other.modifyMethod_;
		mainId_ = other.mainId_;
		subId_ = other.subId_;
		thirdId_ = other.thirdId_;
		intValue_ = other.intValue_;
		floatValue_ = other.floatValue_;
		stringValue_ = other.stringValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushCustom_TableOverride Clone()
	{
		return new BossRushCustom_TableOverride(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushCustom_TableOverride);
	}

	public bool Equals(BossRushCustom_TableOverride other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ModifyMethod != other.ModifyMethod)
		{
			return false;
		}
		if (MainId != other.MainId)
		{
			return false;
		}
		if (SubId != other.SubId)
		{
			return false;
		}
		if (ThirdId != other.ThirdId)
		{
			return false;
		}
		if (IntValue != other.IntValue)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatValue, other.FloatValue))
		{
			return false;
		}
		if (StringValue != other.StringValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ModifyMethod != EBossRushModifyTableMethod.None)
		{
			num ^= ModifyMethod.GetHashCode();
		}
		if (MainId != 0)
		{
			num ^= MainId.GetHashCode();
		}
		if (SubId != 0)
		{
			num ^= SubId.GetHashCode();
		}
		if (ThirdId != 0)
		{
			num ^= ThirdId.GetHashCode();
		}
		if (IntValue != 0)
		{
			num ^= IntValue.GetHashCode();
		}
		if (FloatValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatValue);
		}
		if (StringValue.Length != 0)
		{
			num ^= StringValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ModifyMethod != EBossRushModifyTableMethod.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ModifyMethod);
		}
		if (MainId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MainId);
		}
		if (SubId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SubId);
		}
		if (ThirdId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ThirdId);
		}
		if (IntValue != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(IntValue);
		}
		if (FloatValue != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(FloatValue);
		}
		if (StringValue.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(StringValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ModifyMethod != EBossRushModifyTableMethod.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ModifyMethod);
		}
		if (MainId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MainId);
		}
		if (SubId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubId);
		}
		if (ThirdId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ThirdId);
		}
		if (IntValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IntValue);
		}
		if (FloatValue != 0f)
		{
			num += 5;
		}
		if (StringValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StringValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushCustom_TableOverride other)
	{
		if (other != null)
		{
			if (other.ModifyMethod != EBossRushModifyTableMethod.None)
			{
				ModifyMethod = other.ModifyMethod;
			}
			if (other.MainId != 0)
			{
				MainId = other.MainId;
			}
			if (other.SubId != 0)
			{
				SubId = other.SubId;
			}
			if (other.ThirdId != 0)
			{
				ThirdId = other.ThirdId;
			}
			if (other.IntValue != 0)
			{
				IntValue = other.IntValue;
			}
			if (other.FloatValue != 0f)
			{
				FloatValue = other.FloatValue;
			}
			if (other.StringValue.Length != 0)
			{
				StringValue = other.StringValue;
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
				ModifyMethod = (EBossRushModifyTableMethod)input.ReadEnum();
				break;
			case 16u:
				MainId = input.ReadInt32();
				break;
			case 24u:
				SubId = input.ReadInt32();
				break;
			case 32u:
				ThirdId = input.ReadInt32();
				break;
			case 40u:
				IntValue = input.ReadInt32();
				break;
			case 53u:
				FloatValue = input.ReadFloat();
				break;
			case 58u:
				StringValue = input.ReadString();
				break;
			}
		}
	}
}
