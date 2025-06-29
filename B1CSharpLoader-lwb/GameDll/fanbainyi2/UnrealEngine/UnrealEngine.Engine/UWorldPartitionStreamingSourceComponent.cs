using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.WorldPartitionStreamingSourceComponent", "Engine", UnrealModuleType.Engine)]
public class UWorldPartitionStreamingSourceComponent : UActorComponent
{
	private static bool TargetGrid_IsValid;

	private static int TargetGrid_Offset;

	private static bool TargetHLODLayer_IsValid;

	private static int TargetHLODLayer_Offset;

	private static bool Shapes_IsValid;

	private static FFieldAddress Shapes_PropertyAddress;

	private static int Shapes_Offset;

	private TArrayReadWriteMarshaler<FStreamingSourceShape> Shapes_MarshalerCached;

	private static bool Priority_IsValid;

	private static FFieldAddress Priority_PropertyAddress;

	private static int Priority_Offset;

	private static bool IsStreamingSourceEnabled_IsValid;

	private static IntPtr IsStreamingSourceEnabled_FunctionAddress;

	private static int IsStreamingSourceEnabled_ParamsSize;

	private static bool IsStreamingSourceEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsStreamingSourceEnabled_ReturnValue_PropertyAddress;

	private static int IsStreamingSourceEnabled_ReturnValue_Offset;

	private static bool IsStreamingCompleted_IsValid;

	private static IntPtr IsStreamingCompleted_FunctionAddress;

	private static int IsStreamingCompleted_ParamsSize;

	private static bool IsStreamingCompleted_ReturnValue_IsValid;

	private static FFieldAddress IsStreamingCompleted_ReturnValue_PropertyAddress;

	private static int IsStreamingCompleted_ReturnValue_Offset;

	private static bool EnableStreamingSource_IsValid;

	private static IntPtr EnableStreamingSource_FunctionAddress;

	private static int EnableStreamingSource_ParamsSize;

	private static bool DisableStreamingSource_IsValid;

	private static IntPtr DisableStreamingSource_FunctionAddress;

