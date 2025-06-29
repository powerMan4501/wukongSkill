namespace UnrealEngine.Runtime;

public class NativeMulticastDelegate<TNativeDelegate, TRegisterNativeDelegate, TManagedDelegate> : NativeDelegate<TNativeDelegate, TRegisterNativeDelegate, TManagedDelegate> where TNativeDelegate : class where TRegisterNativeDelegate : class where TManagedDelegate : class
{
	public override bool IsMulticast => true;
}
