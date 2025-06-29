using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.Skeleton", "Engine", UnrealModuleType.Engine)]
public class USkeleton : UObject, IInterface_AssetUserData, IInterface, IInterface_PreviewMeshProvider
{
	private static bool CompatibleSkeletons_IsValid;

	private static FFieldAddress CompatibleSkeletons_PropertyAddress;

	private static int CompatibleSkeletons_Offset;

	private TArrayReadOnlyMarshaler<TSoftObject<USkeleton>> CompatibleSkeletons_MarshalerCached;

	private static bool GetBlendProfile_IsValid;

	private static IntPtr GetBlendProfile_FunctionAddress;

	private static int GetBlendProfile_ParamsSize;

	private static bool GetBlendProfile_InProfileName_IsValid;

	private static FFieldAddress GetBlendProfile_InProfileName_PropertyAddress;

	private static int GetBlendProfile_InProfileName_Offset;

	private static bool GetBlendProfile_ReturnValue_IsValid;

	private static FFieldAddress GetBlendProfile_ReturnValue_PropertyAddress;

	private static int GetBlendProfile_ReturnValue_Offset;

	private static bool AddCompatibleSkeleton_IsValid;

	private static IntPtr AddCompatibleSkeleton_FunctionAddress;

	private static int AddCompatibleSkeleton_ParamsSize;

	private static bool AddCompatibleSkeleton_SourceSkeleton_IsValid;

	private static FFieldAddress AddCompatibleSkeleton_SourceSkeleton_PropertyAddress;

	private static int AddCompatibleSkeleton_SourceSkeleton_Offset;

	[UProperty(Flags = (PropFlags)10141895254606357uL)]
	[UMetaPath("/Script/Engine.Skeleton:CompatibleSkeletons")]
	protected TArrayReadOnly<TSoftObject<USkeleton>> CompatibleSkeletons
	{
		get
		{
			CheckDestroyed();
			if (!CompatibleSkeletons_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Skeleton:CompatibleSkeletons");
				return null;
			}
			if (CompatibleSkeletons_MarshalerCached == null)
			{
				CompatibleSkeletons_MarshalerCached = new TArrayReadOnlyMarshaler<TSoftObject<USkeleton>>(1, CompatibleSkeletons_PropertyAddress, CachedMarshalingDelegates<TSoftObject<USkeleton>, TSoftObjectMarshaler<USkeleton>>.FromNative, CachedMarshalingDelegates<TSoftObject<USkeleton>, TSoftObjectMarshaler<USkeleton>>.ToNative);
			}
			return CompatibleSkeletons_MarshalerCached.FromNative(IntPtr.Add(base.Address, CompatibleSkeletons_Offset));
		}
	}

	[UFunction(Flags = 339870723u)]
	[UMetaPath("/Script/Engine.Skeleton:GetBlendProfile")]
	public unsafe UBlendProfile GetBlendProfile(FName InProfileName)
	{
		CheckDestroyed();
		if (!GetBlendProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Skeleton:GetBlendProfile");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlendProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlendProfile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBlendProfile_InProfileName_Offset), 0, GetBlendProfile_InProfileName_PropertyAddress.Address, InProfileName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBlendProfile_FunctionAddress, intPtr, GetBlendProfile_ParamsSize);
		return UObjectMarshaler<UBlendProfile>.FromNative(IntPtr.Add(intPtr, GetBlendProfile_ReturnValue_Offset), 0, GetBlendProfile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240963u)]
	[UMetaPath("/Script/Engine.Skeleton:AddCompatibleSkeleton")]
	public unsafe void AddCompatibleSkeleton(USkeleton SourceSkeleton)
	{
		CheckDestroyed();
		if (!AddCompatibleSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Skeleton:AddCompatibleSkeleton");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCompatibleSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCompatibleSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, AddCompatibleSkeleton_SourceSkeleton_Offset), 0, AddCompatibleSkeleton_SourceSkeleton_PropertyAddress.Address, SourceSkeleton);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddCompatibleSkeleton_FunctionAddress, intPtr, AddCompatibleSkeleton_ParamsSize);
	}

	static USkeleton()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USkeleton)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USkeleton));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Skeleton");
		NativeReflectionCached.GetPropertyRef(ref CompatibleSkeletons_PropertyAddress, intPtr, "CompatibleSkeletons");
		CompatibleSkeletons_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CompatibleSkeletons");
		CompatibleSkeletons_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CompatibleSkeletons", Classes.FArrayProperty);
		GetBlendProfile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBlendProfile");
		GetBlendProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlendProfile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlendProfile_InProfileName_PropertyAddress, GetBlendProfile_FunctionAddress, "InProfileName");
		GetBlendProfile_InProfileName_Offset = NativeReflectionCached.GetPropertyOffset(GetBlendProfile_FunctionAddress, "InProfileName");
		GetBlendProfile_InProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlendProfile_FunctionAddress, "InProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlendProfile_ReturnValue_PropertyAddress, GetBlendProfile_FunctionAddress, "ReturnValue");
		GetBlendProfile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlendProfile_FunctionAddress, "ReturnValue");
		GetBlendProfile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlendProfile_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBlendProfile_IsValid = GetBlendProfile_FunctionAddress != IntPtr.Zero && GetBlendProfile_InProfileName_IsValid && GetBlendProfile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Skeleton:GetBlendProfile", GetBlendProfile_IsValid);
		AddCompatibleSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddCompatibleSkeleton");
		AddCompatibleSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCompatibleSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCompatibleSkeleton_SourceSkeleton_PropertyAddress, AddCompatibleSkeleton_FunctionAddress, "SourceSkeleton");
		AddCompatibleSkeleton_SourceSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(AddCompatibleSkeleton_FunctionAddress, "SourceSkeleton");
		AddCompatibleSkeleton_SourceSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCompatibleSkeleton_FunctionAddress, "SourceSkeleton", Classes.FObjectProperty);
		AddCompatibleSkeleton_IsValid = AddCompatibleSkeleton_FunctionAddress != IntPtr.Zero && AddCompatibleSkeleton_SourceSkeleton_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Skeleton:AddCompatibleSkeleton", AddCompatibleSkeleton_IsValid);
	}
}
