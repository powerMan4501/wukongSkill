using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_HandleBattleMessage : IMessage<BehaviorCustom_HandleBattleMessage>, IMessage, IEquatable<BehaviorCustom_HandleBattleMessage>, IDeepCloneable<BehaviorCustom_HandleBattleMessage>
{
	private static readonly MessageParser<BehaviorCustom_HandleBattleMessage> _parser = new MessageParser<BehaviorCustom_HandleBattleMessage>(() => new BehaviorCustom_HandleBattleMessage());

	private UnknownFieldSet _unknownFields;

	private string messageContent_ = "";

	public static MessageParser<BehaviorCustom_HandleBattleMessage> Parser => _parser;

	public string MessageContent
	{
		get
		{
			return messageContent_;
		}
		set
		{
			messageContent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_HandleBattleMessage()
	{
	}

	public BehaviorCustom_HandleBattleMessage(BehaviorCustom_HandleBattleMessage other)
		: this()
	{
		messageContent_ = other.messageContent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_HandleBattleMessage Clone()
	{
		return new BehaviorCustom_HandleBattleMessage(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_HandleBattleMessage);
	}

	public bool Equals(BehaviorCustom_HandleBattleMessage other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MessageContent != other.MessageContent)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MessageContent.Length != 0)
		{
			num ^= MessageContent.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MessageContent.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(MessageContent);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MessageContent.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MessageContent);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_HandleBattleMessage other)
	{
		if (other != null)
		{
			if (other.MessageContent.Length != 0)
			{
				MessageContent = other.MessageContent;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				MessageContent = input.ReadString();
			}
		}
	}
}
