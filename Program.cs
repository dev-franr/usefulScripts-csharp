using usefulScripts_csharp;

// Base folders for Rider projects and RPGMMZ projects.
const string riderProjects = "riderprojects";
const string rpgmmz = "rpgmmz";

// Edit these when either project changes.
var currentDev = Path.Combine("rpgmmzPlugin-Quests", "js", "dev");
var currentMZProject = Path.Combine("SeptemberProject");

CopyCurrentRpgmmzPlugInFilesToProjectFolder(currentDev, currentMZProject);

return;

static void CopyCurrentRpgmmzPlugInFilesToProjectFolder(string currentDevFolder, string currentMZProjectFolder)
{
    var pathA = Path.Combine(riderProjects, currentDevFolder);
    var pathB = Path.Combine(rpgmmz, currentMZProjectFolder);
    FileTransfer.CopyFilesFromPathAToPathB(pathA, pathB);
}
