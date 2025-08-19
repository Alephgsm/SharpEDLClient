using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SharpEDLClient.Class.EDLProtocol
{
    public struct RawItem
    {
        public string label;
        public string filename;
        public string filepath;
        public string start_sector;
        public string num_partition_sectors;
        public string size_in_KB;
        public string physical_partition_number;
        public string SECTOR_SIZE_IN_BYTES;
        public string file_sector_offset;
        public string sector_size_in_bytes;
        public bool sparse;
    }

    public class RawProgram
    {
        public static string[] patch = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
    }

    public class storage_info
    {
        [JsonProperty("total_blocks")]
        public int total_blocks;
        [JsonProperty("block_size")]
        public int block_size;
        [JsonProperty("page_size")]
        public int page_size;
        [JsonProperty("num_physical")]
        public int num_physical;
        [JsonProperty("manufacturer_id")]
        public int manufacturer_id;
        [JsonProperty("serial_num")]
        public long serial_num;
        [JsonProperty("fw_version")]
        public string fw_version;
        [JsonProperty("mem_type")]
        public string mem_type;
        [JsonProperty("prod_name")]
        public string prod_name;
    }

    public class StorageInfo
    {
        public static string storageInfo = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
    }
}