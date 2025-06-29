using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.TapDelayInfo", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FTapDelayInfo
{
	private static bool TapLineMode_IsValid;

	private static FFieldAddress TapLineMode_PropertyAddress;

	private static int TapLineMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.TapDelayInfo:TapLineMode")]
	public ETapLineMode TapLineMode;

	private static bool DelayLength_IsValid;

	private static int DelayLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.TapDelayInfo:DelayLength")]
	public float DelayLength;

	private static bool Gain_IsValid;

	private static int Gain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.TapDelayInfo:Gain")]
	public float Gain;

	private static bool OutputChannel_IsValid;

	private static int OutputChannel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.TapDelayInfo:OutputChannel")]
	public int OutputChannel;

	private static bool PanInDegrees_IsValid;

	private static int PanInDegrees_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.TapDelayInfo:PanInDegrees")]
	public float PanInDegrees;

	private static bool FTapDelayInfo_IsValid;

	private static int FTapDelayInfo_StructSize;

	public FTapDelayInfo Copy()
	{
		return this;
	}

	public static FTapDelayInfo FromNative(IntPtr nativeBuffer)
	{
		return new FTapDelayInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTapDelayInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTapDelayInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTapDelayInfo(nativeBuffer + arrayIndex * FTapDelayInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTapDelayInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTapDelayInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTapDelayInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.TapDelayInfo");
			return;
		}
		EnumMarshaler<ETapLineMode>.ToNative(IntPtr.Add(nativeStruct, TapLineMode_Offset), 0, TapLineMode_PropertyAddress.Address, TapLineMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayLength_Offset), DelayLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Gain_Offset), Gain);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OutputChannel_Offset), OutputChannel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PanInDegrees_Offset), PanInDegrees);
	}

	public FTapDelayInfo(IntPtr nativeStruct)
	{
		if (!FTapDelayInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.TapDelayInfo");
			TapLineMode = ETapLineMode.SendToChannel;
			DelayLength = 0f;
			Gain = 0f;
			OutputChannel = 0;
			PanInDegrees = 0f;
		}
		else
		{
			TapLineMode = EnumMarshaler<ETapLineMode>.FromNative(IntPtr.Add(nativeStruct, TapLineMode_Offset), 0, TapLineMode_PropertyAddress.Address);
			DelayLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayLength_Offset));
			Gain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Gain_Offset));
			OutputChannel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OutputChannel_Offset));
			PanInDegrees = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PanInDegrees_Offset));
		}
	}

	static FTapDelayInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTapDelayInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTapDelayInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.TapDelayInfo");
		FTapDelayInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref TapLineMode_PropertyAddress, intPtr, "TapLineMode");
		TapLineMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TapLineMode");
		TapLineMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TapLineMode", Classes.FEnumProperty);
		DelayLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DelayLength");
		DelayLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DelayLength", Classes.FFloatProperty);
		Gain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Gain");
		Gain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Gain", Classes.FFloatProperty);
		OutputChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputChannel");
		OutputChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputChannel", Classes.FIntProperty);
		PanInDegrees_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PanInDegrees");
		PanInDegrees_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PanInDegrees", Classes.FFloatProperty);
		FTapDelayInfo_IsValid = intPtr != IntPtr.Zero && TapLineMode_IsValid && DelayLength_IsValid && Gain_IsValid && OutputChannel_IsValid && PanInDegrees_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.TapDelayInfo", FTapDelayInfo_IsValid);
	}
}
