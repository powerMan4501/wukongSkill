using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryCache;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GeometryCache.GeometryCacheActor", "GeometryCache", UnrealModuleType.EnginePlugin)]
public class AGeometryCacheActor : AActor
{
	private static bool GeometryCacheComponent_IsValid;

	private static int GeometryCacheComponent_Offset;

	private static bool GetGeometryCacheComponent_IsValid;

	private static IntPtr GetGeometryCacheComponent_FunctionAddress;

	private static int GetGeometryCacheComponent_ParamsSize;

	private static bool GetGeometryCacheComponent_ReturnValue_IsValid;

	private static FFieldAddress GetGeometryCacheComponent_ReturnValue_PropertyAddress;

	private static int GetGeometryCacheComponent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheActor:GeometryCacheComponent")]
	public UGeometryCacheComponent GeometryCacheComponent
	{
		get
		{
			CheckDestroyed();
			if (!GeometryCacheComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheActor:GeometryCacheComponent");
				return null;
			}
			return UObjectMarshaler<UGeometryCacheComponent>.FromNative(IntPtr.Add(base.Address, GeometryCacheComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GeometryCacheComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCacheActor:GeometryCacheComponent");
			}
			else
			{
				UObjectMarshaler<UGeometryCacheComponent>.ToNative(IntPtr.Add(base.Address, GeometryCacheComponent_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/GeometryCache.GeometryCacheActor:GetGeometryCacheComponent")]
	public unsafe UGeometryCacheComponent GetGeometryCacheComponent()
	{
		CheckDestroyed();
		if (!GetGeometryCacheComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GeometryCache.GeometryCacheActor:GetGeometryCacheComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGeometryCacheComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGeometryCacheComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGeometryCacheComponent_FunctionAddress, intPtr, GetGeometryCacheComponent_ParamsSize);
		return UObjectMarshaler<UGeometryCacheComponent>.FromNative(IntPtr.Add(intPtr, GetGeometryCacheComponent_ReturnValue_Offset), 0, GetGeometryCacheComponent_ReturnValue_PropertyAddress.Address);
	}

	static AGeometryCacheActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGeometryCacheActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGeometryCacheActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GeometryCache.GeometryCacheActor");
		GeometryCacheComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GeometryCacheComponent");
		GeometryCacheComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GeometryCacheComponent", Classes.FObjectProperty);
		GetGeometryCacheComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGeometryCacheComponent");
		GetGeometryCacheComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGeometryCacheComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGeometryCacheComponent_ReturnValue_PropertyAddress, GetGeometryCacheComponent_FunctionAddress, "ReturnValue");
		GetGeometryCacheComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGeometryCacheComponent_FunctionAddress, "ReturnValue");
		GetGeometryCacheComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGeometryCacheComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGeometryCacheComponent_IsValid = GetGeometryCacheComponent_FunctionAddress != IntPtr.Zero && GetGeometryCacheComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GeometryCache.GeometryCacheActor:GetGeometryCacheComponent", GetGeometryCacheComponent_IsValid);
	}
}
