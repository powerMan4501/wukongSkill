using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)812646560uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection", "UnrealExtent", UnrealModuleType.Game)]
public class UBGUMovieSceneParameterSection : UMovieSceneSection
{
	private static bool RemoveVectorParameterByName_IsValid;

	private static IntPtr RemoveVectorParameterByName_FunctionAddress;

	private static int RemoveVectorParameterByName_ParamsSize;

	private static bool RemoveVectorParameterByName_InParameterInfoName_IsValid;

	private static FFieldAddress RemoveVectorParameterByName_InParameterInfoName_PropertyAddress;

	private static int RemoveVectorParameterByName_InParameterInfoName_Offset;

	private static bool RemoveVectorParameterByName_ReturnValue_IsValid;

	private static FFieldAddress RemoveVectorParameterByName_ReturnValue_PropertyAddress;

	private static int RemoveVectorParameterByName_ReturnValue_Offset;

	private static bool RemoveVectorParameter_IsValid;

	private static IntPtr RemoveVectorParameter_FunctionAddress;

	private static int RemoveVectorParameter_ParamsSize;

	private static bool RemoveVectorParameter_InParameterInfo_IsValid;

	private static FFieldAddress RemoveVectorParameter_InParameterInfo_PropertyAddress;

	private static int RemoveVectorParameter_InParameterInfo_Offset;

	private static bool RemoveVectorParameter_ReturnValue_IsValid;

	private static FFieldAddress RemoveVectorParameter_ReturnValue_PropertyAddress;

	private static int RemoveVectorParameter_ReturnValue_Offset;

	private static bool RemoveScalarParameterByName_IsValid;

	private static IntPtr RemoveScalarParameterByName_FunctionAddress;

	private static int RemoveScalarParameterByName_ParamsSize;

	private static bool RemoveScalarParameterByName_InParameterInfoName_IsValid;

	private static FFieldAddress RemoveScalarParameterByName_InParameterInfoName_PropertyAddress;

	private static int RemoveScalarParameterByName_InParameterInfoName_Offset;

	private static bool RemoveScalarParameterByName_ReturnValue_IsValid;

	private static FFieldAddress RemoveScalarParameterByName_ReturnValue_PropertyAddress;

	private static int RemoveScalarParameterByName_ReturnValue_Offset;

	private static bool RemoveScalarParameter_IsValid;

	private static IntPtr RemoveScalarParameter_FunctionAddress;

	private static int RemoveScalarParameter_ParamsSize;

	private static bool RemoveScalarParameter_InParameterInfo_IsValid;

	private static FFieldAddress RemoveScalarParameter_InParameterInfo_PropertyAddress;

	private static int RemoveScalarParameter_InParameterInfo_Offset;

	private static bool RemoveScalarParameter_ReturnValue_IsValid;

	private static FFieldAddress RemoveScalarParameter_ReturnValue_PropertyAddress;

	private static int RemoveScalarParameter_ReturnValue_Offset;

	private static bool RemoveColorParameterByName_IsValid;

	private static IntPtr RemoveColorParameterByName_FunctionAddress;

	private static int RemoveColorParameterByName_ParamsSize;

	private static bool RemoveColorParameterByName_InParameterInfoName_IsValid;

	private static FFieldAddress RemoveColorParameterByName_InParameterInfoName_PropertyAddress;

	private static int RemoveColorParameterByName_InParameterInfoName_Offset;

	private static bool RemoveColorParameterByName_ReturnValue_IsValid;

	private static FFieldAddress RemoveColorParameterByName_ReturnValue_PropertyAddress;

	private static int RemoveColorParameterByName_ReturnValue_Offset;

	private static bool RemoveColorParameter_IsValid;

	private static IntPtr RemoveColorParameter_FunctionAddress;

	private static int RemoveColorParameter_ParamsSize;

	private static bool RemoveColorParameter_InParameterInfo_IsValid;

	private static FFieldAddress RemoveColorParameter_InParameterInfo_PropertyAddress;

	private static int RemoveColorParameter_InParameterInfo_Offset;

	private static bool RemoveColorParameter_ReturnValue_IsValid;

	private static FFieldAddress RemoveColorParameter_ReturnValue_PropertyAddress;

	private static int RemoveColorParameter_ReturnValue_Offset;

	private static bool GetParameterInfos_IsValid;

