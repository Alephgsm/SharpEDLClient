using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace SharpEDLClient.Class.EDLProtocol
{
    [StructLayout(LayoutKind.Sequential)]
    public struct COMMTIMEOUTS
    {
        public long ReadIntervalTimeout;
        public long ReadTotalTimeoutMultiplier;
        public long ReadTotalTimeoutConstant;
        public long WriteTotalTimeoutMultiplier;
        public long WriteTotalTimeoutConstant;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COMSTAT
    {
        public uint uiCtsHold;
        public uint uiDsrHold;
        public uint uiRlsdHold;
        public uint uiXoffHold;
        public uint uiXoffSent;
        public uint uiEof;
        public uint uiTxim;
        public UInt32 uiFlags;
        public UInt32 cbInQue;
        public UInt32 cbOutQue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DCB
    {
        public UInt32 DCBlength;
        public UInt32 BaudRate;
        public UInt32 fBinary;
        public UInt32 fParity;
        public UInt32 fOutxCtsFlow;
        public UInt32 fOutxDsrFlow;
        public UInt32 fDtrControl;
        public UInt32 fDsrSensitivity;
        public UInt32 fTXContinueOnXoff;
        public UInt32 fOutX;
        public UInt32 fInX;
        public UInt32 fErrorChar;
        public UInt32 fNull;
        public UInt32 fRtsControl;
        public UInt32 fAbortOnError;
        public UInt32 fDummy2;
        public UInt16 wReserved;
        public UInt16 XonLim;
        public UInt16 XoffLim;
        public byte ByteSize;
        public byte Parity;
        public byte StopBits;
        public char XonChar;
        public char XoffChar;
        public char ErrorChar;
        public char EofChar;
        public char EvtChar;
        public UInt16 wReserved1;
    }

    public class USBApi : IDisposable
    {
#region Win32 API Declarations
        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int SetCommState(SafeFileHandle hFile, ref DCB lpDCB)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int FlushFileBuffers(SafeFileHandle hFile)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int ClearCommError(SafeFileHandle hFile, out UInt32 lpErrors, out COMSTAT lpStat)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool SetupComm(SafeFileHandle hFile, int dwInQueue, int dwOutQueue)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int GetCommState(SafeFileHandle hFile, out DCB lpDCB)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern SafeFileHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int CloseHandle(SafeFileHandle hObject)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int ReadFile(SafeFileHandle safeFileHandle_0, byte[] byte_1, int int_1, ref int int_2, IntPtr FE8ED0B1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int WriteFile(SafeFileHandle safeFileHandle_0, byte[] F508251C, int int_1, out int int_2, IntPtr intptr_0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetFileSize(SafeFileHandle safeFileHandle_0, ref long long_3)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool PurgeComm(SafeFileHandle hFile, uint dwFlags)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool ClearCommBreak(SafeFileHandle hFile)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int SetCommTimeouts(SafeFileHandle hFile, ref COMMTIMEOUTS lpCommTimeouts)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern bool EscapeCommFunction(SafeFileHandle hFile, int dwFunc)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
#endregion
#region Constants
        private const int CBR_110 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_300 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_600 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_1200 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_2400 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_4800 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_9600 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_14400 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_19200 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_38400 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_56000 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_57600 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_115200 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_128000 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int CBR_256000 = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int FILE_TYPE_UNKNOWN = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int FILE_TYPE_DISK = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int FILE_TYPE_CHAR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int FILE_TYPE_PIPE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int FILE_TYPE_REMOTE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int FALSE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int TRUE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int DTR_CONTROL_ENABLE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int RTS_CONTROL_ENABLE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const int OPEN_EXISTING = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint PURGE_RXCLEAR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint PURGE_TXCLEAR = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const uint GENERIC_READ_WRITE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
#endregion
#region Fields
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public static SafeFileHandle OpenWritePort = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public string portname = string.Empty;
        public byte[] recData;
        public bool isDdr4;
        public bool isDdr5;
        public string auth = string.Empty;
        public int m_dwBufferSectors;
        public int intSectorSize;
        public string storageInfo = string.Empty;
        public bool isSupportPartialReset;
        public bool isGetChipNum;
        public string chipNum = string.Empty;
        public bool needEdlAuth;
        public event LogDelegate Log;
        public int writeCount;
        public string edlAuthErr = "error: only nop and sig tag can be recevied before authentication";
        private bool disposed;
#endregion
#region Properties
        public bool IsOpen => OpenWritePort != null && !OpenWritePort.IsInvalid && !OpenWritePort.IsClosed;

#endregion
#region Public Methods
        public bool OpenDisk(string devices)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool IsValidPTr()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void SetReadWriteTimeout(int interval)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void Close()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void flush()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool reconfigure()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void flushInput()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void flushOutput()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void Write(string utf8)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool Sign(string Argument)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] DiskRead(int delay = 0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void DiskClose()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string WriteRead(string str)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void Write(byte[] buffer)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] getRecDataIgnoreExcep()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool IsAckDisk()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string CekResponseConfig()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] getRecData()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void discardbuffer()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] ReadPortData()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SendCommand(string command, bool checkAck)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<XmlDocument> GetResponseXml(bool waiteACK)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool GetResponse(bool waiteACK)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool chkRspAck(out string msg, int chunkCount)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region Private Methods
        private byte[] ReadDataFromPort()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private string[] Dump(byte[] binary, bool waitACK = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int SubstringCount(string str, string substring)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void ProcessResponseAttribute(XmlAttribute attribute)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void ProcessChipSerialNumber(string value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region IDisposable Implementation
        public void Dispose()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
#endregion
    }
}