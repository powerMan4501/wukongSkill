using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BUC_LifeSavingData : IMessage<BUC_LifeSavingData>, IMessage, IEquatable<BUC_LifeSavingData>, IDeepCloneable<BUC_LifeSavingData>
{
	private static readonly MessageParser<BUC_LifeSavingData> _parser = new MessageParser<BUC_LifeSavingData>(() => new BUC_LifeSavingData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float coolDownRemainTimerRemoved_;

	public static MessageParser<BUC_LifeSavingData> Parser => _parser;

	public float CoolDownRemainTimerRemoved
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return coolDownRemainTimerRemoved_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			coolDownRemainTimerRemoved_ = value;
		}
	}

	public bool HasCoolDownRemainTimerRemoved => (_hasBits0 & 1) != 0;

	public BUC_LifeSavingData()
	{
	}

	public BUC_LifeSavingData(BUC_LifeSavingData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		coolDownRemainTimerRemoved_ = other.coolDownRemainTimerRemoved_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BUC_LifeSavingData Clone()
	{
		return new BUC_LifeSavingData(this);
	}

	public void ClearCoolDownRemainTimerRemoved()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BUC_LifeSavingData);
	}

	public bool Equals(BUC_LifeSavingData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CoolDownRemainTimerRemoved, other.CoolDownRemainTimerRemoved))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasCoolDownRemainTimerRemoved)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CoolDownRemainTimerRemoved);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasCoolDownRemainTimerRemoved)
		{
			output.WriteRawTag(13);
			output.WriteFloat(CoolDownRemainTimerRemoved);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasCoolDownRemainTimerRemoved)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BUC_LifeSavingData other)
	{
		if (other != null)
		{
			if (other.HasCoolDownRemainTimerRemoved)
			{
				CoolDownRemainTimerRemoved = other.CoolDownRemainTimerRemoved;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 13)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				CoolDownRemainTimerRemoved = input.ReadFloat();
			}
		}
	}
}
