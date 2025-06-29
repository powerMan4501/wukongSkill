using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Plugins.PCG;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner", "UnrealExtent", UnrealModuleType.Game)]
public class UGS_PCGStaticMeshSpawner : UPCGStaticMeshSpawnerSettings
{
	private static bool matSwitchParams_IsValid;

	private static FFieldAddress matSwitchParams_PropertyAddress;

	private static int matSwitchParams_Offset;

	private TMapReadWriteMarshaler<FName, bool> matSwitchParams_MarshalerCached;

	private static bool matScalarParams_IsValid;

	private static FFieldAddress matScalarParams_PropertyAddress;

	private static int matScalarParams_Offset;

	private TMapReadWriteMarshaler<FName, float> matScalarParams_MarshalerCached;

	private static bool matVectorParams_IsValid;

	private static FFieldAddress matVectorParams_PropertyAddress;

	private static int matVectorParams_Offset;

	private TMapReadWriteMarshaler<FName, FLinearColor> matVectorParams_MarshalerCached;

	private static bool ICPDVersion_IsValid;

	private static int ICPDVersion_Offset;

	private static bool AutoSaveICPDMat_IsValid;

	private static FFieldAddress AutoSaveICPDMat_PropertyAddress;

	private static int AutoSaveICPDMat_Offset;

	private static bool GetOriginalCPDParams_IsValid;

	private static FFieldAddress GetOriginalCPDParams_PropertyAddress;

	private static int GetOriginalCPDParams_Offset;

	private static bool ClearICPDMat_IsValid;

	private static FFieldAddress ClearICPDMat_PropertyAddress;

	private static int ClearICPDMat_Offset;

	private static bool DeleteICPDMatWhenClear_IsValid;

	private static FFieldAddress DeleteICPDMatWhenClear_PropertyAddress;

	private static int DeleteICPDMatWhenClear_Offset;

	private static bool UpdateICPD_IsValid;

	private static IntPtr UpdateICPD_FunctionAddress;

