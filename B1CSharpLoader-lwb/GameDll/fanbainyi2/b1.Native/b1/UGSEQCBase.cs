using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.GSEQCBase", "b1", UnrealModuleType.Game)]
public class UGSEQCBase : UEnvQueryContext
{
	private static bool EQCQueryType_IsValid;

	private static FFieldAddress EQCQueryType_PropertyAddress;

	private static int EQCQueryType_Offset;

	private static bool SingleActorResult_IsValid;

	private static int SingleActorResult_Offset;

	private static bool SingleLocationResult_IsValid;

	private static int SingleLocationResult_Offset;

	private static bool ActorsSetResult_IsValid;

	private static FFieldAddress ActorsSetResult_PropertyAddress;

	private static int ActorsSetResult_Offset;

	private TArrayReadWriteMarshaler<AActor> ActorsSetResult_MarshalerCached;

	private static bool LocationsSetResult_IsValid;

	private static FFieldAddress LocationsSetResult_PropertyAddress;

	private static int LocationsSetResult_Offset;

	private TArrayReadWriteMarshaler<FVector> LocationsSetResult_MarshalerCached;

	private static bool ProvideSingleLocationCS_IsValid;

	private IntPtr ProvideSingleLocationCS_InstanceFunctionAddress;

	private static IntPtr ProvideSingleLocationCS_FunctionAddress;

	private static int ProvideSingleLocationCS_ParamsSize;

	private static bool ProvideSingleLocationCS_QuerierObject_IsValid;

	private static FFieldAddress ProvideSingleLocationCS_QuerierObject_PropertyAddress;

	private static int ProvideSingleLocationCS_QuerierObject_Offset;

	private static bool ProvideSingleLocationCS_QuerierActor_IsValid;

	private static FFieldAddress ProvideSingleLocationCS_QuerierActor_PropertyAddress;

	private static int ProvideSingleLocationCS_QuerierActor_Offset;

	private static bool ProvideSingleActorCS_IsValid;

	private IntPtr ProvideSingleActorCS_InstanceFunctionAddress;

	private static IntPtr ProvideSingleActorCS_FunctionAddress;

	private static int ProvideSingleActorCS_ParamsSize;

	private static bool ProvideSingleActorCS_QuerierObject_IsValid;

	private static FFieldAddress ProvideSingleActorCS_QuerierObject_PropertyAddress;

	private static int ProvideSingleActorCS_QuerierObject_Offset;

	private static bool ProvideSingleActorCS_QuerierActor_IsValid;

	private static FFieldAddress ProvideSingleActorCS_QuerierActor_PropertyAddress;

	private static int ProvideSingleActorCS_QuerierActor_Offset;

	private static bool ProvideLocationsSetCS_IsValid;

	private IntPtr ProvideLocationsSetCS_InstanceFunctionAddress;

	private static IntPtr ProvideLocationsSetCS_FunctionAddress;

	private static int ProvideLocationsSetCS_ParamsSize;

	private static bool ProvideLocationsSetCS_QuerierObject_IsValid;

	private static FFieldAddress ProvideLocationsSetCS_QuerierObject_PropertyAddress;

	private static int ProvideLocationsSetCS_QuerierObject_Offset;

	private static bool ProvideLocationsSetCS_QuerierActor_IsValid;

	private static FFieldAddress ProvideLocationsSetCS_QuerierActor_PropertyAddress;

	private static int ProvideLocationsSetCS_QuerierActor_Offset;

	private static bool ProvideActorsSetCS_IsValid;

	private IntPtr ProvideActorsSetCS_InstanceFunctionAddress;

	private static IntPtr ProvideActorsSetCS_FunctionAddress;

	private static int ProvideActorsSetCS_ParamsSize;

	private static bool ProvideActorsSetCS_QuerierObject_IsValid;

	private static FFieldAddress ProvideActorsSetCS_QuerierObject_PropertyAddress;

	private static int ProvideActorsSetCS_QuerierObject_Offset;

	private static bool ProvideActorsSetCS_QuerierActor_IsValid;

	private static FFieldAddress ProvideActorsSetCS_QuerierActor_PropertyAddress;

