using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.MoveAMPath")]
public struct FMoveAMPath
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MoveAMPath:OriginPath")]
	public string OriginPath;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MoveAMPath:NewAMName")]
	public string NewAMName;

	private static int MoveAMPath_StructSize;

	private static int MoveAMPath_IsValid;

	private static bool OriginPath_IsValid;

	private static int OriginPath_Offset;

	private static bool NewAMName_IsValid;

	private static int NewAMName_Offset;

	public FMoveAMPath(string _OriginPath, string _NewAMName)
	{
		OriginPath = _OriginPath;
		NewAMName = _NewAMName;
	}

	public FMoveAMPath Copy()
	{
		return this;
	}

	public static FMoveAMPath FromNative(IntPtr nativeBuffer)
	{
		return new FMoveAMPath(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoveAMPath value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoveAMPath FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoveAMPath(IntPtr.Add(nativeBuffer, arrayIndex * MoveAMPath_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoveAMPath value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MoveAMPath_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MoveAMPath_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MoveAMPath");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, OriginPath_Offset), OriginPath);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NewAMName_Offset), NewAMName);
	}

	public FMoveAMPath(IntPtr nativeStruct)
	{
		if (MoveAMPath_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MoveAMPath");
			OriginPath = null;
			NewAMName = null;
		}
		else
		{
			OriginPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, OriginPath_Offset));
			NewAMName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, NewAMName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MoveAMPath");
		MoveAMPath_StructSize = NativeReflection.GetStructSize(intPtr);
		OriginPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "OriginPath");
		OriginPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OriginPath", Classes.FStrProperty);
		NewAMName_Offset = NativeReflection.GetPropertyOffset(intPtr, "NewAMName");
		NewAMName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NewAMName", Classes.FStrProperty);
		MoveAMPath_IsValid = ((intPtr != IntPtr.Zero && OriginPath_IsValid && NewAMName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MoveAMPath", (byte)MoveAMPath_IsValid != 0);
	}

	static FMoveAMPath()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMoveAMPath)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoveAMPath));
	}
}
