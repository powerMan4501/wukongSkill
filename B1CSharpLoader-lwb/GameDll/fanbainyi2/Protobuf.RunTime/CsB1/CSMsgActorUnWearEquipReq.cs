using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnWearEquipReq : IMessage<CSMsgActorUnWearEquipReq>, IMessage, IEquatable<CSMsgActorUnWearEquipReq>, IDeepCloneable<CSMsgActorUnWearEquipReq>
{
	private static readonly MessageParser<CSMsgActorUnWearEquipReq> _parser = new MessageParser<CSMsgActorUnWearEquipReq>(() => new CSMsgActorUnWearEquipReq());

	private UnknownFieldSet _unknownFields;

	private ulong equipUid_;

	public static MessageParser<CSMsgActorUnWearEquipReq> Parser => _parser;

	public ulong EquipUid
	{
		get
		{
			return equipUid_;
		}
		set
		{
			equipUid_ = value;
		}
	}

	public CSMsgActorUnWearEquipReq()
	{
	}

	public CSMsgActorUnWearEquipReq(CSMsgActorUnWearEquipReq other)
		: this()
	{
		equipUid_ = other.equipUid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnWearEquipReq Clone()
	{
		return new CSMsgActorUnWearEquipReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnWearEquipReq);
	}

	public bool Equals(CSMsgActorUnWearEquipReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EquipUid != other.EquipUid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EquipUid != 0L)
		{
			num ^= EquipUid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EquipUid != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(EquipUid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EquipUid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EquipUid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorUnWearEquipReq other)
	{
		if (other != null)
		{
			if (other.EquipUid != 0L)
			{
				EquipUid = other.EquipUid;
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
				EquipUid = input.ReadUInt64();
			}
		}
	}
}
