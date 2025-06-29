using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_EnterAction : IMessage<ProcessStateCustom_EnterAction>, IMessage, IEquatable<ProcessStateCustom_EnterAction>, IDeepCloneable<ProcessStateCustom_EnterAction>
{
	private static readonly MessageParser<ProcessStateCustom_EnterAction> _parser = new MessageParser<ProcessStateCustom_EnterAction>(() => new ProcessStateCustom_EnterAction());

	private UnknownFieldSet _unknownFields;

	private bool isOverrideParent_;

	public static MessageParser<ProcessStateCustom_EnterAction> Parser => _parser;

	public bool IsOverrideParent
	{
		get
		{
			return isOverrideParent_;
		}
		set
		{
			isOverrideParent_ = value;
		}
	}

	public ProcessStateCustom_EnterAction()
	{
	}

	public ProcessStateCustom_EnterAction(ProcessStateCustom_EnterAction other)
		: this()
	{
		isOverrideParent_ = other.isOverrideParent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_EnterAction Clone()
	{
		return new ProcessStateCustom_EnterAction(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_EnterAction);
	}

	public bool Equals(ProcessStateCustom_EnterAction other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsOverrideParent != other.IsOverrideParent)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsOverrideParent)
		{
			num ^= IsOverrideParent.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsOverrideParent)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsOverrideParent);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsOverrideParent)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessStateCustom_EnterAction other)
	{
		if (other != null)
		{
			if (other.IsOverrideParent)
			{
				IsOverrideParent = other.IsOverrideParent;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				IsOverrideParent = input.ReadBool();
			}
		}
	}
}
