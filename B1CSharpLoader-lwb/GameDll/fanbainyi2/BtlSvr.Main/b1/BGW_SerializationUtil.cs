using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_SerializationUtil
{
	public static byte[] SerializeObject(this object Obj)
	{
		if (Obj == null)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream();
		new BinaryFormatter().Serialize(memoryStream, Obj);
		memoryStream.Position = 0L;
		byte[] array = new byte[memoryStream.Length];
		memoryStream.Read(array, 0, array.Length);
		memoryStream.Close();
		return array;
	}

	public static object DeserializeObject(this byte[] Bytes)
	{
		if (Bytes == null)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream(Bytes)
		{
			Position = 0L
		};
		object result = new BinaryFormatter().Deserialize(memoryStream);
		memoryStream.Close();
		return result;
	}

	public static byte[] CovertObjectToBytes(this object Obj)
	{
		int num = Marshal.SizeOf(Obj);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(Obj, intPtr, fDeleteOld: false);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	public static byte[] CovertObjectToBytes(this UObject Obj)
	{
		int num = Marshal.SizeOf(Obj);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(Obj, intPtr, fDeleteOld: false);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	public static T CovertBytesToObject<T>(this byte[] Bytes)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(Bytes.Length);
		Marshal.Copy(Bytes, 0, intPtr, Bytes.Length);
		T result = (T)Marshal.PtrToStructure(intPtr, typeof(T));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}
}
