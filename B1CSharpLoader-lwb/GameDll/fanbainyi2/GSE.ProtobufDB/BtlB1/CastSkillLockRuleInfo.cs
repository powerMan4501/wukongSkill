using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class CastSkillLockRuleInfo : IMessage<CastSkillLockRuleInfo>, IMessage, IEquatable<CastSkillLockRuleInfo>, IDeepCloneable<CastSkillLockRuleInfo>
{
	private static readonly MessageParser<CastSkillLockRuleInfo> _parser = new MessageParser<CastSkillLockRuleInfo>(() => new CastSkillLockRuleInfo());

	private UnknownFieldSet _unknownFields;

	private EGSYesNo onlyManualLock_;

	private int mappingSkillID_;

	private static readonly FieldCodec<int> _repeated_unitResIDList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> unitResIDList_ = new RepeatedField<int>();

	public static MessageParser<CastSkillLockRuleInfo> Parser => _parser;

	public EGSYesNo OnlyManualLock
	{
		get
		{
			return onlyManualLock_;
		}
		set
		{
			onlyManualLock_ = value;
		}
	}

	public int MappingSkillID
	{
		get
		{
			return mappingSkillID_;
		}
		set
		{
			mappingSkillID_ = value;
		}
	}

	public RepeatedField<int> UnitResIDList => unitResIDList_;

	public CastSkillLockRuleInfo()
	{
	}

	public CastSkillLockRuleInfo(CastSkillLockRuleInfo other)
		: this()
	{
		onlyManualLock_ = other.onlyManualLock_;
		mappingSkillID_ = other.mappingSkillID_;
		unitResIDList_ = other.unitResIDList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CastSkillLockRuleInfo Clone()
	{
		return new CastSkillLockRuleInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CastSkillLockRuleInfo);
	}

	public bool Equals(CastSkillLockRuleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OnlyManualLock != other.OnlyManualLock)
		{
			return false;
		}
		if (MappingSkillID != other.MappingSkillID)
		{
			return false;
		}
		if (!unitResIDList_.Equals(other.unitResIDList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (OnlyManualLock != EGSYesNo.No)
		{
			num ^= OnlyManualLock.GetHashCode();
		}
		if (MappingSkillID != 0)
		{
			num ^= MappingSkillID.GetHashCode();
		}
		num ^= unitResIDList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (OnlyManualLock != EGSYesNo.No)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)OnlyManualLock);
		}
		if (MappingSkillID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MappingSkillID);
		}
		unitResIDList_.WriteTo(output, _repeated_unitResIDList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (OnlyManualLock != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OnlyManualLock);
		}
		if (MappingSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MappingSkillID);
		}
		num += unitResIDList_.CalculateSize(_repeated_unitResIDList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CastSkillLockRuleInfo other)
	{
		if (other != null)
		{
			if (other.OnlyManualLock != EGSYesNo.No)
			{
				OnlyManualLock = other.OnlyManualLock;
			}
			if (other.MappingSkillID != 0)
			{
				MappingSkillID = other.MappingSkillID;
			}
			unitResIDList_.Add(other.unitResIDList_);
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
				OnlyManualLock = (EGSYesNo)input.ReadEnum();
				break;
			case 16u:
				MappingSkillID = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				unitResIDList_.AddEntriesFrom(input, _repeated_unitResIDList_codec);
				break;
			}
		}
	}
}
