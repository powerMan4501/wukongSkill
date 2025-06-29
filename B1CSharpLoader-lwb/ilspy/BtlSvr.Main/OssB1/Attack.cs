using System;
using Google.Protobuf;

namespace OssB1;

public sealed class Attack : IMessage<Attack>, IMessage, IEquatable<Attack>, IDeepCloneable<Attack>
{
	private static readonly MessageParser<Attack> _parser = new MessageParser<Attack>(() => new Attack());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int num_;

	private int dmg_;

	private int hit_;

	private int target_;

	private int call_;

	public static MessageParser<Attack> Parser => _parser;

	public int Id
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

	public int Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	public int Dmg
	{
		get
		{
			return dmg_;
		}
		set
		{
			dmg_ = value;
		}
	}

	public int Hit
	{
		get
		{
			return hit_;
		}
		set
		{
			hit_ = value;
		}
	}

	public int Target
	{
		get
		{
			return target_;
		}
		set
		{
			target_ = value;
		}
	}

	public int Call
	{
		get
		{
			return call_;
		}
		set
		{
			call_ = value;
		}
	}

	public Attack()
	{
	}

	public Attack(Attack other)
		: this()
	{
		id_ = other.id_;
		num_ = other.num_;
		dmg_ = other.dmg_;
		hit_ = other.hit_;
		target_ = other.target_;
		call_ = other.call_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Attack Clone()
	{
		return new Attack(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Attack);
	}

	public bool Equals(Attack other)
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
		if (Num != other.Num)
		{
			return false;
		}
		if (Dmg != other.Dmg)
		{
			return false;
		}
		if (Hit != other.Hit)
		{
			return false;
		}
		if (Target != other.Target)
		{
			return false;
		}
		if (Call != other.Call)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (Dmg != 0)
		{
			num ^= Dmg.GetHashCode();
		}
		if (Hit != 0)
		{
			num ^= Hit.GetHashCode();
		}
		if (Target != 0)
		{
			num ^= Target.GetHashCode();
		}
		if (Call != 0)
		{
			num ^= Call.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Num != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Num);
		}
		if (Dmg != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Dmg);
		}
		if (Hit != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Hit);
		}
		if (Target != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Target);
		}
		if (Call != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Call);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Num);
		}
		if (Dmg != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Dmg);
		}
		if (Hit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Hit);
		}
		if (Target != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Target);
		}
		if (Call != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Call);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Attack other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.Dmg != 0)
			{
				Dmg = other.Dmg;
			}
			if (other.Hit != 0)
			{
				Hit = other.Hit;
			}
			if (other.Target != 0)
			{
				Target = other.Target;
			}
			if (other.Call != 0)
			{
				Call = other.Call;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				Num = input.ReadInt32();
				break;
			case 24u:
				Dmg = input.ReadInt32();
				break;
			case 32u:
				Hit = input.ReadInt32();
				break;
			case 40u:
				Target = input.ReadInt32();
				break;
			case 48u:
				Call = input.ReadInt32();
				break;
			}
		}
	}
}
