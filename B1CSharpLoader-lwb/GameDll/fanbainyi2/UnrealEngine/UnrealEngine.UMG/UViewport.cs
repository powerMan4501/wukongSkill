using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.Viewport", "UMG", UnrealModuleType.Engine)]
public class UViewport : UContentWidget
{
	private static bool Spawn_IsValid;

	private static IntPtr Spawn_FunctionAddress;

	private static int Spawn_ParamsSize;

	private static bool Spawn_ActorClass_IsValid;

	private static FFieldAddress Spawn_ActorClass_PropertyAddress;

	private static int Spawn_ActorClass_Offset;

	private static bool Spawn_ReturnValue_IsValid;

	private static FFieldAddress Spawn_ReturnValue_PropertyAddress;

	private static int Spawn_ReturnValue_Offset;

	private static bool SetViewRotation_IsValid;

	private static IntPtr SetViewRotation_FunctionAddress;

	private static int SetViewRotation_ParamsSize;

	private static bool SetViewRotation_Rotation_IsValid;

	private static FFieldAddress SetViewRotation_Rotation_PropertyAddress;

	private static int SetViewRotation_Rotation_Offset;

	private static bool SetViewLocation_IsValid;

	private static IntPtr SetViewLocation_FunctionAddress;

	private static int SetViewLocation_ParamsSize;

	private static bool SetViewLocation_Location_IsValid;

	private static FFieldAddress SetViewLocation_Location_PropertyAddress;

	private static int SetViewLocation_Location_Offset;

	private static bool GetViewRotation_IsValid;

	private static IntPtr GetViewRotation_FunctionAddress;

	private static int GetViewRotation_ParamsSize;

	private static bool GetViewRotation_ReturnValue_IsValid;

	private static FFieldAddress GetViewRotation_ReturnValue_PropertyAddress;

	private static int GetViewRotation_ReturnValue_Offset;

	private static bool GetViewportWorld_IsValid;

	private static IntPtr GetViewportWorld_FunctionAddress;

	private static int GetViewportWorld_ParamsSize;

	private static bool GetViewportWorld_ReturnValue_IsValid;

	private static FFieldAddress GetViewportWorld_ReturnValue_PropertyAddress;

	private static int GetViewportWorld_ReturnValue_Offset;

	private static bool GetViewLocation_IsValid;

	private static IntPtr GetViewLocation_FunctionAddress;

	private static int GetViewLocation_ParamsSize;

	private static bool GetViewLocation_ReturnValue_IsValid;

	private static FFieldAddress GetViewLocation_ReturnValue_PropertyAddress;

