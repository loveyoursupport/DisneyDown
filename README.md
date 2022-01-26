# DisneyDown
### Builds
Download builds from the [Azure DevOps Pipeline](https://dev.azure.com/brhmedia/DisneyDown/_build) or build using Visual Studio and .NET 4.7.2+.

### About
Downloads Disney+ content using a Widevine Hex-formatted key (32-character AES content key).

You need to obtain this key using either using the Chrome WidevineDecryptor plugin or another method. We cannot provide keys; don't bother asking.

### Usage
`DisneyDown.Console.exe -?` for help on specific arguments and available flags.

You may configure your Disney+ credentials inside of the `api` folder. Doing so will enable automatic discovery of playlist URLs, meaning you can enter a normal Disney+ URL instead of a master playlist URL.

### Platform Information
This is a Windows-only application and there are no plans to port it to other platforms, please do not file issue reports asking for this. If you have completed a platform port,
you are more than welcome to file a pull request and it will be merged into its own branch with due credit.

### Compatibility Notes
Segment filtering is an important component of DisneyDown. Since the system previously did not have API capabilities, it did not have access to available quality data.
As such, DisneyDown manually filters out and selects the highest quality available in a master playlist - this is done with segment filtering definitions and bandwidth definitions.
You may modify both of these by changing their respective JSON files.

If you find that a particular item is not being filtered correctly, you may need to enable the fallback filter which will automatically
include everything inside of a playlist file (this is not recommended for normal usage as it will combine all available streams and could cause distortion).

Playback issues associated with the fallback filter
are mostly resolved when remuxing occurs via FFMPEG.

### Why was this made public?
This project was developed as part of ongoing research interests and as it stands, it does not serve much purpose sitting around in a private repository.

Since the application does not provide decryption keys,
there is no risk of a DMCA notice and/or revocation of the practises employed.
