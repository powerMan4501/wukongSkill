using System.Collections;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;

namespace System.Resources;

[ComVisible(true)]
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable
{
	internal sealed class TypeLimitingDeserializationBinder : SerializationBinder
	{
		private RuntimeType _typeToDeserialize;

		private ObjectReader _objectReader;

		internal ObjectReader ObjectReader
		{
			get
			{
				return _objectReader;
			}
			set
			{
				_objectReader = value;
			}
		}

		internal void ExpectingToDeserialize(RuntimeType type)
		{
			_typeToDeserialize = type;
		}

		[SecuritySafeCritical]
		public override Type BindToType(string assemblyName, string typeName)
		{
			AssemblyName asmName = new AssemblyName(assemblyName);
			bool flag = false;
			string[] typesSafeForDeserialization = TypesSafeForDeserialization;
			foreach (string asmTypeName in typesSafeForDeserialization)
			{
				if (ResourceManager.CompareNames(asmTypeName, typeName, asmName))
				{
					flag = true;
					break;
				}
			}
			Type type = ObjectReader.FastBindToType(assemblyName, typeName);
			if (type.IsEnum)
			{
				flag = true;
			}
			if (flag)
			{
				return null;
			}
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResType&SerBlobMismatch", _typeToDeserialize.FullName, typeName));
		}
	}

	internal sealed class ResourceEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private const int ENUM_DONE = int.MinValue;

		private const int ENUM_NOT_STARTED = -1;

		private ResourceReader _reader;

		private bool _currentIsValid;

		private int _currentName;

		private int _dataPosition;

		public object Key
		{
			[SecuritySafeCritical]
			get
			{
				if (_currentName == int.MinValue)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumEnded"));
				}
				if (!_currentIsValid)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
				}
				if (_reader._resCache == null)
				{
					throw new InvalidOperationException(Environment.GetResourceString("ResourceReaderIsClosed"));
				}
				return _reader.AllocateStringForNameIndex(_currentName, out _dataPosition);
			}
		}

		public object Current => Entry;

		internal int DataPosition => _dataPosition;

		public DictionaryEntry Entry
		{
			[SecuritySafeCritical]
			get
			{
				if (_currentName == int.MinValue)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumEnded"));
				}
				if (!_currentIsValid)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
				}
				if (_reader._resCache == null)
				{
					throw new InvalidOperationException(Environment.GetResourceString("ResourceReaderIsClosed"));
				}
				object obj = null;
				string key;
				lock (_reader)
				{
					lock (_reader._resCache)
					{
						key = _reader.AllocateStringForNameIndex(_currentName, out _dataPosition);
						if (_reader._resCache.TryGetValue(key, out var value))
						{
							obj = value.Value;
						}
						if (obj == null)
						{
							obj = ((_dataPosition != -1) ? _reader.LoadObject(_dataPosition) : _reader.GetValueForNameIndex(_currentName));
						}
					}
				}
				return new DictionaryEntry(key, obj);
			}
		}

		public object Value
		{
			get
			{
				if (_currentName == int.MinValue)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumEnded"));
				}
				if (!_currentIsValid)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
				}
				if (_reader._resCache == null)
				{
					throw new InvalidOperationException(Environment.GetResourceString("ResourceReaderIsClosed"));
				}
				return _reader.GetValueForNameIndex(_currentName);
			}
		}

		internal ResourceEnumerator(ResourceReader reader)
		{
			_currentName = -1;
			_reader = reader;
			_dataPosition = -2;
		}

		public bool MoveNext()
		{
			if (_currentName == _reader._numResources - 1 || _currentName == int.MinValue)
			{
				_currentIsValid = false;
				_currentName = int.MinValue;
				return false;
			}
			_currentIsValid = true;
			_currentName++;
			return true;
		}

		public void Reset()
		{
			if (_reader._resCache == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("ResourceReaderIsClosed"));
			}
			_currentIsValid = false;
			_currentName = -1;
		}
	}

	private const int DefaultFileStreamBufferSize = 4096;

	private BinaryReader _store;

	internal Dictionary<string, ResourceLocator> _resCache;

	private long _nameSectionOffset;

	private long _dataSectionOffset;

	private int[] _nameHashes;

	[SecurityCritical]
	private unsafe int* _nameHashesPtr;

	private int[] _namePositions;

	[SecurityCritical]
	private unsafe int* _namePositionsPtr;

	private RuntimeType[] _typeTable;

	private int[] _typeNamePositions;

	private BinaryFormatter _objFormatter;

	private int _numResources;

	private UnmanagedMemoryStream _ums;

	private int _version;

	private bool[] _safeToDeserialize;

	private TypeLimitingDeserializationBinder _typeLimitingBinder;

	private static readonly string[] TypesSafeForDeserialization = new string[21]
	{
		"System.String[], mscorlib, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.DateTime[], mscorlib, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Bitmap, System.Drawing, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Imaging.Metafile, System.Drawing, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Point, System.Drawing, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.PointF, System.Drawing, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Size, System.Drawing, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.SizeF, System.Drawing, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Font, System.Drawing, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Icon, System.Drawing, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
		"System.Drawing.Color, System.Drawing, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Windows.Forms.Cursor, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Windows.Forms.Padding, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Windows.Forms.LinkArea, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Windows.Forms.ImageListStreamer, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Windows.Forms.ListViewGroup, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Windows.Forms.ListViewItem, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Windows.Forms.ListViewItem+ListViewSubItem, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Windows.Forms.ListViewItem+ListViewSubItem+SubItemStyle, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Windows.Forms.OwnerDrawPropertyBag, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089",
		"System.Windows.Forms.TreeNode, System.Windows.Forms, Culture=neutral, PublicKeyToken=b77a5c561934e089"
	};

	[SecuritySafeCritical]
	public ResourceReader(string fileName)
	{
		_resCache = new Dictionary<string, ResourceLocator>(FastResourceComparer.Default);
		_store = new BinaryReader(new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.RandomAccess, Path.GetFileName(fileName), bFromProxy: false), Encoding.UTF8);
		try
		{
			ReadResources();
		}
		catch
		{
			_store.Close();
			throw;
		}
	}

	[SecurityCritical]
	public ResourceReader(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanRead)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_StreamNotReadable"));
		}
		_resCache = new Dictionary<string, ResourceLocator>(FastResourceComparer.Default);
		_store = new BinaryReader(stream, Encoding.UTF8);
		_ums = stream as UnmanagedMemoryStream;
		ReadResources();
	}

	[SecurityCritical]
	internal ResourceReader(Stream stream, Dictionary<string, ResourceLocator> resCache)
	{
		_resCache = resCache;
		_store = new BinaryReader(stream, Encoding.UTF8);
		_ums = stream as UnmanagedMemoryStream;
		ReadResources();
	}

	public void Close()
	{
		Dispose(disposing: true);
	}

	public void Dispose()
	{
		Close();
	}

	[SecuritySafeCritical]
	private unsafe void Dispose(bool disposing)
	{
		if (_store != null)
		{
			_resCache = null;
			if (disposing)
			{
				BinaryReader store = _store;
				_store = null;
				store?.Close();
			}
			_store = null;
			_namePositions = null;
			_nameHashes = null;
			_ums = null;
			_namePositionsPtr = null;
			_nameHashesPtr = null;
		}
	}

	[SecurityCritical]
	internal unsafe static int ReadUnalignedI4(int* p)
	{
		return *(byte*)p | (((byte*)p)[1] << 8) | (((byte*)p)[2] << 16) | (((byte*)p)[3] << 24);
	}

	private void SkipInt32()
	{
		_store.BaseStream.Seek(4L, SeekOrigin.Current);
	}

	private void SkipString()
	{
		int num = _store.Read7BitEncodedInt();
		if (num < 0)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_NegativeStringLength"));
		}
		_store.BaseStream.Seek(num, SeekOrigin.Current);
	}

	[SecuritySafeCritical]
	private unsafe int GetNameHash(int index)
	{
		if (_ums == null)
		{
			return _nameHashes[index];
		}
		return ReadUnalignedI4(_nameHashesPtr + index);
	}

	[SecuritySafeCritical]
	private unsafe int GetNamePosition(int index)
	{
		int num = ((_ums != null) ? ReadUnalignedI4(_namePositionsPtr + index) : _namePositions[index]);
		if (num < 0 || num > _dataSectionOffset - _nameSectionOffset)
		{
			throw new FormatException(Environment.GetResourceString("BadImageFormat_ResourcesNameInvalidOffset", num));
		}
		return num;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IDictionaryEnumerator GetEnumerator()
	{
		if (_resCache == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("ResourceReaderIsClosed"));
		}
		return new ResourceEnumerator(this);
	}

	internal ResourceEnumerator GetEnumeratorInternal()
	{
		return new ResourceEnumerator(this);
	}

	internal int FindPosForResource(string name)
	{
		int num = FastResourceComparer.HashFunction(name);
		int num2 = 0;
		int i = _numResources - 1;
		int num3 = -1;
		bool flag = false;
		while (num2 <= i)
		{
			num3 = num2 + i >> 1;
			int nameHash = GetNameHash(num3);
			int num4 = ((nameHash != num) ? ((nameHash >= num) ? 1 : (-1)) : 0);
			if (num4 == 0)
			{
				flag = true;
				break;
			}
			if (num4 < 0)
			{
				num2 = num3 + 1;
			}
			else
			{
				i = num3 - 1;
			}
		}
		if (!flag)
		{
			return -1;
		}
		if (num2 != num3)
		{
			num2 = num3;
			while (num2 > 0 && GetNameHash(num2 - 1) == num)
			{
				num2--;
			}
		}
		if (i != num3)
		{
			for (i = num3; i < _numResources - 1 && GetNameHash(i + 1) == num; i++)
			{
			}
		}
		lock (this)
		{
			for (int j = num2; j <= i; j++)
			{
				_store.BaseStream.Seek(_nameSectionOffset + GetNamePosition(j), SeekOrigin.Begin);
				if (CompareStringEqualsName(name))
				{
					int num5 = _store.ReadInt32();
					if (num5 < 0 || num5 >= _store.BaseStream.Length - _dataSectionOffset)
					{
						throw new FormatException(Environment.GetResourceString("BadImageFormat_ResourcesDataInvalidOffset", num5));
					}
					return num5;
				}
			}
		}
		return -1;
	}

	[SecuritySafeCritical]
	private unsafe bool CompareStringEqualsName(string name)
	{
		int num = _store.Read7BitEncodedInt();
		if (num < 0)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_NegativeStringLength"));
		}
		if (_ums != null)
		{
			byte* positionPointer = _ums.PositionPointer;
			_ums.Seek(num, SeekOrigin.Current);
			if (_ums.Position > _ums.Length)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesNameTooLong"));
			}
			return FastResourceComparer.CompareOrdinal(positionPointer, num, name) == 0;
		}
		byte[] array = new byte[num];
		int num2 = num;
		while (num2 > 0)
		{
			int num3 = _store.Read(array, num - num2, num2);
			if (num3 == 0)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourceNameCorrupted"));
			}
			num2 -= num3;
		}
		return FastResourceComparer.CompareOrdinal(array, num / 2, name) == 0;
	}

	[SecurityCritical]
	private unsafe string AllocateStringForNameIndex(int index, out int dataOffset)
	{
		long num = GetNamePosition(index);
		int num2;
		byte[] array;
		lock (this)
		{
			_store.BaseStream.Seek(num + _nameSectionOffset, SeekOrigin.Begin);
			num2 = _store.Read7BitEncodedInt();
			if (num2 < 0)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_NegativeStringLength"));
			}
			if (_ums != null)
			{
				if (_ums.Position > _ums.Length - num2)
				{
					throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesIndexTooLong", index));
				}
				string text = null;
				char* positionPointer = (char*)_ums.PositionPointer;
				text = new string(positionPointer, 0, num2 / 2);
				_ums.Position += num2;
				dataOffset = _store.ReadInt32();
				if (dataOffset < 0 || dataOffset >= _store.BaseStream.Length - _dataSectionOffset)
				{
					throw new FormatException(Environment.GetResourceString("BadImageFormat_ResourcesDataInvalidOffset", dataOffset));
				}
				return text;
			}
			array = new byte[num2];
			int num3 = num2;
			while (num3 > 0)
			{
				int num4 = _store.Read(array, num2 - num3, num3);
				if (num4 == 0)
				{
					throw new EndOfStreamException(Environment.GetResourceString("BadImageFormat_ResourceNameCorrupted_NameIndex", index));
				}
				num3 -= num4;
			}
			dataOffset = _store.ReadInt32();
			if (dataOffset < 0 || dataOffset >= _store.BaseStream.Length - _dataSectionOffset)
			{
				throw new FormatException(Environment.GetResourceString("BadImageFormat_ResourcesDataInvalidOffset", dataOffset));
			}
		}
		return Encoding.Unicode.GetString(array, 0, num2);
	}

	private object GetValueForNameIndex(int index)
	{
		long num = GetNamePosition(index);
		lock (this)
		{
			_store.BaseStream.Seek(num + _nameSectionOffset, SeekOrigin.Begin);
			SkipString();
			int num2 = _store.ReadInt32();
			if (num2 < 0 || num2 >= _store.BaseStream.Length - _dataSectionOffset)
			{
				throw new FormatException(Environment.GetResourceString("BadImageFormat_ResourcesDataInvalidOffset", num2));
			}
			if (_version == 1)
			{
				return LoadObjectV1(num2);
			}
			ResourceTypeCode typeCode;
			return LoadObjectV2(num2, out typeCode);
		}
	}

	internal string LoadString(int pos)
	{
		_store.BaseStream.Seek(_dataSectionOffset + pos, SeekOrigin.Begin);
		string result = null;
		int num = _store.Read7BitEncodedInt();
		if (_version == 1)
		{
			if (num == -1)
			{
				return null;
			}
			if (FindType(num) != typeof(string))
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ResourceNotString_Type", FindType(num).FullName));
			}
			result = _store.ReadString();
		}
		else
		{
			ResourceTypeCode resourceTypeCode = (ResourceTypeCode)num;
			if (resourceTypeCode != ResourceTypeCode.String && resourceTypeCode != ResourceTypeCode.Null)
			{
				string text = ((resourceTypeCode >= ResourceTypeCode.StartOfUserTypes) ? FindType((int)(resourceTypeCode - 64)).FullName : resourceTypeCode.ToString());
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ResourceNotString_Type", text));
			}
			if (resourceTypeCode == ResourceTypeCode.String)
			{
				result = _store.ReadString();
			}
		}
		return result;
	}

	internal object LoadObject(int pos)
	{
		if (_version == 1)
		{
			return LoadObjectV1(pos);
		}
		ResourceTypeCode typeCode;
		return LoadObjectV2(pos, out typeCode);
	}

	internal object LoadObject(int pos, out ResourceTypeCode typeCode)
	{
		if (_version == 1)
		{
			object obj = LoadObjectV1(pos);
			typeCode = ((obj is string) ? ResourceTypeCode.String : ResourceTypeCode.StartOfUserTypes);
			return obj;
		}
		return LoadObjectV2(pos, out typeCode);
	}

	internal object LoadObjectV1(int pos)
	{
		try
		{
			return _LoadObjectV1(pos);
		}
		catch (EndOfStreamException inner)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_TypeMismatch"), inner);
		}
		catch (ArgumentOutOfRangeException inner2)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_TypeMismatch"), inner2);
		}
	}

	[SecuritySafeCritical]
	private object _LoadObjectV1(int pos)
	{
		_store.BaseStream.Seek(_dataSectionOffset + pos, SeekOrigin.Begin);
		int num = _store.Read7BitEncodedInt();
		if (num == -1)
		{
			return null;
		}
		RuntimeType runtimeType = FindType(num);
		if (runtimeType == typeof(string))
		{
			return _store.ReadString();
		}
		if (runtimeType == typeof(int))
		{
			return _store.ReadInt32();
		}
		if (runtimeType == typeof(byte))
		{
			return _store.ReadByte();
		}
		if (runtimeType == typeof(sbyte))
		{
			return _store.ReadSByte();
		}
		if (runtimeType == typeof(short))
		{
			return _store.ReadInt16();
		}
		if (runtimeType == typeof(long))
		{
			return _store.ReadInt64();
		}
		if (runtimeType == typeof(ushort))
		{
			return _store.ReadUInt16();
		}
		if (runtimeType == typeof(uint))
		{
			return _store.ReadUInt32();
		}
		if (runtimeType == typeof(ulong))
		{
			return _store.ReadUInt64();
		}
		if (runtimeType == typeof(float))
		{
			return _store.ReadSingle();
		}
		if (runtimeType == typeof(double))
		{
			return _store.ReadDouble();
		}
		if (runtimeType == typeof(DateTime))
		{
			return new DateTime(_store.ReadInt64());
		}
		if (runtimeType == typeof(TimeSpan))
		{
			return new TimeSpan(_store.ReadInt64());
		}
		if (runtimeType == typeof(decimal))
		{
			int[] array = new int[4];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = _store.ReadInt32();
			}
			return new decimal(array);
		}
		return DeserializeObject(num);
	}

	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode)
	{
		try
		{
			return _LoadObjectV2(pos, out typeCode);
		}
		catch (EndOfStreamException inner)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_TypeMismatch"), inner);
		}
		catch (ArgumentOutOfRangeException inner2)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_TypeMismatch"), inner2);
		}
	}

	[SecuritySafeCritical]
	private unsafe object _LoadObjectV2(int pos, out ResourceTypeCode typeCode)
	{
		_store.BaseStream.Seek(_dataSectionOffset + pos, SeekOrigin.Begin);
		typeCode = (ResourceTypeCode)_store.Read7BitEncodedInt();
		switch (typeCode)
		{
		case ResourceTypeCode.Null:
			return null;
		case ResourceTypeCode.String:
			return _store.ReadString();
		case ResourceTypeCode.Boolean:
			return _store.ReadBoolean();
		case ResourceTypeCode.Char:
			return (char)_store.ReadUInt16();
		case ResourceTypeCode.Byte:
			return _store.ReadByte();
		case ResourceTypeCode.SByte:
			return _store.ReadSByte();
		case ResourceTypeCode.Int16:
			return _store.ReadInt16();
		case ResourceTypeCode.UInt16:
			return _store.ReadUInt16();
		case ResourceTypeCode.Int32:
			return _store.ReadInt32();
		case ResourceTypeCode.UInt32:
			return _store.ReadUInt32();
		case ResourceTypeCode.Int64:
			return _store.ReadInt64();
		case ResourceTypeCode.UInt64:
			return _store.ReadUInt64();
		case ResourceTypeCode.Single:
			return _store.ReadSingle();
		case ResourceTypeCode.Double:
			return _store.ReadDouble();
		case ResourceTypeCode.Decimal:
			return _store.ReadDecimal();
		case ResourceTypeCode.DateTime:
		{
			long dateData = _store.ReadInt64();
			return DateTime.FromBinary(dateData);
		}
		case ResourceTypeCode.TimeSpan:
		{
			long ticks = _store.ReadInt64();
			return new TimeSpan(ticks);
		}
		case ResourceTypeCode.ByteArray:
		{
			int num2 = _store.ReadInt32();
			if (num2 < 0)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourceDataLengthInvalid", num2));
			}
			if (_ums == null)
			{
				if (num2 > _store.BaseStream.Length)
				{
					throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourceDataLengthInvalid", num2));
				}
				return _store.ReadBytes(num2);
			}
			if (num2 > _ums.Length - _ums.Position)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourceDataLengthInvalid", num2));
			}
			byte[] array2 = new byte[num2];
			int num3 = _ums.Read(array2, 0, num2);
			return array2;
		}
		case ResourceTypeCode.Stream:
		{
			int num = _store.ReadInt32();
			if (num < 0)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourceDataLengthInvalid", num));
			}
			if (_ums == null)
			{
				byte[] array = _store.ReadBytes(num);
				return new PinnedBufferMemoryStream(array);
			}
			if (num > _ums.Length - _ums.Position)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourceDataLengthInvalid", num));
			}
			return new UnmanagedMemoryStream(_ums.PositionPointer, num, num, FileAccess.Read, skipSecurityCheck: true);
		}
		default:
		{
			if (typeCode < ResourceTypeCode.StartOfUserTypes)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_TypeMismatch"));
			}
			int typeIndex = (int)(typeCode - 64);
			return DeserializeObject(typeIndex);
		}
		}
	}

	[SecurityCritical]
	private object DeserializeObject(int typeIndex)
	{
		RuntimeType runtimeType = FindType(typeIndex);
		if (_safeToDeserialize == null)
		{
			InitSafeToDeserializeArray();
		}
		object obj;
		if (_safeToDeserialize[typeIndex])
		{
			_objFormatter.Binder = _typeLimitingBinder;
			_typeLimitingBinder.ExpectingToDeserialize(runtimeType);
			obj = _objFormatter.UnsafeDeserialize(_store.BaseStream, null);
		}
		else
		{
			_objFormatter.Binder = null;
			obj = _objFormatter.Deserialize(_store.BaseStream);
		}
		if (obj.GetType() != runtimeType)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResType&SerBlobMismatch", runtimeType.FullName, obj.GetType().FullName));
		}
		return obj;
	}

	[SecurityCritical]
	private void ReadResources()
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.File | StreamingContextStates.Persistence));
		_typeLimitingBinder = new TypeLimitingDeserializationBinder();
		binaryFormatter.Binder = _typeLimitingBinder;
		_objFormatter = binaryFormatter;
		try
		{
			_ReadResources();
		}
		catch (EndOfStreamException inner)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"), inner);
		}
		catch (IndexOutOfRangeException inner2)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"), inner2);
		}
	}

	[SecurityCritical]
	private unsafe void _ReadResources()
	{
		int num = _store.ReadInt32();
		if (num != ResourceManager.MagicNumber)
		{
			throw new ArgumentException(Environment.GetResourceString("Resources_StreamNotValid"));
		}
		int num2 = _store.ReadInt32();
		int num3 = _store.ReadInt32();
		if (num3 < 0 || num2 < 0)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"));
		}
		if (num2 > 1)
		{
			_store.BaseStream.Seek(num3, SeekOrigin.Current);
		}
		else
		{
			string text = _store.ReadString();
			AssemblyName asmName = new AssemblyName(ResourceManager.MscorlibName);
			if (!ResourceManager.CompareNames(text, ResourceManager.ResReaderTypeName, asmName))
			{
				throw new NotSupportedException(Environment.GetResourceString("NotSupported_WrongResourceReader_Type", text));
			}
			SkipString();
		}
		int num4 = _store.ReadInt32();
		if (num4 != 2 && num4 != 1)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ResourceFileUnsupportedVersion", 2, num4));
		}
		_version = num4;
		_numResources = _store.ReadInt32();
		if (_numResources < 0)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"));
		}
		int num5 = _store.ReadInt32();
		if (num5 < 0)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"));
		}
		_typeTable = new RuntimeType[num5];
		_typeNamePositions = new int[num5];
		for (int i = 0; i < num5; i++)
		{
			_typeNamePositions[i] = (int)_store.BaseStream.Position;
			SkipString();
		}
		long position = _store.BaseStream.Position;
		int num6 = (int)position & 7;
		if (num6 != 0)
		{
			for (int j = 0; j < 8 - num6; j++)
			{
				_store.ReadByte();
			}
		}
		if (_ums == null)
		{
			_nameHashes = new int[_numResources];
			for (int k = 0; k < _numResources; k++)
			{
				_nameHashes[k] = _store.ReadInt32();
			}
		}
		else
		{
			if ((_numResources & 0xE0000000u) != 0L)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"));
			}
			int num7 = 4 * _numResources;
			_nameHashesPtr = (int*)_ums.PositionPointer;
			_ums.Seek(num7, SeekOrigin.Current);
			byte* positionPointer = _ums.PositionPointer;
		}
		if (_ums == null)
		{
			_namePositions = new int[_numResources];
			for (int l = 0; l < _numResources; l++)
			{
				int num8 = _store.ReadInt32();
				if (num8 < 0)
				{
					throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"));
				}
				_namePositions[l] = num8;
			}
		}
		else
		{
			if ((_numResources & 0xE0000000u) != 0L)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"));
			}
			int num9 = 4 * _numResources;
			_namePositionsPtr = (int*)_ums.PositionPointer;
			_ums.Seek(num9, SeekOrigin.Current);
			byte* positionPointer2 = _ums.PositionPointer;
		}
		_dataSectionOffset = _store.ReadInt32();
		if (_dataSectionOffset < 0)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"));
		}
		_nameSectionOffset = _store.BaseStream.Position;
		if (_dataSectionOffset < _nameSectionOffset)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_ResourcesHeaderCorrupted"));
		}
	}

	private RuntimeType FindType(int typeIndex)
	{
		if (typeIndex < 0 || typeIndex >= _typeTable.Length)
		{
			throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_InvalidType"));
		}
		if (_typeTable[typeIndex] == null)
		{
			long position = _store.BaseStream.Position;
			try
			{
				_store.BaseStream.Position = _typeNamePositions[typeIndex];
				string typeName = _store.ReadString();
				_typeTable[typeIndex] = (RuntimeType)Type.GetType(typeName, throwOnError: true);
			}
			finally
			{
				_store.BaseStream.Position = position;
			}
		}
		return _typeTable[typeIndex];
	}

	[SecurityCritical]
	private void InitSafeToDeserializeArray()
	{
		_safeToDeserialize = new bool[_typeTable.Length];
		for (int i = 0; i < _typeTable.Length; i++)
		{
			long position = _store.BaseStream.Position;
			string text;
			try
			{
				_store.BaseStream.Position = _typeNamePositions[i];
				text = _store.ReadString();
			}
			finally
			{
				_store.BaseStream.Position = position;
			}
			RuntimeType runtimeType = (RuntimeType)Type.GetType(text, throwOnError: false);
			AssemblyName assemblyName;
			string typeName;
			if (runtimeType == null)
			{
				assemblyName = null;
				typeName = text;
			}
			else
			{
				if (runtimeType.BaseType == typeof(Enum))
				{
					_safeToDeserialize[i] = true;
					continue;
				}
				typeName = runtimeType.FullName;
				assemblyName = new AssemblyName();
				RuntimeAssembly runtimeAssembly = (RuntimeAssembly)runtimeType.Assembly;
				assemblyName.Init(runtimeAssembly.GetSimpleName(), runtimeAssembly.GetPublicKey(), null, null, runtimeAssembly.GetLocale(), AssemblyHashAlgorithm.None, AssemblyVersionCompatibility.SameMachine, null, AssemblyNameFlags.PublicKey, null);
			}
			string[] typesSafeForDeserialization = TypesSafeForDeserialization;
			foreach (string asmTypeName in typesSafeForDeserialization)
			{
				if (ResourceManager.CompareNames(asmTypeName, typeName, assemblyName))
				{
					_safeToDeserialize[i] = true;
				}
			}
		}
	}

	public void GetResourceData(string resourceName, out string resourceType, out byte[] resourceData)
	{
		if (resourceName == null)
		{
			throw new ArgumentNullException("resourceName");
		}
		if (_resCache == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("ResourceReaderIsClosed"));
		}
		int[] array = new int[_numResources];
		int num = FindPosForResource(resourceName);
		if (num == -1)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ResourceNameNotExist", resourceName));
		}
		lock (this)
		{
			for (int i = 0; i < _numResources; i++)
			{
				_store.BaseStream.Position = _nameSectionOffset + GetNamePosition(i);
				int num2 = _store.Read7BitEncodedInt();
				if (num2 < 0)
				{
					throw new FormatException(Environment.GetResourceString("BadImageFormat_ResourcesNameInvalidOffset", num2));
				}
				_store.BaseStream.Position += num2;
				int num3 = _store.ReadInt32();
				if (num3 < 0 || num3 >= _store.BaseStream.Length - _dataSectionOffset)
				{
					throw new FormatException(Environment.GetResourceString("BadImageFormat_ResourcesDataInvalidOffset", num3));
				}
				array[i] = num3;
			}
			Array.Sort(array);
			int num4 = Array.BinarySearch(array, num);
			long num5 = ((num4 < _numResources - 1) ? (array[num4 + 1] + _dataSectionOffset) : _store.BaseStream.Length);
			int num6 = (int)(num5 - (num + _dataSectionOffset));
			_store.BaseStream.Position = _dataSectionOffset + num;
			ResourceTypeCode resourceTypeCode = (ResourceTypeCode)_store.Read7BitEncodedInt();
			if (resourceTypeCode < ResourceTypeCode.Null || (int)resourceTypeCode >= 64 + _typeTable.Length)
			{
				throw new BadImageFormatException(Environment.GetResourceString("BadImageFormat_InvalidType"));
			}
			resourceType = TypeNameFromTypeCode(resourceTypeCode);
			num6 -= (int)(_store.BaseStream.Position - (_dataSectionOffset + num));
			byte[] array2 = _store.ReadBytes(num6);
			if (array2.Length != num6)
			{
				throw new FormatException(Environment.GetResourceString("BadImageFormat_ResourceNameCorrupted"));
			}
			resourceData = array2;
		}
	}

	private string TypeNameFromTypeCode(ResourceTypeCode typeCode)
	{
		if (typeCode < ResourceTypeCode.StartOfUserTypes)
		{
			return "ResourceTypeCode." + typeCode;
		}
		int num = (int)(typeCode - 64);
		long position = _store.BaseStream.Position;
		try
		{
			_store.BaseStream.Position = _typeNamePositions[num];
			return _store.ReadString();
		}
		finally
		{
			_store.BaseStream.Position = position;
		}
	}
}
