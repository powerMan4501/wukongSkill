using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSSetLevelStateFailedInfo", "b1", UnrealModuleType.Game)]
public struct FGSSetLevelStateFailedInfo
{
	private static bool LevelName_IsValid;

	private static int LevelName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/b1.GSSetLevelStateFailedInfo:LevelName")]
	public string LevelName;

	private static bool Result_IsValid;

	private static FFieldAddress Result_PropertyAddress;

	private static int Result_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.GSSetLevelStateFailedInfo:Result")]
	public EGSLevelSetResult Result;

	private static bool FGSSetLevelStateFailedInfo_IsValid;

	private static int FGSSetLevelStateFailedInfo_StructSize;

	public FGSSetLevelStateFailedInfo Copy()
	{
		return this;
	}

	public static FGSSetLevelStateFailedInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSSetLevelStateFailedInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSetLevelStateFailedInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSetLevelStateFailedInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSetLevelStateFailedInfo(nativeBuffer + arrayIndex * FGSSetLevelStateFailedInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSetLevelStateFailedInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSSetLevelStateFailedInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSSetLevelStateFailedInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSSetLevelStateFailedInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, LevelName_Offset), LevelName);
		EnumMarshaler<EGSLevelSetResult>.ToNative(IntPtr.Add(nativeStruct, Result_Offset), 0, Result_PropertyAddress.Address, Result);
	}

	public FGSSetLevelStateFailedInfo(IntPtr nativeStruct)
	{
		if (!FGSSetLevelStateFailedInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSSetLevelStateFailedInfo");
			LevelName = FStringMarshaler.DefaultString;
			Result = EGSLevelSetResult.Success;
		}
		else
		{
			LevelName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, LevelName_Offset));
			Result = EnumMarshaler<EGSLevelSetResult>.FromNative(IntPtr.Add(nativeStruct, Result_Offset), 0, Result_PropertyAddress.Address);
		}
	}

	static FGSSetLevelStateFailedInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSSetLevelStateFailedInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSetLevelStateFailedInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSSetLevelStateFailedInfo");
		FGSSetLevelStateFailedInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LevelName");
		LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Result_PropertyAddress, intPtr, "Result");
		Result_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Result");
		Result_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Result", Classes.FEnumProperty);
		FGSSetLevelStateFailedInfo_IsValid = intPtr != IntPtr.Zero && LevelName_IsValid && Result_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSSetLevelStateFailedInfo", FGSSetLevelStateFailedInfo_IsValid);
	}
}
