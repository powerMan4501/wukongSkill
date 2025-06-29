using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Text;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class StringBuilder : ISerializable
{
	internal char[] m_ChunkChars;

	internal StringBuilder m_ChunkPrevious;

	internal int m_ChunkLength;

	internal int m_ChunkOffset;

	internal int m_MaxCapacity;

	internal const int DefaultCapacity = 16;

	private const string CapacityField = "Capacity";

	private const string MaxCapacityField = "m_MaxCapacity";

	private const string StringValueField = "m_StringValue";

	private const string ThreadIDField = "m_currentThread";

	internal const int MaxChunkSize = 8000;

	[__DynamicallyInvokable]
	public int Capacity
	{
		[__DynamicallyInvokable]
		get
		{
			return m_ChunkChars.Length + m_ChunkOffset;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NegativeCapacity"));
			}
			if (value > MaxCapacity)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_Capacity"));
			}
			if (value < Length)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_SmallCapacity"));
			}
			if (Capacity != value)
			{
				int num = value - m_ChunkOffset;
				char[] array = new char[num];
				Array.Copy(m_ChunkChars, array, m_ChunkLength);
				m_ChunkChars = array;
			}
		}
	}

	[__DynamicallyInvokable]
	public int MaxCapacity
	{
		[__DynamicallyInvokable]
		get
		{
			return m_MaxCapacity;
		}
	}

	[__DynamicallyInvokable]
	public int Length
	{
		[__DynamicallyInvokable]
		get
		{
			return m_ChunkOffset + m_ChunkLength;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NegativeLength"));
			}
			if (value > MaxCapacity)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_SmallCapacity"));
			}
			int capacity = Capacity;
			if (value == 0 && m_ChunkPrevious == null)
			{
				m_ChunkLength = 0;
				m_ChunkOffset = 0;
				return;
			}
			int num = value - Length;
			if (num > 0)
			{
				Append('\0', num);
				return;
			}
			StringBuilder stringBuilder = FindChunkForIndex(value);
			if (stringBuilder != this)
			{
				int num2 = capacity - stringBuilder.m_ChunkOffset;
				char[] array = new char[num2];
				Array.Copy(stringBuilder.m_ChunkChars, array, stringBuilder.m_ChunkLength);
				m_ChunkChars = array;
				m_ChunkPrevious = stringBuilder.m_ChunkPrevious;
				m_ChunkOffset = stringBuilder.m_ChunkOffset;
			}
			m_ChunkLength = value - stringBuilder.m_ChunkOffset;
		}
	}

	[IndexerName("Chars")]
	[__DynamicallyInvokable]
	public char this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			StringBuilder stringBuilder = this;
			do
			{
				int num = index - stringBuilder.m_ChunkOffset;
				if (num >= 0)
				{
					if (num >= stringBuilder.m_ChunkLength)
					{
						throw new IndexOutOfRangeException();
					}
					return stringBuilder.m_ChunkChars[num];
				}
				stringBuilder = stringBuilder.m_ChunkPrevious;
			}
			while (stringBuilder != null);
			throw new IndexOutOfRangeException();
		}
		[__DynamicallyInvokable]
		set
		{
			StringBuilder stringBuilder = this;
			do
			{
				int num = index - stringBuilder.m_ChunkOffset;
				if (num >= 0)
				{
					if (num >= stringBuilder.m_ChunkLength)
					{
						throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
					}
					stringBuilder.m_ChunkChars[num] = value;
					return;
				}
				stringBuilder = stringBuilder.m_ChunkPrevious;
			}
			while (stringBuilder != null);
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
	}

	[__DynamicallyInvokable]
	public StringBuilder()
		: this(16)
	{
	}

	[__DynamicallyInvokable]
	public StringBuilder(int capacity)
		: this(string.Empty, capacity)
	{
	}

	[__DynamicallyInvokable]
	public StringBuilder(string value)
		: this(value, 16)
	{
	}

	[__DynamicallyInvokable]
	public StringBuilder(string value, int capacity)
		: this(value, 0, value?.Length ?? 0, capacity)
	{
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe StringBuilder(string value, int startIndex, int length, int capacity)
	{
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", Environment.GetResourceString("ArgumentOutOfRange_MustBePositive", "capacity"));
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_MustBeNonNegNum", "length"));
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (value == null)
		{
			value = string.Empty;
		}
		if (startIndex > value.Length - length)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_IndexLength"));
		}
		m_MaxCapacity = int.MaxValue;
		if (capacity == 0)
		{
			capacity = 16;
		}
		if (capacity < length)
		{
			capacity = length;
		}
		m_ChunkChars = new char[capacity];
		m_ChunkLength = length;
		fixed (char* ptr = value)
		{
			ThreadSafeCopy(ptr + startIndex, m_ChunkChars, 0, length);
		}
	}

	[__DynamicallyInvokable]
	public StringBuilder(int capacity, int maxCapacity)
	{
		if (capacity > maxCapacity)
		{
			throw new ArgumentOutOfRangeException("capacity", Environment.GetResourceString("ArgumentOutOfRange_Capacity"));
		}
		if (maxCapacity < 1)
		{
			throw new ArgumentOutOfRangeException("maxCapacity", Environment.GetResourceString("ArgumentOutOfRange_SmallMaxCapacity"));
		}
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", Environment.GetResourceString("ArgumentOutOfRange_MustBePositive", "capacity"));
		}
		if (capacity == 0)
		{
			capacity = Math.Min(16, maxCapacity);
		}
		m_MaxCapacity = maxCapacity;
		m_ChunkChars = new char[capacity];
	}

	[SecurityCritical]
	private StringBuilder(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		int num = 0;
		string text = null;
		int num2 = int.MaxValue;
		bool flag = false;
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		while (enumerator.MoveNext())
		{
			switch (enumerator.Name)
			{
			case "m_MaxCapacity":
				num2 = info.GetInt32("m_MaxCapacity");
				break;
			case "m_StringValue":
				text = info.GetString("m_StringValue");
				break;
			case "Capacity":
				num = info.GetInt32("Capacity");
				flag = true;
				break;
			}
		}
		if (text == null)
		{
			text = string.Empty;
		}
		if (num2 < 1 || text.Length > num2)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_StringBuilderMaxCapacity"));
		}
		if (!flag)
		{
			num = 16;
			if (num < text.Length)
			{
				num = text.Length;
			}
			if (num > num2)
			{
				num = num2;
			}
		}
		if (num < 0 || num < text.Length || num > num2)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_StringBuilderCapacity"));
		}
		m_MaxCapacity = num2;
		m_ChunkChars = new char[num];
		text.CopyTo(0, m_ChunkChars, 0, text.Length);
		m_ChunkLength = text.Length;
		m_ChunkPrevious = null;
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("m_MaxCapacity", m_MaxCapacity);
		info.AddValue("Capacity", Capacity);
		info.AddValue("m_StringValue", ToString());
		info.AddValue("m_currentThread", 0);
	}

	[Conditional("_DEBUG")]
	private void VerifyClassInvariant()
	{
		StringBuilder stringBuilder = this;
		int maxCapacity = m_MaxCapacity;
		while (true)
		{
			StringBuilder chunkPrevious = stringBuilder.m_ChunkPrevious;
			if (chunkPrevious != null)
			{
				stringBuilder = chunkPrevious;
				continue;
			}
			break;
		}
	}

	[__DynamicallyInvokable]
	public int EnsureCapacity(int capacity)
	{
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", Environment.GetResourceString("ArgumentOutOfRange_NegativeCapacity"));
		}
		if (Capacity < capacity)
		{
			Capacity = capacity;
		}
		return Capacity;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override string ToString()
	{
		if (Length == 0)
		{
			return string.Empty;
		}
		string text = string.FastAllocateString(Length);
		StringBuilder stringBuilder = this;
		fixed (char* ptr = text)
		{
			do
			{
				if (stringBuilder.m_ChunkLength > 0)
				{
					char[] chunkChars = stringBuilder.m_ChunkChars;
					int chunkOffset = stringBuilder.m_ChunkOffset;
					int chunkLength = stringBuilder.m_ChunkLength;
					if ((uint)(chunkLength + chunkOffset) > text.Length || (uint)chunkLength > (uint)chunkChars.Length)
					{
						throw new ArgumentOutOfRangeException("chunkLength", Environment.GetResourceString("ArgumentOutOfRange_Index"));
					}
					fixed (char* smem = chunkChars)
					{
						string.wstrcpy(ptr + chunkOffset, smem, chunkLength);
					}
				}
				stringBuilder = stringBuilder.m_ChunkPrevious;
			}
			while (stringBuilder != null);
		}
		return text;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe string ToString(int startIndex, int length)
	{
		int length2 = Length;
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (startIndex > length2)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndexLargerThanLength"));
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_NegativeLength"));
		}
		if (startIndex > length2 - length)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_IndexLength"));
		}
		StringBuilder stringBuilder = this;
		int num = startIndex + length;
		string text = string.FastAllocateString(length);
		int num2 = length;
		fixed (char* ptr = text)
		{
			while (num2 > 0)
			{
				int num3 = num - stringBuilder.m_ChunkOffset;
				if (num3 >= 0)
				{
					if (num3 > stringBuilder.m_ChunkLength)
					{
						num3 = stringBuilder.m_ChunkLength;
					}
					int num4 = num2;
					int num5 = num4;
					int num6 = num3 - num4;
					if (num6 < 0)
					{
						num5 += num6;
						num6 = 0;
					}
					num2 -= num5;
					if (num5 > 0)
					{
						char[] chunkChars = stringBuilder.m_ChunkChars;
						if ((uint)(num5 + num2) > length || (uint)(num5 + num6) > (uint)chunkChars.Length)
						{
							throw new ArgumentOutOfRangeException("chunkCount", Environment.GetResourceString("ArgumentOutOfRange_Index"));
						}
						fixed (char* smem = &chunkChars[num6])
						{
							string.wstrcpy(ptr + num2, smem, num5);
						}
					}
				}
				stringBuilder = stringBuilder.m_ChunkPrevious;
			}
		}
		return text;
	}

	[__DynamicallyInvokable]
	public StringBuilder Clear()
	{
		Length = 0;
		return this;
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(char value, int repeatCount)
	{
		if (repeatCount < 0)
		{
			throw new ArgumentOutOfRangeException("repeatCount", Environment.GetResourceString("ArgumentOutOfRange_NegativeCount"));
		}
		if (repeatCount == 0)
		{
			return this;
		}
		int num = m_ChunkLength;
		while (repeatCount > 0)
		{
			if (num < m_ChunkChars.Length)
			{
				m_ChunkChars[num++] = value;
				repeatCount--;
			}
			else
			{
				m_ChunkLength = num;
				ExpandByABlock(repeatCount);
				num = 0;
			}
		}
		m_ChunkLength = num;
		return this;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe StringBuilder Append(char[] value, int startIndex, int charCount)
	{
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (charCount < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8 && charCount == 0)
		{
			return this;
		}
		if (value == null)
		{
			if (startIndex == 0 && charCount == 0)
			{
				return this;
			}
			throw new ArgumentNullException("value");
		}
		if (charCount > value.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (charCount == 0)
		{
			return this;
		}
		fixed (char* value2 = &value[startIndex])
		{
			Append(value2, charCount);
		}
		return this;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe StringBuilder Append(string value)
	{
		if (value != null)
		{
			char[] chunkChars = m_ChunkChars;
			int chunkLength = m_ChunkLength;
			int length = value.Length;
			int num = chunkLength + length;
			if (num < chunkChars.Length)
			{
				if (length <= 2)
				{
					if (length > 0)
					{
						chunkChars[chunkLength] = value[0];
					}
					if (length > 1)
					{
						chunkChars[chunkLength + 1] = value[1];
					}
				}
				else
				{
					fixed (char* smem = value)
					{
						fixed (char* dmem = &chunkChars[chunkLength])
						{
							string.wstrcpy(dmem, smem, length);
						}
					}
				}
				m_ChunkLength = num;
			}
			else
			{
				AppendHelper(value);
			}
		}
		return this;
	}

	[SecuritySafeCritical]
	private unsafe void AppendHelper(string value)
	{
		fixed (char* value2 = value)
		{
			Append(value2, value.Length);
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe extern void ReplaceBufferInternal(char* newBuffer, int newLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe extern void ReplaceBufferAnsiInternal(sbyte* newBuffer, int newLength);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe StringBuilder Append(string value, int startIndex, int count)
	{
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8 && count == 0)
		{
			return this;
		}
		if (value == null)
		{
			if (startIndex == 0 && count == 0)
			{
				return this;
			}
			throw new ArgumentNullException("value");
		}
		if (count == 0)
		{
			return this;
		}
		if (startIndex > value.Length - count)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		fixed (char* ptr = value)
		{
			Append(ptr + startIndex, count);
		}
		return this;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public StringBuilder AppendLine()
	{
		return Append(Environment.NewLine);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public StringBuilder AppendLine(string value)
	{
		Append(value);
		return Append(Environment.NewLine);
	}

	[ComVisible(false)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("Arg_NegativeArgCount"));
		}
		if (destinationIndex < 0)
		{
			throw new ArgumentOutOfRangeException("destinationIndex", Environment.GetResourceString("ArgumentOutOfRange_MustBeNonNegNum", "destinationIndex"));
		}
		if (destinationIndex > destination.Length - count)
		{
			throw new ArgumentException(Environment.GetResourceString("ArgumentOutOfRange_OffsetOut"));
		}
		if ((uint)sourceIndex > (uint)Length)
		{
			throw new ArgumentOutOfRangeException("sourceIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (sourceIndex > Length - count)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_LongerThanSrcString"));
		}
		StringBuilder stringBuilder = this;
		int num = sourceIndex + count;
		int num2 = destinationIndex + count;
		while (count > 0)
		{
			int num3 = num - stringBuilder.m_ChunkOffset;
			if (num3 >= 0)
			{
				if (num3 > stringBuilder.m_ChunkLength)
				{
					num3 = stringBuilder.m_ChunkLength;
				}
				int num4 = count;
				int num5 = num3 - count;
				if (num5 < 0)
				{
					num4 += num5;
					num5 = 0;
				}
				num2 -= num4;
				count -= num4;
				ThreadSafeCopy(stringBuilder.m_ChunkChars, num5, destination, num2, num4);
			}
			stringBuilder = stringBuilder.m_ChunkPrevious;
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe StringBuilder Insert(int index, string value, int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		int length = Length;
		if ((uint)index > (uint)length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (value == null || value.Length == 0 || count == 0)
		{
			return this;
		}
		long num = (long)value.Length * (long)count;
		if (num > MaxCapacity - Length)
		{
			throw new OutOfMemoryException();
		}
		MakeRoom(index, (int)num, out var chunk, out var indexInChunk, doneMoveFollowingChars: false);
		fixed (char* value2 = value)
		{
			while (count > 0)
			{
				ReplaceInPlaceAtChunk(ref chunk, ref indexInChunk, value2, value.Length);
				count--;
			}
		}
		return this;
	}

	[__DynamicallyInvokable]
	public StringBuilder Remove(int startIndex, int length)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_NegativeLength"));
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (length > Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (Length == length && startIndex == 0)
		{
			Length = 0;
			return this;
		}
		if (length > 0)
		{
			Remove(startIndex, length, out var _, out var _);
		}
		return this;
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(bool value)
	{
		return Append(value.ToString());
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public StringBuilder Append(sbyte value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(byte value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(char value)
	{
		if (m_ChunkLength < m_ChunkChars.Length)
		{
			m_ChunkChars[m_ChunkLength++] = value;
		}
		else
		{
			Append(value, 1);
		}
		return this;
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(short value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(int value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(long value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(float value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(double value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(decimal value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public StringBuilder Append(ushort value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public StringBuilder Append(uint value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public StringBuilder Append(ulong value)
	{
		return Append(value.ToString(CultureInfo.CurrentCulture));
	}

	[__DynamicallyInvokable]
	public StringBuilder Append(object value)
	{
		if (value == null)
		{
			return this;
		}
		return Append(value.ToString());
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe StringBuilder Append(char[] value)
	{
		if (value != null && value.Length != 0)
		{
			fixed (char* value2 = &value[0])
			{
				Append(value2, value.Length);
			}
		}
		return this;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe StringBuilder Insert(int index, string value)
	{
		if ((uint)index > (uint)Length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (value != null)
		{
			fixed (char* value2 = value)
			{
				Insert(index, value2, value.Length);
			}
		}
		return this;
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, bool value)
	{
		return Insert(index, value.ToString(), 1);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, sbyte value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, byte value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, short value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe StringBuilder Insert(int index, char value)
	{
		Insert(index, &value, 1);
		return this;
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, char[] value)
	{
		if ((uint)index > (uint)Length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (value != null)
		{
			Insert(index, value, 0, value.Length);
		}
		return this;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe StringBuilder Insert(int index, char[] value, int startIndex, int charCount)
	{
		int length = Length;
		if ((uint)index > (uint)length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (value == null)
		{
			if (startIndex == 0 && charCount == 0)
			{
				return this;
			}
			throw new ArgumentNullException(Environment.GetResourceString("ArgumentNull_String"));
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (charCount < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (startIndex > value.Length - charCount)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (charCount > 0)
		{
			fixed (char* value2 = &value[startIndex])
			{
				Insert(index, value2, charCount);
			}
		}
		return this;
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, int value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, long value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, float value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, double value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, decimal value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, ushort value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, uint value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, ulong value)
	{
		return Insert(index, value.ToString(CultureInfo.CurrentCulture), 1);
	}

	[__DynamicallyInvokable]
	public StringBuilder Insert(int index, object value)
	{
		if (value == null)
		{
			return this;
		}
		return Insert(index, value.ToString(), 1);
	}

	[__DynamicallyInvokable]
	public StringBuilder AppendFormat(string format, object arg0)
	{
		return AppendFormatHelper(null, format, new ParamsArray(arg0));
	}

	[__DynamicallyInvokable]
	public StringBuilder AppendFormat(string format, object arg0, object arg1)
	{
		return AppendFormatHelper(null, format, new ParamsArray(arg0, arg1));
	}

	[__DynamicallyInvokable]
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2)
	{
		return AppendFormatHelper(null, format, new ParamsArray(arg0, arg1, arg2));
	}

	[__DynamicallyInvokable]
	public StringBuilder AppendFormat(string format, params object[] args)
	{
		if (args == null)
		{
			throw new ArgumentNullException((format == null) ? "format" : "args");
		}
		return AppendFormatHelper(null, format, new ParamsArray(args));
	}

	[__DynamicallyInvokable]
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0)
	{
		return AppendFormatHelper(provider, format, new ParamsArray(arg0));
	}

	[__DynamicallyInvokable]
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1)
	{
		return AppendFormatHelper(provider, format, new ParamsArray(arg0, arg1));
	}

	[__DynamicallyInvokable]
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2)
	{
		return AppendFormatHelper(provider, format, new ParamsArray(arg0, arg1, arg2));
	}

	[__DynamicallyInvokable]
	public StringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
	{
		if (args == null)
		{
			throw new ArgumentNullException((format == null) ? "format" : "args");
		}
		return AppendFormatHelper(provider, format, new ParamsArray(args));
	}

	private static void FormatError()
	{
		throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
	}

	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		int num = 0;
		int length = format.Length;
		char c = '\0';
		ICustomFormatter customFormatter = null;
		if (provider != null)
		{
			customFormatter = (ICustomFormatter)provider.GetFormat(typeof(ICustomFormatter));
		}
		while (true)
		{
			int num2 = num;
			int num3 = num;
			while (num < length)
			{
				c = format[num];
				num++;
				if (c == '}')
				{
					if (num < length && format[num] == '}')
					{
						num++;
					}
					else
					{
						FormatError();
					}
				}
				if (c == '{')
				{
					if (num >= length || format[num] != '{')
					{
						num--;
						break;
					}
					num++;
				}
				Append(c);
			}
			if (num == length)
			{
				break;
			}
			num++;
			if (num == length || (c = format[num]) < '0' || c > '9')
			{
				FormatError();
			}
			int num4 = 0;
			do
			{
				num4 = num4 * 10 + c - 48;
				num++;
				if (num == length)
				{
					FormatError();
				}
				c = format[num];
			}
			while (c >= '0' && c <= '9' && num4 < 1000000);
			if (num4 >= args.Length)
			{
				throw new FormatException(Environment.GetResourceString("Format_IndexOutOfRange"));
			}
			for (; num < length; num++)
			{
				if ((c = format[num]) != ' ')
				{
					break;
				}
			}
			bool flag = false;
			int num5 = 0;
			if (c == ',')
			{
				for (num++; num < length && format[num] == ' '; num++)
				{
				}
				if (num == length)
				{
					FormatError();
				}
				c = format[num];
				if (c == '-')
				{
					flag = true;
					num++;
					if (num == length)
					{
						FormatError();
					}
					c = format[num];
				}
				if (c < '0' || c > '9')
				{
					FormatError();
				}
				do
				{
					num5 = num5 * 10 + c - 48;
					num++;
					if (num == length)
					{
						FormatError();
					}
					c = format[num];
				}
				while (c >= '0' && c <= '9' && num5 < 1000000);
			}
			for (; num < length; num++)
			{
				if ((c = format[num]) != ' ')
				{
					break;
				}
			}
			object obj = args[num4];
			StringBuilder stringBuilder = null;
			if (c == ':')
			{
				num++;
				num2 = num;
				num3 = num;
				while (true)
				{
					if (num == length)
					{
						FormatError();
					}
					c = format[num];
					num++;
					if (c == '{')
					{
						if (num < length && format[num] == '{')
						{
							num++;
						}
						else
						{
							FormatError();
						}
					}
					else if (c == '}')
					{
						if (num >= length || format[num] != '}')
						{
							break;
						}
						num++;
					}
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
					}
					stringBuilder.Append(c);
				}
				num--;
			}
			if (c != '}')
			{
				FormatError();
			}
			num++;
			string text = null;
			string text2 = null;
			if (customFormatter != null)
			{
				if (stringBuilder != null)
				{
					text = stringBuilder.ToString();
				}
				text2 = customFormatter.Format(text, obj, provider);
			}
			if (text2 == null)
			{
				if (obj is IFormattable formattable)
				{
					if (text == null && stringBuilder != null)
					{
						text = stringBuilder.ToString();
					}
					text2 = formattable.ToString(text, provider);
				}
				else if (obj != null)
				{
					text2 = obj.ToString();
				}
			}
			if (text2 == null)
			{
				text2 = string.Empty;
			}
			int num6 = num5 - text2.Length;
			if (!flag && num6 > 0)
			{
				Append(' ', num6);
			}
			Append(text2);
			if (flag && num6 > 0)
			{
				Append(' ', num6);
			}
		}
		return this;
	}

	[__DynamicallyInvokable]
	public StringBuilder Replace(string oldValue, string newValue)
	{
		return Replace(oldValue, newValue, 0, Length);
	}

	[__DynamicallyInvokable]
	public bool Equals(StringBuilder sb)
	{
		if (sb == null)
		{
			return false;
		}
		if (Capacity != sb.Capacity || MaxCapacity != sb.MaxCapacity || Length != sb.Length)
		{
			return false;
		}
		if (sb == this)
		{
			return true;
		}
		StringBuilder stringBuilder = this;
		int num = stringBuilder.m_ChunkLength;
		StringBuilder stringBuilder2 = sb;
		int num2 = stringBuilder2.m_ChunkLength;
		do
		{
			num--;
			num2--;
			while (num < 0)
			{
				stringBuilder = stringBuilder.m_ChunkPrevious;
				if (stringBuilder == null)
				{
					break;
				}
				num = stringBuilder.m_ChunkLength + num;
			}
			while (num2 < 0)
			{
				stringBuilder2 = stringBuilder2.m_ChunkPrevious;
				if (stringBuilder2 == null)
				{
					break;
				}
				num2 = stringBuilder2.m_ChunkLength + num2;
			}
			if (num < 0)
			{
				return num2 < 0;
			}
			if (num2 < 0)
			{
				return false;
			}
		}
		while (stringBuilder.m_ChunkChars[num] == stringBuilder2.m_ChunkChars[num2]);
		return false;
	}

	[__DynamicallyInvokable]
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
	{
		int length = Length;
		if ((uint)startIndex > (uint)length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (count < 0 || startIndex > length - count)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (oldValue == null)
		{
			throw new ArgumentNullException("oldValue");
		}
		if (oldValue.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyName"), "oldValue");
		}
		if (newValue == null)
		{
			newValue = "";
		}
		int num = newValue.Length - oldValue.Length;
		int[] array = null;
		int num2 = 0;
		StringBuilder stringBuilder = FindChunkForIndex(startIndex);
		int num3 = startIndex - stringBuilder.m_ChunkOffset;
		while (count > 0)
		{
			if (StartsWith(stringBuilder, num3, count, oldValue))
			{
				if (array == null)
				{
					array = new int[5];
				}
				else if (num2 >= array.Length)
				{
					int[] array2 = new int[array.Length * 3 / 2 + 4];
					Array.Copy(array, array2, array.Length);
					array = array2;
				}
				array[num2++] = num3;
				num3 += oldValue.Length;
				count -= oldValue.Length;
			}
			else
			{
				num3++;
				count--;
			}
			if (num3 >= stringBuilder.m_ChunkLength || count == 0)
			{
				int num4 = num3 + stringBuilder.m_ChunkOffset;
				int num5 = num4;
				ReplaceAllInChunk(array, num2, stringBuilder, oldValue.Length, newValue);
				num4 += (newValue.Length - oldValue.Length) * num2;
				num2 = 0;
				stringBuilder = FindChunkForIndex(num4);
				num3 = num4 - stringBuilder.m_ChunkOffset;
			}
		}
		return this;
	}

	[__DynamicallyInvokable]
	public StringBuilder Replace(char oldChar, char newChar)
	{
		return Replace(oldChar, newChar, 0, Length);
	}

	[__DynamicallyInvokable]
	public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
	{
		int length = Length;
		if ((uint)startIndex > (uint)length)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (count < 0 || startIndex > length - count)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		int num = startIndex + count;
		StringBuilder stringBuilder = this;
		while (true)
		{
			int num2 = num - stringBuilder.m_ChunkOffset;
			int num3 = startIndex - stringBuilder.m_ChunkOffset;
			if (num2 >= 0)
			{
				int i = Math.Max(num3, 0);
				for (int num4 = Math.Min(stringBuilder.m_ChunkLength, num2); i < num4; i++)
				{
					if (stringBuilder.m_ChunkChars[i] == oldChar)
					{
						stringBuilder.m_ChunkChars[i] = newChar;
					}
				}
			}
			if (num3 >= 0)
			{
				break;
			}
			stringBuilder = stringBuilder.m_ChunkPrevious;
		}
		return this;
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe StringBuilder Append(char* value, int valueCount)
	{
		if (valueCount < 0)
		{
			throw new ArgumentOutOfRangeException("valueCount", Environment.GetResourceString("ArgumentOutOfRange_NegativeCount"));
		}
		int num = valueCount + m_ChunkLength;
		if (num <= m_ChunkChars.Length)
		{
			ThreadSafeCopy(value, m_ChunkChars, m_ChunkLength, valueCount);
			m_ChunkLength = num;
		}
		else
		{
			int num2 = m_ChunkChars.Length - m_ChunkLength;
			if (num2 > 0)
			{
				ThreadSafeCopy(value, m_ChunkChars, m_ChunkLength, num2);
				m_ChunkLength = m_ChunkChars.Length;
			}
			int num3 = valueCount - num2;
			ExpandByABlock(num3);
			ThreadSafeCopy(value + num2, m_ChunkChars, 0, num3);
			m_ChunkLength = num3;
		}
		return this;
	}

	[SecurityCritical]
	private unsafe void Insert(int index, char* value, int valueCount)
	{
		if ((uint)index > (uint)Length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (valueCount > 0)
		{
			MakeRoom(index, valueCount, out var chunk, out var indexInChunk, doneMoveFollowingChars: false);
			ReplaceInPlaceAtChunk(ref chunk, ref indexInChunk, value, valueCount);
		}
	}

	[SecuritySafeCritical]
	private unsafe void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value)
	{
		if (replacementsCount <= 0)
		{
			return;
		}
		fixed (char* value2 = value)
		{
			int num = (value.Length - removeCount) * replacementsCount;
			StringBuilder chunk = sourceChunk;
			int indexInChunk = replacements[0];
			if (num > 0)
			{
				MakeRoom(chunk.m_ChunkOffset + indexInChunk, num, out chunk, out indexInChunk, doneMoveFollowingChars: true);
			}
			int num2 = 0;
			while (true)
			{
				ReplaceInPlaceAtChunk(ref chunk, ref indexInChunk, value2, value.Length);
				int num3 = replacements[num2] + removeCount;
				num2++;
				if (num2 >= replacementsCount)
				{
					break;
				}
				int num4 = replacements[num2];
				if (num != 0)
				{
					fixed (char* value3 = &sourceChunk.m_ChunkChars[num3])
					{
						ReplaceInPlaceAtChunk(ref chunk, ref indexInChunk, value3, num4 - num3);
					}
				}
				else
				{
					indexInChunk += num4 - num3;
				}
			}
			if (num < 0)
			{
				Remove(chunk.m_ChunkOffset + indexInChunk, -num, out chunk, out indexInChunk);
			}
		}
	}

	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value)
	{
		for (int i = 0; i < value.Length; i++)
		{
			if (count == 0)
			{
				return false;
			}
			if (indexInChunk >= chunk.m_ChunkLength)
			{
				chunk = Next(chunk);
				if (chunk == null)
				{
					return false;
				}
				indexInChunk = 0;
			}
			if (value[i] != chunk.m_ChunkChars[indexInChunk])
			{
				return false;
			}
			indexInChunk++;
			count--;
		}
		return true;
	}

	[SecurityCritical]
	private unsafe void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count)
	{
		if (count == 0)
		{
			return;
		}
		while (true)
		{
			int val = chunk.m_ChunkLength - indexInChunk;
			int num = Math.Min(val, count);
			ThreadSafeCopy(value, chunk.m_ChunkChars, indexInChunk, num);
			indexInChunk += num;
			if (indexInChunk >= chunk.m_ChunkLength)
			{
				chunk = Next(chunk);
				indexInChunk = 0;
			}
			count -= num;
			if (count != 0)
			{
				value += num;
				continue;
			}
			break;
		}
	}

	[SecurityCritical]
	private unsafe static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count)
	{
		if (count > 0)
		{
			if ((uint)destinationIndex > (uint)destination.Length || destinationIndex + count > destination.Length)
			{
				throw new ArgumentOutOfRangeException("destinationIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
			}
			fixed (char* dmem = &destination[destinationIndex])
			{
				string.wstrcpy(dmem, sourcePtr, count);
			}
		}
	}

	[SecurityCritical]
	private unsafe static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count)
	{
		if (count > 0)
		{
			if ((uint)sourceIndex > (uint)source.Length || sourceIndex + count > source.Length)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
			}
			fixed (char* sourcePtr = &source[sourceIndex])
			{
				ThreadSafeCopy(sourcePtr, destination, destinationIndex, count);
			}
		}
	}

	[SecurityCritical]
	internal unsafe void InternalCopy(IntPtr dest, int len)
	{
		if (len == 0)
		{
			return;
		}
		bool flag = true;
		byte* ptr = (byte*)dest.ToPointer();
		StringBuilder stringBuilder = FindChunkForByte(len);
		do
		{
			int num = stringBuilder.m_ChunkOffset * 2;
			int len2 = stringBuilder.m_ChunkLength * 2;
			fixed (char* ptr2 = &stringBuilder.m_ChunkChars[0])
			{
				byte* src = (byte*)ptr2;
				if (flag)
				{
					flag = false;
					Buffer.Memcpy(ptr + num, src, len - num);
				}
				else
				{
					Buffer.Memcpy(ptr + num, src, len2);
				}
			}
			stringBuilder = stringBuilder.m_ChunkPrevious;
		}
		while (stringBuilder != null);
	}

	private StringBuilder FindChunkForIndex(int index)
	{
		StringBuilder stringBuilder = this;
		while (stringBuilder.m_ChunkOffset > index)
		{
			stringBuilder = stringBuilder.m_ChunkPrevious;
		}
		return stringBuilder;
	}

	private StringBuilder FindChunkForByte(int byteIndex)
	{
		StringBuilder stringBuilder = this;
		while (stringBuilder.m_ChunkOffset * 2 > byteIndex)
		{
			stringBuilder = stringBuilder.m_ChunkPrevious;
		}
		return stringBuilder;
	}

	private StringBuilder Next(StringBuilder chunk)
	{
		if (chunk == this)
		{
			return null;
		}
		return FindChunkForIndex(chunk.m_ChunkOffset + chunk.m_ChunkLength);
	}

	private void ExpandByABlock(int minBlockCharCount)
	{
		if (minBlockCharCount + Length < minBlockCharCount || minBlockCharCount + Length > m_MaxCapacity)
		{
			throw new ArgumentOutOfRangeException("requiredLength", Environment.GetResourceString("ArgumentOutOfRange_SmallCapacity"));
		}
		int num = Math.Max(minBlockCharCount, Math.Min(Length, 8000));
		m_ChunkPrevious = new StringBuilder(this);
		m_ChunkOffset += m_ChunkLength;
		m_ChunkLength = 0;
		if (m_ChunkOffset + num < num)
		{
			m_ChunkChars = null;
			throw new OutOfMemoryException();
		}
		m_ChunkChars = new char[num];
	}

	private StringBuilder(StringBuilder from)
	{
		m_ChunkLength = from.m_ChunkLength;
		m_ChunkOffset = from.m_ChunkOffset;
		m_ChunkChars = from.m_ChunkChars;
		m_ChunkPrevious = from.m_ChunkPrevious;
		m_MaxCapacity = from.m_MaxCapacity;
	}

	[SecuritySafeCritical]
	private unsafe void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars)
	{
		if (count + Length < count || count + Length > m_MaxCapacity)
		{
			throw new ArgumentOutOfRangeException("requiredLength", Environment.GetResourceString("ArgumentOutOfRange_SmallCapacity"));
		}
		chunk = this;
		while (chunk.m_ChunkOffset > index)
		{
			chunk.m_ChunkOffset += count;
			chunk = chunk.m_ChunkPrevious;
		}
		indexInChunk = index - chunk.m_ChunkOffset;
		if (!doneMoveFollowingChars && chunk.m_ChunkLength <= 32 && chunk.m_ChunkChars.Length - chunk.m_ChunkLength >= count)
		{
			int num = chunk.m_ChunkLength;
			while (num > indexInChunk)
			{
				num--;
				chunk.m_ChunkChars[num + count] = chunk.m_ChunkChars[num];
			}
			chunk.m_ChunkLength += count;
			return;
		}
		StringBuilder stringBuilder = new StringBuilder(Math.Max(count, 16), chunk.m_MaxCapacity, chunk.m_ChunkPrevious);
		stringBuilder.m_ChunkLength = count;
		int num2 = Math.Min(count, indexInChunk);
		if (num2 > 0)
		{
			fixed (char* chunkChars = chunk.m_ChunkChars)
			{
				ThreadSafeCopy(chunkChars, stringBuilder.m_ChunkChars, 0, num2);
				int num3 = indexInChunk - num2;
				if (num3 >= 0)
				{
					ThreadSafeCopy(chunkChars + num2, chunk.m_ChunkChars, 0, num3);
					indexInChunk = num3;
				}
			}
		}
		chunk.m_ChunkPrevious = stringBuilder;
		chunk.m_ChunkOffset += count;
		if (num2 < count)
		{
			chunk = stringBuilder;
			indexInChunk = num2;
		}
	}

	private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock)
	{
		m_ChunkChars = new char[size];
		m_MaxCapacity = maxCapacity;
		m_ChunkPrevious = previousBlock;
		if (previousBlock != null)
		{
			m_ChunkOffset = previousBlock.m_ChunkOffset + previousBlock.m_ChunkLength;
		}
	}

	[SecuritySafeCritical]
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk)
	{
		int num = startIndex + count;
		chunk = this;
		StringBuilder stringBuilder = null;
		int num2 = 0;
		while (true)
		{
			if (num - chunk.m_ChunkOffset >= 0)
			{
				if (stringBuilder == null)
				{
					stringBuilder = chunk;
					num2 = num - stringBuilder.m_ChunkOffset;
				}
				if (startIndex - chunk.m_ChunkOffset >= 0)
				{
					break;
				}
			}
			else
			{
				chunk.m_ChunkOffset -= count;
			}
			chunk = chunk.m_ChunkPrevious;
		}
		indexInChunk = startIndex - chunk.m_ChunkOffset;
		int num3 = indexInChunk;
		int count2 = stringBuilder.m_ChunkLength - num2;
		if (stringBuilder != chunk)
		{
			num3 = 0;
			chunk.m_ChunkLength = indexInChunk;
			stringBuilder.m_ChunkPrevious = chunk;
			stringBuilder.m_ChunkOffset = chunk.m_ChunkOffset + chunk.m_ChunkLength;
			if (indexInChunk == 0)
			{
				stringBuilder.m_ChunkPrevious = chunk.m_ChunkPrevious;
				chunk = stringBuilder;
			}
		}
		stringBuilder.m_ChunkLength -= num2 - num3;
		if (num3 != num2)
		{
			ThreadSafeCopy(stringBuilder.m_ChunkChars, num2, stringBuilder.m_ChunkChars, num3, count2);
		}
	}
}
