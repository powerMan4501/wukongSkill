using System;
using Google.Protobuf;

namespace CommB1;

public sealed class LobbyMemberUpdateParam : IMessage<LobbyMemberUpdateParam>, IMessage, IEquatable<LobbyMemberUpdateParam>, IDeepCloneable<LobbyMemberUpdateParam>
{
	private static readonly MessageParser<LobbyMemberUpdateParam> _parser = new MessageParser<LobbyMemberUpdateParam>(() => new LobbyMemberUpdateParam());

	private UnknownFieldSet _unknownFields;

	private LobbyMemberUpdateType updateType_;

	public static MessageParser<LobbyMemberUpdateParam> Parser => _parser;

	public LobbyMemberUpdateType UpdateType
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

	public LobbyMemberUpdateParam()
	{
	}

	public LobbyMemberUpdateParam(LobbyMemberUpdateParam other)
		: this()
	{
		updateType_ = other.updateType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbyMemberUpdateParam Clone()
	{
		return new LobbyMemberUpdateParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbyMemberUpdateParam);
	}

	public bool Equals(LobbyMemberUpdateParam other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UpdateType != LobbyMemberUpdateType.None)
		{
			num ^= UpdateType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UpdateType != LobbyMemberUpdateType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)UpdateType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UpdateType != LobbyMemberUpdateType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UpdateType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobbyMemberUpdateParam other)
	{
		if (other != null)
		{
			if (other.UpdateType != LobbyMemberUpdateType.None)
			{
				UpdateType = other.UpdateType;
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
				UpdateType = (LobbyMemberUpdateType)input.ReadEnum();
			}
		}
	}
}
