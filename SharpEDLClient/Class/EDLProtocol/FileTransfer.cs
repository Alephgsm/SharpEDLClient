using SharpEDLClient.Class.usb;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol
{
    public class FileTransfer
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct SparseImageHeader
        {
            public uint uMagic;
            public ushort uMajorVersion;
            public ushort uMinorVersion;
            public ushort uFileHeaderSize;
            public ushort uChunkHeaderSize;
            public uint uBlockSize;
            public uint uTotalBlocks;
            public uint uTotalChunks;
            public uint uImageChecksum;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct SparseChunkHeader
        {
            public ushort uChunkType;
            public ushort uReserved1;
            public uint uChunkSize;
            public uint uTotalSize;
        }

        public usb Port;
        private USBApi api;
        public bool native
        {
            get
            {
                return api != null;
            }
        }

        public FileTransfer(USBApi api, usb Port)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public event ProgressEventHandler Progress;
        public int transfer(string fpath, int offset, int size)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] GetBytesFromFile(Stream str, long offset, int size, out int n, out float percent)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] GetBytesFromFile(Stream str, long offset, int size, out int n)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void WriteSparseFileToDevice(string FilePath, string pszPartitionStartSector, string pszPartitionSectorNumber, string pszImageFile, string pszFileStartSector, string pszSectorSizeInBytes, string pszPhysicalPartitionNumber, string addtionalFirehose)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void WriteFile(Stream str, string strPartitionStartSector, string strPartitionSectorNumber, string pszImageFile, string strFileStartSector, string strFileSectorOffset, string sector_size, string physical_partition_number, string addtionalFirehose, bool chkAck, int? chunkCount, int filldatasize)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] GetUnitBytesFromFile(Stream fileStream, long offset, int size, int Unitsize, out int n)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void WriteFile(Stream Reader, string strPartitionStartSector, string strPartitionSectorNumber, string pszImageFile, string strFileStartSector, string strFileSectorOffset, string sector_size, string physical_partition_number, string addtionalFirehose, bool chkAck, int? chunkCount)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}