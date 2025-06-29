using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_StateNodeChildActorControl : IMessage<CalliopeCustom_StateNodeChildActorControl>, IMessage, IEquatable<CalliopeCustom_StateNodeChildActorControl>, IDeepCloneable<CalliopeCustom_StateNodeChildActorControl>
{
	private static readonly MessageParser<CalliopeCustom_StateNodeChildActorControl> _parser = new MessageParser<CalliopeCustom_StateNodeChildActorControl>(() => new CalliopeCustom_StateNodeChildActorControl());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CalliopeCustom_StateNodeChildActorControlJJSObstacle> _repeated_jjsobstacleCollection_codec = FieldCodec.ForMessage(10u, CalliopeCustom_StateNodeChildActorControlJJSObstacle.Parser);

	private readonly RepeatedField<CalliopeCustom_StateNodeChildActorControlJJSObstacle> jjsobstacleCollection_ = new RepeatedField<CalliopeCustom_StateNodeChildActorControlJJSObstacle>();

	public static MessageParser<CalliopeCustom_StateNodeChildActorControl> Parser => _parser;

	public RepeatedField<CalliopeCustom_StateNodeChildActorControlJJSObstacle> JjsobstacleCollection => jjsobstacleCollection_;

	public CalliopeCustom_StateNodeChildActorControl()
	{
	}

	public CalliopeCustom_StateNodeChildActorControl(CalliopeCustom_StateNodeChildActorControl other)
		: this()
	{
		jjsobstacleCollection_ = other.jjsobstacleCollection_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_StateNodeChildActorControl Clone()
	{
		return new CalliopeCustom_StateNodeChildActorControl(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_StateNodeChildActorControl);
	}

	public bool Equals(CalliopeCustom_StateNodeChildActorControl other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jjsobstacleCollection_.Equals(other.jjsobstacleCollection_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= jjsobstacleCollection_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		jjsobstacleCollection_.WriteTo(output, _repeated_jjsobstacleCollection_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += jjsobstacleCollection_.CalculateSize(_repeated_jjsobstacleCollection_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_StateNodeChildActorControl other)
	{
		if (other != null)
		{
			jjsobstacleCollection_.Add(other.jjsobstacleCollection_);
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
				jjsobstacleCollection_.AddEntriesFrom(input, _repeated_jjsobstacleCollection_codec);
			}
		}
	}
}
