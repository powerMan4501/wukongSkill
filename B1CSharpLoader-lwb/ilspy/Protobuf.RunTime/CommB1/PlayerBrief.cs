using System;
using ArchiveB1;
using Google.Protobuf;

namespace CommB1;

public sealed class PlayerBrief : IMessage<PlayerBrief>, IMessage, IEquatable<PlayerBrief>, IDeepCloneable<PlayerBrief>
{
	private static readonly MessageParser<PlayerBrief> _parser = new MessageParser<PlayerBrief>(() => new PlayerBrief());

	private UnknownFieldSet _unknownFields;

	private RoleBase base_;

	public static MessageParser<PlayerBrief> Parser => _parser;

	public RoleBase Base
	{
		get
		{
			return base_;
		}
		set
		{
			base_ = value;
		}
	}

	public PlayerBrief()
	{
	}

	public PlayerBrief(PlayerBrief other)
		: this()
	{
		base_ = ((other.base_ != null) ? other.base_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerBrief Clone()
	{
		return new PlayerBrief(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerBrief);
	}

	public bool Equals(PlayerBrief other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Base, other.Base))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (base_ != null)
		{
			num ^= Base.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (base_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Base);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (base_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Base);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerBrief other)
	{
		if (other == null)
		{
			return;
		}
		if (other.base_ != null)
		{
			if (base_ == null)
			{
				Base = new RoleBase();
			}
			Base.MergeFrom(other.Base);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (base_ == null)
			{
				Base = new RoleBase();
			}
			input.ReadMessage(Base);
		}
	}
}