	private static int UpdateICPD_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:matSwitchParams")]
	public TMapReadWrite<FName, bool> matSwitchParams
	{
		get
		{
			CheckDestroyed();
			if (!matSwitchParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:matSwitchParams");
				return null;
			}
			if (matSwitchParams_MarshalerCached == null)
			{
				matSwitchParams_MarshalerCached = new TMapReadWriteMarshaler<FName, bool>(1, matSwitchParams_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative);
			}
			return matSwitchParams_MarshalerCached.FromNative(IntPtr.Add(base.Address, matSwitchParams_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:matScalarParams")]
	public TMapReadWrite<FName, float> matScalarParams
	{
		get
		{
			CheckDestroyed();
			if (!matScalarParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:matScalarParams");
				return null;
			}
			if (matScalarParams_MarshalerCached == null)
			{
				matScalarParams_MarshalerCached = new TMapReadWriteMarshaler<FName, float>(1, matScalarParams_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return matScalarParams_MarshalerCached.FromNative(IntPtr.Add(base.Address, matScalarParams_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:matVectorParams")]
	public TMapReadWrite<FName, FLinearColor> matVectorParams
	{
		get
		{
			CheckDestroyed();
			if (!matVectorParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:matVectorParams");
				return null;
			}
			if (matVectorParams_MarshalerCached == null)
			{
				matVectorParams_MarshalerCached = new TMapReadWriteMarshaler<FName, FLinearColor>(1, matVectorParams_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative);
			}
			return matVectorParams_MarshalerCached.FromNative(IntPtr.Add(base.Address, matVectorParams_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:ICPDVersion")]
	public int ICPDVersion
	{
		get
		{
			CheckDestroyed();
			if (!ICPDVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:ICPDVersion");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ICPDVersion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ICPDVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:ICPDVersion");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ICPDVersion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bAutoSaveICPDMat")]
	public bool AutoSaveICPDMat
	{
		get
		{
			CheckDestroyed();
			if (!AutoSaveICPDMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bAutoSaveICPDMat");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoSaveICPDMat_Offset), 0, AutoSaveICPDMat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoSaveICPDMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bAutoSaveICPDMat");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoSaveICPDMat_Offset), 0, AutoSaveICPDMat_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bGetOriginalCPDParams")]
	public bool GetOriginalCPDParams
	{
		get
		{
			CheckDestroyed();
			if (!GetOriginalCPDParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bGetOriginalCPDParams");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GetOriginalCPDParams_Offset), 0, GetOriginalCPDParams_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GetOriginalCPDParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bGetOriginalCPDParams");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GetOriginalCPDParams_Offset), 0, GetOriginalCPDParams_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bClearICPDMat")]
	public bool ClearICPDMat
	{
		get
		{
			CheckDestroyed();
			if (!ClearICPDMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bClearICPDMat");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClearICPDMat_Offset), 0, ClearICPDMat_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClearICPDMat_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bClearICPDMat");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClearICPDMat_Offset), 0, ClearICPDMat_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bDeleteICPDMatWhenClear")]
	public bool DeleteICPDMatWhenClear
	{
		get
		{
			CheckDestroyed();
			if (!DeleteICPDMatWhenClear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bDeleteICPDMatWhenClear");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DeleteICPDMatWhenClear_Offset), 0, DeleteICPDMatWhenClear_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DeleteICPDMatWhenClear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:bDeleteICPDMatWhenClear");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DeleteICPDMatWhenClear_Offset), 0, DeleteICPDMatWhenClear_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:UpdateICPD")]
	public unsafe void UpdateICPD()
	{
		CheckDestroyed();
		if (!UpdateICPD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:UpdateICPD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateICPD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateICPD_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateICPD_FunctionAddress, argsSize: UpdateICPD_ParamsSize);
	}

	static UGS_PCGStaticMeshSpawner()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGS_PCGStaticMeshSpawner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGS_PCGStaticMeshSpawner));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.GS_PCGStaticMeshSpawner");
		NativeReflectionCached.GetPropertyRef(ref matSwitchParams_PropertyAddress, intPtr, "matSwitchParams");
		matSwitchParams_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "matSwitchParams");
		matSwitchParams_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "matSwitchParams", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref matScalarParams_PropertyAddress, intPtr, "matScalarParams");
		matScalarParams_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "matScalarParams");
		matScalarParams_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "matScalarParams", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref matVectorParams_PropertyAddress, intPtr, "matVectorParams");
		matVectorParams_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "matVectorParams");
		matVectorParams_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "matVectorParams", Classes.FMapProperty);
		ICPDVersion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ICPDVersion");
		ICPDVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ICPDVersion", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoSaveICPDMat_PropertyAddress, intPtr, "bAutoSaveICPDMat");
		AutoSaveICPDMat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoSaveICPDMat");
		AutoSaveICPDMat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoSaveICPDMat", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOriginalCPDParams_PropertyAddress, intPtr, "bGetOriginalCPDParams");
		GetOriginalCPDParams_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGetOriginalCPDParams");
		GetOriginalCPDParams_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGetOriginalCPDParams", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearICPDMat_PropertyAddress, intPtr, "bClearICPDMat");
		ClearICPDMat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClearICPDMat");
		ClearICPDMat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClearICPDMat", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteICPDMatWhenClear_PropertyAddress, intPtr, "bDeleteICPDMatWhenClear");
		DeleteICPDMatWhenClear_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDeleteICPDMatWhenClear");
		DeleteICPDMatWhenClear_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDeleteICPDMatWhenClear", Classes.FBoolProperty);
		UpdateICPD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateICPD");
		UpdateICPD_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateICPD_FunctionAddress);
		UpdateICPD_IsValid = UpdateICPD_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GS_PCGStaticMeshSpawner:UpdateICPD", UpdateICPD_IsValid);
	}
}
