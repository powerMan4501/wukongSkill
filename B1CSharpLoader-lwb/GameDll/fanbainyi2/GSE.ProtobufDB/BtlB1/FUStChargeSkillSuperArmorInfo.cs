using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStChargeSkillSuperArmorInfo : IMessage<FUStChargeSkillSuperArmorInfo>, IMessage, IEquatable<FUStChargeSkillSuperArmorInfo>, IDeepCloneable<FUStChargeSkillSuperArmorInfo>
{
	private static readonly MessageParser<FUStChargeSkillSuperArmorInfo> _parser = new MessageParser<FUStChargeSkillSuperArmorInfo>(() => new FUStChargeSkillSuperArmorInfo());

	private UnknownFieldSet _unknownFields;

	private EGSYesNo hasSuperArmor_;

	private float beginTimeInBeginStage_;

	private float endTimeInEndStage_;

	private float skillSuperArmorValue_;

	private string sSABreakAssignedAnim_ = "";

	public static MessageParser<FUStChargeSkillSuperArmorInfo> Parser => _parser;

	public EGSYesNo HasSuperArmor
	{
		get
		{
			return hasSuperArmor_;
		}
		set
		{
			hasSuperArmor_ = value;
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

	public float SkillSuperArmorValue
	{
		get
		{
			return skillSuperArmorValue_;
		}
		set
		{
			skillSuperArmorValue_ = value;
		}
	}

	public string SSABreakAssignedAnim
	{
		get
		{
			return sSABreakAssignedAnim_;
		}
		set
		{
			sSABreakAssignedAnim_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStChargeSkillSuperArmorInfo()
	{
	}

	public FUStChargeSkillSuperArmorInfo(FUStChargeSkillSuperArmorInfo other)
		: this()
	{
		hasSuperArmor_ = other.hasSuperArmor_;
		beginTimeInBeginStage_ = other.beginTimeInBeginStage_;
		endTimeInEndStage_ = other.endTimeInEndStage_;
		skillSuperArmorValue_ = other.skillSuperArmorValue_;
		sSABreakAssignedAnim_ = other.sSABreakAssignedAnim_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStChargeSkillSuperArmorInfo Clone()
	{
		return new FUStChargeSkillSuperArmorInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStChargeSkillSuperArmorInfo);
	}

	public bool Equals(FUStChargeSkillSuperArmorInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HasSuperArmor != other.HasSuperArmor)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SkillSuperArmorValue, other.SkillSuperArmorValue))
		{
			return false;
		}
		if (SSABreakAssignedAnim != other.SSABreakAssignedAnim)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasSuperArmor != EGSYesNo.No)
		{
			num ^= HasSuperArmor.GetHashCode();
		}
		if (BeginTimeInBeginStage != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BeginTimeInBeginStage);
		}
		if (EndTimeInEndStage != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EndTimeInEndStage);
		}
		if (SkillSuperArmorValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SkillSuperArmorValue);
		}
		if (SSABreakAssignedAnim.Length != 0)
		{
			num ^= SSABreakAssignedAnim.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasSuperArmor != EGSYesNo.No)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)HasSuperArmor);
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
		if (SkillSuperArmorValue != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(SkillSuperArmorValue);
		}
		if (SSABreakAssignedAnim.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(SSABreakAssignedAnim);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasSuperArmor != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HasSuperArmor);
		}
		if (BeginTimeInBeginStage != 0f)
		{
			num += 5;
		}
		if (EndTimeInEndStage != 0f)
		{
			num += 5;
		}
		if (SkillSuperArmorValue != 0f)
		{
			num += 5;
		}
		if (SSABreakAssignedAnim.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SSABreakAssignedAnim);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStChargeSkillSuperArmorInfo other)
	{
		if (other != null)
		{
			if (other.HasSuperArmor != EGSYesNo.No)
			{
				HasSuperArmor = other.HasSuperArmor;
			}
			if (other.BeginTimeInBeginStage != 0f)
			{
				BeginTimeInBeginStage = other.BeginTimeInBeginStage;
			}
			if (other.EndTimeInEndStage != 0f)
			{
				EndTimeInEndStage = other.EndTimeInEndStage;
			}
			if (other.SkillSuperArmorValue != 0f)
			{
				SkillSuperArmorValue = other.SkillSuperArmorValue;
			}
			if (other.SSABreakAssignedAnim.Length != 0)
			{
				SSABreakAssignedAnim = other.SSABreakAssignedAnim;
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
				HasSuperArmor = (EGSYesNo)input.ReadEnum();
				break;
			case 21u:
				BeginTimeInBeginStage = input.ReadFloat();
				break;
			case 29u:
				EndTimeInEndStage = input.ReadFloat();
				break;
			case 37u:
				SkillSuperArmorValue = input.ReadFloat();
				break;
			case 42u:
				SSABreakAssignedAnim = input.ReadString();
				break;
			}
		}
	}
}
