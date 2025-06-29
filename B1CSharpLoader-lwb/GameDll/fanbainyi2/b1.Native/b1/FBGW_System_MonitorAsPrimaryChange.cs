using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/UnrealExtent.BGW_System_MonitorAsPrimaryChange__DelegateSignature")]
public class FBGW_System_MonitorAsPrimaryChange : FMulticastDelegate<FBGW_System_MonitorAsPrimaryChange.Signature>
{
	public delegate void Signature(int TargetPrimaryMonitorIndex);

	private static bool BGW_System_MonitorAsPrimaryChange__DelegateSignature_IsValid;

	private static IntPtr BGW_System_MonitorAsPrimaryChange__DelegateSignature_FunctionAddress;

	private static int BGW_System_MonitorAsPrimaryChange__DelegateSignature_ParamsSize;

	private static bool BGW_System_MonitorAsPrimaryChange__DelegateSignature_TargetPrimaryMonitorIndex_IsValid;

	private static FFieldAddress BGW_System_MonitorAsPrimaryChange__DelegateSignature_TargetPrimaryMonitorIndex_PropertyAddress;

	private static int BGW_System_MonitorAsPrimaryChange__DelegateSignature_TargetPrimaryMonitorIndex_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBGW_System_MonitorAsPrimaryChange()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BGW_System_MonitorAsPrimaryChange__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UnrealExtent.BGW_System_MonitorAsPrimaryChange__DelegateSignature");
		BGW_System_MonitorAsPrimaryChange__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BGW_System_MonitorAsPrimaryChange__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGW_System_MonitorAsPrimaryChange__DelegateSignature_TargetPrimaryMonitorIndex_PropertyAddress, BGW_System_MonitorAsPrimaryChange__DelegateSignature_FunctionAddress, "TargetPrimaryMonitorIndex");
		BGW_System_MonitorAsPrimaryChange__DelegateSignature_TargetPrimaryMonitorIndex_Offset = NativeReflectionCached.GetPropertyOffset(BGW_System_MonitorAsPrimaryChange__DelegateSignature_FunctionAddress, "TargetPrimaryMonitorIndex");
		BGW_System_MonitorAsPrimaryChange__DelegateSignature_TargetPrimaryMonitorIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(BGW_System_MonitorAsPrimaryChange__DelegateSignature_FunctionAddress, "TargetPrimaryMonitorIndex", Classes.FIntProperty);
		BGW_System_MonitorAsPrimaryChange__DelegateSignature_IsValid = BGW_System_MonitorAsPrimaryChange__DelegateSignature_FunctionAddress != IntPtr.Zero && BGW_System_MonitorAsPrimaryChange__DelegateSignature_TargetPrimaryMonitorIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGW_System_MonitorAsPrimaryChange__DelegateSignature", BGW_System_MonitorAsPrimaryChange__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int TargetPrimaryMonitorIndex)
	{
		if (!BGW_System_MonitorAsPrimaryChange__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGW_System_MonitorAsPrimaryChange__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BGW_System_MonitorAsPrimaryChange__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGW_System_MonitorAsPrimaryChange__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGW_System_MonitorAsPrimaryChange__DelegateSignature_TargetPrimaryMonitorIndex_Offset), 0, BGW_System_MonitorAsPrimaryChange__DelegateSignature_TargetPrimaryMonitorIndex_PropertyAddress.Address, TargetPrimaryMonitorIndex);
			ProcessDelegate(intPtr);
		}
	}
}
