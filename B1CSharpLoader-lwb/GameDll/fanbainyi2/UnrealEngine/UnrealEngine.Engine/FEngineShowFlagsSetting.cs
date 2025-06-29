using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.EngineShowFlagsSetting", "Engine", UnrealModuleType.Engine)]
public struct FEngineShowFlagsSetting
{
	private static bool ShowFlagName_IsValid;

	private static int ShowFlagName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/Engine.EngineShowFlagsSetting:ShowFlagName")]
	public string ShowFlagName;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.EngineShowFlagsSetting:Enabled")]
	public bool Enabled;

	private static bool FEngineShowFlagsSetting_IsValid;

	private static int FEngineShowFlagsSetting_StructSize;

	public FEngineShowFlagsSetting Copy()
	{
		return this;
	}

	public static FEngineShowFlagsSetting FromNative(IntPtr nativeBuffer)
	{
		return new FEngineShowFlagsSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEngineShowFlagsSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEngineShowFlagsSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEngineShowFlagsSetting(nativeBuffer + arrayIndex * FEngineShowFlagsSetting_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEngineShowFlagsSetting value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEngineShowFlagsSetting_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEngineShowFlagsSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.EngineShowFlagsSetting");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ShowFlagName_Offset), ShowFlagName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
	}

	public FEngineShowFlagsSetting(IntPtr nativeStruct)
	{
		if (!FEngineShowFlagsSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.EngineShowFlagsSetting");
			ShowFlagName = FStringMarshaler.DefaultString;
			Enabled = false;
		}
		else
		{
			ShowFlagName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ShowFlagName_Offset));
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
	}

	static FEngineShowFlagsSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEngineShowFlagsSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEngineShowFlagsSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.EngineShowFlagsSetting");
		FEngineShowFlagsSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		ShowFlagName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowFlagName");
		ShowFlagName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowFlagName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "Enabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Enabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Enabled", Classes.FBoolProperty);
		FEngineShowFlagsSetting_IsValid = intPtr != IntPtr.Zero && ShowFlagName_IsValid && Enabled_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.EngineShowFlagsSetting", FEngineShowFlagsSetting_IsValid);
	}
}
