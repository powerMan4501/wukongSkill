using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class MemberUpdateParam : IMessage<MemberUpdateParam>, IMessage, IEquatable<MemberUpdateParam>, IDeepCloneable<MemberUpdateParam>
{
	private static readonly MessageParser<MemberUpdateParam> _parser = new MessageParser<MemberUpdateParam>(() => new MemberUpdateParam());

	private UnknownFieldSet _unknownFields;

	private MemberUpdateType updateType_;

	public static MessageParser<MemberUpdateParam> Parser => _parser;

	public MemberUpdateType UpdateType
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

	public MemberUpdateParam()
	{
	}

	public MemberUpdateParam(MemberUpdateParam other)
		: this()
	{
		updateType_ = other.updateType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MemberUpdateParam Clone()
	{
		return new MemberUpdateParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MemberUpdateParam);
	}

	public bool Equals(MemberUpdateParam other)
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
		if (UpdateType != MemberUpdateType.None)
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
		if (UpdateType != MemberUpdateType.None)
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
		if (UpdateType != MemberUpdateType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UpdateType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MemberUpdateParam other)
	{
		if (other != null)
		{
			if (other.UpdateType != MemberUpdateType.None)
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
				UpdateType = (MemberUpdateType)input.ReadEnum();
			}
		}
	}
}
