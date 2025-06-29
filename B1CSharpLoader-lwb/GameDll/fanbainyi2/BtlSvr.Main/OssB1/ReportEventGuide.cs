using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventGuide : IMessage<ReportEventGuide>, IMessage, IEquatable<ReportEventGuide>, IDeepCloneable<ReportEventGuide>
{
	private static readonly MessageParser<ReportEventGuide> _parser = new MessageParser<ReportEventGuide>(() => new ReportEventGuide());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private uint guideGroupId_;

	public static MessageParser<ReportEventGuide> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public uint GuideGroupId
	{
		get
		{
			return guideGroupId_;
		}
		set
		{
			guideGroupId_ = value;
		}
	}

	public ReportEventGuide()
	{
	}

	public ReportEventGuide(ReportEventGuide other)
		: this()
	{
		roleId_ = other.roleId_;
		guideGroupId_ = other.guideGroupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventGuide Clone()
	{
		return new ReportEventGuide(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventGuide);
	}

	public bool Equals(ReportEventGuide other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (GuideGroupId != other.GuideGroupId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (GuideGroupId != 0)
		{
			num ^= GuideGroupId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		if (GuideGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GuideGroupId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (GuideGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GuideGroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventGuide other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.GuideGroupId != 0)
			{
				GuideGroupId = other.GuideGroupId;
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
				RoleId = input.ReadUInt64();
				break;
			case 16u:
				GuideGroupId = input.ReadUInt32();
				break;
			}
		}
	}
}
