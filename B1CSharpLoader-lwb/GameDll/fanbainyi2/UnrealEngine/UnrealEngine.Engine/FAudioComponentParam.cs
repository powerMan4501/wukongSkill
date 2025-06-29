using System;
using System.Collections.Generic;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.AudioComponentParam", "Engine", UnrealModuleType.Engine)]
public struct FAudioComponentParam
{
	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:ParamName")]
	public FName ParamName;

	private static bool FloatParam_IsValid;

	private static int FloatParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:FloatParam")]
	public float FloatParam;

	private static bool BoolParam_IsValid;

	private static FFieldAddress BoolParam_PropertyAddress;

	private static int BoolParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:BoolParam")]
	public bool BoolParam;

	private static bool IntParam_IsValid;

	private static int IntParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:IntParam")]
	public int IntParam;

	private static bool ObjectParam_IsValid;

	private static int ObjectParam_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:ObjectParam")]
	public UObject ObjectParam;

	private static bool StringParam_IsValid;

	private static int StringParam_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:StringParam")]
	public string StringParam;

	private static bool ArrayFloatParam_IsValid;

	private static FFieldAddress ArrayFloatParam_PropertyAddress;

	private static int ArrayFloatParam_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:ArrayFloatParam")]
	public List<float> ArrayFloatParam;

	private static bool ArrayBoolParam_IsValid;

	private static FFieldAddress ArrayBoolParam_PropertyAddress;

	private static int ArrayBoolParam_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:ArrayBoolParam")]
	public List<bool> ArrayBoolParam;

	private static bool ArrayIntParam_IsValid;

	private static FFieldAddress ArrayIntParam_PropertyAddress;

	private static int ArrayIntParam_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:ArrayIntParam")]
	public List<int> ArrayIntParam;

	private static bool ArrayObjectParam_IsValid;

	private static FFieldAddress ArrayObjectParam_PropertyAddress;

	private static int ArrayObjectParam_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:ArrayObjectParam")]
	public List<UObject> ArrayObjectParam;

	private static bool ArrayStringParam_IsValid;

	private static FFieldAddress ArrayStringParam_PropertyAddress;

	private static int ArrayStringParam_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:ArrayStringParam")]
	public List<string> ArrayStringParam;

	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioExtensions.AudioParameter:ParamType")]
	public EAudioParameterType ParamType;

	private static bool SoundWaveParam_IsValid;

	private static int SoundWaveParam_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.AudioComponentParam:SoundWaveParam")]
	public USoundWave SoundWaveParam;

	private static bool FAudioComponentParam_IsValid;

	private static int FAudioComponentParam_StructSize;

	public FAudioComponentParam Copy()
	{
		FAudioComponentParam result = this;
		if (ArrayFloatParam != null)
		{
			result.ArrayFloatParam = new List<float>(ArrayFloatParam);
		}
		if (ArrayBoolParam != null)
		{
			result.ArrayBoolParam = new List<bool>(ArrayBoolParam);
		}
		if (ArrayIntParam != null)
		{
			result.ArrayIntParam = new List<int>(ArrayIntParam);
		}
		if (ArrayObjectParam != null)
		{
			result.ArrayObjectParam = new List<UObject>(ArrayObjectParam);
		}
		if (ArrayStringParam != null)
		{
			result.ArrayStringParam = new List<string>(ArrayStringParam);
		}
		return result;
	}

