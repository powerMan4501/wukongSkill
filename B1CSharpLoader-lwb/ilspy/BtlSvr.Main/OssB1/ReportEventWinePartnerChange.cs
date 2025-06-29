using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventWinePartnerChange : IMessage<ReportEventWinePartnerChange>, IMessage, IEquatable<ReportEventWinePartnerChange>, IDeepCloneable<ReportEventWinePartnerChange>
{
	private static readonly MessageParser<ReportEventWinePartnerChange> _parser = new MessageParser<ReportEventWinePartnerChange>(() => new ReportEventWinePartnerChange());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private Wine oldVal_;

	private Wine newVal_;

	public static MessageParser<ReportEventWinePartnerChange> Parser => _parser;

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

	public Wine OldVal
	{
		get
		{
			return oldVal_;
		}
		set
		{
			oldVal_ = value;
		}
	}

	public Wine NewVal
	{
		get
		{
			return newVal_;
		}
		set
		{
			newVal_ = value;
		}
	}

	public ReportEventWinePartnerChange()
	{
	}

	public ReportEventWinePartnerChange(ReportEventWinePartnerChange other)
		: this()
	{
		roleId_ = other.roleId_;
		oldVal_ = ((other.oldVal_ != null) ? other.oldVal_.Clone() : null);
		newVal_ = ((other.newVal_ != null) ? other.newVal_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventWinePartnerChange Clone()
	{
		return new ReportEventWinePartnerChange(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventWinePartnerChange);
	}

	public bool Equals(ReportEventWinePartnerChange other)
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
		if (!object.Equals(OldVal, other.OldVal))
		{
			return false;
		}
		if (!object.Equals(NewVal, other.NewVal))
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
		if (oldVal_ != null)
		{
			num ^= OldVal.GetHashCode();
		}
		if (newVal_ != null)
		{
			num ^= NewVal.GetHashCode();
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
		if (oldVal_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(OldVal);
		}
		if (newVal_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(NewVal);
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
		if (oldVal_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OldVal);
		}
		if (newVal_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NewVal);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventWinePartnerChange other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoleId != 0L)
		{
			RoleId = other.RoleId;
		}
		if (other.oldVal_ != null)
		{
			if (oldVal_ == null)
			{
				OldVal = new Wine();
			}
			OldVal.MergeFrom(other.OldVal);
		}
		if (other.newVal_ != null)
		{
			if (newVal_ == null)
			{
				NewVal = new Wine();
			}
			NewVal.MergeFrom(other.NewVal);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (oldVal_ == null)
				{
					OldVal = new Wine();
				}
				input.ReadMessage(OldVal);
				break;
			case 26u:
				if (newVal_ == null)
				{
					NewVal = new Wine();
				}
				input.ReadMessage(NewVal);
				break;
			}
		}
	}
}
