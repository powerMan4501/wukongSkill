using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class GeoInfoCustomData : IMessage<GeoInfoCustomData>, IMessage, IEquatable<GeoInfoCustomData>, IDeepCloneable<GeoInfoCustomData>
{
	private static readonly MessageParser<GeoInfoCustomData> _parser = new MessageParser<GeoInfoCustomData>(() => new GeoInfoCustomData());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<GeoInfoCustomData> Parser => _parser;

	public GeoInfoCustomData()
	{
	}

	public GeoInfoCustomData(GeoInfoCustomData other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GeoInfoCustomData Clone()
	{
		return new GeoInfoCustomData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GeoInfoCustomData);
	}

	public bool Equals(GeoInfoCustomData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GeoInfoCustomData other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
