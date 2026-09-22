using usefulScripts_csharp;

// Base folders for Rider projects and RPGMMZ projects.
const string riderProjects = "riderprojects";
const string rpgmmz = "rpgmmz";
const string mzPlugIns = "js/plugins";

// Edit these when either project changes.
var currentDev = Path.Combine("rpgmmzPlugin-Quests", "quests", "dev", "plugins");
var currentMZProject = Path.Combine("SeptemberProject");
const string mzTarget = "dev";

CopyCurrentRpgmmzPlugInFilesToProjectFolder(currentDev, currentMZProject);

return;

static void CopyCurrentRpgmmzPlugInFilesToProjectFolder(string currentDevFolder, string currentMZProjectFolder)
{
    var pathA = Path.Combine(riderProjects, currentDevFolder);
    var pathB = Path.Combine(rpgmmz, currentMZProjectFolder, mzPlugIns, mzTarget);
    FileTransfer.CopyFilesFromPathAToPathB(pathA, pathB);
}
