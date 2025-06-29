using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CircusCollector")]
public struct CircusCollector
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CircusCollector:IsRootMember")]
	public bool IsRootMember;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CircusCollector:SpawnByDefault")]
	public bool SpawnByDefault;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CircusCollector:Socket")]
	public FName Socket;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CircusCollector:ResId")]
	public int ResId;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CircusCollector:Member")]
	public AActor Member;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CircusCollector:MemberType")]
	public CircusMemberType MemberType;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CircusCollector:NickName")]
	public List<FGameplayTag> NickName;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CircusCollector:ChildMembers")]
	public List<AActor> ChildMembers;

	private static int CircusCollector_StructSize;

	private static int CircusCollector_IsValid;

	private static bool IsRootMember_IsValid;

	private static int IsRootMember_Offset;

	private static FFieldAddress IsRootMember_PropertyAddress;

	private static bool SpawnByDefault_IsValid;

	private static int SpawnByDefault_Offset;

	private static FFieldAddress SpawnByDefault_PropertyAddress;

	private static bool Socket_IsValid;

	private static int Socket_Offset;

	private static bool ResId_IsValid;

	private static int ResId_Offset;

	private static bool Member_IsValid;

	private static int Member_Offset;

	private static bool MemberType_IsValid;

	private static int MemberType_Offset;

	private static FFieldAddress MemberType_PropertyAddress;

	private static bool NickName_IsValid;

	private static int NickName_Offset;

	private static FFieldAddress NickName_PropertyAddress;

	private static bool ChildMembers_IsValid;

	private static int ChildMembers_Offset;

	private static FFieldAddress ChildMembers_PropertyAddress;

	public string GetCircusMemberGuid()
	{
		string result = string.Empty;
		if (MemberType == CircusMemberType.Tamer)
		{
			result = (Member as BUTamerActor).GetFinalGuid();
		}
		else
		{
			IBUC_GuidData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(Member);
			if (readOnlyData != null)
			{
				result = readOnlyData.GetFinalGuid();
			}
		}
		return result;
	}

	public CircusCollector Copy()
	{
		CircusCollector result = this;
		if (NickName != null)
		{
			result.NickName = new List<FGameplayTag>(NickName);
		}
		if (ChildMembers != null)
		{
			result.ChildMembers = new List<AActor>(ChildMembers);
		}
		return result;
	}

	public static CircusCollector FromNative(IntPtr nativeBuffer)
	{
		return new CircusCollector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, CircusCollector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static CircusCollector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new CircusCollector(IntPtr.Add(nativeBuffer, arrayIndex * CircusCollector_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, CircusCollector value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CircusCollector_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CircusCollector_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CircusCollector");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsRootMember_Offset), 0, IsRootMember_PropertyAddress.Address, IsRootMember);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SpawnByDefault_Offset), 0, SpawnByDefault_PropertyAddress.Address, SpawnByDefault);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Socket_Offset), Socket);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ResId_Offset), ResId);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Member_Offset), Member);
		EnumMarshaler<CircusMemberType>.ToNative(IntPtr.Add(nativeStruct, MemberType_Offset), 0, MemberType_PropertyAddress.Address, MemberType);
		new TArrayCopyMarshaler<FGameplayTag>(1, NickName_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).ToNative(IntPtr.Add(nativeStruct, NickName_Offset), NickName);
		new TArrayCopyMarshaler<AActor>(1, ChildMembers_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ChildMembers_Offset), ChildMembers);
	}

	public CircusCollector(IntPtr nativeStruct)
	{
		if (CircusCollector_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CircusCollector");
			IsRootMember = false;
			SpawnByDefault = false;
			Socket = default(FName);
			ResId = 0;
			Member = null;
			MemberType = CircusMemberType.Unknown;
			NickName = null;
			ChildMembers = null;
		}
		else
		{
			IsRootMember = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsRootMember_Offset), 0, IsRootMember_PropertyAddress.Address);
			SpawnByDefault = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SpawnByDefault_Offset), 0, SpawnByDefault_PropertyAddress.Address);
			Socket = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Socket_Offset));
			ResId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ResId_Offset));
			Member = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Member_Offset));
			MemberType = EnumMarshaler<CircusMemberType>.FromNative(IntPtr.Add(nativeStruct, MemberType_Offset), 0, MemberType_PropertyAddress.Address);
			NickName = new TArrayCopyMarshaler<FGameplayTag>(1, NickName_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).FromNative(IntPtr.Add(nativeStruct, NickName_Offset));
			ChildMembers = new TArrayCopyMarshaler<AActor>(1, ChildMembers_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ChildMembers_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CircusCollector");
		CircusCollector_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref IsRootMember_PropertyAddress, intPtr, "IsRootMember");
		IsRootMember_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRootMember");
		IsRootMember_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRootMember", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SpawnByDefault_PropertyAddress, intPtr, "SpawnByDefault");
		SpawnByDefault_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnByDefault");
		SpawnByDefault_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnByDefault", Classes.FBoolProperty);
		Socket_Offset = NativeReflection.GetPropertyOffset(intPtr, "Socket");
		Socket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Socket", Classes.FNameProperty);
		ResId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResId");
		ResId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResId", Classes.FIntProperty);
		Member_Offset = NativeReflection.GetPropertyOffset(intPtr, "Member");
		Member_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Member", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref MemberType_PropertyAddress, intPtr, "MemberType");
		MemberType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MemberType");
		MemberType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MemberType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref NickName_PropertyAddress, intPtr, "NickName");
		NickName_Offset = NativeReflection.GetPropertyOffset(intPtr, "NickName");
		NickName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NickName", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ChildMembers_PropertyAddress, intPtr, "ChildMembers");
		ChildMembers_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChildMembers");
		ChildMembers_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChildMembers", Classes.FArrayProperty);
		CircusCollector_IsValid = ((intPtr != IntPtr.Zero && IsRootMember_IsValid && SpawnByDefault_IsValid && Socket_IsValid && ResId_IsValid && Member_IsValid && MemberType_IsValid && NickName_IsValid && ChildMembers_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CircusCollector", (byte)CircusCollector_IsValid != 0);
	}

	static CircusCollector()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(CircusCollector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(CircusCollector));
	}
}
