using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/NavigationSystem.NavigationPath", "NavigationSystem", UnrealModuleType.Engine)]
public class UNavigationPath : UObject
{
	private static bool PathUpdatedNotifier_IsValid;

	private static int PathUpdatedNotifier_Offset;

	private FOnNavigationPathUpdated PathUpdatedNotifier_DelegateCached;

	private static bool PathPoints_IsValid;

	private static FFieldAddress PathPoints_PropertyAddress;

	private static int PathPoints_Offset;

	private TArrayReadOnlyMarshaler<FVector> PathPoints_MarshalerCached;

	private static bool RecalculateOnInvalidation_IsValid;

	private static FFieldAddress RecalculateOnInvalidation_PropertyAddress;

	private static int RecalculateOnInvalidation_Offset;

	private static bool IsValid_IsValid;

	private static IntPtr IsValid_FunctionAddress;

	private static int IsValid_ParamsSize;

	private static bool IsValid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_ReturnValue_PropertyAddress;

	private static int IsValid_ReturnValue_Offset;

	private static bool IsStringPulled_IsValid;

	private static IntPtr IsStringPulled_FunctionAddress;

	private static int IsStringPulled_ParamsSize;

	private static bool IsStringPulled_ReturnValue_IsValid;

	private static FFieldAddress IsStringPulled_ReturnValue_PropertyAddress;

	private static int IsStringPulled_ReturnValue_Offset;

	private static bool IsPartial_IsValid;

	private static IntPtr IsPartial_FunctionAddress;

	private static int IsPartial_ParamsSize;

	private static bool IsPartial_ReturnValue_IsValid;

	private static FFieldAddress IsPartial_ReturnValue_PropertyAddress;

	private static int IsPartial_ReturnValue_Offset;

	private static bool GetPathLength_IsValid;

	private static IntPtr GetPathLength_FunctionAddress;

	private static int GetPathLength_ParamsSize;

	private static bool GetPathLength_ReturnValue_IsValid;

	private static FFieldAddress GetPathLength_ReturnValue_PropertyAddress;

	private static int GetPathLength_ReturnValue_Offset;

	private static bool GetPathCost_IsValid;

	private static IntPtr GetPathCost_FunctionAddress;

	private static int GetPathCost_ParamsSize;

	private static bool GetPathCost_ReturnValue_IsValid;

	private static FFieldAddress GetPathCost_ReturnValue_PropertyAddress;

	private static int GetPathCost_ReturnValue_Offset;

	private static bool GetDebugString_IsValid;

	private static IntPtr GetDebugString_FunctionAddress;

	private static int GetDebugString_ParamsSize;

	private static bool GetDebugString_ReturnValue_IsValid;

	private static FFieldAddress GetDebugString_ReturnValue_PropertyAddress;

	private static int GetDebugString_ReturnValue_Offset;

	private static bool EnableRecalculationOnInvalidation_IsValid;

	private static IntPtr EnableRecalculationOnInvalidation_FunctionAddress;

	private static int EnableRecalculationOnInvalidation_ParamsSize;

	private static bool EnableRecalculationOnInvalidation_DoRecalculation_IsValid;

	private static FFieldAddress EnableRecalculationOnInvalidation_DoRecalculation_PropertyAddress;

	private static int EnableRecalculationOnInvalidation_DoRecalculation_Offset;

	private static bool EnableDebugDrawing_IsValid;

	private static IntPtr EnableDebugDrawing_FunctionAddress;

	private static int EnableDebugDrawing_ParamsSize;

	private static bool EnableDebugDrawing_bShouldDrawDebugData_IsValid;

	private static FFieldAddress EnableDebugDrawing_bShouldDrawDebugData_PropertyAddress;

	private static int EnableDebugDrawing_bShouldDrawDebugData_Offset;

	private static bool EnableDebugDrawing_PathColor_IsValid;

	private static FFieldAddress EnableDebugDrawing_PathColor_PropertyAddress;