	private static IntPtr GetParameterInfos_FunctionAddress;

	private static int GetParameterInfos_ParamsSize;

	private static bool GetParameterInfos_ParameterInfos_IsValid;

	private static FFieldAddress GetParameterInfos_ParameterInfos_PropertyAddress;

	private static int GetParameterInfos_ParameterInfos_Offset;

	private static bool AddVectorParameterKey_IsValid;

	private static IntPtr AddVectorParameterKey_FunctionAddress;

	private static int AddVectorParameterKey_ParamsSize;

	private static bool AddVectorParameterKey_InParameterInfo_IsValid;

	private static FFieldAddress AddVectorParameterKey_InParameterInfo_PropertyAddress;

	private static int AddVectorParameterKey_InParameterInfo_Offset;

	private static bool AddVectorParameterKey_InTime_IsValid;

	private static FFieldAddress AddVectorParameterKey_InTime_PropertyAddress;

	private static int AddVectorParameterKey_InTime_Offset;

	private static bool AddVectorParameterKey_InValue_IsValid;

	private static FFieldAddress AddVectorParameterKey_InValue_PropertyAddress;

	private static int AddVectorParameterKey_InValue_Offset;

	private static bool AddScalarParameterKey_IsValid;

	private static IntPtr AddScalarParameterKey_FunctionAddress;

	private static int AddScalarParameterKey_ParamsSize;

	private static bool AddScalarParameterKey_InParameterInfo_IsValid;

	private static FFieldAddress AddScalarParameterKey_InParameterInfo_PropertyAddress;

	private static int AddScalarParameterKey_InParameterInfo_Offset;

	private static bool AddScalarParameterKey_InTime_IsValid;

	private static FFieldAddress AddScalarParameterKey_InTime_PropertyAddress;

	private static int AddScalarParameterKey_InTime_Offset;

	private static bool AddScalarParameterKey_InValue_IsValid;

	private static FFieldAddress AddScalarParameterKey_InValue_PropertyAddress;

	private static int AddScalarParameterKey_InValue_Offset;

	private static bool AddColorParameterKey_IsValid;

	private static IntPtr AddColorParameterKey_FunctionAddress;

	private static int AddColorParameterKey_ParamsSize;

	private static bool AddColorParameterKey_InParameterInfo_IsValid;

	private static FFieldAddress AddColorParameterKey_InParameterInfo_PropertyAddress;

	private static int AddColorParameterKey_InParameterInfo_Offset;

	private static bool AddColorParameterKey_InTime_IsValid;

	private static FFieldAddress AddColorParameterKey_InTime_PropertyAddress;

	private static int AddColorParameterKey_InTime_Offset;

	private static bool AddColorParameterKey_InValue_IsValid;

	private static FFieldAddress AddColorParameterKey_InValue_PropertyAddress;

