namespace usefulScripts_csharp;

public static class FileTransfer
{
    // TODO: configure naming conventions.
    private const string RootFolderPath = "/home/deck/Desktop";
    private const char FileSeparator = '/';

    public static void CopyFilesFromPathAToPathB(string pathA, string pathB)
    {
        var currentDirectory = Environment.CurrentDirectory;
        Environment.CurrentDirectory = RootFolderPath;
        var filesLocation = Path.Combine(RootFolderPath, pathA);
        var fileList = Directory.GetFiles(filesLocation);
        foreach ( var file in fileList )
        {
            var separated = file.Split(FileSeparator);
            var fileName = separated.Last();
            var fileToCopy = Path.Combine(filesLocation, file);
            var copyTo = Path.Combine(pathB, fileName);
            File.Copy(fileToCopy, copyTo, true);
        }

        // Not sure if needed.
        Environment.CurrentDirectory = currentDirectory;
    }
}