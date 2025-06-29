using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSSplineFlyMoveInfo")]
public struct FGSSplineFlyMoveInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSplineFlyMoveInfo:WaitPointDict")]
	public Dictionary<int, FGSSplineFlyMoveWaitPoint> WaitPointDict;

	private static int FGSSplineFlyMoveInfo_StructSize;

	private static int FGSSplineFlyMoveInfo_IsValid;

	private static bool WaitPointDict_IsValid;

	private static int WaitPointDict_Offset;

	private static FFieldAddress WaitPointDict_PropertyAddress;

	public FGSSplineFlyMoveInfo Copy()
	{
		FGSSplineFlyMoveInfo result = this;
		if (WaitPointDict != null)
		{
			result.WaitPointDict = new Dictionary<int, FGSSplineFlyMoveWaitPoint>(WaitPointDict);
		}
		return result;
	}

	public static FGSSplineFlyMoveInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSSplineFlyMoveInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSplineFlyMoveInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSplineFlyMoveInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSplineFlyMoveInfo(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplineFlyMoveInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSplineFlyMoveInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSplineFlyMoveInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSplineFlyMoveInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplineFlyMoveInfo");
		}
		else
		{
			new TMapCopyMarshaler<int, FGSSplineFlyMoveWaitPoint>(1, WaitPointDict_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplineFlyMoveWaitPoint, FGSSplineFlyMoveWaitPoint>.FromNative, CachedMarshalingDelegates<FGSSplineFlyMoveWaitPoint, FGSSplineFlyMoveWaitPoint>.ToNative).ToNative(IntPtr.Add(nativeStruct, WaitPointDict_Offset), WaitPointDict);
		}
	}

	public FGSSplineFlyMoveInfo(IntPtr nativeStruct)
	{
		if (FGSSplineFlyMoveInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSplineFlyMoveInfo");
			WaitPointDict = null;
		}
		else
		{
			WaitPointDict = new TMapCopyMarshaler<int, FGSSplineFlyMoveWaitPoint>(1, WaitPointDict_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FGSSplineFlyMoveWaitPoint, FGSSplineFlyMoveWaitPoint>.FromNative, CachedMarshalingDelegates<FGSSplineFlyMoveWaitPoint, FGSSplineFlyMoveWaitPoint>.ToNative).FromNative(IntPtr.Add(nativeStruct, WaitPointDict_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSplineFlyMoveInfo");
		FGSSplineFlyMoveInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref WaitPointDict_PropertyAddress, intPtr, "WaitPointDict");
		WaitPointDict_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitPointDict");
		WaitPointDict_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitPointDict", Classes.FMapProperty);
		FGSSplineFlyMoveInfo_IsValid = ((intPtr != IntPtr.Zero && WaitPointDict_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSplineFlyMoveInfo", (byte)FGSSplineFlyMoveInfo_IsValid != 0);
	}

	static FGSSplineFlyMoveInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSplineFlyMoveInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSplineFlyMoveInfo));
	}
}
