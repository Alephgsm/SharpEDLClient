using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol.GPT
{
    public class EMMCGuidPartitiontable
    {
        public readonly Version Revision;
        public readonly uint HeaderSize;
        public readonly ulong MyLBA;
        public readonly ulong AlternateLBA;
        public readonly ulong FirstUsableLBA;
        public readonly ulong LastUsableLBA;
        public readonly Guid DiskGUID;
        public readonly ulong PartitionEntryLBA;
        public readonly uint NumberOfPartitionEntries;
        public readonly uint SizeOfPartitionEntry;
        public readonly GuidPartitionTableEntry[] PartitionTable;
        private const ulong GPT_OFFSET = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        private const ulong SECTOR_SIZE = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        public EMMCGuidPartitiontable(string devicePath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal static byte[] GetSubArray(byte[] InputBytes, uint offset, uint length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal static byte[] readDrive(FileStream streamToRead, ulong offset, ulong sizeToRead)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal EMMCGuidPartitiontable(byte[] bytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] GetBytes(string devicePath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static EMMCGuidPartitiontable Get(string devicePath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public GuidPartitionTableEntry[] GetPartitionTable()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}