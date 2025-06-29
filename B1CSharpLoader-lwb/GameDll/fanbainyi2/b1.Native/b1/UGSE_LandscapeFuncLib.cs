using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_LandscapeFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UpdateLandescape_IsValid;

	private static IntPtr UpdateLandescape_FunctionAddress;

	private static int UpdateLandescape_ParamsSize;

	private static bool UpdateLandescape_Landscape_IsValid;

	private static FFieldAddress UpdateLandescape_Landscape_PropertyAddress;

	private static int UpdateLandescape_Landscape_Offset;

	private static bool SplitLandscapeToGrid_IsValid;

	private static IntPtr SplitLandscapeToGrid_FunctionAddress;

	private static int SplitLandscapeToGrid_ParamsSize;

	private static bool SplitLandscapeToGrid_InStreamingLevel_IsValid;

	private static FFieldAddress SplitLandscapeToGrid_InStreamingLevel_PropertyAddress;

	private static int SplitLandscapeToGrid_InStreamingLevel_Offset;

	private static bool SplitLandscapeToGrid_GridBox_IsValid;

	private static FFieldAddress SplitLandscapeToGrid_GridBox_PropertyAddress;

	private static int SplitLandscapeToGrid_GridBox_Offset;

	private static bool SplitLandscapeToGrid_Lands_IsValid;

	private static FFieldAddress SplitLandscapeToGrid_Lands_PropertyAddress;

	private static int SplitLandscapeToGrid_Lands_Offset;

	private static bool SplitFoliageToGrid_IsValid;

	private static IntPtr SplitFoliageToGrid_FunctionAddress;

	private static int SplitFoliageToGrid_ParamsSize;

	private static bool SplitFoliageToGrid_InStreamingLevels_IsValid;

	private static FFieldAddress SplitFoliageToGrid_InStreamingLevels_PropertyAddress;

	private static int SplitFoliageToGrid_InStreamingLevels_Offset;

	private static bool SplitFoliageToGrid_GridBoxs_IsValid;

	private static FFieldAddress SplitFoliageToGrid_GridBoxs_PropertyAddress;

	private static int SplitFoliageToGrid_GridBoxs_Offset;

	private static bool SaveLandscapeWeight_IsValid;

	private static IntPtr SaveLandscapeWeight_FunctionAddress;

	private static int SaveLandscapeWeight_ParamsSize;

	private static bool SaveLandscapeWeight_PackagePath_IsValid;

	private static FFieldAddress SaveLandscapeWeight_PackagePath_PropertyAddress;

	private static int SaveLandscapeWeight_PackagePath_Offset;

	private static bool SaveLandscapeWeight_LandscapeActor_IsValid;

	private static FFieldAddress SaveLandscapeWeight_LandscapeActor_PropertyAddress;

	private static int SaveLandscapeWeight_LandscapeActor_Offset;

	private static bool SaveLandscapeWeight_ReturnValue_IsValid;

	private static FFieldAddress SaveLandscapeWeight_ReturnValue_PropertyAddress;

	private static int SaveLandscapeWeight_ReturnValue_Offset;

	private static bool SaveLandscapeLayerWeightTex_IsValid;

	private static IntPtr SaveLandscapeLayerWeightTex_FunctionAddress;

	private static int SaveLandscapeLayerWeightTex_ParamsSize;

	private static bool SaveLandscapeLayerWeightTex_packagePath_IsValid;

	private static FFieldAddress SaveLandscapeLayerWeightTex_packagePath_PropertyAddress;

	private static int SaveLandscapeLayerWeightTex_packagePath_Offset;

	private static bool SaveLandscapeLayerWeightTex_AssetName_IsValid;

	private static FFieldAddress SaveLandscapeLayerWeightTex_AssetName_PropertyAddress;

	private static int SaveLandscapeLayerWeightTex_AssetName_Offset;

	private static bool SaveLandscapeLayerWeightTex_landscapeActor_IsValid;

	private static FFieldAddress SaveLandscapeLayerWeightTex_landscapeActor_PropertyAddress;

	private static int SaveLandscapeLayerWeightTex_landscapeActor_Offset;

	private static bool SaveLandscapeLayerWeightTex_LayerName_IsValid;

	private static FFieldAddress SaveLandscapeLayerWeightTex_LayerName_PropertyAddress;

	private static int SaveLandscapeLayerWeightTex_LayerName_Offset;

	private static bool SaveLandscapeLayerWeightTex_ReturnValue_IsValid;

	private static FFieldAddress SaveLandscapeLayerWeightTex_ReturnValue_PropertyAddress;

	private static int SaveLandscapeLayerWeightTex_ReturnValue_Offset;

	private static bool ResizeLandscapeExpandByQuads_IsValid;

	private static IntPtr ResizeLandscapeExpandByQuads_FunctionAddress;

	private static int ResizeLandscapeExpandByQuads_ParamsSize;

	private static bool ResizeLandscapeExpandByQuads_OldLandscape_IsValid;

	private static FFieldAddress ResizeLandscapeExpandByQuads_OldLandscape_PropertyAddress;

	private static int ResizeLandscapeExpandByQuads_OldLandscape_Offset;

	private static bool ResizeLandscapeExpandByQuads_SubsectionSizeQuads_IsValid;

	private static FFieldAddress ResizeLandscapeExpandByQuads_SubsectionSizeQuads_PropertyAddress;

	private static int ResizeLandscapeExpandByQuads_SubsectionSizeQuads_Offset;

	private static bool ResizeLandscapeExpandByQuads_ReturnValue_IsValid;

	private static FFieldAddress ResizeLandscapeExpandByQuads_ReturnValue_PropertyAddress;

	private static int ResizeLandscapeExpandByQuads_ReturnValue_Offset;

	private static bool RefreshLevelBrowser_IsValid;

	private static IntPtr RefreshLevelBrowser_FunctionAddress;

	private static int RefreshLevelBrowser_ParamsSize;

	private static bool RecreateLandscapeActorByProxy_IsValid;

	private static IntPtr RecreateLandscapeActorByProxy_FunctionAddress;

	private static int RecreateLandscapeActorByProxy_ParamsSize;

	private static bool RecreateLandscapeActorByProxy_LandscapeProxy_IsValid;

	private static FFieldAddress RecreateLandscapeActorByProxy_LandscapeProxy_PropertyAddress;

	private static int RecreateLandscapeActorByProxy_LandscapeProxy_Offset;

	private static bool GetLandscapeOriginOffset_IsValid;

	private static IntPtr GetLandscapeOriginOffset_FunctionAddress;

	private static int GetLandscapeOriginOffset_ParamsSize;

	private static bool GetLandscapeOriginOffset_LandscapeActor_IsValid;

	private static FFieldAddress GetLandscapeOriginOffset_LandscapeActor_PropertyAddress;

	private static int GetLandscapeOriginOffset_LandscapeActor_Offset;

	private static bool GetLandscapeOriginOffset_ReturnValue_IsValid;

	private static FFieldAddress GetLandscapeOriginOffset_ReturnValue_PropertyAddress;

	private static int GetLandscapeOriginOffset_ReturnValue_Offset;

	private static bool GetBPBrushOwningLandscape_IsValid;

	private static IntPtr GetBPBrushOwningLandscape_FunctionAddress;

	private static int GetBPBrushOwningLandscape_ParamsSize;

	private static bool GetBPBrushOwningLandscape_BPBrush_IsValid;

	private static FFieldAddress GetBPBrushOwningLandscape_BPBrush_PropertyAddress;

	private static int GetBPBrushOwningLandscape_BPBrush_Offset;

	private static bool GetBPBrushOwningLandscape_ReturnValue_IsValid;

	private static FFieldAddress GetBPBrushOwningLandscape_ReturnValue_PropertyAddress;

	private static int GetBPBrushOwningLandscape_ReturnValue_Offset;

	private static bool GetAllActorsInStreamingLevel_IsValid;

	private static IntPtr GetAllActorsInStreamingLevel_FunctionAddress;

	private static int GetAllActorsInStreamingLevel_ParamsSize;

	private static bool GetAllActorsInStreamingLevel_InStreamingLevel_IsValid;

	private static FFieldAddress GetAllActorsInStreamingLevel_InStreamingLevel_PropertyAddress;

	private static int GetAllActorsInStreamingLevel_InStreamingLevel_Offset;

	private static bool GetAllActorsInStreamingLevel_ActorClass_IsValid;

	private static FFieldAddress GetAllActorsInStreamingLevel_ActorClass_PropertyAddress;

	private static int GetAllActorsInStreamingLevel_ActorClass_Offset;

	private static bool GetAllActorsInStreamingLevel_OutActors_IsValid;

	private static FFieldAddress GetAllActorsInStreamingLevel_OutActors_PropertyAddress;

	private static int GetAllActorsInStreamingLevel_OutActors_Offset;

	private static bool CleanGridLevels_IsValid;

	private static IntPtr CleanGridLevels_FunctionAddress;

	private static int CleanGridLevels_ParamsSize;

	private static bool CleanGridLevels_InStreamingLevel_IsValid;

	private static FFieldAddress CleanGridLevels_InStreamingLevel_PropertyAddress;

	private static int CleanGridLevels_InStreamingLevel_Offset;

	private static bool CleanGridLevels_GridBox_IsValid;

	private static FFieldAddress CleanGridLevels_GridBox_PropertyAddress;

	private static int CleanGridLevels_GridBox_Offset;

	private static bool AddLocationsToStreamingManager_IsValid;

	private static IntPtr AddLocationsToStreamingManager_FunctionAddress;

	private static int AddLocationsToStreamingManager_ParamsSize;

	private static bool AddLocationsToStreamingManager_Locations_IsValid;

	private static FFieldAddress AddLocationsToStreamingManager_Locations_PropertyAddress;

	private static int AddLocationsToStreamingManager_Locations_Offset;

	private static bool AddLocationsToStreamingManager_Duration_IsValid;

	private static FFieldAddress AddLocationsToStreamingManager_Duration_PropertyAddress;

	private static int AddLocationsToStreamingManager_Duration_Offset;

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:UpdateLandescape")]
	public unsafe static void UpdateLandescape(ALandscape Landscape)
	{
		if (!UpdateLandescape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:UpdateLandescape");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateLandescape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateLandescape_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(intPtr, UpdateLandescape_Landscape_Offset), 0, UpdateLandescape_Landscape_PropertyAddress.Address, Landscape);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateLandescape_FunctionAddress, intPtr, UpdateLandescape_ParamsSize);
	}

	[UFunction(Flags = 612508673u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:SplitLandscapeToGrid")]
	public unsafe static void SplitLandscapeToGrid(ULevelStreaming InStreamingLevel, FBox GridBox, List<ALandscape> Lands)
	{
		if (!SplitLandscapeToGrid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:SplitLandscapeToGrid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SplitLandscapeToGrid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SplitLandscapeToGrid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelStreaming>.ToNative(IntPtr.Add(intPtr, SplitLandscapeToGrid_InStreamingLevel_Offset), 0, SplitLandscapeToGrid_InStreamingLevel_PropertyAddress.Address, InStreamingLevel);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, SplitLandscapeToGrid_GridBox_Offset), 0, SplitLandscapeToGrid_GridBox_PropertyAddress.Address, GridBox);
		new TArrayCopyMarshaler<ALandscape>(1, SplitLandscapeToGrid_Lands_PropertyAddress, CachedMarshalingDelegates<ALandscape, UObjectMarshaler<ALandscape>>.FromNative, CachedMarshalingDelegates<ALandscape, UObjectMarshaler<ALandscape>>.ToNative).ToNative(IntPtr.Add(intPtr, SplitLandscapeToGrid_Lands_Offset), Lands);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SplitLandscapeToGrid_FunctionAddress, intPtr, SplitLandscapeToGrid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SplitLandscapeToGrid_Lands_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:SplitFoliageToGrid")]
	public unsafe static void SplitFoliageToGrid(List<ULevelStreaming> InStreamingLevels, List<FBox> GridBoxs)
	{
		if (!SplitFoliageToGrid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:SplitFoliageToGrid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SplitFoliageToGrid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SplitFoliageToGrid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<ULevelStreaming>(1, SplitFoliageToGrid_InStreamingLevels_PropertyAddress, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.FromNative, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.ToNative).ToNative(IntPtr.Add(intPtr, SplitFoliageToGrid_InStreamingLevels_Offset), InStreamingLevels);
		new TArrayCopyMarshaler<FBox>(1, SplitFoliageToGrid_GridBoxs_PropertyAddress, CachedMarshalingDelegates<FBox, BlittableTypeMarshaler<FBox>>.FromNative, CachedMarshalingDelegates<FBox, BlittableTypeMarshaler<FBox>>.ToNative).ToNative(IntPtr.Add(intPtr, SplitFoliageToGrid_GridBoxs_Offset), GridBoxs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SplitFoliageToGrid_FunctionAddress, intPtr, SplitFoliageToGrid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SplitFoliageToGrid_InStreamingLevels_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SplitFoliageToGrid_GridBoxs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:SaveLandscapeWeight")]
	public unsafe static FVector SaveLandscapeWeight(string PackagePath, AActor LandscapeActor)
	{
		if (!SaveLandscapeWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:SaveLandscapeWeight");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveLandscapeWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveLandscapeWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveLandscapeWeight_PackagePath_Offset), 0, SaveLandscapeWeight_PackagePath_PropertyAddress.Address, PackagePath);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SaveLandscapeWeight_LandscapeActor_Offset), 0, SaveLandscapeWeight_LandscapeActor_PropertyAddress.Address, LandscapeActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveLandscapeWeight_FunctionAddress, intPtr, SaveLandscapeWeight_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveLandscapeWeight_PackagePath_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, SaveLandscapeWeight_ReturnValue_Offset), 0, SaveLandscapeWeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:SaveLandscapeLayerWeightTex")]
	public unsafe static UTexture2D SaveLandscapeLayerWeightTex(string packagePath, string AssetName, AActor landscapeActor, string LayerName)
	{
		if (!SaveLandscapeLayerWeightTex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:SaveLandscapeLayerWeightTex");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveLandscapeLayerWeightTex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveLandscapeLayerWeightTex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveLandscapeLayerWeightTex_packagePath_Offset), 0, SaveLandscapeLayerWeightTex_packagePath_PropertyAddress.Address, packagePath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveLandscapeLayerWeightTex_AssetName_Offset), 0, SaveLandscapeLayerWeightTex_AssetName_PropertyAddress.Address, AssetName);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SaveLandscapeLayerWeightTex_landscapeActor_Offset), 0, SaveLandscapeLayerWeightTex_landscapeActor_PropertyAddress.Address, landscapeActor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveLandscapeLayerWeightTex_LayerName_Offset), 0, SaveLandscapeLayerWeightTex_LayerName_PropertyAddress.Address, LayerName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveLandscapeLayerWeightTex_FunctionAddress, intPtr, SaveLandscapeLayerWeightTex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveLandscapeLayerWeightTex_packagePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveLandscapeLayerWeightTex_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveLandscapeLayerWeightTex_LayerName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, SaveLandscapeLayerWeightTex_ReturnValue_Offset), 0, SaveLandscapeLayerWeightTex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:ResizeLandscapeExpandByQuads")]
	public unsafe static ALandscape ResizeLandscapeExpandByQuads(ALandscape OldLandscape, int SubsectionSizeQuads)
	{
		if (!ResizeLandscapeExpandByQuads_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:ResizeLandscapeExpandByQuads");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResizeLandscapeExpandByQuads_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResizeLandscapeExpandByQuads_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(intPtr, ResizeLandscapeExpandByQuads_OldLandscape_Offset), 0, ResizeLandscapeExpandByQuads_OldLandscape_PropertyAddress.Address, OldLandscape);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ResizeLandscapeExpandByQuads_SubsectionSizeQuads_Offset), 0, ResizeLandscapeExpandByQuads_SubsectionSizeQuads_PropertyAddress.Address, SubsectionSizeQuads);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResizeLandscapeExpandByQuads_FunctionAddress, intPtr, ResizeLandscapeExpandByQuads_ParamsSize);
		return UObjectMarshaler<ALandscape>.FromNative(IntPtr.Add(intPtr, ResizeLandscapeExpandByQuads_ReturnValue_Offset), 0, ResizeLandscapeExpandByQuads_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:RefreshLevelBrowser")]
	public unsafe static void RefreshLevelBrowser()
	{
		if (!RefreshLevelBrowser_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:RefreshLevelBrowser");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshLevelBrowser_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshLevelBrowser_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RefreshLevelBrowser_FunctionAddress, argsSize: RefreshLevelBrowser_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:RecreateLandscapeActorByProxy")]
	public unsafe static void RecreateLandscapeActorByProxy(AActor LandscapeProxy)
	{
		if (!RecreateLandscapeActorByProxy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:RecreateLandscapeActorByProxy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecreateLandscapeActorByProxy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecreateLandscapeActorByProxy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RecreateLandscapeActorByProxy_LandscapeProxy_Offset), 0, RecreateLandscapeActorByProxy_LandscapeProxy_PropertyAddress.Address, LandscapeProxy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RecreateLandscapeActorByProxy_FunctionAddress, intPtr, RecreateLandscapeActorByProxy_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:GetLandscapeOriginOffset")]
	public unsafe static FVector GetLandscapeOriginOffset(AActor LandscapeActor)
	{
		if (!GetLandscapeOriginOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:GetLandscapeOriginOffset");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLandscapeOriginOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLandscapeOriginOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetLandscapeOriginOffset_LandscapeActor_Offset), 0, GetLandscapeOriginOffset_LandscapeActor_PropertyAddress.Address, LandscapeActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLandscapeOriginOffset_FunctionAddress, intPtr, GetLandscapeOriginOffset_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLandscapeOriginOffset_ReturnValue_Offset), 0, GetLandscapeOriginOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:GetBPBrushOwningLandscape")]
	public unsafe static ALandscape GetBPBrushOwningLandscape(ALandscapeBlueprintBrushBase BPBrush)
	{
		if (!GetBPBrushOwningLandscape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:GetBPBrushOwningLandscape");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBPBrushOwningLandscape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBPBrushOwningLandscape_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscapeBlueprintBrushBase>.ToNative(IntPtr.Add(intPtr, GetBPBrushOwningLandscape_BPBrush_Offset), 0, GetBPBrushOwningLandscape_BPBrush_PropertyAddress.Address, BPBrush);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBPBrushOwningLandscape_FunctionAddress, intPtr, GetBPBrushOwningLandscape_ParamsSize);
		return UObjectMarshaler<ALandscape>.FromNative(IntPtr.Add(intPtr, GetBPBrushOwningLandscape_ReturnValue_Offset), 0, GetBPBrushOwningLandscape_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:GetAllActorsInStreamingLevel")]
	public unsafe static void GetAllActorsInStreamingLevel(ULevelStreaming InStreamingLevel, TSubclassOf<AActor> ActorClass, out List<AActor> OutActors)
	{
		if (!GetAllActorsInStreamingLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:GetAllActorsInStreamingLevel");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllActorsInStreamingLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllActorsInStreamingLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelStreaming>.ToNative(IntPtr.Add(intPtr, GetAllActorsInStreamingLevel_InStreamingLevel_Offset), 0, GetAllActorsInStreamingLevel_InStreamingLevel_PropertyAddress.Address, InStreamingLevel);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetAllActorsInStreamingLevel_ActorClass_Offset), 0, GetAllActorsInStreamingLevel_ActorClass_PropertyAddress.Address, ActorClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllActorsInStreamingLevel_FunctionAddress, intPtr, GetAllActorsInStreamingLevel_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetAllActorsInStreamingLevel_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllActorsInStreamingLevel_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllActorsInStreamingLevel_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 612508673u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:CleanGridLevels")]
	public unsafe static void CleanGridLevels(ULevelStreaming InStreamingLevel, FBox GridBox)
	{
		if (!CleanGridLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:CleanGridLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanGridLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanGridLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelStreaming>.ToNative(IntPtr.Add(intPtr, CleanGridLevels_InStreamingLevel_Offset), 0, CleanGridLevels_InStreamingLevel_PropertyAddress.Address, InStreamingLevel);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, CleanGridLevels_GridBox_Offset), 0, CleanGridLevels_GridBox_PropertyAddress.Address, GridBox);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CleanGridLevels_FunctionAddress, intPtr, CleanGridLevels_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_LandscapeFuncLib:AddLocationsToStreamingManager")]
	public unsafe static void AddLocationsToStreamingManager(List<FVector> Locations, float Duration)
	{
		if (!AddLocationsToStreamingManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_LandscapeFuncLib:AddLocationsToStreamingManager");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLocationsToStreamingManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLocationsToStreamingManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, AddLocationsToStreamingManager_Locations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, AddLocationsToStreamingManager_Locations_Offset), Locations);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddLocationsToStreamingManager_Duration_Offset), 0, AddLocationsToStreamingManager_Duration_PropertyAddress.Address, Duration);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddLocationsToStreamingManager_FunctionAddress, intPtr, AddLocationsToStreamingManager_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddLocationsToStreamingManager_Locations_PropertyAddress.Address, intPtr);
	}

	static UGSE_LandscapeFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_LandscapeFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_LandscapeFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_LandscapeFuncLib");
		UpdateLandescape_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateLandescape");
		UpdateLandescape_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateLandescape_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateLandescape_Landscape_PropertyAddress, UpdateLandescape_FunctionAddress, "Landscape");
		UpdateLandescape_Landscape_Offset = NativeReflectionCached.GetPropertyOffset(UpdateLandescape_FunctionAddress, "Landscape");
		UpdateLandescape_Landscape_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateLandescape_FunctionAddress, "Landscape", Classes.FObjectProperty);
		UpdateLandescape_IsValid = UpdateLandescape_FunctionAddress != IntPtr.Zero && UpdateLandescape_Landscape_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:UpdateLandescape", UpdateLandescape_IsValid);
		SplitLandscapeToGrid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SplitLandscapeToGrid");
		SplitLandscapeToGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(SplitLandscapeToGrid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SplitLandscapeToGrid_InStreamingLevel_PropertyAddress, SplitLandscapeToGrid_FunctionAddress, "InStreamingLevel");
		SplitLandscapeToGrid_InStreamingLevel_Offset = NativeReflectionCached.GetPropertyOffset(SplitLandscapeToGrid_FunctionAddress, "InStreamingLevel");
		SplitLandscapeToGrid_InStreamingLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitLandscapeToGrid_FunctionAddress, "InStreamingLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitLandscapeToGrid_GridBox_PropertyAddress, SplitLandscapeToGrid_FunctionAddress, "GridBox");
		SplitLandscapeToGrid_GridBox_Offset = NativeReflectionCached.GetPropertyOffset(SplitLandscapeToGrid_FunctionAddress, "GridBox");
		SplitLandscapeToGrid_GridBox_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitLandscapeToGrid_FunctionAddress, "GridBox", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitLandscapeToGrid_Lands_PropertyAddress, SplitLandscapeToGrid_FunctionAddress, "Lands");
		SplitLandscapeToGrid_Lands_Offset = NativeReflectionCached.GetPropertyOffset(SplitLandscapeToGrid_FunctionAddress, "Lands");
		SplitLandscapeToGrid_Lands_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitLandscapeToGrid_FunctionAddress, "Lands", Classes.FArrayProperty);
		SplitLandscapeToGrid_IsValid = SplitLandscapeToGrid_FunctionAddress != IntPtr.Zero && SplitLandscapeToGrid_InStreamingLevel_IsValid && SplitLandscapeToGrid_GridBox_IsValid && SplitLandscapeToGrid_Lands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:SplitLandscapeToGrid", SplitLandscapeToGrid_IsValid);
		SplitFoliageToGrid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SplitFoliageToGrid");
		SplitFoliageToGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(SplitFoliageToGrid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SplitFoliageToGrid_InStreamingLevels_PropertyAddress, SplitFoliageToGrid_FunctionAddress, "InStreamingLevels");
		SplitFoliageToGrid_InStreamingLevels_Offset = NativeReflectionCached.GetPropertyOffset(SplitFoliageToGrid_FunctionAddress, "InStreamingLevels");
		SplitFoliageToGrid_InStreamingLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitFoliageToGrid_FunctionAddress, "InStreamingLevels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SplitFoliageToGrid_GridBoxs_PropertyAddress, SplitFoliageToGrid_FunctionAddress, "GridBoxs");
		SplitFoliageToGrid_GridBoxs_Offset = NativeReflectionCached.GetPropertyOffset(SplitFoliageToGrid_FunctionAddress, "GridBoxs");
		SplitFoliageToGrid_GridBoxs_IsValid = NativeReflectionCached.ValidatePropertyClass(SplitFoliageToGrid_FunctionAddress, "GridBoxs", Classes.FArrayProperty);
		SplitFoliageToGrid_IsValid = SplitFoliageToGrid_FunctionAddress != IntPtr.Zero && SplitFoliageToGrid_InStreamingLevels_IsValid && SplitFoliageToGrid_GridBoxs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:SplitFoliageToGrid", SplitFoliageToGrid_IsValid);
		SaveLandscapeWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveLandscapeWeight");
		SaveLandscapeWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveLandscapeWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeWeight_PackagePath_PropertyAddress, SaveLandscapeWeight_FunctionAddress, "PackagePath");
		SaveLandscapeWeight_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeWeight_FunctionAddress, "PackagePath");
		SaveLandscapeWeight_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeWeight_FunctionAddress, "PackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeWeight_LandscapeActor_PropertyAddress, SaveLandscapeWeight_FunctionAddress, "LandscapeActor");
		SaveLandscapeWeight_LandscapeActor_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeWeight_FunctionAddress, "LandscapeActor");
		SaveLandscapeWeight_LandscapeActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeWeight_FunctionAddress, "LandscapeActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeWeight_ReturnValue_PropertyAddress, SaveLandscapeWeight_FunctionAddress, "ReturnValue");
		SaveLandscapeWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeWeight_FunctionAddress, "ReturnValue");
		SaveLandscapeWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeWeight_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SaveLandscapeWeight_IsValid = SaveLandscapeWeight_FunctionAddress != IntPtr.Zero && SaveLandscapeWeight_PackagePath_IsValid && SaveLandscapeWeight_LandscapeActor_IsValid && SaveLandscapeWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:SaveLandscapeWeight", SaveLandscapeWeight_IsValid);
		SaveLandscapeLayerWeightTex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveLandscapeLayerWeightTex");
		SaveLandscapeLayerWeightTex_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveLandscapeLayerWeightTex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeLayerWeightTex_packagePath_PropertyAddress, SaveLandscapeLayerWeightTex_FunctionAddress, "packagePath");
		SaveLandscapeLayerWeightTex_packagePath_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeLayerWeightTex_FunctionAddress, "packagePath");
		SaveLandscapeLayerWeightTex_packagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeLayerWeightTex_FunctionAddress, "packagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeLayerWeightTex_AssetName_PropertyAddress, SaveLandscapeLayerWeightTex_FunctionAddress, "AssetName");
		SaveLandscapeLayerWeightTex_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeLayerWeightTex_FunctionAddress, "AssetName");
		SaveLandscapeLayerWeightTex_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeLayerWeightTex_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeLayerWeightTex_landscapeActor_PropertyAddress, SaveLandscapeLayerWeightTex_FunctionAddress, "landscapeActor");
		SaveLandscapeLayerWeightTex_landscapeActor_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeLayerWeightTex_FunctionAddress, "landscapeActor");
		SaveLandscapeLayerWeightTex_landscapeActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeLayerWeightTex_FunctionAddress, "landscapeActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeLayerWeightTex_LayerName_PropertyAddress, SaveLandscapeLayerWeightTex_FunctionAddress, "LayerName");
		SaveLandscapeLayerWeightTex_LayerName_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeLayerWeightTex_FunctionAddress, "LayerName");
		SaveLandscapeLayerWeightTex_LayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeLayerWeightTex_FunctionAddress, "LayerName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeLayerWeightTex_ReturnValue_PropertyAddress, SaveLandscapeLayerWeightTex_FunctionAddress, "ReturnValue");
		SaveLandscapeLayerWeightTex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeLayerWeightTex_FunctionAddress, "ReturnValue");
		SaveLandscapeLayerWeightTex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeLayerWeightTex_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SaveLandscapeLayerWeightTex_IsValid = SaveLandscapeLayerWeightTex_FunctionAddress != IntPtr.Zero && SaveLandscapeLayerWeightTex_packagePath_IsValid && SaveLandscapeLayerWeightTex_AssetName_IsValid && SaveLandscapeLayerWeightTex_landscapeActor_IsValid && SaveLandscapeLayerWeightTex_LayerName_IsValid && SaveLandscapeLayerWeightTex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:SaveLandscapeLayerWeightTex", SaveLandscapeLayerWeightTex_IsValid);
		ResizeLandscapeExpandByQuads_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResizeLandscapeExpandByQuads");
		ResizeLandscapeExpandByQuads_ParamsSize = NativeReflection.GetFunctionParamsSize(ResizeLandscapeExpandByQuads_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResizeLandscapeExpandByQuads_OldLandscape_PropertyAddress, ResizeLandscapeExpandByQuads_FunctionAddress, "OldLandscape");
		ResizeLandscapeExpandByQuads_OldLandscape_Offset = NativeReflectionCached.GetPropertyOffset(ResizeLandscapeExpandByQuads_FunctionAddress, "OldLandscape");
		ResizeLandscapeExpandByQuads_OldLandscape_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizeLandscapeExpandByQuads_FunctionAddress, "OldLandscape", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResizeLandscapeExpandByQuads_SubsectionSizeQuads_PropertyAddress, ResizeLandscapeExpandByQuads_FunctionAddress, "SubsectionSizeQuads");
		ResizeLandscapeExpandByQuads_SubsectionSizeQuads_Offset = NativeReflectionCached.GetPropertyOffset(ResizeLandscapeExpandByQuads_FunctionAddress, "SubsectionSizeQuads");
		ResizeLandscapeExpandByQuads_SubsectionSizeQuads_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizeLandscapeExpandByQuads_FunctionAddress, "SubsectionSizeQuads", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ResizeLandscapeExpandByQuads_ReturnValue_PropertyAddress, ResizeLandscapeExpandByQuads_FunctionAddress, "ReturnValue");
		ResizeLandscapeExpandByQuads_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ResizeLandscapeExpandByQuads_FunctionAddress, "ReturnValue");
		ResizeLandscapeExpandByQuads_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizeLandscapeExpandByQuads_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ResizeLandscapeExpandByQuads_IsValid = ResizeLandscapeExpandByQuads_FunctionAddress != IntPtr.Zero && ResizeLandscapeExpandByQuads_OldLandscape_IsValid && ResizeLandscapeExpandByQuads_SubsectionSizeQuads_IsValid && ResizeLandscapeExpandByQuads_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:ResizeLandscapeExpandByQuads", ResizeLandscapeExpandByQuads_IsValid);
		RefreshLevelBrowser_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RefreshLevelBrowser");
		RefreshLevelBrowser_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshLevelBrowser_FunctionAddress);
		RefreshLevelBrowser_IsValid = RefreshLevelBrowser_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:RefreshLevelBrowser", RefreshLevelBrowser_IsValid);
		RecreateLandscapeActorByProxy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecreateLandscapeActorByProxy");
		RecreateLandscapeActorByProxy_ParamsSize = NativeReflection.GetFunctionParamsSize(RecreateLandscapeActorByProxy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecreateLandscapeActorByProxy_LandscapeProxy_PropertyAddress, RecreateLandscapeActorByProxy_FunctionAddress, "LandscapeProxy");
		RecreateLandscapeActorByProxy_LandscapeProxy_Offset = NativeReflectionCached.GetPropertyOffset(RecreateLandscapeActorByProxy_FunctionAddress, "LandscapeProxy");
		RecreateLandscapeActorByProxy_LandscapeProxy_IsValid = NativeReflectionCached.ValidatePropertyClass(RecreateLandscapeActorByProxy_FunctionAddress, "LandscapeProxy", Classes.FObjectProperty);
		RecreateLandscapeActorByProxy_IsValid = RecreateLandscapeActorByProxy_FunctionAddress != IntPtr.Zero && RecreateLandscapeActorByProxy_LandscapeProxy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:RecreateLandscapeActorByProxy", RecreateLandscapeActorByProxy_IsValid);
		GetLandscapeOriginOffset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLandscapeOriginOffset");
		GetLandscapeOriginOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLandscapeOriginOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeOriginOffset_LandscapeActor_PropertyAddress, GetLandscapeOriginOffset_FunctionAddress, "LandscapeActor");
		GetLandscapeOriginOffset_LandscapeActor_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeOriginOffset_FunctionAddress, "LandscapeActor");
		GetLandscapeOriginOffset_LandscapeActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeOriginOffset_FunctionAddress, "LandscapeActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeOriginOffset_ReturnValue_PropertyAddress, GetLandscapeOriginOffset_FunctionAddress, "ReturnValue");
		GetLandscapeOriginOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeOriginOffset_FunctionAddress, "ReturnValue");
		GetLandscapeOriginOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeOriginOffset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLandscapeOriginOffset_IsValid = GetLandscapeOriginOffset_FunctionAddress != IntPtr.Zero && GetLandscapeOriginOffset_LandscapeActor_IsValid && GetLandscapeOriginOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:GetLandscapeOriginOffset", GetLandscapeOriginOffset_IsValid);
		GetBPBrushOwningLandscape_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBPBrushOwningLandscape");
		GetBPBrushOwningLandscape_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBPBrushOwningLandscape_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBPBrushOwningLandscape_BPBrush_PropertyAddress, GetBPBrushOwningLandscape_FunctionAddress, "BPBrush");
		GetBPBrushOwningLandscape_BPBrush_Offset = NativeReflectionCached.GetPropertyOffset(GetBPBrushOwningLandscape_FunctionAddress, "BPBrush");
		GetBPBrushOwningLandscape_BPBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBPBrushOwningLandscape_FunctionAddress, "BPBrush", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBPBrushOwningLandscape_ReturnValue_PropertyAddress, GetBPBrushOwningLandscape_FunctionAddress, "ReturnValue");
		GetBPBrushOwningLandscape_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBPBrushOwningLandscape_FunctionAddress, "ReturnValue");
		GetBPBrushOwningLandscape_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBPBrushOwningLandscape_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBPBrushOwningLandscape_IsValid = GetBPBrushOwningLandscape_FunctionAddress != IntPtr.Zero && GetBPBrushOwningLandscape_BPBrush_IsValid && GetBPBrushOwningLandscape_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:GetBPBrushOwningLandscape", GetBPBrushOwningLandscape_IsValid);
		GetAllActorsInStreamingLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllActorsInStreamingLevel");
		GetAllActorsInStreamingLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllActorsInStreamingLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInStreamingLevel_InStreamingLevel_PropertyAddress, GetAllActorsInStreamingLevel_FunctionAddress, "InStreamingLevel");
		GetAllActorsInStreamingLevel_InStreamingLevel_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInStreamingLevel_FunctionAddress, "InStreamingLevel");
		GetAllActorsInStreamingLevel_InStreamingLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInStreamingLevel_FunctionAddress, "InStreamingLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInStreamingLevel_ActorClass_PropertyAddress, GetAllActorsInStreamingLevel_FunctionAddress, "ActorClass");
		GetAllActorsInStreamingLevel_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInStreamingLevel_FunctionAddress, "ActorClass");
		GetAllActorsInStreamingLevel_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInStreamingLevel_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInStreamingLevel_OutActors_PropertyAddress, GetAllActorsInStreamingLevel_FunctionAddress, "OutActors");
		GetAllActorsInStreamingLevel_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInStreamingLevel_FunctionAddress, "OutActors");
		GetAllActorsInStreamingLevel_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInStreamingLevel_FunctionAddress, "OutActors", Classes.FArrayProperty);
		GetAllActorsInStreamingLevel_IsValid = GetAllActorsInStreamingLevel_FunctionAddress != IntPtr.Zero && GetAllActorsInStreamingLevel_InStreamingLevel_IsValid && GetAllActorsInStreamingLevel_ActorClass_IsValid && GetAllActorsInStreamingLevel_OutActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:GetAllActorsInStreamingLevel", GetAllActorsInStreamingLevel_IsValid);
		CleanGridLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CleanGridLevels");
		CleanGridLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanGridLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CleanGridLevels_InStreamingLevel_PropertyAddress, CleanGridLevels_FunctionAddress, "InStreamingLevel");
		CleanGridLevels_InStreamingLevel_Offset = NativeReflectionCached.GetPropertyOffset(CleanGridLevels_FunctionAddress, "InStreamingLevel");
		CleanGridLevels_InStreamingLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(CleanGridLevels_FunctionAddress, "InStreamingLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CleanGridLevels_GridBox_PropertyAddress, CleanGridLevels_FunctionAddress, "GridBox");
		CleanGridLevels_GridBox_Offset = NativeReflectionCached.GetPropertyOffset(CleanGridLevels_FunctionAddress, "GridBox");
		CleanGridLevels_GridBox_IsValid = NativeReflectionCached.ValidatePropertyClass(CleanGridLevels_FunctionAddress, "GridBox", Classes.FStructProperty);
		CleanGridLevels_IsValid = CleanGridLevels_FunctionAddress != IntPtr.Zero && CleanGridLevels_InStreamingLevel_IsValid && CleanGridLevels_GridBox_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:CleanGridLevels", CleanGridLevels_IsValid);
		AddLocationsToStreamingManager_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddLocationsToStreamingManager");
		AddLocationsToStreamingManager_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLocationsToStreamingManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLocationsToStreamingManager_Locations_PropertyAddress, AddLocationsToStreamingManager_FunctionAddress, "Locations");
		AddLocationsToStreamingManager_Locations_Offset = NativeReflectionCached.GetPropertyOffset(AddLocationsToStreamingManager_FunctionAddress, "Locations");
		AddLocationsToStreamingManager_Locations_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocationsToStreamingManager_FunctionAddress, "Locations", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocationsToStreamingManager_Duration_PropertyAddress, AddLocationsToStreamingManager_FunctionAddress, "Duration");
		AddLocationsToStreamingManager_Duration_Offset = NativeReflectionCached.GetPropertyOffset(AddLocationsToStreamingManager_FunctionAddress, "Duration");
		AddLocationsToStreamingManager_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocationsToStreamingManager_FunctionAddress, "Duration", Classes.FFloatProperty);
		AddLocationsToStreamingManager_IsValid = AddLocationsToStreamingManager_FunctionAddress != IntPtr.Zero && AddLocationsToStreamingManager_Locations_IsValid && AddLocationsToStreamingManager_Duration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_LandscapeFuncLib:AddLocationsToStreamingManager", AddLocationsToStreamingManager_IsValid);
	}
}
