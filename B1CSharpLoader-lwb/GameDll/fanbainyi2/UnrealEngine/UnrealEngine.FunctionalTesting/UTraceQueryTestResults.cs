using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResults", "FunctionalTesting", UnrealModuleType.Engine)]
public class UTraceQueryTestResults : UObject
{
	private static bool ChannelResults_IsValid;

	private static int ChannelResults_Offset;

	private static bool ObjectResults_IsValid;

	private static int ObjectResults_Offset;

	private static bool ProfileResults_IsValid;

	private static int ProfileResults_Offset;

	private static bool BatchOptions_IsValid;

	private static int BatchOptions_Offset;

	private static bool ToString_IsValid;

	private static IntPtr ToString_FunctionAddress;

	private static int ToString_ParamsSize;

	private static bool ToString_ReturnValue_IsValid;

	private static FFieldAddress ToString_ReturnValue_PropertyAddress;

	private static int ToString_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4504149383184389uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResults:ChannelResults")]
	public FTraceQueryTestResultsInner ChannelResults
	{
		get
		{
			CheckDestroyed();
			if (!ChannelResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.TraceQueryTestResults:ChannelResults");
				return default(FTraceQueryTestResultsInner);
			}
			return FTraceQueryTestResultsInner.FromNative(IntPtr.Add(base.Address, ChannelResults_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChannelResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.TraceQueryTestResults:ChannelResults");
			}
			else
			{
				FTraceQueryTestResultsInner.ToNative(IntPtr.Add(base.Address, ChannelResults_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504149383184389uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResults:ObjectResults")]
	public FTraceQueryTestResultsInner ObjectResults
	{
		get
		{
			CheckDestroyed();
			if (!ObjectResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.TraceQueryTestResults:ObjectResults");
				return default(FTraceQueryTestResultsInner);
			}
			return FTraceQueryTestResultsInner.FromNative(IntPtr.Add(base.Address, ObjectResults_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObjectResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.TraceQueryTestResults:ObjectResults");
			}
			else
			{
				FTraceQueryTestResultsInner.ToNative(IntPtr.Add(base.Address, ObjectResults_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4504149383184389uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResults:ProfileResults")]
	public FTraceQueryTestResultsInner ProfileResults
	{
		get
		{
			CheckDestroyed();
			if (!ProfileResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.TraceQueryTestResults:ProfileResults");
				return default(FTraceQueryTestResultsInner);
			}
			return FTraceQueryTestResultsInner.FromNative(IntPtr.Add(base.Address, ProfileResults_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProfileResults_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.TraceQueryTestResults:ProfileResults");
			}
			else
			{
				FTraceQueryTestResultsInner.ToNative(IntPtr.Add(base.Address, ProfileResults_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResults:BatchOptions")]
	public FTraceChannelTestBatchOptions BatchOptions
	{
		get
		{
			CheckDestroyed();
			if (!BatchOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.TraceQueryTestResults:BatchOptions");
				return default(FTraceChannelTestBatchOptions);
			}
			return FTraceChannelTestBatchOptions.FromNative(IntPtr.Add(base.Address, BatchOptions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BatchOptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.TraceQueryTestResults:BatchOptions");
			}
			else
			{
				FTraceChannelTestBatchOptions.ToNative(IntPtr.Add(base.Address, BatchOptions_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResults:ToString")]
	public new unsafe string ToString()
	{
		CheckDestroyed();
		if (!ToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.TraceQueryTestResults:ToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ToString_FunctionAddress, intPtr, ToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ToString_ReturnValue_Offset), 0, ToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UTraceQueryTestResults()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTraceQueryTestResults)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTraceQueryTestResults));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FunctionalTesting.TraceQueryTestResults");
		ChannelResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChannelResults");
		ChannelResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChannelResults", Classes.FStructProperty);
		ObjectResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectResults");
		ObjectResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectResults", Classes.FStructProperty);
		ProfileResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProfileResults");
		ProfileResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProfileResults", Classes.FStructProperty);
		BatchOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BatchOptions");
		BatchOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BatchOptions", Classes.FStructProperty);
		ToString_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToString");
		ToString_ParamsSize = NativeReflection.GetFunctionParamsSize(ToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToString_ReturnValue_PropertyAddress, ToString_FunctionAddress, "ReturnValue");
		ToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToString_FunctionAddress, "ReturnValue");
		ToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ToString_IsValid = ToString_FunctionAddress != IntPtr.Zero && ToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.TraceQueryTestResults:ToString", ToString_IsValid);
	}
}
