using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class FuncBlock : IMessage<FuncBlock>, IMessage, IEquatable<FuncBlock>, IDeepCloneable<FuncBlock>
{
	private static readonly MessageParser<FuncBlock> _parser = new MessageParser<FuncBlock>(() => new FuncBlock());

	private UnknownFieldSet _unknownFields;

	private uint version_;

	private static readonly FieldCodec<int> _repeated_blockPets_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> blockPets_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_blockItems_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> blockItems_ = new RepeatedField<int>();

	private static readonly FieldCodec<FuncType> _repeated_blockFuncs_codec = FieldCodec.ForEnum(34u, (FuncType x) => (int)x, (int x) => (FuncType)x);

	private readonly RepeatedField<FuncType> blockFuncs_ = new RepeatedField<FuncType>();

	public static MessageParser<FuncBlock> Parser => _parser;

	public uint Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = value;
		}
	}

	public RepeatedField<int> BlockPets => blockPets_;

	public RepeatedField<int> BlockItems => blockItems_;

	public RepeatedField<FuncType> BlockFuncs => blockFuncs_;

	public FuncBlock()
	{
	}

	public FuncBlock(FuncBlock other)
		: this()
	{
		version_ = other.version_;
		blockPets_ = other.blockPets_.Clone();
		blockItems_ = other.blockItems_.Clone();
		blockFuncs_ = other.blockFuncs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FuncBlock Clone()
	{
		return new FuncBlock(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FuncBlock);
	}

	public bool Equals(FuncBlock other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (!blockPets_.Equals(other.blockPets_))
		{
			return false;
		}
		if (!blockItems_.Equals(other.blockItems_))
		{
			return false;
		}
		if (!blockFuncs_.Equals(other.blockFuncs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Version != 0)
		{
			num ^= Version.GetHashCode();
		}
		num ^= blockPets_.GetHashCode();
		num ^= blockItems_.GetHashCode();
		num ^= blockFuncs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Version != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Version);
		}
		blockPets_.WriteTo(output, _repeated_blockPets_codec);
		blockItems_.WriteTo(output, _repeated_blockItems_codec);
		blockFuncs_.WriteTo(output, _repeated_blockFuncs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Version != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Version);
		}
		num += blockPets_.CalculateSize(_repeated_blockPets_codec);
		num += blockItems_.CalculateSize(_repeated_blockItems_codec);
		num += blockFuncs_.CalculateSize(_repeated_blockFuncs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FuncBlock other)
	{
		if (other != null)
		{
			if (other.Version != 0)
			{
				Version = other.Version;
			}
			blockPets_.Add(other.blockPets_);
			blockItems_.Add(other.blockItems_);
			blockFuncs_.Add(other.blockFuncs_);
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
				Version = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				blockPets_.AddEntriesFrom(input, _repeated_blockPets_codec);
				break;
			case 24u:
			case 26u:
				blockItems_.AddEntriesFrom(input, _repeated_blockItems_codec);
				break;
			case 32u:
			case 34u:
				blockFuncs_.AddEntriesFrom(input, _repeated_blockFuncs_codec);
				break;
			}
		}
	}
}
