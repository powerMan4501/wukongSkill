using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorWearEquipRes : IMessage<CSMsgActorWearEquipRes>, IMessage, IEquatable<CSMsgActorWearEquipRes>, IDeepCloneable<CSMsgActorWearEquipRes>
{
	private static readonly MessageParser<CSMsgActorWearEquipRes> _parser = new MessageParser<CSMsgActorWearEquipRes>(() => new CSMsgActorWearEquipRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorWearEquipRes> Parser => _parser;

	public CSMsgActorWearEquipRes()
	{
	}

	public CSMsgActorWearEquipRes(CSMsgActorWearEquipRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorWearEquipRes Clone()
	{
		return new CSMsgActorWearEquipRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorWearEquipRes);
	}

	public bool Equals(CSMsgActorWearEquipRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorWearEquipRes other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
