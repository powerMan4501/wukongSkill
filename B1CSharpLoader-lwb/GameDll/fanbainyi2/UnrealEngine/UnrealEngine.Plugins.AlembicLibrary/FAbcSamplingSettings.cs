using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.AbcSamplingSettings", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public struct FAbcSamplingSettings
{
	private static bool SamplingType_IsValid;

	private static FFieldAddress SamplingType_PropertyAddress;

	private static int SamplingType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcSamplingSettings:SamplingType")]
	public EAlembicSamplingType SamplingType;

	private static bool FrameSteps_IsValid;

	private static int FrameSteps_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcSamplingSettings:FrameSteps")]
	public int FrameSteps;

	private static bool TimeSteps_IsValid;

	private static int TimeSteps_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcSamplingSettings:TimeSteps")]
	public float TimeSteps;

	private static bool FrameStart_IsValid;

	private static int FrameStart_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcSamplingSettings:FrameStart")]
	public int FrameStart;

	private static bool FrameEnd_IsValid;

	private static int FrameEnd_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcSamplingSettings:FrameEnd")]
	public int FrameEnd;

	private static bool SkipEmpty_IsValid;

	private static FFieldAddress SkipEmpty_PropertyAddress;

	private static int SkipEmpty_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcSamplingSettings:bSkipEmpty")]
	public bool SkipEmpty;

	private static bool FAbcSamplingSettings_IsValid;

	private static int FAbcSamplingSettings_StructSize;

	public FAbcSamplingSettings Copy()
	{
		return this;
	}

	public static FAbcSamplingSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAbcSamplingSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAbcSamplingSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAbcSamplingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAbcSamplingSettings(nativeBuffer + arrayIndex * FAbcSamplingSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAbcSamplingSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAbcSamplingSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAbcSamplingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcSamplingSettings");
			return;
		}
		EnumMarshaler<EAlembicSamplingType>.ToNative(IntPtr.Add(nativeStruct, SamplingType_Offset), 0, SamplingType_PropertyAddress.Address, SamplingType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameSteps_Offset), FrameSteps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TimeSteps_Offset), TimeSteps);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameStart_Offset), FrameStart);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameEnd_Offset), FrameEnd);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipEmpty_Offset), 0, SkipEmpty_PropertyAddress.Address, SkipEmpty);
	}

	public FAbcSamplingSettings(IntPtr nativeStruct)
	{
		if (!FAbcSamplingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcSamplingSettings");
			SamplingType = EAlembicSamplingType.PerFrame;
			FrameSteps = 0;
			TimeSteps = 0f;
			FrameStart = 0;
			FrameEnd = 0;
			SkipEmpty = false;
		}
		else
		{
			SamplingType = EnumMarshaler<EAlembicSamplingType>.FromNative(IntPtr.Add(nativeStruct, SamplingType_Offset), 0, SamplingType_PropertyAddress.Address);
			FrameSteps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameSteps_Offset));
			TimeSteps = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TimeSteps_Offset));
			FrameStart = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameStart_Offset));
			FrameEnd = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameEnd_Offset));
			SkipEmpty = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipEmpty_Offset), 0, SkipEmpty_PropertyAddress.Address);
		}
	}

	static FAbcSamplingSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAbcSamplingSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAbcSamplingSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AlembicLibrary.AbcSamplingSettings");
		FAbcSamplingSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SamplingType_PropertyAddress, intPtr, "SamplingType");
		SamplingType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SamplingType");
		SamplingType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SamplingType", Classes.FEnumProperty);
		FrameSteps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameSteps");
		FrameSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameSteps", Classes.FIntProperty);
		TimeSteps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeSteps");
		TimeSteps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeSteps", Classes.FFloatProperty);
		FrameStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameStart");
		FrameStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameStart", Classes.FIntProperty);
		FrameEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameEnd");
		FrameEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameEnd", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipEmpty_PropertyAddress, intPtr, "bSkipEmpty");
		SkipEmpty_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipEmpty");
		SkipEmpty_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipEmpty", Classes.FBoolProperty);
		FAbcSamplingSettings_IsValid = intPtr != IntPtr.Zero && SamplingType_IsValid && FrameSteps_IsValid && TimeSteps_IsValid && FrameStart_IsValid && FrameEnd_IsValid && SkipEmpty_IsValid;
		NativeReflection.LogStructIsValid("/Script/AlembicLibrary.AbcSamplingSettings", FAbcSamplingSettings_IsValid);
	}
}
