using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFunctionLibCollisionChannel", "b1", UnrealModuleType.Game)]
public class UBGUFunctionLibCollisionChannel : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetCollisionProfileData_IsValid;

	private static IntPtr GetCollisionProfileData_FunctionAddress;

	private static int GetCollisionProfileData_ParamsSize;

	private static bool GetCollisionProfileData_Comp_IsValid;

	private static FFieldAddress GetCollisionProfileData_Comp_PropertyAddress;

	private static int GetCollisionProfileData_Comp_Offset;

	private static bool GetCollisionProfileData_ProfileName_IsValid;

	private static FFieldAddress GetCollisionProfileData_ProfileName_PropertyAddress;

	private static int GetCollisionProfileData_ProfileName_Offset;

	private static bool GetCollisionProfileData_OutCollisionEnabled_IsValid;

	private static FFieldAddress GetCollisionProfileData_OutCollisionEnabled_PropertyAddress;

	private static int GetCollisionProfileData_OutCollisionEnabled_Offset;

	private static bool GetCollisionProfileData_OutObjectType_IsValid;

	private static FFieldAddress GetCollisionProfileData_OutObjectType_PropertyAddress;

	private static int GetCollisionProfileData_OutObjectType_Offset;

	private static bool GetCollisionProfileData_OutResponseToChannels_IsValid;

	private static FFieldAddress GetCollisionProfileData_OutResponseToChannels_PropertyAddress;

	private static int GetCollisionProfileData_OutResponseToChannels_Offset;

	private static bool GetCollisionProfileData_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionProfileData_ReturnValue_PropertyAddress;

	private static int GetCollisionProfileData_ReturnValue_Offset;

	private static bool ConvertToTraceType_IsValid;

	private static IntPtr ConvertToTraceType_FunctionAddress;

	private static int ConvertToTraceType_ParamsSize;

	private static bool ConvertToTraceType_CollisionChannel_IsValid;

	private static FFieldAddress ConvertToTraceType_CollisionChannel_PropertyAddress;

	private static int ConvertToTraceType_CollisionChannel_Offset;

	private static bool ConvertToTraceType_ReturnValue_IsValid;

	private static FFieldAddress ConvertToTraceType_ReturnValue_PropertyAddress;

	private static int ConvertToTraceType_ReturnValue_Offset;

	private static bool ConvertToObjectType_IsValid;

	private static IntPtr ConvertToObjectType_FunctionAddress;

	private static int ConvertToObjectType_ParamsSize;

	private static bool ConvertToObjectType_CollisionChannel_IsValid;

	private static FFieldAddress ConvertToObjectType_CollisionChannel_PropertyAddress;

	private static int ConvertToObjectType_CollisionChannel_Offset;

	private static bool ConvertToObjectType_ReturnValue_IsValid;

	private static FFieldAddress ConvertToObjectType_ReturnValue_PropertyAddress;

	private static int ConvertToObjectType_ReturnValue_Offset;

	private static bool ConvertToCollisionChannelByTraceType_IsValid;

	private static IntPtr ConvertToCollisionChannelByTraceType_FunctionAddress;

	private static int ConvertToCollisionChannelByTraceType_ParamsSize;

	private static bool ConvertToCollisionChannelByTraceType_TraceType_IsValid;

	private static FFieldAddress ConvertToCollisionChannelByTraceType_TraceType_PropertyAddress;

	private static int ConvertToCollisionChannelByTraceType_TraceType_Offset;

	private static bool ConvertToCollisionChannelByTraceType_ReturnValue_IsValid;

	private static FFieldAddress ConvertToCollisionChannelByTraceType_ReturnValue_PropertyAddress;

	private static int ConvertToCollisionChannelByTraceType_ReturnValue_Offset;

	private static bool ConvertToCollisionChannelByObjectType_IsValid;

	private static IntPtr ConvertToCollisionChannelByObjectType_FunctionAddress;

	private static int ConvertToCollisionChannelByObjectType_ParamsSize;

	private static bool ConvertToCollisionChannelByObjectType_ObjectType_IsValid;

	private static FFieldAddress ConvertToCollisionChannelByObjectType_ObjectType_PropertyAddress;

	private static int ConvertToCollisionChannelByObjectType_ObjectType_Offset;

	private static bool ConvertToCollisionChannelByObjectType_ReturnValue_IsValid;

	private static FFieldAddress ConvertToCollisionChannelByObjectType_ReturnValue_PropertyAddress;

	private static int ConvertToCollisionChannelByObjectType_ReturnValue_Offset;

	private static bool BGUSetCollisionResponseToChannels_IsValid;

	private static IntPtr BGUSetCollisionResponseToChannels_FunctionAddress;

	private static int BGUSetCollisionResponseToChannels_ParamsSize;

	private static bool BGUSetCollisionResponseToChannels_Comp_IsValid;

	private static FFieldAddress BGUSetCollisionResponseToChannels_Comp_PropertyAddress;

	private static int BGUSetCollisionResponseToChannels_Comp_Offset;

	private static bool BGUSetCollisionResponseToChannels_ResponseToChannels_IsValid;

	private static FFieldAddress BGUSetCollisionResponseToChannels_ResponseToChannels_PropertyAddress;

	private static int BGUSetCollisionResponseToChannels_ResponseToChannels_Offset;

	private static bool BGUGetCollisionResponseToChannels_IsValid;

	private static IntPtr BGUGetCollisionResponseToChannels_FunctionAddress;

	private static int BGUGetCollisionResponseToChannels_ParamsSize;

	private static bool BGUGetCollisionResponseToChannels_Comp_IsValid;

	private static FFieldAddress BGUGetCollisionResponseToChannels_Comp_PropertyAddress;

	private static int BGUGetCollisionResponseToChannels_Comp_Offset;

	private static bool BGUGetCollisionResponseToChannels_OutResponseToChannels_IsValid;

	private static FFieldAddress BGUGetCollisionResponseToChannels_OutResponseToChannels_PropertyAddress;

	private static int BGUGetCollisionResponseToChannels_OutResponseToChannels_Offset;

	private static bool BGUGetCollisionResponseToChannels_ReturnValue_IsValid;

	private static FFieldAddress BGUGetCollisionResponseToChannels_ReturnValue_PropertyAddress;

	private static int BGUGetCollisionResponseToChannels_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/b1.BGUFunctionLibCollisionChannel:GetCollisionProfileData")]
	public unsafe static bool GetCollisionProfileData(UPrimitiveComponent Comp, FName ProfileName, out ECollisionEnabled OutCollisionEnabled, out ECollisionChannel OutObjectType, out Dictionary<ECollisionChannel, ECollisionResponseType> OutResponseToChannels)
	{
		if (!GetCollisionProfileData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibCollisionChannel:GetCollisionProfileData");
			OutCollisionEnabled = ECollisionEnabled.NoCollision;
			OutObjectType = ECollisionChannel.ECC_WorldStatic;
			OutResponseToChannels = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionProfileData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionProfileData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, GetCollisionProfileData_Comp_Offset), 0, GetCollisionProfileData_Comp_PropertyAddress.Address, Comp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCollisionProfileData_ProfileName_Offset), 0, GetCollisionProfileData_ProfileName_PropertyAddress.Address, ProfileName);
		NativeReflection.InitializeValue_InContainer(GetCollisionProfileData_OutResponseToChannels_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCollisionProfileData_FunctionAddress, intPtr, GetCollisionProfileData_ParamsSize);
		OutCollisionEnabled = EnumMarshaler<ECollisionEnabled>.FromNative(IntPtr.Add(intPtr, GetCollisionProfileData_OutCollisionEnabled_Offset), 0, GetCollisionProfileData_OutCollisionEnabled_PropertyAddress.Address);
		OutObjectType = EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(intPtr, GetCollisionProfileData_OutObjectType_Offset), 0, GetCollisionProfileData_OutObjectType_PropertyAddress.Address);
		OutResponseToChannels = new TMapCopyMarshaler<ECollisionChannel, ECollisionResponseType>(1, GetCollisionProfileData_OutResponseToChannels_PropertyAddress, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.FromNative, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.ToNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.FromNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCollisionProfileData_OutResponseToChannels_Offset));
		NativeReflection.DestroyValue_InContainer(GetCollisionProfileData_OutResponseToChannels_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCollisionProfileData_ReturnValue_Offset), 0, GetCollisionProfileData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToTraceType")]
	public unsafe static ETraceTypeQuery ConvertToTraceType(ECollisionChannel CollisionChannel)
	{
		if (!ConvertToTraceType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToTraceType");
			return ETraceTypeQuery.TraceTypeQuery1;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToTraceType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToTraceType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, ConvertToTraceType_CollisionChannel_Offset), 0, ConvertToTraceType_CollisionChannel_PropertyAddress.Address, CollisionChannel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToTraceType_FunctionAddress, intPtr, ConvertToTraceType_ParamsSize);
		return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(intPtr, ConvertToTraceType_ReturnValue_Offset), 0, ConvertToTraceType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToObjectType")]
	public unsafe static EObjectTypeQuery ConvertToObjectType(ECollisionChannel CollisionChannel)
	{
		if (!ConvertToObjectType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToObjectType");
			return EObjectTypeQuery.ObjectTypeQuery1;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToObjectType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToObjectType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, ConvertToObjectType_CollisionChannel_Offset), 0, ConvertToObjectType_CollisionChannel_PropertyAddress.Address, CollisionChannel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToObjectType_FunctionAddress, intPtr, ConvertToObjectType_ParamsSize);
		return EnumMarshaler<EObjectTypeQuery>.FromNative(IntPtr.Add(intPtr, ConvertToObjectType_ReturnValue_Offset), 0, ConvertToObjectType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToCollisionChannelByTraceType")]
	public unsafe static ECollisionChannel ConvertToCollisionChannelByTraceType(ETraceTypeQuery TraceType)
	{
		if (!ConvertToCollisionChannelByTraceType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToCollisionChannelByTraceType");
			return ECollisionChannel.ECC_WorldStatic;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToCollisionChannelByTraceType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToCollisionChannelByTraceType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(intPtr, ConvertToCollisionChannelByTraceType_TraceType_Offset), 0, ConvertToCollisionChannelByTraceType_TraceType_PropertyAddress.Address, TraceType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToCollisionChannelByTraceType_FunctionAddress, intPtr, ConvertToCollisionChannelByTraceType_ParamsSize);
		return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(intPtr, ConvertToCollisionChannelByTraceType_ReturnValue_Offset), 0, ConvertToCollisionChannelByTraceType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToCollisionChannelByObjectType")]
	public unsafe static ECollisionChannel ConvertToCollisionChannelByObjectType(EObjectTypeQuery ObjectType)
	{
		if (!ConvertToCollisionChannelByObjectType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToCollisionChannelByObjectType");
			return ECollisionChannel.ECC_WorldStatic;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToCollisionChannelByObjectType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToCollisionChannelByObjectType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EObjectTypeQuery>.ToNative(IntPtr.Add(intPtr, ConvertToCollisionChannelByObjectType_ObjectType_Offset), 0, ConvertToCollisionChannelByObjectType_ObjectType_PropertyAddress.Address, ObjectType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToCollisionChannelByObjectType_FunctionAddress, intPtr, ConvertToCollisionChannelByObjectType_ParamsSize);
		return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(intPtr, ConvertToCollisionChannelByObjectType_ReturnValue_Offset), 0, ConvertToCollisionChannelByObjectType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibCollisionChannel:BGUSetCollisionResponseToChannels")]
	public unsafe static void BGUSetCollisionResponseToChannels(UPrimitiveComponent Comp, Dictionary<ECollisionChannel, ECollisionResponseType> ResponseToChannels)
	{
		if (!BGUSetCollisionResponseToChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibCollisionChannel:BGUSetCollisionResponseToChannels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetCollisionResponseToChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetCollisionResponseToChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUSetCollisionResponseToChannels_Comp_Offset), 0, BGUSetCollisionResponseToChannels_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InitializeValue_InContainer(BGUSetCollisionResponseToChannels_ResponseToChannels_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<ECollisionChannel, ECollisionResponseType>(1, BGUSetCollisionResponseToChannels_ResponseToChannels_PropertyAddress, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.FromNative, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.ToNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.FromNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.ToNative).ToNative(IntPtr.Add(intPtr, BGUSetCollisionResponseToChannels_ResponseToChannels_Offset), ResponseToChannels);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetCollisionResponseToChannels_FunctionAddress, intPtr, BGUSetCollisionResponseToChannels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUSetCollisionResponseToChannels_ResponseToChannels_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibCollisionChannel:BGUGetCollisionResponseToChannels")]
	public unsafe static bool BGUGetCollisionResponseToChannels(UPrimitiveComponent Comp, out Dictionary<ECollisionChannel, ECollisionResponseType> OutResponseToChannels)
	{
		if (!BGUGetCollisionResponseToChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibCollisionChannel:BGUGetCollisionResponseToChannels");
			OutResponseToChannels = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetCollisionResponseToChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetCollisionResponseToChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUGetCollisionResponseToChannels_Comp_Offset), 0, BGUGetCollisionResponseToChannels_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InitializeValue_InContainer(BGUGetCollisionResponseToChannels_OutResponseToChannels_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetCollisionResponseToChannels_FunctionAddress, intPtr, BGUGetCollisionResponseToChannels_ParamsSize);
		OutResponseToChannels = new TMapCopyMarshaler<ECollisionChannel, ECollisionResponseType>(1, BGUGetCollisionResponseToChannels_OutResponseToChannels_PropertyAddress, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.FromNative, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.ToNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.FromNative, CachedMarshalingDelegates<ECollisionResponseType, EnumMarshaler<ECollisionResponseType>>.ToNative).FromNative(IntPtr.Add(intPtr, BGUGetCollisionResponseToChannels_OutResponseToChannels_Offset));
		NativeReflection.DestroyValue_InContainer(BGUGetCollisionResponseToChannels_OutResponseToChannels_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetCollisionResponseToChannels_ReturnValue_Offset), 0, BGUGetCollisionResponseToChannels_ReturnValue_PropertyAddress.Address);
	}

	static UBGUFunctionLibCollisionChannel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFunctionLibCollisionChannel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFunctionLibCollisionChannel));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFunctionLibCollisionChannel");
		GetCollisionProfileData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCollisionProfileData");
		GetCollisionProfileData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionProfileData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionProfileData_Comp_PropertyAddress, GetCollisionProfileData_FunctionAddress, "Comp");
		GetCollisionProfileData_Comp_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionProfileData_FunctionAddress, "Comp");
		GetCollisionProfileData_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionProfileData_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionProfileData_ProfileName_PropertyAddress, GetCollisionProfileData_FunctionAddress, "ProfileName");
		GetCollisionProfileData_ProfileName_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionProfileData_FunctionAddress, "ProfileName");
		GetCollisionProfileData_ProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionProfileData_FunctionAddress, "ProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionProfileData_OutCollisionEnabled_PropertyAddress, GetCollisionProfileData_FunctionAddress, "OutCollisionEnabled");
		GetCollisionProfileData_OutCollisionEnabled_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionProfileData_FunctionAddress, "OutCollisionEnabled");
		GetCollisionProfileData_OutCollisionEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionProfileData_FunctionAddress, "OutCollisionEnabled", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionProfileData_OutObjectType_PropertyAddress, GetCollisionProfileData_FunctionAddress, "OutObjectType");
		GetCollisionProfileData_OutObjectType_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionProfileData_FunctionAddress, "OutObjectType");
		GetCollisionProfileData_OutObjectType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionProfileData_FunctionAddress, "OutObjectType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionProfileData_OutResponseToChannels_PropertyAddress, GetCollisionProfileData_FunctionAddress, "OutResponseToChannels");
		GetCollisionProfileData_OutResponseToChannels_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionProfileData_FunctionAddress, "OutResponseToChannels");
		GetCollisionProfileData_OutResponseToChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionProfileData_FunctionAddress, "OutResponseToChannels", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionProfileData_ReturnValue_PropertyAddress, GetCollisionProfileData_FunctionAddress, "ReturnValue");
		GetCollisionProfileData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionProfileData_FunctionAddress, "ReturnValue");
		GetCollisionProfileData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionProfileData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCollisionProfileData_IsValid = GetCollisionProfileData_FunctionAddress != IntPtr.Zero && GetCollisionProfileData_Comp_IsValid && GetCollisionProfileData_ProfileName_IsValid && GetCollisionProfileData_OutCollisionEnabled_IsValid && GetCollisionProfileData_OutObjectType_IsValid && GetCollisionProfileData_OutResponseToChannels_IsValid && GetCollisionProfileData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibCollisionChannel:GetCollisionProfileData", GetCollisionProfileData_IsValid);
		ConvertToTraceType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToTraceType");
		ConvertToTraceType_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToTraceType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTraceType_CollisionChannel_PropertyAddress, ConvertToTraceType_FunctionAddress, "CollisionChannel");
		ConvertToTraceType_CollisionChannel_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTraceType_FunctionAddress, "CollisionChannel");
		ConvertToTraceType_CollisionChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTraceType_FunctionAddress, "CollisionChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTraceType_ReturnValue_PropertyAddress, ConvertToTraceType_FunctionAddress, "ReturnValue");
		ConvertToTraceType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTraceType_FunctionAddress, "ReturnValue");
		ConvertToTraceType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTraceType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ConvertToTraceType_IsValid = ConvertToTraceType_FunctionAddress != IntPtr.Zero && ConvertToTraceType_CollisionChannel_IsValid && ConvertToTraceType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToTraceType", ConvertToTraceType_IsValid);
		ConvertToObjectType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToObjectType");
		ConvertToObjectType_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToObjectType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToObjectType_CollisionChannel_PropertyAddress, ConvertToObjectType_FunctionAddress, "CollisionChannel");
		ConvertToObjectType_CollisionChannel_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToObjectType_FunctionAddress, "CollisionChannel");
		ConvertToObjectType_CollisionChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToObjectType_FunctionAddress, "CollisionChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToObjectType_ReturnValue_PropertyAddress, ConvertToObjectType_FunctionAddress, "ReturnValue");
		ConvertToObjectType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToObjectType_FunctionAddress, "ReturnValue");
		ConvertToObjectType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToObjectType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ConvertToObjectType_IsValid = ConvertToObjectType_FunctionAddress != IntPtr.Zero && ConvertToObjectType_CollisionChannel_IsValid && ConvertToObjectType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToObjectType", ConvertToObjectType_IsValid);
		ConvertToCollisionChannelByTraceType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToCollisionChannelByTraceType");
		ConvertToCollisionChannelByTraceType_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToCollisionChannelByTraceType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToCollisionChannelByTraceType_TraceType_PropertyAddress, ConvertToCollisionChannelByTraceType_FunctionAddress, "TraceType");
		ConvertToCollisionChannelByTraceType_TraceType_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToCollisionChannelByTraceType_FunctionAddress, "TraceType");
		ConvertToCollisionChannelByTraceType_TraceType_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToCollisionChannelByTraceType_FunctionAddress, "TraceType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToCollisionChannelByTraceType_ReturnValue_PropertyAddress, ConvertToCollisionChannelByTraceType_FunctionAddress, "ReturnValue");
		ConvertToCollisionChannelByTraceType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToCollisionChannelByTraceType_FunctionAddress, "ReturnValue");
		ConvertToCollisionChannelByTraceType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToCollisionChannelByTraceType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ConvertToCollisionChannelByTraceType_IsValid = ConvertToCollisionChannelByTraceType_FunctionAddress != IntPtr.Zero && ConvertToCollisionChannelByTraceType_TraceType_IsValid && ConvertToCollisionChannelByTraceType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToCollisionChannelByTraceType", ConvertToCollisionChannelByTraceType_IsValid);
		ConvertToCollisionChannelByObjectType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToCollisionChannelByObjectType");
		ConvertToCollisionChannelByObjectType_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToCollisionChannelByObjectType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToCollisionChannelByObjectType_ObjectType_PropertyAddress, ConvertToCollisionChannelByObjectType_FunctionAddress, "ObjectType");
		ConvertToCollisionChannelByObjectType_ObjectType_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToCollisionChannelByObjectType_FunctionAddress, "ObjectType");
		ConvertToCollisionChannelByObjectType_ObjectType_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToCollisionChannelByObjectType_FunctionAddress, "ObjectType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToCollisionChannelByObjectType_ReturnValue_PropertyAddress, ConvertToCollisionChannelByObjectType_FunctionAddress, "ReturnValue");
		ConvertToCollisionChannelByObjectType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToCollisionChannelByObjectType_FunctionAddress, "ReturnValue");
		ConvertToCollisionChannelByObjectType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToCollisionChannelByObjectType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ConvertToCollisionChannelByObjectType_IsValid = ConvertToCollisionChannelByObjectType_FunctionAddress != IntPtr.Zero && ConvertToCollisionChannelByObjectType_ObjectType_IsValid && ConvertToCollisionChannelByObjectType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibCollisionChannel:ConvertToCollisionChannelByObjectType", ConvertToCollisionChannelByObjectType_IsValid);
		BGUSetCollisionResponseToChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetCollisionResponseToChannels");
		BGUSetCollisionResponseToChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetCollisionResponseToChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetCollisionResponseToChannels_Comp_PropertyAddress, BGUSetCollisionResponseToChannels_FunctionAddress, "Comp");
		BGUSetCollisionResponseToChannels_Comp_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetCollisionResponseToChannels_FunctionAddress, "Comp");
		BGUSetCollisionResponseToChannels_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetCollisionResponseToChannels_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetCollisionResponseToChannels_ResponseToChannels_PropertyAddress, BGUSetCollisionResponseToChannels_FunctionAddress, "ResponseToChannels");
		BGUSetCollisionResponseToChannels_ResponseToChannels_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetCollisionResponseToChannels_FunctionAddress, "ResponseToChannels");
		BGUSetCollisionResponseToChannels_ResponseToChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetCollisionResponseToChannels_FunctionAddress, "ResponseToChannels", Classes.FMapProperty);
		BGUSetCollisionResponseToChannels_IsValid = BGUSetCollisionResponseToChannels_FunctionAddress != IntPtr.Zero && BGUSetCollisionResponseToChannels_Comp_IsValid && BGUSetCollisionResponseToChannels_ResponseToChannels_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibCollisionChannel:BGUSetCollisionResponseToChannels", BGUSetCollisionResponseToChannels_IsValid);
		BGUGetCollisionResponseToChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetCollisionResponseToChannels");
		BGUGetCollisionResponseToChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetCollisionResponseToChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetCollisionResponseToChannels_Comp_PropertyAddress, BGUGetCollisionResponseToChannels_FunctionAddress, "Comp");
		BGUGetCollisionResponseToChannels_Comp_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetCollisionResponseToChannels_FunctionAddress, "Comp");
		BGUGetCollisionResponseToChannels_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetCollisionResponseToChannels_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetCollisionResponseToChannels_OutResponseToChannels_PropertyAddress, BGUGetCollisionResponseToChannels_FunctionAddress, "OutResponseToChannels");
		BGUGetCollisionResponseToChannels_OutResponseToChannels_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetCollisionResponseToChannels_FunctionAddress, "OutResponseToChannels");
		BGUGetCollisionResponseToChannels_OutResponseToChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetCollisionResponseToChannels_FunctionAddress, "OutResponseToChannels", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetCollisionResponseToChannels_ReturnValue_PropertyAddress, BGUGetCollisionResponseToChannels_FunctionAddress, "ReturnValue");
		BGUGetCollisionResponseToChannels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetCollisionResponseToChannels_FunctionAddress, "ReturnValue");
		BGUGetCollisionResponseToChannels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetCollisionResponseToChannels_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetCollisionResponseToChannels_IsValid = BGUGetCollisionResponseToChannels_FunctionAddress != IntPtr.Zero && BGUGetCollisionResponseToChannels_Comp_IsValid && BGUGetCollisionResponseToChannels_OutResponseToChannels_IsValid && BGUGetCollisionResponseToChannels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibCollisionChannel:BGUGetCollisionResponseToChannels", BGUGetCollisionResponseToChannels_IsValid);
	}
}
