using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821047460uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialBillboardComponent", "Engine", UnrealModuleType.Engine)]
public class UMaterialBillboardComponent : UPrimitiveComponent
{
	private static bool Elements_IsValid;

	private static FFieldAddress Elements_PropertyAddress;

	private static int Elements_Offset;

	private TArrayReadOnlyMarshaler<FMaterialSpriteElement> Elements_MarshalerCached;

	private static bool SetElements_IsValid;

	private static IntPtr SetElements_FunctionAddress;

	private static int SetElements_ParamsSize;

	private static bool SetElements_NewElements_IsValid;

	private static FFieldAddress SetElements_NewElements_PropertyAddress;

	private static int SetElements_NewElements_Offset;

	private static bool AddElement_IsValid;

	private static IntPtr AddElement_FunctionAddress;

	private static int AddElement_ParamsSize;

	private static bool AddElement_Material_IsValid;

	private static FFieldAddress AddElement_Material_PropertyAddress;

	private static int AddElement_Material_Offset;

	private static bool AddElement_DistanceToOpacityCurve_IsValid;

	private static FFieldAddress AddElement_DistanceToOpacityCurve_PropertyAddress;

	private static int AddElement_DistanceToOpacityCurve_Offset;

	private static bool AddElement_bSizeIsInScreenSpace_IsValid;

	private static FFieldAddress AddElement_bSizeIsInScreenSpace_PropertyAddress;

	private static int AddElement_bSizeIsInScreenSpace_Offset;

	private static bool AddElement_BaseSizeX_IsValid;

	private static FFieldAddress AddElement_BaseSizeX_PropertyAddress;

	private static int AddElement_BaseSizeX_Offset;

	private static bool AddElement_BaseSizeY_IsValid;

	private static FFieldAddress AddElement_BaseSizeY_PropertyAddress;

	private static int AddElement_BaseSizeY_Offset;

	private static bool AddElement_DistanceToSizeCurve_IsValid;

	private static FFieldAddress AddElement_DistanceToSizeCurve_PropertyAddress;

