using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LandscapeEditorUtilities;
using UnrealEngine.Plugins.Water;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.WaterEditor;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush", "WaterEditor", UnrealModuleType.EnginePlugin)]
public class AWaterLandscapeBrush : ALandscapeBlueprintBrush
{
	private static bool SetActorCache_IsValid;

	private static IntPtr SetActorCache_FunctionAddress;

	private static int SetActorCache_ParamsSize;

	private static bool SetActorCache_InActor_IsValid;

	private static FFieldAddress SetActorCache_InActor_PropertyAddress;

	private static int SetActorCache_InActor_Offset;

	private static bool SetActorCache_InCache_IsValid;

	private static FFieldAddress SetActorCache_InCache_PropertyAddress;

	private static int SetActorCache_InCache_Offset;

	private static bool GetWaterBodyIslands_IsValid;

	private static IntPtr GetWaterBodyIslands_FunctionAddress;

	private static int GetWaterBodyIslands_ParamsSize;

	private static bool GetWaterBodyIslands_WaterBodyIslandClass_IsValid;

	private static FFieldAddress GetWaterBodyIslands_WaterBodyIslandClass_PropertyAddress;

	private static int GetWaterBodyIslands_WaterBodyIslandClass_Offset;

	private static bool GetWaterBodyIslands_OutWaterBodyIslands_IsValid;

	private static FFieldAddress GetWaterBodyIslands_OutWaterBodyIslands_PropertyAddress;

	private static int GetWaterBodyIslands_OutWaterBodyIslands_Offset;

	private static bool GetWaterBodies_IsValid;

	private static IntPtr GetWaterBodies_FunctionAddress;

	private static int GetWaterBodies_ParamsSize;

	private static bool GetWaterBodies_WaterBodyClass_IsValid;

	private static FFieldAddress GetWaterBodies_WaterBodyClass_PropertyAddress;

	private static int GetWaterBodies_WaterBodyClass_Offset;

	private static bool GetWaterBodies_OutWaterBodies_IsValid;

	private static FFieldAddress GetWaterBodies_OutWaterBodies_PropertyAddress;

	private static int GetWaterBodies_OutWaterBodies_Offset;

	private static bool GetActorsAffectingLandscape_IsValid;

	private static IntPtr GetActorsAffectingLandscape_FunctionAddress;

	private static int GetActorsAffectingLandscape_ParamsSize;

	private static bool GetActorsAffectingLandscape_OutWaterBrushActors_IsValid;

	private static FFieldAddress GetActorsAffectingLandscape_OutWaterBrushActors_PropertyAddress;

	private static int GetActorsAffectingLandscape_OutWaterBrushActors_Offset;

	private static bool GetActorCache_IsValid;

	private static IntPtr GetActorCache_FunctionAddress;

	private static int GetActorCache_ParamsSize;

	private static bool GetActorCache_InActor_IsValid;

	private static FFieldAddress GetActorCache_InActor_PropertyAddress;

	private static int GetActorCache_InActor_Offset;

	private static bool GetActorCache_CacheClass_IsValid;

	private static FFieldAddress GetActorCache_CacheClass_PropertyAddress;

	private static int GetActorCache_CacheClass_Offset;

	private static bool GetActorCache_ReturnValue_IsValid;

	private static FFieldAddress GetActorCache_ReturnValue_PropertyAddress;

	private static int GetActorCache_ReturnValue_Offset;

	private static bool ForceWaterTextureUpdate_IsValid;

	private static IntPtr ForceWaterTextureUpdate_FunctionAddress;

	private static int ForceWaterTextureUpdate_ParamsSize;

	private static bool ClearActorCache_IsValid;

	private static IntPtr ClearActorCache_FunctionAddress;

	private static int ClearActorCache_ParamsSize;

	private static bool ClearActorCache_InActor_IsValid;

	private static FFieldAddress ClearActorCache_InActor_PropertyAddress;

	private static int ClearActorCache_InActor_Offset;

