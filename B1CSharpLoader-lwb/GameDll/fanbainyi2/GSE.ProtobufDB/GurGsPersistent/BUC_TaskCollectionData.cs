using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BUC_TaskCollectionData : IMessage<BUC_TaskCollectionData>, IMessage, IEquatable<BUC_TaskCollectionData>, IDeepCloneable<BUC_TaskCollectionData>
{
	private static readonly MessageParser<BUC_TaskCollectionData> _parser = new MessageParser<BUC_TaskCollectionData>(() => new BUC_TaskCollectionData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private bool isDestoryRemoved_;

	private double lastCollectTimeRemoved_;

	private int curCDRemoved_;

	public static MessageParser<BUC_TaskCollectionData> Parser => _parser;

	public bool IsDestoryRemoved
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return isDestoryRemoved_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 1;
			isDestoryRemoved_ = value;
		}
	}

	public bool HasIsDestoryRemoved => (_hasBits0 & 1) != 0;

	public double LastCollectTimeRemoved
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return lastCollectTimeRemoved_;
			}
			return 0.0;
		}
		set
		{
			_hasBits0 |= 2;
			lastCollectTimeRemoved_ = value;
		}
	}

	public bool HasLastCollectTimeRemoved => (_hasBits0 & 2) != 0;

	public int CurCDRemoved
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return curCDRemoved_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			curCDRemoved_ = value;
		}
	}

	public bool HasCurCDRemoved => (_hasBits0 & 4) != 0;

	public BUC_TaskCollectionData()
	{
	}

	public BUC_TaskCollectionData(BUC_TaskCollectionData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		isDestoryRemoved_ = other.isDestoryRemoved_;
		lastCollectTimeRemoved_ = other.lastCollectTimeRemoved_;
		curCDRemoved_ = other.curCDRemoved_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BUC_TaskCollectionData Clone()
	{
		return new BUC_TaskCollectionData(this);
	}

	public void ClearIsDestoryRemoved()
	{
		_hasBits0 &= -2;
	}

	public void ClearLastCollectTimeRemoved()
	{
		_hasBits0 &= -3;
	}

	public void ClearCurCDRemoved()
	{
		_hasBits0 &= -5;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BUC_TaskCollectionData);
	}

	public bool Equals(BUC_TaskCollectionData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsDestoryRemoved != other.IsDestoryRemoved)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LastCollectTimeRemoved, other.LastCollectTimeRemoved))
		{
			return false;
		}
		if (CurCDRemoved != other.CurCDRemoved)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasIsDestoryRemoved)
		{
			num ^= IsDestoryRemoved.GetHashCode();
		}
		if (HasLastCollectTimeRemoved)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LastCollectTimeRemoved);
		}
		if (HasCurCDRemoved)
		{
			num ^= CurCDRemoved.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasIsDestoryRemoved)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsDestoryRemoved);
		}
		if (HasLastCollectTimeRemoved)
		{
			output.WriteRawTag(17);
			output.WriteDouble(LastCollectTimeRemoved);
		}
		if (HasCurCDRemoved)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CurCDRemoved);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasIsDestoryRemoved)
		{
			num += 2;
		}
		if (HasLastCollectTimeRemoved)
		{
			num += 9;
		}
		if (HasCurCDRemoved)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurCDRemoved);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BUC_TaskCollectionData other)
	{
		if (other != null)
		{
			if (other.HasIsDestoryRemoved)
			{
				IsDestoryRemoved = other.IsDestoryRemoved;
			}
			if (other.HasLastCollectTimeRemoved)
			{
				LastCollectTimeRemoved = other.LastCollectTimeRemoved;
			}
			if (other.HasCurCDRemoved)
			{
				CurCDRemoved = other.CurCDRemoved;
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
				IsDestoryRemoved = input.ReadBool();
				break;
			case 17u:
				LastCollectTimeRemoved = input.ReadDouble();
				break;
			case 24u:
				CurCDRemoved = input.ReadInt32();
				break;
			}
		}
	}
}
