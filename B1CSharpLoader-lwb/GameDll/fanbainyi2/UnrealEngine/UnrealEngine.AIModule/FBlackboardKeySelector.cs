using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.BlackboardKeySelector", "AIModule", UnrealModuleType.Engine)]
public struct FBlackboardKeySelector
{
	private static bool AllowedTypes_IsValid;

	private static FFieldAddress AllowedTypes_PropertyAddress;

	private static int AllowedTypes_Offset;

	[UProperty(Flags = (PropFlags)5629499534221829uL)]
	[UMetaPath("/Script/AIModule.BlackboardKeySelector:AllowedTypes")]
	public List<UBlackboardKeyType> AllowedTypes;

	private static bool SelectedKeyName_IsValid;

	private static int SelectedKeyName_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/AIModule.BlackboardKeySelector:SelectedKeyName")]
	public FName SelectedKeyName;

	private static bool SelectedKeyType_IsValid;

	private static int SelectedKeyType_Offset;

	[UProperty(Flags = (PropFlags)7881369141127685uL)]
	[UMetaPath("/Script/AIModule.BlackboardKeySelector:SelectedKeyType")]
	public TSubclassOf<UBlackboardKeyType> SelectedKeyType;

	private static bool SelectedKeyID_IsValid;

	private static int SelectedKeyID_Offset;

	[UProperty(Flags = (PropFlags)11267864954677765uL)]
	[UMetaPath("/Script/AIModule.BlackboardKeySelector:SelectedKeyID")]
	public byte SelectedKeyID;

	private static bool NoneIsAllowedValue_IsValid;

	private static FFieldAddress NoneIsAllowedValue_PropertyAddress;

	private static int NoneIsAllowedValue_Offset;

	[UProperty(Flags = (PropFlags)11267863880925189uL)]
	[UMetaPath("/Script/AIModule.BlackboardKeySelector:bNoneIsAllowedValue")]
	public bool NoneIsAllowedValue;

	private static bool FBlackboardKeySelector_IsValid;

	private static int FBlackboardKeySelector_StructSize;

	public FBlackboardKeySelector Copy()
	{
		FBlackboardKeySelector result = this;
		if (AllowedTypes != null)
		{
			result.AllowedTypes = new List<UBlackboardKeyType>(AllowedTypes);
		}
		return result;
	}

	public static FBlackboardKeySelector FromNative(IntPtr nativeBuffer)
	{
		return new FBlackboardKeySelector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBlackboardKeySelector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBlackboardKeySelector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBlackboardKeySelector(nativeBuffer + arrayIndex * FBlackboardKeySelector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBlackboardKeySelector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBlackboardKeySelector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBlackboardKeySelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.BlackboardKeySelector");
			return;
		}
		new TArrayCopyMarshaler<UBlackboardKeyType>(1, AllowedTypes_PropertyAddress, CachedMarshalingDelegates<UBlackboardKeyType, UObjectMarshaler<UBlackboardKeyType>>.FromNative, CachedMarshalingDelegates<UBlackboardKeyType, UObjectMarshaler<UBlackboardKeyType>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AllowedTypes_Offset), AllowedTypes);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SelectedKeyName_Offset), SelectedKeyName);
		TSubclassOfMarshaler<UBlackboardKeyType>.ToNative(IntPtr.Add(nativeStruct, SelectedKeyType_Offset), SelectedKeyType);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, SelectedKeyID_Offset), SelectedKeyID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NoneIsAllowedValue_Offset), 0, NoneIsAllowedValue_PropertyAddress.Address, NoneIsAllowedValue);
	}

	public FBlackboardKeySelector(IntPtr nativeStruct)
	{
		if (!FBlackboardKeySelector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.BlackboardKeySelector");
			AllowedTypes = null;
			SelectedKeyName = default(FName);
			SelectedKeyType = default(TSubclassOf<UBlackboardKeyType>);
			SelectedKeyID = 0;
			NoneIsAllowedValue = false;
		}
		else
		{
			AllowedTypes = new TArrayCopyMarshaler<UBlackboardKeyType>(1, AllowedTypes_PropertyAddress, CachedMarshalingDelegates<UBlackboardKeyType, UObjectMarshaler<UBlackboardKeyType>>.FromNative, CachedMarshalingDelegates<UBlackboardKeyType, UObjectMarshaler<UBlackboardKeyType>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AllowedTypes_Offset));
			SelectedKeyName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SelectedKeyName_Offset));
			SelectedKeyType = TSubclassOfMarshaler<UBlackboardKeyType>.FromNative(IntPtr.Add(nativeStruct, SelectedKeyType_Offset));
			SelectedKeyID = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, SelectedKeyID_Offset));
			NoneIsAllowedValue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NoneIsAllowedValue_Offset), 0, NoneIsAllowedValue_PropertyAddress.Address);
		}
	}

	static FBlackboardKeySelector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBlackboardKeySelector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBlackboardKeySelector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.BlackboardKeySelector");
		FBlackboardKeySelector_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AllowedTypes_PropertyAddress, intPtr, "AllowedTypes");
		AllowedTypes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AllowedTypes");
		AllowedTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AllowedTypes", Classes.FArrayProperty);
		SelectedKeyName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectedKeyName");
		SelectedKeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectedKeyName", Classes.FNameProperty);
		SelectedKeyType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectedKeyType");
		SelectedKeyType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectedKeyType", Classes.FClassProperty);
		SelectedKeyID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectedKeyID");
		SelectedKeyID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectedKeyID", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref NoneIsAllowedValue_PropertyAddress, intPtr, "bNoneIsAllowedValue");
		NoneIsAllowedValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNoneIsAllowedValue");
		NoneIsAllowedValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNoneIsAllowedValue", Classes.FBoolProperty);
		FBlackboardKeySelector_IsValid = intPtr != IntPtr.Zero && AllowedTypes_IsValid && SelectedKeyName_IsValid && SelectedKeyType_IsValid && SelectedKeyID_IsValid && NoneIsAllowedValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.BlackboardKeySelector", FBlackboardKeySelector_IsValid);
	}
}
