using System;
using System.Runtime.CompilerServices;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818413729uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialInterface", "Engine", UnrealModuleType.Engine)]
public class UMaterialInterface : UObject, IBlendableInterface, IInterface, IInterface_AssetUserData
{
	private static bool SubsurfaceProfile_IsValid;

	private static int SubsurfaceProfile_Offset;

	private static bool SetForceMipLevelsToBeResident_IsValid;

	private static IntPtr SetForceMipLevelsToBeResident_FunctionAddress;

	private static int SetForceMipLevelsToBeResident_ParamsSize;

	private static bool SetForceMipLevelsToBeResident_OverrideForceMiplevelsToBeResident_IsValid;

	private static FFieldAddress SetForceMipLevelsToBeResident_OverrideForceMiplevelsToBeResident_PropertyAddress;

	private static int SetForceMipLevelsToBeResident_OverrideForceMiplevelsToBeResident_Offset;

	private static bool SetForceMipLevelsToBeResident_bForceMiplevelsToBeResidentValue_IsValid;

	private static FFieldAddress SetForceMipLevelsToBeResident_bForceMiplevelsToBeResidentValue_PropertyAddress;

	private static int SetForceMipLevelsToBeResident_bForceMiplevelsToBeResidentValue_Offset;

	private static bool SetForceMipLevelsToBeResident_ForceDuration_IsValid;

	private static FFieldAddress SetForceMipLevelsToBeResident_ForceDuration_PropertyAddress;

	private static int SetForceMipLevelsToBeResident_ForceDuration_Offset;

	private static bool SetForceMipLevelsToBeResident_CinematicTextureGroups_IsValid;

	private static FFieldAddress SetForceMipLevelsToBeResident_CinematicTextureGroups_PropertyAddress;

	private static int SetForceMipLevelsToBeResident_CinematicTextureGroups_Offset;

	private static bool SetForceMipLevelsToBeResident_bFastResponse_IsValid;

	private static FFieldAddress SetForceMipLevelsToBeResident_bFastResponse_PropertyAddress;

	private static int SetForceMipLevelsToBeResident_bFastResponse_Offset;

	private static bool GetPhysicalMaterialMask_IsValid;

	private static IntPtr GetPhysicalMaterialMask_FunctionAddress;

	private static int GetPhysicalMaterialMask_ParamsSize;

	private static bool GetPhysicalMaterialMask_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicalMaterialMask_ReturnValue_PropertyAddress;

	private static int GetPhysicalMaterialMask_ReturnValue_Offset;

	private static bool GetPhysicalMaterialFromMap_IsValid;

	private static IntPtr GetPhysicalMaterialFromMap_FunctionAddress;

	private static int GetPhysicalMaterialFromMap_ParamsSize;

	private static bool GetPhysicalMaterialFromMap_Index_IsValid;

	private static FFieldAddress GetPhysicalMaterialFromMap_Index_PropertyAddress;

	private static int GetPhysicalMaterialFromMap_Index_Offset;

	private static bool GetPhysicalMaterialFromMap_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicalMaterialFromMap_ReturnValue_PropertyAddress;

	private static int GetPhysicalMaterialFromMap_ReturnValue_Offset;

	private static bool GetPhysicalMaterial_IsValid;

	private static IntPtr GetPhysicalMaterial_FunctionAddress;

	private static int GetPhysicalMaterial_ParamsSize;

	private static bool GetPhysicalMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicalMaterial_ReturnValue_PropertyAddress;

	private static int GetPhysicalMaterial_ReturnValue_Offset;

	private static bool GetParameterInfo_IsValid;

	private static IntPtr GetParameterInfo_FunctionAddress;

	private static int GetParameterInfo_ParamsSize;

	private static bool GetParameterInfo_Association_IsValid;

	private static FFieldAddress GetParameterInfo_Association_PropertyAddress;

	private static int GetParameterInfo_Association_Offset;

	private static bool GetParameterInfo_ParameterName_IsValid;

	private static FFieldAddress GetParameterInfo_ParameterName_PropertyAddress;

	private static int GetParameterInfo_ParameterName_Offset;

	private static bool GetParameterInfo_LayerFunction_IsValid;

	private static FFieldAddress GetParameterInfo_LayerFunction_PropertyAddress;

	private static int GetParameterInfo_LayerFunction_Offset;

	private static bool GetParameterInfo_ReturnValue_IsValid;

	private static FFieldAddress GetParameterInfo_ReturnValue_PropertyAddress;

	private static int GetParameterInfo_ReturnValue_Offset;

	private static bool GetBaseMaterial_IsValid;

	private static IntPtr GetBaseMaterial_FunctionAddress;

	private static int GetBaseMaterial_ParamsSize;

	private static bool GetBaseMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetBaseMaterial_ReturnValue_PropertyAddress;

