using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol.GPT
{
    public class EMMCGPTParser
    {
        public readonly Version Version;
        public readonly uint header_size;
        public readonly ulong current_lba;
        public readonly ulong backup_lba;
        public readonly ulong first_usable_lba;
        public readonly ulong last_usable_lba;
        public readonly Guid disk_guid;
        public readonly ulong part_entry_start_lba;
        public readonly uint num_part_entries;
        public readonly uint part_entry_size;
        public readonly GuidPartitionTableEntry[] Partitions;
        public EMMCGPTParser(string username)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal static byte[] GetFromIndex(byte[] byte_0, uint A7299E19, uint uint_0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal static byte[] GPTFileParse(FileStream fileStream_0, ulong ulong_4, ulong ulong_5)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal EMMCGPTParser(byte[] data)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] ParseFromFile(string username)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static EMMCGPTParser GPTFromFile(string username)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public GuidPartitionTableEntry[] GetPartitionTable()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}