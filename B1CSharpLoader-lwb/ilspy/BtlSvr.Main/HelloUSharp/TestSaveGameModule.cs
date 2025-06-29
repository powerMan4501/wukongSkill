using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace HelloUSharp;

[UClass]
[USharpPath("/Script/b1-Managed.TestSaveGameModule")]
public class TestSaveGameModule : USaveGame
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	private static bool UserIdx_IsValid;

	private static int UserIdx_Offset;

	private static bool TestObj_IsValid;

	private static int TestObj_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TestSaveGameModule:Name")]
	public string Name
	{
		get
		{
			CheckDestroyed();
			if (!Name_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TestSaveGameModule:Name");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Name_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Name_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TestSaveGameModule:Name");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Name_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TestSaveGameModule:UserIdx")]
	public int UserIdx
	{
		get
		{
			CheckDestroyed();
			if (!UserIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TestSaveGameModule:UserIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, UserIdx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UserIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TestSaveGameModule:UserIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, UserIdx_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TestSaveGameModule:TestObj")]
	public UObject TestObj
	{
		get
		{
			CheckDestroyed();
			if (!TestObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TestSaveGameModule:TestObj");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, TestObj_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TestObj_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TestSaveGameModule:TestObj");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, TestObj_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.TestSaveGameModule");
		Name_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Name");
		Name_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Name", Classes.FStrProperty);
		UserIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UserIdx");
		UserIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UserIdx", Classes.FIntProperty);
		TestObj_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TestObj");
		TestObj_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TestObj", Classes.FObjectProperty);
	}

	static TestSaveGameModule()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TestSaveGameModule)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TestSaveGameModule));
	}
}
