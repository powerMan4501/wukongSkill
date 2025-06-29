using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net;

internal class SSPIAuthType : SSPIInterface
{
	private static readonly SecurDll Library;

	private static volatile SecurityPackageInfoClass[] m_SecurityPackages;

	public SecurityPackageInfoClass[] SecurityPackages
	{
		get
		{
			return m_SecurityPackages;
		}
		set
		{
			m_SecurityPackages = value;
		}
	}

	public int EnumerateSecurityPackages(out int pkgnum, out SafeFreeContextBuffer pkgArray)
	{
		return SafeFreeContextBuffer.EnumeratePackages(Library, out pkgnum, out pkgArray);
	}

	public int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref AuthIdentity authdata, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireCredentialsHandle(Library, moduleName, usage, ref authdata, out outCredential);
	}

	public int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref SafeSspiAuthDataHandle authdata, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireCredentialsHandle(moduleName, usage, ref authdata, out outCredential);
	}

	public int AcquireDefaultCredential(string moduleName, CredentialUse usage, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireDefaultCredential(Library, moduleName, usage, out outCredential);
	}

	public int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref SecureCredential authdata, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireCredentialsHandle(Library, moduleName, usage, ref authdata, out outCredential);
	}

	public int AcquireCredentialsHandle(string moduleName, CredentialUse usage, ref SecureCredential2 authdata, out SafeFreeCredentials outCredential)
	{
		return SafeFreeCredentials.AcquireCredentialsHandle(Library, moduleName, usage, ref authdata, out outCredential);
	}

	public int AcceptSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer inputBuffer, ContextFlags inFlags, Endianness endianness, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		return SafeDeleteContext.AcceptSecurityContext(Library, ref credential, ref context, inFlags, endianness, inputBuffer, null, outputBuffer, ref outFlags);
	}

	public int AcceptSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers, ContextFlags inFlags, Endianness endianness, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		return SafeDeleteContext.AcceptSecurityContext(Library, ref credential, ref context, inFlags, endianness, null, inputBuffers, outputBuffer, ref outFlags);
	}

	public int InitializeSecurityContext(ref SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, ContextFlags inFlags, Endianness endianness, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		return SafeDeleteContext.InitializeSecurityContext(Library, ref credential, ref context, targetName, inFlags, endianness, inputBuffer, null, outputBuffer, ref outFlags);
	}

	public int InitializeSecurityContext(SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, ContextFlags inFlags, Endianness endianness, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		return SafeDeleteContext.InitializeSecurityContext(Library, ref credential, ref context, targetName, inFlags, endianness, null, inputBuffers, outputBuffer, ref outFlags);
	}

	public int EncryptMessage(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber)
	{
		int result = -2146893055;
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			context.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				context.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				result = UnsafeNclNativeMethods.NativeNTSSPI.EncryptMessage(ref context._handle, 0u, inputOutput, sequenceNumber);
				context.DangerousRelease();
			}
		}
		return result;
	}

	public unsafe int DecryptMessage(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber)
	{
		int num = -2146893055;
		bool success = false;
		uint num2 = 0u;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			context.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				context.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				num = UnsafeNclNativeMethods.NativeNTSSPI.DecryptMessage(ref context._handle, inputOutput, sequenceNumber, &num2);
				context.DangerousRelease();
			}
		}
		if (num == 0 && num2 == 2147483649u)
		{
			throw new InvalidOperationException(SR.GetString("net_auth_message_not_encrypted"));
		}
		return num;
	}

	public int MakeSignature(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber)
	{
		int result = -2146893055;
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			context.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				context.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				result = UnsafeNclNativeMethods.NativeNTSSPI.EncryptMessage(ref context._handle, 2147483649u, inputOutput, sequenceNumber);
				context.DangerousRelease();
			}
		}
		return result;
	}

	public unsafe int VerifySignature(SafeDeleteContext context, SecurityBufferDescriptor inputOutput, uint sequenceNumber)
	{
		int result = -2146893055;
		bool success = false;
		uint num = 0u;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			context.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				context.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				result = UnsafeNclNativeMethods.NativeNTSSPI.DecryptMessage(ref context._handle, inputOutput, sequenceNumber, &num);
				context.DangerousRelease();
			}
		}
		return result;
	}

	public int QueryContextChannelBinding(SafeDeleteContext context, ContextAttribute attribute, out SafeFreeContextBufferChannelBinding binding)
	{
		binding = null;
		throw new NotSupportedException();
	}

	public unsafe int QueryContextAttributes(SafeDeleteContext context, ContextAttribute attribute, byte[] buffer, Type handleType, out SafeHandle refHandle)
	{
		refHandle = null;
		if (handleType != null)
		{
			if (handleType == typeof(SafeFreeContextBuffer))
			{
				refHandle = SafeFreeContextBuffer.CreateEmptyHandle(Library);
			}
			else
			{
				if (!(handleType == typeof(SafeFreeCertContext)))
				{
					throw new ArgumentException(SR.GetString("SSPIInvalidHandleType", handleType.FullName), "handleType");
				}
				refHandle = new SafeFreeCertContext();
			}
		}
		fixed (byte* buffer2 = buffer)
		{
			return SafeFreeContextBuffer.QueryContextAttributes(Library, context, attribute, buffer2, refHandle);
		}
	}

	public int SetContextAttributes(SafeDeleteContext context, ContextAttribute attribute, byte[] buffer)
	{
		throw new NotImplementedException();
	}

	public int QuerySecurityContextToken(SafeDeleteContext phContext, out SafeCloseHandle phToken)
	{
		return GetSecurityContextToken(phContext, out phToken);
	}

	public int CompleteAuthToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers)
	{
		return SafeDeleteContext.CompleteAuthToken(Library, ref refContext, inputBuffers);
	}

	public int ApplyControlToken(ref SafeDeleteContext refContext, SecurityBuffer[] inputBuffers)
	{
		throw new NotSupportedException();
	}

	private static int GetSecurityContextToken(SafeDeleteContext phContext, out SafeCloseHandle safeHandle)
	{
		int result = -2146893055;
		bool success = false;
		safeHandle = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			phContext.DangerousAddRef(ref success);
		}
		catch (Exception ex)
		{
			if (success)
			{
				phContext.DangerousRelease();
				success = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			if (success)
			{
				result = UnsafeNclNativeMethods.SafeNetHandles.QuerySecurityContextToken(ref phContext._handle, out safeHandle);
				phContext.DangerousRelease();
			}
		}
		return result;
	}
}
