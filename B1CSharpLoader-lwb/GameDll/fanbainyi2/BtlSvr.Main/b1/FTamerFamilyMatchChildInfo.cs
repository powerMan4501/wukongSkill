using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TamerFamilyMatchChildInfo")]
public struct FTamerFamilyMatchChildInfo
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("筛选条件")]
	[USharpPath("/Script/b1-Managed.TamerFamilyMatchChildInfo:Filter")]
	public EChildActorFilterType Filter;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("插槽匹配规则")]
	[USharpPath("/Script/b1-Managed.TamerFamilyMatchChildInfo:MatchSocketType")]
	public ESocketMatchTamerType MatchSocketType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("插槽名")]
	[USharpPath("/Script/b1-Managed.TamerFamilyMatchChildInfo:SocketName")]
	public FName SocketName;

	[DisplayName("ResId")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerFamilyMatchChildInfo:ResId")]
	public int ResId;

	[DisplayName("别名")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TamerFamilyMatchChildInfo:NickName")]
	public FGameplayTag NickName;

	[BlueprintReadWrite]
	[DisplayName("匹配的BuffId")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerFamilyMatchChildInfo:BuffId")]
	public int BuffId;

	private static int TamerFamilyMatchChildInfo_StructSize;

	private static int TamerFamilyMatchChildInfo_IsValid;

	private static bool Filter_IsValid;

	private static int Filter_Offset;

	private static FFieldAddress Filter_PropertyAddress;

	private static bool MatchSocketType_IsValid;

	private static int MatchSocketType_Offset;

	private static FFieldAddress MatchSocketType_PropertyAddress;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool ResId_IsValid;

	private static int ResId_Offset;

	private static bool NickName_IsValid;

	private static int NickName_Offset;

	private static bool BuffId_IsValid;

	private static int BuffId_Offset;

	public static void RegisterCustomizeChildren()
	{
		RegisterPropertyTypeCustomizationDetails(EChildActorFilterType.Socket, new List<string> { "MatchSocketType", "SocketName" });
		RegisterPropertyTypeCustomizationDetails(EChildActorFilterType.ResId, new List<string> { "ResId" });
		RegisterPropertyTypeCustomizationDetails(EChildActorFilterType.NickName, new List<string> { "NickName" });
		RegisterPropertyTypeCustomizationDetails(EChildActorFilterType.Buff, new List<string> { "BuffId" });
	}

	private static void RegisterPropertyTypeCustomizationDetails(EChildActorFilterType Type, List<string> Objects)
	{
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FTamerFamilyMatchChildInfo", (int)Type, Objects.Select((string item) => new FName(item)).ToList());
	}

	public FTamerFamilyMatchChildInfo Copy()
	{
		return this;
	}

	public static FTamerFamilyMatchChildInfo FromNative(IntPtr nativeBuffer)
	{
		return new FTamerFamilyMatchChildInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTamerFamilyMatchChildInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTamerFamilyMatchChildInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTamerFamilyMatchChildInfo(IntPtr.Add(nativeBuffer, arrayIndex * TamerFamilyMatchChildInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTamerFamilyMatchChildInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TamerFamilyMatchChildInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TamerFamilyMatchChildInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TamerFamilyMatchChildInfo");
			return;
		}
		EnumMarshaler<EChildActorFilterType>.ToNative(IntPtr.Add(nativeStruct, Filter_Offset), 0, Filter_PropertyAddress.Address, Filter);
		EnumMarshaler<ESocketMatchTamerType>.ToNative(IntPtr.Add(nativeStruct, MatchSocketType_Offset), 0, MatchSocketType_PropertyAddress.Address, MatchSocketType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ResId_Offset), ResId);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, NickName_Offset), NickName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffId_Offset), BuffId);
	}

	public FTamerFamilyMatchChildInfo(IntPtr nativeStruct)
	{
		if (TamerFamilyMatchChildInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TamerFamilyMatchChildInfo");
			Filter = EChildActorFilterType.Socket;
			MatchSocketType = ESocketMatchTamerType.Prefix;
			SocketName = default(FName);
			ResId = 0;
			NickName = default(FGameplayTag);
			BuffId = 0;
		}
		else
		{
			Filter = EnumMarshaler<EChildActorFilterType>.FromNative(IntPtr.Add(nativeStruct, Filter_Offset), 0, Filter_PropertyAddress.Address);
			MatchSocketType = EnumMarshaler<ESocketMatchTamerType>.FromNative(IntPtr.Add(nativeStruct, MatchSocketType_Offset), 0, MatchSocketType_PropertyAddress.Address);
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			ResId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ResId_Offset));
			NickName = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, NickName_Offset));
			BuffId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffId_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TamerFamilyMatchChildInfo");
		TamerFamilyMatchChildInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Filter_PropertyAddress, intPtr, "Filter");
		Filter_Offset = NativeReflection.GetPropertyOffset(intPtr, "Filter");
		Filter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Filter", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MatchSocketType_PropertyAddress, intPtr, "MatchSocketType");
		MatchSocketType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatchSocketType");
		MatchSocketType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatchSocketType", Classes.FEnumProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		ResId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResId");
		ResId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResId", Classes.FIntProperty);
		NickName_Offset = NativeReflection.GetPropertyOffset(intPtr, "NickName");
		NickName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NickName", Classes.FStructProperty);
		BuffId_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffId");
		BuffId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffId", Classes.FIntProperty);
		TamerFamilyMatchChildInfo_IsValid = ((intPtr != IntPtr.Zero && Filter_IsValid && MatchSocketType_IsValid && SocketName_IsValid && ResId_IsValid && NickName_IsValid && BuffId_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TamerFamilyMatchChildInfo", (byte)TamerFamilyMatchChildInfo_IsValid != 0);
	}

	static FTamerFamilyMatchChildInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTamerFamilyMatchChildInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTamerFamilyMatchChildInfo));
	}
}
