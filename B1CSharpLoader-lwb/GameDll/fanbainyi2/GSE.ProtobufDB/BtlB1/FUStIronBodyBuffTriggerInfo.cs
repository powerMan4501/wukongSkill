using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStIronBodyBuffTriggerInfo : IMessage<FUStIronBodyBuffTriggerInfo>, IMessage, IEquatable<FUStIronBodyBuffTriggerInfo>, IDeepCloneable<FUStIronBodyBuffTriggerInfo>
{
	private static readonly MessageParser<FUStIronBodyBuffTriggerInfo> _parser = new MessageParser<FUStIronBodyBuffTriggerInfo>(() => new FUStIronBodyBuffTriggerInfo());

	private UnknownFieldSet _unknownFields;

	private int buffID_;

	private FUStIronBodyBuffTarget ironBodyBuffTarget_;

	public static MessageParser<FUStIronBodyBuffTriggerInfo> Parser => _parser;

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

	public FUStIronBodyBuffTarget IronBodyBuffTarget
	{
		get
		{
			return ironBodyBuffTarget_;
		}
		set
		{
			ironBodyBuffTarget_ = value;
		}
	}

	public FUStIronBodyBuffTriggerInfo()
	{
	}

	public FUStIronBodyBuffTriggerInfo(FUStIronBodyBuffTriggerInfo other)
		: this()
	{
		buffID_ = other.buffID_;
		ironBodyBuffTarget_ = other.ironBodyBuffTarget_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStIronBodyBuffTriggerInfo Clone()
	{
		return new FUStIronBodyBuffTriggerInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStIronBodyBuffTriggerInfo);
	}

	public bool Equals(FUStIronBodyBuffTriggerInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffID != other.BuffID)
		{
			return false;
		}
		if (IronBodyBuffTarget != other.IronBodyBuffTarget)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BuffID != 0)
		{
			num ^= BuffID.GetHashCode();
		}
		if (IronBodyBuffTarget != FUStIronBodyBuffTarget.Attacker)
		{
			num ^= IronBodyBuffTarget.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BuffID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuffID);
		}
		if (IronBodyBuffTarget != FUStIronBodyBuffTarget.Attacker)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IronBodyBuffTarget);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffID);
		}
		if (IronBodyBuffTarget != FUStIronBodyBuffTarget.Attacker)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IronBodyBuffTarget);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStIronBodyBuffTriggerInfo other)
	{
		if (other != null)
		{
			if (other.BuffID != 0)
			{
				BuffID = other.BuffID;
			}
			if (other.IronBodyBuffTarget != FUStIronBodyBuffTarget.Attacker)
			{
				IronBodyBuffTarget = other.IronBodyBuffTarget;
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
				BuffID = input.ReadInt32();
				break;
			case 16u:
				IronBodyBuffTarget = (FUStIronBodyBuffTarget)input.ReadEnum();
				break;
			}
		}
	}
}
