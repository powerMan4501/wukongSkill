using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig")]
public struct FGSBuffTriggerConfig
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("添加的Buff")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:AddBuffIDList")]
	public List<int> AddBuffIDList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("添加Buff的时机")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:AddBuffCondition")]
	public EBuffControlCondition AddBuffCondition;

	[UProperty]
	[DisplayName("添加Buff的对象")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:AddBuffTarget")]
	public EBuffTarget AddBuffTarget;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "AddBuffTarget == BuffTarget::SceneUnit")]
	[DisplayName("Add手动选择的对象")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:AddSceneTamer")]
	public List<TSoftObject<BUTamerActor>> AddSceneTamer;

	[DisplayName("Add手动选择的对象")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "AddBuffTarget == BuffTarget::SceneUnit")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:AddSceneTamerRef")]
	public List<FGsActorGuidReference> AddSceneTamerRef;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("移除的Buff")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:RemoveBuffIDList")]
	public List<int> RemoveBuffIDList;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("移除Buff的时机")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:RemoveBuffCondition")]
	public EBuffControlCondition RemoveBuffCondition;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("移除Buff的对象")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:RemoveBuffTarget")]
	public EBuffTarget RemoveBuffTarget;

	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "RemoveBuffTarget == BuffTarget::SceneUnit")]
	[DisplayName("Remove手动选择的对象")]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:RemoveSceneTamer")]
	public List<TSoftObject<BUTamerActor>> RemoveSceneTamer;

	[UMeta(MDProp.EditCondition, "RemoveBuffTarget == BuffTarget::SceneUnit")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Remove手动选择的对象")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:RemoveSceneTamerRef")]
	public List<FGsActorGuidReference> RemoveSceneTamerRef;

	[BlueprintReadWrite]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:AddSceneUnit")]
	public List<TSoftObject<BGUCharacterCS>> AddSceneUnit;

	[BlueprintReadWrite]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.FGSBuffTriggerConfig:RemoveSceneUnit")]
	public List<TSoftObject<BGUCharacterCS>> RemoveSceneUnit;

	private static int FGSBuffTriggerConfig_StructSize;

	private static int FGSBuffTriggerConfig_IsValid;

	private static bool AddBuffIDList_IsValid;

	private static int AddBuffIDList_Offset;

	private static FFieldAddress AddBuffIDList_PropertyAddress;

	private static bool AddBuffCondition_IsValid;

	private static int AddBuffCondition_Offset;

	private static FFieldAddress AddBuffCondition_PropertyAddress;

	private static bool AddBuffTarget_IsValid;

	private static int AddBuffTarget_Offset;

	private static FFieldAddress AddBuffTarget_PropertyAddress;

	private static bool AddSceneTamer_IsValid;

	private static int AddSceneTamer_Offset;

	private static FFieldAddress AddSceneTamer_PropertyAddress;

	private static bool AddSceneTamerRef_IsValid;

	private static int AddSceneTamerRef_Offset;

	private static FFieldAddress AddSceneTamerRef_PropertyAddress;

	private static bool RemoveBuffIDList_IsValid;

	private static int RemoveBuffIDList_Offset;

	private static FFieldAddress RemoveBuffIDList_PropertyAddress;

	private static bool RemoveBuffCondition_IsValid;

	private static int RemoveBuffCondition_Offset;

	private static FFieldAddress RemoveBuffCondition_PropertyAddress;

	private static bool RemoveBuffTarget_IsValid;

	private static int RemoveBuffTarget_Offset;

	private static FFieldAddress RemoveBuffTarget_PropertyAddress;

	private static bool RemoveSceneTamer_IsValid;

	private static int RemoveSceneTamer_Offset;

	private static FFieldAddress RemoveSceneTamer_PropertyAddress;

	private static bool RemoveSceneTamerRef_IsValid;

	private static int RemoveSceneTamerRef_Offset;

	private static FFieldAddress RemoveSceneTamerRef_PropertyAddress;

	private static bool AddSceneUnit_IsValid;

	private static int AddSceneUnit_Offset;

	private static FFieldAddress AddSceneUnit_PropertyAddress;

	private static bool RemoveSceneUnit_IsValid;

	private static int RemoveSceneUnit_Offset;

	private static FFieldAddress RemoveSceneUnit_PropertyAddress;

	public FGSBuffTriggerConfig Copy()
	{
		FGSBuffTriggerConfig result = this;
		if (AddBuffIDList != null)
		{
			result.AddBuffIDList = new List<int>(AddBuffIDList);
		}
		if (AddSceneTamer != null)
		{
			result.AddSceneTamer = new List<TSoftObject<BUTamerActor>>(AddSceneTamer);
		}
		if (AddSceneTamerRef != null)
		{
			result.AddSceneTamerRef = new List<FGsActorGuidReference>(AddSceneTamerRef);
		}
		if (RemoveBuffIDList != null)
		{
			result.RemoveBuffIDList = new List<int>(RemoveBuffIDList);
		}
		if (RemoveSceneTamer != null)
		{
			result.RemoveSceneTamer = new List<TSoftObject<BUTamerActor>>(RemoveSceneTamer);
		}
		if (RemoveSceneTamerRef != null)
		{
			result.RemoveSceneTamerRef = new List<FGsActorGuidReference>(RemoveSceneTamerRef);
		}
		if (AddSceneUnit != null)
		{
			result.AddSceneUnit = new List<TSoftObject<BGUCharacterCS>>(AddSceneUnit);
		}
		if (RemoveSceneUnit != null)
		{
			result.RemoveSceneUnit = new List<TSoftObject<BGUCharacterCS>>(RemoveSceneUnit);
		}
		return result;
	}

	public static FGSBuffTriggerConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSBuffTriggerConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSBuffTriggerConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSBuffTriggerConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSBuffTriggerConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSBuffTriggerConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSBuffTriggerConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSBuffTriggerConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSBuffTriggerConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSBuffTriggerConfig");
			return;
		}
		new TArrayCopyMarshaler<int>(1, AddBuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AddBuffIDList_Offset), AddBuffIDList);
		EnumMarshaler<EBuffControlCondition>.ToNative(IntPtr.Add(nativeStruct, AddBuffCondition_Offset), 0, AddBuffCondition_PropertyAddress.Address, AddBuffCondition);
		EnumMarshaler<EBuffTarget>.ToNative(IntPtr.Add(nativeStruct, AddBuffTarget_Offset), 0, AddBuffTarget_PropertyAddress.Address, AddBuffTarget);
		new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, AddSceneTamer_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AddSceneTamer_Offset), AddSceneTamer);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, AddSceneTamerRef_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, AddSceneTamerRef_Offset), AddSceneTamerRef);
		new TArrayCopyMarshaler<int>(1, RemoveBuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, RemoveBuffIDList_Offset), RemoveBuffIDList);
		EnumMarshaler<EBuffControlCondition>.ToNative(IntPtr.Add(nativeStruct, RemoveBuffCondition_Offset), 0, RemoveBuffCondition_PropertyAddress.Address, RemoveBuffCondition);
		EnumMarshaler<EBuffTarget>.ToNative(IntPtr.Add(nativeStruct, RemoveBuffTarget_Offset), 0, RemoveBuffTarget_PropertyAddress.Address, RemoveBuffTarget);
		new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, RemoveSceneTamer_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, RemoveSceneTamer_Offset), RemoveSceneTamer);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, RemoveSceneTamerRef_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, RemoveSceneTamerRef_Offset), RemoveSceneTamerRef);
		new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, AddSceneUnit_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AddSceneUnit_Offset), AddSceneUnit);
		new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, RemoveSceneUnit_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, RemoveSceneUnit_Offset), RemoveSceneUnit);
	}

	public FGSBuffTriggerConfig(IntPtr nativeStruct)
	{
		if (FGSBuffTriggerConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSBuffTriggerConfig");
			AddBuffIDList = null;
			AddBuffCondition = EBuffControlCondition.EnterCollisionArea;
			AddBuffTarget = EBuffTarget.Player;
			AddSceneTamer = null;
			AddSceneTamerRef = null;
			RemoveBuffIDList = null;
			RemoveBuffCondition = EBuffControlCondition.EnterCollisionArea;
			RemoveBuffTarget = EBuffTarget.Player;
			RemoveSceneTamer = null;
			RemoveSceneTamerRef = null;
			AddSceneUnit = null;
			RemoveSceneUnit = null;
		}
		else
		{
			AddBuffIDList = new TArrayCopyMarshaler<int>(1, AddBuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AddBuffIDList_Offset));
			AddBuffCondition = EnumMarshaler<EBuffControlCondition>.FromNative(IntPtr.Add(nativeStruct, AddBuffCondition_Offset), 0, AddBuffCondition_PropertyAddress.Address);
			AddBuffTarget = EnumMarshaler<EBuffTarget>.FromNative(IntPtr.Add(nativeStruct, AddBuffTarget_Offset), 0, AddBuffTarget_PropertyAddress.Address);
			AddSceneTamer = new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, AddSceneTamer_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AddSceneTamer_Offset));
			AddSceneTamerRef = new TArrayCopyMarshaler<FGsActorGuidReference>(1, AddSceneTamerRef_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, AddSceneTamerRef_Offset));
			RemoveBuffIDList = new TArrayCopyMarshaler<int>(1, RemoveBuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, RemoveBuffIDList_Offset));
			RemoveBuffCondition = EnumMarshaler<EBuffControlCondition>.FromNative(IntPtr.Add(nativeStruct, RemoveBuffCondition_Offset), 0, RemoveBuffCondition_PropertyAddress.Address);
			RemoveBuffTarget = EnumMarshaler<EBuffTarget>.FromNative(IntPtr.Add(nativeStruct, RemoveBuffTarget_Offset), 0, RemoveBuffTarget_PropertyAddress.Address);
			RemoveSceneTamer = new TArrayCopyMarshaler<TSoftObject<BUTamerActor>>(1, RemoveSceneTamer_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<BUTamerActor>, TSoftObjectMarshaler<BUTamerActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, RemoveSceneTamer_Offset));
			RemoveSceneTamerRef = new TArrayCopyMarshaler<FGsActorGuidReference>(1, RemoveSceneTamerRef_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, RemoveSceneTamerRef_Offset));
			AddSceneUnit = new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, AddSceneUnit_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AddSceneUnit_Offset));
			RemoveSceneUnit = new TArrayCopyMarshaler<TSoftObject<BGUCharacterCS>>(1, RemoveSceneUnit_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUCharacterCS>, TSoftObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, RemoveSceneUnit_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSBuffTriggerConfig");
		FGSBuffTriggerConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AddBuffIDList_PropertyAddress, intPtr, "AddBuffIDList");
		AddBuffIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddBuffIDList");
		AddBuffIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddBuffIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AddBuffCondition_PropertyAddress, intPtr, "AddBuffCondition");
		AddBuffCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddBuffCondition");
		AddBuffCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddBuffCondition", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AddBuffTarget_PropertyAddress, intPtr, "AddBuffTarget");
		AddBuffTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddBuffTarget");
		AddBuffTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddBuffTarget", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AddSceneTamer_PropertyAddress, intPtr, "AddSceneTamer");
		AddSceneTamer_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddSceneTamer");
		AddSceneTamer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddSceneTamer", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AddSceneTamerRef_PropertyAddress, intPtr, "AddSceneTamerRef");
		AddSceneTamerRef_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddSceneTamerRef");
		AddSceneTamerRef_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddSceneTamerRef", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RemoveBuffIDList_PropertyAddress, intPtr, "RemoveBuffIDList");
		RemoveBuffIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "RemoveBuffIDList");
		RemoveBuffIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RemoveBuffIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RemoveBuffCondition_PropertyAddress, intPtr, "RemoveBuffCondition");
		RemoveBuffCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "RemoveBuffCondition");
		RemoveBuffCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RemoveBuffCondition", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref RemoveBuffTarget_PropertyAddress, intPtr, "RemoveBuffTarget");
		RemoveBuffTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "RemoveBuffTarget");
		RemoveBuffTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RemoveBuffTarget", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref RemoveSceneTamer_PropertyAddress, intPtr, "RemoveSceneTamer");
		RemoveSceneTamer_Offset = NativeReflection.GetPropertyOffset(intPtr, "RemoveSceneTamer");
		RemoveSceneTamer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RemoveSceneTamer", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RemoveSceneTamerRef_PropertyAddress, intPtr, "RemoveSceneTamerRef");
		RemoveSceneTamerRef_Offset = NativeReflection.GetPropertyOffset(intPtr, "RemoveSceneTamerRef");
		RemoveSceneTamerRef_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RemoveSceneTamerRef", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AddSceneUnit_PropertyAddress, intPtr, "AddSceneUnit");
		AddSceneUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "AddSceneUnit");
		AddSceneUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AddSceneUnit", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RemoveSceneUnit_PropertyAddress, intPtr, "RemoveSceneUnit");
		RemoveSceneUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "RemoveSceneUnit");
		RemoveSceneUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RemoveSceneUnit", Classes.FArrayProperty);
		FGSBuffTriggerConfig_IsValid = ((intPtr != IntPtr.Zero && AddBuffIDList_IsValid && AddBuffCondition_IsValid && AddBuffTarget_IsValid && AddSceneTamer_IsValid && AddSceneTamerRef_IsValid && RemoveBuffIDList_IsValid && RemoveBuffCondition_IsValid && RemoveBuffTarget_IsValid && RemoveSceneTamer_IsValid && RemoveSceneTamerRef_IsValid && AddSceneUnit_IsValid && RemoveSceneUnit_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSBuffTriggerConfig", (byte)FGSBuffTriggerConfig_IsValid != 0);
	}

	static FGSBuffTriggerConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSBuffTriggerConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSBuffTriggerConfig));
	}
}
