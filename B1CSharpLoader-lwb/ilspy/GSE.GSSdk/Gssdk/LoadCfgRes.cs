using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class LoadCfgRes : IMessage<LoadCfgRes>, IMessage, IEquatable<LoadCfgRes>, IDeepCloneable<LoadCfgRes>
{
	private static readonly MessageParser<LoadCfgRes> _parser = new MessageParser<LoadCfgRes>(() => new LoadCfgRes());

	private UnknownFieldSet _unknownFields;

	private GssdkConfig data_;

	public static MessageParser<LoadCfgRes> Parser => _parser;

	public GssdkConfig Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	public LoadCfgRes()
	{
	}

	public LoadCfgRes(LoadCfgRes other)
		: this()
	{
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LoadCfgRes Clone()
	{
		return new LoadCfgRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LoadCfgRes);
	}

	public bool Equals(LoadCfgRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Data, other.Data))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (data_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Data);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LoadCfgRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new GssdkConfig();
			}
			Data.MergeFrom(other.Data);
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
			if (data_ == null)
			{
				Data = new GssdkConfig();
			}
			input.ReadMessage(Data);
		}
	}
}
