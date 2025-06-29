using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeGameplayTagLibrary", "Calliope", UnrealModuleType.GamePlugin)]
public class UCalliopeGameplayTagLibrary : UGameplayTagLibrary
{
	private static IntPtr classAddress;

	private static bool MakeGameplayTagFromString_IsValid;

	private static IntPtr MakeGameplayTagFromString_FunctionAddress;

	private static int MakeGameplayTagFromString_ParamsSize;

	private static bool MakeGameplayTagFromString_TagStr_IsValid;

	private static FFieldAddress MakeGameplayTagFromString_TagStr_PropertyAddress;

	private static int MakeGameplayTagFromString_TagStr_Offset;

	private static bool MakeGameplayTagFromString_ReturnValue_IsValid;

	private static FFieldAddress MakeGameplayTagFromString_ReturnValue_PropertyAddress;

	private static int MakeGameplayTagFromString_ReturnValue_Offset;

	private static bool MakeGameplayTagFromName_IsValid;

	private static IntPtr MakeGameplayTagFromName_FunctionAddress;

	private static int MakeGameplayTagFromName_ParamsSize;

	private static bool MakeGameplayTagFromName_TagName_IsValid;

	private static FFieldAddress MakeGameplayTagFromName_TagName_PropertyAddress;

	private static int MakeGameplayTagFromName_TagName_Offset;

	private static bool MakeGameplayTagFromName_ReturnValue_IsValid;

	private static FFieldAddress MakeGameplayTagFromName_ReturnValue_PropertyAddress;

	private static int MakeGameplayTagFromName_ReturnValue_Offset;

	private static bool MakeGameplayTagContainer_IsValid;

	private static IntPtr MakeGameplayTagContainer_FunctionAddress;

	private static int MakeGameplayTagContainer_ParamsSize;

	private static bool MakeGameplayTagContainer_ReturnValue_IsValid;

	private static FFieldAddress MakeGameplayTagContainer_ReturnValue_PropertyAddress;

	private static int MakeGameplayTagContainer_ReturnValue_Offset;

	private static bool HasTagName_IsValid;

	private static IntPtr HasTagName_FunctionAddress;

	private static int HasTagName_ParamsSize;

	private static bool HasTagName_TagContainer_IsValid;

	private static FFieldAddress HasTagName_TagContainer_PropertyAddress;

	private static int HasTagName_TagContainer_Offset;

	private static bool HasTagName_TagName_IsValid;

	private static FFieldAddress HasTagName_TagName_PropertyAddress;

	private static int HasTagName_TagName_Offset;

	private static bool HasTagName_bExactMatch_IsValid;

	private static FFieldAddress HasTagName_bExactMatch_PropertyAddress;

	private static int HasTagName_bExactMatch_Offset;

	private static bool HasTagName_ReturnValue_IsValid;

	private static FFieldAddress HasTagName_ReturnValue_PropertyAddress;

	private static int HasTagName_ReturnValue_Offset;

	private static bool FilterTags_IsValid;

	private static IntPtr FilterTags_FunctionAddress;

	private static int FilterTags_ParamsSize;

	private static bool FilterTags_Container_IsValid;

	private static FFieldAddress FilterTags_Container_PropertyAddress;

	private static int FilterTags_Container_Offset;

	private static bool FilterTags_OtherContainer_IsValid;

	private static FFieldAddress FilterTags_OtherContainer_PropertyAddress;

	private static int FilterTags_OtherContainer_Offset;

	private static bool FilterTags_bExactMatch_IsValid;

	private static FFieldAddress FilterTags_bExactMatch_PropertyAddress;

	private static int FilterTags_bExactMatch_Offset;

	private static bool FilterTags_ReturnValue_IsValid;

	private static FFieldAddress FilterTags_ReturnValue_PropertyAddress;

	private static int FilterTags_ReturnValue_Offset;

	private static bool FilterTag_IsValid;

	private static IntPtr FilterTag_FunctionAddress;

