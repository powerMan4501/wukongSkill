using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyHelp : IMessage<PartyHelp>, IMessage, IEquatable<PartyHelp>, IDeepCloneable<PartyHelp>
{
	private static readonly MessageParser<PartyHelp> _parser = new MessageParser<PartyHelp>(() => new PartyHelp());

	private UnknownFieldSet _unknownFields;

	private PartyHelpState state_;

	private PartyHelpParam helpParam_;

	private uint createTime_;

	private uint lastActivityTime_;

	public static MessageParser<PartyHelp> Parser => _parser;

	public PartyHelpState State
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

	public PartyHelpParam HelpParam
	{
		get
		{
			return helpParam_;
		}
		set
		{
			helpParam_ = value;
		}
	}

	public uint CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	public uint LastActivityTime
	{
		get
		{
			return lastActivityTime_;
		}
		set
		{
			lastActivityTime_ = value;
		}
	}

	public PartyHelp()
	{
	}

	public PartyHelp(PartyHelp other)
		: this()
	{
		state_ = other.state_;
		helpParam_ = ((other.helpParam_ != null) ? other.helpParam_.Clone() : null);
		createTime_ = other.createTime_;
		lastActivityTime_ = other.lastActivityTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyHelp Clone()
	{
		return new PartyHelp(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyHelp);
	}

	public bool Equals(PartyHelp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (State != other.State)
		{
			return false;
		}
		if (!object.Equals(HelpParam, other.HelpParam))
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (LastActivityTime != other.LastActivityTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (State != PartyHelpState.None)
		{
			num ^= State.GetHashCode();
		}
		if (helpParam_ != null)
		{
			num ^= HelpParam.GetHashCode();
		}
		if (CreateTime != 0)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (LastActivityTime != 0)
		{
			num ^= LastActivityTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (State != PartyHelpState.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)State);
		}
		if (helpParam_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HelpParam);
		}
		if (CreateTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CreateTime);
		}
		if (LastActivityTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LastActivityTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (State != PartyHelpState.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (helpParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HelpParam);
		}
		if (CreateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CreateTime);
		}
		if (LastActivityTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LastActivityTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyHelp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.State != PartyHelpState.None)
		{
			State = other.State;
		}
		if (other.helpParam_ != null)
		{
			if (helpParam_ == null)
			{
				HelpParam = new PartyHelpParam();
			}
			HelpParam.MergeFrom(other.HelpParam);
		}
		if (other.CreateTime != 0)
		{
			CreateTime = other.CreateTime;
		}
		if (other.LastActivityTime != 0)
		{
			LastActivityTime = other.LastActivityTime;
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
				State = (PartyHelpState)input.ReadEnum();
				break;
			case 18u:
				if (helpParam_ == null)
				{
					HelpParam = new PartyHelpParam();
				}
				input.ReadMessage(HelpParam);
				break;
			case 24u:
				CreateTime = input.ReadUInt32();
				break;
			case 32u:
				LastActivityTime = input.ReadUInt32();
				break;
			}
		}
	}
}
