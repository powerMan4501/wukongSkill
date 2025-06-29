using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventRefine : IMessage<ReportEventRefine>, IMessage, IEquatable<ReportEventRefine>, IDeepCloneable<ReportEventRefine>
{
	private static readonly MessageParser<ReportEventRefine> _parser = new MessageParser<ReportEventRefine>(() => new ReportEventRefine());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private static readonly FieldCodec<Item> _repeated_raws_codec = FieldCodec.ForMessage(18u, Item.Parser);

	private readonly RepeatedField<Item> raws_ = new RepeatedField<Item>();

	private static readonly FieldCodec<Item> _repeated_out_codec = FieldCodec.ForMessage(26u, Item.Parser);

	private readonly RepeatedField<Item> out_ = new RepeatedField<Item>();

	private int receipeId_;

	public static MessageParser<ReportEventRefine> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public RepeatedField<Item> Raws => raws_;

	public RepeatedField<Item> Out => out_;

	public int ReceipeId
	{
		get
		{
			return receipeId_;
		}
		set
		{
			receipeId_ = value;
		}
	}

	public ReportEventRefine()
	{
	}

	public ReportEventRefine(ReportEventRefine other)
		: this()
	{
		roleId_ = other.roleId_;
		raws_ = other.raws_.Clone();
		out_ = other.out_.Clone();
		receipeId_ = other.receipeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventRefine Clone()
	{
		return new ReportEventRefine(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventRefine);
	}

	public bool Equals(ReportEventRefine other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (!raws_.Equals(other.raws_))
		{
			return false;
		}
		if (!out_.Equals(other.out_))
		{
			return false;
		}
		if (ReceipeId != other.ReceipeId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		num ^= raws_.GetHashCode();
		num ^= out_.GetHashCode();
		if (ReceipeId != 0)
		{
			num ^= ReceipeId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		raws_.WriteTo(output, _repeated_raws_codec);
		out_.WriteTo(output, _repeated_out_codec);
		if (ReceipeId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ReceipeId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		num += raws_.CalculateSize(_repeated_raws_codec);
		num += out_.CalculateSize(_repeated_out_codec);
		if (ReceipeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReceipeId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventRefine other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			raws_.Add(other.raws_);
			out_.Add(other.out_);
			if (other.ReceipeId != 0)
			{
				ReceipeId = other.ReceipeId;
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
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				raws_.AddEntriesFrom(input, _repeated_raws_codec);
				break;
			case 26u:
				out_.AddEntriesFrom(input, _repeated_out_codec);
				break;
			case 32u:
				ReceipeId = input.ReadInt32();
				break;
			}
		}
	}
}
