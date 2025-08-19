using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol.GPT
{
    public class GuidPartitionTableHeader
    {
        private const string SIGNATURE_STRING = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
        internal readonly string Signature;
        internal readonly Version Revision;
        internal readonly uint HeaderSize;
        internal readonly uint HeaderCRC32;
        internal readonly ulong MyLBA;
        internal readonly ulong AlternateLBA;
        internal readonly ulong FirstUsableLBA;
        internal readonly ulong LastUsableLBA;
        internal readonly Guid DiskGUID;
        internal readonly ulong PartitionEntryLBA;
        internal readonly uint NumberOfPartitionEntries;
        internal readonly uint SizeOfPartitionEntry;
        internal readonly byte[] PartitionEntryArrayCRC32;
        internal GuidPartitionTableHeader(byte[] bytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal static byte[] GetSubArray(byte[] data, uint offset, uint len)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}