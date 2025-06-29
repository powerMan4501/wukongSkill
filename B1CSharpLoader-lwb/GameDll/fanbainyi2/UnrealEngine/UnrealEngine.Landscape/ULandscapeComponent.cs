using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UClass(Flags = (ClassFlags)820510884uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Landscape.LandscapeComponent", "Landscape", UnrealModuleType.Engine)]
public class ULandscapeComponent : UPrimitiveComponent
{
	private static bool SectionBaseX_IsValid;

	private static int SectionBaseX_Offset;

	private static bool SectionBaseY_IsValid;

	private static int SectionBaseY_Offset;

	private static bool OverrideMaterial_IsValid;

	private static int OverrideMaterial_Offset;

	private static bool OverrideHoleMaterial_IsValid;

	private static int OverrideHoleMaterial_Offset;

	private static bool ForcedLOD_IsValid;

	private static int ForcedLOD_Offset;

	private static bool LODBias_IsValid;

	private static int LODBias_Offset;

	private static bool GIBakedBaseColorTexture_IsValid;

	private static int GIBakedBaseColorTexture_Offset;

	private static bool GetMaterialInstanceDynamic_IsValid;

	private static IntPtr GetMaterialInstanceDynamic_FunctionAddress;

	private static int GetMaterialInstanceDynamic_ParamsSize;

	private static bool GetMaterialInstanceDynamic_InIndex_IsValid;

	private static FFieldAddress GetMaterialInstanceDynamic_InIndex_PropertyAddress;

	private static int GetMaterialInstanceDynamic_InIndex_Offset;

	private static bool GetMaterialInstanceDynamic_ReturnValue_IsValid;

	private static FFieldAddress GetMaterialInstanceDynamic_ReturnValue_PropertyAddress;

	private static int GetMaterialInstanceDynamic_ReturnValue_Offset;

	private static bool EditorGetPaintLayerWeightByNameAtLocation_IsValid;

	private static IntPtr EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress;

	private static int EditorGetPaintLayerWeightByNameAtLocation_ParamsSize;

	private static bool EditorGetPaintLayerWeightByNameAtLocation_InLocation_IsValid;

	private static FFieldAddress EditorGetPaintLayerWeightByNameAtLocation_InLocation_PropertyAddress;

	private static int EditorGetPaintLayerWeightByNameAtLocation_InLocation_Offset;

	private static bool EditorGetPaintLayerWeightByNameAtLocation_InPaintLayerName_IsValid;

	private static FFieldAddress EditorGetPaintLayerWeightByNameAtLocation_InPaintLayerName_PropertyAddress;

	private static int EditorGetPaintLayerWeightByNameAtLocation_InPaintLayerName_Offset;

	private static bool EditorGetPaintLayerWeightByNameAtLocation_ReturnValue_IsValid;

	private static FFieldAddress EditorGetPaintLayerWeightByNameAtLocation_ReturnValue_PropertyAddress;

	private static int EditorGetPaintLayerWeightByNameAtLocation_ReturnValue_Offset;

	private static bool EditorGetPaintLayerWeightAtLocation_IsValid;

	private static IntPtr EditorGetPaintLayerWeightAtLocation_FunctionAddress;

	private static int EditorGetPaintLayerWeightAtLocation_ParamsSize;

	private static bool EditorGetPaintLayerWeightAtLocation_InLocation_IsValid;

	private static FFieldAddress EditorGetPaintLayerWeightAtLocation_InLocation_PropertyAddress;

	private static int EditorGetPaintLayerWeightAtLocation_InLocation_Offset;

	private static bool EditorGetPaintLayerWeightAtLocation_PaintLayer_IsValid;

	private static FFieldAddress EditorGetPaintLayerWeightAtLocation_PaintLayer_PropertyAddress;

	private static int EditorGetPaintLayerWeightAtLocation_PaintLayer_Offset;

	private static bool EditorGetPaintLayerWeightAtLocation_ReturnValue_IsValid;

	private static FFieldAddress EditorGetPaintLayerWeightAtLocation_ReturnValue_PropertyAddress;

	private static int EditorGetPaintLayerWeightAtLocation_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:SectionBaseX")]
	public int SectionBaseX
	{
		get
		{
			CheckDestroyed();
			if (!SectionBaseX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:SectionBaseX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SectionBaseX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectionBaseX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:SectionBaseX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SectionBaseX_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:SectionBaseY")]
	public int SectionBaseY
	{
		get
		{
			CheckDestroyed();
			if (!SectionBaseY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:SectionBaseY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SectionBaseY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectionBaseY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:SectionBaseY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SectionBaseY_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:OverrideMaterial")]
	public UMaterialInterface OverrideMaterial
	{
		get
		{
			CheckDestroyed();
			if (!OverrideMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:OverrideMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, OverrideMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:OverrideMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, OverrideMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767187628549uL)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:OverrideHoleMaterial")]
	public UMaterialInterface OverrideHoleMaterial
	{
		get
		{
			CheckDestroyed();
			if (!OverrideHoleMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:OverrideHoleMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, OverrideHoleMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideHoleMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:OverrideHoleMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, OverrideHoleMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:ForcedLOD")]
	public int ForcedLOD
	{
		get
		{
			CheckDestroyed();
			if (!ForcedLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:ForcedLOD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForcedLOD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForcedLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:ForcedLOD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForcedLOD_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:LODBias")]
	public int LODBias
	{
		get
		{
			CheckDestroyed();
			if (!LODBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:LODBias");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LODBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LODBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:LODBias");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LODBias_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:GIBakedBaseColorTexture")]
	public UTexture2D GIBakedBaseColorTexture
	{
		get
		{
			CheckDestroyed();
			if (!GIBakedBaseColorTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:GIBakedBaseColorTexture");
				return null;
			}
			return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(base.Address, GIBakedBaseColorTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GIBakedBaseColorTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Landscape.LandscapeComponent:GIBakedBaseColorTexture");
			}
			else
			{
				UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(base.Address, GIBakedBaseColorTexture_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:GetMaterialInstanceDynamic")]
	public unsafe UMaterialInstanceDynamic GetMaterialInstanceDynamic(int InIndex)
	{
		CheckDestroyed();
		if (!GetMaterialInstanceDynamic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeComponent:GetMaterialInstanceDynamic");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialInstanceDynamic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialInstanceDynamic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMaterialInstanceDynamic_InIndex_Offset), 0, GetMaterialInstanceDynamic_InIndex_PropertyAddress.Address, InIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialInstanceDynamic_FunctionAddress, intPtr, GetMaterialInstanceDynamic_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetMaterialInstanceDynamic_ReturnValue_Offset), 0, GetMaterialInstanceDynamic_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823875u)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:EditorGetPaintLayerWeightByNameAtLocation")]
	public unsafe float EditorGetPaintLayerWeightByNameAtLocation(FVector InLocation, FName InPaintLayerName)
	{
		CheckDestroyed();
		if (!EditorGetPaintLayerWeightByNameAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeComponent:EditorGetPaintLayerWeightByNameAtLocation");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorGetPaintLayerWeightByNameAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorGetPaintLayerWeightByNameAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, EditorGetPaintLayerWeightByNameAtLocation_InLocation_Offset), 0, EditorGetPaintLayerWeightByNameAtLocation_InLocation_PropertyAddress.Address, InLocation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, EditorGetPaintLayerWeightByNameAtLocation_InPaintLayerName_Offset), 0, EditorGetPaintLayerWeightByNameAtLocation_InPaintLayerName_PropertyAddress.Address, InPaintLayerName);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, intPtr, EditorGetPaintLayerWeightByNameAtLocation_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, EditorGetPaintLayerWeightByNameAtLocation_ReturnValue_Offset), 0, EditorGetPaintLayerWeightByNameAtLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823875u)]
	[UMetaPath("/Script/Landscape.LandscapeComponent:EditorGetPaintLayerWeightAtLocation")]
	public unsafe float EditorGetPaintLayerWeightAtLocation(FVector InLocation, ULandscapeLayerInfoObject PaintLayer)
	{
		CheckDestroyed();
		if (!EditorGetPaintLayerWeightAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeComponent:EditorGetPaintLayerWeightAtLocation");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorGetPaintLayerWeightAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorGetPaintLayerWeightAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, EditorGetPaintLayerWeightAtLocation_InLocation_Offset), 0, EditorGetPaintLayerWeightAtLocation_InLocation_PropertyAddress.Address, InLocation);
		UObjectMarshaler<ULandscapeLayerInfoObject>.ToNative(IntPtr.Add(intPtr, EditorGetPaintLayerWeightAtLocation_PaintLayer_Offset), 0, EditorGetPaintLayerWeightAtLocation_PaintLayer_PropertyAddress.Address, PaintLayer);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorGetPaintLayerWeightAtLocation_FunctionAddress, intPtr, EditorGetPaintLayerWeightAtLocation_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, EditorGetPaintLayerWeightAtLocation_ReturnValue_Offset), 0, EditorGetPaintLayerWeightAtLocation_ReturnValue_PropertyAddress.Address);
	}

	static ULandscapeComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULandscapeComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULandscapeComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Landscape.LandscapeComponent");
		SectionBaseX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SectionBaseX");
		SectionBaseX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SectionBaseX", Classes.FIntProperty);
		SectionBaseY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SectionBaseY");
		SectionBaseY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SectionBaseY", Classes.FIntProperty);
		OverrideMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverrideMaterial");
		OverrideMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverrideMaterial", Classes.FObjectProperty);
		OverrideHoleMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverrideHoleMaterial");
		OverrideHoleMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverrideHoleMaterial", Classes.FObjectProperty);
		ForcedLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForcedLOD");
		ForcedLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForcedLOD", Classes.FIntProperty);
		LODBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODBias");
		LODBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODBias", Classes.FIntProperty);
		GIBakedBaseColorTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GIBakedBaseColorTexture");
		GIBakedBaseColorTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GIBakedBaseColorTexture", Classes.FObjectProperty);
		GetMaterialInstanceDynamic_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaterialInstanceDynamic");
		GetMaterialInstanceDynamic_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialInstanceDynamic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialInstanceDynamic_InIndex_PropertyAddress, GetMaterialInstanceDynamic_FunctionAddress, "InIndex");
		GetMaterialInstanceDynamic_InIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialInstanceDynamic_FunctionAddress, "InIndex");
		GetMaterialInstanceDynamic_InIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialInstanceDynamic_FunctionAddress, "InIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialInstanceDynamic_ReturnValue_PropertyAddress, GetMaterialInstanceDynamic_FunctionAddress, "ReturnValue");
		GetMaterialInstanceDynamic_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialInstanceDynamic_FunctionAddress, "ReturnValue");
		GetMaterialInstanceDynamic_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialInstanceDynamic_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMaterialInstanceDynamic_IsValid = GetMaterialInstanceDynamic_FunctionAddress != IntPtr.Zero && GetMaterialInstanceDynamic_InIndex_IsValid && GetMaterialInstanceDynamic_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeComponent:GetMaterialInstanceDynamic", GetMaterialInstanceDynamic_IsValid);
		EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorGetPaintLayerWeightByNameAtLocation");
		EditorGetPaintLayerWeightByNameAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorGetPaintLayerWeightByNameAtLocation_InLocation_PropertyAddress, EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, "InLocation");
		EditorGetPaintLayerWeightByNameAtLocation_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, "InLocation");
		EditorGetPaintLayerWeightByNameAtLocation_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorGetPaintLayerWeightByNameAtLocation_InPaintLayerName_PropertyAddress, EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, "InPaintLayerName");
		EditorGetPaintLayerWeightByNameAtLocation_InPaintLayerName_Offset = NativeReflectionCached.GetPropertyOffset(EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, "InPaintLayerName");
		EditorGetPaintLayerWeightByNameAtLocation_InPaintLayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, "InPaintLayerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorGetPaintLayerWeightByNameAtLocation_ReturnValue_PropertyAddress, EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, "ReturnValue");
		EditorGetPaintLayerWeightByNameAtLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, "ReturnValue");
		EditorGetPaintLayerWeightByNameAtLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		EditorGetPaintLayerWeightByNameAtLocation_IsValid = EditorGetPaintLayerWeightByNameAtLocation_FunctionAddress != IntPtr.Zero && EditorGetPaintLayerWeightByNameAtLocation_InLocation_IsValid && EditorGetPaintLayerWeightByNameAtLocation_InPaintLayerName_IsValid && EditorGetPaintLayerWeightByNameAtLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeComponent:EditorGetPaintLayerWeightByNameAtLocation", EditorGetPaintLayerWeightByNameAtLocation_IsValid);
		EditorGetPaintLayerWeightAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorGetPaintLayerWeightAtLocation");
		EditorGetPaintLayerWeightAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorGetPaintLayerWeightAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorGetPaintLayerWeightAtLocation_InLocation_PropertyAddress, EditorGetPaintLayerWeightAtLocation_FunctionAddress, "InLocation");
		EditorGetPaintLayerWeightAtLocation_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(EditorGetPaintLayerWeightAtLocation_FunctionAddress, "InLocation");
		EditorGetPaintLayerWeightAtLocation_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorGetPaintLayerWeightAtLocation_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorGetPaintLayerWeightAtLocation_PaintLayer_PropertyAddress, EditorGetPaintLayerWeightAtLocation_FunctionAddress, "PaintLayer");
		EditorGetPaintLayerWeightAtLocation_PaintLayer_Offset = NativeReflectionCached.GetPropertyOffset(EditorGetPaintLayerWeightAtLocation_FunctionAddress, "PaintLayer");
		EditorGetPaintLayerWeightAtLocation_PaintLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorGetPaintLayerWeightAtLocation_FunctionAddress, "PaintLayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorGetPaintLayerWeightAtLocation_ReturnValue_PropertyAddress, EditorGetPaintLayerWeightAtLocation_FunctionAddress, "ReturnValue");
		EditorGetPaintLayerWeightAtLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EditorGetPaintLayerWeightAtLocation_FunctionAddress, "ReturnValue");
		EditorGetPaintLayerWeightAtLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorGetPaintLayerWeightAtLocation_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		EditorGetPaintLayerWeightAtLocation_IsValid = EditorGetPaintLayerWeightAtLocation_FunctionAddress != IntPtr.Zero && EditorGetPaintLayerWeightAtLocation_InLocation_IsValid && EditorGetPaintLayerWeightAtLocation_PaintLayer_IsValid && EditorGetPaintLayerWeightAtLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeComponent:EditorGetPaintLayerWeightAtLocation", EditorGetPaintLayerWeightAtLocation_IsValid);
	}
}