	private static int AddElement_DistanceToSizeCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.MaterialBillboardComponent:Elements")]
	public TArrayReadOnly<FMaterialSpriteElement> Elements
	{
		get
		{
			CheckDestroyed();
			if (!Elements_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialBillboardComponent:Elements");
				return null;
			}
			if (Elements_MarshalerCached == null)
			{
				Elements_MarshalerCached = new TArrayReadOnlyMarshaler<FMaterialSpriteElement>(1, Elements_PropertyAddress, CachedMarshalingDelegates<FMaterialSpriteElement, FMaterialSpriteElement>.FromNative, CachedMarshalingDelegates<FMaterialSpriteElement, FMaterialSpriteElement>.ToNative);
			}
			return Elements_MarshalerCached.FromNative(IntPtr.Add(base.Address, Elements_Offset));
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.MaterialBillboardComponent:SetElements")]
	public unsafe void SetElements(List<FMaterialSpriteElement> NewElements)
	{
		CheckDestroyed();
		if (!SetElements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialBillboardComponent:SetElements");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetElements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetElements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FMaterialSpriteElement>(1, SetElements_NewElements_PropertyAddress, CachedMarshalingDelegates<FMaterialSpriteElement, FMaterialSpriteElement>.FromNative, CachedMarshalingDelegates<FMaterialSpriteElement, FMaterialSpriteElement>.ToNative).ToNative(IntPtr.Add(intPtr, SetElements_NewElements_Offset), NewElements);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetElements_FunctionAddress, intPtr, SetElements_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetElements_NewElements_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.MaterialBillboardComponent:AddElement")]
	public unsafe void AddElement(UMaterialInterface Material, UCurveFloat DistanceToOpacityCurve, bool bSizeIsInScreenSpace, float BaseSizeX, float BaseSizeY, UCurveFloat DistanceToSizeCurve)
	{
		CheckDestroyed();
		if (!AddElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialBillboardComponent:AddElement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, AddElement_Material_Offset), 0, AddElement_Material_PropertyAddress.Address, Material);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(intPtr, AddElement_DistanceToOpacityCurve_Offset), 0, AddElement_DistanceToOpacityCurve_PropertyAddress.Address, DistanceToOpacityCurve);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddElement_bSizeIsInScreenSpace_Offset), 0, AddElement_bSizeIsInScreenSpace_PropertyAddress.Address, bSizeIsInScreenSpace);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddElement_BaseSizeX_Offset), 0, AddElement_BaseSizeX_PropertyAddress.Address, BaseSizeX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddElement_BaseSizeY_Offset), 0, AddElement_BaseSizeY_PropertyAddress.Address, BaseSizeY);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(intPtr, AddElement_DistanceToSizeCurve_Offset), 0, AddElement_DistanceToSizeCurve_PropertyAddress.Address, DistanceToSizeCurve);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddElement_FunctionAddress, intPtr, AddElement_ParamsSize);
	}

	static UMaterialBillboardComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialBillboardComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialBillboardComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.MaterialBillboardComponent");
		NativeReflectionCached.GetPropertyRef(ref Elements_PropertyAddress, intPtr, "Elements");
		Elements_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Elements");
		Elements_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Elements", Classes.FArrayProperty);
		SetElements_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetElements");
		SetElements_ParamsSize = NativeReflection.GetFunctionParamsSize(SetElements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetElements_NewElements_PropertyAddress, SetElements_FunctionAddress, "NewElements");
		SetElements_NewElements_Offset = NativeReflectionCached.GetPropertyOffset(SetElements_FunctionAddress, "NewElements");
		SetElements_NewElements_IsValid = NativeReflectionCached.ValidatePropertyClass(SetElements_FunctionAddress, "NewElements", Classes.FArrayProperty);
		SetElements_IsValid = SetElements_FunctionAddress != IntPtr.Zero && SetElements_NewElements_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialBillboardComponent:SetElements", SetElements_IsValid);
		AddElement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddElement");
		AddElement_ParamsSize = NativeReflection.GetFunctionParamsSize(AddElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddElement_Material_PropertyAddress, AddElement_FunctionAddress, "Material");
		AddElement_Material_Offset = NativeReflectionCached.GetPropertyOffset(AddElement_FunctionAddress, "Material");
		AddElement_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(AddElement_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddElement_DistanceToOpacityCurve_PropertyAddress, AddElement_FunctionAddress, "DistanceToOpacityCurve");
		AddElement_DistanceToOpacityCurve_Offset = NativeReflectionCached.GetPropertyOffset(AddElement_FunctionAddress, "DistanceToOpacityCurve");
		AddElement_DistanceToOpacityCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(AddElement_FunctionAddress, "DistanceToOpacityCurve", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddElement_bSizeIsInScreenSpace_PropertyAddress, AddElement_FunctionAddress, "bSizeIsInScreenSpace");
		AddElement_bSizeIsInScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(AddElement_FunctionAddress, "bSizeIsInScreenSpace");
		AddElement_bSizeIsInScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(AddElement_FunctionAddress, "bSizeIsInScreenSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddElement_BaseSizeX_PropertyAddress, AddElement_FunctionAddress, "BaseSizeX");
		AddElement_BaseSizeX_Offset = NativeReflectionCached.GetPropertyOffset(AddElement_FunctionAddress, "BaseSizeX");
		AddElement_BaseSizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(AddElement_FunctionAddress, "BaseSizeX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddElement_BaseSizeY_PropertyAddress, AddElement_FunctionAddress, "BaseSizeY");
		AddElement_BaseSizeY_Offset = NativeReflectionCached.GetPropertyOffset(AddElement_FunctionAddress, "BaseSizeY");
		AddElement_BaseSizeY_IsValid = NativeReflectionCached.ValidatePropertyClass(AddElement_FunctionAddress, "BaseSizeY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddElement_DistanceToSizeCurve_PropertyAddress, AddElement_FunctionAddress, "DistanceToSizeCurve");
		AddElement_DistanceToSizeCurve_Offset = NativeReflectionCached.GetPropertyOffset(AddElement_FunctionAddress, "DistanceToSizeCurve");
		AddElement_DistanceToSizeCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(AddElement_FunctionAddress, "DistanceToSizeCurve", Classes.FObjectProperty);
		AddElement_IsValid = AddElement_FunctionAddress != IntPtr.Zero && AddElement_Material_IsValid && AddElement_DistanceToOpacityCurve_IsValid && AddElement_bSizeIsInScreenSpace_IsValid && AddElement_BaseSizeX_IsValid && AddElement_BaseSizeY_IsValid && AddElement_DistanceToSizeCurve_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialBillboardComponent:AddElement", AddElement_IsValid);
	}
}
