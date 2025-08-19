using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol
{
    public class Firehose_pkts
    {
        public struct FIREHOSE_CONFIG
        {
            public int Version;
            public string MemoryName;
            public int SkipWrite;
            public int SkipStorageInit;
            public int ZLPAwareHost;
            public int ActivePartition;
            public int MaxPayloadSizeToTargetInBytes;
            public int AckRawDataEveryNumPackets;
            public int maxPayloadSizeFromTargetInBytes;
        }

        public string xml;
        public static string pkt_fhConfig(string MemName)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_setAckRaw(int val)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_peekMem(uint address64, int size)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_eMMCinfo(string drive)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_ProgramUFS(int nPartSectors, string fileName, int startSector, int lun)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string BootConf()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_readSecBoot()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_readSerialNumber()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_readIMEI()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_sendNop()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_sendReset()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_read(int sectorSize, int numPartitionSectors, int physicalPartNum, string startSector)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_Program(string sectorsize, string NumPartitionSector, string PhysicalPartition, string StartSector)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_patch(string SectorSize, string BytesOffset, string FileName, string PhysicalPartition, string SizeInBytes, string StartSector, string Value, string What)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static string pkt_erase(string sectorSize, string numPartitionSectors, string physicalPartNum, string startSector)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }
}