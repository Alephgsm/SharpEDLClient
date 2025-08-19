using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol.GPT
{
    public class GuidPartitionTableEntry
    {
        [Flags]
        public enum PARTITION_ATTRIBUTE
        {
            RequirePartition = 1,
            NoBlockIOProtocol = 2,
            LegacyBIOSBootable = 4
        }

        public readonly Guid PartitionTypeGUID;
        public readonly Guid UniquePartitionGUID;
        public readonly ulong StartingLBA;
        public readonly ulong EndingLBA;
        public readonly PARTITION_ATTRIBUTE Attributes;
        public readonly string PartitionName;
        internal GuidPartitionTableEntry(byte[] bytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        internal static byte[] GetSubArray(byte[] InputBytes, uint offset, uint length)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}