using System;
using System.Diagnostics;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.ScriptStruct", "CoreUObject", UnrealModuleType.Engine)]
public class UScriptStruct : UStruct
{
	public EStructFlags StructFlags
	{
		get
		{
			return Native_UScriptStruct.Get_StructFlags(base.Address);
		}
		set
		{
			Native_UScriptStruct.Set_StructFlags(base.Address, value);
		}
	}

	public bool HasCppStructOps => Native_UScriptStruct.GetCppStructOps(base.Address) != IntPtr.Zero;

	public static IntPtr GetStructAddress(string path)
	{
		IntPtr intPtr = NativeReflection.FindObject(Classes.UScriptStruct, IntPtr.Zero, path);
		if (intPtr == IntPtr.Zero)
		{
			FName fName = FLinkerLoad.FindNewNameForStruct(new FName(path));
			if (fName != FName.None)
			{
				intPtr = NativeReflection.FindObject(Classes.UScriptStruct, IntPtr.Zero, fName.ToString());
			}
		}
		return intPtr;
	}

	public static UScriptStruct GetStruct(string path)
	{
		IntPtr structAddress = GetStructAddress(path);
		if (structAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UScriptStruct>(structAddress);
		}
		return null;
	}

	public static IntPtr GetStructAddress<T>() where T : struct
	{
		return GetStructAddress(typeof(T));
	}

	public static IntPtr GetStructAddress(Type type)
	{
		UUnrealTypePathAttribute pathAttribute = UnrealTypes.GetPathAttribute(type);
		if (pathAttribute != null)
		{
			if (pathAttribute.IsManagedType)
			{
				return ManagedUnrealTypes.GetStructAddress(type);
			}
			return GetStructAddress(pathAttribute.Path);
		}
		return IntPtr.Zero;
	}

	public static UScriptStruct GetStruct<T>() where T : struct
	{
		return GetStruct(typeof(T));
	}

	public static UScriptStruct GetStruct(Type type)
	{
		IntPtr structAddress = GetStructAddress(type);
		if (structAddress != IntPtr.Zero)
		{
			return GCHelper.Find<UScriptStruct>(structAddress);
		}
		return null;
	}

	public static IntPtr LoadStructAddress(string path)
	{
		return NativeReflection.LoadObject(Classes.UScriptStruct, IntPtr.Zero, path);
	}

	public static UScriptStruct LoadStruct(string path)
	{
		IntPtr intPtr = LoadStructAddress(path);
		if (intPtr != IntPtr.Zero)
		{
			return GCHelper.Find<UScriptStruct>(intPtr);
		}
		return null;
	}

	public static IntPtr LoadStructAddress<T>() where T : struct
	{
		return LoadStructAddress(typeof(T));
	}

	public static IntPtr LoadStructAddress(Type type)
	{
		UUnrealTypePathAttribute pathAttribute = UnrealTypes.GetPathAttribute(type);
		if (pathAttribute != null)
		{
			if (pathAttribute.IsManagedType)
			{
				return ManagedUnrealTypes.GetStructAddress(type);
			}
			return LoadStructAddress(pathAttribute.Path);
		}
		return IntPtr.Zero;
	}

	public static UScriptStruct LoadStruct<T>() where T : struct
	{
		return LoadStruct(typeof(T));
	}

	public static UScriptStruct LoadStruct(Type type)
	{
		IntPtr intPtr = LoadStructAddress(type);
		if (intPtr != IntPtr.Zero)
		{
			return GCHelper.Find<UScriptStruct>(intPtr);
		}
		return null;
	}

	public static IntPtr ResolveStructAddress(string path)
	{
		IntPtr intPtr = GetStructAddress(path);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = LoadStructAddress(path);
		}
		return intPtr;
	}

	public static UScriptStruct ResolveStruct(string path)
	{
		UScriptStruct uScriptStruct = GetStruct(path);
		if (uScriptStruct == null)
		{
			uScriptStruct = LoadStruct(path);
		}
		return uScriptStruct;
	}

	public static IntPtr ResolveStructAddress<T>() where T : struct
	{
		IntPtr intPtr = GetStructAddress<T>();
		if (intPtr == IntPtr.Zero)
		{
			intPtr = LoadStructAddress<T>();
		}
		return intPtr;
	}

	public static IntPtr ResolveStructAddress(Type type)
	{
		IntPtr intPtr = GetStructAddress(type);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = LoadStructAddress(type);
		}
		return intPtr;
	}

	public static UScriptStruct ResolveStruct<T>() where T : struct
	{
		UScriptStruct uScriptStruct = GetStruct<T>();
		if (uScriptStruct == null)
		{
			uScriptStruct = LoadStruct<T>();
		}
		return uScriptStruct;
	}

	public static UScriptStruct ResolveStruct(Type type)
	{
		UScriptStruct uScriptStruct = GetStruct(type);
		if (uScriptStruct == null)
		{
			uScriptStruct = LoadStruct(type);
		}
		return uScriptStruct;
	}

	public ICppStructOps GetCppStructOps()
	{
		return new ICppStructOps(Native_UScriptStruct.GetCppStructOps(base.Address));
	}

	public bool HasDefaults()
	{
		return Native_UScriptStruct.HasDefaults(base.Address);
	}

	public Guid GetCustomGuid()
	{
		Native_UScriptStruct.GetCustomGuid(base.Address, out var result);
		return result;
	}

	public void InitializeDefaultValue(byte[] inStructData)
	{
		if (Native_UScriptStruct.InitializeDefaultValue != null)
		{
			Native_UScriptStruct.InitializeDefaultValue(base.Address, inStructData);
		}
	}

	internal unsafe static bool IsPODZeroInit(IntPtr unrealStruct)
	{
		if (unrealStruct != IntPtr.Zero && (bool)Native_UObjectBaseUtility.IsA(unrealStruct, Classes.UScriptStruct))
		{
			EStructFlags eStructFlags = Native_UScriptStruct.Get_StructFlags(unrealStruct);
			IntPtr intPtr = Native_UScriptStruct.GetCppStructOps(unrealStruct);
			if (intPtr != IntPtr.Zero)
			{
				bool flag = Native_ICppStructOps.IsPlainOldData(intPtr);
				bool flag2 = Native_ICppStructOps.HasZeroConstructor(intPtr);
				bool flag3 = Native_ICppStructOps.HasNoopConstructor(intPtr);
				if (!flag2 && eStructFlags.HasFlag(EStructFlags.ZeroConstructor))
				{
					flag2 = true;
				}
				if (flag && flag2 && !flag3)
				{
					return true;
				}
				if (flag && !flag2)
				{
					if (flag3)
					{
						return false;
					}
					int num = Native_ICppStructOps.GetSize(intPtr);
					IntPtr intPtr2 = FMemory.Malloc(num);
					FMemory.Memzero(intPtr2, num);
					Native_ICppStructOps.Construct(intPtr, intPtr2);
					Native_ICppStructOps.Construct(intPtr, intPtr2);
					bool flag4 = true;
					byte* ptr = (byte*)(void*)intPtr2;
					for (int i = 0; i < num; i++)
					{
						if (ptr[i] != 0)
						{
							flag4 = false;
							break;
						}
					}
					FMemory.Free(intPtr2);
					if (flag4)
					{
						Debugger.Break();
						return true;
					}
				}
				return false;
			}
			return eStructFlags.HasFlag(EStructFlags.IsPlainOldData | EStructFlags.ZeroConstructor);
		}
		return false;
	}
}
