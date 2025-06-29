using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class PartyBattleMsg_PlayerLoc : IMessage<PartyBattleMsg_PlayerLoc>, IMessage, IEquatable<PartyBattleMsg_PlayerLoc>, IDeepCloneable<PartyBattleMsg_PlayerLoc>
{
	private static readonly MessageParser<PartyBattleMsg_PlayerLoc> _parser = new MessageParser<PartyBattleMsg_PlayerLoc>(() => new PartyBattleMsg_PlayerLoc());

	private UnknownFieldSet _unknownFields;

	private float posX_;

	private float posY_;

	private float posZ_;

	private bool isTeleport_;

	private string memberId_ = "";

	private bool needBack_;

	public static MessageParser<PartyBattleMsg_PlayerLoc> Parser => _parser;

	public float PosX
	{
		get
		{
			return posX_;
		}
		set
		{
			posX_ = value;
		}
	}

	public float PosY
	{
		get
		{
			return posY_;
		}
		set
		{
			posY_ = value;
		}
	}

	public float PosZ
	{
		get
		{
			return posZ_;
		}
		set
		{
			posZ_ = value;
		}
	}

	public bool IsTeleport
	{
		get
		{
			return isTeleport_;
		}
		set
		{
			isTeleport_ = value;
		}
	}

	public string MemberId
	{
		get
		{
			return memberId_;
		}
		set
		{
			memberId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool NeedBack
	{
		get
		{
			return needBack_;
		}
		set
		{
			needBack_ = value;
		}
	}

	public PartyBattleMsg_PlayerLoc()
	{
	}

	public PartyBattleMsg_PlayerLoc(PartyBattleMsg_PlayerLoc other)
		: this()
	{
		posX_ = other.posX_;
		posY_ = other.posY_;
		posZ_ = other.posZ_;
		isTeleport_ = other.isTeleport_;
		memberId_ = other.memberId_;
		needBack_ = other.needBack_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyBattleMsg_PlayerLoc Clone()
	{
		return new PartyBattleMsg_PlayerLoc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyBattleMsg_PlayerLoc);
	}

	public bool Equals(PartyBattleMsg_PlayerLoc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosX, other.PosX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosY, other.PosY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PosZ, other.PosZ))
		{
			return false;
		}
		if (IsTeleport != other.IsTeleport)
		{
			return false;
		}
		if (MemberId != other.MemberId)
		{
			return false;
		}
		if (NeedBack != other.NeedBack)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PosX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosX);
		}
		if (PosY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosY);
		}
		if (PosZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PosZ);
		}
		if (IsTeleport)
		{
			num ^= IsTeleport.GetHashCode();
		}
		if (MemberId.Length != 0)
		{
			num ^= MemberId.GetHashCode();
		}
		if (NeedBack)
		{
			num ^= NeedBack.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PosX != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(PosX);
		}
		if (PosY != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(PosY);
		}
		if (PosZ != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(PosZ);
		}
		if (IsTeleport)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsTeleport);
		}
		if (MemberId.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(MemberId);
		}
		if (NeedBack)
		{
			output.WriteRawTag(48);
			output.WriteBool(NeedBack);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PosX != 0f)
		{
			num += 5;
		}
		if (PosY != 0f)
		{
			num += 5;
		}
		if (PosZ != 0f)
		{
			num += 5;
		}
		if (IsTeleport)
		{
			num += 2;
		}
		if (MemberId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MemberId);
		}
		if (NeedBack)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyBattleMsg_PlayerLoc other)
	{
		if (other != null)
		{
			if (other.PosX != 0f)
			{
				PosX = other.PosX;
			}
			if (other.PosY != 0f)
			{
				PosY = other.PosY;
			}
			if (other.PosZ != 0f)
			{
				PosZ = other.PosZ;
			}
			if (other.IsTeleport)
			{
				IsTeleport = other.IsTeleport;
			}
			if (other.MemberId.Length != 0)
			{
				MemberId = other.MemberId;
			}
			if (other.NeedBack)
			{
				NeedBack = other.NeedBack;
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
			case 13u:
				PosX = input.ReadFloat();
				break;
			case 21u:
				PosY = input.ReadFloat();
				break;
			case 29u:
				PosZ = input.ReadFloat();
				break;
			case 32u:
				IsTeleport = input.ReadBool();
				break;
			case 42u:
				MemberId = input.ReadString();
				break;
			case 48u:
				NeedBack = input.ReadBool();
				break;
			}
		}
	}
}
