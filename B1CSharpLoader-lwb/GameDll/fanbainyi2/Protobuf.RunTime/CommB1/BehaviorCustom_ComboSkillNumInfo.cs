using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_ComboSkillNumInfo : IMessage<BehaviorCustom_ComboSkillNumInfo>, IMessage, IEquatable<BehaviorCustom_ComboSkillNumInfo>, IDeepCloneable<BehaviorCustom_ComboSkillNumInfo>
{
	private static readonly MessageParser<BehaviorCustom_ComboSkillNumInfo> _parser = new MessageParser<BehaviorCustom_ComboSkillNumInfo>(() => new BehaviorCustom_ComboSkillNumInfo());

	private UnknownFieldSet _unknownFields;

	private int comboNum_;

	private int comboPercentRatio_;

	public static MessageParser<BehaviorCustom_ComboSkillNumInfo> Parser => _parser;

	public int ComboNum
	{
		get
		{
			return comboNum_;
		}
		set
		{
			comboNum_ = value;
		}
	}

	public int ComboPercentRatio
	{
		get
		{
			return comboPercentRatio_;
		}
		set
		{
			comboPercentRatio_ = value;
		}
	}

	public BehaviorCustom_ComboSkillNumInfo()
	{
	}

	public BehaviorCustom_ComboSkillNumInfo(BehaviorCustom_ComboSkillNumInfo other)
		: this()
	{
		comboNum_ = other.comboNum_;
		comboPercentRatio_ = other.comboPercentRatio_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_ComboSkillNumInfo Clone()
	{
		return new BehaviorCustom_ComboSkillNumInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_ComboSkillNumInfo);
	}

	public bool Equals(BehaviorCustom_ComboSkillNumInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ComboNum != other.ComboNum)
		{
			return false;
		}
		if (ComboPercentRatio != other.ComboPercentRatio)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ComboNum != 0)
		{
			num ^= ComboNum.GetHashCode();
		}
		if (ComboPercentRatio != 0)
		{
			num ^= ComboPercentRatio.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ComboNum != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ComboNum);
		}
		if (ComboPercentRatio != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ComboPercentRatio);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ComboNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ComboNum);
		}
		if (ComboPercentRatio != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ComboPercentRatio);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_ComboSkillNumInfo other)
	{
		if (other != null)
		{
			if (other.ComboNum != 0)
			{
				ComboNum = other.ComboNum;
			}
			if (other.ComboPercentRatio != 0)
			{
				ComboPercentRatio = other.ComboPercentRatio;
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
				ComboNum = input.ReadInt32();
				break;
			case 16u:
				ComboPercentRatio = input.ReadInt32();
				break;
			}
		}
	}
}
