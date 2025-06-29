using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PlayerCommandParam : IMessage<PlayerCommandParam>, IMessage, IEquatable<PlayerCommandParam>, IDeepCloneable<PlayerCommandParam>
{
	private static readonly MessageParser<PlayerCommandParam> _parser = new MessageParser<PlayerCommandParam>(() => new PlayerCommandParam());

	private UnknownFieldSet _unknownFields;

	private ulong id_;

	private ulong iparam1_;

	private ulong iparam2_;

	public static MessageParser<PlayerCommandParam> Parser => _parser;

	public ulong Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public ulong Iparam1
	{
		get
		{
			return iparam1_;
		}
		set
		{
			iparam1_ = value;
		}
	}

	public ulong Iparam2
	{
		get
		{
			return iparam2_;
		}
		set
		{
			iparam2_ = value;
		}
	}

	public PlayerCommandParam()
	{
	}

	public PlayerCommandParam(PlayerCommandParam other)
		: this()
	{
		id_ = other.id_;
		iparam1_ = other.iparam1_;
		iparam2_ = other.iparam2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerCommandParam Clone()
	{
		return new PlayerCommandParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerCommandParam);
	}

	public bool Equals(PlayerCommandParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Iparam1 != other.Iparam1)
		{
			return false;
		}
		if (Iparam2 != other.Iparam2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0L)
		{
			num ^= Id.GetHashCode();
		}
		if (Iparam1 != 0L)
		{
			num ^= Iparam1.GetHashCode();
		}
		if (Iparam2 != 0L)
		{
			num ^= Iparam2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(Id);
		}
		if (Iparam1 != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Iparam1);
		}
		if (Iparam2 != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(Iparam2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Id);
		}
		if (Iparam1 != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Iparam1);
		}
		if (Iparam2 != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Iparam2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerCommandParam other)
	{
		if (other != null)
		{
			if (other.Id != 0L)
			{
				Id = other.Id;
			}
			if (other.Iparam1 != 0L)
			{
				Iparam1 = other.Iparam1;
			}
			if (other.Iparam2 != 0L)
			{
				Iparam2 = other.Iparam2;
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
				Id = input.ReadUInt64();
				break;
			case 16u:
				Iparam1 = input.ReadUInt64();
				break;
			case 24u:
				Iparam2 = input.ReadUInt64();
				break;
			}
		}
	}
}
