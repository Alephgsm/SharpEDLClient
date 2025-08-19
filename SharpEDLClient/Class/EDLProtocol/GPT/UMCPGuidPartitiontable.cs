using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol.GPT
{
    public class UMCPGuidPartitiontable
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
        public UMCPGuidPartitiontable(string filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal static byte[] GetSubArray(byte[] data, uint offset, uint len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal static byte[] readDrive(FileStream streamToRead, ulong offset, ulong sizeToRead)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal UMCPGuidPartitiontable(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] GetBytes(string devicePath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static UMCPGuidPartitiontable Get(string devicePath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public GuidPartitionTableEntry[] GetPartitionTable()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}