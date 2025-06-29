using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class ListDeltaMsgGeoInfoAreaData : IMessage<ListDeltaMsgGeoInfoAreaData>, IMessage, IEquatable<ListDeltaMsgGeoInfoAreaData>, IDeepCloneable<ListDeltaMsgGeoInfoAreaData>
{
	private static readonly MessageParser<ListDeltaMsgGeoInfoAreaData> _parser = new MessageParser<ListDeltaMsgGeoInfoAreaData>(() => new ListDeltaMsgGeoInfoAreaData());

	private UnknownFieldSet _unknownFields;

	private GeoInfoAreaData value_;

	public static MessageParser<ListDeltaMsgGeoInfoAreaData> Parser => _parser;

	public GeoInfoAreaData Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public ListDeltaMsgGeoInfoAreaData()
	{
	}

	public ListDeltaMsgGeoInfoAreaData(ListDeltaMsgGeoInfoAreaData other)
		: this()
	{
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgGeoInfoAreaData Clone()
	{
		return new ListDeltaMsgGeoInfoAreaData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgGeoInfoAreaData);
	}

	public bool Equals(ListDeltaMsgGeoInfoAreaData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Value, other.Value))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (value_ != null)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (value_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (value_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListDeltaMsgGeoInfoAreaData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				Value = new GeoInfoAreaData();
			}
			Value.MergeFrom(other.Value);
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
			if (value_ == null)
			{
				Value = new GeoInfoAreaData();
			}
			input.ReadMessage(Value);
		}
	}
}
