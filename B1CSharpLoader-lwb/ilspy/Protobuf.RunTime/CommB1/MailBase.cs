using System;
using ArchiveB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MailBase : IMessage<MailBase>, IMessage, IEquatable<MailBase>, IDeepCloneable<MailBase>
{
	private static readonly MessageParser<MailBase> _parser = new MessageParser<MailBase>(() => new MailBase());

	private UnknownFieldSet _unknownFields;

	private uint id_;

	private MailType mailType_;

	private MailState state_;

	private MailOption option_;

	private static readonly FieldCodec<RoleItem> _repeated_attachements_codec = FieldCodec.ForMessage(42u, RoleItem.Parser);

	private readonly RepeatedField<RoleItem> attachements_ = new RepeatedField<RoleItem>();

	private MailExt ext_;

	public static MessageParser<MailBase> Parser => _parser;

	public uint Id
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

	public MailType MailType
	{
		get
		{
			return mailType_;
		}
		set
		{
			mailType_ = value;
		}
	}

	public MailState State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	public MailOption Option
	{
		get
		{
			return option_;
		}
		set
		{
			option_ = value;
		}
	}

	public RepeatedField<RoleItem> Attachements => attachements_;

	public MailExt Ext
	{
		get
		{
			return ext_;
		}
		set
		{
			ext_ = value;
		}
	}

	public MailBase()
	{
	}

	public MailBase(MailBase other)
		: this()
	{
		id_ = other.id_;
		mailType_ = other.mailType_;
		state_ = other.state_;
		option_ = ((other.option_ != null) ? other.option_.Clone() : null);
		attachements_ = other.attachements_.Clone();
		ext_ = ((other.ext_ != null) ? other.ext_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailBase Clone()
	{
		return new MailBase(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailBase);
	}

	public bool Equals(MailBase other)
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
		if (MailType != other.MailType)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (!object.Equals(Option, other.Option))
		{
			return false;
		}
		if (!attachements_.Equals(other.attachements_))
		{
			return false;
		}
		if (!object.Equals(Ext, other.Ext))
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
		if (MailType != MailType.Comm)
		{
			num ^= MailType.GetHashCode();
		}
		if (State != MailState.Init)
		{
			num ^= State.GetHashCode();
		}
		if (option_ != null)
		{
			num ^= Option.GetHashCode();
		}
		num ^= attachements_.GetHashCode();
		if (ext_ != null)
		{
			num ^= Ext.GetHashCode();
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
			output.WriteUInt32(Id);
		}
		if (MailType != MailType.Comm)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)MailType);
		}
		if (State != MailState.Init)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)State);
		}
		if (option_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Option);
		}
		attachements_.WriteTo(output, _repeated_attachements_codec);
		if (ext_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Ext);
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
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (MailType != MailType.Comm)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MailType);
		}
		if (State != MailState.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (option_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Option);
		}
		num += attachements_.CalculateSize(_repeated_attachements_codec);
		if (ext_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Ext);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailBase other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.MailType != MailType.Comm)
		{
			MailType = other.MailType;
		}
		if (other.State != MailState.Init)
		{
			State = other.State;
		}
		if (other.option_ != null)
		{
			if (option_ == null)
			{
				Option = new MailOption();
			}
			Option.MergeFrom(other.Option);
		}
		attachements_.Add(other.attachements_);
		if (other.ext_ != null)
		{
			if (ext_ == null)
			{
				Ext = new MailExt();
			}
			Ext.MergeFrom(other.Ext);
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
				Id = input.ReadUInt32();
				break;
			case 16u:
				MailType = (MailType)input.ReadEnum();
				break;
			case 24u:
				State = (MailState)input.ReadEnum();
				break;
			case 34u:
				if (option_ == null)
				{
					Option = new MailOption();
				}
				input.ReadMessage(Option);
				break;
			case 42u:
				attachements_.AddEntriesFrom(input, _repeated_attachements_codec);
				break;
			case 50u:
				if (ext_ == null)
				{
					Ext = new MailExt();
				}
				input.ReadMessage(Ext);
				break;
			}
		}
	}
}
