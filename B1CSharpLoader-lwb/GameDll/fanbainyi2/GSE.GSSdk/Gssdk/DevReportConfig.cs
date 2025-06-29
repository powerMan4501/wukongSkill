using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DevReportConfig : IMessage<DevReportConfig>, IMessage, IEquatable<DevReportConfig>, IDeepCloneable<DevReportConfig>
{
	private static readonly MessageParser<DevReportConfig> _parser = new MessageParser<DevReportConfig>(() => new DevReportConfig());

	private UnknownFieldSet _unknownFields;

	private string storeRoot_ = "";

	private string resv_ = "";

	public static MessageParser<DevReportConfig> Parser => _parser;

	public string StoreRoot
	{
		get
		{
			return storeRoot_;
		}
		set
		{
			storeRoot_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Resv
	{
		get
		{
			return resv_;
		}
		set
		{
			resv_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public DevReportConfig()
	{
	}

	public DevReportConfig(DevReportConfig other)
		: this()
	{
		storeRoot_ = other.storeRoot_;
		resv_ = other.resv_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DevReportConfig Clone()
	{
		return new DevReportConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DevReportConfig);
	}

	public bool Equals(DevReportConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StoreRoot != other.StoreRoot)
		{
			return false;
		}
		if (Resv != other.Resv)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (StoreRoot.Length != 0)
		{
			num ^= StoreRoot.GetHashCode();
		}
		if (Resv.Length != 0)
		{
			num ^= Resv.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (StoreRoot.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(StoreRoot);
		}
		if (Resv.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Resv);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (StoreRoot.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StoreRoot);
		}
		if (Resv.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Resv);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DevReportConfig other)
	{
		if (other != null)
		{
			if (other.StoreRoot.Length != 0)
			{
				StoreRoot = other.StoreRoot;
			}
			if (other.Resv.Length != 0)
			{
				Resv = other.Resv;
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
			case 10u:
				StoreRoot = input.ReadString();
				break;
			case 18u:
				Resv = input.ReadString();
				break;
			}
		}
	}
}
