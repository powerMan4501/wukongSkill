using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.InputMappingContextLevelInfo")]
public struct FInputMappingContextLevelInfo
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("注册类型")]
	[USharpPath("/Script/b1-Managed.InputMappingContextLevelInfo:LevelInfoType")]
	public EInputMappingContextLevelInfoType LevelInfoType;

	[DisplayName("相关地图标签")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.InputMappingContextLevelInfo:LevelTag")]
	public ELevelTag LevelTag;

	private static int InputMappingContextLevelInfo_StructSize;

	private static int InputMappingContextLevelInfo_IsValid;

	private static bool LevelInfoType_IsValid;

	private static int LevelInfoType_Offset;

	private static FFieldAddress LevelInfoType_PropertyAddress;

	private static bool LevelTag_IsValid;

	private static int LevelTag_Offset;

	private static FFieldAddress LevelTag_PropertyAddress;

	public bool IsApplied(int LevelId, UObject WorldContext)
	{
		List<int> levelIdList = BGUFuncLibMap.GetLevelIdList(LevelTag, WorldContext);
		return LevelInfoType switch
		{
			EInputMappingContextLevelInfoType.None => true, 
			EInputMappingContextLevelInfoType.OnlyAppliedToLevels => levelIdList.Contains(LevelId), 
			EInputMappingContextLevelInfoType.NotAppliedToLevels => !levelIdList.Contains(LevelId), 
			_ => false, 
		};
	}

	public FInputMappingContextLevelInfo Copy()
	{
		return this;
	}

	public static FInputMappingContextLevelInfo FromNative(IntPtr nativeBuffer)
	{
		return new FInputMappingContextLevelInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputMappingContextLevelInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputMappingContextLevelInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputMappingContextLevelInfo(IntPtr.Add(nativeBuffer, arrayIndex * InputMappingContextLevelInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputMappingContextLevelInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InputMappingContextLevelInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InputMappingContextLevelInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputMappingContextLevelInfo");
			return;
		}
		EnumMarshaler<EInputMappingContextLevelInfoType>.ToNative(IntPtr.Add(nativeStruct, LevelInfoType_Offset), 0, LevelInfoType_PropertyAddress.Address, LevelInfoType);
		EnumMarshaler<ELevelTag>.ToNative(IntPtr.Add(nativeStruct, LevelTag_Offset), 0, LevelTag_PropertyAddress.Address, LevelTag);
	}

	public FInputMappingContextLevelInfo(IntPtr nativeStruct)
	{
		if (InputMappingContextLevelInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputMappingContextLevelInfo");
			LevelInfoType = EInputMappingContextLevelInfoType.None;
			LevelTag = ELevelTag.None;
		}
		else
		{
			LevelInfoType = EnumMarshaler<EInputMappingContextLevelInfoType>.FromNative(IntPtr.Add(nativeStruct, LevelInfoType_Offset), 0, LevelInfoType_PropertyAddress.Address);
			LevelTag = EnumMarshaler<ELevelTag>.FromNative(IntPtr.Add(nativeStruct, LevelTag_Offset), 0, LevelTag_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InputMappingContextLevelInfo");
		InputMappingContextLevelInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref LevelInfoType_PropertyAddress, intPtr, "LevelInfoType");
		LevelInfoType_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelInfoType");
		LevelInfoType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelInfoType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref LevelTag_PropertyAddress, intPtr, "LevelTag");
		LevelTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelTag");
		LevelTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelTag", Classes.FEnumProperty);
		InputMappingContextLevelInfo_IsValid = ((intPtr != IntPtr.Zero && LevelInfoType_IsValid && LevelTag_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InputMappingContextLevelInfo", (byte)InputMappingContextLevelInfo_IsValid != 0);
	}

	static FInputMappingContextLevelInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInputMappingContextLevelInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputMappingContextLevelInfo));
	}
}
