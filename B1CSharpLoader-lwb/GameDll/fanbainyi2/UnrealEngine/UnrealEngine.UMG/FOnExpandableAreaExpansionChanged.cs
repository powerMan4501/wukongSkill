using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.OnExpandableAreaExpansionChanged__DelegateSignature")]
public class FOnExpandableAreaExpansionChanged : FMulticastDelegate<FOnExpandableAreaExpansionChanged.Signature>
{
	public delegate void Signature(UExpandableArea Area, bool bIsExpanded);

	private static bool OnExpandableAreaExpansionChanged__DelegateSignature_IsValid;

	private static IntPtr OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress;

	private static int OnExpandableAreaExpansionChanged__DelegateSignature_ParamsSize;

	private static bool OnExpandableAreaExpansionChanged__DelegateSignature_Area_IsValid;

	private static FFieldAddress OnExpandableAreaExpansionChanged__DelegateSignature_Area_PropertyAddress;

	private static int OnExpandableAreaExpansionChanged__DelegateSignature_Area_Offset;

	private static bool OnExpandableAreaExpansionChanged__DelegateSignature_bIsExpanded_IsValid;

	private static FFieldAddress OnExpandableAreaExpansionChanged__DelegateSignature_bIsExpanded_PropertyAddress;

	private static int OnExpandableAreaExpansionChanged__DelegateSignature_bIsExpanded_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnExpandableAreaExpansionChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.OnExpandableAreaExpansionChanged__DelegateSignature");
		OnExpandableAreaExpansionChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnExpandableAreaExpansionChanged__DelegateSignature_Area_PropertyAddress, OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress, "Area");
		OnExpandableAreaExpansionChanged__DelegateSignature_Area_Offset = NativeReflectionCached.GetPropertyOffset(OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress, "Area");
		OnExpandableAreaExpansionChanged__DelegateSignature_Area_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress, "Area", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExpandableAreaExpansionChanged__DelegateSignature_bIsExpanded_PropertyAddress, OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress, "bIsExpanded");
		OnExpandableAreaExpansionChanged__DelegateSignature_bIsExpanded_Offset = NativeReflectionCached.GetPropertyOffset(OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress, "bIsExpanded");
		OnExpandableAreaExpansionChanged__DelegateSignature_bIsExpanded_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress, "bIsExpanded", Classes.FBoolProperty);
		OnExpandableAreaExpansionChanged__DelegateSignature_IsValid = OnExpandableAreaExpansionChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnExpandableAreaExpansionChanged__DelegateSignature_Area_IsValid && OnExpandableAreaExpansionChanged__DelegateSignature_bIsExpanded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.OnExpandableAreaExpansionChanged__DelegateSignature", OnExpandableAreaExpansionChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UExpandableArea Area, bool bIsExpanded)
	{
		if (!OnExpandableAreaExpansionChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.OnExpandableAreaExpansionChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnExpandableAreaExpansionChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExpandableAreaExpansionChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UExpandableArea>.ToNative(IntPtr.Add(intPtr, OnExpandableAreaExpansionChanged__DelegateSignature_Area_Offset), 0, OnExpandableAreaExpansionChanged__DelegateSignature_Area_PropertyAddress.Address, Area);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnExpandableAreaExpansionChanged__DelegateSignature_bIsExpanded_Offset), 0, OnExpandableAreaExpansionChanged__DelegateSignature_bIsExpanded_PropertyAddress.Address, bIsExpanded);
			ProcessDelegate(intPtr);
		}
	}
}
