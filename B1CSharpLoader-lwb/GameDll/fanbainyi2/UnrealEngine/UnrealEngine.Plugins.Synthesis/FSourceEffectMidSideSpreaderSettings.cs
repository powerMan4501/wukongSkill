using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectMidSideSpreaderSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectMidSideSpreaderSettings
{
	private static bool SpreadAmount_IsValid;

	private static int SpreadAmount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMidSideSpreaderSettings:SpreadAmount")]
	public float SpreadAmount;

	private static bool InputMode_IsValid;

	private static FFieldAddress InputMode_PropertyAddress;

	private static int InputMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMidSideSpreaderSettings:InputMode")]
	public EStereoChannelMode InputMode;

	private static bool OutputMode_IsValid;

	private static FFieldAddress OutputMode_PropertyAddress;

	private static int OutputMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMidSideSpreaderSettings:OutputMode")]
	public EStereoChannelMode OutputMode;

	private static bool EqualPower_IsValid;

	private static FFieldAddress EqualPower_PropertyAddress;

	private static int EqualPower_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMidSideSpreaderSettings:bEqualPower")]
	public bool EqualPower;

	private static bool FSourceEffectMidSideSpreaderSettings_IsValid;

	private static int FSourceEffectMidSideSpreaderSettings_StructSize;

	public FSourceEffectMidSideSpreaderSettings Copy()
	{
		return this;
	}

	public static FSourceEffectMidSideSpreaderSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectMidSideSpreaderSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectMidSideSpreaderSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectMidSideSpreaderSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectMidSideSpreaderSettings(nativeBuffer + arrayIndex * FSourceEffectMidSideSpreaderSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectMidSideSpreaderSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectMidSideSpreaderSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectMidSideSpreaderSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectMidSideSpreaderSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpreadAmount_Offset), SpreadAmount);
		EnumMarshaler<EStereoChannelMode>.ToNative(IntPtr.Add(nativeStruct, InputMode_Offset), 0, InputMode_PropertyAddress.Address, InputMode);
		EnumMarshaler<EStereoChannelMode>.ToNative(IntPtr.Add(nativeStruct, OutputMode_Offset), 0, OutputMode_PropertyAddress.Address, OutputMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EqualPower_Offset), 0, EqualPower_PropertyAddress.Address, EqualPower);
	}

	public FSourceEffectMidSideSpreaderSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectMidSideSpreaderSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectMidSideSpreaderSettings");
			SpreadAmount = 0f;
			InputMode = EStereoChannelMode.MidSide;
			OutputMode = EStereoChannelMode.MidSide;
			EqualPower = false;
		}
		else
		{
			SpreadAmount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpreadAmount_Offset));
			InputMode = EnumMarshaler<EStereoChannelMode>.FromNative(IntPtr.Add(nativeStruct, InputMode_Offset), 0, InputMode_PropertyAddress.Address);
			OutputMode = EnumMarshaler<EStereoChannelMode>.FromNative(IntPtr.Add(nativeStruct, OutputMode_Offset), 0, OutputMode_PropertyAddress.Address);
			EqualPower = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EqualPower_Offset), 0, EqualPower_PropertyAddress.Address);
		}
	}

	static FSourceEffectMidSideSpreaderSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectMidSideSpreaderSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectMidSideSpreaderSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectMidSideSpreaderSettings");
		FSourceEffectMidSideSpreaderSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		SpreadAmount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpreadAmount");
		SpreadAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpreadAmount", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InputMode_PropertyAddress, intPtr, "InputMode");
		InputMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputMode");
		InputMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputMode_PropertyAddress, intPtr, "OutputMode");
		OutputMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputMode");
		OutputMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualPower_PropertyAddress, intPtr, "bEqualPower");
		EqualPower_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEqualPower");
		EqualPower_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEqualPower", Classes.FBoolProperty);
		FSourceEffectMidSideSpreaderSettings_IsValid = intPtr != IntPtr.Zero && SpreadAmount_IsValid && InputMode_IsValid && OutputMode_IsValid && EqualPower_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectMidSideSpreaderSettings", FSourceEffectMidSideSpreaderSettings_IsValid);
	}
}
