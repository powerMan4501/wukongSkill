using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[Abstract]
[UClass(Flags = (ClassFlags)818938021uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Landscape.LandscapeBlueprintBrushBase", "Landscape", UnrealModuleType.Engine)]
public class ALandscapeBlueprintBrushBase : AActor
{
	private static bool AffectHeightmap_IsValid;

	private static FFieldAddress AffectHeightmap_PropertyAddress;

	private static int AffectHeightmap_Offset;

	private static bool AffectWeightmap_IsValid;

	private static FFieldAddress AffectWeightmap_PropertyAddress;

	private static int AffectWeightmap_Offset;

	private static bool AffectedWeightmapLayers_IsValid;

	private static FFieldAddress AffectedWeightmapLayers_PropertyAddress;

	private static int AffectedWeightmapLayers_Offset;

	private TArrayReadWriteMarshaler<FName> AffectedWeightmapLayers_MarshalerCached;

	private static bool RequestLandscapeUpdate_IsValid;

	private static IntPtr RequestLandscapeUpdate_FunctionAddress;

	private static int RequestLandscapeUpdate_ParamsSize;

	private static bool Render_IsValid;

	private IntPtr Render_InstanceFunctionAddress;

	private static IntPtr Render_FunctionAddress;

	private static int Render_ParamsSize;

	private static bool Render_InIsHeightmap_IsValid;

	private static FFieldAddress Render_InIsHeightmap_PropertyAddress;

	private static int Render_InIsHeightmap_Offset;

	private static bool Render_InCombinedResult_IsValid;

	private static FFieldAddress Render_InCombinedResult_PropertyAddress;

	private static int Render_InCombinedResult_Offset;

	private static bool Render_InWeightmapLayerName_IsValid;

	private static FFieldAddress Render_InWeightmapLayerName_PropertyAddress;

	private static int Render_InWeightmapLayerName_Offset;

	private static bool Render_ReturnValue_IsValid;

	private static FFieldAddress Render_ReturnValue_PropertyAddress;

	private static int Render_ReturnValue_Offset;

	private static bool Initialize_IsValid;

	private IntPtr Initialize_InstanceFunctionAddress;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool Initialize_InLandscapeTransform_IsValid;

	private static FFieldAddress Initialize_InLandscapeTransform_PropertyAddress;

	private static int Initialize_InLandscapeTransform_Offset;

	private static bool Initialize_InLandscapeSize_IsValid;

	private static FFieldAddress Initialize_InLandscapeSize_PropertyAddress;

	private static int Initialize_InLandscapeSize_Offset;

	private static bool Initialize_InLandscapeRenderTargetSize_IsValid;

	private static FFieldAddress Initialize_InLandscapeRenderTargetSize_PropertyAddress;

	private static int Initialize_InLandscapeRenderTargetSize_Offset;

	private static bool GetBlueprintRenderDependencies_IsValid;

	private IntPtr GetBlueprintRenderDependencies_InstanceFunctionAddress;

	private static IntPtr GetBlueprintRenderDependencies_FunctionAddress;

	private static int GetBlueprintRenderDependencies_ParamsSize;

	private static bool GetBlueprintRenderDependencies_OutStreamableAssets_IsValid;

	private static FFieldAddress GetBlueprintRenderDependencies_OutStreamableAssets_PropertyAddress;

	private static int GetBlueprintRenderDependencies_OutStreamableAssets_Offset;

	[UProperty(Flags = (PropFlags)11267899314405893uL)]
	[UMetaPath("/Script/Landscape.LandscapeBlueprintBrushBase:AffectHeightmap")]
	protected bool AffectHeightmap
	{
		get
		{
			CheckDestroyed();
			if (!AffectHeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:AffectHeightmap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectHeightmap_Offset), 0, AffectHeightmap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectHeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:AffectHeightmap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectHeightmap_Offset), 0, AffectHeightmap_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267899314405893uL)]
	[UMetaPath("/Script/Landscape.LandscapeBlueprintBrushBase:AffectWeightmap")]
	protected bool AffectWeightmap
	{
		get
		{
			CheckDestroyed();
			if (!AffectWeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:AffectWeightmap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectWeightmap_Offset), 0, AffectWeightmap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectWeightmap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:AffectWeightmap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectWeightmap_Offset), 0, AffectWeightmap_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9016029707502085uL)]
	[UMetaPath("/Script/Landscape.LandscapeBlueprintBrushBase:AffectedWeightmapLayers")]
	protected TArrayReadWrite<FName> AffectedWeightmapLayers
	{
		get
		{
			CheckDestroyed();
			if (!AffectedWeightmapLayers_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:AffectedWeightmapLayers");
				return null;
			}
			if (AffectedWeightmapLayers_MarshalerCached == null)
			{
				AffectedWeightmapLayers_MarshalerCached = new TArrayReadWriteMarshaler<FName>(1, AffectedWeightmapLayers_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return AffectedWeightmapLayers_MarshalerCached.FromNative(IntPtr.Add(base.Address, AffectedWeightmapLayers_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Landscape.LandscapeBlueprintBrushBase:RequestLandscapeUpdate")]
	public unsafe void RequestLandscapeUpdate()
	{
		CheckDestroyed();
		if (!RequestLandscapeUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:RequestLandscapeUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestLandscapeUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestLandscapeUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestLandscapeUpdate_FunctionAddress, argsSize: RequestLandscapeUpdate_ParamsSize);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/Landscape.LandscapeBlueprintBrushBase:Render")]
	public unsafe UTextureRenderTarget2D Render(bool InIsHeightmap, UTextureRenderTarget2D InCombinedResult, FName InWeightmapLayerName)
	{
		CheckDestroyed();
		if (!Render_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:Render");
			return null;
		}
		if (Render_InstanceFunctionAddress == IntPtr.Zero)
		{
			Render_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Render");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Render_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Render_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Render_InIsHeightmap_Offset), 0, Render_InIsHeightmap_PropertyAddress.Address, InIsHeightmap);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, Render_InCombinedResult_Offset), 0, Render_InCombinedResult_PropertyAddress.Address, InCombinedResult);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Render_InWeightmapLayerName_Offset), 0, Render_InWeightmapLayerName_PropertyAddress.Address, InWeightmapLayerName);
		NativeReflection.InvokeFunctionOptimized(base.Address, Render_InstanceFunctionAddress, intPtr, Render_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, Render_ReturnValue_Offset), 0, Render_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual UTextureRenderTarget2D Render_Implementation(bool InIsHeightmap, UTextureRenderTarget2D InCombinedResult, FName InWeightmapLayerName)
	{
		CheckDestroyed();
		if (!Render_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:Render");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Render_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Render_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Render_InIsHeightmap_Offset), 0, Render_InIsHeightmap_PropertyAddress.Address, InIsHeightmap);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, Render_InCombinedResult_Offset), 0, Render_InCombinedResult_PropertyAddress.Address, InCombinedResult);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Render_InWeightmapLayerName_Offset), 0, Render_InWeightmapLayerName_PropertyAddress.Address, InWeightmapLayerName);
		NativeReflection.InvokeFunctionOptimized(base.Address, Render_FunctionAddress, intPtr, Render_ParamsSize);
		return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(intPtr, Render_ReturnValue_Offset), 0, Render_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 146934784u)]
	[UMetaPath("/Script/Landscape.LandscapeBlueprintBrushBase:Initialize")]
	public unsafe void Initialize(FTransform InLandscapeTransform, FIntPoint InLandscapeSize, FIntPoint InLandscapeRenderTargetSize)
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:Initialize");
			return;
		}
		if (Initialize_InstanceFunctionAddress == IntPtr.Zero)
		{
			Initialize_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Initialize");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Initialize_InLandscapeTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, Initialize_InLandscapeTransform_Offset), 0, Initialize_InLandscapeTransform_PropertyAddress.Address, InLandscapeTransform);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, Initialize_InLandscapeSize_Offset), 0, Initialize_InLandscapeSize_PropertyAddress.Address, InLandscapeSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, Initialize_InLandscapeRenderTargetSize_Offset), 0, Initialize_InLandscapeRenderTargetSize_PropertyAddress.Address, InLandscapeRenderTargetSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, Initialize_InstanceFunctionAddress, intPtr, Initialize_ParamsSize);
	}

	protected unsafe virtual void Initialize_Implementation(FTransform InLandscapeTransform, FIntPoint InLandscapeSize, FIntPoint InLandscapeRenderTargetSize)
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:Initialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Initialize_InLandscapeTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, Initialize_InLandscapeTransform_Offset), 0, Initialize_InLandscapeTransform_PropertyAddress.Address, InLandscapeTransform);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, Initialize_InLandscapeSize_Offset), 0, Initialize_InLandscapeSize_PropertyAddress.Address, InLandscapeSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(intPtr, Initialize_InLandscapeRenderTargetSize_Offset), 0, Initialize_InLandscapeRenderTargetSize_PropertyAddress.Address, InLandscapeRenderTargetSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, Initialize_FunctionAddress, intPtr, Initialize_ParamsSize);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/Landscape.LandscapeBlueprintBrushBase:GetBlueprintRenderDependencies")]
	public unsafe void GetBlueprintRenderDependencies(out List<UObject> OutStreamableAssets)
	{
		CheckDestroyed();
		if (!GetBlueprintRenderDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:GetBlueprintRenderDependencies");
			OutStreamableAssets = null;
			return;
		}
		if (GetBlueprintRenderDependencies_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetBlueprintRenderDependencies_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetBlueprintRenderDependencies");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlueprintRenderDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlueprintRenderDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBlueprintRenderDependencies_InstanceFunctionAddress, intPtr, GetBlueprintRenderDependencies_ParamsSize);
		OutStreamableAssets = new TArrayCopyMarshaler<UObject>(1, GetBlueprintRenderDependencies_OutStreamableAssets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBlueprintRenderDependencies_OutStreamableAssets_Offset));
		NativeReflection.DestroyValue_InContainer(GetBlueprintRenderDependencies_OutStreamableAssets_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void GetBlueprintRenderDependencies_Implementation(out List<UObject> OutStreamableAssets)
	{
		CheckDestroyed();
		if (!GetBlueprintRenderDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeBlueprintBrushBase:GetBlueprintRenderDependencies");
			OutStreamableAssets = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlueprintRenderDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlueprintRenderDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBlueprintRenderDependencies_FunctionAddress, intPtr, GetBlueprintRenderDependencies_ParamsSize);
		OutStreamableAssets = new TArrayCopyMarshaler<UObject>(1, GetBlueprintRenderDependencies_OutStreamableAssets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBlueprintRenderDependencies_OutStreamableAssets_Offset));
		NativeReflection.DestroyValue_InContainer(GetBlueprintRenderDependencies_OutStreamableAssets_PropertyAddress.Address, intPtr);
	}

	static ALandscapeBlueprintBrushBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALandscapeBlueprintBrushBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALandscapeBlueprintBrushBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Landscape.LandscapeBlueprintBrushBase");
		NativeReflectionCached.GetPropertyRef(ref AffectHeightmap_PropertyAddress, intPtr, "AffectHeightmap");
		AffectHeightmap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AffectHeightmap");
		AffectHeightmap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AffectHeightmap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectWeightmap_PropertyAddress, intPtr, "AffectWeightmap");
		AffectWeightmap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AffectWeightmap");
		AffectWeightmap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AffectWeightmap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectedWeightmapLayers_PropertyAddress, intPtr, "AffectedWeightmapLayers");
		AffectedWeightmapLayers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AffectedWeightmapLayers");
		AffectedWeightmapLayers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AffectedWeightmapLayers", Classes.FArrayProperty);
		RequestLandscapeUpdate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RequestLandscapeUpdate");
		RequestLandscapeUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestLandscapeUpdate_FunctionAddress);
		RequestLandscapeUpdate_IsValid = RequestLandscapeUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeBlueprintBrushBase:RequestLandscapeUpdate", RequestLandscapeUpdate_IsValid);
		Render_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Render");
		Render_ParamsSize = NativeReflection.GetFunctionParamsSize(Render_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Render_InIsHeightmap_PropertyAddress, Render_FunctionAddress, "InIsHeightmap");
		Render_InIsHeightmap_Offset = NativeReflectionCached.GetPropertyOffset(Render_FunctionAddress, "InIsHeightmap");
		Render_InIsHeightmap_IsValid = NativeReflectionCached.ValidatePropertyClass(Render_FunctionAddress, "InIsHeightmap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Render_InCombinedResult_PropertyAddress, Render_FunctionAddress, "InCombinedResult");
		Render_InCombinedResult_Offset = NativeReflectionCached.GetPropertyOffset(Render_FunctionAddress, "InCombinedResult");
		Render_InCombinedResult_IsValid = NativeReflectionCached.ValidatePropertyClass(Render_FunctionAddress, "InCombinedResult", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Render_InWeightmapLayerName_PropertyAddress, Render_FunctionAddress, "InWeightmapLayerName");
		Render_InWeightmapLayerName_Offset = NativeReflectionCached.GetPropertyOffset(Render_FunctionAddress, "InWeightmapLayerName");
		Render_InWeightmapLayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(Render_FunctionAddress, "InWeightmapLayerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Render_ReturnValue_PropertyAddress, Render_FunctionAddress, "ReturnValue");
		Render_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Render_FunctionAddress, "ReturnValue");
		Render_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Render_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Render_IsValid = Render_FunctionAddress != IntPtr.Zero && Render_InIsHeightmap_IsValid && Render_InCombinedResult_IsValid && Render_InWeightmapLayerName_IsValid && Render_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeBlueprintBrushBase:Render", Render_IsValid);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InLandscapeTransform_PropertyAddress, Initialize_FunctionAddress, "InLandscapeTransform");
		Initialize_InLandscapeTransform_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InLandscapeTransform");
		Initialize_InLandscapeTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InLandscapeTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InLandscapeSize_PropertyAddress, Initialize_FunctionAddress, "InLandscapeSize");
		Initialize_InLandscapeSize_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InLandscapeSize");
		Initialize_InLandscapeSize_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InLandscapeSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InLandscapeRenderTargetSize_PropertyAddress, Initialize_FunctionAddress, "InLandscapeRenderTargetSize");
		Initialize_InLandscapeRenderTargetSize_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InLandscapeRenderTargetSize");
		Initialize_InLandscapeRenderTargetSize_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InLandscapeRenderTargetSize", Classes.FStructProperty);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero && Initialize_InLandscapeTransform_IsValid && Initialize_InLandscapeSize_IsValid && Initialize_InLandscapeRenderTargetSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeBlueprintBrushBase:Initialize", Initialize_IsValid);
		GetBlueprintRenderDependencies_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBlueprintRenderDependencies");
		GetBlueprintRenderDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlueprintRenderDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprintRenderDependencies_OutStreamableAssets_PropertyAddress, GetBlueprintRenderDependencies_FunctionAddress, "OutStreamableAssets");
		GetBlueprintRenderDependencies_OutStreamableAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprintRenderDependencies_FunctionAddress, "OutStreamableAssets");
		GetBlueprintRenderDependencies_OutStreamableAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprintRenderDependencies_FunctionAddress, "OutStreamableAssets", Classes.FArrayProperty);
		GetBlueprintRenderDependencies_IsValid = GetBlueprintRenderDependencies_FunctionAddress != IntPtr.Zero && GetBlueprintRenderDependencies_OutStreamableAssets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeBlueprintBrushBase:GetBlueprintRenderDependencies", GetBlueprintRenderDependencies_IsValid);
	}
}