	private static bool BlueprintWaterBodyChanged_IsValid;

	private IntPtr BlueprintWaterBodyChanged_InstanceFunctionAddress;

	private static IntPtr BlueprintWaterBodyChanged_FunctionAddress;

	private static int BlueprintWaterBodyChanged_ParamsSize;

	private static bool BlueprintWaterBodyChanged_Actor_IsValid;

	private static FFieldAddress BlueprintWaterBodyChanged_Actor_PropertyAddress;

	private static int BlueprintWaterBodyChanged_Actor_Offset;

	private static bool BlueprintWaterBodiesChanged_IsValid;

	private IntPtr BlueprintWaterBodiesChanged_InstanceFunctionAddress;

	private static IntPtr BlueprintWaterBodiesChanged_FunctionAddress;

	private static int BlueprintWaterBodiesChanged_ParamsSize;

	private static bool BlueprintOnRenderTargetTexturesUpdated_IsValid;

	private IntPtr BlueprintOnRenderTargetTexturesUpdated_InstanceFunctionAddress;

	private static IntPtr BlueprintOnRenderTargetTexturesUpdated_FunctionAddress;

	private static int BlueprintOnRenderTargetTexturesUpdated_ParamsSize;

	private static bool BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_IsValid;

	private static FFieldAddress BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_PropertyAddress;

	private static int BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_Offset;

	private static bool BlueprintGetRenderTargets_IsValid;

	private IntPtr BlueprintGetRenderTargets_InstanceFunctionAddress;

	private static IntPtr BlueprintGetRenderTargets_FunctionAddress;

	private static int BlueprintGetRenderTargets_ParamsSize;

	private static bool BlueprintGetRenderTargets_InHeightRenderTarget_IsValid;

	private static FFieldAddress BlueprintGetRenderTargets_InHeightRenderTarget_PropertyAddress;

	private static int BlueprintGetRenderTargets_InHeightRenderTarget_Offset;

	private static bool BlueprintGetRenderTargets_OutVelocityRenderTarget_IsValid;

	private static FFieldAddress BlueprintGetRenderTargets_OutVelocityRenderTarget_PropertyAddress;

