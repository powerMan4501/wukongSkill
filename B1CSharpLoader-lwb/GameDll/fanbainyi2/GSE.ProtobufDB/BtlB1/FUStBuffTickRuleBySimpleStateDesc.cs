using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBuffTickRuleBySimpleStateDesc : IMessage<FUStBuffTickRuleBySimpleStateDesc>, IMessage, IEquatable<FUStBuffTickRuleBySimpleStateDesc>, IDeepCloneable<FUStBuffTickRuleBySimpleStateDesc>
{
	private static readonly MessageParser<FUStBuffTickRuleBySimpleStateDesc> _parser = new MessageParser<FUStBuffTickRuleBySimpleStateDesc>(() => new FUStBuffTickRuleBySimpleStateDesc());

	private UnknownFieldSet _unknownFields;

	private int simpleStateID_;

	private EBuffTickRuleBySSType ruleType_;

	private static readonly FieldCodec<int> _repeated_buffIDList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> buffIDList_ = new RepeatedField<int>();

	public static MessageParser<FUStBuffTickRuleBySimpleStateDesc> Parser => _parser;

	public int SimpleStateID
	{
		get
		{
			return simpleStateID_;
		}
		set
		{
			simpleStateID_ = value;
		}
	}

	public EBuffTickRuleBySSType RuleType
	{
		get
		{
			return ruleType_;
		}
		set
		{
			ruleType_ = value;
		}
	}

	public RepeatedField<int> BuffIDList => buffIDList_;

	public FUStBuffTickRuleBySimpleStateDesc()
	{
	}

	public FUStBuffTickRuleBySimpleStateDesc(FUStBuffTickRuleBySimpleStateDesc other)
		: this()
	{
		simpleStateID_ = other.simpleStateID_;
		ruleType_ = other.ruleType_;
		buffIDList_ = other.buffIDList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffTickRuleBySimpleStateDesc Clone()
	{
		return new FUStBuffTickRuleBySimpleStateDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffTickRuleBySimpleStateDesc);
	}

	public bool Equals(FUStBuffTickRuleBySimpleStateDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SimpleStateID != other.SimpleStateID)
		{
			return false;
		}
		if (RuleType != other.RuleType)
		{
			return false;
		}
		if (!buffIDList_.Equals(other.buffIDList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SimpleStateID != 0)
		{
			num ^= SimpleStateID.GetHashCode();
		}
		if (RuleType != EBuffTickRuleBySSType.None)
		{
			num ^= RuleType.GetHashCode();
		}
		num ^= buffIDList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SimpleStateID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SimpleStateID);
		}
		if (RuleType != EBuffTickRuleBySSType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)RuleType);
		}
		buffIDList_.WriteTo(output, _repeated_buffIDList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SimpleStateID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SimpleStateID);
		}
		if (RuleType != EBuffTickRuleBySSType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RuleType);
		}
		num += buffIDList_.CalculateSize(_repeated_buffIDList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffTickRuleBySimpleStateDesc other)
	{
		if (other != null)
		{
			if (other.SimpleStateID != 0)
			{
				SimpleStateID = other.SimpleStateID;
			}
			if (other.RuleType != EBuffTickRuleBySSType.None)
			{
				RuleType = other.RuleType;
			}
			buffIDList_.Add(other.buffIDList_);
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
				SimpleStateID = input.ReadInt32();
				break;
			case 16u:
				RuleType = (EBuffTickRuleBySSType)input.ReadEnum();
				break;
			case 24u:
			case 26u:
				buffIDList_.AddEntriesFrom(input, _repeated_buffIDList_codec);
				break;
			}
		}
	}
}
