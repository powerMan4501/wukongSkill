using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyTaskUpdateParam : IMessage<PartyTaskUpdateParam>, IMessage, IEquatable<PartyTaskUpdateParam>, IDeepCloneable<PartyTaskUpdateParam>
{
	private static readonly MessageParser<PartyTaskUpdateParam> _parser = new MessageParser<PartyTaskUpdateParam>(() => new PartyTaskUpdateParam());

	private UnknownFieldSet _unknownFields;

	private PartyTaskUpdateType updateType_;

	private string gameSession_ = "";

	private PartyHelpParam helpParam_;

	public static MessageParser<PartyTaskUpdateParam> Parser => _parser;

	public PartyTaskUpdateType UpdateType
	{
		get
		{
			return updateType_;
		}
		set
		{
			updateType_ = value;
		}
	}

	public string GameSession
	{
		get
		{
			return gameSession_;
		}
		set
		{
			gameSession_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public PartyTaskUpdateParam()
	{
	}

	public PartyTaskUpdateParam(PartyTaskUpdateParam other)
		: this()
	{
		updateType_ = other.updateType_;
		gameSession_ = other.gameSession_;
		helpParam_ = ((other.helpParam_ != null) ? other.helpParam_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyTaskUpdateParam Clone()
	{
		return new PartyTaskUpdateParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyTaskUpdateParam);
	}

	public bool Equals(PartyTaskUpdateParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UpdateType != other.UpdateType)
		{
			return false;
		}
		if (GameSession != other.GameSession)
		{
			return false;
		}
		if (!object.Equals(HelpParam, other.HelpParam))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UpdateType != PartyTaskUpdateType.Default)
		{
			num ^= UpdateType.GetHashCode();
		}
		if (GameSession.Length != 0)
		{
			num ^= GameSession.GetHashCode();
		}
		if (helpParam_ != null)
		{
			num ^= HelpParam.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UpdateType != PartyTaskUpdateType.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)UpdateType);
		}
		if (GameSession.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(GameSession);
		}
		if (helpParam_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(HelpParam);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UpdateType != PartyTaskUpdateType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UpdateType);
		}
		if (GameSession.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GameSession);
		}
		if (helpParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HelpParam);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyTaskUpdateParam other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UpdateType != PartyTaskUpdateType.Default)
		{
			UpdateType = other.UpdateType;
		}
		if (other.GameSession.Length != 0)
		{
			GameSession = other.GameSession;
		}
		if (other.helpParam_ != null)
		{
			if (helpParam_ == null)
			{
				HelpParam = new PartyHelpParam();
			}
			HelpParam.MergeFrom(other.HelpParam);
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
				UpdateType = (PartyTaskUpdateType)input.ReadEnum();
				break;
			case 18u:
				GameSession = input.ReadString();
				break;
			case 26u:
				if (helpParam_ == null)
				{
					HelpParam = new PartyHelpParam();
				}
				input.ReadMessage(HelpParam);
				break;
			}
		}
	}
}
