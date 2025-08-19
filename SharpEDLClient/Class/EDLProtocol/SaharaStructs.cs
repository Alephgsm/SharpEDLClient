using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class.EDLProtocol
{
    public class FIREHOSE_SAHARA
    {
        public struct SAHARA_REQUESTS_HELLO
        {
            public SAHARA_HEADER header;
            public int version;
            public int minVersion;
            public int maxCommandPacketSize;
            public SAHARA_MODE mode;
            public int res1;
            public int res2;
            public int res3;
            public int res4;
            public int res5;
            public int res6;
        }

        public struct SAHARA_HEADER
        {
            public SAHARA_CMD command;
            public int size;
        }

        public struct SAHARA_HEADER64
        {
            public SAHARA_CMD command;
            public int size;
        }

        public struct SAHARA_PBL_INFO
        {
            public string serial;
            public string msm_id;
            public string devid;
            public string pk_hash;
            public int pbl_sw;
        }

        public enum SAHARA_MODE
        {
            SAHARA_MODE_IMAGE_PENDING,
            SAHARA_MODE_IMAGE_TX_COMPLETE,
            SAHARA_MODE_MEMDEBUG,
            SAHARA_MODE_COMMAND
        }

        public enum SAHARA_EXEC_CMD
        {
            SAHARA_EXEC_CMD_NOP = 0,
            SAHARA_EXEC_CMD_SERIAL_NUM_READ = 1,
            SAHARA_EXEC_CMD_MSM_HW_ID_READ = 2,
            SAHARA_EXEC_CMD_OEM_PK_HASH_READ = 3,
            SAHARA_EXEC_CMD_SWITCH_TO_DMSS_DLOAD = 4,
            SAHARA_EXEC_CMD_SWITCH_TO_STREAM_DLOAD = 5,
            SAHARA_EXEC_CMD_READ_DEBUG_DATA = 6,
            SAHARA_EXEC_CMD_GET_SOFTWARE_VERSION_SBL = 7,
            SAHARA_EXEC_CMD_LAST = 8,
            SAHARA_EXEC_CMD_MAX = int.MaxValue
        }

        public struct SAHARA_SWITCH_PACKET
        {
            public SAHARA_HEADER header;
            public SAHARA_MODE mode;
        }

        public struct SAHARA_REQUESTS_IMGDONE_PACKET
        {
            public SAHARA_HEADER header;
        }

        public struct StorageInfo
        {
            [JsonProperty("total_blocks")]
            public long total_blocks { get; set; }

            [JsonProperty("block_size")]
            public long block_size { get; set; }

            [JsonProperty("page_size")]
            public int page_size { get; set; }

            [JsonProperty("num_physical")]
            public int num_physical { get; set; }

            [JsonProperty("manufacturer_id")]
            public int manufacturer_id { get; set; }

            [JsonProperty("serial_num")]
            public long serial_num { get; set; }

            [JsonProperty("fw_version")]
            public string fw_version { get; set; }

            [JsonProperty("mem_type")]
            public string mem_type { get; set; }

            [JsonProperty("prod_name")]
            public string prod_name { get; set; }
        }

        public struct Root
        {
            [JsonProperty("storage_info")]
            public StorageInfo storage_info { get; set; }
        }

        public struct SAHARA_RESPONSE_IMGDONE_PACKET
        {
            public SAHARA_HEADER header;
            public SAHARA_STATUS status;
        }

        public struct SAHARA_RESPONSE_IMGDONE_PACKET64
        {
            public SAHARA_HEADER64 header;
            public SAHARA_STATUS status;
        }

        public enum SAHARA_CMD
        {
            SAHARA_CMD_HELLO_REQ = 1,
            SAHARA_CMD_HELLO_RESP = 2,
            SAHARA_CMD_READ_DATA = 3,
            SAHARA_CMD_IMG_END_TRSFR = 4,
            SAHARA_CMD_IMG_DONE_REQ = 5,
            SAHARA_CMD_IMG_DONE_RESP = 6,
            SAHARA_RESET_REQ = 7,
            SAHARA_RESET_RSP = 8,
            SAHARA_MEMORY_DEBUG = 9,
            SAHARA_CMD_EXECUTE_REQ = 13,
            SAHARA_CMD_EXECUTE_RESPONSE = 14,
            SAHARA_CMD_EXECUTE_DATA = 15,
            SAHARA_MEMORY_READ = 10,
            SAHARA_CMD_READY = 11,
            SAHARA_CMD_SWITCH_MODE = 12,
            SAHARA_EXECUTE_REQ = 13,
            SAHARA_EXECUTE_RSP = 14,
            SAHARA_EXECUTE_DATA = 15,
            SAHARA_64BIT_MEMORY_DEBUG = 16,
            SAHARA_64BIT_MEMORY_READ = 17,
            SAHARA_64BIT_MEMORY_READ_DATA = 18
        }

        public enum SAHARA_IMAGE_ID
        {
            kMbnImageNone = 0,
            kMbnImageOemSbl = 1,
            kMbnImageAmss = 2,
            kMbnImageOcbl = 3,
            kMbnImageHash = 4,
            kMbnImageAppbl = 5,
            kMbnImageApps = 6,
            kMbnImageHostDl = 7,
            kMbnImageDsp1 = 8,
            kMbnImageFsbl = 9,
            kMbnImageDbl = 10,
            kMbnImageOsbl = 11,
            kMbnImageDsp2 = 12,
            kMbnImageEhostdl = 13,
            SAHARA_IMAGE_FIREHOSE = 14,
            kMbnImageNorprg = 15,
            kMbnImageRamfs1 = 16,
            kMbnImageRamfs2 = 17,
            kMbnImageAdspQ5 = 18,
            kMbnImageAppsKernel = 19,
            kMbnImageBackupRamfs = 20,
            kMbnImageSbl1 = 21,
            kMbnImageSbl2 = 22,
            kMbnImageRpm = 23,
            kMbnImageSbl3 = 24,
            kMbnImageTz = 25,
            kMbnImageSsdKeys = 26,
            kMbnImageGen = 27,
            kMbnImageDsp3 = 28,
            kMbnImageAcdb = 29,
            kMbnImageWdt = 30,
            kMbnImageMba = 31,
            kMbnImageLast = 31
        }

        public struct SAHARA_REQUESTS_READDATA
        {
            public SAHARA_HEADER header;
            public SAHARA_IMAGE_ID imageID;
            public int offset;
            public int size;
        }

        public struct SAHARA_REQUESTS_READDATA_64
        {
            public SAHARA_HEADER header;
            public SAHARA_IMAGE_ID imageID;
            public long offset;
            public long size;
        }

        public struct SAHARA_REQUESTS_IMG_DONE
        {
            public SAHARA_HEADER header;
        }

        public struct SAHARA_REQUESTS_IMG_DONE64
        {
            public SAHARA_HEADER64 header;
        }

        [Serializable]
        public struct SAHARA_RESPONSE_HELLO
        {
            public SAHARA_HEADER header;
            public int version;
            public int minVersion;
            public int status;
            public SAHARA_MODE mode;
            public int res1;
            public int res2;
            public int res3;
            public int res4;
            public int res5;
            public int res6;
        }

        public struct SAHARA_RESPONSE_EXECCMD_RESPONSE
        {
            public SAHARA_HEADER header;
            public SAHARA_EXEC_CMD cmd;
            public int size;
        }

        public struct SAHARA_REQUEST_EXE_CMD
        {
            public SAHARA_HEADER header;
            public SAHARA_EXEC_CMD clientCmd;
        }

        public enum SAHARA_STATUS64
        {
            SAHARA_STATUS_SUCCESS = 1,
            SAHARA_NAK_INVALID_CMD = 0,
            SAHARA_NAK_PROTOCOL_MISMATCH = 2,
            SAHARA_NAK_INVALID_TARGET_PROTOCOL = 3,
            SAHARA_NAK_INVALID_HOST_PROTOCOL = 4,
            SAHARA_NAK_INVALID_PACKET_SIZE = 5,
            SAHARA_NAK_UNEXPECTED_IMAGE_ID = 6,
            SAHARA_NAK_INVALID_HEADER_SIZE = 7,
            SAHARA_NAK_INVALID_DATA_SIZE = 8,
            SAHARA_NAK_INVALID_IMAGE_TYPE = 9,
            SAHARA_NAK_INVALID_TX_LENGTH = 10,
            SAHARA_NAK_INVALID_RX_LENGTH = 11,
            SAHARA_NAK_GENERAL_TX_RX_ERROR = 12,
            SAHARA_NAK_READ_DATA_ERROR = 13,
            SAHARA_NAK_UNSUPPORTED_NUM_PHDRS = 14,
            SAHARA_NAK_INVALID_PDHR_SIZE = 15,
            SAHARA_NAK_MULTIPLE_SHARED_SEG = 16,
            SAHARA_NAK_UNINIT_PHDR_LOC = 17,
            SAHARA_NAK_INVALID_DEST_ADDR = 18,
            SAHARA_NAK_INVALID_IMG_HDR_DATA_SIZE = 19,
            SAHARA_NAK_INVALID_ELF_HDR = 20,
            SAHARA_NAK_UNKNOWN_HOST_ERROR = 21,
            SAHARA_NAK_TIMEOUT_RX = 22,
            SAHARA_NAK_TIMEOUT_TX = 23,
            SAHARA_NAK_INVALID_HOST_MODE = 24,
            SAHARA_NAK_INVALID_MEMORY_READ = 25,
            SAHARA_NAK_INVALID_DATA_SIZE_REQUEST = 26,
            SAHARA_NAK_MEMORY_DEBUG_NOT_SUPPORTED = 27,
            SAHARA_NAK_INVALID_MODE_SWITCH = 28,
            SAHARA_NAK_CMD_EXEC_FAILURE = 29,
            SAHARA_NAK_EXEC_CMD_INVALID_PARAM = 30,
            SAHARA_NAK_EXEC_CMD_UNSUPPORTED = 31,
            SAHARA_NAK_EXEC_DATA_INVALID_CLIENT_CMD = 32,
            SAHARA_NAK_HASH_TABLE_AUTH_FAILURE = 33,
            SAHARA_NAK_HASH_VERIFICATION_FAILURE = 34,
            SAHARA_NAK_HASH_TABLE_NOT_FOUND = 35,
            SAHARA_NAK_LAST_CODE = 36,
            SAHARA_NAK_MAX_CODE = int.MaxValue
        }

        public enum SAHARA_STATUS
        {
            SAHARA_STATUS_32 = 0,
            SAHARA_STATUS_64 = 1,
            SAHARA_NAK_PROTOCOL_MISMATCH = 2,
            SAHARA_NAK_INVALID_TARGET_PROTOCOL = 3,
            SAHARA_NAK_INVALID_HOST_PROTOCOL = 4,
            SAHARA_NAK_INVALID_PACKET_SIZE = 5,
            SAHARA_NAK_UNEXPECTED_IMAGE_ID = 6,
            SAHARA_NAK_INVALID_HEADER_SIZE = 7,
            SAHARA_NAK_INVALID_DATA_SIZE = 8,
            SAHARA_NAK_INVALID_IMAGE_TYPE = 9,
            SAHARA_NAK_INVALID_TX_LENGTH = 10,
            SAHARA_NAK_INVALID_RX_LENGTH = 11,
            SAHARA_NAK_GENERAL_TX_RX_ERROR = 12,
            SAHARA_NAK_READ_DATA_ERROR = 13,
            SAHARA_NAK_UNSUPPORTED_NUM_PHDRS = 14,
            SAHARA_NAK_INVALID_PDHR_SIZE = 15,
            SAHARA_NAK_MULTIPLE_SHARED_SEG = 16,
            SAHARA_NAK_UNINIT_PHDR_LOC = 17,
            SAHARA_NAK_INVALID_DEST_ADDR = 18,
            SAHARA_NAK_INVALID_IMG_HDR_DATA_SIZE = 19,
            SAHARA_NAK_INVALID_ELF_HDR = 20,
            SAHARA_NAK_UNKNOWN_HOST_ERROR = 21,
            SAHARA_NAK_TIMEOUT_RX = 22,
            SAHARA_NAK_TIMEOUT_TX = 23,
            SAHARA_NAK_INVALID_HOST_MODE = 24,
            SAHARA_NAK_INVALID_MEMORY_READ = 25,
            SAHARA_NAK_INVALID_DATA_SIZE_REQUEST = 26,
            SAHARA_NAK_MEMORY_DEBUG_NOT_SUPPORTED = 27,
            SAHARA_NAK_INVALID_MODE_SWITCH = 28,
            SAHARA_NAK_CMD_EXEC_FAILURE = 29,
            SAHARA_NAK_EXEC_CMD_INVALID_PARAM = 30,
            SAHARA_NAK_EXEC_CMD_UNSUPPORTED = 31,
            SAHARA_NAK_EXEC_DATA_INVALID_CLIENT_CMD = 32,
            SAHARA_NAK_HASH_TABLE_AUTH_FAILURE = 33,
            SAHARA_NAK_HASH_VERIFICATION_FAILURE = 34,
            SAHARA_NAK_HASH_TABLE_NOT_FOUND = 35,
            SAHARA_NAK_LAST_CODE = 36,
            SAHARA_NAK_MAX_CODE = int.MaxValue
        }

        public static object RawDeserialize(byte[] rawData, int position, Type anyType)
        {
            throw new NotImplementedException("To get full source code, contact us at https://alephgsm.com/contact-us/");
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sahara_switch_Mode_packet
    {
        public uint Command;
        public uint Length;
        public uint Mode;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sahara_packet
    {
        public uint Command;
        public uint Length;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sahara_hello_packet
    {
        public uint Command;
        public uint Length;
        public uint Version;
        public uint Version_min;
        public uint Max_Command_Length;
        public uint Mode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] Reserved;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sahara_hello_response
    {
        public uint Command;
        public uint Length;
        public uint Version;
        public uint Version_min;
        public uint Status;
        public uint Mode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] Reserved;
    }

    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct Programmer
    {
        public static int firehose = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sahara_readdata_packet
    {
        public uint Command;
        public uint Length;
        public uint Image_id;
        public uint Offset;
        public uint SLength;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sahara_64b_readdata_packet
    {
        public uint Command;
        public uint Length;
        public ulong Image_id;
        public ulong Offset;
        public ulong SLength;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sahara_end_transfer_packet
    {
        public uint Command;
        public uint Length;
        public uint Image_id;
        public uint Status;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sahara_done_response
    {
        public uint Command;
        public uint Length;
        public uint Status;
    }
}