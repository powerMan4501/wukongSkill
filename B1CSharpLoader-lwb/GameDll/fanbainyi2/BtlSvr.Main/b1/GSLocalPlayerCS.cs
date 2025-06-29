using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSLocalPlayerCS")]
public class GSLocalPlayerCS : UGSLocalPlayer
{
	public delegate string Del_FillGameLoginOptions(GSLocalPlayerCS LocalPlayer);

	private static bool GetGameLoginOptionsCS_IsValid;

	private static IntPtr GetGameLoginOptionsCS_FunctionAddress;

	private static int GetGameLoginOptionsCS_ParamsSize;

	private static bool GetGameLoginOptionsCS_ReturnValue_IsValid;

	private static int GetGameLoginOptionsCS_ReturnValue_Offset;

	private static FFieldAddress GetGameLoginOptionsCS_ReturnValue_PropertyAddress;

	protected event Del_FillGameLoginOptions FillGameLoginOptionsFunc;

	public void SetGetGameLoginOptionsFunc(Del_FillGameLoginOptions Func)
	{
		this.FillGameLoginOptionsFunc = Func;
	}

	[USharpPath("/Script/b1-Managed.GSLocalPlayerCS:GetGameLoginOptionsCS")]
	protected override string GetGameLoginOptionsCS_Implementation()
	{
		string result = "";
		if (this.FillGameLoginOptionsFunc != null)
		{
			result = this.FillGameLoginOptionsFunc(this);
		}
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSLocalPlayerCS:GetGameLoginOptionsCS")]
	private static void GetGameLoginOptionsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSLocalPlayerCS gSLocalPlayerCS = GCHelper.Find<GSLocalPlayerCS>(obj);
		string gameLoginOptionsCS_Implementation = gSLocalPlayerCS.GetGameLoginOptionsCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetGameLoginOptionsCS_ReturnValue_Offset), gameLoginOptionsCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSLocalPlayerCS");
		GetGameLoginOptionsCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGameLoginOptionsCS");
		GetGameLoginOptionsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameLoginOptionsCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetGameLoginOptionsCS_ReturnValue_PropertyAddress, GetGameLoginOptionsCS_FunctionAddress, "ReturnValue");
		GetGameLoginOptionsCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetGameLoginOptionsCS_FunctionAddress, "ReturnValue");
		GetGameLoginOptionsCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetGameLoginOptionsCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetGameLoginOptionsCS_IsValid = GetGameLoginOptionsCS_FunctionAddress != IntPtr.Zero && GetGameLoginOptionsCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSLocalPlayerCS:GetGameLoginOptionsCS", GetGameLoginOptionsCS_IsValid);
	}

	static GSLocalPlayerCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSLocalPlayerCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSLocalPlayerCS));
	}
}
