using System;
using Google.Protobuf;

namespace CommB1;

public sealed class AwolMsgPlayerCommand : IMessage<AwolMsgPlayerCommand>, IMessage, IEquatable<AwolMsgPlayerCommand>, IDeepCloneable<AwolMsgPlayerCommand>
{
	private static readonly MessageParser<AwolMsgPlayerCommand> _parser = new MessageParser<AwolMsgPlayerCommand>(() => new AwolMsgPlayerCommand());

	private UnknownFieldSet _unknownFields;

	private PlayerCommandType cmdType_;

	private PlayerCommandParam param_;

	public static MessageParser<AwolMsgPlayerCommand> Parser => _parser;

	public PlayerCommandType CmdType
	{
		get
		{
			return cmdType_;
		}
		set
		{
			cmdType_ = value;
		}
	}

	public PlayerCommandParam Param
	{
		get
		{
			return param_;
		}
		set
		{
			param_ = value;
		}
	}

	public AwolMsgPlayerCommand()
	{
	}

	public AwolMsgPlayerCommand(AwolMsgPlayerCommand other)
		: this()
	{
		cmdType_ = other.cmdType_;
		param_ = ((other.param_ != null) ? other.param_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AwolMsgPlayerCommand Clone()
	{
		return new AwolMsgPlayerCommand(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AwolMsgPlayerCommand);
	}

	public bool Equals(AwolMsgPlayerCommand other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CmdType != other.CmdType)
		{
			return false;
		}
		if (!object.Equals(Param, other.Param))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CmdType != PlayerCommandType.None)
		{
			num ^= CmdType.GetHashCode();
		}
		if (param_ != null)
		{
			num ^= Param.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CmdType != PlayerCommandType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)CmdType);
		}
		if (param_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Param);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CmdType != PlayerCommandType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CmdType);
		}
		if (param_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Param);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AwolMsgPlayerCommand other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CmdType != PlayerCommandType.None)
		{
			CmdType = other.CmdType;
		}
		if (other.param_ != null)
		{
			if (param_ == null)
			{
				Param = new PlayerCommandParam();
			}
			Param.MergeFrom(other.Param);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				CmdType = (PlayerCommandType)input.ReadEnum();
				break;
			case 18u:
				if (param_ == null)
				{
					Param = new PlayerCommandParam();
				}
				input.ReadMessage(Param);
				break;
			}
		}
	}
}
