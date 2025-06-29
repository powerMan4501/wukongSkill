using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyHeartBeatParam : IMessage<PartyHeartBeatParam>, IMessage, IEquatable<PartyHeartBeatParam>, IDeepCloneable<PartyHeartBeatParam>
{
	private static readonly MessageParser<PartyHeartBeatParam> _parser = new MessageParser<PartyHeartBeatParam>(() => new PartyHeartBeatParam());

	private UnknownFieldSet _unknownFields;

	private bool isMemberAlive_;

	private bool isTaskAlive_;

	private bool isHelpAlive_;

	public static MessageParser<PartyHeartBeatParam> Parser => _parser;

	public bool IsMemberAlive
	{
		get
		{
			return isMemberAlive_;
		}
		set
		{
			isMemberAlive_ = value;
		}
	}

	public bool IsTaskAlive
	{
		get
		{
			return isTaskAlive_;
		}
		set
		{
			isTaskAlive_ = value;
		}
	}

	public bool IsHelpAlive
	{
		get
		{
			return isHelpAlive_;
		}
		set
		{
			isHelpAlive_ = value;
		}
	}

	public PartyHeartBeatParam()
	{
	}

	public PartyHeartBeatParam(PartyHeartBeatParam other)
		: this()
	{
		isMemberAlive_ = other.isMemberAlive_;
		isTaskAlive_ = other.isTaskAlive_;
		isHelpAlive_ = other.isHelpAlive_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyHeartBeatParam Clone()
	{
		return new PartyHeartBeatParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyHeartBeatParam);
	}

	public bool Equals(PartyHeartBeatParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsMemberAlive != other.IsMemberAlive)
		{
			return false;
		}
		if (IsTaskAlive != other.IsTaskAlive)
		{
			return false;
		}
		if (IsHelpAlive != other.IsHelpAlive)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsMemberAlive)
		{
			num ^= IsMemberAlive.GetHashCode();
		}
		if (IsTaskAlive)
		{
			num ^= IsTaskAlive.GetHashCode();
		}
		if (IsHelpAlive)
		{
			num ^= IsHelpAlive.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsMemberAlive)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsMemberAlive);
		}
		if (IsTaskAlive)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsTaskAlive);
		}
		if (IsHelpAlive)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsHelpAlive);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsMemberAlive)
		{
			num += 2;
		}
		if (IsTaskAlive)
		{
			num += 2;
		}
		if (IsHelpAlive)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyHeartBeatParam other)
	{
		if (other != null)
		{
			if (other.IsMemberAlive)
			{
				IsMemberAlive = other.IsMemberAlive;
			}
			if (other.IsTaskAlive)
			{
				IsTaskAlive = other.IsTaskAlive;
			}
			if (other.IsHelpAlive)
			{
				IsHelpAlive = other.IsHelpAlive;
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
				IsMemberAlive = input.ReadBool();
				break;
			case 16u:
				IsTaskAlive = input.ReadBool();
				break;
			case 24u:
				IsHelpAlive = input.ReadBool();
				break;
			}
		}
	}
}
