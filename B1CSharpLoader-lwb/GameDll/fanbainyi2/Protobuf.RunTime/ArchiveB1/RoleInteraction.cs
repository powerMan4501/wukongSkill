using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleInteraction : IMessage<RoleInteraction>, IMessage, IEquatable<RoleInteraction>, IDeepCloneable<RoleInteraction>
{
	private static readonly MessageParser<RoleInteraction> _parser = new MessageParser<RoleInteraction>(() => new RoleInteraction());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<int> _repeated_interactionFuncList_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> interactionFuncList_ = new RepeatedField<int>();

	public static MessageParser<RoleInteraction> Parser => _parser;

	public RepeatedField<int> InteractionFuncList => interactionFuncList_;

	public RoleInteraction()
	{
	}

	public RoleInteraction(RoleInteraction other)
		: this()
	{
		interactionFuncList_ = other.interactionFuncList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleInteraction Clone()
	{
		return new RoleInteraction(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleInteraction);
	}

	public bool Equals(RoleInteraction other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!interactionFuncList_.Equals(other.interactionFuncList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= interactionFuncList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		interactionFuncList_.WriteTo(output, _repeated_interactionFuncList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += interactionFuncList_.CalculateSize(_repeated_interactionFuncList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleInteraction other)
	{
		if (other != null)
		{
			interactionFuncList_.Add(other.interactionFuncList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				interactionFuncList_.AddEntriesFrom(input, _repeated_interactionFuncList_codec);
			}
		}
	}
}
