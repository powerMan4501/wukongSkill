using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsManagedAiConversationID", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsManagedAiConversationID
{
	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsManagedParamBase:ParamType")]
	public EGsManagedParamType ParamType;

	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsManagedParamBase:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool AliasName_IsValid;

	private static int AliasName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsManagedParamBase:AliasName")]
	public FName AliasName;

	private static bool AiConversationIDList_IsValid;

	private static FFieldAddress AiConversationIDList_PropertyAddress;

	private static int AiConversationIDList_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.GsManagedAiConversationID:AiConversationIDList")]
	public List<int> AiConversationIDList;

	private static bool FGsManagedAiConversationID_IsValid;

	private static int FGsManagedAiConversationID_StructSize;

	public FGsManagedAiConversationID Copy()
	{
		FGsManagedAiConversationID result = this;
		if (AiConversationIDList != null)
		{
			result.AiConversationIDList = new List<int>(AiConversationIDList);
		}
		return result;
	}

	public static FGsManagedAiConversationID FromNative(IntPtr nativeBuffer)
	{
		return new FGsManagedAiConversationID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsManagedAiConversationID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsManagedAiConversationID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsManagedAiConversationID(nativeBuffer + arrayIndex * FGsManagedAiConversationID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsManagedAiConversationID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsManagedAiConversationID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsManagedAiConversationID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedAiConversationID");
			return;
		}
		new TArrayCopyMarshaler<int>(1, AiConversationIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AiConversationIDList_Offset), AiConversationIDList);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AliasName_Offset), AliasName);
	}

	public FGsManagedAiConversationID(IntPtr nativeStruct)
	{
		if (!FGsManagedAiConversationID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsManagedAiConversationID");
			AiConversationIDList = null;
			ParamType = EGsManagedParamType.None;
			ConfigGuid = default(Guid);
			AliasName = default(FName);
		}
		else
		{
			AiConversationIDList = new TArrayCopyMarshaler<int>(1, AiConversationIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AiConversationIDList_Offset));
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			AliasName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AliasName_Offset));
		}
	}

	static FGsManagedAiConversationID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsManagedAiConversationID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsManagedAiConversationID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsManagedAiConversationID");
		FGsManagedAiConversationID_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		AliasName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AliasName");
		AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AliasName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AiConversationIDList_PropertyAddress, intPtr, "AiConversationIDList");
		AiConversationIDList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AiConversationIDList");
		AiConversationIDList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AiConversationIDList", Classes.FArrayProperty);
		FGsManagedAiConversationID_IsValid = intPtr != IntPtr.Zero && AiConversationIDList_IsValid && ParamType_IsValid && ConfigGuid_IsValid && AliasName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsManagedAiConversationID", FGsManagedAiConversationID_IsValid);
	}
}