	private static int DisableStreamingSource_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingSourceComponent:TargetGrid")]
	public FName TargetGrid
	{
		get
		{
			CheckDestroyed();
			if (!TargetGrid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:TargetGrid");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, TargetGrid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetGrid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:TargetGrid");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, TargetGrid_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingSourceComponent:TargetHLODLayer")]
	public UHLODLayer TargetHLODLayer
	{
		get
		{
			CheckDestroyed();
			if (!TargetHLODLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:TargetHLODLayer");
				return null;
			}
			return UObjectMarshaler<UHLODLayer>.FromNative(IntPtr.Add(base.Address, TargetHLODLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetHLODLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:TargetHLODLayer");
			}
			else
			{
				UObjectMarshaler<UHLODLayer>.ToNative(IntPtr.Add(base.Address, TargetHLODLayer_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingSourceComponent:Shapes")]
	public TArrayReadWrite<FStreamingSourceShape> Shapes
	{
		get
		{
			CheckDestroyed();
			if (!Shapes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:Shapes");
				return null;
			}
			if (Shapes_MarshalerCached == null)
			{
				Shapes_MarshalerCached = new TArrayReadWriteMarshaler<FStreamingSourceShape>(1, Shapes_PropertyAddress, CachedMarshalingDelegates<FStreamingSourceShape, FStreamingSourceShape>.FromNative, CachedMarshalingDelegates<FStreamingSourceShape, FStreamingSourceShape>.ToNative);
			}
			return Shapes_MarshalerCached.FromNative(IntPtr.Add(base.Address, Shapes_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingSourceComponent:Priority")]
	public EStreamingSourcePriority Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:Priority");
				return EStreamingSourcePriority.Highest;
			}
			return EnumMarshaler<EStreamingSourcePriority>.FromNative(IntPtr.Add(base.Address, Priority_Offset), 0, Priority_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:Priority");
			}
			else
			{
				EnumMarshaler<EStreamingSourcePriority>.ToNative(IntPtr.Add(base.Address, Priority_Offset), 0, Priority_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingSourceComponent:IsStreamingSourceEnabled")]
	public unsafe bool IsStreamingSourceEnabled()
	{
		CheckDestroyed();
		if (!IsStreamingSourceEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:IsStreamingSourceEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStreamingSourceEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStreamingSourceEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsStreamingSourceEnabled_FunctionAddress, intPtr, IsStreamingSourceEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStreamingSourceEnabled_ReturnValue_Offset), 0, IsStreamingSourceEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingSourceComponent:IsStreamingCompleted")]
	public unsafe bool IsStreamingCompleted()
	{
		CheckDestroyed();
		if (!IsStreamingCompleted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:IsStreamingCompleted");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStreamingCompleted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStreamingCompleted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsStreamingCompleted_FunctionAddress, intPtr, IsStreamingCompleted_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStreamingCompleted_ReturnValue_Offset), 0, IsStreamingCompleted_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingSourceComponent:EnableStreamingSource")]
	public unsafe void EnableStreamingSource()
	{
		CheckDestroyed();
		if (!EnableStreamingSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:EnableStreamingSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableStreamingSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableStreamingSource_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EnableStreamingSource_FunctionAddress, argsSize: EnableStreamingSource_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.WorldPartitionStreamingSourceComponent:DisableStreamingSource")]
	public unsafe void DisableStreamingSource()
	{
		CheckDestroyed();
		if (!DisableStreamingSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.WorldPartitionStreamingSourceComponent:DisableStreamingSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableStreamingSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableStreamingSource_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisableStreamingSource_FunctionAddress, argsSize: DisableStreamingSource_ParamsSize);
	}

	static UWorldPartitionStreamingSourceComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWorldPartitionStreamingSourceComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWorldPartitionStreamingSourceComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.WorldPartitionStreamingSourceComponent");
		TargetGrid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetGrid");
		TargetGrid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetGrid", Classes.FNameProperty);
		TargetHLODLayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetHLODLayer");
		TargetHLODLayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetHLODLayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Shapes_PropertyAddress, intPtr, "Shapes");
		Shapes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Shapes");
		Shapes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Shapes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Priority_PropertyAddress, intPtr, "Priority");
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FEnumProperty);
		IsStreamingSourceEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsStreamingSourceEnabled");
		IsStreamingSourceEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStreamingSourceEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStreamingSourceEnabled_ReturnValue_PropertyAddress, IsStreamingSourceEnabled_FunctionAddress, "ReturnValue");
		IsStreamingSourceEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStreamingSourceEnabled_FunctionAddress, "ReturnValue");
		IsStreamingSourceEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStreamingSourceEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStreamingSourceEnabled_IsValid = IsStreamingSourceEnabled_FunctionAddress != IntPtr.Zero && IsStreamingSourceEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WorldPartitionStreamingSourceComponent:IsStreamingSourceEnabled", IsStreamingSourceEnabled_IsValid);
		IsStreamingCompleted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsStreamingCompleted");
		IsStreamingCompleted_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStreamingCompleted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStreamingCompleted_ReturnValue_PropertyAddress, IsStreamingCompleted_FunctionAddress, "ReturnValue");
		IsStreamingCompleted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStreamingCompleted_FunctionAddress, "ReturnValue");
		IsStreamingCompleted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStreamingCompleted_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStreamingCompleted_IsValid = IsStreamingCompleted_FunctionAddress != IntPtr.Zero && IsStreamingCompleted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WorldPartitionStreamingSourceComponent:IsStreamingCompleted", IsStreamingCompleted_IsValid);
		EnableStreamingSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableStreamingSource");
		EnableStreamingSource_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableStreamingSource_FunctionAddress);
		EnableStreamingSource_IsValid = EnableStreamingSource_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WorldPartitionStreamingSourceComponent:EnableStreamingSource", EnableStreamingSource_IsValid);
		DisableStreamingSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableStreamingSource");
		DisableStreamingSource_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableStreamingSource_FunctionAddress);
		DisableStreamingSource_IsValid = DisableStreamingSource_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.WorldPartitionStreamingSourceComponent:DisableStreamingSource", DisableStreamingSource_IsValid);
	}
}
