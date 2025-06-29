using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class GSUnitBookData : IMessage<GSUnitBookData>, IMessage, IEquatable<GSUnitBookData>, IDeepCloneable<GSUnitBookData>
{
	private static readonly MessageParser<GSUnitBookData> _parser = new MessageParser<GSUnitBookData>(() => new GSUnitBookData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private bool isFirstSightRead_;

	private bool isStory1Read_;

	private int mIParamFirst_;

	private int mIParamFull_;

	public static MessageParser<GSUnitBookData> Parser => _parser;

	public bool IsFirstSightRead
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return isFirstSightRead_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 1;
			isFirstSightRead_ = value;
		}
	}

	public bool HasIsFirstSightRead => (_hasBits0 & 1) != 0;

	public bool IsStory1Read
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return isStory1Read_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 2;
			isStory1Read_ = value;
		}
	}

	public bool HasIsStory1Read => (_hasBits0 & 2) != 0;

	public int MIParamFirst
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return mIParamFirst_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			mIParamFirst_ = value;
		}
	}

	public bool HasMIParamFirst => (_hasBits0 & 4) != 0;

	public int MIParamFull
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return mIParamFull_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8;
			mIParamFull_ = value;
		}
	}

	public bool HasMIParamFull => (_hasBits0 & 8) != 0;

	public GSUnitBookData()
	{
	}

	public GSUnitBookData(GSUnitBookData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		isFirstSightRead_ = other.isFirstSightRead_;
		isStory1Read_ = other.isStory1Read_;
		mIParamFirst_ = other.mIParamFirst_;
		mIParamFull_ = other.mIParamFull_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GSUnitBookData Clone()
	{
		return new GSUnitBookData(this);
	}

	public void ClearIsFirstSightRead()
	{
		_hasBits0 &= -2;
	}

	public void ClearIsStory1Read()
	{
		_hasBits0 &= -3;
	}

	public void ClearMIParamFirst()
	{
		_hasBits0 &= -5;
	}

	public void ClearMIParamFull()
	{
		_hasBits0 &= -9;
	}

	public override bool Equals(object other)
	{
		return Equals(other as GSUnitBookData);
	}

	public bool Equals(GSUnitBookData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsFirstSightRead != other.IsFirstSightRead)
		{
			return false;
		}
		if (IsStory1Read != other.IsStory1Read)
		{
			return false;
		}
		if (MIParamFirst != other.MIParamFirst)
		{
			return false;
		}
		if (MIParamFull != other.MIParamFull)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasIsFirstSightRead)
		{
			num ^= IsFirstSightRead.GetHashCode();
		}
		if (HasIsStory1Read)
		{
			num ^= IsStory1Read.GetHashCode();
		}
		if (HasMIParamFirst)
		{
			num ^= MIParamFirst.GetHashCode();
		}
		if (HasMIParamFull)
		{
			num ^= MIParamFull.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasIsFirstSightRead)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsFirstSightRead);
		}
		if (HasIsStory1Read)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsStory1Read);
		}
		if (HasMIParamFirst)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MIParamFirst);
		}
		if (HasMIParamFull)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MIParamFull);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasIsFirstSightRead)
		{
			num += 2;
		}
		if (HasIsStory1Read)
		{
			num += 2;
		}
		if (HasMIParamFirst)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MIParamFirst);
		}
		if (HasMIParamFull)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MIParamFull);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GSUnitBookData other)
	{
		if (other != null)
		{
			if (other.HasIsFirstSightRead)
			{
				IsFirstSightRead = other.IsFirstSightRead;
			}
			if (other.HasIsStory1Read)
			{
				IsStory1Read = other.IsStory1Read;
			}
			if (other.HasMIParamFirst)
			{
				MIParamFirst = other.MIParamFirst;
			}
			if (other.HasMIParamFull)
			{
				MIParamFull = other.MIParamFull;
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
				IsFirstSightRead = input.ReadBool();
				break;
			case 16u:
				IsStory1Read = input.ReadBool();
				break;
			case 24u:
				MIParamFirst = input.ReadInt32();
				break;
			case 32u:
				MIParamFull = input.ReadInt32();
				break;
			}
		}
	}
}
