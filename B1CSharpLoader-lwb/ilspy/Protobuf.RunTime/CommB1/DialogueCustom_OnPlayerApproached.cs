using System;
using Google.Protobuf;

namespace CommB1;

public sealed class DialogueCustom_OnPlayerApproached : IMessage<DialogueCustom_OnPlayerApproached>, IMessage, IEquatable<DialogueCustom_OnPlayerApproached>, IDeepCloneable<DialogueCustom_OnPlayerApproached>
{
	private static readonly MessageParser<DialogueCustom_OnPlayerApproached> _parser = new MessageParser<DialogueCustom_OnPlayerApproached>(() => new DialogueCustom_OnPlayerApproached());

	private UnknownFieldSet _unknownFields;

	private int resId_;

	public static MessageParser<DialogueCustom_OnPlayerApproached> Parser => _parser;

	public int ResId
	{
		get
		{
			return resId_;
		}
		set
		{
			resId_ = value;
		}
	}

	public DialogueCustom_OnPlayerApproached()
	{
	}

	public DialogueCustom_OnPlayerApproached(DialogueCustom_OnPlayerApproached other)
		: this()
	{
		resId_ = other.resId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DialogueCustom_OnPlayerApproached Clone()
	{
		return new DialogueCustom_OnPlayerApproached(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DialogueCustom_OnPlayerApproached);
	}

	public bool Equals(DialogueCustom_OnPlayerApproached other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ResId != other.ResId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ResId != 0)
		{
			num ^= ResId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ResId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ResId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ResId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DialogueCustom_OnPlayerApproached other)
	{
		if (other != null)
		{
			if (other.ResId != 0)
			{
				ResId = other.ResId;
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
				ResId = input.ReadInt32();
			}
		}
	}
}
