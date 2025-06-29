using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.UserActivity", "Engine", UnrealModuleType.Engine)]
public struct FUserActivity
{
	private static bool ActionName_IsValid;

	private static int ActionName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/Engine.UserActivity:ActionName")]
	public string ActionName;

	private static bool FUserActivity_IsValid;

	private static int FUserActivity_StructSize;

	public FUserActivity Copy()
	{
		return this;
	}

	public static FUserActivity FromNative(IntPtr nativeBuffer)
	{
		return new FUserActivity(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUserActivity value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUserActivity FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUserActivity(nativeBuffer + arrayIndex * FUserActivity_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUserActivity value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUserActivity_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUserActivity_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.UserActivity");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActionName_Offset), ActionName);
		}
	}

	public FUserActivity(IntPtr nativeStruct)
	{
		if (!FUserActivity_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.UserActivity");
			ActionName = FStringMarshaler.DefaultString;
		}
		else
		{
			ActionName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActionName_Offset));
		}
	}

	static FUserActivity()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUserActivity)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUserActivity));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.UserActivity");
		FUserActivity_StructSize = NativeReflection.GetStructSize(intPtr);
		ActionName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActionName");
		ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActionName", Classes.FStrProperty);
		FUserActivity_IsValid = intPtr != IntPtr.Zero && ActionName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.UserActivity", FUserActivity_IsValid);
	}
}
