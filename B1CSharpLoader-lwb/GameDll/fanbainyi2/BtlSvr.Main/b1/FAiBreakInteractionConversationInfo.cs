using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AiBreakInteractionConversationInfo")]
public struct FAiBreakInteractionConversationInfo
{
	[DisplayName("中断原因")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AiBreakInteractionConversationInfo:AiBreakInteractionType")]
	public EAiBreakInteractionType AiBreakInteractionType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Ai对话IDList")]
	[USharpPath("/Script/b1-Managed.AiBreakInteractionConversationInfo:AiConversationIDList")]
	public List<int> AiConversationIDList;

	private static int AiBreakInteractionConversationInfo_StructSize;

	private static int AiBreakInteractionConversationInfo_IsValid;

	private static bool AiBreakInteractionType_IsValid;

	private static int AiBreakInteractionType_Offset;

	private static FFieldAddress AiBreakInteractionType_PropertyAddress;

	private static bool AiConversationIDList_IsValid;

	private static int AiConversationIDList_Offset;

	private static FFieldAddress AiConversationIDList_PropertyAddress;

	public FAiBreakInteractionConversationInfo Copy()
	{
		FAiBreakInteractionConversationInfo result = this;
		if (AiConversationIDList != null)
		{
			result.AiConversationIDList = new List<int>(AiConversationIDList);
		}
		return result;
	}

	public static FAiBreakInteractionConversationInfo FromNative(IntPtr nativeBuffer)
	{
		return new FAiBreakInteractionConversationInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAiBreakInteractionConversationInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAiBreakInteractionConversationInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAiBreakInteractionConversationInfo(IntPtr.Add(nativeBuffer, arrayIndex * AiBreakInteractionConversationInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAiBreakInteractionConversationInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AiBreakInteractionConversationInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AiBreakInteractionConversationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AiBreakInteractionConversationInfo");
			return;
		}
		EnumMarshaler<EAiBreakInteractionType>.ToNative(IntPtr.Add(nativeStruct, AiBreakInteractionType_Offset), 0, AiBreakInteractionType_PropertyAddress.Address, AiBreakInteractionType);
		new TArrayCopyMarshaler<int>(1, AiConversationIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AiConversationIDList_Offset), AiConversationIDList);
	}

	public FAiBreakInteractionConversationInfo(IntPtr nativeStruct)
	{
		if (AiBreakInteractionConversationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AiBreakInteractionConversationInfo");
			AiBreakInteractionType = EAiBreakInteractionType.Battle;
			AiConversationIDList = null;
		}
		else
		{
			AiBreakInteractionType = EnumMarshaler<EAiBreakInteractionType>.FromNative(IntPtr.Add(nativeStruct, AiBreakInteractionType_Offset), 0, AiBreakInteractionType_PropertyAddress.Address);
			AiConversationIDList = new TArrayCopyMarshaler<int>(1, AiConversationIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AiConversationIDList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AiBreakInteractionConversationInfo");
		AiBreakInteractionConversationInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AiBreakInteractionType_PropertyAddress, intPtr, "AiBreakInteractionType");
		AiBreakInteractionType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AiBreakInteractionType");
		AiBreakInteractionType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AiBreakInteractionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AiConversationIDList_PropertyAddress, intPtr, "AiConversationIDList");
		AiConversationIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AiConversationIDList");
		AiConversationIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AiConversationIDList", Classes.FArrayProperty);
		AiBreakInteractionConversationInfo_IsValid = ((intPtr != IntPtr.Zero && AiBreakInteractionType_IsValid && AiConversationIDList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AiBreakInteractionConversationInfo", (byte)AiBreakInteractionConversationInfo_IsValid != 0);
	}

	static FAiBreakInteractionConversationInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAiBreakInteractionConversationInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAiBreakInteractionConversationInfo));
	}
}