	private static int GetViewLocation_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Viewport:Spawn")]
	public unsafe AActor Spawn(TSubclassOf<AActor> ActorClass)
	{
		CheckDestroyed();
		if (!Spawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Viewport:Spawn");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Spawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Spawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Spawn_ActorClass_Offset), 0, Spawn_ActorClass_PropertyAddress.Address, ActorClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, Spawn_FunctionAddress, intPtr, Spawn_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, Spawn_ReturnValue_Offset), 0, Spawn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Viewport:SetViewRotation")]
	public unsafe void SetViewRotation(FRotator Rotation)
	{
		CheckDestroyed();
		if (!SetViewRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Viewport:SetViewRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetViewRotation_Rotation_Offset), 0, SetViewRotation_Rotation_PropertyAddress.Address, Rotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewRotation_FunctionAddress, intPtr, SetViewRotation_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Viewport:SetViewLocation")]
	public unsafe void SetViewLocation(FVector Location)
	{
		CheckDestroyed();
		if (!SetViewLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Viewport:SetViewLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetViewLocation_Location_Offset), 0, SetViewLocation_Location_PropertyAddress.Address, Location);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewLocation_FunctionAddress, intPtr, SetViewLocation_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.Viewport:GetViewRotation")]
	public unsafe FRotator GetViewRotation()
	{
		CheckDestroyed();
		if (!GetViewRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Viewport:GetViewRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewRotation_FunctionAddress, intPtr, GetViewRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetViewRotation_ReturnValue_Offset), 0, GetViewRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Viewport:GetViewportWorld")]
	public unsafe UWorld GetViewportWorld()
	{
		CheckDestroyed();
		if (!GetViewportWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Viewport:GetViewportWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewportWorld_FunctionAddress, intPtr, GetViewportWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetViewportWorld_ReturnValue_Offset), 0, GetViewportWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.Viewport:GetViewLocation")]
	public unsafe FVector GetViewLocation()
	{
		CheckDestroyed();
		if (!GetViewLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Viewport:GetViewLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewLocation_FunctionAddress, intPtr, GetViewLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetViewLocation_ReturnValue_Offset), 0, GetViewLocation_ReturnValue_PropertyAddress.Address);
	}

	static UViewport()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UViewport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UViewport));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.Viewport");
		Spawn_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Spawn");
		Spawn_ParamsSize = NativeReflection.GetFunctionParamsSize(Spawn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Spawn_ActorClass_PropertyAddress, Spawn_FunctionAddress, "ActorClass");
		Spawn_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(Spawn_FunctionAddress, "ActorClass");
		Spawn_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(Spawn_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref Spawn_ReturnValue_PropertyAddress, Spawn_FunctionAddress, "ReturnValue");
		Spawn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Spawn_FunctionAddress, "ReturnValue");
		Spawn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Spawn_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Spawn_IsValid = Spawn_FunctionAddress != IntPtr.Zero && Spawn_ActorClass_IsValid && Spawn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Viewport:Spawn", Spawn_IsValid);
		SetViewRotation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetViewRotation");
		SetViewRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewRotation_Rotation_PropertyAddress, SetViewRotation_FunctionAddress, "Rotation");
		SetViewRotation_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRotation_FunctionAddress, "Rotation");
		SetViewRotation_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRotation_FunctionAddress, "Rotation", Classes.FStructProperty);
		SetViewRotation_IsValid = SetViewRotation_FunctionAddress != IntPtr.Zero && SetViewRotation_Rotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Viewport:SetViewRotation", SetViewRotation_IsValid);
		SetViewLocation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetViewLocation");
		SetViewLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewLocation_Location_PropertyAddress, SetViewLocation_FunctionAddress, "Location");
		SetViewLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(SetViewLocation_FunctionAddress, "Location");
		SetViewLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewLocation_FunctionAddress, "Location", Classes.FStructProperty);
		SetViewLocation_IsValid = SetViewLocation_FunctionAddress != IntPtr.Zero && SetViewLocation_Location_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Viewport:SetViewLocation", SetViewLocation_IsValid);
		GetViewRotation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewRotation");
		GetViewRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewRotation_ReturnValue_PropertyAddress, GetViewRotation_FunctionAddress, "ReturnValue");
		GetViewRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRotation_FunctionAddress, "ReturnValue");
		GetViewRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewRotation_IsValid = GetViewRotation_FunctionAddress != IntPtr.Zero && GetViewRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Viewport:GetViewRotation", GetViewRotation_IsValid);
		GetViewportWorld_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewportWorld");
		GetViewportWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportWorld_ReturnValue_PropertyAddress, GetViewportWorld_FunctionAddress, "ReturnValue");
		GetViewportWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportWorld_FunctionAddress, "ReturnValue");
		GetViewportWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetViewportWorld_IsValid = GetViewportWorld_FunctionAddress != IntPtr.Zero && GetViewportWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Viewport:GetViewportWorld", GetViewportWorld_IsValid);
		GetViewLocation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewLocation");
		GetViewLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewLocation_ReturnValue_PropertyAddress, GetViewLocation_FunctionAddress, "ReturnValue");
		GetViewLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewLocation_FunctionAddress, "ReturnValue");
		GetViewLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewLocation_IsValid = GetViewLocation_FunctionAddress != IntPtr.Zero && GetViewLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Viewport:GetViewLocation", GetViewLocation_IsValid);
	}
}
