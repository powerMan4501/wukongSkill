using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSLandscapeUtil : AActor
{
	private static IntPtr classAddress;

	private static bool weightmapRT_IsValid;

	private static int weightmapRT_Offset;

	private static bool heightmapRT_IsValid;

	private static int heightmapRT_Offset;

	private static bool UpdateLandscapeAllBPBrush_IsValid;

	private static IntPtr UpdateLandscapeAllBPBrush_FunctionAddress;

	private static int UpdateLandscapeAllBPBrush_ParamsSize;

	private static bool UpdateLandscapeAllBPBrush_Landscape_IsValid;

	private static FFieldAddress UpdateLandscapeAllBPBrush_Landscape_PropertyAddress;

	private static int UpdateLandscapeAllBPBrush_Landscape_Offset;

	private static bool SetLandscapeWeightmaps_IsValid;

	private static IntPtr SetLandscapeWeightmaps_FunctionAddress;

	private static int SetLandscapeWeightmaps_ParamsSize;

	private static bool SetLandscapeWeightmaps_Landscape_IsValid;

	private static FFieldAddress SetLandscapeWeightmaps_Landscape_PropertyAddress;

	private static int SetLandscapeWeightmaps_Landscape_Offset;

	private static bool SetLandscapeWeightmaps_WeightmapPath_IsValid;

	private static FFieldAddress SetLandscapeWeightmaps_WeightmapPath_PropertyAddress;

	private static int SetLandscapeWeightmaps_WeightmapPath_Offset;

	private static bool SetLandscapeHeightmap_IsValid;

	private static IntPtr SetLandscapeHeightmap_FunctionAddress;

	private static int SetLandscapeHeightmap_ParamsSize;

	private static bool SetLandscapeHeightmap_Landscape_IsValid;

	private static FFieldAddress SetLandscapeHeightmap_Landscape_PropertyAddress;

	private static int SetLandscapeHeightmap_Landscape_Offset;

	private static bool SetLandscapeHeightmap_HeightmapPath_IsValid;

	private static FFieldAddress SetLandscapeHeightmap_HeightmapPath_PropertyAddress;

	private static int SetLandscapeHeightmap_HeightmapPath_Offset;

	private static bool SaveLandscapeWeightmaps_IsValid;

	private static IntPtr SaveLandscapeWeightmaps_FunctionAddress;

	private static int SaveLandscapeWeightmaps_ParamsSize;

	private static bool SaveLandscapeWeightmaps_pacakgeName_IsValid;

	private static FFieldAddress SaveLandscapeWeightmaps_pacakgeName_PropertyAddress;

	private static int SaveLandscapeWeightmaps_pacakgeName_Offset;

	private static bool SaveLandscapeHeightmaps_IsValid;

	private static IntPtr SaveLandscapeHeightmaps_FunctionAddress;

	private static int SaveLandscapeHeightmaps_ParamsSize;

	private static bool SaveLandscapeHeightmaps_pacakgeName_IsValid;

	private static FFieldAddress SaveLandscapeHeightmaps_pacakgeName_PropertyAddress;

	private static int SaveLandscapeHeightmaps_pacakgeName_Offset;

	private static bool CreateSubLevelFromLandscape_IsValid;

	private static IntPtr CreateSubLevelFromLandscape_FunctionAddress;

	private static int CreateSubLevelFromLandscape_ParamsSize;

	private static bool AddBrushToLayer_IsValid;

	private static IntPtr AddBrushToLayer_FunctionAddress;

	private static int AddBrushToLayer_ParamsSize;

	private static bool AddBrushToLayer_Landscape_IsValid;

	private static FFieldAddress AddBrushToLayer_Landscape_PropertyAddress;

	private static int AddBrushToLayer_Landscape_Offset;

	private static bool AddBrushToLayer_InLayerIndex_IsValid;

	private static FFieldAddress AddBrushToLayer_InLayerIndex_PropertyAddress;

	private static int AddBrushToLayer_InLayerIndex_Offset;

	private static bool AddBrushToLayer_InBrush_IsValid;

	private static FFieldAddress AddBrushToLayer_InBrush_PropertyAddress;

	private static int AddBrushToLayer_InBrush_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil:weightmapRT")]
	public UTextureRenderTarget2D weightmapRT
	{
		get
		{
			CheckDestroyed();
			if (!weightmapRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLandscapeUtil:weightmapRT");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, weightmapRT_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!weightmapRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLandscapeUtil:weightmapRT");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, weightmapRT_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil:heightmapRT")]
	public UTextureRenderTarget2D heightmapRT
	{
		get
		{
			CheckDestroyed();
			if (!heightmapRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLandscapeUtil:heightmapRT");
				return null;
			}
			return UObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(base.Address, heightmapRT_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!heightmapRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSLandscapeUtil:heightmapRT");
			}
			else
			{
				UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(base.Address, heightmapRT_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil:UpdateLandscapeAllBPBrush")]
	public unsafe static void UpdateLandscapeAllBPBrush(ALandscape Landscape)
	{
		if (!UpdateLandscapeAllBPBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLandscapeUtil:UpdateLandscapeAllBPBrush");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateLandscapeAllBPBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateLandscapeAllBPBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(intPtr, UpdateLandscapeAllBPBrush_Landscape_Offset), 0, UpdateLandscapeAllBPBrush_Landscape_PropertyAddress.Address, Landscape);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateLandscapeAllBPBrush_FunctionAddress, intPtr, UpdateLandscapeAllBPBrush_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil:SetLandscapeWeightmaps")]
	public unsafe static void SetLandscapeWeightmaps(ALandscape Landscape, string WeightmapPath)
	{
		if (!SetLandscapeWeightmaps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLandscapeUtil:SetLandscapeWeightmaps");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLandscapeWeightmaps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLandscapeWeightmaps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(intPtr, SetLandscapeWeightmaps_Landscape_Offset), 0, SetLandscapeWeightmaps_Landscape_PropertyAddress.Address, Landscape);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLandscapeWeightmaps_WeightmapPath_Offset), 0, SetLandscapeWeightmaps_WeightmapPath_PropertyAddress.Address, WeightmapPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLandscapeWeightmaps_FunctionAddress, intPtr, SetLandscapeWeightmaps_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLandscapeWeightmaps_WeightmapPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil:SetLandscapeHeightmap")]
	public unsafe static void SetLandscapeHeightmap(ALandscape Landscape, string HeightmapPath)
	{
		if (!SetLandscapeHeightmap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLandscapeUtil:SetLandscapeHeightmap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLandscapeHeightmap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLandscapeHeightmap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(intPtr, SetLandscapeHeightmap_Landscape_Offset), 0, SetLandscapeHeightmap_Landscape_PropertyAddress.Address, Landscape);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLandscapeHeightmap_HeightmapPath_Offset), 0, SetLandscapeHeightmap_HeightmapPath_PropertyAddress.Address, HeightmapPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLandscapeHeightmap_FunctionAddress, intPtr, SetLandscapeHeightmap_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLandscapeHeightmap_HeightmapPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil:SaveLandscapeWeightmaps")]
	public unsafe void SaveLandscapeWeightmaps(string pacakgeName)
	{
		CheckDestroyed();
		if (!SaveLandscapeWeightmaps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLandscapeUtil:SaveLandscapeWeightmaps");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveLandscapeWeightmaps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveLandscapeWeightmaps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveLandscapeWeightmaps_pacakgeName_Offset), 0, SaveLandscapeWeightmaps_pacakgeName_PropertyAddress.Address, pacakgeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SaveLandscapeWeightmaps_FunctionAddress, intPtr, SaveLandscapeWeightmaps_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveLandscapeWeightmaps_pacakgeName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil:SaveLandscapeHeightmaps")]
	public unsafe void SaveLandscapeHeightmaps(string pacakgeName)
	{
		CheckDestroyed();
		if (!SaveLandscapeHeightmaps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLandscapeUtil:SaveLandscapeHeightmaps");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveLandscapeHeightmaps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveLandscapeHeightmaps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveLandscapeHeightmaps_pacakgeName_Offset), 0, SaveLandscapeHeightmaps_pacakgeName_PropertyAddress.Address, pacakgeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SaveLandscapeHeightmaps_FunctionAddress, intPtr, SaveLandscapeHeightmaps_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveLandscapeHeightmaps_pacakgeName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil:CreateSubLevelFromLandscape")]
	public unsafe void CreateSubLevelFromLandscape()
	{
		CheckDestroyed();
		if (!CreateSubLevelFromLandscape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLandscapeUtil:CreateSubLevelFromLandscape");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateSubLevelFromLandscape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateSubLevelFromLandscape_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CreateSubLevelFromLandscape_FunctionAddress, argsSize: CreateSubLevelFromLandscape_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSLandscapeUtil:AddBrushToLayer")]
	public unsafe static void AddBrushToLayer(ALandscape Landscape, int InLayerIndex, ALandscapeBlueprintBrushBase InBrush)
	{
		if (!AddBrushToLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLandscapeUtil:AddBrushToLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBrushToLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBrushToLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(intPtr, AddBrushToLayer_Landscape_Offset), 0, AddBrushToLayer_Landscape_PropertyAddress.Address, Landscape);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddBrushToLayer_InLayerIndex_Offset), 0, AddBrushToLayer_InLayerIndex_PropertyAddress.Address, InLayerIndex);
		UObjectMarshaler<ALandscapeBlueprintBrushBase>.ToNative(IntPtr.Add(intPtr, AddBrushToLayer_InBrush_Offset), 0, AddBrushToLayer_InBrush_PropertyAddress.Address, InBrush);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddBrushToLayer_FunctionAddress, intPtr, AddBrushToLayer_ParamsSize);
	}

	static AGSLandscapeUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSLandscapeUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSLandscapeUtil));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSLandscapeUtil");
		weightmapRT_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "weightmapRT");
		weightmapRT_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "weightmapRT", Classes.FObjectProperty);
		heightmapRT_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "heightmapRT");
		heightmapRT_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "heightmapRT", Classes.FObjectProperty);
		UpdateLandscapeAllBPBrush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateLandscapeAllBPBrush");
		UpdateLandscapeAllBPBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateLandscapeAllBPBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateLandscapeAllBPBrush_Landscape_PropertyAddress, UpdateLandscapeAllBPBrush_FunctionAddress, "Landscape");
		UpdateLandscapeAllBPBrush_Landscape_Offset = NativeReflectionCached.GetPropertyOffset(UpdateLandscapeAllBPBrush_FunctionAddress, "Landscape");
		UpdateLandscapeAllBPBrush_Landscape_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateLandscapeAllBPBrush_FunctionAddress, "Landscape", Classes.FObjectProperty);
		UpdateLandscapeAllBPBrush_IsValid = UpdateLandscapeAllBPBrush_FunctionAddress != IntPtr.Zero && UpdateLandscapeAllBPBrush_Landscape_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLandscapeUtil:UpdateLandscapeAllBPBrush", UpdateLandscapeAllBPBrush_IsValid);
		SetLandscapeWeightmaps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLandscapeWeightmaps");
		SetLandscapeWeightmaps_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLandscapeWeightmaps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeWeightmaps_Landscape_PropertyAddress, SetLandscapeWeightmaps_FunctionAddress, "Landscape");
		SetLandscapeWeightmaps_Landscape_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeWeightmaps_FunctionAddress, "Landscape");
		SetLandscapeWeightmaps_Landscape_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeWeightmaps_FunctionAddress, "Landscape", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeWeightmaps_WeightmapPath_PropertyAddress, SetLandscapeWeightmaps_FunctionAddress, "WeightmapPath");
		SetLandscapeWeightmaps_WeightmapPath_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeWeightmaps_FunctionAddress, "WeightmapPath");
		SetLandscapeWeightmaps_WeightmapPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeWeightmaps_FunctionAddress, "WeightmapPath", Classes.FStrProperty);
		SetLandscapeWeightmaps_IsValid = SetLandscapeWeightmaps_FunctionAddress != IntPtr.Zero && SetLandscapeWeightmaps_Landscape_IsValid && SetLandscapeWeightmaps_WeightmapPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLandscapeUtil:SetLandscapeWeightmaps", SetLandscapeWeightmaps_IsValid);
		SetLandscapeHeightmap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLandscapeHeightmap");
		SetLandscapeHeightmap_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLandscapeHeightmap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeHeightmap_Landscape_PropertyAddress, SetLandscapeHeightmap_FunctionAddress, "Landscape");
		SetLandscapeHeightmap_Landscape_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeHeightmap_FunctionAddress, "Landscape");
		SetLandscapeHeightmap_Landscape_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeHeightmap_FunctionAddress, "Landscape", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLandscapeHeightmap_HeightmapPath_PropertyAddress, SetLandscapeHeightmap_FunctionAddress, "HeightmapPath");
		SetLandscapeHeightmap_HeightmapPath_Offset = NativeReflectionCached.GetPropertyOffset(SetLandscapeHeightmap_FunctionAddress, "HeightmapPath");
		SetLandscapeHeightmap_HeightmapPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLandscapeHeightmap_FunctionAddress, "HeightmapPath", Classes.FStrProperty);
		SetLandscapeHeightmap_IsValid = SetLandscapeHeightmap_FunctionAddress != IntPtr.Zero && SetLandscapeHeightmap_Landscape_IsValid && SetLandscapeHeightmap_HeightmapPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLandscapeUtil:SetLandscapeHeightmap", SetLandscapeHeightmap_IsValid);
		SaveLandscapeWeightmaps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveLandscapeWeightmaps");
		SaveLandscapeWeightmaps_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveLandscapeWeightmaps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeWeightmaps_pacakgeName_PropertyAddress, SaveLandscapeWeightmaps_FunctionAddress, "pacakgeName");
		SaveLandscapeWeightmaps_pacakgeName_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeWeightmaps_FunctionAddress, "pacakgeName");
		SaveLandscapeWeightmaps_pacakgeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeWeightmaps_FunctionAddress, "pacakgeName", Classes.FStrProperty);
		SaveLandscapeWeightmaps_IsValid = SaveLandscapeWeightmaps_FunctionAddress != IntPtr.Zero && SaveLandscapeWeightmaps_pacakgeName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLandscapeUtil:SaveLandscapeWeightmaps", SaveLandscapeWeightmaps_IsValid);
		SaveLandscapeHeightmaps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveLandscapeHeightmaps");
		SaveLandscapeHeightmaps_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveLandscapeHeightmaps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveLandscapeHeightmaps_pacakgeName_PropertyAddress, SaveLandscapeHeightmaps_FunctionAddress, "pacakgeName");
		SaveLandscapeHeightmaps_pacakgeName_Offset = NativeReflectionCached.GetPropertyOffset(SaveLandscapeHeightmaps_FunctionAddress, "pacakgeName");
		SaveLandscapeHeightmaps_pacakgeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLandscapeHeightmaps_FunctionAddress, "pacakgeName", Classes.FStrProperty);
		SaveLandscapeHeightmaps_IsValid = SaveLandscapeHeightmaps_FunctionAddress != IntPtr.Zero && SaveLandscapeHeightmaps_pacakgeName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLandscapeUtil:SaveLandscapeHeightmaps", SaveLandscapeHeightmaps_IsValid);
		CreateSubLevelFromLandscape_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateSubLevelFromLandscape");
		CreateSubLevelFromLandscape_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateSubLevelFromLandscape_FunctionAddress);
		CreateSubLevelFromLandscape_IsValid = CreateSubLevelFromLandscape_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLandscapeUtil:CreateSubLevelFromLandscape", CreateSubLevelFromLandscape_IsValid);
		AddBrushToLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddBrushToLayer");
		AddBrushToLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBrushToLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBrushToLayer_Landscape_PropertyAddress, AddBrushToLayer_FunctionAddress, "Landscape");
		AddBrushToLayer_Landscape_Offset = NativeReflectionCached.GetPropertyOffset(AddBrushToLayer_FunctionAddress, "Landscape");
		AddBrushToLayer_Landscape_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBrushToLayer_FunctionAddress, "Landscape", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBrushToLayer_InLayerIndex_PropertyAddress, AddBrushToLayer_FunctionAddress, "InLayerIndex");
		AddBrushToLayer_InLayerIndex_Offset = NativeReflectionCached.GetPropertyOffset(AddBrushToLayer_FunctionAddress, "InLayerIndex");
		AddBrushToLayer_InLayerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBrushToLayer_FunctionAddress, "InLayerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBrushToLayer_InBrush_PropertyAddress, AddBrushToLayer_FunctionAddress, "InBrush");
		AddBrushToLayer_InBrush_Offset = NativeReflectionCached.GetPropertyOffset(AddBrushToLayer_FunctionAddress, "InBrush");
		AddBrushToLayer_InBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBrushToLayer_FunctionAddress, "InBrush", Classes.FObjectProperty);
		AddBrushToLayer_IsValid = AddBrushToLayer_FunctionAddress != IntPtr.Zero && AddBrushToLayer_Landscape_IsValid && AddBrushToLayer_InLayerIndex_IsValid && AddBrushToLayer_InBrush_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLandscapeUtil:AddBrushToLayer", AddBrushToLayer_IsValid);
	}
}
