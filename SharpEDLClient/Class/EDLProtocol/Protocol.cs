using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharpEDLClient.Class.EDLProtocol.GPT;
using SharpEDLClient.Class.usb;
using SharpEDLClient.Controls;
using SharpEDLClient.Forms;
using SharpEDLClient.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static SharpEDLClient.Class.EDLProtocol.FIREHOSE_SAHARA;

namespace SharpEDLClient.Class.EDLProtocol
{
    public class Protocol : IDisposable
    {
        public usb Port;
        public USBApi api;
        public event LogDelegate Log;
        public event ProgressEventHandler Progress;
        public int SECTOR_SIZE_UFS = 4096;
        public int SECTOR_SIZE_EMMC = 512;
        public bool cpu64 = false;
        private SAHARA_PBL_INFO _pblInfo;
        public string msm_cpu;
        public bool sendingloaderStatus;
        private SAHARA_MODE mode { get; set; }

        public string TypeMemory = "emmc";
        public Protocol()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void Port_Log(string text, Resut color = Resut.Word, bool newline = true, bool bold = false)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool IsConnected
        {
            get
            {
                return api.IsOpen;
            }
        }

        public bool ErasePartition(string sectorSizeInBytes, string sectors, string lun, string sector)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ErasePartition64(string sectorSizeInBytes, string sectors, string lun, string sector)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

      
        public bool ReadPartOld(string start_sector, string num_partition_sectors, string LUN, string SECTOR_SIZE_IN_BYTES, string filePath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ReadPart(string start_sector, string num_partition_sectors, string LUN, string SECTOR_SIZE_IN_BYTES, string filePath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void GenerateRawxml(List<RawPartition> partitions, string Path)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private static string makeprogram(string SECTOR_SIZE_IN_BYTES, string label, string physical_partition_number, string num_partition_sectors, string start_sector)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ApplyPatchesToDevice(string patchFilePath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void ApplyPatch(string pszDiskOffsetSector, string pszSectorOffsetByte, string pszPatchValue, string pszPatchSize, string pszSectorSizeInBytes, string pszPhysicalPartitionNumber)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void RebootDevice()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteFlash(RawItem info)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool InitDevice(ItypePort port)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void FileTransfer_Progress(ulong Value, ulong Max)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void SendHelloResponse(SAHARA_REQUESTS_HELLO pkt, SAHARA_MODE mode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void sendFlashLoader(SAHARA_REQUESTS_READDATA initReq)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void sendFlashLoader64(SAHARA_REQUESTS_READDATA_64 initReq)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private bool switchMode(SAHARA_MODE mode)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void dumpDeviceInfo()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void ReadData(SAHARA_EXEC_CMD cmd)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private bool validateResponse(SAHARA_CMD expectedCMD, byte[] response)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public static byte[] SerializeMessage<T>(T msg)
            where T : struct
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool IsFirehose()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string readimei()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SaharaDownloadProgrammer(string ProgrammerPath)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SaharaDownloadProgrammer2()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string StoID(string id)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<string> getlog(byte[] input)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public void cmd_getstorageinfo()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool FreeSign()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private void ReadStorageInfo()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private bool PrintStorageInfo()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool SetBootPartition()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool ConfigPort()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string CheckIDEMMC(string MFR_ID)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public string BlobKey;
        private bool GetBlobKeyFromDevice()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private string BlobSign = "";
        private string AnalysisBlobKey(string A7074C82)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<XmlDocument> GetREsponseXML(bool E0192C01, string resp)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private string[] StringParse(byte[] FA2C7F35, bool bool_0)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public ItypePort port;
        public bool Configure(ItypePort port)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#region IDisposable implementation with finalizer
        private bool isDisposed = false;
        public void Dispose()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        protected virtual void Dispose(bool disposing)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

#endregion
#region "Read Partition"
        private SPARSE_HEADER sparseheader;
        private uint totalchunk = 0;
        private CHUNK_HEADER chunkheader;
        //public bool CheckSparse(byte[] DataFiles)
        //{
        //    if (DataFiles.Length == 0)
        //    {
        //        return false;
        //    }
        //    Stream stream = new MemoryStream(DataFiles);
        //    byte[] array = new byte[1024];
        //    using (BinaryReader binaryReader = new BinaryReader(stream))
        //    {
        //        binaryReader.Read(array, 0, 28);
        //        sparseheader = ParsingHeader(array);
        //        var dwMagic = sparseheader.dwMagic;
        //        long num = long.Parse("E" + dwMagic.ToString("X"), NumberStyles.HexNumber);
        //        if (num == 64108298042L)
        //        {
        //            totalchunk = sparseheader.dwTotalChunks;
        //            stream.Close();
        //            binaryReader.Close();
        //            return true;
        //        }
        //        stream.Close();
        //        binaryReader.Close();
        //        return false;
        //    }
        //}
        private SPARSE_HEADER ParsingHeader(byte[] bytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public struct SPARSE_HEADER
        {
            public uint dwMagic;
            public ushort wVerMajor;
            public ushort wVerMinor;
            public ushort wSparseHeaderSize;
            public ushort wChunkHeaderSize;
            public uint dwBlockSize;
            public uint dwTotalBlocks;
            public uint dwTotalChunks;
            public uint dwImageChecksum;
        }

        public struct CHUNK_HEADER
        {
            public short wChunkType;
            public short wReserved;
            public int dwChunkSize;
            public int dwTotalSize;
        }

        private CHUNK_HEADER ReadChunkHeader(Stream stream, long offset)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public enum ChunkType : ushort
        {
            Raw = 0xCAC1, // Represents a raw chunk
            Fill = 0xCAC2, // Represents a fill chunk
            DontCare = 0xCAC3 // Represents a don't care chunk
        }

        public bool CheckSparse(byte[] DataFiles)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public bool WriteEmmc(string SectSize, string NumSect, string Physical, string StartSect, string Filename)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private long RoundUp(double value)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public long bulat(double number)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public byte[] ReadGPT(int Lun)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        private List<RawPartition> PartitionTableLists = new List<RawPartition>();
        private bool ParseGPT(byte[] comBuffer, int lun)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<RawPartition> ReadPartitionTables()
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }

        public List<int> FindOffsets(byte[] sourceBytes, byte[] searchBytes)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
#endregion
    }
}