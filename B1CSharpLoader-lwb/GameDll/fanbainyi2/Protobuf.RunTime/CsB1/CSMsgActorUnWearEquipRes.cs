using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnWearEquipRes : IMessage<CSMsgActorUnWearEquipRes>, IMessage, IEquatable<CSMsgActorUnWearEquipRes>, IDeepCloneable<CSMsgActorUnWearEquipRes>
{
	private static readonly MessageParser<CSMsgActorUnWearEquipRes> _parser = new MessageParser<CSMsgActorUnWearEquipRes>(() => new CSMsgActorUnWearEquipRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorUnWearEquipRes> Parser => _parser;

	public CSMsgActorUnWearEquipRes()
	{
	}

	public CSMsgActorUnWearEquipRes(CSMsgActorUnWearEquipRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnWearEquipRes Clone()
	{
		return new CSMsgActorUnWearEquipRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnWearEquipRes);
	}

	public bool Equals(CSMsgActorUnWearEquipRes other)
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

	public void MergeFrom(CSMsgActorUnWearEquipRes other)
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