	private static int EnableDebugDrawing_PathColor_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:PathUpdatedNotifier")]
	public FOnNavigationPathUpdated PathUpdatedNotifier
	{
		get
		{
			CheckDestroyed();
			if (!PathUpdatedNotifier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationPath:PathUpdatedNotifier");
				return new FOnNavigationPathUpdated();
			}
			if (PathUpdatedNotifier_DelegateCached == null)
			{
				PathUpdatedNotifier_DelegateCached = new FOnNavigationPathUpdated();
				PathUpdatedNotifier_DelegateCached.SetAddress(IntPtr.Add(base.Address, PathUpdatedNotifier_Offset));
			}
			return PathUpdatedNotifier_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:PathPoints")]
	public TArrayReadOnly<FVector> PathPoints
	{
		get
		{
			CheckDestroyed();
			if (!PathPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationPath:PathPoints");
				return null;
			}
			if (PathPoints_MarshalerCached == null)
			{
				PathPoints_MarshalerCached = new TArrayReadOnlyMarshaler<FVector>(1, PathPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return PathPoints_MarshalerCached.FromNative(IntPtr.Add(base.Address, PathPoints_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:RecalculateOnInvalidation")]
	public ENavigationOptionFlag RecalculateOnInvalidation
	{
		get
		{
			CheckDestroyed();
			if (!RecalculateOnInvalidation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationPath:RecalculateOnInvalidation");
				return ENavigationOptionFlag.Default;
			}
			return EnumMarshaler<ENavigationOptionFlag>.FromNative(IntPtr.Add(base.Address, RecalculateOnInvalidation_Offset), 0, RecalculateOnInvalidation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RecalculateOnInvalidation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavigationPath:RecalculateOnInvalidation");
			}
			else
			{
				EnumMarshaler<ENavigationOptionFlag>.ToNative(IntPtr.Add(base.Address, RecalculateOnInvalidation_Offset), 0, RecalculateOnInvalidation_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:IsValid")]
	public unsafe bool IsValid()
	{
		CheckDestroyed();
		if (!IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationPath:IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsValid_FunctionAddress, intPtr, IsValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_ReturnValue_Offset), 0, IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:IsStringPulled")]
	public unsafe bool IsStringPulled()
	{
		CheckDestroyed();
		if (!IsStringPulled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationPath:IsStringPulled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStringPulled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStringPulled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsStringPulled_FunctionAddress, intPtr, IsStringPulled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStringPulled_ReturnValue_Offset), 0, IsStringPulled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:IsPartial")]
	public unsafe bool IsPartial()
	{
		CheckDestroyed();
		if (!IsPartial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationPath:IsPartial");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPartial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPartial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPartial_FunctionAddress, intPtr, IsPartial_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPartial_ReturnValue_Offset), 0, IsPartial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:GetPathLength")]
	public unsafe float GetPathLength()
	{
		CheckDestroyed();
		if (!GetPathLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationPath:GetPathLength");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPathLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPathLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPathLength_FunctionAddress, intPtr, GetPathLength_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPathLength_ReturnValue_Offset), 0, GetPathLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:GetPathCost")]
	public unsafe float GetPathCost()
	{
		CheckDestroyed();
		if (!GetPathCost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationPath:GetPathCost");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPathCost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPathCost_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPathCost_FunctionAddress, intPtr, GetPathCost_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPathCost_ReturnValue_Offset), 0, GetPathCost_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:GetDebugString")]
	public unsafe string GetDebugString()
	{
		CheckDestroyed();
		if (!GetDebugString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationPath:GetDebugString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDebugString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDebugString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDebugString_FunctionAddress, intPtr, GetDebugString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDebugString_ReturnValue_Offset), 0, GetDebugString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDebugString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:EnableRecalculationOnInvalidation")]
	public unsafe void EnableRecalculationOnInvalidation(ENavigationOptionFlag DoRecalculation)
	{
		CheckDestroyed();
		if (!EnableRecalculationOnInvalidation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationPath:EnableRecalculationOnInvalidation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableRecalculationOnInvalidation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableRecalculationOnInvalidation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ENavigationOptionFlag>.ToNative(IntPtr.Add(intPtr, EnableRecalculationOnInvalidation_DoRecalculation_Offset), 0, EnableRecalculationOnInvalidation_DoRecalculation_PropertyAddress.Address, DoRecalculation);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableRecalculationOnInvalidation_FunctionAddress, intPtr, EnableRecalculationOnInvalidation_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/NavigationSystem.NavigationPath:EnableDebugDrawing")]
	public unsafe void EnableDebugDrawing(bool bShouldDrawDebugData, FLinearColor PathColor)
	{
		CheckDestroyed();
		if (!EnableDebugDrawing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavigationPath:EnableDebugDrawing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableDebugDrawing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableDebugDrawing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableDebugDrawing_bShouldDrawDebugData_Offset), 0, EnableDebugDrawing_bShouldDrawDebugData_PropertyAddress.Address, bShouldDrawDebugData);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, EnableDebugDrawing_PathColor_Offset), 0, EnableDebugDrawing_PathColor_PropertyAddress.Address, PathColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableDebugDrawing_FunctionAddress, intPtr, EnableDebugDrawing_ParamsSize);
	}

	static UNavigationPath()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNavigationPath)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNavigationPath));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/NavigationSystem.NavigationPath");
		PathUpdatedNotifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathUpdatedNotifier");
		PathUpdatedNotifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathUpdatedNotifier", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PathPoints_PropertyAddress, intPtr, "PathPoints");
		PathPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathPoints");
		PathPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RecalculateOnInvalidation_PropertyAddress, intPtr, "RecalculateOnInvalidation");
		RecalculateOnInvalidation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RecalculateOnInvalidation");
		RecalculateOnInvalidation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RecalculateOnInvalidation", Classes.FByteProperty);
		IsValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsValid");
		IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_ReturnValue_PropertyAddress, IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_IsValid = IsValid_FunctionAddress != IntPtr.Zero && IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationPath:IsValid", IsValid_IsValid);
		IsStringPulled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsStringPulled");
		IsStringPulled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStringPulled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStringPulled_ReturnValue_PropertyAddress, IsStringPulled_FunctionAddress, "ReturnValue");
		IsStringPulled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStringPulled_FunctionAddress, "ReturnValue");
		IsStringPulled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStringPulled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStringPulled_IsValid = IsStringPulled_FunctionAddress != IntPtr.Zero && IsStringPulled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationPath:IsStringPulled", IsStringPulled_IsValid);
		IsPartial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPartial");
		IsPartial_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPartial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPartial_ReturnValue_PropertyAddress, IsPartial_FunctionAddress, "ReturnValue");
		IsPartial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPartial_FunctionAddress, "ReturnValue");
		IsPartial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPartial_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPartial_IsValid = IsPartial_FunctionAddress != IntPtr.Zero && IsPartial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationPath:IsPartial", IsPartial_IsValid);
		GetPathLength_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPathLength");
		GetPathLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPathLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPathLength_ReturnValue_PropertyAddress, GetPathLength_FunctionAddress, "ReturnValue");
		GetPathLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPathLength_FunctionAddress, "ReturnValue");
		GetPathLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPathLength_IsValid = GetPathLength_FunctionAddress != IntPtr.Zero && GetPathLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationPath:GetPathLength", GetPathLength_IsValid);
		GetPathCost_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPathCost");
		GetPathCost_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPathCost_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPathCost_ReturnValue_PropertyAddress, GetPathCost_FunctionAddress, "ReturnValue");
		GetPathCost_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPathCost_FunctionAddress, "ReturnValue");
		GetPathCost_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathCost_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPathCost_IsValid = GetPathCost_FunctionAddress != IntPtr.Zero && GetPathCost_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationPath:GetPathCost", GetPathCost_IsValid);
		GetDebugString_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDebugString");
		GetDebugString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDebugString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDebugString_ReturnValue_PropertyAddress, GetDebugString_FunctionAddress, "ReturnValue");
		GetDebugString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugString_FunctionAddress, "ReturnValue");
		GetDebugString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDebugString_IsValid = GetDebugString_FunctionAddress != IntPtr.Zero && GetDebugString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationPath:GetDebugString", GetDebugString_IsValid);
		EnableRecalculationOnInvalidation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableRecalculationOnInvalidation");
		EnableRecalculationOnInvalidation_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableRecalculationOnInvalidation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableRecalculationOnInvalidation_DoRecalculation_PropertyAddress, EnableRecalculationOnInvalidation_FunctionAddress, "DoRecalculation");
		EnableRecalculationOnInvalidation_DoRecalculation_Offset = NativeReflectionCached.GetPropertyOffset(EnableRecalculationOnInvalidation_FunctionAddress, "DoRecalculation");
		EnableRecalculationOnInvalidation_DoRecalculation_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableRecalculationOnInvalidation_FunctionAddress, "DoRecalculation", Classes.FByteProperty);
		EnableRecalculationOnInvalidation_IsValid = EnableRecalculationOnInvalidation_FunctionAddress != IntPtr.Zero && EnableRecalculationOnInvalidation_DoRecalculation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationPath:EnableRecalculationOnInvalidation", EnableRecalculationOnInvalidation_IsValid);
		EnableDebugDrawing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableDebugDrawing");
		EnableDebugDrawing_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableDebugDrawing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableDebugDrawing_bShouldDrawDebugData_PropertyAddress, EnableDebugDrawing_FunctionAddress, "bShouldDrawDebugData");
		EnableDebugDrawing_bShouldDrawDebugData_Offset = NativeReflectionCached.GetPropertyOffset(EnableDebugDrawing_FunctionAddress, "bShouldDrawDebugData");
		EnableDebugDrawing_bShouldDrawDebugData_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableDebugDrawing_FunctionAddress, "bShouldDrawDebugData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableDebugDrawing_PathColor_PropertyAddress, EnableDebugDrawing_FunctionAddress, "PathColor");
		EnableDebugDrawing_PathColor_Offset = NativeReflectionCached.GetPropertyOffset(EnableDebugDrawing_FunctionAddress, "PathColor");
		EnableDebugDrawing_PathColor_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableDebugDrawing_FunctionAddress, "PathColor", Classes.FStructProperty);
		EnableDebugDrawing_IsValid = EnableDebugDrawing_FunctionAddress != IntPtr.Zero && EnableDebugDrawing_bShouldDrawDebugData_IsValid && EnableDebugDrawing_PathColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavigationPath:EnableDebugDrawing", EnableDebugDrawing_IsValid);
	}
}