	private static int ProvideActorsSetCS_QuerierActor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.GSEQCBase:EQCQueryType")]
	public EBGUEQCQueryType EQCQueryType
	{
		get
		{
			CheckDestroyed();
			if (!EQCQueryType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQCBase:EQCQueryType");
				return EBGUEQCQueryType.None;
			}
			return EnumMarshaler<EBGUEQCQueryType>.FromNative(IntPtr.Add(base.Address, EQCQueryType_Offset), 0, EQCQueryType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EQCQueryType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQCBase:EQCQueryType");
			}
			else
			{
				EnumMarshaler<EBGUEQCQueryType>.ToNative(IntPtr.Add(base.Address, EQCQueryType_Offset), 0, EQCQueryType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.GSEQCBase:SingleActorResult")]
	public AActor SingleActorResult
	{
		get
		{
			CheckDestroyed();
			if (!SingleActorResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQCBase:SingleActorResult");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, SingleActorResult_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SingleActorResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQCBase:SingleActorResult");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, SingleActorResult_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.GSEQCBase:SingleLocationResult")]
	public FVector SingleLocationResult
	{
		get
		{
			CheckDestroyed();
			if (!SingleLocationResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQCBase:SingleLocationResult");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, SingleLocationResult_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SingleLocationResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQCBase:SingleLocationResult");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, SingleLocationResult_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/b1.GSEQCBase:ActorsSetResult")]
	public TArrayReadWrite<AActor> ActorsSetResult
	{
		get
		{
			CheckDestroyed();
			if (!ActorsSetResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQCBase:ActorsSetResult");
				return null;
			}
			if (ActorsSetResult_MarshalerCached == null)
			{
				ActorsSetResult_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, ActorsSetResult_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return ActorsSetResult_MarshalerCached.FromNative(IntPtr.Add(base.Address, ActorsSetResult_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/b1.GSEQCBase:LocationsSetResult")]
	public TArrayReadWrite<FVector> LocationsSetResult
	{
		get
		{
			CheckDestroyed();
			if (!LocationsSetResult_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQCBase:LocationsSetResult");
				return null;
			}
			if (LocationsSetResult_MarshalerCached == null)
			{
				LocationsSetResult_MarshalerCached = new TArrayReadWriteMarshaler<FVector>(1, LocationsSetResult_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return LocationsSetResult_MarshalerCached.FromNative(IntPtr.Add(base.Address, LocationsSetResult_Offset));
		}
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.GSEQCBase:ProvideSingleLocationCS")]
	public unsafe void ProvideSingleLocationCS(UObject QuerierObject, AActor QuerierActor)
	{
		CheckDestroyed();
		if (!ProvideSingleLocationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQCBase:ProvideSingleLocationCS");
			return;
		}
		if (ProvideSingleLocationCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProvideSingleLocationCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProvideSingleLocationCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideSingleLocationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideSingleLocationCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideSingleLocationCS_QuerierObject_Offset), 0, ProvideSingleLocationCS_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideSingleLocationCS_QuerierActor_Offset), 0, ProvideSingleLocationCS_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideSingleLocationCS_InstanceFunctionAddress, intPtr, ProvideSingleLocationCS_ParamsSize);
	}

	protected unsafe virtual void ProvideSingleLocationCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		CheckDestroyed();
		if (!ProvideSingleLocationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQCBase:ProvideSingleLocationCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideSingleLocationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideSingleLocationCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideSingleLocationCS_QuerierObject_Offset), 0, ProvideSingleLocationCS_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideSingleLocationCS_QuerierActor_Offset), 0, ProvideSingleLocationCS_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideSingleLocationCS_FunctionAddress, intPtr, ProvideSingleLocationCS_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.GSEQCBase:ProvideSingleActorCS")]
	public unsafe void ProvideSingleActorCS(UObject QuerierObject, AActor QuerierActor)
	{
		CheckDestroyed();
		if (!ProvideSingleActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQCBase:ProvideSingleActorCS");
			return;
		}
		if (ProvideSingleActorCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProvideSingleActorCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProvideSingleActorCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideSingleActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideSingleActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideSingleActorCS_QuerierObject_Offset), 0, ProvideSingleActorCS_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideSingleActorCS_QuerierActor_Offset), 0, ProvideSingleActorCS_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideSingleActorCS_InstanceFunctionAddress, intPtr, ProvideSingleActorCS_ParamsSize);
	}

	protected unsafe virtual void ProvideSingleActorCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		CheckDestroyed();
		if (!ProvideSingleActorCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQCBase:ProvideSingleActorCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideSingleActorCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideSingleActorCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideSingleActorCS_QuerierObject_Offset), 0, ProvideSingleActorCS_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideSingleActorCS_QuerierActor_Offset), 0, ProvideSingleActorCS_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideSingleActorCS_FunctionAddress, intPtr, ProvideSingleActorCS_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.GSEQCBase:ProvideLocationsSetCS")]
	public unsafe void ProvideLocationsSetCS(UObject QuerierObject, AActor QuerierActor)
	{
		CheckDestroyed();
		if (!ProvideLocationsSetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQCBase:ProvideLocationsSetCS");
			return;
		}
		if (ProvideLocationsSetCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProvideLocationsSetCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProvideLocationsSetCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideLocationsSetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideLocationsSetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideLocationsSetCS_QuerierObject_Offset), 0, ProvideLocationsSetCS_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideLocationsSetCS_QuerierActor_Offset), 0, ProvideLocationsSetCS_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideLocationsSetCS_InstanceFunctionAddress, intPtr, ProvideLocationsSetCS_ParamsSize);
	}

	protected unsafe virtual void ProvideLocationsSetCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		CheckDestroyed();
		if (!ProvideLocationsSetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQCBase:ProvideLocationsSetCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideLocationsSetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideLocationsSetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideLocationsSetCS_QuerierObject_Offset), 0, ProvideLocationsSetCS_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideLocationsSetCS_QuerierActor_Offset), 0, ProvideLocationsSetCS_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideLocationsSetCS_FunctionAddress, intPtr, ProvideLocationsSetCS_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.GSEQCBase:ProvideActorsSetCS")]
	public unsafe void ProvideActorsSetCS(UObject QuerierObject, AActor QuerierActor)
	{
		CheckDestroyed();
		if (!ProvideActorsSetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQCBase:ProvideActorsSetCS");
			return;
		}
		if (ProvideActorsSetCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProvideActorsSetCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProvideActorsSetCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideActorsSetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideActorsSetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideActorsSetCS_QuerierObject_Offset), 0, ProvideActorsSetCS_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideActorsSetCS_QuerierActor_Offset), 0, ProvideActorsSetCS_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideActorsSetCS_InstanceFunctionAddress, intPtr, ProvideActorsSetCS_ParamsSize);
	}

	protected unsafe virtual void ProvideActorsSetCS_Implementation(UObject QuerierObject, AActor QuerierActor)
	{
		CheckDestroyed();
		if (!ProvideActorsSetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQCBase:ProvideActorsSetCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProvideActorsSetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProvideActorsSetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ProvideActorsSetCS_QuerierObject_Offset), 0, ProvideActorsSetCS_QuerierObject_PropertyAddress.Address, QuerierObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProvideActorsSetCS_QuerierActor_Offset), 0, ProvideActorsSetCS_QuerierActor_PropertyAddress.Address, QuerierActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProvideActorsSetCS_FunctionAddress, intPtr, ProvideActorsSetCS_ParamsSize);
	}

	static UGSEQCBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEQCBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEQCBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.GSEQCBase");
		NativeReflectionCached.GetPropertyRef(ref EQCQueryType_PropertyAddress, intPtr, "EQCQueryType");
		EQCQueryType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EQCQueryType");
		EQCQueryType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EQCQueryType", Classes.FEnumProperty);
		SingleActorResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SingleActorResult");
		SingleActorResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SingleActorResult", Classes.FObjectProperty);
		SingleLocationResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SingleLocationResult");
		SingleLocationResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SingleLocationResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorsSetResult_PropertyAddress, intPtr, "ActorsSetResult");
		ActorsSetResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorsSetResult");
		ActorsSetResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorsSetResult", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LocationsSetResult_PropertyAddress, intPtr, "LocationsSetResult");
		LocationsSetResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocationsSetResult");
		LocationsSetResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocationsSetResult", Classes.FArrayProperty);
		ProvideSingleLocationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProvideSingleLocationCS");
		ProvideSingleLocationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideSingleLocationCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleLocationCS_QuerierObject_PropertyAddress, ProvideSingleLocationCS_FunctionAddress, "QuerierObject");
		ProvideSingleLocationCS_QuerierObject_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleLocationCS_FunctionAddress, "QuerierObject");
		ProvideSingleLocationCS_QuerierObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleLocationCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleLocationCS_QuerierActor_PropertyAddress, ProvideSingleLocationCS_FunctionAddress, "QuerierActor");
		ProvideSingleLocationCS_QuerierActor_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleLocationCS_FunctionAddress, "QuerierActor");
		ProvideSingleLocationCS_QuerierActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleLocationCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideSingleLocationCS_IsValid = ProvideSingleLocationCS_FunctionAddress != IntPtr.Zero && ProvideSingleLocationCS_QuerierObject_IsValid && ProvideSingleLocationCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQCBase:ProvideSingleLocationCS", ProvideSingleLocationCS_IsValid);
		ProvideSingleActorCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProvideSingleActorCS");
		ProvideSingleActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideSingleActorCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleActorCS_QuerierObject_PropertyAddress, ProvideSingleActorCS_FunctionAddress, "QuerierObject");
		ProvideSingleActorCS_QuerierObject_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleActorCS_FunctionAddress, "QuerierObject");
		ProvideSingleActorCS_QuerierObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleActorCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideSingleActorCS_QuerierActor_PropertyAddress, ProvideSingleActorCS_FunctionAddress, "QuerierActor");
		ProvideSingleActorCS_QuerierActor_Offset = NativeReflectionCached.GetPropertyOffset(ProvideSingleActorCS_FunctionAddress, "QuerierActor");
		ProvideSingleActorCS_QuerierActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideSingleActorCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideSingleActorCS_IsValid = ProvideSingleActorCS_FunctionAddress != IntPtr.Zero && ProvideSingleActorCS_QuerierObject_IsValid && ProvideSingleActorCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQCBase:ProvideSingleActorCS", ProvideSingleActorCS_IsValid);
		ProvideLocationsSetCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProvideLocationsSetCS");
		ProvideLocationsSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideLocationsSetCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProvideLocationsSetCS_QuerierObject_PropertyAddress, ProvideLocationsSetCS_FunctionAddress, "QuerierObject");
		ProvideLocationsSetCS_QuerierObject_Offset = NativeReflectionCached.GetPropertyOffset(ProvideLocationsSetCS_FunctionAddress, "QuerierObject");
		ProvideLocationsSetCS_QuerierObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideLocationsSetCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideLocationsSetCS_QuerierActor_PropertyAddress, ProvideLocationsSetCS_FunctionAddress, "QuerierActor");
		ProvideLocationsSetCS_QuerierActor_Offset = NativeReflectionCached.GetPropertyOffset(ProvideLocationsSetCS_FunctionAddress, "QuerierActor");
		ProvideLocationsSetCS_QuerierActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideLocationsSetCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideLocationsSetCS_IsValid = ProvideLocationsSetCS_FunctionAddress != IntPtr.Zero && ProvideLocationsSetCS_QuerierObject_IsValid && ProvideLocationsSetCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQCBase:ProvideLocationsSetCS", ProvideLocationsSetCS_IsValid);
		ProvideActorsSetCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProvideActorsSetCS");
		ProvideActorsSetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProvideActorsSetCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProvideActorsSetCS_QuerierObject_PropertyAddress, ProvideActorsSetCS_FunctionAddress, "QuerierObject");
		ProvideActorsSetCS_QuerierObject_Offset = NativeReflectionCached.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierObject");
		ProvideActorsSetCS_QuerierObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProvideActorsSetCS_QuerierActor_PropertyAddress, ProvideActorsSetCS_FunctionAddress, "QuerierActor");
		ProvideActorsSetCS_QuerierActor_Offset = NativeReflectionCached.GetPropertyOffset(ProvideActorsSetCS_FunctionAddress, "QuerierActor");
		ProvideActorsSetCS_QuerierActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProvideActorsSetCS_FunctionAddress, "QuerierActor", Classes.FObjectProperty);
		ProvideActorsSetCS_IsValid = ProvideActorsSetCS_FunctionAddress != IntPtr.Zero && ProvideActorsSetCS_QuerierObject_IsValid && ProvideActorsSetCS_QuerierActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQCBase:ProvideActorsSetCS", ProvideActorsSetCS_IsValid);
	}
}
