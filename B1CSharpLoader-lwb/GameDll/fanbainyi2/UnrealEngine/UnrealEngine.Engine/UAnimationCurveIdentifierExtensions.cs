using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.AnimationCurveIdentifierExtensions", "Engine", UnrealModuleType.Engine)]
public class UAnimationCurveIdentifierExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsValid_IsValid;

	private static IntPtr IsValid_FunctionAddress;

	private static int IsValid_ParamsSize;

	private static bool IsValid_Identifier_IsValid;

	private static FFieldAddress IsValid_Identifier_PropertyAddress;

	private static int IsValid_Identifier_Offset;

	private static bool IsValid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_ReturnValue_PropertyAddress;

	private static int IsValid_ReturnValue_Offset;

	private static bool GetType_IsValid;

	private static IntPtr GetType_FunctionAddress;

	private static int GetType_ParamsSize;

	private static bool GetType_Identifier_IsValid;

	private static FFieldAddress GetType_Identifier_PropertyAddress;

	private static int GetType_Identifier_Offset;

	private static bool GetType_ReturnValue_IsValid;

	private static FFieldAddress GetType_ReturnValue_PropertyAddress;

	private static int GetType_ReturnValue_Offset;

	private static bool GetTransformChildCurveIdentifier_IsValid;

	private static IntPtr GetTransformChildCurveIdentifier_FunctionAddress;

	private static int GetTransformChildCurveIdentifier_ParamsSize;

	private static bool GetTransformChildCurveIdentifier_InOutIdentifier_IsValid;

	private static FFieldAddress GetTransformChildCurveIdentifier_InOutIdentifier_PropertyAddress;

	private static int GetTransformChildCurveIdentifier_InOutIdentifier_Offset;

	private static bool GetTransformChildCurveIdentifier_Channel_IsValid;

	private static FFieldAddress GetTransformChildCurveIdentifier_Channel_PropertyAddress;

	private static int GetTransformChildCurveIdentifier_Channel_Offset;

	private static bool GetTransformChildCurveIdentifier_Axis_IsValid;

	private static FFieldAddress GetTransformChildCurveIdentifier_Axis_PropertyAddress;

	private static int GetTransformChildCurveIdentifier_Axis_Offset;

	private static bool GetTransformChildCurveIdentifier_ReturnValue_IsValid;

	private static FFieldAddress GetTransformChildCurveIdentifier_ReturnValue_PropertyAddress;

	private static int GetTransformChildCurveIdentifier_ReturnValue_Offset;

	private static bool GetName_IsValid;

	private static IntPtr GetName_FunctionAddress;

	private static int GetName_ParamsSize;

	private static bool GetName_Identifier_IsValid;

	private static FFieldAddress GetName_Identifier_PropertyAddress;

	private static int GetName_Identifier_Offset;

	private static bool GetName_ReturnValue_IsValid;

	private static FFieldAddress GetName_ReturnValue_PropertyAddress;

	private static int GetName_ReturnValue_Offset;

	private static bool GetCurveIdentifiers_IsValid;

	private static IntPtr GetCurveIdentifiers_FunctionAddress;

	private static int GetCurveIdentifiers_ParamsSize;

	private static bool GetCurveIdentifiers_InSkeleton_IsValid;

	private static FFieldAddress GetCurveIdentifiers_InSkeleton_PropertyAddress;

	private static int GetCurveIdentifiers_InSkeleton_Offset;

	private static bool GetCurveIdentifiers_CurveType_IsValid;

	private static FFieldAddress GetCurveIdentifiers_CurveType_PropertyAddress;

	private static int GetCurveIdentifiers_CurveType_Offset;

	private static bool GetCurveIdentifiers_ReturnValue_IsValid;

	private static FFieldAddress GetCurveIdentifiers_ReturnValue_PropertyAddress;

	private static int GetCurveIdentifiers_ReturnValue_Offset;

	private static bool GetCurveIdentifier_IsValid;

	private static IntPtr GetCurveIdentifier_FunctionAddress;

	private static int GetCurveIdentifier_ParamsSize;

	private static bool GetCurveIdentifier_InSkeleton_IsValid;

	private static FFieldAddress GetCurveIdentifier_InSkeleton_PropertyAddress;

	private static int GetCurveIdentifier_InSkeleton_Offset;

	private static bool GetCurveIdentifier_Name_IsValid;

	private static FFieldAddress GetCurveIdentifier_Name_PropertyAddress;

	private static int GetCurveIdentifier_Name_Offset;

	private static bool GetCurveIdentifier_CurveType_IsValid;

	private static FFieldAddress GetCurveIdentifier_CurveType_PropertyAddress;

	private static int GetCurveIdentifier_CurveType_Offset;

	private static bool GetCurveIdentifier_ReturnValue_IsValid;

	private static FFieldAddress GetCurveIdentifier_ReturnValue_PropertyAddress;

	private static int GetCurveIdentifier_ReturnValue_Offset;

	private static bool FindCurveIdentifier_IsValid;

	private static IntPtr FindCurveIdentifier_FunctionAddress;

	private static int FindCurveIdentifier_ParamsSize;

	private static bool FindCurveIdentifier_InSkeleton_IsValid;

	private static FFieldAddress FindCurveIdentifier_InSkeleton_PropertyAddress;

	private static int FindCurveIdentifier_InSkeleton_Offset;

	private static bool FindCurveIdentifier_Name_IsValid;

	private static FFieldAddress FindCurveIdentifier_Name_PropertyAddress;

	private static int FindCurveIdentifier_Name_Offset;

	private static bool FindCurveIdentifier_CurveType_IsValid;

	private static FFieldAddress FindCurveIdentifier_CurveType_PropertyAddress;

	private static int FindCurveIdentifier_CurveType_Offset;

	private static bool FindCurveIdentifier_ReturnValue_IsValid;

	private static FFieldAddress FindCurveIdentifier_ReturnValue_PropertyAddress;

	private static int FindCurveIdentifier_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.AnimationCurveIdentifierExtensions:IsValid")]
	public unsafe static bool IsValid(ref FAnimationCurveIdentifier Identifier)
	{
		if (!IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationCurveIdentifierExtensions:IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsValid_Identifier_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, IsValid_Identifier_Offset), 0, IsValid_Identifier_PropertyAddress.Address, Identifier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_FunctionAddress, intPtr, IsValid_ParamsSize);
		Identifier = FAnimationCurveIdentifier.FromNative(IntPtr.Add(intPtr, IsValid_Identifier_Offset), 0, IsValid_Identifier_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_ReturnValue_Offset), 0, IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.AnimationCurveIdentifierExtensions:GetType")]
	public unsafe static ERawCurveTrackTypes GetType(ref FAnimationCurveIdentifier Identifier)
	{
		if (!GetType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationCurveIdentifierExtensions:GetType");
			return ERawCurveTrackTypes.RCT_Float;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetType_Identifier_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, GetType_Identifier_Offset), 0, GetType_Identifier_PropertyAddress.Address, Identifier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetType_FunctionAddress, intPtr, GetType_ParamsSize);
		Identifier = FAnimationCurveIdentifier.FromNative(IntPtr.Add(intPtr, GetType_Identifier_Offset), 0, GetType_Identifier_PropertyAddress.Address);
		return EnumMarshaler<ERawCurveTrackTypes>.FromNative(IntPtr.Add(intPtr, GetType_ReturnValue_Offset), 0, GetType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/Engine.AnimationCurveIdentifierExtensions:GetTransformChildCurveIdentifier")]
	public unsafe static bool GetTransformChildCurveIdentifier(ref FAnimationCurveIdentifier InOutIdentifier, ETransformCurveChannel Channel, EVectorCurveChannel Axis)
	{
		if (!GetTransformChildCurveIdentifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationCurveIdentifierExtensions:GetTransformChildCurveIdentifier");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformChildCurveIdentifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformChildCurveIdentifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTransformChildCurveIdentifier_InOutIdentifier_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, GetTransformChildCurveIdentifier_InOutIdentifier_Offset), 0, GetTransformChildCurveIdentifier_InOutIdentifier_PropertyAddress.Address, InOutIdentifier);
		EnumMarshaler<ETransformCurveChannel>.ToNative(IntPtr.Add(intPtr, GetTransformChildCurveIdentifier_Channel_Offset), 0, GetTransformChildCurveIdentifier_Channel_PropertyAddress.Address, Channel);
		EnumMarshaler<EVectorCurveChannel>.ToNative(IntPtr.Add(intPtr, GetTransformChildCurveIdentifier_Axis_Offset), 0, GetTransformChildCurveIdentifier_Axis_PropertyAddress.Address, Axis);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransformChildCurveIdentifier_FunctionAddress, intPtr, GetTransformChildCurveIdentifier_ParamsSize);
		InOutIdentifier = FAnimationCurveIdentifier.FromNative(IntPtr.Add(intPtr, GetTransformChildCurveIdentifier_InOutIdentifier_Offset), 0, GetTransformChildCurveIdentifier_InOutIdentifier_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTransformChildCurveIdentifier_ReturnValue_Offset), 0, GetTransformChildCurveIdentifier_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.AnimationCurveIdentifierExtensions:GetName")]
	public unsafe static FName GetName(ref FAnimationCurveIdentifier Identifier)
	{
		if (!GetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationCurveIdentifierExtensions:GetName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetName_Identifier_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, GetName_Identifier_Offset), 0, GetName_Identifier_PropertyAddress.Address, Identifier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetName_FunctionAddress, intPtr, GetName_ParamsSize);
		Identifier = FAnimationCurveIdentifier.FromNative(IntPtr.Add(intPtr, GetName_Identifier_Offset), 0, GetName_Identifier_PropertyAddress.Address);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetName_ReturnValue_Offset), 0, GetName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Engine.AnimationCurveIdentifierExtensions:GetCurveIdentifiers")]
	public unsafe static List<FAnimationCurveIdentifier> GetCurveIdentifiers(USkeleton InSkeleton, ERawCurveTrackTypes CurveType)
	{
		if (!GetCurveIdentifiers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationCurveIdentifierExtensions:GetCurveIdentifiers");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurveIdentifiers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurveIdentifiers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, GetCurveIdentifiers_InSkeleton_Offset), 0, GetCurveIdentifiers_InSkeleton_PropertyAddress.Address, InSkeleton);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, GetCurveIdentifiers_CurveType_Offset), 0, GetCurveIdentifiers_CurveType_PropertyAddress.Address, CurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurveIdentifiers_FunctionAddress, intPtr, GetCurveIdentifiers_ParamsSize);
		List<FAnimationCurveIdentifier> result = new TArrayCopyMarshaler<FAnimationCurveIdentifier>(1, GetCurveIdentifiers_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FAnimationCurveIdentifier, FAnimationCurveIdentifier>.FromNative, CachedMarshalingDelegates<FAnimationCurveIdentifier, FAnimationCurveIdentifier>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurveIdentifiers_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurveIdentifiers_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Engine.AnimationCurveIdentifierExtensions:GetCurveIdentifier")]
	public unsafe static FAnimationCurveIdentifier GetCurveIdentifier(USkeleton InSkeleton, FName Name, ERawCurveTrackTypes CurveType)
	{
		if (!GetCurveIdentifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationCurveIdentifierExtensions:GetCurveIdentifier");
			return default(FAnimationCurveIdentifier);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurveIdentifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurveIdentifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, GetCurveIdentifier_InSkeleton_Offset), 0, GetCurveIdentifier_InSkeleton_PropertyAddress.Address, InSkeleton);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCurveIdentifier_Name_Offset), 0, GetCurveIdentifier_Name_PropertyAddress.Address, Name);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, GetCurveIdentifier_CurveType_Offset), 0, GetCurveIdentifier_CurveType_PropertyAddress.Address, CurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurveIdentifier_FunctionAddress, intPtr, GetCurveIdentifier_ParamsSize);
		return FAnimationCurveIdentifier.FromNative(IntPtr.Add(intPtr, GetCurveIdentifier_ReturnValue_Offset), 0, GetCurveIdentifier_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/Engine.AnimationCurveIdentifierExtensions:FindCurveIdentifier")]
	public unsafe static FAnimationCurveIdentifier FindCurveIdentifier(USkeleton InSkeleton, FName Name, ERawCurveTrackTypes CurveType)
	{
		if (!FindCurveIdentifier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationCurveIdentifierExtensions:FindCurveIdentifier");
			return default(FAnimationCurveIdentifier);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindCurveIdentifier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindCurveIdentifier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, FindCurveIdentifier_InSkeleton_Offset), 0, FindCurveIdentifier_InSkeleton_PropertyAddress.Address, InSkeleton);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindCurveIdentifier_Name_Offset), 0, FindCurveIdentifier_Name_PropertyAddress.Address, Name);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, FindCurveIdentifier_CurveType_Offset), 0, FindCurveIdentifier_CurveType_PropertyAddress.Address, CurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindCurveIdentifier_FunctionAddress, intPtr, FindCurveIdentifier_ParamsSize);
		return FAnimationCurveIdentifier.FromNative(IntPtr.Add(intPtr, FindCurveIdentifier_ReturnValue_Offset), 0, FindCurveIdentifier_ReturnValue_PropertyAddress.Address);
	}

	static UAnimationCurveIdentifierExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationCurveIdentifierExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationCurveIdentifierExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.AnimationCurveIdentifierExtensions");
		IsValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid");
		IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_Identifier_PropertyAddress, IsValid_FunctionAddress, "Identifier");
		IsValid_Identifier_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "Identifier");
		IsValid_Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "Identifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_ReturnValue_PropertyAddress, IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_IsValid = IsValid_FunctionAddress != IntPtr.Zero && IsValid_Identifier_IsValid && IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationCurveIdentifierExtensions:IsValid", IsValid_IsValid);
		GetType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetType");
		GetType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetType_Identifier_PropertyAddress, GetType_FunctionAddress, "Identifier");
		GetType_Identifier_Offset = NativeReflectionCached.GetPropertyOffset(GetType_FunctionAddress, "Identifier");
		GetType_Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(GetType_FunctionAddress, "Identifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetType_ReturnValue_PropertyAddress, GetType_FunctionAddress, "ReturnValue");
		GetType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetType_FunctionAddress, "ReturnValue");
		GetType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetType_IsValid = GetType_FunctionAddress != IntPtr.Zero && GetType_Identifier_IsValid && GetType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationCurveIdentifierExtensions:GetType", GetType_IsValid);
		GetTransformChildCurveIdentifier_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransformChildCurveIdentifier");
		GetTransformChildCurveIdentifier_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformChildCurveIdentifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformChildCurveIdentifier_InOutIdentifier_PropertyAddress, GetTransformChildCurveIdentifier_FunctionAddress, "InOutIdentifier");
		GetTransformChildCurveIdentifier_InOutIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformChildCurveIdentifier_FunctionAddress, "InOutIdentifier");
		GetTransformChildCurveIdentifier_InOutIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformChildCurveIdentifier_FunctionAddress, "InOutIdentifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformChildCurveIdentifier_Channel_PropertyAddress, GetTransformChildCurveIdentifier_FunctionAddress, "Channel");
		GetTransformChildCurveIdentifier_Channel_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformChildCurveIdentifier_FunctionAddress, "Channel");
		GetTransformChildCurveIdentifier_Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformChildCurveIdentifier_FunctionAddress, "Channel", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformChildCurveIdentifier_Axis_PropertyAddress, GetTransformChildCurveIdentifier_FunctionAddress, "Axis");
		GetTransformChildCurveIdentifier_Axis_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformChildCurveIdentifier_FunctionAddress, "Axis");
		GetTransformChildCurveIdentifier_Axis_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformChildCurveIdentifier_FunctionAddress, "Axis", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformChildCurveIdentifier_ReturnValue_PropertyAddress, GetTransformChildCurveIdentifier_FunctionAddress, "ReturnValue");
		GetTransformChildCurveIdentifier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformChildCurveIdentifier_FunctionAddress, "ReturnValue");
		GetTransformChildCurveIdentifier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformChildCurveIdentifier_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTransformChildCurveIdentifier_IsValid = GetTransformChildCurveIdentifier_FunctionAddress != IntPtr.Zero && GetTransformChildCurveIdentifier_InOutIdentifier_IsValid && GetTransformChildCurveIdentifier_Channel_IsValid && GetTransformChildCurveIdentifier_Axis_IsValid && GetTransformChildCurveIdentifier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationCurveIdentifierExtensions:GetTransformChildCurveIdentifier", GetTransformChildCurveIdentifier_IsValid);
		GetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetName");
		GetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetName_Identifier_PropertyAddress, GetName_FunctionAddress, "Identifier");
		GetName_Identifier_Offset = NativeReflectionCached.GetPropertyOffset(GetName_FunctionAddress, "Identifier");
		GetName_Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(GetName_FunctionAddress, "Identifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetName_ReturnValue_PropertyAddress, GetName_FunctionAddress, "ReturnValue");
		GetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetName_FunctionAddress, "ReturnValue");
		GetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetName_IsValid = GetName_FunctionAddress != IntPtr.Zero && GetName_Identifier_IsValid && GetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationCurveIdentifierExtensions:GetName", GetName_IsValid);
		GetCurveIdentifiers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurveIdentifiers");
		GetCurveIdentifiers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurveIdentifiers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurveIdentifiers_InSkeleton_PropertyAddress, GetCurveIdentifiers_FunctionAddress, "InSkeleton");
		GetCurveIdentifiers_InSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveIdentifiers_FunctionAddress, "InSkeleton");
		GetCurveIdentifiers_InSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveIdentifiers_FunctionAddress, "InSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveIdentifiers_CurveType_PropertyAddress, GetCurveIdentifiers_FunctionAddress, "CurveType");
		GetCurveIdentifiers_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveIdentifiers_FunctionAddress, "CurveType");
		GetCurveIdentifiers_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveIdentifiers_FunctionAddress, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveIdentifiers_ReturnValue_PropertyAddress, GetCurveIdentifiers_FunctionAddress, "ReturnValue");
		GetCurveIdentifiers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveIdentifiers_FunctionAddress, "ReturnValue");
		GetCurveIdentifiers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveIdentifiers_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCurveIdentifiers_IsValid = GetCurveIdentifiers_FunctionAddress != IntPtr.Zero && GetCurveIdentifiers_InSkeleton_IsValid && GetCurveIdentifiers_CurveType_IsValid && GetCurveIdentifiers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationCurveIdentifierExtensions:GetCurveIdentifiers", GetCurveIdentifiers_IsValid);
		GetCurveIdentifier_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurveIdentifier");
		GetCurveIdentifier_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurveIdentifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurveIdentifier_InSkeleton_PropertyAddress, GetCurveIdentifier_FunctionAddress, "InSkeleton");
		GetCurveIdentifier_InSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveIdentifier_FunctionAddress, "InSkeleton");
		GetCurveIdentifier_InSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveIdentifier_FunctionAddress, "InSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveIdentifier_Name_PropertyAddress, GetCurveIdentifier_FunctionAddress, "Name");
		GetCurveIdentifier_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveIdentifier_FunctionAddress, "Name");
		GetCurveIdentifier_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveIdentifier_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveIdentifier_CurveType_PropertyAddress, GetCurveIdentifier_FunctionAddress, "CurveType");
		GetCurveIdentifier_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveIdentifier_FunctionAddress, "CurveType");
		GetCurveIdentifier_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveIdentifier_FunctionAddress, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveIdentifier_ReturnValue_PropertyAddress, GetCurveIdentifier_FunctionAddress, "ReturnValue");
		GetCurveIdentifier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveIdentifier_FunctionAddress, "ReturnValue");
		GetCurveIdentifier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveIdentifier_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurveIdentifier_IsValid = GetCurveIdentifier_FunctionAddress != IntPtr.Zero && GetCurveIdentifier_InSkeleton_IsValid && GetCurveIdentifier_Name_IsValid && GetCurveIdentifier_CurveType_IsValid && GetCurveIdentifier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationCurveIdentifierExtensions:GetCurveIdentifier", GetCurveIdentifier_IsValid);
		FindCurveIdentifier_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindCurveIdentifier");
		FindCurveIdentifier_ParamsSize = NativeReflection.GetFunctionParamsSize(FindCurveIdentifier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindCurveIdentifier_InSkeleton_PropertyAddress, FindCurveIdentifier_FunctionAddress, "InSkeleton");
		FindCurveIdentifier_InSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(FindCurveIdentifier_FunctionAddress, "InSkeleton");
		FindCurveIdentifier_InSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(FindCurveIdentifier_FunctionAddress, "InSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindCurveIdentifier_Name_PropertyAddress, FindCurveIdentifier_FunctionAddress, "Name");
		FindCurveIdentifier_Name_Offset = NativeReflectionCached.GetPropertyOffset(FindCurveIdentifier_FunctionAddress, "Name");
		FindCurveIdentifier_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(FindCurveIdentifier_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindCurveIdentifier_CurveType_PropertyAddress, FindCurveIdentifier_FunctionAddress, "CurveType");
		FindCurveIdentifier_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(FindCurveIdentifier_FunctionAddress, "CurveType");
		FindCurveIdentifier_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(FindCurveIdentifier_FunctionAddress, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FindCurveIdentifier_ReturnValue_PropertyAddress, FindCurveIdentifier_FunctionAddress, "ReturnValue");
		FindCurveIdentifier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindCurveIdentifier_FunctionAddress, "ReturnValue");
		FindCurveIdentifier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindCurveIdentifier_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindCurveIdentifier_IsValid = FindCurveIdentifier_FunctionAddress != IntPtr.Zero && FindCurveIdentifier_InSkeleton_IsValid && FindCurveIdentifier_Name_IsValid && FindCurveIdentifier_CurveType_IsValid && FindCurveIdentifier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationCurveIdentifierExtensions:FindCurveIdentifier", FindCurveIdentifier_IsValid);
	}
}
