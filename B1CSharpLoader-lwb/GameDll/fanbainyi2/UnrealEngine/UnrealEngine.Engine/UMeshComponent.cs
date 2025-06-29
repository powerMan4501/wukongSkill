using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MeshComponent", "Engine", UnrealModuleType.Engine)]
public class UMeshComponent : UPrimitiveComponent
{
	private static bool EnableMaterialParameterCaching_IsValid;

	private static FFieldAddress EnableMaterialParameterCaching_PropertyAddress;

	private static int EnableMaterialParameterCaching_Offset;

	private static bool SetVectorParameterValueOnMaterials_IsValid;

	private static IntPtr SetVectorParameterValueOnMaterials_FunctionAddress;

	private static int SetVectorParameterValueOnMaterials_ParamsSize;

	private static bool SetVectorParameterValueOnMaterials_ParameterName_IsValid;

	private static FFieldAddress SetVectorParameterValueOnMaterials_ParameterName_PropertyAddress;

	private static int SetVectorParameterValueOnMaterials_ParameterName_Offset;

	private static bool SetVectorParameterValueOnMaterials_ParameterValue_IsValid;

	private static FFieldAddress SetVectorParameterValueOnMaterials_ParameterValue_PropertyAddress;

	private static int SetVectorParameterValueOnMaterials_ParameterValue_Offset;

	private static bool SetScalarParameterValueOnMaterials_IsValid;

	private static IntPtr SetScalarParameterValueOnMaterials_FunctionAddress;

	private static int SetScalarParameterValueOnMaterials_ParamsSize;

	private static bool SetScalarParameterValueOnMaterials_ParameterName_IsValid;

	private static FFieldAddress SetScalarParameterValueOnMaterials_ParameterName_PropertyAddress;

	private static int SetScalarParameterValueOnMaterials_ParameterName_Offset;

	private static bool SetScalarParameterValueOnMaterials_ParameterValue_IsValid;

	private static FFieldAddress SetScalarParameterValueOnMaterials_ParameterValue_PropertyAddress;

	private static int SetScalarParameterValueOnMaterials_ParameterValue_Offset;

	private static bool PrestreamTextures_IsValid;

	private static IntPtr PrestreamTextures_FunctionAddress;

	private static int PrestreamTextures_ParamsSize;

	private static bool PrestreamTextures_Seconds_IsValid;

	private static FFieldAddress PrestreamTextures_Seconds_PropertyAddress;

	private static int PrestreamTextures_Seconds_Offset;

	private static bool PrestreamTextures_bPrioritizeCharacterTextures_IsValid;

	private static FFieldAddress PrestreamTextures_bPrioritizeCharacterTextures_PropertyAddress;

	private static int PrestreamTextures_bPrioritizeCharacterTextures_Offset;

	private static bool PrestreamTextures_CinematicTextureGroups_IsValid;

	private static FFieldAddress PrestreamTextures_CinematicTextureGroups_PropertyAddress;

	private static int PrestreamTextures_CinematicTextureGroups_Offset;

	private static bool IsMaterialSlotNameValid_IsValid;

	private static IntPtr IsMaterialSlotNameValid_FunctionAddress;

	private static int IsMaterialSlotNameValid_ParamsSize;

	private static bool IsMaterialSlotNameValid_MaterialSlotName_IsValid;

	private static FFieldAddress IsMaterialSlotNameValid_MaterialSlotName_PropertyAddress;

	private static int IsMaterialSlotNameValid_MaterialSlotName_Offset;

	private static bool IsMaterialSlotNameValid_ReturnValue_IsValid;

	private static FFieldAddress IsMaterialSlotNameValid_ReturnValue_PropertyAddress;

	private static int IsMaterialSlotNameValid_ReturnValue_Offset;

	private static bool GetMaterialSlotNames_IsValid;

	private static IntPtr GetMaterialSlotNames_FunctionAddress;

	private static int GetMaterialSlotNames_ParamsSize;

	private static bool GetMaterialSlotNames_ReturnValue_IsValid;

	private static FFieldAddress GetMaterialSlotNames_ReturnValue_PropertyAddress;

	private static int GetMaterialSlotNames_ReturnValue_Offset;

	private static bool GetMaterials_IsValid;

	private static IntPtr GetMaterials_FunctionAddress;

	private static int GetMaterials_ParamsSize;

	private static bool GetMaterials_ReturnValue_IsValid;

	private static FFieldAddress GetMaterials_ReturnValue_PropertyAddress;

	private static int GetMaterials_ReturnValue_Offset;

	private static bool GetMaterialIndex_IsValid;

	private static IntPtr GetMaterialIndex_FunctionAddress;

