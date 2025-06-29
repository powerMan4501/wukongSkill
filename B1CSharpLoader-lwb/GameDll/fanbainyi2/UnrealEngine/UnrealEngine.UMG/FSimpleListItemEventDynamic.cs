using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UDelegate]
[UMetaPath("/Script/UMG.SimpleListItemEventDynamic__DelegateSignature")]
public class FSimpleListItemEventDynamic : FMulticastDelegate<FSimpleListItemEventDynamic.Signature>
{
	public delegate void Signature(UObject Item);

	private static bool SimpleListItemEventDynamic__DelegateSignature_IsValid;

	private static IntPtr SimpleListItemEventDynamic__DelegateSignature_FunctionAddress;

	private static int SimpleListItemEventDynamic__DelegateSignature_ParamsSize;

	private static bool SimpleListItemEventDynamic__DelegateSignature_Item_IsValid;

	private static FFieldAddress SimpleListItemEventDynamic__DelegateSignature_Item_PropertyAddress;

	private static int SimpleListItemEventDynamic__DelegateSignature_Item_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FSimpleListItemEventDynamic()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		SimpleListItemEventDynamic__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.SimpleListItemEventDynamic__DelegateSignature");
		SimpleListItemEventDynamic__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(SimpleListItemEventDynamic__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SimpleListItemEventDynamic__DelegateSignature_Item_PropertyAddress, SimpleListItemEventDynamic__DelegateSignature_FunctionAddress, "Item");
		SimpleListItemEventDynamic__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(SimpleListItemEventDynamic__DelegateSignature_FunctionAddress, "Item");
		SimpleListItemEventDynamic__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(SimpleListItemEventDynamic__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
		SimpleListItemEventDynamic__DelegateSignature_IsValid = SimpleListItemEventDynamic__DelegateSignature_FunctionAddress != IntPtr.Zero && SimpleListItemEventDynamic__DelegateSignature_Item_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SimpleListItemEventDynamic__DelegateSignature", SimpleListItemEventDynamic__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UObject Item)
	{
		if (!SimpleListItemEventDynamic__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SimpleListItemEventDynamic__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(SimpleListItemEventDynamic__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SimpleListItemEventDynamic__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SimpleListItemEventDynamic__DelegateSignature_Item_Offset), 0, SimpleListItemEventDynamic__DelegateSignature_Item_PropertyAddress.Address, Item);
			ProcessDelegate(intPtr);
		}
	}
}
