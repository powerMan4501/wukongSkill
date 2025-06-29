using System.Text;

namespace System.Collections.Specialized;

public struct BitVector32
{
	public struct Section
	{
		private readonly short mask;

		private readonly short offset;

		public short Mask => mask;

		public short Offset => offset;

		internal Section(short mask, short offset)
		{
			this.mask = mask;
			this.offset = offset;
		}

		public override bool Equals(object o)
		{
			if (o is Section)
			{
				return Equals((Section)o);
			}
			return false;
		}

		public bool Equals(Section obj)
		{
			if (obj.mask == mask)
			{
				return obj.offset == offset;
			}
			return false;
		}

		public static bool operator ==(Section a, Section b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(Section a, Section b)
		{
			return !(a == b);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public static string ToString(Section value)
		{
			return "Section{0x" + Convert.ToString(value.Mask, 16) + ", 0x" + Convert.ToString(value.Offset, 16) + "}";
		}

		public override string ToString()
		{
			return ToString(this);
		}
	}

	private uint data;

	public bool this[int bit]
	{
		get
		{
			return (data & bit) == (uint)bit;
		}
		set
		{
			if (value)
			{
				data |= (uint)bit;
			}
			else
			{
				data &= (uint)(~bit);
			}
		}
	}

	public int this[Section section]
	{
		get
		{
			return (int)((data & (uint)(section.Mask << (int)section.Offset)) >> (int)section.Offset);
		}
		set
		{
			value <<= (int)section.Offset;
			int num = (0xFFFF & section.Mask) << (int)section.Offset;
			data = (data & (uint)(~num)) | (uint)(value & num);
		}
	}

	public int Data => (int)data;

	public BitVector32(int data)
	{
		this.data = (uint)data;
	}

	public BitVector32(BitVector32 value)
	{
		data = value.data;
	}

	private static short CountBitsSet(short mask)
	{
		short num = 0;
		while ((mask & 1) != 0)
		{
			num++;
			mask >>= 1;
		}
		return num;
	}

	public static int CreateMask()
	{
		return CreateMask(0);
	}

	public static int CreateMask(int previous)
	{
		return previous switch
		{
			0 => 1, 
			int.MinValue => throw new InvalidOperationException(SR.GetString("BitVectorFull")), 
			_ => previous << 1, 
		};
	}

	private static short CreateMaskFromHighValue(short highValue)
	{
		short num = 16;
		while ((highValue & 0x8000) == 0)
		{
			num--;
			highValue <<= 1;
		}
		ushort num2 = 0;
		while (num > 0)
		{
			num--;
			num2 <<= 1;
			num2 |= 1;
		}
		return (short)num2;
	}

	public static Section CreateSection(short maxValue)
	{
		return CreateSectionHelper(maxValue, 0, 0);
	}

	public static Section CreateSection(short maxValue, Section previous)
	{
		return CreateSectionHelper(maxValue, previous.Mask, previous.Offset);
	}

	private static Section CreateSectionHelper(short maxValue, short priorMask, short priorOffset)
	{
		if (maxValue < 1)
		{
			throw new ArgumentException(SR.GetString("Argument_InvalidValue", "maxValue", 0), "maxValue");
		}
		short num = (short)(priorOffset + CountBitsSet(priorMask));
		if (num >= 32)
		{
			throw new InvalidOperationException(SR.GetString("BitVectorFull"));
		}
		return new Section(CreateMaskFromHighValue(maxValue), num);
	}

	public override bool Equals(object o)
	{
		if (!(o is BitVector32))
		{
			return false;
		}
		return data == ((BitVector32)o).data;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public static string ToString(BitVector32 value)
	{
		StringBuilder stringBuilder = new StringBuilder(45);
		stringBuilder.Append("BitVector32{");
		int num = (int)value.data;
		for (int i = 0; i < 32; i++)
		{
			if ((num & 0x80000000u) != 0L)
			{
				stringBuilder.Append("1");
			}
			else
			{
				stringBuilder.Append("0");
			}
			num <<= 1;
		}
		stringBuilder.Append("}");
		return stringBuilder.ToString();
	}

	public override string ToString()
	{
		return ToString(this);
	}
}
