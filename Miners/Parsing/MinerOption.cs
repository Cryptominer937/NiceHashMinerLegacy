﻿using NiceHashMiner.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using WebSocketSharp;

namespace NiceHashMiner.Miners.Parsing {
    public class MinerOption {
        [JsonConstructor]
        public MinerOption(string iType, string iShortName, string iLongName, string iDefault, MinerOptionFlagType iFlagType, string iSeparator = "") {
            this.Type = iType;
            this.ShortName = iShortName;
            this.LongName = iLongName;
            this.Default = iDefault;
            this.FlagType = iFlagType;
            this.Separator = iSeparator;
        }

        // Constructor if no short name
        public MinerOption(string iType, string iLongName, string iDefault, MinerOptionFlagType iFlagType,
            string iSeparator = "")
            : this(iType, iLongName, iLongName, iDefault, iFlagType, iSeparator) { }

        public string Type;
        public string ShortName;
        public string LongName;
        public string Default;
        public MinerOptionFlagType FlagType;
        public string Separator;
    }
}