	private static int GetMaterialIndex_ParamsSize;

	private static bool GetMaterialIndex_MaterialSlotName_IsValid;

	private static FFieldAddress GetMaterialIndex_MaterialSlotName_PropertyAddress;

	private static int GetMaterialIndex_MaterialSlotName_Offset;

	private static bool GetMaterialIndex_ReturnValue_IsValid;

	private static FFieldAddress GetMaterialIndex_ReturnValue_PropertyAddress;

	private static int GetMaterialIndex_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11272261927436309uL)]
	[UMetaPath("/Script/Engine.MeshComponent:bEnableMaterialParameterCaching")]
	protected bool EnableMaterialParameterCaching
	{
		get
		{
			CheckDestroyed();
			if (!EnableMaterialParameterCaching_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MeshComponent:bEnableMaterialParameterCaching");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableMaterialParameterCaching_Offset), 0, EnableMaterialParameterCaching_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableMaterialParameterCaching_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MeshComponent:bEnableMaterialParameterCaching");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableMaterialParameterCaching_Offset), 0, EnableMaterialParameterCaching_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.MeshComponent:SetVectorParameterValueOnMaterials")]
	public unsafe void SetVectorParameterValueOnMaterials(FName ParameterName, FVector ParameterValue)
	{
		CheckDestroyed();
		if (!SetVectorParameterValueOnMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshComponent:SetVectorParameterValueOnMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorParameterValueOnMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorParameterValueOnMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorParameterValueOnMaterials_ParameterName_Offset), 0, SetVectorParameterValueOnMaterials_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVectorParameterValueOnMaterials_ParameterValue_Offset), 0, SetVectorParameterValueOnMaterials_ParameterValue_PropertyAddress.Address, ParameterValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVectorParameterValueOnMaterials_FunctionAddress, intPtr, SetVectorParameterValueOnMaterials_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.MeshComponent:SetScalarParameterValueOnMaterials")]
	public unsafe void SetScalarParameterValueOnMaterials(FName ParameterName, float ParameterValue)
	{
		CheckDestroyed();
		if (!SetScalarParameterValueOnMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshComponent:SetScalarParameterValueOnMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalarParameterValueOnMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalarParameterValueOnMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetScalarParameterValueOnMaterials_ParameterName_Offset), 0, SetScalarParameterValueOnMaterials_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScalarParameterValueOnMaterials_ParameterValue_Offset), 0, SetScalarParameterValueOnMaterials_ParameterValue_PropertyAddress.Address, ParameterValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScalarParameterValueOnMaterials_FunctionAddress, intPtr, SetScalarParameterValueOnMaterials_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MeshComponent:PrestreamTextures")]
	public unsafe void PrestreamTextures(float Seconds, bool bPrioritizeCharacterTextures, int CinematicTextureGroups = 0)
	{
		CheckDestroyed();
		if (!PrestreamTextures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshComponent:PrestreamTextures");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrestreamTextures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrestreamTextures_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PrestreamTextures_Seconds_Offset), 0, PrestreamTextures_Seconds_PropertyAddress.Address, Seconds);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PrestreamTextures_bPrioritizeCharacterTextures_Offset), 0, PrestreamTextures_bPrioritizeCharacterTextures_PropertyAddress.Address, bPrioritizeCharacterTextures);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PrestreamTextures_CinematicTextureGroups_Offset), 0, PrestreamTextures_CinematicTextureGroups_PropertyAddress.Address, CinematicTextureGroups);
		NativeReflection.InvokeFunctionOptimized(base.Address, PrestreamTextures_FunctionAddress, intPtr, PrestreamTextures_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MeshComponent:IsMaterialSlotNameValid")]
	public unsafe bool IsMaterialSlotNameValid(FName MaterialSlotName)
	{
		CheckDestroyed();
		if (!IsMaterialSlotNameValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshComponent:IsMaterialSlotNameValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMaterialSlotNameValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMaterialSlotNameValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsMaterialSlotNameValid_MaterialSlotName_Offset), 0, IsMaterialSlotNameValid_MaterialSlotName_PropertyAddress.Address, MaterialSlotName);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMaterialSlotNameValid_FunctionAddress, intPtr, IsMaterialSlotNameValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMaterialSlotNameValid_ReturnValue_Offset), 0, IsMaterialSlotNameValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MeshComponent:GetMaterialSlotNames")]
	public unsafe List<FName> GetMaterialSlotNames()
	{
		CheckDestroyed();
		if (!GetMaterialSlotNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshComponent:GetMaterialSlotNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialSlotNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialSlotNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialSlotNames_FunctionAddress, intPtr, GetMaterialSlotNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetMaterialSlotNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMaterialSlotNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMaterialSlotNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MeshComponent:GetMaterials")]
	public unsafe List<UMaterialInterface> GetMaterials()
	{
		CheckDestroyed();
		if (!GetMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshComponent:GetMaterials");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterials_FunctionAddress, intPtr, GetMaterials_ParamsSize);
		List<UMaterialInterface> result = new TArrayCopyMarshaler<UMaterialInterface>(1, GetMaterials_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMaterials_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMaterials_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MeshComponent:GetMaterialIndex")]
	public unsafe int GetMaterialIndex(FName MaterialSlotName)
	{
		CheckDestroyed();
		if (!GetMaterialIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MeshComponent:GetMaterialIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMaterialIndex_MaterialSlotName_Offset), 0, GetMaterialIndex_MaterialSlotName_PropertyAddress.Address, MaterialSlotName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialIndex_FunctionAddress, intPtr, GetMaterialIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaterialIndex_ReturnValue_Offset), 0, GetMaterialIndex_ReturnValue_PropertyAddress.Address);
	}

	static UMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.MeshComponent");
		NativeReflectionCached.GetPropertyRef(ref EnableMaterialParameterCaching_PropertyAddress, intPtr, "bEnableMaterialParameterCaching");
		EnableMaterialParameterCaching_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableMaterialParameterCaching");
		EnableMaterialParameterCaching_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableMaterialParameterCaching", Classes.FBoolProperty);
		SetVectorParameterValueOnMaterials_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVectorParameterValueOnMaterials");
		SetVectorParameterValueOnMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorParameterValueOnMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValueOnMaterials_ParameterName_PropertyAddress, SetVectorParameterValueOnMaterials_FunctionAddress, "ParameterName");
		SetVectorParameterValueOnMaterials_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValueOnMaterials_FunctionAddress, "ParameterName");
		SetVectorParameterValueOnMaterials_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValueOnMaterials_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValueOnMaterials_ParameterValue_PropertyAddress, SetVectorParameterValueOnMaterials_FunctionAddress, "ParameterValue");
		SetVectorParameterValueOnMaterials_ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValueOnMaterials_FunctionAddress, "ParameterValue");
		SetVectorParameterValueOnMaterials_ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValueOnMaterials_FunctionAddress, "ParameterValue", Classes.FStructProperty);
		SetVectorParameterValueOnMaterials_IsValid = SetVectorParameterValueOnMaterials_FunctionAddress != IntPtr.Zero && SetVectorParameterValueOnMaterials_ParameterName_IsValid && SetVectorParameterValueOnMaterials_ParameterValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshComponent:SetVectorParameterValueOnMaterials", SetVectorParameterValueOnMaterials_IsValid);
		SetScalarParameterValueOnMaterials_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScalarParameterValueOnMaterials");
		SetScalarParameterValueOnMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalarParameterValueOnMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValueOnMaterials_ParameterName_PropertyAddress, SetScalarParameterValueOnMaterials_FunctionAddress, "ParameterName");
		SetScalarParameterValueOnMaterials_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValueOnMaterials_FunctionAddress, "ParameterName");
		SetScalarParameterValueOnMaterials_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValueOnMaterials_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValueOnMaterials_ParameterValue_PropertyAddress, SetScalarParameterValueOnMaterials_FunctionAddress, "ParameterValue");
		SetScalarParameterValueOnMaterials_ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValueOnMaterials_FunctionAddress, "ParameterValue");
		SetScalarParameterValueOnMaterials_ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValueOnMaterials_FunctionAddress, "ParameterValue", Classes.FFloatProperty);
		SetScalarParameterValueOnMaterials_IsValid = SetScalarParameterValueOnMaterials_FunctionAddress != IntPtr.Zero && SetScalarParameterValueOnMaterials_ParameterName_IsValid && SetScalarParameterValueOnMaterials_ParameterValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshComponent:SetScalarParameterValueOnMaterials", SetScalarParameterValueOnMaterials_IsValid);
		PrestreamTextures_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PrestreamTextures");
		PrestreamTextures_ParamsSize = NativeReflection.GetFunctionParamsSize(PrestreamTextures_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrestreamTextures_Seconds_PropertyAddress, PrestreamTextures_FunctionAddress, "Seconds");
		PrestreamTextures_Seconds_Offset = NativeReflectionCached.GetPropertyOffset(PrestreamTextures_FunctionAddress, "Seconds");
		PrestreamTextures_Seconds_IsValid = NativeReflectionCached.ValidatePropertyClass(PrestreamTextures_FunctionAddress, "Seconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PrestreamTextures_bPrioritizeCharacterTextures_PropertyAddress, PrestreamTextures_FunctionAddress, "bPrioritizeCharacterTextures");
		PrestreamTextures_bPrioritizeCharacterTextures_Offset = NativeReflectionCached.GetPropertyOffset(PrestreamTextures_FunctionAddress, "bPrioritizeCharacterTextures");
		PrestreamTextures_bPrioritizeCharacterTextures_IsValid = NativeReflectionCached.ValidatePropertyClass(PrestreamTextures_FunctionAddress, "bPrioritizeCharacterTextures", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PrestreamTextures_CinematicTextureGroups_PropertyAddress, PrestreamTextures_FunctionAddress, "CinematicTextureGroups");
		PrestreamTextures_CinematicTextureGroups_Offset = NativeReflectionCached.GetPropertyOffset(PrestreamTextures_FunctionAddress, "CinematicTextureGroups");
		PrestreamTextures_CinematicTextureGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(PrestreamTextures_FunctionAddress, "CinematicTextureGroups", Classes.FIntProperty);
		PrestreamTextures_IsValid = PrestreamTextures_FunctionAddress != IntPtr.Zero && PrestreamTextures_Seconds_IsValid && PrestreamTextures_bPrioritizeCharacterTextures_IsValid && PrestreamTextures_CinematicTextureGroups_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshComponent:PrestreamTextures", PrestreamTextures_IsValid);
		IsMaterialSlotNameValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsMaterialSlotNameValid");
		IsMaterialSlotNameValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMaterialSlotNameValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMaterialSlotNameValid_MaterialSlotName_PropertyAddress, IsMaterialSlotNameValid_FunctionAddress, "MaterialSlotName");
		IsMaterialSlotNameValid_MaterialSlotName_Offset = NativeReflectionCached.GetPropertyOffset(IsMaterialSlotNameValid_FunctionAddress, "MaterialSlotName");
		IsMaterialSlotNameValid_MaterialSlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMaterialSlotNameValid_FunctionAddress, "MaterialSlotName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMaterialSlotNameValid_ReturnValue_PropertyAddress, IsMaterialSlotNameValid_FunctionAddress, "ReturnValue");
		IsMaterialSlotNameValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMaterialSlotNameValid_FunctionAddress, "ReturnValue");
		IsMaterialSlotNameValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMaterialSlotNameValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMaterialSlotNameValid_IsValid = IsMaterialSlotNameValid_FunctionAddress != IntPtr.Zero && IsMaterialSlotNameValid_MaterialSlotName_IsValid && IsMaterialSlotNameValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshComponent:IsMaterialSlotNameValid", IsMaterialSlotNameValid_IsValid);
		GetMaterialSlotNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaterialSlotNames");
		GetMaterialSlotNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialSlotNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialSlotNames_ReturnValue_PropertyAddress, GetMaterialSlotNames_FunctionAddress, "ReturnValue");
		GetMaterialSlotNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialSlotNames_FunctionAddress, "ReturnValue");
		GetMaterialSlotNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialSlotNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMaterialSlotNames_IsValid = GetMaterialSlotNames_FunctionAddress != IntPtr.Zero && GetMaterialSlotNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshComponent:GetMaterialSlotNames", GetMaterialSlotNames_IsValid);
		GetMaterials_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaterials");
		GetMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterials_ReturnValue_PropertyAddress, GetMaterials_FunctionAddress, "ReturnValue");
		GetMaterials_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterials_FunctionAddress, "ReturnValue");
		GetMaterials_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterials_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMaterials_IsValid = GetMaterials_FunctionAddress != IntPtr.Zero && GetMaterials_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshComponent:GetMaterials", GetMaterials_IsValid);
		GetMaterialIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaterialIndex");
		GetMaterialIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialIndex_MaterialSlotName_PropertyAddress, GetMaterialIndex_FunctionAddress, "MaterialSlotName");
		GetMaterialIndex_MaterialSlotName_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialIndex_FunctionAddress, "MaterialSlotName");
		GetMaterialIndex_MaterialSlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialIndex_FunctionAddress, "MaterialSlotName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialIndex_ReturnValue_PropertyAddress, GetMaterialIndex_FunctionAddress, "ReturnValue");
		GetMaterialIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialIndex_FunctionAddress, "ReturnValue");
		GetMaterialIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMaterialIndex_IsValid = GetMaterialIndex_FunctionAddress != IntPtr.Zero && GetMaterialIndex_MaterialSlotName_IsValid && GetMaterialIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MeshComponent:GetMaterialIndex", GetMaterialIndex_IsValid);
	}
}
