﻿using Newtonsoft.Json;

namespace Blockcore.Controllers.Models
{
    /// <summary>
    /// 
    /// https://bitcoincore.org/en/doc/0.17.0/rpc/util/validateaddress/
    /// 
    /// validateaddress "address"
    /// 
    /// Return information about the given bitcoin address.
    /// 
    /// DEPRECATION WARNING: Parts of this command have been deprecated and moved to getaddressinfo. Clients must
    /// transition to using getaddressinfo to access this information before upgrading to v0.18. The following deprecated
    /// fields have moved to getaddressinfo and will only be shown here with -deprecatedrpc= validateaddress: ismine, iswatchonly,
    /// script, hex, pubkeys, sigsrequired, pubkey, addresses, embedded, iscompressed, account, timestamp, hdkeypath, kdmasterkeyid.
    /// 
    /// Arguments:
    /// 1. "address"                    (string, required) The bitcoin address to validate
    /// 
    /// 
    /// Result:
    /// {
    ///     "isvalid" : true|false,     (boolean) If the address is valid or not.If not, this is the only property returned.
    ///     "address" : "address",      (string) The bitcoin address validated
    ///     "scriptPubKey" : "hex",     (string) The hex encoded scriptPubKey generated by the address
    ///     "isscript" : true|false,    (boolean) If the key is a script
    ///     "iswitness" : true|false,   (boolean) If the address is a witness address
    ///     "witness_version" : version (numeric, optional) The version number of the witness program
    ///     "witness_program" : "hex"   (string, optional) The hex value of the witness program
    /// }
    /// </summary>
    public class ValidatedAddress
    {
        [JsonProperty(PropertyName = "isvalid")]
        public bool IsValid { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "scriptPubKey")]
        public string ScriptPubKey { get; set; }

        [JsonProperty(PropertyName = "isscript")]
        public bool IsScript { get; set; }

        [JsonProperty(PropertyName = "iswitness")]
        public bool IsWitness { get; set; }
    }
}
