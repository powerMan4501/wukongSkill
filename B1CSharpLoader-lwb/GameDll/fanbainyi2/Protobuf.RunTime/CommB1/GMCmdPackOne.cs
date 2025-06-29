using System;
using Google.Protobuf;

namespace CommB1;

public sealed class GMCmdPackOne : IMessage<GMCmdPackOne>, IMessage, IEquatable<GMCmdPackOne>, IDeepCloneable<GMCmdPackOne>
{
	private static readonly MessageParser<GMCmdPackOne> _parser = new MessageParser<GMCmdPackOne>(() => new GMCmdPackOne());

	private UnknownFieldSet _unknownFields;

	private int index_;

	private string name_ = "";

	private bool autoRun_;

	private string command_ = "";

	public static MessageParser<GMCmdPackOne> Parser => _parser;

	public int Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool AutoRun
	{
		get
		{
			return autoRun_;
		}
		set
		{
			autoRun_ = value;
		}
	}

	public string Command
	{
		get
		{
			return command_;
		}
		set
		{
			command_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GMCmdPackOne()
	{
	}

	public GMCmdPackOne(GMCmdPackOne other)
		: this()
	{
		index_ = other.index_;
		name_ = other.name_;
		autoRun_ = other.autoRun_;
		command_ = other.command_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GMCmdPackOne Clone()
	{
		return new GMCmdPackOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GMCmdPackOne);
	}

	public bool Equals(GMCmdPackOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (AutoRun != other.AutoRun)
		{
			return false;
		}
		if (Command != other.Command)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (AutoRun)
		{
			num ^= AutoRun.GetHashCode();
		}
		if (Command.Length != 0)
		{
			num ^= Command.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Index != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Index);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (AutoRun)
		{
			output.WriteRawTag(24);
			output.WriteBool(AutoRun);
		}
		if (Command.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Command);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Index);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (AutoRun)
		{
			num += 2;
		}
		if (Command.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Command);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GMCmdPackOne other)
	{
		if (other != null)
		{
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.AutoRun)
			{
				AutoRun = other.AutoRun;
			}
			if (other.Command.Length != 0)
			{
				Command = other.Command;
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
				Index = input.ReadInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				AutoRun = input.ReadBool();
				break;
			case 34u:
				Command = input.ReadString();
				break;
			}
		}
	}
}
