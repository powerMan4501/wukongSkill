using System;
using Google.Protobuf;

namespace ResB1;

public sealed class MultiplayerDropRuleDesc : IMessage<MultiplayerDropRuleDesc>, IMessage, IEquatable<MultiplayerDropRuleDesc>, IDeepCloneable<MultiplayerDropRuleDesc>
{
	private static readonly MessageParser<MultiplayerDropRuleDesc> _parser = new MessageParser<MultiplayerDropRuleDesc>(() => new MultiplayerDropRuleDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int specialDropNum_;

	private int specialDropId_;

	private int commonDropId_;

	public static MessageParser<MultiplayerDropRuleDesc> Parser => _parser;

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

	public int SpecialDropNum
	{
		get
		{
			return specialDropNum_;
		}
		set
		{
			specialDropNum_ = value;
		}
	}

	public int SpecialDropId
	{
		get
		{
			return specialDropId_;
		}
		set
		{
			specialDropId_ = value;
		}
	}

	public int CommonDropId
	{
		get
		{
			return commonDropId_;
		}
		set
		{
			commonDropId_ = value;
		}
	}

	public MultiplayerDropRuleDesc()
	{
	}

	public MultiplayerDropRuleDesc(MultiplayerDropRuleDesc other)
		: this()
	{
		id_ = other.id_;
		specialDropNum_ = other.specialDropNum_;
		specialDropId_ = other.specialDropId_;
		commonDropId_ = other.commonDropId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MultiplayerDropRuleDesc Clone()
	{
		return new MultiplayerDropRuleDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MultiplayerDropRuleDesc);
	}

	public bool Equals(MultiplayerDropRuleDesc other)
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
		if (SpecialDropNum != other.SpecialDropNum)
		{
			return false;
		}
		if (SpecialDropId != other.SpecialDropId)
		{
			return false;
		}
		if (CommonDropId != other.CommonDropId)
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
		if (SpecialDropNum != 0)
		{
			num ^= SpecialDropNum.GetHashCode();
		}
		if (SpecialDropId != 0)
		{
			num ^= SpecialDropId.GetHashCode();
		}
		if (CommonDropId != 0)
		{
			num ^= CommonDropId.GetHashCode();
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
		if (SpecialDropNum != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SpecialDropNum);
		}
		if (SpecialDropId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SpecialDropId);
		}
		if (CommonDropId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CommonDropId);
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
		if (SpecialDropNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpecialDropNum);
		}
		if (SpecialDropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpecialDropId);
		}
		if (CommonDropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CommonDropId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MultiplayerDropRuleDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SpecialDropNum != 0)
			{
				SpecialDropNum = other.SpecialDropNum;
			}
			if (other.SpecialDropId != 0)
			{
				SpecialDropId = other.SpecialDropId;
			}
			if (other.CommonDropId != 0)
			{
				CommonDropId = other.CommonDropId;
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
				SpecialDropNum = input.ReadInt32();
				break;
			case 24u:
				SpecialDropId = input.ReadInt32();
				break;
			case 32u:
				CommonDropId = input.ReadInt32();
				break;
			}
		}
	}
}
