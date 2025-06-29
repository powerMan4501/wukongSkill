using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BossRushCustom_ServantOverrideProperty : IMessage<BossRushCustom_ServantOverrideProperty>, IMessage, IEquatable<BossRushCustom_ServantOverrideProperty>, IDeepCloneable<BossRushCustom_ServantOverrideProperty>
{
	private static readonly MessageParser<BossRushCustom_ServantOverrideProperty> _parser = new MessageParser<BossRushCustom_ServantOverrideProperty>(() => new BossRushCustom_ServantOverrideProperty());

	private UnknownFieldSet _unknownFields;

	private int summonId_;

	private int extendId_;

	public static MessageParser<BossRushCustom_ServantOverrideProperty> Parser => _parser;

	public int SummonId
	{
		get
		{
			return summonId_;
		}
		set
		{
			summonId_ = value;
		}
	}

	public int ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
		}
	}

	public BossRushCustom_ServantOverrideProperty()
	{
	}

	public BossRushCustom_ServantOverrideProperty(BossRushCustom_ServantOverrideProperty other)
		: this()
	{
		summonId_ = other.summonId_;
		extendId_ = other.extendId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushCustom_ServantOverrideProperty Clone()
	{
		return new BossRushCustom_ServantOverrideProperty(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushCustom_ServantOverrideProperty);
	}

	public bool Equals(BossRushCustom_ServantOverrideProperty other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SummonId != other.SummonId)
		{
			return false;
		}
		if (ExtendId != other.ExtendId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SummonId != 0)
		{
			num ^= SummonId.GetHashCode();
		}
		if (ExtendId != 0)
		{
			num ^= ExtendId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SummonId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SummonId);
		}
		if (ExtendId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ExtendId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SummonId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SummonId);
		}
		if (ExtendId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtendId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushCustom_ServantOverrideProperty other)
	{
		if (other != null)
		{
			if (other.SummonId != 0)
			{
				SummonId = other.SummonId;
			}
			if (other.ExtendId != 0)
			{
				ExtendId = other.ExtendId;
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
				SummonId = input.ReadInt32();
				break;
			case 16u:
				ExtendId = input.ReadInt32();
				break;
			}
		}
	}
}
