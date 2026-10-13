# mp3HD Converter

A Windows desktop frontend for converting WAV audio to mp3HD and decoding
mp3HD files back to WAV, using Thomson's command-line encoder and decoder.

Written by Jeff Fenster under the Fen-Soft name while in high school in 2009,
the tool was previously distributed through Thomson's all4mp3 website. The
[mp3HD Wikipedia article](https://en.wikipedia.org/wiki/Mp3HD#Encoding) mentions
mp3HD Converter and its WAV-to-mp3HD and mp3HD-to-WAV workflow.

This repository preserves the original project before work to get it building
and running on current Windows machines.

The preserved source identifies itself as **version 1.1.0**, released January
27, 2010. The original assembly and ClickOnce version numbers were left at
older values and are preserved as found.

## Run the portable Windows release

1. **Install .NET Framework 3.5.** On Windows 10 or Windows 11 25H2 and
   earlier, search the Start menu for **Turn Windows features on or off**,
   select **.NET Framework 3.5 (includes .NET 2.0 and 3.0)**, and complete the
   installation. Restart if prompted. See Microsoft's
   [installation instructions](https://learn.microsoft.com/en-us/dotnet/framework/install/dotnet-35-windows).
   On Windows 11 26H1 and later, use the standalone installer linked in
   [Microsoft's Windows 11 guide](https://learn.microsoft.com/en-us/dotnet/framework/install/dotnet-35-windows-11).

2. **Get the application ZIP.** Open the
   [GitHub Releases page](https://github.com/defiant91/mp3HDConverter/releases)
   and download the portable application ZIP attached to a release, when
   available. The automatically generated **Source code** downloads contain
   the project files and must be built before use.

3. **Extract the application ZIP completely.** Use a folder you can write to,
   such as a folder in Documents or Downloads. Open the extracted folder and
   check that it contains `MP3HD Converter.exe`,
   `MP3HD Converter.exe.config`, and `Change Log.txt`. Run the extracted files
   rather than opening the executable from inside the ZIP.

4. **Download the codec toolkit separately.** Download
   [mp3hdtl.zip](https://www.rarewares.org/rrw/files/fhg/mp3hdtl.zip), or use its
   [Internet Archive backup](https://web.archive.org/web/20260311043126id_/https://www.rarewares.org/rrw/files/fhg/mp3hdtl.zip).
   Extract that ZIP, then extract the nested
   `mp3HD_Toolkit_for_Windows_2010-02-02.zip`. Read the toolkit's `license.txt`
   for its evaluation-use terms. These third-party tools are supplied
   separately from the application release.

5. **Add the toolkit files to the application folder.** Copy
   `mp3hdEncoder.exe`, `mp3hdDecoder.exe`, and the toolkit's `license.txt`
   directly alongside `MP3HD Converter.exe`. Keep this toolkit license
   separate from the application's MIT `LICENSE` file. For the optional
   Winamp plugin installation feature, also copy `in_mp3hd.dll` into this
   folder; it is not required for file conversion.

6. **Launch `MP3HD Converter.exe`.** The About tab should show **Version:
   1.1.0**. Keep all the application and required toolkit files together when
   moving the folder. The application writes temporary files and logs, so its
   folder must remain writable.

After adding the separately downloaded toolkit, the folder should look like:

```text
MP3HDConverter-1.1.0/
  MP3HD Converter.exe
  MP3HD Converter.exe.config
  Change Log.txt
  LICENSE
  README.md
  mp3hdEncoder.exe
  mp3hdDecoder.exe
  license.txt
```

The encoder, decoder, and toolkit `license.txt` in this example are added by
the user after download; they are not included in the application release ZIP.

### Convert audio

For a first test, use a copy of a short WAV file and leave **Delete Original
File(s)** unchecked.

1. Open the **Encoder** tab and use the input **Browse** button to select the
   WAV file, or drag it into the input list.
2. Choose an output folder using the output **Browse** button.
3. Select a bitrate, such as **320**, and an encoding mode, such as
   **0 - CBR**. These settings control the conventional MP3 stream stored
   inside the mp3HD file.
4. Click **Encode!** and check the output folder for the resulting `.mp3` file.
5. To decode it back to WAV, open the **Decoder** tab, add the resulting
   `.mp3` file, choose a different output folder, and click **Decode!**.
   Leave **Delete Original File(s)** unchecked while testing.

### Troubleshooting startup

| Symptom | What to check |
| --- | --- |
| Windows asks for .NET Framework | Complete the .NET Framework 3.5 installation in step 1. |
| The application says administrator rights are required | First check that `Change Log.txt` is next to the executable and that `.txt` files open in a text editor. The old startup code reports this message when opening the changelog fails; it does not reliably identify a permissions problem. |
| An error mentions `mp3hdencoder.exe`, `mp3hddecoder.exe`, or `license.txt` | Complete steps 4 and 5. The required files must be in the same folder as the application, rather than inside a nested toolkit folder. |
| The About tab shows an older version | Check that you launched the newly extracted release executable rather than an older copy or shortcut. |
| The contact form cannot send a message | The original embedded email credentials were removed before publication. Use GitHub Issues to report problems. |

## What was mp3HD?

mp3HD was a lossless audio format developed by Thomson, later known as
Technicolor. A single `.mp3` file combined a conventional lossy MP3 stream with
additional data for lossless playback. Ordinary MP3 players could play the
lossy stream; compatible mp3HD software could recover the lossless audio.

The converter provided a graphical interface to the separate codec tools. It
did not implement the mp3HD codec itself, and it could not restore audio
information already lost in an ordinary MP3 file.

## Original features

- Convert multiple WAV files to mp3HD, or decode mp3HD files back to WAV.
- Select MP3 bitrate and constant or variable bitrate encoding modes.
- Choose output locations and add files through drag and drop.
- Enter track metadata and optionally name output files using artist and title.
- Remember settings between sessions.
- Copy an existing mp3HD decoder plugin into a Winamp installation.

## Repository status

The initial source import retains the original solution, project files,
Visual Basic code, form designers, resources, and icons. The only source edits
are emptying the hard-coded SMTP username, password, and contact-form recipient
addresses before publication. The old contact form is therefore nonfunctional.

The initial commit includes documentation and the MIT license. Build outputs,
Visual Studio user settings, logs, installers, and third-party binaries are
excluded. Existing local copies are left in place.

The original application logic has not been modernized. Local Debug and
Release builds have been built and launched in current Visual Studio on
Windows. Audio conversion and compatibility across other Windows machines
have not yet been verified.

## Historical build and runtime requirements

The original project uses:

- Visual Basic .NET and Windows Forms.
- Visual Studio 2008 / MSBuild 3.5 project files.
- .NET Framework 3.5.
- A Windows Shell32 COM reference.

The original solution is [`MP3HD Converter.sln`](https://github.com/defiant91/mp3HDConverter/blob/main/MP3HD%20Converter.sln). These
are the historical requirements, not a verified build recipe for current
Visual Studio or Windows versions.

## Download the required codec tools

**You must download `mp3hdEncoder.exe` and `mp3hdDecoder.exe` separately to use
the conversion features.** The codec tools and Winamp plugin are not bundled
with this repository.

A preserved mp3HD Toolkit 1.5.0, dated February 2, 2010, is available from:

- [ReallyRareWares toolkit page](https://www.rarewares.org/rrw/fhgmp3hd.php), with information about the preserved release.
- [Direct toolkit ZIP download](https://www.rarewares.org/rrw/files/fhg/mp3hdtl.zip).
- [Internet Archive backup of the same ZIP](https://web.archive.org/web/20260311043126id_/https://www.rarewares.org/rrw/files/fhg/mp3hdtl.zip), captured March 11, 2026.

To obtain the Windows tools:

1. Download and extract `mp3hdtl.zip`.
2. Extract the nested `mp3HD_Toolkit_for_Windows_2010-02-02.zip` archive.
3. Place `mp3hdEncoder.exe`, `mp3hdDecoder.exe`, and the toolkit's `license.txt`
   alongside `MP3HD Converter.exe` in the application's output directory.
4. For the optional Winamp plugin installation feature, also place
   `in_mp3hd.dll` in that directory.

The original interface additionally expects `Change Log.txt` alongside its
executable; a preserved copy is available in this repository's `docs/` folder.

Both download links were checked on October 12, 2026. The ZIPs were identical,
and the nested Windows archive contained the encoder, decoder, plugin, and
license. The outer ZIP's SHA-256 checksum is:

```text
8b154a643c08264209b2e48f03bbacd309a98bfd400e16a9f9ec46c0694ec923
```

The toolkit's bundled `license.txt` describes non-commercial evaluation use
and restricts redistribution. Review those terms before use. This repository's
MIT license covers the original application source and does not replace the
toolkit license. Keep the downloaded binaries outside Git; the repository's
ignore rules exclude EXE and DLL files and the toolkit ZIP archives.

These are preserved legacy tools. Their compatibility with this project on
current Windows has not yet been tested.

## Project layout

| Path | Contents |
| --- | --- |
| `MP3HD Converter.sln` | Original Visual Studio solution |
| `MP3HD Converter/` | Application source, project files, and form resources |
| `MP3HD Converter/My Project/` | Application settings, assembly metadata, and manifest |
| `MP3HD Converter/Resources/` | Original images and icons |
| `docs/Change Log.txt` | Release changelog with recovered entries through version 1.1.0 |

## History and references

The [release changelog](https://github.com/defiant91/mp3HDConverter/blob/main/docs/Change%20Log.txt) records development from July
2009 through version 1.1.0 on January 27, 2010. Entries for versions 1.0.0.0
through 1.1.0 were restored from the author's recovered changelog; the earlier
entries are retained from the original local copy.

- [mp3HD on Wikipedia](https://en.wikipedia.org/wiki/Mp3HD), including the converter mention in the Encoding section.
- [Archived all4mp3 website](https://web.archive.org/web/*/http://www.all4mp3.com/), the former distribution site.

## License

The original application source is released under the [MIT license](LICENSE).
Third-party codec tools and plugins are separate software and are not covered
by this license. Product names and trademarks belong to their respective owners.
