using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/Engine.KismetMaterialLibrary", "Engine", UnrealModuleType.Engine)]
public class UMaterialLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetVectorParameterValue_IsValid;

	private static IntPtr SetVectorParameterValue_FunctionAddress;

	private static int SetVectorParameterValue_ParamsSize;

	private static bool SetVectorParameterValue_WorldContextObject_IsValid;

	private static FFieldAddress SetVectorParameterValue_WorldContextObject_PropertyAddress;

	private static int SetVectorParameterValue_WorldContextObject_Offset;

	private static bool SetVectorParameterValue_Collection_IsValid;

	private static FFieldAddress SetVectorParameterValue_Collection_PropertyAddress;

	private static int SetVectorParameterValue_Collection_Offset;

	private static bool SetVectorParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetVectorParameterValue_ParameterName_PropertyAddress;

	private static int SetVectorParameterValue_ParameterName_Offset;

	private static bool SetVectorParameterValue_ParameterValue_IsValid;

	private static FFieldAddress SetVectorParameterValue_ParameterValue_PropertyAddress;

	private static int SetVectorParameterValue_ParameterValue_Offset;

	private static bool SetScalarParameterValue_IsValid;

	private static IntPtr SetScalarParameterValue_FunctionAddress;

	private static int SetScalarParameterValue_ParamsSize;

	private static bool SetScalarParameterValue_WorldContextObject_IsValid;

	private static FFieldAddress SetScalarParameterValue_WorldContextObject_PropertyAddress;

	private static int SetScalarParameterValue_WorldContextObject_Offset;

	private static bool SetScalarParameterValue_Collection_IsValid;

	private static FFieldAddress SetScalarParameterValue_Collection_PropertyAddress;

	private static int SetScalarParameterValue_Collection_Offset;

	private static bool SetScalarParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetScalarParameterValue_ParameterName_PropertyAddress;

	private static int SetScalarParameterValue_ParameterName_Offset;

	private static bool SetScalarParameterValue_ParameterValue_IsValid;

	private static FFieldAddress SetScalarParameterValue_ParameterValue_PropertyAddress;

	private static int SetScalarParameterValue_ParameterValue_Offset;

	private static bool GetVectorParameterValue_IsValid;

	private static IntPtr GetVectorParameterValue_FunctionAddress;

	private static int GetVectorParameterValue_ParamsSize;

	private static bool GetVectorParameterValue_WorldContextObject_IsValid;

	private static FFieldAddress GetVectorParameterValue_WorldContextObject_PropertyAddress;

	private static int GetVectorParameterValue_WorldContextObject_Offset;

	private static bool GetVectorParameterValue_Collection_IsValid;

	private static FFieldAddress GetVectorParameterValue_Collection_PropertyAddress;

	private static int GetVectorParameterValue_Collection_Offset;

	private static bool GetVectorParameterValue_ParameterName_IsValid;

	private static FFieldAddress GetVectorParameterValue_ParameterName_PropertyAddress;

	private static int GetVectorParameterValue_ParameterName_Offset;

	private static bool GetVectorParameterValue_ReturnValue_IsValid;

	private static FFieldAddress GetVectorParameterValue_ReturnValue_PropertyAddress;

	private static int GetVectorParameterValue_ReturnValue_Offset;

	private static bool GetScalarParameterValue_IsValid;

	private static IntPtr GetScalarParameterValue_FunctionAddress;

	private static int GetScalarParameterValue_ParamsSize;

	private static bool GetScalarParameterValue_WorldContextObject_IsValid;

	private static FFieldAddress GetScalarParameterValue_WorldContextObject_PropertyAddress;

	private static int GetScalarParameterValue_WorldContextObject_Offset;

	private static bool GetScalarParameterValue_Collection_IsValid;

	private static FFieldAddress GetScalarParameterValue_Collection_PropertyAddress;

	private static int GetScalarParameterValue_Collection_Offset;

	private static bool GetScalarParameterValue_ParameterName_IsValid;

	private static FFieldAddress GetScalarParameterValue_ParameterName_PropertyAddress;

	private static int GetScalarParameterValue_ParameterName_Offset;

	private static bool GetScalarParameterValue_ReturnValue_IsValid;

	private static FFieldAddress GetScalarParameterValue_ReturnValue_PropertyAddress;

	private static int GetScalarParameterValue_ReturnValue_Offset;

	private static bool CreateDynamicMaterialInstance_IsValid;

	private static IntPtr CreateDynamicMaterialInstance_FunctionAddress;

	private static int CreateDynamicMaterialInstance_ParamsSize;

	private static bool CreateDynamicMaterialInstance_WorldContextObject_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_WorldContextObject_PropertyAddress;

	private static int CreateDynamicMaterialInstance_WorldContextObject_Offset;

	private static bool CreateDynamicMaterialInstance_Parent_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_Parent_PropertyAddress;

	private static int CreateDynamicMaterialInstance_Parent_Offset;

	private static bool CreateDynamicMaterialInstance_OptionalName_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_OptionalName_PropertyAddress;

	private static int CreateDynamicMaterialInstance_OptionalName_Offset;

	private static bool CreateDynamicMaterialInstance_CreationFlags_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_CreationFlags_PropertyAddress;

	private static int CreateDynamicMaterialInstance_CreationFlags_Offset;

	private static bool CreateDynamicMaterialInstance_ReturnValue_IsValid;

	private static FFieldAddress CreateDynamicMaterialInstance_ReturnValue_PropertyAddress;

	private static int CreateDynamicMaterialInstance_ReturnValue_Offset;

	[UFunction(Flags = 79832067u)]
	[UMetaPath("/Script/Engine.KismetMaterialLibrary:SetVectorParameterValue")]
	public unsafe static void SetVectorParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, FLinearColor ParameterValue)
	{
		if (!SetVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetMaterialLibrary:SetVectorParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetVectorParameterValue_WorldContextObject_Offset), 0, SetVectorParameterValue_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(intPtr, SetVectorParameterValue_Collection_Offset), 0, SetVectorParameterValue_Collection_PropertyAddress.Address, Collection);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorParameterValue_ParameterName_Offset), 0, SetVectorParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetVectorParameterValue_ParameterValue_Offset), 0, SetVectorParameterValue_ParameterValue_PropertyAddress.Address, ParameterValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVectorParameterValue_FunctionAddress, intPtr, SetVectorParameterValue_ParamsSize);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetMaterialLibrary:SetScalarParameterValue")]
	public unsafe static void SetScalarParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, float ParameterValue)
	{
		if (!SetScalarParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetMaterialLibrary:SetScalarParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalarParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalarParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetScalarParameterValue_WorldContextObject_Offset), 0, SetScalarParameterValue_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(intPtr, SetScalarParameterValue_Collection_Offset), 0, SetScalarParameterValue_Collection_PropertyAddress.Address, Collection);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetScalarParameterValue_ParameterName_Offset), 0, SetScalarParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScalarParameterValue_ParameterValue_Offset), 0, SetScalarParameterValue_ParameterValue_PropertyAddress.Address, ParameterValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetScalarParameterValue_FunctionAddress, intPtr, SetScalarParameterValue_ParamsSize);
	}

	[UFunction(Flags = 75637763u)]
	[UMetaPath("/Script/Engine.KismetMaterialLibrary:GetVectorParameterValue")]
	public unsafe static FLinearColor GetVectorParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
	{
		if (!GetVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetMaterialLibrary:GetVectorParameterValue");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetVectorParameterValue_WorldContextObject_Offset), 0, GetVectorParameterValue_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(intPtr, GetVectorParameterValue_Collection_Offset), 0, GetVectorParameterValue_Collection_PropertyAddress.Address, Collection);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorParameterValue_ParameterName_Offset), 0, GetVectorParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVectorParameterValue_FunctionAddress, intPtr, GetVectorParameterValue_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetVectorParameterValue_ReturnValue_Offset), 0, GetVectorParameterValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetMaterialLibrary:GetScalarParameterValue")]
	public unsafe static float GetScalarParameterValue(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
	{
		if (!GetScalarParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetMaterialLibrary:GetScalarParameterValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScalarParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScalarParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetScalarParameterValue_WorldContextObject_Offset), 0, GetScalarParameterValue_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(intPtr, GetScalarParameterValue_Collection_Offset), 0, GetScalarParameterValue_Collection_PropertyAddress.Address, Collection);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetScalarParameterValue_ParameterName_Offset), 0, GetScalarParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetScalarParameterValue_FunctionAddress, intPtr, GetScalarParameterValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScalarParameterValue_ReturnValue_Offset), 0, GetScalarParameterValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249155u)]
	[UMetaPath("/Script/Engine.KismetMaterialLibrary:CreateDynamicMaterialInstance")]
	public unsafe static UMaterialInstanceDynamic CreateDynamicMaterialInstance(UObject WorldContextObject, UMaterialInterface Parent, FName OptionalName, EMIDCreationFlags CreationFlags)
	{
		if (!CreateDynamicMaterialInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetMaterialLibrary:CreateDynamicMaterialInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateDynamicMaterialInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateDynamicMaterialInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_WorldContextObject_Offset), 0, CreateDynamicMaterialInstance_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_Parent_Offset), 0, CreateDynamicMaterialInstance_Parent_PropertyAddress.Address, Parent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_OptionalName_Offset), 0, CreateDynamicMaterialInstance_OptionalName_PropertyAddress.Address, OptionalName);
		EnumMarshaler<EMIDCreationFlags>.ToNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_CreationFlags_Offset), 0, CreateDynamicMaterialInstance_CreationFlags_PropertyAddress.Address, CreationFlags);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateDynamicMaterialInstance_FunctionAddress, intPtr, CreateDynamicMaterialInstance_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, CreateDynamicMaterialInstance_ReturnValue_Offset), 0, CreateDynamicMaterialInstance_ReturnValue_PropertyAddress.Address);
	}

	static UMaterialLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.KismetMaterialLibrary");
		SetVectorParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVectorParameterValue");
		SetVectorParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValue_WorldContextObject_PropertyAddress, SetVectorParameterValue_FunctionAddress, "WorldContextObject");
		SetVectorParameterValue_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValue_FunctionAddress, "WorldContextObject");
		SetVectorParameterValue_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValue_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValue_Collection_PropertyAddress, SetVectorParameterValue_FunctionAddress, "Collection");
		SetVectorParameterValue_Collection_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValue_FunctionAddress, "Collection");
		SetVectorParameterValue_Collection_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValue_FunctionAddress, "Collection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValue_ParameterName_PropertyAddress, SetVectorParameterValue_FunctionAddress, "ParameterName");
		SetVectorParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValue_FunctionAddress, "ParameterName");
		SetVectorParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValue_ParameterValue_PropertyAddress, SetVectorParameterValue_FunctionAddress, "ParameterValue");
		SetVectorParameterValue_ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValue_FunctionAddress, "ParameterValue");
		SetVectorParameterValue_ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValue_FunctionAddress, "ParameterValue", Classes.FStructProperty);
		SetVectorParameterValue_IsValid = SetVectorParameterValue_FunctionAddress != IntPtr.Zero && SetVectorParameterValue_WorldContextObject_IsValid && SetVectorParameterValue_Collection_IsValid && SetVectorParameterValue_ParameterName_IsValid && SetVectorParameterValue_ParameterValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetMaterialLibrary:SetVectorParameterValue", SetVectorParameterValue_IsValid);
		SetScalarParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetScalarParameterValue");
		SetScalarParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalarParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValue_WorldContextObject_PropertyAddress, SetScalarParameterValue_FunctionAddress, "WorldContextObject");
		SetScalarParameterValue_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValue_FunctionAddress, "WorldContextObject");
		SetScalarParameterValue_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValue_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValue_Collection_PropertyAddress, SetScalarParameterValue_FunctionAddress, "Collection");
		SetScalarParameterValue_Collection_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValue_FunctionAddress, "Collection");
		SetScalarParameterValue_Collection_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValue_FunctionAddress, "Collection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValue_ParameterName_PropertyAddress, SetScalarParameterValue_FunctionAddress, "ParameterName");
		SetScalarParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValue_FunctionAddress, "ParameterName");
		SetScalarParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValue_ParameterValue_PropertyAddress, SetScalarParameterValue_FunctionAddress, "ParameterValue");
		SetScalarParameterValue_ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValue_FunctionAddress, "ParameterValue");
		SetScalarParameterValue_ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValue_FunctionAddress, "ParameterValue", Classes.FFloatProperty);
		SetScalarParameterValue_IsValid = SetScalarParameterValue_FunctionAddress != IntPtr.Zero && SetScalarParameterValue_WorldContextObject_IsValid && SetScalarParameterValue_Collection_IsValid && SetScalarParameterValue_ParameterName_IsValid && SetScalarParameterValue_ParameterValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetMaterialLibrary:SetScalarParameterValue", SetScalarParameterValue_IsValid);
		GetVectorParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVectorParameterValue");
		GetVectorParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValue_WorldContextObject_PropertyAddress, GetVectorParameterValue_FunctionAddress, "WorldContextObject");
		GetVectorParameterValue_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValue_FunctionAddress, "WorldContextObject");
		GetVectorParameterValue_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValue_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValue_Collection_PropertyAddress, GetVectorParameterValue_FunctionAddress, "Collection");
		GetVectorParameterValue_Collection_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValue_FunctionAddress, "Collection");
		GetVectorParameterValue_Collection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValue_FunctionAddress, "Collection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValue_ParameterName_PropertyAddress, GetVectorParameterValue_FunctionAddress, "ParameterName");
		GetVectorParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValue_FunctionAddress, "ParameterName");
		GetVectorParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValue_ReturnValue_PropertyAddress, GetVectorParameterValue_FunctionAddress, "ReturnValue");
		GetVectorParameterValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValue_FunctionAddress, "ReturnValue");
		GetVectorParameterValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorParameterValue_IsValid = GetVectorParameterValue_FunctionAddress != IntPtr.Zero && GetVectorParameterValue_WorldContextObject_IsValid && GetVectorParameterValue_Collection_IsValid && GetVectorParameterValue_ParameterName_IsValid && GetVectorParameterValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetMaterialLibrary:GetVectorParameterValue", GetVectorParameterValue_IsValid);
		GetScalarParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetScalarParameterValue");
		GetScalarParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScalarParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValue_WorldContextObject_PropertyAddress, GetScalarParameterValue_FunctionAddress, "WorldContextObject");
		GetScalarParameterValue_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValue_FunctionAddress, "WorldContextObject");
		GetScalarParameterValue_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValue_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValue_Collection_PropertyAddress, GetScalarParameterValue_FunctionAddress, "Collection");
		GetScalarParameterValue_Collection_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValue_FunctionAddress, "Collection");
		GetScalarParameterValue_Collection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValue_FunctionAddress, "Collection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValue_ParameterName_PropertyAddress, GetScalarParameterValue_FunctionAddress, "ParameterName");
		GetScalarParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValue_FunctionAddress, "ParameterName");
		GetScalarParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValue_ReturnValue_PropertyAddress, GetScalarParameterValue_FunctionAddress, "ReturnValue");
		GetScalarParameterValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValue_FunctionAddress, "ReturnValue");
		GetScalarParameterValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScalarParameterValue_IsValid = GetScalarParameterValue_FunctionAddress != IntPtr.Zero && GetScalarParameterValue_WorldContextObject_IsValid && GetScalarParameterValue_Collection_IsValid && GetScalarParameterValue_ParameterName_IsValid && GetScalarParameterValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetMaterialLibrary:GetScalarParameterValue", GetScalarParameterValue_IsValid);
		CreateDynamicMaterialInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateDynamicMaterialInstance");
		CreateDynamicMaterialInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateDynamicMaterialInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_WorldContextObject_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "WorldContextObject");
		CreateDynamicMaterialInstance_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "WorldContextObject");
		CreateDynamicMaterialInstance_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_Parent_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "Parent");
		CreateDynamicMaterialInstance_Parent_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "Parent");
		CreateDynamicMaterialInstance_Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "Parent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_OptionalName_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "OptionalName");
		CreateDynamicMaterialInstance_OptionalName_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "OptionalName");
		CreateDynamicMaterialInstance_OptionalName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "OptionalName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_CreationFlags_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "CreationFlags");
		CreateDynamicMaterialInstance_CreationFlags_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "CreationFlags");
		CreateDynamicMaterialInstance_CreationFlags_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "CreationFlags", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDynamicMaterialInstance_ReturnValue_PropertyAddress, CreateDynamicMaterialInstance_FunctionAddress, "ReturnValue");
		CreateDynamicMaterialInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateDynamicMaterialInstance_FunctionAddress, "ReturnValue");
		CreateDynamicMaterialInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDynamicMaterialInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateDynamicMaterialInstance_IsValid = CreateDynamicMaterialInstance_FunctionAddress != IntPtr.Zero && CreateDynamicMaterialInstance_WorldContextObject_IsValid && CreateDynamicMaterialInstance_Parent_IsValid && CreateDynamicMaterialInstance_OptionalName_IsValid && CreateDynamicMaterialInstance_CreationFlags_IsValid && CreateDynamicMaterialInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetMaterialLibrary:CreateDynamicMaterialInstance", CreateDynamicMaterialInstance_IsValid);
	}
}
