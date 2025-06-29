using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TransInputUITipsDesc : IMessage<TransInputUITipsDesc>, IMessage, IEquatable<TransInputUITipsDesc>, IDeepCloneable<TransInputUITipsDesc>
{
	private static readonly MessageParser<TransInputUITipsDesc> _parser = new MessageParser<TransInputUITipsDesc>(() => new TransInputUITipsDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int resId_;

	private int stateBuffId1_;

	private int stateBuffId2_;

	private int stateBuffId3_;

	private ETransInputCondition condition_;

	private int conditionParamInt_;

	private ETransInputCondition condition2_;

	private int conditionParamInt2_;

	private string title_ = "";

	private string content_ = "";

	private int sortId_;

	private int priorityId_;

	private int localizationTag_;

	public static MessageParser<TransInputUITipsDesc> Parser => _parser;

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

	public int ResId
	{
		get
		{
			return resId_;
		}
		set
		{
			resId_ = value;
		}
	}

	public int StateBuffId1
	{
		get
		{
			return stateBuffId1_;
		}
		set
		{
			stateBuffId1_ = value;
		}
	}

	public int StateBuffId2
	{
		get
		{
			return stateBuffId2_;
		}
		set
		{
			stateBuffId2_ = value;
		}
	}

	public int StateBuffId3
	{
		get
		{
			return stateBuffId3_;
		}
		set
		{
			stateBuffId3_ = value;
		}
	}

	public ETransInputCondition Condition
	{
		get
		{
			return condition_;
		}
		set
		{
			condition_ = value;
		}
	}

	public int ConditionParamInt
	{
		get
		{
			return conditionParamInt_;
		}
		set
		{
			conditionParamInt_ = value;
		}
	}

	public ETransInputCondition Condition2
	{
		get
		{
			return condition2_;
		}
		set
		{
			condition2_ = value;
		}
	}

	public int ConditionParamInt2
	{
		get
		{
			return conditionParamInt2_;
		}
		set
		{
			conditionParamInt2_ = value;
		}
	}

	public string Title
	{
		get
		{
			return title_;
		}
		set
		{
			title_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Content
	{
		get
		{
			return content_;
		}
		set
		{
			content_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public int PriorityId
	{
		get
		{
			return priorityId_;
		}
		set
		{
			priorityId_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public TransInputUITipsDesc()
	{
	}

	public TransInputUITipsDesc(TransInputUITipsDesc other)
		: this()
	{
		id_ = other.id_;
		resId_ = other.resId_;
		stateBuffId1_ = other.stateBuffId1_;
		stateBuffId2_ = other.stateBuffId2_;
		stateBuffId3_ = other.stateBuffId3_;
		condition_ = other.condition_;
		conditionParamInt_ = other.conditionParamInt_;
		condition2_ = other.condition2_;
		conditionParamInt2_ = other.conditionParamInt2_;
		title_ = other.title_;
		content_ = other.content_;
		sortId_ = other.sortId_;
		priorityId_ = other.priorityId_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TransInputUITipsDesc Clone()
	{
		return new TransInputUITipsDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TransInputUITipsDesc);
	}

	public bool Equals(TransInputUITipsDesc other)
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
		if (ResId != other.ResId)
		{
			return false;
		}
		if (StateBuffId1 != other.StateBuffId1)
		{
			return false;
		}
		if (StateBuffId2 != other.StateBuffId2)
		{
			return false;
		}
		if (StateBuffId3 != other.StateBuffId3)
		{
			return false;
		}
		if (Condition != other.Condition)
		{
			return false;
		}
		if (ConditionParamInt != other.ConditionParamInt)
		{
			return false;
		}
		if (Condition2 != other.Condition2)
		{
			return false;
		}
		if (ConditionParamInt2 != other.ConditionParamInt2)
		{
			return false;
		}
		if (Title != other.Title)
		{
			return false;
		}
		if (Content != other.Content)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (PriorityId != other.PriorityId)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (ResId != 0)
		{
			num ^= ResId.GetHashCode();
		}
		if (StateBuffId1 != 0)
		{
			num ^= StateBuffId1.GetHashCode();
		}
		if (StateBuffId2 != 0)
		{
			num ^= StateBuffId2.GetHashCode();
		}
		if (StateBuffId3 != 0)
		{
			num ^= StateBuffId3.GetHashCode();
		}
		if (Condition != ETransInputCondition.None)
		{
			num ^= Condition.GetHashCode();
		}
		if (ConditionParamInt != 0)
		{
			num ^= ConditionParamInt.GetHashCode();
		}
		if (Condition2 != ETransInputCondition.None)
		{
			num ^= Condition2.GetHashCode();
		}
		if (ConditionParamInt2 != 0)
		{
			num ^= ConditionParamInt2.GetHashCode();
		}
		if (Title.Length != 0)
		{
			num ^= Title.GetHashCode();
		}
		if (Content.Length != 0)
		{
			num ^= Content.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (PriorityId != 0)
		{
			num ^= PriorityId.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
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
		if (ResId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResId);
		}
		if (StateBuffId1 != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(StateBuffId1);
		}
		if (StateBuffId2 != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(StateBuffId2);
		}
		if (StateBuffId3 != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(StateBuffId3);
		}
		if (Condition != ETransInputCondition.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Condition);
		}
		if (ConditionParamInt != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ConditionParamInt);
		}
		if (Condition2 != ETransInputCondition.None)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)Condition2);
		}
		if (ConditionParamInt2 != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ConditionParamInt2);
		}
		if (Title.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(Title);
		}
		if (Content.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Content);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(SortId);
		}
		if (PriorityId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(PriorityId);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(LocalizationTag);
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
		if (ResId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResId);
		}
		if (StateBuffId1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StateBuffId1);
		}
		if (StateBuffId2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StateBuffId2);
		}
		if (StateBuffId3 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StateBuffId3);
		}
		if (Condition != ETransInputCondition.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Condition);
		}
		if (ConditionParamInt != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionParamInt);
		}
		if (Condition2 != ETransInputCondition.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Condition2);
		}
		if (ConditionParamInt2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionParamInt2);
		}
		if (Title.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (Content.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Content);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (PriorityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PriorityId);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TransInputUITipsDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ResId != 0)
			{
				ResId = other.ResId;
			}
			if (other.StateBuffId1 != 0)
			{
				StateBuffId1 = other.StateBuffId1;
			}
			if (other.StateBuffId2 != 0)
			{
				StateBuffId2 = other.StateBuffId2;
			}
			if (other.StateBuffId3 != 0)
			{
				StateBuffId3 = other.StateBuffId3;
			}
			if (other.Condition != ETransInputCondition.None)
			{
				Condition = other.Condition;
			}
			if (other.ConditionParamInt != 0)
			{
				ConditionParamInt = other.ConditionParamInt;
			}
			if (other.Condition2 != ETransInputCondition.None)
			{
				Condition2 = other.Condition2;
			}
			if (other.ConditionParamInt2 != 0)
			{
				ConditionParamInt2 = other.ConditionParamInt2;
			}
			if (other.Title.Length != 0)
			{
				Title = other.Title;
			}
			if (other.Content.Length != 0)
			{
				Content = other.Content;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.PriorityId != 0)
			{
				PriorityId = other.PriorityId;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				ResId = input.ReadInt32();
				break;
			case 24u:
				StateBuffId1 = input.ReadInt32();
				break;
			case 32u:
				StateBuffId2 = input.ReadInt32();
				break;
			case 40u:
				StateBuffId3 = input.ReadInt32();
				break;
			case 48u:
				Condition = (ETransInputCondition)input.ReadEnum();
				break;
			case 56u:
				ConditionParamInt = input.ReadInt32();
				break;
			case 64u:
				Condition2 = (ETransInputCondition)input.ReadEnum();
				break;
			case 72u:
				ConditionParamInt2 = input.ReadInt32();
				break;
			case 82u:
				Title = input.ReadString();
				break;
			case 90u:
				Content = input.ReadString();
				break;
			case 96u:
				SortId = input.ReadInt32();
				break;
			case 104u:
				PriorityId = input.ReadInt32();
				break;
			case 112u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
