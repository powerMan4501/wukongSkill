using System.Collections;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System.IO.IsolatedStorage;

internal sealed class IsolatedStorageFileEnumerator : IEnumerator
{
	private const char s_SepExternal = '\\';

	private IsolatedStorageFile m_Current;

	private IsolatedStorageScope m_Scope;

	private FileIOPermission m_fiop;

	private string m_rootDir;

	private TwoLevelFileEnumerator m_fileEnum;

	private bool m_fReset;

	private bool m_fEnd;

	public object Current
	{
		get
		{
			if (m_fReset)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
			}
			if (m_fEnd)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumEnded"));
			}
			return m_Current;
		}
	}

	[SecurityCritical]
	internal IsolatedStorageFileEnumerator(IsolatedStorageScope scope)
	{
		m_Scope = scope;
		m_fiop = IsolatedStorageFile.GetGlobalFileIOPerm(scope);
		m_rootDir = IsolatedStorageFile.GetRootDir(scope);
		m_fileEnum = new TwoLevelFileEnumerator(m_rootDir);
		Reset();
	}

	[SecuritySafeCritical]
	public bool MoveNext()
	{
		m_fiop.Assert();
		m_fReset = false;
		IsolatedStorageFile isolatedStorageFile;
		Stream s;
		Stream s2;
		Stream s3;
		IsolatedStorageScope scope;
		string domainName;
		string assemName;
		string appName;
		do
		{
			IL_0012:
			if (!m_fileEnum.MoveNext())
			{
				m_fEnd = true;
				return false;
			}
			isolatedStorageFile = new IsolatedStorageFile();
			TwoPaths twoPaths = (TwoPaths)m_fileEnum.Current;
			bool flag = false;
			if (IsolatedStorageFile.NotAssemFilesDir(twoPaths.Path2) && IsolatedStorageFile.NotAppFilesDir(twoPaths.Path2))
			{
				flag = true;
			}
			s = null;
			s2 = null;
			s3 = null;
			if (flag)
			{
				if (!GetIDStream(twoPaths.Path1, out s) || !GetIDStream(twoPaths.Path1 + "\\" + twoPaths.Path2, out s2))
				{
					goto IL_0012;
				}
				s.Position = 0L;
				scope = (IsolatedStorage.IsRoaming(m_Scope) ? (IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming) : ((!IsolatedStorage.IsMachine(m_Scope)) ? (IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly) : (IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine)));
				domainName = twoPaths.Path1;
				assemName = twoPaths.Path2;
				appName = null;
			}
			else if (IsolatedStorageFile.NotAppFilesDir(twoPaths.Path2))
			{
				if (!GetIDStream(twoPaths.Path1, out s2))
				{
					goto IL_0012;
				}
				scope = (IsolatedStorage.IsRoaming(m_Scope) ? (IsolatedStorageScope.User | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming) : ((!IsolatedStorage.IsMachine(m_Scope)) ? (IsolatedStorageScope.User | IsolatedStorageScope.Assembly) : (IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine)));
				domainName = null;
				assemName = twoPaths.Path1;
				appName = null;
				s2.Position = 0L;
			}
			else
			{
				if (!GetIDStream(twoPaths.Path1, out s3))
				{
					goto IL_0012;
				}
				scope = (IsolatedStorage.IsRoaming(m_Scope) ? (IsolatedStorageScope.User | IsolatedStorageScope.Roaming | IsolatedStorageScope.Application) : ((!IsolatedStorage.IsMachine(m_Scope)) ? (IsolatedStorageScope.User | IsolatedStorageScope.Application) : (IsolatedStorageScope.Machine | IsolatedStorageScope.Application)));
				domainName = null;
				assemName = null;
				appName = twoPaths.Path1;
				s3.Position = 0L;
			}
		}
		while (!isolatedStorageFile.InitStore(scope, s, s2, s3, domainName, assemName, appName) || !isolatedStorageFile.InitExistingStore(scope));
		m_Current = isolatedStorageFile;
		return true;
	}

	public void Reset()
	{
		m_Current = null;
		m_fReset = true;
		m_fEnd = false;
		m_fileEnum.Reset();
	}

	private bool GetIDStream(string path, out Stream s)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(m_rootDir);
		stringBuilder.Append(path);
		stringBuilder.Append('\\');
		stringBuilder.Append("identity.dat");
		s = null;
		try
		{
			byte[] buffer;
			using (FileStream fileStream = new FileStream(stringBuilder.ToString(), FileMode.Open))
			{
				int num = (int)fileStream.Length;
				buffer = new byte[num];
				int num2 = 0;
				while (num > 0)
				{
					int num3 = fileStream.Read(buffer, num2, num);
					if (num3 == 0)
					{
						__Error.EndOfFile();
					}
					num2 += num3;
					num -= num3;
				}
			}
			s = new MemoryStream(buffer);
		}
		catch
		{
			return false;
		}
		return true;
	}
}
