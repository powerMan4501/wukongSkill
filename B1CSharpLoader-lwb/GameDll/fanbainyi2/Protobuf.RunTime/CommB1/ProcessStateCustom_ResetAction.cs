using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ProcessStateCustom_ResetAction : IMessage<ProcessStateCustom_ResetAction>, IMessage, IEquatable<ProcessStateCustom_ResetAction>, IDeepCloneable<ProcessStateCustom_ResetAction>
{
	private static readonly MessageParser<ProcessStateCustom_ResetAction> _parser = new MessageParser<ProcessStateCustom_ResetAction>(() => new ProcessStateCustom_ResetAction());

	private UnknownFieldSet _unknownFields;

	private bool isOverrideParent_;

	public static MessageParser<ProcessStateCustom_ResetAction> Parser => _parser;

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

	public ProcessStateCustom_ResetAction()
	{
	}

	public ProcessStateCustom_ResetAction(ProcessStateCustom_ResetAction other)
		: this()
	{
		isOverrideParent_ = other.isOverrideParent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessStateCustom_ResetAction Clone()
	{
		return new ProcessStateCustom_ResetAction(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessStateCustom_ResetAction);
	}

	public bool Equals(ProcessStateCustom_ResetAction other)
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

	public void MergeFrom(ProcessStateCustom_ResetAction other)
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