	private static int GetBaseMaterial_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.MaterialInterface:SubsurfaceProfile")]
	public USubsurfaceProfile SubsurfaceProfile
	{
		get
		{
			CheckDestroyed();
			if (!SubsurfaceProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInterface:SubsurfaceProfile");
				return null;
			}
			return UObjectMarshaler<USubsurfaceProfile>.FromNative(IntPtr.Add(base.Address, SubsurfaceProfile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubsurfaceProfile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialInterface:SubsurfaceProfile");
			}
			else
			{
				UObjectMarshaler<USubsurfaceProfile>.ToNative(IntPtr.Add(base.Address, SubsurfaceProfile_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240962u)]
	[UMetaPath("/Script/Engine.MaterialInterface:SetForceMipLevelsToBeResident")]
	public unsafe void SetForceMipLevelsToBeResident(bool OverrideForceMiplevelsToBeResident, bool bForceMiplevelsToBeResidentValue, float ForceDuration, int CinematicTextureGroups = 0, bool bFastResponse = false)
	{
		CheckDestroyed();
		if (!SetForceMipLevelsToBeResident_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInterface:SetForceMipLevelsToBeResident");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceMipLevelsToBeResident_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceMipLevelsToBeResident_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceMipLevelsToBeResident_OverrideForceMiplevelsToBeResident_Offset), 0, SetForceMipLevelsToBeResident_OverrideForceMiplevelsToBeResident_PropertyAddress.Address, OverrideForceMiplevelsToBeResident);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceMipLevelsToBeResident_bForceMiplevelsToBeResidentValue_Offset), 0, SetForceMipLevelsToBeResident_bForceMiplevelsToBeResidentValue_PropertyAddress.Address, bForceMiplevelsToBeResidentValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetForceMipLevelsToBeResident_ForceDuration_Offset), 0, SetForceMipLevelsToBeResident_ForceDuration_PropertyAddress.Address, ForceDuration);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetForceMipLevelsToBeResident_CinematicTextureGroups_Offset), 0, SetForceMipLevelsToBeResident_CinematicTextureGroups_PropertyAddress.Address, CinematicTextureGroups);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceMipLevelsToBeResident_bFastResponse_Offset), 0, SetForceMipLevelsToBeResident_bFastResponse_PropertyAddress.Address, bFastResponse);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceMipLevelsToBeResident_FunctionAddress, intPtr, SetForceMipLevelsToBeResident_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MaterialInterface:GetPhysicalMaterialMask")]
	public unsafe UPhysicalMaterialMask GetPhysicalMaterialMask()
	{
		CheckDestroyed();
		if (!GetPhysicalMaterialMask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInterface:GetPhysicalMaterialMask");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicalMaterialMask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicalMaterialMask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicalMaterialMask_FunctionAddress, intPtr, GetPhysicalMaterialMask_ParamsSize);
		return UObjectMarshaler<UPhysicalMaterialMask>.FromNative(IntPtr.Add(intPtr, GetPhysicalMaterialMask_ReturnValue_Offset), 0, GetPhysicalMaterialMask_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MaterialInterface:GetPhysicalMaterialFromMap")]
	public unsafe UPhysicalMaterial GetPhysicalMaterialFromMap(int Index)
	{
		CheckDestroyed();
		if (!GetPhysicalMaterialFromMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInterface:GetPhysicalMaterialFromMap");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicalMaterialFromMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicalMaterialFromMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetPhysicalMaterialFromMap_Index_Offset), 0, GetPhysicalMaterialFromMap_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicalMaterialFromMap_FunctionAddress, intPtr, GetPhysicalMaterialFromMap_ParamsSize);
		return UObjectMarshaler<UPhysicalMaterial>.FromNative(IntPtr.Add(intPtr, GetPhysicalMaterialFromMap_ReturnValue_Offset), 0, GetPhysicalMaterialFromMap_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MaterialInterface:GetPhysicalMaterial")]
	public unsafe UPhysicalMaterial GetPhysicalMaterial()
	{
		CheckDestroyed();
		if (!GetPhysicalMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInterface:GetPhysicalMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicalMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicalMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicalMaterial_FunctionAddress, intPtr, GetPhysicalMaterial_ParamsSize);
		return UObjectMarshaler<UPhysicalMaterial>.FromNative(IntPtr.Add(intPtr, GetPhysicalMaterial_ReturnValue_Offset), 0, GetPhysicalMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/Engine.MaterialInterface:GetParameterInfo")]
	public unsafe FMaterialParameterInfo GetParameterInfo(EMaterialParameterAssociation Association, FName ParameterName, UMaterialFunctionInterface LayerFunction)
	{
		CheckDestroyed();
		if (!GetParameterInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInterface:GetParameterInfo");
			return default(FMaterialParameterInfo);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMaterialParameterAssociation>.ToNative(IntPtr.Add(intPtr, GetParameterInfo_Association_Offset), 0, GetParameterInfo_Association_PropertyAddress.Address, Association);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterInfo_ParameterName_Offset), 0, GetParameterInfo_ParameterName_PropertyAddress.Address, ParameterName);
		UObjectMarshaler<UMaterialFunctionInterface>.ToNative(IntPtr.Add(intPtr, GetParameterInfo_LayerFunction_Offset), 0, GetParameterInfo_LayerFunction_PropertyAddress.Address, LayerFunction);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterInfo_FunctionAddress, intPtr, GetParameterInfo_ParamsSize);
		return FMaterialParameterInfo.FromNative(IntPtr.Add(intPtr, GetParameterInfo_ReturnValue_Offset), 0, GetParameterInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.MaterialInterface:GetBaseMaterial")]
	public unsafe UMaterial GetBaseMaterial()
	{
		CheckDestroyed();
		if (!GetBaseMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInterface:GetBaseMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBaseMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBaseMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBaseMaterial_FunctionAddress, intPtr, GetBaseMaterial_ParamsSize);
		return UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(intPtr, GetBaseMaterial_ReturnValue_Offset), 0, GetBaseMaterial_ReturnValue_PropertyAddress.Address);
	}

	static UMaterialInterface()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialInterface)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialInterface));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.MaterialInterface");
		SubsurfaceProfile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubsurfaceProfile");
		SubsurfaceProfile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubsurfaceProfile", Classes.FObjectProperty);
		SetForceMipLevelsToBeResident_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForceMipLevelsToBeResident");
		SetForceMipLevelsToBeResident_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceMipLevelsToBeResident_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceMipLevelsToBeResident_OverrideForceMiplevelsToBeResident_PropertyAddress, SetForceMipLevelsToBeResident_FunctionAddress, "OverrideForceMiplevelsToBeResident");
		SetForceMipLevelsToBeResident_OverrideForceMiplevelsToBeResident_Offset = NativeReflectionCached.GetPropertyOffset(SetForceMipLevelsToBeResident_FunctionAddress, "OverrideForceMiplevelsToBeResident");
		SetForceMipLevelsToBeResident_OverrideForceMiplevelsToBeResident_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceMipLevelsToBeResident_FunctionAddress, "OverrideForceMiplevelsToBeResident", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetForceMipLevelsToBeResident_bForceMiplevelsToBeResidentValue_PropertyAddress, SetForceMipLevelsToBeResident_FunctionAddress, "bForceMiplevelsToBeResidentValue");
		SetForceMipLevelsToBeResident_bForceMiplevelsToBeResidentValue_Offset = NativeReflectionCached.GetPropertyOffset(SetForceMipLevelsToBeResident_FunctionAddress, "bForceMiplevelsToBeResidentValue");
		SetForceMipLevelsToBeResident_bForceMiplevelsToBeResidentValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceMipLevelsToBeResident_FunctionAddress, "bForceMiplevelsToBeResidentValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetForceMipLevelsToBeResident_ForceDuration_PropertyAddress, SetForceMipLevelsToBeResident_FunctionAddress, "ForceDuration");
		SetForceMipLevelsToBeResident_ForceDuration_Offset = NativeReflectionCached.GetPropertyOffset(SetForceMipLevelsToBeResident_FunctionAddress, "ForceDuration");
		SetForceMipLevelsToBeResident_ForceDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceMipLevelsToBeResident_FunctionAddress, "ForceDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetForceMipLevelsToBeResident_CinematicTextureGroups_PropertyAddress, SetForceMipLevelsToBeResident_FunctionAddress, "CinematicTextureGroups");
		SetForceMipLevelsToBeResident_CinematicTextureGroups_Offset = NativeReflectionCached.GetPropertyOffset(SetForceMipLevelsToBeResident_FunctionAddress, "CinematicTextureGroups");
		SetForceMipLevelsToBeResident_CinematicTextureGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceMipLevelsToBeResident_FunctionAddress, "CinematicTextureGroups", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetForceMipLevelsToBeResident_bFastResponse_PropertyAddress, SetForceMipLevelsToBeResident_FunctionAddress, "bFastResponse");
		SetForceMipLevelsToBeResident_bFastResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetForceMipLevelsToBeResident_FunctionAddress, "bFastResponse");
		SetForceMipLevelsToBeResident_bFastResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceMipLevelsToBeResident_FunctionAddress, "bFastResponse", Classes.FBoolProperty);
		SetForceMipLevelsToBeResident_IsValid = SetForceMipLevelsToBeResident_FunctionAddress != IntPtr.Zero && SetForceMipLevelsToBeResident_OverrideForceMiplevelsToBeResident_IsValid && SetForceMipLevelsToBeResident_bForceMiplevelsToBeResidentValue_IsValid && SetForceMipLevelsToBeResident_ForceDuration_IsValid && SetForceMipLevelsToBeResident_CinematicTextureGroups_IsValid && SetForceMipLevelsToBeResident_bFastResponse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInterface:SetForceMipLevelsToBeResident", SetForceMipLevelsToBeResident_IsValid);
		GetPhysicalMaterialMask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicalMaterialMask");
		GetPhysicalMaterialMask_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicalMaterialMask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicalMaterialMask_ReturnValue_PropertyAddress, GetPhysicalMaterialMask_FunctionAddress, "ReturnValue");
		GetPhysicalMaterialMask_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicalMaterialMask_FunctionAddress, "ReturnValue");
		GetPhysicalMaterialMask_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicalMaterialMask_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPhysicalMaterialMask_IsValid = GetPhysicalMaterialMask_FunctionAddress != IntPtr.Zero && GetPhysicalMaterialMask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInterface:GetPhysicalMaterialMask", GetPhysicalMaterialMask_IsValid);
		GetPhysicalMaterialFromMap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicalMaterialFromMap");
		GetPhysicalMaterialFromMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicalMaterialFromMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicalMaterialFromMap_Index_PropertyAddress, GetPhysicalMaterialFromMap_FunctionAddress, "Index");
		GetPhysicalMaterialFromMap_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicalMaterialFromMap_FunctionAddress, "Index");
		GetPhysicalMaterialFromMap_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicalMaterialFromMap_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicalMaterialFromMap_ReturnValue_PropertyAddress, GetPhysicalMaterialFromMap_FunctionAddress, "ReturnValue");
		GetPhysicalMaterialFromMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicalMaterialFromMap_FunctionAddress, "ReturnValue");
		GetPhysicalMaterialFromMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicalMaterialFromMap_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPhysicalMaterialFromMap_IsValid = GetPhysicalMaterialFromMap_FunctionAddress != IntPtr.Zero && GetPhysicalMaterialFromMap_Index_IsValid && GetPhysicalMaterialFromMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInterface:GetPhysicalMaterialFromMap", GetPhysicalMaterialFromMap_IsValid);
		GetPhysicalMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicalMaterial");
		GetPhysicalMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicalMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicalMaterial_ReturnValue_PropertyAddress, GetPhysicalMaterial_FunctionAddress, "ReturnValue");
		GetPhysicalMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicalMaterial_FunctionAddress, "ReturnValue");
		GetPhysicalMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicalMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPhysicalMaterial_IsValid = GetPhysicalMaterial_FunctionAddress != IntPtr.Zero && GetPhysicalMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInterface:GetPhysicalMaterial", GetPhysicalMaterial_IsValid);
		GetParameterInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetParameterInfo");
		GetParameterInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterInfo_Association_PropertyAddress, GetParameterInfo_FunctionAddress, "Association");
		GetParameterInfo_Association_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterInfo_FunctionAddress, "Association");
		GetParameterInfo_Association_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterInfo_FunctionAddress, "Association", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterInfo_ParameterName_PropertyAddress, GetParameterInfo_FunctionAddress, "ParameterName");
		GetParameterInfo_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterInfo_FunctionAddress, "ParameterName");
		GetParameterInfo_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterInfo_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterInfo_LayerFunction_PropertyAddress, GetParameterInfo_FunctionAddress, "LayerFunction");
		GetParameterInfo_LayerFunction_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterInfo_FunctionAddress, "LayerFunction");
		GetParameterInfo_LayerFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterInfo_FunctionAddress, "LayerFunction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterInfo_ReturnValue_PropertyAddress, GetParameterInfo_FunctionAddress, "ReturnValue");
		GetParameterInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterInfo_FunctionAddress, "ReturnValue");
		GetParameterInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterInfo_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParameterInfo_IsValid = GetParameterInfo_FunctionAddress != IntPtr.Zero && GetParameterInfo_Association_IsValid && GetParameterInfo_ParameterName_IsValid && GetParameterInfo_LayerFunction_IsValid && GetParameterInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInterface:GetParameterInfo", GetParameterInfo_IsValid);
		GetBaseMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBaseMaterial");
		GetBaseMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBaseMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBaseMaterial_ReturnValue_PropertyAddress, GetBaseMaterial_FunctionAddress, "ReturnValue");
		GetBaseMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBaseMaterial_FunctionAddress, "ReturnValue");
		GetBaseMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBaseMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBaseMaterial_IsValid = GetBaseMaterial_FunctionAddress != IntPtr.Zero && GetBaseMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInterface:GetBaseMaterial", GetBaseMaterial_IsValid);
	}
}