	private static int FilterTag_ParamsSize;

	private static bool FilterTag_Container_IsValid;

	private static FFieldAddress FilterTag_Container_PropertyAddress;

	private static int FilterTag_Container_Offset;

	private static bool FilterTag_Tag_IsValid;

	private static FFieldAddress FilterTag_Tag_PropertyAddress;

	private static int FilterTag_Tag_Offset;

	private static bool FilterTag_bExactMatch_IsValid;

	private static FFieldAddress FilterTag_bExactMatch_PropertyAddress;

	private static int FilterTag_bExactMatch_Offset;

	private static bool FilterTag_ReturnValue_IsValid;

	private static FFieldAddress FilterTag_ReturnValue_PropertyAddress;

	private static int FilterTag_ReturnValue_Offset;

	private static bool AddGamePlayTagToINI_IsValid;

	private static IntPtr AddGamePlayTagToINI_FunctionAddress;

	private static int AddGamePlayTagToINI_ParamsSize;

	private static bool AddGamePlayTagToINI_NewTag_IsValid;

	private static FFieldAddress AddGamePlayTagToINI_NewTag_PropertyAddress;

	private static int AddGamePlayTagToINI_NewTag_Offset;

	private static bool AddGamePlayTagToINI_Comment_IsValid;

	private static FFieldAddress AddGamePlayTagToINI_Comment_PropertyAddress;

	private static int AddGamePlayTagToINI_Comment_Offset;

	private static bool AddGamePlayTagToINI_TagSourceName_IsValid;

	private static FFieldAddress AddGamePlayTagToINI_TagSourceName_PropertyAddress;

	private static int AddGamePlayTagToINI_TagSourceName_Offset;

	private static bool AddGamePlayTagToINI_bIsRestrictedTag_IsValid;

	private static FFieldAddress AddGamePlayTagToINI_bIsRestrictedTag_PropertyAddress;

	private static int AddGamePlayTagToINI_bIsRestrictedTag_Offset;

	private static bool AddGamePlayTagToINI_bAllowNonRestrictedChildren_IsValid;

	private static FFieldAddress AddGamePlayTagToINI_bAllowNonRestrictedChildren_PropertyAddress;

	private static int AddGamePlayTagToINI_bAllowNonRestrictedChildren_Offset;

	private static bool AddGamePlayTagToINI_ReturnValue_IsValid;

	private static FFieldAddress AddGamePlayTagToINI_ReturnValue_PropertyAddress;

