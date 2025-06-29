using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGUSimpleGamePlayTraceObject", "b1", UnrealModuleType.Game)]
public class UBGUSimpleGamePlayTraceObject : UObject
{
	private static bool OnTick_IsValid;

	private static IntPtr OnTick_FunctionAddress;

	private static int OnTick_ParamsSize;

	private static bool OnTick_DeltaTime_IsValid;

	private static FFieldAddress OnTick_DeltaTime_PropertyAddress;

	private static int OnTick_DeltaTime_Offset;

	private static bool OnShutdown_IsValid;

	private static IntPtr OnShutdown_FunctionAddress;

	private static int OnShutdown_ParamsSize;

	private static bool OnInit_IsValid;

	private static IntPtr OnInit_FunctionAddress;

	private static int OnInit_ParamsSize;

	private static bool FindTraceStatResult_IsValid;

	private static IntPtr FindTraceStatResult_FunctionAddress;

	private static int FindTraceStatResult_ParamsSize;

	private static bool FindTraceStatResult_Name_IsValid;

	private static FFieldAddress FindTraceStatResult_Name_PropertyAddress;

	private static int FindTraceStatResult_Name_Offset;

	private static bool FindTraceStatResult_ReturnValue_IsValid;

	private static FFieldAddress FindTraceStatResult_ReturnValue_PropertyAddress;

	private static int FindTraceStatResult_ReturnValue_Offset;

	private static bool AddTraceStatByName_IsValid;

	private static IntPtr AddTraceStatByName_FunctionAddress;

	private static int AddTraceStatByName_ParamsSize;

	private static bool AddTraceStatByName_Name_IsValid;

	private static FFieldAddress AddTraceStatByName_Name_PropertyAddress;

	private static int AddTraceStatByName_Name_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUSimpleGamePlayTraceObject:OnTick")]
	public unsafe void OnTick(float DeltaTime)
	{
		CheckDestroyed();
		if (!OnTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSimpleGamePlayTraceObject:OnTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnTick_DeltaTime_Offset), 0, OnTick_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTick_FunctionAddress, intPtr, OnTick_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUSimpleGamePlayTraceObject:OnShutdown")]
	public unsafe void OnShutdown()
	{
		CheckDestroyed();
		if (!OnShutdown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSimpleGamePlayTraceObject:OnShutdown");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnShutdown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnShutdown_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnShutdown_FunctionAddress, argsSize: OnShutdown_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUSimpleGamePlayTraceObject:OnInit")]
	public unsafe void OnInit()
	{
		CheckDestroyed();
		if (!OnInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSimpleGamePlayTraceObject:OnInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnInit_FunctionAddress, argsSize: OnInit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUSimpleGamePlayTraceObject:FindTraceStatResult")]
	public unsafe FTraceStatResult FindTraceStatResult(string Name)
	{
		CheckDestroyed();
		if (!FindTraceStatResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSimpleGamePlayTraceObject:FindTraceStatResult");
			return default(FTraceStatResult);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindTraceStatResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindTraceStatResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindTraceStatResult_Name_Offset), 0, FindTraceStatResult_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindTraceStatResult_FunctionAddress, intPtr, FindTraceStatResult_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindTraceStatResult_Name_PropertyAddress.Address, intPtr);
		FTraceStatResult result = FTraceStatResult.FromNative(IntPtr.Add(intPtr, FindTraceStatResult_ReturnValue_Offset), 0, FindTraceStatResult_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FindTraceStatResult_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUSimpleGamePlayTraceObject:AddTraceStatByName")]
	public unsafe void AddTraceStatByName(string Name)
	{
		CheckDestroyed();
		if (!AddTraceStatByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUSimpleGamePlayTraceObject:AddTraceStatByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTraceStatByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTraceStatByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddTraceStatByName_Name_Offset), 0, AddTraceStatByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTraceStatByName_FunctionAddress, intPtr, AddTraceStatByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddTraceStatByName_Name_PropertyAddress.Address, intPtr);
	}

	static UBGUSimpleGamePlayTraceObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUSimpleGamePlayTraceObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUSimpleGamePlayTraceObject));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGUSimpleGamePlayTraceObject");
		OnTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnTick");
		OnTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTick_DeltaTime_PropertyAddress, OnTick_FunctionAddress, "DeltaTime");
		OnTick_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(OnTick_FunctionAddress, "DeltaTime");
		OnTick_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnTick_IsValid = OnTick_FunctionAddress != IntPtr.Zero && OnTick_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSimpleGamePlayTraceObject:OnTick", OnTick_IsValid);
		OnShutdown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnShutdown");
		OnShutdown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnShutdown_FunctionAddress);
		OnShutdown_IsValid = OnShutdown_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSimpleGamePlayTraceObject:OnShutdown", OnShutdown_IsValid);
		OnInit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnInit");
		OnInit_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInit_FunctionAddress);
		OnInit_IsValid = OnInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSimpleGamePlayTraceObject:OnInit", OnInit_IsValid);
		FindTraceStatResult_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindTraceStatResult");
		FindTraceStatResult_ParamsSize = NativeReflection.GetFunctionParamsSize(FindTraceStatResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindTraceStatResult_Name_PropertyAddress, FindTraceStatResult_FunctionAddress, "Name");
		FindTraceStatResult_Name_Offset = NativeReflectionCached.GetPropertyOffset(FindTraceStatResult_FunctionAddress, "Name");
		FindTraceStatResult_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTraceStatResult_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTraceStatResult_ReturnValue_PropertyAddress, FindTraceStatResult_FunctionAddress, "ReturnValue");
		FindTraceStatResult_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindTraceStatResult_FunctionAddress, "ReturnValue");
		FindTraceStatResult_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTraceStatResult_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindTraceStatResult_IsValid = FindTraceStatResult_FunctionAddress != IntPtr.Zero && FindTraceStatResult_Name_IsValid && FindTraceStatResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSimpleGamePlayTraceObject:FindTraceStatResult", FindTraceStatResult_IsValid);
		AddTraceStatByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddTraceStatByName");
		AddTraceStatByName_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTraceStatByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTraceStatByName_Name_PropertyAddress, AddTraceStatByName_FunctionAddress, "Name");
		AddTraceStatByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(AddTraceStatByName_FunctionAddress, "Name");
		AddTraceStatByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTraceStatByName_FunctionAddress, "Name", Classes.FStrProperty);
		AddTraceStatByName_IsValid = AddTraceStatByName_FunctionAddress != IntPtr.Zero && AddTraceStatByName_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUSimpleGamePlayTraceObject:AddTraceStatByName", AddTraceStatByName_IsValid);
	}
}
