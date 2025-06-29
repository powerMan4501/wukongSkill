using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyObjST", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAnimKeyObjST
{
	private static bool TargetObject_IsValid;

	private static int TargetObject_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyObjST:TargetObject")]
	public UObject TargetObject;

	private static bool ObjType_IsValid;

	private static FFieldAddress ObjType_PropertyAddress;

	private static int ObjType_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyObjST:ObjType")]
	public EGSAKBObjType ObjType;

	private static bool StateKeyDataList_IsValid;

	private static FFieldAddress StateKeyDataList_PropertyAddress;

	private static int StateKeyDataList_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyObjST:StateKeyDataList")]
	public List<FGSAnimKeyStateData> StateKeyDataList;

	private static bool FGSAnimKeyObjST_IsValid;

	private static int FGSAnimKeyObjST_StructSize;

	public FGSAnimKeyObjST Copy()
	{
		FGSAnimKeyObjST result = this;
		if (StateKeyDataList != null)
		{
			result.StateKeyDataList = new List<FGSAnimKeyStateData>(StateKeyDataList);
		}
		return result;
	}

	public static FGSAnimKeyObjST FromNative(IntPtr nativeBuffer)
	{
		return new FGSAnimKeyObjST(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAnimKeyObjST value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAnimKeyObjST FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAnimKeyObjST(nativeBuffer + arrayIndex * FGSAnimKeyObjST_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAnimKeyObjST value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAnimKeyObjST_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAnimKeyObjST_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyObjST");
			return;
		}
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, TargetObject_Offset), TargetObject);
		EnumMarshaler<EGSAKBObjType>.ToNative(IntPtr.Add(nativeStruct, ObjType_Offset), 0, ObjType_PropertyAddress.Address, ObjType);
		new TArrayCopyMarshaler<FGSAnimKeyStateData>(1, StateKeyDataList_PropertyAddress, CachedMarshalingDelegates<FGSAnimKeyStateData, FGSAnimKeyStateData>.FromNative, CachedMarshalingDelegates<FGSAnimKeyStateData, FGSAnimKeyStateData>.ToNative).ToNative(IntPtr.Add(nativeStruct, StateKeyDataList_Offset), StateKeyDataList);
	}

	public FGSAnimKeyObjST(IntPtr nativeStruct)
	{
		if (!FGSAnimKeyObjST_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyObjST");
			TargetObject = null;
			ObjType = EGSAKBObjType.GSA_OBJ_TYPE_MIN;
			StateKeyDataList = null;
		}
		else
		{
			TargetObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, TargetObject_Offset));
			ObjType = EnumMarshaler<EGSAKBObjType>.FromNative(IntPtr.Add(nativeStruct, ObjType_Offset), 0, ObjType_PropertyAddress.Address);
			StateKeyDataList = new TArrayCopyMarshaler<FGSAnimKeyStateData>(1, StateKeyDataList_PropertyAddress, CachedMarshalingDelegates<FGSAnimKeyStateData, FGSAnimKeyStateData>.FromNative, CachedMarshalingDelegates<FGSAnimKeyStateData, FGSAnimKeyStateData>.ToNative).FromNative(IntPtr.Add(nativeStruct, StateKeyDataList_Offset));
		}
	}

	static FGSAnimKeyObjST()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAnimKeyObjST)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAnimKeyObjST));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAnimKeyObjST");
		FGSAnimKeyObjST_StructSize = NativeReflection.GetStructSize(intPtr);
		TargetObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetObject");
		TargetObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjType_PropertyAddress, intPtr, "ObjType");
		ObjType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjType");
		ObjType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StateKeyDataList_PropertyAddress, intPtr, "StateKeyDataList");
		StateKeyDataList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StateKeyDataList");
		StateKeyDataList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StateKeyDataList", Classes.FArrayProperty);
		FGSAnimKeyObjST_IsValid = intPtr != IntPtr.Zero && TargetObject_IsValid && ObjType_IsValid && StateKeyDataList_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyObjST", FGSAnimKeyObjST_IsValid);
	}
}
