using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStCCGCastSkillMappingRuleDesc : IMessage<FUStCCGCastSkillMappingRuleDesc>, IMessage, IEquatable<FUStCCGCastSkillMappingRuleDesc>, IDeepCloneable<FUStCCGCastSkillMappingRuleDesc>
{
	private static readonly MessageParser<FUStCCGCastSkillMappingRuleDesc> _parser = new MessageParser<FUStCCGCastSkillMappingRuleDesc>(() => new FUStCCGCastSkillMappingRuleDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private CastSkillLockRuleInfo lockRuleInfo_;

	private string guard_ = "";

	public static MessageParser<FUStCCGCastSkillMappingRuleDesc> Parser => _parser;

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

	public CastSkillLockRuleInfo LockRuleInfo
	{
		get
		{
			return lockRuleInfo_;
		}
		set
		{
			lockRuleInfo_ = value;
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

	public FUStCCGCastSkillMappingRuleDesc()
	{
	}

	public FUStCCGCastSkillMappingRuleDesc(FUStCCGCastSkillMappingRuleDesc other)
		: this()
	{
		iD_ = other.iD_;
		lockRuleInfo_ = ((other.lockRuleInfo_ != null) ? other.lockRuleInfo_.Clone() : null);
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStCCGCastSkillMappingRuleDesc Clone()
	{
		return new FUStCCGCastSkillMappingRuleDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStCCGCastSkillMappingRuleDesc);
	}

	public bool Equals(FUStCCGCastSkillMappingRuleDesc other)
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
		if (!object.Equals(LockRuleInfo, other.LockRuleInfo))
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
		if (lockRuleInfo_ != null)
		{
			num ^= LockRuleInfo.GetHashCode();
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
		if (lockRuleInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(LockRuleInfo);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(26);
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
		if (lockRuleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LockRuleInfo);
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

	public void MergeFrom(FUStCCGCastSkillMappingRuleDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.lockRuleInfo_ != null)
		{
			if (lockRuleInfo_ == null)
			{
				LockRuleInfo = new CastSkillLockRuleInfo();
			}
			LockRuleInfo.MergeFrom(other.LockRuleInfo);
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
			case 18u:
				if (lockRuleInfo_ == null)
				{
					LockRuleInfo = new CastSkillLockRuleInfo();
				}
				input.ReadMessage(LockRuleInfo);
				break;
			case 26u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
