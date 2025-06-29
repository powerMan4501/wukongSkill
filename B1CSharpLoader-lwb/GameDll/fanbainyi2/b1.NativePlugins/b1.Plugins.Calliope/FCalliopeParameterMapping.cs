using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeParameterMapping", "Calliope", UnrealModuleType.GamePlugin)]
public struct FCalliopeParameterMapping
{
	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:ParamType")]
	public EGsManagedParamType ParamType;

	private static bool ParamGuid_IsValid;

	private static int ParamGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:ParamGuid")]
	public Guid ParamGuid;

	private static bool ParamDisplayName_IsValid;

	private static int ParamDisplayName_Offset;

	[UProperty(Flags = (PropFlags)6755399441187333uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:ParamDisplayName")]
	public string ParamDisplayName;

	private static bool Actor_IsValid;

	private static int Actor_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:Actor")]
	public TSoftObject<AActor> Actor;

	private static bool ActorGuid_IsValid;

	private static int ActorGuid_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:ActorGuid")]
	public string ActorGuid;

	private static bool SequenceID_IsValid;

	private static int SequenceID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:SequenceID")]
	public int SequenceID;

	private static bool TaskStage_IsValid;

	private static int TaskStage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:TaskStage")]
	public int TaskStage;

	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:BuffID")]
	public int BuffID;

	private static bool GroupID_IsValid;

	private static int GroupID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:GroupID")]
	public int GroupID;

	private static bool AiConversationIDList_IsValid;

	private static FFieldAddress AiConversationIDList_PropertyAddress;

	private static int AiConversationIDList_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:AiConversationIDList")]
	public List<int> AiConversationIDList;

	private static bool ArchiveLabel_IsValid;

	private static int ArchiveLabel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:ArchiveLabel")]
	public FName ArchiveLabel;

	private static bool KeepOriginal_IsValid;

	private static FFieldAddress KeepOriginal_PropertyAddress;

	private static int KeepOriginal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:bKeepOriginal")]
	public bool KeepOriginal;

	private static bool ParameterString_IsValid;

	private static int ParameterString_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:ParameterString")]
	public string ParameterString;

	private static bool ParameterInt_IsValid;

	private static int ParameterInt_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:ParameterInt")]
	public int ParameterInt;

	private static bool ParameterArrayInt_IsValid;

	private static FFieldAddress ParameterArrayInt_PropertyAddress;

	private static int ParameterArrayInt_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMapping:ParameterArrayInt")]
	public List<int> ParameterArrayInt;

	private static bool FCalliopeParameterMapping_IsValid;

	private static int FCalliopeParameterMapping_StructSize;

	public FCalliopeParameterMapping Copy()
	{
		FCalliopeParameterMapping result = this;
		if (AiConversationIDList != null)
		{
			result.AiConversationIDList = new List<int>(AiConversationIDList);
		}
		if (ParameterArrayInt != null)
		{
			result.ParameterArrayInt = new List<int>(ParameterArrayInt);
		}
		return result;
	}

	public static FCalliopeParameterMapping FromNative(IntPtr nativeBuffer)
	{
		return new FCalliopeParameterMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCalliopeParameterMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCalliopeParameterMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCalliopeParameterMapping(nativeBuffer + arrayIndex * FCalliopeParameterMapping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCalliopeParameterMapping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCalliopeParameterMapping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCalliopeParameterMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeParameterMapping");
			return;
		}
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ParamGuid_Offset), ParamGuid);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ParamDisplayName_Offset), ParamDisplayName);
		TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorGuid_Offset), ActorGuid);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SequenceID_Offset), SequenceID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TaskStage_Offset), TaskStage);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffID_Offset), BuffID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GroupID_Offset), GroupID);
		new TArrayCopyMarshaler<int>(1, AiConversationIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AiConversationIDList_Offset), AiConversationIDList);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ArchiveLabel_Offset), ArchiveLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, KeepOriginal_Offset), 0, KeepOriginal_PropertyAddress.Address, KeepOriginal);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ParameterString_Offset), ParameterString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ParameterInt_Offset), ParameterInt);
		new TArrayCopyMarshaler<int>(1, ParameterArrayInt_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ParameterArrayInt_Offset), ParameterArrayInt);
	}

	public FCalliopeParameterMapping(IntPtr nativeStruct)
	{
		if (!FCalliopeParameterMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeParameterMapping");
			ParamType = EGsManagedParamType.None;
			ParamGuid = default(Guid);
			ParamDisplayName = FStringMarshaler.DefaultString;
			Actor = default(TSoftObject<AActor>);
			ActorGuid = FStringMarshaler.DefaultString;
			SequenceID = 0;
			TaskStage = 0;
			BuffID = 0;
			GroupID = 0;
			AiConversationIDList = null;
			ArchiveLabel = default(FName);
			KeepOriginal = false;
			ParameterString = FStringMarshaler.DefaultString;
			ParameterInt = 0;
			ParameterArrayInt = null;
		}
		else
		{
			ParamType = EnumMarshaler<EGsManagedParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ParamGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ParamGuid_Offset));
			ParamDisplayName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ParamDisplayName_Offset));
			Actor = TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			ActorGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorGuid_Offset));
			SequenceID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SequenceID_Offset));
			TaskStage = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TaskStage_Offset));
			BuffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffID_Offset));
			GroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GroupID_Offset));
			AiConversationIDList = new TArrayCopyMarshaler<int>(1, AiConversationIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AiConversationIDList_Offset));
			ArchiveLabel = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ArchiveLabel_Offset));
			KeepOriginal = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, KeepOriginal_Offset), 0, KeepOriginal_PropertyAddress.Address);
			ParameterString = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ParameterString_Offset));
			ParameterInt = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ParameterInt_Offset));
			ParameterArrayInt = new TArrayCopyMarshaler<int>(1, ParameterArrayInt_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ParameterArrayInt_Offset));
		}
	}

	static FCalliopeParameterMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCalliopeParameterMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCalliopeParameterMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.CalliopeParameterMapping");
		FCalliopeParameterMapping_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ParamGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamGuid");
		ParamGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamGuid", Classes.FStructProperty);
		ParamDisplayName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamDisplayName");
		ParamDisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamDisplayName", Classes.FStrProperty);
		Actor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Actor", Classes.FSoftObjectProperty);
		ActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorGuid");
		ActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorGuid", Classes.FStrProperty);
		SequenceID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SequenceID");
		SequenceID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SequenceID", Classes.FIntProperty);
		TaskStage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TaskStage");
		TaskStage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TaskStage", Classes.FIntProperty);
		BuffID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		GroupID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupID");
		GroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AiConversationIDList_PropertyAddress, intPtr, "AiConversationIDList");
		AiConversationIDList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AiConversationIDList");
		AiConversationIDList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AiConversationIDList", Classes.FArrayProperty);
		ArchiveLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArchiveLabel");
		ArchiveLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArchiveLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref KeepOriginal_PropertyAddress, intPtr, "bKeepOriginal");
		KeepOriginal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bKeepOriginal");
		KeepOriginal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bKeepOriginal", Classes.FBoolProperty);
		ParameterString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterString");
		ParameterString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterString", Classes.FStrProperty);
		ParameterInt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterInt");
		ParameterInt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterInt", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ParameterArrayInt_PropertyAddress, intPtr, "ParameterArrayInt");
		ParameterArrayInt_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParameterArrayInt");
		ParameterArrayInt_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParameterArrayInt", Classes.FArrayProperty);
		FCalliopeParameterMapping_IsValid = intPtr != IntPtr.Zero && ParamType_IsValid && ParamGuid_IsValid && ParamDisplayName_IsValid && Actor_IsValid && ActorGuid_IsValid && SequenceID_IsValid && TaskStage_IsValid && BuffID_IsValid && GroupID_IsValid && AiConversationIDList_IsValid && ArchiveLabel_IsValid && KeepOriginal_IsValid && ParameterString_IsValid && ParameterInt_IsValid && ParameterArrayInt_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.CalliopeParameterMapping", FCalliopeParameterMapping_IsValid);
	}
}
