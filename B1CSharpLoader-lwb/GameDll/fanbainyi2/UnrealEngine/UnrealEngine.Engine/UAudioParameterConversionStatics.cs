using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioExtensions;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.AudioParameterConversionStatics", "Engine", UnrealModuleType.Engine)]
public class UAudioParameterConversionStatics : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StringToAudioParameter_IsValid;

	private static IntPtr StringToAudioParameter_FunctionAddress;

	private static int StringToAudioParameter_ParamsSize;

	private static bool StringToAudioParameter_Name_IsValid;

	private static FFieldAddress StringToAudioParameter_Name_PropertyAddress;

	private static int StringToAudioParameter_Name_Offset;

	private static bool StringToAudioParameter_String_IsValid;

	private static FFieldAddress StringToAudioParameter_String_PropertyAddress;

	private static int StringToAudioParameter_String_Offset;

	private static bool StringToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress StringToAudioParameter_ReturnValue_PropertyAddress;

	private static int StringToAudioParameter_ReturnValue_Offset;

	private static bool StringArrayToAudioParameter_IsValid;

	private static IntPtr StringArrayToAudioParameter_FunctionAddress;

	private static int StringArrayToAudioParameter_ParamsSize;

	private static bool StringArrayToAudioParameter_Name_IsValid;

	private static FFieldAddress StringArrayToAudioParameter_Name_PropertyAddress;

	private static int StringArrayToAudioParameter_Name_Offset;

	private static bool StringArrayToAudioParameter_Strings_IsValid;

	private static FFieldAddress StringArrayToAudioParameter_Strings_PropertyAddress;

	private static int StringArrayToAudioParameter_Strings_Offset;

	private static bool StringArrayToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress StringArrayToAudioParameter_ReturnValue_PropertyAddress;

	private static int StringArrayToAudioParameter_ReturnValue_Offset;

	private static bool ObjectToAudioParameter_IsValid;

	private static IntPtr ObjectToAudioParameter_FunctionAddress;

	private static int ObjectToAudioParameter_ParamsSize;

	private static bool ObjectToAudioParameter_Name_IsValid;

	private static FFieldAddress ObjectToAudioParameter_Name_PropertyAddress;

	private static int ObjectToAudioParameter_Name_Offset;

	private static bool ObjectToAudioParameter_Object_IsValid;

	private static FFieldAddress ObjectToAudioParameter_Object_PropertyAddress;

	private static int ObjectToAudioParameter_Object_Offset;

	private static bool ObjectToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress ObjectToAudioParameter_ReturnValue_PropertyAddress;

	private static int ObjectToAudioParameter_ReturnValue_Offset;

	private static bool ObjectArrayToAudioParameter_IsValid;

	private static IntPtr ObjectArrayToAudioParameter_FunctionAddress;

	private static int ObjectArrayToAudioParameter_ParamsSize;

	private static bool ObjectArrayToAudioParameter_Name_IsValid;

	private static FFieldAddress ObjectArrayToAudioParameter_Name_PropertyAddress;

	private static int ObjectArrayToAudioParameter_Name_Offset;

	private static bool ObjectArrayToAudioParameter_Objects_IsValid;

	private static FFieldAddress ObjectArrayToAudioParameter_Objects_PropertyAddress;

	private static int ObjectArrayToAudioParameter_Objects_Offset;

	private static bool ObjectArrayToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress ObjectArrayToAudioParameter_ReturnValue_PropertyAddress;

	private static int ObjectArrayToAudioParameter_ReturnValue_Offset;

	private static bool IntegerToAudioParameter_IsValid;

	private static IntPtr IntegerToAudioParameter_FunctionAddress;

	private static int IntegerToAudioParameter_ParamsSize;

	private static bool IntegerToAudioParameter_Name_IsValid;

	private static FFieldAddress IntegerToAudioParameter_Name_PropertyAddress;

	private static int IntegerToAudioParameter_Name_Offset;

	private static bool IntegerToAudioParameter_Integer_IsValid;

	private static FFieldAddress IntegerToAudioParameter_Integer_PropertyAddress;

	private static int IntegerToAudioParameter_Integer_Offset;

	private static bool IntegerToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress IntegerToAudioParameter_ReturnValue_PropertyAddress;

	private static int IntegerToAudioParameter_ReturnValue_Offset;

	private static bool IntegerArrayToAudioParameter_IsValid;

	private static IntPtr IntegerArrayToAudioParameter_FunctionAddress;

	private static int IntegerArrayToAudioParameter_ParamsSize;

	private static bool IntegerArrayToAudioParameter_Name_IsValid;

	private static FFieldAddress IntegerArrayToAudioParameter_Name_PropertyAddress;

	private static int IntegerArrayToAudioParameter_Name_Offset;

	private static bool IntegerArrayToAudioParameter_Integers_IsValid;

	private static FFieldAddress IntegerArrayToAudioParameter_Integers_PropertyAddress;

	private static int IntegerArrayToAudioParameter_Integers_Offset;

	private static bool IntegerArrayToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress IntegerArrayToAudioParameter_ReturnValue_PropertyAddress;

	private static int IntegerArrayToAudioParameter_ReturnValue_Offset;

	private static bool FloatToAudioParameter_IsValid;

	private static IntPtr FloatToAudioParameter_FunctionAddress;

	private static int FloatToAudioParameter_ParamsSize;

	private static bool FloatToAudioParameter_Name_IsValid;

	private static FFieldAddress FloatToAudioParameter_Name_PropertyAddress;

	private static int FloatToAudioParameter_Name_Offset;

	private static bool FloatToAudioParameter_Float_IsValid;

	private static FFieldAddress FloatToAudioParameter_Float_PropertyAddress;

	private static int FloatToAudioParameter_Float_Offset;

	private static bool FloatToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress FloatToAudioParameter_ReturnValue_PropertyAddress;

	private static int FloatToAudioParameter_ReturnValue_Offset;

	private static bool FloatArrayToAudioParameter_IsValid;

	private static IntPtr FloatArrayToAudioParameter_FunctionAddress;

	private static int FloatArrayToAudioParameter_ParamsSize;

	private static bool FloatArrayToAudioParameter_Name_IsValid;

	private static FFieldAddress FloatArrayToAudioParameter_Name_PropertyAddress;

	private static int FloatArrayToAudioParameter_Name_Offset;

	private static bool FloatArrayToAudioParameter_Floats_IsValid;

	private static FFieldAddress FloatArrayToAudioParameter_Floats_PropertyAddress;

	private static int FloatArrayToAudioParameter_Floats_Offset;

	private static bool FloatArrayToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress FloatArrayToAudioParameter_ReturnValue_PropertyAddress;

	private static int FloatArrayToAudioParameter_ReturnValue_Offset;

	private static bool BooleanToAudioParameter_IsValid;

	private static IntPtr BooleanToAudioParameter_FunctionAddress;

	private static int BooleanToAudioParameter_ParamsSize;

	private static bool BooleanToAudioParameter_Name_IsValid;

	private static FFieldAddress BooleanToAudioParameter_Name_PropertyAddress;

	private static int BooleanToAudioParameter_Name_Offset;

	private static bool BooleanToAudioParameter_Bool_IsValid;

	private static FFieldAddress BooleanToAudioParameter_Bool_PropertyAddress;

	private static int BooleanToAudioParameter_Bool_Offset;

	private static bool BooleanToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress BooleanToAudioParameter_ReturnValue_PropertyAddress;

	private static int BooleanToAudioParameter_ReturnValue_Offset;

	private static bool BooleanArrayToAudioParameter_IsValid;

	private static IntPtr BooleanArrayToAudioParameter_FunctionAddress;

	private static int BooleanArrayToAudioParameter_ParamsSize;

	private static bool BooleanArrayToAudioParameter_Name_IsValid;

	private static FFieldAddress BooleanArrayToAudioParameter_Name_PropertyAddress;

	private static int BooleanArrayToAudioParameter_Name_Offset;

	private static bool BooleanArrayToAudioParameter_Bools_IsValid;

	private static FFieldAddress BooleanArrayToAudioParameter_Bools_PropertyAddress;

	private static int BooleanArrayToAudioParameter_Bools_Offset;

	private static bool BooleanArrayToAudioParameter_ReturnValue_IsValid;

	private static FFieldAddress BooleanArrayToAudioParameter_ReturnValue_PropertyAddress;

	private static int BooleanArrayToAudioParameter_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:StringToAudioParameter")]
	public unsafe static FAudioParameter StringToAudioParameter(FName Name, string String)
	{
		if (!StringToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:StringToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(StringToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StringToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, StringToAudioParameter_Name_Offset), 0, StringToAudioParameter_Name_PropertyAddress.Address, Name);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StringToAudioParameter_String_Offset), 0, StringToAudioParameter_String_PropertyAddress.Address, String);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StringToAudioParameter_FunctionAddress, intPtr, StringToAudioParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StringToAudioParameter_String_PropertyAddress.Address, intPtr);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, StringToAudioParameter_ReturnValue_Offset), 0, StringToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(StringToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:StringArrayToAudioParameter")]
	public unsafe static FAudioParameter StringArrayToAudioParameter(FName Name, List<string> Strings)
	{
		if (!StringArrayToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:StringArrayToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(StringArrayToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StringArrayToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, StringArrayToAudioParameter_Name_Offset), 0, StringArrayToAudioParameter_Name_PropertyAddress.Address, Name);
		new TArrayCopyMarshaler<string>(1, StringArrayToAudioParameter_Strings_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, StringArrayToAudioParameter_Strings_Offset), Strings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StringArrayToAudioParameter_FunctionAddress, intPtr, StringArrayToAudioParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StringArrayToAudioParameter_Strings_PropertyAddress.Address, intPtr);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, StringArrayToAudioParameter_ReturnValue_Offset), 0, StringArrayToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(StringArrayToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:ObjectToAudioParameter")]
	public unsafe static FAudioParameter ObjectToAudioParameter(FName Name, UObject Object)
	{
		if (!ObjectToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:ObjectToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ObjectToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ObjectToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ObjectToAudioParameter_Name_Offset), 0, ObjectToAudioParameter_Name_PropertyAddress.Address, Name);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ObjectToAudioParameter_Object_Offset), 0, ObjectToAudioParameter_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ObjectToAudioParameter_FunctionAddress, intPtr, ObjectToAudioParameter_ParamsSize);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, ObjectToAudioParameter_ReturnValue_Offset), 0, ObjectToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ObjectToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:ObjectArrayToAudioParameter")]
	public unsafe static FAudioParameter ObjectArrayToAudioParameter(FName Name, List<UObject> Objects)
	{
		if (!ObjectArrayToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:ObjectArrayToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ObjectArrayToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ObjectArrayToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ObjectArrayToAudioParameter_Name_Offset), 0, ObjectArrayToAudioParameter_Name_PropertyAddress.Address, Name);
		new TArrayCopyMarshaler<UObject>(1, ObjectArrayToAudioParameter_Objects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, ObjectArrayToAudioParameter_Objects_Offset), Objects);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ObjectArrayToAudioParameter_FunctionAddress, intPtr, ObjectArrayToAudioParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ObjectArrayToAudioParameter_Objects_PropertyAddress.Address, intPtr);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, ObjectArrayToAudioParameter_ReturnValue_Offset), 0, ObjectArrayToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ObjectArrayToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:IntegerToAudioParameter")]
	public unsafe static FAudioParameter IntegerToAudioParameter(FName Name, int Integer)
	{
		if (!IntegerToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:IntegerToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(IntegerToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IntegerToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IntegerToAudioParameter_Name_Offset), 0, IntegerToAudioParameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IntegerToAudioParameter_Integer_Offset), 0, IntegerToAudioParameter_Integer_PropertyAddress.Address, Integer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IntegerToAudioParameter_FunctionAddress, intPtr, IntegerToAudioParameter_ParamsSize);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, IntegerToAudioParameter_ReturnValue_Offset), 0, IntegerToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(IntegerToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:IntegerArrayToAudioParameter")]
	public unsafe static FAudioParameter IntegerArrayToAudioParameter(FName Name, List<int> Integers)
	{
		if (!IntegerArrayToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:IntegerArrayToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(IntegerArrayToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IntegerArrayToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IntegerArrayToAudioParameter_Name_Offset), 0, IntegerArrayToAudioParameter_Name_PropertyAddress.Address, Name);
		new TArrayCopyMarshaler<int>(1, IntegerArrayToAudioParameter_Integers_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, IntegerArrayToAudioParameter_Integers_Offset), Integers);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IntegerArrayToAudioParameter_FunctionAddress, intPtr, IntegerArrayToAudioParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IntegerArrayToAudioParameter_Integers_PropertyAddress.Address, intPtr);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, IntegerArrayToAudioParameter_ReturnValue_Offset), 0, IntegerArrayToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(IntegerArrayToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:FloatToAudioParameter")]
	public unsafe static FAudioParameter FloatToAudioParameter(FName Name, float Float)
	{
		if (!FloatToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:FloatToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FloatToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FloatToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FloatToAudioParameter_Name_Offset), 0, FloatToAudioParameter_Name_PropertyAddress.Address, Name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FloatToAudioParameter_Float_Offset), 0, FloatToAudioParameter_Float_PropertyAddress.Address, Float);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FloatToAudioParameter_FunctionAddress, intPtr, FloatToAudioParameter_ParamsSize);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, FloatToAudioParameter_ReturnValue_Offset), 0, FloatToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FloatToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:FloatArrayToAudioParameter")]
	public unsafe static FAudioParameter FloatArrayToAudioParameter(FName Name, List<float> Floats)
	{
		if (!FloatArrayToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:FloatArrayToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FloatArrayToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FloatArrayToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FloatArrayToAudioParameter_Name_Offset), 0, FloatArrayToAudioParameter_Name_PropertyAddress.Address, Name);
		new TArrayCopyMarshaler<float>(1, FloatArrayToAudioParameter_Floats_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, FloatArrayToAudioParameter_Floats_Offset), Floats);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FloatArrayToAudioParameter_FunctionAddress, intPtr, FloatArrayToAudioParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FloatArrayToAudioParameter_Floats_PropertyAddress.Address, intPtr);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, FloatArrayToAudioParameter_ReturnValue_Offset), 0, FloatArrayToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FloatArrayToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:BooleanToAudioParameter")]
	public unsafe static FAudioParameter BooleanToAudioParameter(FName Name, bool Bool)
	{
		if (!BooleanToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:BooleanToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BooleanToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BooleanToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BooleanToAudioParameter_Name_Offset), 0, BooleanToAudioParameter_Name_PropertyAddress.Address, Name);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BooleanToAudioParameter_Bool_Offset), 0, BooleanToAudioParameter_Bool_PropertyAddress.Address, Bool);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BooleanToAudioParameter_FunctionAddress, intPtr, BooleanToAudioParameter_ParamsSize);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, BooleanToAudioParameter_ReturnValue_Offset), 0, BooleanToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BooleanToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.AudioParameterConversionStatics:BooleanArrayToAudioParameter")]
	public unsafe static FAudioParameter BooleanArrayToAudioParameter(FName Name, List<bool> Bools)
	{
		if (!BooleanArrayToAudioParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioParameterConversionStatics:BooleanArrayToAudioParameter");
			return default(FAudioParameter);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BooleanArrayToAudioParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BooleanArrayToAudioParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BooleanArrayToAudioParameter_Name_Offset), 0, BooleanArrayToAudioParameter_Name_PropertyAddress.Address, Name);
		new TArrayCopyMarshaler<bool>(1, BooleanArrayToAudioParameter_Bools_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, BooleanArrayToAudioParameter_Bools_Offset), Bools);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BooleanArrayToAudioParameter_FunctionAddress, intPtr, BooleanArrayToAudioParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BooleanArrayToAudioParameter_Bools_PropertyAddress.Address, intPtr);
		FAudioParameter result = FAudioParameter.FromNative(IntPtr.Add(intPtr, BooleanArrayToAudioParameter_ReturnValue_Offset), 0, BooleanArrayToAudioParameter_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BooleanArrayToAudioParameter_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAudioParameterConversionStatics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioParameterConversionStatics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioParameterConversionStatics));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.AudioParameterConversionStatics");
		StringToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StringToAudioParameter");
		StringToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(StringToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StringToAudioParameter_Name_PropertyAddress, StringToAudioParameter_FunctionAddress, "Name");
		StringToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(StringToAudioParameter_FunctionAddress, "Name");
		StringToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(StringToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref StringToAudioParameter_String_PropertyAddress, StringToAudioParameter_FunctionAddress, "String");
		StringToAudioParameter_String_Offset = NativeReflectionCached.GetPropertyOffset(StringToAudioParameter_FunctionAddress, "String");
		StringToAudioParameter_String_IsValid = NativeReflectionCached.ValidatePropertyClass(StringToAudioParameter_FunctionAddress, "String", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StringToAudioParameter_ReturnValue_PropertyAddress, StringToAudioParameter_FunctionAddress, "ReturnValue");
		StringToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StringToAudioParameter_FunctionAddress, "ReturnValue");
		StringToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StringToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		StringToAudioParameter_IsValid = StringToAudioParameter_FunctionAddress != IntPtr.Zero && StringToAudioParameter_Name_IsValid && StringToAudioParameter_String_IsValid && StringToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:StringToAudioParameter", StringToAudioParameter_IsValid);
		StringArrayToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StringArrayToAudioParameter");
		StringArrayToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(StringArrayToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StringArrayToAudioParameter_Name_PropertyAddress, StringArrayToAudioParameter_FunctionAddress, "Name");
		StringArrayToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(StringArrayToAudioParameter_FunctionAddress, "Name");
		StringArrayToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(StringArrayToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref StringArrayToAudioParameter_Strings_PropertyAddress, StringArrayToAudioParameter_FunctionAddress, "Strings");
		StringArrayToAudioParameter_Strings_Offset = NativeReflectionCached.GetPropertyOffset(StringArrayToAudioParameter_FunctionAddress, "Strings");
		StringArrayToAudioParameter_Strings_IsValid = NativeReflectionCached.ValidatePropertyClass(StringArrayToAudioParameter_FunctionAddress, "Strings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref StringArrayToAudioParameter_ReturnValue_PropertyAddress, StringArrayToAudioParameter_FunctionAddress, "ReturnValue");
		StringArrayToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StringArrayToAudioParameter_FunctionAddress, "ReturnValue");
		StringArrayToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StringArrayToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		StringArrayToAudioParameter_IsValid = StringArrayToAudioParameter_FunctionAddress != IntPtr.Zero && StringArrayToAudioParameter_Name_IsValid && StringArrayToAudioParameter_Strings_IsValid && StringArrayToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:StringArrayToAudioParameter", StringArrayToAudioParameter_IsValid);
		ObjectToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ObjectToAudioParameter");
		ObjectToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(ObjectToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ObjectToAudioParameter_Name_PropertyAddress, ObjectToAudioParameter_FunctionAddress, "Name");
		ObjectToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(ObjectToAudioParameter_FunctionAddress, "Name");
		ObjectToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(ObjectToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectToAudioParameter_Object_PropertyAddress, ObjectToAudioParameter_FunctionAddress, "Object");
		ObjectToAudioParameter_Object_Offset = NativeReflectionCached.GetPropertyOffset(ObjectToAudioParameter_FunctionAddress, "Object");
		ObjectToAudioParameter_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(ObjectToAudioParameter_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectToAudioParameter_ReturnValue_PropertyAddress, ObjectToAudioParameter_FunctionAddress, "ReturnValue");
		ObjectToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ObjectToAudioParameter_FunctionAddress, "ReturnValue");
		ObjectToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ObjectToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ObjectToAudioParameter_IsValid = ObjectToAudioParameter_FunctionAddress != IntPtr.Zero && ObjectToAudioParameter_Name_IsValid && ObjectToAudioParameter_Object_IsValid && ObjectToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:ObjectToAudioParameter", ObjectToAudioParameter_IsValid);
		ObjectArrayToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ObjectArrayToAudioParameter");
		ObjectArrayToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(ObjectArrayToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ObjectArrayToAudioParameter_Name_PropertyAddress, ObjectArrayToAudioParameter_FunctionAddress, "Name");
		ObjectArrayToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(ObjectArrayToAudioParameter_FunctionAddress, "Name");
		ObjectArrayToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(ObjectArrayToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectArrayToAudioParameter_Objects_PropertyAddress, ObjectArrayToAudioParameter_FunctionAddress, "Objects");
		ObjectArrayToAudioParameter_Objects_Offset = NativeReflectionCached.GetPropertyOffset(ObjectArrayToAudioParameter_FunctionAddress, "Objects");
		ObjectArrayToAudioParameter_Objects_IsValid = NativeReflectionCached.ValidatePropertyClass(ObjectArrayToAudioParameter_FunctionAddress, "Objects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectArrayToAudioParameter_ReturnValue_PropertyAddress, ObjectArrayToAudioParameter_FunctionAddress, "ReturnValue");
		ObjectArrayToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ObjectArrayToAudioParameter_FunctionAddress, "ReturnValue");
		ObjectArrayToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ObjectArrayToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ObjectArrayToAudioParameter_IsValid = ObjectArrayToAudioParameter_FunctionAddress != IntPtr.Zero && ObjectArrayToAudioParameter_Name_IsValid && ObjectArrayToAudioParameter_Objects_IsValid && ObjectArrayToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:ObjectArrayToAudioParameter", ObjectArrayToAudioParameter_IsValid);
		IntegerToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IntegerToAudioParameter");
		IntegerToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(IntegerToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IntegerToAudioParameter_Name_PropertyAddress, IntegerToAudioParameter_FunctionAddress, "Name");
		IntegerToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(IntegerToAudioParameter_FunctionAddress, "Name");
		IntegerToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(IntegerToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IntegerToAudioParameter_Integer_PropertyAddress, IntegerToAudioParameter_FunctionAddress, "Integer");
		IntegerToAudioParameter_Integer_Offset = NativeReflectionCached.GetPropertyOffset(IntegerToAudioParameter_FunctionAddress, "Integer");
		IntegerToAudioParameter_Integer_IsValid = NativeReflectionCached.ValidatePropertyClass(IntegerToAudioParameter_FunctionAddress, "Integer", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IntegerToAudioParameter_ReturnValue_PropertyAddress, IntegerToAudioParameter_FunctionAddress, "ReturnValue");
		IntegerToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IntegerToAudioParameter_FunctionAddress, "ReturnValue");
		IntegerToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IntegerToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		IntegerToAudioParameter_IsValid = IntegerToAudioParameter_FunctionAddress != IntPtr.Zero && IntegerToAudioParameter_Name_IsValid && IntegerToAudioParameter_Integer_IsValid && IntegerToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:IntegerToAudioParameter", IntegerToAudioParameter_IsValid);
		IntegerArrayToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IntegerArrayToAudioParameter");
		IntegerArrayToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(IntegerArrayToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IntegerArrayToAudioParameter_Name_PropertyAddress, IntegerArrayToAudioParameter_FunctionAddress, "Name");
		IntegerArrayToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(IntegerArrayToAudioParameter_FunctionAddress, "Name");
		IntegerArrayToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(IntegerArrayToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IntegerArrayToAudioParameter_Integers_PropertyAddress, IntegerArrayToAudioParameter_FunctionAddress, "Integers");
		IntegerArrayToAudioParameter_Integers_Offset = NativeReflectionCached.GetPropertyOffset(IntegerArrayToAudioParameter_FunctionAddress, "Integers");
		IntegerArrayToAudioParameter_Integers_IsValid = NativeReflectionCached.ValidatePropertyClass(IntegerArrayToAudioParameter_FunctionAddress, "Integers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IntegerArrayToAudioParameter_ReturnValue_PropertyAddress, IntegerArrayToAudioParameter_FunctionAddress, "ReturnValue");
		IntegerArrayToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IntegerArrayToAudioParameter_FunctionAddress, "ReturnValue");
		IntegerArrayToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IntegerArrayToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		IntegerArrayToAudioParameter_IsValid = IntegerArrayToAudioParameter_FunctionAddress != IntPtr.Zero && IntegerArrayToAudioParameter_Name_IsValid && IntegerArrayToAudioParameter_Integers_IsValid && IntegerArrayToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:IntegerArrayToAudioParameter", IntegerArrayToAudioParameter_IsValid);
		FloatToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FloatToAudioParameter");
		FloatToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(FloatToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FloatToAudioParameter_Name_PropertyAddress, FloatToAudioParameter_FunctionAddress, "Name");
		FloatToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(FloatToAudioParameter_FunctionAddress, "Name");
		FloatToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(FloatToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FloatToAudioParameter_Float_PropertyAddress, FloatToAudioParameter_FunctionAddress, "Float");
		FloatToAudioParameter_Float_Offset = NativeReflectionCached.GetPropertyOffset(FloatToAudioParameter_FunctionAddress, "Float");
		FloatToAudioParameter_Float_IsValid = NativeReflectionCached.ValidatePropertyClass(FloatToAudioParameter_FunctionAddress, "Float", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FloatToAudioParameter_ReturnValue_PropertyAddress, FloatToAudioParameter_FunctionAddress, "ReturnValue");
		FloatToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FloatToAudioParameter_FunctionAddress, "ReturnValue");
		FloatToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FloatToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FloatToAudioParameter_IsValid = FloatToAudioParameter_FunctionAddress != IntPtr.Zero && FloatToAudioParameter_Name_IsValid && FloatToAudioParameter_Float_IsValid && FloatToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:FloatToAudioParameter", FloatToAudioParameter_IsValid);
		FloatArrayToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FloatArrayToAudioParameter");
		FloatArrayToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(FloatArrayToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FloatArrayToAudioParameter_Name_PropertyAddress, FloatArrayToAudioParameter_FunctionAddress, "Name");
		FloatArrayToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(FloatArrayToAudioParameter_FunctionAddress, "Name");
		FloatArrayToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(FloatArrayToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FloatArrayToAudioParameter_Floats_PropertyAddress, FloatArrayToAudioParameter_FunctionAddress, "Floats");
		FloatArrayToAudioParameter_Floats_Offset = NativeReflectionCached.GetPropertyOffset(FloatArrayToAudioParameter_FunctionAddress, "Floats");
		FloatArrayToAudioParameter_Floats_IsValid = NativeReflectionCached.ValidatePropertyClass(FloatArrayToAudioParameter_FunctionAddress, "Floats", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FloatArrayToAudioParameter_ReturnValue_PropertyAddress, FloatArrayToAudioParameter_FunctionAddress, "ReturnValue");
		FloatArrayToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FloatArrayToAudioParameter_FunctionAddress, "ReturnValue");
		FloatArrayToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FloatArrayToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FloatArrayToAudioParameter_IsValid = FloatArrayToAudioParameter_FunctionAddress != IntPtr.Zero && FloatArrayToAudioParameter_Name_IsValid && FloatArrayToAudioParameter_Floats_IsValid && FloatArrayToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:FloatArrayToAudioParameter", FloatArrayToAudioParameter_IsValid);
		BooleanToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BooleanToAudioParameter");
		BooleanToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(BooleanToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BooleanToAudioParameter_Name_PropertyAddress, BooleanToAudioParameter_FunctionAddress, "Name");
		BooleanToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(BooleanToAudioParameter_FunctionAddress, "Name");
		BooleanToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(BooleanToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BooleanToAudioParameter_Bool_PropertyAddress, BooleanToAudioParameter_FunctionAddress, "Bool");
		BooleanToAudioParameter_Bool_Offset = NativeReflectionCached.GetPropertyOffset(BooleanToAudioParameter_FunctionAddress, "Bool");
		BooleanToAudioParameter_Bool_IsValid = NativeReflectionCached.ValidatePropertyClass(BooleanToAudioParameter_FunctionAddress, "Bool", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BooleanToAudioParameter_ReturnValue_PropertyAddress, BooleanToAudioParameter_FunctionAddress, "ReturnValue");
		BooleanToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BooleanToAudioParameter_FunctionAddress, "ReturnValue");
		BooleanToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BooleanToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BooleanToAudioParameter_IsValid = BooleanToAudioParameter_FunctionAddress != IntPtr.Zero && BooleanToAudioParameter_Name_IsValid && BooleanToAudioParameter_Bool_IsValid && BooleanToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:BooleanToAudioParameter", BooleanToAudioParameter_IsValid);
		BooleanArrayToAudioParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BooleanArrayToAudioParameter");
		BooleanArrayToAudioParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(BooleanArrayToAudioParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BooleanArrayToAudioParameter_Name_PropertyAddress, BooleanArrayToAudioParameter_FunctionAddress, "Name");
		BooleanArrayToAudioParameter_Name_Offset = NativeReflectionCached.GetPropertyOffset(BooleanArrayToAudioParameter_FunctionAddress, "Name");
		BooleanArrayToAudioParameter_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(BooleanArrayToAudioParameter_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BooleanArrayToAudioParameter_Bools_PropertyAddress, BooleanArrayToAudioParameter_FunctionAddress, "Bools");
		BooleanArrayToAudioParameter_Bools_Offset = NativeReflectionCached.GetPropertyOffset(BooleanArrayToAudioParameter_FunctionAddress, "Bools");
		BooleanArrayToAudioParameter_Bools_IsValid = NativeReflectionCached.ValidatePropertyClass(BooleanArrayToAudioParameter_FunctionAddress, "Bools", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BooleanArrayToAudioParameter_ReturnValue_PropertyAddress, BooleanArrayToAudioParameter_FunctionAddress, "ReturnValue");
		BooleanArrayToAudioParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BooleanArrayToAudioParameter_FunctionAddress, "ReturnValue");
		BooleanArrayToAudioParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BooleanArrayToAudioParameter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BooleanArrayToAudioParameter_IsValid = BooleanArrayToAudioParameter_FunctionAddress != IntPtr.Zero && BooleanArrayToAudioParameter_Name_IsValid && BooleanArrayToAudioParameter_Bools_IsValid && BooleanArrayToAudioParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioParameterConversionStatics:BooleanArrayToAudioParameter", BooleanArrayToAudioParameter_IsValid);
	}
}
