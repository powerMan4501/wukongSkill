using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)812646560uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieSceneParameterSection : UMovieSceneSection
{
	private static bool RemoveVectorParameter_IsValid;

	private static IntPtr RemoveVectorParameter_FunctionAddress;

	private static int RemoveVectorParameter_ParamsSize;

	private static bool RemoveVectorParameter_InParameterName_IsValid;

	private static FFieldAddress RemoveVectorParameter_InParameterName_PropertyAddress;

	private static int RemoveVectorParameter_InParameterName_Offset;

	private static bool RemoveVectorParameter_ReturnValue_IsValid;

	private static FFieldAddress RemoveVectorParameter_ReturnValue_PropertyAddress;

	private static int RemoveVectorParameter_ReturnValue_Offset;

	private static bool RemoveVector2DParameter_IsValid;

	private static IntPtr RemoveVector2DParameter_FunctionAddress;

	private static int RemoveVector2DParameter_ParamsSize;

	private static bool RemoveVector2DParameter_InParameterName_IsValid;

	private static FFieldAddress RemoveVector2DParameter_InParameterName_PropertyAddress;

	private static int RemoveVector2DParameter_InParameterName_Offset;

	private static bool RemoveVector2DParameter_ReturnValue_IsValid;

	private static FFieldAddress RemoveVector2DParameter_ReturnValue_PropertyAddress;

	private static int RemoveVector2DParameter_ReturnValue_Offset;

	private static bool RemoveTransformParameter_IsValid;

	private static IntPtr RemoveTransformParameter_FunctionAddress;

	private static int RemoveTransformParameter_ParamsSize;

	private static bool RemoveTransformParameter_InParameterName_IsValid;

	private static FFieldAddress RemoveTransformParameter_InParameterName_PropertyAddress;

	private static int RemoveTransformParameter_InParameterName_Offset;

	private static bool RemoveTransformParameter_ReturnValue_IsValid;

	private static FFieldAddress RemoveTransformParameter_ReturnValue_PropertyAddress;

	private static int RemoveTransformParameter_ReturnValue_Offset;

	private static bool RemoveScalarParameter_IsValid;

	private static IntPtr RemoveScalarParameter_FunctionAddress;

	private static int RemoveScalarParameter_ParamsSize;

	private static bool RemoveScalarParameter_InParameterName_IsValid;

	private static FFieldAddress RemoveScalarParameter_InParameterName_PropertyAddress;

	private static int RemoveScalarParameter_InParameterName_Offset;

	private static bool RemoveScalarParameter_ReturnValue_IsValid;

	private static FFieldAddress RemoveScalarParameter_ReturnValue_PropertyAddress;

	private static int RemoveScalarParameter_ReturnValue_Offset;

	private static bool RemoveColorParameter_IsValid;

	private static IntPtr RemoveColorParameter_FunctionAddress;

	private static int RemoveColorParameter_ParamsSize;

	private static bool RemoveColorParameter_InParameterName_IsValid;

	private static FFieldAddress RemoveColorParameter_InParameterName_PropertyAddress;

	private static int RemoveColorParameter_InParameterName_Offset;

	private static bool RemoveColorParameter_ReturnValue_IsValid;

	private static FFieldAddress RemoveColorParameter_ReturnValue_PropertyAddress;

	private static int RemoveColorParameter_ReturnValue_Offset;

	private static bool RemoveBoolParameter_IsValid;

	private static IntPtr RemoveBoolParameter_FunctionAddress;

	private static int RemoveBoolParameter_ParamsSize;

	private static bool RemoveBoolParameter_InParameterName_IsValid;

	private static FFieldAddress RemoveBoolParameter_InParameterName_PropertyAddress;

	private static int RemoveBoolParameter_InParameterName_Offset;

	private static bool RemoveBoolParameter_ReturnValue_IsValid;

	private static FFieldAddress RemoveBoolParameter_ReturnValue_PropertyAddress;

	private static int RemoveBoolParameter_ReturnValue_Offset;

	private static bool GetParameterNames_IsValid;

	private static IntPtr GetParameterNames_FunctionAddress;

	private static int GetParameterNames_ParamsSize;

	private static bool GetParameterNames_ParameterNames_IsValid;

	private static FFieldAddress GetParameterNames_ParameterNames_PropertyAddress;

	private static int GetParameterNames_ParameterNames_Offset;

	private static bool AddVectorParameterKey_IsValid;

	private static IntPtr AddVectorParameterKey_FunctionAddress;

	private static int AddVectorParameterKey_ParamsSize;

	private static bool AddVectorParameterKey_InParameterName_IsValid;

	private static FFieldAddress AddVectorParameterKey_InParameterName_PropertyAddress;

	private static int AddVectorParameterKey_InParameterName_Offset;

	private static bool AddVectorParameterKey_InTime_IsValid;

	private static FFieldAddress AddVectorParameterKey_InTime_PropertyAddress;

	private static int AddVectorParameterKey_InTime_Offset;

	private static bool AddVectorParameterKey_InValue_IsValid;

	private static FFieldAddress AddVectorParameterKey_InValue_PropertyAddress;

	private static int AddVectorParameterKey_InValue_Offset;

	private static bool AddVector2DParameterKey_IsValid;

	private static IntPtr AddVector2DParameterKey_FunctionAddress;

	private static int AddVector2DParameterKey_ParamsSize;

	private static bool AddVector2DParameterKey_InParameterName_IsValid;

	private static FFieldAddress AddVector2DParameterKey_InParameterName_PropertyAddress;

	private static int AddVector2DParameterKey_InParameterName_Offset;

	private static bool AddVector2DParameterKey_InTime_IsValid;

	private static FFieldAddress AddVector2DParameterKey_InTime_PropertyAddress;

	private static int AddVector2DParameterKey_InTime_Offset;

	private static bool AddVector2DParameterKey_InValue_IsValid;

	private static FFieldAddress AddVector2DParameterKey_InValue_PropertyAddress;

	private static int AddVector2DParameterKey_InValue_Offset;

	private static bool AddTransformParameterKey_IsValid;

	private static IntPtr AddTransformParameterKey_FunctionAddress;

	private static int AddTransformParameterKey_ParamsSize;

	private static bool AddTransformParameterKey_InParameterName_IsValid;

	private static FFieldAddress AddTransformParameterKey_InParameterName_PropertyAddress;

	private static int AddTransformParameterKey_InParameterName_Offset;

	private static bool AddTransformParameterKey_InTime_IsValid;

	private static FFieldAddress AddTransformParameterKey_InTime_PropertyAddress;

	private static int AddTransformParameterKey_InTime_Offset;

	private static bool AddTransformParameterKey_InValue_IsValid;

	private static FFieldAddress AddTransformParameterKey_InValue_PropertyAddress;

	private static int AddTransformParameterKey_InValue_Offset;

	private static bool AddScalarParameterKey_IsValid;

	private static IntPtr AddScalarParameterKey_FunctionAddress;

	private static int AddScalarParameterKey_ParamsSize;

	private static bool AddScalarParameterKey_InParameterName_IsValid;

	private static FFieldAddress AddScalarParameterKey_InParameterName_PropertyAddress;

	private static int AddScalarParameterKey_InParameterName_Offset;

	private static bool AddScalarParameterKey_InTime_IsValid;

	private static FFieldAddress AddScalarParameterKey_InTime_PropertyAddress;

	private static int AddScalarParameterKey_InTime_Offset;

	private static bool AddScalarParameterKey_InValue_IsValid;

	private static FFieldAddress AddScalarParameterKey_InValue_PropertyAddress;

	private static int AddScalarParameterKey_InValue_Offset;

	private static bool AddColorParameterKey_IsValid;

	private static IntPtr AddColorParameterKey_FunctionAddress;

	private static int AddColorParameterKey_ParamsSize;

	private static bool AddColorParameterKey_InParameterName_IsValid;

	private static FFieldAddress AddColorParameterKey_InParameterName_PropertyAddress;

	private static int AddColorParameterKey_InParameterName_Offset;

	private static bool AddColorParameterKey_InTime_IsValid;

	private static FFieldAddress AddColorParameterKey_InTime_PropertyAddress;

	private static int AddColorParameterKey_InTime_Offset;

	private static bool AddColorParameterKey_InValue_IsValid;

	private static FFieldAddress AddColorParameterKey_InValue_PropertyAddress;

	private static int AddColorParameterKey_InValue_Offset;

	private static bool AddBoolParameterKey_IsValid;

	private static IntPtr AddBoolParameterKey_FunctionAddress;

	private static int AddBoolParameterKey_ParamsSize;

	private static bool AddBoolParameterKey_InParameterName_IsValid;

	private static FFieldAddress AddBoolParameterKey_InParameterName_PropertyAddress;

	private static int AddBoolParameterKey_InParameterName_Offset;

	private static bool AddBoolParameterKey_InTime_IsValid;

	private static FFieldAddress AddBoolParameterKey_InTime_PropertyAddress;

	private static int AddBoolParameterKey_InTime_Offset;

	private static bool AddBoolParameterKey_InValue_IsValid;

	private static FFieldAddress AddBoolParameterKey_InValue_PropertyAddress;

	private static int AddBoolParameterKey_InValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveVectorParameter")]
	public unsafe bool RemoveVectorParameter(FName InParameterName)
	{
		CheckDestroyed();
		if (!RemoveVectorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveVectorParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveVectorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveVectorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveVectorParameter_InParameterName_Offset), 0, RemoveVectorParameter_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveVectorParameter_FunctionAddress, intPtr, RemoveVectorParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveVectorParameter_ReturnValue_Offset), 0, RemoveVectorParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveVector2DParameter")]
	public unsafe bool RemoveVector2DParameter(FName InParameterName)
	{
		CheckDestroyed();
		if (!RemoveVector2DParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveVector2DParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveVector2DParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveVector2DParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveVector2DParameter_InParameterName_Offset), 0, RemoveVector2DParameter_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveVector2DParameter_FunctionAddress, intPtr, RemoveVector2DParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveVector2DParameter_ReturnValue_Offset), 0, RemoveVector2DParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveTransformParameter")]
	public unsafe bool RemoveTransformParameter(FName InParameterName)
	{
		CheckDestroyed();
		if (!RemoveTransformParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveTransformParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTransformParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTransformParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveTransformParameter_InParameterName_Offset), 0, RemoveTransformParameter_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTransformParameter_FunctionAddress, intPtr, RemoveTransformParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveTransformParameter_ReturnValue_Offset), 0, RemoveTransformParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveScalarParameter")]
	public unsafe bool RemoveScalarParameter(FName InParameterName)
	{
		CheckDestroyed();
		if (!RemoveScalarParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveScalarParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveScalarParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveScalarParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveScalarParameter_InParameterName_Offset), 0, RemoveScalarParameter_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveScalarParameter_FunctionAddress, intPtr, RemoveScalarParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveScalarParameter_ReturnValue_Offset), 0, RemoveScalarParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveColorParameter")]
	public unsafe bool RemoveColorParameter(FName InParameterName)
	{
		CheckDestroyed();
		if (!RemoveColorParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveColorParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveColorParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveColorParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveColorParameter_InParameterName_Offset), 0, RemoveColorParameter_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveColorParameter_FunctionAddress, intPtr, RemoveColorParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveColorParameter_ReturnValue_Offset), 0, RemoveColorParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveBoolParameter")]
	public unsafe bool RemoveBoolParameter(FName InParameterName)
	{
		CheckDestroyed();
		if (!RemoveBoolParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveBoolParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveBoolParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveBoolParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveBoolParameter_InParameterName_Offset), 0, RemoveBoolParameter_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveBoolParameter_FunctionAddress, intPtr, RemoveBoolParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveBoolParameter_ReturnValue_Offset), 0, RemoveBoolParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:GetParameterNames")]
	public unsafe void GetParameterNames(out HashSet<FName> ParameterNames)
	{
		CheckDestroyed();
		if (!GetParameterNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:GetParameterNames");
			ParameterNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParameterNames_ParameterNames_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterNames_FunctionAddress, intPtr, GetParameterNames_ParamsSize);
		ParameterNames = new TSetCopyMarshaler<FName>(1, GetParameterNames_ParameterNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetParameterNames_ParameterNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetParameterNames_ParameterNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:AddVectorParameterKey")]
	public unsafe void AddVectorParameterKey(FName InParameterName, FFrameNumber InTime, FVector InValue)
	{
		CheckDestroyed();
		if (!AddVectorParameterKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:AddVectorParameterKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVectorParameterKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVectorParameterKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVectorParameterKey_InParameterName_Offset), 0, AddVectorParameterKey_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InitializeValue_InContainer(AddVectorParameterKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddVectorParameterKey_InTime_Offset), 0, AddVectorParameterKey_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddVectorParameterKey_InValue_Offset), 0, AddVectorParameterKey_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddVectorParameterKey_FunctionAddress, intPtr, AddVectorParameterKey_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:AddVector2DParameterKey")]
	public unsafe void AddVector2DParameterKey(FName InParameterName, FFrameNumber InTime, FVector2D InValue)
	{
		CheckDestroyed();
		if (!AddVector2DParameterKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:AddVector2DParameterKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVector2DParameterKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVector2DParameterKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVector2DParameterKey_InParameterName_Offset), 0, AddVector2DParameterKey_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InitializeValue_InContainer(AddVector2DParameterKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddVector2DParameterKey_InTime_Offset), 0, AddVector2DParameterKey_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddVector2DParameterKey_InValue_Offset), 0, AddVector2DParameterKey_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddVector2DParameterKey_FunctionAddress, intPtr, AddVector2DParameterKey_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:AddTransformParameterKey")]
	public unsafe void AddTransformParameterKey(FName InParameterName, FFrameNumber InTime, FTransform InValue)
	{
		CheckDestroyed();
		if (!AddTransformParameterKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:AddTransformParameterKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTransformParameterKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTransformParameterKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddTransformParameterKey_InParameterName_Offset), 0, AddTransformParameterKey_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InitializeValue_InContainer(AddTransformParameterKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddTransformParameterKey_InTime_Offset), 0, AddTransformParameterKey_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InitializeValue_InContainer(AddTransformParameterKey_InValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddTransformParameterKey_InValue_Offset), 0, AddTransformParameterKey_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTransformParameterKey_FunctionAddress, intPtr, AddTransformParameterKey_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:AddScalarParameterKey")]
	public unsafe void AddScalarParameterKey(FName InParameterName, FFrameNumber InTime, float InValue)
	{
		CheckDestroyed();
		if (!AddScalarParameterKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:AddScalarParameterKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddScalarParameterKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddScalarParameterKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddScalarParameterKey_InParameterName_Offset), 0, AddScalarParameterKey_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InitializeValue_InContainer(AddScalarParameterKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddScalarParameterKey_InTime_Offset), 0, AddScalarParameterKey_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddScalarParameterKey_InValue_Offset), 0, AddScalarParameterKey_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddScalarParameterKey_FunctionAddress, intPtr, AddScalarParameterKey_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:AddColorParameterKey")]
	public unsafe void AddColorParameterKey(FName InParameterName, FFrameNumber InTime, FLinearColor InValue)
	{
		CheckDestroyed();
		if (!AddColorParameterKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:AddColorParameterKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddColorParameterKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddColorParameterKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddColorParameterKey_InParameterName_Offset), 0, AddColorParameterKey_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InitializeValue_InContainer(AddColorParameterKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddColorParameterKey_InTime_Offset), 0, AddColorParameterKey_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, AddColorParameterKey_InValue_Offset), 0, AddColorParameterKey_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddColorParameterKey_FunctionAddress, intPtr, AddColorParameterKey_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneParameterSection:AddBoolParameterKey")]
	public unsafe void AddBoolParameterKey(FName InParameterName, FFrameNumber InTime, bool InValue)
	{
		CheckDestroyed();
		if (!AddBoolParameterKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneParameterSection:AddBoolParameterKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBoolParameterKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBoolParameterKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBoolParameterKey_InParameterName_Offset), 0, AddBoolParameterKey_InParameterName_PropertyAddress.Address, InParameterName);
		NativeReflection.InitializeValue_InContainer(AddBoolParameterKey_InTime_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, AddBoolParameterKey_InTime_Offset), 0, AddBoolParameterKey_InTime_PropertyAddress.Address, InTime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBoolParameterKey_InValue_Offset), 0, AddBoolParameterKey_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBoolParameterKey_FunctionAddress, intPtr, AddBoolParameterKey_ParamsSize);
	}

	static UMovieSceneParameterSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneParameterSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneParameterSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieSceneParameterSection");
		RemoveVectorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveVectorParameter");
		RemoveVectorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveVectorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveVectorParameter_InParameterName_PropertyAddress, RemoveVectorParameter_FunctionAddress, "InParameterName");
		RemoveVectorParameter_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVectorParameter_FunctionAddress, "InParameterName");
		RemoveVectorParameter_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVectorParameter_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveVectorParameter_ReturnValue_PropertyAddress, RemoveVectorParameter_FunctionAddress, "ReturnValue");
		RemoveVectorParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVectorParameter_FunctionAddress, "ReturnValue");
		RemoveVectorParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVectorParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveVectorParameter_IsValid = RemoveVectorParameter_FunctionAddress != IntPtr.Zero && RemoveVectorParameter_InParameterName_IsValid && RemoveVectorParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveVectorParameter", RemoveVectorParameter_IsValid);
		RemoveVector2DParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveVector2DParameter");
		RemoveVector2DParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveVector2DParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveVector2DParameter_InParameterName_PropertyAddress, RemoveVector2DParameter_FunctionAddress, "InParameterName");
		RemoveVector2DParameter_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVector2DParameter_FunctionAddress, "InParameterName");
		RemoveVector2DParameter_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVector2DParameter_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveVector2DParameter_ReturnValue_PropertyAddress, RemoveVector2DParameter_FunctionAddress, "ReturnValue");
		RemoveVector2DParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVector2DParameter_FunctionAddress, "ReturnValue");
		RemoveVector2DParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVector2DParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveVector2DParameter_IsValid = RemoveVector2DParameter_FunctionAddress != IntPtr.Zero && RemoveVector2DParameter_InParameterName_IsValid && RemoveVector2DParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveVector2DParameter", RemoveVector2DParameter_IsValid);
		RemoveTransformParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveTransformParameter");
		RemoveTransformParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTransformParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTransformParameter_InParameterName_PropertyAddress, RemoveTransformParameter_FunctionAddress, "InParameterName");
		RemoveTransformParameter_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTransformParameter_FunctionAddress, "InParameterName");
		RemoveTransformParameter_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTransformParameter_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveTransformParameter_ReturnValue_PropertyAddress, RemoveTransformParameter_FunctionAddress, "ReturnValue");
		RemoveTransformParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTransformParameter_FunctionAddress, "ReturnValue");
		RemoveTransformParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTransformParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveTransformParameter_IsValid = RemoveTransformParameter_FunctionAddress != IntPtr.Zero && RemoveTransformParameter_InParameterName_IsValid && RemoveTransformParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveTransformParameter", RemoveTransformParameter_IsValid);
		RemoveScalarParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveScalarParameter");
		RemoveScalarParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveScalarParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveScalarParameter_InParameterName_PropertyAddress, RemoveScalarParameter_FunctionAddress, "InParameterName");
		RemoveScalarParameter_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveScalarParameter_FunctionAddress, "InParameterName");
		RemoveScalarParameter_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveScalarParameter_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveScalarParameter_ReturnValue_PropertyAddress, RemoveScalarParameter_FunctionAddress, "ReturnValue");
		RemoveScalarParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveScalarParameter_FunctionAddress, "ReturnValue");
		RemoveScalarParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveScalarParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveScalarParameter_IsValid = RemoveScalarParameter_FunctionAddress != IntPtr.Zero && RemoveScalarParameter_InParameterName_IsValid && RemoveScalarParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveScalarParameter", RemoveScalarParameter_IsValid);
		RemoveColorParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveColorParameter");
		RemoveColorParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveColorParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveColorParameter_InParameterName_PropertyAddress, RemoveColorParameter_FunctionAddress, "InParameterName");
		RemoveColorParameter_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveColorParameter_FunctionAddress, "InParameterName");
		RemoveColorParameter_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveColorParameter_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveColorParameter_ReturnValue_PropertyAddress, RemoveColorParameter_FunctionAddress, "ReturnValue");
		RemoveColorParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveColorParameter_FunctionAddress, "ReturnValue");
		RemoveColorParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveColorParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveColorParameter_IsValid = RemoveColorParameter_FunctionAddress != IntPtr.Zero && RemoveColorParameter_InParameterName_IsValid && RemoveColorParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveColorParameter", RemoveColorParameter_IsValid);
		RemoveBoolParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveBoolParameter");
		RemoveBoolParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveBoolParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveBoolParameter_InParameterName_PropertyAddress, RemoveBoolParameter_FunctionAddress, "InParameterName");
		RemoveBoolParameter_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBoolParameter_FunctionAddress, "InParameterName");
		RemoveBoolParameter_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBoolParameter_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveBoolParameter_ReturnValue_PropertyAddress, RemoveBoolParameter_FunctionAddress, "ReturnValue");
		RemoveBoolParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBoolParameter_FunctionAddress, "ReturnValue");
		RemoveBoolParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBoolParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveBoolParameter_IsValid = RemoveBoolParameter_FunctionAddress != IntPtr.Zero && RemoveBoolParameter_InParameterName_IsValid && RemoveBoolParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:RemoveBoolParameter", RemoveBoolParameter_IsValid);
		GetParameterNames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterNames");
		GetParameterNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterNames_ParameterNames_PropertyAddress, GetParameterNames_FunctionAddress, "ParameterNames");
		GetParameterNames_ParameterNames_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterNames_FunctionAddress, "ParameterNames");
		GetParameterNames_ParameterNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterNames_FunctionAddress, "ParameterNames", Classes.FSetProperty);
		GetParameterNames_IsValid = GetParameterNames_FunctionAddress != IntPtr.Zero && GetParameterNames_ParameterNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:GetParameterNames", GetParameterNames_IsValid);
		AddVectorParameterKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddVectorParameterKey");
		AddVectorParameterKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVectorParameterKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVectorParameterKey_InParameterName_PropertyAddress, AddVectorParameterKey_FunctionAddress, "InParameterName");
		AddVectorParameterKey_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorParameterKey_FunctionAddress, "InParameterName");
		AddVectorParameterKey_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorParameterKey_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorParameterKey_InTime_PropertyAddress, AddVectorParameterKey_FunctionAddress, "InTime");
		AddVectorParameterKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorParameterKey_FunctionAddress, "InTime");
		AddVectorParameterKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorParameterKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorParameterKey_InValue_PropertyAddress, AddVectorParameterKey_FunctionAddress, "InValue");
		AddVectorParameterKey_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorParameterKey_FunctionAddress, "InValue");
		AddVectorParameterKey_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorParameterKey_FunctionAddress, "InValue", Classes.FStructProperty);
		AddVectorParameterKey_IsValid = AddVectorParameterKey_FunctionAddress != IntPtr.Zero && AddVectorParameterKey_InParameterName_IsValid && AddVectorParameterKey_InTime_IsValid && AddVectorParameterKey_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:AddVectorParameterKey", AddVectorParameterKey_IsValid);
		AddVector2DParameterKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddVector2DParameterKey");
		AddVector2DParameterKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVector2DParameterKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVector2DParameterKey_InParameterName_PropertyAddress, AddVector2DParameterKey_FunctionAddress, "InParameterName");
		AddVector2DParameterKey_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddVector2DParameterKey_FunctionAddress, "InParameterName");
		AddVector2DParameterKey_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVector2DParameterKey_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVector2DParameterKey_InTime_PropertyAddress, AddVector2DParameterKey_FunctionAddress, "InTime");
		AddVector2DParameterKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddVector2DParameterKey_FunctionAddress, "InTime");
		AddVector2DParameterKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVector2DParameterKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVector2DParameterKey_InValue_PropertyAddress, AddVector2DParameterKey_FunctionAddress, "InValue");
		AddVector2DParameterKey_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddVector2DParameterKey_FunctionAddress, "InValue");
		AddVector2DParameterKey_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVector2DParameterKey_FunctionAddress, "InValue", Classes.FStructProperty);
		AddVector2DParameterKey_IsValid = AddVector2DParameterKey_FunctionAddress != IntPtr.Zero && AddVector2DParameterKey_InParameterName_IsValid && AddVector2DParameterKey_InTime_IsValid && AddVector2DParameterKey_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:AddVector2DParameterKey", AddVector2DParameterKey_IsValid);
		AddTransformParameterKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddTransformParameterKey");
		AddTransformParameterKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTransformParameterKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTransformParameterKey_InParameterName_PropertyAddress, AddTransformParameterKey_FunctionAddress, "InParameterName");
		AddTransformParameterKey_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformParameterKey_FunctionAddress, "InParameterName");
		AddTransformParameterKey_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformParameterKey_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformParameterKey_InTime_PropertyAddress, AddTransformParameterKey_FunctionAddress, "InTime");
		AddTransformParameterKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformParameterKey_FunctionAddress, "InTime");
		AddTransformParameterKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformParameterKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformParameterKey_InValue_PropertyAddress, AddTransformParameterKey_FunctionAddress, "InValue");
		AddTransformParameterKey_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformParameterKey_FunctionAddress, "InValue");
		AddTransformParameterKey_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformParameterKey_FunctionAddress, "InValue", Classes.FStructProperty);
		AddTransformParameterKey_IsValid = AddTransformParameterKey_FunctionAddress != IntPtr.Zero && AddTransformParameterKey_InParameterName_IsValid && AddTransformParameterKey_InTime_IsValid && AddTransformParameterKey_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:AddTransformParameterKey", AddTransformParameterKey_IsValid);
		AddScalarParameterKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddScalarParameterKey");
		AddScalarParameterKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddScalarParameterKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddScalarParameterKey_InParameterName_PropertyAddress, AddScalarParameterKey_FunctionAddress, "InParameterName");
		AddScalarParameterKey_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddScalarParameterKey_FunctionAddress, "InParameterName");
		AddScalarParameterKey_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddScalarParameterKey_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddScalarParameterKey_InTime_PropertyAddress, AddScalarParameterKey_FunctionAddress, "InTime");
		AddScalarParameterKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddScalarParameterKey_FunctionAddress, "InTime");
		AddScalarParameterKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddScalarParameterKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddScalarParameterKey_InValue_PropertyAddress, AddScalarParameterKey_FunctionAddress, "InValue");
		AddScalarParameterKey_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddScalarParameterKey_FunctionAddress, "InValue");
		AddScalarParameterKey_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddScalarParameterKey_FunctionAddress, "InValue", Classes.FFloatProperty);
		AddScalarParameterKey_IsValid = AddScalarParameterKey_FunctionAddress != IntPtr.Zero && AddScalarParameterKey_InParameterName_IsValid && AddScalarParameterKey_InTime_IsValid && AddScalarParameterKey_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:AddScalarParameterKey", AddScalarParameterKey_IsValid);
		AddColorParameterKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddColorParameterKey");
		AddColorParameterKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddColorParameterKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddColorParameterKey_InParameterName_PropertyAddress, AddColorParameterKey_FunctionAddress, "InParameterName");
		AddColorParameterKey_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddColorParameterKey_FunctionAddress, "InParameterName");
		AddColorParameterKey_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddColorParameterKey_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddColorParameterKey_InTime_PropertyAddress, AddColorParameterKey_FunctionAddress, "InTime");
		AddColorParameterKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddColorParameterKey_FunctionAddress, "InTime");
		AddColorParameterKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddColorParameterKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddColorParameterKey_InValue_PropertyAddress, AddColorParameterKey_FunctionAddress, "InValue");
		AddColorParameterKey_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddColorParameterKey_FunctionAddress, "InValue");
		AddColorParameterKey_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddColorParameterKey_FunctionAddress, "InValue", Classes.FStructProperty);
		AddColorParameterKey_IsValid = AddColorParameterKey_FunctionAddress != IntPtr.Zero && AddColorParameterKey_InParameterName_IsValid && AddColorParameterKey_InTime_IsValid && AddColorParameterKey_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:AddColorParameterKey", AddColorParameterKey_IsValid);
		AddBoolParameterKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBoolParameterKey");
		AddBoolParameterKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBoolParameterKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBoolParameterKey_InParameterName_PropertyAddress, AddBoolParameterKey_FunctionAddress, "InParameterName");
		AddBoolParameterKey_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoolParameterKey_FunctionAddress, "InParameterName");
		AddBoolParameterKey_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoolParameterKey_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoolParameterKey_InTime_PropertyAddress, AddBoolParameterKey_FunctionAddress, "InTime");
		AddBoolParameterKey_InTime_Offset = NativeReflectionCached.GetPropertyOffset(AddBoolParameterKey_FunctionAddress, "InTime");
		AddBoolParameterKey_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoolParameterKey_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoolParameterKey_InValue_PropertyAddress, AddBoolParameterKey_FunctionAddress, "InValue");
		AddBoolParameterKey_InValue_Offset = NativeReflectionCached.GetPropertyOffset(AddBoolParameterKey_FunctionAddress, "InValue");
		AddBoolParameterKey_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoolParameterKey_FunctionAddress, "InValue", Classes.FBoolProperty);
		AddBoolParameterKey_IsValid = AddBoolParameterKey_FunctionAddress != IntPtr.Zero && AddBoolParameterKey_InParameterName_IsValid && AddBoolParameterKey_InTime_IsValid && AddBoolParameterKey_InValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneParameterSection:AddBoolParameterKey", AddBoolParameterKey_IsValid);
	}
}
