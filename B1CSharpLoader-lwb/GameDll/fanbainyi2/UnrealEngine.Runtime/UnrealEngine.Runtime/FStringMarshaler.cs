using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FStringMarshaler
{
	private static int charSize = 2;

	public static readonly string DefaultString = string.Empty;

	public static Encoding Encoding => CharSize switch
	{
		4 => Encoding.UTF32, 
		1 => Encoding.ASCII, 
		_ => Encoding.Unicode, 
	};

	public static int CharSize
	{
		get
		{
			return charSize;
		}
		private set
		{
			charSize = value;
		}
	}

	public static string FromCharPtr(IntPtr address)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FString.FromCharPtr(address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public unsafe static string FromPtr(IntPtr address, bool destory = false)
	{
		if (address == IntPtr.Zero)
		{
			return DefaultString;
		}
		FScriptArray* ptr = (FScriptArray*)(void*)address;
		return FromArray(ref *ptr, destory);
	}

	public static string FromArray(FScriptArray array)
	{
		return FromArray(array, destroy: false);
	}

	public static string FromArray(FScriptArray array, bool destroy)
	{
		return FromArray(ref array, destroy);
	}

	public static string FromArray(ref FScriptArray array, bool destroy = false)
	{
		if (array.Data == IntPtr.Zero)
		{
			return DefaultString;
		}
		byte[] array2 = new byte[array.Count * charSize];
		Marshal.Copy(array.Data, array2, 0, array2.Length);
		string result = Encoding.GetString(array2).TrimEnd(default(char));
		if (destroy)
		{
			Native_FScriptArray.Destroy(ref array);
		}
		return result;
	}

	public static FScriptArray ToArray(string value)
	{
		FScriptArray array = default(FScriptArray);
		ToArray(ref array, value);
		return array;
	}

	public static FScriptArray ToArray(ref FScriptArray array, string value)
	{
		if (value == null)
		{
			array.Destroy();
			return array;
		}
		byte[] bytes = Encoding.GetBytes(value);
		if (bytes.Length != value.Length * CharSize)
		{
			Debugger.Break();
		}
		byte[] array2 = new byte[CharSize];
		int num = value.Length + 1;
		array.Empty(num, CharSize);
		array.Add(CharSize, num);
		Marshal.Copy(array2, 0, array.Data + bytes.Length, array2.Length);
		if (array.Data != IntPtr.Zero && bytes.Length != 0)
		{
			Marshal.Copy(bytes, 0, array.Data, bytes.Length);
		}
		return array;
	}

	public static FScriptArray ToArray(IntPtr arrayAddress, string value)
	{
		FScriptArray array = Marshal.PtrToStructure<FScriptArray>(arrayAddress);
		ToArray(ref array, value);
		Marshal.StructureToPtr(array, arrayAddress, fDeleteOld: false);
		return array;
	}

	public static string FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public static string FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return FromPtr(nativeBuffer + arrayIndex * FScriptArray.StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, string value)
	{
		ToNative(nativeBuffer, 0, IntPtr.Zero, value);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, string value)
	{
		ToArray(nativeBuffer + arrayIndex * FScriptArray.StructSize, value);
	}

	public unsafe static void Destroy(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		FScriptArray* ptr = (FScriptArray*)(void*)(nativeBuffer + arrayIndex * FScriptArray.StructSize);
		ptr->Destroy();
	}

	internal static void OnNativeFunctionsRegistered()
	{
		CharSize = Native_FString.GetCharSize();
	}
}