	private static int BlueprintGetRenderTargets_OutVelocityRenderTarget_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:SetActorCache")]
	public unsafe void SetActorCache(AActor InActor, UObject InCache)
	{
		CheckDestroyed();
		if (!SetActorCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:SetActorCache");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorCache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorCache_InActor_Offset), 0, SetActorCache_InActor_PropertyAddress.Address, InActor);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetActorCache_InCache_Offset), 0, SetActorCache_InCache_PropertyAddress.Address, InCache);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetActorCache_FunctionAddress, intPtr, SetActorCache_ParamsSize);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:GetWaterBodyIslands")]
	public unsafe void GetWaterBodyIslands(TSubclassOf<AWaterBodyIsland> WaterBodyIslandClass, out List<AWaterBodyIsland> OutWaterBodyIslands)
	{
		CheckDestroyed();
		if (!GetWaterBodyIslands_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:GetWaterBodyIslands");
			OutWaterBodyIslands = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterBodyIslands_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterBodyIslands_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AWaterBodyIsland>.ToNative(IntPtr.Add(intPtr, GetWaterBodyIslands_WaterBodyIslandClass_Offset), 0, GetWaterBodyIslands_WaterBodyIslandClass_PropertyAddress.Address, WaterBodyIslandClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterBodyIslands_FunctionAddress, intPtr, GetWaterBodyIslands_ParamsSize);
		OutWaterBodyIslands = new TArrayCopyMarshaler<AWaterBodyIsland>(1, GetWaterBodyIslands_OutWaterBodyIslands_PropertyAddress, CachedMarshalingDelegates<AWaterBodyIsland, UObjectMarshaler<AWaterBodyIsland>>.FromNative, CachedMarshalingDelegates<AWaterBodyIsland, UObjectMarshaler<AWaterBodyIsland>>.ToNative).FromNative(IntPtr.Add(intPtr, GetWaterBodyIslands_OutWaterBodyIslands_Offset));
		NativeReflection.DestroyValue_InContainer(GetWaterBodyIslands_OutWaterBodyIslands_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:GetWaterBodies")]
	public unsafe void GetWaterBodies(TSubclassOf<AWaterBody> WaterBodyClass, out List<AWaterBody> OutWaterBodies)
	{
		CheckDestroyed();
		if (!GetWaterBodies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:GetWaterBodies");
			OutWaterBodies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterBodies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterBodies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AWaterBody>.ToNative(IntPtr.Add(intPtr, GetWaterBodies_WaterBodyClass_Offset), 0, GetWaterBodies_WaterBodyClass_PropertyAddress.Address, WaterBodyClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterBodies_FunctionAddress, intPtr, GetWaterBodies_ParamsSize);
		OutWaterBodies = new TArrayCopyMarshaler<AWaterBody>(1, GetWaterBodies_OutWaterBodies_PropertyAddress, CachedMarshalingDelegates<AWaterBody, UObjectMarshaler<AWaterBody>>.FromNative, CachedMarshalingDelegates<AWaterBody, UObjectMarshaler<AWaterBody>>.ToNative).FromNative(IntPtr.Add(intPtr, GetWaterBodies_OutWaterBodies_Offset));
		NativeReflection.DestroyValue_InContainer(GetWaterBodies_OutWaterBodies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:GetActorsAffectingLandscape")]
	public unsafe void GetActorsAffectingLandscape(out List<IWaterBrushActorInterface> OutWaterBrushActors)
	{
		CheckDestroyed();
		if (!GetActorsAffectingLandscape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:GetActorsAffectingLandscape");
			OutWaterBrushActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorsAffectingLandscape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorsAffectingLandscape_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorsAffectingLandscape_FunctionAddress, intPtr, GetActorsAffectingLandscape_ParamsSize);
		OutWaterBrushActors = new TArrayCopyMarshaler<IWaterBrushActorInterface>(1, GetActorsAffectingLandscape_OutWaterBrushActors_PropertyAddress, CachedMarshalingDelegates<IWaterBrushActorInterface, InterfaceMarshaler<IWaterBrushActorInterface>>.FromNative, CachedMarshalingDelegates<IWaterBrushActorInterface, InterfaceMarshaler<IWaterBrushActorInterface>>.ToNative).FromNative(IntPtr.Add(intPtr, GetActorsAffectingLandscape_OutWaterBrushActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorsAffectingLandscape_OutWaterBrushActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:GetActorCache")]
	public unsafe UObject GetActorCache(AActor InActor, TSubclassOf<UObject> CacheClass)
	{
		CheckDestroyed();
		if (!GetActorCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:GetActorCache");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorCache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorCache_InActor_Offset), 0, GetActorCache_InActor_PropertyAddress.Address, InActor);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetActorCache_CacheClass_Offset), 0, GetActorCache_CacheClass_PropertyAddress.Address, CacheClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorCache_FunctionAddress, intPtr, GetActorCache_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetActorCache_ReturnValue_Offset), 0, GetActorCache_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:ForceWaterTextureUpdate")]
	public unsafe void ForceWaterTextureUpdate()
	{
		CheckDestroyed();
		if (!ForceWaterTextureUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:ForceWaterTextureUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceWaterTextureUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceWaterTextureUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceWaterTextureUpdate_FunctionAddress, argsSize: ForceWaterTextureUpdate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:ClearActorCache")]
	public unsafe void ClearActorCache(AActor InActor)
	{
		CheckDestroyed();
		if (!ClearActorCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:ClearActorCache");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearActorCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearActorCache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ClearActorCache_InActor_Offset), 0, ClearActorCache_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearActorCache_FunctionAddress, intPtr, ClearActorCache_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:BlueprintWaterBodyChanged")]
	public unsafe void BlueprintWaterBodyChanged(AActor Actor)
	{
		CheckDestroyed();
		if (!BlueprintWaterBodyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:BlueprintWaterBodyChanged");
			return;
		}
		if (BlueprintWaterBodyChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			BlueprintWaterBodyChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BlueprintWaterBodyChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintWaterBodyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintWaterBodyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BlueprintWaterBodyChanged_Actor_Offset), 0, BlueprintWaterBodyChanged_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintWaterBodyChanged_InstanceFunctionAddress, intPtr, BlueprintWaterBodyChanged_ParamsSize);
	}

	protected unsafe virtual void BlueprintWaterBodyChanged_Implementation(AActor Actor)
	{
		CheckDestroyed();
		if (!BlueprintWaterBodyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:BlueprintWaterBodyChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintWaterBodyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintWaterBodyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BlueprintWaterBodyChanged_Actor_Offset), 0, BlueprintWaterBodyChanged_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintWaterBodyChanged_FunctionAddress, intPtr, BlueprintWaterBodyChanged_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:BlueprintWaterBodiesChanged")]
	public unsafe void BlueprintWaterBodiesChanged()
	{
		CheckDestroyed();
		if (!BlueprintWaterBodiesChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:BlueprintWaterBodiesChanged");
			return;
		}
		if (BlueprintWaterBodiesChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			BlueprintWaterBodiesChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BlueprintWaterBodiesChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintWaterBodiesChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintWaterBodiesChanged_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BlueprintWaterBodiesChanged_InstanceFunctionAddress, argsSize: BlueprintWaterBodiesChanged_ParamsSize);
	}

	protected unsafe virtual void BlueprintWaterBodiesChanged_Implementation()
	{
		CheckDestroyed();
		if (!BlueprintWaterBodiesChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:BlueprintWaterBodiesChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintWaterBodiesChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintWaterBodiesChanged_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BlueprintWaterBodiesChanged_FunctionAddress, argsSize: BlueprintWaterBodiesChanged_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:BlueprintOnRenderTargetTexturesUpdated")]
	public unsafe void BlueprintOnRenderTargetTexturesUpdated(UTexture2D VelocityTexture)
	{
		CheckDestroyed();
		if (!BlueprintOnRenderTargetTexturesUpdated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:BlueprintOnRenderTargetTexturesUpdated");
			return;
		}
		if (BlueprintOnRenderTargetTexturesUpdated_InstanceFunctionAddress == IntPtr.Zero)
		{
			BlueprintOnRenderTargetTexturesUpdated_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BlueprintOnRenderTargetTexturesUpdated");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintOnRenderTargetTexturesUpdated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintOnRenderTargetTexturesUpdated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_Offset), 0, BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_PropertyAddress.Address, VelocityTexture);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintOnRenderTargetTexturesUpdated_InstanceFunctionAddress, intPtr, BlueprintOnRenderTargetTexturesUpdated_ParamsSize);
	}

	protected unsafe virtual void BlueprintOnRenderTargetTexturesUpdated_Implementation(UTexture2D VelocityTexture)
	{
		CheckDestroyed();
		if (!BlueprintOnRenderTargetTexturesUpdated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:BlueprintOnRenderTargetTexturesUpdated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintOnRenderTargetTexturesUpdated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintOnRenderTargetTexturesUpdated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_Offset), 0, BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_PropertyAddress.Address, VelocityTexture);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintOnRenderTargetTexturesUpdated_FunctionAddress, intPtr, BlueprintOnRenderTargetTexturesUpdated_ParamsSize);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/WaterEditor.WaterLandscapeBrush:BlueprintGetRenderTargets")]
	public unsafe void BlueprintGetRenderTargets(UTextureRenderTarget2D InHeightRenderTarget, out UTextureRenderTarget2D OutVelocityRenderTarget)
	{
		CheckDestroyed();
		if (!BlueprintGetRenderTargets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:BlueprintGetRenderTargets");
			OutVelocityRenderTarget = null;
			return;
		}
		if (BlueprintGetRenderTargets_InstanceFunctionAddress == IntPtr.Zero)
		{
			BlueprintGetRenderTargets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BlueprintGetRenderTargets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintGetRenderTargets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintGetRenderTargets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, BlueprintGetRenderTargets_InHeightRenderTarget_Offset), 0, BlueprintGetRenderTargets_InHeightRenderTarget_PropertyAddress.Address, InHeightRenderTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintGetRenderTargets_InstanceFunctionAddress, intPtr, BlueprintGetRenderTargets_ParamsSize);
		OutVelocityRenderTarget = UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, BlueprintGetRenderTargets_OutVelocityRenderTarget_Offset), 0, BlueprintGetRenderTargets_OutVelocityRenderTarget_PropertyAddress.Address);
	}

	protected unsafe virtual void BlueprintGetRenderTargets_Implementation(UTextureRenderTarget2D InHeightRenderTarget, out UTextureRenderTarget2D OutVelocityRenderTarget)
	{
		CheckDestroyed();
		if (!BlueprintGetRenderTargets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.WaterLandscapeBrush:BlueprintGetRenderTargets");
			OutVelocityRenderTarget = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlueprintGetRenderTargets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlueprintGetRenderTargets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, BlueprintGetRenderTargets_InHeightRenderTarget_Offset), 0, BlueprintGetRenderTargets_InHeightRenderTarget_PropertyAddress.Address, InHeightRenderTarget);
		NativeReflection.InvokeFunctionOptimized(base.Address, BlueprintGetRenderTargets_FunctionAddress, intPtr, BlueprintGetRenderTargets_ParamsSize);
		OutVelocityRenderTarget = UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, BlueprintGetRenderTargets_OutVelocityRenderTarget_Offset), 0, BlueprintGetRenderTargets_OutVelocityRenderTarget_PropertyAddress.Address);
	}

	static AWaterLandscapeBrush()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AWaterLandscapeBrush)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AWaterLandscapeBrush));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/WaterEditor.WaterLandscapeBrush");
		SetActorCache_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetActorCache");
		SetActorCache_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorCache_InActor_PropertyAddress, SetActorCache_FunctionAddress, "InActor");
		SetActorCache_InActor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorCache_FunctionAddress, "InActor");
		SetActorCache_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorCache_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorCache_InCache_PropertyAddress, SetActorCache_FunctionAddress, "InCache");
		SetActorCache_InCache_Offset = NativeReflectionCached.GetPropertyOffset(SetActorCache_FunctionAddress, "InCache");
		SetActorCache_InCache_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorCache_FunctionAddress, "InCache", Classes.FObjectProperty);
		SetActorCache_IsValid = SetActorCache_FunctionAddress != IntPtr.Zero && SetActorCache_InActor_IsValid && SetActorCache_InCache_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:SetActorCache", SetActorCache_IsValid);
		GetWaterBodyIslands_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWaterBodyIslands");
		GetWaterBodyIslands_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterBodyIslands_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterBodyIslands_WaterBodyIslandClass_PropertyAddress, GetWaterBodyIslands_FunctionAddress, "WaterBodyIslandClass");
		GetWaterBodyIslands_WaterBodyIslandClass_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterBodyIslands_FunctionAddress, "WaterBodyIslandClass");
		GetWaterBodyIslands_WaterBodyIslandClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterBodyIslands_FunctionAddress, "WaterBodyIslandClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterBodyIslands_OutWaterBodyIslands_PropertyAddress, GetWaterBodyIslands_FunctionAddress, "OutWaterBodyIslands");
		GetWaterBodyIslands_OutWaterBodyIslands_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterBodyIslands_FunctionAddress, "OutWaterBodyIslands");
		GetWaterBodyIslands_OutWaterBodyIslands_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterBodyIslands_FunctionAddress, "OutWaterBodyIslands", Classes.FArrayProperty);
		GetWaterBodyIslands_IsValid = GetWaterBodyIslands_FunctionAddress != IntPtr.Zero && GetWaterBodyIslands_WaterBodyIslandClass_IsValid && GetWaterBodyIslands_OutWaterBodyIslands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:GetWaterBodyIslands", GetWaterBodyIslands_IsValid);
		GetWaterBodies_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWaterBodies");
		GetWaterBodies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterBodies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterBodies_WaterBodyClass_PropertyAddress, GetWaterBodies_FunctionAddress, "WaterBodyClass");
		GetWaterBodies_WaterBodyClass_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterBodies_FunctionAddress, "WaterBodyClass");
		GetWaterBodies_WaterBodyClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterBodies_FunctionAddress, "WaterBodyClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWaterBodies_OutWaterBodies_PropertyAddress, GetWaterBodies_FunctionAddress, "OutWaterBodies");
		GetWaterBodies_OutWaterBodies_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterBodies_FunctionAddress, "OutWaterBodies");
		GetWaterBodies_OutWaterBodies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterBodies_FunctionAddress, "OutWaterBodies", Classes.FArrayProperty);
		GetWaterBodies_IsValid = GetWaterBodies_FunctionAddress != IntPtr.Zero && GetWaterBodies_WaterBodyClass_IsValid && GetWaterBodies_OutWaterBodies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:GetWaterBodies", GetWaterBodies_IsValid);
		GetActorsAffectingLandscape_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorsAffectingLandscape");
		GetActorsAffectingLandscape_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorsAffectingLandscape_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorsAffectingLandscape_OutWaterBrushActors_PropertyAddress, GetActorsAffectingLandscape_FunctionAddress, "OutWaterBrushActors");
		GetActorsAffectingLandscape_OutWaterBrushActors_Offset = NativeReflectionCached.GetPropertyOffset(GetActorsAffectingLandscape_FunctionAddress, "OutWaterBrushActors");
		GetActorsAffectingLandscape_OutWaterBrushActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorsAffectingLandscape_FunctionAddress, "OutWaterBrushActors", Classes.FArrayProperty);
		GetActorsAffectingLandscape_IsValid = GetActorsAffectingLandscape_FunctionAddress != IntPtr.Zero && GetActorsAffectingLandscape_OutWaterBrushActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:GetActorsAffectingLandscape", GetActorsAffectingLandscape_IsValid);
		GetActorCache_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorCache");
		GetActorCache_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorCache_InActor_PropertyAddress, GetActorCache_FunctionAddress, "InActor");
		GetActorCache_InActor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorCache_FunctionAddress, "InActor");
		GetActorCache_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorCache_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorCache_CacheClass_PropertyAddress, GetActorCache_FunctionAddress, "CacheClass");
		GetActorCache_CacheClass_Offset = NativeReflectionCached.GetPropertyOffset(GetActorCache_FunctionAddress, "CacheClass");
		GetActorCache_CacheClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorCache_FunctionAddress, "CacheClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorCache_ReturnValue_PropertyAddress, GetActorCache_FunctionAddress, "ReturnValue");
		GetActorCache_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorCache_FunctionAddress, "ReturnValue");
		GetActorCache_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorCache_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActorCache_IsValid = GetActorCache_FunctionAddress != IntPtr.Zero && GetActorCache_InActor_IsValid && GetActorCache_CacheClass_IsValid && GetActorCache_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:GetActorCache", GetActorCache_IsValid);
		ForceWaterTextureUpdate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ForceWaterTextureUpdate");
		ForceWaterTextureUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceWaterTextureUpdate_FunctionAddress);
		ForceWaterTextureUpdate_IsValid = ForceWaterTextureUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:ForceWaterTextureUpdate", ForceWaterTextureUpdate_IsValid);
		ClearActorCache_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearActorCache");
		ClearActorCache_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearActorCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearActorCache_InActor_PropertyAddress, ClearActorCache_FunctionAddress, "InActor");
		ClearActorCache_InActor_Offset = NativeReflectionCached.GetPropertyOffset(ClearActorCache_FunctionAddress, "InActor");
		ClearActorCache_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearActorCache_FunctionAddress, "InActor", Classes.FObjectProperty);
		ClearActorCache_IsValid = ClearActorCache_FunctionAddress != IntPtr.Zero && ClearActorCache_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:ClearActorCache", ClearActorCache_IsValid);
		BlueprintWaterBodyChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BlueprintWaterBodyChanged");
		BlueprintWaterBodyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintWaterBodyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlueprintWaterBodyChanged_Actor_PropertyAddress, BlueprintWaterBodyChanged_FunctionAddress, "Actor");
		BlueprintWaterBodyChanged_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintWaterBodyChanged_FunctionAddress, "Actor");
		BlueprintWaterBodyChanged_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintWaterBodyChanged_FunctionAddress, "Actor", Classes.FObjectProperty);
		BlueprintWaterBodyChanged_IsValid = BlueprintWaterBodyChanged_FunctionAddress != IntPtr.Zero && BlueprintWaterBodyChanged_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:BlueprintWaterBodyChanged", BlueprintWaterBodyChanged_IsValid);
		BlueprintWaterBodiesChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BlueprintWaterBodiesChanged");
		BlueprintWaterBodiesChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintWaterBodiesChanged_FunctionAddress);
		BlueprintWaterBodiesChanged_IsValid = BlueprintWaterBodiesChanged_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:BlueprintWaterBodiesChanged", BlueprintWaterBodiesChanged_IsValid);
		BlueprintOnRenderTargetTexturesUpdated_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BlueprintOnRenderTargetTexturesUpdated");
		BlueprintOnRenderTargetTexturesUpdated_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintOnRenderTargetTexturesUpdated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_PropertyAddress, BlueprintOnRenderTargetTexturesUpdated_FunctionAddress, "VelocityTexture");
		BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintOnRenderTargetTexturesUpdated_FunctionAddress, "VelocityTexture");
		BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintOnRenderTargetTexturesUpdated_FunctionAddress, "VelocityTexture", Classes.FObjectProperty);
		BlueprintOnRenderTargetTexturesUpdated_IsValid = BlueprintOnRenderTargetTexturesUpdated_FunctionAddress != IntPtr.Zero && BlueprintOnRenderTargetTexturesUpdated_VelocityTexture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:BlueprintOnRenderTargetTexturesUpdated", BlueprintOnRenderTargetTexturesUpdated_IsValid);
		BlueprintGetRenderTargets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BlueprintGetRenderTargets");
		BlueprintGetRenderTargets_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintGetRenderTargets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlueprintGetRenderTargets_InHeightRenderTarget_PropertyAddress, BlueprintGetRenderTargets_FunctionAddress, "InHeightRenderTarget");
		BlueprintGetRenderTargets_InHeightRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintGetRenderTargets_FunctionAddress, "InHeightRenderTarget");
		BlueprintGetRenderTargets_InHeightRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintGetRenderTargets_FunctionAddress, "InHeightRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BlueprintGetRenderTargets_OutVelocityRenderTarget_PropertyAddress, BlueprintGetRenderTargets_FunctionAddress, "OutVelocityRenderTarget");
		BlueprintGetRenderTargets_OutVelocityRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(BlueprintGetRenderTargets_FunctionAddress, "OutVelocityRenderTarget");
		BlueprintGetRenderTargets_OutVelocityRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(BlueprintGetRenderTargets_FunctionAddress, "OutVelocityRenderTarget", Classes.FObjectProperty);
		BlueprintGetRenderTargets_IsValid = BlueprintGetRenderTargets_FunctionAddress != IntPtr.Zero && BlueprintGetRenderTargets_InHeightRenderTarget_IsValid && BlueprintGetRenderTargets_OutVelocityRenderTarget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.WaterLandscapeBrush:BlueprintGetRenderTargets", BlueprintGetRenderTargets_IsValid);
	}
}
