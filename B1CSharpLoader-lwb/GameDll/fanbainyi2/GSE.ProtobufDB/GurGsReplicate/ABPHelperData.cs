using System;
using Google.Protobuf;

namespace GurGsReplicate;

public sealed class ABPHelperData : IMessage<ABPHelperData>, IMessage, IEquatable<ABPHelperData>, IDeepCloneable<ABPHelperData>
{
	private static readonly MessageParser<ABPHelperData> _parser = new MessageParser<ABPHelperData>(() => new ABPHelperData());

	private UnknownFieldSet _unknownFields;

	private string aBPSettingPath_;

	public static MessageParser<ABPHelperData> Parser => _parser;

	public string ABPSettingPath
	{
		get
		{
			return aBPSettingPath_ ?? "";
		}
		set
		{
			aBPSettingPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasABPSettingPath => aBPSettingPath_ != null;

	public ABPHelperData()
	{
	}

	public ABPHelperData(ABPHelperData other)
		: this()
	{
		aBPSettingPath_ = other.aBPSettingPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ABPHelperData Clone()
	{
		return new ABPHelperData(this);
	}

	public void ClearABPSettingPath()
	{
		aBPSettingPath_ = null;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ABPHelperData);
	}

	public bool Equals(ABPHelperData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ABPSettingPath != other.ABPSettingPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasABPSettingPath)
		{
			num ^= ABPSettingPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasABPSettingPath)
		{
			output.WriteRawTag(10);
			output.WriteString(ABPSettingPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasABPSettingPath)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ABPSettingPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ABPHelperData other)
	{
		if (other != null)
		{
			if (other.HasABPSettingPath)
			{
				ABPSettingPath = other.ABPSettingPath;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				ABPSettingPath = input.ReadString();
			}
		}
	}
}
