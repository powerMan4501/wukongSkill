using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGStaticMeshSpawnerSettings : UPCGSettings
{
	private static bool MeshSelectorType_IsValid;

	private static int MeshSelectorType_Offset;

	private static bool MeshSelectorParameters_IsValid;

	private static int MeshSelectorParameters_Offset;

	private static bool InstanceDataPackerType_IsValid;

	private static int InstanceDataPackerType_Offset;

	private static bool InstanceDataPackerParameters_IsValid;

	private static int InstanceDataPackerParameters_Offset;

	private static bool OutAttributeName_IsValid;

	private static int OutAttributeName_Offset;

	private static bool ApplyMeshBoundsToPoints_IsValid;

	private static FFieldAddress ApplyMeshBoundsToPoints_PropertyAddress;

	private static int ApplyMeshBoundsToPoints_Offset;

	private static bool TargetActor_IsValid;

	private static int TargetActor_Offset;

	private static bool SetMeshSelectorType_IsValid;

	private static IntPtr SetMeshSelectorType_FunctionAddress;

	private static int SetMeshSelectorType_ParamsSize;

	private static bool SetMeshSelectorType_InMeshSelectorType_IsValid;

	private static FFieldAddress SetMeshSelectorType_InMeshSelectorType_PropertyAddress;

	private static int SetMeshSelectorType_InMeshSelectorType_Offset;

	private static bool SetInstancePackerType_IsValid;

	private static IntPtr SetInstancePackerType_FunctionAddress;

	private static int SetInstancePackerType_ParamsSize;

	private static bool SetInstancePackerType_InInstancePackerType_IsValid;

	private static FFieldAddress SetInstancePackerType_InInstancePackerType_PropertyAddress;

	private static int SetInstancePackerType_InInstancePackerType_Offset;

	[UProperty(Flags = (PropFlags)7881369174671893uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings:MeshSelectorType")]
	public TSubclassOf<UPCGMeshSelectorBase> MeshSelectorType
	{
		get
		{
			CheckDestroyed();
			if (!MeshSelectorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:MeshSelectorType");
				return default(TSubclassOf<UPCGMeshSelectorBase>);
			}
			return TSubclassOfMarshaler<UPCGMeshSelectorBase>.FromNative(IntPtr.Add(base.Address, MeshSelectorType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeshSelectorType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:MeshSelectorType");
			}
			else
			{
				TSubclassOfMarshaler<UPCGMeshSelectorBase>.ToNative(IntPtr.Add(base.Address, MeshSelectorType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095194141uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings:MeshSelectorParameters")]
	public UPCGMeshSelectorBase MeshSelectorParameters
	{
		get
		{
			CheckDestroyed();
			if (!MeshSelectorParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:MeshSelectorParameters");
				return null;
			}
			return UObjectMarshaler<UPCGMeshSelectorBase>.FromNative(IntPtr.Add(base.Address, MeshSelectorParameters_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeshSelectorParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:MeshSelectorParameters");
			}
			else
			{
				UObjectMarshaler<UPCGMeshSelectorBase>.ToNative(IntPtr.Add(base.Address, MeshSelectorParameters_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings:InstanceDataPackerType")]
	public TSubclassOf<UPCGInstanceDataPackerBase> InstanceDataPackerType
	{
		get
		{
			CheckDestroyed();
			if (!InstanceDataPackerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:InstanceDataPackerType");
				return default(TSubclassOf<UPCGInstanceDataPackerBase>);
			}
			return TSubclassOfMarshaler<UPCGInstanceDataPackerBase>.FromNative(IntPtr.Add(base.Address, InstanceDataPackerType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InstanceDataPackerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:InstanceDataPackerType");
			}
			else
			{
				TSubclassOfMarshaler<UPCGInstanceDataPackerBase>.ToNative(IntPtr.Add(base.Address, InstanceDataPackerType_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095194141uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings:InstanceDataPackerParameters")]
	public UPCGInstanceDataPackerBase InstanceDataPackerParameters
	{
		get
		{
			CheckDestroyed();
			if (!InstanceDataPackerParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:InstanceDataPackerParameters");
				return null;
			}
			return UObjectMarshaler<UPCGInstanceDataPackerBase>.FromNative(IntPtr.Add(base.Address, InstanceDataPackerParameters_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InstanceDataPackerParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:InstanceDataPackerParameters");
			}
			else
			{
				UObjectMarshaler<UPCGInstanceDataPackerBase>.ToNative(IntPtr.Add(base.Address, InstanceDataPackerParameters_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings:OutAttributeName")]
	public FName OutAttributeName
	{
		get
		{
			CheckDestroyed();
			if (!OutAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:OutAttributeName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OutAttributeName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutAttributeName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:OutAttributeName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OutAttributeName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings:bApplyMeshBoundsToPoints")]
	public bool ApplyMeshBoundsToPoints
	{
		get
		{
			CheckDestroyed();
			if (!ApplyMeshBoundsToPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:bApplyMeshBoundsToPoints");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ApplyMeshBoundsToPoints_Offset), 0, ApplyMeshBoundsToPoints_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ApplyMeshBoundsToPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:bApplyMeshBoundsToPoints");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ApplyMeshBoundsToPoints_Offset), 0, ApplyMeshBoundsToPoints_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881299347898372uL)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings:TargetActor")]
	public TSoftObject<AActor> TargetActor
	{
		get
		{
			CheckDestroyed();
			if (!TargetActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:TargetActor");
				return default(TSoftObject<AActor>);
			}
			return TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, TargetActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:TargetActor");
			}
			else
			{
				TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, TargetActor_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings:SetMeshSelectorType")]
	public unsafe void SetMeshSelectorType(TSubclassOf<UPCGMeshSelectorBase> InMeshSelectorType)
	{
		CheckDestroyed();
		if (!SetMeshSelectorType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:SetMeshSelectorType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshSelectorType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshSelectorType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UPCGMeshSelectorBase>.ToNative(IntPtr.Add(intPtr, SetMeshSelectorType_InMeshSelectorType_Offset), 0, SetMeshSelectorType_InMeshSelectorType_PropertyAddress.Address, InMeshSelectorType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMeshSelectorType_FunctionAddress, intPtr, SetMeshSelectorType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGStaticMeshSpawnerSettings:SetInstancePackerType")]
	public unsafe void SetInstancePackerType(TSubclassOf<UPCGInstanceDataPackerBase> InInstancePackerType)
	{
		CheckDestroyed();
		if (!SetInstancePackerType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGStaticMeshSpawnerSettings:SetInstancePackerType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInstancePackerType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInstancePackerType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UPCGInstanceDataPackerBase>.ToNative(IntPtr.Add(intPtr, SetInstancePackerType_InInstancePackerType_Offset), 0, SetInstancePackerType_InInstancePackerType_PropertyAddress.Address, InInstancePackerType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInstancePackerType_FunctionAddress, intPtr, SetInstancePackerType_ParamsSize);
	}

	static UPCGStaticMeshSpawnerSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGStaticMeshSpawnerSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGStaticMeshSpawnerSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGStaticMeshSpawnerSettings");
		MeshSelectorType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshSelectorType");
		MeshSelectorType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshSelectorType", Classes.FClassProperty);
		MeshSelectorParameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshSelectorParameters");
		MeshSelectorParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshSelectorParameters", Classes.FObjectProperty);
		InstanceDataPackerType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstanceDataPackerType");
		InstanceDataPackerType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstanceDataPackerType", Classes.FClassProperty);
		InstanceDataPackerParameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstanceDataPackerParameters");
		InstanceDataPackerParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstanceDataPackerParameters", Classes.FObjectProperty);
		OutAttributeName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutAttributeName");
		OutAttributeName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutAttributeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyMeshBoundsToPoints_PropertyAddress, intPtr, "bApplyMeshBoundsToPoints");
		ApplyMeshBoundsToPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyMeshBoundsToPoints");
		ApplyMeshBoundsToPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyMeshBoundsToPoints", Classes.FBoolProperty);
		TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetActor");
		TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetActor", Classes.FSoftObjectProperty);
		SetMeshSelectorType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMeshSelectorType");
		SetMeshSelectorType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshSelectorType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshSelectorType_InMeshSelectorType_PropertyAddress, SetMeshSelectorType_FunctionAddress, "InMeshSelectorType");
		SetMeshSelectorType_InMeshSelectorType_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshSelectorType_FunctionAddress, "InMeshSelectorType");
		SetMeshSelectorType_InMeshSelectorType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshSelectorType_FunctionAddress, "InMeshSelectorType", Classes.FClassProperty);
		SetMeshSelectorType_IsValid = SetMeshSelectorType_FunctionAddress != IntPtr.Zero && SetMeshSelectorType_InMeshSelectorType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGStaticMeshSpawnerSettings:SetMeshSelectorType", SetMeshSelectorType_IsValid);
		SetInstancePackerType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInstancePackerType");
		SetInstancePackerType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInstancePackerType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInstancePackerType_InInstancePackerType_PropertyAddress, SetInstancePackerType_FunctionAddress, "InInstancePackerType");
		SetInstancePackerType_InInstancePackerType_Offset = NativeReflectionCached.GetPropertyOffset(SetInstancePackerType_FunctionAddress, "InInstancePackerType");
		SetInstancePackerType_InInstancePackerType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInstancePackerType_FunctionAddress, "InInstancePackerType", Classes.FClassProperty);
		SetInstancePackerType_IsValid = SetInstancePackerType_FunctionAddress != IntPtr.Zero && SetInstancePackerType_InInstancePackerType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGStaticMeshSpawnerSettings:SetInstancePackerType", SetInstancePackerType_IsValid);
	}
}
