using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStGuideAssetConfigDesc : IMessage<FUStGuideAssetConfigDesc>, IMessage, IEquatable<FUStGuideAssetConfigDesc>, IDeepCloneable<FUStGuideAssetConfigDesc>
{
	private static readonly MessageParser<FUStGuideAssetConfigDesc> _parser = new MessageParser<FUStGuideAssetConfigDesc>(() => new FUStGuideAssetConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string assetPath_ = "";

	private EGSYesNo isForDebug_;

	public static MessageParser<FUStGuideAssetConfigDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string AssetPath
	{
		get
		{
			return assetPath_;
		}
		set
		{
			assetPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo IsForDebug
	{
		get
		{
			return isForDebug_;
		}
		set
		{
			isForDebug_ = value;
		}
	}

	public FUStGuideAssetConfigDesc()
	{
	}

	public FUStGuideAssetConfigDesc(FUStGuideAssetConfigDesc other)
		: this()
	{
		id_ = other.id_;
		assetPath_ = other.assetPath_;
		isForDebug_ = other.isForDebug_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStGuideAssetConfigDesc Clone()
	{
		return new FUStGuideAssetConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStGuideAssetConfigDesc);
	}

	public bool Equals(FUStGuideAssetConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (AssetPath != other.AssetPath)
		{
			return false;
		}
		if (IsForDebug != other.IsForDebug)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (AssetPath.Length != 0)
		{
			num ^= AssetPath.GetHashCode();
		}
		if (IsForDebug != EGSYesNo.No)
		{
			num ^= IsForDebug.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (AssetPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AssetPath);
		}
		if (IsForDebug != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IsForDebug);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (AssetPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AssetPath);
		}
		if (IsForDebug != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsForDebug);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStGuideAssetConfigDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.AssetPath.Length != 0)
			{
				AssetPath = other.AssetPath;
			}
			if (other.IsForDebug != EGSYesNo.No)
			{
				IsForDebug = other.IsForDebug;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				AssetPath = input.ReadString();
				break;
			case 24u:
				IsForDebug = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
