using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpEDLClient.Class
{
    public enum RichFont
    {
        Bold,
        Regulator,
        Delete
    }

    public enum RichColor
    {
        Yellow,
        Lime,
        Cyan,
        Red
    }

    public class Configuration
    {
        public List<IOperation> Operations = new List<IOperation>();
        public static Configuration CFG = default /* To get full source code, contact us at https://alephgsm.com/contact-us/ */;
    }

    public struct IOperation
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public DateTime StartedAt, EndedAt;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public List<IRichItem> Items;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string OperationName, Tab;
    }

    public struct IRichItem
    {
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public string text;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public Resut color;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public bool newline;
        [ObfuscationAttribute(Exclude = true, Feature = "renaming")]
        public bool bold;
    }

    public delegate void InvokeString(string text);
    public delegate void IsRunningProcessDelegate(bool IsRunning, string process);
    public delegate void LogDelegate(string text, Resut color = Resut.Word, bool newline = true, bool bold = false);
    public delegate void InvokeCmd();
    public delegate void ProgressEventHandler(ulong Value, ulong Max);
}