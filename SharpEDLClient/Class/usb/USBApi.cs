using Microsoft.Win32.SafeHandles;
using SharpEDLClient.Class.EDLProtocol;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace SharpEDLClient.Class.usb
{
    public class USBApi
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public static SafeFileHandle OpenWritePort = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern SafeFileHandle CreateFile(string FE0A9589, int int_1, uint uint_0, IntPtr intptr_0, uint uint_1, uint uint_2, IntPtr AE930ABD)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(SafeFileHandle EA22139C)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int ReadFile(SafeFileHandle safeFileHandle_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] byte_1, int int_1, ref int int_2, IntPtr FE8ED0B1)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern int WriteFile(SafeFileHandle safeFileHandle_0, byte[] F508251C, int int_1, out int int_2, IntPtr intptr_0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetFileSize(SafeFileHandle safeFileHandle_0, ref long long_3)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "ReadFile", SetLastError = true)]
        internal static extern int ReadFReadFileile_1(SafeFileHandle FE370F11, IntPtr E1A66E04, int int_1, ref int int_2, IntPtr CC095325)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern bool PurgeComm(SafeFileHandle hFile, // handle to communications resource
 uint dwFlags // action to perform
        )
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
        public bool OpenDisk(string devices)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string portname;
        public bool open()
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

        public bool IsOpen
        {
            get
            {
                if (OpenWritePort == null || OpenWritePort.IsInvalid || OpenWritePort.IsClosed)
                {
                    return false;
                }

                return true;
            }
        }

        public void discardbuffer()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] recData;
        public byte[] ReadPortData()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private byte[] ReadDataFromPort()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private string[] Dump(byte[] binary)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private int SubstringCount(string str, string substring)
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

        public bool isDdr4;
        public bool isDdr5;
        public string auth = "";
        public int m_dwBufferSectors;
        public int intSectorSize;
        public string storageInfo = "";
        public bool isSupportPartialReset;
        public bool isGetChipNum;
        public string chipNum = "";
        public bool needEdlAuth;
        public event LogDelegate Log;
        public int writeCount;
        public string edlAuthErr = "error: only nop and sig tag can be recevied before authentication";
        public bool GetResponse(bool waiteACK)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool chkRspAck(out string msg, int chunkCount)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private string[] Dump(byte[] binary, bool waitACK)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}