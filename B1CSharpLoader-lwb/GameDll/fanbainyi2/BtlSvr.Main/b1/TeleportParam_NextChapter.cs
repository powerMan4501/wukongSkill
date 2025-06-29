using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TeleportParam_NextChapter")]
public struct TeleportParam_NextChapter
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.TeleportParam_NextChapter:LevelId")]
	public int LevelId;

	public Action TeleportFinishCallback;

	private static int TeleportParam_NextChapter_StructSize;

	private static int TeleportParam_NextChapter_IsValid;

	private static bool LevelId_IsValid;

	private static int LevelId_Offset;

	public TeleportParam_NextChapter Copy()
	{
		return this;
	}

	public static TeleportParam_NextChapter FromNative(IntPtr nativeBuffer)
	{
		return new TeleportParam_NextChapter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, TeleportParam_NextChapter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static TeleportParam_NextChapter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TeleportParam_NextChapter(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_NextChapter_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TeleportParam_NextChapter value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TeleportParam_NextChapter_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TeleportParam_NextChapter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_NextChapter");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LevelId_Offset), LevelId);
		}
	}

	public TeleportParam_NextChapter(IntPtr nativeStruct)
	{
		if (TeleportParam_NextChapter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TeleportParam_NextChapter");
			LevelId = 0;
		}
		else
		{
			LevelId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LevelId_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TeleportParam_NextChapter");
		TeleportParam_NextChapter_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelId_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelId");
		LevelId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelId", Classes.FIntProperty);
		TeleportParam_NextChapter_IsValid = ((intPtr != IntPtr.Zero && LevelId_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TeleportParam_NextChapter", (byte)TeleportParam_NextChapter_IsValid != 0);
	}

	static TeleportParam_NextChapter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TeleportParam_NextChapter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TeleportParam_NextChapter));
	}
}
