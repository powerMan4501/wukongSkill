using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class ERemoveAttachedNiagaraRuleSyncWrapper : IMessage<ERemoveAttachedNiagaraRuleSyncWrapper>, IMessage, IEquatable<ERemoveAttachedNiagaraRuleSyncWrapper>, IDeepCloneable<ERemoveAttachedNiagaraRuleSyncWrapper>
{
	private static readonly MessageParser<ERemoveAttachedNiagaraRuleSyncWrapper> _parser = new MessageParser<ERemoveAttachedNiagaraRuleSyncWrapper>(() => new ERemoveAttachedNiagaraRuleSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private ERemoveAttachedNiagaraRule value_;

	public static MessageParser<ERemoveAttachedNiagaraRuleSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public ERemoveAttachedNiagaraRule Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public ERemoveAttachedNiagaraRuleSyncWrapper()
	{
	}

	public ERemoveAttachedNiagaraRuleSyncWrapper(ERemoveAttachedNiagaraRuleSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ERemoveAttachedNiagaraRuleSyncWrapper Clone()
	{
		return new ERemoveAttachedNiagaraRuleSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ERemoveAttachedNiagaraRuleSyncWrapper);
	}

	public bool Equals(ERemoveAttachedNiagaraRuleSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (Value != other.Value)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (Value != ERemoveAttachedNiagaraRule.Stack)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (Value != ERemoveAttachedNiagaraRule.Stack)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (Value != ERemoveAttachedNiagaraRule.Stack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ERemoveAttachedNiagaraRuleSyncWrapper other)
	{
		if (other != null)
		{
			if (other.SyncFlag != 0)
			{
				SyncFlag = other.SyncFlag;
			}
			if (other.SyncIdx != 0)
			{
				SyncIdx = other.SyncIdx;
			}
			if (other.Value != ERemoveAttachedNiagaraRule.Stack)
			{
				Value = other.Value;
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 24u:
				Value = (ERemoveAttachedNiagaraRule)input.ReadEnum();
				break;
			}
		}
	}
}
