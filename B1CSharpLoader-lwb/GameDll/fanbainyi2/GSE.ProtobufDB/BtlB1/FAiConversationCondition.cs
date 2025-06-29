using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FAiConversationCondition : IMessage<FAiConversationCondition>, IMessage, IEquatable<FAiConversationCondition>, IDeepCloneable<FAiConversationCondition>
{
	private static readonly MessageParser<FAiConversationCondition> _parser = new MessageParser<FAiConversationCondition>(() => new FAiConversationCondition());

	private UnknownFieldSet _unknownFields;

	private EAiConversationConditionType conditionType_;

	private EAiConversationTargetType conditionTargetType_;

	private string targetTypeParam_ = "";

	private string conditionValue_ = "";

	public static MessageParser<FAiConversationCondition> Parser => _parser;

	public EAiConversationConditionType ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

	public EAiConversationTargetType ConditionTargetType
	{
		get
		{
			return conditionTargetType_;
		}
		set
		{
			conditionTargetType_ = value;
		}
	}

	public string TargetTypeParam
	{
		get
		{
			return targetTypeParam_;
		}
		set
		{
			targetTypeParam_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ConditionValue
	{
		get
		{
			return conditionValue_;
		}
		set
		{
			conditionValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FAiConversationCondition()
	{
	}

	public FAiConversationCondition(FAiConversationCondition other)
		: this()
	{
		conditionType_ = other.conditionType_;
		conditionTargetType_ = other.conditionTargetType_;
		targetTypeParam_ = other.targetTypeParam_;
		conditionValue_ = other.conditionValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FAiConversationCondition Clone()
	{
		return new FAiConversationCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FAiConversationCondition);
	}

	public bool Equals(FAiConversationCondition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConditionType != other.ConditionType)
		{
			return false;
		}
		if (ConditionTargetType != other.ConditionTargetType)
		{
			return false;
		}
		if (TargetTypeParam != other.TargetTypeParam)
		{
			return false;
		}
		if (ConditionValue != other.ConditionValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConditionType != EAiConversationConditionType.None)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (ConditionTargetType != EAiConversationTargetType.None)
		{
			num ^= ConditionTargetType.GetHashCode();
		}
		if (TargetTypeParam.Length != 0)
		{
			num ^= TargetTypeParam.GetHashCode();
		}
		if (ConditionValue.Length != 0)
		{
			num ^= ConditionValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConditionType != EAiConversationConditionType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ConditionType);
		}
		if (ConditionTargetType != EAiConversationTargetType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ConditionTargetType);
		}
		if (TargetTypeParam.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TargetTypeParam);
		}
		if (ConditionValue.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ConditionValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConditionType != EAiConversationConditionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConditionType);
		}
		if (ConditionTargetType != EAiConversationTargetType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConditionTargetType);
		}
		if (TargetTypeParam.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TargetTypeParam);
		}
		if (ConditionValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConditionValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FAiConversationCondition other)
	{
		if (other != null)
		{
			if (other.ConditionType != EAiConversationConditionType.None)
			{
				ConditionType = other.ConditionType;
			}
			if (other.ConditionTargetType != EAiConversationTargetType.None)
			{
				ConditionTargetType = other.ConditionTargetType;
			}
			if (other.TargetTypeParam.Length != 0)
			{
				TargetTypeParam = other.TargetTypeParam;
			}
			if (other.ConditionValue.Length != 0)
			{
				ConditionValue = other.ConditionValue;
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
				ConditionType = (EAiConversationConditionType)input.ReadEnum();
				break;
			case 16u:
				ConditionTargetType = (EAiConversationTargetType)input.ReadEnum();
				break;
			case 26u:
				TargetTypeParam = input.ReadString();
				break;
			case 34u:
				ConditionValue = input.ReadString();
				break;
			}
		}
	}
}
