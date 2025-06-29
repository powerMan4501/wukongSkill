using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_StateNodeChildActorControlJJSObstacle : IMessage<CalliopeCustom_StateNodeChildActorControlJJSObstacle>, IMessage, IEquatable<CalliopeCustom_StateNodeChildActorControlJJSObstacle>, IDeepCloneable<CalliopeCustom_StateNodeChildActorControlJJSObstacle>
{
	private static readonly MessageParser<CalliopeCustom_StateNodeChildActorControlJJSObstacle> _parser = new MessageParser<CalliopeCustom_StateNodeChildActorControlJJSObstacle>(() => new CalliopeCustom_StateNodeChildActorControlJJSObstacle());

	private UnknownFieldSet _unknownFields;

	private string nickname_ = "";

	private int state_;

	public static MessageParser<CalliopeCustom_StateNodeChildActorControlJJSObstacle> Parser => _parser;

	public string Nickname
	{
		get
		{
			return nickname_;
		}
		set
		{
			nickname_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	public CalliopeCustom_StateNodeChildActorControlJJSObstacle()
	{
	}

	public CalliopeCustom_StateNodeChildActorControlJJSObstacle(CalliopeCustom_StateNodeChildActorControlJJSObstacle other)
		: this()
	{
		nickname_ = other.nickname_;
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_StateNodeChildActorControlJJSObstacle Clone()
	{
		return new CalliopeCustom_StateNodeChildActorControlJJSObstacle(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_StateNodeChildActorControlJJSObstacle);
	}

	public bool Equals(CalliopeCustom_StateNodeChildActorControlJJSObstacle other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Nickname != other.Nickname)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Nickname.Length != 0)
		{
			num ^= Nickname.GetHashCode();
		}
		if (State != 0)
		{
			num ^= State.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Nickname.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Nickname);
		}
		if (State != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(State);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Nickname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nickname);
		}
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_StateNodeChildActorControlJJSObstacle other)
	{
		if (other != null)
		{
			if (other.Nickname.Length != 0)
			{
				Nickname = other.Nickname;
			}
			if (other.State != 0)
			{
				State = other.State;
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
			case 10u:
				Nickname = input.ReadString();
				break;
			case 16u:
				State = input.ReadInt32();
				break;
			}
		}
	}
}