	private static int AddGamePlayTagToINI_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Calliope.CalliopeGameplayTagLibrary:MakeGameplayTagFromString")]
	public unsafe static FGameplayTag MakeGameplayTagFromString(string TagStr)
	{
		if (!MakeGameplayTagFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeGameplayTagLibrary:MakeGameplayTagFromString");
			return default(FGameplayTag);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeGameplayTagFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeGameplayTagFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakeGameplayTagFromString_TagStr_Offset), 0, MakeGameplayTagFromString_TagStr_PropertyAddress.Address, TagStr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeGameplayTagFromString_FunctionAddress, intPtr, MakeGameplayTagFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakeGameplayTagFromString_TagStr_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(intPtr, MakeGameplayTagFromString_ReturnValue_Offset), 0, MakeGameplayTagFromString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Calliope.CalliopeGameplayTagLibrary:MakeGameplayTagFromName")]
	public unsafe static FGameplayTag MakeGameplayTagFromName(FName TagName)
	{
		if (!MakeGameplayTagFromName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeGameplayTagLibrary:MakeGameplayTagFromName");
			return default(FGameplayTag);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeGameplayTagFromName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeGameplayTagFromName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, MakeGameplayTagFromName_TagName_Offset), 0, MakeGameplayTagFromName_TagName_PropertyAddress.Address, TagName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeGameplayTagFromName_FunctionAddress, intPtr, MakeGameplayTagFromName_ParamsSize);
		return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(intPtr, MakeGameplayTagFromName_ReturnValue_Offset), 0, MakeGameplayTagFromName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Calliope.CalliopeGameplayTagLibrary:MakeGameplayTagContainer")]
	public unsafe static FGameplayTagContainer MakeGameplayTagContainer()
	{
		if (!MakeGameplayTagContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeGameplayTagLibrary:MakeGameplayTagContainer");
			return default(FGameplayTagContainer);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeGameplayTagContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeGameplayTagContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeGameplayTagContainer_FunctionAddress, intPtr, MakeGameplayTagContainer_ParamsSize);
		FGameplayTagContainer result = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, MakeGameplayTagContainer_ReturnValue_Offset), 0, MakeGameplayTagContainer_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeGameplayTagContainer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Calliope.CalliopeGameplayTagLibrary:HasTagName")]
	public unsafe static bool HasTagName(FGameplayTagContainer TagContainer, FName TagName, bool bExactMatch)
	{
		if (!HasTagName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeGameplayTagLibrary:HasTagName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasTagName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasTagName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasTagName_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, HasTagName_TagContainer_Offset), 0, HasTagName_TagContainer_PropertyAddress.Address, TagContainer);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, HasTagName_TagName_Offset), 0, HasTagName_TagName_PropertyAddress.Address, TagName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HasTagName_bExactMatch_Offset), 0, HasTagName_bExactMatch_PropertyAddress.Address, bExactMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasTagName_FunctionAddress, intPtr, HasTagName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HasTagName_TagContainer_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasTagName_ReturnValue_Offset), 0, HasTagName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Calliope.CalliopeGameplayTagLibrary:FilterTags")]
	public unsafe static FGameplayTagContainer FilterTags(FGameplayTagContainer Container, FGameplayTagContainer OtherContainer, bool bExactMatch)
	{
		if (!FilterTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeGameplayTagLibrary:FilterTags");
			return default(FGameplayTagContainer);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FilterTags_Container_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, FilterTags_Container_Offset), 0, FilterTags_Container_PropertyAddress.Address, Container);
		NativeReflection.InitializeValue_InContainer(FilterTags_OtherContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, FilterTags_OtherContainer_Offset), 0, FilterTags_OtherContainer_PropertyAddress.Address, OtherContainer);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FilterTags_bExactMatch_Offset), 0, FilterTags_bExactMatch_PropertyAddress.Address, bExactMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FilterTags_FunctionAddress, intPtr, FilterTags_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FilterTags_Container_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(FilterTags_OtherContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer result = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, FilterTags_ReturnValue_Offset), 0, FilterTags_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FilterTags_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Calliope.CalliopeGameplayTagLibrary:FilterTag")]
	public unsafe static FGameplayTagContainer FilterTag(FGameplayTagContainer Container, FGameplayTag Tag, bool bExactMatch)
	{
		if (!FilterTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeGameplayTagLibrary:FilterTag");
			return default(FGameplayTagContainer);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FilterTag_Container_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, FilterTag_Container_Offset), 0, FilterTag_Container_PropertyAddress.Address, Container);
		NativeReflection.InitializeValue_InContainer(FilterTag_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, FilterTag_Tag_Offset), 0, FilterTag_Tag_PropertyAddress.Address, Tag);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FilterTag_bExactMatch_Offset), 0, FilterTag_bExactMatch_PropertyAddress.Address, bExactMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FilterTag_FunctionAddress, intPtr, FilterTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FilterTag_Container_PropertyAddress.Address, intPtr);
		FGameplayTagContainer result = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, FilterTag_ReturnValue_Offset), 0, FilterTag_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FilterTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Calliope.CalliopeGameplayTagLibrary:AddGamePlayTagToINI")]
	public unsafe static bool AddGamePlayTagToINI(string NewTag, string Comment, FName TagSourceName, bool bIsRestrictedTag, bool bAllowNonRestrictedChildren)
	{
		if (!AddGamePlayTagToINI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeGameplayTagLibrary:AddGamePlayTagToINI");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGamePlayTagToINI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGamePlayTagToINI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddGamePlayTagToINI_NewTag_Offset), 0, AddGamePlayTagToINI_NewTag_PropertyAddress.Address, NewTag);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddGamePlayTagToINI_Comment_Offset), 0, AddGamePlayTagToINI_Comment_PropertyAddress.Address, Comment);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddGamePlayTagToINI_TagSourceName_Offset), 0, AddGamePlayTagToINI_TagSourceName_PropertyAddress.Address, TagSourceName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddGamePlayTagToINI_bIsRestrictedTag_Offset), 0, AddGamePlayTagToINI_bIsRestrictedTag_PropertyAddress.Address, bIsRestrictedTag);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddGamePlayTagToINI_bAllowNonRestrictedChildren_Offset), 0, AddGamePlayTagToINI_bAllowNonRestrictedChildren_PropertyAddress.Address, bAllowNonRestrictedChildren);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddGamePlayTagToINI_FunctionAddress, intPtr, AddGamePlayTagToINI_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddGamePlayTagToINI_NewTag_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddGamePlayTagToINI_Comment_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddGamePlayTagToINI_ReturnValue_Offset), 0, AddGamePlayTagToINI_ReturnValue_PropertyAddress.Address);
	}

	static UCalliopeGameplayTagLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCalliopeGameplayTagLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCalliopeGameplayTagLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Calliope.CalliopeGameplayTagLibrary");
		MakeGameplayTagFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeGameplayTagFromString");
		MakeGameplayTagFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeGameplayTagFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagFromString_TagStr_PropertyAddress, MakeGameplayTagFromString_FunctionAddress, "TagStr");
		MakeGameplayTagFromString_TagStr_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagFromString_FunctionAddress, "TagStr");
		MakeGameplayTagFromString_TagStr_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagFromString_FunctionAddress, "TagStr", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagFromString_ReturnValue_PropertyAddress, MakeGameplayTagFromString_FunctionAddress, "ReturnValue");
		MakeGameplayTagFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagFromString_FunctionAddress, "ReturnValue");
		MakeGameplayTagFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagFromString_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeGameplayTagFromString_IsValid = MakeGameplayTagFromString_FunctionAddress != IntPtr.Zero && MakeGameplayTagFromString_TagStr_IsValid && MakeGameplayTagFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeGameplayTagLibrary:MakeGameplayTagFromString", MakeGameplayTagFromString_IsValid);
		MakeGameplayTagFromName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeGameplayTagFromName");
		MakeGameplayTagFromName_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeGameplayTagFromName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagFromName_TagName_PropertyAddress, MakeGameplayTagFromName_FunctionAddress, "TagName");
		MakeGameplayTagFromName_TagName_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagFromName_FunctionAddress, "TagName");
		MakeGameplayTagFromName_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagFromName_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagFromName_ReturnValue_PropertyAddress, MakeGameplayTagFromName_FunctionAddress, "ReturnValue");
		MakeGameplayTagFromName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagFromName_FunctionAddress, "ReturnValue");
		MakeGameplayTagFromName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagFromName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeGameplayTagFromName_IsValid = MakeGameplayTagFromName_FunctionAddress != IntPtr.Zero && MakeGameplayTagFromName_TagName_IsValid && MakeGameplayTagFromName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeGameplayTagLibrary:MakeGameplayTagFromName", MakeGameplayTagFromName_IsValid);
		MakeGameplayTagContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeGameplayTagContainer");
		MakeGameplayTagContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeGameplayTagContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagContainer_ReturnValue_PropertyAddress, MakeGameplayTagContainer_FunctionAddress, "ReturnValue");
		MakeGameplayTagContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagContainer_FunctionAddress, "ReturnValue");
		MakeGameplayTagContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagContainer_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeGameplayTagContainer_IsValid = MakeGameplayTagContainer_FunctionAddress != IntPtr.Zero && MakeGameplayTagContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeGameplayTagLibrary:MakeGameplayTagContainer", MakeGameplayTagContainer_IsValid);
		HasTagName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasTagName");
		HasTagName_ParamsSize = NativeReflection.GetFunctionParamsSize(HasTagName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasTagName_TagContainer_PropertyAddress, HasTagName_FunctionAddress, "TagContainer");
		HasTagName_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(HasTagName_FunctionAddress, "TagContainer");
		HasTagName_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTagName_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasTagName_TagName_PropertyAddress, HasTagName_FunctionAddress, "TagName");
		HasTagName_TagName_Offset = NativeReflectionCached.GetPropertyOffset(HasTagName_FunctionAddress, "TagName");
		HasTagName_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTagName_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref HasTagName_bExactMatch_PropertyAddress, HasTagName_FunctionAddress, "bExactMatch");
		HasTagName_bExactMatch_Offset = NativeReflectionCached.GetPropertyOffset(HasTagName_FunctionAddress, "bExactMatch");
		HasTagName_bExactMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTagName_FunctionAddress, "bExactMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasTagName_ReturnValue_PropertyAddress, HasTagName_FunctionAddress, "ReturnValue");
		HasTagName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasTagName_FunctionAddress, "ReturnValue");
		HasTagName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTagName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasTagName_IsValid = HasTagName_FunctionAddress != IntPtr.Zero && HasTagName_TagContainer_IsValid && HasTagName_TagName_IsValid && HasTagName_bExactMatch_IsValid && HasTagName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeGameplayTagLibrary:HasTagName", HasTagName_IsValid);
		FilterTags_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FilterTags");
		FilterTags_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterTags_Container_PropertyAddress, FilterTags_FunctionAddress, "Container");
		FilterTags_Container_Offset = NativeReflectionCached.GetPropertyOffset(FilterTags_FunctionAddress, "Container");
		FilterTags_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterTags_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterTags_OtherContainer_PropertyAddress, FilterTags_FunctionAddress, "OtherContainer");
		FilterTags_OtherContainer_Offset = NativeReflectionCached.GetPropertyOffset(FilterTags_FunctionAddress, "OtherContainer");
		FilterTags_OtherContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterTags_FunctionAddress, "OtherContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterTags_bExactMatch_PropertyAddress, FilterTags_FunctionAddress, "bExactMatch");
		FilterTags_bExactMatch_Offset = NativeReflectionCached.GetPropertyOffset(FilterTags_FunctionAddress, "bExactMatch");
		FilterTags_bExactMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterTags_FunctionAddress, "bExactMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterTags_ReturnValue_PropertyAddress, FilterTags_FunctionAddress, "ReturnValue");
		FilterTags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FilterTags_FunctionAddress, "ReturnValue");
		FilterTags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterTags_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FilterTags_IsValid = FilterTags_FunctionAddress != IntPtr.Zero && FilterTags_Container_IsValid && FilterTags_OtherContainer_IsValid && FilterTags_bExactMatch_IsValid && FilterTags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeGameplayTagLibrary:FilterTags", FilterTags_IsValid);
		FilterTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FilterTag");
		FilterTag_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterTag_Container_PropertyAddress, FilterTag_FunctionAddress, "Container");
		FilterTag_Container_Offset = NativeReflectionCached.GetPropertyOffset(FilterTag_FunctionAddress, "Container");
		FilterTag_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterTag_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterTag_Tag_PropertyAddress, FilterTag_FunctionAddress, "Tag");
		FilterTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(FilterTag_FunctionAddress, "Tag");
		FilterTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterTag_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterTag_bExactMatch_PropertyAddress, FilterTag_FunctionAddress, "bExactMatch");
		FilterTag_bExactMatch_Offset = NativeReflectionCached.GetPropertyOffset(FilterTag_FunctionAddress, "bExactMatch");
		FilterTag_bExactMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterTag_FunctionAddress, "bExactMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterTag_ReturnValue_PropertyAddress, FilterTag_FunctionAddress, "ReturnValue");
		FilterTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FilterTag_FunctionAddress, "ReturnValue");
		FilterTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterTag_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FilterTag_IsValid = FilterTag_FunctionAddress != IntPtr.Zero && FilterTag_Container_IsValid && FilterTag_Tag_IsValid && FilterTag_bExactMatch_IsValid && FilterTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeGameplayTagLibrary:FilterTag", FilterTag_IsValid);
		AddGamePlayTagToINI_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddGamePlayTagToINI");
		AddGamePlayTagToINI_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGamePlayTagToINI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGamePlayTagToINI_NewTag_PropertyAddress, AddGamePlayTagToINI_FunctionAddress, "NewTag");
		AddGamePlayTagToINI_NewTag_Offset = NativeReflectionCached.GetPropertyOffset(AddGamePlayTagToINI_FunctionAddress, "NewTag");
		AddGamePlayTagToINI_NewTag_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGamePlayTagToINI_FunctionAddress, "NewTag", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddGamePlayTagToINI_Comment_PropertyAddress, AddGamePlayTagToINI_FunctionAddress, "Comment");
		AddGamePlayTagToINI_Comment_Offset = NativeReflectionCached.GetPropertyOffset(AddGamePlayTagToINI_FunctionAddress, "Comment");
		AddGamePlayTagToINI_Comment_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGamePlayTagToINI_FunctionAddress, "Comment", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddGamePlayTagToINI_TagSourceName_PropertyAddress, AddGamePlayTagToINI_FunctionAddress, "TagSourceName");
		AddGamePlayTagToINI_TagSourceName_Offset = NativeReflectionCached.GetPropertyOffset(AddGamePlayTagToINI_FunctionAddress, "TagSourceName");
		AddGamePlayTagToINI_TagSourceName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGamePlayTagToINI_FunctionAddress, "TagSourceName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddGamePlayTagToINI_bIsRestrictedTag_PropertyAddress, AddGamePlayTagToINI_FunctionAddress, "bIsRestrictedTag");
		AddGamePlayTagToINI_bIsRestrictedTag_Offset = NativeReflectionCached.GetPropertyOffset(AddGamePlayTagToINI_FunctionAddress, "bIsRestrictedTag");
		AddGamePlayTagToINI_bIsRestrictedTag_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGamePlayTagToINI_FunctionAddress, "bIsRestrictedTag", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddGamePlayTagToINI_bAllowNonRestrictedChildren_PropertyAddress, AddGamePlayTagToINI_FunctionAddress, "bAllowNonRestrictedChildren");
		AddGamePlayTagToINI_bAllowNonRestrictedChildren_Offset = NativeReflectionCached.GetPropertyOffset(AddGamePlayTagToINI_FunctionAddress, "bAllowNonRestrictedChildren");
		AddGamePlayTagToINI_bAllowNonRestrictedChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGamePlayTagToINI_FunctionAddress, "bAllowNonRestrictedChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddGamePlayTagToINI_ReturnValue_PropertyAddress, AddGamePlayTagToINI_FunctionAddress, "ReturnValue");
		AddGamePlayTagToINI_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddGamePlayTagToINI_FunctionAddress, "ReturnValue");
		AddGamePlayTagToINI_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGamePlayTagToINI_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddGamePlayTagToINI_IsValid = AddGamePlayTagToINI_FunctionAddress != IntPtr.Zero && AddGamePlayTagToINI_NewTag_IsValid && AddGamePlayTagToINI_Comment_IsValid && AddGamePlayTagToINI_TagSourceName_IsValid && AddGamePlayTagToINI_bIsRestrictedTag_IsValid && AddGamePlayTagToINI_bAllowNonRestrictedChildren_IsValid && AddGamePlayTagToINI_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeGameplayTagLibrary:AddGamePlayTagToINI", AddGamePlayTagToINI_IsValid);
	}
}
