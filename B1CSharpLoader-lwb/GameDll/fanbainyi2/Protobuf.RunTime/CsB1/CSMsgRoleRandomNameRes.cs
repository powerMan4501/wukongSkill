using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleRandomNameRes : IMessage<CSMsgRoleRandomNameRes>, IMessage, IEquatable<CSMsgRoleRandomNameRes>, IDeepCloneable<CSMsgRoleRandomNameRes>
{
	private static readonly MessageParser<CSMsgRoleRandomNameRes> _parser = new MessageParser<CSMsgRoleRandomNameRes>(() => new CSMsgRoleRandomNameRes());

	private UnknownFieldSet _unknownFields;

	private RandomNameList nameList_;

	public static MessageParser<CSMsgRoleRandomNameRes> Parser => _parser;

	public RandomNameList NameList
	{
		get
		{
			return nameList_;
		}
		set
		{
			nameList_ = value;
		}
	}

	public CSMsgRoleRandomNameRes()
	{
	}

	public CSMsgRoleRandomNameRes(CSMsgRoleRandomNameRes other)
		: this()
	{
		nameList_ = ((other.nameList_ != null) ? other.nameList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleRandomNameRes Clone()
	{
		return new CSMsgRoleRandomNameRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleRandomNameRes);
	}

	public bool Equals(CSMsgRoleRandomNameRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NameList, other.NameList))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (nameList_ != null)
		{
			num ^= NameList.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (nameList_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(NameList);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (nameList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NameList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoleRandomNameRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nameList_ != null)
		{
			if (nameList_ == null)
			{
				NameList = new RandomNameList();
			}
			NameList.MergeFrom(other.NameList);
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
			if (nameList_ == null)
			{
				NameList = new RandomNameList();
			}
			input.ReadMessage(NameList);
		}
	}
}
