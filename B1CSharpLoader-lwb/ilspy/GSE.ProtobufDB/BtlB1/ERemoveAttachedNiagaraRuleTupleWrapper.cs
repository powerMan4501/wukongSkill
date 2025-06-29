using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class ERemoveAttachedNiagaraRuleTupleWrapper : IMessage<ERemoveAttachedNiagaraRuleTupleWrapper>, IMessage, IEquatable<ERemoveAttachedNiagaraRuleTupleWrapper>, IDeepCloneable<ERemoveAttachedNiagaraRuleTupleWrapper>
{
	private static readonly MessageParser<ERemoveAttachedNiagaraRuleTupleWrapper> _parser = new MessageParser<ERemoveAttachedNiagaraRuleTupleWrapper>(() => new ERemoveAttachedNiagaraRuleTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ERemoveAttachedNiagaraRule item1_;

	private ERemoveAttachedNiagaraRule item2_;

	public static MessageParser<ERemoveAttachedNiagaraRuleTupleWrapper> Parser => _parser;

	public ERemoveAttachedNiagaraRule Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public ERemoveAttachedNiagaraRule Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public ERemoveAttachedNiagaraRuleTupleWrapper()
	{
	}

	public ERemoveAttachedNiagaraRuleTupleWrapper(ERemoveAttachedNiagaraRuleTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ERemoveAttachedNiagaraRuleTupleWrapper Clone()
	{
		return new ERemoveAttachedNiagaraRuleTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ERemoveAttachedNiagaraRuleTupleWrapper);
	}

	public bool Equals(ERemoveAttachedNiagaraRuleTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != ERemoveAttachedNiagaraRule.Stack)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ERemoveAttachedNiagaraRule.Stack)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != ERemoveAttachedNiagaraRule.Stack)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ERemoveAttachedNiagaraRule.Stack)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != ERemoveAttachedNiagaraRule.Stack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ERemoveAttachedNiagaraRule.Stack)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ERemoveAttachedNiagaraRuleTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ERemoveAttachedNiagaraRule.Stack)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ERemoveAttachedNiagaraRule.Stack)
			{
				Item2 = other.Item2;
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
				Item1 = (ERemoveAttachedNiagaraRule)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ERemoveAttachedNiagaraRule)input.ReadEnum();
				break;
			}
		}
	}
}