	private static int AddColorParameterKey_InValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveVectorParameterByName")]
	public unsafe bool RemoveVectorParameterByName(FName InParameterInfoName)
	{
		CheckDestroyed();
		if (!RemoveVectorParameterByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveVectorParameterByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveVectorParameterByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveVectorParameterByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveVectorParameterByName_InParameterInfoName_Offset), 0, RemoveVectorParameterByName_InParameterInfoName_PropertyAddress.Address, InParameterInfoName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveVectorParameterByName_FunctionAddress, intPtr, RemoveVectorParameterByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveVectorParameterByName_ReturnValue_Offset), 0, RemoveVectorParameterByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveVectorParameter")]
	public unsafe bool RemoveVectorParameter(FBGUMaterialParameterInfo InParameterInfo)
	{
		CheckDestroyed();
		if (!RemoveVectorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveVectorParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveVectorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveVectorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveVectorParameter_InParameterInfo_PropertyAddress.Address, intPtr);
		FBGUMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, RemoveVectorParameter_InParameterInfo_Offset), 0, RemoveVectorParameter_InParameterInfo_PropertyAddress.Address, InParameterInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveVectorParameter_FunctionAddress, intPtr, RemoveVectorParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveVectorParameter_ReturnValue_Offset), 0, RemoveVectorParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveScalarParameterByName")]
	public unsafe bool RemoveScalarParameterByName(FName InParameterInfoName)
	{
		CheckDestroyed();
		if (!RemoveScalarParameterByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveScalarParameterByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveScalarParameterByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveScalarParameterByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveScalarParameterByName_InParameterInfoName_Offset), 0, RemoveScalarParameterByName_InParameterInfoName_PropertyAddress.Address, InParameterInfoName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveScalarParameterByName_FunctionAddress, intPtr, RemoveScalarParameterByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveScalarParameterByName_ReturnValue_Offset), 0, RemoveScalarParameterByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveScalarParameter")]
	public unsafe bool RemoveScalarParameter(FBGUMaterialParameterInfo InParameterInfo)
	{
		CheckDestroyed();
		if (!RemoveScalarParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveScalarParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveScalarParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveScalarParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveScalarParameter_InParameterInfo_PropertyAddress.Address, intPtr);
		FBGUMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, RemoveScalarParameter_InParameterInfo_Offset), 0, RemoveScalarParameter_InParameterInfo_PropertyAddress.Address, InParameterInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveScalarParameter_FunctionAddress, intPtr, RemoveScalarParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveScalarParameter_ReturnValue_Offset), 0, RemoveScalarParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveColorParameterByName")]
	public unsafe bool RemoveColorParameterByName(FName InParameterInfoName)
	{
		CheckDestroyed();
		if (!RemoveColorParameterByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveColorParameterByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveColorParameterByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveColorParameterByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveColorParameterByName_InParameterInfoName_Offset), 0, RemoveColorParameterByName_InParameterInfoName_PropertyAddress.Address, InParameterInfoName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveColorParameterByName_FunctionAddress, intPtr, RemoveColorParameterByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveColorParameterByName_ReturnValue_Offset), 0, RemoveColorParameterByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveColorParameter")]
	public unsafe bool RemoveColorParameter(FBGUMaterialParameterInfo InParameterInfo)
	{
		CheckDestroyed();
		if (!RemoveColorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveColorParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveColorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveColorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveColorParameter_InParameterInfo_PropertyAddress.Address, intPtr);
		FBGUMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, RemoveColorParameter_InParameterInfo_Offset), 0, RemoveColorParameter_InParameterInfo_PropertyAddress.Address, InParameterInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveColorParameter_FunctionAddress, intPtr, RemoveColorParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveColorParameter_ReturnValue_Offset), 0, RemoveColorParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:GetParameterInfos")]
	public unsafe void GetParameterInfos(out HashSet<FBGUMaterialParameterInfo> ParameterInfos)
	{
		CheckDestroyed();
		if (!GetParameterInfos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:GetParameterInfos");
			ParameterInfos = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterInfos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterInfos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParameterInfos_ParameterInfos_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterInfos_FunctionAddress, intPtr, GetParameterInfos_ParamsSize);
		ParameterInfos = new TSetCopyMarshaler<FBGUMaterialParameterInfo>(1, GetParameterInfos_ParameterInfos_PropertyAddress, CachedMarshalingDelegates<FBGUMaterialParameterInfo, FBGUMaterialParameterInfo>.FromNative, CachedMarshalingDelegates<FBGUMaterialParameterInfo, FBGUMaterialParameterInfo>.ToNative).FromNative(IntPtr.Add(intPtr, GetParameterInfos_ParameterInfos_Offset));
		NativeReflection.DestroyValue_InContainer(GetParameterInfos_ParameterInfos_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:AddVectorParameterKey")]
	public unsafe void AddVectorParameterKey(FBGUMaterialParameterInfo InParameterInfo, FFrameNumber InTime, FVector InValue)
	{
		CheckDestroyed();
		if (!AddVectorParameterKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:AddVectorParameterKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVectorParameterKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVectorParameterKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddVectorParameterKey_InParameterInfo_PropertyAddress.Address, intPtr);
		FBGUMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, AddVectorParameterKey_InParameterInfo_Offset), 0, AddVectorParameterKey_InParameterInfo_PropertyAddress.Address, InParameterInfo);
		NativeReflection.InitializeValue_InContainer(AddVectorParameterKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddVectorParameterKey_InTime_Offset), 0, AddVectorParameterKey_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddVectorParameterKey_InValue_Offset), 0, AddVectorParameterKey_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddVectorParameterKey_FunctionAddress, intPtr, AddVectorParameterKey_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:AddScalarParameterKey")]
	public unsafe void AddScalarParameterKey(FBGUMaterialParameterInfo InParameterInfo, FFrameNumber InTime, float InValue)
	{
		CheckDestroyed();
		if (!AddScalarParameterKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:AddScalarParameterKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddScalarParameterKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddScalarParameterKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddScalarParameterKey_InParameterInfo_PropertyAddress.Address, intPtr);
		FBGUMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, AddScalarParameterKey_InParameterInfo_Offset), 0, AddScalarParameterKey_InParameterInfo_PropertyAddress.Address, InParameterInfo);
		NativeReflection.InitializeValue_InContainer(AddScalarParameterKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddScalarParameterKey_InTime_Offset), 0, AddScalarParameterKey_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddScalarParameterKey_InValue_Offset), 0, AddScalarParameterKey_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddScalarParameterKey_FunctionAddress, intPtr, AddScalarParameterKey_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.BGUMovieSceneParameterSection:AddColorParameterKey")]
	public unsafe void AddColorParameterKey(FBGUMaterialParameterInfo InParameterInfo, FFrameNumber InTime, FLinearColor InValue)
	{
		CheckDestroyed();
		if (!AddColorParameterKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUMovieSceneParameterSection:AddColorParameterKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddColorParameterKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddColorParameterKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddColorParameterKey_InParameterInfo_PropertyAddress.Address, intPtr);
		FBGUMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, AddColorParameterKey_InParameterInfo_Offset), 0, AddColorParameterKey_InParameterInfo_PropertyAddress.Address, InParameterInfo);
		NativeReflection.InitializeValue_InContainer(AddColorParameterKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddColorParameterKey_InTime_Offset), 0, AddColorParameterKey_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, AddColorParameterKey_InValue_Offset), 0, AddColorParameterKey_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddColorParameterKey_FunctionAddress, intPtr, AddColorParameterKey_ParamsSize);
	}

	static UBGUMovieSceneParameterSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUMovieSceneParameterSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUMovieSceneParameterSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.BGUMovieSceneParameterSection");
		RemoveVectorParameterByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveVectorParameterByName");
		RemoveVectorParameterByName_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveVectorParameterByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveVectorParameterByName_InParameterInfoName_PropertyAddress, RemoveVectorParameterByName_FunctionAddress, "InParameterInfoName");
		RemoveVectorParameterByName_InParameterInfoName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVectorParameterByName_FunctionAddress, "InParameterInfoName");
		RemoveVectorParameterByName_InParameterInfoName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVectorParameterByName_FunctionAddress, "InParameterInfoName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveVectorParameterByName_ReturnValue_PropertyAddress, RemoveVectorParameterByName_FunctionAddress, "ReturnValue");
		RemoveVectorParameterByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVectorParameterByName_FunctionAddress, "ReturnValue");
		RemoveVectorParameterByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVectorParameterByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveVectorParameterByName_IsValid = RemoveVectorParameterByName_FunctionAddress != IntPtr.Zero && RemoveVectorParameterByName_InParameterInfoName_IsValid && RemoveVectorParameterByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveVectorParameterByName", RemoveVectorParameterByName_IsValid);
		RemoveVectorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveVectorParameter");
		RemoveVectorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveVectorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveVectorParameter_InParameterInfo_PropertyAddress, RemoveVectorParameter_FunctionAddress, "InParameterInfo");
		RemoveVectorParameter_InParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVectorParameter_FunctionAddress, "InParameterInfo");
		RemoveVectorParameter_InParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVectorParameter_FunctionAddress, "InParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveVectorParameter_ReturnValue_PropertyAddress, RemoveVectorParameter_FunctionAddress, "ReturnValue");
		RemoveVectorParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVectorParameter_FunctionAddress, "ReturnValue");
		RemoveVectorParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVectorParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveVectorParameter_IsValid = RemoveVectorParameter_FunctionAddress != IntPtr.Zero && RemoveVectorParameter_InParameterInfo_IsValid && RemoveVectorParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveVectorParameter", RemoveVectorParameter_IsValid);
		RemoveScalarParameterByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveScalarParameterByName");
		RemoveScalarParameterByName_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveScalarParameterByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveScalarParameterByName_InParameterInfoName_PropertyAddress, RemoveScalarParameterByName_FunctionAddress, "InParameterInfoName");
		RemoveScalarParameterByName_InParameterInfoName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveScalarParameterByName_FunctionAddress, "InParameterInfoName");
		RemoveScalarParameterByName_InParameterInfoName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveScalarParameterByName_FunctionAddress, "InParameterInfoName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveScalarParameterByName_ReturnValue_PropertyAddress, RemoveScalarParameterByName_FunctionAddress, "ReturnValue");
		RemoveScalarParameterByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveScalarParameterByName_FunctionAddress, "ReturnValue");
		RemoveScalarParameterByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveScalarParameterByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveScalarParameterByName_IsValid = RemoveScalarParameterByName_FunctionAddress != IntPtr.Zero && RemoveScalarParameterByName_InParameterInfoName_IsValid && RemoveScalarParameterByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveScalarParameterByName", RemoveScalarParameterByName_IsValid);
		RemoveScalarParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveScalarParameter");
		RemoveScalarParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveScalarParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveScalarParameter_InParameterInfo_PropertyAddress, RemoveScalarParameter_FunctionAddress, "InParameterInfo");
		RemoveScalarParameter_InParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveScalarParameter_FunctionAddress, "InParameterInfo");
		RemoveScalarParameter_InParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveScalarParameter_FunctionAddress, "InParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveScalarParameter_ReturnValue_PropertyAddress, RemoveScalarParameter_FunctionAddress, "ReturnValue");
		RemoveScalarParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveScalarParameter_FunctionAddress, "ReturnValue");
		RemoveScalarParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveScalarParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveScalarParameter_IsValid = RemoveScalarParameter_FunctionAddress != IntPtr.Zero && RemoveScalarParameter_InParameterInfo_IsValid && RemoveScalarParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveScalarParameter", RemoveScalarParameter_IsValid);
		RemoveColorParameterByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveColorParameterByName");
		RemoveColorParameterByName_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveColorParameterByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveColorParameterByName_InParameterInfoName_PropertyAddress, RemoveColorParameterByName_FunctionAddress, "InParameterInfoName");
		RemoveColorParameterByName_InParameterInfoName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveColorParameterByName_FunctionAddress, "InParameterInfoName");
		RemoveColorParameterByName_InParameterInfoName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveColorParameterByName_FunctionAddress, "InParameterInfoName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveColorParameterByName_ReturnValue_PropertyAddress, RemoveColorParameterByName_FunctionAddress, "ReturnValue");
		RemoveColorParameterByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveColorParameterByName_FunctionAddress, "ReturnValue");
		RemoveColorParameterByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveColorParameterByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveColorParameterByName_IsValid = RemoveColorParameterByName_FunctionAddress != IntPtr.Zero && RemoveColorParameterByName_InParameterInfoName_IsValid && RemoveColorParameterByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveColorParameterByName", RemoveColorParameterByName_IsValid);
		RemoveColorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveColorParameter");
		RemoveColorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveColorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveColorParameter_InParameterInfo_PropertyAddress, RemoveColorParameter_FunctionAddress, "InParameterInfo");
		RemoveColorParameter_InParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveColorParameter_FunctionAddress, "InParameterInfo");
		RemoveColorParameter_InParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveColorParameter_FunctionAddress, "InParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveColorParameter_ReturnValue_PropertyAddress, RemoveColorParameter_FunctionAddress, "ReturnValue");
		RemoveColorParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveColorParameter_FunctionAddress, "ReturnValue");
		RemoveColorParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveColorParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveColorParameter_IsValid = RemoveColorParameter_FunctionAddress != IntPtr.Zero && RemoveColorParameter_InParameterInfo_IsValid && RemoveColorParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:RemoveColorParameter", RemoveColorParameter_IsValid);
		GetParameterInfos_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterInfos");
		GetParameterInfos_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterInfos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterInfos_ParameterInfos_PropertyAddress, GetParameterInfos_FunctionAddress, "ParameterInfos");
		GetParameterInfos_ParameterInfos_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterInfos_FunctionAddress, "ParameterInfos");
		GetParameterInfos_ParameterInfos_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterInfos_FunctionAddress, "ParameterInfos", Classes.FSetProperty);
		GetParameterInfos_IsValid = GetParameterInfos_FunctionAddress != IntPtr.Zero && GetParameterInfos_ParameterInfos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:GetParameterInfos", GetParameterInfos_IsValid);
		AddVectorParameterKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddVectorParameterKey");
		AddVectorParameterKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVectorParameterKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVectorParameterKey_InParameterInfo_PropertyAddress, AddVectorParameterKey_FunctionAddress, "InParameterInfo");
		AddVectorParameterKey_InParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorParameterKey_FunctionAddress, "InParameterInfo");
		AddVectorParameterKey_InParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorParameterKey_FunctionAddress, "InParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorParameterKey_InTime_PropertyAddress, AddVectorParameterKey_FunctionAddress, "InTime");
		AddVectorParameterKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorParameterKey_FunctionAddress, "InTime");
		AddVectorParameterKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorParameterKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorParameterKey_InValue_PropertyAddress, AddVectorParameterKey_FunctionAddress, "InValue");
		AddVectorParameterKey_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorParameterKey_FunctionAddress, "InValue");
		AddVectorParameterKey_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorParameterKey_FunctionAddress, "InValue", Classes.FStructProperty);
		AddVectorParameterKey_IsValid = AddVectorParameterKey_FunctionAddress != IntPtr.Zero && AddVectorParameterKey_InParameterInfo_IsValid && AddVectorParameterKey_InTime_IsValid && AddVectorParameterKey_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:AddVectorParameterKey", AddVectorParameterKey_IsValid);
		AddScalarParameterKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddScalarParameterKey");
		AddScalarParameterKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddScalarParameterKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddScalarParameterKey_InParameterInfo_PropertyAddress, AddScalarParameterKey_FunctionAddress, "InParameterInfo");
		AddScalarParameterKey_InParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(AddScalarParameterKey_FunctionAddress, "InParameterInfo");
		AddScalarParameterKey_InParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddScalarParameterKey_FunctionAddress, "InParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddScalarParameterKey_InTime_PropertyAddress, AddScalarParameterKey_FunctionAddress, "InTime");
		AddScalarParameterKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddScalarParameterKey_FunctionAddress, "InTime");
		AddScalarParameterKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddScalarParameterKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddScalarParameterKey_InValue_PropertyAddress, AddScalarParameterKey_FunctionAddress, "InValue");
		AddScalarParameterKey_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddScalarParameterKey_FunctionAddress, "InValue");
		AddScalarParameterKey_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddScalarParameterKey_FunctionAddress, "InValue", Classes.FFloatProperty);
		AddScalarParameterKey_IsValid = AddScalarParameterKey_FunctionAddress != IntPtr.Zero && AddScalarParameterKey_InParameterInfo_IsValid && AddScalarParameterKey_InTime_IsValid && AddScalarParameterKey_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:AddScalarParameterKey", AddScalarParameterKey_IsValid);
		AddColorParameterKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddColorParameterKey");
		AddColorParameterKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddColorParameterKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddColorParameterKey_InParameterInfo_PropertyAddress, AddColorParameterKey_FunctionAddress, "InParameterInfo");
		AddColorParameterKey_InParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(AddColorParameterKey_FunctionAddress, "InParameterInfo");
		AddColorParameterKey_InParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddColorParameterKey_FunctionAddress, "InParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddColorParameterKey_InTime_PropertyAddress, AddColorParameterKey_FunctionAddress, "InTime");
		AddColorParameterKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddColorParameterKey_FunctionAddress, "InTime");
		AddColorParameterKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddColorParameterKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddColorParameterKey_InValue_PropertyAddress, AddColorParameterKey_FunctionAddress, "InValue");
		AddColorParameterKey_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddColorParameterKey_FunctionAddress, "InValue");
		AddColorParameterKey_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddColorParameterKey_FunctionAddress, "InValue", Classes.FStructProperty);
		AddColorParameterKey_IsValid = AddColorParameterKey_FunctionAddress != IntPtr.Zero && AddColorParameterKey_InParameterInfo_IsValid && AddColorParameterKey_InTime_IsValid && AddColorParameterKey_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUMovieSceneParameterSection:AddColorParameterKey", AddColorParameterKey_IsValid);
	}
}