	public static FAudioComponentParam FromNative(IntPtr nativeBuffer)
	{
		return new FAudioComponentParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAudioComponentParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAudioComponentParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAudioComponentParam(nativeBuffer + arrayIndex * FAudioComponentParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAudioComponentParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAudioComponentParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAudioComponentParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AudioComponentParam");
			return;
		}
		UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(nativeStruct, SoundWaveParam_Offset), SoundWaveParam);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FloatParam_Offset), FloatParam);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BoolParam_Offset), 0, BoolParam_PropertyAddress.Address, BoolParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IntParam_Offset), IntParam);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, ObjectParam_Offset), ObjectParam);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, StringParam_Offset), StringParam);
		new TArrayCopyMarshaler<float>(1, ArrayFloatParam_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ArrayFloatParam_Offset), ArrayFloatParam);
		new TArrayCopyMarshaler<bool>(1, ArrayBoolParam_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, ArrayBoolParam_Offset), ArrayBoolParam);
		new TArrayCopyMarshaler<int>(1, ArrayIntParam_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ArrayIntParam_Offset), ArrayIntParam);
		new TArrayCopyMarshaler<UObject>(1, ArrayObjectParam_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ArrayObjectParam_Offset), ArrayObjectParam);
		new TArrayCopyMarshaler<string>(1, ArrayStringParam_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, ArrayStringParam_Offset), ArrayStringParam);
		EnumMarshaler<EAudioParameterType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
	}

	public FAudioComponentParam(IntPtr nativeStruct)
	{
		if (!FAudioComponentParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AudioComponentParam");
			SoundWaveParam = null;
			ParamName = default(FName);
			FloatParam = 0f;
			BoolParam = false;
			IntParam = 0;
			ObjectParam = null;
			StringParam = FStringMarshaler.DefaultString;
			ArrayFloatParam = null;
			ArrayBoolParam = null;
			ArrayIntParam = null;
			ArrayObjectParam = null;
			ArrayStringParam = null;
			ParamType = EAudioParameterType.None;
		}
		else
		{
			SoundWaveParam = UObjectMarshaler<USoundWave>.FromNative(IntPtr.Add(nativeStruct, SoundWaveParam_Offset));
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			FloatParam = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FloatParam_Offset));
			BoolParam = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BoolParam_Offset), 0, BoolParam_PropertyAddress.Address);
			IntParam = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IntParam_Offset));
			ObjectParam = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, ObjectParam_Offset));
			StringParam = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, StringParam_Offset));
			ArrayFloatParam = new TArrayCopyMarshaler<float>(1, ArrayFloatParam_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ArrayFloatParam_Offset));
			ArrayBoolParam = new TArrayCopyMarshaler<bool>(1, ArrayBoolParam_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, ArrayBoolParam_Offset));
			ArrayIntParam = new TArrayCopyMarshaler<int>(1, ArrayIntParam_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ArrayIntParam_Offset));
			ArrayObjectParam = new TArrayCopyMarshaler<UObject>(1, ArrayObjectParam_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ArrayObjectParam_Offset));
			ArrayStringParam = new TArrayCopyMarshaler<string>(1, ArrayStringParam_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, ArrayStringParam_Offset));
			ParamType = EnumMarshaler<EAudioParameterType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
		}
	}

	static FAudioComponentParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAudioComponentParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAudioComponentParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AudioComponentParam");
		FAudioComponentParam_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		FloatParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloatParam");
		FloatParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloatParam", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BoolParam_PropertyAddress, intPtr, "BoolParam");
		BoolParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoolParam");
		BoolParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoolParam", Classes.FBoolProperty);
		IntParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IntParam");
		IntParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IntParam", Classes.FIntProperty);
		ObjectParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectParam");
		ObjectParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectParam", Classes.FObjectProperty);
		StringParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StringParam");
		StringParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StringParam", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ArrayFloatParam_PropertyAddress, intPtr, "ArrayFloatParam");
		ArrayFloatParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArrayFloatParam");
		ArrayFloatParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArrayFloatParam", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ArrayBoolParam_PropertyAddress, intPtr, "ArrayBoolParam");
		ArrayBoolParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArrayBoolParam");
		ArrayBoolParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArrayBoolParam", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ArrayIntParam_PropertyAddress, intPtr, "ArrayIntParam");
		ArrayIntParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArrayIntParam");
		ArrayIntParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArrayIntParam", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ArrayObjectParam_PropertyAddress, intPtr, "ArrayObjectParam");
		ArrayObjectParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArrayObjectParam");
		ArrayObjectParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArrayObjectParam", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ArrayStringParam_PropertyAddress, intPtr, "ArrayStringParam");
		ArrayStringParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArrayStringParam");
		ArrayStringParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArrayStringParam", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		SoundWaveParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoundWaveParam");
		SoundWaveParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoundWaveParam", Classes.FObjectProperty);
		FAudioComponentParam_IsValid = intPtr != IntPtr.Zero && SoundWaveParam_IsValid && ParamName_IsValid && FloatParam_IsValid && BoolParam_IsValid && IntParam_IsValid && ObjectParam_IsValid && StringParam_IsValid && ArrayFloatParam_IsValid && ArrayBoolParam_IsValid && ArrayIntParam_IsValid && ArrayObjectParam_IsValid && ArrayStringParam_IsValid && ParamType_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AudioComponentParam", FAudioComponentParam_IsValid);
	}
}
